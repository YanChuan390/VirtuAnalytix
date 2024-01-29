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
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
internal class LabelEffect
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enabled;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Color color;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector2 distance;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int padding;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1F2B960", Offset = "0x1F2B960", VA = "0x1F2B960")]
	internal LabelEffect(bool enabled, Color color, int padding)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1F2BA2C", Offset = "0x1F2BA2C", VA = "0x1F2BA2C")]
	internal LabelEffect(bool enabled, Color color, Vector2 distance)
	{
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public enum Axis
	{
		[Token(Token = "0x4000006")]
		X,
		[Token(Token = "0x4000007")]
		Y,
		[Token(Token = "0x4000008")]
		Z
	}
	[Token(Token = "0x2000004")]
	public class AxisTools
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1F377EC", Offset = "0x1F377EC", VA = "0x1F377EC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1F378A4", Offset = "0x1F378A4", VA = "0x1F378A4")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1F37950", Offset = "0x1F37950", VA = "0x1F37950")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1F37B34", Offset = "0x1F37B34", VA = "0x1F37B34")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1F37A6C", Offset = "0x1F37A6C", VA = "0x1F37A6C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1F37C50", Offset = "0x1F37C50", VA = "0x1F37C50")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1F37E7C", Offset = "0x1F37E7C", VA = "0x1F37E7C")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1F38144", Offset = "0x1F38144", VA = "0x1F38144")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000001")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1F37ED0", Offset = "0x1F37ED0", VA = "0x1F37ED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1F381BC", Offset = "0x1F381BC", VA = "0x1F381BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1F37E84", Offset = "0x1F37E84", VA = "0x1F37E84")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public enum BoneType
		{
			[Token(Token = "0x4000468")]
			Unassigned,
			[Token(Token = "0x4000469")]
			Spine,
			[Token(Token = "0x400046A")]
			Head,
			[Token(Token = "0x400046B")]
			Arm,
			[Token(Token = "0x400046C")]
			Leg,
			[Token(Token = "0x400046D")]
			Tail,
			[Token(Token = "0x400046E")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public enum BoneSide
		{
			[Token(Token = "0x4000470")]
			Center,
			[Token(Token = "0x4000471")]
			Left,
			[Token(Token = "0x4000472")]
			Right
		}

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1F38430", Offset = "0x1F38430", VA = "0x1F38430")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1F38730", Offset = "0x1F38730", VA = "0x1F38730")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1F38980", Offset = "0x1F38980", VA = "0x1F38980")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1F38A04", Offset = "0x1F38A04", VA = "0x1F38A04")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1F38AB0", Offset = "0x1F38AB0", VA = "0x1F38AB0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1F385E0", Offset = "0x1F385E0", VA = "0x1F385E0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1F388E0", Offset = "0x1F388E0", VA = "0x1F388E0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1F392F0", Offset = "0x1F392F0", VA = "0x1F392F0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1F39108", Offset = "0x1F39108", VA = "0x1F39108")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1F391FC", Offset = "0x1F391FC", VA = "0x1F391FC")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1F38CD0", Offset = "0x1F38CD0", VA = "0x1F38CD0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1F38D84", Offset = "0x1F38D84", VA = "0x1F38D84")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1F38E38", Offset = "0x1F38E38", VA = "0x1F38E38")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1F38EEC", Offset = "0x1F38EEC", VA = "0x1F38EEC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1F38FA0", Offset = "0x1F38FA0", VA = "0x1F38FA0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1F39054", Offset = "0x1F39054", VA = "0x1F39054")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1F39504", Offset = "0x1F39504", VA = "0x1F39504")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1F38BE4", Offset = "0x1F38BE4", VA = "0x1F38BE4")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1F39474", Offset = "0x1F39474", VA = "0x1F39474")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1F39574", Offset = "0x1F39574", VA = "0x1F39574")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1F3964C", Offset = "0x1F3964C", VA = "0x1F3964C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1F393F8", Offset = "0x1F393F8", VA = "0x1F393F8")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1F39380", Offset = "0x1F39380", VA = "0x1F39380")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class BipedReferences
	{
		[Token(Token = "0x2000087")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000AB")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0x1F3E5DC", Offset = "0x1F3E5DC", VA = "0x1F3E5DC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1F3E5C8", Offset = "0x1F3E5C8", VA = "0x1F3E5C8")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000003")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1F3B1C0", Offset = "0x1F3B1C0", VA = "0x1F3B1C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool isEmpty
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1F3B5AC", Offset = "0x1F3B5AC", VA = "0x1F3B5AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1F3B5BC", Offset = "0x1F3B5BC", VA = "0x1F3B5BC", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1F3B9E8", Offset = "0x1F3B9E8", VA = "0x1F3B9E8", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1F3BE20", Offset = "0x1F3BE20", VA = "0x1F3BE20")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1F3C430", Offset = "0x1F3C430", VA = "0x1F3C430")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1F3C06C", Offset = "0x1F3C06C", VA = "0x1F3C06C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1F3CBE0", Offset = "0x1F3CBE0", VA = "0x1F3CBE0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1F3CCD4", Offset = "0x1F3CCD4", VA = "0x1F3CCD4")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1F3D22C", Offset = "0x1F3D22C", VA = "0x1F3D22C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1F3D030", Offset = "0x1F3D030", VA = "0x1F3D030")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1F3CEA8", Offset = "0x1F3CEA8", VA = "0x1F3CEA8")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1F3CD74", Offset = "0x1F3CD74", VA = "0x1F3CD74")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1F3D134", Offset = "0x1F3D134", VA = "0x1F3D134")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1F3D328", Offset = "0x1F3D328", VA = "0x1F3D328")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1F3DDC8", Offset = "0x1F3DDC8", VA = "0x1F3DDC8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1F3D8AC", Offset = "0x1F3D8AC", VA = "0x1F3D8AC")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1F3E0BC", Offset = "0x1F3E0BC", VA = "0x1F3E0BC")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1F3DBEC", Offset = "0x1F3DBEC", VA = "0x1F3DBEC")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1F3E0C4", Offset = "0x1F3E0C4", VA = "0x1F3E0C4")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1F3E0CC", Offset = "0x1F3E0CC", VA = "0x1F3E0CC")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1F3E28C", Offset = "0x1F3E28C", VA = "0x1F3E28C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1F3E4A4", Offset = "0x1F3E4A4", VA = "0x1F3E4A4")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1F3BFFC", Offset = "0x1F3BFFC", VA = "0x1F3BFFC")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1F3E5E4", Offset = "0x1F3E5E4", VA = "0x1F3E5E4")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1F3E5EC", Offset = "0x1F3E5EC", VA = "0x1F3E5EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1F3E72C", Offset = "0x1F3E72C", VA = "0x1F3E72C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class Hierarchy
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x25C6258", Offset = "0x25C6258", VA = "0x25C6258")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x25C6458", Offset = "0x25C6458", VA = "0x25C6458")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x25C62F0", Offset = "0x25C62F0", VA = "0x25C62F0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x25C657C", Offset = "0x25C657C", VA = "0x25C657C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x25C66A0", Offset = "0x25C66A0", VA = "0x25C66A0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x25C6948", Offset = "0x25C6948", VA = "0x25C6948")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x25C6A64", Offset = "0x25C6A64", VA = "0x25C6A64")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x25C6BEC", Offset = "0x25C6BEC", VA = "0x25C6BEC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x25C6F80", Offset = "0x25C6F80", VA = "0x25C6F80")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x25C6D6C", Offset = "0x25C6D6C", VA = "0x25C6D6C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x25C7120", Offset = "0x25C7120", VA = "0x25C7120")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x25C7128", Offset = "0x25C7128", VA = "0x25C7128")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x25C7198", Offset = "0x25C7198", VA = "0x25C7198")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000036")]
		None,
		[Token(Token = "0x4000037")]
		InOutCubic,
		[Token(Token = "0x4000038")]
		InOutQuintic,
		[Token(Token = "0x4000039")]
		InOutSine,
		[Token(Token = "0x400003A")]
		InQuintic,
		[Token(Token = "0x400003B")]
		InQuartic,
		[Token(Token = "0x400003C")]
		InCubic,
		[Token(Token = "0x400003D")]
		InQuadratic,
		[Token(Token = "0x400003E")]
		InElastic,
		[Token(Token = "0x400003F")]
		InElasticSmall,
		[Token(Token = "0x4000040")]
		InElasticBig,
		[Token(Token = "0x4000041")]
		InSine,
		[Token(Token = "0x4000042")]
		InBack,
		[Token(Token = "0x4000043")]
		OutQuintic,
		[Token(Token = "0x4000044")]
		OutQuartic,
		[Token(Token = "0x4000045")]
		OutCubic,
		[Token(Token = "0x4000046")]
		OutInCubic,
		[Token(Token = "0x4000047")]
		OutInQuartic,
		[Token(Token = "0x4000048")]
		OutElastic,
		[Token(Token = "0x4000049")]
		OutElasticSmall,
		[Token(Token = "0x400004A")]
		OutElasticBig,
		[Token(Token = "0x400004B")]
		OutSine,
		[Token(Token = "0x400004C")]
		OutBack,
		[Token(Token = "0x400004D")]
		OutBackCubic,
		[Token(Token = "0x400004E")]
		OutBackQuartic,
		[Token(Token = "0x400004F")]
		BackInCubic,
		[Token(Token = "0x4000050")]
		BackInQuartic
	}
	[Token(Token = "0x200000D")]
	public class Interp
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x25C7208", Offset = "0x25C7208", VA = "0x25C7208")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x25C7C70", Offset = "0x25C7C70", VA = "0x25C7C70")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x25C7D78", Offset = "0x25C7D78", VA = "0x25C7D78")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x25C7574", Offset = "0x25C7574", VA = "0x25C7574")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x25C7580", Offset = "0x25C7580", VA = "0x25C7580")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x25C75A4", Offset = "0x25C75A4", VA = "0x25C75A4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x25C75E0", Offset = "0x25C75E0", VA = "0x25C75E0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x25C75F8", Offset = "0x25C75F8", VA = "0x25C75F8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x25C760C", Offset = "0x25C760C", VA = "0x25C760C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x25C7620", Offset = "0x25C7620", VA = "0x25C7620")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x25C7630", Offset = "0x25C7630", VA = "0x25C7630")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x25C7678", Offset = "0x25C7678", VA = "0x25C7678")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x25C76B0", Offset = "0x25C76B0", VA = "0x25C76B0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x25C76D8", Offset = "0x25C76D8", VA = "0x25C76D8")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x25C7E74", Offset = "0x25C7E74", VA = "0x25C7E74")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x25C770C", Offset = "0x25C770C", VA = "0x25C770C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x25C7734", Offset = "0x25C7734", VA = "0x25C7734")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x25C7764", Offset = "0x25C7764", VA = "0x25C7764")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x25C7798", Offset = "0x25C7798", VA = "0x25C7798")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x25C77DC", Offset = "0x25C77DC", VA = "0x25C77DC")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x25C7840", Offset = "0x25C7840", VA = "0x25C7840")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x25C78A4", Offset = "0x25C78A4", VA = "0x25C78A4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x25C78F8", Offset = "0x25C78F8", VA = "0x25C78F8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x25C794C", Offset = "0x25C794C", VA = "0x25C794C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x25C79E4", Offset = "0x25C79E4", VA = "0x25C79E4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x25C7A78", Offset = "0x25C7A78", VA = "0x25C7A78")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x25C7EA8", Offset = "0x25C7EA8", VA = "0x25C7EA8")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x25C7B1C", Offset = "0x25C7B1C", VA = "0x25C7B1C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x25C7C00", Offset = "0x25C7C00", VA = "0x25C7C00")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x25C7C30", Offset = "0x25C7C30", VA = "0x25C7C30")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x25C7F90", Offset = "0x25C7F90", VA = "0x25C7F90")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x25C7F98", Offset = "0x25C7F98", VA = "0x25C7F98")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x25C8008", Offset = "0x25C8008", VA = "0x25C8008")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x25C8078", Offset = "0x25C8078", VA = "0x25C8078")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x25C80D0", Offset = "0x25C80D0", VA = "0x25C80D0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x25C819C", Offset = "0x25C819C", VA = "0x25C819C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x25C80E8", Offset = "0x25C80E8", VA = "0x25C80E8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x25C81B4", Offset = "0x25C81B4", VA = "0x25C81B4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x25C8258", Offset = "0x25C8258", VA = "0x25C8258")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x25C8284", Offset = "0x25C8284", VA = "0x25C8284")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x25C82D4", Offset = "0x25C82D4", VA = "0x25C82D4")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x25C8340", Offset = "0x25C8340", VA = "0x25C8340")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x25C8434", Offset = "0x25C8434", VA = "0x25C8434")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x25C850C", Offset = "0x25C850C", VA = "0x25C850C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x25C856C", Offset = "0x25C856C", VA = "0x25C856C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public static class QuaTools
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x25C859C", Offset = "0x25C859C", VA = "0x25C859C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x25C86E8", Offset = "0x25C86E8", VA = "0x25C86E8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x25C8834", Offset = "0x25C8834", VA = "0x25C8834")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x25C8948", Offset = "0x25C8948", VA = "0x25C8948")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x25C8A5C", Offset = "0x25C8A5C", VA = "0x25C8A5C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x25C8BE8", Offset = "0x25C8BE8", VA = "0x25C8BE8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x25C8CB8", Offset = "0x25C8CB8", VA = "0x25C8CB8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x25C8E0C", Offset = "0x25C8E0C", VA = "0x25C8E0C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x25C9090", Offset = "0x25C9090", VA = "0x25C9090")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x25C92A4", Offset = "0x25C92A4", VA = "0x25C92A4")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x25C4024", Offset = "0x25C4024", VA = "0x25C4024")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000011")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000005")]
		public static T instance
		{
			[Token(Token = "0x6000085")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000086")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000087")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE1EC", Offset = "0xCDE1EC")]
		public bool fixTransforms;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000006")]
		private bool animatePhysics
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x25C955C", Offset = "0x25C955C", VA = "0x25C955C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		private bool isAnimated
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x25C9858", Offset = "0x25C9858", VA = "0x25C9858")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x25C9424", Offset = "0x25C9424", VA = "0x25C9424")]
		public void Disable()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x25C94BC", Offset = "0x25C94BC", VA = "0x25C94BC", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x25C94C0", Offset = "0x25C94C0", VA = "0x25C94C0", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x25C94C4", Offset = "0x25C94C4", VA = "0x25C94C4", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x25C94C8", Offset = "0x25C94C8", VA = "0x25C94C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x25C9558", Offset = "0x25C9558", VA = "0x25C9558")]
		private void Start()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x25C9500", Offset = "0x25C9500", VA = "0x25C9500")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x25C980C", Offset = "0x25C980C", VA = "0x25C980C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x25C964C", Offset = "0x25C964C", VA = "0x25C964C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x25C9914", Offset = "0x25C9914", VA = "0x25C9914")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x25C9970", Offset = "0x25C9970", VA = "0x25C9970")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x25C99CC", Offset = "0x25C99CC", VA = "0x25C99CC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x25C9A14", Offset = "0x25C9A14", VA = "0x25C9A14")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x25C9A24", Offset = "0x25C9A24", VA = "0x25C9A24")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x25C9ADC", Offset = "0x25C9ADC", VA = "0x25C9ADC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x25C9B94", Offset = "0x25C9B94", VA = "0x25C9B94")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x25C9C4C", Offset = "0x25C9C4C", VA = "0x25C9C4C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class V3Tools
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x25C9C54", Offset = "0x25C9C54", VA = "0x25C9C54")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x25C9D4C", Offset = "0x25C9D4C", VA = "0x25C9D4C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x25C9E44", Offset = "0x25C9E44", VA = "0x25C9E44")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x25C9F3C", Offset = "0x25C9F3C", VA = "0x25C9F3C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x25CA03C", Offset = "0x25CA03C", VA = "0x25CA03C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x25CA278", Offset = "0x25CA278", VA = "0x25CA278")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x25CA4C8", Offset = "0x25CA4C8", VA = "0x25CA4C8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x25CA6C8", Offset = "0x25CA6C8", VA = "0x25CA6C8")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000015")]
	public static class Warning
	{
		[Token(Token = "0x2000088")]
		public delegate void Logger(string message);

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x25CA8A4", Offset = "0x25CA8A4", VA = "0x25CA8A4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x25BC65C", Offset = "0x25BC65C", VA = "0x25BC65C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x2000016")]
	public class Navigator
	{
		[Token(Token = "0x2000089")]
		public enum State
		{
			[Token(Token = "0x4000476")]
			Idle,
			[Token(Token = "0x4000477")]
			Seeking,
			[Token(Token = "0x4000478")]
			OnPath
		}

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE224", Offset = "0xCDE224")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE25C", Offset = "0xCDE25C")]
		public float cornerRadius;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE294", Offset = "0xCDE294")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE2CC", Offset = "0xCDE2CC")]
		public float maxSampleDistance;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE304", Offset = "0xCDE304")]
		public float nextPathInterval;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE33C", Offset = "0xCDE33C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE34C", Offset = "0xCDE34C")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000008")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1F3E760", Offset = "0x1F3E760", VA = "0x1F3E760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6538", Offset = "0xCE6538")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1F3E76C", Offset = "0x1F3E76C", VA = "0x1F3E76C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6548", Offset = "0xCE6548")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public State state
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1F3E778", Offset = "0x1F3E778", VA = "0x1F3E778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6558", Offset = "0xCE6558")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1F3E780", Offset = "0x1F3E780", VA = "0x1F3E780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6568", Offset = "0xCE6568")]
			private set
			{
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1F3E788", Offset = "0x1F3E788", VA = "0x1F3E788")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1F3E85C", Offset = "0x1F3E85C", VA = "0x1F3E85C")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1F3EDA0", Offset = "0x1F3EDA0", VA = "0x1F3EDA0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1F3EE10", Offset = "0x1F3EE10", VA = "0x1F3EE10")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1F3EC68", Offset = "0x1F3EC68", VA = "0x1F3EC68")]
		private void Stop()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1F3ECDC", Offset = "0x1F3ECDC", VA = "0x1F3ECDC")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1F3EF58", Offset = "0x1F3EF58", VA = "0x1F3EF58")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1F3F108", Offset = "0x1F3F108", VA = "0x1F3F108")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD5FC", Offset = "0xCDD5FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD5FC", Offset = "0xCDD5FC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1E6C0FC", Offset = "0x1E6C0FC", VA = "0x1E6C0FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6578", Offset = "0xCE6578")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1E6C148", Offset = "0x1E6C148", VA = "0x1E6C148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE65B0", Offset = "0xCE65B0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1E6C194", Offset = "0x1E6C194", VA = "0x1E6C194")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE65E8", Offset = "0xCE65E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E6C1E0", Offset = "0x1E6C1E0", VA = "0x1E6C1E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6620", Offset = "0xCE6620")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E6C22C", Offset = "0x1E6C22C", VA = "0x1E6C22C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1E6C2C8", Offset = "0x1E6C2C8", VA = "0x1E6C2C8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1E6C2E8", Offset = "0x1E6C2E8", VA = "0x1E6C2E8")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1E6C318", Offset = "0x1E6C318", VA = "0x1E6C318")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1E6C348", Offset = "0x1E6C348", VA = "0x1E6C348")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1E6C388", Offset = "0x1E6C388", VA = "0x1E6C388")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1E6C3CC", Offset = "0x1E6C3CC", VA = "0x1E6C3CC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1E6C3F0", Offset = "0x1E6C3F0", VA = "0x1E6C3F0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1E6C414", Offset = "0x1E6C414", VA = "0x1E6C414")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1E6C43C", Offset = "0x1E6C43C", VA = "0x1E6C43C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1E6C468", Offset = "0x1E6C468", VA = "0x1E6C468")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1E6C494", Offset = "0x1E6C494", VA = "0x1E6C494")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1E6C24C", Offset = "0x1E6C24C", VA = "0x1E6C24C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1E6C4BC", Offset = "0x1E6C4BC", VA = "0x1E6C4BC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1E6C4C8", Offset = "0x1E6C4C8", VA = "0x1E6C4C8")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1E6C4D4", Offset = "0x1E6C4D4", VA = "0x1E6C4D4")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1E6C7BC", Offset = "0x1E6C7BC", VA = "0x1E6C7BC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1E6C864", Offset = "0x1E6C864", VA = "0x1E6C864", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1E6CBAC", Offset = "0x1E6CBAC", VA = "0x1E6CBAC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1E6D094", Offset = "0x1E6D094", VA = "0x1E6D094")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1E6D0C8", Offset = "0x1E6D0C8", VA = "0x1E6D0C8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000A")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1E6C674", Offset = "0x1E6C674", VA = "0x1E6C674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1E6D294", Offset = "0x1E6D294", VA = "0x1E6D294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1E6CA34", Offset = "0x1E6CA34", VA = "0x1E6CA34")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1E6D14C", Offset = "0x1E6D14C", VA = "0x1E6D14C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700000C")]
		public bool isValid
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1E704D8", Offset = "0x1E704D8", VA = "0x1E704D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D0")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1E70548", Offset = "0x1E70548", VA = "0x1E70548")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1E70550", Offset = "0x1E70550", VA = "0x1E70550", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1E7065C", Offset = "0x1E7065C", VA = "0x1E7065C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1E70664", Offset = "0x1E70664", VA = "0x1E70664")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700000D")]
		private bool positionChanged
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1E7082C", Offset = "0x1E7082C", VA = "0x1E7082C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1E70690", Offset = "0x1E70690", VA = "0x1E70690", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1E708E8", Offset = "0x1E708E8", VA = "0x1E708E8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1E708F0", Offset = "0x1E708F0", VA = "0x1E708F0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1E7091C", Offset = "0x1E7091C", VA = "0x1E7091C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1E70A44", Offset = "0x1E70A44", VA = "0x1E70A44")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1E70A4C", Offset = "0x1E70A4C", VA = "0x1E70A4C")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700000E")]
		private bool rotationChanged
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x1E70C18", Offset = "0x1E70C18", VA = "0x1E70C18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1E70A78", Offset = "0x1E70A78", VA = "0x1E70A78", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1E70CE8", Offset = "0x1E70CE8", VA = "0x1E70CE8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1E70CF0", Offset = "0x1E70CF0", VA = "0x1E70CF0")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class Constraints
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE35C", Offset = "0xCDE35C")]
		public float positionWeight;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE374", Offset = "0xCDE374")]
		public float rotationWeight;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1E70D1C", Offset = "0x1E70D1C", VA = "0x1E70D1C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1E6CB58", Offset = "0x1E6CB58", VA = "0x1E6CB58")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1E6CD34", Offset = "0x1E6CD34", VA = "0x1E6CD34")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1E6D460", Offset = "0x1E6D460", VA = "0x1E6D460")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200008A")]
		public enum DOF
		{
			[Token(Token = "0x400047A")]
			One,
			[Token(Token = "0x400047B")]
			Three
		}

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE38C", Offset = "0xCDE38C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE38C", Offset = "0xCDE38C")]
		public float weight;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE3E0", Offset = "0xCDE3E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE3E0", Offset = "0xCDE3E0")]
		public float rotationWeight;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE434", Offset = "0xCDE434")]
		public DOF rotationDOF;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE46C", Offset = "0xCDE46C")]
		public Transform bone1;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE4A4", Offset = "0xCDE4A4")]
		public Transform bone2;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE4DC", Offset = "0xCDE4DC")]
		public Transform bone3;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE514", Offset = "0xCDE514")]
		public Transform tip;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE54C", Offset = "0xCDE54C")]
		public Transform target;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE584", Offset = "0xCDE584")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700000F")]
		public bool initiated
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1E77EE8", Offset = "0x1E77EE8", VA = "0x1E77EE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6658", Offset = "0xCE6658")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1E77EF0", Offset = "0x1E77EF0", VA = "0x1E77EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6668", Offset = "0xCE6668")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1E77EFC", Offset = "0x1E77EFC", VA = "0x1E77EFC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1E77F1C", Offset = "0x1E77F1C", VA = "0x1E77F1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1E77F3C", Offset = "0x1E77F3C", VA = "0x1E77F3C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1E77F5C", Offset = "0x1E77F5C", VA = "0x1E77F5C")]
			set
			{
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1E77F7C", Offset = "0x1E77F7C", VA = "0x1E77F7C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1E7807C", Offset = "0x1E7807C", VA = "0x1E7807C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1E78490", Offset = "0x1E78490", VA = "0x1E78490")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1E7856C", Offset = "0x1E7856C", VA = "0x1E7856C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1E78634", Offset = "0x1E78634", VA = "0x1E78634")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1E789E8", Offset = "0x1E789E8", VA = "0x1E789E8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE594", Offset = "0xCDE594")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE594", Offset = "0xCDE594")]
		public float weight;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE5E8", Offset = "0xCDE5E8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000012")]
		public bool initiated
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1E789F8", Offset = "0x1E789F8", VA = "0x1E789F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6678", Offset = "0xCE6678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1E78A00", Offset = "0x1E78A00", VA = "0x1E78A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6688", Offset = "0xCE6688")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1E78A0C", Offset = "0x1E78A0C", VA = "0x1E78A0C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1E78A94", Offset = "0x1E78A94", VA = "0x1E78A94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6698", Offset = "0xCE6698")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1E78DB8", Offset = "0x1E78DB8", VA = "0x1E78DB8")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1E78F28", Offset = "0x1E78F28", VA = "0x1E78F28")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1E78CB0", Offset = "0x1E78CB0", VA = "0x1E78CB0")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1E79090", Offset = "0x1E79090", VA = "0x1E79090", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1E79150", Offset = "0x1E79150", VA = "0x1E79150")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1E791C8", Offset = "0x1E791C8", VA = "0x1E791C8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1E7923C", Offset = "0x1E7923C", VA = "0x1E7923C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1E792A4", Offset = "0x1E792A4", VA = "0x1E792A4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1E792A8", Offset = "0x1E792A8", VA = "0x1E792A8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1E792BC", Offset = "0x1E792BC", VA = "0x1E792BC")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE5F8", Offset = "0xCDE5F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE5F8", Offset = "0xCDE5F8")]
		public float weight;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE64C", Offset = "0xCDE64C")]
		public Grounding solver;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE684", Offset = "0xCDE684")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000013")]
		public bool initiated
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1E7A2F0", Offset = "0x1E7A2F0", VA = "0x1E7A2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE66D0", Offset = "0xCE66D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1E7A2F8", Offset = "0x1E7A2F8", VA = "0x1E7A2F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE66E0", Offset = "0xCE66E0")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000FE")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1E7A304", Offset = "0x1E7A304", VA = "0x1E7A304")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1E7A5D8", Offset = "0x1E7A5D8", VA = "0x1E7A5D8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1E7A448", Offset = "0x1E7A448", VA = "0x1E7A448")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1E7A60C", Offset = "0x1E7A60C", VA = "0x1E7A60C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000106")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1E7A814", Offset = "0x1E7A814", VA = "0x1E7A814")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD65C", Offset = "0xCDD65C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD65C", Offset = "0xCDD65C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE694", Offset = "0xCDE694")]
		public BipedIK ik;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE6CC", Offset = "0xCDE6CC")]
		public float spineBend;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE704", Offset = "0xCDE704")]
		public float spineSpeed;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1E7AAD8", Offset = "0x1E7AAD8", VA = "0x1E7AAD8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE66F0", Offset = "0xCE66F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1E7AB24", Offset = "0x1E7AB24", VA = "0x1E7AB24", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6728", Offset = "0xCE6728")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1E7AB70", Offset = "0x1E7AB70", VA = "0x1E7AB70", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1E7ABF4", Offset = "0x1E7ABF4", VA = "0x1E7ABF4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1E7ACA4", Offset = "0x1E7ACA4", VA = "0x1E7ACA4")]
		private void Update()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1E7AD58", Offset = "0x1E7AD58", VA = "0x1E7AD58")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1E7B010", Offset = "0x1E7B010", VA = "0x1E7B010")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1E7B064", Offset = "0x1E7B064", VA = "0x1E7B064")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1E7B5B8", Offset = "0x1E7B5B8", VA = "0x1E7B5B8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1E7B68C", Offset = "0x1E7B68C", VA = "0x1E7B68C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1E7B81C", Offset = "0x1E7B81C", VA = "0x1E7B81C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1E7B98C", Offset = "0x1E7B98C", VA = "0x1E7B98C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD6BC", Offset = "0xCDD6BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD6BC", Offset = "0xCDD6BC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200008C")]
		public class SpineEffector
		{
			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3124", Offset = "0xCE3124")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE315C", Offset = "0xCE315C")]
			public float horizontalWeight;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3194", Offset = "0xCE3194")]
			public float verticalWeight;

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1E7C800", Offset = "0x1E7C800", VA = "0x1E7C800")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x1E7C810", Offset = "0x1E7C810", VA = "0x1E7C810")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE73C", Offset = "0xCDE73C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE774", Offset = "0xCDE774")]
		public float spineBend;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE7AC", Offset = "0xCDE7AC")]
		public float spineSpeed;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1E7BA0C", Offset = "0x1E7BA0C", VA = "0x1E7BA0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6760", Offset = "0xCE6760")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1E7BA58", Offset = "0x1E7BA58", VA = "0x1E7BA58", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6798", Offset = "0xCE6798")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1E7BAA4", Offset = "0x1E7BAA4", VA = "0x1E7BAA4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE67D0", Offset = "0xCE67D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1E7BAF0", Offset = "0x1E7BAF0", VA = "0x1E7BAF0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1E7BB74", Offset = "0x1E7BB74", VA = "0x1E7BB74")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1E7BC0C", Offset = "0x1E7BC0C", VA = "0x1E7BC0C")]
		private void Update()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1E7BECC", Offset = "0x1E7BECC", VA = "0x1E7BECC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1E7BED8", Offset = "0x1E7BED8", VA = "0x1E7BED8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1E7BCC8", Offset = "0x1E7BCC8", VA = "0x1E7BCC8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1E7BEE4", Offset = "0x1E7BEE4", VA = "0x1E7BEE4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1E7C388", Offset = "0x1E7C388", VA = "0x1E7C388")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1E7C548", Offset = "0x1E7C548", VA = "0x1E7C548")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1E7C680", Offset = "0x1E7C680", VA = "0x1E7C680")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1E7C780", Offset = "0x1E7C780", VA = "0x1E7C780")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD71C", Offset = "0xCDD71C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD71C", Offset = "0xCDD71C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE7E4", Offset = "0xCDE7E4")]
		public Transform pelvis;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE81C", Offset = "0xCDE81C")]
		public Transform characterRoot;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE854", Offset = "0xCDE854")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE854", Offset = "0xCDE854")]
		public float rootRotationWeight;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE8A8", Offset = "0xCDE8A8")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE8E0", Offset = "0xCDE8E0")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1E7C858", Offset = "0x1E7C858", VA = "0x1E7C858", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6808", Offset = "0xCE6808")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1E7C8A4", Offset = "0x1E7C8A4", VA = "0x1E7C8A4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6840", Offset = "0xCE6840")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1E7C8F0", Offset = "0x1E7C8F0", VA = "0x1E7C8F0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1E7C90C", Offset = "0x1E7C90C", VA = "0x1E7C90C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1E7CAFC", Offset = "0x1E7CAFC", VA = "0x1E7CAFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1E7CBFC", Offset = "0x1E7CBFC", VA = "0x1E7CBFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1E7D130", Offset = "0x1E7D130", VA = "0x1E7D130")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1E7D518", Offset = "0x1E7D518", VA = "0x1E7D518")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1E7D78C", Offset = "0x1E7D78C", VA = "0x1E7D78C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1E7DAAC", Offset = "0x1E7DAAC", VA = "0x1E7DAAC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1E7DC38", Offset = "0x1E7DC38", VA = "0x1E7DC38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1E7DE00", Offset = "0x1E7DE00", VA = "0x1E7DE00")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD77C", Offset = "0xCDD77C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD77C", Offset = "0xCDD77C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200008D")]
		public struct Foot
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x205EF50", Offset = "0x205EF50", VA = "0x205EF50")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE918", Offset = "0xCDE918")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE950", Offset = "0xCDE950")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE950", Offset = "0xCDE950")]
		public float rootRotationWeight;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE9A4", Offset = "0xCDE9A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE9A4", Offset = "0xCDE9A4")]
		public float minRootRotation;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDE9FC", Offset = "0xCDE9FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDE9FC", Offset = "0xCDE9FC")]
		public float maxRootRotation;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEA54", Offset = "0xCDEA54")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEA8C", Offset = "0xCDEA8C")]
		public float maxLegOffset;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEAC4", Offset = "0xCDEAC4")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEAFC", Offset = "0xCDEAFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDEAFC", Offset = "0xCDEAFC")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEB50", Offset = "0xCDEB50")]
		public Transform characterRoot;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEB88", Offset = "0xCDEB88")]
		public Transform pelvis;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEBC0", Offset = "0xCDEBC0")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEBF8", Offset = "0xCDEBF8")]
		public Transform head;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x205E1A0", Offset = "0x205E1A0", VA = "0x205E1A0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6878", Offset = "0xCE6878")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x205E1EC", Offset = "0x205E1EC", VA = "0x205E1EC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE68B0", Offset = "0xCE68B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x205E238", Offset = "0x205E238", VA = "0x205E238", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x205E2F0", Offset = "0x205E2F0", VA = "0x205E2F0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x205E420", Offset = "0x205E420", VA = "0x205E420")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x205E5CC", Offset = "0x205E5CC", VA = "0x205E5CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x205E634", Offset = "0x205E634", VA = "0x205E634")]
		private void Update()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x205E6EC", Offset = "0x205E6EC", VA = "0x205E6EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x205E9EC", Offset = "0x205E9EC", VA = "0x205E9EC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x205EFA0", Offset = "0x205EFA0", VA = "0x205EFA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x205F0EC", Offset = "0x205F0EC", VA = "0x205F0EC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x205F590", Offset = "0x205F590", VA = "0x205F590")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x205FD88", Offset = "0x205FD88", VA = "0x205FD88")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x20602B0", Offset = "0x20602B0", VA = "0x20602B0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2060410", Offset = "0x2060410", VA = "0x2060410")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x20606EC", Offset = "0x20606EC", VA = "0x20606EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2060724", Offset = "0x2060724", VA = "0x2060724")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x20608DC", Offset = "0x20608DC", VA = "0x20608DC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD7DC", Offset = "0xCDD7DC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEC40", Offset = "0xCDEC40")]
		public VRIK ik;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2060A4C", Offset = "0x2060A4C", VA = "0x2060A4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE68E8", Offset = "0xCE68E8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2060A50", Offset = "0x2060A50", VA = "0x2060A50", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6920", Offset = "0xCE6920")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2060A54", Offset = "0x2060A54", VA = "0x2060A54", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6958", Offset = "0xCE6958")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2060A58", Offset = "0x2060A58", VA = "0x2060A58", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2060A70", Offset = "0x2060A70", VA = "0x2060A70")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2060B08", Offset = "0x2060B08", VA = "0x2060B08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2060BBC", Offset = "0x2060BBC", VA = "0x2060BBC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2060DAC", Offset = "0x2060DAC", VA = "0x2060DAC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2061048", Offset = "0x2061048", VA = "0x2061048")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2061150", Offset = "0x2061150", VA = "0x2061150")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2061350", Offset = "0x2061350", VA = "0x2061350")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2061488", Offset = "0x2061488", VA = "0x2061488")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x20615D8", Offset = "0x20615D8", VA = "0x20615D8")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public enum Quality
		{
			[Token(Token = "0x4000484")]
			Fastest,
			[Token(Token = "0x4000485")]
			Simple,
			[Token(Token = "0x4000486")]
			Best
		}

		[Token(Token = "0x200008F")]
		public class Leg
		{
			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE31CC", Offset = "0xCE31CC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE31DC", Offset = "0xCE31DC")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE31EC", Offset = "0xCE31EC")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE31FC", Offset = "0xCE31FC")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE320C", Offset = "0xCE320C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE321C", Offset = "0xCE321C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE322C", Offset = "0xCE322C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000AC")]
			public bool isGrounded
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x2063090", Offset = "0x2063090", VA = "0x2063090")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE84D8", Offset = "0xCE84D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x2063098", Offset = "0x2063098", VA = "0x2063098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE84E8", Offset = "0xCE84E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x20630A4", Offset = "0x20630A4", VA = "0x20630A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE84F8", Offset = "0xCE84F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x20630B0", Offset = "0x20630B0", VA = "0x20630B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8508", Offset = "0xCE8508")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AE")]
			public bool initiated
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x20630BC", Offset = "0x20630BC", VA = "0x20630BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8518", Offset = "0xCE8518")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0x20630C4", Offset = "0x20630C4", VA = "0x20630C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8528", Offset = "0xCE8528")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public float heightFromGround
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x20630D0", Offset = "0x20630D0", VA = "0x20630D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8538", Offset = "0xCE8538")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005B6")]
				[Address(RVA = "0x20630D8", Offset = "0x20630D8", VA = "0x20630D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8548", Offset = "0xCE8548")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0x20630E0", Offset = "0x20630E0", VA = "0x20630E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8558", Offset = "0xCE8558")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x20630EC", Offset = "0x20630EC", VA = "0x20630EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8568", Offset = "0xCE8568")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			public Transform transform
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x20630F8", Offset = "0x20630F8", VA = "0x20630F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8578", Offset = "0xCE8578")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x2063100", Offset = "0x2063100", VA = "0x2063100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8588", Offset = "0xCE8588")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public float IKOffset
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x2063108", Offset = "0x2063108", VA = "0x2063108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8598", Offset = "0xCE8598")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x2063110", Offset = "0x2063110", VA = "0x2063110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE85A8", Offset = "0xCE85A8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x2063C60", Offset = "0x2063C60", VA = "0x2063C60")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B4")]
			private float rootYOffset
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x2063F54", Offset = "0x2063F54", VA = "0x2063F54")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x2061D00", Offset = "0x2061D00", VA = "0x2061D00")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2063118", Offset = "0x2063118", VA = "0x2063118")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x2062BB0", Offset = "0x2062BB0", VA = "0x2062BB0")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x2061E0C", Offset = "0x2061E0C", VA = "0x2061E0C")]
			public void Process()
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x20637F8", Offset = "0x20637F8", VA = "0x20637F8")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x2063164", Offset = "0x2063164", VA = "0x2063164")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2063DE0", Offset = "0x2063DE0", VA = "0x2063DE0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x2063488", Offset = "0x2063488", VA = "0x2063488")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x2063590", Offset = "0x2063590", VA = "0x2063590")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x2063EDC", Offset = "0x2063EDC", VA = "0x2063EDC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2063CEC", Offset = "0x2063CEC", VA = "0x2063CEC")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2064088", Offset = "0x2064088", VA = "0x2064088")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x2061C50", Offset = "0x2061C50", VA = "0x2061C50")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000090")]
		public class Pelvis
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE323C", Offset = "0xCE323C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE324C", Offset = "0xCE324C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000B5")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x2064178", Offset = "0x2064178", VA = "0x2064178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE85B8", Offset = "0xCE85B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x2064184", Offset = "0x2064184", VA = "0x2064184")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE85C8", Offset = "0xCE85C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public float heightOffset
			{
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x2064190", Offset = "0x2064190", VA = "0x2064190")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE85D8", Offset = "0xCE85D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005CF")]
				[Address(RVA = "0x2064198", Offset = "0x2064198", VA = "0x2064198")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE85E8", Offset = "0xCE85E8")]
				private set
				{
				}
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x2061DE4", Offset = "0x2061DE4", VA = "0x2061DE4")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2062B00", Offset = "0x2062B00", VA = "0x2062B00")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x20641A0", Offset = "0x20641A0", VA = "0x20641A0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x206267C", Offset = "0x206267C", VA = "0x206267C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x2061CF8", Offset = "0x2061CF8", VA = "0x2061CF8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEC78", Offset = "0xCDEC78")]
		public LayerMask layers;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDECB0", Offset = "0xCDECB0")]
		public float maxStep;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDECE8", Offset = "0xCDECE8")]
		public float heightOffset;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDED20", Offset = "0xCDED20")]
		public float footSpeed;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDED58", Offset = "0xCDED58")]
		public float footRadius;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDED90", Offset = "0xCDED90")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEDDC", Offset = "0xCDEDDC")]
		public float prediction;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEE14", Offset = "0xCDEE14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDEE14", Offset = "0xCDEE14")]
		public float footRotationWeight;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEE68", Offset = "0xCDEE68")]
		public float footRotationSpeed;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEEA0", Offset = "0xCDEEA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDEEA0", Offset = "0xCDEEA0")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEEF8", Offset = "0xCDEEF8")]
		public bool rotateSolver;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEF30", Offset = "0xCDEF30")]
		public float pelvisSpeed;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEF68", Offset = "0xCDEF68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDEF68", Offset = "0xCDEF68")]
		public float pelvisDamper;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEFBC", Offset = "0xCDEFBC")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDEFF4", Offset = "0xCDEFF4")]
		public float liftPelvisWeight;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF02C", Offset = "0xCDF02C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF064", Offset = "0xCDF064")]
		public bool overstepFallsDown;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF09C", Offset = "0xCDF09C")]
		public Quality quality;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF0D4", Offset = "0xCDF0D4")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF0E4", Offset = "0xCDF0E4")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF0F4", Offset = "0xCDF0F4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF104", Offset = "0xCDF104")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF114", Offset = "0xCDF114")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		public Leg[] legs
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2061638", Offset = "0x2061638", VA = "0x2061638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6990", Offset = "0xCE6990")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2061640", Offset = "0x2061640", VA = "0x2061640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE69A0", Offset = "0xCE69A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2061648", Offset = "0x2061648", VA = "0x2061648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE69B0", Offset = "0xCE69B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2061650", Offset = "0x2061650", VA = "0x2061650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE69C0", Offset = "0xCE69C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool isGrounded
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2061658", Offset = "0x2061658", VA = "0x2061658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE69D0", Offset = "0xCE69D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2061660", Offset = "0x2061660", VA = "0x2061660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE69E0", Offset = "0xCE69E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Transform root
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x206166C", Offset = "0x206166C", VA = "0x206166C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE69F0", Offset = "0xCE69F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2061674", Offset = "0x2061674", VA = "0x2061674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6A00", Offset = "0xCE6A00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x206167C", Offset = "0x206167C", VA = "0x206167C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6A10", Offset = "0xCE6A10")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2061694", Offset = "0x2061694", VA = "0x2061694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE6A20", Offset = "0xCE6A20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x20616B4", Offset = "0x20616B4", VA = "0x20616B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 up
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2061AE8", Offset = "0x2061AE8", VA = "0x2061AE8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001B")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2062C64", Offset = "0x2062C64", VA = "0x2062C64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2061708", Offset = "0x2061708", VA = "0x2061708")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2061B74", Offset = "0x2061B74", VA = "0x2061B74")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x205ECF0", Offset = "0x205ECF0", VA = "0x205ECF0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2060048", Offset = "0x2060048", VA = "0x2060048")]
		public void Update()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x20628E8", Offset = "0x20628E8", VA = "0x20628E8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x205E26C", Offset = "0x205E26C", VA = "0x205E26C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2061DF4", Offset = "0x2061DF4", VA = "0x2061DF4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2062D34", Offset = "0x2062D34", VA = "0x2062D34")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2062E9C", Offset = "0x2062E9C", VA = "0x2062E9C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2062FA0", Offset = "0x2062FA0", VA = "0x2062FA0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x20609F8", Offset = "0x20609F8", VA = "0x20609F8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD814", Offset = "0xCDD814")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD814", Offset = "0xCDD814")]
	public class AimIK : IK
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1E676F4", Offset = "0x1E676F4", VA = "0x1E676F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6A30", Offset = "0xCE6A30")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1E67740", Offset = "0x1E67740", VA = "0x1E67740", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6A68", Offset = "0xCE6A68")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1E6778C", Offset = "0x1E6778C", VA = "0x1E6778C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6AA0", Offset = "0xCE6AA0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1E677D8", Offset = "0x1E677D8", VA = "0x1E677D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6AD8", Offset = "0xCE6AD8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1E67824", Offset = "0x1E67824", VA = "0x1E67824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6B10", Offset = "0xCE6B10")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1E67870", Offset = "0x1E67870", VA = "0x1E67870", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1E67878", Offset = "0x1E67878", VA = "0x1E67878")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD874", Offset = "0xCDD874")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1E6BF1C", Offset = "0x1E6BF1C", VA = "0x1E6BF1C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6B48", Offset = "0xCE6B48")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1E6BF88", Offset = "0x1E6BF88", VA = "0x1E6BF88", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6B80", Offset = "0xCE6B80")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1E6BFF4", Offset = "0x1E6BFF4", VA = "0x1E6BFF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6BB8", Offset = "0xCE6BB8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1E6C040", Offset = "0x1E6C040", VA = "0x1E6C040")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6BF0", Offset = "0xCE6BF0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1E6C08C", Offset = "0x1E6C08C", VA = "0x1E6C08C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1E6C094", Offset = "0x1E6C094", VA = "0x1E6C094")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD8AC", Offset = "0xCDD8AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD8AC", Offset = "0xCDD8AC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1E6D6F4", Offset = "0x1E6D6F4", VA = "0x1E6D6F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6C28", Offset = "0xCE6C28")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1E6D740", Offset = "0x1E6D740", VA = "0x1E6D740", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6C60", Offset = "0xCE6C60")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1E6D78C", Offset = "0x1E6D78C", VA = "0x1E6D78C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6C98", Offset = "0xCE6C98")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1E6D7D8", Offset = "0x1E6D7D8", VA = "0x1E6D7D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6CD0", Offset = "0xCE6CD0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1E6D824", Offset = "0x1E6D824", VA = "0x1E6D824", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1E6D82C", Offset = "0x1E6D82C", VA = "0x1E6D82C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD90C", Offset = "0xCDD90C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD90C", Offset = "0xCDD90C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1E70D8C", Offset = "0x1E70D8C", VA = "0x1E70D8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6D08", Offset = "0xCE6D08")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1E70DD8", Offset = "0x1E70DD8", VA = "0x1E70DD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6D40", Offset = "0xCE6D40")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1E70E24", Offset = "0x1E70E24", VA = "0x1E70E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6D78", Offset = "0xCE6D78")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1E70E70", Offset = "0x1E70E70", VA = "0x1E70E70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6DB0", Offset = "0xCE6DB0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1E70EBC", Offset = "0x1E70EBC", VA = "0x1E70EBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1E70EC4", Offset = "0x1E70EC4", VA = "0x1E70EC4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD96C", Offset = "0xCDD96C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD96C", Offset = "0xCDD96C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1E71544", Offset = "0x1E71544", VA = "0x1E71544", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6DE8", Offset = "0xCE6DE8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1E71590", Offset = "0x1E71590", VA = "0x1E71590", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6E20", Offset = "0xCE6E20")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1E715DC", Offset = "0x1E715DC", VA = "0x1E715DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6E58", Offset = "0xCE6E58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1E71628", Offset = "0x1E71628", VA = "0x1E71628")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6E90", Offset = "0xCE6E90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1E71674", Offset = "0x1E71674", VA = "0x1E71674", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1E7167C", Offset = "0x1E7167C", VA = "0x1E7167C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDD9CC", Offset = "0xCDD9CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDD9CC", Offset = "0xCDD9CC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1E79324", Offset = "0x1E79324", VA = "0x1E79324", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6EC8", Offset = "0xCE6EC8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1E79370", Offset = "0x1E79370", VA = "0x1E79370", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6F00", Offset = "0xCE6F00")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1E793BC", Offset = "0x1E793BC", VA = "0x1E793BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6F38", Offset = "0xCE6F38")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1E79408", Offset = "0x1E79408", VA = "0x1E79408")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6F70", Offset = "0xCE6F70")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1E79454", Offset = "0x1E79454", VA = "0x1E79454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6FA8", Offset = "0xCE6FA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1E794A0", Offset = "0x1E794A0", VA = "0x1E794A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE6FE0", Offset = "0xCE6FE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1E794EC", Offset = "0x1E794EC", VA = "0x1E794EC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1E79510", Offset = "0x1E79510", VA = "0x1E79510", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1E79518", Offset = "0x1E79518", VA = "0x1E79518")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1E796D4", Offset = "0x1E796D4", VA = "0x1E796D4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1E79A28", Offset = "0x1E79A28", VA = "0x1E79A28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7018", Offset = "0xCE7018")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1E79A48", Offset = "0x1E79A48", VA = "0x1E79A48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7050", Offset = "0xCE7050")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1E79B24", Offset = "0x1E79B24", VA = "0x1E79B24")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000191")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2066C88", Offset = "0x2066C88", VA = "0x2066C88", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2066D74", Offset = "0x2066D74", VA = "0x2066D74", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2066F30", Offset = "0x2066F30", VA = "0x2066F30", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000195")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000196")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2066F90", Offset = "0x2066F90", VA = "0x2066F90")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF124", Offset = "0xCDF124")]
		public IK[] IKComponents;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF15C", Offset = "0xCDF15C")]
		public Animator animator;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700001C")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x2069ED8", Offset = "0x2069ED8", VA = "0x2069ED8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2069F74", Offset = "0x2069F74", VA = "0x2069F74")]
		private void Start()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2069FE4", Offset = "0x2069FE4", VA = "0x2069FE4")]
		private void Update()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x206A0A0", Offset = "0x206A0A0", VA = "0x206A0A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x206A0DC", Offset = "0x206A0DC", VA = "0x206A0DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x206A018", Offset = "0x206A018", VA = "0x206A018")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x206A168", Offset = "0x206A168", VA = "0x206A168")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDA2C", Offset = "0xCDDA2C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1D8EB1C", Offset = "0x1D8EB1C", VA = "0x1D8EB1C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7088", Offset = "0xCE7088")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1D8EB88", Offset = "0x1D8EB88", VA = "0x1D8EB88", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE70C0", Offset = "0xCE70C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1D8EBF4", Offset = "0x1D8EBF4", VA = "0x1D8EBF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE70F8", Offset = "0xCE70F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1D8EC40", Offset = "0x1D8EC40", VA = "0x1D8EC40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7130", Offset = "0xCE7130")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1D8EC8C", Offset = "0x1D8EC8C", VA = "0x1D8EC8C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1D8EC94", Offset = "0x1D8EC94", VA = "0x1D8EC94")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDA64", Offset = "0xCDDA64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDA64", Offset = "0xCDDA64")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1D8ECFC", Offset = "0x1D8ECFC", VA = "0x1D8ECFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7168", Offset = "0xCE7168")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1D8ED48", Offset = "0x1D8ED48", VA = "0x1D8ED48", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE71A0", Offset = "0xCE71A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1D8ED94", Offset = "0x1D8ED94", VA = "0x1D8ED94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE71D8", Offset = "0xCE71D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1D8EDE0", Offset = "0x1D8EDE0", VA = "0x1D8EDE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7210", Offset = "0xCE7210")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1D8EE2C", Offset = "0x1D8EE2C", VA = "0x1D8EE2C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1D8EE34", Offset = "0x1D8EE34", VA = "0x1D8EE34")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDAC4", Offset = "0xCDDAC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDAC4", Offset = "0xCDDAC4")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1D8FCD4", Offset = "0x1D8FCD4", VA = "0x1D8FCD4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7248", Offset = "0xCE7248")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1D8FD20", Offset = "0x1D8FD20", VA = "0x1D8FD20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7280", Offset = "0xCE7280")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1D8FD6C", Offset = "0x1D8FD6C", VA = "0x1D8FD6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE72B8", Offset = "0xCE72B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1D8FDB8", Offset = "0x1D8FDB8", VA = "0x1D8FDB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE72F0", Offset = "0xCE72F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1D8FE04", Offset = "0x1D8FE04", VA = "0x1D8FE04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1D8FE0C", Offset = "0x1D8FE0C", VA = "0x1D8FE0C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDB24", Offset = "0xCDDB24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDB24", Offset = "0xCDDB24")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x25C0A6C", Offset = "0x25C0A6C", VA = "0x25C0A6C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7328", Offset = "0xCE7328")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x25C0AB8", Offset = "0x25C0AB8", VA = "0x25C0AB8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7360", Offset = "0xCE7360")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x25C0B04", Offset = "0x25C0B04", VA = "0x25C0B04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7398", Offset = "0xCE7398")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x25C0B50", Offset = "0x25C0B50", VA = "0x25C0B50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE73D0", Offset = "0xCE73D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x25C0B9C", Offset = "0x25C0B9C", VA = "0x25C0B9C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x25C0BA4", Offset = "0x25C0BA4", VA = "0x25C0BA4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDB84", Offset = "0xCDDB84")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public class References
		{
			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE325C", Offset = "0xCE325C")]
			public Transform chest;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3294", Offset = "0xCE3294")]
			public Transform neck;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE32CC", Offset = "0xCE32CC")]
			public Transform leftShoulder;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3304", Offset = "0xCE3304")]
			public Transform rightShoulder;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE333C", Offset = "0xCE333C")]
			public Transform leftThigh;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3374", Offset = "0xCE3374")]
			public Transform leftCalf;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE33AC", Offset = "0xCE33AC")]
			public Transform leftFoot;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE33E4", Offset = "0xCE33E4")]
			public Transform leftToes;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE341C", Offset = "0xCE341C")]
			public Transform rightThigh;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3454", Offset = "0xCE3454")]
			public Transform rightCalf;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE348C", Offset = "0xCE348C")]
			public Transform rightFoot;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE34C4", Offset = "0xCE34C4")]
			public Transform rightToes;

			[Token(Token = "0x170000B7")]
			public bool isFilled
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x25C20E4", Offset = "0x25C20E4", VA = "0x25C20E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B8")]
			public bool isEmpty
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x25C1C68", Offset = "0x25C1C68", VA = "0x25C1C68")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x25C2768", Offset = "0x25C2768", VA = "0x25C2768")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x25C1854", Offset = "0x25C1854", VA = "0x25C1854")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x25C2760", Offset = "0x25C2760", VA = "0x25C2760")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xCDF194", Offset = "0xCDF194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF194", Offset = "0xCDF194")]
		public References references;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF210", Offset = "0xCDF210")]
		public IKSolverVR solver;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x25C1708", Offset = "0x25C1708", VA = "0x25C1708", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7408", Offset = "0xCE7408")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x25C1774", Offset = "0x25C1774", VA = "0x25C1774", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7440", Offset = "0xCE7440")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x25C17E0", Offset = "0x25C17E0", VA = "0x25C17E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7478", Offset = "0xCE7478")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x25C182C", Offset = "0x25C182C", VA = "0x25C182C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE74B0", Offset = "0xCE74B0")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x25C1BC4", Offset = "0x25C1BC4", VA = "0x25C1BC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE74E8", Offset = "0xCE74E8")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x25C1BEC", Offset = "0x25C1BEC", VA = "0x25C1BEC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x25C1BF4", Offset = "0x25C1BF4", VA = "0x25C1BF4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x25C2560", Offset = "0x25C2560", VA = "0x25C2560", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x25C26D8", Offset = "0x25C26D8", VA = "0x25C26D8")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCDDBBC", Offset = "0xCDDBBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDBBC", Offset = "0xCDDBBC")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF248", Offset = "0xCDF248")]
		public Transform target;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF280", Offset = "0xCDF280")]
		public Transform poleTarget;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF2B8", Offset = "0xCDF2B8")]
		public Transform aimTransform;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCDF2F0", Offset = "0xCDF2F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF2F0", Offset = "0xCDF2F0")]
		public float axisX;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF340", Offset = "0xCDF340")]
		public float axisY;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF378", Offset = "0xCDF378")]
		public float axisZ;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCDF3B0", Offset = "0xCDF3B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF3B0", Offset = "0xCDF3B0")]
		public float poleAxisX;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF400", Offset = "0xCDF400")]
		public float poleAxisY;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF438", Offset = "0xCDF438")]
		public float poleAxisZ;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCDF470", Offset = "0xCDF470")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF470", Offset = "0xCDF470")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF470", Offset = "0xCDF470")]
		public float weight;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF4D8", Offset = "0xCDF4D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF4D8", Offset = "0xCDF4D8")]
		public float poleWeight;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF52C", Offset = "0xCDF52C")]
		public float tolerance;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF564", Offset = "0xCDF564")]
		public int maxIterations;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF59C", Offset = "0xCDF59C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF59C", Offset = "0xCDF59C")]
		public float clampWeight;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF5F0", Offset = "0xCDF5F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF5F0", Offset = "0xCDF5F0")]
		public int clampSmoothing;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF644", Offset = "0xCDF644")]
		public bool useRotationLimits;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF67C", Offset = "0xCDF67C")]
		public bool XY;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCDF6B4", Offset = "0xCDF6B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF6B4", Offset = "0xCDF6B4")]
		public Transform[] bones;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF704", Offset = "0xCDF704")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AimIKJob job;

		[Token(Token = "0x1700001D")]
		public bool initiated
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1E678E0", Offset = "0x1E678E0", VA = "0x1E678E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7520", Offset = "0xCE7520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x1E678E8", Offset = "0x1E678E8", VA = "0x1E678E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7530", Offset = "0xCE7530")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 axis
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1E678F4", Offset = "0x1E678F4", VA = "0x1E678F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1E67930", Offset = "0x1E67930", VA = "0x1E67930")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1E6793C", Offset = "0x1E6793C", VA = "0x1E6793C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1E67978", Offset = "0x1E67978", VA = "0x1E67978")]
			set
			{
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1E67984", Offset = "0x1E67984", VA = "0x1E67984")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1E6878C", Offset = "0x1E6878C", VA = "0x1E6878C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1E68B74", Offset = "0x1E68B74", VA = "0x1E68B74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1E68C74", Offset = "0x1E68C74", VA = "0x1E68C74")]
		public AimIKJ()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public struct AimIKJob : IAnimationJob
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float step;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1E680C4", Offset = "0x1E680C4", VA = "0x1E680C4")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1E68D04", Offset = "0x1E68D04", VA = "0x1E68D04")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1E69378", Offset = "0x1E69378", VA = "0x1E69378")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1E6947C", Offset = "0x1E6947C", VA = "0x1E6947C", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1E69480", Offset = "0x1E69480", VA = "0x1E69480", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1E694B8", Offset = "0x1E694B8", VA = "0x1E694B8")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1E6A5FC", Offset = "0x1E6A5FC", VA = "0x1E6A5FC")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1E6A338", Offset = "0x1E6A338", VA = "0x1E6A338")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1E6A000", Offset = "0x1E6A000", VA = "0x1E6A000")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1E6A4DC", Offset = "0x1E6A4DC", VA = "0x1E6A4DC")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1E6B424", Offset = "0x1E6B424", VA = "0x1E6B424")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1E68C08", Offset = "0x1E68C08", VA = "0x1E68C08")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCDDC44", Offset = "0xCDDC44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDC44", Offset = "0xCDDC44")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF714", Offset = "0xCDF714")]
		public Transform target;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF74C", Offset = "0xCDF74C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF74C", Offset = "0xCDF74C")]
		public float weight;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF7A0", Offset = "0xCDF7A0")]
		public float tolerance;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF7D8", Offset = "0xCDF7D8")]
		public int maxIterations;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF810", Offset = "0xCDF810")]
		public bool useRotationLimits;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF848", Offset = "0xCDF848")]
		public bool XY;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF880", Offset = "0xCDF880")]
		public Transform[] bones;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF8B8", Offset = "0xCDF8B8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CCDIKJob job;

		[Token(Token = "0x17000020")]
		public bool initiated
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1E6D894", Offset = "0x1E6D894", VA = "0x1E6D894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7540", Offset = "0xCE7540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x1E6D89C", Offset = "0x1E6D89C", VA = "0x1E6D89C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7550", Offset = "0xCE7550")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1E6D8A8", Offset = "0x1E6D8A8", VA = "0x1E6D8A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1E6E06C", Offset = "0x1E6E06C", VA = "0x1E6E06C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1E6E204", Offset = "0x1E6E204", VA = "0x1E6E204")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1E6E318", Offset = "0x1E6E318", VA = "0x1E6E318")]
		public CCDIKJ()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public struct CCDIKJob : IAnimationJob
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1E6DC0C", Offset = "0x1E6DC0C", VA = "0x1E6DC0C")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1E6E390", Offset = "0x1E6E390", VA = "0x1E6E390")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1E6EA04", Offset = "0x1E6EA04", VA = "0x1E6EA04")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1E6EB08", Offset = "0x1E6EB08", VA = "0x1E6EB08", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1E6EB0C", Offset = "0x1E6EB0C", VA = "0x1E6EB0C", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1E6EB44", Offset = "0x1E6EB44", VA = "0x1E6EB44")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1E6F06C", Offset = "0x1E6F06C", VA = "0x1E6F06C")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1E6F83C", Offset = "0x1E6F83C", VA = "0x1E6F83C")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1E6F580", Offset = "0x1E6F580", VA = "0x1E6F580")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1E6F78C", Offset = "0x1E6F78C", VA = "0x1E6F78C")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1E6F238", Offset = "0x1E6F238", VA = "0x1E6F238")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1E7026C", Offset = "0x1E7026C", VA = "0x1E7026C")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1E6E298", Offset = "0x1E6E298", VA = "0x1E6E298")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF8C8", Offset = "0xCDF8C8")]
		public float weight;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x206A170", Offset = "0x206A170", VA = "0x206A170")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x25BFA04", Offset = "0x25BFA04", VA = "0x25BFA04")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x25BFD24", Offset = "0x25BFD24", VA = "0x25BFD24")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x25BFE08", Offset = "0x25BFE08", VA = "0x25BFE08")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x25BFE70", Offset = "0x25BFE70", VA = "0x25BFE70")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x25C00A4", Offset = "0x25C00A4", VA = "0x25C00A4")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF8E0", Offset = "0xCDF8E0")]
		public float pull;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF8F8", Offset = "0xCDF8F8")]
		public float pin;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1E70F2C", Offset = "0x1E70F2C", VA = "0x1E70F2C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1E70FF4", Offset = "0x1E70FF4", VA = "0x1E70FF4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1E71014", Offset = "0x1E71014", VA = "0x1E71014")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1E713E4", Offset = "0x1E713E4", VA = "0x1E713E4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1E710E8", Offset = "0x1E710E8", VA = "0x1E710E8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1E714DC", Offset = "0x1E714DC", VA = "0x1E714DC")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1E716E4", Offset = "0x1E716E4", VA = "0x1E716E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1E71C4C", Offset = "0x1E71C4C", VA = "0x1E71C4C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1E71E0C", Offset = "0x1E71E0C", VA = "0x1E71E0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1E71F04", Offset = "0x1E71F04", VA = "0x1E71F04")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class BendBone
		{
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE34FC", Offset = "0xCE34FC")]
			public Transform transform;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3534", Offset = "0xCE3534")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3534", Offset = "0xCE3534")]
			public float weight;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1E74F34", Offset = "0x1E74F34", VA = "0x1E74F34")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1E74FB4", Offset = "0x1E74FB4", VA = "0x1E74FB4")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1E726C4", Offset = "0x1E726C4", VA = "0x1E726C4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1E72AC8", Offset = "0x1E72AC8", VA = "0x1E72AC8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF910", Offset = "0xCDF910")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCDF948", Offset = "0xCDF948")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF948", Offset = "0xCDF948")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF948", Offset = "0xCDF948")]
		public float positionWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDF9C0", Offset = "0xCDF9C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDF9C0", Offset = "0xCDF9C0")]
		public float bodyWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFA14", Offset = "0xCDFA14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFA14", Offset = "0xCDFA14")]
		public float thighWeight;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFA68", Offset = "0xCDFA68")]
		public bool handsPullBody;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCDFAA0", Offset = "0xCDFAA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFAA0", Offset = "0xCDFAA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFAA0", Offset = "0xCDFAA0")]
		public float rotationWeight;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFB18", Offset = "0xCDFB18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFB18", Offset = "0xCDFB18")]
		public float bodyClampWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFB6C", Offset = "0xCDFB6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFB6C", Offset = "0xCDFB6C")]
		public float headClampWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFBC0", Offset = "0xCDFBC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFBC0", Offset = "0xCDFBC0")]
		public float bendWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFC14", Offset = "0xCDFC14")]
		public BendBone[] bendBones;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCDFC4C", Offset = "0xCDFC4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFC4C", Offset = "0xCDFC4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFC4C", Offset = "0xCDFC4C")]
		public float CCDWeight;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFCC4", Offset = "0xCDFCC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFCC4", Offset = "0xCDFCC4")]
		public float roll;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFD18", Offset = "0xCDFD18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFD18", Offset = "0xCDFD18")]
		public float damper;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFD70", Offset = "0xCDFD70")]
		public Transform[] CCDBones;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCDFDA8", Offset = "0xCDFDA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFDA8", Offset = "0xCDFDA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFDA8", Offset = "0xCDFDA8")]
		public float postStretchWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFE20", Offset = "0xCDFE20")]
		public float maxStretch;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFE58", Offset = "0xCDFE58")]
		public float stretchDamper;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFE90", Offset = "0xCDFE90")]
		public bool fixHead;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDFEC8", Offset = "0xCDFEC8")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCDFF00", Offset = "0xCDFF00")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFF38", Offset = "0xCDFF38")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1E71F0C", Offset = "0x1E71F0C", VA = "0x1E71F0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1E7223C", Offset = "0x1E7223C", VA = "0x1E7223C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1E726FC", Offset = "0x1E726FC", VA = "0x1E726FC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1E72AF0", Offset = "0x1E72AF0", VA = "0x1E72AF0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1E73468", Offset = "0x1E73468", VA = "0x1E73468")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1E737B4", Offset = "0x1E737B4", VA = "0x1E737B4")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1E73B50", Offset = "0x1E73B50", VA = "0x1E73B50")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1E745BC", Offset = "0x1E745BC", VA = "0x1E745BC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1E73194", Offset = "0x1E73194", VA = "0x1E73194")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1E747CC", Offset = "0x1E747CC", VA = "0x1E747CC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1E74478", Offset = "0x1E74478", VA = "0x1E74478")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1E742DC", Offset = "0x1E742DC", VA = "0x1E742DC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1E74B38", Offset = "0x1E74B38", VA = "0x1E74B38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1E74DB8", Offset = "0x1E74DB8", VA = "0x1E74DB8")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000093")]
		public class ChildConstraint
		{
			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE35A8", Offset = "0xCE35A8")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE35B8", Offset = "0xCE35B8")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000B9")]
			public float nominalDistance
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x1E77E78", Offset = "0x1E77E78", VA = "0x1E77E78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE85F8", Offset = "0xCE85F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x1E77E80", Offset = "0x1E77E80", VA = "0x1E77E80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8608", Offset = "0xCE8608")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BA")]
			public bool isRigid
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x1E77E88", Offset = "0x1E77E88", VA = "0x1E77E88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8618", Offset = "0xCE8618")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x1E77E90", Offset = "0x1E77E90", VA = "0x1E77E90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8628", Offset = "0xCE8628")]
				private set
				{
				}
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x1E77E9C", Offset = "0x1E77E9C", VA = "0x1E77E9C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x1E75BFC", Offset = "0x1E75BFC", VA = "0x1E75BFC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x1E7613C", Offset = "0x1E7613C", VA = "0x1E7613C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x1E77B74", Offset = "0x1E77B74", VA = "0x1E77B74")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public enum Smoothing
		{
			[Token(Token = "0x40004C3")]
			None,
			[Token(Token = "0x40004C4")]
			Exponential,
			[Token(Token = "0x40004C5")]
			Cubic
		}

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFF50", Offset = "0xCDFF50")]
		public float pin;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFF68", Offset = "0xCDFF68")]
		public float pull;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFF80", Offset = "0xCDFF80")]
		public float push;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFF98", Offset = "0xCDFF98")]
		public float pushParent;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFFB0", Offset = "0xCDFFB0")]
		public float reach;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001B4")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1E75058", Offset = "0x1E75058", VA = "0x1E75058")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1E75124", Offset = "0x1E75124", VA = "0x1E75124")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1E75230", Offset = "0x1E75230", VA = "0x1E75230")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1E75354", Offset = "0x1E75354", VA = "0x1E75354")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1E75430", Offset = "0x1E75430", VA = "0x1E75430")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1E75534", Offset = "0x1E75534", VA = "0x1E75534")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1E75C54", Offset = "0x1E75C54", VA = "0x1E75C54")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1E756C4", Offset = "0x1E756C4", VA = "0x1E756C4")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1E76340", Offset = "0x1E76340", VA = "0x1E76340")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1E766E4", Offset = "0x1E766E4", VA = "0x1E766E4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1E76AC8", Offset = "0x1E76AC8", VA = "0x1E76AC8")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1E7704C", Offset = "0x1E7704C", VA = "0x1E7704C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1E7761C", Offset = "0x1E7761C", VA = "0x1E7761C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1E778B4", Offset = "0x1E778B4", VA = "0x1E778B4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1E77514", Offset = "0x1E77514", VA = "0x1E77514")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1E76E34", Offset = "0x1E76E34", VA = "0x1E76E34")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1E7749C", Offset = "0x1E7749C", VA = "0x1E7749C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1E7799C", Offset = "0x1E7799C", VA = "0x1E7799C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1E773BC", Offset = "0x1E773BC", VA = "0x1E773BC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1E7779C", Offset = "0x1E7779C", VA = "0x1E7779C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFFC8", Offset = "0xCDFFC8")]
		public float weight;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFFE0", Offset = "0xCDFFE0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000021")]
		public bool initiated
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x2067160", Offset = "0x2067160", VA = "0x2067160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7560", Offset = "0xCE7560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x2067168", Offset = "0x2067168", VA = "0x2067168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7570", Offset = "0xCE7570")]
			private set
			{
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2066F98", Offset = "0x2066F98", VA = "0x2066F98")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2067174", Offset = "0x2067174", VA = "0x2067174")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x20671F8", Offset = "0x20671F8", VA = "0x20671F8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x20672A4", Offset = "0x20672A4", VA = "0x20672A4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x20672B0", Offset = "0x20672B0", VA = "0x20672B0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x20677A0", Offset = "0x20677A0", VA = "0x20677A0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x20679D8", Offset = "0x20679D8", VA = "0x20679D8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2067E74", Offset = "0x2067E74", VA = "0x2067E74")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2067560", Offset = "0x2067560", VA = "0x2067560")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2067680", Offset = "0x2067680", VA = "0x2067680")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IKEffector
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDFFF0", Offset = "0xCDFFF0")]
		public float positionWeight;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0008", Offset = "0xCE0008")]
		public float rotationWeight;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0020", Offset = "0xCE0020")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0030", Offset = "0xCE0030")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000022")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x20684E0", Offset = "0x20684E0", VA = "0x20684E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7580", Offset = "0xCE7580")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x20684E8", Offset = "0x20684E8", VA = "0x20684E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7590", Offset = "0xCE7590")]
			private set
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2068478", Offset = "0x2068478", VA = "0x2068478")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x20684F4", Offset = "0x20684F4", VA = "0x20684F4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x20685C8", Offset = "0x20685C8", VA = "0x20685C8")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2068704", Offset = "0x2068704", VA = "0x2068704")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x206885C", Offset = "0x206885C", VA = "0x206885C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2068B4C", Offset = "0x2068B4C", VA = "0x2068B4C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2068DEC", Offset = "0x2068DEC", VA = "0x2068DEC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2068F2C", Offset = "0x2068F2C", VA = "0x2068F2C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2068FD8", Offset = "0x2068FD8", VA = "0x2068FD8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x206962C", Offset = "0x206962C", VA = "0x206962C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x206969C", Offset = "0x206969C", VA = "0x206969C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x20698B4", Offset = "0x20698B4", VA = "0x20698B4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2069BFC", Offset = "0x2069BFC", VA = "0x2069BFC")]
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
		[Token(Token = "0x2000095")]
		public class BoneMap
		{
			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000BB")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60005E7")]
				[Address(RVA = "0x206A3EC", Offset = "0x206A3EC", VA = "0x206A3EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BC")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x206A558", Offset = "0x206A558", VA = "0x206A558")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BD")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x206AB3C", Offset = "0x206AB3C", VA = "0x206AB3C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x206A3C0", Offset = "0x206A3C0", VA = "0x206A3C0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x206A4B8", Offset = "0x206A4B8", VA = "0x206A4B8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x206A508", Offset = "0x206A508", VA = "0x206A508")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x206A568", Offset = "0x206A568", VA = "0x206A568")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x206A650", Offset = "0x206A650", VA = "0x206A650")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x206A658", Offset = "0x206A658", VA = "0x206A658")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x206A7E8", Offset = "0x206A7E8", VA = "0x206A7E8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x206A8F4", Offset = "0x206A8F4", VA = "0x206A8F4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x206A98C", Offset = "0x206A98C", VA = "0x206A98C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x206AD60", Offset = "0x206AD60", VA = "0x206AD60")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x206AD98", Offset = "0x206AD98", VA = "0x206AD98")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x206ADD0", Offset = "0x206ADD0", VA = "0x206ADD0")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x206ADF8", Offset = "0x206ADF8", VA = "0x206ADF8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x206AF24", Offset = "0x206AF24", VA = "0x206AF24")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x206B26C", Offset = "0x206B26C", VA = "0x206B26C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x206B29C", Offset = "0x206B29C", VA = "0x206B29C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x206B434", Offset = "0x206B434", VA = "0x206B434")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x206B4A4", Offset = "0x206B4A4", VA = "0x206B4A4")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x206B6E8", Offset = "0x206B6E8", VA = "0x206B6E8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x206B910", Offset = "0x206B910", VA = "0x206B910")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x206BA28", Offset = "0x206BA28", VA = "0x206BA28")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x206B068", Offset = "0x206B068", VA = "0x206B068")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x206BBC4", Offset = "0x206BBC4", VA = "0x206BBC4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x206A180", Offset = "0x206A180", VA = "0x206A180", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x206A188", Offset = "0x206A188", VA = "0x206A188", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x206A18C", Offset = "0x206A18C", VA = "0x206A18C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x206A2B0", Offset = "0x206A2B0", VA = "0x206A2B0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x206A3B8", Offset = "0x206A3B8", VA = "0x206A3B8")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0048", Offset = "0xCE0048")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x206BBE0", Offset = "0x206BBE0", VA = "0x206BBE0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x206BC80", Offset = "0x206BC80", VA = "0x206BC80")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x206BD04", Offset = "0x206BD04", VA = "0x206BD04")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x206BD9C", Offset = "0x206BD9C", VA = "0x206BD9C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x206BDB4", Offset = "0x206BDB4", VA = "0x206BDB4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x206BDD0", Offset = "0x206BDD0", VA = "0x206BDD0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x206BE6C", Offset = "0x206BE6C", VA = "0x206BE6C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x206BE84", Offset = "0x206BE84", VA = "0x206BE84")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public enum BoneMapType
		{
			[Token(Token = "0x40004DD")]
			Parent,
			[Token(Token = "0x40004DE")]
			Bone1,
			[Token(Token = "0x40004DF")]
			Bone2,
			[Token(Token = "0x40004E0")]
			Bone3
		}

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0060", Offset = "0xCE0060")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0078", Offset = "0xCE0078")]
		public float weight;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x206BEA8", Offset = "0x206BEA8", VA = "0x206BEA8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x206BF2C", Offset = "0x206BF2C", VA = "0x206BF2C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x206C000", Offset = "0x206C000", VA = "0x206C000")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x206C354", Offset = "0x206C354", VA = "0x206C354")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x206C454", Offset = "0x206C454", VA = "0x206C454")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x206C580", Offset = "0x206C580", VA = "0x206C580")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x206C58C", Offset = "0x206C58C", VA = "0x206C58C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x206C634", Offset = "0x206C634", VA = "0x206C634")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x206C6EC", Offset = "0x206C6EC", VA = "0x206C6EC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x206C95C", Offset = "0x206C95C", VA = "0x206C95C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x206CA14", Offset = "0x206CA14", VA = "0x206CA14")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0090", Offset = "0xCE0090")]
		public int iterations;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE00A8", Offset = "0xCE00A8")]
		public float twistWeight;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x206CB80", Offset = "0x206CB80", VA = "0x206CB80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x206CE70", Offset = "0x206CE70", VA = "0x206CE70")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x206CF8C", Offset = "0x206CF8C", VA = "0x206CF8C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x206D0E4", Offset = "0x206D0E4", VA = "0x206D0E4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x206D0F4", Offset = "0x206D0F4", VA = "0x206D0F4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x206D15C", Offset = "0x206D15C", VA = "0x206D15C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x206D1DC", Offset = "0x206D1DC", VA = "0x206D1DC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x206D830", Offset = "0x206D830", VA = "0x206D830")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x206D868", Offset = "0x206D868", VA = "0x206D868")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x206DB48", Offset = "0x206DB48", VA = "0x206DB48")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x206DEFC", Offset = "0x206DEFC", VA = "0x206DEFC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x206DFE8", Offset = "0x206DFE8", VA = "0x206DFE8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x206E0B0", Offset = "0x206E0B0", VA = "0x206E0B0")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public class Point
		{
			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE35C8", Offset = "0xCE35C8")]
			public float weight;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x206FBD8", Offset = "0x206FBD8", VA = "0x206FBD8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x206FC28", Offset = "0x206FC28", VA = "0x206FC28")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x206FDB0", Offset = "0x206FDB0", VA = "0x206FDB0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x206FDE8", Offset = "0x206FDE8", VA = "0x206FDE8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x206FE20", Offset = "0x206FE20", VA = "0x206FE20")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x206FE70", Offset = "0x206FE70", VA = "0x206FE70")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x206F6AC", Offset = "0x206F6AC", VA = "0x206F6AC")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public class Bone : Point
		{
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000BE")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000607")]
				[Address(RVA = "0x206EC7C", Offset = "0x206EC7C", VA = "0x206EC7C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000608")]
				[Address(RVA = "0x206ED70", Offset = "0x206ED70", VA = "0x206ED70")]
				set
				{
				}
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x206EDF8", Offset = "0x206EDF8", VA = "0x206EDF8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x206F0B8", Offset = "0x206F0B8", VA = "0x206F0B8")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x206F398", Offset = "0x206F398", VA = "0x206F398")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x206F600", Offset = "0x206F600", VA = "0x206F600")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x206F628", Offset = "0x206F628", VA = "0x206F628")]
			public Bone()
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x206F72C", Offset = "0x206F72C", VA = "0x206F72C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x206F7C4", Offset = "0x206F7C4", VA = "0x206F7C4")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class Node : Point
		{
			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x206FB74", Offset = "0x206FB74", VA = "0x206FB74")]
			public Node()
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x206FB78", Offset = "0x206FB78", VA = "0x206FB78")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x206FBA0", Offset = "0x206FBA0", VA = "0x206FBA0")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200009A")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200009B")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE00D0", Offset = "0xCE00D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE00D0", Offset = "0xCE00D0")]
		public float IKPositionWeight;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0124", Offset = "0xCE0124")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000023")]
		public bool initiated
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x206E6CC", Offset = "0x206E6CC", VA = "0x206E6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE75A0", Offset = "0xCE75A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x206E6D4", Offset = "0x206E6D4", VA = "0x206E6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE75B0", Offset = "0xCE75B0")]
			private set
			{
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x206E398", Offset = "0x206E398", VA = "0x206E398")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2066DE4", Offset = "0x2066DE4", VA = "0x2066DE4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2066D0C", Offset = "0x2066D0C", VA = "0x2066D0C")]
		public void Update()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x206E620", Offset = "0x206E620", VA = "0x206E620", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x206E62C", Offset = "0x206E62C", VA = "0x206E62C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x206E638", Offset = "0x206E638", VA = "0x206E638")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x206E640", Offset = "0x206E640", VA = "0x206E640")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x206E6C4", Offset = "0x206E6C4", VA = "0x206E6C4")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000267")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000268")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000269")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600026A")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600026B")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x206E6E0", Offset = "0x206E6E0", VA = "0x206E6E0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x206E6F8", Offset = "0x206E6F8", VA = "0x206E6F8")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x206E834", Offset = "0x206E834", VA = "0x206E834")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x206E8E0", Offset = "0x206E8E0", VA = "0x206E8E0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x206EC64", Offset = "0x206EC64", VA = "0x206EC64")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE016C", Offset = "0xCE016C")]
		public float poleWeight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0184", Offset = "0xCE0184")]
		public float clampWeight;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE019C", Offset = "0xCE019C")]
		public int clampSmoothing;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000024")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x206FFF8", Offset = "0x206FFF8", VA = "0x206FFF8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x20700C4", Offset = "0x20700C4", VA = "0x20700C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		protected override int minBones
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x2070E34", Offset = "0x2070E34", VA = "0x2070E34", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x20713D8", Offset = "0x20713D8", VA = "0x20713D8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x206FEF8", Offset = "0x206FEF8", VA = "0x206FEF8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2070190", Offset = "0x2070190", VA = "0x2070190", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2070410", Offset = "0x2070410", VA = "0x2070410", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2070D80", Offset = "0x2070D80", VA = "0x2070D80")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x20709A8", Offset = "0x20709A8", VA = "0x20709A8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2070E3C", Offset = "0x2070E3C", VA = "0x2070E3C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x207144C", Offset = "0x207144C", VA = "0x207144C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE01B4", Offset = "0xCE01B4")]
		public float IKRotationWeight;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x20714E4", Offset = "0x20714E4", VA = "0x20714E4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2071858", Offset = "0x2071858", VA = "0x2071858")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x20718C4", Offset = "0x20718C4", VA = "0x20718C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2071A20", Offset = "0x2071A20", VA = "0x2071A20", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2071BB8", Offset = "0x2071BB8", VA = "0x2071BB8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2071C04", Offset = "0x2071C04", VA = "0x2071C04", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2071C64", Offset = "0x2071C64", VA = "0x2071C64", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2071FD4", Offset = "0x2071FD4", VA = "0x2071FD4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2072000", Offset = "0x2072000", VA = "0x2072000")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2071CC8", Offset = "0x2071CC8", VA = "0x2071CC8")]
		private void Read()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x207206C", Offset = "0x207206C", VA = "0x207206C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x20721F8", Offset = "0x20721F8", VA = "0x20721F8")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2072348", Offset = "0x2072348", VA = "0x2072348")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x20723F8", Offset = "0x20723F8", VA = "0x20723F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x207247C", Offset = "0x207247C", VA = "0x207247C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2072778", Offset = "0x2072778", VA = "0x2072778")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2072ECC", Offset = "0x2072ECC", VA = "0x2072ECC")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000028")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x20740FC", Offset = "0x20740FC", VA = "0x20740FC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2072ED4", Offset = "0x2072ED4", VA = "0x2072ED4")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x207361C", Offset = "0x207361C", VA = "0x207361C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2073754", Offset = "0x2073754", VA = "0x2073754", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x20737EC", Offset = "0x20737EC", VA = "0x20737EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2073D94", Offset = "0x2073D94", VA = "0x2073D94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2074104", Offset = "0x2074104", VA = "0x2074104")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2072FA8", Offset = "0x2072FA8", VA = "0x2072FA8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2073700", Offset = "0x2073700", VA = "0x2073700")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x20740A0", Offset = "0x20740A0", VA = "0x20740A0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2073444", Offset = "0x2073444", VA = "0x2073444")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2074944", Offset = "0x2074944", VA = "0x2074944")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2074A54", Offset = "0x2074A54", VA = "0x2074A54")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2074B80", Offset = "0x2074B80", VA = "0x2074B80")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2074C98", Offset = "0x2074C98", VA = "0x2074C98")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2073AFC", Offset = "0x2073AFC", VA = "0x2073AFC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2073C48", Offset = "0x2073C48", VA = "0x2073C48")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2074E84", Offset = "0x2074E84", VA = "0x2074E84")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x20743BC", Offset = "0x20743BC", VA = "0x20743BC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x20736F0", Offset = "0x20736F0", VA = "0x20736F0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x20755EC", Offset = "0x20755EC", VA = "0x20755EC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2075058", Offset = "0x2075058", VA = "0x2075058")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x207421C", Offset = "0x207421C", VA = "0x207421C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x20742F8", Offset = "0x20742F8", VA = "0x20742F8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x20756B8", Offset = "0x20756B8", VA = "0x20756B8")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE01CC", Offset = "0xCE01CC")]
		public float rootPin;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1FDFEE8", Offset = "0x1FDFEE8", VA = "0x1FDFEE8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1FE07B4", Offset = "0x1FE07B4", VA = "0x1FE07B4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1FE084C", Offset = "0x1FE084C", VA = "0x1FE084C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1FE08EC", Offset = "0x1FE08EC", VA = "0x1FE08EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1FE09EC", Offset = "0x1FE09EC", VA = "0x1FE09EC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1FE0A88", Offset = "0x1FE0A88", VA = "0x1FE0A88", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1FE0FF0", Offset = "0x1FE0FF0", VA = "0x1FE0FF0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1FE11F0", Offset = "0x1FE11F0", VA = "0x1FE11F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1FE10A0", Offset = "0x1FE10A0", VA = "0x1FE10A0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1FE0CBC", Offset = "0x1FE0CBC", VA = "0x1FE0CBC")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1FE1288", Offset = "0x1FE1288", VA = "0x1FE1288")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE01E4", Offset = "0xCE01E4")]
		public int iterations;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1FE12F0", Offset = "0x1FE12F0", VA = "0x1FE12F0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1FE13E4", Offset = "0x1FE13E4", VA = "0x1FE13E4")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1FE1440", Offset = "0x1FE1440", VA = "0x1FE1440")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1FE1574", Offset = "0x1FE1574", VA = "0x1FE1574")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1FE15D0", Offset = "0x1FE15D0", VA = "0x1FE15D0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1FE1650", Offset = "0x1FE1650", VA = "0x1FE1650", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1FE17D8", Offset = "0x1FE17D8", VA = "0x1FE17D8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1FE194C", Offset = "0x1FE194C", VA = "0x1FE194C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1FE1B50", Offset = "0x1FE1B50", VA = "0x1FE1B50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1FE1C28", Offset = "0x1FE1C28", VA = "0x1FE1C28", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1FE1D14", Offset = "0x1FE1D14", VA = "0x1FE1D14", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1FE1E88", Offset = "0x1FE1E88", VA = "0x1FE1E88", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1FE2050", Offset = "0x1FE2050", VA = "0x1FE2050", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1FE229C", Offset = "0x1FE229C", VA = "0x1FE229C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1FE2578", Offset = "0x1FE2578", VA = "0x1FE2578", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1FE25BC", Offset = "0x1FE25BC", VA = "0x1FE25BC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1FE26AC", Offset = "0x1FE26AC", VA = "0x1FE26AC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400023D")]
		Body,
		[Token(Token = "0x400023E")]
		LeftShoulder,
		[Token(Token = "0x400023F")]
		RightShoulder,
		[Token(Token = "0x4000240")]
		LeftThigh,
		[Token(Token = "0x4000241")]
		RightThigh,
		[Token(Token = "0x4000242")]
		LeftHand,
		[Token(Token = "0x4000243")]
		RightHand,
		[Token(Token = "0x4000244")]
		LeftFoot,
		[Token(Token = "0x4000245")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000247")]
		LeftArm,
		[Token(Token = "0x4000248")]
		RightArm,
		[Token(Token = "0x4000249")]
		LeftLeg,
		[Token(Token = "0x400024A")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE01FC", Offset = "0xCE01FC")]
		public float spineStiffness;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0214", Offset = "0xCE0214")]
		public float pullBodyVertical;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE022C", Offset = "0xCE022C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0244", Offset = "0xCE0244")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000029")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1FE2784", Offset = "0x1FE2784", VA = "0x1FE2784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1FE28CC", Offset = "0x1FE28CC", VA = "0x1FE28CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1FE28D4", Offset = "0x1FE28D4", VA = "0x1FE28D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1FE28DC", Offset = "0x1FE28DC", VA = "0x1FE28DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1FE28E4", Offset = "0x1FE28E4", VA = "0x1FE28E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1FE28EC", Offset = "0x1FE28EC", VA = "0x1FE28EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1FE28F4", Offset = "0x1FE28F4", VA = "0x1FE28F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1FE28FC", Offset = "0x1FE28FC", VA = "0x1FE28FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1FE2904", Offset = "0x1FE2904", VA = "0x1FE2904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1FE290C", Offset = "0x1FE290C", VA = "0x1FE290C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1FE2944", Offset = "0x1FE2944", VA = "0x1FE2944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1FE297C", Offset = "0x1FE297C", VA = "0x1FE297C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1FE29B4", Offset = "0x1FE29B4", VA = "0x1FE29B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1FE29EC", Offset = "0x1FE29EC", VA = "0x1FE29EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1FE2A20", Offset = "0x1FE2A20", VA = "0x1FE2A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1FE2A58", Offset = "0x1FE2A58", VA = "0x1FE2A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1FE2A90", Offset = "0x1FE2A90", VA = "0x1FE2A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1FE2AC8", Offset = "0x1FE2AC8", VA = "0x1FE2AC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1FE4A8C", Offset = "0x1FE4A8C", VA = "0x1FE4A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE75C0", Offset = "0xCE75C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1FE4A98", Offset = "0x1FE4A98", VA = "0x1FE4A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE75D0", Offset = "0xCE75D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1FE2AFC", Offset = "0x1FE2AFC", VA = "0x1FE2AFC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1FE2C08", Offset = "0x1FE2C08", VA = "0x1FE2C08")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1FE2B50", Offset = "0x1FE2B50", VA = "0x1FE2B50")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1FE2CE4", Offset = "0x1FE2CE4", VA = "0x1FE2CE4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1FE278C", Offset = "0x1FE278C", VA = "0x1FE278C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1FE2DB4", Offset = "0x1FE2DB4", VA = "0x1FE2DB4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1FE2E6C", Offset = "0x1FE2E6C", VA = "0x1FE2E6C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1FE2F20", Offset = "0x1FE2F20", VA = "0x1FE2F20")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1FE2FD4", Offset = "0x1FE2FD4", VA = "0x1FE2FD4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1FE2FDC", Offset = "0x1FE2FDC", VA = "0x1FE2FDC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1FE3010", Offset = "0x1FE3010", VA = "0x1FE3010")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1FE30D8", Offset = "0x1FE30D8", VA = "0x1FE30D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1FE3268", Offset = "0x1FE3268", VA = "0x1FE3268")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1FE43A4", Offset = "0x1FE43A4", VA = "0x1FE43A4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1FE4838", Offset = "0x1FE4838", VA = "0x1FE4838")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1FE4898", Offset = "0x1FE4898", VA = "0x1FE4898")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1FE46B8", Offset = "0x1FE46B8", VA = "0x1FE46B8")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1FE4778", Offset = "0x1FE4778", VA = "0x1FE4778")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1FE4AA4", Offset = "0x1FE4AA4", VA = "0x1FE4AA4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1FE4B80", Offset = "0x1FE4B80", VA = "0x1FE4B80", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1FE4CC8", Offset = "0x1FE4CC8", VA = "0x1FE4CC8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1FE4E58", Offset = "0x1FE4E58", VA = "0x1FE4E58")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1FE5058", Offset = "0x1FE5058", VA = "0x1FE5058")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1FE5258", Offset = "0x1FE5258", VA = "0x1FE5258", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1FE558C", Offset = "0x1FE558C", VA = "0x1FE558C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1FE568C", Offset = "0x1FE568C", VA = "0x1FE568C")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700003C")]
		protected virtual int minBones
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x1FE5EDC", Offset = "0x1FE5EDC", VA = "0x1FE5EDC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1FE5EE4", Offset = "0x1FE5EE4", VA = "0x1FE5EE4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1FE5EEC", Offset = "0x1FE5EEC", VA = "0x1FE5EEC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1FE647C", Offset = "0x1FE647C", VA = "0x1FE647C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000040")]
		protected float positionOffset
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x1FE65B0", Offset = "0x1FE65B0", VA = "0x1FE65B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1FE5698", Offset = "0x1FE5698", VA = "0x1FE5698")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1FE582C", Offset = "0x1FE582C", VA = "0x1FE582C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1FE5968", Offset = "0x1FE5968", VA = "0x1FE5968", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1FE59D4", Offset = "0x1FE59D4", VA = "0x1FE59D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1FE5A54", Offset = "0x1FE5A54", VA = "0x1FE5A54", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1FE5DE0", Offset = "0x1FE5DE0", VA = "0x1FE5DE0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1FE5DE8", Offset = "0x1FE5DE8", VA = "0x1FE5DE8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1FE5EF4", Offset = "0x1FE5EF4", VA = "0x1FE5EF4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1FE5EF8", Offset = "0x1FE5EF8", VA = "0x1FE5EF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1FE5EFC", Offset = "0x1FE5EFC", VA = "0x1FE5EFC")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1FE6674", Offset = "0x1FE6674", VA = "0x1FE6674")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1FE6A18", Offset = "0x1FE6A18", VA = "0x1FE6A18")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1FE6CCC", Offset = "0x1FE6CCC", VA = "0x1FE6CCC")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0254", Offset = "0xCE0254")]
		public float IKRotationWeight;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1FE6D3C", Offset = "0x1FE6D3C", VA = "0x1FE6D3C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1FE70B0", Offset = "0x1FE70B0", VA = "0x1FE70B0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1FE7120", Offset = "0x1FE7120", VA = "0x1FE7120", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1FE727C", Offset = "0x1FE727C", VA = "0x1FE727C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1FE7414", Offset = "0x1FE7414", VA = "0x1FE7414", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1FE7470", Offset = "0x1FE7470", VA = "0x1FE7470", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1FE74E0", Offset = "0x1FE74E0", VA = "0x1FE74E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1FE784C", Offset = "0x1FE784C", VA = "0x1FE784C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1FE7878", Offset = "0x1FE7878", VA = "0x1FE7878")]
		private void Solve()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1FE7544", Offset = "0x1FE7544", VA = "0x1FE7544")]
		private void Read()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1FE797C", Offset = "0x1FE797C", VA = "0x1FE797C")]
		private void Write()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1FE81B8", Offset = "0x1FE81B8", VA = "0x1FE81B8")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200009C")]
		public enum BendModifier
		{
			[Token(Token = "0x40004F1")]
			Animation,
			[Token(Token = "0x40004F2")]
			Target,
			[Token(Token = "0x40004F3")]
			Parent,
			[Token(Token = "0x40004F4")]
			Arm,
			[Token(Token = "0x40004F5")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200009D")]
		public struct AxisDirection
		{
			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1FE9B20", Offset = "0x1FE9B20", VA = "0x1FE9B20")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE026C", Offset = "0xCE026C")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0284", Offset = "0xCE0284")]
		public float bendModifierWeight;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000041")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1FE9B04", Offset = "0x1FE9B04", VA = "0x1FE9B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1FE8400", Offset = "0x1FE8400", VA = "0x1FE8400")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1FE8450", Offset = "0x1FE8450", VA = "0x1FE8450")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1FE8564", Offset = "0x1FE8564", VA = "0x1FE8564", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1FE8BD4", Offset = "0x1FE8BD4", VA = "0x1FE8BD4", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1FE97B0", Offset = "0x1FE97B0", VA = "0x1FE97B0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1FE98F8", Offset = "0x1FE98F8", VA = "0x1FE98F8")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1FE9A7C", Offset = "0x1FE9A7C", VA = "0x1FE9A7C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1FE88E0", Offset = "0x1FE88E0", VA = "0x1FE88E0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1FE8D00", Offset = "0x1FE8D00", VA = "0x1FE8D00")]
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
		[Token(Token = "0x200009E")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000BF")]
			public Vector3 forward
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x1FEB9C0", Offset = "0x1FEB9C0", VA = "0x1FEB9C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1FEC10C", Offset = "0x1FEC10C", VA = "0x1FEC10C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1FEAD5C", Offset = "0x1FEAD5C", VA = "0x1FEAD5C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1FEB098", Offset = "0x1FEB098", VA = "0x1FEB098")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1FEBDC4", Offset = "0x1FEBDC4", VA = "0x1FEBDC4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE029C", Offset = "0xCE029C")]
		public float bodyWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE02B4", Offset = "0xCE02B4")]
		public float headWeight;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE02CC", Offset = "0xCE02CC")]
		public float eyesWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE02E4", Offset = "0xCE02E4")]
		public float clampWeight;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE02FC", Offset = "0xCE02FC")]
		public float clampWeightHead;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0314", Offset = "0xCE0314")]
		public float clampWeightEyes;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE032C", Offset = "0xCE032C")]
		public int clampSmoothing;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000042")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1FEA4C0", Offset = "0x1FEA4C0", VA = "0x1FEA4C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1FEA698", Offset = "0x1FEA698", VA = "0x1FEA698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		private bool headIsValid
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1FEA5A4", Offset = "0x1FEA5A4", VA = "0x1FEA5A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1FEA6BC", Offset = "0x1FEA6BC", VA = "0x1FEA6BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1FEA5B4", Offset = "0x1FEA5B4", VA = "0x1FEA5B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1FEA738", Offset = "0x1FEA738", VA = "0x1FEA738")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1FE9B80", Offset = "0x1FE9B80", VA = "0x1FE9B80")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1FE9C04", Offset = "0x1FE9C04", VA = "0x1FE9C04")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1FE9CB0", Offset = "0x1FE9CB0", VA = "0x1FE9CB0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1FE9D78", Offset = "0x1FE9D78", VA = "0x1FE9D78")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1FE9E64", Offset = "0x1FE9E64", VA = "0x1FE9E64")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1FE9F70", Offset = "0x1FE9F70", VA = "0x1FE9F70")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1FEA0B8", Offset = "0x1FEA0B8", VA = "0x1FEA0B8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1FEA1E8", Offset = "0x1FEA1E8", VA = "0x1FEA1E8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1FEA32C", Offset = "0x1FEA32C", VA = "0x1FEA32C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1FEA75C", Offset = "0x1FEA75C", VA = "0x1FEA75C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1FEA994", Offset = "0x1FEA994", VA = "0x1FEA994", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1FEAB34", Offset = "0x1FEAB34", VA = "0x1FEAB34")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1FEAD88", Offset = "0x1FEAD88", VA = "0x1FEAD88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1FEB1D4", Offset = "0x1FEB1D4", VA = "0x1FEB1D4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1FEB2D8", Offset = "0x1FEB2D8", VA = "0x1FEB2D8")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1FEB504", Offset = "0x1FEB504", VA = "0x1FEB504")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1FEB760", Offset = "0x1FEB760", VA = "0x1FEB760")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1FEBA8C", Offset = "0x1FEBA8C", VA = "0x1FEBA8C")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1FEABE4", Offset = "0x1FEABE4", VA = "0x1FEABE4")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1FEBF2C", Offset = "0x1FEBF2C", VA = "0x1FEBF2C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1FED6E4", Offset = "0x1FED6E4", VA = "0x1FED6E4")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1FEE28C", Offset = "0x1FEE28C", VA = "0x1FEE28C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1FE8498", Offset = "0x1FE8498", VA = "0x1FE8498")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1FEE354", Offset = "0x1FEE354", VA = "0x1FEE354")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0344", Offset = "0xCE0344")]
		public float IKRotationWeight;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1FEC114", Offset = "0x1FEC114", VA = "0x1FEC114")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1FEC304", Offset = "0x1FEC304", VA = "0x1FEC304")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1FEC4B8", Offset = "0x1FEC4B8", VA = "0x1FEC4B8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1FEC4C4", Offset = "0x1FEC4C4", VA = "0x1FEC4C4")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1FEC548", Offset = "0x1FEC548", VA = "0x1FEC548")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1FEC554", Offset = "0x1FEC554", VA = "0x1FEC554")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1FEC55C", Offset = "0x1FEC55C", VA = "0x1FEC55C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1FEC660", Offset = "0x1FEC660", VA = "0x1FEC660", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1FEC780", Offset = "0x1FEC780", VA = "0x1FEC780", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1FEC7CC", Offset = "0x1FEC7CC", VA = "0x1FEC7CC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1FEC82C", Offset = "0x1FEC82C", VA = "0x1FEC82C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1FECC08", Offset = "0x1FECC08", VA = "0x1FECC08")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1FECC60", Offset = "0x1FECC60", VA = "0x1FECC60")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1FED208", Offset = "0x1FED208", VA = "0x1FED208")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1FED420", Offset = "0x1FED420", VA = "0x1FED420", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1FED5DC", Offset = "0x1FED5DC", VA = "0x1FED5DC")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1FED558", Offset = "0x1FED558", VA = "0x1FED558")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1FED884", Offset = "0x1FED884", VA = "0x1FED884", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1FEE348", Offset = "0x1FEE348", VA = "0x1FEE348", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1FEE34C", Offset = "0x1FEE34C", VA = "0x1FEE34C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1FEE350", Offset = "0x1FEE350", VA = "0x1FEE350", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1FEDF90", Offset = "0x1FEDF90", VA = "0x1FEDF90")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1FE996C", Offset = "0x1FE996C", VA = "0x1FE996C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000A0")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000D0")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400067A")]
				YawPitch,
				[Token(Token = "0x400067B")]
				FromTo
			}

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE35E0", Offset = "0xCE35E0")]
			public Transform target;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3618", Offset = "0xCE3618")]
			public Transform bendGoal;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3650", Offset = "0xCE3650")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3650", Offset = "0xCE3650")]
			public float positionWeight;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE36A4", Offset = "0xCE36A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE36A4", Offset = "0xCE36A4")]
			public float rotationWeight;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE36F8", Offset = "0xCE36F8")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3730", Offset = "0xCE3730")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3730", Offset = "0xCE3730")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3784", Offset = "0xCE3784")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3784", Offset = "0xCE3784")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE37D8", Offset = "0xCE37D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE37D8", Offset = "0xCE37D8")]
			public float bendGoalWeight;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE382C", Offset = "0xCE382C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE382C", Offset = "0xCE382C")]
			public float swivelOffset;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3888", Offset = "0xCE3888")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE38C0", Offset = "0xCE38C0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE38F8", Offset = "0xCE38F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE38F8", Offset = "0xCE38F8")]
			public float armLengthMlp;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3950", Offset = "0xCE3950")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE39C8", Offset = "0xCE39C8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE39D8", Offset = "0xCE39D8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000515")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000516")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000C0")]
			public Vector3 position
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0x1FF3CE8", Offset = "0x1FF3CE8", VA = "0x1FF3CE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8638", Offset = "0xCE8638")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x1FF3CF4", Offset = "0x1FF3CF4", VA = "0x1FF3CF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8648", Offset = "0xCE8648")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x1FF3D00", Offset = "0x1FF3D00", VA = "0x1FF3D00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8658", Offset = "0xCE8658")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x1FF3D0C", Offset = "0x1FF3D0C", VA = "0x1FF3D0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8668", Offset = "0xCE8668")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x1FF3D18", Offset = "0x1FF3D18", VA = "0x1FF3D18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x1FF3D4C", Offset = "0x1FF3D4C", VA = "0x1FF3D4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x1FF3D8C", Offset = "0x1FF3D8C", VA = "0x1FF3D8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private VirtualBone hand
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x1FF3DD8", Offset = "0x1FF3DD8", VA = "0x1FF3DD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1FF3E24", Offset = "0x1FF3E24", VA = "0x1FF3E24", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1FF45A4", Offset = "0x1FF45A4", VA = "0x1FF45A4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1FF4798", Offset = "0x1FF4798", VA = "0x1FF4798", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1FF4844", Offset = "0x1FF4844", VA = "0x1FF4844")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1FF2058", Offset = "0x1FF2058", VA = "0x1FF2058")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1FF5490", Offset = "0x1FF5490", VA = "0x1FF5490", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1FF5500", Offset = "0x1FF5500", VA = "0x1FF5500", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1FF4C5C", Offset = "0x1FF4C5C", VA = "0x1FF4C5C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x1FF4D34", Offset = "0x1FF4D34", VA = "0x1FF4D34")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x1FF5720", Offset = "0x1FF5720", VA = "0x1FF5720")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x1FF3BC0", Offset = "0x1FF3BC0", VA = "0x1FF3BC0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A1")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE39E8", Offset = "0xCE39E8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE39F8", Offset = "0xCE39F8")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000C6")]
			public float sqrMag
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x1FF58E0", Offset = "0x1FF58E0", VA = "0x1FF58E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8678", Offset = "0xCE8678")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x1FF58E8", Offset = "0x1FF58E8", VA = "0x1FF58E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8688", Offset = "0xCE8688")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public float mag
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x1FF58F0", Offset = "0x1FF58F0", VA = "0x1FF58F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8698", Offset = "0xCE8698")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x1FF58F8", Offset = "0x1FF58F8", VA = "0x1FF58F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE86A8", Offset = "0xCE86A8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000638")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000639")]
			public abstract void PreSolve();

			[Token(Token = "0x600063A")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600063B")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600063C")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x1FE80E4", Offset = "0x1FE80E4", VA = "0x1FE80E4")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1FF5900", Offset = "0x1FF5900", VA = "0x1FF5900")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x1FF5A6C", Offset = "0x1FF5A6C", VA = "0x1FF5A6C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1FF5B18", Offset = "0x1FF5B18", VA = "0x1FF5B18")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x1FF1E68", Offset = "0x1FF1E68", VA = "0x1FF1E68")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x1FF52EC", Offset = "0x1FF52EC", VA = "0x1FF52EC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x1FF5B6C", Offset = "0x1FF5B6C", VA = "0x1FF5B6C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1FF5CB0", Offset = "0x1FF5CB0", VA = "0x1FF5CB0")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x1FF5848", Offset = "0x1FF5848", VA = "0x1FF5848")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class Footstep
		{
			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE3A18", Offset = "0xCE3A18")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000C8")]
			public bool isStepping
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x1FF5CD8", Offset = "0x1FF5CD8", VA = "0x1FF5CD8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C9")]
			public float stepProgress
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x1FF5CEC", Offset = "0x1FF5CEC", VA = "0x1FF5CEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE86B8", Offset = "0xCE86B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x1FF5CF4", Offset = "0x1FF5CF4", VA = "0x1FF5CF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE86C8", Offset = "0xCE86C8")]
				private set
				{
				}
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1FF5CFC", Offset = "0x1FF5CFC", VA = "0x1FF5CFC")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1FF5E8C", Offset = "0x1FF5E8C", VA = "0x1FF5E8C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1FF5ED4", Offset = "0x1FF5ED4", VA = "0x1FF5ED4")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x1FF5FD4", Offset = "0x1FF5FD4", VA = "0x1FF5FD4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1FF61AC", Offset = "0x1FF61AC", VA = "0x1FF61AC")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1FF6398", Offset = "0x1FF6398", VA = "0x1FF6398")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3A28", Offset = "0xCE3A28")]
			public Transform target;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3A60", Offset = "0xCE3A60")]
			public Transform bendGoal;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3A98", Offset = "0xCE3A98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3A98", Offset = "0xCE3A98")]
			public float positionWeight;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3AEC", Offset = "0xCE3AEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3AEC", Offset = "0xCE3AEC")]
			public float rotationWeight;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3B40", Offset = "0xCE3B40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3B40", Offset = "0xCE3B40")]
			public float bendGoalWeight;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3B94", Offset = "0xCE3B94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3B94", Offset = "0xCE3B94")]
			public float swivelOffset;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3BF0", Offset = "0xCE3BF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3BF0", Offset = "0xCE3BF0")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3C44", Offset = "0xCE3C44")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3C44", Offset = "0xCE3C44")]
			public float legLengthMlp;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3C9C", Offset = "0xCE3C9C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE3D34", Offset = "0xCE3D34")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE3D44", Offset = "0xCE3D44")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE3D54", Offset = "0xCE3D54")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE3D64", Offset = "0xCE3D64")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000CA")]
			public Vector3 position
			{
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x1FF65B4", Offset = "0x1FF65B4", VA = "0x1FF65B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE86D8", Offset = "0xCE86D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x1FF65C0", Offset = "0x1FF65C0", VA = "0x1FF65C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE86E8", Offset = "0xCE86E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x1FF65CC", Offset = "0x1FF65CC", VA = "0x1FF65CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE86F8", Offset = "0xCE86F8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x1FF65D8", Offset = "0x1FF65D8", VA = "0x1FF65D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8708", Offset = "0xCE8708")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			public bool hasToes
			{
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x1FF65E4", Offset = "0x1FF65E4", VA = "0x1FF65E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8718", Offset = "0xCE8718")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000658")]
				[Address(RVA = "0x1FF65EC", Offset = "0x1FF65EC", VA = "0x1FF65EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8728", Offset = "0xCE8728")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0x1FF65F8", Offset = "0x1FF65F8", VA = "0x1FF65F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private VirtualBone calf
			{
				[Token(Token = "0x600065A")]
				[Address(RVA = "0x1FF662C", Offset = "0x1FF662C", VA = "0x1FF662C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private VirtualBone foot
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0x1FF6664", Offset = "0x1FF6664", VA = "0x1FF6664")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private VirtualBone toes
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0x1FF669C", Offset = "0x1FF669C", VA = "0x1FF669C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x1FF1E28", Offset = "0x1FF1E28", VA = "0x1FF1E28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x1FF66D4", Offset = "0x1FF66D4", VA = "0x1FF66D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8738", Offset = "0xCE8738")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x1FF66E0", Offset = "0x1FF66E0", VA = "0x1FF66E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8748", Offset = "0xCE8748")]
				private set
				{
				}
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1FF66EC", Offset = "0x1FF66EC", VA = "0x1FF66EC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1FF6D30", Offset = "0x1FF6D30", VA = "0x1FF6D30", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1FF7540", Offset = "0x1FF7540", VA = "0x1FF7540", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1FF743C", Offset = "0x1FF743C", VA = "0x1FF743C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x1FF7204", Offset = "0x1FF7204", VA = "0x1FF7204")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1FE7B08", Offset = "0x1FE7B08", VA = "0x1FE7B08")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1FF7AF8", Offset = "0x1FF7AF8", VA = "0x1FF7AF8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1FF7FF8", Offset = "0x1FF7FF8", VA = "0x1FF7FF8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1FF8214", Offset = "0x1FF8214", VA = "0x1FF8214", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1FE830C", Offset = "0x1FE830C", VA = "0x1FE830C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A4")]
		public class Locomotion
		{
			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3D74", Offset = "0xCE3D74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3D74", Offset = "0xCE3D74")]
			public float weight;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3DC8", Offset = "0xCE3DC8")]
			public float footDistance;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3E00", Offset = "0xCE3E00")]
			public float stepThreshold;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3E38", Offset = "0xCE3E38")]
			public float angleThreshold;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3E70", Offset = "0xCE3E70")]
			public float comAngleMlp;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3EA8", Offset = "0xCE3EA8")]
			public float maxVelocity;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3EE0", Offset = "0xCE3EE0")]
			public float velocityFactor;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3F18", Offset = "0xCE3F18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE3F18", Offset = "0xCE3F18")]
			public float maxLegStretch;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3F70", Offset = "0xCE3F70")]
			public float rootSpeed;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3FA8", Offset = "0xCE3FA8")]
			public float stepSpeed;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3FE0", Offset = "0xCE3FE0")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4018", Offset = "0xCE4018")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4050", Offset = "0xCE4050")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4050", Offset = "0xCE4050")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE40A8", Offset = "0xCE40A8")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE40E0", Offset = "0xCE40E0")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4118", Offset = "0xCE4118")]
			public Vector3 offset;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4190", Offset = "0xCE4190")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE41C8", Offset = "0xCE41C8")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE4200", Offset = "0xCE4200")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000D3")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x1D7D4E8", Offset = "0x1D7D4E8", VA = "0x1D7D4E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8758", Offset = "0xCE8758")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x1D7D4F4", Offset = "0x1D7D4F4", VA = "0x1D7D4F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8768", Offset = "0xCE8768")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x1D7F9CC", Offset = "0x1D7F9CC", VA = "0x1D7F9CC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D5")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x1D7FA0C", Offset = "0x1D7FA0C", VA = "0x1D7FA0C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D6")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x1D7FA50", Offset = "0x1D7FA50", VA = "0x1D7FA50")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000D7")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x1D7FA90", Offset = "0x1D7FA90", VA = "0x1D7FA90")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1D7D500", Offset = "0x1D7D500", VA = "0x1D7D500")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1D7D800", Offset = "0x1D7D800", VA = "0x1D7D800")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1D7DA7C", Offset = "0x1D7DA7C", VA = "0x1D7DA7C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1D7DE54", Offset = "0x1D7DE54", VA = "0x1D7DE54")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1D7E004", Offset = "0x1D7E004", VA = "0x1D7E004")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1D7F5B8", Offset = "0x1D7F5B8", VA = "0x1D7F5B8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1D7F75C", Offset = "0x1D7F75C", VA = "0x1D7F75C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1D7F800", Offset = "0x1D7F800", VA = "0x1D7F800")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1D7FAD4", Offset = "0x1D7FAD4", VA = "0x1D7FAD4")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4210", Offset = "0xCE4210")]
			public Transform headTarget;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4248", Offset = "0xCE4248")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4280", Offset = "0xCE4280")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4280", Offset = "0xCE4280")]
			public float positionWeight;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE42D4", Offset = "0xCE42D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE42D4", Offset = "0xCE42D4")]
			public float rotationWeight;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4328", Offset = "0xCE4328")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4328", Offset = "0xCE4328")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE437C", Offset = "0xCE437C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE437C", Offset = "0xCE437C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE43D0", Offset = "0xCE43D0")]
			public Transform chestGoal;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4408", Offset = "0xCE4408")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4408", Offset = "0xCE4408")]
			public float chestGoalWeight;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE445C", Offset = "0xCE445C")]
			public float minHeadHeight;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4494", Offset = "0xCE4494")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4494", Offset = "0xCE4494")]
			public float bodyPosStiffness;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE44E8", Offset = "0xCE44E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE44E8", Offset = "0xCE44E8")]
			public float bodyRotStiffness;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE453C", Offset = "0xCE453C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCE453C", Offset = "0xCE453C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE453C", Offset = "0xCE453C")]
			public float neckStiffness;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE45B4", Offset = "0xCE45B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE45B4", Offset = "0xCE45B4")]
			public float rotateChestByHands;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4608", Offset = "0xCE4608")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4608", Offset = "0xCE4608")]
			public float chestClampWeight;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE465C", Offset = "0xCE465C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE465C", Offset = "0xCE465C")]
			public float headClampWeight;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE46B0", Offset = "0xCE46B0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE46E8", Offset = "0xCE46E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE46E8", Offset = "0xCE46E8")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE473C", Offset = "0xCE473C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE473C", Offset = "0xCE473C")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE4874", Offset = "0xCE4874")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x170000D8")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0x1D7F538", Offset = "0x1D7F538", VA = "0x1D7F538")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x1D7FBB8", Offset = "0x1D7FBB8", VA = "0x1D7FBB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			public VirtualBone chest
			{
				[Token(Token = "0x600067B")]
				[Address(RVA = "0x1D7FBF8", Offset = "0x1D7FBF8", VA = "0x1D7FBF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private VirtualBone neck
			{
				[Token(Token = "0x600067C")]
				[Address(RVA = "0x1D7FC4C", Offset = "0x1D7FC4C", VA = "0x1D7FC4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			public VirtualBone head
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x1D7F578", Offset = "0x1D7F578", VA = "0x1D7F578")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x1D7FC8C", Offset = "0x1D7FC8C", VA = "0x1D7FC8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8778", Offset = "0xCE8778")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x1D7FCA0", Offset = "0x1D7FCA0", VA = "0x1D7FCA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8788", Offset = "0xCE8788")]
				private set
				{
				}
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1D7FCB4", Offset = "0x1D7FCB4", VA = "0x1D7FCB4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1D80810", Offset = "0x1D80810", VA = "0x1D80810", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1D80A20", Offset = "0x1D80A20", VA = "0x1D80A20", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1D80FD8", Offset = "0x1D80FD8", VA = "0x1D80FD8")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x1D8158C", Offset = "0x1D8158C", VA = "0x1D8158C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1D81EF4", Offset = "0x1D81EF4", VA = "0x1D81EF4")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x1D82710", Offset = "0x1D82710", VA = "0x1D82710")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1D8348C", Offset = "0x1D8348C", VA = "0x1D8348C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1D83668", Offset = "0x1D83668", VA = "0x1D83668", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1D81208", Offset = "0x1D81208", VA = "0x1D81208")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1D82354", Offset = "0x1D82354", VA = "0x1D82354")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1D81AE8", Offset = "0x1D81AE8", VA = "0x1D81AE8")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1D83760", Offset = "0x1D83760", VA = "0x1D83760")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1D824C4", Offset = "0x1D824C4", VA = "0x1D824C4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1D820A0", Offset = "0x1D820A0", VA = "0x1D820A0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1D83C7C", Offset = "0x1D83C7C", VA = "0x1D83C7C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000599")]
			Pelvis,
			[Token(Token = "0x400059A")]
			Chest,
			[Token(Token = "0x400059B")]
			Head,
			[Token(Token = "0x400059C")]
			LeftHand,
			[Token(Token = "0x400059D")]
			RightHand,
			[Token(Token = "0x400059E")]
			LeftFoot,
			[Token(Token = "0x400059F")]
			RightFoot,
			[Token(Token = "0x40005A0")]
			LeftHeel,
			[Token(Token = "0x40005A1")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public enum RotationOffset
		{
			[Token(Token = "0x40005A3")]
			Pelvis,
			[Token(Token = "0x40005A4")]
			Chest,
			[Token(Token = "0x40005A5")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000A8")]
		public class VirtualBone
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1D80774", Offset = "0x1D80774", VA = "0x1D80774")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1D807F0", Offset = "0x1D807F0", VA = "0x1D807F0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1D83E4C", Offset = "0x1D83E4C", VA = "0x1D83E4C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1D840DC", Offset = "0x1D840DC", VA = "0x1D840DC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1D83A94", Offset = "0x1D83A94", VA = "0x1D83A94")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1D843C8", Offset = "0x1D843C8", VA = "0x1D843C8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1D84600", Offset = "0x1D84600", VA = "0x1D84600")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1D84834", Offset = "0x1D84834", VA = "0x1D84834")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1D82EE0", Offset = "0x1D82EE0", VA = "0x1D82EE0")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1D848EC", Offset = "0x1D848EC", VA = "0x1D848EC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1D82A98", Offset = "0x1D82A98", VA = "0x1D82A98")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1D84B04", Offset = "0x1D84B04", VA = "0x1D84B04")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1D84C0C", Offset = "0x1D84C0C", VA = "0x1D84C0C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE035C", Offset = "0xCE035C")]
		public bool plantFeet;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0394", Offset = "0xCE0394")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE03A4", Offset = "0xCE03A4")]
		public Spine spine;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE03DC", Offset = "0xCE03DC")]
		public Arm leftArm;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0414", Offset = "0xCE0414")]
		public Arm rightArm;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE044C", Offset = "0xCE044C")]
		public Leg leftLeg;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0484", Offset = "0xCE0484")]
		public Leg rightLeg;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE04BC", Offset = "0xCE04BC")]
		public Locomotion locomotion;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000048")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1FF3A00", Offset = "0x1FF3A00", VA = "0x1FF3A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE75E0", Offset = "0xCE75E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1FF3A08", Offset = "0x1FF3A08", VA = "0x1FF3A08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE75F0", Offset = "0xCE75F0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1FEE35C", Offset = "0x1FEE35C", VA = "0x1FEE35C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1FEE798", Offset = "0x1FEE798", VA = "0x1FEE798")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1FEE640", Offset = "0x1FEE640", VA = "0x1FEE640")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1FEF184", Offset = "0x1FEF184", VA = "0x1FEF184")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1FEF460", Offset = "0x1FEF460", VA = "0x1FEF460")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1FEF504", Offset = "0x1FEF504", VA = "0x1FEF504")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1FEF698", Offset = "0x1FEF698", VA = "0x1FEF698")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1FEF824", Offset = "0x1FEF824", VA = "0x1FEF824")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1FF0034", Offset = "0x1FF0034", VA = "0x1FF0034", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1FF01A8", Offset = "0x1FF01A8", VA = "0x1FF01A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1FF034C", Offset = "0x1FF034C", VA = "0x1FF034C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1FF03C0", Offset = "0x1FF03C0", VA = "0x1FF03C0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1FF0434", Offset = "0x1FF0434", VA = "0x1FF0434", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1FF0648", Offset = "0x1FF0648", VA = "0x1FF0648")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1FEEA38", Offset = "0x1FEEA38", VA = "0x1FEEA38")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1FEEC10", Offset = "0x1FEEC10", VA = "0x1FEEC10")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1FEF060", Offset = "0x1FEF060", VA = "0x1FEF060")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1FEF99C", Offset = "0x1FEF99C", VA = "0x1FEF99C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1FF0928", Offset = "0x1FF0928", VA = "0x1FF0928", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1FF0970", Offset = "0x1FF0970", VA = "0x1FF0970", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1FF1B40", Offset = "0x1FF1B40", VA = "0x1FF1B40")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1FEFB04", Offset = "0x1FEFB04", VA = "0x1FEFB04")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1FF09DC", Offset = "0x1FF09DC", VA = "0x1FF09DC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1FF1D9C", Offset = "0x1FF1D9C", VA = "0x1FF1D9C")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1FF1DE4", Offset = "0x1FF1DE4", VA = "0x1FF1DE4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1FF19F0", Offset = "0x1FF19F0", VA = "0x1FF19F0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1FF3400", Offset = "0x1FF3400", VA = "0x1FF3400")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1FF3A10", Offset = "0x1FF3A10", VA = "0x1FF3A10")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE04F4", Offset = "0xCE04F4")]
		public Transform parent;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE052C", Offset = "0xCE052C")]
		public Transform child;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0564", Offset = "0xCE0564")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0564", Offset = "0xCE0564")]
		public float weight;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE05B8", Offset = "0xCE05B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE05B8", Offset = "0xCE05B8")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE060C", Offset = "0xCE060C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE060C", Offset = "0xCE060C")]
		public float twistAngleOffset;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x25C0C0C", Offset = "0x25C0C0C", VA = "0x25C0C0C")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x25C0FEC", Offset = "0x25C0FEC", VA = "0x25C0FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x25C1460", Offset = "0x25C1460", VA = "0x25C1460")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x25C14E8", Offset = "0x25C14E8", VA = "0x25C14E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x25C1570", Offset = "0x25C1570", VA = "0x25C1570")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x25C1674", Offset = "0x25C1674", VA = "0x25C1674")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0668", Offset = "0xCE0668")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0678", Offset = "0xCE0678")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0688", Offset = "0xCE0688")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000049")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1D85530", Offset = "0x1D85530", VA = "0x1D85530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7600", Offset = "0xCE7600")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1D85538", Offset = "0x1D85538", VA = "0x1D85538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7610", Offset = "0xCE7610")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool isPaused
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1D85540", Offset = "0x1D85540", VA = "0x1D85540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7620", Offset = "0xCE7620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1D85548", Offset = "0x1D85548", VA = "0x1D85548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7630", Offset = "0xCE7630")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1D85554", Offset = "0x1D85554", VA = "0x1D85554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7640", Offset = "0xCE7640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x1D8555C", Offset = "0x1D8555C", VA = "0x1D8555C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE7650", Offset = "0xCE7650")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool inInteraction
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1D85564", Offset = "0x1D85564", VA = "0x1D85564")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public float progress
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x1D87E24", Offset = "0x1D87E24", VA = "0x1D87E24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1D855D4", Offset = "0x1D855D4", VA = "0x1D855D4")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1D85658", Offset = "0x1D85658", VA = "0x1D85658")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1D856FC", Offset = "0x1D856FC", VA = "0x1D856FC")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1D8583C", Offset = "0x1D8583C", VA = "0x1D8583C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1D85C40", Offset = "0x1D85C40", VA = "0x1D85C40")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1D86000", Offset = "0x1D86000", VA = "0x1D86000")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1D86054", Offset = "0x1D86054", VA = "0x1D86054")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1D86B94", Offset = "0x1D86B94", VA = "0x1D86B94")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1D87674", Offset = "0x1D87674", VA = "0x1D87674")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1D8789C", Offset = "0x1D8789C", VA = "0x1D8789C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1D87CD0", Offset = "0x1D87CD0", VA = "0x1D87CD0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1D8830C", Offset = "0x1D8830C", VA = "0x1D8830C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0698", Offset = "0xCE0698")]
		public LookAtIK ik;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE06D0", Offset = "0xCE06D0")]
		public float lerpSpeed;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0708", Offset = "0xCE0708")]
		public float weightSpeed;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1D88570", Offset = "0x1D88570", VA = "0x1D88570")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1D886E8", Offset = "0x1D886E8", VA = "0x1D886E8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1D88790", Offset = "0x1D88790", VA = "0x1D88790")]
		public void Update()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1D889D4", Offset = "0x1D889D4", VA = "0x1D889D4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1D88ACC", Offset = "0x1D88ACC", VA = "0x1D88ACC")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1D88B98", Offset = "0x1D88B98", VA = "0x1D88B98")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDCCC", Offset = "0xCDDCCC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDCCC", Offset = "0xCDDCCC")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class InteractionEvent
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4884", Offset = "0xCE4884")]
			public float time;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE48BC", Offset = "0xCE48BC")]
			public bool pause;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE48F4", Offset = "0xCE48F4")]
			public bool pickUp;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE492C", Offset = "0xCE492C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4964", Offset = "0xCE4964")]
			public Message[] messages;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE499C", Offset = "0xCE499C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1D87E60", Offset = "0x1D87E60", VA = "0x1D87E60")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1D89E38", Offset = "0x1D89E38", VA = "0x1D89E38")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AA")]
		public class Message
		{
			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE49D4", Offset = "0xCE49D4")]
			public string function;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4A0C", Offset = "0xCE4A0C")]
			public GameObject recipient;

			[Token(Token = "0x40005B5")]
			private const string empty = "";

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1D89D48", Offset = "0x1D89D48", VA = "0x1D89D48")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1D89E40", Offset = "0x1D89E40", VA = "0x1D89E40")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4A44", Offset = "0xCE4A44")]
			public Animator animator;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4A7C", Offset = "0xCE4A7C")]
			public Animation animation;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4AB4", Offset = "0xCE4AB4")]
			public string animationState;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4AEC", Offset = "0xCE4AEC")]
			public float crossfadeTime;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4B24", Offset = "0xCE4B24")]
			public int layer;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4B5C", Offset = "0xCE4B5C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40005BC")]
			private const string empty = "";

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1D89AA8", Offset = "0x1D89AA8", VA = "0x1D89AA8")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1D89B9C", Offset = "0x1D89B9C", VA = "0x1D89B9C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1D89C54", Offset = "0x1D89C54", VA = "0x1D89C54")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x1D89D34", Offset = "0x1D89D34", VA = "0x1D89D34")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000D1")]
			public enum Type
			{
				[Token(Token = "0x400067D")]
				PositionWeight,
				[Token(Token = "0x400067E")]
				RotationWeight,
				[Token(Token = "0x400067F")]
				PositionOffsetX,
				[Token(Token = "0x4000680")]
				PositionOffsetY,
				[Token(Token = "0x4000681")]
				PositionOffsetZ,
				[Token(Token = "0x4000682")]
				Pull,
				[Token(Token = "0x4000683")]
				Reach,
				[Token(Token = "0x4000684")]
				RotateBoneWeight,
				[Token(Token = "0x4000685")]
				Push,
				[Token(Token = "0x4000686")]
				PushParent,
				[Token(Token = "0x4000687")]
				PoserWeight
			}

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4B94", Offset = "0xCE4B94")]
			public Type type;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4BCC", Offset = "0xCE4BCC")]
			public AnimationCurve curve;

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1D892A4", Offset = "0x1D892A4", VA = "0x1D892A4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1D89E58", Offset = "0x1D89E58", VA = "0x1D89E58")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AD")]
		public class Multiplier
		{
			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4C04", Offset = "0xCE4C04")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4C3C", Offset = "0xCE4C3C")]
			public float multiplier;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4C74", Offset = "0xCE4C74")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1D89908", Offset = "0x1D89908", VA = "0x1D89908")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1D89E48", Offset = "0x1D89E48", VA = "0x1D89E48")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0750", Offset = "0xCE0750")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0788", Offset = "0xCE0788")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE07C0", Offset = "0xCE07C0")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE07F8", Offset = "0xCE07F8")]
		private float <length>k__BackingField;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0808", Offset = "0xCE0808")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004E")]
		public float length
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1D88D74", Offset = "0x1D88D74", VA = "0x1D88D74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE77B0", Offset = "0xCE77B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x1D88D7C", Offset = "0x1D88D7C", VA = "0x1D88D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE77C0", Offset = "0xCE77C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1D88D84", Offset = "0x1D88D84", VA = "0x1D88D84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE77D0", Offset = "0xCE77D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1D88D8C", Offset = "0x1D88D8C", VA = "0x1D88D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE77E0", Offset = "0xCE77E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1D88FA8", Offset = "0x1D88FA8", VA = "0x1D88FA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1D881E0", Offset = "0x1D881E0", VA = "0x1D881E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1D88BAC", Offset = "0x1D88BAC", VA = "0x1D88BAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7660", Offset = "0xCE7660")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1D88BF8", Offset = "0x1D88BF8", VA = "0x1D88BF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7698", Offset = "0xCE7698")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1D88C44", Offset = "0x1D88C44", VA = "0x1D88C44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE76D0", Offset = "0xCE76D0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1D88C90", Offset = "0x1D88C90", VA = "0x1D88C90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7708", Offset = "0xCE7708")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1D88CDC", Offset = "0x1D88CDC", VA = "0x1D88CDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7740", Offset = "0xCE7740")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1D88D28", Offset = "0x1D88D28", VA = "0x1D88D28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7778", Offset = "0xCE7778")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1D88D94", Offset = "0x1D88D94", VA = "0x1D88D94")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1D89038", Offset = "0x1D89038", VA = "0x1D89038")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1D865BC", Offset = "0x1D865BC", VA = "0x1D865BC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1D891BC", Offset = "0x1D891BC", VA = "0x1D891BC")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1D86470", Offset = "0x1D86470", VA = "0x1D86470")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1D865B4", Offset = "0x1D865B4", VA = "0x1D865B4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1D87258", Offset = "0x1D87258", VA = "0x1D87258")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1D87AA8", Offset = "0x1D87AA8", VA = "0x1D87AA8")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1D89944", Offset = "0x1D89944", VA = "0x1D89944")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1D892C0", Offset = "0x1D892C0", VA = "0x1D892C0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1D891C4", Offset = "0x1D891C4", VA = "0x1D891C4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1D898A0", Offset = "0x1D898A0", VA = "0x1D898A0")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1D89948", Offset = "0x1D89948", VA = "0x1D89948")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1D899B0", Offset = "0x1D899B0", VA = "0x1D899B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE77F0", Offset = "0xCE77F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1D899FC", Offset = "0x1D899FC", VA = "0x1D899FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7828", Offset = "0xCE7828")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1D89A48", Offset = "0x1D89A48", VA = "0x1D89A48")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDD2C", Offset = "0xCDDD2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDD2C", Offset = "0xCDDD2C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000AF")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0818", Offset = "0xCE0818")]
		public string targetTag;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0850", Offset = "0xCE0850")]
		public float fadeInTime;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0888", Offset = "0xCE0888")]
		public float speed;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE08C0", Offset = "0xCE08C0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE08F8", Offset = "0xCE08F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE08F8", Offset = "0xCE08F8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCE08F8", Offset = "0xCE08F8")]
		public Collider characterCollider;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE097C", Offset = "0xCE097C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCE097C", Offset = "0xCE097C")]
		public Transform FPSCamera;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE09DC", Offset = "0xCE09DC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0A14", Offset = "0xCE0A14")]
		public float camRaycastDistance;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE0A4C", Offset = "0xCE0A4C")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCE0A5C", Offset = "0xCE0A5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0A5C", Offset = "0xCE0A5C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0ABC", Offset = "0xCE0ABC")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000052")]
		public bool inInteraction
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1D8A028", Offset = "0x1D8A028", VA = "0x1D8A028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1D8BC40", Offset = "0x1D8BC40", VA = "0x1D8BC40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1D8BC48", Offset = "0x1D8BC48", VA = "0x1D8BC48")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1D8BC50", Offset = "0x1D8BC50", VA = "0x1D8BC50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE79B0", Offset = "0xCE79B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1D8BC58", Offset = "0x1D8BC58", VA = "0x1D8BC58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE79C0", Offset = "0xCE79C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1D89E60", Offset = "0x1D89E60", VA = "0x1D89E60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7860", Offset = "0xCE7860")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1D89EAC", Offset = "0x1D89EAC", VA = "0x1D89EAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7898", Offset = "0xCE7898")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1D89EF8", Offset = "0x1D89EF8", VA = "0x1D89EF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE78D0", Offset = "0xCE78D0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1D89F44", Offset = "0x1D89F44", VA = "0x1D89F44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7908", Offset = "0xCE7908")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1D89F90", Offset = "0x1D89F90", VA = "0x1D89F90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7940", Offset = "0xCE7940")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1D89FDC", Offset = "0x1D89FDC", VA = "0x1D89FDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7978", Offset = "0xCE7978")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1D8A1B8", Offset = "0x1D8A1B8", VA = "0x1D8A1B8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1D8A284", Offset = "0x1D8A284", VA = "0x1D8A284")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1D8A350", Offset = "0x1D8A350", VA = "0x1D8A350")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1D8A3FC", Offset = "0x1D8A3FC", VA = "0x1D8A3FC")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1D8A4F4", Offset = "0x1D8A4F4", VA = "0x1D8A4F4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1D8A610", Offset = "0x1D8A610", VA = "0x1D8A610")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1D8A6A0", Offset = "0x1D8A6A0", VA = "0x1D8A6A0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1D8A730", Offset = "0x1D8A730", VA = "0x1D8A730")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1D8A7C0", Offset = "0x1D8A7C0", VA = "0x1D8A7C0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1D8A834", Offset = "0x1D8A834", VA = "0x1D8A834")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1D8A8A8", Offset = "0x1D8A8A8", VA = "0x1D8A8A8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1D8A910", Offset = "0x1D8A910", VA = "0x1D8A910")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1D8A99C", Offset = "0x1D8A99C", VA = "0x1D8A99C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1D8AA50", Offset = "0x1D8AA50", VA = "0x1D8AA50")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1D8AB34", Offset = "0x1D8AB34", VA = "0x1D8AB34")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1D8ADD8", Offset = "0x1D8ADD8", VA = "0x1D8ADD8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1D8AFB0", Offset = "0x1D8AFB0", VA = "0x1D8AFB0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1D8B224", Offset = "0x1D8B224", VA = "0x1D8B224")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1D8B518", Offset = "0x1D8B518", VA = "0x1D8B518")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1D8B55C", Offset = "0x1D8B55C", VA = "0x1D8B55C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1D8B5D4", Offset = "0x1D8B5D4", VA = "0x1D8B5D4")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1D8B6F4", Offset = "0x1D8B6F4", VA = "0x1D8B6F4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1D8B86C", Offset = "0x1D8B86C", VA = "0x1D8B86C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1D8BB14", Offset = "0x1D8BB14", VA = "0x1D8BB14")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1D8B324", Offset = "0x1D8B324", VA = "0x1D8B324")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1D8BC60", Offset = "0x1D8BC60", VA = "0x1D8BC60")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1D8C314", Offset = "0x1D8C314", VA = "0x1D8C314")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1D8C334", Offset = "0x1D8C334", VA = "0x1D8C334")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1D8C350", Offset = "0x1D8C350", VA = "0x1D8C350")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1D8C36C", Offset = "0x1D8C36C", VA = "0x1D8C36C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1D8C3CC", Offset = "0x1D8C3CC", VA = "0x1D8C3CC")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1D8C4E8", Offset = "0x1D8C4E8", VA = "0x1D8C4E8")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1D8C5E4", Offset = "0x1D8C5E4", VA = "0x1D8C5E4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1D8C944", Offset = "0x1D8C944", VA = "0x1D8C944")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1D8CA30", Offset = "0x1D8CA30", VA = "0x1D8CA30")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1D8CC7C", Offset = "0x1D8CC7C", VA = "0x1D8CC7C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1D8C08C", Offset = "0x1D8C08C", VA = "0x1D8C08C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1D8CDBC", Offset = "0x1D8CDBC", VA = "0x1D8CDBC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1D8CEE8", Offset = "0x1D8CEE8", VA = "0x1D8CEE8")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1D8CF90", Offset = "0x1D8CF90", VA = "0x1D8CF90")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1D8D078", Offset = "0x1D8D078", VA = "0x1D8D078")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1D8D090", Offset = "0x1D8D090", VA = "0x1D8D090")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1D8A0D4", Offset = "0x1D8A0D4", VA = "0x1D8A0D4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1D8ACD4", Offset = "0x1D8ACD4", VA = "0x1D8ACD4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1D8D380", Offset = "0x1D8D380", VA = "0x1D8D380")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE79D0", Offset = "0xCE79D0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1D8D3CC", Offset = "0x1D8D3CC", VA = "0x1D8D3CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7A08", Offset = "0xCE7A08")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1D8D418", Offset = "0x1D8D418", VA = "0x1D8D418")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDD8C", Offset = "0xCDDD8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDD8C", Offset = "0xCDDD8C")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public class Multiplier
		{
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4CAC", Offset = "0xCE4CAC")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4CE4", Offset = "0xCE4CE4")]
			public float multiplier;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1D8DBB8", Offset = "0x1D8DBB8", VA = "0x1D8DBB8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0AF4", Offset = "0xCE0AF4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0B2C", Offset = "0xCE0B2C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0B64", Offset = "0xCE0B64")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0B9C", Offset = "0xCE0B9C")]
		public Transform pivot;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0BD4", Offset = "0xCE0BD4")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0C0C", Offset = "0xCE0C0C")]
		public float twistWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0C44", Offset = "0xCE0C44")]
		public float swingWeight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0C7C", Offset = "0xCE0C7C")]
		public bool rotateOnce;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1D8D8CC", Offset = "0x1D8D8CC", VA = "0x1D8D8CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7A40", Offset = "0xCE7A40")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1D8D918", Offset = "0x1D8D918", VA = "0x1D8D918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7A78", Offset = "0xCE7A78")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1D8D964", Offset = "0x1D8D964", VA = "0x1D8D964")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7AB0", Offset = "0xCE7AB0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1D8D9B0", Offset = "0x1D8D9B0", VA = "0x1D8D9B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7AE8", Offset = "0xCE7AE8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1D8D9FC", Offset = "0x1D8D9FC", VA = "0x1D8D9FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7B20", Offset = "0xCE7B20")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1D8DA48", Offset = "0x1D8DA48", VA = "0x1D8DA48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7B58", Offset = "0xCE7B58")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1D89234", Offset = "0x1D89234", VA = "0x1D89234")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1D88270", Offset = "0x1D88270", VA = "0x1D88270")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1D86670", Offset = "0x1D86670", VA = "0x1D86670")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1D8DA94", Offset = "0x1D8DA94", VA = "0x1D8DA94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7B90", Offset = "0xCE7B90")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1D8DAE0", Offset = "0x1D8DAE0", VA = "0x1D8DAE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7BC8", Offset = "0xCE7BC8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1D8DB2C", Offset = "0x1D8DB2C", VA = "0x1D8DB2C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDDEC", Offset = "0xCDDDEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDDEC", Offset = "0xCDDDEC")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class CharacterPosition
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4D1C", Offset = "0xCE4D1C")]
			public bool use;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4D54", Offset = "0xCE4D54")]
			public Vector2 offset;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4D8C", Offset = "0xCE4D8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4D8C", Offset = "0xCE4D8C")]
			public float angleOffset;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4DE8", Offset = "0xCE4DE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4DE8", Offset = "0xCE4DE8")]
			public float maxAngle;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4E40", Offset = "0xCE4E40")]
			public float radius;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4E78", Offset = "0xCE4E78")]
			public bool orbit;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4EB0", Offset = "0xCE4EB0")]
			public bool fixYAxis;

			[Token(Token = "0x170000DE")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x1D8E340", Offset = "0x1D8E340", VA = "0x1D8E340")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DF")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x1D8E37C", Offset = "0x1D8E37C", VA = "0x1D8E37C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1D8E474", Offset = "0x1D8E474", VA = "0x1D8E474")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1D8EAF0", Offset = "0x1D8EAF0", VA = "0x1D8EAF0")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public class CameraPosition
		{
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4EE8", Offset = "0xCE4EE8")]
			public Collider lookAtTarget;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4F20", Offset = "0xCE4F20")]
			public Vector3 direction;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4F58", Offset = "0xCE4F58")]
			public float maxDistance;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4F90", Offset = "0xCE4F90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE4F90", Offset = "0xCE4F90")]
			public float maxAngle;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE4FE8", Offset = "0xCE4FE8")]
			public bool fixYAxis;

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1D8DE2C", Offset = "0x1D8DE2C", VA = "0x1D8DE2C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1D8DFD4", Offset = "0x1D8DFD4", VA = "0x1D8DFD4")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1D8E2B4", Offset = "0x1D8E2B4", VA = "0x1D8E2B4")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000D2")]
			public class Interaction
			{
				[Token(Token = "0x4000688")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE60A0", Offset = "0xCE60A0")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE60D8", Offset = "0xCE60D8")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000736")]
				[Address(RVA = "0x1D8EB14", Offset = "0x1D8EB14", VA = "0x1D8EB14")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5090", Offset = "0xCE5090")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE50C8", Offset = "0xCE50C8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5100", Offset = "0xCE5100")]
			public Interaction[] interactions;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1D8DCA8", Offset = "0x1D8DCA8", VA = "0x1D8DCA8")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1D8EB04", Offset = "0x1D8EB04", VA = "0x1D8EB04")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0CB4", Offset = "0xCE0CB4")]
		public Range[] ranges;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1D8DBC0", Offset = "0x1D8DBC0", VA = "0x1D8DBC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7C00", Offset = "0xCE7C00")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1D8DC0C", Offset = "0x1D8DC0C", VA = "0x1D8DC0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7C38", Offset = "0xCE7C38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1D8DC58", Offset = "0x1D8DC58", VA = "0x1D8DC58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7C70", Offset = "0xCE7C70")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1D8DCA4", Offset = "0x1D8DCA4", VA = "0x1D8DCA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1D8C788", Offset = "0x1D8C788", VA = "0x1D8C788")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1D8DDCC", Offset = "0x1D8DDCC", VA = "0x1D8DDCC")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class Map
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1E79E94", Offset = "0x1E79E94", VA = "0x1E79E94")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1E7A298", Offset = "0x1E7A298", VA = "0x1E7A298")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1E7A24C", Offset = "0x1E7A24C", VA = "0x1E7A24C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1E7A044", Offset = "0x1E7A044", VA = "0x1E7A044")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1E79BAC", Offset = "0x1E79BAC", VA = "0x1E79BAC", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7CA8", Offset = "0xCE7CA8")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1E79F38", Offset = "0x1E79F38", VA = "0x1E79F38", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1E79F3C", Offset = "0x1E79F3C", VA = "0x1E79F3C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1E7A1E4", Offset = "0x1E7A1E4", VA = "0x1E7A1E4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1E79ED0", Offset = "0x1E79ED0", VA = "0x1E79ED0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1E79DF4", Offset = "0x1E79DF4", VA = "0x1E79DF4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1E7A2E8", Offset = "0x1E7A2E8", VA = "0x1E7A2E8")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2064200", Offset = "0x2064200", VA = "0x2064200", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x20642B4", Offset = "0x20642B4", VA = "0x20642B4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x206446C", Offset = "0x206446C", VA = "0x206446C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2064568", Offset = "0x2064568", VA = "0x2064568", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2064310", Offset = "0x2064310", VA = "0x2064310")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2064918", Offset = "0x2064918", VA = "0x2064918")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0CEC", Offset = "0xCE0CEC")]
		public float weight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0D04", Offset = "0xCE0D04")]
		public float localRotationWeight;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0D1C", Offset = "0xCE0D1C")]
		public float localPositionWeight;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60003FC")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1D916E8", Offset = "0x1D916E8", VA = "0x1D916E8")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60003FE")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60003FF")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000400")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1D916F4", Offset = "0x1D916F4", VA = "0x1D916F4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1D91748", Offset = "0x1D91748", VA = "0x1D91748", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1D91784", Offset = "0x1D91784", VA = "0x1D91784", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1D9179C", Offset = "0x1D9179C", VA = "0x1D9179C")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCDDE4C", Offset = "0xCDDE4C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		public class Rigidbone
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1D91D20", Offset = "0x1D91D20", VA = "0x1D91D20")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1D9292C", Offset = "0x1D9292C", VA = "0x1D9292C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1D92710", Offset = "0x1D92710", VA = "0x1D92710")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000B6")]
		public class Child
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1D91E7C", Offset = "0x1D91E7C", VA = "0x1D91E7C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1D92AC8", Offset = "0x1D92AC8", VA = "0x1D92AC8")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1D92A78", Offset = "0x1D92A78", VA = "0x1D92A78")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE17C", Offset = "0xCDE17C")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x1D930A8", Offset = "0x1D930A8", VA = "0x1D930A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x1D93110", Offset = "0x1D93110", VA = "0x1D93110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1D91EDC", Offset = "0x1D91EDC", VA = "0x1D91EDC")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1D92E60", Offset = "0x1D92E60", VA = "0x1D92E60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1D92E64", Offset = "0x1D92E64", VA = "0x1D92E64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1D930B0", Offset = "0x1D930B0", VA = "0x1D930B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0D34", Offset = "0xCE0D34")]
		public IK ik;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0D6C", Offset = "0xCE0D6C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0DA4", Offset = "0xCE0DA4")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0DDC", Offset = "0xCE0DDC")]
		public float applyVelocity;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0E14", Offset = "0xCE0E14")]
		public float applyAngularVelocity;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000055")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1D917E4", Offset = "0x1D917E4", VA = "0x1D917E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool ikUsed
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1D922C8", Offset = "0x1D922C8", VA = "0x1D922C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1D917AC", Offset = "0x1D917AC", VA = "0x1D917AC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1D9185C", Offset = "0x1D9185C", VA = "0x1D9185C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1D9198C", Offset = "0x1D9198C", VA = "0x1D9198C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1D9191C", Offset = "0x1D9191C", VA = "0x1D9191C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCE7CE0", Offset = "0xCE7CE0")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1D91F08", Offset = "0x1D91F08", VA = "0x1D91F08")]
		private void Update()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1D92154", Offset = "0x1D92154", VA = "0x1D92154")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1D9220C", Offset = "0x1D9220C", VA = "0x1D9220C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1D9244C", Offset = "0x1D9244C", VA = "0x1D9244C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1D9228C", Offset = "0x1D9228C", VA = "0x1D9228C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1D92408", Offset = "0x1D92408", VA = "0x1D92408")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1D924E8", Offset = "0x1D924E8", VA = "0x1D924E8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1D92480", Offset = "0x1D92480", VA = "0x1D92480")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1D918B4", Offset = "0x1D918B4", VA = "0x1D918B4")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1D92194", Offset = "0x1D92194", VA = "0x1D92194")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1D92C90", Offset = "0x1D92C90", VA = "0x1D92C90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1D92D94", Offset = "0x1D92D94", VA = "0x1D92D94")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000057")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x25BC51C", Offset = "0x25BC51C", VA = "0x25BC51C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x25BC558", Offset = "0x25BC558", VA = "0x25BC558")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x25BC1A4", Offset = "0x25BC1A4", VA = "0x25BC1A4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x25BC1E8", Offset = "0x25BC1E8", VA = "0x25BC1E8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x25BC474", Offset = "0x25BC474", VA = "0x25BC474")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x25BC4E4", Offset = "0x25BC4E4", VA = "0x25BC4E4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600041D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x25BC384", Offset = "0x25BC384", VA = "0x25BC384")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x25BC628", Offset = "0x25BC628", VA = "0x25BC628")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x25BC62C", Offset = "0x25BC62C", VA = "0x25BC62C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x25BC714", Offset = "0x25BC714", VA = "0x25BC714")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x25BC7F8", Offset = "0x25BC7F8", VA = "0x25BC7F8")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x25BCA74", Offset = "0x25BCA74", VA = "0x25BCA74")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x25BCB30", Offset = "0x25BCB30", VA = "0x25BCB30")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDEB0", Offset = "0xCDDEB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDEB0", Offset = "0xCDDEB0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0E5C", Offset = "0xCE0E5C")]
		public float limit;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0E78", Offset = "0xCE0E78")]
		public float twistLimit;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x25BCBA8", Offset = "0x25BCBA8", VA = "0x25BCBA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7D44", Offset = "0xCE7D44")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x25BCBF4", Offset = "0x25BCBF4", VA = "0x25BCBF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7D7C", Offset = "0xCE7D7C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x25BCC40", Offset = "0x25BCC40", VA = "0x25BCC40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7DB4", Offset = "0xCE7DB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x25BCC8C", Offset = "0x25BCC8C", VA = "0x25BCC8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7DEC", Offset = "0xCE7DEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x25BCCD8", Offset = "0x25BCCD8", VA = "0x25BCCD8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x25BCD90", Offset = "0x25BCD90", VA = "0x25BCD90")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x25BCFD8", Offset = "0x25BCFD8", VA = "0x25BCFD8")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDF10", Offset = "0xCDDF10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDF10", Offset = "0xCDDF10")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x25BCFE8", Offset = "0x25BCFE8", VA = "0x25BCFE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7E24", Offset = "0xCE7E24")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x25BD034", Offset = "0x25BD034", VA = "0x25BD034")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7E5C", Offset = "0xCE7E5C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x25BD080", Offset = "0x25BD080", VA = "0x25BD080")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7E94", Offset = "0xCE7E94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x25BD0CC", Offset = "0x25BD0CC", VA = "0x25BD0CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7ECC", Offset = "0xCE7ECC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x25BD118", Offset = "0x25BD118", VA = "0x25BD118", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x25BD140", Offset = "0x25BD140", VA = "0x25BD140")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x25BD440", Offset = "0x25BD440", VA = "0x25BD440")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDF70", Offset = "0xCDDF70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDF70", Offset = "0xCDDF70")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public class ReachCone
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000E2")]
			public Vector3 o
			{
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x25BF3DC", Offset = "0x25BF3DC", VA = "0x25BF3DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E3")]
			public Vector3 a
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x25BF414", Offset = "0x25BF414", VA = "0x25BF414")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E4")]
			public Vector3 b
			{
				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x25BF450", Offset = "0x25BF450", VA = "0x25BF450")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E5")]
			public Vector3 c
			{
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x25BF48C", Offset = "0x25BF48C", VA = "0x25BF48C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E6")]
			public bool isValid
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x25BE540", Offset = "0x25BE540", VA = "0x25BE540")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x25BEB8C", Offset = "0x25BEB8C", VA = "0x25BEB8C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x25BECEC", Offset = "0x25BECEC", VA = "0x25BECEC")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B9")]
		public class LimitPoint
		{
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x25BE550", Offset = "0x25BE550", VA = "0x25BE550")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0EA4", Offset = "0xCE0EA4")]
		public float twistLimit;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0EC0", Offset = "0xCE0EC0")]
		public int smoothIterations;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x25BD4C8", Offset = "0x25BD4C8", VA = "0x25BD4C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7F04", Offset = "0xCE7F04")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x25BD514", Offset = "0x25BD514", VA = "0x25BD514")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7F3C", Offset = "0xCE7F3C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x25BD560", Offset = "0x25BD560", VA = "0x25BD560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7F74", Offset = "0xCE7F74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x25BD5AC", Offset = "0x25BD5AC", VA = "0x25BD5AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7FAC", Offset = "0xCE7FAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x25BD5F8", Offset = "0x25BD5F8", VA = "0x25BD5F8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x25BDADC", Offset = "0x25BDADC", VA = "0x25BDADC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x25BDBD4", Offset = "0x25BDBD4", VA = "0x25BDBD4")]
		private void Start()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x25BE18C", Offset = "0x25BE18C", VA = "0x25BE18C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x25BD694", Offset = "0x25BD694", VA = "0x25BD694")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x25BE5D4", Offset = "0x25BE5D4", VA = "0x25BE5D4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x25BEEAC", Offset = "0x25BEEAC", VA = "0x25BEEAC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x25BEEF0", Offset = "0x25BEEF0", VA = "0x25BEEF0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x25BF038", Offset = "0x25BF038", VA = "0x25BF038")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x25BDE54", Offset = "0x25BDE54", VA = "0x25BDE54")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x25BF1C8", Offset = "0x25BF1C8", VA = "0x25BF1C8")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x25BF378", Offset = "0x25BF378", VA = "0x25BF378")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCDDFD0", Offset = "0xCDDFD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDDFD0", Offset = "0xCDDFD0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE0F80", Offset = "0xCE0F80")]
		public float twistLimit;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x25BF4C8", Offset = "0x25BF4C8", VA = "0x25BF4C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE7FE4", Offset = "0xCE7FE4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x25BF514", Offset = "0x25BF514", VA = "0x25BF514")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE801C", Offset = "0xCE801C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x25BF560", Offset = "0x25BF560", VA = "0x25BF560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE8054", Offset = "0xCE8054")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x25BF5AC", Offset = "0x25BF5AC", VA = "0x25BF5AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCE808C", Offset = "0xCE808C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x25BF5F8", Offset = "0x25BF5F8", VA = "0x25BF5F8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x25BF614", Offset = "0x25BF614", VA = "0x25BF614", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x25BF6CC", Offset = "0x25BF6CC", VA = "0x25BF6CC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x25BF9F8", Offset = "0x25BF9F8", VA = "0x25BF9F8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE18C", Offset = "0xCDE18C")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000E7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x1E67684", Offset = "0x1E67684", VA = "0x1E67684", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x1E676EC", Offset = "0x1E676EC", VA = "0x1E676EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1E67534", Offset = "0x1E67534", VA = "0x1E67534")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1E67560", Offset = "0x1E67560", VA = "0x1E67560", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1E67564", Offset = "0x1E67564", VA = "0x1E67564", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1E6768C", Offset = "0x1E6768C", VA = "0x1E6768C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE0FD4", Offset = "0xCE0FD4")]
		public AimIK ik;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE100C", Offset = "0xCE100C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE100C", Offset = "0xCE100C")]
		public float weight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE1060", Offset = "0xCE1060")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1060", Offset = "0xCE1060")]
		public Transform target;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE10C0", Offset = "0xCE10C0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE10F8", Offset = "0xCE10F8")]
		public float weightSmoothTime;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE1130", Offset = "0xCE1130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1130", Offset = "0xCE1130")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1190", Offset = "0xCE1190")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE11C8", Offset = "0xCE11C8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1200", Offset = "0xCE1200")]
		public float slerpSpeed;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1238", Offset = "0xCE1238")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1270", Offset = "0xCE1270")]
		public float minDistance;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE12A8", Offset = "0xCE12A8")]
		public Vector3 offset;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE12E0", Offset = "0xCE12E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE12E0", Offset = "0xCE12E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE12E0", Offset = "0xCE12E0")]
		public float maxRootAngle;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE135C", Offset = "0xCE135C")]
		public bool turnToTarget;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1394", Offset = "0xCE1394")]
		public float turnToTargetTime;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE13CC", Offset = "0xCE13CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE13CC", Offset = "0xCE13CC")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE142C", Offset = "0xCE142C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000059")]
		private Vector3 pivot
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x1F3F270", Offset = "0x1F3F270", VA = "0x1F3F270")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1F3F174", Offset = "0x1F3F174", VA = "0x1F3F174")]
		private void Start()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1F3F3BC", Offset = "0x1F3F3BC", VA = "0x1F3F3BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1F3FAD8", Offset = "0x1F3FAD8", VA = "0x1F3FAD8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1F3FC74", Offset = "0x1F3FC74", VA = "0x1F3FC74")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1F3FFE4", Offset = "0x1F3FFE4", VA = "0x1F3FFE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCE80C4", Offset = "0xCE80C4")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1F40054", Offset = "0x1F40054", VA = "0x1F40054")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class Pose
		{
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1E6B5B0", Offset = "0x1E6B5B0", VA = "0x1E6B5B0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1E6B91C", Offset = "0x1E6B91C", VA = "0x1E6B91C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1E6B924", Offset = "0x1E6B924", VA = "0x1E6B924")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1E6B4D4", Offset = "0x1E6B4D4", VA = "0x1E6B4D4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1E6B848", Offset = "0x1E6B848", VA = "0x1E6B848")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1E6B8B4", Offset = "0x1E6B8B4", VA = "0x1E6B8B4")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000D3")]
			public class EffectorLink
			{
				[Token(Token = "0x400068A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6110", Offset = "0xCE6110")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6148", Offset = "0xCE6148")]
				public float weight;

				[Token(Token = "0x6000737")]
				[Address(RVA = "0x1E6BF14", Offset = "0x1E6BF14", VA = "0x1E6BF14")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5138", Offset = "0xCE5138")]
			public Transform transform;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5170", Offset = "0xCE5170")]
			public Transform relativeTo;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE51A8", Offset = "0xCE51A8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE51E0", Offset = "0xCE51E0")]
			public float verticalWeight;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5218", Offset = "0xCE5218")]
			public float horizontalWeight;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5250", Offset = "0xCE5250")]
			public float speed;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1E6BA80", Offset = "0x1E6BA80", VA = "0x1E6BA80")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1E6BEEC", Offset = "0x1E6BEEC", VA = "0x1E6BEEC")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x1E6BEFC", Offset = "0x1E6BEFC", VA = "0x1E6BEFC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1464", Offset = "0xCE1464")]
		public Body[] bodies;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1E6B940", Offset = "0x1E6B940", VA = "0x1E6B940", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1E6BEE4", Offset = "0x1E6BEE4", VA = "0x1E6BEE4")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE149C", Offset = "0xCE149C")]
		public float tiltSpeed;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE14D4", Offset = "0xCE14D4")]
		public float tiltSensitivity;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE150C", Offset = "0xCE150C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1544", Offset = "0xCE1544")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1E6D468", Offset = "0x1E6D468", VA = "0x1E6D468", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1E6D4B0", Offset = "0x1E6D4B0", VA = "0x1E6D4B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1E6D6E0", Offset = "0x1E6D6E0", VA = "0x1E6D6E0")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5288", Offset = "0xCE5288")]
			public string name;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE52C0", Offset = "0xCE52C0")]
			public Collider collider;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE52F8", Offset = "0xCE52F8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5344", Offset = "0xCE5344")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5354", Offset = "0xCE5354")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5364", Offset = "0xCE5364")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5374", Offset = "0xCE5374")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000E9")]
			public bool inProgress
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x20649DC", Offset = "0x20649DC", VA = "0x20649DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EA")]
			protected float crossFader
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x2064F84", Offset = "0x2064F84", VA = "0x2064F84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8838", Offset = "0xCE8838")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x2064F8C", Offset = "0x2064F8C", VA = "0x2064F8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8848", Offset = "0xCE8848")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			protected float timer
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x2064F94", Offset = "0x2064F94", VA = "0x2064F94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8858", Offset = "0xCE8858")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x2064F9C", Offset = "0x2064F9C", VA = "0x2064F9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8868", Offset = "0xCE8868")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EC")]
			protected Vector3 force
			{
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x2064FA4", Offset = "0x2064FA4", VA = "0x2064FA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8878", Offset = "0xCE8878")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x2064FB0", Offset = "0x2064FB0", VA = "0x2064FB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8888", Offset = "0xCE8888")]
				private set
				{
				}
			}

			[Token(Token = "0x170000ED")]
			protected Vector3 point
			{
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x2064FBC", Offset = "0x2064FBC", VA = "0x2064FBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8898", Offset = "0xCE8898")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x2064FC8", Offset = "0x2064FC8", VA = "0x2064FC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE88A8", Offset = "0xCE88A8")]
				private set
				{
				}
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x2064E50", Offset = "0x2064E50", VA = "0x2064E50")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x2064AC4", Offset = "0x2064AC4", VA = "0x2064AC4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006EA")]
			protected abstract float GetLength();

			[Token(Token = "0x60006EB")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60006EC")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x2064FD4", Offset = "0x2064FD4", VA = "0x2064FD4")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000D4")]
			public class EffectorLink
			{
				[Token(Token = "0x400068C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6180", Offset = "0xCE6180")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE61B8", Offset = "0xCE61B8")]
				public float weight;

				[Token(Token = "0x400068E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400068F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000738")]
				[Address(RVA = "0x2065940", Offset = "0x2065940", VA = "0x2065940")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000739")]
				[Address(RVA = "0x2065734", Offset = "0x2065734", VA = "0x2065734")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600073A")]
				[Address(RVA = "0x2065A7C", Offset = "0x2065A7C", VA = "0x2065A7C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5384", Offset = "0xCE5384")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE53BC", Offset = "0xCE53BC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE53F4", Offset = "0xCE53F4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x2065550", Offset = "0x2065550", VA = "0x2065550", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x20656C8", Offset = "0x20656C8", VA = "0x20656C8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x2065748", Offset = "0x2065748", VA = "0x2065748", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x2065A68", Offset = "0x2065A68", VA = "0x2065A68")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000D5")]
			public class BoneLink
			{
				[Token(Token = "0x4000690")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE61F0", Offset = "0xCE61F0")]
				public Transform bone;

				[Token(Token = "0x4000691")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6228", Offset = "0xCE6228")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE6228", Offset = "0xCE6228")]
				public float weight;

				[Token(Token = "0x4000692")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000693")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600073B")]
				[Address(RVA = "0x2065358", Offset = "0x2065358", VA = "0x2065358")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600073C")]
				[Address(RVA = "0x20650F0", Offset = "0x20650F0", VA = "0x20650F0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600073D")]
				[Address(RVA = "0x20654C8", Offset = "0x20654C8", VA = "0x20654C8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE542C", Offset = "0xCE542C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5464", Offset = "0xCE5464")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x2064FE8", Offset = "0x2064FE8", VA = "0x2064FE8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x206508C", Offset = "0x206508C", VA = "0x206508C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x20650FC", Offset = "0x20650FC", VA = "0x20650FC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x20654B4", Offset = "0x20654B4", VA = "0x20654B4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE157C", Offset = "0xCE157C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE15B4", Offset = "0xCE15B4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005A")]
		public bool inProgress
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2064920", Offset = "0x2064920", VA = "0x2064920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x20649F0", Offset = "0x20649F0", VA = "0x20649F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2064C10", Offset = "0x2064C10", VA = "0x2064C10")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2064F7C", Offset = "0x2064F7C", VA = "0x2064F7C")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public abstract class Offset
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE549C", Offset = "0xCE549C")]
			public string name;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE54D4", Offset = "0xCE54D4")]
			public Collider collider;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE550C", Offset = "0xCE550C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5558", Offset = "0xCE5558")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5568", Offset = "0xCE5568")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5578", Offset = "0xCE5578")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE5588", Offset = "0xCE5588")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000EE")]
			protected float crossFader
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x2066034", Offset = "0x2066034", VA = "0x2066034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE88B8", Offset = "0xCE88B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x206603C", Offset = "0x206603C", VA = "0x206603C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE88C8", Offset = "0xCE88C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EF")]
			protected float timer
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x2066044", Offset = "0x2066044", VA = "0x2066044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE88D8", Offset = "0xCE88D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x206604C", Offset = "0x206604C", VA = "0x206604C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE88E8", Offset = "0xCE88E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F0")]
			protected Vector3 force
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x2066054", Offset = "0x2066054", VA = "0x2066054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE88F8", Offset = "0xCE88F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x2066060", Offset = "0x2066060", VA = "0x2066060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8908", Offset = "0xCE8908")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F1")]
			protected Vector3 point
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x206606C", Offset = "0x206606C", VA = "0x206606C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8918", Offset = "0xCE8918")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0x2066078", Offset = "0x2066078", VA = "0x2066078")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8928", Offset = "0xCE8928")]
				private set
				{
				}
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x2065EEC", Offset = "0x2065EEC", VA = "0x2065EEC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x2065B50", Offset = "0x2065B50", VA = "0x2065B50")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000700")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000701")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000702")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x2066084", Offset = "0x2066084", VA = "0x2066084")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D6")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000694")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE627C", Offset = "0xCE627C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000695")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE62B4", Offset = "0xCE62B4")]
				public float weight;

				[Token(Token = "0x4000696")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000697")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600073E")]
				[Address(RVA = "0x2066540", Offset = "0x2066540", VA = "0x2066540")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600073F")]
				[Address(RVA = "0x20662FC", Offset = "0x20662FC", VA = "0x20662FC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000740")]
				[Address(RVA = "0x206665C", Offset = "0x206665C", VA = "0x206665C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5598", Offset = "0xCE5598")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE55D0", Offset = "0xCE55D0")]
			public int upDirCurveIndex;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5608", Offset = "0xCE5608")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x2066098", Offset = "0x2066098", VA = "0x2066098", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x2066290", Offset = "0x2066290", VA = "0x2066290", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x2066310", Offset = "0x2066310", VA = "0x2066310", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x2066640", Offset = "0x2066640", VA = "0x2066640")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D7")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000698")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE62EC", Offset = "0xCE62EC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000699")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6324", Offset = "0xCE6324")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE6324", Offset = "0xCE6324")]
				public float weight;

				[Token(Token = "0x400069A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400069B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000741")]
				[Address(RVA = "0x2066AC4", Offset = "0x2066AC4", VA = "0x2066AC4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000742")]
				[Address(RVA = "0x20667AC", Offset = "0x20667AC", VA = "0x20667AC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000743")]
				[Address(RVA = "0x2066C00", Offset = "0x2066C00", VA = "0x2066C00")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5640", Offset = "0xCE5640")]
			public int curveIndex;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5678", Offset = "0xCE5678")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x2066664", Offset = "0x2066664", VA = "0x2066664", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x2066748", Offset = "0x2066748", VA = "0x2066748", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x20667B8", Offset = "0x20667B8", VA = "0x20667B8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x2066BEC", Offset = "0x2066BEC", VA = "0x2066BEC")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE15EC", Offset = "0xCE15EC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1624", Offset = "0xCE1624")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2065A84", Offset = "0x2065A84", VA = "0x2065A84", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2065CA4", Offset = "0x2065CA4", VA = "0x2065CA4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x206602C", Offset = "0x206602C", VA = "0x206602C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000D8")]
			public class EffectorLink
			{
				[Token(Token = "0x400069C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6378", Offset = "0xCE6378")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400069D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE63B0", Offset = "0xCE63B0")]
				public float weight;

				[Token(Token = "0x6000744")]
				[Address(RVA = "0x1D85528", Offset = "0x1D85528", VA = "0x1D85528")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE56B0", Offset = "0xCE56B0")]
			public Transform transform;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE56E8", Offset = "0xCE56E8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5720", Offset = "0xCE5720")]
			public float speed;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5758", Offset = "0xCE5758")]
			public float acceleration;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5790", Offset = "0xCE5790")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE5790", Offset = "0xCE5790")]
			public float matchVelocity;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE57E4", Offset = "0xCE57E4")]
			public float gravity;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x1D84EF8", Offset = "0x1D84EF8", VA = "0x1D84EF8")]
			public void Reset()
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1D850B8", Offset = "0x1D850B8", VA = "0x1D850B8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1D8550C", Offset = "0x1D8550C", VA = "0x1D8550C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE165C", Offset = "0xCE165C")]
		public Body[] bodies;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1694", Offset = "0xCE1694")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1D84E80", Offset = "0x1D84E80", VA = "0x1D84E80")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1D84FD4", Offset = "0x1D84FD4", VA = "0x1D84FD4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1D854EC", Offset = "0x1D854EC", VA = "0x1D854EC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE16CC", Offset = "0xCE16CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE16CC", Offset = "0xCE16CC")]
		public Transform target;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE172C", Offset = "0xCE172C")]
		public float weight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1744", Offset = "0xCE1744")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE177C", Offset = "0xCE177C")]
		public float weightSmoothTime;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE17B4", Offset = "0xCE17B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE17B4", Offset = "0xCE17B4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1814", Offset = "0xCE1814")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE184C", Offset = "0xCE184C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1884", Offset = "0xCE1884")]
		public float slerpSpeed;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE18BC", Offset = "0xCE18BC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE18F4", Offset = "0xCE18F4")]
		public float minDistance;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCE192C", Offset = "0xCE192C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE192C", Offset = "0xCE192C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE192C", Offset = "0xCE192C")]
		public float maxRootAngle;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700005B")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x1D8EF84", Offset = "0x1D8EF84", VA = "0x1D8EF84")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1D8EE9C", Offset = "0x1D8EE9C", VA = "0x1D8EE9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1D8F0D0", Offset = "0x1D8F0D0", VA = "0x1D8F0D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1D8F768", Offset = "0x1D8F768", VA = "0x1D8F768")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1D8F904", Offset = "0x1D8F904", VA = "0x1D8F904")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1D8FC20", Offset = "0x1D8FC20", VA = "0x1D8FC20")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class OffsetLimits
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE581C", Offset = "0xCE581C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5854", Offset = "0xCE5854")]
			public float spring;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE588C", Offset = "0xCE588C")]
			public bool x;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE58C4", Offset = "0xCE58C4")]
			public bool y;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE58FC", Offset = "0xCE58FC")]
			public bool z;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5934", Offset = "0xCE5934")]
			public float minX;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE596C", Offset = "0xCE596C")]
			public float maxX;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE59A4", Offset = "0xCE59A4")]
			public float minY;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE59DC", Offset = "0xCE59DC")]
			public float maxY;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5A14", Offset = "0xCE5A14")]
			public float minZ;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5A4C", Offset = "0xCE5A4C")]
			public float maxZ;

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1D90048", Offset = "0x1D90048", VA = "0x1D90048")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1D90550", Offset = "0x1D90550", VA = "0x1D90550")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1D90580", Offset = "0x1D90580", VA = "0x1D90580")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1D90658", Offset = "0x1D90658", VA = "0x1D90658")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE19C", Offset = "0xCDE19C")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000F2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000716")]
				[Address(RVA = "0x1D904E0", Offset = "0x1D904E0", VA = "0x1D904E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000718")]
				[Address(RVA = "0x1D90548", Offset = "0x1D90548", VA = "0x1D90548", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1D8FF10", Offset = "0x1D8FF10", VA = "0x1D8FF10")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1D903A0", Offset = "0x1D903A0", VA = "0x1D903A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1D903A4", Offset = "0x1D903A4", VA = "0x1D903A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1D904E8", Offset = "0x1D904E8", VA = "0x1D904E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE19A8", Offset = "0xCE19A8")]
		public float weight;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE19E0", Offset = "0xCE19E0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005C")]
		protected float deltaTime
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1D8508C", Offset = "0x1D8508C", VA = "0x1D8508C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600046B")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1D8FE74", Offset = "0x1D8FE74", VA = "0x1D8FE74", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1D8FEA0", Offset = "0x1D8FEA0", VA = "0x1D8FEA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCE8128", Offset = "0xCE8128")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1D8FF3C", Offset = "0x1D8FF3C", VA = "0x1D8FF3C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1D85430", Offset = "0x1D85430", VA = "0x1D85430")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1D902A8", Offset = "0x1D902A8", VA = "0x1D902A8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1D854FC", Offset = "0x1D854FC", VA = "0x1D854FC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE1AC", Offset = "0xCDE1AC")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600071C")]
				[Address(RVA = "0x1D90AA8", Offset = "0x1D90AA8", VA = "0x1D90AA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x1D90B10", Offset = "0x1D90B10", VA = "0x1D90B10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1D90728", Offset = "0x1D90728", VA = "0x1D90728")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1D90968", Offset = "0x1D90968", VA = "0x1D90968", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1D9096C", Offset = "0x1D9096C", VA = "0x1D9096C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1D90AB0", Offset = "0x1D90AB0", VA = "0x1D90AB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1A18", Offset = "0xCE1A18")]
		public float weight;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1A50", Offset = "0xCE1A50")]
		public VRIK ik;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005D")]
		protected float deltaTime
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x1D90660", Offset = "0x1D90660", VA = "0x1D90660")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000473")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1D9068C", Offset = "0x1D9068C", VA = "0x1D9068C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1D906B8", Offset = "0x1D906B8", VA = "0x1D906B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCE818C", Offset = "0xCE818C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1D90754", Offset = "0x1D90754", VA = "0x1D90754")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1D90860", Offset = "0x1D90860", VA = "0x1D90860", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1D90958", Offset = "0x1D90958", VA = "0x1D90958")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public class EffectorLink
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1D90BD8", Offset = "0x1D90BD8", VA = "0x1D90BD8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1D91028", Offset = "0x1D91028", VA = "0x1D91028")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1D90B18", Offset = "0x1D90B18", VA = "0x1D90B18")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1D90F10", Offset = "0x1D90F10", VA = "0x1D90F10")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1D90FC8", Offset = "0x1D90FC8", VA = "0x1D90FC8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000D9")]
			public class EffectorLink
			{
				[Token(Token = "0x400069E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE63E8", Offset = "0xCE63E8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400069F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6420", Offset = "0xCE6420")]
				public float weight;

				[Token(Token = "0x6000745")]
				[Address(RVA = "0x1D916E0", Offset = "0x1D916E0", VA = "0x1D916E0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5A84", Offset = "0xCE5A84")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5ABC", Offset = "0xCE5ABC")]
			public Transform raycastTo;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5AF4", Offset = "0xCE5AF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE5AF4", Offset = "0xCE5AF4")]
			public float raycastRadius;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5B48", Offset = "0xCE5B48")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5B80", Offset = "0xCE5B80")]
			public float smoothTimeIn;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5BB8", Offset = "0xCE5BB8")]
			public float smoothTimeOut;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5BF0", Offset = "0xCE5BF0")]
			public LayerMask layers;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1D910B4", Offset = "0x1D910B4", VA = "0x1D910B4")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1D912C0", Offset = "0x1D912C0", VA = "0x1D912C0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1D91458", Offset = "0x1D91458", VA = "0x1D91458")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1D916CC", Offset = "0x1D916CC", VA = "0x1D916CC")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1A88", Offset = "0xCE1A88")]
		public Avoider[] avoiders;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1D91030", Offset = "0x1D91030", VA = "0x1D91030", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1D912B0", Offset = "0x1D912B0", VA = "0x1D912B0")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000DA")]
			public class EffectorLink
			{
				[Token(Token = "0x40006A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6458", Offset = "0xCE6458")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6490", Offset = "0xCE6490")]
				public float weight;

				[Token(Token = "0x6000746")]
				[Address(RVA = "0x25BC19C", Offset = "0x25BC19C", VA = "0x25BC19C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5C28", Offset = "0xCE5C28")]
			public Vector3 offset;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5C60", Offset = "0xCE5C60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE5C60", Offset = "0xCE5C60")]
			public float additivity;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5CB4", Offset = "0xCE5CB4")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5CEC", Offset = "0xCE5CEC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x25BBE64", Offset = "0x25BBE64", VA = "0x25BBE64")]
			public void Start()
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x25BBF14", Offset = "0x25BBF14", VA = "0x25BBF14")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x25BC188", Offset = "0x25BC188", VA = "0x25BC188")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public enum Handedness
		{
			[Token(Token = "0x4000653")]
			Right,
			[Token(Token = "0x4000654")]
			Left
		}

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1AC0", Offset = "0xCE1AC0")]
		public AimIK aimIK;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1AF8", Offset = "0xCE1AF8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1B30", Offset = "0xCE1B30")]
		public Handedness handedness;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1B68", Offset = "0xCE1B68")]
		public bool twoHanded;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1BA0", Offset = "0xCE1BA0")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1BD8", Offset = "0xCE1BD8")]
		public float magnitudeRandom;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1C10", Offset = "0xCE1C10")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1C48", Offset = "0xCE1C48")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1C80", Offset = "0xCE1C80")]
		public float blendTime;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCE1CB8", Offset = "0xCE1CB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1CB8", Offset = "0xCE1CB8")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700005E")]
		public bool isFinished
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1D93118", Offset = "0x1D93118", VA = "0x1D93118")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1D93E68", Offset = "0x1D93E68", VA = "0x1D93E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1D93EA8", Offset = "0x1D93EA8", VA = "0x1D93EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1D93E28", Offset = "0x1D93E28", VA = "0x1D93E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1D93E48", Offset = "0x1D93E48", VA = "0x1D93E48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1D93148", Offset = "0x1D93148", VA = "0x1D93148")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1D93174", Offset = "0x1D93174", VA = "0x1D93174")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1D93344", Offset = "0x1D93344", VA = "0x1D93344", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1D93EE8", Offset = "0x1D93EE8", VA = "0x1D93EE8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1D94040", Offset = "0x1D94040", VA = "0x1D94040")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1D9407C", Offset = "0x1D9407C", VA = "0x1D9407C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1D94214", Offset = "0x1D94214", VA = "0x1D94214")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1D18", Offset = "0xCE1D18")]
		public float weight;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1D50", Offset = "0xCE1D50")]
		public float offset;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x25C0320", Offset = "0x25C0320", VA = "0x25C0320")]
		private void Start()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x25C03F4", Offset = "0x25C03F4", VA = "0x25C03F4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x25C04E0", Offset = "0x25C04E0", VA = "0x25C04E0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x25C0928", Offset = "0x25C0928", VA = "0x25C0928")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x25C0960", Offset = "0x25C0960", VA = "0x25C0960")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x25C0A58", Offset = "0x25C0A58", VA = "0x25C0A58")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Settings
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5D24", Offset = "0xCE5D24")]
			public float scaleMlp;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5D5C", Offset = "0xCE5D5C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5D94", Offset = "0xCE5D94")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5DCC", Offset = "0xCE5DCC")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5E04", Offset = "0xCE5E04")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5E3C", Offset = "0xCE5E3C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5E74", Offset = "0xCE5E74")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5EAC", Offset = "0xCE5EAC")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5EE4", Offset = "0xCE5EE4")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCE5F1C", Offset = "0xCE5F1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5F1C", Offset = "0xCE5F1C")]
			public Vector3 headOffset;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5F6C", Offset = "0xCE5F6C")]
			public Vector3 handOffset;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5FA4", Offset = "0xCE5FA4")]
			public float footForwardOffset;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE5FDC", Offset = "0xCE5FDC")]
			public float footInwardOffset;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE6014", Offset = "0xCE6014")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE6014", Offset = "0xCE6014")]
			public float footHeadingOffset;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE6070", Offset = "0xCE6070")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE6088", Offset = "0xCE6088")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x25C5ACC", Offset = "0x25C5ACC", VA = "0x25C5ACC")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000DB")]
			public class Target
			{
				[Token(Token = "0x40006A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40006A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40006A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000747")]
				[Address(RVA = "0x25C4B78", Offset = "0x25C4B78", VA = "0x25C4B78")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000748")]
				[Address(RVA = "0x25C56CC", Offset = "0x25C56CC", VA = "0x25C56CC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x25C401C", Offset = "0x25C401C", VA = "0x25C401C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x25C2BB4", Offset = "0x25C2BB4", VA = "0x25C2BB4")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x25C2D1C", Offset = "0x25C2D1C", VA = "0x25C2D1C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x25C4194", Offset = "0x25C4194", VA = "0x25C4194")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x25C4C3C", Offset = "0x25C4C3C", VA = "0x25C4C3C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x25C572C", Offset = "0x25C572C", VA = "0x25C572C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE1D88", Offset = "0xCE1D88")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000063")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x25C5BC4", Offset = "0x25C5BC4", VA = "0x25C5BC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE81F0", Offset = "0xCE81F0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x25C5BD0", Offset = "0x25C5BD0", VA = "0x25C5BD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8200", Offset = "0xCE8200")]
			private set
			{
			}
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x25C5BDC", Offset = "0x25C5BDC", VA = "0x25C5BDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x25C4954", Offset = "0x25C4954", VA = "0x25C4954")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x25C595C", Offset = "0x25C595C", VA = "0x25C595C")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x25C5CB4", Offset = "0x25C5CB4", VA = "0x25C5CB4")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x25C6158", Offset = "0x25C6158", VA = "0x25C6158")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x25C6250", Offset = "0x25C6250", VA = "0x25C6250")]
		public VRIKRootController()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x2000075")]
	public class APITester : MonoBehaviour
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int selectedTab;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string[] tabs;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSLevel currentFPSLevel;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1F2BB8C", Offset = "0x1F2BB8C", VA = "0x1F2BB8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1F2BCCC", Offset = "0x1F2BCCC", VA = "0x1F2BCCC")]
		private void OnFPSLevelChanged(FPSLevel newLevel)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1F2BCD4", Offset = "0x1F2BCD4", VA = "0x1F2BCD4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1F2D020", Offset = "0x1F2D020", VA = "0x1F2D020")]
		private void DrawCommonTab()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1F2DD68", Offset = "0x1F2DD68", VA = "0x1F2DD68")]
		private void DrawLookFeelTab()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1F2EAB4", Offset = "0x1F2EAB4", VA = "0x1F2EAB4")]
		private void DrawFPSCounterTab()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1F3031C", Offset = "0x1F3031C", VA = "0x1F3031C")]
		private void DrawMemoryCounterTab()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1F31200", Offset = "0x1F31200", VA = "0x1F31200")]
		private void DrawDeviceInfoTab()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1F32324", Offset = "0x1F32324", VA = "0x1F32324")]
		private static float SliderLabel(float sliderValue, float sliderMinValue, float sliderMaxValue)
		{
			return default(float);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1F328E4", Offset = "0x1F328E4", VA = "0x1F328E4")]
		private Color ColorSliders(string caption, Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1F3262C", Offset = "0x1F3262C", VA = "0x1F3262C")]
		private Vector2 Vector2Slider(Vector2 input, string label)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1F33898", Offset = "0x1F33898", VA = "0x1F33898")]
		public APITester()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDE030", Offset = "0xCDE030")]
	[DisallowMultipleComponent]
	public class AFPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40003A8")]
		private const string MENU_PATH = "Code Stage/Advanced FPS Counter";

		[Token(Token = "0x40003A9")]
		private const string COMPONENT_NAME = "Advanced FPS Counter";

		[Token(Token = "0x40003AA")]
		internal const string LOG_PREFIX = "<b>[AFPSCounter]:</b> ";

		[Token(Token = "0x40003AB")]
		internal const char NEW_LINE = '\n';

		[Token(Token = "0x40003AC")]
		internal const char SPACE = ' ';

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FPSCounterData fpsCounter;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MemoryCounterData memoryCounter;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DeviceInfoCounterData deviceInfoCounter;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1D98", Offset = "0xCE1D98")]
		public KeyCode hotKey;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1DD0", Offset = "0xCE1DD0")]
		public bool circleGesture;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1E08", Offset = "0xCE1E08")]
		public bool hotKeyCtrl;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1E40", Offset = "0xCE1E40")]
		public bool hotKeyShift;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1E78", Offset = "0xCE1E78")]
		public bool hotKeyAlt;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1EB0", Offset = "0xCE1EB0")]
		[SerializeField]
		private bool keepAlive;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Canvas canvas;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasScaler canvasScaler;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool externalCanvas;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DrawableLabel[] labels;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int anchorsCount;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int cachedVSync;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int cachedFrameRate;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool inited;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<Vector2> gesturePoints;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int gestureCount;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1EFC", Offset = "0xCE1EFC")]
		[SerializeField]
		private OperationMode operationMode;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1F48", Offset = "0xCE1F48")]
		[SerializeField]
		private bool forceFrameRate;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE1F94", Offset = "0xCE1F94")]
		[SerializeField]
		private int forcedFrameRate;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE1FD8", Offset = "0xCE1FD8")]
		[SerializeField]
		private bool background;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2024", Offset = "0xCE2024")]
		[SerializeField]
		private Color backgroundColor;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2070", Offset = "0xCE2070")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE2070", Offset = "0xCE2070")]
		[SerializeField]
		private int backgroundPadding;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE20D4", Offset = "0xCE20D4")]
		[SerializeField]
		private bool shadow;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2120", Offset = "0xCE2120")]
		[SerializeField]
		private Color shadowColor;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE216C", Offset = "0xCE216C")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE21B8", Offset = "0xCE21B8")]
		[SerializeField]
		private bool outline;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2204", Offset = "0xCE2204")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2250", Offset = "0xCE2250")]
		[SerializeField]
		private Vector2 outlineDistance;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE229C", Offset = "0xCE229C")]
		[SerializeField]
		private bool autoScale;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE22E8", Offset = "0xCE22E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE22E8", Offset = "0xCE22E8")]
		[SerializeField]
		private float scaleFactor;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE234C", Offset = "0xCE234C")]
		[SerializeField]
		private Font labelsFont;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2398", Offset = "0xCE2398")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE2398", Offset = "0xCE2398")]
		[SerializeField]
		private int fontSize;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2400", Offset = "0xCE2400")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE2400", Offset = "0xCE2400")]
		[SerializeField]
		private float lineSpacing;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2464", Offset = "0xCE2464")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE2464", Offset = "0xCE2464")]
		[SerializeField]
		private int countersSpacing;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE24C8", Offset = "0xCE24C8")]
		[SerializeField]
		private Vector2 paddingOffset;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2514", Offset = "0xCE2514")]
		[SerializeField]
		private bool pixelPerfect;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2560", Offset = "0xCE2560")]
		[SerializeField]
		private int sortingOrder;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE25AC", Offset = "0xCE25AC")]
		private static AFPSCounter <Instance>k__BackingField;

		[Token(Token = "0x17000064")]
		public bool KeepAlive
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1F27D90", Offset = "0x1F27D90", VA = "0x1F27D90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public OperationMode OperationMode
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1F27D98", Offset = "0x1F27D98", VA = "0x1F27D98")]
			get
			{
				return default(OperationMode);
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1F27DA0", Offset = "0x1F27DA0", VA = "0x1F27DA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool ForceFrameRate
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1F283EC", Offset = "0x1F283EC", VA = "0x1F283EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1F283F4", Offset = "0x1F283F4", VA = "0x1F283F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public int ForcedFrameRate
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1F28460", Offset = "0x1F28460", VA = "0x1F28460")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1F28468", Offset = "0x1F28468", VA = "0x1F28468")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool Background
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1F284C0", Offset = "0x1F284C0", VA = "0x1F284C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1F284C8", Offset = "0x1F284C8", VA = "0x1F284C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Color BackgroundColor
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1F28598", Offset = "0x1F28598", VA = "0x1F28598")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1F285A4", Offset = "0x1F285A4", VA = "0x1F285A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int BackgroundPadding
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1F286A8", Offset = "0x1F286A8", VA = "0x1F286A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1F286B0", Offset = "0x1F286B0", VA = "0x1F286B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public bool Shadow
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1F2877C", Offset = "0x1F2877C", VA = "0x1F2877C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1F28784", Offset = "0x1F28784", VA = "0x1F28784")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Color ShadowColor
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x1F28854", Offset = "0x1F28854", VA = "0x1F28854")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1F28860", Offset = "0x1F28860", VA = "0x1F28860")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Vector2 ShadowDistance
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1F28964", Offset = "0x1F28964", VA = "0x1F28964")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x1F2896C", Offset = "0x1F2896C", VA = "0x1F2896C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool Outline
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1F28A98", Offset = "0x1F28A98", VA = "0x1F28A98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1F28AA0", Offset = "0x1F28AA0", VA = "0x1F28AA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Color OutlineColor
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x1F28B70", Offset = "0x1F28B70", VA = "0x1F28B70")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x1F28B7C", Offset = "0x1F28B7C", VA = "0x1F28B7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Vector2 OutlineDistance
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x1F28C80", Offset = "0x1F28C80", VA = "0x1F28C80")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x1F28C88", Offset = "0x1F28C88", VA = "0x1F28C88")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool AutoScale
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x1F28DB4", Offset = "0x1F28DB4", VA = "0x1F28DB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x1F28DBC", Offset = "0x1F28DBC", VA = "0x1F28DBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public float ScaleFactor
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x1F28E8C", Offset = "0x1F28E8C", VA = "0x1F28E8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x1F28E94", Offset = "0x1F28E94", VA = "0x1F28E94")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public Font LabelsFont
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x1F28FC8", Offset = "0x1F28FC8", VA = "0x1F28FC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1F28FD0", Offset = "0x1F28FD0", VA = "0x1F28FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public int FontSize
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1F29104", Offset = "0x1F29104", VA = "0x1F29104")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1F2910C", Offset = "0x1F2910C", VA = "0x1F2910C")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public float LineSpacing
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1F29254", Offset = "0x1F29254", VA = "0x1F29254")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x1F2925C", Offset = "0x1F2925C", VA = "0x1F2925C")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public int CountersSpacing
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1F293FC", Offset = "0x1F293FC", VA = "0x1F293FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1F29404", Offset = "0x1F29404", VA = "0x1F29404")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Vector2 PaddingOffset
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1F294B0", Offset = "0x1F294B0", VA = "0x1F294B0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x1F294B8", Offset = "0x1F294B8", VA = "0x1F294B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool PixelPerfect
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1F29678", Offset = "0x1F29678", VA = "0x1F29678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1F29680", Offset = "0x1F29680", VA = "0x1F29680")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public int SortingOrder
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1F296F8", Offset = "0x1F296F8", VA = "0x1F296F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1F29700", Offset = "0x1F29700", VA = "0x1F29700")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public static AFPSCounter Instance
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1F29C6C", Offset = "0x1F29C6C", VA = "0x1F29C6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8210", Offset = "0xCE8210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1F29CBC", Offset = "0x1F29CBC", VA = "0x1F29CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8220", Offset = "0xCE8220")]
			private set
			{
			}
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1F297CC", Offset = "0x1F297CC", VA = "0x1F297CC")]
		private AFPSCounter()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1F29D10", Offset = "0x1F29D10", VA = "0x1F29D10")]
		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1F29F80", Offset = "0x1F29F80", VA = "0x1F29F80")]
		public static AFPSCounter AddToScene()
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1F29F88", Offset = "0x1F29F88", VA = "0x1F29F88")]
		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1F29F90", Offset = "0x1F29F90", VA = "0x1F29F90")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1F2A168", Offset = "0x1F2A168", VA = "0x1F2A168")]
		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1F29E80", Offset = "0x1F29E80", VA = "0x1F29E80")]
		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1F2A228", Offset = "0x1F2A228", VA = "0x1F2A228")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1F2A894", Offset = "0x1F2A894", VA = "0x1F2A894")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1F2A9A0", Offset = "0x1F2A9A0", VA = "0x1F2A9A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1F2AED0", Offset = "0x1F2AED0", VA = "0x1F2AED0")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1F2AED4", Offset = "0x1F2AED4", VA = "0x1F2AED4")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1F27F7C", Offset = "0x1F27F7C", VA = "0x1F27F7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1F28310", Offset = "0x1F28310", VA = "0x1F28310")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1F2B18C", Offset = "0x1F2B18C", VA = "0x1F2B18C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1F2B448", Offset = "0x1F2B448", VA = "0x1F2B448")]
		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1F27FF8", Offset = "0x1F27FF8", VA = "0x1F27FF8")]
		internal void UpdateTexts()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1F2A3C0", Offset = "0x1F2A3C0", VA = "0x1F2A3C0")]
		private void ConfigureCanvas()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1F2A604", Offset = "0x1F2A604", VA = "0x1F2A604")]
		private void ConfigureLabels()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1F2A084", Offset = "0x1F2A084", VA = "0x1F2A084")]
		private void DisposeInternal()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1F2A9EC", Offset = "0x1F2A9EC", VA = "0x1F2A9EC")]
		private void ProcessHotKey()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1F2AAF0", Offset = "0x1F2AAF0", VA = "0x1F2AAF0")]
		private bool CircleGestureMade()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1F2AEAC", Offset = "0x1F2AEAC", VA = "0x1F2AEAC")]
		private void SwitchCounter()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1F2AF6C", Offset = "0x1F2AF6C", VA = "0x1F2AF6C")]
		private void ActivateCounters()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1F2B008", Offset = "0x1F2B008", VA = "0x1F2B008")]
		private void DeactivateCounters()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1F28458", Offset = "0x1F28458", VA = "0x1F28458")]
		private void RefreshForcedFrameRate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1F2B0FC", Offset = "0x1F2B0FC", VA = "0x1F2B0FC")]
		private void RefreshForcedFrameRate(bool disabling)
		{
		}
	}
	[Token(Token = "0x2000077")]
	public enum FPSLevel : byte
	{
		[Token(Token = "0x40003D7")]
		Normal,
		[Token(Token = "0x40003D8")]
		Warning,
		[Token(Token = "0x40003D9")]
		Critical
	}
	[Token(Token = "0x2000078")]
	public enum OperationMode : byte
	{
		[Token(Token = "0x40003DB")]
		Disabled,
		[Token(Token = "0x40003DC")]
		Background,
		[Token(Token = "0x40003DD")]
		Normal
	}
	[Token(Token = "0x2000079")]
	internal class UIUtils
	{
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1F2B7FC", Offset = "0x1F2B7FC", VA = "0x1F2B7FC")]
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1F375A8", Offset = "0x1F375A8", VA = "0x1F375A8")]
		public UIUtils()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class WaitForSecondsUnscaled : CustomYieldInstruction
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly float waitTime;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float runUntil;

		[Token(Token = "0x1700007B")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1F377BC", Offset = "0x1F377BC", VA = "0x1F377BC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1F35DAC", Offset = "0x1F35DAC", VA = "0x1F35DAC")]
		public new void Reset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1F36928", Offset = "0x1F36928", VA = "0x1F36928")]
		public WaitForSecondsUnscaled(float time)
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[Token(Token = "0x200007B")]
	[DisallowMultipleComponent]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool recording;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float renderTime;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1F375B0", Offset = "0x1F375B0", VA = "0x1F375B0")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1F37678", Offset = "0x1F37678", VA = "0x1F37678")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1F377B4", Offset = "0x1F377B4", VA = "0x1F377B4")]
		public AFPSRenderRecorder()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Labels
{
	[Token(Token = "0x200007C")]
	internal class DrawableLabel
	{
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal GameObject container;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal LabelAnchor anchor;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal StringBuilder newText;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool dirty;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject labelGameObject;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform labelTransform;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ContentSizeFitter labelFitter;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HorizontalLayoutGroup labelGroup;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject uiTextGameObject;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Text uiText;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Font font;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int fontSize;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lineSpacing;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 pixelOffset;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly LabelEffect background;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image backgroundImage;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly LabelEffect shadow;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Shadow shadowComponent;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly LabelEffect outline;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Outline outlineComponent;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1F2BA98", Offset = "0x1F2BA98", VA = "0x1F2BA98")]
		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1F2B4A0", Offset = "0x1F2B4A0", VA = "0x1F2B4A0")]
		internal void CheckAndUpdate()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1F27EA4", Offset = "0x1F27EA4", VA = "0x1F27EA4")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1F2B424", Offset = "0x1F2B424", VA = "0x1F2B424")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1F290DC", Offset = "0x1F290DC", VA = "0x1F290DC")]
		internal void ChangeFont(Font labelsFont)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1F291B0", Offset = "0x1F291B0", VA = "0x1F291B0")]
		internal void ChangeFontSize(int newSize)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1F295C8", Offset = "0x1F295C8", VA = "0x1F295C8")]
		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1F29358", Offset = "0x1F29358", VA = "0x1F29358")]
		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1F28578", Offset = "0x1F28578", VA = "0x1F28578")]
		internal void ChangeBackground(bool enabled)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1F28688", Offset = "0x1F28688", VA = "0x1F28688")]
		internal void ChangeBackgroundColor(Color color)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1F28760", Offset = "0x1F28760", VA = "0x1F28760")]
		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1F28834", Offset = "0x1F28834", VA = "0x1F28834")]
		internal void ChangeShadow(bool enabled)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1F28944", Offset = "0x1F28944", VA = "0x1F28944")]
		internal void ChangeShadowColor(Color color)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1F28A7C", Offset = "0x1F28A7C", VA = "0x1F28A7C")]
		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1F28B50", Offset = "0x1F28B50", VA = "0x1F28B50")]
		internal void ChangeOutline(bool enabled)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1F28C60", Offset = "0x1F28C60", VA = "0x1F28C60")]
		internal void ChangeOutlineColor(Color color)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1F28D98", Offset = "0x1F28D98", VA = "0x1F28D98")]
		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1F36E24", Offset = "0x1F36E24", VA = "0x1F36E24")]
		private void UpdateTextPosition()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1F3695C", Offset = "0x1F3695C", VA = "0x1F3695C")]
		private void NormalizeOffset()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1F37304", Offset = "0x1F37304", VA = "0x1F37304")]
		private void ApplyBackground()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1F369C0", Offset = "0x1F369C0", VA = "0x1F369C0")]
		private void ApplyShadow()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1F36B78", Offset = "0x1F36B78", VA = "0x1F36B78")]
		private void ApplyOutline()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1F36D30", Offset = "0x1F36D30", VA = "0x1F36D30")]
		private void ApplyFont()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public enum LabelAnchor : byte
	{
		[Token(Token = "0x40003F7")]
		UpperLeft,
		[Token(Token = "0x40003F8")]
		UpperRight,
		[Token(Token = "0x40003F9")]
		LowerLeft,
		[Token(Token = "0x40003FA")]
		LowerRight,
		[Token(Token = "0x40003FB")]
		UpperCenter,
		[Token(Token = "0x40003FC")]
		LowerCenter
	}
}
namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDE08C", Offset = "0xCDE08C")]
	public abstract class BaseCounterData
	{
		[Token(Token = "0x40003FD")]
		protected const string BOLD_START = "<b>";

		[Token(Token = "0x40003FE")]
		protected const string BOLD_END = "</b>";

		[Token(Token = "0x40003FF")]
		protected const string ITALIC_START = "<i>";

		[Token(Token = "0x4000400")]
		protected const string ITALIC_END = "</i>";

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal StringBuilder text;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool dirty;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AFPSCounter main;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string colorCached;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool inited;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool enabled;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE25CC", Offset = "0xCE25CC")]
		[SerializeField]
		protected LabelAnchor anchor;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2618", Offset = "0xCE2618")]
		[SerializeField]
		protected Color color;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2664", Offset = "0xCE2664")]
		[SerializeField]
		protected FontStyle style;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE26B0", Offset = "0xCE26B0")]
		protected string extraText;

		[Token(Token = "0x1700007C")]
		public bool Enabled
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x1F33A24", Offset = "0x1F33A24", VA = "0x1F33A24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1F32BF4", Offset = "0x1F32BF4", VA = "0x1F32BF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public LabelAnchor Anchor
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1F33A2C", Offset = "0x1F33A2C", VA = "0x1F33A2C")]
			get
			{
				return default(LabelAnchor);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1F32D1C", Offset = "0x1F32D1C", VA = "0x1F32D1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Color Color
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1F33A34", Offset = "0x1F33A34", VA = "0x1F33A34")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1F33A40", Offset = "0x1F33A40", VA = "0x1F33A40")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public FontStyle Style
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1F33B44", Offset = "0x1F33B44", VA = "0x1F33B44")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1F32C70", Offset = "0x1F32C70", VA = "0x1F32C70")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public string ExtraText
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1F33B4C", Offset = "0x1F33B4C", VA = "0x1F33B4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1F32CC4", Offset = "0x1F32CC4", VA = "0x1F32CC4")]
			set
			{
			}
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1F33AE8", Offset = "0x1F33AE8", VA = "0x1F33AE8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1F33B54", Offset = "0x1F33B54", VA = "0x1F33B54", Slot = "4")]
		internal virtual void UpdateValue()
		{
		}

		[Token(Token = "0x600051C")]
		internal abstract void UpdateValue(bool force);

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1F33B64", Offset = "0x1F33B64", VA = "0x1F33B64")]
		internal void Init(AFPSCounter reference)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1F2B3D8", Offset = "0x1F2B3D8", VA = "0x1F2B3D8")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1F33B6C", Offset = "0x1F33B6C", VA = "0x1F33B6C", Slot = "6")]
		internal virtual void Activate()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1F33C8C", Offset = "0x1F33C8C", VA = "0x1F33C8C", Slot = "7")]
		internal virtual void Deactivate()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1F33D00", Offset = "0x1F33D00", VA = "0x1F33D00", Slot = "8")]
		protected virtual void PerformInitActions()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1F33D04", Offset = "0x1F33D04", VA = "0x1F33D04", Slot = "9")]
		protected virtual void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1F33D08", Offset = "0x1F33D08", VA = "0x1F33D08", Slot = "10")]
		protected virtual void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000524")]
		protected abstract bool HasData();

		[Token(Token = "0x6000525")]
		protected abstract void CacheCurrentColor();

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1F33D0C", Offset = "0x1F33D0C", VA = "0x1F33D0C")]
		protected void ApplyTextStyles()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1F33EA0", Offset = "0x1F33EA0", VA = "0x1F33EA0")]
		protected BaseCounterData()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class UpdatebleCounterData : BaseCounterData
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Coroutine updateCoroutine;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected WaitForSecondsUnscaled cachedWaitForSecondsUnscaled;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE26E8", Offset = "0xCE26E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE26E8", Offset = "0xCE26E8")]
		[SerializeField]
		protected float updateInterval;

		[Token(Token = "0x17000081")]
		public float UpdateInterval
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x1F3683C", Offset = "0x1F3683C", VA = "0x1F3683C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1F32D90", Offset = "0x1F32D90", VA = "0x1F32D90")]
			set
			{
			}
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1F368B4", Offset = "0x1F368B4", VA = "0x1F368B4", Slot = "8")]
		protected override void PerformInitActions()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1F35A88", Offset = "0x1F35A88", VA = "0x1F35A88", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1F35AC8", Offset = "0x1F35AC8", VA = "0x1F35AC8", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600052D")]
		protected abstract IEnumerator UpdateCounter();

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1F368B8", Offset = "0x1F368B8", VA = "0x1F368B8")]
		private void StartUpdateCoroutine()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1F36904", Offset = "0x1F36904", VA = "0x1F36904")]
		private void StoptUpdateCoroutine()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1F36844", Offset = "0x1F36844", VA = "0x1F36844")]
		private void CacheWaitForSeconds()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1F35040", Offset = "0x1F35040", VA = "0x1F35040")]
		protected UpdatebleCounterData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDE0C4", Offset = "0xCDE0C4")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2750", Offset = "0xCE2750")]
		[SerializeField]
		private bool platform;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE279C", Offset = "0xCE279C")]
		[SerializeField]
		private bool cpuModel;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE27E8", Offset = "0xCE27E8")]
		[SerializeField]
		private bool gpuModel;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2834", Offset = "0xCE2834")]
		[SerializeField]
		private bool gpuApi;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2880", Offset = "0xCE2880")]
		[SerializeField]
		private bool gpuSpec;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE28CC", Offset = "0xCE28CC")]
		[SerializeField]
		private bool ramSize;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2918", Offset = "0xCE2918")]
		[SerializeField]
		private bool screenData;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2964", Offset = "0xCE2964")]
		[SerializeField]
		private bool deviceModel;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE29B0", Offset = "0xCE29B0")]
		private string <LastValue>k__BackingField;

		[Token(Token = "0x17000082")]
		public bool Platform
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1F33EB0", Offset = "0x1F33EB0", VA = "0x1F33EB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1F33598", Offset = "0x1F33598", VA = "0x1F33598")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool CpuModel
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1F33EB8", Offset = "0x1F33EB8", VA = "0x1F33EB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1F335F8", Offset = "0x1F335F8", VA = "0x1F335F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool GpuModel
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1F33EC0", Offset = "0x1F33EC0", VA = "0x1F33EC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1F33658", Offset = "0x1F33658", VA = "0x1F33658")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool GpuApi
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1F33EC8", Offset = "0x1F33EC8", VA = "0x1F33EC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1F336B8", Offset = "0x1F336B8", VA = "0x1F336B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool GpuSpec
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1F33ED0", Offset = "0x1F33ED0", VA = "0x1F33ED0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1F33718", Offset = "0x1F33718", VA = "0x1F33718")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool RamSize
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x1F33ED8", Offset = "0x1F33ED8", VA = "0x1F33ED8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x1F33778", Offset = "0x1F33778", VA = "0x1F33778")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public bool ScreenData
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x1F33EE0", Offset = "0x1F33EE0", VA = "0x1F33EE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x1F337D8", Offset = "0x1F337D8", VA = "0x1F337D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public bool DeviceModel
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1F33EE8", Offset = "0x1F33EE8", VA = "0x1F33EE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1F33838", Offset = "0x1F33838", VA = "0x1F33838")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public string LastValue
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x1F33EF0", Offset = "0x1F33EF0", VA = "0x1F33EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8230", Offset = "0xCE8230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1F33EF8", Offset = "0x1F33EF8", VA = "0x1F33EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8240", Offset = "0xCE8240")]
			private set
			{
			}
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1F29BF0", Offset = "0x1F29BF0", VA = "0x1F29BF0")]
		internal DeviceInfoCounterData()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1F33F00", Offset = "0x1F33F00", VA = "0x1F33F00", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1F34754", Offset = "0x1F34754", VA = "0x1F34754", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1F34784", Offset = "0x1F34784", VA = "0x1F34784", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDE0FC", Offset = "0xCDE0FC")]
	public class FPSCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE1BC", Offset = "0xCDE1BC")]
		private sealed class <UpdateCounter>d__147 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FPSCounterData <>4__this;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <previousUpdateTime>5__2;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <previousUpdateFrames>5__3;

			[Token(Token = "0x170000F6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072D")]
				[Address(RVA = "0x1F35DDC", Offset = "0x1F35DDC", VA = "0x1F35DDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072F")]
				[Address(RVA = "0x1F35E44", Offset = "0x1F35E44", VA = "0x1F35E44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1F35B3C", Offset = "0x1F35B3C", VA = "0x1F35B3C")]
			[DebuggerHidden]
			public <UpdateCounter>d__147(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1F35C9C", Offset = "0x1F35C9C", VA = "0x1F35C9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1F35CA0", Offset = "0x1F35CA0", VA = "0x1F35CA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1F35DE4", Offset = "0x1F35DE4", VA = "0x1F35DE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000417")]
		private const string COLOR_TEXT_START = "<color=#{0}>";

		[Token(Token = "0x4000418")]
		private const string COLOR_TEXT_END = "</color>";

		[Token(Token = "0x4000419")]
		private const string FPS_TEXT_START = "<color=#{0}>FPS: ";

		[Token(Token = "0x400041A")]
		private const string MS_TEXT_START = " <color=#{0}>[";

		[Token(Token = "0x400041B")]
		private const string MS_TEXT_END = " MS]</color>";

		[Token(Token = "0x400041C")]
		private const string MIN_TEXT_START = "<color=#{0}>MIN: ";

		[Token(Token = "0x400041D")]
		private const string MAX_TEXT_START = "<color=#{0}>MAX: ";

		[Token(Token = "0x400041E")]
		private const string AVG_TEXT_START = "<color=#{0}>AVG: ";

		[Token(Token = "0x400041F")]
		private const string RENDER_TEXT_START = "<color=#{0}>REN: ";

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int warningLevelValue;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int criticalLevelValue;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE29C0", Offset = "0xCE29C0")]
		public bool resetAverageOnNewScene;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE29F8", Offset = "0xCE29F8")]
		public bool resetMinMaxOnNewScene;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2A30", Offset = "0xCE2A30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE2A30", Offset = "0xCE2A30")]
		public int minMaxIntervalsToSkip;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal float newValue;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string colorCachedMs;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string colorCachedMin;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string colorCachedMax;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string colorCachedAvg;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string colorCachedRender;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string colorWarningCached;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string colorWarningCachedMs;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string colorWarningCachedMin;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string colorWarningCachedMax;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string colorWarningCachedAvg;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string colorCriticalCached;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string colorCriticalCachedMs;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string colorCriticalCachedMin;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string colorCriticalCachedMax;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string colorCriticalCachedAvg;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int currentAverageSamples;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float currentAverageRaw;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float[] accumulatedAverageSamples;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int minMaxIntervalsSkipped;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float renderTimeBank;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int previousFrameCount;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2A94", Offset = "0xCE2A94")]
		[SerializeField]
		private bool milliseconds;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2AE0", Offset = "0xCE2AE0")]
		[SerializeField]
		private bool average;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2B2C", Offset = "0xCE2B2C")]
		[SerializeField]
		private bool averageMilliseconds;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2B78", Offset = "0xCE2B78")]
		[SerializeField]
		private bool averageNewLine;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2BC4", Offset = "0xCE2BC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCE2BC4", Offset = "0xCE2BC4")]
		[SerializeField]
		private int averageSamples;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2C2C", Offset = "0xCE2C2C")]
		[SerializeField]
		private bool minMax;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2C78", Offset = "0xCE2C78")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2CC4", Offset = "0xCE2CC4")]
		[SerializeField]
		private bool minMaxNewLine;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2D10", Offset = "0xCE2D10")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2D5C", Offset = "0xCE2D5C")]
		[SerializeField]
		private bool render;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2DA8", Offset = "0xCE2DA8")]
		[SerializeField]
		private bool renderNewLine;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2DF4", Offset = "0xCE2DF4")]
		[SerializeField]
		private bool renderAutoAdd;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2E40", Offset = "0xCE2E40")]
		[SerializeField]
		private Color colorWarning;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2E8C", Offset = "0xCE2E8C")]
		[SerializeField]
		private Color colorCritical;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2ED8", Offset = "0xCE2ED8")]
		[SerializeField]
		protected Color colorRender;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F24", Offset = "0xCE2F24")]
		private int <LastValue>k__BackingField;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F34", Offset = "0xCE2F34")]
		private float <LastMillisecondsValue>k__BackingField;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F44", Offset = "0xCE2F44")]
		private float <LastRenderValue>k__BackingField;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F54", Offset = "0xCE2F54")]
		private int <LastAverageValue>k__BackingField;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F64", Offset = "0xCE2F64")]
		private float <LastAverageMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F74", Offset = "0xCE2F74")]
		private int <LastMinimumValue>k__BackingField;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F84", Offset = "0xCE2F84")]
		private int <LastMaximumValue>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2F94", Offset = "0xCE2F94")]
		private float <LastMinMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2FA4", Offset = "0xCE2FA4")]
		private float <LastMaxMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE2FB4", Offset = "0xCE2FB4")]
		private FPSLevel <CurrentFpsLevel>k__BackingField;

		[Token(Token = "0x1700008B")]
		public bool Milliseconds
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1F348AC", Offset = "0x1F348AC", VA = "0x1F348AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x1F32E38", Offset = "0x1F32E38", VA = "0x1F32E38")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool Average
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1F348B4", Offset = "0x1F348B4", VA = "0x1F348B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1F32EA0", Offset = "0x1F32EA0", VA = "0x1F32EA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool AverageMilliseconds
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1F348BC", Offset = "0x1F348BC", VA = "0x1F348BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x1F32FF4", Offset = "0x1F32FF4", VA = "0x1F32FF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool AverageNewLine
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x1F348C4", Offset = "0x1F348C4", VA = "0x1F348C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1F3305C", Offset = "0x1F3305C", VA = "0x1F3305C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public int AverageSamples
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x1F348CC", Offset = "0x1F348CC", VA = "0x1F348CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x1F32F0C", Offset = "0x1F32F0C", VA = "0x1F32F0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool MinMax
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x1F348D4", Offset = "0x1F348D4", VA = "0x1F348D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x1F33118", Offset = "0x1F33118", VA = "0x1F33118")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool MinMaxMilliseconds
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x1F348DC", Offset = "0x1F348DC", VA = "0x1F348DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x1F33188", Offset = "0x1F33188", VA = "0x1F33188")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool MinMaxNewLine
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x1F348E4", Offset = "0x1F348E4", VA = "0x1F348E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x1F33268", Offset = "0x1F33268", VA = "0x1F33268")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool MinMaxTwoLines
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x1F348EC", Offset = "0x1F348EC", VA = "0x1F348EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1F33208", Offset = "0x1F33208", VA = "0x1F33208")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool Render
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1F348F4", Offset = "0x1F348F4", VA = "0x1F348F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1F33318", Offset = "0x1F33318", VA = "0x1F33318")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool RenderNewLine
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x1F34AF0", Offset = "0x1F34AF0", VA = "0x1F34AF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x1F333A0", Offset = "0x1F333A0", VA = "0x1F333A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool RenderAutoAdd
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x1F34AF8", Offset = "0x1F34AF8", VA = "0x1F34AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1F34B00", Offset = "0x1F34B00", VA = "0x1F34B00")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public Color ColorWarning
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1F34B64", Offset = "0x1F34B64", VA = "0x1F34B64")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1F34B78", Offset = "0x1F34B78", VA = "0x1F34B78")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public Color ColorCritical
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x1F34D1C", Offset = "0x1F34D1C", VA = "0x1F34D1C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x1F34D30", Offset = "0x1F34D30", VA = "0x1F34D30")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Color ColorRender
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1F34ED4", Offset = "0x1F34ED4", VA = "0x1F34ED4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x1F34EE8", Offset = "0x1F34EE8", VA = "0x1F34EE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int LastValue
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1F34FA0", Offset = "0x1F34FA0", VA = "0x1F34FA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8270", Offset = "0xCE8270")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x1F34FA8", Offset = "0x1F34FA8", VA = "0x1F34FA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8280", Offset = "0xCE8280")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public float LastMillisecondsValue
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x1F34FB0", Offset = "0x1F34FB0", VA = "0x1F34FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8290", Offset = "0xCE8290")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x1F34FB8", Offset = "0x1F34FB8", VA = "0x1F34FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE82A0", Offset = "0xCE82A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public float LastRenderValue
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x1F34FC0", Offset = "0x1F34FC0", VA = "0x1F34FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE82B0", Offset = "0xCE82B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x1F34FC8", Offset = "0x1F34FC8", VA = "0x1F34FC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE82C0", Offset = "0xCE82C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public int LastAverageValue
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x1F34FD0", Offset = "0x1F34FD0", VA = "0x1F34FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE82D0", Offset = "0xCE82D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x1F34FD8", Offset = "0x1F34FD8", VA = "0x1F34FD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE82E0", Offset = "0xCE82E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public float LastAverageMillisecondsValue
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x1F34FE0", Offset = "0x1F34FE0", VA = "0x1F34FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE82F0", Offset = "0xCE82F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x1F34FE8", Offset = "0x1F34FE8", VA = "0x1F34FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8300", Offset = "0xCE8300")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public int LastMinimumValue
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1F34FF0", Offset = "0x1F34FF0", VA = "0x1F34FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8310", Offset = "0xCE8310")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1F34FF8", Offset = "0x1F34FF8", VA = "0x1F34FF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8320", Offset = "0xCE8320")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public int LastMaximumValue
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1F35000", Offset = "0x1F35000", VA = "0x1F35000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8330", Offset = "0xCE8330")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1F35008", Offset = "0x1F35008", VA = "0x1F35008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8340", Offset = "0xCE8340")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public float LastMinMillisecondsValue
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x1F35010", Offset = "0x1F35010", VA = "0x1F35010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8350", Offset = "0xCE8350")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1F35018", Offset = "0x1F35018", VA = "0x1F35018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8360", Offset = "0xCE8360")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float LastMaxMillisecondsValue
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1F35020", Offset = "0x1F35020", VA = "0x1F35020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8370", Offset = "0xCE8370")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1F35028", Offset = "0x1F35028", VA = "0x1F35028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8380", Offset = "0xCE8380")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public FPSLevel CurrentFpsLevel
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1F35030", Offset = "0x1F35030", VA = "0x1F35030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8390", Offset = "0xCE8390")]
			get
			{
				return default(FPSLevel);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1F35038", Offset = "0x1F35038", VA = "0x1F35038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE83A0", Offset = "0xCE83A0")]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<FPSLevel> OnFPSLevelChange
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1F2BC28", Offset = "0x1F2BC28", VA = "0x1F2BC28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8250", Offset = "0xCE8250")]
			add
			{
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1F34808", Offset = "0x1F34808", VA = "0x1F34808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8260", Offset = "0xCE8260")]
			remove
			{
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1F29A04", Offset = "0x1F29A04", VA = "0x1F29A04")]
		internal FPSCounterData()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1F330BC", Offset = "0x1F330BC", VA = "0x1F330BC")]
		public void ResetAverage()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1F332C8", Offset = "0x1F332C8", VA = "0x1F332C8")]
		public void ResetMinMax(bool withoutUpdate = false)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1F2AF00", Offset = "0x1F2AF00", VA = "0x1F2AF00")]
		internal void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1F35058", Offset = "0x1F35058", VA = "0x1F35058")]
		internal void AddRenderTime(float time)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1F35078", Offset = "0x1F35078", VA = "0x1F35078", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1F35988", Offset = "0x1F35988", VA = "0x1F35988", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1F35A8C", Offset = "0x1F35A8C", VA = "0x1F35A8C", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1F35ACC", Offset = "0x1F35ACC", VA = "0x1F35ACC", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCE83B0", Offset = "0xCE83B0")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1F35B68", Offset = "0x1F35B68", VA = "0x1F35B68", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1F35B70", Offset = "0x1F35B70", VA = "0x1F35B70", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1F34C28", Offset = "0x1F34C28", VA = "0x1F34C28")]
		protected void CacheWarningColor()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1F34DE0", Offset = "0x1F34DE0", VA = "0x1F34DE0")]
		protected void CacheCriticalColor()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1F3590C", Offset = "0x1F3590C", VA = "0x1F3590C")]
		private float GetAverageFromAccumulatedSamples()
		{
			return default(float);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1F349F8", Offset = "0x1F349F8", VA = "0x1F349F8")]
		private static void TryToAddRenderRecorder()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1F348FC", Offset = "0x1F348FC", VA = "0x1F348FC")]
		private static void TryToRemoveRenderRecorder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCDE134", Offset = "0xCDE134")]
	public class MemoryCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE1CC", Offset = "0xCDE1CC")]
		private sealed class <UpdateCounter>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MemoryCounterData <>4__this;

			[Token(Token = "0x170000F8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000733")]
				[Address(RVA = "0x1F367CC", Offset = "0x1F367CC", VA = "0x1F367CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x1F36834", Offset = "0x1F36834", VA = "0x1F36834", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1F36668", Offset = "0x1F36668", VA = "0x1F36668")]
			[DebuggerHidden]
			public <UpdateCounter>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1F36734", Offset = "0x1F36734", VA = "0x1F36734", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1F36738", Offset = "0x1F36738", VA = "0x1F36738", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1F367D4", Offset = "0x1F367D4", VA = "0x1F367D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000455")]
		public const long MEMORY_DIVIDER = 1048576L;

		[Token(Token = "0x4000456")]
		private const string TEXT_START = "<color=#{0}>";

		[Token(Token = "0x4000457")]
		private const string LINE_START_TOTAL = "MEM TOTAL: ";

		[Token(Token = "0x4000458")]
		private const string LINE_START_ALLOCATED = "MEM ALLOC: ";

		[Token(Token = "0x4000459")]
		private const string LINE_START_MONO = "MEM MONO: ";

		[Token(Token = "0x400045A")]
		private const string LINE_END = " MB";

		[Token(Token = "0x400045B")]
		private const string TEXT_END = "</color>";

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE2FC4", Offset = "0xCE2FC4")]
		[SerializeField]
		private bool precise;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE3010", Offset = "0xCE3010")]
		[SerializeField]
		private bool total;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE305C", Offset = "0xCE305C")]
		[SerializeField]
		private bool allocated;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCE30A8", Offset = "0xCE30A8")]
		[SerializeField]
		private bool monoUsage;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE30F4", Offset = "0xCE30F4")]
		private long <LastTotalValue>k__BackingField;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE3104", Offset = "0xCE3104")]
		private long <LastAllocatedValue>k__BackingField;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE3114", Offset = "0xCE3114")]
		private long <LastMonoValue>k__BackingField;

		[Token(Token = "0x170000A4")]
		public bool Precise
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1F35E4C", Offset = "0x1F35E4C", VA = "0x1F35E4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x1F33400", Offset = "0x1F33400", VA = "0x1F33400")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool Total
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1F35E54", Offset = "0x1F35E54", VA = "0x1F35E54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1F33460", Offset = "0x1F33460", VA = "0x1F33460")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool Allocated
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1F35E5C", Offset = "0x1F35E5C", VA = "0x1F35E5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1F334C8", Offset = "0x1F334C8", VA = "0x1F334C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool MonoUsage
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1F35E64", Offset = "0x1F35E64", VA = "0x1F35E64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1F33530", Offset = "0x1F33530", VA = "0x1F33530")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public long LastTotalValue
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1F35E6C", Offset = "0x1F35E6C", VA = "0x1F35E6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8414", Offset = "0xCE8414")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1F35E74", Offset = "0x1F35E74", VA = "0x1F35E74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8424", Offset = "0xCE8424")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public long LastAllocatedValue
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1F35E7C", Offset = "0x1F35E7C", VA = "0x1F35E7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8434", Offset = "0xCE8434")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x1F35E84", Offset = "0x1F35E84", VA = "0x1F35E84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8444", Offset = "0xCE8444")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public long LastMonoValue
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1F35E8C", Offset = "0x1F35E8C", VA = "0x1F35E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8454", Offset = "0xCE8454")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1F35E94", Offset = "0x1F35E94", VA = "0x1F35E94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE8464", Offset = "0xCE8464")]
			private set
			{
			}
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1F29B70", Offset = "0x1F29B70", VA = "0x1F29B70")]
		internal MemoryCounterData()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1F35E9C", Offset = "0x1F35E9C", VA = "0x1F35E9C", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1F36310", Offset = "0x1F36310", VA = "0x1F36310", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1F365B4", Offset = "0x1F365B4", VA = "0x1F365B4", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1F365F8", Offset = "0x1F365F8", VA = "0x1F365F8", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCE8474", Offset = "0xCE8474")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1F36694", Offset = "0x1F36694", VA = "0x1F36694", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1F366BC", Offset = "0x1F366BC", VA = "0x1F366BC", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
}
