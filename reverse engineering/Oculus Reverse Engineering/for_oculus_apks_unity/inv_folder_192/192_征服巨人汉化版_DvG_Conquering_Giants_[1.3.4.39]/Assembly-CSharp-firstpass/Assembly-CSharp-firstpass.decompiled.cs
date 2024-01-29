using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[assembly: AssemblyVersion("3.7.1.6")]
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000002")]
	public enum Axis
	{
		[Token(Token = "0x4000002")]
		X,
		[Token(Token = "0x4000003")]
		Y,
		[Token(Token = "0x4000004")]
		Z
	}
	[Token(Token = "0x2000003")]
	public class AxisTools
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xE81004", Offset = "0xE81004", VA = "0xE81004")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE810C4", Offset = "0xE810C4", VA = "0xE810C4")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xE81170", Offset = "0xE81170", VA = "0xE81170")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xE81358", Offset = "0xE81358", VA = "0xE81358")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xE8128C", Offset = "0xE8128C", VA = "0xE8128C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xE81474", Offset = "0xE81474", VA = "0xE81474")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xE814CC", Offset = "0xE814CC", VA = "0xE814CC")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xE81794", Offset = "0xE81794", VA = "0xE81794")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000004")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000071")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600047E")]
			[Address(RVA = "0xE81A5C", Offset = "0xE81A5C", VA = "0xE81A5C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000001")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xE817E8", Offset = "0xE817E8", VA = "0xE817E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0xE81AD8", Offset = "0xE81AD8", VA = "0xE81AD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xE8179C", Offset = "0xE8179C", VA = "0xE8179C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public enum BoneType
		{
			[Token(Token = "0x4000357")]
			Unassigned,
			[Token(Token = "0x4000358")]
			Spine,
			[Token(Token = "0x4000359")]
			Head,
			[Token(Token = "0x400035A")]
			Arm,
			[Token(Token = "0x400035B")]
			Leg,
			[Token(Token = "0x400035C")]
			Tail,
			[Token(Token = "0x400035D")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000073")]
		public enum BoneSide
		{
			[Token(Token = "0x400035F")]
			Center,
			[Token(Token = "0x4000360")]
			Left,
			[Token(Token = "0x4000361")]
			Right
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE81D4C", Offset = "0xE81D4C", VA = "0xE81D4C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xE82090", Offset = "0xE82090", VA = "0xE82090")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE82324", Offset = "0xE82324", VA = "0xE82324")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE823A8", Offset = "0xE823A8", VA = "0xE823A8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xE8245C", Offset = "0xE8245C", VA = "0xE8245C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xE81F40", Offset = "0xE81F40", VA = "0xE81F40")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xE82284", Offset = "0xE82284", VA = "0xE82284")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xE82CB0", Offset = "0xE82CB0", VA = "0xE82CB0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE82AC8", Offset = "0xE82AC8", VA = "0xE82AC8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE82BBC", Offset = "0xE82BBC", VA = "0xE82BBC")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE82690", Offset = "0xE82690", VA = "0xE82690")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE82744", Offset = "0xE82744", VA = "0xE82744")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE827F8", Offset = "0xE827F8", VA = "0xE827F8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE828AC", Offset = "0xE828AC", VA = "0xE828AC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE82960", Offset = "0xE82960", VA = "0xE82960")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE82A14", Offset = "0xE82A14", VA = "0xE82A14")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE82F2C", Offset = "0xE82F2C", VA = "0xE82F2C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE8259C", Offset = "0xE8259C", VA = "0xE8259C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE82E94", Offset = "0xE82E94", VA = "0xE82E94")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE82F9C", Offset = "0xE82F9C", VA = "0xE82F9C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE83070", Offset = "0xE83070", VA = "0xE83070")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE82E00", Offset = "0xE82E00", VA = "0xE82E00")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE82D40", Offset = "0xE82D40", VA = "0xE82D40")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class BipedReferences
	{
		[Token(Token = "0x2000074")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000061")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000480")]
				[Address(RVA = "0xE89B68", Offset = "0xE89B68", VA = "0xE89B68")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x6FA378", Offset = "0x6FA378", VA = "0x6FA378")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000003")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xE85B54", Offset = "0xE85B54", VA = "0xE85B54", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool isEmpty
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xE85F58", Offset = "0xE85F58", VA = "0xE85F58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xE85F68", Offset = "0xE85F68", VA = "0xE85F68", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xE863AC", Offset = "0xE863AC", VA = "0xE863AC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xE867F4", Offset = "0xE867F4", VA = "0xE867F4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xE8703C", Offset = "0xE8703C", VA = "0xE8703C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xE86A78", Offset = "0xE86A78", VA = "0xE86A78")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xE87B20", Offset = "0xE87B20", VA = "0xE87B20")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xE87C18", Offset = "0xE87C18", VA = "0xE87C18")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xE88248", Offset = "0xE88248", VA = "0xE88248")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xE88018", Offset = "0xE88018", VA = "0xE88018")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xE87E60", Offset = "0xE87E60", VA = "0xE87E60")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xE87CF0", Offset = "0xE87CF0", VA = "0xE87CF0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xE88130", Offset = "0xE88130", VA = "0xE88130")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE88354", Offset = "0xE88354", VA = "0xE88354")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE891F8", Offset = "0xE891F8", VA = "0xE891F8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xE88AE4", Offset = "0xE88AE4", VA = "0xE88AE4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE895B0", Offset = "0xE895B0", VA = "0xE895B0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE88FA4", Offset = "0xE88FA4", VA = "0xE88FA4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE895B8", Offset = "0xE895B8", VA = "0xE895B8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE895C0", Offset = "0xE895C0", VA = "0xE895C0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xE897CC", Offset = "0xE897CC", VA = "0xE897CC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xE89A30", Offset = "0xE89A30", VA = "0xE89A30")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xE86A08", Offset = "0xE86A08", VA = "0xE86A08")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x63ECD8", Offset = "0x63ECD8")]
		public string text;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xE89B70", Offset = "0xE89B70", VA = "0xE89B70")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xE89B78", Offset = "0xE89B78", VA = "0xE89B78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xE89C38", Offset = "0xE89C38", VA = "0xE89C38")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class Hierarchy
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1553F34", Offset = "0x1553F34", VA = "0x1553F34")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1554168", Offset = "0x1554168", VA = "0x1554168")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1553FE4", Offset = "0x1553FE4", VA = "0x1553FE4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x15542B4", Offset = "0x15542B4", VA = "0x15542B4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x15543DC", Offset = "0x15543DC", VA = "0x15543DC")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x155472C", Offset = "0x155472C", VA = "0x155472C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1554870", Offset = "0x1554870", VA = "0x1554870")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1554A1C", Offset = "0x1554A1C", VA = "0x1554A1C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1554E04", Offset = "0x1554E04", VA = "0x1554E04")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1554BD0", Offset = "0x1554BD0", VA = "0x1554BD0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1554FB4", Offset = "0x1554FB4", VA = "0x1554FB4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1554FBC", Offset = "0x1554FBC", VA = "0x1554FBC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x155502C", Offset = "0x155502C", VA = "0x155502C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000032")]
		None,
		[Token(Token = "0x4000033")]
		InOutCubic,
		[Token(Token = "0x4000034")]
		InOutQuintic,
		[Token(Token = "0x4000035")]
		InOutSine,
		[Token(Token = "0x4000036")]
		InQuintic,
		[Token(Token = "0x4000037")]
		InQuartic,
		[Token(Token = "0x4000038")]
		InCubic,
		[Token(Token = "0x4000039")]
		InQuadratic,
		[Token(Token = "0x400003A")]
		InElastic,
		[Token(Token = "0x400003B")]
		InElasticSmall,
		[Token(Token = "0x400003C")]
		InElasticBig,
		[Token(Token = "0x400003D")]
		InSine,
		[Token(Token = "0x400003E")]
		InBack,
		[Token(Token = "0x400003F")]
		OutQuintic,
		[Token(Token = "0x4000040")]
		OutQuartic,
		[Token(Token = "0x4000041")]
		OutCubic,
		[Token(Token = "0x4000042")]
		OutInCubic,
		[Token(Token = "0x4000043")]
		OutInQuartic,
		[Token(Token = "0x4000044")]
		OutElastic,
		[Token(Token = "0x4000045")]
		OutElasticSmall,
		[Token(Token = "0x4000046")]
		OutElasticBig,
		[Token(Token = "0x4000047")]
		OutSine,
		[Token(Token = "0x4000048")]
		OutBack,
		[Token(Token = "0x4000049")]
		OutBackCubic,
		[Token(Token = "0x400004A")]
		OutBackQuartic,
		[Token(Token = "0x400004B")]
		BackInCubic,
		[Token(Token = "0x400004C")]
		BackInQuartic
	}
	[Token(Token = "0x200000C")]
	public class Interp
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x155509C", Offset = "0x155509C", VA = "0x155509C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1555B0C", Offset = "0x1555B0C", VA = "0x1555B0C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1555C14", Offset = "0x1555C14", VA = "0x1555C14")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x155540C", Offset = "0x155540C", VA = "0x155540C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1555418", Offset = "0x1555418", VA = "0x1555418")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1555440", Offset = "0x1555440", VA = "0x1555440")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x155547C", Offset = "0x155547C", VA = "0x155547C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1555494", Offset = "0x1555494", VA = "0x1555494")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15554A8", Offset = "0x15554A8", VA = "0x15554A8")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x15554BC", Offset = "0x15554BC", VA = "0x15554BC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x15554CC", Offset = "0x15554CC", VA = "0x15554CC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1555514", Offset = "0x1555514", VA = "0x1555514")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x155554C", Offset = "0x155554C", VA = "0x155554C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1555574", Offset = "0x1555574", VA = "0x1555574")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1555D10", Offset = "0x1555D10", VA = "0x1555D10")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x15555A8", Offset = "0x15555A8", VA = "0x15555A8")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x15555D0", Offset = "0x15555D0", VA = "0x15555D0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1555600", Offset = "0x1555600", VA = "0x1555600")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1555634", Offset = "0x1555634", VA = "0x1555634")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1555678", Offset = "0x1555678", VA = "0x1555678")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15556DC", Offset = "0x15556DC", VA = "0x15556DC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1555740", Offset = "0x1555740", VA = "0x1555740")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1555794", Offset = "0x1555794", VA = "0x1555794")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15557E8", Offset = "0x15557E8", VA = "0x15557E8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1555880", Offset = "0x1555880", VA = "0x1555880")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1555914", Offset = "0x1555914", VA = "0x1555914")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1555D44", Offset = "0x1555D44", VA = "0x1555D44")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x15559B8", Offset = "0x15559B8", VA = "0x15559B8")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1555A9C", Offset = "0x1555A9C", VA = "0x1555A9C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1555ACC", Offset = "0x1555ACC", VA = "0x1555ACC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1555E2C", Offset = "0x1555E2C", VA = "0x1555E2C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1555E34", Offset = "0x1555E34", VA = "0x1555E34")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1555EA4", Offset = "0x1555EA4", VA = "0x1555EA4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1555F14", Offset = "0x1555F14", VA = "0x1555F14")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1555F70", Offset = "0x1555F70", VA = "0x1555F70")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1556048", Offset = "0x1556048", VA = "0x1556048")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1555F88", Offset = "0x1555F88", VA = "0x1555F88")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1556060", Offset = "0x1556060", VA = "0x1556060")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1556110", Offset = "0x1556110", VA = "0x1556110")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x155613C", Offset = "0x155613C", VA = "0x155613C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x155618C", Offset = "0x155618C", VA = "0x155618C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15561F8", Offset = "0x15561F8", VA = "0x15561F8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15562F8", Offset = "0x15562F8", VA = "0x15562F8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15563DC", Offset = "0x15563DC", VA = "0x15563DC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x155643C", Offset = "0x155643C", VA = "0x155643C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	public static class QuaTools
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x155646C", Offset = "0x155646C", VA = "0x155646C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15565B8", Offset = "0x15565B8", VA = "0x15565B8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1556704", Offset = "0x1556704", VA = "0x1556704")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1556818", Offset = "0x1556818", VA = "0x1556818")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x155692C", Offset = "0x155692C", VA = "0x155692C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1556AB8", Offset = "0x1556AB8", VA = "0x1556AB8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1556B88", Offset = "0x1556B88", VA = "0x1556B88")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1556CDC", Offset = "0x1556CDC", VA = "0x1556CDC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1556F60", Offset = "0x1556F60", VA = "0x1556F60")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1557174", Offset = "0x1557174", VA = "0x1557174")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x15572F4", Offset = "0x15572F4", VA = "0x15572F4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1557464", Offset = "0x1557464", VA = "0x1557464")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1557574", Offset = "0x1557574", VA = "0x1557574")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000010")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000005")]
		public static T instance
		{
			[Token(Token = "0x6000086")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000088")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63ECE8", Offset = "0x63ECE8")]
		public bool fixTransforms;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000006")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1557708", Offset = "0x1557708", VA = "0x1557708")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		private bool isAnimated
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x1557A5C", Offset = "0x1557A5C", VA = "0x1557A5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x15575D0", Offset = "0x15575D0", VA = "0x15575D0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1557668", Offset = "0x1557668", VA = "0x1557668", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x155766C", Offset = "0x155766C", VA = "0x155766C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1557670", Offset = "0x1557670", VA = "0x1557670", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1557674", Offset = "0x1557674", VA = "0x1557674")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1557704", Offset = "0x1557704", VA = "0x1557704")]
		private void Start()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x15576AC", Offset = "0x15576AC", VA = "0x15576AC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1557A0C", Offset = "0x1557A0C", VA = "0x1557A0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x155780C", Offset = "0x155780C", VA = "0x155780C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1557B18", Offset = "0x1557B18", VA = "0x1557B18")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1557B74", Offset = "0x1557B74", VA = "0x1557B74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1557BD4", Offset = "0x1557BD4", VA = "0x1557BD4")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1557C1C", Offset = "0x1557C1C", VA = "0x1557C1C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1557C2C", Offset = "0x1557C2C", VA = "0x1557C2C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1557CEC", Offset = "0x1557CEC", VA = "0x1557CEC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1557DAC", Offset = "0x1557DAC", VA = "0x1557DAC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1557E6C", Offset = "0x1557E6C", VA = "0x1557E6C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public static class V3Tools
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1557E74", Offset = "0x1557E74", VA = "0x1557E74")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1557F6C", Offset = "0x1557F6C", VA = "0x1557F6C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1558064", Offset = "0x1558064", VA = "0x1558064")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x155815C", Offset = "0x155815C", VA = "0x155815C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x155825C", Offset = "0x155825C", VA = "0x155825C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1558480", Offset = "0x1558480", VA = "0x1558480")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x15586BC", Offset = "0x15586BC", VA = "0x15586BC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x155890C", Offset = "0x155890C", VA = "0x155890C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1558B1C", Offset = "0x1558B1C", VA = "0x1558B1C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1558CF8", Offset = "0x1558CF8", VA = "0x1558CF8")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1558E3C", Offset = "0x1558E3C", VA = "0x1558E3C")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000014")]
	public static class Warning
	{
		[Token(Token = "0x2000075")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1558F9C", Offset = "0x1558F9C", VA = "0x1558F9C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1559768", Offset = "0x1559768", VA = "0x1559768")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x2000015")]
	public class Navigator
	{
		[Token(Token = "0x2000076")]
		public enum State
		{
			[Token(Token = "0x4000365")]
			Idle,
			[Token(Token = "0x4000366")]
			Seeking,
			[Token(Token = "0x4000367")]
			OnPath
		}

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63ED20", Offset = "0x63ED20")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63ED58", Offset = "0x63ED58")]
		public float cornerRadius;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63ED90", Offset = "0x63ED90")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EDC8", Offset = "0x63EDC8")]
		public float maxSampleDistance;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EE00", Offset = "0x63EE00")]
		public float nextPathInterval;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE38", Offset = "0x63EE38")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE48", Offset = "0x63EE48")]
		private State <state>k__BackingField;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000008")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xE89C6C", Offset = "0xE89C6C", VA = "0xE89C6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645748", Offset = "0x645748")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xE89C78", Offset = "0xE89C78", VA = "0xE89C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645758", Offset = "0x645758")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public State state
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xE89C84", Offset = "0xE89C84", VA = "0xE89C84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645768", Offset = "0x645768")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xE89C8C", Offset = "0xE89C8C", VA = "0xE89C8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645778", Offset = "0x645778")]
			private set
			{
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE89C94", Offset = "0xE89C94", VA = "0xE89C94")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE89D68", Offset = "0xE89D68", VA = "0xE89D68")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE8A324", Offset = "0xE8A324", VA = "0xE8A324")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE8A394", Offset = "0xE8A394", VA = "0xE8A394")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE8A1EC", Offset = "0xE8A1EC", VA = "0xE8A1EC")]
		private void Stop()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE8A260", Offset = "0xE8A260", VA = "0xE8A260")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE8A4FC", Offset = "0xE8A4FC", VA = "0xE8A4FC")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE8A78C", Offset = "0xE8A78C", VA = "0xE8A78C")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E2DC", Offset = "0x63E2DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E2DC", Offset = "0x63E2DC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE8CCF4", Offset = "0xE8CCF4", VA = "0xE8CCF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645788", Offset = "0x645788")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE8CD40", Offset = "0xE8CD40", VA = "0xE8CD40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6457C0", Offset = "0x6457C0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE8CD8C", Offset = "0xE8CD8C", VA = "0xE8CD8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6457F8", Offset = "0x6457F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE8CDD8", Offset = "0xE8CDD8", VA = "0xE8CDD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645830", Offset = "0x645830")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE8CE24", Offset = "0xE8CE24", VA = "0xE8CE24")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE8CEF4", Offset = "0xE8CEF4", VA = "0xE8CEF4")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE8CF24", Offset = "0xE8CF24", VA = "0xE8CF24")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE8CF64", Offset = "0xE8CF64", VA = "0xE8CF64")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE8CFA4", Offset = "0xE8CFA4", VA = "0xE8CFA4")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE8CFFC", Offset = "0xE8CFFC", VA = "0xE8CFFC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE8D05C", Offset = "0xE8D05C", VA = "0xE8D05C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE8D090", Offset = "0xE8D090", VA = "0xE8D090")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE8D0C0", Offset = "0xE8D0C0", VA = "0xE8D0C0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE8D158", Offset = "0xE8D158", VA = "0xE8D158")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE8D1C0", Offset = "0xE8D1C0", VA = "0xE8D1C0")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xE8D228", Offset = "0xE8D228", VA = "0xE8D228")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE8CE54", Offset = "0xE8CE54", VA = "0xE8CE54")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE8D278", Offset = "0xE8D278", VA = "0xE8D278")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE8D284", Offset = "0xE8D284", VA = "0xE8D284")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE8D290", Offset = "0xE8D290", VA = "0xE8D290")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE8D6DC", Offset = "0xE8D6DC", VA = "0xE8D6DC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xE8D7D4", Offset = "0xE8D7D4", VA = "0xE8D7D4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE8DD14", Offset = "0xE8DD14", VA = "0xE8DD14", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE8E3E4", Offset = "0xE8E3E4", VA = "0xE8E3E4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE8E418", Offset = "0xE8E418", VA = "0xE8E418")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000A")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xE8D524", Offset = "0xE8D524", VA = "0xE8D524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xE8E5E0", Offset = "0xE8E5E0", VA = "0xE8E5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE8DA58", Offset = "0xE8DA58", VA = "0xE8DA58")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE8E498", Offset = "0xE8E498", VA = "0xE8E498")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700000C")]
		public bool isValid
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xE8ECF8", Offset = "0xE8ECF8", VA = "0xE8ECF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D4")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE8ED68", Offset = "0xE8ED68", VA = "0xE8ED68")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE8ED70", Offset = "0xE8ED70", VA = "0xE8ED70", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE8EEA4", Offset = "0xE8EEA4", VA = "0xE8EEA4")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE8EEAC", Offset = "0xE8EEAC", VA = "0xE8EEAC")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700000D")]
		private bool positionChanged
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xE8F104", Offset = "0xE8F104", VA = "0xE8F104")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE8EED8", Offset = "0xE8EED8", VA = "0xE8EED8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE8F1C8", Offset = "0xE8F1C8", VA = "0xE8F1C8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xE8F1D0", Offset = "0xE8F1D0", VA = "0xE8F1D0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE8F1FC", Offset = "0xE8F1FC", VA = "0xE8F1FC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE8F354", Offset = "0xE8F354", VA = "0xE8F354")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE8F35C", Offset = "0xE8F35C", VA = "0xE8F35C")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700000E")]
		private bool rotationChanged
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xE8F5C8", Offset = "0xE8F5C8", VA = "0xE8F5C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE8F388", Offset = "0xE8F388", VA = "0xE8F388", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE8F6A0", Offset = "0xE8F6A0", VA = "0xE8F6A0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE8F6A8", Offset = "0xE8F6A8", VA = "0xE8F6A8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class Constraints
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63EE58", Offset = "0x63EE58")]
		public float positionWeight;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63EE70", Offset = "0x63EE70")]
		public float rotationWeight;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE8F6D4", Offset = "0xE8F6D4", VA = "0xE8F6D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE8DC9C", Offset = "0xE8DC9C", VA = "0xE8DC9C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE8DFB0", Offset = "0xE8DFB0", VA = "0xE8DFB0")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE8E87C", Offset = "0xE8E87C", VA = "0xE8E87C")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000077")]
		public enum DOF
		{
			[Token(Token = "0x4000369")]
			One,
			[Token(Token = "0x400036A")]
			Three
		}

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EE88", Offset = "0x63EE88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63EE88", Offset = "0x63EE88")]
		public float weight;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EEDC", Offset = "0x63EEDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63EEDC", Offset = "0x63EEDC")]
		public float rotationWeight;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EF30", Offset = "0x63EF30")]
		public DOF rotationDOF;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EF68", Offset = "0x63EF68")]
		public bool fixBone1Twist;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EFA0", Offset = "0x63EFA0")]
		public Transform bone1;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63EFD8", Offset = "0x63EFD8")]
		public Transform bone2;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F010", Offset = "0x63F010")]
		public Transform bone3;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F048", Offset = "0x63F048")]
		public Transform tip;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F080", Offset = "0x63F080")]
		public Transform target;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F0B8", Offset = "0x63F0B8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x1700000F")]
		public bool initiated
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xE99D38", Offset = "0xE99D38", VA = "0xE99D38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645868", Offset = "0x645868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xE99D40", Offset = "0xE99D40", VA = "0xE99D40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645878", Offset = "0x645878")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xE99D4C", Offset = "0xE99D4C", VA = "0xE99D4C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xE99D7C", Offset = "0xE99D7C", VA = "0xE99D7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xE99DC8", Offset = "0xE99DC8", VA = "0xE99DC8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xE99DF8", Offset = "0xE99DF8", VA = "0xE99DF8")]
			set
			{
			}
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE99E48", Offset = "0xE99E48", VA = "0xE99E48")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE99F48", Offset = "0xE99F48", VA = "0xE99F48")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE9A628", Offset = "0xE9A628", VA = "0xE9A628")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE9A758", Offset = "0xE9A758", VA = "0xE9A758")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE9A840", Offset = "0xE9A840", VA = "0xE9A840")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE9B19C", Offset = "0xE9B19C", VA = "0xE9B19C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F0C8", Offset = "0x63F0C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F0C8", Offset = "0x63F0C8")]
		public float weight;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F11C", Offset = "0x63F11C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000012")]
		public bool initiated
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xE9B1AC", Offset = "0xE9B1AC", VA = "0xE9B1AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645888", Offset = "0x645888")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xE9B1B4", Offset = "0xE9B1B4", VA = "0xE9B1B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645898", Offset = "0x645898")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE9B1C0", Offset = "0xE9B1C0", VA = "0xE9B1C0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE9B254", Offset = "0xE9B254", VA = "0xE9B254")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6458A8", Offset = "0x6458A8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE9B6A0", Offset = "0xE9B6A0", VA = "0xE9B6A0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xE9B8B4", Offset = "0xE9B8B4", VA = "0xE9B8B4")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE9B554", Offset = "0xE9B554", VA = "0xE9B554")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE9BAAC", Offset = "0xE9BAAC", VA = "0xE9BAAC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE9BBB4", Offset = "0xE9BBB4", VA = "0xE9BBB4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE9BC48", Offset = "0xE9BC48", VA = "0xE9BC48")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE9BCD4", Offset = "0xE9BCD4", VA = "0xE9BCD4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE9BD54", Offset = "0xE9BD54", VA = "0xE9BD54", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE9BD58", Offset = "0xE9BD58", VA = "0xE9BD58", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE9BD6C", Offset = "0xE9BD6C", VA = "0xE9BD6C")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000078")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F12C", Offset = "0x63F12C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F12C", Offset = "0x63F12C")]
		public float weight;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F180", Offset = "0x63F180")]
		public Grounding solver;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F1B8", Offset = "0x63F1B8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000013")]
		public bool initiated
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xE9D0E8", Offset = "0xE9D0E8", VA = "0xE9D0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6458E0", Offset = "0x6458E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xE9D0F0", Offset = "0xE9D0F0", VA = "0xE9D0F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6458F0", Offset = "0x6458F0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000102")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE9D0FC", Offset = "0xE9D0FC", VA = "0xE9D0FC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE9D470", Offset = "0xE9D470", VA = "0xE9D470")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE9D28C", Offset = "0xE9D28C", VA = "0xE9D28C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE9D4A4", Offset = "0xE9D4A4", VA = "0xE9D4A4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600010A")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE9D728", Offset = "0xE9D728", VA = "0xE9D728")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E33C", Offset = "0x63E33C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E33C", Offset = "0x63E33C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F1C8", Offset = "0x63F1C8")]
		public BipedIK ik;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F200", Offset = "0x63F200")]
		public float spineBend;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F238", Offset = "0x63F238")]
		public float spineSpeed;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE9DBE8", Offset = "0xE9DBE8", VA = "0xE9DBE8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645900", Offset = "0x645900")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xE9DC34", Offset = "0xE9DC34", VA = "0xE9DC34", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645938", Offset = "0x645938")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE9DC80", Offset = "0xE9DC80", VA = "0xE9DC80", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xE9DD0C", Offset = "0xE9DD0C", VA = "0xE9DD0C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xE9DE0C", Offset = "0xE9DE0C", VA = "0xE9DE0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE9DEC0", Offset = "0xE9DEC0", VA = "0xE9DEC0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xE9E354", Offset = "0xE9E354", VA = "0xE9E354")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xE9E3E0", Offset = "0xE9E3E0", VA = "0xE9E3E0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE9EB44", Offset = "0xE9EB44", VA = "0xE9EB44")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE9ECB4", Offset = "0xE9ECB4", VA = "0xE9ECB4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE9EF2C", Offset = "0xE9EF2C", VA = "0xE9EF2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE9F180", Offset = "0xE9F180", VA = "0xE9F180")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E39C", Offset = "0x63E39C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E39C", Offset = "0x63E39C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public class SpineEffector
		{
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642298", Offset = "0x642298")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6422D0", Offset = "0x6422D0")]
			public float horizontalWeight;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642308", Offset = "0x642308")]
			public float verticalWeight;

			[Token(Token = "0x6000489")]
			[Address(RVA = "0xEA03D8", Offset = "0xEA03D8", VA = "0xEA03D8")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xEA03E8", Offset = "0xEA03E8", VA = "0xEA03E8")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F270", Offset = "0x63F270")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F2A8", Offset = "0x63F2A8")]
		public float spineBend;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F2E0", Offset = "0x63F2E0")]
		public float spineSpeed;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE9F200", Offset = "0xE9F200", VA = "0xE9F200")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645970", Offset = "0x645970")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE9F24C", Offset = "0xE9F24C", VA = "0xE9F24C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6459A8", Offset = "0x6459A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE9F298", Offset = "0xE9F298", VA = "0xE9F298", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6459E0", Offset = "0x6459E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE9F2E4", Offset = "0xE9F2E4", VA = "0xE9F2E4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE9F370", Offset = "0xE9F370", VA = "0xE9F370")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE9F420", Offset = "0xE9F420", VA = "0xE9F420")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE9F814", Offset = "0xE9F814", VA = "0xE9F814")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE9F820", Offset = "0xE9F820", VA = "0xE9F820")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE9F4DC", Offset = "0xE9F4DC", VA = "0xE9F4DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE9F82C", Offset = "0xE9F82C", VA = "0xE9F82C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE9FE70", Offset = "0xE9FE70", VA = "0xE9FE70")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xEA00B8", Offset = "0xEA00B8", VA = "0xEA00B8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xEA01F0", Offset = "0xEA01F0", VA = "0xEA01F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xEA0358", Offset = "0xEA0358", VA = "0xEA0358")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E3FC", Offset = "0x63E3FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E3FC", Offset = "0x63E3FC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F318", Offset = "0x63F318")]
		public Transform pelvis;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F350", Offset = "0x63F350")]
		public Transform characterRoot;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F388", Offset = "0x63F388")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F388", Offset = "0x63F388")]
		public float rootRotationWeight;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F3DC", Offset = "0x63F3DC")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F414", Offset = "0x63F414")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xEA0430", Offset = "0xEA0430", VA = "0xEA0430", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645A18", Offset = "0x645A18")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xEA047C", Offset = "0xEA047C", VA = "0xEA047C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645A50", Offset = "0x645A50")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xEA04C8", Offset = "0xEA04C8", VA = "0xEA04C8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xEA04F8", Offset = "0xEA04F8", VA = "0xEA04F8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xEA06F8", Offset = "0xEA06F8", VA = "0xEA06F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xEA0844", Offset = "0xEA0844", VA = "0xEA0844")]
		private void Update()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xEA0E20", Offset = "0xEA0E20", VA = "0xEA0E20")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xEA1470", Offset = "0xEA1470", VA = "0xEA1470")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xEA176C", Offset = "0xEA176C", VA = "0xEA176C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xEA1CCC", Offset = "0xEA1CCC", VA = "0xEA1CCC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xEA1F50", Offset = "0xEA1F50", VA = "0xEA1F50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xEA21E8", Offset = "0xEA21E8", VA = "0xEA21E8")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E45C", Offset = "0x63E45C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E45C", Offset = "0x63E45C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200007A")]
		public struct Foot
		{
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x6FBCD8", Offset = "0x6FBCD8", VA = "0x6FBCD8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F44C", Offset = "0x63F44C")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F484", Offset = "0x63F484")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F484", Offset = "0x63F484")]
		public float rootRotationWeight;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F4D8", Offset = "0x63F4D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F4D8", Offset = "0x63F4D8")]
		public float minRootRotation;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F530", Offset = "0x63F530")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F530", Offset = "0x63F530")]
		public float maxRootRotation;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F588", Offset = "0x63F588")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F5C0", Offset = "0x63F5C0")]
		public float maxLegOffset;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F5F8", Offset = "0x63F5F8")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F630", Offset = "0x63F630")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F630", Offset = "0x63F630")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F684", Offset = "0x63F684")]
		public Transform characterRoot;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F6BC", Offset = "0x63F6BC")]
		public Transform pelvis;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F6F4", Offset = "0x63F6F4")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F72C", Offset = "0x63F72C")]
		public Transform head;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x63F764", Offset = "0x63F764")]
		public Vector3 gravity;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xEA2268", Offset = "0xEA2268", VA = "0xEA2268", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645A88", Offset = "0x645A88")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xEA22B4", Offset = "0xEA22B4", VA = "0xEA22B4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645AC0", Offset = "0x645AC0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xEA2300", Offset = "0xEA2300", VA = "0xEA2300", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xEA2350", Offset = "0xEA2350", VA = "0xEA2350")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xEA248C", Offset = "0xEA248C", VA = "0xEA248C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xEA2644", Offset = "0xEA2644", VA = "0xEA2644")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xEA2724", Offset = "0xEA2724", VA = "0xEA2724")]
		private void Update()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xEA27DC", Offset = "0xEA27DC", VA = "0xEA27DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xEA2C00", Offset = "0xEA2C00", VA = "0xEA2C00")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xEA30C4", Offset = "0xEA30C4", VA = "0xEA30C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xEA3210", Offset = "0xEA3210", VA = "0xEA3210")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xEA3770", Offset = "0xEA3770", VA = "0xEA3770")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xEA41E8", Offset = "0xEA41E8", VA = "0xEA41E8")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xEA455C", Offset = "0xEA455C", VA = "0xEA455C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xEA4700", Offset = "0xEA4700", VA = "0xEA4700")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xEA4AF8", Offset = "0xEA4AF8", VA = "0xEA4AF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xEA4B3C", Offset = "0xEA4B3C", VA = "0xEA4B3C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xEA4DCC", Offset = "0xEA4DCC", VA = "0xEA4DCC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E4BC", Offset = "0x63E4BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E4BC", Offset = "0x63E4BC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F774", Offset = "0x63F774")]
		public VRIK ik;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xF72DB8", Offset = "0xF72DB8", VA = "0xF72DB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645AF8", Offset = "0x645AF8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF72E04", Offset = "0xF72E04", VA = "0xF72E04", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645B30", Offset = "0x645B30")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF72E50", Offset = "0xF72E50", VA = "0xF72E50", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645B68", Offset = "0x645B68")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xF72E9C", Offset = "0xF72E9C", VA = "0xF72E9C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xF72F70", Offset = "0xF72F70", VA = "0xF72F70")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xF7301C", Offset = "0xF7301C", VA = "0xF7301C")]
		private void Update()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xF730D8", Offset = "0xF730D8", VA = "0xF730D8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xF73740", Offset = "0xF73740", VA = "0xF73740")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xF73DE0", Offset = "0xF73DE0", VA = "0xF73DE0")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xF73F1C", Offset = "0xF73F1C", VA = "0xF73F1C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xF7424C", Offset = "0xF7424C", VA = "0xF7424C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xF74384", Offset = "0xF74384", VA = "0xF74384")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xF745C0", Offset = "0xF745C0", VA = "0xF745C0")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200007B")]
		public enum Quality
		{
			[Token(Token = "0x4000373")]
			Fastest,
			[Token(Token = "0x4000374")]
			Simple,
			[Token(Token = "0x4000375")]
			Best
		}

		[Token(Token = "0x200007C")]
		public class Leg
		{
			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642340", Offset = "0x642340")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642350", Offset = "0x642350")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642360", Offset = "0x642360")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642370", Offset = "0x642370")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642380", Offset = "0x642380")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642390", Offset = "0x642390")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6423A0", Offset = "0x6423A0")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6423B0", Offset = "0x6423B0")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6423C0", Offset = "0x6423C0")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000062")]
			public bool isGrounded
			{
				[Token(Token = "0x600048C")]
				[Address(RVA = "0xF7588C", Offset = "0xF7588C", VA = "0xF7588C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647470", Offset = "0x647470")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600048D")]
				[Address(RVA = "0xF76430", Offset = "0xF76430", VA = "0xF76430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647480", Offset = "0x647480")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600048E")]
				[Address(RVA = "0xF73DD4", Offset = "0xF73DD4", VA = "0xF73DD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647490", Offset = "0x647490")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600048F")]
				[Address(RVA = "0xF7643C", Offset = "0xF7643C", VA = "0xF7643C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6474A0", Offset = "0x6474A0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public bool initiated
			{
				[Token(Token = "0x6000490")]
				[Address(RVA = "0xF76448", Offset = "0xF76448", VA = "0xF76448")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6474B0", Offset = "0x6474B0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000491")]
				[Address(RVA = "0xF76450", Offset = "0xF76450", VA = "0xF76450")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6474C0", Offset = "0x6474C0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public float heightFromGround
			{
				[Token(Token = "0x6000492")]
				[Address(RVA = "0xF7645C", Offset = "0xF7645C", VA = "0xF7645C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6474D0", Offset = "0x6474D0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000493")]
				[Address(RVA = "0xF76464", Offset = "0xF76464", VA = "0xF76464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6474E0", Offset = "0x6474E0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000066")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000494")]
				[Address(RVA = "0xF7646C", Offset = "0xF7646C", VA = "0xF7646C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6474F0", Offset = "0x6474F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000495")]
				[Address(RVA = "0xF76478", Offset = "0xF76478", VA = "0xF76478")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647500", Offset = "0x647500")]
				private set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public Transform transform
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0xF74B84", Offset = "0xF74B84", VA = "0xF74B84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647510", Offset = "0x647510")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000497")]
				[Address(RVA = "0xF76484", Offset = "0xF76484", VA = "0xF76484")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647520", Offset = "0x647520")]
				private set
				{
				}
			}

			[Token(Token = "0x17000068")]
			public float IKOffset
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0xF75884", Offset = "0xF75884", VA = "0xF75884")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647530", Offset = "0x647530")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000499")]
				[Address(RVA = "0xF7648C", Offset = "0xF7648C", VA = "0xF7648C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647540", Offset = "0x647540")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0xF76494", Offset = "0xF76494", VA = "0xF76494")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647550", Offset = "0x647550")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600049B")]
				[Address(RVA = "0xF764B0", Offset = "0xF764B0", VA = "0xF764B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647560", Offset = "0x647560")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0xF764D0", Offset = "0xF764D0", VA = "0xF764D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647570", Offset = "0x647570")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600049D")]
				[Address(RVA = "0xF764EC", Offset = "0xF764EC", VA = "0xF764EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647580", Offset = "0x647580")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x600049E")]
				[Address(RVA = "0xF7650C", Offset = "0xF7650C", VA = "0xF7650C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700006C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60004A4")]
				[Address(RVA = "0xF7745C", Offset = "0xF7745C", VA = "0xF7745C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700006D")]
			private float rootYOffset
			{
				[Token(Token = "0x60004AD")]
				[Address(RVA = "0xF777BC", Offset = "0xF777BC", VA = "0xF777BC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0xF76580", Offset = "0xF76580", VA = "0xF76580")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xF74D18", Offset = "0xF74D18", VA = "0xF74D18")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xF76594", Offset = "0xF76594", VA = "0xF76594")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xF75EB8", Offset = "0xF75EB8", VA = "0xF75EB8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xF74E28", Offset = "0xF74E28", VA = "0xF74E28")]
			public void Process()
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xF76E18", Offset = "0xF76E18", VA = "0xF76E18")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xF765E8", Offset = "0xF765E8", VA = "0xF765E8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xF77620", Offset = "0xF77620", VA = "0xF77620")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xF76AC0", Offset = "0xF76AC0", VA = "0xF76AC0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xF76BC8", Offset = "0xF76BC8", VA = "0xF76BC8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xF77730", Offset = "0xF77730", VA = "0xF77730")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xF7750C", Offset = "0xF7750C", VA = "0xF7750C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xF778FC", Offset = "0xF778FC", VA = "0xF778FC")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xF74C68", Offset = "0xF74C68", VA = "0xF74C68")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200007D")]
		public class Pelvis
		{
			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6423D0", Offset = "0x6423D0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6423E0", Offset = "0x6423E0")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700006E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0xF73DC0", Offset = "0xF73DC0", VA = "0xF73DC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647590", Offset = "0x647590")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004B0")]
				[Address(RVA = "0xF77A74", Offset = "0xF77A74", VA = "0xF77A74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6475A0", Offset = "0x6475A0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public float heightOffset
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0xF77A80", Offset = "0xF77A80", VA = "0xF77A80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6475B0", Offset = "0x6475B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004B2")]
				[Address(RVA = "0xF77A88", Offset = "0xF77A88", VA = "0xF77A88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6475C0", Offset = "0x6475C0")]
				private set
				{
				}
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xF74E00", Offset = "0xF74E00", VA = "0xF74E00")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xF75DEC", Offset = "0xF75DEC", VA = "0xF75DEC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xF77A90", Offset = "0xF77A90", VA = "0xF77A90")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xF75894", Offset = "0xF75894", VA = "0xF75894")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xF74D10", Offset = "0xF74D10", VA = "0xF74D10")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F7AC", Offset = "0x63F7AC")]
		public LayerMask layers;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F7E4", Offset = "0x63F7E4")]
		public float maxStep;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F81C", Offset = "0x63F81C")]
		public float heightOffset;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F854", Offset = "0x63F854")]
		public float footSpeed;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F88C", Offset = "0x63F88C")]
		public float footRadius;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F8C4", Offset = "0x63F8C4")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x63F8C4", Offset = "0x63F8C4")]
		public float footCenterOffset;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F910", Offset = "0x63F910")]
		public float prediction;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F948", Offset = "0x63F948")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F948", Offset = "0x63F948")]
		public float footRotationWeight;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F99C", Offset = "0x63F99C")]
		public float footRotationSpeed;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F9D4", Offset = "0x63F9D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F9D4", Offset = "0x63F9D4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FA2C", Offset = "0x63FA2C")]
		public bool rotateSolver;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FA64", Offset = "0x63FA64")]
		public float pelvisSpeed;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FA9C", Offset = "0x63FA9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FA9C", Offset = "0x63FA9C")]
		public float pelvisDamper;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FAF0", Offset = "0x63FAF0")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FB28", Offset = "0x63FB28")]
		public float liftPelvisWeight;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FB60", Offset = "0x63FB60")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FB98", Offset = "0x63FB98")]
		public bool overstepFallsDown;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FBD0", Offset = "0x63FBD0")]
		public Quality quality;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63FC08", Offset = "0x63FC08")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63FC18", Offset = "0x63FC18")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63FC28", Offset = "0x63FC28")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63FC38", Offset = "0x63FC38")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63FC48", Offset = "0x63FC48")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		public Leg[] legs
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xF73DCC", Offset = "0xF73DCC", VA = "0xF73DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645BA0", Offset = "0x645BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xF74620", Offset = "0xF74620", VA = "0xF74620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645BB0", Offset = "0x645BB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xF73DB8", Offset = "0xF73DB8", VA = "0xF73DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645BC0", Offset = "0x645BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xF74628", Offset = "0xF74628", VA = "0xF74628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645BD0", Offset = "0x645BD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool isGrounded
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xF74630", Offset = "0xF74630", VA = "0xF74630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645BE0", Offset = "0x645BE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xF74638", Offset = "0xF74638", VA = "0xF74638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645BF0", Offset = "0x645BF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Transform root
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xF74644", Offset = "0xF74644", VA = "0xF74644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645C00", Offset = "0x645C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xF7464C", Offset = "0xF7464C", VA = "0xF7464C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645C10", Offset = "0x645C10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xF74654", Offset = "0xF74654", VA = "0xF74654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645C20", Offset = "0x645C20")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xF74670", Offset = "0xF74670", VA = "0xF74670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645C30", Offset = "0x645C30")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool rootGrounded
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xF74690", Offset = "0xF74690", VA = "0xF74690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 up
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xF74AF0", Offset = "0xF74AF0", VA = "0xF74AF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001B")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xF75F80", Offset = "0xF75F80", VA = "0xF75F80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xF746E8", Offset = "0xF746E8", VA = "0xF746E8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xF74B8C", Offset = "0xF74B8C", VA = "0xF74B8C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xF7343C", Offset = "0xF7343C", VA = "0xF7343C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xF73B18", Offset = "0xF73B18", VA = "0xF73B18")]
		public void Update()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xF75B78", Offset = "0xF75B78", VA = "0xF75B78")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xF72EC8", Offset = "0xF72EC8", VA = "0xF72EC8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xF74E10", Offset = "0xF74E10", VA = "0xF74E10")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xF76058", Offset = "0xF76058", VA = "0xF76058")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xF761C8", Offset = "0xF761C8", VA = "0xF761C8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xF762D4", Offset = "0xF762D4", VA = "0xF762D4")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xF763D8", Offset = "0xF763D8", VA = "0xF763D8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E51C", Offset = "0x63E51C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E51C", Offset = "0x63E51C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE8BD00", Offset = "0xE8BD00", VA = "0xE8BD00", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645C40", Offset = "0x645C40")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE8BD4C", Offset = "0xE8BD4C", VA = "0xE8BD4C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645C78", Offset = "0x645C78")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE8BD98", Offset = "0xE8BD98", VA = "0xE8BD98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645CB0", Offset = "0x645CB0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE8BDE4", Offset = "0xE8BDE4", VA = "0xE8BDE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645CE8", Offset = "0x645CE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE8BE30", Offset = "0xE8BE30", VA = "0xE8BE30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645D20", Offset = "0x645D20")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE8BE7C", Offset = "0xE8BE7C", VA = "0xE8BE7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE8BE84", Offset = "0xE8BE84", VA = "0xE8BE84")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E57C", Offset = "0x63E57C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E57C", Offset = "0x63E57C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE8CB54", Offset = "0xE8CB54", VA = "0xE8CB54", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645D58", Offset = "0x645D58")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE8CBA0", Offset = "0xE8CBA0", VA = "0xE8CBA0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645D90", Offset = "0x645D90")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE8CBEC", Offset = "0xE8CBEC", VA = "0xE8CBEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645DC8", Offset = "0x645DC8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE8CC38", Offset = "0xE8CC38", VA = "0xE8CC38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645E00", Offset = "0x645E00")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE8CC84", Offset = "0xE8CC84", VA = "0xE8CC84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE8CC8C", Offset = "0xE8CC8C", VA = "0xE8CC8C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E5DC", Offset = "0x63E5DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E5DC", Offset = "0x63E5DC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE8EB58", Offset = "0xE8EB58", VA = "0xE8EB58", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645E38", Offset = "0x645E38")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE8EBA4", Offset = "0xE8EBA4", VA = "0xE8EBA4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645E70", Offset = "0x645E70")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE8EBF0", Offset = "0xE8EBF0", VA = "0xE8EBF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645EA8", Offset = "0x645EA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE8EC3C", Offset = "0xE8EC3C", VA = "0xE8EC3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645EE0", Offset = "0x645EE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE8EC88", Offset = "0xE8EC88", VA = "0xE8EC88", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE8EC90", Offset = "0xE8EC90", VA = "0xE8EC90")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E63C", Offset = "0x63E63C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E63C", Offset = "0x63E63C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE8F908", Offset = "0xE8F908", VA = "0xE8F908", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645F18", Offset = "0x645F18")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE8F954", Offset = "0xE8F954", VA = "0xE8F954", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645F50", Offset = "0x645F50")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xE8F9A0", Offset = "0xE8F9A0", VA = "0xE8F9A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645F88", Offset = "0x645F88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE8F9EC", Offset = "0xE8F9EC", VA = "0xE8F9EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645FC0", Offset = "0x645FC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE8FA38", Offset = "0xE8FA38", VA = "0xE8FA38", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xE8FA40", Offset = "0xE8FA40", VA = "0xE8FA40")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E69C", Offset = "0x63E69C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E69C", Offset = "0x63E69C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE903A4", Offset = "0xE903A4", VA = "0xE903A4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x645FF8", Offset = "0x645FF8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE903F0", Offset = "0xE903F0", VA = "0xE903F0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646030", Offset = "0x646030")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE9043C", Offset = "0xE9043C", VA = "0xE9043C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646068", Offset = "0x646068")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE90488", Offset = "0xE90488", VA = "0xE90488")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6460A0", Offset = "0x6460A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE904D4", Offset = "0xE904D4", VA = "0xE904D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE904DC", Offset = "0xE904DC", VA = "0xE904DC")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E6FC", Offset = "0x63E6FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E6FC", Offset = "0x63E6FC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE9BDD4", Offset = "0xE9BDD4", VA = "0xE9BDD4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6460D8", Offset = "0x6460D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE9BE20", Offset = "0xE9BE20", VA = "0xE9BE20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646110", Offset = "0x646110")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE9BE6C", Offset = "0xE9BE6C", VA = "0xE9BE6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646148", Offset = "0x646148")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE9BEB8", Offset = "0xE9BEB8", VA = "0xE9BEB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646180", Offset = "0x646180")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE9BF04", Offset = "0xE9BF04", VA = "0xE9BF04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6461B8", Offset = "0x6461B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE9BF50", Offset = "0xE9BF50", VA = "0xE9BF50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6461F0", Offset = "0x6461F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE9BF9C", Offset = "0xE9BF9C", VA = "0xE9BF9C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE9BFE8", Offset = "0xE9BFE8", VA = "0xE9BFE8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE9BFF0", Offset = "0xE9BFF0", VA = "0xE9BFF0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE9C210", Offset = "0xE9C210", VA = "0xE9C210")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE9C5FC", Offset = "0xE9C5FC", VA = "0xE9C5FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646228", Offset = "0x646228")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE9C63C", Offset = "0xE9C63C", VA = "0xE9C63C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646260", Offset = "0x646260")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE9C720", Offset = "0xE9C720", VA = "0xE9C720")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000195")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xF7B0B4", Offset = "0xF7B0B4", VA = "0xF7B0B4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xF7B1B8", Offset = "0xF7B1B8", VA = "0xF7B1B8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xF7B384", Offset = "0xF7B384", VA = "0xF7B384", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000199")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600019A")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xF7B3F4", Offset = "0xF7B3F4", VA = "0xF7B3F4")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FC58", Offset = "0x63FC58")]
		public IK[] IKComponents;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FC90", Offset = "0x63FC90")]
		public Animator animator;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700001C")]
		private bool animatePhysics
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xF7EC88", Offset = "0xF7EC88", VA = "0xF7EC88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xF7ED2C", Offset = "0xF7ED2C", VA = "0xF7ED2C")]
		private void Start()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xF7EDCC", Offset = "0xF7EDCC", VA = "0xF7EDCC")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xF7EF04", Offset = "0xF7EF04", VA = "0xF7EF04")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xF7EF40", Offset = "0xF7EF40", VA = "0xF7EF40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xF7EE00", Offset = "0xF7EE00", VA = "0xF7EE00")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xF7F008", Offset = "0xF7F008", VA = "0xF7F008")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E75C", Offset = "0x63E75C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E75C", Offset = "0x63E75C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xD6E5AC", Offset = "0xD6E5AC", VA = "0xD6E5AC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646298", Offset = "0x646298")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD6E5F8", Offset = "0xD6E5F8", VA = "0xD6E5F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6462D0", Offset = "0x6462D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xD6E644", Offset = "0xD6E644", VA = "0xD6E644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646308", Offset = "0x646308")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD6E690", Offset = "0xD6E690", VA = "0xD6E690")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646340", Offset = "0x646340")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD6E6DC", Offset = "0xD6E6DC", VA = "0xD6E6DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD6E6E4", Offset = "0xD6E6E4", VA = "0xD6E6E4")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E7BC", Offset = "0x63E7BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E7BC", Offset = "0x63E7BC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xD6E74C", Offset = "0xD6E74C", VA = "0xD6E74C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646378", Offset = "0x646378")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xD6E798", Offset = "0xD6E798", VA = "0xD6E798", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6463B0", Offset = "0x6463B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xD6E7E4", Offset = "0xD6E7E4", VA = "0xD6E7E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6463E8", Offset = "0x6463E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD6E830", Offset = "0xD6E830", VA = "0xD6E830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646420", Offset = "0x646420")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD6E87C", Offset = "0xD6E87C", VA = "0xD6E87C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD6E884", Offset = "0xD6E884", VA = "0xD6E884")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E81C", Offset = "0x63E81C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E81C", Offset = "0x63E81C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xD6F9CC", Offset = "0xD6F9CC", VA = "0xD6F9CC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646458", Offset = "0x646458")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD6FA18", Offset = "0xD6FA18", VA = "0xD6FA18", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646490", Offset = "0x646490")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD6FA64", Offset = "0xD6FA64", VA = "0xD6FA64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6464C8", Offset = "0x6464C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD6FAB0", Offset = "0xD6FAB0", VA = "0xD6FAB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646500", Offset = "0x646500")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD6FAFC", Offset = "0xD6FAFC", VA = "0xD6FAFC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xD6FB04", Offset = "0xD6FB04", VA = "0xD6FB04")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E87C", Offset = "0x63E87C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E87C", Offset = "0x63E87C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xD799B4", Offset = "0xD799B4", VA = "0xD799B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646538", Offset = "0x646538")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xD79A00", Offset = "0xD79A00", VA = "0xD79A00", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646570", Offset = "0x646570")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xD79A4C", Offset = "0xD79A4C", VA = "0xD79A4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6465A8", Offset = "0x6465A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xD79A98", Offset = "0xD79A98", VA = "0xD79A98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6465E0", Offset = "0x6465E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD79AE4", Offset = "0xD79AE4", VA = "0xD79AE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD79AEC", Offset = "0xD79AEC", VA = "0xD79AEC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E8DC", Offset = "0x63E8DC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200007E")]
		public class References
		{
			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6423F0", Offset = "0x6423F0")]
			public Transform chest;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642428", Offset = "0x642428")]
			public Transform neck;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642460", Offset = "0x642460")]
			public Transform leftShoulder;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642498", Offset = "0x642498")]
			public Transform rightShoulder;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6424D0", Offset = "0x6424D0")]
			public Transform leftThigh;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642508", Offset = "0x642508")]
			public Transform leftCalf;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642540", Offset = "0x642540")]
			public Transform leftFoot;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642578", Offset = "0x642578")]
			public Transform leftToes;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6425B0", Offset = "0x6425B0")]
			public Transform rightThigh;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6425E8", Offset = "0x6425E8")]
			public Transform rightCalf;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642620", Offset = "0x642620")]
			public Transform rightFoot;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642658", Offset = "0x642658")]
			public Transform rightToes;

			[Token(Token = "0x17000070")]
			public bool isFilled
			{
				[Token(Token = "0x60004B9")]
				[Address(RVA = "0xD7B3FC", Offset = "0xD7B3FC", VA = "0xD7B3FC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000071")]
			public bool isEmpty
			{
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0xD7AF80", Offset = "0xD7AF80", VA = "0xD7AF80")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xD7BAA0", Offset = "0xD7BAA0", VA = "0xD7BAA0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xD7A928", Offset = "0xD7A928", VA = "0xD7A928")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xD7BA98", Offset = "0xD7BA98", VA = "0xD7BA98")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x63FCC8", Offset = "0x63FCC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FCC8", Offset = "0x63FCC8")]
		public References references;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FD44", Offset = "0x63FD44")]
		public IKSolverVR solver;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD7A81C", Offset = "0xD7A81C", VA = "0xD7A81C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646618", Offset = "0x646618")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xD7A868", Offset = "0xD7A868", VA = "0xD7A868", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646650", Offset = "0x646650")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xD7A8B4", Offset = "0xD7A8B4", VA = "0xD7A8B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646688", Offset = "0x646688")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xD7A900", Offset = "0xD7A900", VA = "0xD7A900")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6466C0", Offset = "0x6466C0")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD7AEA4", Offset = "0xD7AEA4", VA = "0xD7AEA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6466F8", Offset = "0x6466F8")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD7AEDC", Offset = "0xD7AEDC", VA = "0xD7AEDC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD7AEE4", Offset = "0xD7AEE4", VA = "0xD7AEE4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD7B880", Offset = "0xD7B880", VA = "0xD7B880", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xD7BA10", Offset = "0xD7BA10", VA = "0xD7BA10")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FD7C", Offset = "0x63FD7C")]
		public float pull;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FD94", Offset = "0x63FD94")]
		public float pin;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE8FAA8", Offset = "0xE8FAA8", VA = "0xE8FAA8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE8FB80", Offset = "0xE8FB80", VA = "0xE8FB80")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE8FBB4", Offset = "0xE8FBB4", VA = "0xE8FBB4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE90134", Offset = "0xE90134", VA = "0xE90134")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE8FD3C", Offset = "0xE8FD3C", VA = "0xE8FD3C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE9033C", Offset = "0xE9033C", VA = "0xE9033C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE90544", Offset = "0xE90544", VA = "0xE90544")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE90CB4", Offset = "0xE90CB4", VA = "0xE90CB4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE90F88", Offset = "0xE90F88", VA = "0xE90F88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE910E8", Offset = "0xE910E8", VA = "0xE910E8")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		public class BendBone
		{
			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642690", Offset = "0x642690")]
			public Transform transform;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6426C8", Offset = "0x6426C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6426C8", Offset = "0x6426C8")]
			public float weight;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xE954CC", Offset = "0xE954CC", VA = "0xE954CC")]
			public BendBone()
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xE9554C", Offset = "0xE9554C", VA = "0xE9554C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xE91D70", Offset = "0xE91D70", VA = "0xE91D70")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xE923BC", Offset = "0xE923BC", VA = "0xE923BC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FDAC", Offset = "0x63FDAC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x63FDE4", Offset = "0x63FDE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FDE4", Offset = "0x63FDE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FDE4", Offset = "0x63FDE4")]
		public float positionWeight;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FE5C", Offset = "0x63FE5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FE5C", Offset = "0x63FE5C")]
		public float bodyWeight;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FEB0", Offset = "0x63FEB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FEB0", Offset = "0x63FEB0")]
		public float thighWeight;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FF04", Offset = "0x63FF04")]
		public bool handsPullBody;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x63FF3C", Offset = "0x63FF3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FF3C", Offset = "0x63FF3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FF3C", Offset = "0x63FF3C")]
		public float rotationWeight;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FFB4", Offset = "0x63FFB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FFB4", Offset = "0x63FFB4")]
		public float bodyClampWeight;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640008", Offset = "0x640008")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640008", Offset = "0x640008")]
		public float headClampWeight;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64005C", Offset = "0x64005C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64005C", Offset = "0x64005C")]
		public float bendWeight;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6400B0", Offset = "0x6400B0")]
		public BendBone[] bendBones;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6400E8", Offset = "0x6400E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6400E8", Offset = "0x6400E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6400E8", Offset = "0x6400E8")]
		public float CCDWeight;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640160", Offset = "0x640160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640160", Offset = "0x640160")]
		public float roll;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6401B4", Offset = "0x6401B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6401B4", Offset = "0x6401B4")]
		public float damper;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64020C", Offset = "0x64020C")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x640244", Offset = "0x640244")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640244", Offset = "0x640244")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640244", Offset = "0x640244")]
		public float postStretchWeight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6402BC", Offset = "0x6402BC")]
		public float maxStretch;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6402F4", Offset = "0x6402F4")]
		public float stretchDamper;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64032C", Offset = "0x64032C")]
		public bool fixHead;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640364", Offset = "0x640364")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64039C", Offset = "0x64039C")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6403D4", Offset = "0x6403D4")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE910F0", Offset = "0xE910F0", VA = "0xE910F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE91678", Offset = "0xE91678", VA = "0xE91678")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE91DB0", Offset = "0xE91DB0", VA = "0xE91DB0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE92414", Offset = "0xE92414", VA = "0xE92414")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE930C8", Offset = "0xE930C8", VA = "0xE930C8")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE93538", Offset = "0xE93538", VA = "0xE93538")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE93A18", Offset = "0xE93A18", VA = "0xE93A18")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE94760", Offset = "0xE94760", VA = "0xE94760")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE92D3C", Offset = "0xE92D3C", VA = "0xE92D3C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE94A48", Offset = "0xE94A48", VA = "0xE94A48")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE945E0", Offset = "0xE945E0", VA = "0xE945E0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE94444", Offset = "0xE94444", VA = "0xE94444")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE94EAC", Offset = "0xE94EAC", VA = "0xE94EAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE9534C", Offset = "0xE9534C", VA = "0xE9534C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		public class ChildConstraint
		{
			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64273C", Offset = "0x64273C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64274C", Offset = "0x64274C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000072")]
			public float nominalDistance
			{
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0xE99CC8", Offset = "0xE99CC8", VA = "0xE99CC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6475D0", Offset = "0x6475D0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0xE99CD0", Offset = "0xE99CD0", VA = "0xE99CD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6475E0", Offset = "0x6475E0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000073")]
			public bool isRigid
			{
				[Token(Token = "0x60004C3")]
				[Address(RVA = "0xE99CD8", Offset = "0xE99CD8", VA = "0xE99CD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6475F0", Offset = "0x6475F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004C4")]
				[Address(RVA = "0xE99CE0", Offset = "0xE99CE0", VA = "0xE99CE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647600", Offset = "0x647600")]
				private set
				{
				}
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xE99CEC", Offset = "0xE99CEC", VA = "0xE99CEC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xE96754", Offset = "0xE96754", VA = "0xE96754")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xE970D8", Offset = "0xE970D8", VA = "0xE970D8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xE9987C", Offset = "0xE9987C", VA = "0xE9987C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000081")]
		public enum Smoothing
		{
			[Token(Token = "0x40003B6")]
			None,
			[Token(Token = "0x40003B7")]
			Exponential,
			[Token(Token = "0x40003B8")]
			Cubic
		}

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6403EC", Offset = "0x6403EC")]
		public float pin;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640404", Offset = "0x640404")]
		public float pull;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64041C", Offset = "0x64041C")]
		public float push;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640434", Offset = "0x640434")]
		public float pushParent;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64044C", Offset = "0x64044C")]
		public float reach;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000156")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE955F0", Offset = "0xE955F0", VA = "0xE955F0")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xE956BC", Offset = "0xE956BC", VA = "0xE956BC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xE957C8", Offset = "0xE957C8", VA = "0xE957C8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE95918", Offset = "0xE95918", VA = "0xE95918")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE95A18", Offset = "0xE95A18", VA = "0xE95A18")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE95B38", Offset = "0xE95B38", VA = "0xE95B38")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE967CC", Offset = "0xE967CC", VA = "0xE967CC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE95DCC", Offset = "0xE95DCC", VA = "0xE95DCC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE973B8", Offset = "0xE973B8", VA = "0xE973B8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE97890", Offset = "0xE97890", VA = "0xE97890")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE97DC0", Offset = "0xE97DC0", VA = "0xE97DC0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE984D4", Offset = "0xE984D4", VA = "0xE984D4")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE98FC4", Offset = "0xE98FC4", VA = "0xE98FC4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE99474", Offset = "0xE99474", VA = "0xE99474")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE98EBC", Offset = "0xE98EBC", VA = "0xE98EBC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE982BC", Offset = "0xE982BC", VA = "0xE982BC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE98E14", Offset = "0xE98E14", VA = "0xE98E14")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE99698", Offset = "0xE99698", VA = "0xE99698")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE98BCC", Offset = "0xE98BCC", VA = "0xE98BCC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE991E8", Offset = "0xE991E8", VA = "0xE991E8")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640464", Offset = "0x640464")]
		public float weight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64047C", Offset = "0x64047C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700001D")]
		public bool initiated
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xF7B5DC", Offset = "0xF7B5DC", VA = "0xF7B5DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646730", Offset = "0x646730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xF7B5E4", Offset = "0xF7B5E4", VA = "0xF7B5E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646740", Offset = "0x646740")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xF7B3FC", Offset = "0xF7B3FC", VA = "0xF7B3FC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xF7B5F0", Offset = "0xF7B5F0", VA = "0xF7B5F0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xF7B674", Offset = "0xF7B674", VA = "0xF7B674")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF7B720", Offset = "0xF7B720", VA = "0xF7B720")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xF7B72C", Offset = "0xF7B72C", VA = "0xF7B72C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF7BD94", Offset = "0xF7BD94", VA = "0xF7BD94")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF7BFCC", Offset = "0xF7BFCC", VA = "0xF7BFCC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xF7C544", Offset = "0xF7C544", VA = "0xF7C544")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xF7BB04", Offset = "0xF7BB04", VA = "0xF7BB04")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xF7BC4C", Offset = "0xF7BC4C", VA = "0xF7BC4C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class IKEffector
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64048C", Offset = "0x64048C")]
		public float positionWeight;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6404A4", Offset = "0x6404A4")]
		public float rotationWeight;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6404BC", Offset = "0x6404BC")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6404CC", Offset = "0x6404CC")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700001E")]
		public bool isEndEffector
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xF7CCF8", Offset = "0xF7CCF8", VA = "0xF7CCF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646750", Offset = "0x646750")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xF7CD00", Offset = "0xF7CD00", VA = "0xF7CD00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646760", Offset = "0x646760")]
			private set
			{
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF7CC48", Offset = "0xF7CC48", VA = "0xF7CC48")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xF7CD0C", Offset = "0xF7CD0C", VA = "0xF7CD0C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF7CDF4", Offset = "0xF7CDF4", VA = "0xF7CDF4")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF7CF30", Offset = "0xF7CF30", VA = "0xF7CF30")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF7D088", Offset = "0xF7D088", VA = "0xF7D088")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xF7D3E0", Offset = "0xF7D3E0", VA = "0xF7D3E0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xF7D77C", Offset = "0xF7D77C", VA = "0xF7D77C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xF7D950", Offset = "0xF7D950", VA = "0xF7D950")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xF7DA10", Offset = "0xF7DA10", VA = "0xF7DA10")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xF7E200", Offset = "0xF7E200", VA = "0xF7E200")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xF7E270", Offset = "0xF7E270", VA = "0xF7E270")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xF7E4D0", Offset = "0xF7E4D0", VA = "0xF7E4D0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF7E92C", Offset = "0xF7E92C", VA = "0xF7E92C")]
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
		[Token(Token = "0x2000082")]
		public class BoneMap
		{
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000074")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0xF7F2B4", Offset = "0xF7F2B4", VA = "0xF7F2B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000075")]
			public bool isNodeBone
			{
				[Token(Token = "0x60004CD")]
				[Address(RVA = "0xF7F47C", Offset = "0xF7F47C", VA = "0xF7F47C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000076")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60004E1")]
				[Address(RVA = "0xF7FB20", Offset = "0xF7FB20", VA = "0xF7FB20")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xF7F264", Offset = "0xF7F264", VA = "0xF7F264")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xF7F388", Offset = "0xF7F388", VA = "0xF7F388")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xF7F3EC", Offset = "0xF7F3EC", VA = "0xF7F3EC")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xF7F48C", Offset = "0xF7F48C", VA = "0xF7F48C")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xF7F590", Offset = "0xF7F590", VA = "0xF7F590")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xF7F598", Offset = "0xF7F598", VA = "0xF7F598")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xF7F750", Offset = "0xF7F750", VA = "0xF7F750")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xF7F864", Offset = "0xF7F864", VA = "0xF7F864")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xF7F950", Offset = "0xF7F950", VA = "0xF7F950")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xF7FD94", Offset = "0xF7FD94", VA = "0xF7FD94")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xF7FDD4", Offset = "0xF7FDD4", VA = "0xF7FDD4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xF7FE14", Offset = "0xF7FE14", VA = "0xF7FE14")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xF7FE68", Offset = "0xF7FE68", VA = "0xF7FE68")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xF7FFD8", Offset = "0xF7FFD8", VA = "0xF7FFD8")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xF80388", Offset = "0xF80388", VA = "0xF80388")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xF803E4", Offset = "0xF803E4", VA = "0xF803E4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xF805B4", Offset = "0xF805B4", VA = "0xF805B4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xF8062C", Offset = "0xF8062C", VA = "0xF8062C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xF808C8", Offset = "0xF808C8", VA = "0xF808C8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xF80B48", Offset = "0xF80B48", VA = "0xF80B48")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xF80C90", Offset = "0xF80C90", VA = "0xF80C90")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xF80138", Offset = "0xF80138", VA = "0xF80138")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xF80EA4", Offset = "0xF80EA4", VA = "0xF80EA4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xF7F010", Offset = "0xF7F010", VA = "0xF7F010", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xF7F018", Offset = "0xF7F018", VA = "0xF7F018", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xF7F01C", Offset = "0xF7F01C", VA = "0xF7F01C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xF7F154", Offset = "0xF7F154", VA = "0xF7F154")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xF7F25C", Offset = "0xF7F25C", VA = "0xF7F25C")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6404E4", Offset = "0x6404E4")]
		public float maintainRotationWeight;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xF80EBC", Offset = "0xF80EBC", VA = "0xF80EBC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xF80F5C", Offset = "0xF80F5C", VA = "0xF80F5C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xF80FE0", Offset = "0xF80FE0", VA = "0xF80FE0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xF81078", Offset = "0xF81078", VA = "0xF81078")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xF810A4", Offset = "0xF810A4", VA = "0xF810A4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xF810D4", Offset = "0xF810D4", VA = "0xF810D4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xF81180", Offset = "0xF81180", VA = "0xF81180")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xF811AC", Offset = "0xF811AC", VA = "0xF811AC")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public enum BoneMapType
		{
			[Token(Token = "0x40003D0")]
			Parent,
			[Token(Token = "0x40003D1")]
			Bone1,
			[Token(Token = "0x40003D2")]
			Bone2,
			[Token(Token = "0x40003D3")]
			Bone3
		}

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6404FC", Offset = "0x6404FC")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640514", Offset = "0x640514")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xF811EC", Offset = "0xF811EC", VA = "0xF811EC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xF81270", Offset = "0xF81270", VA = "0xF81270")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xF81344", Offset = "0xF81344", VA = "0xF81344")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xF81714", Offset = "0xF81714", VA = "0xF81714")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xF8181C", Offset = "0xF8181C", VA = "0xF8181C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xF81950", Offset = "0xF81950", VA = "0xF81950")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xF8195C", Offset = "0xF8195C", VA = "0xF8195C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xF81A30", Offset = "0xF81A30", VA = "0xF81A30")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xF81B14", Offset = "0xF81B14", VA = "0xF81B14", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xF81E30", Offset = "0xF81E30", VA = "0xF81E30")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xF81F20", Offset = "0xF81F20", VA = "0xF81F20")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64052C", Offset = "0x64052C")]
		public int iterations;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640544", Offset = "0x640544")]
		public float twistWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xF8214C", Offset = "0xF8214C", VA = "0xF8214C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xF82470", Offset = "0xF82470", VA = "0xF82470")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xF8258C", Offset = "0xF8258C", VA = "0xF8258C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xF826DC", Offset = "0xF826DC", VA = "0xF826DC")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xF826EC", Offset = "0xF826EC", VA = "0xF826EC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xF82784", Offset = "0xF82784", VA = "0xF82784")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xF82854", Offset = "0xF82854", VA = "0xF82854", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xF83278", Offset = "0xF83278", VA = "0xF83278")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xF832C4", Offset = "0xF832C4", VA = "0xF832C4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xF837A8", Offset = "0xF837A8", VA = "0xF837A8")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xF83DE4", Offset = "0xF83DE4", VA = "0xF83DE4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xF84040", Offset = "0xF84040", VA = "0xF84040")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xF84254", Offset = "0xF84254", VA = "0xF84254")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class Point
		{
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64275C", Offset = "0x64275C")]
			public float weight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xF868F8", Offset = "0xF868F8", VA = "0xF868F8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xF8695C", Offset = "0xF8695C", VA = "0xF8695C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xF86B2C", Offset = "0xF86B2C", VA = "0xF86B2C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xF86B6C", Offset = "0xF86B6C", VA = "0xF86B6C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xF86BAC", Offset = "0xF86BAC", VA = "0xF86BAC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0xF86C10", Offset = "0xF86C10", VA = "0xF86C10")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xF861EC", Offset = "0xF861EC", VA = "0xF861EC")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class Bone : Point
		{
			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000077")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60004EA")]
				[Address(RVA = "0xF855E0", Offset = "0xF855E0", VA = "0xF855E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60004EB")]
				[Address(RVA = "0xF856DC", Offset = "0xF856DC", VA = "0xF856DC")]
				set
				{
				}
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xF85764", Offset = "0xF85764", VA = "0xF85764")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xF85A6C", Offset = "0xF85A6C", VA = "0xF85A6C")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xF85E64", Offset = "0xF85E64", VA = "0xF85E64")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xF86114", Offset = "0xF86114", VA = "0xF86114")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xF86168", Offset = "0xF86168", VA = "0xF86168")]
			public Bone()
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xF8626C", Offset = "0xF8626C", VA = "0xF8626C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xF86304", Offset = "0xF86304", VA = "0xF86304")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Node : Point
		{
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xF86894", Offset = "0xF86894", VA = "0xF86894")]
			public Node()
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xF86898", Offset = "0xF86898", VA = "0xF86898")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xF868C0", Offset = "0xF868C0", VA = "0xF868C0")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000087")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000088")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64055C", Offset = "0x64055C")]
		public Vector3 IKPosition;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64056C", Offset = "0x64056C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64056C", Offset = "0x64056C")]
		public float IKPositionWeight;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6405C0", Offset = "0x6405C0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x6405D0", Offset = "0x6405D0")]
		protected Transform root;

		[Token(Token = "0x1700001F")]
		public bool initiated
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xF73014", Offset = "0xF73014", VA = "0xF73014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646770", Offset = "0x646770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xF84BDC", Offset = "0xF84BDC", VA = "0xF84BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646780", Offset = "0x646780")]
			private set
			{
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xF84760", Offset = "0xF84760", VA = "0xF84760")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xF7B238", Offset = "0xF7B238", VA = "0xF7B238")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xF7B150", Offset = "0xF7B150", VA = "0xF7B150")]
		public void Update()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xF84BE8", Offset = "0xF84BE8", VA = "0xF84BE8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xF84BF4", Offset = "0xF84BF4", VA = "0xF84BF4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xF84C00", Offset = "0xF84C00", VA = "0xF84C00")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xF84C08", Offset = "0xF84C08", VA = "0xF84C08")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xF797AC", Offset = "0xF797AC", VA = "0xF797AC")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600023C")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600023D")]
		public abstract void FixTransforms();

		[Token(Token = "0x600023E")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600023F")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000240")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xF84C8C", Offset = "0xF84C8C", VA = "0xF84C8C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xF84CA4", Offset = "0xF84CA4", VA = "0xF84CA4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xF84E20", Offset = "0xF84E20", VA = "0xF84E20")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xF84EF4", Offset = "0xF84EF4", VA = "0xF84EF4")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xF855C8", Offset = "0xF855C8", VA = "0xF855C8")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640608", Offset = "0x640608")]
		public float poleWeight;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640620", Offset = "0x640620")]
		public float clampWeight;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640638", Offset = "0x640638")]
		public int clampSmoothing;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000020")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xF86DBC", Offset = "0xF86DBC", VA = "0xF86DBC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xF86E90", Offset = "0xF86E90", VA = "0xF86E90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000022")]
		protected override int minBones
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0xF87E7C", Offset = "0xF87E7C", VA = "0xF87E7C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0xF8850C", Offset = "0xF8850C", VA = "0xF8850C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xF86CB4", Offset = "0xF86CB4", VA = "0xF86CB4")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xF86F64", Offset = "0xF86F64", VA = "0xF86F64", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xF8726C", Offset = "0xF8726C", VA = "0xF8726C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xF87CA0", Offset = "0xF87CA0", VA = "0xF87CA0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF87878", Offset = "0xF87878", VA = "0xF87878")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xF87E84", Offset = "0xF87E84", VA = "0xF87E84")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xF88614", Offset = "0xF88614", VA = "0xF88614")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640650", Offset = "0x640650")]
		public float IKRotationWeight;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xF886AC", Offset = "0xF886AC", VA = "0xF886AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xF88B44", Offset = "0xF88B44", VA = "0xF88B44")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xF88C04", Offset = "0xF88C04", VA = "0xF88C04", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xF88DF0", Offset = "0xF88DF0", VA = "0xF88DF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xF88FAC", Offset = "0xF88FAC", VA = "0xF88FAC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xF89024", Offset = "0xF89024", VA = "0xF89024", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xF890B0", Offset = "0xF890B0", VA = "0xF890B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xF89738", Offset = "0xF89738", VA = "0xF89738", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xF89764", Offset = "0xF89764", VA = "0xF89764")]
		private void Solve()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xF89138", Offset = "0xF89138", VA = "0xF89138")]
		private void Read()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xF8980C", Offset = "0xF8980C", VA = "0xF8980C")]
		private void Write()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xF89B0C", Offset = "0xF89B0C", VA = "0xF89B0C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xF89C5C", Offset = "0xF89C5C", VA = "0xF89C5C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xF89DB4", Offset = "0xF89DB4", VA = "0xF89DB4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xF89E68", Offset = "0xF89E68", VA = "0xF89E68", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xF8A1C0", Offset = "0xF8A1C0", VA = "0xF8A1C0")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xF8AC8C", Offset = "0xF8AC8C", VA = "0xF8AC8C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000024")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xF8C694", Offset = "0xF8C694", VA = "0xF8C694", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xF8AC94", Offset = "0xF8AC94", VA = "0xF8AC94")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xF8B8AC", Offset = "0xF8B8AC", VA = "0xF8B8AC")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xF8B9E4", Offset = "0xF8B9E4", VA = "0xF8B9E4", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xF8BA88", Offset = "0xF8BA88", VA = "0xF8BA88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xF8C2E4", Offset = "0xF8C2E4", VA = "0xF8C2E4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xF8C69C", Offset = "0xF8C69C", VA = "0xF8C69C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xF8AD68", Offset = "0xF8AD68", VA = "0xF8AD68")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xF8B990", Offset = "0xF8B990", VA = "0xF8B990")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xF8C61C", Offset = "0xF8C61C", VA = "0xF8C61C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xF8B500", Offset = "0xF8B500", VA = "0xF8B500")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xF8D350", Offset = "0xF8D350", VA = "0xF8D350")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xF8D478", Offset = "0xF8D478", VA = "0xF8D478")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xF8D610", Offset = "0xF8D610", VA = "0xF8D610")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xF8D7A8", Offset = "0xF8D7A8", VA = "0xF8D7A8")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xF8BF4C", Offset = "0xF8BF4C", VA = "0xF8BF4C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xF8C118", Offset = "0xF8C118", VA = "0xF8C118")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xF8DA48", Offset = "0xF8DA48", VA = "0xF8DA48")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xF8CB70", Offset = "0xF8CB70", VA = "0xF8CB70")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xF8B980", Offset = "0xF8B980", VA = "0xF8B980")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xF8E550", Offset = "0xF8E550", VA = "0xF8E550")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xF8DC40", Offset = "0xF8DC40", VA = "0xF8DC40")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xF8C7B4", Offset = "0xF8C7B4", VA = "0xF8C7B4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xF8C994", Offset = "0xF8C994", VA = "0xF8C994")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xF8E768", Offset = "0xF8E768", VA = "0xF8E768")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640668", Offset = "0x640668")]
		public float rootPin;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xF8E7E0", Offset = "0xF8E7E0", VA = "0xF8E7E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xF8F73C", Offset = "0xF8F73C", VA = "0xF8F73C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xF8F820", Offset = "0xF8F820", VA = "0xF8F820", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xF8F928", Offset = "0xF8F928", VA = "0xF8F928", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xF8FA94", Offset = "0xF8FA94", VA = "0xF8FA94")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xF8FBEC", Offset = "0xF8FBEC", VA = "0xF8FBEC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xF90344", Offset = "0xF90344", VA = "0xF90344", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xF905D0", Offset = "0xF905D0", VA = "0xF905D0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xF90418", Offset = "0xF90418", VA = "0xF90418")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xF8FF20", Offset = "0xF8FF20", VA = "0xF8FF20")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xF906A8", Offset = "0xF906A8", VA = "0xF906A8")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640680", Offset = "0x640680")]
		public int iterations;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xF90720", Offset = "0xF90720", VA = "0xF90720")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xF90854", Offset = "0xF90854", VA = "0xF90854")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xF908C0", Offset = "0xF908C0", VA = "0xF908C0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xF7CBA4", Offset = "0xF7CBA4", VA = "0xF7CBA4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xF7BA60", Offset = "0xF7BA60", VA = "0xF7BA60")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xF90A74", Offset = "0xF90A74", VA = "0xF90A74", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xF90CE4", Offset = "0xF90CE4", VA = "0xF90CE4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xF90F0C", Offset = "0xF90F0C", VA = "0xF90F0C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xF911B0", Offset = "0xF911B0", VA = "0xF911B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xF912EC", Offset = "0xF912EC", VA = "0xF912EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xF9143C", Offset = "0xF9143C", VA = "0xF9143C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xF9163C", Offset = "0xF9163C", VA = "0xF9163C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xF91874", Offset = "0xF91874", VA = "0xF91874", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xF91CAC", Offset = "0xF91CAC", VA = "0xF91CAC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xF92260", Offset = "0xF92260", VA = "0xF92260", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xF922C4", Offset = "0xF922C4", VA = "0xF922C4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xF92424", Offset = "0xF92424", VA = "0xF92424")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40001E0")]
		Body,
		[Token(Token = "0x40001E1")]
		LeftShoulder,
		[Token(Token = "0x40001E2")]
		RightShoulder,
		[Token(Token = "0x40001E3")]
		LeftThigh,
		[Token(Token = "0x40001E4")]
		RightThigh,
		[Token(Token = "0x40001E5")]
		LeftHand,
		[Token(Token = "0x40001E6")]
		RightHand,
		[Token(Token = "0x40001E7")]
		LeftFoot,
		[Token(Token = "0x40001E8")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40001EA")]
		LeftArm,
		[Token(Token = "0x40001EB")]
		RightArm,
		[Token(Token = "0x40001EC")]
		LeftLeg,
		[Token(Token = "0x40001ED")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640698", Offset = "0x640698")]
		public float spineStiffness;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6406B0", Offset = "0x6406B0")]
		public float pullBodyVertical;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6406C8", Offset = "0x6406C8")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6406E0", Offset = "0x6406E0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000025")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0xF92504", Offset = "0xF92504", VA = "0xF92504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0xF9250C", Offset = "0xF9250C", VA = "0xF9250C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xF92514", Offset = "0xF92514", VA = "0xF92514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0xF9251C", Offset = "0xF9251C", VA = "0xF9251C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xF92524", Offset = "0xF92524", VA = "0xF92524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0xF9252C", Offset = "0xF9252C", VA = "0xF9252C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0xF92534", Offset = "0xF92534", VA = "0xF92534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xF9253C", Offset = "0xF9253C", VA = "0xF9253C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xF92544", Offset = "0xF92544", VA = "0xF92544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xF9254C", Offset = "0xF9254C", VA = "0xF9254C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xF92594", Offset = "0xF92594", VA = "0xF92594")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xF925DC", Offset = "0xF925DC", VA = "0xF925DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0xF92624", Offset = "0xF92624", VA = "0xF92624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xF9266C", Offset = "0xF9266C", VA = "0xF9266C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xF926B0", Offset = "0xF926B0", VA = "0xF926B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xF926F8", Offset = "0xF926F8", VA = "0xF926F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xF92740", Offset = "0xF92740", VA = "0xF92740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xF92788", Offset = "0xF92788", VA = "0xF92788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xF956AC", Offset = "0xF956AC", VA = "0xF956AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646790", Offset = "0x646790")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xF956B8", Offset = "0xF956B8", VA = "0xF956B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6467A0", Offset = "0x6467A0")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xF927CC", Offset = "0xF927CC", VA = "0xF927CC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xF92944", Offset = "0xF92944", VA = "0xF92944")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xF92834", Offset = "0xF92834", VA = "0xF92834")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xF92A34", Offset = "0xF92A34", VA = "0xF92A34")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xF79910", Offset = "0xF79910", VA = "0xF79910")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xF92B74", Offset = "0xF92B74", VA = "0xF92B74")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xF92C84", Offset = "0xF92C84", VA = "0xF92C84")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xF92D90", Offset = "0xF92D90", VA = "0xF92D90")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xF92E9C", Offset = "0xF92E9C", VA = "0xF92E9C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xF92EA4", Offset = "0xF92EA4", VA = "0xF92EA4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xF92EE8", Offset = "0xF92EE8", VA = "0xF92EE8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xF9300C", Offset = "0xF9300C", VA = "0xF9300C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xF932D8", Offset = "0xF932D8", VA = "0xF932D8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xF94E18", Offset = "0xF94E18", VA = "0xF94E18")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xF953B0", Offset = "0xF953B0", VA = "0xF953B0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xF95470", Offset = "0xF95470", VA = "0xF95470")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xF951E0", Offset = "0xF951E0", VA = "0xF951E0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xF952C8", Offset = "0xF952C8", VA = "0xF952C8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF956C4", Offset = "0xF956C4", VA = "0xF956C4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xF9579C", Offset = "0xF9579C", VA = "0xF9579C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xF95994", Offset = "0xF95994", VA = "0xF95994")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xF95B54", Offset = "0xF95B54", VA = "0xF95B54")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xF95D5C", Offset = "0xF95D5C", VA = "0xF95D5C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xF95FD0", Offset = "0xF95FD0", VA = "0xF95FD0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xF964E4", Offset = "0xF964E4", VA = "0xF964E4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xF96620", Offset = "0xF96620", VA = "0xF96620")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000038")]
		protected virtual int minBones
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x12932E0", Offset = "0x12932E0", VA = "0x12932E0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000039")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x12932E8", Offset = "0x12932E8", VA = "0x12932E8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x12932F0", Offset = "0x12932F0", VA = "0x12932F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1293B38", Offset = "0x1293B38", VA = "0x1293B38", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003C")]
		protected float positionOffset
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1293D18", Offset = "0x1293D18", VA = "0x1293D18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1292854", Offset = "0x1292854", VA = "0x1292854")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1292A6C", Offset = "0x1292A6C", VA = "0x1292A6C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1292C38", Offset = "0x1292C38", VA = "0x1292C38", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1292CD4", Offset = "0x1292CD4", VA = "0x1292CD4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1292D88", Offset = "0x1292D88", VA = "0x1292D88", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x12931A4", Offset = "0x12931A4", VA = "0x12931A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x12931AC", Offset = "0x12931AC", VA = "0x12931AC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x12932F8", Offset = "0x12932F8", VA = "0x12932F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x12932FC", Offset = "0x12932FC", VA = "0x12932FC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1293300", Offset = "0x1293300", VA = "0x1293300")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1293DDC", Offset = "0x1293DDC", VA = "0x1293DDC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x12942AC", Offset = "0x12942AC", VA = "0x12942AC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1294624", Offset = "0x1294624", VA = "0x1294624")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6406F0", Offset = "0x6406F0")]
		public float IKRotationWeight;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1294694", Offset = "0x1294694", VA = "0x1294694", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1294B2C", Offset = "0x1294B2C", VA = "0x1294B2C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1294BF4", Offset = "0x1294BF4", VA = "0x1294BF4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1294DE0", Offset = "0x1294DE0", VA = "0x1294DE0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1294F9C", Offset = "0x1294F9C", VA = "0x1294F9C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1295024", Offset = "0x1295024", VA = "0x1295024", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x12950C4", Offset = "0x12950C4", VA = "0x12950C4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x129574C", Offset = "0x129574C", VA = "0x129574C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1295778", Offset = "0x1295778", VA = "0x1295778")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x129514C", Offset = "0x129514C", VA = "0x129514C")]
		private void Read()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x12958B0", Offset = "0x12958B0", VA = "0x12958B0")]
		private void Write()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1295F4C", Offset = "0x1295F4C", VA = "0x1295F4C")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000089")]
		public enum BendModifier
		{
			[Token(Token = "0x40003E4")]
			Animation,
			[Token(Token = "0x40003E5")]
			Target,
			[Token(Token = "0x40003E6")]
			Parent,
			[Token(Token = "0x40003E7")]
			Arm,
			[Token(Token = "0x40003E8")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public struct AxisDirection
		{
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x70433C", Offset = "0x70433C", VA = "0x70433C")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640708", Offset = "0x640708")]
		public float maintainRotationWeight;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640720", Offset = "0x640720")]
		public float bendModifierWeight;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700003D")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1297BB8", Offset = "0x1297BB8", VA = "0x1297BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1296194", Offset = "0x1296194", VA = "0x1296194")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x12961F8", Offset = "0x12961F8", VA = "0x12961F8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1296320", Offset = "0x1296320", VA = "0x1296320", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1296AA4", Offset = "0x1296AA4", VA = "0x1296AA4", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1297808", Offset = "0x1297808", VA = "0x1297808", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x12979AC", Offset = "0x12979AC", VA = "0x12979AC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1297B30", Offset = "0x1297B30", VA = "0x1297B30")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1296760", Offset = "0x1296760", VA = "0x1296760")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1296BE0", Offset = "0x1296BE0", VA = "0x1296BE0")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008B")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000078")]
			public Vector3 forward
			{
				[Token(Token = "0x6000503")]
				[Address(RVA = "0x129A44C", Offset = "0x129A44C", VA = "0x129A44C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x129ACA0", Offset = "0x129ACA0", VA = "0x129ACA0")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x12991F4", Offset = "0x12991F4", VA = "0x12991F4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x1299638", Offset = "0x1299638", VA = "0x1299638")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x129A910", Offset = "0x129A910", VA = "0x129A910")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640738", Offset = "0x640738")]
		public float bodyWeight;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640750", Offset = "0x640750")]
		public float headWeight;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640768", Offset = "0x640768")]
		public float eyesWeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640780", Offset = "0x640780")]
		public float clampWeight;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640798", Offset = "0x640798")]
		public float clampWeightHead;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6407B0", Offset = "0x6407B0")]
		public float clampWeightEyes;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6407C8", Offset = "0x6407C8")]
		public int clampSmoothing;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x1700003E")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x1298678", Offset = "0x1298678", VA = "0x1298678")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x1298918", Offset = "0x1298918", VA = "0x1298918")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected bool headIsValid
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x12987C0", Offset = "0x12987C0", VA = "0x12987C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x129894C", Offset = "0x129894C", VA = "0x129894C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x12987D0", Offset = "0x12987D0", VA = "0x12987D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x12989CC", Offset = "0x12989CC", VA = "0x12989CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1297C34", Offset = "0x1297C34", VA = "0x1297C34")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1297CB8", Offset = "0x1297CB8", VA = "0x1297CB8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1297D64", Offset = "0x1297D64", VA = "0x1297D64")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1297E2C", Offset = "0x1297E2C", VA = "0x1297E2C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1297F18", Offset = "0x1297F18", VA = "0x1297F18")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1298024", Offset = "0x1298024", VA = "0x1298024")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x129816C", Offset = "0x129816C", VA = "0x129816C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x129830C", Offset = "0x129830C", VA = "0x129830C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x12984C8", Offset = "0x12984C8", VA = "0x12984C8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1298A00", Offset = "0x1298A00", VA = "0x1298A00", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1298D60", Offset = "0x1298D60", VA = "0x1298D60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1298F20", Offset = "0x1298F20", VA = "0x1298F20")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1299220", Offset = "0x1299220", VA = "0x1299220", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1299784", Offset = "0x1299784", VA = "0x1299784", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1299890", Offset = "0x1299890", VA = "0x1299890")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1299B8C", Offset = "0x1299B8C", VA = "0x1299B8C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1299E88", Offset = "0x1299E88", VA = "0x1299E88")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x129A520", Offset = "0x129A520", VA = "0x129A520")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1298FD4", Offset = "0x1298FD4", VA = "0x1298FD4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x129AAA8", Offset = "0x129AAA8", VA = "0x129AAA8")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008C")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x129C6C4", Offset = "0x129C6C4", VA = "0x129C6C4")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x129D55C", Offset = "0x129D55C", VA = "0x129D55C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x129624C", Offset = "0x129624C", VA = "0x129624C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x129D624", Offset = "0x129D624", VA = "0x129D624")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6407E0", Offset = "0x6407E0")]
		public float IKRotationWeight;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x129ACA8", Offset = "0x129ACA8", VA = "0x129ACA8")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x129AECC", Offset = "0x129AECC", VA = "0x129AECC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x129B0D4", Offset = "0x129B0D4", VA = "0x129B0D4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x129B0E0", Offset = "0x129B0E0", VA = "0x129B0E0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x129B164", Offset = "0x129B164", VA = "0x129B164")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x129B170", Offset = "0x129B170", VA = "0x129B170")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x129B178", Offset = "0x129B178", VA = "0x129B178", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x129B2CC", Offset = "0x129B2CC", VA = "0x129B2CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x129B400", Offset = "0x129B400", VA = "0x129B400", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x129B46C", Offset = "0x129B46C", VA = "0x129B46C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x129B4F0", Offset = "0x129B4F0", VA = "0x129B4F0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x129B9E0", Offset = "0x129B9E0", VA = "0x129B9E0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x129BA70", Offset = "0x129BA70", VA = "0x129BA70")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x129C0FC", Offset = "0x129C0FC", VA = "0x129C0FC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x129C314", Offset = "0x129C314", VA = "0x129C314", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x129C588", Offset = "0x129C588", VA = "0x129C588")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x129C470", Offset = "0x129C470", VA = "0x129C470")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x129C884", Offset = "0x129C884", VA = "0x129C884", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x129D618", Offset = "0x129D618", VA = "0x129D618", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x129D61C", Offset = "0x129D61C", VA = "0x129D61C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x129D620", Offset = "0x129D620", VA = "0x129D620", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x129D218", Offset = "0x129D218", VA = "0x129D218")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1297A20", Offset = "0x1297A20", VA = "0x1297A20")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000BB")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400056A")]
				YawPitch,
				[Token(Token = "0x400056B")]
				FromTo
			}

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642774", Offset = "0x642774")]
			public Transform target;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6427AC", Offset = "0x6427AC")]
			public Transform bendGoal;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6427E4", Offset = "0x6427E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6427E4", Offset = "0x6427E4")]
			public float positionWeight;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642838", Offset = "0x642838")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642838", Offset = "0x642838")]
			public float rotationWeight;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64288C", Offset = "0x64288C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6428C4", Offset = "0x6428C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6428C4", Offset = "0x6428C4")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642918", Offset = "0x642918")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642918", Offset = "0x642918")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64296C", Offset = "0x64296C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64296C", Offset = "0x64296C")]
			public float bendGoalWeight;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6429C0", Offset = "0x6429C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6429C0", Offset = "0x6429C0")]
			public float swivelOffset;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642A1C", Offset = "0x642A1C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642A54", Offset = "0x642A54")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642A8C", Offset = "0x642A8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642A8C", Offset = "0x642A8C")]
			public float armLengthMlp;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642AE4", Offset = "0x642AE4")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642B1C", Offset = "0x642B1C")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642B2C", Offset = "0x642B2C")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642B3C", Offset = "0x642B3C")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642B4C", Offset = "0x642B4C")]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B5C", Offset = "0x642B5C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B6C", Offset = "0x642B6C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400040A")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400040B")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000079")]
			public Vector3 position
			{
				[Token(Token = "0x6000508")]
				[Address(RVA = "0x12A8334", Offset = "0x12A8334", VA = "0x12A8334")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647610", Offset = "0x647610")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000509")]
				[Address(RVA = "0x12A8340", Offset = "0x12A8340", VA = "0x12A8340")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647620", Offset = "0x647620")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public Quaternion rotation
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0x12A834C", Offset = "0x12A834C", VA = "0x12A834C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647630", Offset = "0x647630")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600050B")]
				[Address(RVA = "0x12A8358", Offset = "0x12A8358", VA = "0x12A8358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647640", Offset = "0x647640")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x12A8364", Offset = "0x12A8364", VA = "0x12A8364")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600050D")]
				[Address(RVA = "0x12A83A8", Offset = "0x12A83A8", VA = "0x12A83A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0x12A83F8", Offset = "0x12A83F8", VA = "0x12A83F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private VirtualBone hand
			{
				[Token(Token = "0x600050F")]
				[Address(RVA = "0x12A8454", Offset = "0x12A8454", VA = "0x12A8454")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x12A84B0", Offset = "0x12A84B0", VA = "0x12A84B0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x12A90F8", Offset = "0x12A90F8", VA = "0x12A90F8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x12A9340", Offset = "0x12A9340", VA = "0x12A9340", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x12A93EC", Offset = "0x12A93EC", VA = "0x12A93EC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x12A5FF4", Offset = "0x12A5FF4", VA = "0x12A5FF4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x12AAC2C", Offset = "0x12AAC2C", VA = "0x12AAC2C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x12AAC9C", Offset = "0x12AAC9C", VA = "0x12AAC9C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x12A98D4", Offset = "0x12A98D4", VA = "0x12A98D4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x12A9CC4", Offset = "0x12A9CC4", VA = "0x12A9CC4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x12AAFE8", Offset = "0x12AAFE8", VA = "0x12AAFE8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0x12A8124", Offset = "0x12A8124", VA = "0x12A8124")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B7C", Offset = "0x642B7C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B8C", Offset = "0x642B8C")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642B9C", Offset = "0x642B9C")]
			public VirtualBone[] bones;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x1700007F")]
			public float sqrMag
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x12AB1D8", Offset = "0x12AB1D8", VA = "0x12AB1D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647650", Offset = "0x647650")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000521")]
				[Address(RVA = "0x12AB1E0", Offset = "0x12AB1E0", VA = "0x12AB1E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647660", Offset = "0x647660")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public float mag
			{
				[Token(Token = "0x6000522")]
				[Address(RVA = "0x12A99AC", Offset = "0x12A99AC", VA = "0x12A99AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647670", Offset = "0x647670")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000523")]
				[Address(RVA = "0x12AB1E8", Offset = "0x12AB1E8", VA = "0x12AB1E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647680", Offset = "0x647680")]
				private set
				{
				}
			}

			[Token(Token = "0x600051B")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600051C")]
			public abstract void PreSolve();

			[Token(Token = "0x600051D")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600051E")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600051F")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x12A38E8", Offset = "0x12A38E8", VA = "0x12A38E8")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x1295E04", Offset = "0x1295E04", VA = "0x1295E04")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x12AB734", Offset = "0x12AB734", VA = "0x12AB734")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x12AB8CC", Offset = "0x12AB8CC", VA = "0x12AB8CC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x12ABC54", Offset = "0x12ABC54", VA = "0x12ABC54")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x12A5D94", Offset = "0x12A5D94", VA = "0x12A5D94")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x12AAA14", Offset = "0x12AAA14", VA = "0x12AAA14")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x12ABCA8", Offset = "0x12ABCA8", VA = "0x12ABCA8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x12ABE48", Offset = "0x12ABE48", VA = "0x12ABE48")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x12AB140", Offset = "0x12AB140", VA = "0x12AB140")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class Footstep
		{
			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642BAC", Offset = "0x642BAC")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000081")]
			public bool isStepping
			{
				[Token(Token = "0x600052E")]
				[Address(RVA = "0x12ABE70", Offset = "0x12ABE70", VA = "0x12ABE70")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000082")]
			public float stepProgress
			{
				[Token(Token = "0x600052F")]
				[Address(RVA = "0x12ABE84", Offset = "0x12ABE84", VA = "0x12ABE84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647690", Offset = "0x647690")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000530")]
				[Address(RVA = "0x12ABE8C", Offset = "0x12ABE8C", VA = "0x12ABE8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6476A0", Offset = "0x6476A0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x12ABE94", Offset = "0x12ABE94", VA = "0x12ABE94")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x12AC028", Offset = "0x12AC028", VA = "0x12AC028")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x12AC070", Offset = "0x12AC070", VA = "0x12AC070")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x12AC23C", Offset = "0x12AC23C", VA = "0x12AC23C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x12AC414", Offset = "0x12AC414", VA = "0x12AC414")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x12AC600", Offset = "0x12AC600", VA = "0x12AC600")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642BBC", Offset = "0x642BBC")]
			public Transform target;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642BF4", Offset = "0x642BF4")]
			public Transform bendGoal;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642C2C", Offset = "0x642C2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642C2C", Offset = "0x642C2C")]
			public float positionWeight;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642C80", Offset = "0x642C80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642C80", Offset = "0x642C80")]
			public float rotationWeight;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642CD4", Offset = "0x642CD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642CD4", Offset = "0x642CD4")]
			public float bendGoalWeight;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642D28", Offset = "0x642D28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642D28", Offset = "0x642D28")]
			public float swivelOffset;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642D84", Offset = "0x642D84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642D84", Offset = "0x642D84")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642DD8", Offset = "0x642DD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642DD8", Offset = "0x642DD8")]
			public float legLengthMlp;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642E30", Offset = "0x642E30")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642E68", Offset = "0x642E68")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642E78", Offset = "0x642E78")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642E88", Offset = "0x642E88")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642E98", Offset = "0x642E98")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642EA8", Offset = "0x642EA8")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642EB8", Offset = "0x642EB8")]
			public float currentMag;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x642EC8", Offset = "0x642EC8")]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642ED8", Offset = "0x642ED8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642EE8", Offset = "0x642EE8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642EF8", Offset = "0x642EF8")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642F08", Offset = "0x642F08")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x17000083")]
			public Vector3 position
			{
				[Token(Token = "0x6000537")]
				[Address(RVA = "0x12A5C10", Offset = "0x12A5C10", VA = "0x12A5C10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6476B0", Offset = "0x6476B0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000538")]
				[Address(RVA = "0x12AC820", Offset = "0x12AC820", VA = "0x12AC820")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6476C0", Offset = "0x6476C0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000539")]
				[Address(RVA = "0x12AC82C", Offset = "0x12AC82C", VA = "0x12AC82C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6476D0", Offset = "0x6476D0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600053A")]
				[Address(RVA = "0x12AC838", Offset = "0x12AC838", VA = "0x12AC838")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6476E0", Offset = "0x6476E0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public bool hasToes
			{
				[Token(Token = "0x600053B")]
				[Address(RVA = "0x12AC844", Offset = "0x12AC844", VA = "0x12AC844")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6476F0", Offset = "0x6476F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600053C")]
				[Address(RVA = "0x12AC84C", Offset = "0x12AC84C", VA = "0x12AC84C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647700", Offset = "0x647700")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600053D")]
				[Address(RVA = "0x12AC858", Offset = "0x12AC858", VA = "0x12AC858")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private VirtualBone calf
			{
				[Token(Token = "0x600053E")]
				[Address(RVA = "0x12AC89C", Offset = "0x12AC89C", VA = "0x12AC89C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private VirtualBone foot
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0x12AC8E4", Offset = "0x12AC8E4", VA = "0x12AC8E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0x12AC92C", Offset = "0x12AC92C", VA = "0x12AC92C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000541")]
				[Address(RVA = "0x12A5BB4", Offset = "0x12A5BB4", VA = "0x12A5BB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0x12AC974", Offset = "0x12AC974", VA = "0x12AC974")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647710", Offset = "0x647710")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000543")]
				[Address(RVA = "0x12AC980", Offset = "0x12AC980", VA = "0x12AC980")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647720", Offset = "0x647720")]
				private set
				{
				}
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x12AC98C", Offset = "0x12AC98C", VA = "0x12AC98C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x12AD19C", Offset = "0x12AD19C", VA = "0x12AD19C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x12ADB24", Offset = "0x12ADB24", VA = "0x12ADB24", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x12ADA20", Offset = "0x12ADA20", VA = "0x12ADA20")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x12AD7E8", Offset = "0x12AD7E8", VA = "0x12AD7E8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1295BB0", Offset = "0x1295BB0", VA = "0x1295BB0")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x12AE740", Offset = "0x12AE740", VA = "0x12AE740")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x12AE13C", Offset = "0x12AE13C", VA = "0x12AE13C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x12AEBEC", Offset = "0x12AEBEC", VA = "0x12AEBEC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x12AEF34", Offset = "0x12AEF34", VA = "0x12AEF34", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x12960A0", Offset = "0x12960A0", VA = "0x12960A0")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public class Locomotion
		{
			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642F18", Offset = "0x642F18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642F18", Offset = "0x642F18")]
			public float weight;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642F6C", Offset = "0x642F6C")]
			public float footDistance;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642FA4", Offset = "0x642FA4")]
			public float stepThreshold;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642FDC", Offset = "0x642FDC")]
			public float angleThreshold;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643014", Offset = "0x643014")]
			public float comAngleMlp;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64304C", Offset = "0x64304C")]
			public float maxVelocity;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643084", Offset = "0x643084")]
			public float velocityFactor;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6430BC", Offset = "0x6430BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6430BC", Offset = "0x6430BC")]
			public float maxLegStretch;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643114", Offset = "0x643114")]
			public float rootSpeed;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64314C", Offset = "0x64314C")]
			public float stepSpeed;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643184", Offset = "0x643184")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6431BC", Offset = "0x6431BC")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6431F4", Offset = "0x6431F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6431F4", Offset = "0x6431F4")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64324C", Offset = "0x64324C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643284", Offset = "0x643284")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6432BC", Offset = "0x6432BC")]
			public Vector3 offset;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6432F4", Offset = "0x6432F4")]
			public bool blockingEnabled;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643304", Offset = "0x643304")]
			public LayerMask blockingLayers;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643314", Offset = "0x643314")]
			public float raycastRadius;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643324", Offset = "0x643324")]
			public float raycastHeight;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643334", Offset = "0x643334")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64336C", Offset = "0x64336C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6433A4", Offset = "0x6433A4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x1700008C")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x12AEFE4", Offset = "0x12AEFE4", VA = "0x12AEFE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647730", Offset = "0x647730")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000550")]
				[Address(RVA = "0x12AEFF0", Offset = "0x12AEFF0", VA = "0x12AEFF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647740", Offset = "0x647740")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008D")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000556")]
				[Address(RVA = "0x12AF464", Offset = "0x12AF464", VA = "0x12AF464")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000557")]
				[Address(RVA = "0x12AF4BC", Offset = "0x12AF4BC", VA = "0x12AF4BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0x12AF518", Offset = "0x12AF518", VA = "0x12AF518")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000090")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000559")]
				[Address(RVA = "0x12AF570", Offset = "0x12AF570", VA = "0x12AF570")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x12A3500", Offset = "0x12A3500", VA = "0x12A3500")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x129FDCC", Offset = "0x129FDCC", VA = "0x129FDCC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x129EF08", Offset = "0x129EF08", VA = "0x129EF08")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x129ED4C", Offset = "0x129ED4C", VA = "0x129ED4C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x12A3FA4", Offset = "0x12A3FA4", VA = "0x12A3FA4")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x12AF04C", Offset = "0x12AF04C", VA = "0x12AF04C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x12AF1F0", Offset = "0x12AF1F0", VA = "0x12AF1F0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x12AF298", Offset = "0x12AF298", VA = "0x12AF298")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x12A824C", Offset = "0x12A824C", VA = "0x12A824C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6433B4", Offset = "0x6433B4")]
			public Transform headTarget;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6433EC", Offset = "0x6433EC")]
			public Transform pelvisTarget;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643424", Offset = "0x643424")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643424", Offset = "0x643424")]
			public float positionWeight;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643478", Offset = "0x643478")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643478", Offset = "0x643478")]
			public float rotationWeight;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6434CC", Offset = "0x6434CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6434CC", Offset = "0x6434CC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643520", Offset = "0x643520")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643520", Offset = "0x643520")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643574", Offset = "0x643574")]
			public Transform chestGoal;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6435AC", Offset = "0x6435AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6435AC", Offset = "0x6435AC")]
			public float chestGoalWeight;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643600", Offset = "0x643600")]
			public float minHeadHeight;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643638", Offset = "0x643638")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643638", Offset = "0x643638")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64368C", Offset = "0x64368C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64368C", Offset = "0x64368C")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6436E0", Offset = "0x6436E0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6436E0", Offset = "0x6436E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6436E0", Offset = "0x6436E0")]
			public float neckStiffness;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643758", Offset = "0x643758")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643758", Offset = "0x643758")]
			public float rotateChestByHands;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6437AC", Offset = "0x6437AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6437AC", Offset = "0x6437AC")]
			public float chestClampWeight;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643800", Offset = "0x643800")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643800", Offset = "0x643800")]
			public float headClampWeight;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643854", Offset = "0x643854")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64388C", Offset = "0x64388C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64388C", Offset = "0x64388C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6438E0", Offset = "0x6438E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6438E0", Offset = "0x6438E0")]
			public float maxRootAngle;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643938", Offset = "0x643938")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643938", Offset = "0x643938")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643994", Offset = "0x643994")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6439A4", Offset = "0x6439A4")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6439B4", Offset = "0x6439B4")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6439C4", Offset = "0x6439C4")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6439D4", Offset = "0x6439D4")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6439E4", Offset = "0x6439E4")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6439F4", Offset = "0x6439F4")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643A04", Offset = "0x643A04")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643A14", Offset = "0x643A14")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643A24", Offset = "0x643A24")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643A34", Offset = "0x643A34")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643A44", Offset = "0x643A44")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643A54", Offset = "0x643A54")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x643A64", Offset = "0x643A64")]
			public Vector3 headPosition;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643A74", Offset = "0x643A74")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643A84", Offset = "0x643A84")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x17000091")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0x12A018C", Offset = "0x12A018C", VA = "0x12A018C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600055F")]
				[Address(RVA = "0x12AF5CC", Offset = "0x12AF5CC", VA = "0x12AF5CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0x12A5F8C", Offset = "0x12A5F8C", VA = "0x12A5F8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000561")]
				[Address(RVA = "0x12AF61C", Offset = "0x12AF61C", VA = "0x12AF61C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			public VirtualBone head
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0x12AEFFC", Offset = "0x12AEFFC", VA = "0x12AEFFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000563")]
				[Address(RVA = "0x12AF66C", Offset = "0x12AF66C", VA = "0x12AF66C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647750", Offset = "0x647750")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000564")]
				[Address(RVA = "0x12AF680", Offset = "0x12AF680", VA = "0x12AF680")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647760", Offset = "0x647760")]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000565")]
				[Address(RVA = "0x12A3394", Offset = "0x12A3394", VA = "0x12A3394")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647770", Offset = "0x647770")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000566")]
				[Address(RVA = "0x12AF694", Offset = "0x12AF694", VA = "0x12AF694")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647780", Offset = "0x647780")]
				private set
				{
				}
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0x12AF6A8", Offset = "0x12AF6A8", VA = "0x12AF6A8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x12B04EC", Offset = "0x12B04EC", VA = "0x12B04EC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x12B074C", Offset = "0x12B074C", VA = "0x12B074C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x12B0DCC", Offset = "0x12B0DCC", VA = "0x12B0DCC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0x12A38F0", Offset = "0x12A38F0", VA = "0x12A38F0")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x12B17EC", Offset = "0x12B17EC", VA = "0x12B17EC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x12B1F9C", Offset = "0x12B1F9C", VA = "0x12B1F9C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x12B29A4", Offset = "0x12B29A4", VA = "0x12B29A4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x12B2D20", Offset = "0x12B2D20", VA = "0x12B2D20", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x12B1000", Offset = "0x12B1000", VA = "0x12B1000")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x12A5C1C", Offset = "0x12A5C1C", VA = "0x12A5C1C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x12B13C4", Offset = "0x12B13C4", VA = "0x12B13C4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x12B2E1C", Offset = "0x12B2E1C", VA = "0x12B2E1C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x12B1CFC", Offset = "0x12B1CFC", VA = "0x12B1CFC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x12B1A08", Offset = "0x12B1A08", VA = "0x12B1A08")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x12A7F70", Offset = "0x12A7F70", VA = "0x12A7F70")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000491")]
			Pelvis,
			[Token(Token = "0x4000492")]
			Chest,
			[Token(Token = "0x4000493")]
			Head,
			[Token(Token = "0x4000494")]
			LeftHand,
			[Token(Token = "0x4000495")]
			RightHand,
			[Token(Token = "0x4000496")]
			LeftFoot,
			[Token(Token = "0x4000497")]
			RightFoot,
			[Token(Token = "0x4000498")]
			LeftHeel,
			[Token(Token = "0x4000499")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public enum RotationOffset
		{
			[Token(Token = "0x400049B")]
			Pelvis,
			[Token(Token = "0x400049C")]
			Chest,
			[Token(Token = "0x400049D")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class VirtualBone
		{
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x12A345C", Offset = "0x12A345C", VA = "0x12A345C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x12A34E0", Offset = "0x12A34E0", VA = "0x12A34E0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x12B31CC", Offset = "0x12B31CC", VA = "0x12B31CC")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x12AB1F0", Offset = "0x12AB1F0", VA = "0x12AB1F0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x12AB9C8", Offset = "0x12AB9C8", VA = "0x12AB9C8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x12B3508", Offset = "0x12B3508", VA = "0x12B3508")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x12A99B4", Offset = "0x12A99B4", VA = "0x12A99B4")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x12B3810", Offset = "0x12B3810", VA = "0x12B3810")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x12AA2F0", Offset = "0x12AA2F0", VA = "0x12AA2F0")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x12B3910", Offset = "0x12B3910", VA = "0x12B3910")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x12B232C", Offset = "0x12B232C", VA = "0x12B232C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x12B3B28", Offset = "0x12B3B28", VA = "0x12B3B28")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x12B3C30", Offset = "0x12B3C30", VA = "0x12B3C30")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6407F8", Offset = "0x6407F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6407F8", Offset = "0x6407F8")]
		public int LOD;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64084C", Offset = "0x64084C")]
		public bool plantFeet;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640884", Offset = "0x640884")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640894", Offset = "0x640894")]
		public Spine spine;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6408CC", Offset = "0x6408CC")]
		public Arm leftArm;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640904", Offset = "0x640904")]
		public Arm rightArm;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64093C", Offset = "0x64093C")]
		public Leg leftLeg;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640974", Offset = "0x640974")]
		public Leg rightLeg;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6409AC", Offset = "0x6409AC")]
		public Locomotion locomotion;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000044")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x647A70", Offset = "0x647A70")]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x129FDC4", Offset = "0x129FDC4", VA = "0x129FDC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6467B0", Offset = "0x6467B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x12A34D8", Offset = "0x12A34D8", VA = "0x12A34D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6467C0", Offset = "0x6467C0")]
			private set
			{
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x129D62C", Offset = "0x129D62C", VA = "0x129D62C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x129DBAC", Offset = "0x129DBAC", VA = "0x129DBAC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x129D9C8", Offset = "0x129D9C8", VA = "0x129D9C8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x129E7B0", Offset = "0x129E7B0", VA = "0x129E7B0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x129E94C", Offset = "0x129E94C", VA = "0x129E94C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x129E9F0", Offset = "0x129E9F0", VA = "0x129E9F0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x129EB98", Offset = "0x129EB98", VA = "0x129EB98")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x129F2EC", Offset = "0x129F2EC", VA = "0x129F2EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x12A01DC", Offset = "0x12A01DC", VA = "0x12A01DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x12A0410", Offset = "0x12A0410", VA = "0x12A0410", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x12A06DC", Offset = "0x12A06DC", VA = "0x12A06DC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x12A0750", Offset = "0x12A0750", VA = "0x12A0750", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x12A07C4", Offset = "0x12A07C4", VA = "0x12A07C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x12A09F4", Offset = "0x12A09F4", VA = "0x12A09F4")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x129DF6C", Offset = "0x129DF6C", VA = "0x129DF6C")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x129E15C", Offset = "0x129E15C", VA = "0x129E15C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x129E638", Offset = "0x129E638", VA = "0x129E638")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x129F4A8", Offset = "0x129F4A8", VA = "0x129F4A8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x12A0D38", Offset = "0x12A0D38", VA = "0x12A0D38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x12A0D80", Offset = "0x12A0D80", VA = "0x12A0D80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x12A2D1C", Offset = "0x12A2D1C", VA = "0x12A2D1C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x129F6CC", Offset = "0x129F6CC", VA = "0x129F6CC")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x12A13A4", Offset = "0x12A13A4", VA = "0x12A13A4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x12A33A8", Offset = "0x12A33A8", VA = "0x12A33A8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x12A3404", Offset = "0x12A3404", VA = "0x12A3404")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x12A2B40", Offset = "0x12A2B40", VA = "0x12A2B40")]
		private void Write()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x12A76C8", Offset = "0x12A76C8", VA = "0x12A76C8")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x12A7DC8", Offset = "0x12A7DC8", VA = "0x12A7DC8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6409E4", Offset = "0x6409E4")]
		public Transform parent;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640A1C", Offset = "0x640A1C")]
		public Transform child;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640A54", Offset = "0x640A54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640A54", Offset = "0x640A54")]
		public float weight;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640AA8", Offset = "0x640AA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640AA8", Offset = "0x640AA8")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640AFC", Offset = "0x640AFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640AFC", Offset = "0x640AFC")]
		public float twistAngleOffset;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xD79B54", Offset = "0xD79B54", VA = "0xD79B54")]
		public void Relax()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xD79F98", Offset = "0xD79F98", VA = "0xD79F98")]
		private void Start()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xD7A50C", Offset = "0xD7A50C", VA = "0xD7A50C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xD7A594", Offset = "0xD7A594", VA = "0xD7A594")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xD7A61C", Offset = "0xD7A61C", VA = "0xD7A61C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xD7A788", Offset = "0xD7A788", VA = "0xD7A788")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class InteractionEffector
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640B58", Offset = "0x640B58")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640B68", Offset = "0x640B68")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640B78", Offset = "0x640B78")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000045")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xD61A48", Offset = "0xD61A48", VA = "0xD61A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6467D0", Offset = "0x6467D0")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0xD61A50", Offset = "0xD61A50", VA = "0xD61A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6467E0", Offset = "0x6467E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public bool isPaused
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0xD61A58", Offset = "0xD61A58", VA = "0xD61A58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6467F0", Offset = "0x6467F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0xD61A60", Offset = "0xD61A60", VA = "0xD61A60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646800", Offset = "0x646800")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xD61A6C", Offset = "0xD61A6C", VA = "0xD61A6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646810", Offset = "0x646810")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xD61A74", Offset = "0xD61A74", VA = "0xD61A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646820", Offset = "0x646820")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool inInteraction
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0xD61A7C", Offset = "0xD61A7C", VA = "0xD61A7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public float progress
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0xD655F4", Offset = "0xD655F4", VA = "0xD655F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xD61AEC", Offset = "0xD61AEC", VA = "0xD61AEC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xD61B70", Offset = "0xD61B70", VA = "0xD61B70")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xD61C4C", Offset = "0xD61C4C", VA = "0xD61C4C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xD61EE8", Offset = "0xD61EE8", VA = "0xD61EE8")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xD6255C", Offset = "0xD6255C", VA = "0xD6255C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD62B80", Offset = "0xD62B80", VA = "0xD62B80")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD62C0C", Offset = "0xD62C0C", VA = "0xD62C0C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD63A3C", Offset = "0xD63A3C", VA = "0xD63A3C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD649A0", Offset = "0xD649A0", VA = "0xD649A0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD64E64", Offset = "0xD64E64", VA = "0xD64E64")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xD65454", Offset = "0xD65454", VA = "0xD65454")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xD65D48", Offset = "0xD65D48", VA = "0xD65D48")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640B88", Offset = "0x640B88")]
		public LookAtIK ik;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640BC0", Offset = "0x640BC0")]
		public float lerpSpeed;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640BF8", Offset = "0x640BF8")]
		public float weightSpeed;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x640C30", Offset = "0x640C30")]
		public bool isPaused;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xD660B0", Offset = "0xD660B0", VA = "0xD660B0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xD662BC", Offset = "0xD662BC", VA = "0xD662BC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xD66384", Offset = "0xD66384", VA = "0xD66384")]
		public void Update()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xD66640", Offset = "0xD66640", VA = "0xD66640")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xD667D4", Offset = "0xD667D4", VA = "0xD667D4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xD668F8", Offset = "0xD668F8", VA = "0xD668F8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E914", Offset = "0x63E914")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E914", Offset = "0x63E914")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class InteractionEvent
		{
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643A94", Offset = "0x643A94")]
			public float time;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643ACC", Offset = "0x643ACC")]
			public bool pause;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643B04", Offset = "0x643B04")]
			public bool pickUp;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643B3C", Offset = "0x643B3C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643B74", Offset = "0x643B74")]
			public Message[] messages;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643BAC", Offset = "0x643BAC")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000584")]
			[Address(RVA = "0xD65630", Offset = "0xD65630", VA = "0xD65630")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0xD681C4", Offset = "0xD681C4", VA = "0xD681C4")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class Message
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643BE4", Offset = "0x643BE4")]
			public string function;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643C1C", Offset = "0x643C1C")]
			public GameObject recipient;

			[Token(Token = "0x40004AD")]
			private const string empty = "";

			[Token(Token = "0x6000586")]
			[Address(RVA = "0xD680C8", Offset = "0xD680C8", VA = "0xD680C8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0xD681CC", Offset = "0xD681CC", VA = "0xD681CC")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643C54", Offset = "0x643C54")]
			public Animator animator;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643C8C", Offset = "0x643C8C")]
			public Animation animation;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643CC4", Offset = "0x643CC4")]
			public string animationState;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643CFC", Offset = "0x643CFC")]
			public float crossfadeTime;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643D34", Offset = "0x643D34")]
			public int layer;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643D6C", Offset = "0x643D6C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40004B4")]
			private const string empty = "";

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xD67DA4", Offset = "0xD67DA4", VA = "0xD67DA4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0xD67EA0", Offset = "0xD67EA0", VA = "0xD67EA0")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0xD67F88", Offset = "0xD67F88", VA = "0xD67F88")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0xD680B4", Offset = "0xD680B4", VA = "0xD680B4")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000BC")]
			public enum Type
			{
				[Token(Token = "0x400056D")]
				PositionWeight,
				[Token(Token = "0x400056E")]
				RotationWeight,
				[Token(Token = "0x400056F")]
				PositionOffsetX,
				[Token(Token = "0x4000570")]
				PositionOffsetY,
				[Token(Token = "0x4000571")]
				PositionOffsetZ,
				[Token(Token = "0x4000572")]
				Pull,
				[Token(Token = "0x4000573")]
				Reach,
				[Token(Token = "0x4000574")]
				RotateBoneWeight,
				[Token(Token = "0x4000575")]
				Push,
				[Token(Token = "0x4000576")]
				PushParent,
				[Token(Token = "0x4000577")]
				PoserWeight,
				[Token(Token = "0x4000578")]
				BendGoalWeight
			}

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643DA4", Offset = "0x643DA4")]
			public Type type;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643DDC", Offset = "0x643DDC")]
			public AnimationCurve curve;

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xD672EC", Offset = "0xD672EC", VA = "0xD672EC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xD681E4", Offset = "0xD681E4", VA = "0xD681E4")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009A")]
		public class Multiplier
		{
			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643E14", Offset = "0x643E14")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643E4C", Offset = "0x643E4C")]
			public float multiplier;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643E84", Offset = "0x643E84")]
			public WeightCurve.Type result;

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xD67C44", Offset = "0xD67C44", VA = "0xD67C44")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0xD681D4", Offset = "0xD681D4", VA = "0xD681D4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640C40", Offset = "0x640C40")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640C78", Offset = "0x640C78")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640CB0", Offset = "0x640CB0")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CE8", Offset = "0x640CE8")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CF8", Offset = "0x640CF8")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004A")]
		public float length
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0xD63420", Offset = "0xD63420", VA = "0xD63420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6469F0", Offset = "0x6469F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0xD66B6C", Offset = "0xD66B6C", VA = "0xD66B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646A00", Offset = "0x646A00")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0xD66B74", Offset = "0xD66B74", VA = "0xD66B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646A10", Offset = "0x646A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0xD66B7C", Offset = "0xD66B7C", VA = "0xD66B7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646A20", Offset = "0x646A20")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xD66E94", Offset = "0xD66E94", VA = "0xD66E94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xD65BEC", Offset = "0xD65BEC", VA = "0xD65BEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xD6690C", Offset = "0xD6690C", VA = "0xD6690C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646830", Offset = "0x646830")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xD66958", Offset = "0xD66958", VA = "0xD66958")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646868", Offset = "0x646868")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xD669A4", Offset = "0xD669A4", VA = "0xD669A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6468A0", Offset = "0x6468A0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xD669F0", Offset = "0xD669F0", VA = "0xD669F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6468D8", Offset = "0x6468D8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xD66A3C", Offset = "0xD66A3C", VA = "0xD66A3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646910", Offset = "0x646910")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xD66A88", Offset = "0xD66A88", VA = "0xD66A88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646948", Offset = "0x646948")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xD66AD4", Offset = "0xD66AD4", VA = "0xD66AD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646980", Offset = "0x646980")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xD66B20", Offset = "0xD66B20", VA = "0xD66B20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6469B8", Offset = "0x6469B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xD66B84", Offset = "0xD66B84", VA = "0xD66B84")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD66F24", Offset = "0xD66F24", VA = "0xD66F24")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xD63320", Offset = "0xD63320", VA = "0xD63320")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xD670F0", Offset = "0xD670F0", VA = "0xD670F0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xD63140", Offset = "0xD63140", VA = "0xD63140")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xD63318", Offset = "0xD63318", VA = "0xD63318")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD64330", Offset = "0xD64330", VA = "0xD64330")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xD6512C", Offset = "0xD6512C", VA = "0xD6512C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xD67C90", Offset = "0xD67C90", VA = "0xD67C90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xD6732C", Offset = "0xD6732C", VA = "0xD6732C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xD670F8", Offset = "0xD670F8", VA = "0xD670F8")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xD67B94", Offset = "0xD67B94", VA = "0xD67B94")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xD67C94", Offset = "0xD67C94", VA = "0xD67C94")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xD67D44", Offset = "0xD67D44", VA = "0xD67D44")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E974", Offset = "0x63E974")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E974", Offset = "0x63E974")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200009C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640D08", Offset = "0x640D08")]
		public string targetTag;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640D40", Offset = "0x640D40")]
		public float fadeInTime;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640D78", Offset = "0x640D78")]
		public float speed;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640DB0", Offset = "0x640DB0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x640DE8", Offset = "0x640DE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640DE8", Offset = "0x640DE8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x640DE8", Offset = "0x640DE8")]
		public Collider characterCollider;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640E6C", Offset = "0x640E6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x640E6C", Offset = "0x640E6C")]
		public Transform FPSCamera;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640ECC", Offset = "0x640ECC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640F04", Offset = "0x640F04")]
		public float camRaycastDistance;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F3C", Offset = "0x640F3C")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x640F4C", Offset = "0x640F4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640F4C", Offset = "0x640F4C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640FAC", Offset = "0x640FAC")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700004E")]
		public bool inInteraction
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0xD6844C", Offset = "0xD6844C", VA = "0xD6844C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xD61C44", Offset = "0xD61C44", VA = "0xD61C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xD6ADC8", Offset = "0xD6ADC8", VA = "0xD6ADC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xD69938", Offset = "0xD69938", VA = "0xD69938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646BF0", Offset = "0x646BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xD6ADD0", Offset = "0xD6ADD0", VA = "0xD6ADD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646C00", Offset = "0x646C00")]
			private set
			{
			}
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xD681EC", Offset = "0xD681EC", VA = "0xD681EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646A30", Offset = "0x646A30")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xD68238", Offset = "0xD68238", VA = "0xD68238")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646A68", Offset = "0x646A68")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xD68284", Offset = "0xD68284", VA = "0xD68284")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646AA0", Offset = "0x646AA0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xD682D0", Offset = "0xD682D0", VA = "0xD682D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646AD8", Offset = "0x646AD8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xD6831C", Offset = "0xD6831C", VA = "0xD6831C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646B10", Offset = "0x646B10")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xD68368", Offset = "0xD68368", VA = "0xD68368")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646B48", Offset = "0x646B48")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xD683B4", Offset = "0xD683B4", VA = "0xD683B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646B80", Offset = "0x646B80")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xD68400", Offset = "0xD68400", VA = "0xD68400")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646BB8", Offset = "0x646BB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xD6862C", Offset = "0xD6862C", VA = "0xD6862C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xD68784", Offset = "0xD68784", VA = "0xD68784")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xD688DC", Offset = "0xD688DC", VA = "0xD688DC")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xD689D8", Offset = "0xD689D8", VA = "0xD689D8")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xD68B58", Offset = "0xD68B58", VA = "0xD68B58")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xD68CFC", Offset = "0xD68CFC", VA = "0xD68CFC")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xD68E0C", Offset = "0xD68E0C", VA = "0xD68E0C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xD68F1C", Offset = "0xD68F1C", VA = "0xD68F1C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xD6902C", Offset = "0xD6902C", VA = "0xD6902C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xD690D0", Offset = "0xD690D0", VA = "0xD690D0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xD69174", Offset = "0xD69174", VA = "0xD69174")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xD6920C", Offset = "0xD6920C", VA = "0xD6920C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xD6930C", Offset = "0xD6930C", VA = "0xD6930C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xD69434", Offset = "0xD69434", VA = "0xD69434")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xD69564", Offset = "0xD69564", VA = "0xD69564")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xD69940", Offset = "0xD69940", VA = "0xD69940")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xD69BF0", Offset = "0xD69BF0", VA = "0xD69BF0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xD69FB0", Offset = "0xD69FB0", VA = "0xD69FB0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xD6A354", Offset = "0xD6A354", VA = "0xD6A354")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xD6A3B0", Offset = "0xD6A3B0", VA = "0xD6A3B0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xD6A4A8", Offset = "0xD6A4A8", VA = "0xD6A4A8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xD6A620", Offset = "0xD6A620", VA = "0xD6A620")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xD6A7D8", Offset = "0xD6A7D8", VA = "0xD6A7D8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xD6AC70", Offset = "0xD6AC70", VA = "0xD6AC70")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xD6A0E8", Offset = "0xD6A0E8", VA = "0xD6A0E8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xD6ADD8", Offset = "0xD6ADD8", VA = "0xD6ADD8")]
		public void Start()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xD6B750", Offset = "0xD6B750", VA = "0xD6B750")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xD6B780", Offset = "0xD6B780", VA = "0xD6B780")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xD6B7AC", Offset = "0xD6B7AC", VA = "0xD6B7AC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD6B7D8", Offset = "0xD6B7D8", VA = "0xD6B7D8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD6B85C", Offset = "0xD6B85C", VA = "0xD6B85C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xD6B994", Offset = "0xD6B994", VA = "0xD6B994")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xD6BAA0", Offset = "0xD6BAA0", VA = "0xD6BAA0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xD6BE74", Offset = "0xD6BE74", VA = "0xD6BE74")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD6BF60", Offset = "0xD6BF60", VA = "0xD6BF60")]
		public void Update()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xD6C228", Offset = "0xD6C228", VA = "0xD6C228")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xD6B490", Offset = "0xD6B490", VA = "0xD6B490")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xD6C37C", Offset = "0xD6C37C", VA = "0xD6C37C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD6C510", Offset = "0xD6C510", VA = "0xD6C510")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xD6C5B0", Offset = "0xD6C5B0", VA = "0xD6C5B0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xD6C6C8", Offset = "0xD6C6C8", VA = "0xD6C6C8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xD6C6F4", Offset = "0xD6C6F4", VA = "0xD6C6F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xD68548", Offset = "0xD68548", VA = "0xD68548")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xD69808", Offset = "0xD69808", VA = "0xD69808")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xD6CC5C", Offset = "0xD6CC5C", VA = "0xD6CC5C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63E9D4", Offset = "0x63E9D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63E9D4", Offset = "0x63E9D4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009D")]
		public class Multiplier
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643EBC", Offset = "0x643EBC")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643EF4", Offset = "0x643EF4")]
			public float multiplier;

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xD6D50C", Offset = "0xD6D50C", VA = "0xD6D50C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640FE4", Offset = "0x640FE4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64101C", Offset = "0x64101C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641054", Offset = "0x641054")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64108C", Offset = "0x64108C")]
		public Transform pivot;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6410C4", Offset = "0x6410C4")]
		public Vector3 twistAxis;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6410FC", Offset = "0x6410FC")]
		public float twistWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641134", Offset = "0x641134")]
		public float swingWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64116C", Offset = "0x64116C")]
		public bool rotateOnce;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xD6D220", Offset = "0xD6D220", VA = "0xD6D220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646C10", Offset = "0x646C10")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xD6D26C", Offset = "0xD6D26C", VA = "0xD6D26C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646C48", Offset = "0x646C48")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xD6D2B8", Offset = "0xD6D2B8", VA = "0xD6D2B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646C80", Offset = "0x646C80")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xD6D304", Offset = "0xD6D304", VA = "0xD6D304")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646CB8", Offset = "0x646CB8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xD6D350", Offset = "0xD6D350", VA = "0xD6D350")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646CF0", Offset = "0x646CF0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xD6D39C", Offset = "0xD6D39C", VA = "0xD6D39C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646D28", Offset = "0x646D28")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xD6D3E8", Offset = "0xD6D3E8", VA = "0xD6D3E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646D60", Offset = "0x646D60")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xD6D434", Offset = "0xD6D434", VA = "0xD6D434")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646D98", Offset = "0x646D98")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xD671EC", Offset = "0xD671EC", VA = "0xD671EC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xD65C7C", Offset = "0xD65C7C", VA = "0xD65C7C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xD63428", Offset = "0xD63428", VA = "0xD63428")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xD6D480", Offset = "0xD6D480", VA = "0xD6D480")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63EA34", Offset = "0x63EA34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63EA34", Offset = "0x63EA34")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643F2C", Offset = "0x643F2C")]
			public bool use;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643F64", Offset = "0x643F64")]
			public Vector2 offset;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643F9C", Offset = "0x643F9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643F9C", Offset = "0x643F9C")]
			public float angleOffset;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643FF8", Offset = "0x643FF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643FF8", Offset = "0x643FF8")]
			public float maxAngle;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644050", Offset = "0x644050")]
			public float radius;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644088", Offset = "0x644088")]
			public bool orbit;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6440C0", Offset = "0x6440C0")]
			public bool fixYAxis;

			[Token(Token = "0x17000098")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0xD6DD78", Offset = "0xD6DD78", VA = "0xD6DD78")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600059A")]
				[Address(RVA = "0xD6DDB4", Offset = "0xD6DDB4", VA = "0xD6DDB4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0xD6DEAC", Offset = "0xD6DEAC", VA = "0xD6DEAC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0xD6E580", Offset = "0xD6E580", VA = "0xD6E580")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public class CameraPosition
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6440F8", Offset = "0x6440F8")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644130", Offset = "0x644130")]
			public Vector3 direction;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644168", Offset = "0x644168")]
			public float maxDistance;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6441A0", Offset = "0x6441A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6441A0", Offset = "0x6441A0")]
			public float maxAngle;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6441F8", Offset = "0x6441F8")]
			public bool fixYAxis;

			[Token(Token = "0x600059D")]
			[Address(RVA = "0xD6D834", Offset = "0xD6D834", VA = "0xD6D834")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0xD6DA08", Offset = "0xD6DA08", VA = "0xD6DA08")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0xD6DCEC", Offset = "0xD6DCEC", VA = "0xD6DCEC")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000BD")]
			public class Interaction
			{
				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6452B0", Offset = "0x6452B0")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400057A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6452E8", Offset = "0x6452E8")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000611")]
				[Address(RVA = "0xD6E5A4", Offset = "0xD6E5A4", VA = "0xD6E5A4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x644230", Offset = "0x644230")]
			[SerializeField]
			public string name;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x644268", Offset = "0x644268")]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6442A0", Offset = "0x6442A0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6442D8", Offset = "0x6442D8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644310", Offset = "0x644310")]
			public Interaction[] interactions;

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xD6D694", Offset = "0xD6D694", VA = "0xD6D694")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xD6E594", Offset = "0xD6E594", VA = "0xD6E594")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6411A4", Offset = "0x6411A4")]
		public Range[] ranges;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xD6D514", Offset = "0xD6D514", VA = "0xD6D514")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646DD0", Offset = "0x646DD0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xD6D560", Offset = "0xD6D560", VA = "0xD6D560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646E08", Offset = "0x646E08")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xD6D5AC", Offset = "0xD6D5AC", VA = "0xD6D5AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646E40", Offset = "0x646E40")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xD6D5F8", Offset = "0xD6D5F8", VA = "0xD6D5F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646E78", Offset = "0x646E78")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xD6D644", Offset = "0xD6D644", VA = "0xD6D644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646EB0", Offset = "0x646EB0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xD6D690", Offset = "0xD6D690", VA = "0xD6D690")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xD6BC88", Offset = "0xD6BC88", VA = "0xD6BC88")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xD6D7D4", Offset = "0xD6D7D4", VA = "0xD6D7D4")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class Map
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xE9CB34", Offset = "0xE9CB34", VA = "0xE9CB34")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xE9D07C", Offset = "0xE9D07C", VA = "0xE9D07C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xE9CFF0", Offset = "0xE9CFF0", VA = "0xE9CFF0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xE9CD44", Offset = "0xE9CD44", VA = "0xE9CD44")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xE9C7A4", Offset = "0xE9C7A4", VA = "0xE9C7A4", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646EE8", Offset = "0x646EE8")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xE9CC08", Offset = "0xE9CC08", VA = "0xE9CC08", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE9CC0C", Offset = "0xE9CC0C", VA = "0xE9CC0C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE9CF58", Offset = "0xE9CF58", VA = "0xE9CF58", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xE9CB70", Offset = "0xE9CB70", VA = "0xE9CB70")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xE9CA6C", Offset = "0xE9CA6C", VA = "0xE9CA6C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xE9D0E0", Offset = "0xE9D0E0", VA = "0xE9D0E0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xF77B0C", Offset = "0xF77B0C", VA = "0xF77B0C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xF77BC8", Offset = "0xF77BC8", VA = "0xF77BC8", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xF77E28", Offset = "0xF77E28", VA = "0xF77E28", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xF77FB8", Offset = "0xF77FB8", VA = "0xF77FB8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xF77C24", Offset = "0xF77C24", VA = "0xF77C24")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xF784DC", Offset = "0xF784DC", VA = "0xF784DC")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6411DC", Offset = "0x6411DC")]
		public float weight;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6411F4", Offset = "0x6411F4")]
		public float localRotationWeight;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64120C", Offset = "0x64120C")]
		public float localPositionWeight;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60003D3")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xD717B0", Offset = "0xD717B0", VA = "0xD717B0")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60003D5")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60003D6")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60003D7")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xD717BC", Offset = "0xD717BC", VA = "0xD717BC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xD71810", Offset = "0xD71810", VA = "0xD71810", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xD7184C", Offset = "0xD7184C", VA = "0xD7184C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xD71864", Offset = "0xD71864", VA = "0xD71864")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x63EA94", Offset = "0x63EA94")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000A2")]
		public class Rigidbone
		{
			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xD71F3C", Offset = "0xD71F3C", VA = "0xD71F3C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xD72F50", Offset = "0xD72F50", VA = "0xD72F50")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xD72C98", Offset = "0xD72C98", VA = "0xD72C98")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000A3")]
		public class Child
		{
			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xD720D4", Offset = "0xD720D4", VA = "0xD720D4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xD7312C", Offset = "0xD7312C", VA = "0xD7312C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xD730C8", Offset = "0xD730C8", VA = "0xD730C8")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EC98", Offset = "0x63EC98")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700009A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0xD738C4", Offset = "0xD738C4", VA = "0xD738C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0xD73934", Offset = "0xD73934", VA = "0xD73934", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xD72144", Offset = "0xD72144", VA = "0xD72144")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xD7359C", Offset = "0xD7359C", VA = "0xD7359C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xD735A0", Offset = "0xD735A0", VA = "0xD735A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xD738CC", Offset = "0xD738CC", VA = "0xD738CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641224", Offset = "0x641224")]
		public IK ik;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64125C", Offset = "0x64125C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641294", Offset = "0x641294")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6412CC", Offset = "0x6412CC")]
		public float applyVelocity;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641304", Offset = "0x641304")]
		public float applyAngularVelocity;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000051")]
		private bool isRagdoll
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xD718AC", Offset = "0xD718AC", VA = "0xD718AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		private bool ikUsed
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xD726AC", Offset = "0xD726AC", VA = "0xD726AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD71874", Offset = "0xD71874", VA = "0xD71874")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xD7194C", Offset = "0xD7194C", VA = "0xD7194C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xD71A98", Offset = "0xD71A98", VA = "0xD71A98")]
		public void Start()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD71A24", Offset = "0xD71A24", VA = "0xD71A24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x646F20", Offset = "0x646F20")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD72170", Offset = "0xD72170", VA = "0xD72170")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xD7250C", Offset = "0xD7250C", VA = "0xD7250C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xD725DC", Offset = "0xD725DC", VA = "0xD725DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xD72870", Offset = "0xD72870", VA = "0xD72870")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xD72670", Offset = "0xD72670", VA = "0xD72670")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xD7282C", Offset = "0xD7282C", VA = "0xD7282C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xD72924", Offset = "0xD72924", VA = "0xD72924")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xD728A4", Offset = "0xD728A4", VA = "0xD728A4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xD719A4", Offset = "0xD719A4", VA = "0xD719A4")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xD7254C", Offset = "0xD7254C", VA = "0xD7254C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD73364", Offset = "0xD73364", VA = "0xD73364")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xD734D0", Offset = "0xD734D0", VA = "0xD734D0")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64133C", Offset = "0x64133C")]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64134C", Offset = "0x64134C")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000053")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xD755EC", Offset = "0xD755EC", VA = "0xD755EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000054")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xD75628", Offset = "0xD75628", VA = "0xD75628")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000055")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xD756F8", Offset = "0xD756F8", VA = "0xD756F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646F84", Offset = "0x646F84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xD75248", Offset = "0xD75248", VA = "0xD75248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646F94", Offset = "0x646F94")]
			private set
			{
			}
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xD751F8", Offset = "0xD751F8", VA = "0xD751F8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD75254", Offset = "0xD75254", VA = "0xD75254")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xD7526C", Offset = "0xD7526C", VA = "0xD7526C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xD75504", Offset = "0xD75504", VA = "0xD75504")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD755B4", Offset = "0xD755B4", VA = "0xD755B4")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003F7")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xD75414", Offset = "0xD75414", VA = "0xD75414")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD75700", Offset = "0xD75700", VA = "0xD75700")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD75704", Offset = "0xD75704", VA = "0xD75704")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD75738", Offset = "0xD75738", VA = "0xD75738")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD7581C", Offset = "0xD7581C", VA = "0xD7581C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD75A9C", Offset = "0xD75A9C", VA = "0xD75A9C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD75B58", Offset = "0xD75B58", VA = "0xD75B58")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63EAF8", Offset = "0x63EAF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63EAF8", Offset = "0x63EAF8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64135C", Offset = "0x64135C")]
		public float limit;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641378", Offset = "0x641378")]
		public float twistLimit;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xD75BD0", Offset = "0xD75BD0", VA = "0xD75BD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646FA4", Offset = "0x646FA4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD75C1C", Offset = "0xD75C1C", VA = "0xD75C1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x646FDC", Offset = "0x646FDC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xD75C68", Offset = "0xD75C68", VA = "0xD75C68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x647014", Offset = "0x647014")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xD75CB4", Offset = "0xD75CB4", VA = "0xD75CB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64704C", Offset = "0x64704C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xD75D00", Offset = "0xD75D00", VA = "0xD75D00", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD75DB8", Offset = "0xD75DB8", VA = "0xD75DB8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xD76000", Offset = "0xD76000", VA = "0xD76000")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63EB58", Offset = "0x63EB58")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63EB58", Offset = "0x63EB58")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x641394", Offset = "0x641394")]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD76010", Offset = "0xD76010", VA = "0xD76010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x647084", Offset = "0x647084")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD7605C", Offset = "0xD7605C", VA = "0xD7605C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6470BC", Offset = "0x6470BC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD760A8", Offset = "0xD760A8", VA = "0xD760A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6470F4", Offset = "0x6470F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD760F4", Offset = "0xD760F4", VA = "0xD760F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64712C", Offset = "0x64712C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD76140", Offset = "0xD76140", VA = "0xD76140", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD76168", Offset = "0xD76168", VA = "0xD76168")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD76468", Offset = "0xD76468", VA = "0xD76468")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63EBB8", Offset = "0x63EBB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63EBB8", Offset = "0x63EBB8")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A5")]
		public class ReachCone
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700009C")]
			public Vector3 o
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0xD7895C", Offset = "0xD7895C", VA = "0xD7895C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public Vector3 a
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0xD789A4", Offset = "0xD789A4", VA = "0xD789A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009E")]
			public Vector3 b
			{
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0xD789F0", Offset = "0xD789F0", VA = "0xD789F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009F")]
			public Vector3 c
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0xD78A3C", Offset = "0xD78A3C", VA = "0xD78A3C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A0")]
			public bool isValid
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0xD77898", Offset = "0xD77898", VA = "0xD77898")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xD78040", Offset = "0xD78040", VA = "0xD78040")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xD781F0", Offset = "0xD781F0", VA = "0xD781F0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public class LimitPoint
		{
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xD778A8", Offset = "0xD778A8", VA = "0xD778A8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6413A4", Offset = "0x6413A4")]
		public float twistLimit;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6413C0", Offset = "0x6413C0")]
		public int smoothIterations;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x6413D8", Offset = "0x6413D8")]
		public LimitPoint[] points;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x641410", Offset = "0x641410")]
		public Vector3[] P;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x641448", Offset = "0x641448")]
		public ReachCone[] reachCones;

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD764F0", Offset = "0xD764F0", VA = "0xD764F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x647164", Offset = "0x647164")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD7653C", Offset = "0xD7653C", VA = "0xD7653C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64719C", Offset = "0x64719C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xD76588", Offset = "0xD76588", VA = "0xD76588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6471D4", Offset = "0x6471D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xD765D4", Offset = "0xD765D4", VA = "0xD765D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64720C", Offset = "0x64720C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD76620", Offset = "0xD76620", VA = "0xD76620")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD76C5C", Offset = "0xD76C5C", VA = "0xD76C5C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD76D58", Offset = "0xD76D58", VA = "0xD76D58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD77424", Offset = "0xD77424", VA = "0xD77424")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD766C4", Offset = "0xD766C4", VA = "0xD766C4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD7792C", Offset = "0xD7792C", VA = "0xD7792C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD783B0", Offset = "0xD783B0", VA = "0xD783B0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD783F4", Offset = "0xD783F4", VA = "0xD783F4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD7853C", Offset = "0xD7853C", VA = "0xD7853C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD770B8", Offset = "0xD770B8", VA = "0xD770B8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD786CC", Offset = "0xD786CC", VA = "0xD786CC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xD788F8", Offset = "0xD788F8", VA = "0xD788F8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x63EC18", Offset = "0x63EC18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63EC18", Offset = "0x63EC18")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641480", Offset = "0x641480")]
		public float twistLimit;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64149C", Offset = "0x64149C")]
		public AnimationCurve spline;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xD78A88", Offset = "0xD78A88", VA = "0xD78A88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x647244", Offset = "0x647244")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xD78AD4", Offset = "0xD78AD4", VA = "0xD78AD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64727C", Offset = "0x64727C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xD78B20", Offset = "0xD78B20", VA = "0xD78B20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6472B4", Offset = "0x6472B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xD78B6C", Offset = "0xD78B6C", VA = "0xD78B6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6472EC", Offset = "0x6472EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xD78BB8", Offset = "0xD78BB8", VA = "0xD78BB8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xD78BF0", Offset = "0xD78BF0", VA = "0xD78BF0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xD78CA8", Offset = "0xD78CA8", VA = "0xD78CA8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xD78FE0", Offset = "0xD78FE0", VA = "0xD78FE0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63ECA8", Offset = "0x63ECA8")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000A1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0xE8BC88", Offset = "0xE8BC88", VA = "0xE8BC88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0xE8BCF8", Offset = "0xE8BCF8", VA = "0xE8BCF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xE8BA14", Offset = "0xE8BA14", VA = "0xE8BA14")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xE8BB0C", Offset = "0xE8BB0C", VA = "0xE8BB0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xE8BB10", Offset = "0xE8BB10", VA = "0xE8BB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xE8BC90", Offset = "0xE8BC90", VA = "0xE8BC90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6414D4", Offset = "0x6414D4")]
		public AimIK ik;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64150C", Offset = "0x64150C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64150C", Offset = "0x64150C")]
		public float weight;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x641560", Offset = "0x641560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641560", Offset = "0x641560")]
		public Transform target;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6415C0", Offset = "0x6415C0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6415F8", Offset = "0x6415F8")]
		public float weightSmoothTime;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x641630", Offset = "0x641630")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641630", Offset = "0x641630")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641690", Offset = "0x641690")]
		public float maxRadiansDelta;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6416C8", Offset = "0x6416C8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641700", Offset = "0x641700")]
		public float slerpSpeed;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641738", Offset = "0x641738")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641770", Offset = "0x641770")]
		public float minDistance;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6417A8", Offset = "0x6417A8")]
		public Vector3 offset;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6417E0", Offset = "0x6417E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6417E0", Offset = "0x6417E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6417E0", Offset = "0x6417E0")]
		public float maxRootAngle;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64185C", Offset = "0x64185C")]
		public bool turnToTarget;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641894", Offset = "0x641894")]
		public float turnToTargetTime;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6418CC", Offset = "0x6418CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6418CC", Offset = "0x6418CC")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64192C", Offset = "0x64192C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000056")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xE8A928", Offset = "0xE8A928", VA = "0xE8A928")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xE8A7F8", Offset = "0xE8A7F8", VA = "0xE8A7F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xE8AAA0", Offset = "0xE8AAA0", VA = "0xE8AAA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xE8B3D0", Offset = "0xE8B3D0", VA = "0xE8B3D0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xE8B59C", Offset = "0xE8B59C", VA = "0xE8B59C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xE8B9A0", Offset = "0xE8B9A0", VA = "0xE8B9A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x647324", Offset = "0x647324")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xE8BA40", Offset = "0xE8BA40", VA = "0xE8BA40")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A8")]
		public class Pose
		{
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xE8C04C", Offset = "0xE8C04C", VA = "0xE8C04C")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xE8C3E0", Offset = "0xE8C3E0", VA = "0xE8C3E0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xE8C450", Offset = "0xE8C450", VA = "0xE8C450")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xE8BEEC", Offset = "0xE8BEEC", VA = "0xE8BEEC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xE8C2E8", Offset = "0xE8C2E8", VA = "0xE8C2E8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xE8C3E8", Offset = "0xE8C3E8", VA = "0xE8C3E8")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BE")]
			public class EffectorLink
			{
				[Token(Token = "0x400057B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645320", Offset = "0x645320")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400057C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645358", Offset = "0x645358")]
				public float weight;

				[Token(Token = "0x6000612")]
				[Address(RVA = "0xE8CB4C", Offset = "0xE8CB4C", VA = "0xE8CB4C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644348", Offset = "0x644348")]
			public Transform transform;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644380", Offset = "0x644380")]
			public Transform relativeTo;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6443B8", Offset = "0x6443B8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6443F0", Offset = "0x6443F0")]
			public float verticalWeight;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644428", Offset = "0x644428")]
			public float horizontalWeight;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644460", Offset = "0x644460")]
			public float speed;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xE8C5CC", Offset = "0xE8C5CC", VA = "0xE8C5CC")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xE8CB24", Offset = "0xE8CB24", VA = "0xE8CB24")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xE8CB34", Offset = "0xE8CB34", VA = "0xE8CB34")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641964", Offset = "0x641964")]
		public Body[] bodies;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xE8C46C", Offset = "0xE8C46C", VA = "0xE8C46C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xE8CB1C", Offset = "0xE8CB1C", VA = "0xE8CB1C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64199C", Offset = "0x64199C")]
		public float tiltSpeed;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6419D4", Offset = "0x6419D4")]
		public float tiltSensitivity;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A0C", Offset = "0x641A0C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A44", Offset = "0x641A44")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xE8E884", Offset = "0xE8E884", VA = "0xE8E884", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xE8E8D4", Offset = "0xE8E8D4", VA = "0xE8E8D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xE8EB40", Offset = "0xE8EB40", VA = "0xE8EB40")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x63EC78", Offset = "0x63EC78")]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xE8F744", Offset = "0xE8F744", VA = "0xE8F744")]
		private void Start()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xE8F7F4", Offset = "0xE8F7F4", VA = "0xE8F7F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xE8F900", Offset = "0xE8F900", VA = "0xE8F900")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644498", Offset = "0x644498")]
			public string name;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6444D0", Offset = "0x6444D0")]
			public Collider collider;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644508", Offset = "0x644508")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644554", Offset = "0x644554")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644564", Offset = "0x644564")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644574", Offset = "0x644574")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644584", Offset = "0x644584")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A3")]
			public bool inProgress
			{
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0xF785E0", Offset = "0xF785E0", VA = "0xF785E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A4")]
			protected float crossFader
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0xF78C18", Offset = "0xF78C18", VA = "0xF78C18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647830", Offset = "0x647830")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0xF78C20", Offset = "0xF78C20", VA = "0xF78C20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647840", Offset = "0x647840")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected float timer
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0xF78C10", Offset = "0xF78C10", VA = "0xF78C10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647850", Offset = "0x647850")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0xF78C28", Offset = "0xF78C28", VA = "0xF78C28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647860", Offset = "0x647860")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 force
			{
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0xF78C30", Offset = "0xF78C30", VA = "0xF78C30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647870", Offset = "0x647870")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0xF78C3C", Offset = "0xF78C3C", VA = "0xF78C3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647880", Offset = "0x647880")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 point
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0xF78C48", Offset = "0xF78C48", VA = "0xF78C48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647890", Offset = "0x647890")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0xF78C54", Offset = "0xF78C54", VA = "0xF78C54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6478A0", Offset = "0x6478A0")]
				private set
				{
				}
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xF78ADC", Offset = "0xF78ADC", VA = "0xF78ADC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xF78728", Offset = "0xF78728", VA = "0xF78728")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005D1")]
			protected abstract float GetLength();

			[Token(Token = "0x60005D2")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005D3")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xF78C60", Offset = "0xF78C60", VA = "0xF78C60")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000BF")]
			public class EffectorLink
			{
				[Token(Token = "0x400057D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645390", Offset = "0x645390")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400057E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6453C8", Offset = "0x6453C8")]
				public float weight;

				[Token(Token = "0x400057F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000613")]
				[Address(RVA = "0xF797B4", Offset = "0xF797B4", VA = "0xF797B4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000614")]
				[Address(RVA = "0xF79550", Offset = "0xF79550", VA = "0xF79550")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000615")]
				[Address(RVA = "0xF79B20", Offset = "0xF79B20", VA = "0xF79B20")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644594", Offset = "0x644594")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6445CC", Offset = "0x6445CC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644604", Offset = "0x644604")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xF792C8", Offset = "0xF792C8", VA = "0xF792C8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xF794C8", Offset = "0xF794C8", VA = "0xF794C8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xF79564", Offset = "0xF79564", VA = "0xF79564", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xF798FC", Offset = "0xF798FC", VA = "0xF798FC")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C0")]
			public class BoneLink
			{
				[Token(Token = "0x4000581")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645400", Offset = "0x645400")]
				public Transform bone;

				[Token(Token = "0x4000582")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645438", Offset = "0x645438")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645438", Offset = "0x645438")]
				public float weight;

				[Token(Token = "0x4000583")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000584")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000616")]
				[Address(RVA = "0xF790A0", Offset = "0xF790A0", VA = "0xF790A0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000617")]
				[Address(RVA = "0xF78DE0", Offset = "0xF78DE0", VA = "0xF78DE0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000618")]
				[Address(RVA = "0xF79240", Offset = "0xF79240", VA = "0xF79240")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64463C", Offset = "0x64463C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644674", Offset = "0x644674")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xF78C74", Offset = "0xF78C74", VA = "0xF78C74", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xF78D50", Offset = "0xF78D50", VA = "0xF78D50", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xF78DFC", Offset = "0xF78DFC", VA = "0xF78DFC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xF7922C", Offset = "0xF7922C", VA = "0xF7922C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A7C", Offset = "0x641A7C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641AB4", Offset = "0x641AB4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000057")]
		public bool inProgress
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xF784E4", Offset = "0xF784E4", VA = "0xF784E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xF785F4", Offset = "0xF785F4", VA = "0xF785F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xF78874", Offset = "0xF78874", VA = "0xF78874")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xF78C08", Offset = "0xF78C08", VA = "0xF78C08")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public abstract class Offset
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6446AC", Offset = "0x6446AC")]
			public string name;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6446E4", Offset = "0x6446E4")]
			public Collider collider;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64471C", Offset = "0x64471C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644768", Offset = "0x644768")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644778", Offset = "0x644778")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644788", Offset = "0x644788")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644798", Offset = "0x644798")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A8")]
			protected float crossFader
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0xF7A158", Offset = "0xF7A158", VA = "0xF7A158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6478B0", Offset = "0x6478B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0xF7A160", Offset = "0xF7A160", VA = "0xF7A160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6478C0", Offset = "0x6478C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected float timer
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0xF7A168", Offset = "0xF7A168", VA = "0xF7A168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6478D0", Offset = "0x6478D0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0xF7A170", Offset = "0xF7A170", VA = "0xF7A170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6478E0", Offset = "0x6478E0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected Vector3 force
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0xF7A178", Offset = "0xF7A178", VA = "0xF7A178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6478F0", Offset = "0x6478F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0xF7A184", Offset = "0xF7A184", VA = "0xF7A184")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647900", Offset = "0x647900")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			protected Vector3 point
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0xF7A190", Offset = "0xF7A190", VA = "0xF7A190")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647910", Offset = "0x647910")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E4")]
				[Address(RVA = "0xF7A19C", Offset = "0xF7A19C", VA = "0xF7A19C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647920", Offset = "0x647920")]
				private set
				{
				}
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xF7A010", Offset = "0xF7A010", VA = "0xF7A010")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xF79C4C", Offset = "0xF79C4C", VA = "0xF79C4C")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005E7")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x60005E8")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005E9")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xF7A1A8", Offset = "0xF7A1A8", VA = "0xF7A1A8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AE")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C1")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000585")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64548C", Offset = "0x64548C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000586")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6454C4", Offset = "0x6454C4")]
				public float weight;

				[Token(Token = "0x4000587")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000588")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000619")]
				[Address(RVA = "0xF7A7E8", Offset = "0xF7A7E8", VA = "0xF7A7E8")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600061A")]
				[Address(RVA = "0xF7A52C", Offset = "0xF7A52C", VA = "0xF7A52C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600061B")]
				[Address(RVA = "0xF7A938", Offset = "0xF7A938", VA = "0xF7A938")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6447A8", Offset = "0x6447A8")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6447E0", Offset = "0x6447E0")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644818", Offset = "0x644818")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xF7A1BC", Offset = "0xF7A1BC", VA = "0xF7A1BC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xF7A4A4", Offset = "0xF7A4A4", VA = "0xF7A4A4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xF7A540", Offset = "0xF7A540", VA = "0xF7A540", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xF7A91C", Offset = "0xF7A91C", VA = "0xF7A91C")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C2")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000589")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6454FC", Offset = "0x6454FC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400058A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645534", Offset = "0x645534")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645534", Offset = "0x645534")]
				public float weight;

				[Token(Token = "0x400058B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400058C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600061C")]
				[Address(RVA = "0xF7AEB4", Offset = "0xF7AEB4", VA = "0xF7AEB4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600061D")]
				[Address(RVA = "0xF7AB34", Offset = "0xF7AB34", VA = "0xF7AB34")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600061E")]
				[Address(RVA = "0xF7B02C", Offset = "0xF7B02C", VA = "0xF7B02C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644850", Offset = "0x644850")]
			public int curveIndex;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644888", Offset = "0x644888")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xF7A940", Offset = "0xF7A940", VA = "0xF7A940", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xF7AAA4", Offset = "0xF7AAA4", VA = "0xF7AAA4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xF7AB50", Offset = "0xF7AB50", VA = "0xF7AB50", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xF7B018", Offset = "0xF7B018", VA = "0xF7B018")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641AEC", Offset = "0x641AEC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B24", Offset = "0x641B24")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xF79B28", Offset = "0xF79B28", VA = "0xF79B28", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xF79DA0", Offset = "0xF79DA0", VA = "0xF79DA0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xF7A150", Offset = "0xF7A150", VA = "0xF7A150")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000C3")]
			public class EffectorLink
			{
				[Token(Token = "0x400058D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645588", Offset = "0x645588")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400058E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6455C0", Offset = "0x6455C0")]
				public float weight;

				[Token(Token = "0x600061F")]
				[Address(RVA = "0xD61A40", Offset = "0xD61A40", VA = "0xD61A40")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6448C0", Offset = "0x6448C0")]
			public Transform transform;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6448F8", Offset = "0x6448F8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644930", Offset = "0x644930")]
			public float speed;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644968", Offset = "0x644968")]
			public float acceleration;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6449A0", Offset = "0x6449A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6449A0", Offset = "0x6449A0")]
			public float matchVelocity;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6449F4", Offset = "0x6449F4")]
			public float gravity;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xD61364", Offset = "0xD61364", VA = "0xD61364")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xD61550", Offset = "0xD61550", VA = "0xD61550")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xD61A24", Offset = "0xD61A24", VA = "0xD61A24")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B5C", Offset = "0x641B5C")]
		public Body[] bodies;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B94", Offset = "0x641B94")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xD612D4", Offset = "0xD612D4", VA = "0xD612D4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xD61454", Offset = "0xD61454", VA = "0xD61454", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xD61A04", Offset = "0xD61A04", VA = "0xD61A04")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x641BCC", Offset = "0x641BCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641BCC", Offset = "0x641BCC")]
		public Transform target;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641C2C", Offset = "0x641C2C")]
		public float weight;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641C44", Offset = "0x641C44")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641C7C", Offset = "0x641C7C")]
		public float weightSmoothTime;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x641CB4", Offset = "0x641CB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641CB4", Offset = "0x641CB4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D14", Offset = "0x641D14")]
		public float maxRadiansDelta;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D4C", Offset = "0x641D4C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D84", Offset = "0x641D84")]
		public float slerpSpeed;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641DBC", Offset = "0x641DBC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641DF4", Offset = "0x641DF4")]
		public float minDistance;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x641E2C", Offset = "0x641E2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641E2C", Offset = "0x641E2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641E2C", Offset = "0x641E2C")]
		public float maxRootAngle;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000058")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xD6E9F8", Offset = "0xD6E9F8", VA = "0xD6E9F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xD6E8EC", Offset = "0xD6E8EC", VA = "0xD6E8EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xD6EB70", Offset = "0xD6EB70", VA = "0xD6EB70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD6F3A4", Offset = "0xD6F3A4", VA = "0xD6F3A4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xD6F570", Offset = "0xD6F570", VA = "0xD6F570")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xD6F920", Offset = "0xD6F920", VA = "0xD6F920")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644A2C", Offset = "0x644A2C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644A64", Offset = "0x644A64")]
			public float spring;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644A9C", Offset = "0x644A9C")]
			public bool x;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644AD4", Offset = "0x644AD4")]
			public bool y;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644B0C", Offset = "0x644B0C")]
			public bool z;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644B44", Offset = "0x644B44")]
			public float minX;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644B7C", Offset = "0x644B7C")]
			public float maxX;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644BB4", Offset = "0x644BB4")]
			public float minY;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644BEC", Offset = "0x644BEC")]
			public float maxY;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644C24", Offset = "0x644C24")]
			public float minZ;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644C5C", Offset = "0x644C5C")]
			public float maxZ;

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xD6FD44", Offset = "0xD6FD44", VA = "0xD6FD44")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xD70350", Offset = "0xD70350", VA = "0xD70350")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xD70380", Offset = "0xD70380", VA = "0xD70380")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xD70458", Offset = "0xD70458", VA = "0xD70458")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63ECB8", Offset = "0x63ECB8")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0xD702D8", Offset = "0xD702D8", VA = "0xD702D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0xD70348", Offset = "0xD70348", VA = "0xD70348", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xD6FC0C", Offset = "0xD6FC0C", VA = "0xD6FC0C")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xD70128", Offset = "0xD70128", VA = "0xD70128", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xD7012C", Offset = "0xD7012C", VA = "0xD7012C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xD702E0", Offset = "0xD702E0", VA = "0xD702E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641EA8", Offset = "0x641EA8")]
		public float weight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641EE0", Offset = "0x641EE0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000059")]
		protected float deltaTime
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xD61524", Offset = "0xD61524", VA = "0xD61524")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000448")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xD6FB6C", Offset = "0xD6FB6C", VA = "0xD6FB6C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xD6FB98", Offset = "0xD6FB98", VA = "0xD6FB98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x647388", Offset = "0x647388")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xD6FC38", Offset = "0xD6FC38", VA = "0xD6FC38")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xD61918", Offset = "0xD61918", VA = "0xD61918")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xD6FFC8", Offset = "0xD6FFC8", VA = "0xD6FFC8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xD61A14", Offset = "0xD61A14", VA = "0xD61A14")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63ECC8", Offset = "0x63ECC8")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000603")]
				[Address(RVA = "0xD70984", Offset = "0xD70984", VA = "0xD70984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000605")]
				[Address(RVA = "0xD709F4", Offset = "0xD709F4", VA = "0xD709F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0xD7052C", Offset = "0xD7052C", VA = "0xD7052C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xD707D4", Offset = "0xD707D4", VA = "0xD707D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0xD707D8", Offset = "0xD707D8", VA = "0xD707D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xD7098C", Offset = "0xD7098C", VA = "0xD7098C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F18", Offset = "0x641F18")]
		public float weight;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F50", Offset = "0x641F50")]
		public VRIK ik;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005A")]
		protected float deltaTime
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xD70460", Offset = "0xD70460", VA = "0xD70460")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000450")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xD7048C", Offset = "0xD7048C", VA = "0xD7048C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xD704B8", Offset = "0xD704B8", VA = "0xD704B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6473EC", Offset = "0x6473EC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xD70558", Offset = "0xD70558", VA = "0xD70558")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xD70664", Offset = "0xD70664", VA = "0xD70664", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xD707C4", Offset = "0xD707C4", VA = "0xD707C4")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class EffectorLink
		{
			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xD70B14", Offset = "0xD70B14", VA = "0xD70B14")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0xD71050", Offset = "0xD71050", VA = "0xD71050")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD709FC", Offset = "0xD709FC", VA = "0xD709FC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xD70F08", Offset = "0xD70F08", VA = "0xD70F08")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xD70FF0", Offset = "0xD70FF0", VA = "0xD70FF0")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000C4")]
			public class EffectorLink
			{
				[Token(Token = "0x400058F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6455F8", Offset = "0x6455F8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000590")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645630", Offset = "0x645630")]
				public float weight;

				[Token(Token = "0x6000620")]
				[Address(RVA = "0xD717A8", Offset = "0xD717A8", VA = "0xD717A8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644C94", Offset = "0x644C94")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644CCC", Offset = "0x644CCC")]
			public Transform raycastTo;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644D04", Offset = "0x644D04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644D04", Offset = "0x644D04")]
			public float raycastRadius;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644D58", Offset = "0x644D58")]
			public EffectorLink[] effectors;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644D90", Offset = "0x644D90")]
			public float smoothTimeIn;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644DC8", Offset = "0x644DC8")]
			public float smoothTimeOut;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644E00", Offset = "0x644E00")]
			public LayerMask layers;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000608")]
			[Address(RVA = "0xD7110C", Offset = "0xD7110C", VA = "0xD7110C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0xD71334", Offset = "0xD71334", VA = "0xD71334")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0xD71518", Offset = "0xD71518", VA = "0xD71518")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0xD7178C", Offset = "0xD7178C", VA = "0xD7178C")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F88", Offset = "0x641F88")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xD71058", Offset = "0xD71058", VA = "0xD71058", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xD71324", Offset = "0xD71324", VA = "0xD71324")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000C5")]
			public class EffectorLink
			{
				[Token(Token = "0x4000591")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645668", Offset = "0x645668")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000592")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6456A0", Offset = "0x6456A0")]
				public float weight;

				[Token(Token = "0x6000621")]
				[Address(RVA = "0xD751F0", Offset = "0xD751F0", VA = "0xD751F0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644E38", Offset = "0x644E38")]
			public Vector3 offset;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644E70", Offset = "0x644E70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644E70", Offset = "0x644E70")]
			public float additivity;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644EC4", Offset = "0x644EC4")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644EFC", Offset = "0x644EFC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600060C")]
			[Address(RVA = "0xD73BA0", Offset = "0xD73BA0", VA = "0xD73BA0")]
			public void Start()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xD74910", Offset = "0xD74910", VA = "0xD74910")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xD751D8", Offset = "0xD751D8", VA = "0xD751D8")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public enum Handedness
		{
			[Token(Token = "0x400054B")]
			Right,
			[Token(Token = "0x400054C")]
			Left
		}

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641FC0", Offset = "0x641FC0")]
		public AimIK aimIK;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641FF8", Offset = "0x641FF8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642030", Offset = "0x642030")]
		public Handedness handedness;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642068", Offset = "0x642068")]
		public bool twoHanded;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6420A0", Offset = "0x6420A0")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6420D8", Offset = "0x6420D8")]
		public float magnitudeRandom;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642110", Offset = "0x642110")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642148", Offset = "0x642148")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642180", Offset = "0x642180")]
		public float blendTime;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6421B8", Offset = "0x6421B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6421B8", Offset = "0x6421B8")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x642208", Offset = "0x642208")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700005B")]
		public bool isFinished
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xD7393C", Offset = "0xD7393C", VA = "0xD7393C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0xD74BF8", Offset = "0xD74BF8", VA = "0xD74BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xD74C58", Offset = "0xD74C58", VA = "0xD74C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xD74BA0", Offset = "0xD74BA0", VA = "0xD74BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xD74BCC", Offset = "0xD74BCC", VA = "0xD74BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xD7396C", Offset = "0xD7396C", VA = "0xD7396C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD73998", Offset = "0xD73998", VA = "0xD73998")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xD73C50", Offset = "0xD73C50", VA = "0xD73C50", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xD74CB8", Offset = "0xD74CB8", VA = "0xD74CB8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xD74E54", Offset = "0xD74E54", VA = "0xD74E54")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xD74EB0", Offset = "0xD74EB0", VA = "0xD74EB0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xD75124", Offset = "0xD75124", VA = "0xD75124")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642218", Offset = "0x642218")]
		public float weight;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642250", Offset = "0x642250")]
		public float offset;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xD78FEC", Offset = "0xD78FEC", VA = "0xD78FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xD79128", Offset = "0xD79128", VA = "0xD79128")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xD79240", Offset = "0xD79240", VA = "0xD79240")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xD797D8", Offset = "0xD797D8", VA = "0xD797D8")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xD7983C", Offset = "0xD7983C", VA = "0xD7983C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xD7999C", Offset = "0xD7999C", VA = "0xD7999C")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public class Settings
		{
			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644F34", Offset = "0x644F34")]
			public float scaleMlp;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644F6C", Offset = "0x644F6C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644FA4", Offset = "0x644FA4")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644FDC", Offset = "0x644FDC")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645014", Offset = "0x645014")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64504C", Offset = "0x64504C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645084", Offset = "0x645084")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6450BC", Offset = "0x6450BC")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6450F4", Offset = "0x6450F4")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64512C", Offset = "0x64512C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64512C", Offset = "0x64512C")]
			public Vector3 headOffset;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64517C", Offset = "0x64517C")]
			public Vector3 handOffset;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6451B4", Offset = "0x6451B4")]
			public float footForwardOffset;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6451EC", Offset = "0x6451EC")]
			public float footInwardOffset;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645224", Offset = "0x645224")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645224", Offset = "0x645224")]
			public float footHeadingOffset;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645280", Offset = "0x645280")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645298", Offset = "0x645298")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xD7FDD4", Offset = "0xD7FDD4", VA = "0xD7FDD4")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B9")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000C6")]
			public class Target
			{
				[Token(Token = "0x4000593")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000594")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000595")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000622")]
				[Address(RVA = "0xD7EAA8", Offset = "0xD7EAA8", VA = "0xD7EAA8")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000623")]
				[Address(RVA = "0xD7F8E4", Offset = "0xD7F8E4", VA = "0xD7F8E4")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0xD7DE94", Offset = "0xD7DE94", VA = "0xD7DE94")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xD7C198", Offset = "0xD7C198", VA = "0xD7C198")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xD7C390", Offset = "0xD7C390", VA = "0xD7C390")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xD7DE9C", Offset = "0xD7DE9C", VA = "0xD7DE9C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xD7EB9C", Offset = "0xD7EB9C", VA = "0xD7EB9C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xD7F988", Offset = "0xD7F988", VA = "0xD7F988")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xD7FECC", Offset = "0xD7FECC", VA = "0xD7FECC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xD7FF24", Offset = "0xD7FF24", VA = "0xD7FF24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xD7FF70", Offset = "0xD7FF70", VA = "0xD7FF70")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xD80130", Offset = "0xD80130", VA = "0xD80130")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642288", Offset = "0x642288")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000060")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0xD7EB90", Offset = "0xD7EB90", VA = "0xD7EB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647450", Offset = "0x647450")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0xD80148", Offset = "0xD80148", VA = "0xD80148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647460", Offset = "0x647460")]
			private set
			{
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xD80154", Offset = "0xD80154", VA = "0xD80154")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xD7E804", Offset = "0xD7E804", VA = "0xD7E804")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xD7FC04", Offset = "0xD7FC04", VA = "0xD7FC04")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xD80298", Offset = "0xD80298", VA = "0xD80298")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xD80968", Offset = "0xD80968", VA = "0xD80968")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xD80AC8", Offset = "0xD80AC8", VA = "0xD80AC8")]
		public VRIKRootController()
		{
		}
	}
}
