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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A5BD4", Offset = "0x7A5BD4")]
		public bool smoothFollow;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A5C0C", Offset = "0x7A5C0C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A5C44", Offset = "0x7A5C44")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A5C7C", Offset = "0x7A5C7C")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A5CB4", Offset = "0x7A5CB4")]
		public float blockedOffset;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5CCC", Offset = "0x7A5CCC")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5CDC", Offset = "0x7A5CDC")]
		private float <y>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5CEC", Offset = "0x7A5CEC")]
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
			[Address(RVA = "0xFD3ED4", Offset = "0xFD3ED4", VA = "0xFD3ED4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE0E4", Offset = "0x7AE0E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0xFD3EDC", Offset = "0xFD3EDC", VA = "0xFD3EDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE0F4", Offset = "0x7AE0F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0xFD3EE4", Offset = "0xFD3EE4", VA = "0xFD3EE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE104", Offset = "0x7AE104")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0xFD3EEC", Offset = "0xFD3EEC", VA = "0xFD3EEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE114", Offset = "0x7AE114")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0xFD3EF4", Offset = "0xFD3EF4", VA = "0xFD3EF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE124", Offset = "0x7AE124")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xFD3EFC", Offset = "0xFD3EFC", VA = "0xFD3EFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE134", Offset = "0x7AE134")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xFD4A00", Offset = "0xFD4A00", VA = "0xFD4A00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xFD3F04", Offset = "0xFD3F04", VA = "0xFD3F04", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xFD4040", Offset = "0xFD4040", VA = "0xFD4040", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xFD40A4", Offset = "0xFD40A4", VA = "0xFD40A4", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xFD410C", Offset = "0xFD410C", VA = "0xFD410C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xFD4170", Offset = "0xFD4170", VA = "0xFD4170")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xFD407C", Offset = "0xFD407C", VA = "0xFD407C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xFD42F8", Offset = "0xFD42F8", VA = "0xFD42F8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xFD4950", Offset = "0xFD4950", VA = "0xFD4950")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xFD4A74", Offset = "0xFD4A74", VA = "0xFD4A74")]
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
		[Address(RVA = "0xFD4B8C", Offset = "0xFD4B8C", VA = "0xFD4B8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xFD4BCC", Offset = "0xFD4BCC", VA = "0xFD4BCC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xFD4DA8", Offset = "0xFD4DA8", VA = "0xFD4DA8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xFD4E58", Offset = "0xFD4E58", VA = "0xFD4E58")]
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
		[Address(RVA = "0xFCB440", Offset = "0xFCB440", VA = "0xFCB440")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xFCB500", Offset = "0xFCB500", VA = "0xFCB500")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xFCB5AC", Offset = "0xFCB5AC", VA = "0xFCB5AC")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xFCB794", Offset = "0xFCB794", VA = "0xFCB794")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xFCB6C8", Offset = "0xFCB6C8", VA = "0xFCB6C8")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xFCB8B0", Offset = "0xFCB8B0", VA = "0xFCB8B0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xFCBAF8", Offset = "0xFCBAF8", VA = "0xFCBAF8")]
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
			[Address(RVA = "0xFCBDC0", Offset = "0xFCBDC0", VA = "0xFCBDC0")]
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
			[Address(RVA = "0xFCBB4C", Offset = "0xFCBB4C", VA = "0xFCBB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xFCBE3C", Offset = "0xFCBE3C", VA = "0xFCBE3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xFCBB00", Offset = "0xFCBB00", VA = "0xFCBB00")]
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
		[Address(RVA = "0xFCC0B0", Offset = "0xFCC0B0", VA = "0xFCC0B0")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xFCC3F4", Offset = "0xFCC3F4", VA = "0xFCC3F4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xFCC688", Offset = "0xFCC688", VA = "0xFCC688")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xFCC70C", Offset = "0xFCC70C", VA = "0xFCC70C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xFCC7C0", Offset = "0xFCC7C0", VA = "0xFCC7C0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xFCC2A4", Offset = "0xFCC2A4", VA = "0xFCC2A4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xFCC5E8", Offset = "0xFCC5E8", VA = "0xFCC5E8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xFCD014", Offset = "0xFCD014", VA = "0xFCD014")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xFCCE2C", Offset = "0xFCCE2C", VA = "0xFCCE2C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xFCCF20", Offset = "0xFCCF20", VA = "0xFCCF20")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xFCC9F4", Offset = "0xFCC9F4", VA = "0xFCC9F4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xFCCAA8", Offset = "0xFCCAA8", VA = "0xFCCAA8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xFCCB5C", Offset = "0xFCCB5C", VA = "0xFCCB5C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xFCCC10", Offset = "0xFCCC10", VA = "0xFCCC10")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xFCCCC4", Offset = "0xFCCCC4", VA = "0xFCCCC4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xFCCD78", Offset = "0xFCCD78", VA = "0xFCCD78")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xFCD290", Offset = "0xFCD290", VA = "0xFCD290")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xFCC900", Offset = "0xFCC900", VA = "0xFCC900")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xFCD1F8", Offset = "0xFCD1F8", VA = "0xFCD1F8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xFCD300", Offset = "0xFCD300", VA = "0xFCD300")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xFCD3D4", Offset = "0xFCD3D4", VA = "0xFCD3D4")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xFCD164", Offset = "0xFCD164", VA = "0xFCD164")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xFCD0A4", Offset = "0xFCD0A4", VA = "0xFCD0A4")]
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
				[Address(RVA = "0xFD3ECC", Offset = "0xFD3ECC", VA = "0xFD3ECC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x86DB74", Offset = "0x86DB74", VA = "0x86DB74")]
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
			[Address(RVA = "0xFCFEB8", Offset = "0xFCFEB8", VA = "0xFCFEB8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xFD02BC", Offset = "0xFD02BC", VA = "0xFD02BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xFD02CC", Offset = "0xFD02CC", VA = "0xFD02CC", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xFD0710", Offset = "0xFD0710", VA = "0xFD0710", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xFD0B58", Offset = "0xFD0B58", VA = "0xFD0B58")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xFD13A0", Offset = "0xFD13A0", VA = "0xFD13A0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xFD0DDC", Offset = "0xFD0DDC", VA = "0xFD0DDC")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xFD1E84", Offset = "0xFD1E84", VA = "0xFD1E84")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xFD1F7C", Offset = "0xFD1F7C", VA = "0xFD1F7C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xFD25AC", Offset = "0xFD25AC", VA = "0xFD25AC")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xFD237C", Offset = "0xFD237C", VA = "0xFD237C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xFD21C4", Offset = "0xFD21C4", VA = "0xFD21C4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xFD2054", Offset = "0xFD2054", VA = "0xFD2054")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xFD2494", Offset = "0xFD2494", VA = "0xFD2494")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xFD26B8", Offset = "0xFD26B8", VA = "0xFD26B8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xFD355C", Offset = "0xFD355C", VA = "0xFD355C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xFD2E48", Offset = "0xFD2E48", VA = "0xFD2E48")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xFD3914", Offset = "0xFD3914", VA = "0xFD3914")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xFD3308", Offset = "0xFD3308", VA = "0xFD3308")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xFD391C", Offset = "0xFD391C", VA = "0xFD391C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xFD3924", Offset = "0xFD3924", VA = "0xFD3924")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xFD3B30", Offset = "0xFD3B30", VA = "0xFD3B30")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xFD3D94", Offset = "0xFD3D94", VA = "0xFD3D94")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xFD0D6C", Offset = "0xFD0D6C", VA = "0xFD0D6C")]
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
		[Address(RVA = "0xFD4E74", Offset = "0xFD4E74", VA = "0xFD4E74")]
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
		[Address(RVA = "0xFD4E7C", Offset = "0xFD4E7C", VA = "0xFD4E7C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xFD4F3C", Offset = "0xFD4F3C", VA = "0xFD4F3C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Hierarchy
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1A77EF0", Offset = "0x1A77EF0", VA = "0x1A77EF0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1A78124", Offset = "0x1A78124", VA = "0x1A78124")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1A77FA0", Offset = "0x1A77FA0", VA = "0x1A77FA0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1A78270", Offset = "0x1A78270", VA = "0x1A78270")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1A78398", Offset = "0x1A78398", VA = "0x1A78398")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1A786E8", Offset = "0x1A786E8", VA = "0x1A786E8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1A7882C", Offset = "0x1A7882C", VA = "0x1A7882C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1A789D8", Offset = "0x1A789D8", VA = "0x1A789D8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1A78DC0", Offset = "0x1A78DC0", VA = "0x1A78DC0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1A78B8C", Offset = "0x1A78B8C", VA = "0x1A78B8C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1A78F70", Offset = "0x1A78F70", VA = "0x1A78F70")]
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
		[Address(RVA = "0x1A78F78", Offset = "0x1A78F78", VA = "0x1A78F78")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1A78FE8", Offset = "0x1A78FE8", VA = "0x1A78FE8")]
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
		[Address(RVA = "0x1A79058", Offset = "0x1A79058", VA = "0x1A79058")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1A79AC8", Offset = "0x1A79AC8", VA = "0x1A79AC8")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1A79BD0", Offset = "0x1A79BD0", VA = "0x1A79BD0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1A793C8", Offset = "0x1A793C8", VA = "0x1A793C8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1A793D4", Offset = "0x1A793D4", VA = "0x1A793D4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1A793FC", Offset = "0x1A793FC", VA = "0x1A793FC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1A79438", Offset = "0x1A79438", VA = "0x1A79438")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1A79450", Offset = "0x1A79450", VA = "0x1A79450")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1A79464", Offset = "0x1A79464", VA = "0x1A79464")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1A79478", Offset = "0x1A79478", VA = "0x1A79478")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1A79488", Offset = "0x1A79488", VA = "0x1A79488")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1A794D0", Offset = "0x1A794D0", VA = "0x1A794D0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1A79508", Offset = "0x1A79508", VA = "0x1A79508")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1A79530", Offset = "0x1A79530", VA = "0x1A79530")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1A79CCC", Offset = "0x1A79CCC", VA = "0x1A79CCC")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1A79564", Offset = "0x1A79564", VA = "0x1A79564")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1A7958C", Offset = "0x1A7958C", VA = "0x1A7958C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1A795BC", Offset = "0x1A795BC", VA = "0x1A795BC")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1A795F0", Offset = "0x1A795F0", VA = "0x1A795F0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1A79634", Offset = "0x1A79634", VA = "0x1A79634")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1A79698", Offset = "0x1A79698", VA = "0x1A79698")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1A796FC", Offset = "0x1A796FC", VA = "0x1A796FC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1A79750", Offset = "0x1A79750", VA = "0x1A79750")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1A797A4", Offset = "0x1A797A4", VA = "0x1A797A4")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1A7983C", Offset = "0x1A7983C", VA = "0x1A7983C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1A798D0", Offset = "0x1A798D0", VA = "0x1A798D0")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1A79D00", Offset = "0x1A79D00", VA = "0x1A79D00")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1A79974", Offset = "0x1A79974", VA = "0x1A79974")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1A79A58", Offset = "0x1A79A58", VA = "0x1A79A58")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1A79A88", Offset = "0x1A79A88", VA = "0x1A79A88")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1A79DE8", Offset = "0x1A79DE8", VA = "0x1A79DE8")]
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
		[Address(RVA = "0x1A79DF0", Offset = "0x1A79DF0", VA = "0x1A79DF0")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1A79E60", Offset = "0x1A79E60", VA = "0x1A79E60")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1A79ED0", Offset = "0x1A79ED0", VA = "0x1A79ED0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1A79F2C", Offset = "0x1A79F2C", VA = "0x1A79F2C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1A7A004", Offset = "0x1A7A004", VA = "0x1A7A004")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1A79F44", Offset = "0x1A79F44", VA = "0x1A79F44")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1A7A01C", Offset = "0x1A7A01C", VA = "0x1A7A01C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1A7A0CC", Offset = "0x1A7A0CC", VA = "0x1A7A0CC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1A7A0F8", Offset = "0x1A7A0F8", VA = "0x1A7A0F8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1A7A148", Offset = "0x1A7A148", VA = "0x1A7A148")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1A7A1B4", Offset = "0x1A7A1B4", VA = "0x1A7A1B4")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1A7A2B4", Offset = "0x1A7A2B4", VA = "0x1A7A2B4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1A7A398", Offset = "0x1A7A398", VA = "0x1A7A398")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1A7A3F8", Offset = "0x1A7A3F8", VA = "0x1A7A3F8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000011")]
	public static class QuaTools
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1A7A428", Offset = "0x1A7A428", VA = "0x1A7A428")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1A7A574", Offset = "0x1A7A574", VA = "0x1A7A574")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1A7A6C0", Offset = "0x1A7A6C0", VA = "0x1A7A6C0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1A7A7D4", Offset = "0x1A7A7D4", VA = "0x1A7A7D4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1A7A8E8", Offset = "0x1A7A8E8", VA = "0x1A7A8E8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1A7AA74", Offset = "0x1A7AA74", VA = "0x1A7AA74")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1A7AB44", Offset = "0x1A7AB44", VA = "0x1A7AB44")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1A7AC98", Offset = "0x1A7AC98", VA = "0x1A7AC98")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1A7AF1C", Offset = "0x1A7AF1C", VA = "0x1A7AF1C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1A7B130", Offset = "0x1A7B130", VA = "0x1A7B130")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1A7B2B0", Offset = "0x1A7B2B0", VA = "0x1A7B2B0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5D0C", Offset = "0x7A5D0C")]
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
			[Address(RVA = "0x1A7B558", Offset = "0x1A7B558", VA = "0x1A7B558")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1A7B8AC", Offset = "0x1A7B8AC", VA = "0x1A7B8AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1A7B420", Offset = "0x1A7B420", VA = "0x1A7B420")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1A7B4B8", Offset = "0x1A7B4B8", VA = "0x1A7B4B8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1A7B4BC", Offset = "0x1A7B4BC", VA = "0x1A7B4BC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1A7B4C0", Offset = "0x1A7B4C0", VA = "0x1A7B4C0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1A7B4C4", Offset = "0x1A7B4C4", VA = "0x1A7B4C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1A7B554", Offset = "0x1A7B554", VA = "0x1A7B554")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1A7B4FC", Offset = "0x1A7B4FC", VA = "0x1A7B4FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1A7B85C", Offset = "0x1A7B85C", VA = "0x1A7B85C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1A7B65C", Offset = "0x1A7B65C", VA = "0x1A7B65C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1A7B968", Offset = "0x1A7B968", VA = "0x1A7B968")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1A7B9C4", Offset = "0x1A7B9C4", VA = "0x1A7B9C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1A7BA24", Offset = "0x1A7BA24", VA = "0x1A7BA24")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1A7BA6C", Offset = "0x1A7BA6C", VA = "0x1A7BA6C")]
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
		[Address(RVA = "0x1A7BA7C", Offset = "0x1A7BA7C", VA = "0x1A7BA7C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1A7BB3C", Offset = "0x1A7BB3C", VA = "0x1A7BB3C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1A7BBFC", Offset = "0x1A7BBFC", VA = "0x1A7BBFC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1A7BCBC", Offset = "0x1A7BCBC", VA = "0x1A7BCBC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class V3Tools
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1A7BCC4", Offset = "0x1A7BCC4", VA = "0x1A7BCC4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1A7BDBC", Offset = "0x1A7BDBC", VA = "0x1A7BDBC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1A7BEB4", Offset = "0x1A7BEB4", VA = "0x1A7BEB4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1A7BFAC", Offset = "0x1A7BFAC", VA = "0x1A7BFAC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1A7C0AC", Offset = "0x1A7C0AC", VA = "0x1A7C0AC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1A7C2E8", Offset = "0x1A7C2E8", VA = "0x1A7C2E8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1A7C538", Offset = "0x1A7C538", VA = "0x1A7C538")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1A7C748", Offset = "0x1A7C748", VA = "0x1A7C748")]
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
		[Address(RVA = "0x1A7C924", Offset = "0x1A7C924", VA = "0x1A7C924")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1A7D0F0", Offset = "0x1A7D0F0", VA = "0x1A7D0F0")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4B84", Offset = "0x7A4B84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4B84", Offset = "0x7A4B84")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xF3E6FC", Offset = "0xF3E6FC", VA = "0xF3E6FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE1B4", Offset = "0x7AE1B4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xF3E748", Offset = "0xF3E748", VA = "0xF3E748")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE1EC", Offset = "0x7AE1EC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xF3E794", Offset = "0xF3E794", VA = "0xF3E794")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE224", Offset = "0x7AE224")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xF3E7E0", Offset = "0xF3E7E0", VA = "0xF3E7E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE25C", Offset = "0x7AE25C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xF3E82C", Offset = "0xF3E82C", VA = "0xF3E82C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xF3E8FC", Offset = "0xF3E8FC", VA = "0xF3E8FC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xF3E92C", Offset = "0xF3E92C", VA = "0xF3E92C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xF3E96C", Offset = "0xF3E96C", VA = "0xF3E96C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xF3E9AC", Offset = "0xF3E9AC", VA = "0xF3E9AC")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xF3EA04", Offset = "0xF3EA04", VA = "0xF3EA04")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xF3EA64", Offset = "0xF3EA64", VA = "0xF3EA64")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xF3EA98", Offset = "0xF3EA98", VA = "0xF3EA98")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xF3EAC8", Offset = "0xF3EAC8", VA = "0xF3EAC8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xF3EB60", Offset = "0xF3EB60", VA = "0xF3EB60")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xF3EBC8", Offset = "0xF3EBC8", VA = "0xF3EBC8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xF3EC30", Offset = "0xF3EC30", VA = "0xF3EC30")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xF3E85C", Offset = "0xF3E85C", VA = "0xF3E85C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xF3EC80", Offset = "0xF3EC80", VA = "0xF3EC80")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xF3EC8C", Offset = "0xF3EC8C", VA = "0xF3EC8C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xF3EC98", Offset = "0xF3EC98", VA = "0xF3EC98")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xF3F0E4", Offset = "0xF3F0E4", VA = "0xF3F0E4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xF3F1DC", Offset = "0xF3F1DC", VA = "0xF3F1DC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xF3F720", Offset = "0xF3F720", VA = "0xF3F720", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xF3FDF0", Offset = "0xF3FDF0", VA = "0xF3FDF0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xF3FE24", Offset = "0xF3FE24", VA = "0xF3FE24")]
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
			[Address(RVA = "0xF3EF2C", Offset = "0xF3EF2C", VA = "0xF3EF2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xF3FFF0", Offset = "0xF3FFF0", VA = "0xF3FFF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xF3F464", Offset = "0xF3F464", VA = "0xF3F464")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xF3FEA8", Offset = "0xF3FEA8", VA = "0xF3FEA8")]
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
			[Address(RVA = "0xF4383C", Offset = "0xF4383C", VA = "0xF4383C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D6")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xF438AC", Offset = "0xF438AC", VA = "0xF438AC")]
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
		[Address(RVA = "0xF438B4", Offset = "0xF438B4", VA = "0xF438B4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xF439E8", Offset = "0xF439E8", VA = "0xF439E8")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xF439F0", Offset = "0xF439F0", VA = "0xF439F0")]
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
			[Address(RVA = "0xF43C48", Offset = "0xF43C48", VA = "0xF43C48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xF43A1C", Offset = "0xF43A1C", VA = "0xF43A1C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xF43D0C", Offset = "0xF43D0C", VA = "0xF43D0C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xF43D14", Offset = "0xF43D14", VA = "0xF43D14")]
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
		[Address(RVA = "0xF43D40", Offset = "0xF43D40", VA = "0xF43D40", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xF43E98", Offset = "0xF43E98", VA = "0xF43E98")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xF43EA0", Offset = "0xF43EA0", VA = "0xF43EA0")]
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
			[Address(RVA = "0xF4410C", Offset = "0xF4410C", VA = "0xF4410C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xF43ECC", Offset = "0xF43ECC", VA = "0xF43ECC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xF441E4", Offset = "0xF441E4", VA = "0xF441E4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xF441EC", Offset = "0xF441EC", VA = "0xF441EC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A5D44", Offset = "0x7A5D44")]
		public float positionWeight;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A5D5C", Offset = "0x7A5D5C")]
		public float rotationWeight;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xF44218", Offset = "0xF44218", VA = "0xF44218")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xF3F6A8", Offset = "0xF3F6A8", VA = "0xF3F6A8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xF3F9BC", Offset = "0xF3F9BC", VA = "0xF3F9BC")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xF4028C", Offset = "0xF4028C", VA = "0xF4028C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5D74", Offset = "0x7A5D74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A5D74", Offset = "0x7A5D74")]
		public float weight;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5DC8", Offset = "0x7A5DC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A5DC8", Offset = "0x7A5DC8")]
		public float rotationWeight;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5E1C", Offset = "0x7A5E1C")]
		public DOF rotationDOF;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5E54", Offset = "0x7A5E54")]
		public Transform bone1;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5E8C", Offset = "0x7A5E8C")]
		public Transform bone2;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5EC4", Offset = "0x7A5EC4")]
		public Transform bone3;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5EFC", Offset = "0x7A5EFC")]
		public Transform tip;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5F34", Offset = "0x7A5F34")]
		public Transform target;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5F6C", Offset = "0x7A5F6C")]
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
			[Address(RVA = "0xF4E6B8", Offset = "0xF4E6B8", VA = "0xF4E6B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE294", Offset = "0x7AE294")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xF4E6C0", Offset = "0xF4E6C0", VA = "0xF4E6C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE2A4", Offset = "0x7AE2A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xF4E6CC", Offset = "0xF4E6CC", VA = "0xF4E6CC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xF4E6FC", Offset = "0xF4E6FC", VA = "0xF4E6FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xF4E748", Offset = "0xF4E748", VA = "0xF4E748")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xF4E778", Offset = "0xF4E778", VA = "0xF4E778")]
			set
			{
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xF4E7C8", Offset = "0xF4E7C8", VA = "0xF4E7C8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xF4E8C8", Offset = "0xF4E8C8", VA = "0xF4E8C8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xF4EDD4", Offset = "0xF4EDD4", VA = "0xF4EDD4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xF4EF04", Offset = "0xF4EF04", VA = "0xF4EF04")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xF4EFEC", Offset = "0xF4EFEC", VA = "0xF4EFEC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xF4F4E4", Offset = "0xF4F4E4", VA = "0xF4F4E4")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5F7C", Offset = "0x7A5F7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A5F7C", Offset = "0x7A5F7C")]
		public float weight;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5FD0", Offset = "0x7A5FD0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xF4F4F4", Offset = "0xF4F4F4", VA = "0xF4F4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE2B4", Offset = "0x7AE2B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0xF4F4FC", Offset = "0xF4F4FC", VA = "0xF4F4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE2C4", Offset = "0x7AE2C4")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xF4F508", Offset = "0xF4F508", VA = "0xF4F508")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xF4F59C", Offset = "0xF4F59C", VA = "0xF4F59C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE2D4", Offset = "0x7AE2D4")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xF4F9E8", Offset = "0xF4F9E8", VA = "0xF4F9E8")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xF4FBFC", Offset = "0xF4FBFC", VA = "0xF4FBFC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xF4F89C", Offset = "0xF4F89C", VA = "0xF4F89C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xF4FDF4", Offset = "0xF4FDF4", VA = "0xF4FDF4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xF4FEFC", Offset = "0xF4FEFC", VA = "0xF4FEFC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xF4FF90", Offset = "0xF4FF90", VA = "0xF4FF90")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xF5001C", Offset = "0xF5001C", VA = "0xF5001C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xF5009C", Offset = "0xF5009C", VA = "0xF5009C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xF500A0", Offset = "0xF500A0", VA = "0xF500A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xF500B4", Offset = "0xF500B4", VA = "0xF500B4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A5FE0", Offset = "0x7A5FE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A5FE0", Offset = "0x7A5FE0")]
		public float weight;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6034", Offset = "0x7A6034")]
		public Grounding solver;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A606C", Offset = "0x7A606C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xF5146C", Offset = "0xF5146C", VA = "0xF5146C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE30C", Offset = "0x7AE30C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xF51474", Offset = "0xF51474", VA = "0xF51474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE31C", Offset = "0x7AE31C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000104")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xF51480", Offset = "0xF51480", VA = "0xF51480")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xF517F4", Offset = "0xF517F4", VA = "0xF517F4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xF51610", Offset = "0xF51610", VA = "0xF51610")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xF51828", Offset = "0xF51828", VA = "0xF51828")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600010C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xF51AAC", Offset = "0xF51AAC", VA = "0xF51AAC")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4BE4", Offset = "0x7A4BE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4BE4", Offset = "0x7A4BE4")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A607C", Offset = "0x7A607C")]
		public BipedIK ik;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A60B4", Offset = "0x7A60B4")]
		public float spineBend;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A60EC", Offset = "0x7A60EC")]
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
		[Address(RVA = "0xF51F6C", Offset = "0xF51F6C", VA = "0xF51F6C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE32C", Offset = "0x7AE32C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xF51FB8", Offset = "0xF51FB8", VA = "0xF51FB8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE364", Offset = "0x7AE364")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xF52004", Offset = "0xF52004", VA = "0xF52004", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xF52090", Offset = "0xF52090", VA = "0xF52090")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xF52190", Offset = "0xF52190", VA = "0xF52190")]
		private void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xF52244", Offset = "0xF52244", VA = "0xF52244")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xF526D8", Offset = "0xF526D8", VA = "0xF526D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xF52764", Offset = "0xF52764", VA = "0xF52764")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xF52EC8", Offset = "0xF52EC8", VA = "0xF52EC8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xF53038", Offset = "0xF53038", VA = "0xF53038")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xF532B0", Offset = "0xF532B0", VA = "0xF532B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xF53504", Offset = "0xF53504", VA = "0xF53504")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4C44", Offset = "0x7A4C44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4C44", Offset = "0x7A4C44")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public class SpineEffector
		{
			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAB70", Offset = "0x7AAB70")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AABA8", Offset = "0x7AABA8")]
			public float horizontalWeight;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AABE0", Offset = "0x7AABE0")]
			public float verticalWeight;

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x15676AC", Offset = "0x15676AC", VA = "0x15676AC")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x15676BC", Offset = "0x15676BC", VA = "0x15676BC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6124", Offset = "0x7A6124")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A615C", Offset = "0x7A615C")]
		public float spineBend;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6194", Offset = "0x7A6194")]
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
		[Address(RVA = "0xF53584", Offset = "0xF53584", VA = "0xF53584")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE39C", Offset = "0x7AE39C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xF535D0", Offset = "0xF535D0", VA = "0xF535D0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE3D4", Offset = "0x7AE3D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xF5361C", Offset = "0xF5361C", VA = "0xF5361C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE40C", Offset = "0x7AE40C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xF53668", Offset = "0xF53668", VA = "0xF53668", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xF536F4", Offset = "0xF536F4", VA = "0xF536F4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xF537A4", Offset = "0xF537A4", VA = "0xF537A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xF53B98", Offset = "0xF53B98", VA = "0xF53B98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xF53BA4", Offset = "0xF53BA4", VA = "0xF53BA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xF53860", Offset = "0xF53860", VA = "0xF53860")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xF53BB0", Offset = "0xF53BB0", VA = "0xF53BB0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xF541F4", Offset = "0xF541F4", VA = "0xF541F4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xF5443C", Offset = "0xF5443C", VA = "0xF5443C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xF54574", Offset = "0xF54574", VA = "0xF54574")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xF546DC", Offset = "0xF546DC", VA = "0xF546DC")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4CA4", Offset = "0x7A4CA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4CA4", Offset = "0x7A4CA4")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A61CC", Offset = "0x7A61CC")]
		public Transform pelvis;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6204", Offset = "0x7A6204")]
		public Transform characterRoot;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A623C", Offset = "0x7A623C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A623C", Offset = "0x7A623C")]
		public float rootRotationWeight;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6290", Offset = "0x7A6290")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A62C8", Offset = "0x7A62C8")]
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
		[Address(RVA = "0x1567704", Offset = "0x1567704", VA = "0x1567704", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE444", Offset = "0x7AE444")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1567750", Offset = "0x1567750", VA = "0x1567750", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE47C", Offset = "0x7AE47C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x156779C", Offset = "0x156779C", VA = "0x156779C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1567870", Offset = "0x1567870", VA = "0x1567870")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1567A5C", Offset = "0x1567A5C", VA = "0x1567A5C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1567BB0", Offset = "0x1567BB0", VA = "0x1567BB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1568404", Offset = "0x1568404", VA = "0x1568404")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1568D6C", Offset = "0x1568D6C", VA = "0x1568D6C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x15692F4", Offset = "0x15692F4", VA = "0x15692F4")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x156985C", Offset = "0x156985C", VA = "0x156985C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1569AD4", Offset = "0x1569AD4", VA = "0x1569AD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1569D74", Offset = "0x1569D74", VA = "0x1569D74")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4D04", Offset = "0x7A4D04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4D04", Offset = "0x7A4D04")]
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
			[Address(RVA = "0x87F448", Offset = "0x87F448", VA = "0x87F448")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6300", Offset = "0x7A6300")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6338", Offset = "0x7A6338")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A6338", Offset = "0x7A6338")]
		public float rootRotationWeight;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A638C", Offset = "0x7A638C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A638C", Offset = "0x7A638C")]
		public float minRootRotation;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A63E4", Offset = "0x7A63E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A63E4", Offset = "0x7A63E4")]
		public float maxRootRotation;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A643C", Offset = "0x7A643C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6474", Offset = "0x7A6474")]
		public float maxLegOffset;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A64AC", Offset = "0x7A64AC")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A64E4", Offset = "0x7A64E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A64E4", Offset = "0x7A64E4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6538", Offset = "0x7A6538")]
		public Transform characterRoot;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6570", Offset = "0x7A6570")]
		public Transform pelvis;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A65A8", Offset = "0x7A65A8")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A65E0", Offset = "0x7A65E0")]
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
		[Address(RVA = "0x1569DF8", Offset = "0x1569DF8", VA = "0x1569DF8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE4B4", Offset = "0x7AE4B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1569E44", Offset = "0x1569E44", VA = "0x1569E44", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE4EC", Offset = "0x7AE4EC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1569E90", Offset = "0x1569E90", VA = "0x1569E90", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1569ED8", Offset = "0x1569ED8", VA = "0x1569ED8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x156A014", Offset = "0x156A014", VA = "0x156A014")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x156A1B8", Offset = "0x156A1B8", VA = "0x156A1B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x156A29C", Offset = "0x156A29C", VA = "0x156A29C")]
		private void Update()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x156A35C", Offset = "0x156A35C", VA = "0x156A35C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x156A76C", Offset = "0x156A76C", VA = "0x156A76C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x156AC68", Offset = "0x156AC68", VA = "0x156AC68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x156ADB4", Offset = "0x156ADB4", VA = "0x156ADB4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x156B318", Offset = "0x156B318", VA = "0x156B318")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x156BD40", Offset = "0x156BD40", VA = "0x156BD40")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x156C0AC", Offset = "0x156C0AC", VA = "0x156C0AC")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x156C248", Offset = "0x156C248", VA = "0x156C248")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x156C640", Offset = "0x156C640", VA = "0x156C640")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x156C688", Offset = "0x156C688", VA = "0x156C688")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x156C918", Offset = "0x156C918", VA = "0x156C918")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4D64", Offset = "0x7A4D64")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6628", Offset = "0x7A6628")]
		public VRIK ik;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x156CA90", Offset = "0x156CA90", VA = "0x156CA90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE524", Offset = "0x7AE524")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x156CA94", Offset = "0x156CA94", VA = "0x156CA94", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE55C", Offset = "0x7AE55C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x156CA98", Offset = "0x156CA98", VA = "0x156CA98", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE594", Offset = "0x7AE594")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x156CA9C", Offset = "0x156CA9C", VA = "0x156CA9C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x156CAC8", Offset = "0x156CAC8", VA = "0x156CAC8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x156CB74", Offset = "0x156CB74", VA = "0x156CB74")]
		private void Update()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x156CC30", Offset = "0x156CC30", VA = "0x156CC30")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x156CF84", Offset = "0x156CF84", VA = "0x156CF84")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x156D35C", Offset = "0x156D35C", VA = "0x156D35C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x156D498", Offset = "0x156D498", VA = "0x156D498")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x156D7C8", Offset = "0x156D7C8", VA = "0x156D7C8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x156D900", Offset = "0x156D900", VA = "0x156D900")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x156DB3C", Offset = "0x156DB3C", VA = "0x156DB3C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC18", Offset = "0x7AAC18")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC28", Offset = "0x7AAC28")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC38", Offset = "0x7AAC38")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC48", Offset = "0x7AAC48")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC58", Offset = "0x7AAC58")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC68", Offset = "0x7AAC68")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC78", Offset = "0x7AAC78")]
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
				[Address(RVA = "0x156ED6C", Offset = "0x156ED6C", VA = "0x156ED6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B005C", Offset = "0x7B005C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0x156F644", Offset = "0x156F644", VA = "0x156F644")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B006C", Offset = "0x7B006C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x1569850", Offset = "0x1569850", VA = "0x1569850")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B007C", Offset = "0x7B007C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0x156F650", Offset = "0x156F650", VA = "0x156F650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B008C", Offset = "0x7B008C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public bool initiated
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x156F65C", Offset = "0x156F65C", VA = "0x156F65C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B009C", Offset = "0x7B009C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0x156F664", Offset = "0x156F664", VA = "0x156F664")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B00AC", Offset = "0x7B00AC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public float heightFromGround
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x156F670", Offset = "0x156F670", VA = "0x156F670")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B00BC", Offset = "0x7B00BC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x156F678", Offset = "0x156F678", VA = "0x156F678")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B00CC", Offset = "0x7B00CC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x156F680", Offset = "0x156F680", VA = "0x156F680")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B00DC", Offset = "0x7B00DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x156F68C", Offset = "0x156F68C", VA = "0x156F68C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B00EC", Offset = "0x7B00EC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public Transform transform
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x156C240", Offset = "0x156C240", VA = "0x156C240")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B00FC", Offset = "0x7B00FC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x156F698", Offset = "0x156F698", VA = "0x156F698")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B010C", Offset = "0x7B010C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public float IKOffset
			{
				[Token(Token = "0x60005CF")]
				[Address(RVA = "0x156ED64", Offset = "0x156ED64", VA = "0x156ED64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B011C", Offset = "0x7B011C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D0")]
				[Address(RVA = "0x156F6A0", Offset = "0x156F6A0", VA = "0x156F6A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B012C", Offset = "0x7B012C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x1570324", Offset = "0x1570324", VA = "0x1570324")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700007B")]
			private float rootYOffset
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x15706A8", Offset = "0x15706A8", VA = "0x15706A8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x156E268", Offset = "0x156E268", VA = "0x156E268")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x156F6A8", Offset = "0x156F6A8", VA = "0x156F6A8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x156F124", Offset = "0x156F124", VA = "0x156F124")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x156E378", Offset = "0x156E378", VA = "0x156E378")]
			public void Process()
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x156FE28", Offset = "0x156FE28", VA = "0x156FE28")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x156F6FC", Offset = "0x156F6FC", VA = "0x156F6FC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x15704E8", Offset = "0x15704E8", VA = "0x15704E8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x156FAAC", Offset = "0x156FAAC", VA = "0x156FAAC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x156FBB4", Offset = "0x156FBB4", VA = "0x156FBB4")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x15705F8", Offset = "0x15705F8", VA = "0x15705F8")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x15703D4", Offset = "0x15703D4", VA = "0x15703D4")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1570814", Offset = "0x1570814", VA = "0x1570814")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x156E1B8", Offset = "0x156E1B8", VA = "0x156E1B8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		public class Pelvis
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC88", Offset = "0x7AAC88")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAC98", Offset = "0x7AAC98")]
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
				[Address(RVA = "0x1569844", Offset = "0x1569844", VA = "0x1569844")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B013C", Offset = "0x7B013C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x157098C", Offset = "0x157098C", VA = "0x157098C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B014C", Offset = "0x7B014C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public float heightOffset
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x156C0A4", Offset = "0x156C0A4", VA = "0x156C0A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B015C", Offset = "0x7B015C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x1570998", Offset = "0x1570998", VA = "0x1570998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B016C", Offset = "0x7B016C")]
				private set
				{
				}
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x156E350", Offset = "0x156E350", VA = "0x156E350")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x156F058", Offset = "0x156F058", VA = "0x156F058")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x15709A0", Offset = "0x15709A0", VA = "0x15709A0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x156ED74", Offset = "0x156ED74", VA = "0x156ED74")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x156E260", Offset = "0x156E260", VA = "0x156E260")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6660", Offset = "0x7A6660")]
		public LayerMask layers;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6698", Offset = "0x7A6698")]
		public float maxStep;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A66D0", Offset = "0x7A66D0")]
		public float heightOffset;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6708", Offset = "0x7A6708")]
		public float footSpeed;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6740", Offset = "0x7A6740")]
		public float footRadius;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6778", Offset = "0x7A6778")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A67C4", Offset = "0x7A67C4")]
		public float prediction;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A67FC", Offset = "0x7A67FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A67FC", Offset = "0x7A67FC")]
		public float footRotationWeight;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6850", Offset = "0x7A6850")]
		public float footRotationSpeed;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6888", Offset = "0x7A6888")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A6888", Offset = "0x7A6888")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A68E0", Offset = "0x7A68E0")]
		public bool rotateSolver;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6918", Offset = "0x7A6918")]
		public float pelvisSpeed;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6950", Offset = "0x7A6950")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A6950", Offset = "0x7A6950")]
		public float pelvisDamper;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A69A4", Offset = "0x7A69A4")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A69DC", Offset = "0x7A69DC")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6A14", Offset = "0x7A6A14")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6A4C", Offset = "0x7A6A4C")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6A84", Offset = "0x7A6A84")]
		public Quality quality;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6ABC", Offset = "0x7A6ABC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6ACC", Offset = "0x7A6ACC")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6ADC", Offset = "0x7A6ADC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6AEC", Offset = "0x7A6AEC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6AFC", Offset = "0x7A6AFC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000016")]
		public Leg[] legs
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1568D64", Offset = "0x1568D64", VA = "0x1568D64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE5CC", Offset = "0x7AE5CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x156DB9C", Offset = "0x156DB9C", VA = "0x156DB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE5DC", Offset = "0x7AE5DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x156983C", Offset = "0x156983C", VA = "0x156983C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE5EC", Offset = "0x7AE5EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x156DBA4", Offset = "0x156DBA4", VA = "0x156DBA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE5FC", Offset = "0x7AE5FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool isGrounded
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x156DBAC", Offset = "0x156DBAC", VA = "0x156DBAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE60C", Offset = "0x7AE60C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x156DBB4", Offset = "0x156DBB4", VA = "0x156DBB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE61C", Offset = "0x7AE61C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Transform root
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x156C09C", Offset = "0x156C09C", VA = "0x156C09C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE62C", Offset = "0x7AE62C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x156DBC0", Offset = "0x156DBC0", VA = "0x156DBC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE63C", Offset = "0x7AE63C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x156B2FC", Offset = "0x156B2FC", VA = "0x156B2FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE64C", Offset = "0x7AE64C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x156DBC8", Offset = "0x156DBC8", VA = "0x156DBC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AE65C", Offset = "0x7AE65C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool rootGrounded
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x156DBE8", Offset = "0x156DBE8", VA = "0x156DBE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 up
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x156E048", Offset = "0x156E048", VA = "0x156E048")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001D")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x156F1EC", Offset = "0x156F1EC", VA = "0x156F1EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x156DC40", Offset = "0x156DC40", VA = "0x156DC40")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x156E0DC", Offset = "0x156E0DC", VA = "0x156E0DC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1568A60", Offset = "0x1568A60", VA = "0x1568A60")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1569054", Offset = "0x1569054", VA = "0x1569054")]
		public void Update()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1568190", Offset = "0x1568190", VA = "0x1568190")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x15677C8", Offset = "0x15677C8", VA = "0x15677C8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x156E360", Offset = "0x156E360", VA = "0x156E360")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x156F2C4", Offset = "0x156F2C4", VA = "0x156F2C4")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x156F434", Offset = "0x156F434", VA = "0x156F434")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x156F540", Offset = "0x156F540", VA = "0x156F540")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x156CA38", Offset = "0x156CA38", VA = "0x156CA38")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4D9C", Offset = "0x7A4D9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4D9C", Offset = "0x7A4D9C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xF3945C", Offset = "0xF3945C", VA = "0xF3945C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE66C", Offset = "0x7AE66C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xF394A8", Offset = "0xF394A8", VA = "0xF394A8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE6A4", Offset = "0x7AE6A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xF394F4", Offset = "0xF394F4", VA = "0xF394F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE6DC", Offset = "0x7AE6DC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xF39540", Offset = "0xF39540", VA = "0xF39540")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE714", Offset = "0x7AE714")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xF3958C", Offset = "0xF3958C", VA = "0xF3958C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE74C", Offset = "0x7AE74C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xF395D8", Offset = "0xF395D8", VA = "0xF395D8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xF395E0", Offset = "0xF395E0", VA = "0xF395E0")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4DFC", Offset = "0x7A4DFC")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xF3E51C", Offset = "0xF3E51C", VA = "0xF3E51C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE784", Offset = "0x7AE784")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xF3E588", Offset = "0xF3E588", VA = "0xF3E588", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE7BC", Offset = "0x7AE7BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xF3E5F4", Offset = "0xF3E5F4", VA = "0xF3E5F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE7F4", Offset = "0x7AE7F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xF3E640", Offset = "0xF3E640", VA = "0xF3E640")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE82C", Offset = "0x7AE82C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xF3E68C", Offset = "0xF3E68C", VA = "0xF3E68C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xF3E694", Offset = "0xF3E694", VA = "0xF3E694")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4E34", Offset = "0x7A4E34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4E34", Offset = "0x7A4E34")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xF40568", Offset = "0xF40568", VA = "0xF40568", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE864", Offset = "0x7AE864")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xF405B4", Offset = "0xF405B4", VA = "0xF405B4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE89C", Offset = "0x7AE89C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xF40600", Offset = "0xF40600", VA = "0xF40600")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE8D4", Offset = "0x7AE8D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xF4064C", Offset = "0xF4064C", VA = "0xF4064C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE90C", Offset = "0x7AE90C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xF40698", Offset = "0xF40698", VA = "0xF40698", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xF406A0", Offset = "0xF406A0", VA = "0xF406A0")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4E94", Offset = "0x7A4E94")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4E94", Offset = "0x7A4E94")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xF44288", Offset = "0xF44288", VA = "0xF44288", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE944", Offset = "0x7AE944")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xF442D4", Offset = "0xF442D4", VA = "0xF442D4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE97C", Offset = "0x7AE97C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xF44320", Offset = "0xF44320", VA = "0xF44320")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE9B4", Offset = "0x7AE9B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xF4436C", Offset = "0xF4436C", VA = "0xF4436C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AE9EC", Offset = "0x7AE9EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xF443B8", Offset = "0xF443B8", VA = "0xF443B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xF443C0", Offset = "0xF443C0", VA = "0xF443C0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4EF4", Offset = "0x7A4EF4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4EF4", Offset = "0x7A4EF4")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xF44D24", Offset = "0xF44D24", VA = "0xF44D24", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEA24", Offset = "0x7AEA24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xF44D70", Offset = "0xF44D70", VA = "0xF44D70", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEA5C", Offset = "0x7AEA5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xF44DBC", Offset = "0xF44DBC", VA = "0xF44DBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEA94", Offset = "0x7AEA94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF44E08", Offset = "0xF44E08", VA = "0xF44E08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEACC", Offset = "0x7AEACC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xF44E54", Offset = "0xF44E54", VA = "0xF44E54", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xF44E5C", Offset = "0xF44E5C", VA = "0xF44E5C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4F54", Offset = "0x7A4F54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4F54", Offset = "0x7A4F54")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xF5011C", Offset = "0xF5011C", VA = "0xF5011C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEB04", Offset = "0x7AEB04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xF50168", Offset = "0xF50168", VA = "0xF50168", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEB3C", Offset = "0x7AEB3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xF501B4", Offset = "0xF501B4", VA = "0xF501B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEB74", Offset = "0x7AEB74")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xF50200", Offset = "0xF50200", VA = "0xF50200")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEBAC", Offset = "0x7AEBAC")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xF5024C", Offset = "0xF5024C", VA = "0xF5024C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEBE4", Offset = "0x7AEBE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xF50298", Offset = "0xF50298", VA = "0xF50298")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEC1C", Offset = "0x7AEC1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xF502E4", Offset = "0xF502E4", VA = "0xF502E4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xF50330", Offset = "0xF50330", VA = "0xF50330", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xF50338", Offset = "0xF50338", VA = "0xF50338")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xF5055C", Offset = "0xF5055C", VA = "0xF5055C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xF5094C", Offset = "0xF5094C", VA = "0xF5094C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEC54", Offset = "0x7AEC54")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xF5098C", Offset = "0xF5098C", VA = "0xF5098C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEC8C", Offset = "0x7AEC8C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xF50AA0", Offset = "0xF50AA0", VA = "0xF50AA0")]
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
		[Address(RVA = "0x1573DB8", Offset = "0x1573DB8", VA = "0x1573DB8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1573EBC", Offset = "0x1573EBC", VA = "0x1573EBC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1574088", Offset = "0x1574088", VA = "0x1574088", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600019B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600019C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x15740F8", Offset = "0x15740F8", VA = "0x15740F8")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6B0C", Offset = "0x7A6B0C")]
		public IK[] IKComponents;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6B44", Offset = "0x7A6B44")]
		public Animator animator;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700001E")]
		private bool animatePhysics
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x15778D4", Offset = "0x15778D4", VA = "0x15778D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1577978", Offset = "0x1577978", VA = "0x1577978")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1577A18", Offset = "0x1577A18", VA = "0x1577A18")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1577B50", Offset = "0x1577B50", VA = "0x1577B50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1577B8C", Offset = "0x1577B8C", VA = "0x1577B8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1577A4C", Offset = "0x1577A4C", VA = "0x1577A4C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1577C54", Offset = "0x1577C54", VA = "0x1577C54")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4FB4", Offset = "0x7A4FB4")]
	public class LegIK : IK
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x105BBC4", Offset = "0x105BBC4", VA = "0x105BBC4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AECC4", Offset = "0x7AECC4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x105BC30", Offset = "0x105BC30", VA = "0x105BC30", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AECFC", Offset = "0x7AECFC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x105BC9C", Offset = "0x105BC9C", VA = "0x105BC9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AED34", Offset = "0x7AED34")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x105BCE8", Offset = "0x105BCE8", VA = "0x105BCE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AED6C", Offset = "0x7AED6C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x105BD34", Offset = "0x105BD34", VA = "0x105BD34", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x105BD3C", Offset = "0x105BD3C", VA = "0x105BD3C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A4FEC", Offset = "0x7A4FEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A4FEC", Offset = "0x7A4FEC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x105BDA4", Offset = "0x105BDA4", VA = "0x105BDA4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEDA4", Offset = "0x7AEDA4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x105BDF0", Offset = "0x105BDF0", VA = "0x105BDF0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEDDC", Offset = "0x7AEDDC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x105BE3C", Offset = "0x105BE3C", VA = "0x105BE3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEE14", Offset = "0x7AEE14")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x105BE88", Offset = "0x105BE88", VA = "0x105BE88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEE4C", Offset = "0x7AEE4C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x105BED4", Offset = "0x105BED4", VA = "0x105BED4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x105BEDC", Offset = "0x105BEDC", VA = "0x105BEDC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A504C", Offset = "0x7A504C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A504C", Offset = "0x7A504C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x105CFF8", Offset = "0x105CFF8", VA = "0x105CFF8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEE84", Offset = "0x7AEE84")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x105D044", Offset = "0x105D044", VA = "0x105D044", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEEBC", Offset = "0x7AEEBC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x105D090", Offset = "0x105D090", VA = "0x105D090")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEEF4", Offset = "0x7AEEF4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x105D0DC", Offset = "0x105D0DC", VA = "0x105D0DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEF2C", Offset = "0x7AEF2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x105D128", Offset = "0x105D128", VA = "0x105D128", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x105D130", Offset = "0x105D130", VA = "0x105D130")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A50AC", Offset = "0x7A50AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A50AC", Offset = "0x7A50AC")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x10678C8", Offset = "0x10678C8", VA = "0x10678C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEF64", Offset = "0x7AEF64")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1067914", Offset = "0x1067914", VA = "0x1067914", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEF9C", Offset = "0x7AEF9C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1067960", Offset = "0x1067960", VA = "0x1067960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AEFD4", Offset = "0x7AEFD4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10679AC", Offset = "0x10679AC", VA = "0x10679AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF00C", Offset = "0x7AF00C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10679F8", Offset = "0x10679F8", VA = "0x10679F8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1067A00", Offset = "0x1067A00", VA = "0x1067A00")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A510C", Offset = "0x7A510C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AACA8", Offset = "0x7AACA8")]
			public Transform chest;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AACE0", Offset = "0x7AACE0")]
			public Transform neck;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAD18", Offset = "0x7AAD18")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAD50", Offset = "0x7AAD50")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAD88", Offset = "0x7AAD88")]
			public Transform leftThigh;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AADC0", Offset = "0x7AADC0")]
			public Transform leftCalf;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AADF8", Offset = "0x7AADF8")]
			public Transform leftFoot;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAE30", Offset = "0x7AAE30")]
			public Transform leftToes;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAE68", Offset = "0x7AAE68")]
			public Transform rightThigh;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAEA0", Offset = "0x7AAEA0")]
			public Transform rightCalf;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAED8", Offset = "0x7AAED8")]
			public Transform rightFoot;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAF10", Offset = "0x7AAF10")]
			public Transform rightToes;

			[Token(Token = "0x1700007E")]
			public bool isFilled
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x1069350", Offset = "0x1069350", VA = "0x1069350")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007F")]
			public bool isEmpty
			{
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x1068ED4", Offset = "0x1068ED4", VA = "0x1068ED4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x10699F4", Offset = "0x10699F4", VA = "0x10699F4")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x106887C", Offset = "0x106887C", VA = "0x106887C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x10699EC", Offset = "0x10699EC", VA = "0x10699EC")]
			public References()
			{
			}
		}

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x7A6B7C", Offset = "0x7A6B7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6B7C", Offset = "0x7A6B7C")]
		public References references;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6BF8", Offset = "0x7A6BF8")]
		public IKSolverVR solver;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1068730", Offset = "0x1068730", VA = "0x1068730", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF044", Offset = "0x7AF044")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x106879C", Offset = "0x106879C", VA = "0x106879C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF07C", Offset = "0x7AF07C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1068808", Offset = "0x1068808", VA = "0x1068808")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF0B4", Offset = "0x7AF0B4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1068854", Offset = "0x1068854", VA = "0x1068854")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF0EC", Offset = "0x7AF0EC")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1068DF8", Offset = "0x1068DF8", VA = "0x1068DF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF124", Offset = "0x7AF124")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1068E30", Offset = "0x1068E30", VA = "0x1068E30", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1068E38", Offset = "0x1068E38", VA = "0x1068E38", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x10697D4", Offset = "0x10697D4", VA = "0x10697D4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1069964", Offset = "0x1069964", VA = "0x1069964")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5144", Offset = "0x7A5144")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A5144", Offset = "0x7A5144")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6C30", Offset = "0x7A6C30")]
		public Transform target;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6C68", Offset = "0x7A6C68")]
		public Transform poleTarget;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6CA0", Offset = "0x7A6CA0")]
		public Transform aimTransform;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7A6CD8", Offset = "0x7A6CD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6CD8", Offset = "0x7A6CD8")]
		public float axisX;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6D28", Offset = "0x7A6D28")]
		public float axisY;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6D60", Offset = "0x7A6D60")]
		public float axisZ;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7A6D98", Offset = "0x7A6D98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6D98", Offset = "0x7A6D98")]
		public float poleAxisX;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6DE8", Offset = "0x7A6DE8")]
		public float poleAxisY;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6E20", Offset = "0x7A6E20")]
		public float poleAxisZ;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7A6E58", Offset = "0x7A6E58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6E58", Offset = "0x7A6E58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A6E58", Offset = "0x7A6E58")]
		public float weight;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6EC0", Offset = "0x7A6EC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A6EC0", Offset = "0x7A6EC0")]
		public float poleWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6F14", Offset = "0x7A6F14")]
		public float tolerance;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6F4C", Offset = "0x7A6F4C")]
		public int maxIterations;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6F84", Offset = "0x7A6F84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A6F84", Offset = "0x7A6F84")]
		public float clampWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A6FD8", Offset = "0x7A6FD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A6FD8", Offset = "0x7A6FD8")]
		public int clampSmoothing;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A702C", Offset = "0x7A702C")]
		public bool useRotationLimits;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7064", Offset = "0x7A7064")]
		public bool XY;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7A709C", Offset = "0x7A709C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A709C", Offset = "0x7A709C")]
		public Transform[] bones;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A70EC", Offset = "0x7A70EC")]
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
			[Address(RVA = "0xF39648", Offset = "0xF39648", VA = "0xF39648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF15C", Offset = "0x7AF15C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xF39650", Offset = "0xF39650", VA = "0xF39650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF16C", Offset = "0x7AF16C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 axis
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xF3965C", Offset = "0xF3965C", VA = "0xF3965C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xF39698", Offset = "0xF39698", VA = "0xF39698")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xF396A4", Offset = "0xF396A4", VA = "0xF396A4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xF396E0", Offset = "0xF396E0", VA = "0xF396E0")]
			set
			{
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xF396EC", Offset = "0xF396EC", VA = "0xF396EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xF3A8A4", Offset = "0xF3A8A4", VA = "0xF3A8A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xF3AC90", Offset = "0xF3AC90", VA = "0xF3AC90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xF3AD90", Offset = "0xF3AD90", VA = "0xF3AD90")]
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
		[Address(RVA = "0x86C344", Offset = "0x86C344", VA = "0x86C344")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x86C34C", Offset = "0x86C34C", VA = "0x86C34C")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x86C354", Offset = "0x86C354", VA = "0x86C354")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x86C35C", Offset = "0x86C35C", VA = "0x86C35C", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x86C360", Offset = "0x86C360", VA = "0x86C360", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x86C3A4", Offset = "0x86C3A4", VA = "0x86C3A4")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x86C3E8", Offset = "0x86C3E8", VA = "0x86C3E8")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x86C454", Offset = "0x86C454", VA = "0x86C454")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x86C498", Offset = "0x86C498", VA = "0x86C498")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x86C4AC", Offset = "0x86C4AC", VA = "0x86C4AC")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x86C4F0", Offset = "0x86C4F0", VA = "0x86C4F0")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x86C4F8", Offset = "0x86C4F8", VA = "0x86C4F8")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A51CC", Offset = "0x7A51CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A51CC", Offset = "0x7A51CC")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A70FC", Offset = "0x7A70FC")]
		public Transform target;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7134", Offset = "0x7A7134")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7134", Offset = "0x7A7134")]
		public float weight;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7188", Offset = "0x7A7188")]
		public float tolerance;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A71C0", Offset = "0x7A71C0")]
		public int maxIterations;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A71F8", Offset = "0x7A71F8")]
		public bool useRotationLimits;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7230", Offset = "0x7A7230")]
		public bool XY;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7268", Offset = "0x7A7268")]
		public Transform[] bones;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A72A0", Offset = "0x7A72A0")]
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
			[Address(RVA = "0xF40708", Offset = "0xF40708", VA = "0xF40708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF17C", Offset = "0x7AF17C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xF40710", Offset = "0xF40710", VA = "0xF40710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF18C", Offset = "0x7AF18C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xF4071C", Offset = "0xF4071C", VA = "0xF4071C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xF410EC", Offset = "0xF410EC", VA = "0xF410EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xF41288", Offset = "0xF41288", VA = "0xF41288")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xF4139C", Offset = "0xF4139C", VA = "0xF4139C")]
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
		[Address(RVA = "0x86C54C", Offset = "0x86C54C", VA = "0x86C54C")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x86C554", Offset = "0x86C554", VA = "0x86C554")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x86C55C", Offset = "0x86C55C", VA = "0x86C55C")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x86C564", Offset = "0x86C564", VA = "0x86C564", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x86C568", Offset = "0x86C568", VA = "0x86C568", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x86C5AC", Offset = "0x86C5AC", VA = "0x86C5AC")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x86C5F0", Offset = "0x86C5F0", VA = "0x86C5F0")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x86C634", Offset = "0x86C634", VA = "0x86C634")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x86C680", Offset = "0x86C680", VA = "0x86C680")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x86C6C4", Offset = "0x86C6C4", VA = "0x86C6C4")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x86C6CC", Offset = "0x86C6CC", VA = "0x86C6CC")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x86C714", Offset = "0x86C714", VA = "0x86C714")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x86C75C", Offset = "0x86C75C", VA = "0x86C75C")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A72B0", Offset = "0x7A72B0")]
		public float weight;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1577C5C", Offset = "0x1577C5C", VA = "0x1577C5C")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x10665E0", Offset = "0x10665E0", VA = "0x10665E0")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1066900", Offset = "0x1066900", VA = "0x1066900")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x10669E4", Offset = "0x10669E4", VA = "0x10669E4")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1066A4C", Offset = "0x1066A4C", VA = "0x1066A4C")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1066C80", Offset = "0x1066C80", VA = "0x1066C80")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A72C8", Offset = "0x7A72C8")]
		public float pull;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A72E0", Offset = "0x7A72E0")]
		public float pin;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF44428", Offset = "0xF44428", VA = "0xF44428")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xF44500", Offset = "0xF44500", VA = "0xF44500")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF44534", Offset = "0xF44534", VA = "0xF44534")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF44AB4", Offset = "0xF44AB4", VA = "0xF44AB4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xF446BC", Offset = "0xF446BC", VA = "0xF446BC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xF44CBC", Offset = "0xF44CBC", VA = "0xF44CBC")]
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
		[Address(RVA = "0xF44EC4", Offset = "0xF44EC4", VA = "0xF44EC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF45634", Offset = "0xF45634", VA = "0xF45634")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xF45908", Offset = "0xF45908", VA = "0xF45908")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xF45A68", Offset = "0xF45A68", VA = "0xF45A68")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAF48", Offset = "0x7AAF48")]
			public Transform transform;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAF80", Offset = "0x7AAF80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AAF80", Offset = "0x7AAF80")]
			public float weight;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xF49E4C", Offset = "0xF49E4C", VA = "0xF49E4C")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xF49ECC", Offset = "0xF49ECC", VA = "0xF49ECC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xF466F0", Offset = "0xF466F0", VA = "0xF466F0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xF46D3C", Offset = "0xF46D3C", VA = "0xF46D3C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A72F8", Offset = "0x7A72F8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A7330", Offset = "0x7A7330")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7330", Offset = "0x7A7330")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7330", Offset = "0x7A7330")]
		public float positionWeight;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A73A8", Offset = "0x7A73A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A73A8", Offset = "0x7A73A8")]
		public float bodyWeight;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A73FC", Offset = "0x7A73FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A73FC", Offset = "0x7A73FC")]
		public float thighWeight;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7450", Offset = "0x7A7450")]
		public bool handsPullBody;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A7488", Offset = "0x7A7488")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7488", Offset = "0x7A7488")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7488", Offset = "0x7A7488")]
		public float rotationWeight;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7500", Offset = "0x7A7500")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7500", Offset = "0x7A7500")]
		public float bodyClampWeight;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7554", Offset = "0x7A7554")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7554", Offset = "0x7A7554")]
		public float headClampWeight;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A75A8", Offset = "0x7A75A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A75A8", Offset = "0x7A75A8")]
		public float bendWeight;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A75FC", Offset = "0x7A75FC")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A7634", Offset = "0x7A7634")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7634", Offset = "0x7A7634")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7634", Offset = "0x7A7634")]
		public float CCDWeight;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A76AC", Offset = "0x7A76AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A76AC", Offset = "0x7A76AC")]
		public float roll;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7700", Offset = "0x7A7700")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7700", Offset = "0x7A7700")]
		public float damper;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7758", Offset = "0x7A7758")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A7790", Offset = "0x7A7790")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7790", Offset = "0x7A7790")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7790", Offset = "0x7A7790")]
		public float postStretchWeight;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7808", Offset = "0x7A7808")]
		public float maxStretch;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7840", Offset = "0x7A7840")]
		public float stretchDamper;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7878", Offset = "0x7A7878")]
		public bool fixHead;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A78B0", Offset = "0x7A78B0")]
		public Transform[] stretchBones;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A78E8", Offset = "0x7A78E8")]
		public Vector3 chestDirection;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7920", Offset = "0x7A7920")]
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
		[Address(RVA = "0xF45A70", Offset = "0xF45A70", VA = "0xF45A70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF45FF8", Offset = "0xF45FF8", VA = "0xF45FF8")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF46730", Offset = "0xF46730", VA = "0xF46730")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF46D94", Offset = "0xF46D94", VA = "0xF46D94")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xF47A48", Offset = "0xF47A48", VA = "0xF47A48")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xF47EB8", Offset = "0xF47EB8", VA = "0xF47EB8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xF48398", Offset = "0xF48398", VA = "0xF48398")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xF490E0", Offset = "0xF490E0", VA = "0xF490E0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xF476BC", Offset = "0xF476BC", VA = "0xF476BC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xF493C8", Offset = "0xF493C8", VA = "0xF493C8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xF48F60", Offset = "0xF48F60", VA = "0xF48F60")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF48DC4", Offset = "0xF48DC4", VA = "0xF48DC4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xF4982C", Offset = "0xF4982C", VA = "0xF4982C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xF49CCC", Offset = "0xF49CCC", VA = "0xF49CCC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAFF4", Offset = "0x7AAFF4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB004", Offset = "0x7AB004")]
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
				[Address(RVA = "0xF4E648", Offset = "0xF4E648", VA = "0xF4E648")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B017C", Offset = "0x7B017C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0xF4E650", Offset = "0xF4E650", VA = "0xF4E650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B018C", Offset = "0x7B018C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public bool isRigid
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0xF4E658", Offset = "0xF4E658", VA = "0xF4E658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B019C", Offset = "0x7B019C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0xF4E660", Offset = "0xF4E660", VA = "0xF4E660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B01AC", Offset = "0x7B01AC")]
				private set
				{
				}
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xF4E66C", Offset = "0xF4E66C", VA = "0xF4E66C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xF4B0D4", Offset = "0xF4B0D4", VA = "0xF4B0D4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xF4BA58", Offset = "0xF4BA58", VA = "0xF4BA58")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xF4E1FC", Offset = "0xF4E1FC", VA = "0xF4E1FC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7938", Offset = "0x7A7938")]
		public float pin;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7950", Offset = "0x7A7950")]
		public float pull;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7968", Offset = "0x7A7968")]
		public float push;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7980", Offset = "0x7A7980")]
		public float pushParent;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7998", Offset = "0x7A7998")]
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
		[Address(RVA = "0xF49F70", Offset = "0xF49F70", VA = "0xF49F70")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xF4A03C", Offset = "0xF4A03C", VA = "0xF4A03C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xF4A148", Offset = "0xF4A148", VA = "0xF4A148")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xF4A298", Offset = "0xF4A298", VA = "0xF4A298")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xF4A398", Offset = "0xF4A398", VA = "0xF4A398")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xF4A4B8", Offset = "0xF4A4B8", VA = "0xF4A4B8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xF4B14C", Offset = "0xF4B14C", VA = "0xF4B14C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xF4A74C", Offset = "0xF4A74C", VA = "0xF4A74C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xF4BD38", Offset = "0xF4BD38", VA = "0xF4BD38")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xF4C210", Offset = "0xF4C210", VA = "0xF4C210")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xF4C740", Offset = "0xF4C740", VA = "0xF4C740")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xF4CE54", Offset = "0xF4CE54", VA = "0xF4CE54")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xF4D944", Offset = "0xF4D944", VA = "0xF4D944")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xF4DDF4", Offset = "0xF4DDF4", VA = "0xF4DDF4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xF4D83C", Offset = "0xF4D83C", VA = "0xF4D83C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xF4CC3C", Offset = "0xF4CC3C", VA = "0xF4CC3C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xF4D794", Offset = "0xF4D794", VA = "0xF4D794")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xF4E018", Offset = "0xF4E018", VA = "0xF4E018")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xF4D54C", Offset = "0xF4D54C", VA = "0xF4D54C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xF4DB68", Offset = "0xF4DB68", VA = "0xF4DB68")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A79B0", Offset = "0x7A79B0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A79C8", Offset = "0x7A79C8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000023")]
		public bool initiated
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x15742E0", Offset = "0x15742E0", VA = "0x15742E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF19C", Offset = "0x7AF19C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x15742E8", Offset = "0x15742E8", VA = "0x15742E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF1AC", Offset = "0x7AF1AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1574100", Offset = "0x1574100", VA = "0x1574100")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x15742F4", Offset = "0x15742F4", VA = "0x15742F4")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1574378", Offset = "0x1574378", VA = "0x1574378")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1574424", Offset = "0x1574424", VA = "0x1574424")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1574430", Offset = "0x1574430", VA = "0x1574430")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1574A10", Offset = "0x1574A10", VA = "0x1574A10")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1574C48", Offset = "0x1574C48", VA = "0x1574C48")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x15751C0", Offset = "0x15751C0", VA = "0x15751C0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1574770", Offset = "0x1574770", VA = "0x1574770")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x15748C0", Offset = "0x15748C0", VA = "0x15748C0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A79D8", Offset = "0x7A79D8")]
		public float positionWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A79F0", Offset = "0x7A79F0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A7A08", Offset = "0x7A7A08")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7A18", Offset = "0x7A7A18")]
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
			[Address(RVA = "0x15758E8", Offset = "0x15758E8", VA = "0x15758E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF1BC", Offset = "0x7AF1BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x15758F0", Offset = "0x15758F0", VA = "0x15758F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF1CC", Offset = "0x7AF1CC")]
			private set
			{
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1575838", Offset = "0x1575838", VA = "0x1575838")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x15758FC", Offset = "0x15758FC", VA = "0x15758FC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x15759E4", Offset = "0x15759E4", VA = "0x15759E4")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1575B20", Offset = "0x1575B20", VA = "0x1575B20")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1575C78", Offset = "0x1575C78", VA = "0x1575C78")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1575FD0", Offset = "0x1575FD0", VA = "0x1575FD0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1576380", Offset = "0x1576380", VA = "0x1576380")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x157655C", Offset = "0x157655C", VA = "0x157655C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x157661C", Offset = "0x157661C", VA = "0x157661C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1576E20", Offset = "0x1576E20", VA = "0x1576E20")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1576E90", Offset = "0x1576E90", VA = "0x1576E90")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x15770FC", Offset = "0x15770FC", VA = "0x15770FC")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x157756C", Offset = "0x157756C", VA = "0x157756C")]
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
				[Address(RVA = "0x1577F14", Offset = "0x1577F14", VA = "0x1577F14")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000083")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x15780DC", Offset = "0x15780DC", VA = "0x15780DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000084")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000612")]
				[Address(RVA = "0x1578794", Offset = "0x1578794", VA = "0x1578794")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1577EC0", Offset = "0x1577EC0", VA = "0x1577EC0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1577FE8", Offset = "0x1577FE8", VA = "0x1577FE8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x157804C", Offset = "0x157804C", VA = "0x157804C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x15780EC", Offset = "0x15780EC", VA = "0x15780EC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x15781F0", Offset = "0x15781F0", VA = "0x15781F0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x15781F8", Offset = "0x15781F8", VA = "0x15781F8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x15783B0", Offset = "0x15783B0", VA = "0x15783B0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x15784C4", Offset = "0x15784C4", VA = "0x15784C4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x15785C4", Offset = "0x15785C4", VA = "0x15785C4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1578A08", Offset = "0x1578A08", VA = "0x1578A08")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1578A48", Offset = "0x1578A48", VA = "0x1578A48")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1578A88", Offset = "0x1578A88", VA = "0x1578A88")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1578ADC", Offset = "0x1578ADC", VA = "0x1578ADC")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1578C50", Offset = "0x1578C50", VA = "0x1578C50")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1579010", Offset = "0x1579010", VA = "0x1579010")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x157906C", Offset = "0x157906C", VA = "0x157906C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x157923C", Offset = "0x157923C", VA = "0x157923C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x15792B4", Offset = "0x15792B4", VA = "0x15792B4")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x1579550", Offset = "0x1579550", VA = "0x1579550")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x15797D0", Offset = "0x15797D0", VA = "0x15797D0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1579918", Offset = "0x1579918", VA = "0x1579918")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1578DB4", Offset = "0x1578DB4", VA = "0x1578DB4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1579B38", Offset = "0x1579B38", VA = "0x1579B38")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1577C6C", Offset = "0x1577C6C", VA = "0x1577C6C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1577C74", Offset = "0x1577C74", VA = "0x1577C74", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1577C78", Offset = "0x1577C78", VA = "0x1577C78")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1577DB0", Offset = "0x1577DB0", VA = "0x1577DB0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1577EB8", Offset = "0x1577EB8", VA = "0x1577EB8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7A30", Offset = "0x7A7A30")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1579B50", Offset = "0x1579B50", VA = "0x1579B50", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1579BF0", Offset = "0x1579BF0", VA = "0x1579BF0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1579C74", Offset = "0x1579C74", VA = "0x1579C74")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1579D0C", Offset = "0x1579D0C", VA = "0x1579D0C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1579D38", Offset = "0x1579D38", VA = "0x1579D38")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1579D68", Offset = "0x1579D68", VA = "0x1579D68", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1579E14", Offset = "0x1579E14", VA = "0x1579E14")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1579E40", Offset = "0x1579E40", VA = "0x1579E40")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7A48", Offset = "0x7A7A48")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7A60", Offset = "0x7A7A60")]
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
		[Address(RVA = "0x1579E80", Offset = "0x1579E80", VA = "0x1579E80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1579F04", Offset = "0x1579F04", VA = "0x1579F04")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1579FD8", Offset = "0x1579FD8", VA = "0x1579FD8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x157A3A8", Offset = "0x157A3A8", VA = "0x157A3A8")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x157A4A8", Offset = "0x157A4A8", VA = "0x157A4A8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x157A5D4", Offset = "0x157A5D4", VA = "0x157A5D4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x157A5E0", Offset = "0x157A5E0", VA = "0x157A5E0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x157A6B4", Offset = "0x157A6B4", VA = "0x157A6B4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x157A798", Offset = "0x157A798", VA = "0x157A798", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x157AAB4", Offset = "0x157AAB4", VA = "0x157AAB4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x157AB8C", Offset = "0x157AB8C", VA = "0x157AB8C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7A78", Offset = "0x7A7A78")]
		public int iterations;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7A90", Offset = "0x7A7A90")]
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
		[Address(RVA = "0x157ADBC", Offset = "0x157ADBC", VA = "0x157ADBC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x157B0E0", Offset = "0x157B0E0", VA = "0x157B0E0")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x157B1FC", Offset = "0x157B1FC", VA = "0x157B1FC")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x157B34C", Offset = "0x157B34C", VA = "0x157B34C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x157B35C", Offset = "0x157B35C", VA = "0x157B35C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x157B3F4", Offset = "0x157B3F4", VA = "0x157B3F4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x157B4C4", Offset = "0x157B4C4", VA = "0x157B4C4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x157BEE8", Offset = "0x157BEE8", VA = "0x157BEE8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x157BF34", Offset = "0x157BF34", VA = "0x157BF34")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x157C418", Offset = "0x157C418", VA = "0x157C418")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x157CA5C", Offset = "0x157CA5C", VA = "0x157CA5C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x157CCB8", Offset = "0x157CCB8", VA = "0x157CCB8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x157CECC", Offset = "0x157CECC", VA = "0x157CECC")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB014", Offset = "0x7AB014")]
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
			[Address(RVA = "0x157F578", Offset = "0x157F578", VA = "0x157F578")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x157F5DC", Offset = "0x157F5DC", VA = "0x157F5DC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x157F7AC", Offset = "0x157F7AC", VA = "0x157F7AC")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x157F7EC", Offset = "0x157F7EC", VA = "0x157F7EC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x157F82C", Offset = "0x157F82C", VA = "0x157F82C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x157F890", Offset = "0x157F890", VA = "0x157F890")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x157EE6C", Offset = "0x157EE6C", VA = "0x157EE6C")]
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
				[Address(RVA = "0x157E260", Offset = "0x157E260", VA = "0x157E260")]
				get
				{
					return null;
				}
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x157E35C", Offset = "0x157E35C", VA = "0x157E35C")]
				set
				{
				}
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x157E3E4", Offset = "0x157E3E4", VA = "0x157E3E4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x157E6EC", Offset = "0x157E6EC", VA = "0x157E6EC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x157EAE4", Offset = "0x157EAE4", VA = "0x157EAE4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x157ED94", Offset = "0x157ED94", VA = "0x157ED94")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x157EDE8", Offset = "0x157EDE8", VA = "0x157EDE8")]
			public Bone()
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x157EEEC", Offset = "0x157EEEC", VA = "0x157EEEC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x157EF84", Offset = "0x157EF84", VA = "0x157EF84")]
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
			[Address(RVA = "0x157F514", Offset = "0x157F514", VA = "0x157F514")]
			public Node()
			{
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x157F518", Offset = "0x157F518", VA = "0x157F518")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x157F540", Offset = "0x157F540", VA = "0x157F540")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7AB8", Offset = "0x7A7AB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7AB8", Offset = "0x7A7AB8")]
		public float IKPositionWeight;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A7B0C", Offset = "0x7A7B0C")]
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
			[Address(RVA = "0x156CB6C", Offset = "0x156CB6C", VA = "0x156CB6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF1DC", Offset = "0x7AF1DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x157D85C", Offset = "0x157D85C", VA = "0x157D85C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF1EC", Offset = "0x7AF1EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x157D3E0", Offset = "0x157D3E0", VA = "0x157D3E0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1573F3C", Offset = "0x1573F3C", VA = "0x1573F3C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1573E54", Offset = "0x1573E54", VA = "0x1573E54")]
		public void Update()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x157D868", Offset = "0x157D868", VA = "0x157D868", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x157D874", Offset = "0x157D874", VA = "0x157D874")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x157D880", Offset = "0x157D880", VA = "0x157D880")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x157D888", Offset = "0x157D888", VA = "0x157D888")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x15726BC", Offset = "0x15726BC", VA = "0x15726BC")]
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
		[Address(RVA = "0x157D90C", Offset = "0x157D90C", VA = "0x157D90C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x157D924", Offset = "0x157D924", VA = "0x157D924")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x157DAA0", Offset = "0x157DAA0", VA = "0x157DAA0")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x157DB74", Offset = "0x157DB74", VA = "0x157DB74")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x157E248", Offset = "0x157E248", VA = "0x157E248")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7B54", Offset = "0x7A7B54")]
		public float poleWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7B6C", Offset = "0x7A7B6C")]
		public float clampWeight;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7B84", Offset = "0x7A7B84")]
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
			[Address(RVA = "0x157FA3C", Offset = "0x157FA3C", VA = "0x157FA3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x157FB10", Offset = "0x157FB10", VA = "0x157FB10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000028")]
		protected override int minBones
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x1580AFC", Offset = "0x1580AFC", VA = "0x1580AFC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x158118C", Offset = "0x158118C", VA = "0x158118C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x157F934", Offset = "0x157F934", VA = "0x157F934")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x157FBE4", Offset = "0x157FBE4", VA = "0x157FBE4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x157FEEC", Offset = "0x157FEEC", VA = "0x157FEEC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1580920", Offset = "0x1580920", VA = "0x1580920")]
		private void Solve()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x15804F8", Offset = "0x15804F8", VA = "0x15804F8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1580B04", Offset = "0x1580B04", VA = "0x1580B04")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1581294", Offset = "0x1581294", VA = "0x1581294")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7B9C", Offset = "0x7A7B9C")]
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
		[Address(RVA = "0x158132C", Offset = "0x158132C", VA = "0x158132C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x15817C4", Offset = "0x15817C4", VA = "0x15817C4")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1581884", Offset = "0x1581884", VA = "0x1581884", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1581A70", Offset = "0x1581A70", VA = "0x1581A70", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1581C2C", Offset = "0x1581C2C", VA = "0x1581C2C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1581CA4", Offset = "0x1581CA4", VA = "0x1581CA4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1581D30", Offset = "0x1581D30", VA = "0x1581D30", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x15823B8", Offset = "0x15823B8", VA = "0x15823B8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x15823E4", Offset = "0x15823E4", VA = "0x15823E4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1581DB8", Offset = "0x1581DB8", VA = "0x1581DB8")]
		private void Read()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x158248C", Offset = "0x158248C", VA = "0x158248C")]
		private void Write()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x158278C", Offset = "0x158278C", VA = "0x158278C")]
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
		[Address(RVA = "0x15828DC", Offset = "0x15828DC", VA = "0x15828DC")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1582A34", Offset = "0x1582A34", VA = "0x1582A34", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1582AE8", Offset = "0x1582AE8", VA = "0x1582AE8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1582E40", Offset = "0x1582E40", VA = "0x1582E40")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x158390C", Offset = "0x158390C", VA = "0x158390C")]
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
			[Address(RVA = "0x1585314", Offset = "0x1585314", VA = "0x1585314", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1583914", Offset = "0x1583914", VA = "0x1583914")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x158452C", Offset = "0x158452C", VA = "0x158452C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1584664", Offset = "0x1584664", VA = "0x1584664", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1584708", Offset = "0x1584708", VA = "0x1584708", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1584F64", Offset = "0x1584F64", VA = "0x1584F64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x158531C", Offset = "0x158531C", VA = "0x158531C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x15839E8", Offset = "0x15839E8", VA = "0x15839E8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1584610", Offset = "0x1584610", VA = "0x1584610")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x158529C", Offset = "0x158529C", VA = "0x158529C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1584180", Offset = "0x1584180", VA = "0x1584180")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1585FD0", Offset = "0x1585FD0", VA = "0x1585FD0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x15860F8", Offset = "0x15860F8", VA = "0x15860F8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1586290", Offset = "0x1586290", VA = "0x1586290")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1586428", Offset = "0x1586428", VA = "0x1586428")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1584BCC", Offset = "0x1584BCC", VA = "0x1584BCC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1584D98", Offset = "0x1584D98", VA = "0x1584D98")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x15866C8", Offset = "0x15866C8", VA = "0x15866C8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x15857F0", Offset = "0x15857F0", VA = "0x15857F0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1584600", Offset = "0x1584600", VA = "0x1584600")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x15871D0", Offset = "0x15871D0", VA = "0x15871D0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x15868C0", Offset = "0x15868C0", VA = "0x15868C0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1585434", Offset = "0x1585434", VA = "0x1585434")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1585614", Offset = "0x1585614", VA = "0x1585614")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x15873E8", Offset = "0x15873E8", VA = "0x15873E8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7BB4", Offset = "0x7A7BB4")]
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
		[Address(RVA = "0x1587460", Offset = "0x1587460", VA = "0x1587460", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x15883BC", Offset = "0x15883BC", VA = "0x15883BC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x15884A0", Offset = "0x15884A0", VA = "0x15884A0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x15885A8", Offset = "0x15885A8", VA = "0x15885A8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1588714", Offset = "0x1588714", VA = "0x1588714")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x158886C", Offset = "0x158886C", VA = "0x158886C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1588FC4", Offset = "0x1588FC4", VA = "0x1588FC4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1589250", Offset = "0x1589250", VA = "0x1589250", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1589098", Offset = "0x1589098", VA = "0x1589098")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1588BA0", Offset = "0x1588BA0", VA = "0x1588BA0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1589328", Offset = "0x1589328", VA = "0x1589328")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7BCC", Offset = "0x7A7BCC")]
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
		[Address(RVA = "0x1496CA0", Offset = "0x1496CA0", VA = "0x1496CA0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1496DD4", Offset = "0x1496DD4", VA = "0x1496DD4")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1496E40", Offset = "0x1496E40", VA = "0x1496E40")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1496FF4", Offset = "0x1496FF4", VA = "0x1496FF4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1497098", Offset = "0x1497098", VA = "0x1497098")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x149713C", Offset = "0x149713C", VA = "0x149713C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x149739C", Offset = "0x149739C", VA = "0x149739C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x14975C4", Offset = "0x14975C4", VA = "0x14975C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x149786C", Offset = "0x149786C", VA = "0x149786C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x14979B8", Offset = "0x14979B8", VA = "0x14979B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1497B1C", Offset = "0x1497B1C", VA = "0x1497B1C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1497D20", Offset = "0x1497D20", VA = "0x1497D20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1497F68", Offset = "0x1497F68", VA = "0x1497F68", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x14983C0", Offset = "0x14983C0", VA = "0x14983C0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x14989B0", Offset = "0x14989B0", VA = "0x14989B0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1498A14", Offset = "0x1498A14", VA = "0x1498A14", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1498B80", Offset = "0x1498B80", VA = "0x1498B80")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7BE4", Offset = "0x7A7BE4")]
		public float spineStiffness;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7BFC", Offset = "0x7A7BFC")]
		public float pullBodyVertical;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7C14", Offset = "0x7A7C14")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A7C2C", Offset = "0x7A7C2C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700002B")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1498C58", Offset = "0x1498C58", VA = "0x1498C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1498E70", Offset = "0x1498E70", VA = "0x1498E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1498E78", Offset = "0x1498E78", VA = "0x1498E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1498E80", Offset = "0x1498E80", VA = "0x1498E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1498E88", Offset = "0x1498E88", VA = "0x1498E88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1498E90", Offset = "0x1498E90", VA = "0x1498E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1498E98", Offset = "0x1498E98", VA = "0x1498E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1498EA0", Offset = "0x1498EA0", VA = "0x1498EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1498EA8", Offset = "0x1498EA8", VA = "0x1498EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1498EB0", Offset = "0x1498EB0", VA = "0x1498EB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1498EF8", Offset = "0x1498EF8", VA = "0x1498EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1498F40", Offset = "0x1498F40", VA = "0x1498F40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1498F88", Offset = "0x1498F88", VA = "0x1498F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1498FD0", Offset = "0x1498FD0", VA = "0x1498FD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x1499014", Offset = "0x1499014", VA = "0x1499014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x149905C", Offset = "0x149905C", VA = "0x149905C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x14990A4", Offset = "0x14990A4", VA = "0x14990A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x14990EC", Offset = "0x14990EC", VA = "0x14990EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x149C110", Offset = "0x149C110", VA = "0x149C110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF1FC", Offset = "0x7AF1FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x149C11C", Offset = "0x149C11C", VA = "0x149C11C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF20C", Offset = "0x7AF20C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1499130", Offset = "0x1499130", VA = "0x1499130")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x14992A8", Offset = "0x14992A8", VA = "0x14992A8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1499198", Offset = "0x1499198", VA = "0x1499198")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1499398", Offset = "0x1499398", VA = "0x1499398")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1498C60", Offset = "0x1498C60", VA = "0x1498C60")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x14994D8", Offset = "0x14994D8", VA = "0x14994D8")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x14995E8", Offset = "0x14995E8", VA = "0x14995E8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x14996F4", Offset = "0x14996F4", VA = "0x14996F4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1499800", Offset = "0x1499800", VA = "0x1499800")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1499808", Offset = "0x1499808", VA = "0x1499808")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x149984C", Offset = "0x149984C", VA = "0x149984C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1499970", Offset = "0x1499970", VA = "0x1499970", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1499C3C", Offset = "0x1499C3C", VA = "0x1499C3C")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x149B870", Offset = "0x149B870", VA = "0x149B870")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x149BE08", Offset = "0x149BE08", VA = "0x149BE08")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x149BEC8", Offset = "0x149BEC8", VA = "0x149BEC8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x149BC38", Offset = "0x149BC38", VA = "0x149BC38")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x149BD20", Offset = "0x149BD20", VA = "0x149BD20")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x149C128", Offset = "0x149C128", VA = "0x149C128")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x149C200", Offset = "0x149C200", VA = "0x149C200", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x149C3FC", Offset = "0x149C3FC", VA = "0x149C3FC")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x149C5BC", Offset = "0x149C5BC", VA = "0x149C5BC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x149C7C4", Offset = "0x149C7C4", VA = "0x149C7C4")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x149CA38", Offset = "0x149CA38", VA = "0x149CA38", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x149CF50", Offset = "0x149CF50", VA = "0x149CF50", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x149D08C", Offset = "0x149D08C", VA = "0x149D08C")]
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
			[Address(RVA = "0x149DB24", Offset = "0x149DB24", VA = "0x149DB24", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x149DB2C", Offset = "0x149DB2C", VA = "0x149DB2C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x149DB34", Offset = "0x149DB34", VA = "0x149DB34", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x149E37C", Offset = "0x149E37C", VA = "0x149E37C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000042")]
		protected float positionOffset
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x149E55C", Offset = "0x149E55C", VA = "0x149E55C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x149D098", Offset = "0x149D098", VA = "0x149D098")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x149D2B0", Offset = "0x149D2B0", VA = "0x149D2B0")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x149D47C", Offset = "0x149D47C", VA = "0x149D47C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x149D518", Offset = "0x149D518", VA = "0x149D518", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x149D5CC", Offset = "0x149D5CC", VA = "0x149D5CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x149D9E8", Offset = "0x149D9E8", VA = "0x149D9E8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x149D9F0", Offset = "0x149D9F0", VA = "0x149D9F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x149DB3C", Offset = "0x149DB3C", VA = "0x149DB3C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x149DB40", Offset = "0x149DB40", VA = "0x149DB40", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x149DB44", Offset = "0x149DB44", VA = "0x149DB44")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x149E620", Offset = "0x149E620", VA = "0x149E620")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x149EAF0", Offset = "0x149EAF0", VA = "0x149EAF0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x149EE68", Offset = "0x149EE68", VA = "0x149EE68")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7C3C", Offset = "0x7A7C3C")]
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
		[Address(RVA = "0x149EED8", Offset = "0x149EED8", VA = "0x149EED8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x149F370", Offset = "0x149F370", VA = "0x149F370")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x149F438", Offset = "0x149F438", VA = "0x149F438", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x149F624", Offset = "0x149F624", VA = "0x149F624", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x149F7E0", Offset = "0x149F7E0", VA = "0x149F7E0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x149F868", Offset = "0x149F868", VA = "0x149F868", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x149F908", Offset = "0x149F908", VA = "0x149F908", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x149FF90", Offset = "0x149FF90", VA = "0x149FF90", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x149FFBC", Offset = "0x149FFBC", VA = "0x149FFBC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x149F990", Offset = "0x149F990", VA = "0x149F990")]
		private void Read()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x14A00F4", Offset = "0x14A00F4", VA = "0x14A00F4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x14A0BA0", Offset = "0x14A0BA0", VA = "0x14A0BA0")]
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
			[Address(RVA = "0x8785F8", Offset = "0x8785F8", VA = "0x8785F8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7C54", Offset = "0x7A7C54")]
		public float maintainRotationWeight;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7C6C", Offset = "0x7A7C6C")]
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
			[Address(RVA = "0x14A280C", Offset = "0x14A280C", VA = "0x14A280C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x14A0DE8", Offset = "0x14A0DE8", VA = "0x14A0DE8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x14A0E4C", Offset = "0x14A0E4C", VA = "0x14A0E4C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x14A0F74", Offset = "0x14A0F74", VA = "0x14A0F74", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x14A16F8", Offset = "0x14A16F8", VA = "0x14A16F8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x14A245C", Offset = "0x14A245C", VA = "0x14A245C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x14A2600", Offset = "0x14A2600", VA = "0x14A2600")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x14A2784", Offset = "0x14A2784", VA = "0x14A2784")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x14A13B4", Offset = "0x14A13B4", VA = "0x14A13B4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x14A1834", Offset = "0x14A1834", VA = "0x14A1834")]
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
				[Address(RVA = "0x14A4D90", Offset = "0x14A4D90", VA = "0x14A4D90")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x14A55E4", Offset = "0x14A55E4", VA = "0x14A55E4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x14A3DF8", Offset = "0x14A3DF8", VA = "0x14A3DF8")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x14A423C", Offset = "0x14A423C", VA = "0x14A423C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x14A5254", Offset = "0x14A5254", VA = "0x14A5254")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7C84", Offset = "0x7A7C84")]
		public float bodyWeight;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7C9C", Offset = "0x7A7C9C")]
		public float headWeight;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7CB4", Offset = "0x7A7CB4")]
		public float eyesWeight;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7CCC", Offset = "0x7A7CCC")]
		public float clampWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7CE4", Offset = "0x7A7CE4")]
		public float clampWeightHead;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7CFC", Offset = "0x7A7CFC")]
		public float clampWeightEyes;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7D14", Offset = "0x7A7D14")]
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
			[Address(RVA = "0x14A32CC", Offset = "0x14A32CC", VA = "0x14A32CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x14A356C", Offset = "0x14A356C", VA = "0x14A356C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		private bool headIsValid
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x14A3414", Offset = "0x14A3414", VA = "0x14A3414")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x14A35A0", Offset = "0x14A35A0", VA = "0x14A35A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x14A3424", Offset = "0x14A3424", VA = "0x14A3424")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x14A3620", Offset = "0x14A3620", VA = "0x14A3620")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x14A2888", Offset = "0x14A2888", VA = "0x14A2888")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x14A290C", Offset = "0x14A290C", VA = "0x14A290C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x14A29B8", Offset = "0x14A29B8", VA = "0x14A29B8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x14A2A80", Offset = "0x14A2A80", VA = "0x14A2A80")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x14A2B6C", Offset = "0x14A2B6C", VA = "0x14A2B6C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x14A2C78", Offset = "0x14A2C78", VA = "0x14A2C78")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x14A2DC0", Offset = "0x14A2DC0", VA = "0x14A2DC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x14A2F60", Offset = "0x14A2F60", VA = "0x14A2F60", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x14A311C", Offset = "0x14A311C", VA = "0x14A311C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x14A3654", Offset = "0x14A3654", VA = "0x14A3654", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x14A3964", Offset = "0x14A3964", VA = "0x14A3964", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x14A3B24", Offset = "0x14A3B24", VA = "0x14A3B24")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x14A3E24", Offset = "0x14A3E24", VA = "0x14A3E24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x14A4388", Offset = "0x14A4388", VA = "0x14A4388", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x14A4494", Offset = "0x14A4494", VA = "0x14A4494")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x14A4790", Offset = "0x14A4790", VA = "0x14A4790")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x14A4A8C", Offset = "0x14A4A8C", VA = "0x14A4A8C")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x14A4E64", Offset = "0x14A4E64", VA = "0x14A4E64")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x14A3BD8", Offset = "0x14A3BD8", VA = "0x14A3BD8")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x14A53EC", Offset = "0x14A53EC", VA = "0x14A53EC")]
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
			[Address(RVA = "0x14A7008", Offset = "0x14A7008", VA = "0x14A7008")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x14A7E94", Offset = "0x14A7E94", VA = "0x14A7E94")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x14A0EA0", Offset = "0x14A0EA0", VA = "0x14A0EA0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x14A7F5C", Offset = "0x14A7F5C", VA = "0x14A7F5C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7D2C", Offset = "0x7A7D2C")]
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
		[Address(RVA = "0x14A55EC", Offset = "0x14A55EC", VA = "0x14A55EC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x14A5810", Offset = "0x14A5810", VA = "0x14A5810")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x14A5A18", Offset = "0x14A5A18", VA = "0x14A5A18")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x14A5A24", Offset = "0x14A5A24", VA = "0x14A5A24")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x14A5AA8", Offset = "0x14A5AA8", VA = "0x14A5AA8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x14A5AB4", Offset = "0x14A5AB4", VA = "0x14A5AB4")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x14A5ABC", Offset = "0x14A5ABC", VA = "0x14A5ABC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x14A5C10", Offset = "0x14A5C10", VA = "0x14A5C10", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x14A5D44", Offset = "0x14A5D44", VA = "0x14A5D44", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x14A5DB0", Offset = "0x14A5DB0", VA = "0x14A5DB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x14A5E34", Offset = "0x14A5E34", VA = "0x14A5E34", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x14A6324", Offset = "0x14A6324", VA = "0x14A6324")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x14A63B4", Offset = "0x14A63B4", VA = "0x14A63B4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x14A6A40", Offset = "0x14A6A40", VA = "0x14A6A40")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x14A6C58", Offset = "0x14A6C58", VA = "0x14A6C58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x14A6ECC", Offset = "0x14A6ECC", VA = "0x14A6ECC")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x14A6DB4", Offset = "0x14A6DB4", VA = "0x14A6DB4")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x14A71C8", Offset = "0x14A71C8", VA = "0x14A71C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x14A7F50", Offset = "0x14A7F50", VA = "0x14A7F50", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x14A7F54", Offset = "0x14A7F54", VA = "0x14A7F54", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x14A7F58", Offset = "0x14A7F58", VA = "0x14A7F58", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x14A7B5C", Offset = "0x14A7B5C", VA = "0x14A7B5C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x14A2674", Offset = "0x14A2674", VA = "0x14A2674")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB02C", Offset = "0x7AB02C")]
			public Transform target;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB064", Offset = "0x7AB064")]
			public Transform bendGoal;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB09C", Offset = "0x7AB09C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB09C", Offset = "0x7AB09C")]
			public float positionWeight;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB0F0", Offset = "0x7AB0F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB0F0", Offset = "0x7AB0F0")]
			public float rotationWeight;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB144", Offset = "0x7AB144")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB17C", Offset = "0x7AB17C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB17C", Offset = "0x7AB17C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB1D0", Offset = "0x7AB1D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB1D0", Offset = "0x7AB1D0")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB224", Offset = "0x7AB224")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB224", Offset = "0x7AB224")]
			public float bendGoalWeight;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB278", Offset = "0x7AB278")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB278", Offset = "0x7AB278")]
			public float swivelOffset;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB2D4", Offset = "0x7AB2D4")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB30C", Offset = "0x7AB30C")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB344", Offset = "0x7AB344")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB344", Offset = "0x7AB344")]
			public float armLengthMlp;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB39C", Offset = "0x7AB39C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB414", Offset = "0x7AB414")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB424", Offset = "0x7AB424")]
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
				[Address(RVA = "0x14B1EE4", Offset = "0x14B1EE4", VA = "0x14B1EE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B01BC", Offset = "0x7B01BC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x14B1EF0", Offset = "0x14B1EF0", VA = "0x14B1EF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B01CC", Offset = "0x7B01CC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public Quaternion rotation
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x14B1EFC", Offset = "0x14B1EFC", VA = "0x14B1EFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B01DC", Offset = "0x7B01DC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x14B1F08", Offset = "0x14B1F08", VA = "0x14B1F08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B01EC", Offset = "0x7B01EC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x14B1F14", Offset = "0x14B1F14", VA = "0x14B1F14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x14B1F58", Offset = "0x14B1F58", VA = "0x14B1F58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x14B1FA8", Offset = "0x14B1FA8", VA = "0x14B1FA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x14B2004", Offset = "0x14B2004", VA = "0x14B2004")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x14B2060", Offset = "0x14B2060", VA = "0x14B2060", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x14B2A98", Offset = "0x14B2A98", VA = "0x14B2A98", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x14B2CE0", Offset = "0x14B2CE0", VA = "0x14B2CE0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x14B2D8C", Offset = "0x14B2D8C", VA = "0x14B2D8C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x14AFD90", Offset = "0x14AFD90", VA = "0x14AFD90")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x14B3B9C", Offset = "0x14B3B9C", VA = "0x14B3B9C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x14B3C0C", Offset = "0x14B3C0C", VA = "0x14B3C0C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x14B3274", Offset = "0x14B3274", VA = "0x14B3274")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x14B3354", Offset = "0x14B3354", VA = "0x14B3354")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x14B3F58", Offset = "0x14B3F58", VA = "0x14B3F58")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x14B1CD4", Offset = "0x14B1CD4", VA = "0x14B1CD4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB434", Offset = "0x7AB434")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB444", Offset = "0x7AB444")]
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
				[Address(RVA = "0x14B4148", Offset = "0x14B4148", VA = "0x14B4148")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B01FC", Offset = "0x7B01FC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x14B4150", Offset = "0x14B4150", VA = "0x14B4150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B020C", Offset = "0x7B020C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public float mag
			{
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x14B334C", Offset = "0x14B334C", VA = "0x14B334C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B021C", Offset = "0x7B021C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x14B4158", Offset = "0x14B4158", VA = "0x14B4158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B022C", Offset = "0x7B022C")]
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
			[Address(RVA = "0x14A0A54", Offset = "0x14A0A54", VA = "0x14A0A54")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x14B4160", Offset = "0x14B4160", VA = "0x14B4160")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x14B42F8", Offset = "0x14B42F8", VA = "0x14B42F8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x14B43F8", Offset = "0x14B43F8", VA = "0x14B43F8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x14AFB2C", Offset = "0x14AFB2C", VA = "0x14AFB2C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x14B3980", Offset = "0x14B3980", VA = "0x14B3980")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x14B444C", Offset = "0x14B444C", VA = "0x14B444C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x14B45EC", Offset = "0x14B45EC", VA = "0x14B45EC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x14B40B0", Offset = "0x14B40B0", VA = "0x14B40B0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB464", Offset = "0x7AB464")]
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
				[Address(RVA = "0x14B4614", Offset = "0x14B4614", VA = "0x14B4614")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000090")]
			public float stepProgress
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x14B4628", Offset = "0x14B4628", VA = "0x14B4628")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B023C", Offset = "0x7B023C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x14B4630", Offset = "0x14B4630", VA = "0x14B4630")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B024C", Offset = "0x7B024C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x14B4638", Offset = "0x14B4638", VA = "0x14B4638")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x14B47CC", Offset = "0x14B47CC", VA = "0x14B47CC")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x14B4814", Offset = "0x14B4814", VA = "0x14B4814")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x14B4920", Offset = "0x14B4920", VA = "0x14B4920")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x14B4AF8", Offset = "0x14B4AF8", VA = "0x14B4AF8")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x14B4CE4", Offset = "0x14B4CE4", VA = "0x14B4CE4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB474", Offset = "0x7AB474")]
			public Transform target;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB4AC", Offset = "0x7AB4AC")]
			public Transform bendGoal;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB4E4", Offset = "0x7AB4E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB4E4", Offset = "0x7AB4E4")]
			public float positionWeight;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB538", Offset = "0x7AB538")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB538", Offset = "0x7AB538")]
			public float rotationWeight;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB58C", Offset = "0x7AB58C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB58C", Offset = "0x7AB58C")]
			public float bendGoalWeight;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB5E0", Offset = "0x7AB5E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB5E0", Offset = "0x7AB5E0")]
			public float swivelOffset;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB63C", Offset = "0x7AB63C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB63C", Offset = "0x7AB63C")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB690", Offset = "0x7AB690")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB690", Offset = "0x7AB690")]
			public float legLengthMlp;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB6E8", Offset = "0x7AB6E8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB780", Offset = "0x7AB780")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB790", Offset = "0x7AB790")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB7A0", Offset = "0x7AB7A0")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB7B0", Offset = "0x7AB7B0")]
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
				[Address(RVA = "0x14AF9A8", Offset = "0x14AF9A8", VA = "0x14AF9A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B025C", Offset = "0x7B025C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x14B4F04", Offset = "0x14B4F04", VA = "0x14B4F04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B026C", Offset = "0x7B026C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000669")]
				[Address(RVA = "0x14B4F10", Offset = "0x14B4F10", VA = "0x14B4F10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B027C", Offset = "0x7B027C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x14B4F1C", Offset = "0x14B4F1C", VA = "0x14B4F1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B028C", Offset = "0x7B028C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public bool hasToes
			{
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x14B4F28", Offset = "0x14B4F28", VA = "0x14B4F28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B029C", Offset = "0x7B029C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600066C")]
				[Address(RVA = "0x14B4F30", Offset = "0x14B4F30", VA = "0x14B4F30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B02AC", Offset = "0x7B02AC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600066D")]
				[Address(RVA = "0x14B4F3C", Offset = "0x14B4F3C", VA = "0x14B4F3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone calf
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x14B4F80", Offset = "0x14B4F80", VA = "0x14B4F80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private VirtualBone foot
			{
				[Token(Token = "0x600066F")]
				[Address(RVA = "0x14B4FC8", Offset = "0x14B4FC8", VA = "0x14B4FC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000670")]
				[Address(RVA = "0x14B5010", Offset = "0x14B5010", VA = "0x14B5010")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x14AF94C", Offset = "0x14AF94C", VA = "0x14AF94C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x14B5058", Offset = "0x14B5058", VA = "0x14B5058")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B02BC", Offset = "0x7B02BC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x14B5064", Offset = "0x14B5064", VA = "0x14B5064")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B02CC", Offset = "0x7B02CC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x14B5070", Offset = "0x14B5070", VA = "0x14B5070", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x14B5888", Offset = "0x14B5888", VA = "0x14B5888", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x14B611C", Offset = "0x14B611C", VA = "0x14B611C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x14B6018", Offset = "0x14B6018", VA = "0x14B6018")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x14B5DE0", Offset = "0x14B5DE0", VA = "0x14B5DE0")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x14A03F4", Offset = "0x14A03F4", VA = "0x14A03F4")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x14B6734", Offset = "0x14B6734", VA = "0x14B6734")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x14B6D18", Offset = "0x14B6D18", VA = "0x14B6D18", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x14B7060", Offset = "0x14B7060", VA = "0x14B7060", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x14A0CF4", Offset = "0x14A0CF4", VA = "0x14A0CF4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB7C0", Offset = "0x7AB7C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB7C0", Offset = "0x7AB7C0")]
			public float weight;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB814", Offset = "0x7AB814")]
			public float footDistance;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB84C", Offset = "0x7AB84C")]
			public float stepThreshold;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB884", Offset = "0x7AB884")]
			public float angleThreshold;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB8BC", Offset = "0x7AB8BC")]
			public float comAngleMlp;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB8F4", Offset = "0x7AB8F4")]
			public float maxVelocity;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB92C", Offset = "0x7AB92C")]
			public float velocityFactor;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB964", Offset = "0x7AB964")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB964", Offset = "0x7AB964")]
			public float maxLegStretch;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB9BC", Offset = "0x7AB9BC")]
			public float rootSpeed;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AB9F4", Offset = "0x7AB9F4")]
			public float stepSpeed;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABA2C", Offset = "0x7ABA2C")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABA64", Offset = "0x7ABA64")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABA9C", Offset = "0x7ABA9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABA9C", Offset = "0x7ABA9C")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABAF4", Offset = "0x7ABAF4")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABB2C", Offset = "0x7ABB2C")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABB64", Offset = "0x7ABB64")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABBDC", Offset = "0x7ABBDC")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABC14", Offset = "0x7ABC14")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ABC4C", Offset = "0x7ABC4C")]
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
				[Address(RVA = "0x14B7110", Offset = "0x14B7110", VA = "0x14B7110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B02DC", Offset = "0x7B02DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x14B711C", Offset = "0x14B711C", VA = "0x14B711C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B02EC", Offset = "0x7B02EC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x14B7590", Offset = "0x14B7590", VA = "0x14B7590")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x14B75E8", Offset = "0x14B75E8", VA = "0x14B75E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x14B7644", Offset = "0x14B7644", VA = "0x14B7644")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700009E")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000688")]
				[Address(RVA = "0x14B769C", Offset = "0x14B769C", VA = "0x14B769C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x14AD40C", Offset = "0x14AD40C", VA = "0x14AD40C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x14AA6F8", Offset = "0x14AA6F8", VA = "0x14AA6F8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x14A9840", Offset = "0x14A9840", VA = "0x14A9840")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x14A9684", Offset = "0x14A9684", VA = "0x14A9684")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x14ADDD8", Offset = "0x14ADDD8", VA = "0x14ADDD8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x14B7178", Offset = "0x14B7178", VA = "0x14B7178")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x14B731C", Offset = "0x14B731C", VA = "0x14B731C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x14B73C4", Offset = "0x14B73C4", VA = "0x14B73C4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x14B1DFC", Offset = "0x14B1DFC", VA = "0x14B1DFC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABC5C", Offset = "0x7ABC5C")]
			public Transform headTarget;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABC94", Offset = "0x7ABC94")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABCCC", Offset = "0x7ABCCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABCCC", Offset = "0x7ABCCC")]
			public float positionWeight;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABD20", Offset = "0x7ABD20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABD20", Offset = "0x7ABD20")]
			public float rotationWeight;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABD74", Offset = "0x7ABD74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABD74", Offset = "0x7ABD74")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABDC8", Offset = "0x7ABDC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABDC8", Offset = "0x7ABDC8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABE1C", Offset = "0x7ABE1C")]
			public Transform chestGoal;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABE54", Offset = "0x7ABE54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABE54", Offset = "0x7ABE54")]
			public float chestGoalWeight;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABEA8", Offset = "0x7ABEA8")]
			public float minHeadHeight;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABEE0", Offset = "0x7ABEE0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABEE0", Offset = "0x7ABEE0")]
			public float bodyPosStiffness;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABF34", Offset = "0x7ABF34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABF34", Offset = "0x7ABF34")]
			public float bodyRotStiffness;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ABF88", Offset = "0x7ABF88")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7ABF88", Offset = "0x7ABF88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ABF88", Offset = "0x7ABF88")]
			public float neckStiffness;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC000", Offset = "0x7AC000")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC000", Offset = "0x7AC000")]
			public float rotateChestByHands;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC054", Offset = "0x7AC054")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC054", Offset = "0x7AC054")]
			public float chestClampWeight;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC0A8", Offset = "0x7AC0A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC0A8", Offset = "0x7AC0A8")]
			public float headClampWeight;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC0FC", Offset = "0x7AC0FC")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC134", Offset = "0x7AC134")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC134", Offset = "0x7AC134")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC188", Offset = "0x7AC188")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC188", Offset = "0x7AC188")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AC2C0", Offset = "0x7AC2C0")]
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
				[Address(RVA = "0x14AAAB8", Offset = "0x14AAAB8", VA = "0x14AAAB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x14B76F8", Offset = "0x14B76F8", VA = "0x14B76F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			public VirtualBone chest
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x14AFD28", Offset = "0x14AFD28", VA = "0x14AFD28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x14B7748", Offset = "0x14B7748", VA = "0x14B7748")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			public VirtualBone head
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x14B7128", Offset = "0x14B7128", VA = "0x14B7128")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x14B7798", Offset = "0x14B7798", VA = "0x14B7798")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B02FC", Offset = "0x7B02FC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x14B77AC", Offset = "0x14B77AC", VA = "0x14B77AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B030C", Offset = "0x7B030C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x14B77C0", Offset = "0x14B77C0", VA = "0x14B77C0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x14B8590", Offset = "0x14B8590", VA = "0x14B8590", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x14B87F0", Offset = "0x14B87F0", VA = "0x14B87F0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x14B8DB0", Offset = "0x14B8DB0", VA = "0x14B8DB0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x14AD7F4", Offset = "0x14AD7F4", VA = "0x14AD7F4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x14B97B4", Offset = "0x14B97B4", VA = "0x14B97B4")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x14B9F64", Offset = "0x14B9F64", VA = "0x14B9F64")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x14BA304", Offset = "0x14BA304", VA = "0x14BA304", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x14BA680", Offset = "0x14BA680", VA = "0x14BA680", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x14B8FE4", Offset = "0x14B8FE4", VA = "0x14B8FE4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x14AF9B4", Offset = "0x14AF9B4", VA = "0x14AF9B4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x14B939C", Offset = "0x14B939C", VA = "0x14B939C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x14BA778", Offset = "0x14BA778", VA = "0x14BA778")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x14B9CC0", Offset = "0x14B9CC0", VA = "0x14B9CC0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x14B99C8", Offset = "0x14B99C8", VA = "0x14B99C8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x14B1B08", Offset = "0x14B1B08", VA = "0x14B1B08")]
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
			[Address(RVA = "0x104C58C", Offset = "0x104C58C", VA = "0x104C58C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x104C608", Offset = "0x104C608", VA = "0x104C608")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x104C628", Offset = "0x104C628", VA = "0x104C628")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x104C964", Offset = "0x104C964", VA = "0x104C964")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x104CEA8", Offset = "0x104CEA8", VA = "0x104CEA8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x104D134", Offset = "0x104D134", VA = "0x104D134")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x104D43C", Offset = "0x104D43C", VA = "0x104D43C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x104D74C", Offset = "0x104D74C", VA = "0x104D74C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x104D84C", Offset = "0x104D84C", VA = "0x104D84C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x104DF70", Offset = "0x104DF70", VA = "0x104DF70")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x104E188", Offset = "0x104E188", VA = "0x104E188")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x104E7E8", Offset = "0x104E7E8", VA = "0x104E7E8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x104E8F0", Offset = "0x104E8F0", VA = "0x104E8F0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7D44", Offset = "0x7A7D44")]
		public bool plantFeet;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A7D7C", Offset = "0x7A7D7C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7D8C", Offset = "0x7A7D8C")]
		public Spine spine;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7DC4", Offset = "0x7A7DC4")]
		public Arm leftArm;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7DFC", Offset = "0x7A7DFC")]
		public Arm rightArm;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7E34", Offset = "0x7A7E34")]
		public Leg leftLeg;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7E6C", Offset = "0x7A7E6C")]
		public Leg rightLeg;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7EA4", Offset = "0x7A7EA4")]
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
			[Address(RVA = "0x14AA6F0", Offset = "0x14AA6F0", VA = "0x14AA6F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF21C", Offset = "0x7AF21C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x14AD404", Offset = "0x14AD404", VA = "0x14AD404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF22C", Offset = "0x7AF22C")]
			private set
			{
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x14A7F64", Offset = "0x14A7F64", VA = "0x14A7F64")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x14A84E4", Offset = "0x14A84E4", VA = "0x14A84E4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x14A8300", Offset = "0x14A8300", VA = "0x14A8300")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x14A90E8", Offset = "0x14A90E8", VA = "0x14A90E8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x14A9284", Offset = "0x14A9284", VA = "0x14A9284")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x14A9328", Offset = "0x14A9328", VA = "0x14A9328")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x14A94D0", Offset = "0x14A94D0", VA = "0x14A94D0")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x14A9C24", Offset = "0x14A9C24", VA = "0x14A9C24")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x14AAB08", Offset = "0x14AAB08", VA = "0x14AAB08", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x14AAD3C", Offset = "0x14AAD3C", VA = "0x14AAD3C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x14AAFA8", Offset = "0x14AAFA8", VA = "0x14AAFA8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x14AB01C", Offset = "0x14AB01C", VA = "0x14AB01C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x14AB090", Offset = "0x14AB090", VA = "0x14AB090", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x14AB2C0", Offset = "0x14AB2C0", VA = "0x14AB2C0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x14A88A4", Offset = "0x14A88A4", VA = "0x14A88A4")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x14A8A94", Offset = "0x14A8A94", VA = "0x14A8A94")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x14A8F70", Offset = "0x14A8F70", VA = "0x14A8F70")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x14A9DE0", Offset = "0x14A9DE0", VA = "0x14A9DE0")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x14AB604", Offset = "0x14AB604", VA = "0x14AB604", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x14AB64C", Offset = "0x14AB64C", VA = "0x14AB64C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x14ACF54", Offset = "0x14ACF54", VA = "0x14ACF54")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x14AA004", Offset = "0x14AA004", VA = "0x14AA004")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x14AB6C8", Offset = "0x14AB6C8", VA = "0x14AB6C8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x14AD350", Offset = "0x14AD350", VA = "0x14AD350")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x14AD3AC", Offset = "0x14AD3AC", VA = "0x14AD3AC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x14ACD78", Offset = "0x14ACD78", VA = "0x14ACD78")]
		private void Write()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x14B1260", Offset = "0x14B1260", VA = "0x14B1260")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x14B1960", Offset = "0x14B1960", VA = "0x14B1960")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7EDC", Offset = "0x7A7EDC")]
		public Transform parent;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7F14", Offset = "0x7A7F14")]
		public Transform child;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7F4C", Offset = "0x7A7F4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7F4C", Offset = "0x7A7F4C")]
		public float weight;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7FA0", Offset = "0x7A7FA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7FA0", Offset = "0x7A7FA0")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A7FF4", Offset = "0x7A7FF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A7FF4", Offset = "0x7A7FF4")]
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
		[Address(RVA = "0x1067A68", Offset = "0x1067A68", VA = "0x1067A68")]
		public void Relax()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1067EAC", Offset = "0x1067EAC", VA = "0x1067EAC")]
		private void Start()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1068420", Offset = "0x1068420", VA = "0x1068420")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x10684A8", Offset = "0x10684A8", VA = "0x10684A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1068530", Offset = "0x1068530", VA = "0x1068530")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x106869C", Offset = "0x106869C", VA = "0x106869C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A8050", Offset = "0x7A8050")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A8060", Offset = "0x7A8060")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A8070", Offset = "0x7A8070")]
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
			[Address(RVA = "0x104F320", Offset = "0x104F320", VA = "0x104F320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF23C", Offset = "0x7AF23C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x104F328", Offset = "0x104F328", VA = "0x104F328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF24C", Offset = "0x7AF24C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool isPaused
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x104F330", Offset = "0x104F330", VA = "0x104F330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF25C", Offset = "0x7AF25C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x104F338", Offset = "0x104F338", VA = "0x104F338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF26C", Offset = "0x7AF26C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x104F344", Offset = "0x104F344", VA = "0x104F344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF27C", Offset = "0x7AF27C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x104F34C", Offset = "0x104F34C", VA = "0x104F34C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF28C", Offset = "0x7AF28C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool inInteraction
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x104F354", Offset = "0x104F354", VA = "0x104F354")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public float progress
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1052D38", Offset = "0x1052D38", VA = "0x1052D38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x104F3C4", Offset = "0x104F3C4", VA = "0x104F3C4")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x104F448", Offset = "0x104F448", VA = "0x104F448")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x104F524", Offset = "0x104F524", VA = "0x104F524")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x104F758", Offset = "0x104F758", VA = "0x104F758")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x104FCC0", Offset = "0x104FCC0", VA = "0x104FCC0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x10502E4", Offset = "0x10502E4", VA = "0x10502E4")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1050370", Offset = "0x1050370", VA = "0x1050370")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x105118C", Offset = "0x105118C", VA = "0x105118C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x10520EC", Offset = "0x10520EC", VA = "0x10520EC")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x10525B0", Offset = "0x10525B0", VA = "0x10525B0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1052B98", Offset = "0x1052B98", VA = "0x1052B98")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x105348C", Offset = "0x105348C", VA = "0x105348C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8080", Offset = "0x7A8080")]
		public LookAtIK ik;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A80B8", Offset = "0x7A80B8")]
		public float lerpSpeed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A80F0", Offset = "0x7A80F0")]
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
		[Address(RVA = "0x10537F4", Offset = "0x10537F4", VA = "0x10537F4")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1053A00", Offset = "0x1053A00", VA = "0x1053A00")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1053AC8", Offset = "0x1053AC8", VA = "0x1053AC8")]
		public void Update()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1053D84", Offset = "0x1053D84", VA = "0x1053D84")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1053F18", Offset = "0x1053F18", VA = "0x1053F18")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x105403C", Offset = "0x105403C", VA = "0x105403C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A5254", Offset = "0x7A5254")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A5254", Offset = "0x7A5254")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC2D0", Offset = "0x7AC2D0")]
			public float time;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC308", Offset = "0x7AC308")]
			public bool pause;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC340", Offset = "0x7AC340")]
			public bool pickUp;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC378", Offset = "0x7AC378")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC3B0", Offset = "0x7AC3B0")]
			public Message[] messages;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC3E8", Offset = "0x7AC3E8")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1052D74", Offset = "0x1052D74", VA = "0x1052D74")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1055854", Offset = "0x1055854", VA = "0x1055854")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC420", Offset = "0x7AC420")]
			public string function;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC458", Offset = "0x7AC458")]
			public GameObject recipient;

			[Token(Token = "0x40006C4")]
			private const string empty = "";

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1055758", Offset = "0x1055758", VA = "0x1055758")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x105585C", Offset = "0x105585C", VA = "0x105585C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC490", Offset = "0x7AC490")]
			public Animator animator;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC4C8", Offset = "0x7AC4C8")]
			public Animation animation;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC500", Offset = "0x7AC500")]
			public string animationState;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC538", Offset = "0x7AC538")]
			public float crossfadeTime;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC570", Offset = "0x7AC570")]
			public int layer;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC5A8", Offset = "0x7AC5A8")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006CB")]
			private const string empty = "";

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1055434", Offset = "0x1055434", VA = "0x1055434")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1055530", Offset = "0x1055530", VA = "0x1055530")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1055618", Offset = "0x1055618", VA = "0x1055618")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1055744", Offset = "0x1055744", VA = "0x1055744")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC5E0", Offset = "0x7AC5E0")]
			public Type type;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC618", Offset = "0x7AC618")]
			public AnimationCurve curve;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1054998", Offset = "0x1054998", VA = "0x1054998")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1055874", Offset = "0x1055874", VA = "0x1055874")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC650", Offset = "0x7AC650")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC688", Offset = "0x7AC688")]
			public float multiplier;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC6C0", Offset = "0x7AC6C0")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x105523C", Offset = "0x105523C", VA = "0x105523C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1055864", Offset = "0x1055864", VA = "0x1055864")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8138", Offset = "0x7A8138")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8170", Offset = "0x7A8170")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A81A8", Offset = "0x7A81A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A81E0", Offset = "0x7A81E0")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A81F0", Offset = "0x7A81F0")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000050")]
		public float length
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x1050B70", Offset = "0x1050B70", VA = "0x1050B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF3EC", Offset = "0x7AF3EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x1054218", Offset = "0x1054218", VA = "0x1054218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF3FC", Offset = "0x7AF3FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1054220", Offset = "0x1054220", VA = "0x1054220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF40C", Offset = "0x7AF40C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1054228", Offset = "0x1054228", VA = "0x1054228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF41C", Offset = "0x7AF41C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1054540", Offset = "0x1054540", VA = "0x1054540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x1053330", Offset = "0x1053330", VA = "0x1053330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1054050", Offset = "0x1054050", VA = "0x1054050")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF29C", Offset = "0x7AF29C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x105409C", Offset = "0x105409C", VA = "0x105409C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF2D4", Offset = "0x7AF2D4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x10540E8", Offset = "0x10540E8", VA = "0x10540E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF30C", Offset = "0x7AF30C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1054134", Offset = "0x1054134", VA = "0x1054134")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF344", Offset = "0x7AF344")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1054180", Offset = "0x1054180", VA = "0x1054180")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF37C", Offset = "0x7AF37C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x10541CC", Offset = "0x10541CC", VA = "0x10541CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF3B4", Offset = "0x7AF3B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1054230", Offset = "0x1054230", VA = "0x1054230")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x10545D0", Offset = "0x10545D0", VA = "0x10545D0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1050A70", Offset = "0x1050A70", VA = "0x1050A70")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x105479C", Offset = "0x105479C", VA = "0x105479C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1050890", Offset = "0x1050890", VA = "0x1050890")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1050A68", Offset = "0x1050A68", VA = "0x1050A68")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1051A7C", Offset = "0x1051A7C", VA = "0x1051A7C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1052870", Offset = "0x1052870", VA = "0x1052870")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1055288", Offset = "0x1055288", VA = "0x1055288")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x10549D8", Offset = "0x10549D8", VA = "0x10549D8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x10547A4", Offset = "0x10547A4", VA = "0x10547A4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x105518C", Offset = "0x105518C", VA = "0x105518C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x105528C", Offset = "0x105528C", VA = "0x105528C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x105533C", Offset = "0x105533C", VA = "0x105533C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF42C", Offset = "0x7AF42C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1055388", Offset = "0x1055388", VA = "0x1055388")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF464", Offset = "0x7AF464")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x10553D4", Offset = "0x10553D4", VA = "0x10553D4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A52B4", Offset = "0x7A52B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A52B4", Offset = "0x7A52B4")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000DF")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8200", Offset = "0x7A8200")]
		public string targetTag;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8238", Offset = "0x7A8238")]
		public float fadeInTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8270", Offset = "0x7A8270")]
		public float speed;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A82A8", Offset = "0x7A82A8")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A82E0", Offset = "0x7A82E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A82E0", Offset = "0x7A82E0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7A82E0", Offset = "0x7A82E0")]
		public Collider characterCollider;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8364", Offset = "0x7A8364")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7A8364", Offset = "0x7A8364")]
		public Transform FPSCamera;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A83C4", Offset = "0x7A83C4")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A83FC", Offset = "0x7A83FC")]
		public float camRaycastDistance;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A8434", Offset = "0x7A8434")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7A8444", Offset = "0x7A8444")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8444", Offset = "0x7A8444")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A84A4", Offset = "0x7A84A4")]
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
			[Address(RVA = "0x1055A44", Offset = "0x1055A44", VA = "0x1055A44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x104F51C", Offset = "0x104F51C", VA = "0x104F51C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x10583C0", Offset = "0x10583C0", VA = "0x10583C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1056F30", Offset = "0x1056F30", VA = "0x1056F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF5EC", Offset = "0x7AF5EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x10583C8", Offset = "0x10583C8", VA = "0x10583C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AF5FC", Offset = "0x7AF5FC")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x105587C", Offset = "0x105587C", VA = "0x105587C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF49C", Offset = "0x7AF49C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x10558C8", Offset = "0x10558C8", VA = "0x10558C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF4D4", Offset = "0x7AF4D4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1055914", Offset = "0x1055914", VA = "0x1055914")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF50C", Offset = "0x7AF50C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1055960", Offset = "0x1055960", VA = "0x1055960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF544", Offset = "0x7AF544")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x10559AC", Offset = "0x10559AC", VA = "0x10559AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF57C", Offset = "0x7AF57C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x10559F8", Offset = "0x10559F8", VA = "0x10559F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF5B4", Offset = "0x7AF5B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1055C24", Offset = "0x1055C24", VA = "0x1055C24")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1055D7C", Offset = "0x1055D7C", VA = "0x1055D7C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1055ED4", Offset = "0x1055ED4", VA = "0x1055ED4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1055FD0", Offset = "0x1055FD0", VA = "0x1055FD0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1056150", Offset = "0x1056150", VA = "0x1056150")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x10562F4", Offset = "0x10562F4", VA = "0x10562F4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1056404", Offset = "0x1056404", VA = "0x1056404")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1056514", Offset = "0x1056514", VA = "0x1056514")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1056624", Offset = "0x1056624", VA = "0x1056624")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x10566C8", Offset = "0x10566C8", VA = "0x10566C8")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x105676C", Offset = "0x105676C", VA = "0x105676C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1056804", Offset = "0x1056804", VA = "0x1056804")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1056904", Offset = "0x1056904", VA = "0x1056904")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1056A2C", Offset = "0x1056A2C", VA = "0x1056A2C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1056B5C", Offset = "0x1056B5C", VA = "0x1056B5C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1056F38", Offset = "0x1056F38", VA = "0x1056F38")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x10571E8", Offset = "0x10571E8", VA = "0x10571E8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x10575A8", Offset = "0x10575A8", VA = "0x10575A8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x105794C", Offset = "0x105794C", VA = "0x105794C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x10579A8", Offset = "0x10579A8", VA = "0x10579A8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1057AA0", Offset = "0x1057AA0", VA = "0x1057AA0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1057C18", Offset = "0x1057C18", VA = "0x1057C18")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1057DD0", Offset = "0x1057DD0", VA = "0x1057DD0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1058268", Offset = "0x1058268", VA = "0x1058268")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x10576E0", Offset = "0x10576E0", VA = "0x10576E0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x10583D0", Offset = "0x10583D0", VA = "0x10583D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1058D48", Offset = "0x1058D48", VA = "0x1058D48")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1058D78", Offset = "0x1058D78", VA = "0x1058D78")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1058DA4", Offset = "0x1058DA4", VA = "0x1058DA4")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1058DD0", Offset = "0x1058DD0", VA = "0x1058DD0")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1058E54", Offset = "0x1058E54", VA = "0x1058E54")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1058F8C", Offset = "0x1058F8C", VA = "0x1058F8C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1059098", Offset = "0x1059098", VA = "0x1059098")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x105946C", Offset = "0x105946C", VA = "0x105946C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1059558", Offset = "0x1059558", VA = "0x1059558")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1059820", Offset = "0x1059820", VA = "0x1059820")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1058A88", Offset = "0x1058A88", VA = "0x1058A88")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1059974", Offset = "0x1059974", VA = "0x1059974")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1059B08", Offset = "0x1059B08", VA = "0x1059B08")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1059BB8", Offset = "0x1059BB8", VA = "0x1059BB8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1059CE0", Offset = "0x1059CE0", VA = "0x1059CE0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1059D0C", Offset = "0x1059D0C", VA = "0x1059D0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1055B40", Offset = "0x1055B40", VA = "0x1055B40")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1056E00", Offset = "0x1056E00", VA = "0x1056E00")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x105A274", Offset = "0x105A274", VA = "0x105A274")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF60C", Offset = "0x7AF60C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x105A2C0", Offset = "0x105A2C0", VA = "0x105A2C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF644", Offset = "0x7AF644")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x105A30C", Offset = "0x105A30C", VA = "0x105A30C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A5314", Offset = "0x7A5314")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A5314", Offset = "0x7A5314")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Multiplier
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC6F8", Offset = "0x7AC6F8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC730", Offset = "0x7AC730")]
			public float multiplier;

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x105ABBC", Offset = "0x105ABBC", VA = "0x105ABBC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A84DC", Offset = "0x7A84DC")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8514", Offset = "0x7A8514")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A854C", Offset = "0x7A854C")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8584", Offset = "0x7A8584")]
		public Transform pivot;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A85BC", Offset = "0x7A85BC")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A85F4", Offset = "0x7A85F4")]
		public float twistWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A862C", Offset = "0x7A862C")]
		public float swingWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8664", Offset = "0x7A8664")]
		public bool rotateOnce;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x105A8D0", Offset = "0x105A8D0", VA = "0x105A8D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF67C", Offset = "0x7AF67C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x105A91C", Offset = "0x105A91C", VA = "0x105A91C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF6B4", Offset = "0x7AF6B4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x105A968", Offset = "0x105A968", VA = "0x105A968")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF6EC", Offset = "0x7AF6EC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x105A9B4", Offset = "0x105A9B4", VA = "0x105A9B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF724", Offset = "0x7AF724")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x105AA00", Offset = "0x105AA00", VA = "0x105AA00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF75C", Offset = "0x7AF75C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x105AA4C", Offset = "0x105AA4C", VA = "0x105AA4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF794", Offset = "0x7AF794")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1054898", Offset = "0x1054898", VA = "0x1054898")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x10533C0", Offset = "0x10533C0", VA = "0x10533C0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1050B78", Offset = "0x1050B78", VA = "0x1050B78")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x105AA98", Offset = "0x105AA98", VA = "0x105AA98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF7CC", Offset = "0x7AF7CC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x105AAE4", Offset = "0x105AAE4", VA = "0x105AAE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF804", Offset = "0x7AF804")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x105AB30", Offset = "0x105AB30", VA = "0x105AB30")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A5374", Offset = "0x7A5374")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A5374", Offset = "0x7A5374")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC768", Offset = "0x7AC768")]
			public bool use;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC7A0", Offset = "0x7AC7A0")]
			public Vector2 offset;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC7D8", Offset = "0x7AC7D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC7D8", Offset = "0x7AC7D8")]
			public float angleOffset;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC834", Offset = "0x7AC834")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC834", Offset = "0x7AC834")]
			public float maxAngle;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC88C", Offset = "0x7AC88C")]
			public float radius;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC8C4", Offset = "0x7AC8C4")]
			public bool orbit;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC8FC", Offset = "0x7AC8FC")]
			public bool fixYAxis;

			[Token(Token = "0x170000A5")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x105B390", Offset = "0x105B390", VA = "0x105B390")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x105B3CC", Offset = "0x105B3CC", VA = "0x105B3CC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x105B4C4", Offset = "0x105B4C4", VA = "0x105B4C4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x105BB98", Offset = "0x105BB98", VA = "0x105BB98")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC934", Offset = "0x7AC934")]
			public Collider lookAtTarget;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC96C", Offset = "0x7AC96C")]
			public Vector3 direction;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC9A4", Offset = "0x7AC9A4")]
			public float maxDistance;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AC9DC", Offset = "0x7AC9DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AC9DC", Offset = "0x7AC9DC")]
			public float maxAngle;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACA34", Offset = "0x7ACA34")]
			public bool fixYAxis;

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x105AE4C", Offset = "0x105AE4C", VA = "0x105AE4C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x105B020", Offset = "0x105B020", VA = "0x105B020")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x105B304", Offset = "0x105B304", VA = "0x105B304")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADCBC", Offset = "0x7ADCBC")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40007ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADCF4", Offset = "0x7ADCF4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600076E")]
				[Address(RVA = "0x105BBBC", Offset = "0x105BBBC", VA = "0x105BBBC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACADC", Offset = "0x7ACADC")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACB14", Offset = "0x7ACB14")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACB4C", Offset = "0x7ACB4C")]
			public Interaction[] interactions;

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x105ACAC", Offset = "0x105ACAC", VA = "0x105ACAC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x105BBAC", Offset = "0x105BBAC", VA = "0x105BBAC")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A869C", Offset = "0x7A869C")]
		public Range[] ranges;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x105ABC4", Offset = "0x105ABC4", VA = "0x105ABC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF83C", Offset = "0x7AF83C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x105AC10", Offset = "0x105AC10", VA = "0x105AC10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF874", Offset = "0x7AF874")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x105AC5C", Offset = "0x105AC5C", VA = "0x105AC5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF8AC", Offset = "0x7AF8AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x105ACA8", Offset = "0x105ACA8", VA = "0x105ACA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1059280", Offset = "0x1059280", VA = "0x1059280")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x105ADEC", Offset = "0x105ADEC", VA = "0x105ADEC")]
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
			[Address(RVA = "0xF50EB8", Offset = "0xF50EB8", VA = "0xF50EB8")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xF51400", Offset = "0xF51400", VA = "0xF51400")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xF51374", Offset = "0xF51374", VA = "0xF51374")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xF510C8", Offset = "0xF510C8", VA = "0xF510C8")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xF50B28", Offset = "0xF50B28", VA = "0xF50B28", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF8E4", Offset = "0x7AF8E4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xF50F8C", Offset = "0xF50F8C", VA = "0xF50F8C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xF50F90", Offset = "0xF50F90", VA = "0xF50F90", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xF512DC", Offset = "0xF512DC", VA = "0xF512DC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xF50EF4", Offset = "0xF50EF4", VA = "0xF50EF4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xF50DF0", Offset = "0xF50DF0", VA = "0xF50DF0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF51464", Offset = "0xF51464", VA = "0xF51464")]
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
		[Address(RVA = "0x1570A1C", Offset = "0x1570A1C", VA = "0x1570A1C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1570AD8", Offset = "0x1570AD8", VA = "0x1570AD8", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1570D38", Offset = "0x1570D38", VA = "0x1570D38", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1570EC8", Offset = "0x1570EC8", VA = "0x1570EC8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1570B34", Offset = "0x1570B34", VA = "0x1570B34")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x15713EC", Offset = "0x15713EC", VA = "0x15713EC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A86D4", Offset = "0x7A86D4")]
		public float weight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A86EC", Offset = "0x7A86EC")]
		public float localRotationWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A8704", Offset = "0x7A8704")]
		public float localPositionWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000402")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x105EDDC", Offset = "0x105EDDC", VA = "0x105EDDC")]
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
		[Address(RVA = "0x105EDE8", Offset = "0x105EDE8", VA = "0x105EDE8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x105EE3C", Offset = "0x105EE3C", VA = "0x105EE3C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x105EE78", Offset = "0x105EE78", VA = "0x105EE78", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x105EE90", Offset = "0x105EE90", VA = "0x105EE90")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A53D4", Offset = "0x7A53D4")]
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
			[Address(RVA = "0x105F568", Offset = "0x105F568", VA = "0x105F568")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x106057C", Offset = "0x106057C", VA = "0x106057C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x10602C4", Offset = "0x10602C4", VA = "0x10602C4")]
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
			[Address(RVA = "0x105F700", Offset = "0x105F700", VA = "0x105F700")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1060758", Offset = "0x1060758", VA = "0x1060758")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x10606F4", Offset = "0x10606F4", VA = "0x10606F4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5B54", Offset = "0x7A5B54")]
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
				[Address(RVA = "0x1060EF0", Offset = "0x1060EF0", VA = "0x1060EF0", Slot = "4")]
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
				[Address(RVA = "0x1060F60", Offset = "0x1060F60", VA = "0x1060F60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x105F770", Offset = "0x105F770", VA = "0x105F770")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1060BC8", Offset = "0x1060BC8", VA = "0x1060BC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1060BCC", Offset = "0x1060BCC", VA = "0x1060BCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1060EF8", Offset = "0x1060EF8", VA = "0x1060EF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A871C", Offset = "0x7A871C")]
		public IK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8754", Offset = "0x7A8754")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A878C", Offset = "0x7A878C")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A87C4", Offset = "0x7A87C4")]
		public float applyVelocity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A87FC", Offset = "0x7A87FC")]
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
			[Address(RVA = "0x105EED8", Offset = "0x105EED8", VA = "0x105EED8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		private bool ikUsed
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x105FCD8", Offset = "0x105FCD8", VA = "0x105FCD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x105EEA0", Offset = "0x105EEA0", VA = "0x105EEA0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x105EF78", Offset = "0x105EF78", VA = "0x105EF78")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x105F0C4", Offset = "0x105F0C4", VA = "0x105F0C4")]
		public void Start()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x105F050", Offset = "0x105F050", VA = "0x105F050")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AF91C", Offset = "0x7AF91C")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x105F79C", Offset = "0x105F79C", VA = "0x105F79C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x105FB38", Offset = "0x105FB38", VA = "0x105FB38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x105FC08", Offset = "0x105FC08", VA = "0x105FC08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x105FE9C", Offset = "0x105FE9C", VA = "0x105FE9C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x105FC9C", Offset = "0x105FC9C", VA = "0x105FC9C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x105FE58", Offset = "0x105FE58", VA = "0x105FE58")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x105FF50", Offset = "0x105FF50", VA = "0x105FF50")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x105FED0", Offset = "0x105FED0", VA = "0x105FED0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x105EFD0", Offset = "0x105EFD0", VA = "0x105EFD0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x105FB78", Offset = "0x105FB78", VA = "0x105FB78")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1060990", Offset = "0x1060990", VA = "0x1060990")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1060AFC", Offset = "0x1060AFC", VA = "0x1060AFC")]
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
			[Address(RVA = "0x1062BE8", Offset = "0x1062BE8", VA = "0x1062BE8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1062C24", Offset = "0x1062C24", VA = "0x1062C24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1062824", Offset = "0x1062824", VA = "0x1062824")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1062870", Offset = "0x1062870", VA = "0x1062870")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1062B00", Offset = "0x1062B00", VA = "0x1062B00")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1062BB0", Offset = "0x1062BB0", VA = "0x1062BB0")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000423")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1062A10", Offset = "0x1062A10", VA = "0x1062A10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1062CF4", Offset = "0x1062CF4", VA = "0x1062CF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1062CF8", Offset = "0x1062CF8", VA = "0x1062CF8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1062D2C", Offset = "0x1062D2C", VA = "0x1062D2C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1062E10", Offset = "0x1062E10", VA = "0x1062E10")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1063090", Offset = "0x1063090", VA = "0x1063090")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x106314C", Offset = "0x106314C", VA = "0x106314C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A5438", Offset = "0x7A5438")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A5438", Offset = "0x7A5438")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A8844", Offset = "0x7A8844")]
		public float limit;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A8860", Offset = "0x7A8860")]
		public float twistLimit;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x10631C4", Offset = "0x10631C4", VA = "0x10631C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF980", Offset = "0x7AF980")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1063210", Offset = "0x1063210", VA = "0x1063210")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF9B8", Offset = "0x7AF9B8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x106325C", Offset = "0x106325C", VA = "0x106325C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AF9F0", Offset = "0x7AF9F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x10632A8", Offset = "0x10632A8", VA = "0x10632A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFA28", Offset = "0x7AFA28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x10632F4", Offset = "0x10632F4", VA = "0x10632F4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x10633AC", Offset = "0x10633AC", VA = "0x10633AC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x10635F4", Offset = "0x10635F4", VA = "0x10635F4")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A5498", Offset = "0x7A5498")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A5498", Offset = "0x7A5498")]
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
		[Address(RVA = "0x1063604", Offset = "0x1063604", VA = "0x1063604")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFA60", Offset = "0x7AFA60")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1063650", Offset = "0x1063650", VA = "0x1063650")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFA98", Offset = "0x7AFA98")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x106369C", Offset = "0x106369C", VA = "0x106369C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFAD0", Offset = "0x7AFAD0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x10636E8", Offset = "0x10636E8", VA = "0x10636E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFB08", Offset = "0x7AFB08")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1063734", Offset = "0x1063734", VA = "0x1063734", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x106375C", Offset = "0x106375C", VA = "0x106375C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1063A5C", Offset = "0x1063A5C", VA = "0x1063A5C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A54F8", Offset = "0x7A54F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A54F8", Offset = "0x7A54F8")]
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
				[Address(RVA = "0x1065F50", Offset = "0x1065F50", VA = "0x1065F50")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AA")]
			public Vector3 a
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x1065F98", Offset = "0x1065F98", VA = "0x1065F98")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AB")]
			public Vector3 b
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x1065FE4", Offset = "0x1065FE4", VA = "0x1065FE4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AC")]
			public Vector3 c
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x1066030", Offset = "0x1066030", VA = "0x1066030")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AD")]
			public bool isValid
			{
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x1064E8C", Offset = "0x1064E8C", VA = "0x1064E8C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1065634", Offset = "0x1065634", VA = "0x1065634")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x10657E4", Offset = "0x10657E4", VA = "0x10657E4")]
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
			[Address(RVA = "0x1064E9C", Offset = "0x1064E9C", VA = "0x1064E9C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A888C", Offset = "0x7A888C")]
		public float twistLimit;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A88A8", Offset = "0x7A88A8")]
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
		[Address(RVA = "0x1063AE4", Offset = "0x1063AE4", VA = "0x1063AE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFB40", Offset = "0x7AFB40")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1063B30", Offset = "0x1063B30", VA = "0x1063B30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFB78", Offset = "0x7AFB78")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1063B7C", Offset = "0x1063B7C", VA = "0x1063B7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFBB0", Offset = "0x7AFBB0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1063BC8", Offset = "0x1063BC8", VA = "0x1063BC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFBE8", Offset = "0x7AFBE8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1063C14", Offset = "0x1063C14", VA = "0x1063C14")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1064250", Offset = "0x1064250", VA = "0x1064250", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x106434C", Offset = "0x106434C", VA = "0x106434C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1064A18", Offset = "0x1064A18", VA = "0x1064A18")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1063CB8", Offset = "0x1063CB8", VA = "0x1063CB8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1064F20", Offset = "0x1064F20", VA = "0x1064F20")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x10659A4", Offset = "0x10659A4", VA = "0x10659A4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x10659E8", Offset = "0x10659E8", VA = "0x10659E8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1065B30", Offset = "0x1065B30", VA = "0x1065B30")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x10646AC", Offset = "0x10646AC", VA = "0x10646AC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1065CC0", Offset = "0x1065CC0", VA = "0x1065CC0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1065EEC", Offset = "0x1065EEC", VA = "0x1065EEC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7A5558", Offset = "0x7A5558")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A5558", Offset = "0x7A5558")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A8968", Offset = "0x7A8968")]
		public float twistLimit;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x106607C", Offset = "0x106607C", VA = "0x106607C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFC20", Offset = "0x7AFC20")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x10660C8", Offset = "0x10660C8", VA = "0x10660C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFC58", Offset = "0x7AFC58")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1066114", Offset = "0x1066114", VA = "0x1066114")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFC90", Offset = "0x7AFC90")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1066160", Offset = "0x1066160", VA = "0x1066160")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7AFCC8", Offset = "0x7AFCC8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x10661AC", Offset = "0x10661AC", VA = "0x10661AC")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x10661E4", Offset = "0x10661E4", VA = "0x10661E4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x106629C", Offset = "0x106629C", VA = "0x106629C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x10665D4", Offset = "0x10665D4", VA = "0x10665D4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5B64", Offset = "0x7A5B64")]
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
				[Address(RVA = "0xF393E4", Offset = "0xF393E4", VA = "0xF393E4", Slot = "4")]
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
				[Address(RVA = "0xF39454", Offset = "0xF39454", VA = "0xF39454", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xF39170", Offset = "0xF39170", VA = "0xF39170")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xF39268", Offset = "0xF39268", VA = "0xF39268", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xF3926C", Offset = "0xF3926C", VA = "0xF3926C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xF393EC", Offset = "0xF393EC", VA = "0xF393EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A89BC", Offset = "0x7A89BC")]
		public AimIK ik;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A89F4", Offset = "0x7A89F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A89F4", Offset = "0x7A89F4")]
		public float weight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A8A48", Offset = "0x7A8A48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8A48", Offset = "0x7A8A48")]
		public Transform target;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8AA8", Offset = "0x7A8AA8")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8AE0", Offset = "0x7A8AE0")]
		public float weightSmoothTime;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A8B18", Offset = "0x7A8B18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8B18", Offset = "0x7A8B18")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8B78", Offset = "0x7A8B78")]
		public float maxRadiansDelta;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8BB0", Offset = "0x7A8BB0")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8BE8", Offset = "0x7A8BE8")]
		public float slerpSpeed;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8C20", Offset = "0x7A8C20")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8C58", Offset = "0x7A8C58")]
		public float minDistance;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8C90", Offset = "0x7A8C90")]
		public Vector3 offset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A8CC8", Offset = "0x7A8CC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8CC8", Offset = "0x7A8CC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A8CC8", Offset = "0x7A8CC8")]
		public float maxRootAngle;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8D44", Offset = "0x7A8D44")]
		public bool turnToTarget;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8D7C", Offset = "0x7A8D7C")]
		public float turnToTargetTime;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A8DB4", Offset = "0x7A8DB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8DB4", Offset = "0x7A8DB4")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8E14", Offset = "0x7A8E14")]
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
			[Address(RVA = "0xF380B0", Offset = "0xF380B0", VA = "0xF380B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xF37F80", Offset = "0xF37F80", VA = "0xF37F80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xF38228", Offset = "0xF38228", VA = "0xF38228")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xF38B2C", Offset = "0xF38B2C", VA = "0xF38B2C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xF38CF8", Offset = "0xF38CF8", VA = "0xF38CF8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xF390FC", Offset = "0xF390FC", VA = "0xF390FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AFD00", Offset = "0x7AFD00")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xF3919C", Offset = "0xF3919C", VA = "0xF3919C")]
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
			[Address(RVA = "0xF3DA14", Offset = "0xF3DA14", VA = "0xF3DA14")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xF3DDA8", Offset = "0xF3DDA8", VA = "0xF3DDA8")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0xF3DE18", Offset = "0xF3DE18", VA = "0xF3DE18")]
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
		[Address(RVA = "0xF3D8B4", Offset = "0xF3D8B4", VA = "0xF3D8B4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xF3DCB0", Offset = "0xF3DCB0", VA = "0xF3DCB0")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xF3DDB0", Offset = "0xF3DDB0", VA = "0xF3DDB0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADD2C", Offset = "0x7ADD2C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADD64", Offset = "0x7ADD64")]
				public float weight;

				[Token(Token = "0x600076F")]
				[Address(RVA = "0xF3E514", Offset = "0xF3E514", VA = "0xF3E514")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACB84", Offset = "0x7ACB84")]
			public Transform transform;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACBBC", Offset = "0x7ACBBC")]
			public Transform relativeTo;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACBF4", Offset = "0x7ACBF4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACC2C", Offset = "0x7ACC2C")]
			public float verticalWeight;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACC64", Offset = "0x7ACC64")]
			public float horizontalWeight;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACC9C", Offset = "0x7ACC9C")]
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
			[Address(RVA = "0xF3DF94", Offset = "0xF3DF94", VA = "0xF3DF94")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0xF3E4EC", Offset = "0xF3E4EC", VA = "0xF3E4EC")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0xF3E4FC", Offset = "0xF3E4FC", VA = "0xF3E4FC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8E4C", Offset = "0x7A8E4C")]
		public Body[] bodies;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xF3DE34", Offset = "0xF3DE34", VA = "0xF3DE34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xF3E4E4", Offset = "0xF3E4E4", VA = "0xF3E4E4")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8E84", Offset = "0x7A8E84")]
		public float tiltSpeed;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8EBC", Offset = "0x7A8EBC")]
		public float tiltSensitivity;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8EF4", Offset = "0x7A8EF4")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8F2C", Offset = "0x7A8F2C")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xF40294", Offset = "0xF40294", VA = "0xF40294", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xF402E4", Offset = "0xF402E4", VA = "0xF402E4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xF40550", Offset = "0xF40550", VA = "0xF40550")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACCD4", Offset = "0x7ACCD4")]
			public string name;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACD0C", Offset = "0x7ACD0C")]
			public Collider collider;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACD44", Offset = "0x7ACD44")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACD90", Offset = "0x7ACD90")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACDA0", Offset = "0x7ACDA0")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACDB0", Offset = "0x7ACDB0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACDC0", Offset = "0x7ACDC0")]
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
				[Address(RVA = "0x15714F0", Offset = "0x15714F0", VA = "0x15714F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B1")]
			protected float crossFader
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x1571B28", Offset = "0x1571B28", VA = "0x1571B28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B03BC", Offset = "0x7B03BC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x1571B30", Offset = "0x1571B30", VA = "0x1571B30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B03CC", Offset = "0x7B03CC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			protected float timer
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x1571B20", Offset = "0x1571B20", VA = "0x1571B20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B03DC", Offset = "0x7B03DC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x1571B38", Offset = "0x1571B38", VA = "0x1571B38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B03EC", Offset = "0x7B03EC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			protected Vector3 force
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x1571B40", Offset = "0x1571B40", VA = "0x1571B40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B03FC", Offset = "0x7B03FC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x1571B4C", Offset = "0x1571B4C", VA = "0x1571B4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B040C", Offset = "0x7B040C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			protected Vector3 point
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1571B58", Offset = "0x1571B58", VA = "0x1571B58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B041C", Offset = "0x7B041C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x1571B64", Offset = "0x1571B64", VA = "0x1571B64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B042C", Offset = "0x7B042C")]
				private set
				{
				}
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x15719EC", Offset = "0x15719EC", VA = "0x15719EC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1571638", Offset = "0x1571638", VA = "0x1571638")]
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
			[Address(RVA = "0x1571B70", Offset = "0x1571B70", VA = "0x1571B70")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADD9C", Offset = "0x7ADD9C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADDD4", Offset = "0x7ADDD4")]
				public float weight;

				[Token(Token = "0x40007F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000770")]
				[Address(RVA = "0x15726C4", Offset = "0x15726C4", VA = "0x15726C4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000771")]
				[Address(RVA = "0x1572460", Offset = "0x1572460", VA = "0x1572460")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000772")]
				[Address(RVA = "0x1572824", Offset = "0x1572824", VA = "0x1572824")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACDD0", Offset = "0x7ACDD0")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACE08", Offset = "0x7ACE08")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACE40", Offset = "0x7ACE40")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x15721D8", Offset = "0x15721D8", VA = "0x15721D8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x15723D8", Offset = "0x15723D8", VA = "0x15723D8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1572474", Offset = "0x1572474", VA = "0x1572474", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1572810", Offset = "0x1572810", VA = "0x1572810")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADE0C", Offset = "0x7ADE0C")]
				public Transform bone;

				[Token(Token = "0x40007F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADE44", Offset = "0x7ADE44")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ADE44", Offset = "0x7ADE44")]
				public float weight;

				[Token(Token = "0x40007F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40007F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000773")]
				[Address(RVA = "0x1571FB0", Offset = "0x1571FB0", VA = "0x1571FB0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000774")]
				[Address(RVA = "0x1571CF0", Offset = "0x1571CF0", VA = "0x1571CF0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000775")]
				[Address(RVA = "0x1572150", Offset = "0x1572150", VA = "0x1572150")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACE78", Offset = "0x7ACE78")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACEB0", Offset = "0x7ACEB0")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1571B84", Offset = "0x1571B84", VA = "0x1571B84", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1571C60", Offset = "0x1571C60", VA = "0x1571C60", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1571D0C", Offset = "0x1571D0C", VA = "0x1571D0C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x157213C", Offset = "0x157213C", VA = "0x157213C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8F64", Offset = "0x7A8F64")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8F9C", Offset = "0x7A8F9C")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005C")]
		public bool inProgress
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x15713F4", Offset = "0x15713F4", VA = "0x15713F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1571504", Offset = "0x1571504", VA = "0x1571504", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1571784", Offset = "0x1571784", VA = "0x1571784")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1571B18", Offset = "0x1571B18", VA = "0x1571B18")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACEE8", Offset = "0x7ACEE8")]
			public string name;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACF20", Offset = "0x7ACF20")]
			public Collider collider;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACF58", Offset = "0x7ACF58")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACFA4", Offset = "0x7ACFA4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACFB4", Offset = "0x7ACFB4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACFC4", Offset = "0x7ACFC4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ACFD4", Offset = "0x7ACFD4")]
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
				[Address(RVA = "0x1572E5C", Offset = "0x1572E5C", VA = "0x1572E5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B043C", Offset = "0x7B043C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x1572E64", Offset = "0x1572E64", VA = "0x1572E64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B044C", Offset = "0x7B044C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			protected float timer
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x1572E6C", Offset = "0x1572E6C", VA = "0x1572E6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B045C", Offset = "0x7B045C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x1572E74", Offset = "0x1572E74", VA = "0x1572E74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B046C", Offset = "0x7B046C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B7")]
			protected Vector3 force
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x1572E7C", Offset = "0x1572E7C", VA = "0x1572E7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B047C", Offset = "0x7B047C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600070F")]
				[Address(RVA = "0x1572E88", Offset = "0x1572E88", VA = "0x1572E88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B048C", Offset = "0x7B048C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000710")]
				[Address(RVA = "0x1572E94", Offset = "0x1572E94", VA = "0x1572E94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B049C", Offset = "0x7B049C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x1572EA0", Offset = "0x1572EA0", VA = "0x1572EA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B04AC", Offset = "0x7B04AC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1572D14", Offset = "0x1572D14", VA = "0x1572D14")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1572950", Offset = "0x1572950", VA = "0x1572950")]
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
			[Address(RVA = "0x1572EAC", Offset = "0x1572EAC", VA = "0x1572EAC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADE98", Offset = "0x7ADE98")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40007F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADED0", Offset = "0x7ADED0")]
				public float weight;

				[Token(Token = "0x40007FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000776")]
				[Address(RVA = "0x15734EC", Offset = "0x15734EC", VA = "0x15734EC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000777")]
				[Address(RVA = "0x1573230", Offset = "0x1573230", VA = "0x1573230")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000778")]
				[Address(RVA = "0x157363C", Offset = "0x157363C", VA = "0x157363C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ACFE4", Offset = "0x7ACFE4")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD01C", Offset = "0x7AD01C")]
			public int upDirCurveIndex;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD054", Offset = "0x7AD054")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1572EC0", Offset = "0x1572EC0", VA = "0x1572EC0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x15731A8", Offset = "0x15731A8", VA = "0x15731A8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1573244", Offset = "0x1573244", VA = "0x1573244", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1573620", Offset = "0x1573620", VA = "0x1573620")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADF08", Offset = "0x7ADF08")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40007FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADF40", Offset = "0x7ADF40")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ADF40", Offset = "0x7ADF40")]
				public float weight;

				[Token(Token = "0x40007FE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40007FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000779")]
				[Address(RVA = "0x1573BB8", Offset = "0x1573BB8", VA = "0x1573BB8")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600077A")]
				[Address(RVA = "0x1573838", Offset = "0x1573838", VA = "0x1573838")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600077B")]
				[Address(RVA = "0x1573D30", Offset = "0x1573D30", VA = "0x1573D30")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD08C", Offset = "0x7AD08C")]
			public int curveIndex;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD0C4", Offset = "0x7AD0C4")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1573644", Offset = "0x1573644", VA = "0x1573644", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x15737A8", Offset = "0x15737A8", VA = "0x15737A8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1573854", Offset = "0x1573854", VA = "0x1573854", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1573D1C", Offset = "0x1573D1C", VA = "0x1573D1C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A8FD4", Offset = "0x7A8FD4")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A900C", Offset = "0x7A900C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x157282C", Offset = "0x157282C", VA = "0x157282C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1572AA4", Offset = "0x1572AA4", VA = "0x1572AA4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1572E54", Offset = "0x1572E54", VA = "0x1572E54")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADF94", Offset = "0x7ADF94")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000801")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADFCC", Offset = "0x7ADFCC")]
				public float weight;

				[Token(Token = "0x600077C")]
				[Address(RVA = "0x104F318", Offset = "0x104F318", VA = "0x104F318")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD0FC", Offset = "0x7AD0FC")]
			public Transform transform;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD134", Offset = "0x7AD134")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD16C", Offset = "0x7AD16C")]
			public float speed;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD1A4", Offset = "0x7AD1A4")]
			public float acceleration;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD1DC", Offset = "0x7AD1DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AD1DC", Offset = "0x7AD1DC")]
			public float matchVelocity;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD230", Offset = "0x7AD230")]
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
			[Address(RVA = "0x104EC3C", Offset = "0x104EC3C", VA = "0x104EC3C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x104EE28", Offset = "0x104EE28", VA = "0x104EE28")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x104F2FC", Offset = "0x104F2FC", VA = "0x104F2FC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9044", Offset = "0x7A9044")]
		public Body[] bodies;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A907C", Offset = "0x7A907C")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x104EBAC", Offset = "0x104EBAC", VA = "0x104EBAC")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x104ED2C", Offset = "0x104ED2C", VA = "0x104ED2C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x104F2DC", Offset = "0x104F2DC", VA = "0x104F2DC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A90B4", Offset = "0x7A90B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A90B4", Offset = "0x7A90B4")]
		public Transform target;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9114", Offset = "0x7A9114")]
		public float weight;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A912C", Offset = "0x7A912C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9164", Offset = "0x7A9164")]
		public float weightSmoothTime;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A919C", Offset = "0x7A919C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A919C", Offset = "0x7A919C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A91FC", Offset = "0x7A91FC")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9234", Offset = "0x7A9234")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A926C", Offset = "0x7A926C")]
		public float slerpSpeed;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A92A4", Offset = "0x7A92A4")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A92DC", Offset = "0x7A92DC")]
		public float minDistance;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7A9314", Offset = "0x7A9314")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9314", Offset = "0x7A9314")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9314", Offset = "0x7A9314")]
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
			[Address(RVA = "0x105C050", Offset = "0x105C050", VA = "0x105C050")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x105BF44", Offset = "0x105BF44", VA = "0x105BF44")]
		private void Start()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x105C1C8", Offset = "0x105C1C8", VA = "0x105C1C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x105C9D0", Offset = "0x105C9D0", VA = "0x105C9D0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x105CB9C", Offset = "0x105CB9C", VA = "0x105CB9C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x105CF4C", Offset = "0x105CF4C", VA = "0x105CF4C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD268", Offset = "0x7AD268")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD2A0", Offset = "0x7AD2A0")]
			public float spring;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD2D8", Offset = "0x7AD2D8")]
			public bool x;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD310", Offset = "0x7AD310")]
			public bool y;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD348", Offset = "0x7AD348")]
			public bool z;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD380", Offset = "0x7AD380")]
			public float minX;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD3B8", Offset = "0x7AD3B8")]
			public float maxX;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD3F0", Offset = "0x7AD3F0")]
			public float minY;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD428", Offset = "0x7AD428")]
			public float maxY;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD460", Offset = "0x7AD460")]
			public float minZ;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD498", Offset = "0x7AD498")]
			public float maxZ;

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x105D370", Offset = "0x105D370", VA = "0x105D370")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x105D97C", Offset = "0x105D97C", VA = "0x105D97C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x105D9AC", Offset = "0x105D9AC", VA = "0x105D9AC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x105DA84", Offset = "0x105DA84", VA = "0x105DA84")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5B74", Offset = "0x7A5B74")]
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
				[Address(RVA = "0x105D904", Offset = "0x105D904", VA = "0x105D904", Slot = "4")]
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
				[Address(RVA = "0x105D974", Offset = "0x105D974", VA = "0x105D974", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x105D238", Offset = "0x105D238", VA = "0x105D238")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x105D754", Offset = "0x105D754", VA = "0x105D754", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x105D758", Offset = "0x105D758", VA = "0x105D758", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x105D90C", Offset = "0x105D90C", VA = "0x105D90C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9390", Offset = "0x7A9390")]
		public float weight;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A93C8", Offset = "0x7A93C8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005E")]
		protected float deltaTime
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x104EDFC", Offset = "0x104EDFC", VA = "0x104EDFC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000471")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x105D198", Offset = "0x105D198", VA = "0x105D198", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x105D1C4", Offset = "0x105D1C4", VA = "0x105D1C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AFD64", Offset = "0x7AFD64")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x105D264", Offset = "0x105D264", VA = "0x105D264")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x104F1F0", Offset = "0x104F1F0", VA = "0x104F1F0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x105D5F4", Offset = "0x105D5F4", VA = "0x105D5F4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x104F2EC", Offset = "0x104F2EC", VA = "0x104F2EC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5B84", Offset = "0x7A5B84")]
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
				[Address(RVA = "0x105DFB0", Offset = "0x105DFB0", VA = "0x105DFB0", Slot = "4")]
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
				[Address(RVA = "0x105E020", Offset = "0x105E020", VA = "0x105E020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x105DB58", Offset = "0x105DB58", VA = "0x105DB58")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x105DE00", Offset = "0x105DE00", VA = "0x105DE00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x105DE04", Offset = "0x105DE04", VA = "0x105DE04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x105DFB8", Offset = "0x105DFB8", VA = "0x105DFB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9400", Offset = "0x7A9400")]
		public float weight;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9438", Offset = "0x7A9438")]
		public VRIK ik;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005F")]
		protected float deltaTime
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x105DA8C", Offset = "0x105DA8C", VA = "0x105DA8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000479")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x105DAB8", Offset = "0x105DAB8", VA = "0x105DAB8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x105DAE4", Offset = "0x105DAE4", VA = "0x105DAE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AFDC8", Offset = "0x7AFDC8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x105DB84", Offset = "0x105DB84", VA = "0x105DB84")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x105DC90", Offset = "0x105DC90", VA = "0x105DC90", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x105DDF0", Offset = "0x105DDF0", VA = "0x105DDF0")]
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
			[Address(RVA = "0x105E140", Offset = "0x105E140", VA = "0x105E140")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x105E67C", Offset = "0x105E67C", VA = "0x105E67C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x105E028", Offset = "0x105E028", VA = "0x105E028")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x105E534", Offset = "0x105E534", VA = "0x105E534")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x105E61C", Offset = "0x105E61C", VA = "0x105E61C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AE004", Offset = "0x7AE004")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000803")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AE03C", Offset = "0x7AE03C")]
				public float weight;

				[Token(Token = "0x600077D")]
				[Address(RVA = "0x105EDD4", Offset = "0x105EDD4", VA = "0x105EDD4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD4D0", Offset = "0x7AD4D0")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD508", Offset = "0x7AD508")]
			public Transform raycastTo;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD540", Offset = "0x7AD540")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AD540", Offset = "0x7AD540")]
			public float raycastRadius;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD594", Offset = "0x7AD594")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD5CC", Offset = "0x7AD5CC")]
			public float smoothTimeIn;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD604", Offset = "0x7AD604")]
			public float smoothTimeOut;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD63C", Offset = "0x7AD63C")]
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
			[Address(RVA = "0x105E738", Offset = "0x105E738", VA = "0x105E738")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x105E960", Offset = "0x105E960", VA = "0x105E960")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x105EB44", Offset = "0x105EB44", VA = "0x105EB44")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x105EDB8", Offset = "0x105EDB8", VA = "0x105EDB8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9470", Offset = "0x7A9470")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x105E684", Offset = "0x105E684", VA = "0x105E684", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x105E950", Offset = "0x105E950", VA = "0x105E950")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AE074", Offset = "0x7AE074")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000805")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AE0AC", Offset = "0x7AE0AC")]
				public float weight;

				[Token(Token = "0x600077E")]
				[Address(RVA = "0x106281C", Offset = "0x106281C", VA = "0x106281C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD674", Offset = "0x7AD674")]
			public Vector3 offset;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD6AC", Offset = "0x7AD6AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AD6AC", Offset = "0x7AD6AC")]
			public float additivity;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD700", Offset = "0x7AD700")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD738", Offset = "0x7AD738")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x10611CC", Offset = "0x10611CC", VA = "0x10611CC")]
			public void Start()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1061F3C", Offset = "0x1061F3C", VA = "0x1061F3C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1062804", Offset = "0x1062804", VA = "0x1062804")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A94A8", Offset = "0x7A94A8")]
		public AimIK aimIK;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A94E0", Offset = "0x7A94E0")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9518", Offset = "0x7A9518")]
		public Handedness handedness;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9550", Offset = "0x7A9550")]
		public bool twoHanded;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9588", Offset = "0x7A9588")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A95C0", Offset = "0x7A95C0")]
		public float magnitudeRandom;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A95F8", Offset = "0x7A95F8")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9630", Offset = "0x7A9630")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9668", Offset = "0x7A9668")]
		public float blendTime;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7A96A0", Offset = "0x7A96A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A96A0", Offset = "0x7A96A0")]
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
			[Address(RVA = "0x1060F68", Offset = "0x1060F68", VA = "0x1060F68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1062224", Offset = "0x1062224", VA = "0x1062224")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1062284", Offset = "0x1062284", VA = "0x1062284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private Transform primaryHand
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x10621CC", Offset = "0x10621CC", VA = "0x10621CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x10621F8", Offset = "0x10621F8", VA = "0x10621F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1060F98", Offset = "0x1060F98", VA = "0x1060F98")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1060FC4", Offset = "0x1060FC4", VA = "0x1060FC4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x106127C", Offset = "0x106127C", VA = "0x106127C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x10622E4", Offset = "0x10622E4", VA = "0x10622E4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1062480", Offset = "0x1062480", VA = "0x1062480")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x10624DC", Offset = "0x10624DC", VA = "0x10624DC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1062750", Offset = "0x1062750", VA = "0x1062750")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9700", Offset = "0x7A9700")]
		public float weight;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9738", Offset = "0x7A9738")]
		public float offset;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1066F00", Offset = "0x1066F00", VA = "0x1066F00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x106703C", Offset = "0x106703C", VA = "0x106703C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1067154", Offset = "0x1067154", VA = "0x1067154")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x10676EC", Offset = "0x10676EC", VA = "0x10676EC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1067750", Offset = "0x1067750", VA = "0x1067750")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x10678B0", Offset = "0x10678B0", VA = "0x10678B0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD770", Offset = "0x7AD770")]
			public float scaleMlp;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD7A8", Offset = "0x7AD7A8")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD7E0", Offset = "0x7AD7E0")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD818", Offset = "0x7AD818")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD850", Offset = "0x7AD850")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD888", Offset = "0x7AD888")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD8C0", Offset = "0x7AD8C0")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD8F8", Offset = "0x7AD8F8")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD930", Offset = "0x7AD930")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7AD968", Offset = "0x7AD968")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD968", Offset = "0x7AD968")]
			public Vector3 headOffset;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD9B8", Offset = "0x7AD9B8")]
			public Vector3 handOffset;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AD9F0", Offset = "0x7AD9F0")]
			public float footForwardOffset;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADA28", Offset = "0x7ADA28")]
			public float footInwardOffset;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADA60", Offset = "0x7ADA60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ADA60", Offset = "0x7ADA60")]
			public float footHeadingOffset;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ADABC", Offset = "0x7ADABC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ADAD4", Offset = "0x7ADAD4")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1A76FF0", Offset = "0x1A76FF0", VA = "0x1A76FF0")]
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
				[Address(RVA = "0x1A76E64", Offset = "0x1A76E64", VA = "0x1A76E64")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000780")]
				[Address(RVA = "0x1A76F4C", Offset = "0x1A76F4C", VA = "0x1A76F4C")]
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
			[Address(RVA = "0x1A76E5C", Offset = "0x1A76E5C", VA = "0x1A76E5C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x106A0EC", Offset = "0x106A0EC", VA = "0x106A0EC")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x106A2E4", Offset = "0x106A2E4", VA = "0x106A2E4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x106BDEC", Offset = "0x106BDEC", VA = "0x106BDEC")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x106C754", Offset = "0x106C754", VA = "0x106C754")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x106D4B0", Offset = "0x106D4B0", VA = "0x106D4B0")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A9770", Offset = "0x7A9770")]
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
			[Address(RVA = "0x1A770E8", Offset = "0x1A770E8", VA = "0x1A770E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AFE2C", Offset = "0x7AFE2C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1A770F4", Offset = "0x1A770F4", VA = "0x1A770F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AFE3C", Offset = "0x7AFE3C")]
			private set
			{
			}
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1A77100", Offset = "0x1A77100", VA = "0x1A77100")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1A77244", Offset = "0x1A77244", VA = "0x1A77244")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1A774E8", Offset = "0x1A774E8", VA = "0x1A774E8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1A776B8", Offset = "0x1A776B8", VA = "0x1A776B8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1A77D88", Offset = "0x1A77D88", VA = "0x1A77D88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1A77EE8", Offset = "0x1A77EE8", VA = "0x1A77EE8")]
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
		[Address(RVA = "0xFD4F70", Offset = "0xFD4F70", VA = "0xFD4F70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xFD506C", Offset = "0xFD506C", VA = "0xFD506C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9780", Offset = "0x7A9780")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xFD5074", Offset = "0xFD5074", VA = "0xFD5074")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xFD5200", Offset = "0xFD5200", VA = "0xFD5200")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A97B8", Offset = "0x7A97B8")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A97F0", Offset = "0x7A97F0")]
		public AimIK aim;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9828", Offset = "0x7A9828")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9860", Offset = "0x7A9860")]
		public Animator animator;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9898", Offset = "0x7A9898")]
		public float crossfadeTime;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A98D0", Offset = "0x7A98D0")]
		public float minAimDistance;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xFEAF1C", Offset = "0xFEAF1C", VA = "0xFEAF1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xFEAF74", Offset = "0xFEAF74", VA = "0xFEAF74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xFEB0FC", Offset = "0xFEB0FC", VA = "0xFEB0FC")]
		private void Pose()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xFEB3B4", Offset = "0xFEB3B4", VA = "0xFEB3B4")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xFEB620", Offset = "0xFEB620", VA = "0xFEB620")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xFEB714", Offset = "0xFEB714", VA = "0xFEB714")]
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
		[Address(RVA = "0xF33E54", Offset = "0xF33E54", VA = "0xF33E54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xF3411C", Offset = "0xF3411C", VA = "0xF3411C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xF34374", Offset = "0xF34374", VA = "0xF34374")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A9908", Offset = "0x7A9908")]
		public Animator animator;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A9940", Offset = "0x7A9940")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9978", Offset = "0x7A9978")]
		public float lookAtWeight;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9990", Offset = "0x7A9990")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A99A8", Offset = "0x7A99A8")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A99C0", Offset = "0x7A99C0")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A99D8", Offset = "0x7A99D8")]
		public float lookAtClampWeight;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A99F0", Offset = "0x7A99F0")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9A08", Offset = "0x7A9A08")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A9A20", Offset = "0x7A9A20")]
		public Transform footTargetBiped;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9A58", Offset = "0x7A9A58")]
		public float footPositionWeight;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9A70", Offset = "0x7A9A70")]
		public float footRotationWeight;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7A9A88", Offset = "0x7A9A88")]
		public Transform handTargetBiped;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9AC0", Offset = "0x7A9AC0")]
		public float handPositionWeight;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9AD8", Offset = "0x7A9AD8")]
		public float handRotationWeight;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xFD74F4", Offset = "0xFD74F4", VA = "0xFD74F4")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xFD7DB0", Offset = "0xFD7DB0", VA = "0xFD7DB0")]
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
		[Address(RVA = "0xFE37B0", Offset = "0xFE37B0", VA = "0xFE37B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xFE4388", Offset = "0xFE4388", VA = "0xFE4388")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xFE400C", Offset = "0xFE400C", VA = "0xFE400C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xFE4584", Offset = "0xFE4584", VA = "0xFE4584")]
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
			[Address(RVA = "0xFE45B0", Offset = "0xFE45B0", VA = "0xFE45B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xFE4650", Offset = "0xFE4650", VA = "0xFE4650")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xFE4984", Offset = "0xFE4984", VA = "0xFE4984")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5B94", Offset = "0x7A5B94")]
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
				[Address(RVA = "0xFE594C", Offset = "0xFE594C", VA = "0xFE594C", Slot = "4")]
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
				[Address(RVA = "0xFE59BC", Offset = "0xFE59BC", VA = "0xFE59BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xFE5510", Offset = "0xFE5510", VA = "0xFE5510")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0xFE556C", Offset = "0xFE556C", VA = "0xFE556C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0xFE5570", Offset = "0xFE5570", VA = "0xFE5570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0xFE5954", Offset = "0xFE5954", VA = "0xFE5954", Slot = "8")]
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
			[Address(RVA = "0xFE4998", Offset = "0xFE4998", VA = "0xFE4998")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 position
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xFE4534", Offset = "0xFE4534", VA = "0xFE4534")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xFE49AC", Offset = "0xFE49AC", VA = "0xFE49AC")]
			set
			{
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xFE4A20", Offset = "0xFE4A20", VA = "0xFE4A20")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xFE4A78", Offset = "0xFE4A78", VA = "0xFE4A78")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xFE4CA0", Offset = "0xFE4CA0", VA = "0xFE4CA0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xFE5164", Offset = "0xFE5164", VA = "0xFE5164")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xFE52A8", Offset = "0xFE52A8", VA = "0xFE52A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xFE51D4", Offset = "0xFE51D4", VA = "0xFE51D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AFE4C", Offset = "0x7AFE4C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xFE553C", Offset = "0xFE553C", VA = "0xFE553C")]
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
		[Address(RVA = "0xFE59C4", Offset = "0xFE59C4", VA = "0xFE59C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xFE5ABC", Offset = "0xFE5ABC", VA = "0xFE5ABC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xFE5D90", Offset = "0xFE5D90", VA = "0xFE5D90")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADAEC", Offset = "0x7ADAEC")]
			public int animationLayer;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADB24", Offset = "0x7ADB24")]
			public string animationState;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADB5C", Offset = "0x7ADB5C")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADB94", Offset = "0x7ADB94")]
			public Transform warpFrom;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADBCC", Offset = "0x7ADBCC")]
			public Transform warpTo;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADC04", Offset = "0x7ADC04")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9AF0", Offset = "0x7A9AF0")]
		public Animator animator;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9B28", Offset = "0x7A9B28")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7A9B60", Offset = "0x7A9B60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9B60", Offset = "0x7A9B60")]
		public Warp[] warps;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xFD5278", Offset = "0xFD5278", VA = "0xFD5278", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xFD52A4", Offset = "0xFD52A4", VA = "0xFD52A4")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xFD5510", Offset = "0xFD5510", VA = "0xFD5510", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xFD5A34", Offset = "0xFD5A34", VA = "0xFD5A34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xFD5AFC", Offset = "0xFD5AFC", VA = "0xFD5AFC")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A55B8", Offset = "0x7A55B8")]
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
		[Address(RVA = "0xFD5B04", Offset = "0xFD5B04", VA = "0xFD5B04", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xFD5B5C", Offset = "0xFD5B5C", VA = "0xFD5B5C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xFD5DD8", Offset = "0xFD5DD8", VA = "0xFD5DD8", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xFD609C", Offset = "0xFD609C", VA = "0xFD609C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A561C", Offset = "0x7A561C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A561C", Offset = "0x7A561C")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9BB0", Offset = "0x7A9BB0")]
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
		[Address(RVA = "0xFD60B0", Offset = "0xFD60B0", VA = "0xFD60B0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xFD6320", Offset = "0xFD6320", VA = "0xFD6320", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xFD6394", Offset = "0xFD6394", VA = "0xFD6394")]
		private void Read()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xFD6584", Offset = "0xFD6584", VA = "0xFD6584")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xFD6608", Offset = "0xFD6608", VA = "0xFD6608")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xFD6DC4", Offset = "0xFD6DC4", VA = "0xFD6DC4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xFD6B08", Offset = "0xFD6B08", VA = "0xFD6B08")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xFD71A4", Offset = "0xFD71A4", VA = "0xFD71A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xFD7304", Offset = "0xFD7304", VA = "0xFD7304")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A56A8", Offset = "0x7A56A8")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xFD9188", Offset = "0xFD9188", VA = "0xFD9188", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xFD91E8", Offset = "0xFD91E8", VA = "0xFD91E8", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xFD9530", Offset = "0xFD9530", VA = "0xFD9530")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xFD96F8", Offset = "0xFD96F8", VA = "0xFD96F8")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A570C", Offset = "0x7A570C")]
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
			[Address(RVA = "0xFDA708", Offset = "0xFDA708", VA = "0xFDA708")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xFDA7A8", Offset = "0xFDA7A8", VA = "0xFDA7A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xFDA404", Offset = "0xFDA404", VA = "0xFDA404")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xFDA478", Offset = "0xFDA478", VA = "0xFDA478")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xFDA848", Offset = "0xFDA848", VA = "0xFDA848")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9BD8", Offset = "0x7A9BD8")]
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
		[Address(RVA = "0xFDD424", Offset = "0xFDD424", VA = "0xFDD424", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xFDDB84", Offset = "0xFDDB84", VA = "0xFDDB84")]
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
		[Address(RVA = "0xFDDB8C", Offset = "0xFDDB8C", VA = "0xFDDB8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xFDDC48", Offset = "0xFDDC48", VA = "0xFDDC48")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xFDE2AC", Offset = "0xFDE2AC", VA = "0xFDE2AC")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xFDE3C4", Offset = "0xFDE3C4", VA = "0xFDE3C4")]
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
			[Address(RVA = "0xFDE63C", Offset = "0xFDE63C", VA = "0xFDE63C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xFDE7B0", Offset = "0xFDE7B0", VA = "0xFDE7B0")]
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
		[Address(RVA = "0xFDE44C", Offset = "0xFDE44C", VA = "0xFDE44C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xFDE700", Offset = "0xFDE700", VA = "0xFDE700")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xFDE79C", Offset = "0xFDE79C", VA = "0xFDE79C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xFDE7A0", Offset = "0xFDE7A0", VA = "0xFDE7A0")]
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
		[Address(RVA = "0xFDE7C0", Offset = "0xFDE7C0", VA = "0xFDE7C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xFDE82C", Offset = "0xFDE82C", VA = "0xFDE82C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xFDE94C", Offset = "0xFDE94C", VA = "0xFDE94C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9BF0", Offset = "0x7A9BF0")]
		public Transform target;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9C28", Offset = "0x7A9C28")]
		public Transform pin;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9C60", Offset = "0x7A9C60")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9C98", Offset = "0x7A9C98")]
		public AimIK aim;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9CD0", Offset = "0x7A9CD0")]
		public float weight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9D08", Offset = "0x7A9D08")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9D40", Offset = "0x7A9D40")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xFDE954", Offset = "0xFDE954", VA = "0xFDE954")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xFDE9AC", Offset = "0xFDE9AC", VA = "0xFDE9AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xFDEC38", Offset = "0xFDEC38", VA = "0xFDEC38")]
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
		[Address(RVA = "0xFDEC40", Offset = "0xFDEC40", VA = "0xFDEC40")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xFDED68", Offset = "0xFDED68", VA = "0xFDED68")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xFDEE40", Offset = "0xFDEE40", VA = "0xFDEE40")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xFDF460", Offset = "0xFDF460", VA = "0xFDF460")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xFDF5C0", Offset = "0xFDF5C0", VA = "0xFDF5C0")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9D78", Offset = "0x7A9D78")]
		public float aimWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9D90", Offset = "0x7A9D90")]
		public float sightWeight;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9DA8", Offset = "0x7A9DA8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9E34", Offset = "0x7A9E34")]
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
		[Address(RVA = "0xFDF5C8", Offset = "0xFDF5C8", VA = "0xFDF5C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xFDF788", Offset = "0xFDF788", VA = "0xFDF788")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xFDF794", Offset = "0xFDF794", VA = "0xFDF794")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xFDFC10", Offset = "0xFDFC10", VA = "0xFDFC10")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xFDFF3C", Offset = "0xFDFF3C", VA = "0xFDFF3C")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xFDF8E0", Offset = "0xFDF8E0", VA = "0xFDF8E0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xFE0D50", Offset = "0xFE0D50", VA = "0xFE0D50")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5770", Offset = "0x7A5770")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5770", Offset = "0x7A5770")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7A9E74", Offset = "0x7A9E74")]
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
		[Address(RVA = "0xFE0D70", Offset = "0xFE0D70", VA = "0xFE0D70")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xFE0DE0", Offset = "0xFE0DE0", VA = "0xFE0DE0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xFE0F48", Offset = "0xFE0F48", VA = "0xFE0F48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xFE0FF8", Offset = "0xFE0FF8", VA = "0xFE0FF8")]
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
		[Address(RVA = "0xFE11E0", Offset = "0xFE11E0", VA = "0xFE11E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xFE13EC", Offset = "0xFE13EC", VA = "0xFE13EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xFE14BC", Offset = "0xFE14BC", VA = "0xFE14BC")]
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
		[Address(RVA = "0xFE17B8", Offset = "0xFE17B8", VA = "0xFE17B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xFE19C8", Offset = "0xFE19C8", VA = "0xFE19C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xFE1F44", Offset = "0xFE1F44", VA = "0xFE1F44")]
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
		[Address(RVA = "0xFE1F54", Offset = "0xFE1F54", VA = "0xFE1F54")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xFE2030", Offset = "0xFE2030", VA = "0xFE2030")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xFE2204", Offset = "0xFE2204", VA = "0xFE2204")]
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
		[Address(RVA = "0xFE220C", Offset = "0xFE220C", VA = "0xFE220C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xFE265C", Offset = "0xFE265C", VA = "0xFE265C")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A57FC", Offset = "0x7A57FC")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9EAC", Offset = "0x7A9EAC")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9EF8", Offset = "0x7A9EF8")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xFE2664", Offset = "0xFE2664", VA = "0xFE2664")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xFE26BC", Offset = "0xFE26BC", VA = "0xFE26BC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xFE2964", Offset = "0xFE2964", VA = "0xFE2964")]
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
				[Address(RVA = "0xFE36C0", Offset = "0xFE36C0", VA = "0xFE36C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xFE29B4", Offset = "0xFE29B4", VA = "0xFE29B4")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xFE2A74", Offset = "0xFE2A74", VA = "0xFE2A74")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xFE346C", Offset = "0xFE346C", VA = "0xFE346C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xFE379C", Offset = "0xFE379C", VA = "0xFE379C")]
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
		[Address(RVA = "0xFE296C", Offset = "0xFE296C", VA = "0xFE296C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xFE29E8", Offset = "0xFE29E8", VA = "0xFE29E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xFE345C", Offset = "0xFE345C", VA = "0xFE345C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADC3C", Offset = "0x7ADC3C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ADC74", Offset = "0x7ADC74")]
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
			[Address(RVA = "0xFE5FA8", Offset = "0xFE5FA8", VA = "0xFE5FA8")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0xFE6254", Offset = "0xFE6254", VA = "0xFE6254")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0xFE62B4", Offset = "0xFE62B4", VA = "0xFE62B4")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0xFE64C0", Offset = "0xFE64C0", VA = "0xFE64C0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0xFE67A4", Offset = "0xFE67A4", VA = "0xFE67A4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9F44", Offset = "0x7A9F44")]
		public Mode mode;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9F7C", Offset = "0x7A9F7C")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9FB4", Offset = "0x7A9FB4")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7A9FEC", Offset = "0x7A9FEC")]
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
		[Address(RVA = "0xFE5D98", Offset = "0xFE5D98", VA = "0xFE5D98", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xFE5ED4", Offset = "0xFE5ED4", VA = "0xFE5ED4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xFE60D4", Offset = "0xFE60D4", VA = "0xFE60D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xFE6400", Offset = "0xFE6400", VA = "0xFE6400")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xFE6628", Offset = "0xFE6628", VA = "0xFE6628", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xFE6794", Offset = "0xFE6794", VA = "0xFE6794")]
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
		[Address(RVA = "0xFE6824", Offset = "0xFE6824", VA = "0xFE6824")]
		private void Start()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xFE68B0", Offset = "0xFE68B0", VA = "0xFE68B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xFE6984", Offset = "0xFE6984", VA = "0xFE6984")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xFE6B68", Offset = "0xFE6B68", VA = "0xFE6B68")]
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
			[Address(RVA = "0xFE7B50", Offset = "0xFE7B50", VA = "0xFE7B50")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xFE7708", Offset = "0xFE7708", VA = "0xFE7708", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xFE7894", Offset = "0xFE7894", VA = "0xFE7894", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xFE7B48", Offset = "0xFE7B48", VA = "0xFE7B48")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5860", Offset = "0x7A5860")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA024", Offset = "0x7AA024")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AA024", Offset = "0x7AA024")]
		public float weight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA078", Offset = "0x7AA078")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA0B0", Offset = "0x7AA0B0")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA0FC", Offset = "0x7AA0FC")]
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
		[Address(RVA = "0xFE7B60", Offset = "0xFE7B60", VA = "0xFE7B60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xFE7F88", Offset = "0xFE7F88", VA = "0xFE7F88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xFE8984", Offset = "0xFE8984", VA = "0xFE8984")]
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
			[Address(RVA = "0xFE8B94", Offset = "0xFE8B94", VA = "0xFE8B94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xFE8A0C", Offset = "0xFE8A0C", VA = "0xFE8A0C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000523")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xFE8BC8", Offset = "0xFE8BC8", VA = "0xFE8BC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xFE8E58", Offset = "0xFE8E58", VA = "0xFE8E58")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xFE9034", Offset = "0xFE9034", VA = "0xFE9034")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xFE9168", Offset = "0xFE9168", VA = "0xFE9168")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xFE92CC", Offset = "0xFE92CC", VA = "0xFE92CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xFE9558", Offset = "0xFE9558", VA = "0xFE9558")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xFE9820", Offset = "0xFE9820", VA = "0xFE9820")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600052C")]
		[Address(RVA = "0xFE9834", Offset = "0xFE9834", VA = "0xFE9834", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xFE9AD0", Offset = "0xFE9AD0", VA = "0xFE9AD0")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600052E")]
		[Address(RVA = "0xFE9AE4", Offset = "0xFE9AE4", VA = "0xFE9AE4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xFE9D3C", Offset = "0xFE9D3C", VA = "0xFE9D3C")]
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
		[Address(RVA = "0xFEA660", Offset = "0xFEA660", VA = "0xFEA660")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xFEA6C4", Offset = "0xFEA6C4", VA = "0xFEA6C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xFEA8FC", Offset = "0xFEA8FC", VA = "0xFEA8FC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A58C4", Offset = "0x7A58C4")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xFEA904", Offset = "0xFEA904", VA = "0xFEA904")]
		private void Start()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xFEA95C", Offset = "0xFEA95C", VA = "0xFEA95C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xFEA9D0", Offset = "0xFEA9D0", VA = "0xFEA9D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xFEAA34", Offset = "0xFEAA34", VA = "0xFEAA34")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5BA4", Offset = "0x7A5BA4")]
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
				[Address(RVA = "0xFEAEA4", Offset = "0xFEAEA4", VA = "0xFEAEA4", Slot = "4")]
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
				[Address(RVA = "0xFEAF14", Offset = "0xFEAF14", VA = "0xFEAF14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0xFEABFC", Offset = "0xFEABFC", VA = "0xFEABFC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0xFEAC38", Offset = "0xFEAC38", VA = "0xFEAC38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0xFEAC3C", Offset = "0xFEAC3C", VA = "0xFEAC3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0xFEAEAC", Offset = "0xFEAEAC", VA = "0xFEAEAC", Slot = "8")]
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
		[Address(RVA = "0xFEAA44", Offset = "0xFEAA44", VA = "0xFEAA44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xFEAB1C", Offset = "0xFEAB1C", VA = "0xFEAB1C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xFEAB64", Offset = "0xFEAB64", VA = "0xFEAB64")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AFEB0", Offset = "0x7AFEB0")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xFEAC28", Offset = "0xFEAC28", VA = "0xFEAC28")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5928", Offset = "0x7A5928")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5BB4", Offset = "0x7A5BB4")]
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
				[Address(RVA = "0xF33DDC", Offset = "0xF33DDC", VA = "0xF33DDC", Slot = "4")]
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
				[Address(RVA = "0xF33E4C", Offset = "0xF33E4C", VA = "0xF33E4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0xF33C00", Offset = "0xF33C00", VA = "0xF33C00")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0xF33C34", Offset = "0xF33C34", VA = "0xF33C34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xF33C38", Offset = "0xF33C38", VA = "0xF33C38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xF33DE4", Offset = "0xF33DE4", VA = "0xF33DE4", Slot = "8")]
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
		[Address(RVA = "0xF33AC8", Offset = "0xF33AC8", VA = "0xF33AC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF33B8C", Offset = "0xF33B8C", VA = "0xF33B8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AFF14", Offset = "0x7AFF14")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF33C2C", Offset = "0xF33C2C", VA = "0xF33C2C")]
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
			[Address(RVA = "0xF3447C", Offset = "0xF3447C", VA = "0xF3447C")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xF355DC", Offset = "0xF355DC", VA = "0xF355DC")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xF349B4", Offset = "0xF349B4", VA = "0xF349B4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xF356CC", Offset = "0xF356CC", VA = "0xF356CC")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0xF358B4", Offset = "0xF358B4", VA = "0xF358B4")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xF35950", Offset = "0xF35950", VA = "0xF35950")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xF359E8", Offset = "0xF359E8", VA = "0xF359E8")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xF35344", Offset = "0xF35344", VA = "0xF35344")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xF35A80", Offset = "0xF35A80", VA = "0xF35A80")]
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
		[Address(RVA = "0xF343E8", Offset = "0xF343E8", VA = "0xF343E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF34914", Offset = "0xF34914", VA = "0xF34914")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF35248", Offset = "0xF35248", VA = "0xF35248")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF355D4", Offset = "0xF355D4", VA = "0xF355D4")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA1E8", Offset = "0x7AA1E8")]
		public Transform to;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA220", Offset = "0x7AA220")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AA220", Offset = "0x7AA220")]
		public float transferMotion;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xF35AC0", Offset = "0xF35AC0", VA = "0xF35AC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF35B04", Offset = "0xF35B04", VA = "0xF35B04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xF35C9C", Offset = "0xF35C9C", VA = "0xF35C9C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA274", Offset = "0x7AA274")]
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
		[Address(RVA = "0xF35EC8", Offset = "0xF35EC8", VA = "0xF35EC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF36128", Offset = "0xF36128", VA = "0xF36128")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF364F8", Offset = "0xF364F8", VA = "0xF364F8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF36670", Offset = "0xF36670", VA = "0xF36670")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xF367D0", Offset = "0xF367D0", VA = "0xF367D0")]
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
		[Address(RVA = "0xF36C0C", Offset = "0xF36C0C", VA = "0xF36C0C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF370D0", Offset = "0xF370D0", VA = "0xF370D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF37294", Offset = "0xF37294", VA = "0xF37294")]
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
		[Address(RVA = "0xFE1008", Offset = "0xFE1008", VA = "0xFE1008")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xFE1128", Offset = "0xFE1128", VA = "0xFE1128")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xFE11D8", Offset = "0xFE11D8", VA = "0xFE11D8")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A5BC4", Offset = "0x7A5BC4")]
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
				[Address(RVA = "0xFEA5E8", Offset = "0xFEA5E8", VA = "0xFEA5E8", Slot = "4")]
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
				[Address(RVA = "0xFEA658", Offset = "0xFEA658", VA = "0xFEA658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xFEA184", Offset = "0xFEA184", VA = "0xFEA184")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xFEA3F0", Offset = "0xFEA3F0", VA = "0xFEA3F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xFEA3F4", Offset = "0xFEA3F4", VA = "0xFEA3F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xFEA5F0", Offset = "0xFEA5F0", VA = "0xFEA5F0", Slot = "8")]
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
		[Address(RVA = "0xFE9D50", Offset = "0xFE9D50", VA = "0xFE9D50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xFE9EF4", Offset = "0xFE9EF4", VA = "0xFE9EF4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xFE9E80", Offset = "0xFE9E80", VA = "0xFE9E80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AFF78", Offset = "0x7AFF78")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xFEA1B0", Offset = "0xFEA1B0", VA = "0xFEA1B0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xFEA2C4", Offset = "0xFEA2C4", VA = "0xFEA2C4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xFEA3D4", Offset = "0xFEA3D4", VA = "0xFEA3D4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AA2DC", Offset = "0x7AA2DC")]
		public float weight;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xFD7364", Offset = "0xFD7364", VA = "0xFD7364")]
		private void Start()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xFD73D0", Offset = "0xFD73D0", VA = "0xFD73D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xFD74E4", Offset = "0xFD74E4", VA = "0xFD74E4")]
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
			[Address(RVA = "0xF35D44", Offset = "0xF35D44", VA = "0xF35D44")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xF35EC0", Offset = "0xF35EC0", VA = "0xF35EC0")]
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
		[Address(RVA = "0xF35CB0", Offset = "0xF35CB0", VA = "0xF35CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF35EB8", Offset = "0xF35EB8", VA = "0xF35EB8")]
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
		[Address(RVA = "0xFE14CC", Offset = "0xFE14CC", VA = "0xFE14CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xFE16D8", Offset = "0xFE16D8", VA = "0xFE16D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xFE17A8", Offset = "0xFE17A8", VA = "0xFE17A8")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA314", Offset = "0x7AA314")]
		public VRIK ik;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA34C", Offset = "0x7AA34C")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA384", Offset = "0x7AA384")]
		public Transform headTracker;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA3BC", Offset = "0x7AA3BC")]
		public Transform bodyTracker;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA3F4", Offset = "0x7AA3F4")]
		public Transform leftHandTracker;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA42C", Offset = "0x7AA42C")]
		public Transform rightHandTracker;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA464", Offset = "0x7AA464")]
		public Transform leftFootTracker;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA49C", Offset = "0x7AA49C")]
		public Transform rightFootTracker;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA4D4", Offset = "0x7AA4D4")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xF372B8", Offset = "0xF372B8", VA = "0xF372B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xF37424", Offset = "0xF37424", VA = "0xF37424")]
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
		[Address(RVA = "0xF3748C", Offset = "0xF3748C", VA = "0xF3748C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xF374FC", Offset = "0xF374FC", VA = "0xF374FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xF3776C", Offset = "0xF3776C", VA = "0xF3776C")]
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
		[Address(RVA = "0xF377E4", Offset = "0xF377E4", VA = "0xF377E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xF37F00", Offset = "0xF37F00", VA = "0xF37F00")]
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
			[Address(RVA = "0xFD7E04", Offset = "0xFD7E04", VA = "0xFD7E04", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xFD7DD0", Offset = "0xFD7DD0", VA = "0xFD7DD0", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xFD7E0C", Offset = "0xFD7E0C", VA = "0xFD7E0C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xFD7ED8", Offset = "0xFD7ED8", VA = "0xFD7ED8", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xFD81C0", Offset = "0xFD81C0", VA = "0xFD81C0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xFD84E0", Offset = "0xFD84E0", VA = "0xFD84E0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xFD81D0", Offset = "0xFD81D0", VA = "0xFD81D0")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xFD84F0", Offset = "0xFD84F0", VA = "0xFD84F0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A598C", Offset = "0x7A598C")]
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
		[Address(RVA = "0xFD8508", Offset = "0xFD8508", VA = "0xFD8508", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xFD8568", Offset = "0xFD8568", VA = "0xFD8568", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xFD86B4", Offset = "0xFD86B4", VA = "0xFD86B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xFD8888", Offset = "0xFD8888", VA = "0xFD8888")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A59F0", Offset = "0x7A59F0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AA56C", Offset = "0x7AA56C")]
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
			[Address(RVA = "0xFD895C", Offset = "0xFD895C", VA = "0xFD895C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xFD88A0", Offset = "0xFD88A0", VA = "0xFD88A0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xFD892C", Offset = "0xFD892C", VA = "0xFD892C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xFD8A60", Offset = "0xFD8A60", VA = "0xFD8A60", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xFD8F80", Offset = "0xFD8F80", VA = "0xFD8F80")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xFD9164", Offset = "0xFD9164", VA = "0xFD9164")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5A54", Offset = "0x7A5A54")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5A54", Offset = "0x7A5A54")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA5B0", Offset = "0x7AA5B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA5B0", Offset = "0x7AA5B0")]
		public Transform gravityTarget;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA610", Offset = "0x7AA610")]
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
		[Address(RVA = "0xFD971C", Offset = "0xFD971C", VA = "0xFD971C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xFD98B4", Offset = "0xFD98B4", VA = "0xFD98B4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xFD9AA0", Offset = "0xFD9AA0", VA = "0xFD9AA0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xFD9D5C", Offset = "0xFD9D5C", VA = "0xFD9D5C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xFD9E28", Offset = "0xFD9E28", VA = "0xFD9E28")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xFDA070", Offset = "0xFDA070", VA = "0xFDA070")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xFDA270", Offset = "0xFDA270", VA = "0xFDA270")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xFDA2A8", Offset = "0xFDA2A8", VA = "0xFDA2A8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xFDA2E0", Offset = "0xFDA2E0", VA = "0xFDA2E0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xFDA3E4", Offset = "0xFDA3E4", VA = "0xFDA3E4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA6AC", Offset = "0x7AA6AC")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA6E4", Offset = "0x7AA6E4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA71C", Offset = "0x7AA71C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA754", Offset = "0x7AA754")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA78C", Offset = "0x7AA78C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7AA7D8", Offset = "0x7AA7D8")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AA810", Offset = "0x7AA810")]
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
			[Address(RVA = "0xFDA850", Offset = "0xFDA850", VA = "0xFDA850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AFFDC", Offset = "0x7AFFDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xFDA858", Offset = "0xFDA858", VA = "0xFDA858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AFFEC", Offset = "0x7AFFEC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xFDA864", Offset = "0xFDA864", VA = "0xFDA864", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xFDA9FC", Offset = "0xFDA9FC", VA = "0xFDA9FC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xFDAAA0", Offset = "0xFDAAA0", VA = "0xFDAAA0", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xFDABDC", Offset = "0xFDABDC", VA = "0xFDABDC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xFDBD50", Offset = "0xFDBD50", VA = "0xFDBD50", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xFDC120", Offset = "0xFDC120", VA = "0xFDC120", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xFDB338", Offset = "0xFDB338", VA = "0xFDB338")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xFDC240", Offset = "0xFDC240", VA = "0xFDC240")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xFDC8EC", Offset = "0xFDC8EC", VA = "0xFDC8EC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xFDBE30", Offset = "0xFDBE30", VA = "0xFDBE30")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xFDC990", Offset = "0xFDC990", VA = "0xFDC990", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xFDCED4", Offset = "0xFDCED4", VA = "0xFDCED4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xFDD0D0", Offset = "0xFDD0D0", VA = "0xFDD0D0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xFDB8C8", Offset = "0xFDB8C8", VA = "0xFDB8C8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xFDD2FC", Offset = "0xFDD2FC", VA = "0xFDD2FC")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A5AE0", Offset = "0x7A5AE0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA820", Offset = "0x7AA820")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA86C", Offset = "0x7AA86C")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA8B8", Offset = "0x7AA8B8")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA904", Offset = "0x7AA904")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA950", Offset = "0x7AA950")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AA99C", Offset = "0x7AA99C")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AA9E8", Offset = "0x7AA9E8")]
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
			[Address(RVA = "0xFDE2A4", Offset = "0xFDE2A4", VA = "0xFDE2A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AFFFC", Offset = "0x7AFFFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xFEB72C", Offset = "0xFEB72C", VA = "0xFEB72C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B000C", Offset = "0x7B000C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xFEB738", Offset = "0xFEB738", VA = "0xFEB738")]
		private void Start()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xFEB7C4", Offset = "0xFEB7C4", VA = "0xFEB7C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xFEBF7C", Offset = "0xFEBF7C", VA = "0xFEBF7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xFEB820", Offset = "0xFEB820", VA = "0xFEB820")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xFEBC7C", Offset = "0xFEBC7C", VA = "0xFEBC7C")]
		private void Move()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xFEBFCC", Offset = "0xFEBFCC", VA = "0xFEBFCC")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xFEC0C4", Offset = "0xFEC0C4", VA = "0xFEC0C4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xFEC164", Offset = "0xFEC164", VA = "0xFEC164")]
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
		[Address(RVA = "0xF367D8", Offset = "0xF367D8", VA = "0xF367D8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xF36864", Offset = "0xF36864", VA = "0xF36864", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xF36B88", Offset = "0xF36B88", VA = "0xF36B88")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF36BE0", Offset = "0xF36BE0", VA = "0xF36BE0")]
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
		[Address(RVA = "0xF36824", Offset = "0xF36824", VA = "0xF36824", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xF36D40", Offset = "0xF36D40", VA = "0xF36D40", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xF36BFC", Offset = "0xF36BFC", VA = "0xF36BFC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xFD7320", Offset = "0xFD7320", VA = "0xFD7320")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xFD735C", Offset = "0xFD735C", VA = "0xFD735C")]
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
		[Address(RVA = "0xF339B0", Offset = "0xF339B0", VA = "0xF339B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xF339E4", Offset = "0xF339E4", VA = "0xF339E4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xF33AB4", Offset = "0xF33AB4", VA = "0xF33AB4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAA38", Offset = "0x7AAA38")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAA70", Offset = "0x7AAA70")]
		public float cornerRadius;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAAA8", Offset = "0x7AAAA8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAAE0", Offset = "0x7AAAE0")]
		public float maxSampleDistance;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7AAB18", Offset = "0x7AAB18")]
		public float nextPathInterval;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAB50", Offset = "0x7AAB50")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AAB60", Offset = "0x7AAB60")]
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
			[Address(RVA = "0xFE6B7C", Offset = "0xFE6B7C", VA = "0xFE6B7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B001C", Offset = "0x7B001C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xFE6B88", Offset = "0xFE6B88", VA = "0xFE6B88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B002C", Offset = "0x7B002C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public State state
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xFE6B94", Offset = "0xFE6B94", VA = "0xFE6B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B003C", Offset = "0x7B003C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xFE6B9C", Offset = "0xFE6B9C", VA = "0xFE6B9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7B004C", Offset = "0x7B004C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xFE6BA4", Offset = "0xFE6BA4", VA = "0xFE6BA4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xFE6C78", Offset = "0xFE6C78", VA = "0xFE6C78")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xFE7234", Offset = "0xFE7234", VA = "0xFE7234")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xFE72A4", Offset = "0xFE72A4", VA = "0xFE72A4")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xFE70FC", Offset = "0xFE70FC", VA = "0xFE70FC")]
		private void Stop()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xFE7170", Offset = "0xFE7170", VA = "0xFE7170")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xFE740C", Offset = "0xFE740C", VA = "0xFE740C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xFE769C", Offset = "0xFE769C", VA = "0xFE769C")]
		public Navigator()
		{
		}
	}
}
