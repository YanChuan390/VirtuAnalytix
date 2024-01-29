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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31A754", Offset = "0x31A754")]
		public bool smoothFollow;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float followSpeed;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31A788", Offset = "0x31A788")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31A7BC", Offset = "0x31A7BC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31A7F4", Offset = "0x31A7F4")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float blockingRadius;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31A82C", Offset = "0x31A82C")]
		public float blockedOffset;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A844", Offset = "0x31A844")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A854", Offset = "0x31A854")]
		private float <y>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A864", Offset = "0x31A864")]
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
			[Address(RVA = "0xDFA000", Offset = "0xDFA000", VA = "0xDFA000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x322EE8", Offset = "0x322EE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0xDFA008", Offset = "0xDFA008", VA = "0xDFA008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x322EF8", Offset = "0x322EF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0xDFA010", Offset = "0xDFA010", VA = "0xDFA010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x322F08", Offset = "0x322F08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0xDFA018", Offset = "0xDFA018", VA = "0xDFA018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x322F18", Offset = "0x322F18")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0xDFA020", Offset = "0xDFA020", VA = "0xDFA020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x322F28", Offset = "0x322F28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xDFA028", Offset = "0xDFA028", VA = "0xDFA028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x322F38", Offset = "0x322F38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xDFADD4", Offset = "0xDFADD4", VA = "0xDFADD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xDFA030", Offset = "0xDFA030", VA = "0xDFA030", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xDFA1E0", Offset = "0xDFA1E0", VA = "0xDFA1E0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xDFA234", Offset = "0xDFA234", VA = "0xDFA234", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xDFA290", Offset = "0xDFA290", VA = "0xDFA290", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xDFA2F4", Offset = "0xDFA2F4", VA = "0xDFA2F4")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xDFA210", Offset = "0xDFA210", VA = "0xDFA210")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xDFA4E0", Offset = "0xDFA4E0", VA = "0xDFA4E0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xDFAD08", Offset = "0xDFAD08", VA = "0xDFAD08")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xDFAE68", Offset = "0xDFAE68", VA = "0xDFAE68")]
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
		[Address(RVA = "0xDFAFE8", Offset = "0xDFAFE8", VA = "0xDFAFE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xDFB038", Offset = "0xDFB038", VA = "0xDFB038")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xDFB22C", Offset = "0xDFB22C", VA = "0xDFB22C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xDFB2F8", Offset = "0xDFB2F8", VA = "0xDFB2F8")]
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
		[Address(RVA = "0xDEF47C", Offset = "0xDEF47C", VA = "0xDEF47C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xDEF57C", Offset = "0xDEF57C", VA = "0xDEF57C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xDEF658", Offset = "0xDEF658", VA = "0xDEF658")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xDEF8A4", Offset = "0xDEF8A4", VA = "0xDEF8A4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xDEF7B4", Offset = "0xDEF7B4", VA = "0xDEF7B4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xDEFA00", Offset = "0xDEFA00", VA = "0xDEFA00")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xDEFD54", Offset = "0xDEFD54", VA = "0xDEFD54")]
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
			[Address(RVA = "0xDEFFE8", Offset = "0xDEFFE8", VA = "0xDEFFE8")]
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
			[Address(RVA = "0xDEFD94", Offset = "0xDEFD94", VA = "0xDEFD94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xDF0040", Offset = "0xDF0040", VA = "0xDF0040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xDEFD5C", Offset = "0xDEFD5C", VA = "0xDEFD5C")]
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
		[Address(RVA = "0xDF0294", Offset = "0xDF0294", VA = "0xDF0294")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xDF0694", Offset = "0xDF0694", VA = "0xDF0694")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xDF0980", Offset = "0xDF0980", VA = "0xDF0980")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xDF0A18", Offset = "0xDF0A18", VA = "0xDF0A18")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xDF0ACC", Offset = "0xDF0ACC", VA = "0xDF0ACC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xDF04B8", Offset = "0xDF04B8", VA = "0xDF04B8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xDF08B8", Offset = "0xDF08B8", VA = "0xDF08B8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xDF15AC", Offset = "0xDF15AC", VA = "0xDF15AC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xDF131C", Offset = "0xDF131C", VA = "0xDF131C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xDF1464", Offset = "0xDF1464", VA = "0xDF1464")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xDF0D4C", Offset = "0xDF0D4C", VA = "0xDF0D4C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xDF0E44", Offset = "0xDF0E44", VA = "0xDF0E44")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xDF0F3C", Offset = "0xDF0F3C", VA = "0xDF0F3C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xDF1034", Offset = "0xDF1034", VA = "0xDF1034")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xDF112C", Offset = "0xDF112C", VA = "0xDF112C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xDF1224", Offset = "0xDF1224", VA = "0xDF1224")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xDF1850", Offset = "0xDF1850", VA = "0xDF1850")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xDF0C28", Offset = "0xDF0C28", VA = "0xDF0C28")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xDF17C4", Offset = "0xDF17C4", VA = "0xDF17C4")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xDF18E8", Offset = "0xDF18E8", VA = "0xDF18E8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xDF19C8", Offset = "0xDF19C8", VA = "0xDF19C8")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xDF171C", Offset = "0xDF171C", VA = "0xDF171C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xDF1648", Offset = "0xDF1648", VA = "0xDF1648")]
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
				[Address(RVA = "0xDF9FF8", Offset = "0xDF9FF8", VA = "0xDF9FF8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x478CCC", Offset = "0x478CCC", VA = "0x478CCC")]
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
			[Address(RVA = "0xDF52A0", Offset = "0xDF52A0", VA = "0xDF52A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xDF584C", Offset = "0xDF584C", VA = "0xDF584C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xDF5860", Offset = "0xDF5860", VA = "0xDF5860", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xDF5E64", Offset = "0xDF5E64", VA = "0xDF5E64", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xDF6438", Offset = "0xDF6438", VA = "0xDF6438")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xDF6DC0", Offset = "0xDF6DC0", VA = "0xDF6DC0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xDF6720", Offset = "0xDF6720", VA = "0xDF6720")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xDF7B28", Offset = "0xDF7B28", VA = "0xDF7B28")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xDF7C4C", Offset = "0xDF7C4C", VA = "0xDF7C4C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xDF8364", Offset = "0xDF8364", VA = "0xDF8364")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xDF80DC", Offset = "0xDF80DC", VA = "0xDF80DC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xDF7EA8", Offset = "0xDF7EA8", VA = "0xDF7EA8")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xDF7D34", Offset = "0xDF7D34", VA = "0xDF7D34")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xDF8228", Offset = "0xDF8228", VA = "0xDF8228")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xDF8498", Offset = "0xDF8498", VA = "0xDF8498")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xDF9598", Offset = "0xDF9598", VA = "0xDF9598")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xDF8D94", Offset = "0xDF8D94", VA = "0xDF8D94")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xDF99C4", Offset = "0xDF99C4", VA = "0xDF99C4")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xDF92E0", Offset = "0xDF92E0", VA = "0xDF92E0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xDF99CC", Offset = "0xDF99CC", VA = "0xDF99CC")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xDF99D4", Offset = "0xDF99D4", VA = "0xDF99D4")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xDF9BFC", Offset = "0xDF9BFC", VA = "0xDF9BFC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xDF9EA4", Offset = "0xDF9EA4", VA = "0xDF9EA4")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xDF669C", Offset = "0xDF669C", VA = "0xDF669C")]
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
		[Address(RVA = "0xDFB324", Offset = "0xDFB324", VA = "0xDFB324")]
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
		[Address(RVA = "0xDFB32C", Offset = "0xDFB32C", VA = "0xDFB32C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xDFB414", Offset = "0xDFB414", VA = "0xDFB414")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Hierarchy
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x16DFD74", Offset = "0x16DFD74", VA = "0x16DFD74")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x16E0000", Offset = "0x16E0000", VA = "0x16E0000")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x16DFE0C", Offset = "0x16DFE0C", VA = "0x16DFE0C")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x16E0160", Offset = "0x16E0160", VA = "0x16E0160")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x16E02C0", Offset = "0x16E02C0", VA = "0x16E02C0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x16E063C", Offset = "0x16E063C", VA = "0x16E063C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x16E07BC", Offset = "0x16E07BC", VA = "0x16E07BC")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x16E09E8", Offset = "0x16E09E8", VA = "0x16E09E8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x16E0E78", Offset = "0x16E0E78", VA = "0x16E0E78")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x16E0BD0", Offset = "0x16E0BD0", VA = "0x16E0BD0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x16E109C", Offset = "0x16E109C", VA = "0x16E109C")]
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
		[Address(RVA = "0x16E10A4", Offset = "0x16E10A4", VA = "0x16E10A4")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x16E1D48", Offset = "0x16E1D48", VA = "0x16E1D48")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x16E1E68", Offset = "0x16E1E68", VA = "0x16E1E68")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x16E1468", Offset = "0x16E1468", VA = "0x16E1468")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x16E1484", Offset = "0x16E1484", VA = "0x16E1484")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x16E14BC", Offset = "0x16E14BC", VA = "0x16E14BC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x16E1508", Offset = "0x16E1508", VA = "0x16E1508")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x16E1530", Offset = "0x16E1530", VA = "0x16E1530")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x16E1554", Offset = "0x16E1554", VA = "0x16E1554")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x16E1578", Offset = "0x16E1578", VA = "0x16E1578")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x16E1598", Offset = "0x16E1598", VA = "0x16E1598")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x16E15F0", Offset = "0x16E15F0", VA = "0x16E15F0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x16E1638", Offset = "0x16E1638", VA = "0x16E1638")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x16E1670", Offset = "0x16E1670", VA = "0x16E1670")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x16E1F88", Offset = "0x16E1F88", VA = "0x16E1F88")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x16E16B4", Offset = "0x16E16B4", VA = "0x16E16B4")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x16E16EC", Offset = "0x16E16EC", VA = "0x16E16EC")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x16E172C", Offset = "0x16E172C", VA = "0x16E172C")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x16E1770", Offset = "0x16E1770", VA = "0x16E1770")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x16E17C4", Offset = "0x16E17C4", VA = "0x16E17C4")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x16E1838", Offset = "0x16E1838", VA = "0x16E1838")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x16E18AC", Offset = "0x16E18AC", VA = "0x16E18AC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x16E1910", Offset = "0x16E1910", VA = "0x16E1910")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x16E1974", Offset = "0x16E1974", VA = "0x16E1974")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x16E1A2C", Offset = "0x16E1A2C", VA = "0x16E1A2C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x16E1AE0", Offset = "0x16E1AE0", VA = "0x16E1AE0")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x16E1FCC", Offset = "0x16E1FCC", VA = "0x16E1FCC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x16E1BA4", Offset = "0x16E1BA4", VA = "0x16E1BA4")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x16E1CB8", Offset = "0x16E1CB8", VA = "0x16E1CB8")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x16E1CF8", Offset = "0x16E1CF8", VA = "0x16E1CF8")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x16E20E4", Offset = "0x16E20E4", VA = "0x16E20E4")]
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
		[Address(RVA = "0x16E20EC", Offset = "0x16E20EC", VA = "0x16E20EC")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x16E2168", Offset = "0x16E2168", VA = "0x16E2168")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x16E21E4", Offset = "0x16E21E4", VA = "0x16E21E4")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x16E222C", Offset = "0x16E222C", VA = "0x16E222C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x16E22D0", Offset = "0x16E22D0", VA = "0x16E22D0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x16E2230", Offset = "0x16E2230", VA = "0x16E2230")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x16E22D4", Offset = "0x16E22D4", VA = "0x16E22D4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x16E2364", Offset = "0x16E2364", VA = "0x16E2364")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x16E2384", Offset = "0x16E2384", VA = "0x16E2384")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x16E23BC", Offset = "0x16E23BC", VA = "0x16E23BC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x16E240C", Offset = "0x16E240C", VA = "0x16E240C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x16E2524", Offset = "0x16E2524", VA = "0x16E2524")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x16E261C", Offset = "0x16E261C", VA = "0x16E261C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x16E2690", Offset = "0x16E2690", VA = "0x16E2690")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public static class QuaTools
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x16E26B4", Offset = "0x16E26B4", VA = "0x16E26B4")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x16E27E4", Offset = "0x16E27E4", VA = "0x16E27E4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x16E2914", Offset = "0x16E2914", VA = "0x16E2914")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x16E2A58", Offset = "0x16E2A58", VA = "0x16E2A58")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x16CC490", Offset = "0x16CC490", VA = "0x16CC490")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x16E2B9C", Offset = "0x16E2B9C", VA = "0x16E2B9C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x16D24A8", Offset = "0x16D24A8", VA = "0x16D24A8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x16E2C9C", Offset = "0x16E2C9C", VA = "0x16E2C9C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x16E2FEC", Offset = "0x16E2FEC", VA = "0x16E2FEC")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x16E327C", Offset = "0x16E327C", VA = "0x16E327C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x16DE4E0", Offset = "0x16DE4E0", VA = "0x16DE4E0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31A884", Offset = "0x31A884")]
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
			[Address(RVA = "0x16E358C", Offset = "0x16E358C", VA = "0x16E358C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x16E39A4", Offset = "0x16E39A4", VA = "0x16E39A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x16E344C", Offset = "0x16E344C", VA = "0x16E344C")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x16E3500", Offset = "0x16E3500", VA = "0x16E3500", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x16E3504", Offset = "0x16E3504", VA = "0x16E3504", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x16E3508", Offset = "0x16E3508", VA = "0x16E3508", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x16E350C", Offset = "0x16E350C", VA = "0x16E350C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x16E3588", Offset = "0x16E3588", VA = "0x16E3588")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x16E3534", Offset = "0x16E3534", VA = "0x16E3534")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x16E3954", Offset = "0x16E3954", VA = "0x16E3954")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x16E36C4", Offset = "0x16E36C4", VA = "0x16E36C4")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x16E3A7C", Offset = "0x16E3A7C", VA = "0x16E3A7C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x16E3AD8", Offset = "0x16E3AD8", VA = "0x16E3AD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x16E3B38", Offset = "0x16E3B38", VA = "0x16E3B38")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x16D0034", Offset = "0x16D0034", VA = "0x16D0034")]
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
		[Address(RVA = "0x16E3B74", Offset = "0x16E3B74", VA = "0x16E3B74")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x16E3C50", Offset = "0x16E3C50", VA = "0x16E3C50")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x16E3D2C", Offset = "0x16E3D2C", VA = "0x16E3D2C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x16E3E08", Offset = "0x16E3E08", VA = "0x16E3E08")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class V3Tools
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x16E3E10", Offset = "0x16E3E10", VA = "0x16E3E10")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x16E3F24", Offset = "0x16E3F24", VA = "0x16E3F24")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x16E4038", Offset = "0x16E4038", VA = "0x16E4038")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x16E4164", Offset = "0x16E4164", VA = "0x16E4164")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x16E42C4", Offset = "0x16E42C4", VA = "0x16E42C4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x16E457C", Offset = "0x16E457C", VA = "0x16E457C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x16E4828", Offset = "0x16E4828", VA = "0x16E4828")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x16E4A40", Offset = "0x16E4A40", VA = "0x16E4A40")]
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
		[Address(RVA = "0x16E4C5C", Offset = "0x16E4C5C", VA = "0x16E4C5C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x16CCB50", Offset = "0x16CCB50", VA = "0x16CCB50")]
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
		[Address(RVA = "0x16DF45C", Offset = "0x16DF45C", VA = "0x16DF45C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x16DF16C", Offset = "0x16DF16C", VA = "0x16DF16C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x16DF5D8", Offset = "0x16DF5D8", VA = "0x16DF5D8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x16DFBC4", Offset = "0x16DFBC4", VA = "0x16DFBC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x16DFD6C", Offset = "0x16DFD6C", VA = "0x16DFD6C")]
		public VRIKRootController()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319314", Offset = "0x319314")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319314", Offset = "0x319314")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xF59AB0", Offset = "0xF59AB0", VA = "0xF59AB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x322FB8", Offset = "0x322FB8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xF59B10", Offset = "0xF59B10", VA = "0xF59B10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x322FEC", Offset = "0x322FEC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xF59B70", Offset = "0xF59B70", VA = "0xF59B70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323020", Offset = "0x323020")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xF59BD0", Offset = "0xF59BD0", VA = "0xF59BD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323054", Offset = "0x323054")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xF59C30", Offset = "0xF59C30", VA = "0xF59C30")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xF59D08", Offset = "0xF59D08", VA = "0xF59D08")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xF59D38", Offset = "0xF59D38", VA = "0xF59D38")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xF59D70", Offset = "0xF59D70", VA = "0xF59D70")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xF59DA8", Offset = "0xF59DA8", VA = "0xF59DA8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xF59DFC", Offset = "0xF59DFC", VA = "0xF59DFC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xF59E58", Offset = "0xF59E58", VA = "0xF59E58")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xF59EA0", Offset = "0xF59EA0", VA = "0xF59EA0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xF59EE0", Offset = "0xF59EE0", VA = "0xF59EE0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xF59F6C", Offset = "0xF59F6C", VA = "0xF59F6C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xF59FD0", Offset = "0xF59FD0", VA = "0xF59FD0")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xF5A034", Offset = "0xF5A034", VA = "0xF5A034")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xF59C60", Offset = "0xF59C60", VA = "0xF59C60")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xF5A07C", Offset = "0xF5A07C", VA = "0xF5A07C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xF5A08C", Offset = "0xF5A08C", VA = "0xF5A08C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xF5A09C", Offset = "0xF5A09C", VA = "0xF5A09C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xF5A57C", Offset = "0xF5A57C", VA = "0xF5A57C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xF5A688", Offset = "0xF5A688", VA = "0xF5A688", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xF5AC5C", Offset = "0xF5AC5C", VA = "0xF5AC5C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xF5B3E8", Offset = "0xF5B3E8", VA = "0xF5B3E8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xF5B414", Offset = "0xF5B414", VA = "0xF5B414")]
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
			[Address(RVA = "0xF5A394", Offset = "0xF5A394", VA = "0xF5A394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xF5B614", Offset = "0xF5B614", VA = "0xF5B614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xF5A960", Offset = "0xF5A960", VA = "0xF5A960")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xF5B4B0", Offset = "0xF5B4B0", VA = "0xF5B4B0")]
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
			[Address(RVA = "0xF5BE58", Offset = "0xF5BE58", VA = "0xF5BE58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D9")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xF5BEE4", Offset = "0xF5BEE4", VA = "0xF5BEE4")]
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
		[Address(RVA = "0xF5BEEC", Offset = "0xF5BEEC", VA = "0xF5BEEC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xF5C018", Offset = "0xF5C018", VA = "0xF5C018")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xF5C020", Offset = "0xF5C020", VA = "0xF5C020")]
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
			[Address(RVA = "0xF5C2D4", Offset = "0xF5C2D4", VA = "0xF5C2D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xF5C040", Offset = "0xF5C040", VA = "0xF5C040", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xF5C3A0", Offset = "0xF5C3A0", VA = "0xF5C3A0")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xF5C3A8", Offset = "0xF5C3A8", VA = "0xF5C3A8")]
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
		[Address(RVA = "0xF5C3C8", Offset = "0xF5C3C8", VA = "0xF5C3C8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xF5C504", Offset = "0xF5C504", VA = "0xF5C504")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xF5C50C", Offset = "0xF5C50C", VA = "0xF5C50C")]
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
			[Address(RVA = "0xF5C7C4", Offset = "0xF5C7C4", VA = "0xF5C7C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xF5C52C", Offset = "0xF5C52C", VA = "0xF5C52C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xF5C898", Offset = "0xF5C898", VA = "0xF5C898")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xF5C8A0", Offset = "0xF5C8A0", VA = "0xF5C8A0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31A8B8", Offset = "0x31A8B8")]
		public float positionWeight;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 rotation;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31A8D0", Offset = "0x31A8D0")]
		public float rotationWeight;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xF5C8C0", Offset = "0xF5C8C0", VA = "0xF5C8C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xF5ABE0", Offset = "0xF5ABE0", VA = "0xF5ABE0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xF5AF48", Offset = "0xF5AF48", VA = "0xF5AF48")]
		public void Update()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xF5B8F8", Offset = "0xF5B8F8", VA = "0xF5B8F8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31A8E8", Offset = "0x31A8E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31A8E8", Offset = "0x31A8E8")]
		public float weight;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31A950", Offset = "0x31A950")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31A950", Offset = "0x31A950")]
		public float rotationWeight;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31A9A0", Offset = "0x31A9A0")]
		public DOF rotationDOF;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31A9D4", Offset = "0x31A9D4")]
		public Transform bone1;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AA20", Offset = "0x31AA20")]
		public Transform bone2;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AA6C", Offset = "0x31AA6C")]
		public Transform bone3;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AAA0", Offset = "0x31AAA0")]
		public Transform tip;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AAD4", Offset = "0x31AAD4")]
		public Transform target;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31AB08", Offset = "0x31AB08")]
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
			[Address(RVA = "0xF68974", Offset = "0xF68974", VA = "0xF68974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323088", Offset = "0x323088")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xF6897C", Offset = "0xF6897C", VA = "0xF6897C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323098", Offset = "0x323098")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xF68984", Offset = "0xF68984", VA = "0xF68984")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xF689B8", Offset = "0xF689B8", VA = "0xF689B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xF689F0", Offset = "0xF689F0", VA = "0xF689F0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xF68A20", Offset = "0xF68A20", VA = "0xF68A20")]
			set
			{
			}
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xF68A60", Offset = "0xF68A60", VA = "0xF68A60")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xF68BA8", Offset = "0xF68BA8", VA = "0xF68BA8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xF691C8", Offset = "0xF691C8", VA = "0xF691C8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xF69308", Offset = "0xF69308", VA = "0xF69308")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xF698C8", Offset = "0xF698C8", VA = "0xF698C8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AB18", Offset = "0x31AB18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31AB18", Offset = "0x31AB18")]
		public float weight;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31AB84", Offset = "0x31AB84")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xF698DC", Offset = "0xF698DC", VA = "0xF698DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3230A8", Offset = "0x3230A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xF698E4", Offset = "0xF698E4", VA = "0xF698E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3230B8", Offset = "0x3230B8")]
			private set
			{
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xF698EC", Offset = "0xF698EC", VA = "0xF698EC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xF69974", Offset = "0xF69974", VA = "0xF69974")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3230C8", Offset = "0x3230C8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xF69E20", Offset = "0xF69E20", VA = "0xF69E20")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xF6A060", Offset = "0xF6A060", VA = "0xF6A060")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xF69CCC", Offset = "0xF69CCC", VA = "0xF69CCC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xF6A258", Offset = "0xF6A258", VA = "0xF6A258", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xF6A354", Offset = "0xF6A354", VA = "0xF6A354")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xF6A3E8", Offset = "0xF6A3E8", VA = "0xF6A3E8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xF6A458", Offset = "0xF6A458", VA = "0xF6A458", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xF6A45C", Offset = "0xF6A45C", VA = "0xF6A45C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xF6A460", Offset = "0xF6A460", VA = "0xF6A460")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AB94", Offset = "0x31AB94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31AB94", Offset = "0x31AB94")]
		public float weight;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31ABE4", Offset = "0x31ABE4")]
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
		[Address(RVA = "0xF6BA44", Offset = "0xF6BA44", VA = "0xF6BA44")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xF6BE0C", Offset = "0xF6BE0C", VA = "0xF6BE0C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xF6BBF4", Offset = "0xF6BBF4", VA = "0xF6BBF4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xF6BE38", Offset = "0xF6BE38", VA = "0xF6BE38")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600010B")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xF6C128", Offset = "0xF6C128", VA = "0xF6C128")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3193C4", Offset = "0x3193C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3193C4", Offset = "0x3193C4")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AC48", Offset = "0x31AC48")]
		public BipedIK ik;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AC8C", Offset = "0x31AC8C")]
		public float spineBend;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31ACC0", Offset = "0x31ACC0")]
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
		[Address(RVA = "0xF6C710", Offset = "0xF6C710", VA = "0xF6C710", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323100", Offset = "0x323100")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xF6C770", Offset = "0xF6C770", VA = "0xF6C770", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323134", Offset = "0x323134")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xF6C7D0", Offset = "0xF6C7D0", VA = "0xF6C7D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xF6C928", Offset = "0xF6C928", VA = "0xF6C928")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xF6CA5C", Offset = "0xF6CA5C", VA = "0xF6CA5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xF6CB34", Offset = "0xF6CB34", VA = "0xF6CB34")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xF6D3EC", Offset = "0xF6D3EC", VA = "0xF6D3EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xF6D490", Offset = "0xF6D490", VA = "0xF6D490")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xF6DFF8", Offset = "0xF6DFF8", VA = "0xF6DFF8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xF6E21C", Offset = "0xF6E21C", VA = "0xF6E21C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xF6E4D8", Offset = "0xF6E4D8", VA = "0xF6E4D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xF6E7B8", Offset = "0xF6E7B8", VA = "0xF6E7B8")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319450", Offset = "0x319450")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319450", Offset = "0x319450")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class SpineEffector
		{
			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F600", Offset = "0x31F600")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F648", Offset = "0x31F648")]
			public float horizontalWeight;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F6AC", Offset = "0x31F6AC")]
			public float verticalWeight;

			[Token(Token = "0x600057A")]
			[Address(RVA = "0xF6FD2C", Offset = "0xF6FD2C", VA = "0xF6FD2C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0xF6FD3C", Offset = "0xF6FD3C", VA = "0xF6FD3C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31ACF4", Offset = "0x31ACF4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AD44", Offset = "0x31AD44")]
		public float spineBend;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AD78", Offset = "0x31AD78")]
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
		[Address(RVA = "0xF6E85C", Offset = "0xF6E85C", VA = "0xF6E85C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323168", Offset = "0x323168")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xF6E8BC", Offset = "0xF6E8BC", VA = "0xF6E8BC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32319C", Offset = "0x32319C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xF6E91C", Offset = "0xF6E91C", VA = "0xF6E91C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3231D0", Offset = "0x3231D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xF6E97C", Offset = "0xF6E97C", VA = "0xF6E97C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xF6EA30", Offset = "0xF6EA30", VA = "0xF6EA30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xF6EAFC", Offset = "0xF6EAFC", VA = "0xF6EAFC")]
		private void Update()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xF6EFB4", Offset = "0xF6EFB4", VA = "0xF6EFB4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xF6EFC0", Offset = "0xF6EFC0", VA = "0xF6EFC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xF6EBDC", Offset = "0xF6EBDC", VA = "0xF6EBDC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xF6EFCC", Offset = "0xF6EFCC", VA = "0xF6EFCC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xF6F6E0", Offset = "0xF6F6E0", VA = "0xF6F6E0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xF6F950", Offset = "0xF6F950", VA = "0xF6F950")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xF6FAD8", Offset = "0xF6FAD8", VA = "0xF6FAD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xF6FC8C", Offset = "0xF6FC8C", VA = "0xF6FC8C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3194E8", Offset = "0x3194E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3194E8", Offset = "0x3194E8")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IK[] legs;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31ADAC", Offset = "0x31ADAC")]
		public Transform pelvis;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AE10", Offset = "0x31AE10")]
		public Transform characterRoot;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AE44", Offset = "0x31AE44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31AE44", Offset = "0x31AE44")]
		public float rootRotationWeight;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AE94", Offset = "0x31AE94")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AEC8", Offset = "0x31AEC8")]
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
		[Address(RVA = "0xF6FD78", Offset = "0xF6FD78", VA = "0xF6FD78", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323204", Offset = "0x323204")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xF6FDD8", Offset = "0xF6FDD8", VA = "0xF6FDD8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323238", Offset = "0x323238")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xF6FE38", Offset = "0xF6FE38", VA = "0xF6FE38", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xF6FE60", Offset = "0xF6FE60", VA = "0xF6FE60")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xF700CC", Offset = "0xF700CC", VA = "0xF700CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xF70240", Offset = "0xF70240", VA = "0xF70240")]
		private void Update()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xF70A3C", Offset = "0xF70A3C", VA = "0xF70A3C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xF71138", Offset = "0xF71138", VA = "0xF71138")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xF71444", Offset = "0xF71444", VA = "0xF71444")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xF71A2C", Offset = "0xF71A2C", VA = "0xF71A2C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xF71CDC", Offset = "0xF71CDC", VA = "0xF71CDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xF72014", Offset = "0xF72014", VA = "0xF72014")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319570", Offset = "0x319570")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319570", Offset = "0x319570")]
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
			[Address(RVA = "0x47C554", Offset = "0x47C554", VA = "0x47C554")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AF28", Offset = "0x31AF28")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AF7C", Offset = "0x31AF7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31AF7C", Offset = "0x31AF7C")]
		public float rootRotationWeight;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31AFCC", Offset = "0x31AFCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31AFCC", Offset = "0x31AFCC")]
		public float minRootRotation;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B020", Offset = "0x31B020")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31B020", Offset = "0x31B020")]
		public float maxRootRotation;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B074", Offset = "0x31B074")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B0A8", Offset = "0x31B0A8")]
		public float maxLegOffset;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B10C", Offset = "0x31B10C")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B174", Offset = "0x31B174")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31B174", Offset = "0x31B174")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B1C4", Offset = "0x31B1C4")]
		public Transform characterRoot;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B1F8", Offset = "0x31B1F8")]
		public Transform pelvis;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B22C", Offset = "0x31B22C")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B260", Offset = "0x31B260")]
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
		[Address(RVA = "0xF720B8", Offset = "0xF720B8", VA = "0xF720B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32326C", Offset = "0x32326C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xF72118", Offset = "0xF72118", VA = "0xF72118", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3232A0", Offset = "0x3232A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xF72178", Offset = "0xF72178", VA = "0xF72178", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xF721C0", Offset = "0xF721C0", VA = "0xF721C0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xF7234C", Offset = "0xF7234C", VA = "0xF7234C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF72544", Offset = "0xF72544", VA = "0xF72544")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xF7261C", Offset = "0xF7261C", VA = "0xF7261C")]
		private void Update()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xF726FC", Offset = "0xF726FC", VA = "0xF726FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xF72B6C", Offset = "0xF72B6C", VA = "0xF72B6C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xF73154", Offset = "0xF73154", VA = "0xF73154")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xF732AC", Offset = "0xF732AC", VA = "0xF732AC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xF73784", Offset = "0xF73784", VA = "0xF73784")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xF74278", Offset = "0xF74278", VA = "0xF74278")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xF74640", Offset = "0xF74640", VA = "0xF74640")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xF747EC", Offset = "0xF747EC", VA = "0xF747EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xF74C74", Offset = "0xF74C74", VA = "0xF74C74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xF74CA8", Offset = "0xF74CA8", VA = "0xF74CA8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xF74FD0", Offset = "0xF74FD0", VA = "0xF74FD0")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319600", Offset = "0x319600")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B2DC", Offset = "0x31B2DC")]
		public VRIK ik;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform[] feet;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF75148", Offset = "0xF75148", VA = "0xF75148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3232D4", Offset = "0x3232D4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF7514C", Offset = "0xF7514C", VA = "0xF7514C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323308", Offset = "0x323308")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xF75150", Offset = "0xF75150", VA = "0xF75150", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32333C", Offset = "0x32333C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xF75154", Offset = "0xF75154", VA = "0xF75154", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xF7517C", Offset = "0xF7517C", VA = "0xF7517C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xF75248", Offset = "0xF75248", VA = "0xF75248")]
		private void Update()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xF75320", Offset = "0xF75320", VA = "0xF75320")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xF7571C", Offset = "0xF7571C", VA = "0xF7571C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xF75B54", Offset = "0xF75B54", VA = "0xF75B54")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xF75CA0", Offset = "0xF75CA0", VA = "0xF75CA0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xF76018", Offset = "0xF76018", VA = "0xF76018")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xF761A0", Offset = "0xF761A0", VA = "0xF761A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xF76458", Offset = "0xF76458", VA = "0xF76458")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F6FC", Offset = "0x31F6FC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F70C", Offset = "0x31F70C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F71C", Offset = "0x31F71C")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F72C", Offset = "0x31F72C")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F73C", Offset = "0x31F73C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F74C", Offset = "0x31F74C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F75C", Offset = "0x31F75C")]
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
				[Address(RVA = "0xF77B54", Offset = "0xF77B54", VA = "0xF77B54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324BD0", Offset = "0x324BD0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600057E")]
				[Address(RVA = "0xF7815C", Offset = "0xF7815C", VA = "0xF7815C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324BE0", Offset = "0x324BE0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600057F")]
				[Address(RVA = "0xF6C108", Offset = "0xF6C108", VA = "0xF6C108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324BF0", Offset = "0x324BF0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000580")]
				[Address(RVA = "0xF78164", Offset = "0xF78164", VA = "0xF78164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C00", Offset = "0x324C00")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public bool initiated
			{
				[Token(Token = "0x6000581")]
				[Address(RVA = "0xF78170", Offset = "0xF78170", VA = "0xF78170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C10", Offset = "0x324C10")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000582")]
				[Address(RVA = "0xF78178", Offset = "0xF78178", VA = "0xF78178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C20", Offset = "0x324C20")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public float heightFromGround
			{
				[Token(Token = "0x6000583")]
				[Address(RVA = "0xF78180", Offset = "0xF78180", VA = "0xF78180")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C30", Offset = "0x324C30")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000584")]
				[Address(RVA = "0xF78188", Offset = "0xF78188", VA = "0xF78188")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C40", Offset = "0x324C40")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000585")]
				[Address(RVA = "0xF78190", Offset = "0xF78190", VA = "0xF78190")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C50", Offset = "0x324C50")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000586")]
				[Address(RVA = "0xF781A4", Offset = "0xF781A4", VA = "0xF781A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C60", Offset = "0x324C60")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public Transform transform
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0xF6C11C", Offset = "0xF6C11C", VA = "0xF6C11C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C70", Offset = "0x324C70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000588")]
				[Address(RVA = "0xF781B0", Offset = "0xF781B0", VA = "0xF781B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C80", Offset = "0x324C80")]
				private set
				{
				}
			}

			[Token(Token = "0x17000070")]
			public float IKOffset
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0xF77B4C", Offset = "0xF77B4C", VA = "0xF77B4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324C90", Offset = "0x324C90")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600058A")]
				[Address(RVA = "0xF781B8", Offset = "0xF781B8", VA = "0xF781B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324CA0", Offset = "0x324CA0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000071")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600058F")]
				[Address(RVA = "0xF78D90", Offset = "0xF78D90", VA = "0xF78D90")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000072")]
			private float rootYOffset
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0xF7918C", Offset = "0xF7918C", VA = "0xF7918C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0xF76C80", Offset = "0xF76C80", VA = "0xF76C80")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xF781C0", Offset = "0xF781C0", VA = "0xF781C0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xF77B5C", Offset = "0xF77B5C", VA = "0xF77B5C")]
			public void Reset()
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xF76DD8", Offset = "0xF76DD8", VA = "0xF76DD8")]
			public void Process()
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0xF788C8", Offset = "0xF788C8", VA = "0xF788C8")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0xF78220", Offset = "0xF78220", VA = "0xF78220")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0xF78FA8", Offset = "0xF78FA8", VA = "0xF78FA8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0xF78524", Offset = "0xF78524", VA = "0xF78524")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0xF78624", Offset = "0xF78624", VA = "0xF78624")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0xF790F8", Offset = "0xF790F8", VA = "0xF790F8")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0xF78E64", Offset = "0xF78E64", VA = "0xF78E64")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0xF79314", Offset = "0xF79314", VA = "0xF79314")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xF76B90", Offset = "0xF76B90", VA = "0xF76B90")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000B6")]
		public class Pelvis
		{
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F76C", Offset = "0x31F76C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F77C", Offset = "0x31F77C")]
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
				[Address(RVA = "0x13AC33C", Offset = "0x13AC33C", VA = "0x13AC33C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324CB0", Offset = "0x324CB0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600059B")]
				[Address(RVA = "0x13AC350", Offset = "0x13AC350", VA = "0x13AC350")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324CC0", Offset = "0x324CC0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public float heightOffset
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0x13AC35C", Offset = "0x13AC35C", VA = "0x13AC35C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324CD0", Offset = "0x324CD0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600059D")]
				[Address(RVA = "0x13AC364", Offset = "0x13AC364", VA = "0x13AC364")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324CE0", Offset = "0x324CE0")]
				private set
				{
				}
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x13AC36C", Offset = "0x13AC36C", VA = "0x13AC36C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x13AC41C", Offset = "0x13AC41C", VA = "0x13AC41C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x13AC37C", Offset = "0x13AC37C", VA = "0x13AC37C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x13AC538", Offset = "0x13AC538", VA = "0x13AC538")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x13AC8B0", Offset = "0x13AC8B0", VA = "0x13AC8B0")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B328", Offset = "0x31B328")]
		public LayerMask layers;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B35C", Offset = "0x31B35C")]
		public float maxStep;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B390", Offset = "0x31B390")]
		public float heightOffset;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B3DC", Offset = "0x31B3DC")]
		public float footSpeed;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B430", Offset = "0x31B430")]
		public float footRadius;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B464", Offset = "0x31B464")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B4DC", Offset = "0x31B4DC")]
		public float prediction;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B544", Offset = "0x31B544")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31B544", Offset = "0x31B544")]
		public float footRotationWeight;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B5C8", Offset = "0x31B5C8")]
		public float footRotationSpeed;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B62C", Offset = "0x31B62C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31B62C", Offset = "0x31B62C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B680", Offset = "0x31B680")]
		public bool rotateSolver;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B6B4", Offset = "0x31B6B4")]
		public float pelvisSpeed;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B70C", Offset = "0x31B70C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31B70C", Offset = "0x31B70C")]
		public float pelvisDamper;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B794", Offset = "0x31B794")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B7F8", Offset = "0x31B7F8")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B82C", Offset = "0x31B82C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B860", Offset = "0x31B860")]
		public Quality quality;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31B894", Offset = "0x31B894")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31B8A4", Offset = "0x31B8A4")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31B8B4", Offset = "0x31B8B4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31B8C4", Offset = "0x31B8C4")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31B8D4", Offset = "0x31B8D4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool initiated;

		[Token(Token = "0x17000015")]
		public Leg[] legs
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xF6BBEC", Offset = "0xF6BBEC", VA = "0xF6BBEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323370", Offset = "0x323370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xF764C8", Offset = "0xF764C8", VA = "0xF764C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323380", Offset = "0x323380")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xF6DFF0", Offset = "0xF6DFF0", VA = "0xF6DFF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323390", Offset = "0x323390")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xF764D0", Offset = "0xF764D0", VA = "0xF764D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3233A0", Offset = "0x3233A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool isGrounded
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xF764D8", Offset = "0xF764D8", VA = "0xF764D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3233B0", Offset = "0x3233B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xF764E0", Offset = "0xF764E0", VA = "0xF764E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3233C0", Offset = "0x3233C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Transform root
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xF6C100", Offset = "0xF6C100", VA = "0xF6C100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3233D0", Offset = "0x3233D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xF764E8", Offset = "0xF764E8", VA = "0xF764E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3233E0", Offset = "0x3233E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xF73764", Offset = "0xF73764", VA = "0xF73764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3233F0", Offset = "0x3233F0")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xF764F0", Offset = "0xF764F0", VA = "0xF764F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323400", Offset = "0x323400")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool rootGrounded
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xF76548", Offset = "0xF76548", VA = "0xF76548")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public Vector3 up
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xF6E15C", Offset = "0xF6E15C", VA = "0xF6E15C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001C")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xF77C78", Offset = "0xF77C78", VA = "0xF77C78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xF765A4", Offset = "0xF765A4", VA = "0xF765A4")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xF76A88", Offset = "0xF76A88", VA = "0xF76A88")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xF6D09C", Offset = "0xF6D09C", VA = "0xF6D09C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xF6DD1C", Offset = "0xF6DD1C", VA = "0xF6DD1C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xF7074C", Offset = "0xF7074C", VA = "0xF7074C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xF6C884", Offset = "0xF6C884", VA = "0xF6C884")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xF76DC0", Offset = "0xF76DC0", VA = "0xF76DC0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xF77D60", Offset = "0xF77D60", VA = "0xF77D60")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xF77EE4", Offset = "0xF77EE4", VA = "0xF77EE4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xF78020", Offset = "0xF78020", VA = "0xF78020")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xF6C218", Offset = "0xF6C218", VA = "0xF6C218")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319660", Offset = "0x319660")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319660", Offset = "0x319660")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverAim solver;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xF5896C", Offset = "0xF5896C", VA = "0xF5896C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323410", Offset = "0x323410")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xF589CC", Offset = "0xF589CC", VA = "0xF589CC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323444", Offset = "0x323444")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xF58A2C", Offset = "0xF58A2C", VA = "0xF58A2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323478", Offset = "0x323478")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xF58A8C", Offset = "0xF58A8C", VA = "0xF58A8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3234AC", Offset = "0x3234AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xF58AEC", Offset = "0xF58AEC", VA = "0xF58AEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3234E0", Offset = "0x3234E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xF58B4C", Offset = "0xF58B4C", VA = "0xF58B4C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xF58B54", Offset = "0xF58B54", VA = "0xF58B54")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3196E0", Offset = "0x3196E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3196E0", Offset = "0x3196E0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xF5BC54", Offset = "0xF5BC54", VA = "0xF5BC54", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323514", Offset = "0x323514")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xF5BCB4", Offset = "0xF5BCB4", VA = "0xF5BCB4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323548", Offset = "0x323548")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xF5BD14", Offset = "0xF5BD14", VA = "0xF5BD14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32357C", Offset = "0x32357C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xF5BD74", Offset = "0xF5BD74", VA = "0xF5BD74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3235B0", Offset = "0x3235B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xF5BDD4", Offset = "0xF5BDD4", VA = "0xF5BDD4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xF5BDDC", Offset = "0xF5BDDC", VA = "0xF5BDDC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319790", Offset = "0x319790")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319790", Offset = "0x319790")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xF5C94C", Offset = "0xF5C94C", VA = "0xF5C94C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3235E4", Offset = "0x3235E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xF5C9AC", Offset = "0xF5C9AC", VA = "0xF5C9AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323618", Offset = "0x323618")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xF5CA0C", Offset = "0xF5CA0C", VA = "0xF5CA0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32364C", Offset = "0x32364C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xF5CA6C", Offset = "0xF5CA6C", VA = "0xF5CA6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323680", Offset = "0x323680")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xF5CACC", Offset = "0xF5CACC", VA = "0xF5CACC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xF5CAD4", Offset = "0xF5CAD4", VA = "0xF5CAD4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319840", Offset = "0x319840")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319840", Offset = "0x319840")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xF5D598", Offset = "0xF5D598", VA = "0xF5D598", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3236B4", Offset = "0x3236B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xF5D5F8", Offset = "0xF5D5F8", VA = "0xF5D5F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3236E8", Offset = "0x3236E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xF5D658", Offset = "0xF5D658", VA = "0xF5D658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32371C", Offset = "0x32371C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xF5D6B8", Offset = "0xF5D6B8", VA = "0xF5D6B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323750", Offset = "0x323750")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xF5D718", Offset = "0xF5D718", VA = "0xF5D718", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xF5D720", Offset = "0xF5D720", VA = "0xF5D720")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3198F4", Offset = "0x3198F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3198F4", Offset = "0x3198F4")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xF6A4DC", Offset = "0xF6A4DC", VA = "0xF6A4DC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323784", Offset = "0x323784")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xF6A53C", Offset = "0xF6A53C", VA = "0xF6A53C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3237B8", Offset = "0x3237B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xF6A59C", Offset = "0xF6A59C", VA = "0xF6A59C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3237EC", Offset = "0x3237EC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xF6A5FC", Offset = "0xF6A5FC", VA = "0xF6A5FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323830", Offset = "0x323830")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF6A65C", Offset = "0xF6A65C", VA = "0xF6A65C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323878", Offset = "0x323878")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xF6A6BC", Offset = "0xF6A6BC", VA = "0xF6A6BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3238AC", Offset = "0x3238AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xF6A71C", Offset = "0xF6A71C", VA = "0xF6A71C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xF6A75C", Offset = "0xF6A75C", VA = "0xF6A75C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xF6A764", Offset = "0xF6A764", VA = "0xF6A764")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xF6AA08", Offset = "0xF6AA08", VA = "0xF6AA08")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xF6AE94", Offset = "0xF6AE94", VA = "0xF6AE94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3238E0", Offset = "0x3238E0")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xF6AECC", Offset = "0xF6AECC", VA = "0xF6AECC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323918", Offset = "0x323918")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xF6AFF4", Offset = "0xF6AFF4", VA = "0xF6AFF4")]
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
		[Address(RVA = "0x13B041C", Offset = "0x13B041C", VA = "0x13B041C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x13B0544", Offset = "0x13B0544", VA = "0x13B0544", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x13B0764", Offset = "0x13B0764", VA = "0x13B0764", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000194")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000195")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x13B07E4", Offset = "0x13B07E4", VA = "0x13B07E4")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B8E4", Offset = "0x31B8E4")]
		public IK[] IKComponents;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B918", Offset = "0x31B918")]
		public Animator animator;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool fixedFrame;

		[Token(Token = "0x1700001D")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x13B4DE0", Offset = "0x13B4DE0", VA = "0x13B4DE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x13B4EA8", Offset = "0x13B4EA8", VA = "0x13B4EA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x13B4F3C", Offset = "0x13B4F3C", VA = "0x13B4F3C")]
		private void Update()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x13B5070", Offset = "0x13B5070", VA = "0x13B5070")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x13B50A0", Offset = "0x13B50A0", VA = "0x13B50A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x13B4F60", Offset = "0x13B4F60", VA = "0x13B4F60")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x13B5170", Offset = "0x13B5170", VA = "0x13B5170")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319980", Offset = "0x319980")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLeg solver;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x16CDFB0", Offset = "0x16CDFB0", VA = "0x16CDFB0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32394C", Offset = "0x32394C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x16CE03C", Offset = "0x16CE03C", VA = "0x16CE03C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323980", Offset = "0x323980")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x16CE0C8", Offset = "0x16CE0C8", VA = "0x16CE0C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3239B4", Offset = "0x3239B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x16CE128", Offset = "0x16CE128", VA = "0x16CE128")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3239E8", Offset = "0x3239E8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x16CE188", Offset = "0x16CE188", VA = "0x16CE188", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x16CE190", Offset = "0x16CE190", VA = "0x16CE190")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3199D4", Offset = "0x3199D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3199D4", Offset = "0x3199D4")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x16CE20C", Offset = "0x16CE20C", VA = "0x16CE20C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323A1C", Offset = "0x323A1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x16CE26C", Offset = "0x16CE26C", VA = "0x16CE26C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323A50", Offset = "0x323A50")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x16CE2CC", Offset = "0x16CE2CC", VA = "0x16CE2CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323A84", Offset = "0x323A84")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x16CE32C", Offset = "0x16CE32C", VA = "0x16CE32C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323AB8", Offset = "0x323AB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x16CE38C", Offset = "0x16CE38C", VA = "0x16CE38C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x16CE394", Offset = "0x16CE394", VA = "0x16CE394")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319A84", Offset = "0x319A84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319A84", Offset = "0x319A84")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x16CE410", Offset = "0x16CE410", VA = "0x16CE410", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323AEC", Offset = "0x323AEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x16CE470", Offset = "0x16CE470", VA = "0x16CE470", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323B20", Offset = "0x323B20")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x16CE4D0", Offset = "0x16CE4D0", VA = "0x16CE4D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323B54", Offset = "0x323B54")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x16CE530", Offset = "0x16CE530", VA = "0x16CE530")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323B88", Offset = "0x323B88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x16CE590", Offset = "0x16CE590", VA = "0x16CE590", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x16CE598", Offset = "0x16CE598", VA = "0x16CE598")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319B08", Offset = "0x319B08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319B08", Offset = "0x319B08")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x16D99BC", Offset = "0x16D99BC", VA = "0x16D99BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323BBC", Offset = "0x323BBC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x16D9A1C", Offset = "0x16D9A1C", VA = "0x16D9A1C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323BF0", Offset = "0x323BF0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x16D9A7C", Offset = "0x16D9A7C", VA = "0x16D9A7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323C24", Offset = "0x323C24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x16D9ADC", Offset = "0x16D9ADC", VA = "0x16D9ADC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323C58", Offset = "0x323C58")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x16D9B3C", Offset = "0x16D9B3C", VA = "0x16D9B3C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x16D9B44", Offset = "0x16D9B44", VA = "0x16D9B44")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319BC0", Offset = "0x319BC0")]
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
				[Address(RVA = "0x16DBA18", Offset = "0x16DBA18", VA = "0x16DBA18")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000076")]
			public bool isEmpty
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x16DB398", Offset = "0x16DB398", VA = "0x16DB398")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x16DBF90", Offset = "0x16DBF90", VA = "0x16DBF90")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x16DAC54", Offset = "0x16DAC54", VA = "0x16DAC54")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x16DBF88", Offset = "0x16DBF88", VA = "0x16DBF88")]
			public References()
			{
			}
		}

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x31B94C", Offset = "0x31B94C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B94C", Offset = "0x31B94C")]
		public References references;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31B9D4", Offset = "0x31B9D4")]
		public IKSolverVR solver;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x16DAABC", Offset = "0x16DAABC", VA = "0x16DAABC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323C8C", Offset = "0x323C8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x16DAB48", Offset = "0x16DAB48", VA = "0x16DAB48", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323CC0", Offset = "0x323CC0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x16DABD4", Offset = "0x16DABD4", VA = "0x16DABD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323CF4", Offset = "0x323CF4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x16DAC34", Offset = "0x16DAC34", VA = "0x16DAC34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323D40", Offset = "0x323D40")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x16DB2B4", Offset = "0x16DB2B4", VA = "0x16DB2B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323D74", Offset = "0x323D74")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x16DB2EC", Offset = "0x16DB2EC", VA = "0x16DB2EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x16DB2F4", Offset = "0x16DB2F4", VA = "0x16DB2F4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x16DBEE8", Offset = "0x16DBEE8", VA = "0x16DBEE8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BA14", Offset = "0x31BA14")]
		public float pull;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BA2C", Offset = "0x31BA2C")]
		public float pin;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int[] children;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xF5CB50", Offset = "0xF5CB50", VA = "0xF5CB50")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xF5CC44", Offset = "0xF5CC44", VA = "0xF5CC44")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xF5CC74", Offset = "0xF5CC74", VA = "0xF5CC74")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xF5D31C", Offset = "0xF5D31C", VA = "0xF5D31C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xF5CE08", Offset = "0xF5CE08", VA = "0xF5CE08")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xF5D518", Offset = "0xF5D518", VA = "0xF5D518")]
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
		[Address(RVA = "0xF5D79C", Offset = "0xF5D79C", VA = "0xF5D79C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xF5E0C8", Offset = "0xF5E0C8", VA = "0xF5E0C8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xF5E40C", Offset = "0xF5E40C", VA = "0xF5E40C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xF5E5B4", Offset = "0xF5E5B4", VA = "0xF5E5B4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F78C", Offset = "0x31F78C")]
			public Transform transform;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F7D8", Offset = "0x31F7D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31F7D8", Offset = "0x31F7D8")]
			public float weight;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xF63638", Offset = "0xF63638", VA = "0xF63638")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xF636EC", Offset = "0xF636EC", VA = "0xF636EC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xF5F4A8", Offset = "0xF5F4A8", VA = "0xF5F4A8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xF5FBEC", Offset = "0xF5FBEC", VA = "0xF5FBEC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BA44", Offset = "0x31BA44")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31BA78", Offset = "0x31BA78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BA78", Offset = "0x31BA78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BA78", Offset = "0x31BA78")]
		public float positionWeight;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BB10", Offset = "0x31BB10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BB10", Offset = "0x31BB10")]
		public float bodyWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BB8C", Offset = "0x31BB8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BB8C", Offset = "0x31BB8C")]
		public float thighWeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BC08", Offset = "0x31BC08")]
		public bool handsPullBody;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31BC3C", Offset = "0x31BC3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BC3C", Offset = "0x31BC3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BC3C", Offset = "0x31BC3C")]
		public float rotationWeight;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BCE0", Offset = "0x31BCE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BCE0", Offset = "0x31BCE0")]
		public float bodyClampWeight;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BD4C", Offset = "0x31BD4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BD4C", Offset = "0x31BD4C")]
		public float headClampWeight;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BDB8", Offset = "0x31BDB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BDB8", Offset = "0x31BDB8")]
		public float bendWeight;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BE08", Offset = "0x31BE08")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31BE54", Offset = "0x31BE54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BE54", Offset = "0x31BE54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BE54", Offset = "0x31BE54")]
		public float CCDWeight;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BEC8", Offset = "0x31BEC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BEC8", Offset = "0x31BEC8")]
		public float roll;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BF48", Offset = "0x31BF48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31BF48", Offset = "0x31BF48")]
		public float damper;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31BFB0", Offset = "0x31BFB0")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31C01C", Offset = "0x31C01C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C01C", Offset = "0x31C01C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C01C", Offset = "0x31C01C")]
		public float postStretchWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C098", Offset = "0x31C098")]
		public float maxStretch;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C0E0", Offset = "0x31C0E0")]
		public float stretchDamper;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C134", Offset = "0x31C134")]
		public bool fixHead;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C168", Offset = "0x31C168")]
		public Transform[] stretchBones;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31C19C", Offset = "0x31C19C")]
		public Vector3 chestDirection;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C1D8", Offset = "0x31C1D8")]
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
		[Address(RVA = "0xF5E5BC", Offset = "0xF5E5BC", VA = "0xF5E5BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xF5EC64", Offset = "0xF5EC64", VA = "0xF5EC64")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xF5F4F8", Offset = "0xF5F4F8", VA = "0xF5F4F8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xF5FC44", Offset = "0xF5FC44", VA = "0xF5FC44")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xF60AAC", Offset = "0xF60AAC", VA = "0xF60AAC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xF60FC8", Offset = "0xF60FC8", VA = "0xF60FC8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xF615A0", Offset = "0xF615A0", VA = "0xF615A0")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xF62654", Offset = "0xF62654", VA = "0xF62654")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xF606D4", Offset = "0xF606D4", VA = "0xF606D4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xF62968", Offset = "0xF62968", VA = "0xF62968")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xF62498", Offset = "0xF62498", VA = "0xF62498")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xF622B8", Offset = "0xF622B8", VA = "0xF622B8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xF62EC0", Offset = "0xF62EC0", VA = "0xF62EC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xF63478", Offset = "0xF63478", VA = "0xF63478")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F864", Offset = "0x31F864")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F874", Offset = "0x31F874")]
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
				[Address(RVA = "0xF6891C", Offset = "0xF6891C", VA = "0xF6891C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324CF0", Offset = "0x324CF0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0xF68924", Offset = "0xF68924", VA = "0xF68924")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D00", Offset = "0x324D00")]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public bool isRigid
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0xF6892C", Offset = "0xF6892C", VA = "0xF6892C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D10", Offset = "0x324D10")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0xF68934", Offset = "0xF68934", VA = "0xF68934")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D20", Offset = "0x324D20")]
				private set
				{
				}
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xF6893C", Offset = "0xF6893C", VA = "0xF6893C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xF64B50", Offset = "0xF64B50", VA = "0xF64B50")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xF655DC", Offset = "0xF655DC", VA = "0xF655DC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xF68410", Offset = "0xF68410", VA = "0xF68410")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C1F0", Offset = "0x31C1F0")]
		public float pin;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C208", Offset = "0x31C208")]
		public float pull;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C220", Offset = "0x31C220")]
		public float push;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C238", Offset = "0x31C238")]
		public float pushParent;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C254", Offset = "0x31C254")]
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
		[Address(RVA = "0xF637BC", Offset = "0xF637BC", VA = "0xF637BC")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xF638AC", Offset = "0xF638AC", VA = "0xF638AC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xF639D4", Offset = "0xF639D4", VA = "0xF639D4")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xF63B34", Offset = "0xF63B34", VA = "0xF63B34")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xF63C48", Offset = "0xF63C48", VA = "0xF63C48")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xF63D90", Offset = "0xF63D90", VA = "0xF63D90")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xF64BC0", Offset = "0xF64BC0", VA = "0xF64BC0")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xF6408C", Offset = "0xF6408C", VA = "0xF6408C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xF65914", Offset = "0xF65914", VA = "0xF65914")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xF65EFC", Offset = "0xF65EFC", VA = "0xF65EFC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xF66580", Offset = "0xF66580", VA = "0xF66580")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xF66E0C", Offset = "0xF66E0C", VA = "0xF66E0C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xF67A48", Offset = "0xF67A48", VA = "0xF67A48")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xF67F54", Offset = "0xF67F54", VA = "0xF67F54")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xF67908", Offset = "0xF67908", VA = "0xF67908")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xF66B84", Offset = "0xF66B84", VA = "0xF66B84")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xF67874", Offset = "0xF67874", VA = "0xF67874")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xF6818C", Offset = "0xF6818C", VA = "0xF6818C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xF67628", Offset = "0xF67628", VA = "0xF67628")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xF67C88", Offset = "0xF67C88", VA = "0xF67C88")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C26C", Offset = "0x31C26C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C284", Offset = "0x31C284")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001E")]
		public bool initiated
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x13B0AC0", Offset = "0x13B0AC0", VA = "0x13B0AC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323DB8", Offset = "0x323DB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x13B0AC8", Offset = "0x13B0AC8", VA = "0x13B0AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323DC8", Offset = "0x323DC8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x13B07EC", Offset = "0x13B07EC", VA = "0x13B07EC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x13B0AD0", Offset = "0x13B0AD0", VA = "0x13B0AD0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x13B0B80", Offset = "0x13B0B80", VA = "0x13B0B80")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x13B0C48", Offset = "0x13B0C48", VA = "0x13B0C48")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x13B0C54", Offset = "0x13B0C54", VA = "0x13B0C54")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x13B13CC", Offset = "0x13B13CC", VA = "0x13B13CC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x13B169C", Offset = "0x13B169C", VA = "0x13B169C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x13B1D30", Offset = "0x13B1D30", VA = "0x13B1D30")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x13B10AC", Offset = "0x13B10AC", VA = "0x13B10AC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x13B123C", Offset = "0x13B123C", VA = "0x13B123C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C294", Offset = "0x31C294")]
		public float positionWeight;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C2AC", Offset = "0x31C2AC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C2C4", Offset = "0x31C2C4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool effectChildNodes;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C2D4", Offset = "0x31C2D4")]
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
			[Address(RVA = "0x13B268C", Offset = "0x13B268C", VA = "0x13B268C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323DD8", Offset = "0x323DD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x13B2694", Offset = "0x13B2694", VA = "0x13B2694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323DE8", Offset = "0x323DE8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x13B25E0", Offset = "0x13B25E0", VA = "0x13B25E0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x13B269C", Offset = "0x13B269C", VA = "0x13B269C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x13B27C0", Offset = "0x13B27C0", VA = "0x13B27C0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x13B2974", Offset = "0x13B2974", VA = "0x13B2974")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x13B2B38", Offset = "0x13B2B38", VA = "0x13B2B38")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x13B3048", Offset = "0x13B3048", VA = "0x13B3048")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x13B3488", Offset = "0x13B3488", VA = "0x13B3488")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x13B3670", Offset = "0x13B3670", VA = "0x13B3670")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x13B3778", Offset = "0x13B3778", VA = "0x13B3778")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x13B411C", Offset = "0x13B411C", VA = "0x13B411C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x13B41B4", Offset = "0x13B41B4", VA = "0x13B41B4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x13B4484", Offset = "0x13B4484", VA = "0x13B4484")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x13B49A4", Offset = "0x13B49A4", VA = "0x13B49A4")]
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
				[Address(RVA = "0x13B5470", Offset = "0x13B5470", VA = "0x13B5470")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700007A")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x13B5664", Offset = "0x13B5664", VA = "0x13B5664")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007B")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x13B5D6C", Offset = "0x13B5D6C", VA = "0x13B5D6C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x13B5424", Offset = "0x13B5424", VA = "0x13B5424")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x13B5548", Offset = "0x13B5548", VA = "0x13B5548")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x13B55CC", Offset = "0x13B55CC", VA = "0x13B55CC")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x13B5678", Offset = "0x13B5678", VA = "0x13B5678")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x13B5774", Offset = "0x13B5774", VA = "0x13B5774")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x13B577C", Offset = "0x13B577C", VA = "0x13B577C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x13B5940", Offset = "0x13B5940", VA = "0x13B5940")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x13B5A90", Offset = "0x13B5A90", VA = "0x13B5A90")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x13B5B64", Offset = "0x13B5B64", VA = "0x13B5B64")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x13B600C", Offset = "0x13B600C", VA = "0x13B600C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x13B6054", Offset = "0x13B6054", VA = "0x13B6054")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x13B60A4", Offset = "0x13B60A4", VA = "0x13B60A4")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x13B60F0", Offset = "0x13B60F0", VA = "0x13B60F0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x13B629C", Offset = "0x13B629C", VA = "0x13B629C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x13B6684", Offset = "0x13B6684", VA = "0x13B6684")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x13B66D0", Offset = "0x13B66D0", VA = "0x13B66D0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x13B6894", Offset = "0x13B6894", VA = "0x13B6894")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x13B690C", Offset = "0x13B690C", VA = "0x13B690C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x13B6BD8", Offset = "0x13B6BD8", VA = "0x13B6BD8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x13B6E9C", Offset = "0x13B6E9C", VA = "0x13B6E9C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x13B6FC4", Offset = "0x13B6FC4", VA = "0x13B6FC4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x13B63F0", Offset = "0x13B63F0", VA = "0x13B63F0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x13B71FC", Offset = "0x13B71FC", VA = "0x13B71FC")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x13B5178", Offset = "0x13B5178", VA = "0x13B5178", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x13B5180", Offset = "0x13B5180", VA = "0x13B5180", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x13B5184", Offset = "0x13B5184", VA = "0x13B5184")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x13B52DC", Offset = "0x13B52DC", VA = "0x13B52DC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x13B541C", Offset = "0x13B541C", VA = "0x13B541C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C2EC", Offset = "0x31C2EC")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BoneMap boneMap;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x13B7234", Offset = "0x13B7234", VA = "0x13B7234", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x13B72EC", Offset = "0x13B72EC", VA = "0x13B72EC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x13B7390", Offset = "0x13B7390", VA = "0x13B7390")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x13B743C", Offset = "0x13B743C", VA = "0x13B743C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x13B7464", Offset = "0x13B7464", VA = "0x13B7464")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x13B7490", Offset = "0x13B7490", VA = "0x13B7490", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x13B7568", Offset = "0x13B7568", VA = "0x13B7568")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x13B7590", Offset = "0x13B7590", VA = "0x13B7590")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C304", Offset = "0x31C304")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C31C", Offset = "0x31C31C")]
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
		[Address(RVA = "0x13B75D0", Offset = "0x13B75D0", VA = "0x13B75D0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x13B7650", Offset = "0x13B7650", VA = "0x13B7650")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x13B7740", Offset = "0x13B7740", VA = "0x13B7740")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x13B7B70", Offset = "0x13B7B70", VA = "0x13B7B70")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x13B7CB0", Offset = "0x13B7CB0", VA = "0x13B7CB0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x13B7E14", Offset = "0x13B7E14", VA = "0x13B7E14")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x13B7E28", Offset = "0x13B7E28", VA = "0x13B7E28")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x13B7F2C", Offset = "0x13B7F2C", VA = "0x13B7F2C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x13B8040", Offset = "0x13B8040", VA = "0x13B8040", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x13B83F8", Offset = "0x13B83F8", VA = "0x13B83F8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x13B84F8", Offset = "0x13B84F8", VA = "0x13B84F8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C334", Offset = "0x31C334")]
		public int iterations;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C350", Offset = "0x31C350")]
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
		[Address(RVA = "0x13B8780", Offset = "0x13B8780", VA = "0x13B8780", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x13B8B78", Offset = "0x13B8B78", VA = "0x13B8B78")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x13B8CDC", Offset = "0x13B8CDC", VA = "0x13B8CDC")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x13B8E70", Offset = "0x13B8E70", VA = "0x13B8E70")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x13B8E98", Offset = "0x13B8E98", VA = "0x13B8E98")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x13B8F24", Offset = "0x13B8F24", VA = "0x13B8F24")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x13B8FEC", Offset = "0x13B8FEC", VA = "0x13B8FEC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x13B9B18", Offset = "0x13B9B18", VA = "0x13B9B18")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x13B9B5C", Offset = "0x13B9B5C", VA = "0x13B9B5C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x13BA070", Offset = "0x13BA070", VA = "0x13BA070")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x13BA7A0", Offset = "0x13BA7A0", VA = "0x13BA7A0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x13BA9FC", Offset = "0x13BA9FC", VA = "0x13BA9FC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x13BAC30", Offset = "0x13BAC30", VA = "0x13BAC30")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31F884", Offset = "0x31F884")]
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
			[Address(RVA = "0x13BD6EC", Offset = "0x13BD6EC", VA = "0x13BD6EC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x13BD770", Offset = "0x13BD770", VA = "0x13BD770")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x13BD944", Offset = "0x13BD944", VA = "0x13BD944")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x13BD98C", Offset = "0x13BD98C", VA = "0x13BD98C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x13BD9D4", Offset = "0x13BD9D4", VA = "0x13BD9D4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x13BDA58", Offset = "0x13BDA58", VA = "0x13BDA58")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x13BCF28", Offset = "0x13BCF28", VA = "0x13BCF28")]
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
				[Address(RVA = "0x13BC1B0", Offset = "0x13BC1B0", VA = "0x13BC1B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x13BC2DC", Offset = "0x13BC2DC", VA = "0x13BC2DC")]
				set
				{
				}
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x13BC370", Offset = "0x13BC370", VA = "0x13BC370")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x13BC6AC", Offset = "0x13BC6AC", VA = "0x13BC6AC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x13BCB68", Offset = "0x13BCB68", VA = "0x13BCB68")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x13BCE18", Offset = "0x13BCE18", VA = "0x13BCE18")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x13BCE64", Offset = "0x13BCE64", VA = "0x13BCE64")]
			public Bone()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x13BCFDC", Offset = "0x13BCFDC", VA = "0x13BCFDC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x13BD0A8", Offset = "0x13BD0A8", VA = "0x13BD0A8")]
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
			[Address(RVA = "0x13BD6A8", Offset = "0x13BD6A8", VA = "0x13BD6A8")]
			public Node()
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x13BD6AC", Offset = "0x13BD6AC", VA = "0x13BD6AC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x13BD6C8", Offset = "0x13BD6C8", VA = "0x13BD6C8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C378", Offset = "0x31C378")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C378", Offset = "0x31C378")]
		public float IKPositionWeight;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C3F4", Offset = "0x31C3F4")]
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
			[Address(RVA = "0x13B04D8", Offset = "0x13B04D8", VA = "0x13B04D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323DF8", Offset = "0x323DF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x13BB6B4", Offset = "0x13BB6B4", VA = "0x13BB6B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E08", Offset = "0x323E08")]
			private set
			{
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x13BB1E8", Offset = "0x13BB1E8", VA = "0x13BB1E8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x13B05CC", Offset = "0x13B05CC", VA = "0x13B05CC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x13B04E0", Offset = "0x13B04E0", VA = "0x13B04E0")]
		public void Update()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x13BB6BC", Offset = "0x13BB6BC", VA = "0x13BB6BC", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x13BB6D0", Offset = "0x13BB6D0", VA = "0x13BB6D0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x13BB6DC", Offset = "0x13BB6DC", VA = "0x13BB6DC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x13BB6E4", Offset = "0x13BB6E4", VA = "0x13BB6E4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x13AE824", Offset = "0x13AE824", VA = "0x13AE824")]
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
		[Address(RVA = "0x13BB778", Offset = "0x13BB778", VA = "0x13BB778")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x13BB790", Offset = "0x13BB790", VA = "0x13BB790")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x13BB92C", Offset = "0x13BB92C", VA = "0x13BB92C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x13BB9F4", Offset = "0x13BB9F4", VA = "0x13BB9F4")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x13BC198", Offset = "0x13BC198", VA = "0x13BC198")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C434", Offset = "0x31C434")]
		public float poleWeight;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform poleTarget;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C44C", Offset = "0x31C44C")]
		public float clampWeight;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C464", Offset = "0x31C464")]
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
			[Address(RVA = "0x13BDC24", Offset = "0x13BDC24", VA = "0x13BDC24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x13BDCFC", Offset = "0x13BDCFC", VA = "0x13BDCFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		protected override int minBones
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x13BEFE0", Offset = "0x13BEFE0", VA = "0x13BEFE0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000024")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x13BF7F8", Offset = "0x13BF7F8", VA = "0x13BF7F8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x13BDB28", Offset = "0x13BDB28", VA = "0x13BDB28")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x13BDDD4", Offset = "0x13BDDD4", VA = "0x13BDDD4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x13BE158", Offset = "0x13BE158", VA = "0x13BE158", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x13BEDF8", Offset = "0x13BEDF8", VA = "0x13BEDF8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x13BE93C", Offset = "0x13BE93C", VA = "0x13BE93C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x13BEFE8", Offset = "0x13BEFE8", VA = "0x13BEFE8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x13BF904", Offset = "0x13BF904", VA = "0x13BF904")]
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
		[Address(RVA = "0x13BFA64", Offset = "0x13BFA64", VA = "0x13BFA64")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x13BFBBC", Offset = "0x13BFBBC", VA = "0x13BFBBC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x13C05CC", Offset = "0x13C05CC", VA = "0x13C05CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x13C102C", Offset = "0x13C102C", VA = "0x13C102C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x13C1C5C", Offset = "0x13C1C5C", VA = "0x13C1C5C")]
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
			[Address(RVA = "0x13C39B0", Offset = "0x13C39B0", VA = "0x13C39B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x13C1C60", Offset = "0x13C1C60", VA = "0x13C1C60")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x13C2978", Offset = "0x13C2978", VA = "0x13C2978")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x13C2AD8", Offset = "0x13C2AD8", VA = "0x13C2AD8", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x13C2BA8", Offset = "0x13C2BA8", VA = "0x13C2BA8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x13C34F8", Offset = "0x13C34F8", VA = "0x13C34F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x13C39B8", Offset = "0x13C39B8", VA = "0x13C39B8")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x13C1D34", Offset = "0x13C1D34", VA = "0x13C1D34")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x13C2A7C", Offset = "0x13C2A7C", VA = "0x13C2A7C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x13C3920", Offset = "0x13C3920", VA = "0x13C3920")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x13C2594", Offset = "0x13C2594", VA = "0x13C2594")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x13C4890", Offset = "0x13C4890", VA = "0x13C4890")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x13C49D4", Offset = "0x13C49D4", VA = "0x13C49D4")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x13C4B78", Offset = "0x13C4B78", VA = "0x13C4B78")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x13C4D1C", Offset = "0x13C4D1C", VA = "0x13C4D1C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x13C30CC", Offset = "0x13C30CC", VA = "0x13C30CC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x13C32E0", Offset = "0x13C32E0", VA = "0x13C32E0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x13C5004", Offset = "0x13C5004", VA = "0x13C5004")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x13C3F00", Offset = "0x13C3F00", VA = "0x13C3F00")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x13C2A4C", Offset = "0x13C2A4C", VA = "0x13C2A4C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x13C5DC8", Offset = "0x13C5DC8", VA = "0x13C5DC8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x13C5254", Offset = "0x13C5254", VA = "0x13C5254")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x13C3B04", Offset = "0x13C3B04", VA = "0x13C3B04")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x13C3D00", Offset = "0x13C3D00", VA = "0x13C3D00")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x13C6000", Offset = "0x13C6000", VA = "0x13C6000")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C47C", Offset = "0x31C47C")]
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
		[Address(RVA = "0x13C608C", Offset = "0x13C608C", VA = "0x13C608C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x13C7288", Offset = "0x13C7288", VA = "0x13C7288", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x13C7380", Offset = "0x13C7380", VA = "0x13C7380", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x13C748C", Offset = "0x13C748C", VA = "0x13C748C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x13C7600", Offset = "0x13C7600", VA = "0x13C7600")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x13C7748", Offset = "0x13C7748", VA = "0x13C7748", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x13C7F94", Offset = "0x13C7F94", VA = "0x13C7F94", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x13C8244", Offset = "0x13C8244", VA = "0x13C8244", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x13C8078", Offset = "0x13C8078", VA = "0x13C8078")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x13C7AE0", Offset = "0x13C7AE0", VA = "0x13C7AE0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x13C8318", Offset = "0x13C8318", VA = "0x13C8318")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C494", Offset = "0x31C494")]
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
		[Address(RVA = "0x13C83A4", Offset = "0x13C83A4", VA = "0x13C83A4")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x13C84EC", Offset = "0x13C84EC", VA = "0x13C84EC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x13C854C", Offset = "0x13C854C", VA = "0x13C854C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x13B254C", Offset = "0x13B254C", VA = "0x13B254C")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x13B1018", Offset = "0x13B1018", VA = "0x13B1018")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x13C871C", Offset = "0x13C871C", VA = "0x13C871C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x13C899C", Offset = "0x13C899C", VA = "0x13C899C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x13C8BF0", Offset = "0x13C8BF0", VA = "0x13C8BF0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x13C8EDC", Offset = "0x13C8EDC", VA = "0x13C8EDC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x13C9010", Offset = "0x13C9010", VA = "0x13C9010", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x13C9160", Offset = "0x13C9160", VA = "0x13C9160", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x13C9370", Offset = "0x13C9370", VA = "0x13C9370", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x13C95E4", Offset = "0x13C95E4", VA = "0x13C95E4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x13C9A5C", Offset = "0x13C9A5C", VA = "0x13C9A5C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x13CA094", Offset = "0x13CA094", VA = "0x13CA094", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x13CA0FC", Offset = "0x13CA0FC", VA = "0x13CA0FC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x13CA264", Offset = "0x13CA264", VA = "0x13CA264")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C4B0", Offset = "0x31C4B0")]
		public float spineStiffness;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C4C8", Offset = "0x31C4C8")]
		public float pullBodyVertical;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C4E4", Offset = "0x31C4E4")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C500", Offset = "0x31C500")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 offset;

		[Token(Token = "0x17000026")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x13CA368", Offset = "0x13CA368", VA = "0x13CA368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x13CA370", Offset = "0x13CA370", VA = "0x13CA370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x13CA378", Offset = "0x13CA378", VA = "0x13CA378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x13CA380", Offset = "0x13CA380", VA = "0x13CA380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x13CA388", Offset = "0x13CA388", VA = "0x13CA388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x13CA390", Offset = "0x13CA390", VA = "0x13CA390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x13CA398", Offset = "0x13CA398", VA = "0x13CA398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x13CA3A0", Offset = "0x13CA3A0", VA = "0x13CA3A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x13CA3A8", Offset = "0x13CA3A8", VA = "0x13CA3A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x13CA3B0", Offset = "0x13CA3B0", VA = "0x13CA3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x13CA3F0", Offset = "0x13CA3F0", VA = "0x13CA3F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x13CA430", Offset = "0x13CA430", VA = "0x13CA430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x13CA470", Offset = "0x13CA470", VA = "0x13CA470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x13CA4B0", Offset = "0x13CA4B0", VA = "0x13CA4B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x13CA4F0", Offset = "0x13CA4F0", VA = "0x13CA4F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x13CA530", Offset = "0x13CA530", VA = "0x13CA530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x13CA570", Offset = "0x13CA570", VA = "0x13CA570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x13CA5B0", Offset = "0x13CA5B0", VA = "0x13CA5B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x13CDB8C", Offset = "0x13CDB8C", VA = "0x13CDB8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E18", Offset = "0x323E18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x13CDBA0", Offset = "0x13CDBA0", VA = "0x13CDBA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E28", Offset = "0x323E28")]
			private set
			{
			}
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x13CA5F0", Offset = "0x13CA5F0", VA = "0x13CA5F0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x13CA774", Offset = "0x13CA774", VA = "0x13CA774")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x13CA65C", Offset = "0x13CA65C", VA = "0x13CA65C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x13CA878", Offset = "0x13CA878", VA = "0x13CA878")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x13AE9E4", Offset = "0x13AE9E4", VA = "0x13AE9E4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x13CA9DC", Offset = "0x13CA9DC", VA = "0x13CA9DC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x13CAAF4", Offset = "0x13CAAF4", VA = "0x13CAAF4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x13CAC0C", Offset = "0x13CAC0C", VA = "0x13CAC0C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x13CAD38", Offset = "0x13CAD38", VA = "0x13CAD38")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x13CAD40", Offset = "0x13CAD40", VA = "0x13CAD40")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x13CAD80", Offset = "0x13CAD80", VA = "0x13CAD80")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x13CAEAC", Offset = "0x13CAEAC", VA = "0x13CAEAC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x13CB1E4", Offset = "0x13CB1E4", VA = "0x13CB1E4")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x13CD1AC", Offset = "0x13CD1AC", VA = "0x13CD1AC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x13CD850", Offset = "0x13CD850", VA = "0x13CD850")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x13CD90C", Offset = "0x13CD90C", VA = "0x13CD90C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x13CD648", Offset = "0x13CD648", VA = "0x13CD648")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x13CD74C", Offset = "0x13CD74C", VA = "0x13CD74C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x13CDBAC", Offset = "0x13CDBAC", VA = "0x13CDBAC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x13CDC90", Offset = "0x13CDC90", VA = "0x13CDC90", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x13CDEDC", Offset = "0x13CDEDC", VA = "0x13CDEDC")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x13CE0E4", Offset = "0x13CE0E4", VA = "0x13CE0E4")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x13CE30C", Offset = "0x13CE30C", VA = "0x13CE30C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x13CE608", Offset = "0x13CE608", VA = "0x13CE608", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x13CEC04", Offset = "0x13CEC04", VA = "0x13CEC04", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x13CED54", Offset = "0x13CED54", VA = "0x13CED54")]
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
			[Address(RVA = "0x13CF89C", Offset = "0x13CF89C", VA = "0x13CF89C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003A")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x13CF8A4", Offset = "0x13CF8A4", VA = "0x13CF8A4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x13CF8AC", Offset = "0x13CF8AC", VA = "0x13CF8AC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x13CF8BC", Offset = "0x13CF8BC", VA = "0x13CF8BC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		protected float positionOffset
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x13C0F58", Offset = "0x13C0F58", VA = "0x13C0F58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x13CED64", Offset = "0x13CED64", VA = "0x13CED64")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x13CEF94", Offset = "0x13CEF94", VA = "0x13CEF94")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x13CF170", Offset = "0x13CF170", VA = "0x13CF170", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x13CF1FC", Offset = "0x13CF1FC", VA = "0x13CF1FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x13CF2A0", Offset = "0x13CF2A0", VA = "0x13CF2A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x13CF74C", Offset = "0x13CF74C", VA = "0x13CF74C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x13CF754", Offset = "0x13CF754", VA = "0x13CF754", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x13CF8B4", Offset = "0x13CF8B4", VA = "0x13CF8B4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x13CF8B8", Offset = "0x13CF8B8", VA = "0x13CF8B8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x13BFC7C", Offset = "0x13BFC7C", VA = "0x13BFC7C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x13C0A0C", Offset = "0x13C0A0C", VA = "0x13C0A0C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x13CFAC4", Offset = "0x13CFAC4", VA = "0x13CFAC4")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x13BF9D4", Offset = "0x13BF9D4", VA = "0x13BF9D4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C510", Offset = "0x31C510")]
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
		[Address(RVA = "0x13CFEA0", Offset = "0x13CFEA0", VA = "0x13CFEA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x13D0440", Offset = "0x13D0440", VA = "0x13D0440")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x13D04F0", Offset = "0x13D04F0", VA = "0x13D04F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x13D0710", Offset = "0x13D0710", VA = "0x13D0710", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x13D0950", Offset = "0x13D0950", VA = "0x13D0950", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x13D09D0", Offset = "0x13D09D0", VA = "0x13D09D0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x13D0A5C", Offset = "0x13D0A5C", VA = "0x13D0A5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x13D117C", Offset = "0x13D117C", VA = "0x13D117C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x13D11A0", Offset = "0x13D11A0", VA = "0x13D11A0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x13D0B10", Offset = "0x13D0B10", VA = "0x13D0B10")]
		private void Read()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x13D1310", Offset = "0x13D1310", VA = "0x13D1310")]
		private void Write()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x13D1570", Offset = "0x13D1570", VA = "0x13D1570")]
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
			[Address(RVA = "0x47DB14", Offset = "0x47DB14", VA = "0x47DB14")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C528", Offset = "0x31C528")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C540", Offset = "0x31C540")]
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
			[Address(RVA = "0x13D3490", Offset = "0x13D3490", VA = "0x13D3490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x13D16FC", Offset = "0x13D16FC", VA = "0x13D16FC")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x13D1774", Offset = "0x13D1774", VA = "0x13D1774")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x13D17D0", Offset = "0x13D17D0", VA = "0x13D17D0", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x13D2094", Offset = "0x13D2094", VA = "0x13D2094", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x13D31E8", Offset = "0x13D31E8", VA = "0x13D31E8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x13D3370", Offset = "0x13D3370", VA = "0x13D3370")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x13D33FC", Offset = "0x13D33FC", VA = "0x13D33FC")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x13D1CA4", Offset = "0x13D1CA4", VA = "0x13D1CA4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x13D221C", Offset = "0x13D221C", VA = "0x13D221C")]
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
				[Address(RVA = "0x11AEF58", Offset = "0x11AEF58", VA = "0x11AEF58")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x11AF900", Offset = "0x11AF900", VA = "0x11AF900")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x11ADCC0", Offset = "0x11ADCC0", VA = "0x11ADCC0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x11AE25C", Offset = "0x11AE25C", VA = "0x11AE25C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x11AF520", Offset = "0x11AF520", VA = "0x11AF520")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C558", Offset = "0x31C558")]
		public float bodyWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C570", Offset = "0x31C570")]
		public float headWeight;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C588", Offset = "0x31C588")]
		public float eyesWeight;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C5A0", Offset = "0x31C5A0")]
		public float clampWeight;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C5B8", Offset = "0x31C5B8")]
		public float clampWeightHead;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C5D0", Offset = "0x31C5D0")]
		public float clampWeightEyes;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C5E8", Offset = "0x31C5E8")]
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
			[Address(RVA = "0x11AD06C", Offset = "0x11AD06C", VA = "0x11AD06C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x11AD35C", Offset = "0x11AD35C", VA = "0x11AD35C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		private bool headIsValid
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x11AD1DC", Offset = "0x11AD1DC", VA = "0x11AD1DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x11AD38C", Offset = "0x11AD38C", VA = "0x11AD38C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x11AD1EC", Offset = "0x11AD1EC", VA = "0x11AD1EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x11AD42C", Offset = "0x11AD42C", VA = "0x11AD42C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11AC51C", Offset = "0x11AC51C", VA = "0x11AC51C")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x11AC5B0", Offset = "0x11AC5B0", VA = "0x11AC5B0")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x11AC660", Offset = "0x11AC660", VA = "0x11AC660")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11AC72C", Offset = "0x11AC72C", VA = "0x11AC72C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x11AC820", Offset = "0x11AC820", VA = "0x11AC820")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x11AC93C", Offset = "0x11AC93C", VA = "0x11AC93C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11ACA90", Offset = "0x11ACA90", VA = "0x11ACA90", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x11ACC54", Offset = "0x11ACC54", VA = "0x11ACC54", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x11ACE3C", Offset = "0x11ACE3C", VA = "0x11ACE3C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11AD45C", Offset = "0x11AD45C", VA = "0x11AD45C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11AD7BC", Offset = "0x11AD7BC", VA = "0x11AD7BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x11AD9CC", Offset = "0x11AD9CC", VA = "0x11AD9CC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11ADCE0", Offset = "0x11ADCE0", VA = "0x11ADCE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11AE3C8", Offset = "0x11AE3C8", VA = "0x11AE3C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x11AE508", Offset = "0x11AE508", VA = "0x11AE508")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x11AE858", Offset = "0x11AE858", VA = "0x11AE858")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x11AEBDC", Offset = "0x11AEBDC", VA = "0x11AEBDC")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x11AF030", Offset = "0x11AF030", VA = "0x11AF030")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x11ADA84", Offset = "0x11ADA84", VA = "0x11ADA84")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11AF6B8", Offset = "0x11AF6B8", VA = "0x11AF6B8")]
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
			[Address(RVA = "0x11B16F8", Offset = "0x11B16F8", VA = "0x11B16F8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x11B28BC", Offset = "0x11B28BC", VA = "0x11B28BC")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x11B2420", Offset = "0x11B2420", VA = "0x11B2420")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x11B2B1C", Offset = "0x11B2B1C", VA = "0x11B2B1C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C600", Offset = "0x31C600")]
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
		[Address(RVA = "0x11AF908", Offset = "0x11AF908", VA = "0x11AF908")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x11AFB84", Offset = "0x11AFB84", VA = "0x11AFB84")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x11AFDB8", Offset = "0x11AFDB8", VA = "0x11AFDB8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x11AFDC8", Offset = "0x11AFDC8", VA = "0x11AFDC8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11AFE5C", Offset = "0x11AFE5C", VA = "0x11AFE5C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x11AFE6C", Offset = "0x11AFE6C", VA = "0x11AFE6C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x11AFE74", Offset = "0x11AFE74", VA = "0x11AFE74", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x11AFFEC", Offset = "0x11AFFEC", VA = "0x11AFFEC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x11B016C", Offset = "0x11B016C", VA = "0x11B016C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x11B01DC", Offset = "0x11B01DC", VA = "0x11B01DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x11B025C", Offset = "0x11B025C", VA = "0x11B025C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x11B0824", Offset = "0x11B0824", VA = "0x11B0824")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x11B08A8", Offset = "0x11B08A8", VA = "0x11B08A8")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x11B1030", Offset = "0x11B1030", VA = "0x11B1030")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x11B12B8", Offset = "0x11B12B8", VA = "0x11B12B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x11B1580", Offset = "0x11B1580", VA = "0x11B1580")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x11B1480", Offset = "0x11B1480", VA = "0x11B1480")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x11B1918", Offset = "0x11B1918", VA = "0x11B1918", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x11B29BC", Offset = "0x11B29BC", VA = "0x11B29BC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x11B29C0", Offset = "0x11B29C0", VA = "0x11B29C0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x11B29C4", Offset = "0x11B29C4", VA = "0x11B29C4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x11B24F8", Offset = "0x11B24F8", VA = "0x11B24F8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x11B29C8", Offset = "0x11B29C8", VA = "0x11B29C8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F89C", Offset = "0x31F89C")]
			public Transform target;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F8D8", Offset = "0x31F8D8")]
			public Transform bendGoal;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F90C", Offset = "0x31F90C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31F90C", Offset = "0x31F90C")]
			public float positionWeight;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F97C", Offset = "0x31F97C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31F97C", Offset = "0x31F97C")]
			public float rotationWeight;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F9EC", Offset = "0x31F9EC")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FA4C", Offset = "0x31FA4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FA4C", Offset = "0x31FA4C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FAB4", Offset = "0x31FAB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FAB4", Offset = "0x31FAB4")]
			public float bendGoalWeight;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FB04", Offset = "0x31FB04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FB04", Offset = "0x31FB04")]
			public float swivelOffset;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FB84", Offset = "0x31FB84")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FBB8", Offset = "0x31FBB8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FBEC", Offset = "0x31FBEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FBEC", Offset = "0x31FBEC")]
			public float armLengthMlp;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FC64", Offset = "0x31FC64")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FCD8", Offset = "0x31FCD8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FCE8", Offset = "0x31FCE8")]
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
				[Address(RVA = "0x11BF744", Offset = "0x11BF744", VA = "0x11BF744")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D30", Offset = "0x324D30")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0x11BF758", Offset = "0x11BF758", VA = "0x11BF758")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D40", Offset = "0x324D40")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion rotation
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x11BF764", Offset = "0x11BF764", VA = "0x11BF764")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D50", Offset = "0x324D50")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x11BF774", Offset = "0x11BF774", VA = "0x11BF774")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D60", Offset = "0x324D60")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x11BF784", Offset = "0x11BF784", VA = "0x11BF784")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x11BF7C4", Offset = "0x11BF7C4", VA = "0x11BF7C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x11BF804", Offset = "0x11BF804", VA = "0x11BF804")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private VirtualBone hand
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x11BF844", Offset = "0x11BF844", VA = "0x11BF844")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x11BF884", Offset = "0x11BF884", VA = "0x11BF884", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x11C05A4", Offset = "0x11C05A4", VA = "0x11C05A4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x11C08A0", Offset = "0x11C08A0", VA = "0x11C08A0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x11C0958", Offset = "0x11C0958", VA = "0x11C0958")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x11BC86C", Offset = "0x11BC86C", VA = "0x11BC86C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x11C26E4", Offset = "0x11C26E4", VA = "0x11C26E4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x11C277C", Offset = "0x11C277C", VA = "0x11C277C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x11C0F98", Offset = "0x11C0F98", VA = "0x11C0F98")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x11C1450", Offset = "0x11C1450", VA = "0x11C1450")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x11C2B28", Offset = "0x11C2B28", VA = "0x11C2B28")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x11BF3A8", Offset = "0x11BF3A8", VA = "0x11BF3A8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FCF8", Offset = "0x31FCF8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FD08", Offset = "0x31FD08")]
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
				[Address(RVA = "0x11C2D80", Offset = "0x11C2D80", VA = "0x11C2D80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D70", Offset = "0x324D70")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600060C")]
				[Address(RVA = "0x11C2D88", Offset = "0x11C2D88", VA = "0x11C2D88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D80", Offset = "0x324D80")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float mag
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0x11C1098", Offset = "0x11C1098", VA = "0x11C1098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324D90", Offset = "0x324D90")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x11C2D90", Offset = "0x11C2D90", VA = "0x11C2D90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324DA0", Offset = "0x324DA0")]
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
			[Address(RVA = "0x11B8ED8", Offset = "0x11B8ED8", VA = "0x11B8ED8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x11C3380", Offset = "0x11C3380", VA = "0x11C3380")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x11C3574", Offset = "0x11C3574", VA = "0x11C3574")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x11C394C", Offset = "0x11C394C", VA = "0x11C394C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x11BC160", Offset = "0x11BC160", VA = "0x11BC160")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x11C248C", Offset = "0x11C248C", VA = "0x11C248C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x11C3980", Offset = "0x11C3980", VA = "0x11C3980")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x11C3B34", Offset = "0x11C3B34", VA = "0x11C3B34")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x11C2CB0", Offset = "0x11C2CB0", VA = "0x11C2CB0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FD28", Offset = "0x31FD28")]
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
				[Address(RVA = "0x11C3B70", Offset = "0x11C3B70", VA = "0x11C3B70")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000087")]
			public float stepProgress
			{
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x11C3B8C", Offset = "0x11C3B8C", VA = "0x11C3B8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324DB0", Offset = "0x324DB0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x11C3B94", Offset = "0x11C3B94", VA = "0x11C3B94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324DC0", Offset = "0x324DC0")]
				private set
				{
				}
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x11C3B9C", Offset = "0x11C3B9C", VA = "0x11C3B9C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x11C3D38", Offset = "0x11C3D38", VA = "0x11C3D38")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x11C3ED4", Offset = "0x11C3ED4", VA = "0x11C3ED4")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x11C4024", Offset = "0x11C4024", VA = "0x11C4024")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x11C4234", Offset = "0x11C4234", VA = "0x11C4234")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x11C4458", Offset = "0x11C4458", VA = "0x11C4458")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FD38", Offset = "0x31FD38")]
			public Transform target;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FD7C", Offset = "0x31FD7C")]
			public Transform bendGoal;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FDB0", Offset = "0x31FDB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FDB0", Offset = "0x31FDB0")]
			public float positionWeight;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FE24", Offset = "0x31FE24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FE24", Offset = "0x31FE24")]
			public float rotationWeight;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FE98", Offset = "0x31FE98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FE98", Offset = "0x31FE98")]
			public float bendGoalWeight;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31FEE8", Offset = "0x31FEE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31FEE8", Offset = "0x31FEE8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FFC8", Offset = "0x31FFC8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FFD8", Offset = "0x31FFD8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FFE8", Offset = "0x31FFE8")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31FFF8", Offset = "0x31FFF8")]
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
				[Address(RVA = "0x11BBF48", Offset = "0x11BBF48", VA = "0x11BBF48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324DD0", Offset = "0x324DD0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x11C4700", Offset = "0x11C4700", VA = "0x11C4700")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324DE0", Offset = "0x324DE0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000623")]
				[Address(RVA = "0x11C470C", Offset = "0x11C470C", VA = "0x11C470C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324DF0", Offset = "0x324DF0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x11C471C", Offset = "0x11C471C", VA = "0x11C471C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E00", Offset = "0x324E00")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public bool hasToes
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0x11C472C", Offset = "0x11C472C", VA = "0x11C472C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E10", Offset = "0x324E10")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x11C4734", Offset = "0x11C4734", VA = "0x11C4734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E20", Offset = "0x324E20")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008B")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x11C473C", Offset = "0x11C473C", VA = "0x11C473C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x11C477C", Offset = "0x11C477C", VA = "0x11C477C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x11C47BC", Offset = "0x11C47BC", VA = "0x11C47BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private VirtualBone toes
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x11C47FC", Offset = "0x11C47FC", VA = "0x11C47FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x11BBEF8", Offset = "0x11BBEF8", VA = "0x11BBEF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x11C483C", Offset = "0x11C483C", VA = "0x11C483C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E30", Offset = "0x324E30")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x11C4850", Offset = "0x11C4850", VA = "0x11C4850")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E40", Offset = "0x324E40")]
				private set
				{
				}
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x11C485C", Offset = "0x11C485C", VA = "0x11C485C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x11C5074", Offset = "0x11C5074", VA = "0x11C5074", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x11C59E0", Offset = "0x11C59E0", VA = "0x11C59E0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x11C58B0", Offset = "0x11C58B0", VA = "0x11C58B0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x11C55D4", Offset = "0x11C55D4", VA = "0x11C55D4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x11BC3B4", Offset = "0x11BC3B4", VA = "0x11BC3B4")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x11C61A8", Offset = "0x11C61A8", VA = "0x11C61A8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x11C6368", Offset = "0x11C6368", VA = "0x11C6368", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x11BF518", Offset = "0x11BF518", VA = "0x11BF518")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320008", Offset = "0x320008")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320008", Offset = "0x320008")]
			public float weight;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320084", Offset = "0x320084")]
			public float footDistance;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3200E4", Offset = "0x3200E4")]
			public float stepThreshold;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320118", Offset = "0x320118")]
			public float angleThreshold;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32014C", Offset = "0x32014C")]
			public float comAngleMlp;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320180", Offset = "0x320180")]
			public float maxVelocity;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3201B4", Offset = "0x3201B4")]
			public float velocityFactor;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320214", Offset = "0x320214")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320214", Offset = "0x320214")]
			public float maxLegStretch;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320268", Offset = "0x320268")]
			public float rootSpeed;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32029C", Offset = "0x32029C")]
			public float stepSpeed;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3202DC", Offset = "0x3202DC")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320344", Offset = "0x320344")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320378", Offset = "0x320378")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320378", Offset = "0x320378")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3203CC", Offset = "0x3203CC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320400", Offset = "0x320400")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32044C", Offset = "0x32044C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3204E4", Offset = "0x3204E4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320540", Offset = "0x320540")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x32059C", Offset = "0x32059C")]
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
				[Address(RVA = "0x11C6468", Offset = "0x11C6468", VA = "0x11C6468")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E50", Offset = "0x324E50")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x11C647C", Offset = "0x11C647C", VA = "0x11C647C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E60", Offset = "0x324E60")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x11C696C", Offset = "0x11C696C", VA = "0x11C696C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000093")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x11C69D0", Offset = "0x11C69D0", VA = "0x11C69D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000094")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x11C6A34", Offset = "0x11C6A34", VA = "0x11C6A34")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000095")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0x11C6A94", Offset = "0x11C6A94", VA = "0x11C6A94")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x11B9004", Offset = "0x11B9004", VA = "0x11B9004")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x11B5A98", Offset = "0x11B5A98", VA = "0x11B5A98")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x11B49A8", Offset = "0x11B49A8", VA = "0x11B49A8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x11B476C", Offset = "0x11B476C", VA = "0x11B476C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x11B9C34", Offset = "0x11B9C34", VA = "0x11B9C34")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x11C64D0", Offset = "0x11C64D0", VA = "0x11C64D0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x11C66A8", Offset = "0x11C66A8", VA = "0x11C66A8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x11C6744", Offset = "0x11C6744", VA = "0x11C6744")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x11BF618", Offset = "0x11BF618", VA = "0x11BF618")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3205AC", Offset = "0x3205AC")]
			public Transform headTarget;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3205EC", Offset = "0x3205EC")]
			public Transform pelvisTarget;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320644", Offset = "0x320644")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320644", Offset = "0x320644")]
			public float positionWeight;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3206B4", Offset = "0x3206B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3206B4", Offset = "0x3206B4")]
			public float rotationWeight;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320724", Offset = "0x320724")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320724", Offset = "0x320724")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320794", Offset = "0x320794")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320794", Offset = "0x320794")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320804", Offset = "0x320804")]
			public Transform chestGoal;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320838", Offset = "0x320838")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320838", Offset = "0x320838")]
			public float chestGoalWeight;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3208A8", Offset = "0x3208A8")]
			public float minHeadHeight;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320910", Offset = "0x320910")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320910", Offset = "0x320910")]
			public float bodyPosStiffness;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320960", Offset = "0x320960")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320960", Offset = "0x320960")]
			public float bodyRotStiffness;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3209B0", Offset = "0x3209B0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3209B0", Offset = "0x3209B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3209B0", Offset = "0x3209B0")]
			public float neckStiffness;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320A34", Offset = "0x320A34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320A34", Offset = "0x320A34")]
			public float rotateChestByHands;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320A84", Offset = "0x320A84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320A84", Offset = "0x320A84")]
			public float chestClampWeight;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320AE4", Offset = "0x320AE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320AE4", Offset = "0x320AE4")]
			public float headClampWeight;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320B44", Offset = "0x320B44")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320B78", Offset = "0x320B78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320B78", Offset = "0x320B78")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320BFC", Offset = "0x320BFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x320BFC", Offset = "0x320BFC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x320D30", Offset = "0x320D30")]
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
				[Address(RVA = "0x11B5F08", Offset = "0x11B5F08", VA = "0x11B5F08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x11C6AF4", Offset = "0x11C6AF4", VA = "0x11C6AF4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x11BC818", Offset = "0x11BC818", VA = "0x11BC818")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x11C6B3C", Offset = "0x11C6B3C", VA = "0x11C6B3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			public VirtualBone head
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x11C6488", Offset = "0x11C6488", VA = "0x11C6488")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x11C6B84", Offset = "0x11C6B84", VA = "0x11C6B84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E70", Offset = "0x324E70")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x11C6B94", Offset = "0x11C6B94", VA = "0x11C6B94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324E80", Offset = "0x324E80")]
				private set
				{
				}
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x11C6BA4", Offset = "0x11C6BA4", VA = "0x11C6BA4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x11C7C90", Offset = "0x11C7C90", VA = "0x11C7C90", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x11C7F80", Offset = "0x11C7F80", VA = "0x11C7F80", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x11C863C", Offset = "0x11C863C", VA = "0x11C863C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x11B9474", Offset = "0x11B9474", VA = "0x11B9474")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x11C9278", Offset = "0x11C9278", VA = "0x11C9278")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x11C9BF8", Offset = "0x11C9BF8", VA = "0x11C9BF8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x11CA7F4", Offset = "0x11CA7F4", VA = "0x11CA7F4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x11CABBC", Offset = "0x11CABBC", VA = "0x11CABBC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x11C8898", Offset = "0x11C8898", VA = "0x11C8898")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x11BBF5C", Offset = "0x11BBF5C", VA = "0x11BBF5C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x11C8D54", Offset = "0x11C8D54", VA = "0x11C8D54")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x11CAD14", Offset = "0x11CAD14", VA = "0x11CAD14")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x11C98D4", Offset = "0x11C98D4", VA = "0x11C98D4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x11C957C", Offset = "0x11C957C", VA = "0x11C957C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x11BF160", Offset = "0x11BF160", VA = "0x11BF160")]
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
			[Address(RVA = "0x11B8E14", Offset = "0x11B8E14", VA = "0x11B8E14")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x11B8E84", Offset = "0x11B8E84", VA = "0x11B8E84")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x11CB1A4", Offset = "0x11CB1A4", VA = "0x11CB1A4")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x11C2D98", Offset = "0x11C2D98", VA = "0x11C2D98")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x11C367C", Offset = "0x11C367C", VA = "0x11C367C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x11CB5B0", Offset = "0x11CB5B0", VA = "0x11CB5B0")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x11C10A0", Offset = "0x11C10A0", VA = "0x11C10A0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x11CB924", Offset = "0x11CB924", VA = "0x11CB924")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x11C1BD4", Offset = "0x11C1BD4", VA = "0x11C1BD4")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x11CBA1C", Offset = "0x11CBA1C", VA = "0x11CBA1C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x11CA09C", Offset = "0x11CA09C", VA = "0x11CA09C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x11CBCA4", Offset = "0x11CBCA4", VA = "0x11CBCA4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x11CBDE4", Offset = "0x11CBDE4", VA = "0x11CBDE4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C618", Offset = "0x31C618")]
		public bool plantFeet;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C64C", Offset = "0x31C64C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C65C", Offset = "0x31C65C")]
		public Spine spine;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C69C", Offset = "0x31C69C")]
		public Arm leftArm;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C6E0", Offset = "0x31C6E0")]
		public Arm rightArm;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C724", Offset = "0x31C724")]
		public Leg leftLeg;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C768", Offset = "0x31C768")]
		public Leg rightLeg;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C7AC", Offset = "0x31C7AC")]
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
			[Address(RVA = "0x11B5A90", Offset = "0x11B5A90", VA = "0x11B5A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E38", Offset = "0x323E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x11B8E7C", Offset = "0x11B8E7C", VA = "0x11B8E7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E48", Offset = "0x323E48")]
			private set
			{
			}
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x11B2B24", Offset = "0x11B2B24", VA = "0x11B2B24")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x11B311C", Offset = "0x11B311C", VA = "0x11B311C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x11B2EE8", Offset = "0x11B2EE8", VA = "0x11B2EE8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x11B3EC4", Offset = "0x11B3EC4", VA = "0x11B3EC4")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x11B42EC", Offset = "0x11B42EC", VA = "0x11B42EC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x11B43B8", Offset = "0x11B43B8", VA = "0x11B43B8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11B4598", Offset = "0x11B4598", VA = "0x11B4598")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x11B4ED0", Offset = "0x11B4ED0", VA = "0x11B4ED0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x11B5F50", Offset = "0x11B5F50", VA = "0x11B5F50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x11B61DC", Offset = "0x11B61DC", VA = "0x11B61DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x11B6478", Offset = "0x11B6478", VA = "0x11B6478", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11B6508", Offset = "0x11B6508", VA = "0x11B6508", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x11B6598", Offset = "0x11B6598", VA = "0x11B6598", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x11B687C", Offset = "0x11B687C", VA = "0x11B687C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x11B3574", Offset = "0x11B3574", VA = "0x11B3574")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x11B37A8", Offset = "0x11B37A8", VA = "0x11B37A8")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x11B3D34", Offset = "0x11B3D34", VA = "0x11B3D34")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x11B50A8", Offset = "0x11B50A8", VA = "0x11B50A8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x11B6C54", Offset = "0x11B6C54", VA = "0x11B6C54", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x11B6C94", Offset = "0x11B6C94", VA = "0x11B6C94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x11B8A40", Offset = "0x11B8A40", VA = "0x11B8A40")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x11B531C", Offset = "0x11B531C", VA = "0x11B531C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x11B6D04", Offset = "0x11B6D04", VA = "0x11B6D04")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x11B8D64", Offset = "0x11B8D64", VA = "0x11B8D64")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x11B8DC0", Offset = "0x11B8DC0", VA = "0x11B8DC0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x11B8840", Offset = "0x11B8840", VA = "0x11B8840")]
		private void Write()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x11BE694", Offset = "0x11BE694", VA = "0x11BE694")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x11BEF88", Offset = "0x11BEF88", VA = "0x11BEF88")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C7FC", Offset = "0x31C7FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C7FC", Offset = "0x31C7FC")]
		public float weight;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C878", Offset = "0x31C878")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C878", Offset = "0x31C878")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C8C8", Offset = "0x31C8C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31C8C8", Offset = "0x31C8C8")]
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
		[Address(RVA = "0x16D9BC0", Offset = "0x16D9BC0", VA = "0x16D9BC0")]
		public void Relax()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x16DA124", Offset = "0x16DA124", VA = "0x16DA124")]
		private void Start()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x16DA6F8", Offset = "0x16DA6F8", VA = "0x16DA6F8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x16DA794", Offset = "0x16DA794", VA = "0x16DA794")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x16DA830", Offset = "0x16DA830", VA = "0x16DA830")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x16DA9EC", Offset = "0x16DA9EC", VA = "0x16DA9EC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C940", Offset = "0x31C940")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C950", Offset = "0x31C950")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31C960", Offset = "0x31C960")]
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
			[Address(RVA = "0x11CC8F4", Offset = "0x11CC8F4", VA = "0x11CC8F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E58", Offset = "0x323E58")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x11CC8FC", Offset = "0x11CC8FC", VA = "0x11CC8FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E68", Offset = "0x323E68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool isPaused
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x11CC904", Offset = "0x11CC904", VA = "0x11CC904")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E78", Offset = "0x323E78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x11CC90C", Offset = "0x11CC90C", VA = "0x11CC90C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E88", Offset = "0x323E88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x11CC914", Offset = "0x11CC914", VA = "0x11CC914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323E98", Offset = "0x323E98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x11CC91C", Offset = "0x11CC91C", VA = "0x11CC91C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323EA8", Offset = "0x323EA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool inInteraction
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x11CC924", Offset = "0x11CC924", VA = "0x11CC924")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public float progress
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x11D0114", Offset = "0x11D0114", VA = "0x11D0114")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x11CC9B0", Offset = "0x11CC9B0", VA = "0x11CC9B0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x11CCA44", Offset = "0x11CCA44", VA = "0x11CCA44")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x11CCB48", Offset = "0x11CCB48", VA = "0x11CCB48")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11CCDE0", Offset = "0x11CCDE0", VA = "0x11CCDE0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x11CD49C", Offset = "0x11CD49C", VA = "0x11CD49C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x11CD6AC", Offset = "0x11CD6AC", VA = "0x11CD6AC")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x11CD740", Offset = "0x11CD740", VA = "0x11CD740")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x11CE078", Offset = "0x11CE078", VA = "0x11CE078")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x11CF2B8", Offset = "0x11CF2B8", VA = "0x11CF2B8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x11CF848", Offset = "0x11CF848", VA = "0x11CF848")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x11CFF14", Offset = "0x11CFF14", VA = "0x11CFF14")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x11D0310", Offset = "0x11D0310", VA = "0x11D0310")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C970", Offset = "0x31C970")]
		public LookAtIK ik;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C9A4", Offset = "0x31C9A4")]
		public float lerpSpeed;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31C9FC", Offset = "0x31C9FC")]
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
		[Address(RVA = "0x11D06F8", Offset = "0x11D06F8", VA = "0x11D06F8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x11D0944", Offset = "0x11D0944", VA = "0x11D0944")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x11D0A38", Offset = "0x11D0A38", VA = "0x11D0A38")]
		public void Update()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x11D0D90", Offset = "0x11D0D90", VA = "0x11D0D90")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x11D0F74", Offset = "0x11D0F74", VA = "0x11D0F74")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x11D10D8", Offset = "0x11D10D8", VA = "0x11D10D8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319C10", Offset = "0x319C10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319C10", Offset = "0x319C10")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320D40", Offset = "0x320D40")]
			public float time;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320D9C", Offset = "0x320D9C")]
			public bool pause;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320DD0", Offset = "0x320DD0")]
			public bool pickUp;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320E04", Offset = "0x320E04")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320E58", Offset = "0x320E58")]
			public Message[] messages;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320EC4", Offset = "0x320EC4")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x11D0154", Offset = "0x11D0154", VA = "0x11D0154")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x11D2AB4", Offset = "0x11D2AB4", VA = "0x11D2AB4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320F18", Offset = "0x320F18")]
			public string function;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320F68", Offset = "0x320F68")]
			public GameObject recipient;

			[Token(Token = "0x4000629")]
			private const string empty = "";

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x11D2990", Offset = "0x11D2990", VA = "0x11D2990")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x11D2ABC", Offset = "0x11D2ABC", VA = "0x11D2ABC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x320FB0", Offset = "0x320FB0")]
			public Animator animator;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32101C", Offset = "0x32101C")]
			public Animation animation;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321050", Offset = "0x321050")]
			public string animationState;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3210A0", Offset = "0x3210A0")]
			public float crossfadeTime;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3210E4", Offset = "0x3210E4")]
			public int layer;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321118", Offset = "0x321118")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000630")]
			private const string empty = "";

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x11D2628", Offset = "0x11D2628", VA = "0x11D2628")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x11D274C", Offset = "0x11D274C", VA = "0x11D274C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x11D2830", Offset = "0x11D2830", VA = "0x11D2830")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x11D297C", Offset = "0x11D297C", VA = "0x11D297C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321180", Offset = "0x321180")]
			public Type type;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3211E8", Offset = "0x3211E8")]
			public AnimationCurve curve;

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x11D1A24", Offset = "0x11D1A24", VA = "0x11D1A24")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x11D2AD4", Offset = "0x11D2AD4", VA = "0x11D2AD4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321228", Offset = "0x321228")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321270", Offset = "0x321270")]
			public float multiplier;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3212C4", Offset = "0x3212C4")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x11D2410", Offset = "0x11D2410", VA = "0x11D2410")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x11D2AC4", Offset = "0x11D2AC4", VA = "0x11D2AC4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CA64", Offset = "0x31CA64")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CA98", Offset = "0x31CA98")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CACC", Offset = "0x31CACC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31CB00", Offset = "0x31CB00")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31CB10", Offset = "0x31CB10")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004B")]
		public float length
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x11CE070", Offset = "0x11CE070", VA = "0x11CE070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x323FF0", Offset = "0x323FF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x11D1334", Offset = "0x11D1334", VA = "0x11D1334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324000", Offset = "0x324000")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x11D133C", Offset = "0x11D133C", VA = "0x11D133C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324010", Offset = "0x324010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x11D1344", Offset = "0x11D1344", VA = "0x11D1344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324020", Offset = "0x324020")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x11D1698", Offset = "0x11D1698", VA = "0x11D1698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x11D026C", Offset = "0x11D026C", VA = "0x11D026C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x11D10F4", Offset = "0x11D10F4", VA = "0x11D10F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323EB8", Offset = "0x323EB8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x11D1154", Offset = "0x11D1154", VA = "0x11D1154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323EEC", Offset = "0x323EEC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x11D11B4", Offset = "0x11D11B4", VA = "0x11D11B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323F20", Offset = "0x323F20")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x11D1214", Offset = "0x11D1214", VA = "0x11D1214")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323F54", Offset = "0x323F54")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x11D1274", Offset = "0x11D1274", VA = "0x11D1274")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323F88", Offset = "0x323F88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x11D12D4", Offset = "0x11D12D4", VA = "0x11D12D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x323FBC", Offset = "0x323FBC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x11D134C", Offset = "0x11D134C", VA = "0x11D134C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x11D173C", Offset = "0x11D173C", VA = "0x11D173C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x11CDF84", Offset = "0x11CDF84", VA = "0x11CDF84")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x11D1934", Offset = "0x11D1934", VA = "0x11D1934")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x11CDD90", Offset = "0x11CDD90", VA = "0x11CDD90")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x11CDF7C", Offset = "0x11CDF7C", VA = "0x11CDF7C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x11CEB20", Offset = "0x11CEB20", VA = "0x11CEB20")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x11CFB94", Offset = "0x11CFB94", VA = "0x11CFB94")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x11D2454", Offset = "0x11D2454", VA = "0x11D2454")]
		private void Awake()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x11D1A58", Offset = "0x11D1A58", VA = "0x11D1A58")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x11D193C", Offset = "0x11D193C", VA = "0x11D193C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x11D2374", Offset = "0x11D2374", VA = "0x11D2374")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x11D2458", Offset = "0x11D2458", VA = "0x11D2458")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x11D24F4", Offset = "0x11D24F4", VA = "0x11D24F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324030", Offset = "0x324030")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x11D2554", Offset = "0x11D2554", VA = "0x11D2554")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324064", Offset = "0x324064")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x11D25B4", Offset = "0x11D25B4", VA = "0x11D25B4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319C70", Offset = "0x319C70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319C70", Offset = "0x319C70")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000D5")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CB20", Offset = "0x31CB20")]
		public string targetTag;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CB54", Offset = "0x31CB54")]
		public float fadeInTime;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CBA8", Offset = "0x31CBA8")]
		public float speed;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CBFC", Offset = "0x31CBFC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31CC30", Offset = "0x31CC30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CC30", Offset = "0x31CC30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x31CC30", Offset = "0x31CC30")]
		public Collider characterCollider;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CCBC", Offset = "0x31CCBC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x31CCBC", Offset = "0x31CCBC")]
		public Transform FPSCamera;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CD1C", Offset = "0x31CD1C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CD50", Offset = "0x31CD50")]
		public float camRaycastDistance;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31CDA8", Offset = "0x31CDA8")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x31CDB8", Offset = "0x31CDB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CDB8", Offset = "0x31CDB8")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CE18", Offset = "0x31CE18")]
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
			[Address(RVA = "0x11D2D1C", Offset = "0x11D2D1C", VA = "0x11D2D1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x11CCB40", Offset = "0x11CCB40", VA = "0x11CCB40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x11D59C4", Offset = "0x11D59C4", VA = "0x11D59C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x11D42B0", Offset = "0x11D42B0", VA = "0x11D42B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3241D0", Offset = "0x3241D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x11D59CC", Offset = "0x11D59CC", VA = "0x11D59CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3241E0", Offset = "0x3241E0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x11D2ADC", Offset = "0x11D2ADC", VA = "0x11D2ADC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324098", Offset = "0x324098")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x11D2B3C", Offset = "0x11D2B3C", VA = "0x11D2B3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3240CC", Offset = "0x3240CC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x11D2B9C", Offset = "0x11D2B9C", VA = "0x11D2B9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324100", Offset = "0x324100")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x11D2BFC", Offset = "0x11D2BFC", VA = "0x11D2BFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324134", Offset = "0x324134")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x11D2C5C", Offset = "0x11D2C5C", VA = "0x11D2C5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324168", Offset = "0x324168")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x11D2CBC", Offset = "0x11D2CBC", VA = "0x11D2CBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32419C", Offset = "0x32419C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x11D2F38", Offset = "0x11D2F38", VA = "0x11D2F38")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x11D3094", Offset = "0x11D3094", VA = "0x11D3094")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x11D31EC", Offset = "0x11D31EC", VA = "0x11D31EC")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x11D32F4", Offset = "0x11D32F4", VA = "0x11D32F4")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x11D3488", Offset = "0x11D3488", VA = "0x11D3488")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x11D363C", Offset = "0x11D363C", VA = "0x11D363C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x11D3734", Offset = "0x11D3734", VA = "0x11D3734")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x11D382C", Offset = "0x11D382C", VA = "0x11D382C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x11D3924", Offset = "0x11D3924", VA = "0x11D3924")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x11D39C0", Offset = "0x11D39C0", VA = "0x11D39C0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x11D3A5C", Offset = "0x11D3A5C", VA = "0x11D3A5C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x11D3AE8", Offset = "0x11D3AE8", VA = "0x11D3AE8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x11D3BE4", Offset = "0x11D3BE4", VA = "0x11D3BE4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x11D3D0C", Offset = "0x11D3D0C", VA = "0x11D3D0C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x11D3E60", Offset = "0x11D3E60", VA = "0x11D3E60")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x11D42B8", Offset = "0x11D42B8", VA = "0x11D42B8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x11D45A0", Offset = "0x11D45A0", VA = "0x11D45A0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x11D49C4", Offset = "0x11D49C4", VA = "0x11D49C4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x11D4E10", Offset = "0x11D4E10", VA = "0x11D4E10")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x11D4E78", Offset = "0x11D4E78", VA = "0x11D4E78")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x11D4F80", Offset = "0x11D4F80", VA = "0x11D4F80")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x11D510C", Offset = "0x11D510C", VA = "0x11D510C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x11D52FC", Offset = "0x11D52FC", VA = "0x11D52FC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x11D5838", Offset = "0x11D5838", VA = "0x11D5838")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x11D4B28", Offset = "0x11D4B28", VA = "0x11D4B28")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x11D59D4", Offset = "0x11D59D4", VA = "0x11D59D4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x11D65B4", Offset = "0x11D65B4", VA = "0x11D65B4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x11D65DC", Offset = "0x11D65DC", VA = "0x11D65DC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x11D6604", Offset = "0x11D6604", VA = "0x11D6604")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x11D662C", Offset = "0x11D662C", VA = "0x11D662C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x11D66B4", Offset = "0x11D66B4", VA = "0x11D66B4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x11D6828", Offset = "0x11D6828", VA = "0x11D6828")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x11D6960", Offset = "0x11D6960", VA = "0x11D6960")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x11D6C00", Offset = "0x11D6C00", VA = "0x11D6C00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x11D6D24", Offset = "0x11D6D24", VA = "0x11D6D24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x11D70B4", Offset = "0x11D70B4", VA = "0x11D70B4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x11D620C", Offset = "0x11D620C", VA = "0x11D620C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x11D71FC", Offset = "0x11D71FC", VA = "0x11D71FC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x11D73BC", Offset = "0x11D73BC", VA = "0x11D73BC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x11D74B4", Offset = "0x11D74B4", VA = "0x11D74B4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x11D761C", Offset = "0x11D761C", VA = "0x11D761C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x11D7644", Offset = "0x11D7644", VA = "0x11D7644")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x11D2E24", Offset = "0x11D2E24", VA = "0x11D2E24")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x11D4140", Offset = "0x11D4140", VA = "0x11D4140")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x11D7D14", Offset = "0x11D7D14", VA = "0x11D7D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3241F0", Offset = "0x3241F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x11D7D74", Offset = "0x11D7D74", VA = "0x11D7D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324224", Offset = "0x324224")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x11D7DD4", Offset = "0x11D7DD4", VA = "0x11D7DD4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319CD0", Offset = "0x319CD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319CD0", Offset = "0x319CD0")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Multiplier
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321328", Offset = "0x321328")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32138C", Offset = "0x32138C")]
			public float multiplier;

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x16CC7EC", Offset = "0x16CC7EC", VA = "0x16CC7EC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CE6C", Offset = "0x31CE6C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CEB8", Offset = "0x31CEB8")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CEEC", Offset = "0x31CEEC")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CF20", Offset = "0x31CF20")]
		public Transform pivot;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CF54", Offset = "0x31CF54")]
		public Vector3 twistAxis;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CFBC", Offset = "0x31CFBC")]
		public float twistWeight;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31CFF0", Offset = "0x31CFF0")]
		public float swingWeight;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D024", Offset = "0x31D024")]
		public bool rotateOnce;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Transform lastPivot;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x16CB9EC", Offset = "0x16CB9EC", VA = "0x16CB9EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324258", Offset = "0x324258")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x16CBA4C", Offset = "0x16CBA4C", VA = "0x16CBA4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32428C", Offset = "0x32428C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x16CBAAC", Offset = "0x16CBAAC", VA = "0x16CBAAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3242C0", Offset = "0x3242C0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x16CBB0C", Offset = "0x16CBB0C", VA = "0x16CBB0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3242F4", Offset = "0x3242F4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x16CBB6C", Offset = "0x16CBB6C", VA = "0x16CBB6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324328", Offset = "0x324328")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x16CBBCC", Offset = "0x16CBBCC", VA = "0x16CBBCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32435C", Offset = "0x32435C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x16CBC2C", Offset = "0x16CBC2C", VA = "0x16CBC2C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x16CBD1C", Offset = "0x16CBD1C", VA = "0x16CBD1C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x16CBDF8", Offset = "0x16CBDF8", VA = "0x16CBDF8")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x16CC678", Offset = "0x16CC678", VA = "0x16CC678")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324390", Offset = "0x324390")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x16CC6D8", Offset = "0x16CC6D8", VA = "0x16CC6D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3243C4", Offset = "0x3243C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x16CC738", Offset = "0x16CC738", VA = "0x16CC738")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319D30", Offset = "0x319D30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319D30", Offset = "0x319D30")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3213DC", Offset = "0x3213DC")]
			public bool use;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321410", Offset = "0x321410")]
			public Vector2 offset;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321444", Offset = "0x321444")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x321444", Offset = "0x321444")]
			public float angleOffset;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3214C8", Offset = "0x3214C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3214C8", Offset = "0x3214C8")]
			public float maxAngle;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32151C", Offset = "0x32151C")]
			public float radius;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321550", Offset = "0x321550")]
			public bool orbit;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321584", Offset = "0x321584")]
			public bool fixYAxis;

			[Token(Token = "0x1700009C")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x16CD4F8", Offset = "0x16CD4F8", VA = "0x16CD4F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x16CD534", Offset = "0x16CD534", VA = "0x16CD534")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x16CD64C", Offset = "0x16CD64C", VA = "0x16CD64C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x16CDF7C", Offset = "0x16CDF7C", VA = "0x16CDF7C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3215B8", Offset = "0x3215B8")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3215EC", Offset = "0x3215EC")]
			public Vector3 direction;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321620", Offset = "0x321620")]
			public float maxDistance;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321680", Offset = "0x321680")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x321680", Offset = "0x321680")]
			public float maxAngle;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3216D4", Offset = "0x3216D4")]
			public bool fixYAxis;

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x16CCE54", Offset = "0x16CCE54", VA = "0x16CCE54")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x16CD090", Offset = "0x16CD090", VA = "0x16CD090")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x16CD428", Offset = "0x16CD428", VA = "0x16CD428")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322B38", Offset = "0x322B38")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000731")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322B8C", Offset = "0x322B8C")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600071C")]
				[Address(RVA = "0x16CDFA8", Offset = "0x16CDFA8", VA = "0x16CDFA8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321768", Offset = "0x321768")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3217CC", Offset = "0x3217CC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321834", Offset = "0x321834")]
			public Interaction[] interactions;

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x16CCC34", Offset = "0x16CCC34", VA = "0x16CCC34")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x16CDF98", Offset = "0x16CDF98", VA = "0x16CDF98")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D058", Offset = "0x31D058")]
		public Range[] ranges;

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x16CC7F4", Offset = "0x16CC7F4", VA = "0x16CC7F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3243F8", Offset = "0x3243F8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x16CC854", Offset = "0x16CC854", VA = "0x16CC854")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32442C", Offset = "0x32442C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x16CC8B4", Offset = "0x16CC8B4", VA = "0x16CC8B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324460", Offset = "0x324460")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x16CC914", Offset = "0x16CC914", VA = "0x16CC914")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x16CC918", Offset = "0x16CC918", VA = "0x16CC918")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x16CCDE0", Offset = "0x16CCDE0", VA = "0x16CCDE0")]
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
			[Address(RVA = "0xF6B460", Offset = "0xF6B460", VA = "0xF6B460")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xF6B9B8", Offset = "0xF6B9B8", VA = "0xF6B9B8")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xF6B930", Offset = "0xF6B930", VA = "0xF6B930")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xF6B684", Offset = "0xF6B684", VA = "0xF6B684")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Map[] maps;

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xF6B094", Offset = "0xF6B094", VA = "0xF6B094", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324494", Offset = "0x324494")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xF6B51C", Offset = "0xF6B51C", VA = "0xF6B51C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xF6B520", Offset = "0xF6B520", VA = "0xF6B520", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF6B8A4", Offset = "0xF6B8A4", VA = "0xF6B8A4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xF6B490", Offset = "0xF6B490", VA = "0xF6B490")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xF6B3AC", Offset = "0xF6B3AC", VA = "0xF6B3AC")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xF6BA3C", Offset = "0xF6BA3C", VA = "0xF6BA3C")]
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
		[Address(RVA = "0x13AC8B8", Offset = "0x13AC8B8", VA = "0x13AC8B8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x13AC9A0", Offset = "0x13AC9A0", VA = "0x13AC9A0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x13ACC5C", Offset = "0x13ACC5C", VA = "0x13ACC5C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x13ACE00", Offset = "0x13ACE00", VA = "0x13ACE00", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x13ACA10", Offset = "0x13ACA10", VA = "0x13ACA10")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x13AD370", Offset = "0x13AD370", VA = "0x13AD370")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D08C", Offset = "0x31D08C")]
		public float weight;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D0A4", Offset = "0x31D0A4")]
		public float localRotationWeight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D0BC", Offset = "0x31D0BC")]
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
		[Address(RVA = "0x16CFF74", Offset = "0x16CFF74", VA = "0x16CFF74", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x16CFFC4", Offset = "0x16CFFC4", VA = "0x16CFFC4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x16CFFFC", Offset = "0x16CFFFC", VA = "0x16CFFFC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x16D0018", Offset = "0x16D0018", VA = "0x16D0018")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x319D90", Offset = "0x319D90")]
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
			[Address(RVA = "0x16D07D8", Offset = "0x16D07D8", VA = "0x16D07D8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x16D1958", Offset = "0x16D1958", VA = "0x16D1958")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x16D1630", Offset = "0x16D1630", VA = "0x16D1630")]
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
			[Address(RVA = "0x16D09DC", Offset = "0x16D09DC", VA = "0x16D09DC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x16D1B98", Offset = "0x16D1B98", VA = "0x16D1B98")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x16D1B14", Offset = "0x16D1B14", VA = "0x16D1B14")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A6E4", Offset = "0x31A6E4")]
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
				[Address(RVA = "0x16D2410", Offset = "0x16D2410", VA = "0x16D2410", Slot = "4")]
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
				[Address(RVA = "0x16D24A0", Offset = "0x16D24A0", VA = "0x16D24A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x16D0A6C", Offset = "0x16D0A6C", VA = "0x16D0A6C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x16D2090", Offset = "0x16D2090", VA = "0x16D2090", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x16D2094", Offset = "0x16D2094", VA = "0x16D2094", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x16D2418", Offset = "0x16D2418", VA = "0x16D2418", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D0D4", Offset = "0x31D0D4")]
		public IK ik;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D108", Offset = "0x31D108")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D170", Offset = "0x31D170")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D1DC", Offset = "0x31D1DC")]
		public float applyVelocity;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D240", Offset = "0x31D240")]
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
			[Address(RVA = "0x16D0074", Offset = "0x16D0074", VA = "0x16D0074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		private bool ikUsed
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x16D0FD8", Offset = "0x16D0FD8", VA = "0x16D0FD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x16D0044", Offset = "0x16D0044", VA = "0x16D0044")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x16D011C", Offset = "0x16D011C", VA = "0x16D011C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x16D0260", Offset = "0x16D0260", VA = "0x16D0260")]
		public void Start()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x16D01D4", Offset = "0x16D01D4", VA = "0x16D01D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3244D0", Offset = "0x3244D0")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x16D0A8C", Offset = "0x16D0A8C", VA = "0x16D0A8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x16D0E60", Offset = "0x16D0E60", VA = "0x16D0E60")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x16D0F10", Offset = "0x16D0F10", VA = "0x16D0F10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x16D11E4", Offset = "0x16D11E4", VA = "0x16D11E4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x16D0FA4", Offset = "0x16D0FA4", VA = "0x16D0FA4")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x16D11B0", Offset = "0x16D11B0", VA = "0x16D11B0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x16D1278", Offset = "0x16D1278", VA = "0x16D1278")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x16D1208", Offset = "0x16D1208", VA = "0x16D1208")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x16D0164", Offset = "0x16D0164", VA = "0x16D0164")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x16D0E98", Offset = "0x16D0E98", VA = "0x16D0E98")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x16D1DE4", Offset = "0x16D1DE4", VA = "0x16D1DE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x16D1FA0", Offset = "0x16D1FA0", VA = "0x16D1FA0")]
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
			[Address(RVA = "0x16D4914", Offset = "0x16D4914", VA = "0x16D4914")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x16D4950", Offset = "0x16D4950", VA = "0x16D4950")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x16D4498", Offset = "0x16D4498", VA = "0x16D4498")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x16D44F8", Offset = "0x16D44F8", VA = "0x16D44F8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x16D4830", Offset = "0x16D4830", VA = "0x16D4830")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x16D48E4", Offset = "0x16D48E4", VA = "0x16D48E4")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003DF")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x16D4714", Offset = "0x16D4714", VA = "0x16D4714")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x16D4A24", Offset = "0x16D4A24", VA = "0x16D4A24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x16D4A28", Offset = "0x16D4A28", VA = "0x16D4A28")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x16D4A50", Offset = "0x16D4A50", VA = "0x16D4A50")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x16D4B68", Offset = "0x16D4B68", VA = "0x16D4B68")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x16D4E80", Offset = "0x16D4E80", VA = "0x16D4E80")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x16D4F7C", Offset = "0x16D4F7C", VA = "0x16D4F7C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319E08", Offset = "0x319E08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319E08", Offset = "0x319E08")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D284", Offset = "0x31D284")]
		public float limit;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D2A0", Offset = "0x31D2A0")]
		public float twistLimit;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x16D5020", Offset = "0x16D5020", VA = "0x16D5020")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324548", Offset = "0x324548")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x16D5080", Offset = "0x16D5080", VA = "0x16D5080")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32457C", Offset = "0x32457C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x16D50E0", Offset = "0x16D50E0", VA = "0x16D50E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3245B0", Offset = "0x3245B0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x16D5140", Offset = "0x16D5140", VA = "0x16D5140")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3245E4", Offset = "0x3245E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x16D51A0", Offset = "0x16D51A0", VA = "0x16D51A0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x16D5240", Offset = "0x16D5240", VA = "0x16D5240")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x16D5534", Offset = "0x16D5534", VA = "0x16D5534")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319EA0", Offset = "0x319EA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319EA0", Offset = "0x319EA0")]
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
		[Address(RVA = "0x16D5550", Offset = "0x16D5550", VA = "0x16D5550")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324618", Offset = "0x324618")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x16D55B0", Offset = "0x16D55B0", VA = "0x16D55B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32464C", Offset = "0x32464C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x16D5610", Offset = "0x16D5610", VA = "0x16D5610")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324680", Offset = "0x324680")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x16D5670", Offset = "0x16D5670", VA = "0x16D5670")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3246B4", Offset = "0x3246B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x16D56D0", Offset = "0x16D56D0", VA = "0x16D56D0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x16D571C", Offset = "0x16D571C", VA = "0x16D571C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x16D5AC4", Offset = "0x16D5AC4", VA = "0x16D5AC4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319F38", Offset = "0x319F38")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319F38", Offset = "0x319F38")]
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
				[Address(RVA = "0x16D8624", Offset = "0x16D8624", VA = "0x16D8624")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A1")]
			public Vector3 a
			{
				[Token(Token = "0x6000699")]
				[Address(RVA = "0x16D8674", Offset = "0x16D8674", VA = "0x16D8674")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A2")]
			public Vector3 b
			{
				[Token(Token = "0x600069A")]
				[Address(RVA = "0x16D86C4", Offset = "0x16D86C4", VA = "0x16D86C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A3")]
			public Vector3 c
			{
				[Token(Token = "0x600069B")]
				[Address(RVA = "0x16D8714", Offset = "0x16D8714", VA = "0x16D8714")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A4")]
			public bool isValid
			{
				[Token(Token = "0x600069D")]
				[Address(RVA = "0x16D72F0", Offset = "0x16D72F0", VA = "0x16D72F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x16D7BB8", Offset = "0x16D7BB8", VA = "0x16D7BB8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x16D7DAC", Offset = "0x16D7DAC", VA = "0x16D7DAC")]
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
			[Address(RVA = "0x16D7308", Offset = "0x16D7308", VA = "0x16D7308")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D2CC", Offset = "0x31D2CC")]
		public float twistLimit;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D2E8", Offset = "0x31D2E8")]
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
		[Address(RVA = "0x16D5B8C", Offset = "0x16D5B8C", VA = "0x16D5B8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3246E8", Offset = "0x3246E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x16D5BEC", Offset = "0x16D5BEC", VA = "0x16D5BEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x32471C", Offset = "0x32471C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x16D5C4C", Offset = "0x16D5C4C", VA = "0x16D5C4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324750", Offset = "0x324750")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x16D5CAC", Offset = "0x16D5CAC", VA = "0x16D5CAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324784", Offset = "0x324784")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x16D5D0C", Offset = "0x16D5D0C", VA = "0x16D5D0C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x16D6428", Offset = "0x16D6428", VA = "0x16D6428", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x16D6500", Offset = "0x16D6500", VA = "0x16D6500")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x16D6D84", Offset = "0x16D6D84", VA = "0x16D6D84")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x16D5DB4", Offset = "0x16D5DB4", VA = "0x16D5DB4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x16D73B0", Offset = "0x16D73B0", VA = "0x16D73B0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x16D7FA4", Offset = "0x16D7FA4", VA = "0x16D7FA4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x16D7FEC", Offset = "0x16D7FEC", VA = "0x16D7FEC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x16D8154", Offset = "0x16D8154", VA = "0x16D8154")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x16D6920", Offset = "0x16D6920", VA = "0x16D6920")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x16D8300", Offset = "0x16D8300", VA = "0x16D8300")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x16D85A8", Offset = "0x16D85A8", VA = "0x16D85A8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x319F98", Offset = "0x319F98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x319F98", Offset = "0x319F98")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D394", Offset = "0x31D394")]
		public float twistLimit;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x16D8764", Offset = "0x16D8764", VA = "0x16D8764")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3247B8", Offset = "0x3247B8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x16D87C4", Offset = "0x16D87C4", VA = "0x16D87C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3247EC", Offset = "0x3247EC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x16D8824", Offset = "0x16D8824", VA = "0x16D8824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324820", Offset = "0x324820")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x16D8884", Offset = "0x16D8884", VA = "0x16D8884")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324854", Offset = "0x324854")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x16D88E4", Offset = "0x16D88E4", VA = "0x16D88E4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x16D8918", Offset = "0x16D8918", VA = "0x16D8918", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x16D89B8", Offset = "0x16D89B8", VA = "0x16D89B8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x16D8DFC", Offset = "0x16D8DFC", VA = "0x16D8DFC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D3E0", Offset = "0x31D3E0")]
		public AimIK ik;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D414", Offset = "0x31D414")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D414", Offset = "0x31D414")]
		public float weight;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31D47C", Offset = "0x31D47C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D47C", Offset = "0x31D47C")]
		public Transform target;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D4E8", Offset = "0x31D4E8")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D53C", Offset = "0x31D53C")]
		public float weightSmoothTime;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31D59C", Offset = "0x31D59C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D59C", Offset = "0x31D59C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D610", Offset = "0x31D610")]
		public float maxRadiansDelta;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D644", Offset = "0x31D644")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D6B0", Offset = "0x31D6B0")]
		public float slerpSpeed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D704", Offset = "0x31D704")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D738", Offset = "0x31D738")]
		public float minDistance;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D76C", Offset = "0x31D76C")]
		public Vector3 offset;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31D7A0", Offset = "0x31D7A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D7A0", Offset = "0x31D7A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31D7A0", Offset = "0x31D7A0")]
		public float maxRootAngle;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31D824", Offset = "0x31D824")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D824", Offset = "0x31D824")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D884", Offset = "0x31D884")]
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
			[Address(RVA = "0xF575D4", Offset = "0xF575D4", VA = "0xF575D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xF5747C", Offset = "0xF5747C", VA = "0xF5747C")]
		private void Start()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xF57768", Offset = "0xF57768", VA = "0xF57768")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xF58260", Offset = "0xF58260", VA = "0xF58260")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xF58460", Offset = "0xF58460", VA = "0xF58460")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xF5886C", Offset = "0xF5886C", VA = "0xF5886C")]
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
			[Address(RVA = "0xF58D30", Offset = "0xF58D30", VA = "0xF58D30")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xF59184", Offset = "0xF59184", VA = "0xF59184")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xF5920C", Offset = "0xF5920C", VA = "0xF5920C")]
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
		[Address(RVA = "0xF58BD0", Offset = "0xF58BD0", VA = "0xF58BD0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF590A8", Offset = "0xF590A8", VA = "0xF590A8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF5918C", Offset = "0xF5918C", VA = "0xF5918C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322BD8", Offset = "0x322BD8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000733")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322C0C", Offset = "0x322C0C")]
				public float weight;

				[Token(Token = "0x600071D")]
				[Address(RVA = "0xF59AA8", Offset = "0xF59AA8", VA = "0xF59AA8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32189C", Offset = "0x32189C")]
			public Transform transform;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3218F4", Offset = "0x3218F4")]
			public Transform relativeTo;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321960", Offset = "0x321960")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321994", Offset = "0x321994")]
			public float verticalWeight;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3219FC", Offset = "0x3219FC")]
			public float horizontalWeight;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321A30", Offset = "0x321A30")]
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
			[Address(RVA = "0xF593B4", Offset = "0xF593B4", VA = "0xF593B4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xF59A54", Offset = "0xF59A54", VA = "0xF59A54")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xF59A88", Offset = "0xF59A88", VA = "0xF59A88")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D8B8", Offset = "0x31D8B8")]
		public Body[] bodies;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF59234", Offset = "0xF59234", VA = "0xF59234", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF59A4C", Offset = "0xF59A4C", VA = "0xF59A4C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D8FC", Offset = "0x31D8FC")]
		public float tiltSpeed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D93C", Offset = "0x31D93C")]
		public float tiltSensitivity;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D980", Offset = "0x31D980")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D9B4", Offset = "0x31D9B4")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float tiltAngle;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF5B900", Offset = "0xF5B900", VA = "0xF5B900", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF5B95C", Offset = "0xF5B95C", VA = "0xF5B95C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xF5BC34", Offset = "0xF5BC34", VA = "0xF5BC34")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321A88", Offset = "0x321A88")]
			public string name;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321ABC", Offset = "0x321ABC")]
			public Collider collider;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321AF0", Offset = "0x321AF0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321B38", Offset = "0x321B38")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321B48", Offset = "0x321B48")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321B58", Offset = "0x321B58")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321B68", Offset = "0x321B68")]
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
				[Address(RVA = "0x13AD470", Offset = "0x13AD470", VA = "0x13AD470")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A6")]
			protected float crossFader
			{
				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x13ADB44", Offset = "0x13ADB44", VA = "0x13ADB44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324EE0", Offset = "0x324EE0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006A8")]
				[Address(RVA = "0x13ADB4C", Offset = "0x13ADB4C", VA = "0x13ADB4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324EF0", Offset = "0x324EF0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected float timer
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x13ADB3C", Offset = "0x13ADB3C", VA = "0x13ADB3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F00", Offset = "0x324F00")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x13ADB54", Offset = "0x13ADB54", VA = "0x13ADB54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F10", Offset = "0x324F10")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 force
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x13ADB5C", Offset = "0x13ADB5C", VA = "0x13ADB5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F20", Offset = "0x324F20")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x13ADB70", Offset = "0x13ADB70", VA = "0x13ADB70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F30", Offset = "0x324F30")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 point
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x13ADB7C", Offset = "0x13ADB7C", VA = "0x13ADB7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F40", Offset = "0x324F40")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x13ADB90", Offset = "0x13ADB90", VA = "0x13ADB90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F50", Offset = "0x324F50")]
				private set
				{
				}
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x13AD9DC", Offset = "0x13AD9DC", VA = "0x13AD9DC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x13AD5B4", Offset = "0x13AD5B4", VA = "0x13AD5B4")]
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
			[Address(RVA = "0x13ADB9C", Offset = "0x13ADB9C", VA = "0x13ADB9C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322C40", Offset = "0x322C40")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000735")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322C74", Offset = "0x322C74")]
				public float weight;

				[Token(Token = "0x4000736")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x4000737")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x600071E")]
				[Address(RVA = "0x13AE82C", Offset = "0x13AE82C", VA = "0x13AE82C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600071F")]
				[Address(RVA = "0x13AE588", Offset = "0x13AE588", VA = "0x13AE588")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000720")]
				[Address(RVA = "0x13AEC28", Offset = "0x13AEC28", VA = "0x13AEC28")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321B78", Offset = "0x321B78")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321BAC", Offset = "0x321BAC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321BE0", Offset = "0x321BE0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x13AE2C8", Offset = "0x13AE2C8", VA = "0x13AE2C8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x13AE510", Offset = "0x13AE510", VA = "0x13AE510", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x13AE59C", Offset = "0x13AE59C", VA = "0x13AE59C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x13AE9D0", Offset = "0x13AE9D0", VA = "0x13AE9D0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322CA8", Offset = "0x322CA8")]
				public Transform bone;

				[Token(Token = "0x4000739")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322CDC", Offset = "0x322CDC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x322CDC", Offset = "0x322CDC")]
				public float weight;

				[Token(Token = "0x400073A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x400073B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000721")]
				[Address(RVA = "0x13AE028", Offset = "0x13AE028", VA = "0x13AE028")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000722")]
				[Address(RVA = "0x13ADD0C", Offset = "0x13ADD0C", VA = "0x13ADD0C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000723")]
				[Address(RVA = "0x13AE200", Offset = "0x13AE200", VA = "0x13AE200")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321C38", Offset = "0x321C38")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321C6C", Offset = "0x321C6C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x13ADBB0", Offset = "0x13ADBB0", VA = "0x13ADBB0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x13ADC94", Offset = "0x13ADC94", VA = "0x13ADC94", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x13ADD20", Offset = "0x13ADD20", VA = "0x13ADD20", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x13AE1EC", Offset = "0x13AE1EC", VA = "0x13AE1EC")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31D9E8", Offset = "0x31D9E8")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DA1C", Offset = "0x31DA1C")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000057")]
		public bool inProgress
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x13AD378", Offset = "0x13AD378", VA = "0x13AD378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x13AD48C", Offset = "0x13AD48C", VA = "0x13AD48C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x13AD720", Offset = "0x13AD720", VA = "0x13AD720")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x13ADB34", Offset = "0x13ADB34", VA = "0x13ADB34")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321CA0", Offset = "0x321CA0")]
			public string name;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321CD4", Offset = "0x321CD4")]
			public Collider collider;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321D08", Offset = "0x321D08")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321D50", Offset = "0x321D50")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321D60", Offset = "0x321D60")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321D70", Offset = "0x321D70")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x321D80", Offset = "0x321D80")]
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
				[Address(RVA = "0x13AF304", Offset = "0x13AF304", VA = "0x13AF304")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F60", Offset = "0x324F60")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x13AF30C", Offset = "0x13AF30C", VA = "0x13AF30C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F70", Offset = "0x324F70")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			protected float timer
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x13AF314", Offset = "0x13AF314", VA = "0x13AF314")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F80", Offset = "0x324F80")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0x13AF31C", Offset = "0x13AF31C", VA = "0x13AF31C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324F90", Offset = "0x324F90")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			protected Vector3 force
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x13AF324", Offset = "0x13AF324", VA = "0x13AF324")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324FA0", Offset = "0x324FA0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x13AF338", Offset = "0x13AF338", VA = "0x13AF338")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324FB0", Offset = "0x324FB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			protected Vector3 point
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x13AF344", Offset = "0x13AF344", VA = "0x13AF344")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324FC0", Offset = "0x324FC0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x13AF358", Offset = "0x13AF358", VA = "0x13AF358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324FD0", Offset = "0x324FD0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x13AF19C", Offset = "0x13AF19C", VA = "0x13AF19C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x13AED50", Offset = "0x13AED50", VA = "0x13AED50")]
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
			[Address(RVA = "0x13AF364", Offset = "0x13AF364", VA = "0x13AF364")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322D2C", Offset = "0x322D2C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400073D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322D60", Offset = "0x322D60")]
				public float weight;

				[Token(Token = "0x400073E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x400073F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x6000724")]
				[Address(RVA = "0x13AFA30", Offset = "0x13AFA30", VA = "0x13AFA30")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000725")]
				[Address(RVA = "0x13AF724", Offset = "0x13AF724", VA = "0x13AF724")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000726")]
				[Address(RVA = "0x13AFBB8", Offset = "0x13AFBB8", VA = "0x13AFBB8")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321D90", Offset = "0x321D90")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321DC4", Offset = "0x321DC4")]
			public int upDirCurveIndex;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321DF8", Offset = "0x321DF8")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x13AF378", Offset = "0x13AF378", VA = "0x13AF378", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x13AF6AC", Offset = "0x13AF6AC", VA = "0x13AF6AC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x13AF738", Offset = "0x13AF738", VA = "0x13AF738", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x13AFB9C", Offset = "0x13AFB9C", VA = "0x13AFB9C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322D94", Offset = "0x322D94")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000741")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322DC8", Offset = "0x322DC8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x322DC8", Offset = "0x322DC8")]
				public float weight;

				[Token(Token = "0x4000742")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x4000743")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000727")]
				[Address(RVA = "0x13B019C", Offset = "0x13B019C", VA = "0x13B019C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000728")]
				[Address(RVA = "0x13AFD9C", Offset = "0x13AFD9C", VA = "0x13AFD9C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000729")]
				[Address(RVA = "0x13B0354", Offset = "0x13B0354", VA = "0x13B0354")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321E58", Offset = "0x321E58")]
			public int curveIndex;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321E8C", Offset = "0x321E8C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x13AFBC0", Offset = "0x13AFBC0", VA = "0x13AFBC0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x13AFD24", Offset = "0x13AFD24", VA = "0x13AFD24", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x13AFDB0", Offset = "0x13AFDB0", VA = "0x13AFDB0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x13B0340", Offset = "0x13B0340", VA = "0x13B0340")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DA50", Offset = "0x31DA50")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DA84", Offset = "0x31DA84")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x13AEC30", Offset = "0x13AEC30", VA = "0x13AEC30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x13AEEC8", Offset = "0x13AEEC8", VA = "0x13AEEC8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x13AF2FC", Offset = "0x13AF2FC", VA = "0x13AF2FC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322E18", Offset = "0x322E18")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000745")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322E4C", Offset = "0x322E4C")]
				public float weight;

				[Token(Token = "0x600072A")]
				[Address(RVA = "0x11CC8EC", Offset = "0x11CC8EC", VA = "0x11CC8EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321EC0", Offset = "0x321EC0")]
			public Transform transform;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321F28", Offset = "0x321F28")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321F5C", Offset = "0x321F5C")]
			public float speed;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x321FAC", Offset = "0x321FAC")]
			public float acceleration;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322010", Offset = "0x322010")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x322010", Offset = "0x322010")]
			public float matchVelocity;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322074", Offset = "0x322074")]
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
			[Address(RVA = "0x11CC190", Offset = "0x11CC190", VA = "0x11CC190")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x11CC3AC", Offset = "0x11CC3AC", VA = "0x11CC3AC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x11CC8C4", Offset = "0x11CC8C4", VA = "0x11CC8C4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DAB8", Offset = "0x31DAB8")]
		public Body[] bodies;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DAF8", Offset = "0x31DAF8")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x11CC110", Offset = "0x11CC110", VA = "0x11CC110")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x11CC2D8", Offset = "0x11CC2D8", VA = "0x11CC2D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x11CC8BC", Offset = "0x11CC8BC", VA = "0x11CC8BC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3220BC", Offset = "0x3220BC")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322114", Offset = "0x322114")]
			public float spring;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322148", Offset = "0x322148")]
			public bool x;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32217C", Offset = "0x32217C")]
			public bool y;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3221B0", Offset = "0x3221B0")]
			public bool z;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3221E4", Offset = "0x3221E4")]
			public float minX;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322218", Offset = "0x322218")]
			public float maxX;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32224C", Offset = "0x32224C")]
			public float minY;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322280", Offset = "0x322280")]
			public float maxY;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3222B4", Offset = "0x3222B4")]
			public float minZ;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3222E8", Offset = "0x3222E8")]
			public float maxZ;

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x16CE958", Offset = "0x16CE958", VA = "0x16CE958")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x16CF0A4", Offset = "0x16CF0A4", VA = "0x16CF0A4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x16CF100", Offset = "0x16CF100", VA = "0x16CF100")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x16CF204", Offset = "0x16CF204", VA = "0x16CF204")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A6F4", Offset = "0x31A6F4")]
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
				[Address(RVA = "0x16CF00C", Offset = "0x16CF00C", VA = "0x16CF00C", Slot = "4")]
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
				[Address(RVA = "0x16CF09C", Offset = "0x16CF09C", VA = "0x16CF09C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x16CE6EC", Offset = "0x16CE6EC", VA = "0x16CE6EC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x16CEE0C", Offset = "0x16CEE0C", VA = "0x16CEE0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x16CEE10", Offset = "0x16CEE10", VA = "0x16CEE10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x16CF014", Offset = "0x16CF014", VA = "0x16CF014", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DB40", Offset = "0x31DB40")]
		public float weight;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DB74", Offset = "0x31DB74")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected float lastTime;

		[Token(Token = "0x17000058")]
		protected float deltaTime
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x16CE614", Offset = "0x16CE614", VA = "0x16CE614")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000426")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x16CE63C", Offset = "0x16CE63C", VA = "0x16CE63C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x16CE660", Offset = "0x16CE660", VA = "0x16CE660")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x324888", Offset = "0x324888")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x16CE70C", Offset = "0x16CE70C", VA = "0x16CE70C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x16CE854", Offset = "0x16CE854", VA = "0x16CE854")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x16CEC54", Offset = "0x16CEC54", VA = "0x16CEC54", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x16CEDFC", Offset = "0x16CEDFC", VA = "0x16CEDFC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A704", Offset = "0x31A704")]
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
				[Address(RVA = "0x16CF804", Offset = "0x16CF804", VA = "0x16CF804", Slot = "4")]
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
				[Address(RVA = "0x16CF894", Offset = "0x16CF894", VA = "0x16CF894", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x16CF2E4", Offset = "0x16CF2E4", VA = "0x16CF2E4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x16CF604", Offset = "0x16CF604", VA = "0x16CF604", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x16CF608", Offset = "0x16CF608", VA = "0x16CF608", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x16CF80C", Offset = "0x16CF80C", VA = "0x16CF80C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DBC4", Offset = "0x31DBC4")]
		public float weight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DBF8", Offset = "0x31DBF8")]
		public VRIK ik;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float lastTime;

		[Token(Token = "0x17000059")]
		protected float deltaTime
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x16CF20C", Offset = "0x16CF20C", VA = "0x16CF20C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600042E")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x16CF234", Offset = "0x16CF234", VA = "0x16CF234", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x16CF258", Offset = "0x16CF258", VA = "0x16CF258")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x324900", Offset = "0x324900")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x16CF304", Offset = "0x16CF304", VA = "0x16CF304")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x16CF44C", Offset = "0x16CF44C", VA = "0x16CF44C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x16CF5F4", Offset = "0x16CF5F4", VA = "0x16CF5F4")]
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
			[Address(RVA = "0x16CF994", Offset = "0x16CF994", VA = "0x16CF994")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x16CFF6C", Offset = "0x16CFF6C", VA = "0x16CFF6C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x16CF89C", Offset = "0x16CF89C", VA = "0x16CF89C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x16CFE34", Offset = "0x16CFE34", VA = "0x16CFE34")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x16CFEF8", Offset = "0x16CFEF8", VA = "0x16CFEF8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322E80", Offset = "0x322E80")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000747")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322EB4", Offset = "0x322EB4")]
				public float weight;

				[Token(Token = "0x600072B")]
				[Address(RVA = "0x16D4490", Offset = "0x16D4490", VA = "0x16D4490")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32231C", Offset = "0x32231C")]
			public Vector3 offset;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322388", Offset = "0x322388")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x322388", Offset = "0x322388")]
			public float additivity;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3223D8", Offset = "0x3223D8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32242C", Offset = "0x32242C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x16D28F8", Offset = "0x16D28F8", VA = "0x16D28F8")]
			public void Start()
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x16D3A50", Offset = "0x16D3A50", VA = "0x16D3A50")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x16D4474", Offset = "0x16D4474", VA = "0x16D4474")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DC44", Offset = "0x31DC44")]
		public AimIK aimIK;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DC78", Offset = "0x31DC78")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DCAC", Offset = "0x31DCAC")]
		public Handedness handedness;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DCFC", Offset = "0x31DCFC")]
		public bool twoHanded;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DD44", Offset = "0x31DD44")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DD78", Offset = "0x31DD78")]
		public float magnitudeRandom;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DDAC", Offset = "0x31DDAC")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DE18", Offset = "0x31DE18")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DE84", Offset = "0x31DE84")]
		public float blendTime;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x31DEF0", Offset = "0x31DEF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DEF0", Offset = "0x31DEF0")]
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
			[Address(RVA = "0x16D2618", Offset = "0x16D2618", VA = "0x16D2618")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x16D3DE0", Offset = "0x16D3DE0", VA = "0x16D3DE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x16D3E34", Offset = "0x16D3E34", VA = "0x16D3E34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private Transform primaryHand
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x16D3D90", Offset = "0x16D3D90", VA = "0x16D3D90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x16D3DB8", Offset = "0x16D3DB8", VA = "0x16D3DB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x16D264C", Offset = "0x16D264C", VA = "0x16D264C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x16D26A4", Offset = "0x16D26A4", VA = "0x16D26A4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x16D29E4", Offset = "0x16D29E4", VA = "0x16D29E4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x16D3E88", Offset = "0x16D3E88", VA = "0x16D3E88")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x16D4018", Offset = "0x16D4018", VA = "0x16D4018")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x16D4074", Offset = "0x16D4074", VA = "0x16D4074", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x16D437C", Offset = "0x16D437C", VA = "0x16D437C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DF50", Offset = "0x31DF50")]
		public float weight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DF98", Offset = "0x31DF98")]
		public float offset;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool skip;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x16D8E0C", Offset = "0x16D8E0C", VA = "0x16D8E0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x16D8F88", Offset = "0x16D8F88", VA = "0x16D8F88")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x16D90DC", Offset = "0x16D90DC", VA = "0x16D90DC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x16D978C", Offset = "0x16D978C", VA = "0x16D978C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x16D97F8", Offset = "0x16D97F8", VA = "0x16D97F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x16D99A0", Offset = "0x16D99A0", VA = "0x16D99A0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322488", Offset = "0x322488")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3224DC", Offset = "0x3224DC")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32252C", Offset = "0x32252C")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322560", Offset = "0x322560")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3225C8", Offset = "0x3225C8")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3225FC", Offset = "0x3225FC")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322630", Offset = "0x322630")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322664", Offset = "0x322664")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x3226CC", Offset = "0x3226CC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3226CC", Offset = "0x3226CC")]
			public Vector3 headOffset;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32271C", Offset = "0x32271C")]
			public Vector3 handOffset;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322750", Offset = "0x322750")]
			public float footForwardOffset;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3227B8", Offset = "0x3227B8")]
			public float footInwardOffset;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x32281C", Offset = "0x32281C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x32281C", Offset = "0x32281C")]
			public float footHeadingOffset;

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x16DF2F4", Offset = "0x16DF2F4", VA = "0x16DF2F4")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x16DC744", Offset = "0x16DC744", VA = "0x16DC744")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x16DE660", Offset = "0x16DE660", VA = "0x16DE660")]
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
		[Address(RVA = "0xDFB458", Offset = "0xDFB458", VA = "0xDFB458")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xDFB550", Offset = "0xDFB550", VA = "0xDFB550")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31DFCC", Offset = "0x31DFCC")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xDFB558", Offset = "0xDFB558", VA = "0xDFB558")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xDFB6E8", Offset = "0xDFB6E8", VA = "0xDFB6E8")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E000", Offset = "0x31E000")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E034", Offset = "0x31E034")]
		public AimIK aim;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E068", Offset = "0x31E068")]
		public LookAtIK lookAt;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E09C", Offset = "0x31E09C")]
		public Animator animator;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E0F0", Offset = "0x31E0F0")]
		public float crossfadeTime;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E144", Offset = "0x31E144")]
		public float minAimDistance;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xE13DEC", Offset = "0xE13DEC", VA = "0xE13DEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xE13E44", Offset = "0xE13E44", VA = "0xE13E44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xE14010", Offset = "0xE14010", VA = "0xE14010")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xE142EC", Offset = "0xE142EC", VA = "0xE142EC")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xE1459C", Offset = "0xE1459C", VA = "0xE1459C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xE146AC", Offset = "0xE146AC", VA = "0xE146AC")]
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
		[Address(RVA = "0xF5351C", Offset = "0xF5351C", VA = "0xF5351C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xF53844", Offset = "0xF53844", VA = "0xF53844")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xF53B08", Offset = "0xF53B08", VA = "0xF53B08")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31E198", Offset = "0x31E198")]
		public Animator animator;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BipedIK bipedIK;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31E1CC", Offset = "0x31E1CC")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E200", Offset = "0x31E200")]
		public float lookAtWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E218", Offset = "0x31E218")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E230", Offset = "0x31E230")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E248", Offset = "0x31E248")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E260", Offset = "0x31E260")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E278", Offset = "0x31E278")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E290", Offset = "0x31E290")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31E2A8", Offset = "0x31E2A8")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E2DC", Offset = "0x31E2DC")]
		public float footPositionWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E2F4", Offset = "0x31E2F4")]
		public float footRotationWeight;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x31E30C", Offset = "0x31E30C")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E340", Offset = "0x31E340")]
		public float handPositionWeight;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E358", Offset = "0x31E358")]
		public float handRotationWeight;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xDFE00C", Offset = "0xDFE00C", VA = "0xDFE00C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xDFE958", Offset = "0xDFE958", VA = "0xDFE958")]
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
		[Address(RVA = "0xE0C2C8", Offset = "0xE0C2C8", VA = "0xE0C2C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xE0D064", Offset = "0xE0D064", VA = "0xE0D064")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xE0CC18", Offset = "0xE0CC18", VA = "0xE0CC18")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xE0D2A8", Offset = "0xE0D2A8", VA = "0xE0D2A8")]
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
			[Address(RVA = "0xE0D308", Offset = "0xE0D308", VA = "0xE0D308")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xE0D3B8", Offset = "0xE0D3B8", VA = "0xE0D3B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xE0D728", Offset = "0xE0D728", VA = "0xE0D728")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A714", Offset = "0x31A714")]
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
				[Address(RVA = "0xE0E82C", Offset = "0xE0E82C", VA = "0xE0E82C", Slot = "4")]
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
				[Address(RVA = "0xE0E8BC", Offset = "0xE0E8BC", VA = "0xE0E8BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xE0E38C", Offset = "0xE0E38C", VA = "0xE0E38C")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xE0E3F8", Offset = "0xE0E3F8", VA = "0xE0E3F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xE0E3FC", Offset = "0xE0E3FC", VA = "0xE0E3FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xE0E834", Offset = "0xE0E834", VA = "0xE0E834", Slot = "8")]
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
			[Address(RVA = "0xE0D748", Offset = "0xE0D748", VA = "0xE0D748")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public Vector3 position
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xE0D240", Offset = "0xE0D240", VA = "0xE0D240")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xE0D764", Offset = "0xE0D764", VA = "0xE0D764")]
			set
			{
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xE0D7DC", Offset = "0xE0D7DC", VA = "0xE0D7DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xE0DA7C", Offset = "0xE0DA7C", VA = "0xE0DA7C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xE0DFD8", Offset = "0xE0DFD8", VA = "0xE0DFD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xE0E2A4", Offset = "0xE0E2A4", VA = "0xE0E2A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x324978", Offset = "0x324978")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xE0E3B0", Offset = "0xE0E3B0", VA = "0xE0E3B0")]
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
		[Address(RVA = "0xE0E8C4", Offset = "0xE0E8C4", VA = "0xE0E8C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xE0E9F4", Offset = "0xE0E9F4", VA = "0xE0E9F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xE0ED84", Offset = "0xE0ED84", VA = "0xE0ED84")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3228AC", Offset = "0x3228AC")]
			public int animationLayer;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322908", Offset = "0x322908")]
			public string animationState;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322960", Offset = "0x322960")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3229C8", Offset = "0x3229C8")]
			public Transform warpFrom;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3229FC", Offset = "0x3229FC")]
			public Transform warpTo;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322A48", Offset = "0x322A48")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E370", Offset = "0x31E370")]
		public Animator animator;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E3C8", Offset = "0x31E3C8")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x31E3FC", Offset = "0x31E3FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E3FC", Offset = "0x31E3FC")]
		public Warp[] warps;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EffectorMode lastMode;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xDFB78C", Offset = "0xDFB78C", VA = "0xDFB78C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xDFB7AC", Offset = "0xDFB7AC", VA = "0xDFB7AC")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xDFBAC4", Offset = "0xDFBAC4", VA = "0xDFBAC4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xDFC0D0", Offset = "0xDFC0D0", VA = "0xDFC0D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xDFC198", Offset = "0xDFC198", VA = "0xDFC198")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x319FF8", Offset = "0x319FF8")]
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
		[Address(RVA = "0xDFC1A0", Offset = "0xDFC1A0", VA = "0xDFC1A0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xDFC208", Offset = "0xDFC208", VA = "0xDFC208")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xDFC4B8", Offset = "0xDFC4B8", VA = "0xDFC4B8", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xDFC820", Offset = "0xDFC820", VA = "0xDFC820")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A070", Offset = "0x31A070")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A070", Offset = "0x31A070")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E480", Offset = "0x31E480")]
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
		[Address(RVA = "0xDFC848", Offset = "0xDFC848", VA = "0xDFC848", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xDFCB10", Offset = "0xDFCB10", VA = "0xDFCB10", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xDFCB90", Offset = "0xDFCB90", VA = "0xDFCB90")]
		private void Read()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xDFCDCC", Offset = "0xDFCDCC", VA = "0xDFCDCC")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xDFCE48", Offset = "0xDFCE48", VA = "0xDFCE48")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xDFD7A0", Offset = "0xDFD7A0", VA = "0xDFD7A0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xDFD4C0", Offset = "0xDFD4C0", VA = "0xDFD4C0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xDFDC38", Offset = "0xDFDC38", VA = "0xDFDC38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xDFDDE0", Offset = "0xDFDDE0", VA = "0xDFDDE0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A114", Offset = "0x31A114")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xE00010", Offset = "0xE00010", VA = "0xE00010", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xE00080", Offset = "0xE00080", VA = "0xE00080", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xE003F0", Offset = "0xE003F0", VA = "0xE003F0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xE005E0", Offset = "0xE005E0", VA = "0xE005E0")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A18C", Offset = "0x31A18C")]
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
			[Address(RVA = "0xE01884", Offset = "0xE01884", VA = "0xE01884")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000063")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0xE01934", Offset = "0xE01934", VA = "0xE01934")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xE014E0", Offset = "0xE014E0", VA = "0xE014E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xE0156C", Offset = "0xE0156C", VA = "0xE0156C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xE019E4", Offset = "0xE019E4", VA = "0xE019E4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E4A8", Offset = "0x31E4A8")]
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
		[Address(RVA = "0xE04DAC", Offset = "0xE04DAC", VA = "0xE04DAC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xE05840", Offset = "0xE05840", VA = "0xE05840")]
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
		[Address(RVA = "0xE05848", Offset = "0xE05848", VA = "0xE05848")]
		private void Start()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xE05938", Offset = "0xE05938", VA = "0xE05938")]
		private void Update()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xE060C8", Offset = "0xE060C8", VA = "0xE060C8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xE06218", Offset = "0xE06218", VA = "0xE06218")]
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
			[Address(RVA = "0xE06514", Offset = "0xE06514", VA = "0xE06514")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xE066A8", Offset = "0xE066A8", VA = "0xE066A8")]
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
		[Address(RVA = "0xE062CC", Offset = "0xE062CC", VA = "0xE062CC")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xE065E0", Offset = "0xE065E0", VA = "0xE065E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xE06694", Offset = "0xE06694", VA = "0xE06694")]
		private void Update()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xE06698", Offset = "0xE06698", VA = "0xE06698")]
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
		[Address(RVA = "0xE066B8", Offset = "0xE066B8", VA = "0xE066B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xE06744", Offset = "0xE06744", VA = "0xE06744")]
		private void Update()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xE06894", Offset = "0xE06894", VA = "0xE06894")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E4C0", Offset = "0x31E4C0")]
		public Transform target;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E508", Offset = "0x31E508")]
		public Transform pin;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E53C", Offset = "0x31E53C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E58C", Offset = "0x31E58C")]
		public AimIK aim;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E5C0", Offset = "0x31E5C0")]
		public float weight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E5F4", Offset = "0x31E5F4")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E648", Offset = "0x31E648")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xE0689C", Offset = "0xE0689C", VA = "0xE0689C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xE06904", Offset = "0xE06904", VA = "0xE06904")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xE06BF0", Offset = "0xE06BF0", VA = "0xE06BF0")]
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
		[Address(RVA = "0xE06BF8", Offset = "0xE06BF8", VA = "0xE06BF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xE06D58", Offset = "0xE06D58", VA = "0xE06D58")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xE06E2C", Offset = "0xE06E2C", VA = "0xE06E2C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xE074D8", Offset = "0xE074D8", VA = "0xE074D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE07680", Offset = "0xE07680", VA = "0xE07680")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E6A4", Offset = "0x31E6A4")]
		public float aimWeight;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E6BC", Offset = "0x31E6BC")]
		public float sightWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E6D4", Offset = "0x31E6D4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E760", Offset = "0x31E760")]
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
		[Address(RVA = "0xE07688", Offset = "0xE07688", VA = "0xE07688")]
		private void Start()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE078C4", Offset = "0xE078C4", VA = "0xE078C4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xE078D0", Offset = "0xE078D0", VA = "0xE078D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xE07DA8", Offset = "0xE07DA8", VA = "0xE07DA8")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xE08048", Offset = "0xE08048", VA = "0xE08048")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xE07A28", Offset = "0xE07A28", VA = "0xE07A28")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xE091C4", Offset = "0xE091C4", VA = "0xE091C4")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A204", Offset = "0x31A204")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A204", Offset = "0x31A204")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E798", Offset = "0x31E798")]
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
		[Address(RVA = "0xE091EC", Offset = "0xE091EC", VA = "0xE091EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xE09270", Offset = "0xE09270", VA = "0xE09270")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xE09420", Offset = "0xE09420", VA = "0xE09420")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xE09504", Offset = "0xE09504", VA = "0xE09504")]
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
		[Address(RVA = "0xE09718", Offset = "0xE09718", VA = "0xE09718")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xE0995C", Offset = "0xE0995C", VA = "0xE0995C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xE09A48", Offset = "0xE09A48", VA = "0xE09A48")]
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
		[Address(RVA = "0xE09D98", Offset = "0xE09D98", VA = "0xE09D98")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xE0A010", Offset = "0xE0A010", VA = "0xE0A010")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xE0A630", Offset = "0xE0A630", VA = "0xE0A630")]
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
		[Address(RVA = "0xE0A644", Offset = "0xE0A644", VA = "0xE0A644")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xE0A734", Offset = "0xE0A734", VA = "0xE0A734")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xE0A954", Offset = "0xE0A954", VA = "0xE0A954")]
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
		[Address(RVA = "0xE0A95C", Offset = "0xE0A95C", VA = "0xE0A95C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xE0AEB8", Offset = "0xE0AEB8", VA = "0xE0AEB8")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A2A8", Offset = "0x31A2A8")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E7D0", Offset = "0x31E7D0")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E82C", Offset = "0x31E82C")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xE0AEC0", Offset = "0xE0AEC0", VA = "0xE0AEC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xE0AF28", Offset = "0xE0AF28", VA = "0xE0AF28")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xE0B228", Offset = "0xE0B228", VA = "0xE0B228")]
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
				[Address(RVA = "0xE0C1C4", Offset = "0xE0C1C4", VA = "0xE0C1C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xE0B278", Offset = "0xE0B278", VA = "0xE0B278")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xE0B328", Offset = "0xE0B328", VA = "0xE0B328")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xE0BF30", Offset = "0xE0BF30", VA = "0xE0BF30")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xE0C2A0", Offset = "0xE0C2A0", VA = "0xE0C2A0")]
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
		[Address(RVA = "0xE0B230", Offset = "0xE0B230", VA = "0xE0B230")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xE0B2A8", Offset = "0xE0B2A8", VA = "0xE0B2A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xE0BF20", Offset = "0xE0BF20", VA = "0xE0BF20")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322A94", Offset = "0x322A94")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x322AC8", Offset = "0x322AC8")]
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
			[Address(RVA = "0xE0EFC8", Offset = "0xE0EFC8", VA = "0xE0EFC8")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xE0F2D8", Offset = "0xE0F2D8", VA = "0xE0F2D8")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xE0F334", Offset = "0xE0F334", VA = "0xE0F334")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xE0F58C", Offset = "0xE0F58C", VA = "0xE0F58C")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xE0F8AC", Offset = "0xE0F8AC", VA = "0xE0F8AC")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E88C", Offset = "0x31E88C")]
		public Mode mode;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E8C0", Offset = "0x31E8C0")]
		public Absorber[] absorbers;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E90C", Offset = "0x31E90C")]
		public AnimationCurve falloff;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E940", Offset = "0x31E940")]
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
		[Address(RVA = "0xE0ED8C", Offset = "0xE0ED8C", VA = "0xE0ED8C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xE0EF00", Offset = "0xE0EF00", VA = "0xE0EF00")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xE0F140", Offset = "0xE0F140", VA = "0xE0F140", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xE0F4CC", Offset = "0xE0F4CC", VA = "0xE0F4CC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xE0F6E8", Offset = "0xE0F6E8", VA = "0xE0F6E8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xE0F89C", Offset = "0xE0F89C", VA = "0xE0F89C")]
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
		[Address(RVA = "0xE0F960", Offset = "0xE0F960", VA = "0xE0F960")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xE0FA14", Offset = "0xE0FA14", VA = "0xE0FA14")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xE0FAEC", Offset = "0xE0FAEC", VA = "0xE0FAEC")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xE0FCC8", Offset = "0xE0FCC8", VA = "0xE0FCC8")]
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
			[Address(RVA = "0xE101D8", Offset = "0xE101D8", VA = "0xE101D8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xE0FCDC", Offset = "0xE0FCDC", VA = "0xE0FCDC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xE0FE84", Offset = "0xE0FE84", VA = "0xE0FE84", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xE101D0", Offset = "0xE101D0", VA = "0xE101D0")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A320", Offset = "0x31A320")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E974", Offset = "0x31E974")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31E974", Offset = "0x31E974")]
		public float weight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31E9E0", Offset = "0x31E9E0")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EA44", Offset = "0x31EA44")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EA8C", Offset = "0x31EA8C")]
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
		[Address(RVA = "0xE101E8", Offset = "0xE101E8", VA = "0xE101E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xE106D4", Offset = "0xE106D4", VA = "0xE106D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xE11238", Offset = "0xE11238", VA = "0xE11238")]
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
			[Address(RVA = "0xE114D0", Offset = "0xE114D0", VA = "0xE114D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xE112F0", Offset = "0xE112F0", VA = "0xE112F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004C9")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xE11500", Offset = "0xE11500", VA = "0xE11500")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xE1182C", Offset = "0xE1182C", VA = "0xE1182C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xE11A8C", Offset = "0xE11A8C", VA = "0xE11A8C")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xE11BC0", Offset = "0xE11BC0", VA = "0xE11BC0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xE11D70", Offset = "0xE11D70", VA = "0xE11D70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xE11FF8", Offset = "0xE11FF8", VA = "0xE11FF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xE1236C", Offset = "0xE1236C", VA = "0xE1236C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xE12380", Offset = "0xE12380", VA = "0xE12380", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xE12670", Offset = "0xE12670", VA = "0xE12670")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xE12684", Offset = "0xE12684", VA = "0xE12684", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xE1293C", Offset = "0xE1293C", VA = "0xE1293C")]
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
		[Address(RVA = "0xE133D8", Offset = "0xE133D8", VA = "0xE133D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xE13450", Offset = "0xE13450", VA = "0xE13450")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xE136AC", Offset = "0xE136AC", VA = "0xE136AC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A398", Offset = "0x31A398")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float magnitude;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Recoil recoil;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xE136B4", Offset = "0xE136B4", VA = "0xE136B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xE1371C", Offset = "0xE1371C", VA = "0xE1371C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xE13788", Offset = "0xE13788", VA = "0xE13788")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xE13800", Offset = "0xE13800", VA = "0xE13800")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A724", Offset = "0x31A724")]
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
				[Address(RVA = "0xE13D54", Offset = "0xE13D54", VA = "0xE13D54", Slot = "4")]
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
				[Address(RVA = "0xE13DE4", Offset = "0xE13DE4", VA = "0xE13DE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xE13A30", Offset = "0xE13A30", VA = "0xE13A30")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0xE13A60", Offset = "0xE13A60", VA = "0xE13A60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xE13A64", Offset = "0xE13A64", VA = "0xE13A64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xE13D5C", Offset = "0xE13D5C", VA = "0xE13D5C", Slot = "8")]
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
		[Address(RVA = "0xE13810", Offset = "0xE13810", VA = "0xE13810")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xE13934", Offset = "0xE13934", VA = "0xE13934")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xE1397C", Offset = "0xE1397C", VA = "0xE1397C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3249F0", Offset = "0x3249F0")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xE13A50", Offset = "0xE13A50", VA = "0xE13A50")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A410", Offset = "0x31A410")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A734", Offset = "0x31A734")]
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
				[Address(RVA = "0xF53484", Offset = "0xF53484", VA = "0xF53484", Slot = "4")]
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
				[Address(RVA = "0xF53514", Offset = "0xF53514", VA = "0xF53514", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0xF53288", Offset = "0xF53288", VA = "0xF53288")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0xF532B0", Offset = "0xF532B0", VA = "0xF532B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0xF532B4", Offset = "0xF532B4", VA = "0xF532B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0xF5348C", Offset = "0xF5348C", VA = "0xF5348C", Slot = "8")]
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
		[Address(RVA = "0xF530F0", Offset = "0xF530F0", VA = "0xF530F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xF531FC", Offset = "0xF531FC", VA = "0xF531FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x324A68", Offset = "0x324A68")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xF532A8", Offset = "0xF532A8", VA = "0xF532A8")]
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
			[Address(RVA = "0xF53BFC", Offset = "0xF53BFC", VA = "0xF53BFC")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xF5505C", Offset = "0xF5505C", VA = "0xF5505C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0xF54224", Offset = "0xF54224", VA = "0xF54224")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0xF55140", Offset = "0xF55140", VA = "0xF55140")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0xF5535C", Offset = "0xF5535C", VA = "0xF5535C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0xF55408", Offset = "0xF55408", VA = "0xF55408")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0xF554B4", Offset = "0xF554B4", VA = "0xF554B4")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0xF54D24", Offset = "0xF54D24", VA = "0xF54D24")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0xF55560", Offset = "0xF55560", VA = "0xF55560")]
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
		[Address(RVA = "0xF53B80", Offset = "0xF53B80", VA = "0xF53B80")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xF54190", Offset = "0xF54190", VA = "0xF54190")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xF54C0C", Offset = "0xF54C0C", VA = "0xF54C0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xF55054", Offset = "0xF55054", VA = "0xF55054")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EB74", Offset = "0x31EB74")]
		public Transform to;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EBC8", Offset = "0x31EBC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31EBC8", Offset = "0x31EBC8")]
		public float transferMotion;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 lastPosition;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xF555A8", Offset = "0xF555A8", VA = "0xF555A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xF555F8", Offset = "0xF555F8", VA = "0xF555F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xF557B0", Offset = "0xF557B0", VA = "0xF557B0")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EC34", Offset = "0x31EC34")]
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
		[Address(RVA = "0xF559D8", Offset = "0xF559D8", VA = "0xF559D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xF55CC8", Offset = "0xF55CC8", VA = "0xF55CC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xF56164", Offset = "0xF56164", VA = "0xF56164")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xF56320", Offset = "0xF56320", VA = "0xF56320")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xF564C8", Offset = "0xF564C8", VA = "0xF564C8")]
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
		[Address(RVA = "0xF567A4", Offset = "0xF567A4", VA = "0xF567A4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xF56D98", Offset = "0xF56D98", VA = "0xF56D98")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xF56F88", Offset = "0xF56F88", VA = "0xF56F88")]
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
		[Address(RVA = "0xE09514", Offset = "0xE09514", VA = "0xE09514")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xE09670", Offset = "0xE09670", VA = "0xE09670")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xE09710", Offset = "0xE09710", VA = "0xE09710")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31A744", Offset = "0x31A744")]
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
				[Address(RVA = "0xE13340", Offset = "0xE13340", VA = "0xE13340", Slot = "4")]
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
				[Address(RVA = "0xE133D0", Offset = "0xE133D0", VA = "0xE133D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0xE12E3C", Offset = "0xE12E3C", VA = "0xE12E3C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0xE13120", Offset = "0xE13120", VA = "0xE13120", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0xE13124", Offset = "0xE13124", VA = "0xE13124", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0xE13348", Offset = "0xE13348", VA = "0xE13348", Slot = "8")]
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
		[Address(RVA = "0xE12950", Offset = "0xE12950", VA = "0xE12950")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xE12B40", Offset = "0xE12B40", VA = "0xE12B40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xE12AB4", Offset = "0xE12AB4", VA = "0xE12AB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x324AE0", Offset = "0x324AE0")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xE12E5C", Offset = "0xE12E5C", VA = "0xE12E5C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xE12FA4", Offset = "0xE12FA4", VA = "0xE12FA4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xE130E8", Offset = "0xE130E8", VA = "0xE130E8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31ECC4", Offset = "0x31ECC4")]
		public float weight;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xDFDE54", Offset = "0xDFDE54", VA = "0xDFDE54")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xDFDEE0", Offset = "0xDFDEE0", VA = "0xDFDEE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xDFDFFC", Offset = "0xDFDFFC", VA = "0xDFDFFC")]
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
			[Address(RVA = "0xF55840", Offset = "0xF55840", VA = "0xF55840")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0xF559D0", Offset = "0xF559D0", VA = "0xF559D0")]
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
		[Address(RVA = "0xF557C4", Offset = "0xF557C4", VA = "0xF557C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xF559C8", Offset = "0xF559C8", VA = "0xF559C8")]
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
		[Address(RVA = "0xE09A58", Offset = "0xE09A58", VA = "0xE09A58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xE09C9C", Offset = "0xE09C9C", VA = "0xE09C9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xE09D88", Offset = "0xE09D88", VA = "0xE09D88")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31ECFC", Offset = "0x31ECFC")]
		public VRIK ik;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31ED58", Offset = "0x31ED58")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EDA8", Offset = "0x31EDA8")]
		public Transform headTracker;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EDE0", Offset = "0x31EDE0")]
		public Transform bodyTracker;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EE14", Offset = "0x31EE14")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EE48", Offset = "0x31EE48")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EE7C", Offset = "0x31EE7C")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EEB0", Offset = "0x31EEB0")]
		public Transform rightFootTracker;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xF56FE8", Offset = "0xF56FE8", VA = "0xF56FE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xF57014", Offset = "0xF57014", VA = "0xF57014")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x324B58", Offset = "0x324B58")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xF5705C", Offset = "0xF5705C", VA = "0xF5705C")]
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
		[Address(RVA = "0xF57064", Offset = "0xF57064", VA = "0xF57064")]
		private void Start()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xF570FC", Offset = "0xF570FC", VA = "0xF570FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xF573D0", Offset = "0xF573D0", VA = "0xF573D0")]
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
			[Address(RVA = "0xDFE9BC", Offset = "0xDFE9BC", VA = "0xDFE9BC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xDFE97C", Offset = "0xDFE97C", VA = "0xDFE97C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xDFE9C4", Offset = "0xDFE9C4", VA = "0xDFE9C4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xDFEABC", Offset = "0xDFEABC", VA = "0xDFEABC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xDFEE40", Offset = "0xDFEE40", VA = "0xDFEE40", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xDFF1B4", Offset = "0xDFF1B4", VA = "0xDFF1B4", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xDFEE50", Offset = "0xDFEE50", VA = "0xDFEE50")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xDFF1C4", Offset = "0xDFF1C4", VA = "0xDFF1C4")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A488", Offset = "0x31A488")]
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
		[Address(RVA = "0xDFF1E0", Offset = "0xDFF1E0", VA = "0xDFF1E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xDFF250", Offset = "0xDFF250", VA = "0xDFF250", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xDFF3A8", Offset = "0xDFF3A8", VA = "0xDFF3A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xDFF5B8", Offset = "0xDFF5B8", VA = "0xDFF5B8")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A500", Offset = "0x31A500")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x31EF44", Offset = "0x31EF44")]
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
			[Address(RVA = "0xDFF6BC", Offset = "0xDFF6BC", VA = "0xDFF6BC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xDFF5D4", Offset = "0xDFF5D4", VA = "0xDFF5D4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xDFF688", Offset = "0xDFF688", VA = "0xDFF688", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xDFF7F4", Offset = "0xDFF7F4", VA = "0xDFF7F4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xDFFDC4", Offset = "0xDFFDC4", VA = "0xDFFDC4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xDFFFD0", Offset = "0xDFFFD0", VA = "0xDFFFD0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A578", Offset = "0x31A578")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A578", Offset = "0x31A578")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31EF84", Offset = "0x31EF84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EF84", Offset = "0x31EF84")]
		public Transform gravityTarget;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31EFEC", Offset = "0x31EFEC")]
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
		[Address(RVA = "0xE00620", Offset = "0xE00620", VA = "0xE00620")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE007E0", Offset = "0xE007E0", VA = "0xE007E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE00A24", Offset = "0xE00A24", VA = "0xE00A24", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xE00D6C", Offset = "0xE00D6C", VA = "0xE00D6C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xE00E64", Offset = "0xE00E64", VA = "0xE00E64")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xE010D8", Offset = "0xE010D8", VA = "0xE010D8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xE012FC", Offset = "0xE012FC", VA = "0xE012FC")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xE01330", Offset = "0xE01330", VA = "0xE01330")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xE01364", Offset = "0xE01364", VA = "0xE01364")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xE014A8", Offset = "0xE014A8", VA = "0xE014A8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31F084", Offset = "0x31F084")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CameraController cam;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31F0B8", Offset = "0x31F0B8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31F0F0", Offset = "0x31F0F0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float turnSpeed;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31F124", Offset = "0x31F124")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31F164", Offset = "0x31F164")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31F1B4", Offset = "0x31F1B4")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F1EC", Offset = "0x31F1EC")]
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
			[Address(RVA = "0xE019EC", Offset = "0xE019EC", VA = "0xE019EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324B90", Offset = "0x324B90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xE019F4", Offset = "0xE019F4", VA = "0xE019F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324BA0", Offset = "0x324BA0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xE019FC", Offset = "0xE019FC", VA = "0xE019FC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xE01BC8", Offset = "0xE01BC8", VA = "0xE01BC8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xE01C5C", Offset = "0xE01C5C", VA = "0xE01C5C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xE01DA8", Offset = "0xE01DA8", VA = "0xE01DA8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xE031E4", Offset = "0xE031E4", VA = "0xE031E4", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xE03678", Offset = "0xE03678", VA = "0xE03678", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xE024CC", Offset = "0xE024CC", VA = "0xE024CC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xE037C4", Offset = "0xE037C4", VA = "0xE037C4")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xE03FDC", Offset = "0xE03FDC", VA = "0xE03FDC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xE032F0", Offset = "0xE032F0", VA = "0xE032F0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xE040A0", Offset = "0xE040A0", VA = "0xE040A0", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xE0466C", Offset = "0xE0466C", VA = "0xE0466C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xE04950", Offset = "0xE04950", VA = "0xE04950", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xE02C74", Offset = "0xE02C74", VA = "0xE02C74")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xE04BE8", Offset = "0xE04BE8", VA = "0xE04BE8")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x31A61C", Offset = "0x31A61C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F1FC", Offset = "0x31F1FC")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F264", Offset = "0x31F264")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F2C0", Offset = "0x31F2C0")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F310", Offset = "0x31F310")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F358", Offset = "0x31F358")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F3B4", Offset = "0x31F3B4")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x31F428", Offset = "0x31F428")]
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
			[Address(RVA = "0xF523A0", Offset = "0xF523A0", VA = "0xF523A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324BB0", Offset = "0x324BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF523A8", Offset = "0xF523A8", VA = "0xF523A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x324BC0", Offset = "0x324BC0")]
			private set
			{
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xF523B0", Offset = "0xF523B0", VA = "0xF523B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF52458", Offset = "0xF52458", VA = "0xF52458")]
		private void Update()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF52D7C", Offset = "0xF52D7C", VA = "0xF52D7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF524CC", Offset = "0xF524CC", VA = "0xF524CC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF52A08", Offset = "0xF52A08", VA = "0xF52A08")]
		private void Move()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF52DCC", Offset = "0xF52DCC", VA = "0xF52DCC")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF52EFC", Offset = "0xF52EFC", VA = "0xF52EFC")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF52FAC", Offset = "0xF52FAC", VA = "0xF52FAC")]
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
		[Address(RVA = "0xF564D0", Offset = "0xF564D0", VA = "0xF564D0", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF56774", Offset = "0xF56774", VA = "0xF56774")]
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
		[Address(RVA = "0xF56FAC", Offset = "0xF56FAC", VA = "0xF56FAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xF56938", Offset = "0xF56938", VA = "0xF56938", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF56794", Offset = "0xF56794", VA = "0xF56794")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000547")]
		[Address(RVA = "0xDFDE10", Offset = "0xDFDE10", VA = "0xDFDE10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xDFDE4C", Offset = "0xDFDE4C", VA = "0xDFDE4C")]
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
		[Address(RVA = "0xF52FD8", Offset = "0xF52FD8", VA = "0xF52FD8")]
		private void Update()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF53004", Offset = "0xF53004", VA = "0xF53004")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF530DC", Offset = "0xF530DC", VA = "0xF530DC")]
		public SlowMo()
		{
		}
	}
}
namespace IKINEMAClient
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x31A694", Offset = "0x31A694")]
	public class IKINEMAVRPN : MonoBehaviour
	{
		[Token(Token = "0x40004CC")]
		public const string Version = "0.5";

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F478", Offset = "0x31F478")]
		public string SubjectName;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F4D0", Offset = "0x31F4D0")]
		public string ServerHost;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F528", Offset = "0x31F528")]
		public bool UpdateScaleFromStream;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x31F588", Offset = "0x31F588")]
		public bool ApplyVerticalRotation;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x31F5BC", Offset = "0x31F5BC")]
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
		[Address(RVA = "0xDECE08", Offset = "0xDECE08", VA = "0xDECE08")]
		public void Start()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xDECEEC", Offset = "0xDECEEC", VA = "0xDECEEC")]
		public void Update()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xDED41C", Offset = "0xDED41C", VA = "0xDED41C")]
		private void ReadMetadata()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xDECEF0", Offset = "0xDECEF0", VA = "0xDECEF0")]
		private void UpdateTransformsFromStream()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xDED74C", Offset = "0xDED74C", VA = "0xDED74C")]
		private Dictionary<string, Transform> ReadGameObjectHierarchy()
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xDEDD80", Offset = "0xDEDD80", VA = "0xDEDD80")]
		protected Vector3 ParseVector(ref TransformData inputData)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xDEDE68", Offset = "0xDEDE68", VA = "0xDEDE68")]
		protected Quaternion ParseQuaternion(ref TransformData inputData)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xDEDF8C", Offset = "0xDEDF8C", VA = "0xDEDF8C")]
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
		[Address(RVA = "0xDECE7C", Offset = "0xDECE7C", VA = "0xDECE7C")]
		public static StreamCharacter Connect(string connectionString)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xDEE0AC", Offset = "0xDEE0AC", VA = "0xDEE0AC")]
		private StreamCharacter(string connectionString)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xDEE360", Offset = "0xDEE360", VA = "0xDEE360", Slot = "1")]
		~StreamCharacter()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xDEDC54", Offset = "0xDEDC54", VA = "0xDEDC54")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xDEDC64", Offset = "0xDEDC64", VA = "0xDEDC64")]
		public float GetFigureScale()
		{
			return default(float);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xDEDC5C", Offset = "0xDEDC5C", VA = "0xDEDC5C")]
		public bool GetFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xDED744", Offset = "0xDED744", VA = "0xDED744")]
		public uint GetBoneCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xDEDB04", Offset = "0xDEDB04", VA = "0xDEDB04")]
		public string GetBoneName(uint boneId)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xDEDBAC", Offset = "0xDEDBAC", VA = "0xDEDBAC")]
		public string GetParentBoneName(uint boneId)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xDEEC40", Offset = "0xDEEC40", VA = "0xDEEC40")]
		public TransformData GetBoneRestLocalTransform(uint boneId)
		{
			return default(TransformData);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xDEDC6C", Offset = "0xDEDC6C", VA = "0xDEDC6C")]
		public TransformData GetBoneLocalTransform(uint boneId)
		{
			return default(TransformData);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xDEEFA0", Offset = "0xDEEFA0", VA = "0xDEEFA0")]
		public uint GetRigidBodyCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xDEF0B0", Offset = "0xDEF0B0", VA = "0xDEF0B0")]
		public string GetRigidBodyName(uint rigidBodyId)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xDEF278", Offset = "0xDEF278", VA = "0xDEF278")]
		public TransformData GetRigidBodyGlobalTransform(uint rigidBodyId)
		{
			return default(TransformData);
		}

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0xDEE238", Offset = "0xDEE238", VA = "0xDEE238")]
		private static extern IntPtr CharacterCreate(string connectionString);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0xDEE4D8", Offset = "0xDEE4D8", VA = "0xDEE4D8")]
		private static extern void CharacterDestroy(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0xDEE5E0", Offset = "0xDEE5E0", VA = "0xDEE5E0")]
		private static extern bool CharacterInitialized(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0xDEE6F8", Offset = "0xDEE6F8", VA = "0xDEE6F8")]
		private static extern float CharacterFigureScale(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0xDEE808", Offset = "0xDEE808", VA = "0xDEE808")]
		private static extern bool GetFrame(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000567")]
		[Address(RVA = "0xDEE908", Offset = "0xDEE908", VA = "0xDEE908")]
		private static extern uint GetBoneCount(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xDEEA08", Offset = "0xDEEA08", VA = "0xDEEA08")]
		private static extern void GetBoneName(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer, uint bufferLength);

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0xDEEB20", Offset = "0xDEEB20", VA = "0xDEEB20")]
		private static extern void GetParentBoneName(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer, uint bufferLength);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0xDEED58", Offset = "0xDEED58", VA = "0xDEED58")]
		private static extern void GetBoneRestLocalTransform(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0xDEEE80", Offset = "0xDEEE80", VA = "0xDEEE80")]
		private static extern void GetBoneLocalTransform(IntPtr nativeHandle, uint boneId, IntPtr resultBuffer);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0xDEEFA8", Offset = "0xDEEFA8", VA = "0xDEEFA8")]
		private static extern uint GetRigidBodyCount(IntPtr nativeHandle);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0xDEF158", Offset = "0xDEF158", VA = "0xDEF158")]
		private static extern void GetRigidBodyName(IntPtr nativeHandle, uint rigidBodyId, IntPtr resultBuffer, uint bufferLength);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0xDEF390", Offset = "0xDEF390", VA = "0xDEF390")]
		private static extern void GetRigidBodyGlobalTransform(IntPtr nativeHandle, uint rigidBodyId, IntPtr resultBuffer);
	}
}
