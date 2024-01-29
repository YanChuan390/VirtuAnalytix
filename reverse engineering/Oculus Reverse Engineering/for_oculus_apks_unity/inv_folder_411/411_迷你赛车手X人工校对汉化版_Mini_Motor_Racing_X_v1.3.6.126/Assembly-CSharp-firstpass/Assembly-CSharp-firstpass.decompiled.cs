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
using UnityEngine.Events;
using UnityEngine.Experimental.Animations;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("3.7.1.6")]
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
	[Address(RVA = "0x17BAB6C", Offset = "0x17BAB6C", VA = "0x17BAB6C")]
	internal LabelEffect(bool enabled, Color color, int padding)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x17BAC38", Offset = "0x17BAC38", VA = "0x17BAC38")]
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
		[Address(RVA = "0x17C69C8", Offset = "0x17C69C8", VA = "0x17C69C8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17C6A88", Offset = "0x17C6A88", VA = "0x17C6A88")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17C6B34", Offset = "0x17C6B34", VA = "0x17C6B34")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17C6D1C", Offset = "0x17C6D1C", VA = "0x17C6D1C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17C6C50", Offset = "0x17C6C50", VA = "0x17C6C50")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x17C6E38", Offset = "0x17C6E38", VA = "0x17C6E38")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x17C7068", Offset = "0x17C7068", VA = "0x17C7068")]
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
			[Address(RVA = "0x17C7330", Offset = "0x17C7330", VA = "0x17C7330")]
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
			[Address(RVA = "0x17C70BC", Offset = "0x17C70BC", VA = "0x17C70BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x17C73AC", Offset = "0x17C73AC", VA = "0x17C73AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x17C7070", Offset = "0x17C7070", VA = "0x17C7070")]
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
		[Address(RVA = "0x17C7620", Offset = "0x17C7620", VA = "0x17C7620")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x17C7918", Offset = "0x17C7918", VA = "0x17C7918")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x17C7B60", Offset = "0x17C7B60", VA = "0x17C7B60")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x17C7BE4", Offset = "0x17C7BE4", VA = "0x17C7BE4")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x17C7C94", Offset = "0x17C7C94", VA = "0x17C7C94")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x17C77C8", Offset = "0x17C77C8", VA = "0x17C77C8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17C7AC0", Offset = "0x17C7AC0", VA = "0x17C7AC0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17C84D4", Offset = "0x17C84D4", VA = "0x17C84D4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17C82EC", Offset = "0x17C82EC", VA = "0x17C82EC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17C83E0", Offset = "0x17C83E0", VA = "0x17C83E0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17C7EB4", Offset = "0x17C7EB4", VA = "0x17C7EB4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17C7F68", Offset = "0x17C7F68", VA = "0x17C7F68")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17C801C", Offset = "0x17C801C", VA = "0x17C801C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x17C80D0", Offset = "0x17C80D0", VA = "0x17C80D0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x17C8184", Offset = "0x17C8184", VA = "0x17C8184")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17C8238", Offset = "0x17C8238", VA = "0x17C8238")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x17C86F4", Offset = "0x17C86F4", VA = "0x17C86F4")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x17C7DC4", Offset = "0x17C7DC4", VA = "0x17C7DC4")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x17C8660", Offset = "0x17C8660", VA = "0x17C8660")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x17C8764", Offset = "0x17C8764", VA = "0x17C8764")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x17C8840", Offset = "0x17C8840", VA = "0x17C8840")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x17C85E0", Offset = "0x17C85E0", VA = "0x17C85E0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x17C8564", Offset = "0x17C8564", VA = "0x17C8564")]
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
				[Address(RVA = "0x17CD858", Offset = "0x17CD858", VA = "0x17CD858")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xBB9B5C", Offset = "0xBB9B5C", VA = "0xBB9B5C")]
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
			[Address(RVA = "0x17CA39C", Offset = "0x17CA39C", VA = "0x17CA39C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool isEmpty
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x17CA788", Offset = "0x17CA788", VA = "0x17CA788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17CA798", Offset = "0x17CA798", VA = "0x17CA798", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x17CABC4", Offset = "0x17CABC4", VA = "0x17CABC4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x17CAFF4", Offset = "0x17CAFF4", VA = "0x17CAFF4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x17CB60C", Offset = "0x17CB60C", VA = "0x17CB60C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17CB244", Offset = "0x17CB244", VA = "0x17CB244")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x17CBDC4", Offset = "0x17CBDC4", VA = "0x17CBDC4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x17CBEBC", Offset = "0x17CBEBC", VA = "0x17CBEBC")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x17CC424", Offset = "0x17CC424", VA = "0x17CC424")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x17CC220", Offset = "0x17CC220", VA = "0x17CC220")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x17CC094", Offset = "0x17CC094", VA = "0x17CC094")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17CBF5C", Offset = "0x17CBF5C", VA = "0x17CBF5C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17CC328", Offset = "0x17CC328", VA = "0x17CC328")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x17CC524", Offset = "0x17CC524", VA = "0x17CC524")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x17CD038", Offset = "0x17CD038", VA = "0x17CD038")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x17CCAB0", Offset = "0x17CCAB0", VA = "0x17CCAB0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x17CD330", Offset = "0x17CD330", VA = "0x17CD330")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x17CCE54", Offset = "0x17CCE54", VA = "0x17CCE54")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x17CD338", Offset = "0x17CD338", VA = "0x17CD338")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x17CD340", Offset = "0x17CD340", VA = "0x17CD340")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x17CD504", Offset = "0x17CD504", VA = "0x17CD504")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x17CD720", Offset = "0x17CD720", VA = "0x17CD720")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x17CB1D4", Offset = "0x17CB1D4", VA = "0x17CB1D4")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0xAD0BC8", Offset = "0xAD0BC8")]
		public string text;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x17CD860", Offset = "0x17CD860", VA = "0x17CD860")]
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
		[Address(RVA = "0x17CD868", Offset = "0x17CD868", VA = "0x17CD868")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x17CD9A8", Offset = "0x17CD9A8", VA = "0x17CD9A8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class Hierarchy
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x186D2B8", Offset = "0x186D2B8", VA = "0x186D2B8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x186D4BC", Offset = "0x186D4BC", VA = "0x186D4BC")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x186D350", Offset = "0x186D350", VA = "0x186D350")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x186D5DC", Offset = "0x186D5DC", VA = "0x186D5DC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x186D708", Offset = "0x186D708", VA = "0x186D708")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x186D9B4", Offset = "0x186D9B4", VA = "0x186D9B4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x186DAD4", Offset = "0x186DAD4", VA = "0x186DAD4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x186DC60", Offset = "0x186DC60", VA = "0x186DC60")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x186DFF8", Offset = "0x186DFF8", VA = "0x186DFF8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x186DDE0", Offset = "0x186DDE0", VA = "0x186DDE0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x186E19C", Offset = "0x186E19C", VA = "0x186E19C")]
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
		[Address(RVA = "0x186E1A4", Offset = "0x186E1A4", VA = "0x186E1A4")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x186E214", Offset = "0x186E214", VA = "0x186E214")]
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
		[Address(RVA = "0x186E284", Offset = "0x186E284", VA = "0x186E284")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x186ECF4", Offset = "0x186ECF4", VA = "0x186ECF4")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x186EDFC", Offset = "0x186EDFC", VA = "0x186EDFC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x186E5F4", Offset = "0x186E5F4", VA = "0x186E5F4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x186E600", Offset = "0x186E600", VA = "0x186E600")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x186E628", Offset = "0x186E628", VA = "0x186E628")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x186E664", Offset = "0x186E664", VA = "0x186E664")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x186E67C", Offset = "0x186E67C", VA = "0x186E67C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x186E690", Offset = "0x186E690", VA = "0x186E690")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x186E6A4", Offset = "0x186E6A4", VA = "0x186E6A4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x186E6B4", Offset = "0x186E6B4", VA = "0x186E6B4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x186E6FC", Offset = "0x186E6FC", VA = "0x186E6FC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x186E734", Offset = "0x186E734", VA = "0x186E734")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x186E75C", Offset = "0x186E75C", VA = "0x186E75C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x186EEF8", Offset = "0x186EEF8", VA = "0x186EEF8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x186E790", Offset = "0x186E790", VA = "0x186E790")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x186E7B8", Offset = "0x186E7B8", VA = "0x186E7B8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x186E7E8", Offset = "0x186E7E8", VA = "0x186E7E8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x186E81C", Offset = "0x186E81C", VA = "0x186E81C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x186E860", Offset = "0x186E860", VA = "0x186E860")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x186E8C4", Offset = "0x186E8C4", VA = "0x186E8C4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x186E928", Offset = "0x186E928", VA = "0x186E928")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x186E97C", Offset = "0x186E97C", VA = "0x186E97C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x186E9D0", Offset = "0x186E9D0", VA = "0x186E9D0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x186EA68", Offset = "0x186EA68", VA = "0x186EA68")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x186EAFC", Offset = "0x186EAFC", VA = "0x186EAFC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x186EF2C", Offset = "0x186EF2C", VA = "0x186EF2C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x186EBA0", Offset = "0x186EBA0", VA = "0x186EBA0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x186EC84", Offset = "0x186EC84", VA = "0x186EC84")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x186ECB4", Offset = "0x186ECB4", VA = "0x186ECB4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x186F014", Offset = "0x186F014", VA = "0x186F014")]
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
		[Address(RVA = "0x186F01C", Offset = "0x186F01C", VA = "0x186F01C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x186F08C", Offset = "0x186F08C", VA = "0x186F08C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x186F0FC", Offset = "0x186F0FC", VA = "0x186F0FC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x186F158", Offset = "0x186F158", VA = "0x186F158")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x186F22C", Offset = "0x186F22C", VA = "0x186F22C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x186F170", Offset = "0x186F170", VA = "0x186F170")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x186F244", Offset = "0x186F244", VA = "0x186F244")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x186F2E8", Offset = "0x186F2E8", VA = "0x186F2E8")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x186F314", Offset = "0x186F314", VA = "0x186F314")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x186F364", Offset = "0x186F364", VA = "0x186F364")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x186F3D0", Offset = "0x186F3D0", VA = "0x186F3D0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x186F4C8", Offset = "0x186F4C8", VA = "0x186F4C8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x186F5A4", Offset = "0x186F5A4", VA = "0x186F5A4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x186F604", Offset = "0x186F604", VA = "0x186F604")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public static class QuaTools
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x186F634", Offset = "0x186F634", VA = "0x186F634")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x186F780", Offset = "0x186F780", VA = "0x186F780")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x186F8CC", Offset = "0x186F8CC", VA = "0x186F8CC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x186F9E0", Offset = "0x186F9E0", VA = "0x186F9E0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x185C29C", Offset = "0x185C29C", VA = "0x185C29C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x186FAF4", Offset = "0x186FAF4", VA = "0x186FAF4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1861C7C", Offset = "0x1861C7C", VA = "0x1861C7C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x186FBC4", Offset = "0x186FBC4", VA = "0x186FBC4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x186FE48", Offset = "0x186FE48", VA = "0x186FE48")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x187005C", Offset = "0x187005C", VA = "0x187005C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x186B08C", Offset = "0x186B08C", VA = "0x186B08C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0BD8", Offset = "0xAD0BD8")]
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
			[Address(RVA = "0x1870314", Offset = "0x1870314", VA = "0x1870314")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		private bool isAnimated
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x1870618", Offset = "0x1870618", VA = "0x1870618")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x18701DC", Offset = "0x18701DC", VA = "0x18701DC")]
		public void Disable()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1870274", Offset = "0x1870274", VA = "0x1870274", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1870278", Offset = "0x1870278", VA = "0x1870278", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x187027C", Offset = "0x187027C", VA = "0x187027C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1870280", Offset = "0x1870280", VA = "0x1870280")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1870310", Offset = "0x1870310", VA = "0x1870310")]
		private void Start()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x18702B8", Offset = "0x18702B8", VA = "0x18702B8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x18705C8", Offset = "0x18705C8", VA = "0x18705C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1870404", Offset = "0x1870404", VA = "0x1870404")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x18706D4", Offset = "0x18706D4", VA = "0x18706D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1870730", Offset = "0x1870730", VA = "0x1870730")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1870790", Offset = "0x1870790", VA = "0x1870790")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x18602B8", Offset = "0x18602B8", VA = "0x18602B8")]
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
		[Address(RVA = "0x18707D8", Offset = "0x18707D8", VA = "0x18707D8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1870890", Offset = "0x1870890", VA = "0x1870890")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1870948", Offset = "0x1870948", VA = "0x1870948")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1870A00", Offset = "0x1870A00", VA = "0x1870A00")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class V3Tools
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1870A08", Offset = "0x1870A08", VA = "0x1870A08")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1870B00", Offset = "0x1870B00", VA = "0x1870B00")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1870BF8", Offset = "0x1870BF8", VA = "0x1870BF8")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1870CF0", Offset = "0x1870CF0", VA = "0x1870CF0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1870DF0", Offset = "0x1870DF0", VA = "0x1870DF0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x187102C", Offset = "0x187102C", VA = "0x187102C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x187127C", Offset = "0x187127C", VA = "0x187127C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x187148C", Offset = "0x187148C", VA = "0x187148C")]
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
		[Address(RVA = "0x1871668", Offset = "0x1871668", VA = "0x1871668")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x18597BC", Offset = "0x18597BC", VA = "0x18597BC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0C10", Offset = "0xAD0C10")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0C48", Offset = "0xAD0C48")]
		public float cornerRadius;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0C80", Offset = "0xAD0C80")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0CB8", Offset = "0xAD0CB8")]
		public float maxSampleDistance;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0CF0", Offset = "0xAD0CF0")]
		public float nextPathInterval;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0D28", Offset = "0xAD0D28")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0D38", Offset = "0xAD0D38")]
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
			[Address(RVA = "0x17CD9DC", Offset = "0x17CD9DC", VA = "0x17CD9DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD8F24", Offset = "0xAD8F24")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x17CD9E8", Offset = "0x17CD9E8", VA = "0x17CD9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD8F34", Offset = "0xAD8F34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public State state
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x17CD9F4", Offset = "0x17CD9F4", VA = "0x17CD9F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD8F44", Offset = "0xAD8F44")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x17CD9FC", Offset = "0x17CD9FC", VA = "0x17CD9FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD8F54", Offset = "0xAD8F54")]
			private set
			{
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17CDA04", Offset = "0x17CDA04", VA = "0x17CDA04")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x17CDAD8", Offset = "0x17CDAD8", VA = "0x17CDAD8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x17CE02C", Offset = "0x17CE02C", VA = "0x17CE02C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x17CE09C", Offset = "0x17CE09C", VA = "0x17CE09C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x17CDEF4", Offset = "0x17CDEF4", VA = "0x17CDEF4")]
		private void Stop()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x17CDF68", Offset = "0x17CDF68", VA = "0x17CDF68")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x17CE1E4", Offset = "0x17CE1E4", VA = "0x17CE1E4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x17CE3A0", Offset = "0x17CE3A0", VA = "0x17CE3A0")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xACFFE8", Offset = "0xACFFE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xACFFE8", Offset = "0xACFFE8")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x18ECEF4", Offset = "0x18ECEF4", VA = "0x18ECEF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD8F64", Offset = "0xAD8F64")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x18ECF40", Offset = "0x18ECF40", VA = "0x18ECF40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD8F9C", Offset = "0xAD8F9C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x18ECF8C", Offset = "0x18ECF8C", VA = "0x18ECF8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD8FD4", Offset = "0xAD8FD4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x18ECFD8", Offset = "0x18ECFD8", VA = "0x18ECFD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD900C", Offset = "0xAD900C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x18ED024", Offset = "0x18ED024", VA = "0x18ED024")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x18ED0C4", Offset = "0x18ED0C4", VA = "0x18ED0C4")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x18ED0E4", Offset = "0x18ED0E4", VA = "0x18ED0E4")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x18ED114", Offset = "0x18ED114", VA = "0x18ED114")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x18ED144", Offset = "0x18ED144", VA = "0x18ED144")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x18ED184", Offset = "0x18ED184", VA = "0x18ED184")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x18ED1C8", Offset = "0x18ED1C8", VA = "0x18ED1C8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x18ED1EC", Offset = "0x18ED1EC", VA = "0x18ED1EC")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x18ED210", Offset = "0x18ED210", VA = "0x18ED210")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x18ED23C", Offset = "0x18ED23C", VA = "0x18ED23C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x18ED26C", Offset = "0x18ED26C", VA = "0x18ED26C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x18ED29C", Offset = "0x18ED29C", VA = "0x18ED29C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x18ED044", Offset = "0x18ED044", VA = "0x18ED044")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x18ED2C8", Offset = "0x18ED2C8", VA = "0x18ED2C8")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x18ED2D4", Offset = "0x18ED2D4", VA = "0x18ED2D4")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x18ED2E0", Offset = "0x18ED2E0", VA = "0x18ED2E0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x18ED5D4", Offset = "0x18ED5D4", VA = "0x18ED5D4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x18ED684", Offset = "0x18ED684", VA = "0x18ED684", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x18ED9D8", Offset = "0x18ED9D8", VA = "0x18ED9D8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x18EDEDC", Offset = "0x18EDEDC", VA = "0x18EDEDC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x18EDF10", Offset = "0x18EDF10", VA = "0x18EDF10")]
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
			[Address(RVA = "0x18ED48C", Offset = "0x18ED48C", VA = "0x18ED48C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x18EE0DC", Offset = "0x18EE0DC", VA = "0x18EE0DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x18ED85C", Offset = "0x18ED85C", VA = "0x18ED85C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x18EDF94", Offset = "0x18EDF94", VA = "0x18EDF94")]
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
			[Address(RVA = "0x18F14C0", Offset = "0x18F14C0", VA = "0x18F14C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D0")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x18F1530", Offset = "0x18F1530", VA = "0x18F1530")]
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
		[Address(RVA = "0x18F1538", Offset = "0x18F1538", VA = "0x18F1538", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x18F1648", Offset = "0x18F1648", VA = "0x18F1648")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x18F1650", Offset = "0x18F1650", VA = "0x18F1650")]
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
			[Address(RVA = "0x18F1820", Offset = "0x18F1820", VA = "0x18F1820")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x18F167C", Offset = "0x18F167C", VA = "0x18F167C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x18F18DC", Offset = "0x18F18DC", VA = "0x18F18DC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x18F18E4", Offset = "0x18F18E4", VA = "0x18F18E4")]
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
		[Address(RVA = "0x18F1910", Offset = "0x18F1910", VA = "0x18F1910", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x18F1A3C", Offset = "0x18F1A3C", VA = "0x18F1A3C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x18F1A44", Offset = "0x18F1A44", VA = "0x18F1A44")]
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
			[Address(RVA = "0x18F1C18", Offset = "0x18F1C18", VA = "0x18F1C18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x18F1A70", Offset = "0x18F1A70", VA = "0x18F1A70", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x18F1CE8", Offset = "0x18F1CE8", VA = "0x18F1CE8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x18F1CF0", Offset = "0x18F1CF0", VA = "0x18F1CF0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD0D48", Offset = "0xAD0D48")]
		public float positionWeight;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD0D60", Offset = "0xAD0D60")]
		public float rotationWeight;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x18F1D1C", Offset = "0x18F1D1C", VA = "0x18F1D1C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x18ED980", Offset = "0x18ED980", VA = "0x18ED980")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x18EDB74", Offset = "0x18EDB74", VA = "0x18EDB74")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x18EE2A8", Offset = "0x18EE2A8", VA = "0x18EE2A8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0D78", Offset = "0xAD0D78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD0D78", Offset = "0xAD0D78")]
		public float weight;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0DCC", Offset = "0xAD0DCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD0DCC", Offset = "0xAD0DCC")]
		public float rotationWeight;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0E20", Offset = "0xAD0E20")]
		public DOF rotationDOF;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0E58", Offset = "0xAD0E58")]
		public Transform bone1;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0E90", Offset = "0xAD0E90")]
		public Transform bone2;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0EC8", Offset = "0xAD0EC8")]
		public Transform bone3;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0F00", Offset = "0xAD0F00")]
		public Transform tip;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0F38", Offset = "0xAD0F38")]
		public Transform target;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0F70", Offset = "0xAD0F70")]
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
			[Address(RVA = "0x18F902C", Offset = "0x18F902C", VA = "0x18F902C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9044", Offset = "0xAD9044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x18F9034", Offset = "0x18F9034", VA = "0x18F9034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9054", Offset = "0xAD9054")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x18F9040", Offset = "0x18F9040", VA = "0x18F9040")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x18F9064", Offset = "0x18F9064", VA = "0x18F9064")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x18F9088", Offset = "0x18F9088", VA = "0x18F9088")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x18F90AC", Offset = "0x18F90AC", VA = "0x18F90AC")]
			set
			{
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x18F90D0", Offset = "0x18F90D0", VA = "0x18F90D0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x18F91D0", Offset = "0x18F91D0", VA = "0x18F91D0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x18F95F0", Offset = "0x18F95F0", VA = "0x18F95F0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x18F96CC", Offset = "0x18F96CC", VA = "0x18F96CC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x18F9794", Offset = "0x18F9794", VA = "0x18F9794")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x18F9B88", Offset = "0x18F9B88", VA = "0x18F9B88")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0F80", Offset = "0xAD0F80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD0F80", Offset = "0xAD0F80")]
		public float weight;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0FD4", Offset = "0xAD0FD4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000012")]
		public bool initiated
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x18F9B98", Offset = "0x18F9B98", VA = "0x18F9B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9064", Offset = "0xAD9064")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x18F9BA0", Offset = "0x18F9BA0", VA = "0x18F9BA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9074", Offset = "0xAD9074")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x18F9BAC", Offset = "0x18F9BAC", VA = "0x18F9BAC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x18F9C40", Offset = "0x18F9C40", VA = "0x18F9C40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9084", Offset = "0xAD9084")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x18F9F70", Offset = "0x18F9F70", VA = "0x18F9F70")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x18FA0E4", Offset = "0x18FA0E4", VA = "0x18FA0E4")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x18F9E64", Offset = "0x18F9E64", VA = "0x18F9E64")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x18FA268", Offset = "0x18FA268", VA = "0x18FA268", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x18FA330", Offset = "0x18FA330", VA = "0x18FA330")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x18FA3B4", Offset = "0x18FA3B4", VA = "0x18FA3B4")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x18FA434", Offset = "0x18FA434", VA = "0x18FA434")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x18FA4A8", Offset = "0x18FA4A8", VA = "0x18FA4A8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x18FA4AC", Offset = "0x18FA4AC", VA = "0x18FA4AC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x18FA4C0", Offset = "0x18FA4C0", VA = "0x18FA4C0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD0FE4", Offset = "0xAD0FE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD0FE4", Offset = "0xAD0FE4")]
		public float weight;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1038", Offset = "0xAD1038")]
		public Grounding solver;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD1070", Offset = "0xAD1070")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000013")]
		public bool initiated
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x18FB538", Offset = "0x18FB538", VA = "0x18FB538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD90BC", Offset = "0xAD90BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x18FB540", Offset = "0x18FB540", VA = "0x18FB540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD90CC", Offset = "0xAD90CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000FE")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x18FB54C", Offset = "0x18FB54C", VA = "0x18FB54C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x18FB828", Offset = "0x18FB828", VA = "0x18FB828")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x18FB694", Offset = "0x18FB694", VA = "0x18FB694")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x18FB85C", Offset = "0x18FB85C", VA = "0x18FB85C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000106")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x18FBA68", Offset = "0x18FBA68", VA = "0x18FBA68")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0048", Offset = "0xAD0048")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0048", Offset = "0xAD0048")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1080", Offset = "0xAD1080")]
		public BipedIK ik;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD10B8", Offset = "0xAD10B8")]
		public float spineBend;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD10F0", Offset = "0xAD10F0")]
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
		[Address(RVA = "0x18FBDF0", Offset = "0x18FBDF0", VA = "0x18FBDF0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD90DC", Offset = "0xAD90DC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x18FBE3C", Offset = "0x18FBE3C", VA = "0x18FBE3C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9114", Offset = "0xAD9114")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x18FBE88", Offset = "0x18FBE88", VA = "0x18FBE88", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x18FBF98", Offset = "0x18FBF98", VA = "0x18FBF98")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x18FC04C", Offset = "0x18FC04C", VA = "0x18FC04C")]
		private void Update()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x18FC100", Offset = "0x18FC100", VA = "0x18FC100")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x18FC640", Offset = "0x18FC640", VA = "0x18FC640")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x18FC698", Offset = "0x18FC698", VA = "0x18FC698")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x18FCE64", Offset = "0x18FCE64", VA = "0x18FCE64")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x18FCFD0", Offset = "0x18FCFD0", VA = "0x18FCFD0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x18FD160", Offset = "0x18FD160", VA = "0x18FD160")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x18FD2D8", Offset = "0x18FD2D8", VA = "0x18FD2D8")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD00A8", Offset = "0xAD00A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD00A8", Offset = "0xAD00A8")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200008C")]
		public class SpineEffector
		{
			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5B10", Offset = "0xAD5B10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5B48", Offset = "0xAD5B48")]
			public float horizontalWeight;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5B80", Offset = "0xAD5B80")]
			public float verticalWeight;

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x18FE168", Offset = "0x18FE168", VA = "0x18FE168")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x18FE178", Offset = "0x18FE178", VA = "0x18FE178")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1128", Offset = "0xAD1128")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1160", Offset = "0xAD1160")]
		public float spineBend;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1198", Offset = "0xAD1198")]
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
		[Address(RVA = "0x18FD358", Offset = "0x18FD358", VA = "0x18FD358")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD914C", Offset = "0xAD914C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x18FD3A4", Offset = "0x18FD3A4", VA = "0x18FD3A4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9184", Offset = "0xAD9184")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x18FD3F0", Offset = "0x18FD3F0", VA = "0x18FD3F0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD91BC", Offset = "0xAD91BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x18FD43C", Offset = "0x18FD43C", VA = "0x18FD43C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x18FD4BC", Offset = "0x18FD4BC", VA = "0x18FD4BC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x18FD558", Offset = "0x18FD558", VA = "0x18FD558")]
		private void Update()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x18FD818", Offset = "0x18FD818", VA = "0x18FD818")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x18FD824", Offset = "0x18FD824", VA = "0x18FD824")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x18FD614", Offset = "0x18FD614", VA = "0x18FD614")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x18FD830", Offset = "0x18FD830", VA = "0x18FD830")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x18FDCE8", Offset = "0x18FDCE8", VA = "0x18FDCE8")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x18FDEAC", Offset = "0x18FDEAC", VA = "0x18FDEAC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x18FDFE4", Offset = "0x18FDFE4", VA = "0x18FDFE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x18FE0E8", Offset = "0x18FE0E8", VA = "0x18FE0E8")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0108", Offset = "0xAD0108")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0108", Offset = "0xAD0108")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD11D0", Offset = "0xAD11D0")]
		public Transform pelvis;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1208", Offset = "0xAD1208")]
		public Transform characterRoot;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1240", Offset = "0xAD1240")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1240", Offset = "0xAD1240")]
		public float rootRotationWeight;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1294", Offset = "0xAD1294")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD12CC", Offset = "0xAD12CC")]
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
		[Address(RVA = "0x18FE1C0", Offset = "0x18FE1C0", VA = "0x18FE1C0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD91F4", Offset = "0xAD91F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x18FE20C", Offset = "0x18FE20C", VA = "0x18FE20C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD922C", Offset = "0xAD922C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x18FE258", Offset = "0x18FE258", VA = "0x18FE258", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x18FE270", Offset = "0x18FE270", VA = "0x18FE270")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x18FE460", Offset = "0x18FE460", VA = "0x18FE460")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x18FE570", Offset = "0x18FE570", VA = "0x18FE570")]
		private void Update()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x18FECC8", Offset = "0x18FECC8", VA = "0x18FECC8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x18FF0D8", Offset = "0x18FF0D8", VA = "0x18FF0D8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x18FF350", Offset = "0x18FF350", VA = "0x18FF350")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x18FF67C", Offset = "0x18FF67C", VA = "0x18FF67C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x18FF814", Offset = "0x18FF814", VA = "0x18FF814")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x18FF9E0", Offset = "0x18FF9E0", VA = "0x18FF9E0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0168", Offset = "0xAD0168")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0168", Offset = "0xAD0168")]
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
			[Address(RVA = "0xBBD938", Offset = "0xBBD938", VA = "0xBBD938")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1304", Offset = "0xAD1304")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD133C", Offset = "0xAD133C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD133C", Offset = "0xAD133C")]
		public float rootRotationWeight;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1390", Offset = "0xAD1390")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1390", Offset = "0xAD1390")]
		public float minRootRotation;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD13E8", Offset = "0xAD13E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD13E8", Offset = "0xAD13E8")]
		public float maxRootRotation;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1440", Offset = "0xAD1440")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1478", Offset = "0xAD1478")]
		public float maxLegOffset;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD14B0", Offset = "0xAD14B0")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD14E8", Offset = "0xAD14E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD14E8", Offset = "0xAD14E8")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD153C", Offset = "0xAD153C")]
		public Transform characterRoot;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1574", Offset = "0xAD1574")]
		public Transform pelvis;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD15AC", Offset = "0xAD15AC")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD15E4", Offset = "0xAD15E4")]
		public Transform head;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD161C", Offset = "0xAD161C")]
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
		[Address(RVA = "0x18FFA60", Offset = "0x18FFA60", VA = "0x18FFA60", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9264", Offset = "0xAD9264")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x18FFAAC", Offset = "0x18FFAAC", VA = "0x18FFAAC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD929C", Offset = "0xAD929C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x18FFAF8", Offset = "0x18FFAF8", VA = "0x18FFAF8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x18FFB2C", Offset = "0x18FFB2C", VA = "0x18FFB2C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x18FFC60", Offset = "0x18FFC60", VA = "0x18FFC60")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x18FFE1C", Offset = "0x18FFE1C", VA = "0x18FFE1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x18FFE94", Offset = "0x18FFE94", VA = "0x18FFE94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x18FFF4C", Offset = "0x18FFF4C", VA = "0x18FFF4C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x190025C", Offset = "0x190025C", VA = "0x190025C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x19005A4", Offset = "0x19005A4", VA = "0x19005A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x19006F0", Offset = "0x19006F0", VA = "0x19006F0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1900BA0", Offset = "0x1900BA0", VA = "0x1900BA0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x19013A4", Offset = "0x19013A4", VA = "0x19013A4")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1901668", Offset = "0x1901668", VA = "0x1901668")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x19017CC", Offset = "0x19017CC", VA = "0x19017CC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1901AB4", Offset = "0x1901AB4", VA = "0x1901AB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1901AF8", Offset = "0x1901AF8", VA = "0x1901AF8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1901CBC", Offset = "0x1901CBC", VA = "0x1901CBC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD01C8", Offset = "0xAD01C8")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD162C", Offset = "0xAD162C")]
		public VRIK ik;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1901DD8", Offset = "0x1901DD8", VA = "0x1901DD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD92D4", Offset = "0xAD92D4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1901DDC", Offset = "0x1901DDC", VA = "0x1901DDC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD930C", Offset = "0xAD930C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1901DE0", Offset = "0x1901DE0", VA = "0x1901DE0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9344", Offset = "0xAD9344")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1901DE4", Offset = "0x1901DE4", VA = "0x1901DE4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1901DFC", Offset = "0x1901DFC", VA = "0x1901DFC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1901E98", Offset = "0x1901E98", VA = "0x1901E98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1901F4C", Offset = "0x1901F4C", VA = "0x1901F4C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1902158", Offset = "0x1902158", VA = "0x1902158")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x19023F8", Offset = "0x19023F8", VA = "0x19023F8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1902504", Offset = "0x1902504", VA = "0x1902504")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1902710", Offset = "0x1902710", VA = "0x1902710")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1902848", Offset = "0x1902848", VA = "0x1902848")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x19029B0", Offset = "0x19029B0", VA = "0x19029B0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5BB8", Offset = "0xAD5BB8")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5BC8", Offset = "0xAD5BC8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5BD8", Offset = "0xAD5BD8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5BE8", Offset = "0xAD5BE8")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5BF8", Offset = "0xAD5BF8")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5C08", Offset = "0xAD5C08")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5C18", Offset = "0xAD5C18")]
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
				[Address(RVA = "0x19041F0", Offset = "0x19041F0", VA = "0x19041F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAEC4", Offset = "0xADAEC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x19041F8", Offset = "0x19041F8", VA = "0x19041F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAED4", Offset = "0xADAED4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x1904204", Offset = "0x1904204", VA = "0x1904204")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAEE4", Offset = "0xADAEE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x1904210", Offset = "0x1904210", VA = "0x1904210")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAEF4", Offset = "0xADAEF4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AE")]
			public bool initiated
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x190421C", Offset = "0x190421C", VA = "0x190421C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF04", Offset = "0xADAF04")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0x1904224", Offset = "0x1904224", VA = "0x1904224")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF14", Offset = "0xADAF14")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public float heightFromGround
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x1904230", Offset = "0x1904230", VA = "0x1904230")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF24", Offset = "0xADAF24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005B6")]
				[Address(RVA = "0x1904238", Offset = "0x1904238", VA = "0x1904238")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF34", Offset = "0xADAF34")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0x1904240", Offset = "0x1904240", VA = "0x1904240")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF44", Offset = "0xADAF44")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x190424C", Offset = "0x190424C", VA = "0x190424C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF54", Offset = "0xADAF54")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			public Transform transform
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x1904258", Offset = "0x1904258", VA = "0x1904258")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF64", Offset = "0xADAF64")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x1904260", Offset = "0x1904260", VA = "0x1904260")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF74", Offset = "0xADAF74")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public float IKOffset
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x1904268", Offset = "0x1904268", VA = "0x1904268")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF84", Offset = "0xADAF84")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x1904270", Offset = "0x1904270", VA = "0x1904270")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAF94", Offset = "0xADAF94")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x1904DE8", Offset = "0x1904DE8", VA = "0x1904DE8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B4")]
			private float rootYOffset
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x19050F0", Offset = "0x19050F0", VA = "0x19050F0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1903058", Offset = "0x1903058", VA = "0x1903058")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x1904278", Offset = "0x1904278", VA = "0x1904278")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x1903D10", Offset = "0x1903D10", VA = "0x1903D10")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x1903168", Offset = "0x1903168", VA = "0x1903168")]
			public void Process()
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1904968", Offset = "0x1904968", VA = "0x1904968")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x19042C4", Offset = "0x19042C4", VA = "0x19042C4")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x1904F70", Offset = "0x1904F70", VA = "0x1904F70")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x19045F0", Offset = "0x19045F0", VA = "0x19045F0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x19046F8", Offset = "0x19046F8", VA = "0x19046F8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x1905070", Offset = "0x1905070", VA = "0x1905070")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1904E78", Offset = "0x1904E78", VA = "0x1904E78")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x190522C", Offset = "0x190522C", VA = "0x190522C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1902FA8", Offset = "0x1902FA8", VA = "0x1902FA8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000090")]
		public class Pelvis
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5C28", Offset = "0xAD5C28")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5C38", Offset = "0xAD5C38")]
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
				[Address(RVA = "0x1905328", Offset = "0x1905328", VA = "0x1905328")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAFA4", Offset = "0xADAFA4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x1905334", Offset = "0x1905334", VA = "0x1905334")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAFB4", Offset = "0xADAFB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public float heightOffset
			{
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x1905340", Offset = "0x1905340", VA = "0x1905340")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAFC4", Offset = "0xADAFC4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005CF")]
				[Address(RVA = "0x1905348", Offset = "0x1905348", VA = "0x1905348")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAFD4", Offset = "0xADAFD4")]
				private set
				{
				}
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1903140", Offset = "0x1903140", VA = "0x1903140")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1903C5C", Offset = "0x1903C5C", VA = "0x1903C5C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1905350", Offset = "0x1905350", VA = "0x1905350")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x19039E8", Offset = "0x19039E8", VA = "0x19039E8")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1903050", Offset = "0x1903050", VA = "0x1903050")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1664", Offset = "0xAD1664")]
		public LayerMask layers;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD169C", Offset = "0xAD169C")]
		public float maxStep;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD16D4", Offset = "0xAD16D4")]
		public float heightOffset;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD170C", Offset = "0xAD170C")]
		public float footSpeed;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1744", Offset = "0xAD1744")]
		public float footRadius;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD177C", Offset = "0xAD177C")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD177C", Offset = "0xAD177C")]
		public float footCenterOffset;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD17C8", Offset = "0xAD17C8")]
		public float prediction;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1800", Offset = "0xAD1800")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1800", Offset = "0xAD1800")]
		public float footRotationWeight;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1854", Offset = "0xAD1854")]
		public float footRotationSpeed;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD188C", Offset = "0xAD188C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD188C", Offset = "0xAD188C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD18E4", Offset = "0xAD18E4")]
		public bool rotateSolver;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD191C", Offset = "0xAD191C")]
		public float pelvisSpeed;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1954", Offset = "0xAD1954")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1954", Offset = "0xAD1954")]
		public float pelvisDamper;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD19A8", Offset = "0xAD19A8")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD19E0", Offset = "0xAD19E0")]
		public float liftPelvisWeight;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1A18", Offset = "0xAD1A18")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1A50", Offset = "0xAD1A50")]
		public bool overstepFallsDown;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1A88", Offset = "0xAD1A88")]
		public Quality quality;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD1AC0", Offset = "0xAD1AC0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD1AD0", Offset = "0xAD1AD0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD1AE0", Offset = "0xAD1AE0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD1AF0", Offset = "0xAD1AF0")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD1B00", Offset = "0xAD1B00")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		public Leg[] legs
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1902A0C", Offset = "0x1902A0C", VA = "0x1902A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD937C", Offset = "0xAD937C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1902A14", Offset = "0x1902A14", VA = "0x1902A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD938C", Offset = "0xAD938C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1902A1C", Offset = "0x1902A1C", VA = "0x1902A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD939C", Offset = "0xAD939C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1902A24", Offset = "0x1902A24", VA = "0x1902A24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD93AC", Offset = "0xAD93AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool isGrounded
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1902A2C", Offset = "0x1902A2C", VA = "0x1902A2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD93BC", Offset = "0xAD93BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1902A34", Offset = "0x1902A34", VA = "0x1902A34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD93CC", Offset = "0xAD93CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Transform root
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1902A40", Offset = "0x1902A40", VA = "0x1902A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD93DC", Offset = "0xAD93DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1902A48", Offset = "0x1902A48", VA = "0x1902A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD93EC", Offset = "0xAD93EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1902A50", Offset = "0x1902A50", VA = "0x1902A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD93FC", Offset = "0xAD93FC")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1902A6C", Offset = "0x1902A6C", VA = "0x1902A6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD940C", Offset = "0xAD940C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1902A8C", Offset = "0x1902A8C", VA = "0x1902A8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 up
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x18FCF44", Offset = "0x18FCF44", VA = "0x18FCF44")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001B")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1903DC4", Offset = "0x1903DC4", VA = "0x1903DC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1902AE4", Offset = "0x1902AE4", VA = "0x1902AE4")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1902ECC", Offset = "0x1902ECC", VA = "0x1902ECC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x18FC3C0", Offset = "0x18FC3C0", VA = "0x18FC3C0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x18FCBF0", Offset = "0x18FCBF0", VA = "0x18FCBF0")]
		public void Update()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x18FEAAC", Offset = "0x18FEAAC", VA = "0x18FEAAC")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x18FBF08", Offset = "0x18FBF08", VA = "0x18FBF08")]
		public void Reset()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1903150", Offset = "0x1903150", VA = "0x1903150")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1903E94", Offset = "0x1903E94", VA = "0x1903E94")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1903FFC", Offset = "0x1903FFC", VA = "0x1903FFC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1904100", Offset = "0x1904100", VA = "0x1904100")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x18FBB2C", Offset = "0x18FBB2C", VA = "0x18FBB2C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0200", Offset = "0xAD0200")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0200", Offset = "0xAD0200")]
	public class AimIK : IK
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x17CF598", Offset = "0x17CF598", VA = "0x17CF598", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD941C", Offset = "0xAD941C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x17CF5E4", Offset = "0x17CF5E4", VA = "0x17CF5E4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9454", Offset = "0xAD9454")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x17CF630", Offset = "0x17CF630", VA = "0x17CF630")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD948C", Offset = "0xAD948C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x17CF67C", Offset = "0x17CF67C", VA = "0x17CF67C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD94C4", Offset = "0xAD94C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x17CF6C8", Offset = "0x17CF6C8", VA = "0x17CF6C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD94FC", Offset = "0xAD94FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x17CF714", Offset = "0x17CF714", VA = "0x17CF714", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x17CF71C", Offset = "0x17CF71C", VA = "0x17CF71C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0260", Offset = "0xAD0260")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x18ECD14", Offset = "0x18ECD14", VA = "0x18ECD14", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9534", Offset = "0xAD9534")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x18ECD80", Offset = "0x18ECD80", VA = "0x18ECD80", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD956C", Offset = "0xAD956C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x18ECDEC", Offset = "0x18ECDEC", VA = "0x18ECDEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD95A4", Offset = "0xAD95A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x18ECE38", Offset = "0x18ECE38", VA = "0x18ECE38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD95DC", Offset = "0xAD95DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x18ECE84", Offset = "0x18ECE84", VA = "0x18ECE84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x18ECE8C", Offset = "0x18ECE8C", VA = "0x18ECE8C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0298", Offset = "0xAD0298")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0298", Offset = "0xAD0298")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x18EE548", Offset = "0x18EE548", VA = "0x18EE548", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9614", Offset = "0xAD9614")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x18EE594", Offset = "0x18EE594", VA = "0x18EE594", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD964C", Offset = "0xAD964C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x18EE5E0", Offset = "0x18EE5E0", VA = "0x18EE5E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9684", Offset = "0xAD9684")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x18EE62C", Offset = "0x18EE62C", VA = "0x18EE62C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD96BC", Offset = "0xAD96BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x18EE678", Offset = "0x18EE678", VA = "0x18EE678", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x18EE680", Offset = "0x18EE680", VA = "0x18EE680")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD02F8", Offset = "0xAD02F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD02F8", Offset = "0xAD02F8")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x18F1D8C", Offset = "0x18F1D8C", VA = "0x18F1D8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD96F4", Offset = "0xAD96F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x18F1DD8", Offset = "0x18F1DD8", VA = "0x18F1DD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD972C", Offset = "0xAD972C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x18F1E24", Offset = "0x18F1E24", VA = "0x18F1E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9764", Offset = "0xAD9764")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x18F1E70", Offset = "0x18F1E70", VA = "0x18F1E70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD979C", Offset = "0xAD979C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x18F1EBC", Offset = "0x18F1EBC", VA = "0x18F1EBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x18F1EC4", Offset = "0x18F1EC4", VA = "0x18F1EC4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0358", Offset = "0xAD0358")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0358", Offset = "0xAD0358")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x18F2558", Offset = "0x18F2558", VA = "0x18F2558", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD97D4", Offset = "0xAD97D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x18F25A4", Offset = "0x18F25A4", VA = "0x18F25A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD980C", Offset = "0xAD980C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x18F25F0", Offset = "0x18F25F0", VA = "0x18F25F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9844", Offset = "0xAD9844")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x18F263C", Offset = "0x18F263C", VA = "0x18F263C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD987C", Offset = "0xAD987C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x18F2688", Offset = "0x18F2688", VA = "0x18F2688", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x18F2690", Offset = "0x18F2690", VA = "0x18F2690")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD03B8", Offset = "0xAD03B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD03B8", Offset = "0xAD03B8")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x18FA528", Offset = "0x18FA528", VA = "0x18FA528", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD98B4", Offset = "0xAD98B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x18FA574", Offset = "0x18FA574", VA = "0x18FA574", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD98EC", Offset = "0xAD98EC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x18FA5C0", Offset = "0x18FA5C0", VA = "0x18FA5C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9924", Offset = "0xAD9924")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x18FA60C", Offset = "0x18FA60C", VA = "0x18FA60C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD995C", Offset = "0xAD995C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x18FA658", Offset = "0x18FA658", VA = "0x18FA658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9994", Offset = "0xAD9994")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x18FA6A4", Offset = "0x18FA6A4", VA = "0x18FA6A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD99CC", Offset = "0xAD99CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x18FA6F0", Offset = "0x18FA6F0", VA = "0x18FA6F0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x18FA714", Offset = "0x18FA714", VA = "0x18FA714", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x18FA71C", Offset = "0x18FA71C", VA = "0x18FA71C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x18FA8E0", Offset = "0x18FA8E0", VA = "0x18FA8E0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x18FAC38", Offset = "0x18FAC38", VA = "0x18FAC38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9A04", Offset = "0xAD9A04")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x18FAC5C", Offset = "0x18FAC5C", VA = "0x18FAC5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9A3C", Offset = "0xAD9A3C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x18FAD3C", Offset = "0x18FAD3C", VA = "0x18FAD3C")]
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
		[Address(RVA = "0x1C45B24", Offset = "0x1C45B24", VA = "0x1C45B24", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1C45C10", Offset = "0x1C45C10", VA = "0x1C45C10", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1C45DD4", Offset = "0x1C45DD4", VA = "0x1C45DD4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000195")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000196")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1C45E34", Offset = "0x1C45E34", VA = "0x1C45E34")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1B10", Offset = "0xAD1B10")]
		public IK[] IKComponents;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1B48", Offset = "0xAD1B48")]
		public Animator animator;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700001C")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1C48E74", Offset = "0x1C48E74", VA = "0x1C48E74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1C48F10", Offset = "0x1C48F10", VA = "0x1C48F10")]
		private void Start()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1C48F88", Offset = "0x1C48F88", VA = "0x1C48F88")]
		private void Update()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1C49058", Offset = "0x1C49058", VA = "0x1C49058")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1C49094", Offset = "0x1C49094", VA = "0x1C49094")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1C48FBC", Offset = "0x1C48FBC", VA = "0x1C48FBC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1C49128", Offset = "0x1C49128", VA = "0x1C49128")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0418", Offset = "0xAD0418")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x185D4C0", Offset = "0x185D4C0", VA = "0x185D4C0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9A74", Offset = "0xAD9A74")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x185D52C", Offset = "0x185D52C", VA = "0x185D52C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9AAC", Offset = "0xAD9AAC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x185D598", Offset = "0x185D598", VA = "0x185D598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9AE4", Offset = "0xAD9AE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x185D5E4", Offset = "0x185D5E4", VA = "0x185D5E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9B1C", Offset = "0xAD9B1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x185D630", Offset = "0x185D630", VA = "0x185D630", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x185D638", Offset = "0x185D638", VA = "0x185D638")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0450", Offset = "0xAD0450")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0450", Offset = "0xAD0450")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x185D6A0", Offset = "0x185D6A0", VA = "0x185D6A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9B54", Offset = "0xAD9B54")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x185D6EC", Offset = "0x185D6EC", VA = "0x185D6EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9B8C", Offset = "0xAD9B8C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x185D738", Offset = "0x185D738", VA = "0x185D738")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9BC4", Offset = "0xAD9BC4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x185D784", Offset = "0x185D784", VA = "0x185D784")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9BFC", Offset = "0xAD9BFC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x185D7D0", Offset = "0x185D7D0", VA = "0x185D7D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x185D7D8", Offset = "0x185D7D8", VA = "0x185D7D8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD04B0", Offset = "0xAD04B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD04B0", Offset = "0xAD04B0")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x185E684", Offset = "0x185E684", VA = "0x185E684", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9C34", Offset = "0xAD9C34")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x185E6D0", Offset = "0x185E6D0", VA = "0x185E6D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9C6C", Offset = "0xAD9C6C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x185E71C", Offset = "0x185E71C", VA = "0x185E71C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9CA4", Offset = "0xAD9CA4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x185E768", Offset = "0x185E768", VA = "0x185E768")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9CDC", Offset = "0xAD9CDC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x185E7B4", Offset = "0x185E7B4", VA = "0x185E7B4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x185E7BC", Offset = "0x185E7BC", VA = "0x185E7BC")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0510", Offset = "0xAD0510")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0510", Offset = "0xAD0510")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1867AFC", Offset = "0x1867AFC", VA = "0x1867AFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9D14", Offset = "0xAD9D14")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1867B48", Offset = "0x1867B48", VA = "0x1867B48", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9D4C", Offset = "0xAD9D4C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1867B94", Offset = "0x1867B94", VA = "0x1867B94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9D84", Offset = "0xAD9D84")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1867BE0", Offset = "0x1867BE0", VA = "0x1867BE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9DBC", Offset = "0xAD9DBC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1867C2C", Offset = "0x1867C2C", VA = "0x1867C2C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1867C34", Offset = "0x1867C34", VA = "0x1867C34")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0570", Offset = "0xAD0570")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5C48", Offset = "0xAD5C48")]
			public Transform chest;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5C80", Offset = "0xAD5C80")]
			public Transform neck;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5CB8", Offset = "0xAD5CB8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5CF0", Offset = "0xAD5CF0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5D28", Offset = "0xAD5D28")]
			public Transform leftThigh;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5D60", Offset = "0xAD5D60")]
			public Transform leftCalf;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5D98", Offset = "0xAD5D98")]
			public Transform leftFoot;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5DD0", Offset = "0xAD5DD0")]
			public Transform leftToes;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5E08", Offset = "0xAD5E08")]
			public Transform rightThigh;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5E40", Offset = "0xAD5E40")]
			public Transform rightCalf;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5E78", Offset = "0xAD5E78")]
			public Transform rightFoot;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5EB0", Offset = "0xAD5EB0")]
			public Transform rightToes;

			[Token(Token = "0x170000B7")]
			public bool isFilled
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x1869188", Offset = "0x1869188", VA = "0x1869188")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B8")]
			public bool isEmpty
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x1868D0C", Offset = "0x1868D0C", VA = "0x1868D0C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1869818", Offset = "0x1869818", VA = "0x1869818")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x18688F4", Offset = "0x18688F4", VA = "0x18688F4")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x1869810", Offset = "0x1869810", VA = "0x1869810")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xAD1B80", Offset = "0xAD1B80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1B80", Offset = "0xAD1B80")]
		public References references;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1BFC", Offset = "0xAD1BFC")]
		public IKSolverVR solver;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x18687A8", Offset = "0x18687A8", VA = "0x18687A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9DF4", Offset = "0xAD9DF4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1868814", Offset = "0x1868814", VA = "0x1868814", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9E2C", Offset = "0xAD9E2C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1868880", Offset = "0x1868880", VA = "0x1868880")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9E64", Offset = "0xAD9E64")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x18688CC", Offset = "0x18688CC", VA = "0x18688CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9E9C", Offset = "0xAD9E9C")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1868C68", Offset = "0x1868C68", VA = "0x1868C68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xAD9ED4", Offset = "0xAD9ED4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1868C90", Offset = "0x1868C90", VA = "0x1868C90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1868C98", Offset = "0x1868C98", VA = "0x1868C98", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x186960C", Offset = "0x186960C", VA = "0x186960C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1869788", Offset = "0x1869788", VA = "0x1869788")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAD05A8", Offset = "0xAD05A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD05A8", Offset = "0xAD05A8")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1C34", Offset = "0xAD1C34")]
		public Transform target;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1C6C", Offset = "0xAD1C6C")]
		public Transform poleTarget;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1CA4", Offset = "0xAD1CA4")]
		public Transform aimTransform;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAD1CDC", Offset = "0xAD1CDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1CDC", Offset = "0xAD1CDC")]
		public float axisX;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1D2C", Offset = "0xAD1D2C")]
		public float axisY;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1D64", Offset = "0xAD1D64")]
		public float axisZ;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAD1D9C", Offset = "0xAD1D9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1D9C", Offset = "0xAD1D9C")]
		public float poleAxisX;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1DEC", Offset = "0xAD1DEC")]
		public float poleAxisY;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1E24", Offset = "0xAD1E24")]
		public float poleAxisZ;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAD1E5C", Offset = "0xAD1E5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1E5C", Offset = "0xAD1E5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1E5C", Offset = "0xAD1E5C")]
		public float weight;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1EC4", Offset = "0xAD1EC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1EC4", Offset = "0xAD1EC4")]
		public float poleWeight;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1F18", Offset = "0xAD1F18")]
		public float tolerance;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1F50", Offset = "0xAD1F50")]
		public int maxIterations;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1F88", Offset = "0xAD1F88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1F88", Offset = "0xAD1F88")]
		public float clampWeight;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD1FDC", Offset = "0xAD1FDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD1FDC", Offset = "0xAD1FDC")]
		public int clampSmoothing;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2030", Offset = "0xAD2030")]
		public bool useRotationLimits;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2068", Offset = "0xAD2068")]
		public bool XY;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAD20A0", Offset = "0xAD20A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD20A0", Offset = "0xAD20A0")]
		public Transform[] bones;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD20F0", Offset = "0xAD20F0")]
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
			[Address(RVA = "0x17CF784", Offset = "0x17CF784", VA = "0x17CF784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F0C", Offset = "0xAD9F0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x17CF78C", Offset = "0x17CF78C", VA = "0x17CF78C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F1C", Offset = "0xAD9F1C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 axis
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x17CF798", Offset = "0x17CF798", VA = "0x17CF798")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x17CF7D4", Offset = "0x17CF7D4", VA = "0x17CF7D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x17CF7E0", Offset = "0x17CF7E0", VA = "0x17CF7E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x17CF81C", Offset = "0x17CF81C", VA = "0x17CF81C")]
			set
			{
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x17CF828", Offset = "0x17CF828", VA = "0x17CF828")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x17D0650", Offset = "0x17D0650", VA = "0x17D0650")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x17D0A3C", Offset = "0x17D0A3C", VA = "0x17D0A3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x17D0B3C", Offset = "0x17D0B3C", VA = "0x17D0B3C")]
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
		[Address(RVA = "0xBB9BB4", Offset = "0xBB9BB4", VA = "0xBB9BB4")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xBB9BBC", Offset = "0xBB9BBC", VA = "0xBB9BBC")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xBB9BC4", Offset = "0xBB9BC4", VA = "0xBB9BC4")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xBB9BCC", Offset = "0xBB9BCC", VA = "0xBB9BCC", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xBB9BD0", Offset = "0xBB9BD0", VA = "0xBB9BD0", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xBB9C14", Offset = "0xBB9C14", VA = "0xBB9C14")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xBB9C58", Offset = "0xBB9C58", VA = "0xBB9C58")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xBB9CC4", Offset = "0xBB9CC4", VA = "0xBB9CC4")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xBB9D08", Offset = "0xBB9D08", VA = "0xBB9D08")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xBB9D1C", Offset = "0xBB9D1C", VA = "0xBB9D1C")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xBB9D60", Offset = "0xBB9D60", VA = "0xBB9D60")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xBB9D68", Offset = "0xBB9D68", VA = "0xBB9D68")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAD0630", Offset = "0xAD0630")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0630", Offset = "0xAD0630")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2100", Offset = "0xAD2100")]
		public Transform target;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2138", Offset = "0xAD2138")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2138", Offset = "0xAD2138")]
		public float weight;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD218C", Offset = "0xAD218C")]
		public float tolerance;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD21C4", Offset = "0xAD21C4")]
		public int maxIterations;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD21FC", Offset = "0xAD21FC")]
		public bool useRotationLimits;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2234", Offset = "0xAD2234")]
		public bool XY;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD226C", Offset = "0xAD226C")]
		public Transform[] bones;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD22A4", Offset = "0xAD22A4")]
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
			[Address(RVA = "0x18EE6E8", Offset = "0x18EE6E8", VA = "0x18EE6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F2C", Offset = "0xAD9F2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x18EE6F0", Offset = "0x18EE6F0", VA = "0x18EE6F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F3C", Offset = "0xAD9F3C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x18EE6FC", Offset = "0x18EE6FC", VA = "0x18EE6FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x18EEEE0", Offset = "0x18EEEE0", VA = "0x18EEEE0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x18EF07C", Offset = "0x18EF07C", VA = "0x18EF07C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x18EF190", Offset = "0x18EF190", VA = "0x18EF190")]
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
		[Address(RVA = "0xBBD6D0", Offset = "0xBBD6D0", VA = "0xBBD6D0")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xBBD6D8", Offset = "0xBBD6D8", VA = "0xBBD6D8")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xBBD6E0", Offset = "0xBBD6E0", VA = "0xBBD6E0")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xBBD6E8", Offset = "0xBBD6E8", VA = "0xBBD6E8", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xBBD6EC", Offset = "0xBBD6EC", VA = "0xBBD6EC", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xBBD730", Offset = "0xBBD730", VA = "0xBBD730")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xBBD774", Offset = "0xBBD774", VA = "0xBBD774")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xBBD7B8", Offset = "0xBBD7B8", VA = "0xBBD7B8")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xBBD804", Offset = "0xBBD804", VA = "0xBBD804")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xBBD848", Offset = "0xBBD848", VA = "0xBBD848")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xBBD850", Offset = "0xBBD850", VA = "0xBBD850")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xBBD898", Offset = "0xBBD898", VA = "0xBBD898")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xBBD8E0", Offset = "0xBBD8E0", VA = "0xBBD8E0")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD22B4", Offset = "0xAD22B4")]
		public float weight;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1C49130", Offset = "0x1C49130", VA = "0x1C49130")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1866A70", Offset = "0x1866A70", VA = "0x1866A70")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1866D90", Offset = "0x1866D90", VA = "0x1866D90")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1866E74", Offset = "0x1866E74", VA = "0x1866E74")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1866EDC", Offset = "0x1866EDC", VA = "0x1866EDC")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1867110", Offset = "0x1867110", VA = "0x1867110")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD22CC", Offset = "0xAD22CC")]
		public float pull;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD22E4", Offset = "0xAD22E4")]
		public float pin;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x18F1F2C", Offset = "0x18F1F2C", VA = "0x18F1F2C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x18F1FF8", Offset = "0x18F1FF8", VA = "0x18F1FF8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x18F2018", Offset = "0x18F2018", VA = "0x18F2018")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x18F23F4", Offset = "0x18F23F4", VA = "0x18F23F4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x18F20F0", Offset = "0x18F20F0", VA = "0x18F20F0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x18F24F0", Offset = "0x18F24F0", VA = "0x18F24F0")]
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
		[Address(RVA = "0x18F26F8", Offset = "0x18F26F8", VA = "0x18F26F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x18F2C68", Offset = "0x18F2C68", VA = "0x18F2C68")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x18F2E2C", Offset = "0x18F2E2C", VA = "0x18F2E2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x18F2F28", Offset = "0x18F2F28", VA = "0x18F2F28")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5EE8", Offset = "0xAD5EE8")]
			public Transform transform;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5F20", Offset = "0xAD5F20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD5F20", Offset = "0xAD5F20")]
			public float weight;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x18F5FC0", Offset = "0x18F5FC0", VA = "0x18F5FC0")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x18F6040", Offset = "0x18F6040", VA = "0x18F6040")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x18F36F0", Offset = "0x18F36F0", VA = "0x18F36F0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x18F3AEC", Offset = "0x18F3AEC", VA = "0x18F3AEC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD22FC", Offset = "0xAD22FC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xAD2334", Offset = "0xAD2334")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2334", Offset = "0xAD2334")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2334", Offset = "0xAD2334")]
		public float positionWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD23AC", Offset = "0xAD23AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD23AC", Offset = "0xAD23AC")]
		public float bodyWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2400", Offset = "0xAD2400")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2400", Offset = "0xAD2400")]
		public float thighWeight;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2454", Offset = "0xAD2454")]
		public bool handsPullBody;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xAD248C", Offset = "0xAD248C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD248C", Offset = "0xAD248C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD248C", Offset = "0xAD248C")]
		public float rotationWeight;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2504", Offset = "0xAD2504")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2504", Offset = "0xAD2504")]
		public float bodyClampWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2558", Offset = "0xAD2558")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2558", Offset = "0xAD2558")]
		public float headClampWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD25AC", Offset = "0xAD25AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD25AC", Offset = "0xAD25AC")]
		public float bendWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2600", Offset = "0xAD2600")]
		public BendBone[] bendBones;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xAD2638", Offset = "0xAD2638")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2638", Offset = "0xAD2638")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2638", Offset = "0xAD2638")]
		public float CCDWeight;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD26B0", Offset = "0xAD26B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD26B0", Offset = "0xAD26B0")]
		public float roll;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2704", Offset = "0xAD2704")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2704", Offset = "0xAD2704")]
		public float damper;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD275C", Offset = "0xAD275C")]
		public Transform[] CCDBones;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xAD2794", Offset = "0xAD2794")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2794", Offset = "0xAD2794")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2794", Offset = "0xAD2794")]
		public float postStretchWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD280C", Offset = "0xAD280C")]
		public float maxStretch;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2844", Offset = "0xAD2844")]
		public float stretchDamper;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD287C", Offset = "0xAD287C")]
		public bool fixHead;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD28B4", Offset = "0xAD28B4")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xAD28EC", Offset = "0xAD28EC")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2924", Offset = "0xAD2924")]
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
		[Address(RVA = "0x18F2F30", Offset = "0x18F2F30", VA = "0x18F2F30")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x18F3270", Offset = "0x18F3270", VA = "0x18F3270")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x18F3728", Offset = "0x18F3728", VA = "0x18F3728")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x18F3B14", Offset = "0x18F3B14", VA = "0x18F3B14")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x18F449C", Offset = "0x18F449C", VA = "0x18F449C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x18F47F0", Offset = "0x18F47F0", VA = "0x18F47F0")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x18F4B9C", Offset = "0x18F4B9C", VA = "0x18F4B9C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x18F5620", Offset = "0x18F5620", VA = "0x18F5620")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x18F41C0", Offset = "0x18F41C0", VA = "0x18F41C0")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x18F5838", Offset = "0x18F5838", VA = "0x18F5838")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x18F54D4", Offset = "0x18F54D4", VA = "0x18F54D4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x18F5338", Offset = "0x18F5338", VA = "0x18F5338")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x18F5BB4", Offset = "0x18F5BB4", VA = "0x18F5BB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x18F5E40", Offset = "0x18F5E40", VA = "0x18F5E40")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5F94", Offset = "0xAD5F94")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5FA4", Offset = "0xAD5FA4")]
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
				[Address(RVA = "0x18F8FBC", Offset = "0x18F8FBC", VA = "0x18F8FBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAFE4", Offset = "0xADAFE4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x18F8FC4", Offset = "0x18F8FC4", VA = "0x18F8FC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAFF4", Offset = "0xADAFF4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BA")]
			public bool isRigid
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x18F8FCC", Offset = "0x18F8FCC", VA = "0x18F8FCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB004", Offset = "0xADB004")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x18F8FD4", Offset = "0x18F8FD4", VA = "0x18F8FD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB014", Offset = "0xADB014")]
				private set
				{
				}
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x18F8FE0", Offset = "0x18F8FE0", VA = "0x18F8FE0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x18F6C9C", Offset = "0x18F6C9C", VA = "0x18F6C9C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x18F71FC", Offset = "0x18F71FC", VA = "0x18F71FC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x18F8CA4", Offset = "0x18F8CA4", VA = "0x18F8CA4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD293C", Offset = "0xAD293C")]
		public float pin;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2954", Offset = "0xAD2954")]
		public float pull;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD296C", Offset = "0xAD296C")]
		public float push;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2984", Offset = "0xAD2984")]
		public float pushParent;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD299C", Offset = "0xAD299C")]
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
		[Address(RVA = "0x18F60E4", Offset = "0x18F60E4", VA = "0x18F60E4")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x18F61B0", Offset = "0x18F61B0", VA = "0x18F61B0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x18F62BC", Offset = "0x18F62BC", VA = "0x18F62BC")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x18F63E0", Offset = "0x18F63E0", VA = "0x18F63E0")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x18F64C0", Offset = "0x18F64C0", VA = "0x18F64C0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x18F65C8", Offset = "0x18F65C8", VA = "0x18F65C8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x18F6CF8", Offset = "0x18F6CF8", VA = "0x18F6CF8")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x18F6760", Offset = "0x18F6760", VA = "0x18F6760")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x18F740C", Offset = "0x18F740C", VA = "0x18F740C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x18F77C0", Offset = "0x18F77C0", VA = "0x18F77C0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x18F7BB0", Offset = "0x18F7BB0", VA = "0x18F7BB0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x18F813C", Offset = "0x18F813C", VA = "0x18F813C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x18F8730", Offset = "0x18F8730", VA = "0x18F8730")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x18F89D0", Offset = "0x18F89D0", VA = "0x18F89D0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x18F8628", Offset = "0x18F8628", VA = "0x18F8628")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x18F7F24", Offset = "0x18F7F24", VA = "0x18F7F24")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x18F85A8", Offset = "0x18F85A8", VA = "0x18F85A8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x18F8AC8", Offset = "0x18F8AC8", VA = "0x18F8AC8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x18F84C0", Offset = "0x18F84C0", VA = "0x18F84C0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x18F88B8", Offset = "0x18F88B8", VA = "0x18F88B8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD29B4", Offset = "0xAD29B4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD29CC", Offset = "0xAD29CC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000021")]
		public bool initiated
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1C4600C", Offset = "0x1C4600C", VA = "0x1C4600C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F4C", Offset = "0xAD9F4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1C46014", Offset = "0x1C46014", VA = "0x1C46014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F5C", Offset = "0xAD9F5C")]
			private set
			{
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1C45E3C", Offset = "0x1C45E3C", VA = "0x1C45E3C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1C46020", Offset = "0x1C46020", VA = "0x1C46020")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1C460A4", Offset = "0x1C460A4", VA = "0x1C460A4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1C46150", Offset = "0x1C46150", VA = "0x1C46150")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1C4615C", Offset = "0x1C4615C", VA = "0x1C4615C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1C466C8", Offset = "0x1C466C8", VA = "0x1C466C8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1C46900", Offset = "0x1C46900", VA = "0x1C46900")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1C46DA4", Offset = "0x1C46DA4", VA = "0x1C46DA4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1C46490", Offset = "0x1C46490", VA = "0x1C46490")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1C465AC", Offset = "0x1C465AC", VA = "0x1C465AC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD29DC", Offset = "0xAD29DC")]
		public float positionWeight;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD29F4", Offset = "0xAD29F4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD2A0C", Offset = "0xAD2A0C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2A1C", Offset = "0xAD2A1C")]
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
			[Address(RVA = "0x1C47468", Offset = "0x1C47468", VA = "0x1C47468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F6C", Offset = "0xAD9F6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1C47470", Offset = "0x1C47470", VA = "0x1C47470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F7C", Offset = "0xAD9F7C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1C473F8", Offset = "0x1C473F8", VA = "0x1C473F8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1C4747C", Offset = "0x1C4747C", VA = "0x1C4747C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1C47550", Offset = "0x1C47550", VA = "0x1C47550")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1C4768C", Offset = "0x1C4768C", VA = "0x1C4768C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1C477E4", Offset = "0x1C477E4", VA = "0x1C477E4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1C47AD8", Offset = "0x1C47AD8", VA = "0x1C47AD8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1C47D70", Offset = "0x1C47D70", VA = "0x1C47D70")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1C47EB8", Offset = "0x1C47EB8", VA = "0x1C47EB8")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1C47F64", Offset = "0x1C47F64", VA = "0x1C47F64")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1C485C0", Offset = "0x1C485C0", VA = "0x1C485C0")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1C48630", Offset = "0x1C48630", VA = "0x1C48630")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1C48840", Offset = "0x1C48840", VA = "0x1C48840")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1C48B84", Offset = "0x1C48B84", VA = "0x1C48B84")]
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
				[Address(RVA = "0x1C493B8", Offset = "0x1C493B8", VA = "0x1C493B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BC")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x1C49524", Offset = "0x1C49524", VA = "0x1C49524")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BD")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x1C49B18", Offset = "0x1C49B18", VA = "0x1C49B18")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x1C4938C", Offset = "0x1C4938C", VA = "0x1C4938C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1C49484", Offset = "0x1C49484", VA = "0x1C49484")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1C494D4", Offset = "0x1C494D4", VA = "0x1C494D4")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1C49534", Offset = "0x1C49534", VA = "0x1C49534")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1C49624", Offset = "0x1C49624", VA = "0x1C49624")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x1C4962C", Offset = "0x1C4962C", VA = "0x1C4962C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x1C497CC", Offset = "0x1C497CC", VA = "0x1C497CC")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1C498D8", Offset = "0x1C498D8", VA = "0x1C498D8")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x1C49968", Offset = "0x1C49968", VA = "0x1C49968")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x1C49D3C", Offset = "0x1C49D3C", VA = "0x1C49D3C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1C49D74", Offset = "0x1C49D74", VA = "0x1C49D74")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1C49DAC", Offset = "0x1C49DAC", VA = "0x1C49DAC")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1C49DD4", Offset = "0x1C49DD4", VA = "0x1C49DD4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x1C49F00", Offset = "0x1C49F00", VA = "0x1C49F00")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x1C4A244", Offset = "0x1C4A244", VA = "0x1C4A244")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1C4A278", Offset = "0x1C4A278", VA = "0x1C4A278")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1C4A414", Offset = "0x1C4A414", VA = "0x1C4A414")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1C4A484", Offset = "0x1C4A484", VA = "0x1C4A484")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1C4A6D0", Offset = "0x1C4A6D0", VA = "0x1C4A6D0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1C4A900", Offset = "0x1C4A900", VA = "0x1C4A900")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1C4AA1C", Offset = "0x1C4AA1C", VA = "0x1C4AA1C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1C4A048", Offset = "0x1C4A048", VA = "0x1C4A048")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1C4ABB0", Offset = "0x1C4ABB0", VA = "0x1C4ABB0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1C49140", Offset = "0x1C49140", VA = "0x1C49140", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1C49148", Offset = "0x1C49148", VA = "0x1C49148", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1C4914C", Offset = "0x1C4914C", VA = "0x1C4914C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1C4927C", Offset = "0x1C4927C", VA = "0x1C4927C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1C49384", Offset = "0x1C49384", VA = "0x1C49384")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2A34", Offset = "0xAD2A34")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1C4ABC8", Offset = "0x1C4ABC8", VA = "0x1C4ABC8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1C4AC68", Offset = "0x1C4AC68", VA = "0x1C4AC68")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1C4ACEC", Offset = "0x1C4ACEC", VA = "0x1C4ACEC")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1C4AD84", Offset = "0x1C4AD84", VA = "0x1C4AD84")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1C4AD9C", Offset = "0x1C4AD9C", VA = "0x1C4AD9C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1C4ADB8", Offset = "0x1C4ADB8", VA = "0x1C4ADB8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1C4AE58", Offset = "0x1C4AE58", VA = "0x1C4AE58")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1C4AE70", Offset = "0x1C4AE70", VA = "0x1C4AE70")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2A4C", Offset = "0xAD2A4C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2A64", Offset = "0xAD2A64")]
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
		[Address(RVA = "0x1C4AE94", Offset = "0x1C4AE94", VA = "0x1C4AE94", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1C4AF18", Offset = "0x1C4AF18", VA = "0x1C4AF18")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1C4AFEC", Offset = "0x1C4AFEC", VA = "0x1C4AFEC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1C4B34C", Offset = "0x1C4B34C", VA = "0x1C4B34C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1C4B44C", Offset = "0x1C4B44C", VA = "0x1C4B44C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1C4B578", Offset = "0x1C4B578", VA = "0x1C4B578")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1C4B584", Offset = "0x1C4B584", VA = "0x1C4B584")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1C4B62C", Offset = "0x1C4B62C", VA = "0x1C4B62C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1C4B6E4", Offset = "0x1C4B6E4", VA = "0x1C4B6E4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1C4B95C", Offset = "0x1C4B95C", VA = "0x1C4B95C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1C4BA14", Offset = "0x1C4BA14", VA = "0x1C4BA14")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2A7C", Offset = "0xAD2A7C")]
		public int iterations;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2A94", Offset = "0xAD2A94")]
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
		[Address(RVA = "0x1C4BB80", Offset = "0x1C4BB80", VA = "0x1C4BB80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1C4BE68", Offset = "0x1C4BE68", VA = "0x1C4BE68")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1C4BF84", Offset = "0x1C4BF84", VA = "0x1C4BF84")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1C4C0D4", Offset = "0x1C4C0D4", VA = "0x1C4C0D4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1C4C0E4", Offset = "0x1C4C0E4", VA = "0x1C4C0E4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1C4C154", Offset = "0x1C4C154", VA = "0x1C4C154")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1C4C1DC", Offset = "0x1C4C1DC", VA = "0x1C4C1DC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1C4C86C", Offset = "0x1C4C86C", VA = "0x1C4C86C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1C4C8A8", Offset = "0x1C4C8A8", VA = "0x1C4C8A8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1C4CBA0", Offset = "0x1C4CBA0", VA = "0x1C4CBA0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1C4CF54", Offset = "0x1C4CF54", VA = "0x1C4CF54")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1C4D048", Offset = "0x1C4D048", VA = "0x1C4D048")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1C4D110", Offset = "0x1C4D110", VA = "0x1C4D110")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD5FB4", Offset = "0xAD5FB4")]
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
			[Address(RVA = "0x1C4EC5C", Offset = "0x1C4EC5C", VA = "0x1C4EC5C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1C4ECAC", Offset = "0x1C4ECAC", VA = "0x1C4ECAC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1C4EE34", Offset = "0x1C4EE34", VA = "0x1C4EE34")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1C4EE6C", Offset = "0x1C4EE6C", VA = "0x1C4EE6C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1C4EEA4", Offset = "0x1C4EEA4", VA = "0x1C4EEA4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1C4EEF4", Offset = "0x1C4EEF4", VA = "0x1C4EEF4")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1C4E74C", Offset = "0x1C4E74C", VA = "0x1C4E74C")]
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
				[Address(RVA = "0x1C4DD10", Offset = "0x1C4DD10", VA = "0x1C4DD10")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000608")]
				[Address(RVA = "0x1C4DE04", Offset = "0x1C4DE04", VA = "0x1C4DE04")]
				set
				{
				}
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1C4DE8C", Offset = "0x1C4DE8C", VA = "0x1C4DE8C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1C4E154", Offset = "0x1C4E154", VA = "0x1C4E154")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1C4E430", Offset = "0x1C4E430", VA = "0x1C4E430")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1C4E6A0", Offset = "0x1C4E6A0", VA = "0x1C4E6A0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1C4E6C8", Offset = "0x1C4E6C8", VA = "0x1C4E6C8")]
			public Bone()
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x1C4E7CC", Offset = "0x1C4E7CC", VA = "0x1C4E7CC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1C4E864", Offset = "0x1C4E864", VA = "0x1C4E864")]
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
			[Address(RVA = "0x1C4EBF8", Offset = "0x1C4EBF8", VA = "0x1C4EBF8")]
			public Node()
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1C4EBFC", Offset = "0x1C4EBFC", VA = "0x1C4EBFC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1C4EC24", Offset = "0x1C4EC24", VA = "0x1C4EC24")]
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
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD2AAC", Offset = "0xAD2AAC")]
		public Vector3 IKPosition;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2ABC", Offset = "0xAD2ABC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2ABC", Offset = "0xAD2ABC")]
		public float IKPositionWeight;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD2B10", Offset = "0xAD2B10")]
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
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD2B20", Offset = "0xAD2B20")]
		protected Transform root;

		[Token(Token = "0x17000023")]
		public bool initiated
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1C4D754", Offset = "0x1C4D754", VA = "0x1C4D754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F8C", Offset = "0xAD9F8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1C4D75C", Offset = "0x1C4D75C", VA = "0x1C4D75C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9F9C", Offset = "0xAD9F9C")]
			private set
			{
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1C4D410", Offset = "0x1C4D410", VA = "0x1C4D410")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1C45C88", Offset = "0x1C45C88", VA = "0x1C45C88")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1C45BA8", Offset = "0x1C45BA8", VA = "0x1C45BA8")]
		public void Update()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1C4D6A8", Offset = "0x1C4D6A8", VA = "0x1C4D6A8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1C4D6B4", Offset = "0x1C4D6B4", VA = "0x1C4D6B4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1C4D6C0", Offset = "0x1C4D6C0", VA = "0x1C4D6C0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1C4D6C8", Offset = "0x1C4D6C8", VA = "0x1C4D6C8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1C4D74C", Offset = "0x1C4D74C", VA = "0x1C4D74C")]
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
		[Address(RVA = "0x1C4D768", Offset = "0x1C4D768", VA = "0x1C4D768")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1C4D780", Offset = "0x1C4D780", VA = "0x1C4D780")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1C4D8B8", Offset = "0x1C4D8B8", VA = "0x1C4D8B8")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1C4D970", Offset = "0x1C4D970", VA = "0x1C4D970")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1C4DCF8", Offset = "0x1C4DCF8", VA = "0x1C4DCF8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2B58", Offset = "0xAD2B58")]
		public float poleWeight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2B70", Offset = "0xAD2B70")]
		public float clampWeight;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2B88", Offset = "0xAD2B88")]
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
			[Address(RVA = "0x1C4F094", Offset = "0x1C4F094", VA = "0x1C4F094")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1C4F160", Offset = "0x1C4F160", VA = "0x1C4F160")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		protected override int minBones
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1C4FEFC", Offset = "0x1C4FEFC", VA = "0x1C4FEFC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x1C504A8", Offset = "0x1C504A8", VA = "0x1C504A8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1C4EF94", Offset = "0x1C4EF94", VA = "0x1C4EF94")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1C4F22C", Offset = "0x1C4F22C", VA = "0x1C4F22C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1C4F4C0", Offset = "0x1C4F4C0", VA = "0x1C4F4C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1C4FE40", Offset = "0x1C4FE40", VA = "0x1C4FE40")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1C4FA68", Offset = "0x1C4FA68", VA = "0x1C4FA68")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1C4FF04", Offset = "0x1C4FF04", VA = "0x1C4FF04")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1C50528", Offset = "0x1C50528", VA = "0x1C50528")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2BA0", Offset = "0xAD2BA0")]
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
		[Address(RVA = "0x1C50638", Offset = "0x1C50638", VA = "0x1C50638", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1C509B0", Offset = "0x1C509B0", VA = "0x1C509B0")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1C50A20", Offset = "0x1C50A20", VA = "0x1C50A20", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1C50B7C", Offset = "0x1C50B7C", VA = "0x1C50B7C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1C50D18", Offset = "0x1C50D18", VA = "0x1C50D18", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1C50D64", Offset = "0x1C50D64", VA = "0x1C50D64", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1C50DC4", Offset = "0x1C50DC4", VA = "0x1C50DC4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1C51150", Offset = "0x1C51150", VA = "0x1C51150", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1C5117C", Offset = "0x1C5117C", VA = "0x1C5117C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1C50E2C", Offset = "0x1C50E2C", VA = "0x1C50E2C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1C511E8", Offset = "0x1C511E8", VA = "0x1C511E8")]
		private void Write()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1C51380", Offset = "0x1C51380", VA = "0x1C51380")]
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
		[Address(RVA = "0x1C514D0", Offset = "0x1C514D0", VA = "0x1C514D0")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1C51588", Offset = "0x1C51588", VA = "0x1C51588", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1C51BA0", Offset = "0x1C51BA0", VA = "0x1C51BA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1C5233C", Offset = "0x1C5233C", VA = "0x1C5233C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1C52A98", Offset = "0x1C52A98", VA = "0x1C52A98")]
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
			[Address(RVA = "0x1C53D50", Offset = "0x1C53D50", VA = "0x1C53D50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1C52A9C", Offset = "0x1C52A9C", VA = "0x1C52A9C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1C5320C", Offset = "0x1C5320C", VA = "0x1C5320C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1C53344", Offset = "0x1C53344", VA = "0x1C53344", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1C533E0", Offset = "0x1C533E0", VA = "0x1C533E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1C539D4", Offset = "0x1C539D4", VA = "0x1C539D4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1C53D58", Offset = "0x1C53D58", VA = "0x1C53D58")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1C52B70", Offset = "0x1C52B70", VA = "0x1C52B70")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1C532F0", Offset = "0x1C532F0", VA = "0x1C532F0")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1C53CE8", Offset = "0x1C53CE8", VA = "0x1C53CE8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1C53030", Offset = "0x1C53030", VA = "0x1C53030")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1C545D4", Offset = "0x1C545D4", VA = "0x1C545D4")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1C546DC", Offset = "0x1C546DC", VA = "0x1C546DC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1C54808", Offset = "0x1C54808", VA = "0x1C54808")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1C54928", Offset = "0x1C54928", VA = "0x1C54928")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1C53704", Offset = "0x1C53704", VA = "0x1C53704")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1C5386C", Offset = "0x1C5386C", VA = "0x1C5386C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1C54B1C", Offset = "0x1C54B1C", VA = "0x1C54B1C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1C54030", Offset = "0x1C54030", VA = "0x1C54030")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1C532E0", Offset = "0x1C532E0", VA = "0x1C532E0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1C552D0", Offset = "0x1C552D0", VA = "0x1C552D0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1C54CFC", Offset = "0x1C54CFC", VA = "0x1C54CFC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1C53E70", Offset = "0x1C53E70", VA = "0x1C53E70")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1C53F58", Offset = "0x1C53F58", VA = "0x1C53F58")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1C5539C", Offset = "0x1C5539C", VA = "0x1C5539C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2BB8", Offset = "0xAD2BB8")]
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
		[Address(RVA = "0x1C55410", Offset = "0x1C55410", VA = "0x1C55410", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1C55D18", Offset = "0x1C55D18", VA = "0x1C55D18", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1C55DB8", Offset = "0x1C55DB8", VA = "0x1C55DB8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1C55E60", Offset = "0x1C55E60", VA = "0x1C55E60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1C55F68", Offset = "0x1C55F68", VA = "0x1C55F68")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1C56014", Offset = "0x1C56014", VA = "0x1C56014", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1C565AC", Offset = "0x1C565AC", VA = "0x1C565AC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1C567A4", Offset = "0x1C567A4", VA = "0x1C567A4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1C56660", Offset = "0x1C56660", VA = "0x1C56660")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1C56270", Offset = "0x1C56270", VA = "0x1C56270")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1C56840", Offset = "0x1C56840", VA = "0x1C56840")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2BD0", Offset = "0xAD2BD0")]
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
		[Address(RVA = "0x1C568B8", Offset = "0x1C568B8", VA = "0x1C568B8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1C569BC", Offset = "0x1C569BC", VA = "0x1C569BC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1C56A20", Offset = "0x1C56A20", VA = "0x1C56A20")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1C47394", Offset = "0x1C47394", VA = "0x1C47394")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1C46404", Offset = "0x1C46404", VA = "0x1C46404")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1C56B54", Offset = "0x1C56B54", VA = "0x1C56B54", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1C56CD4", Offset = "0x1C56CD4", VA = "0x1C56CD4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1C56E48", Offset = "0x1C56E48", VA = "0x1C56E48", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1C57054", Offset = "0x1C57054", VA = "0x1C57054", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1C57120", Offset = "0x1C57120", VA = "0x1C57120", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1C57200", Offset = "0x1C57200", VA = "0x1C57200", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1C57374", Offset = "0x1C57374", VA = "0x1C57374", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1C5752C", Offset = "0x1C5752C", VA = "0x1C5752C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1C57764", Offset = "0x1C57764", VA = "0x1C57764", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1C57A50", Offset = "0x1C57A50", VA = "0x1C57A50", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1C57AA4", Offset = "0x1C57AA4", VA = "0x1C57AA4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1C57B8C", Offset = "0x1C57B8C", VA = "0x1C57B8C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2BE8", Offset = "0xAD2BE8")]
		public float spineStiffness;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2C00", Offset = "0xAD2C00")]
		public float pullBodyVertical;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2C18", Offset = "0xAD2C18")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD2C30", Offset = "0xAD2C30")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000029")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1C57C6C", Offset = "0x1C57C6C", VA = "0x1C57C6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1C57C74", Offset = "0x1C57C74", VA = "0x1C57C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1C57C7C", Offset = "0x1C57C7C", VA = "0x1C57C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1C57C84", Offset = "0x1C57C84", VA = "0x1C57C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1C57C8C", Offset = "0x1C57C8C", VA = "0x1C57C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1C57C94", Offset = "0x1C57C94", VA = "0x1C57C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1C57C9C", Offset = "0x1C57C9C", VA = "0x1C57C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1C57CA4", Offset = "0x1C57CA4", VA = "0x1C57CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1C57CAC", Offset = "0x1C57CAC", VA = "0x1C57CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1C57CB4", Offset = "0x1C57CB4", VA = "0x1C57CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1C57CF4", Offset = "0x1C57CF4", VA = "0x1C57CF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1C57D34", Offset = "0x1C57D34", VA = "0x1C57D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1C57D74", Offset = "0x1C57D74", VA = "0x1C57D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1C57DB4", Offset = "0x1C57DB4", VA = "0x1C57DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1C57DF0", Offset = "0x1C57DF0", VA = "0x1C57DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1C57E30", Offset = "0x1C57E30", VA = "0x1C57E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1C57E70", Offset = "0x1C57E70", VA = "0x1C57E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1C57EB0", Offset = "0x1C57EB0", VA = "0x1C57EB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1C59E4C", Offset = "0x1C59E4C", VA = "0x1C59E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9FAC", Offset = "0xAD9FAC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1C59E58", Offset = "0x1C59E58", VA = "0x1C59E58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9FBC", Offset = "0xAD9FBC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1C57EEC", Offset = "0x1C57EEC", VA = "0x1C57EEC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1C58000", Offset = "0x1C58000", VA = "0x1C58000")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1C57F40", Offset = "0x1C57F40", VA = "0x1C57F40")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1C580E0", Offset = "0x1C580E0", VA = "0x1C580E0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1C44754", Offset = "0x1C44754", VA = "0x1C44754")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1C581B8", Offset = "0x1C581B8", VA = "0x1C581B8")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1C58278", Offset = "0x1C58278", VA = "0x1C58278")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1C58334", Offset = "0x1C58334", VA = "0x1C58334")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1C583F0", Offset = "0x1C583F0", VA = "0x1C583F0")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1C583F8", Offset = "0x1C583F8", VA = "0x1C583F8")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1C58434", Offset = "0x1C58434", VA = "0x1C58434")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1C58504", Offset = "0x1C58504", VA = "0x1C58504", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1C58698", Offset = "0x1C58698", VA = "0x1C58698")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1C59754", Offset = "0x1C59754", VA = "0x1C59754")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1C59BF8", Offset = "0x1C59BF8", VA = "0x1C59BF8")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1C59C60", Offset = "0x1C59C60", VA = "0x1C59C60")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1C59A70", Offset = "0x1C59A70", VA = "0x1C59A70")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1C59B34", Offset = "0x1C59B34", VA = "0x1C59B34")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1C59E64", Offset = "0x1C59E64", VA = "0x1C59E64")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1C59F44", Offset = "0x1C59F44", VA = "0x1C59F44", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1C5A090", Offset = "0x1C5A090", VA = "0x1C5A090")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1C5A220", Offset = "0x1C5A220", VA = "0x1C5A220")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1C5A420", Offset = "0x1C5A420", VA = "0x1C5A420")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1C5A630", Offset = "0x1C5A630", VA = "0x1C5A630", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1C5A9A8", Offset = "0x1C5A9A8", VA = "0x1C5A9A8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1C5AAB0", Offset = "0x1C5AAB0", VA = "0x1C5AAB0")]
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
			[Address(RVA = "0x1C5B324", Offset = "0x1C5B324", VA = "0x1C5B324", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1C5B32C", Offset = "0x1C5B32C", VA = "0x1C5B32C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1C5B334", Offset = "0x1C5B334", VA = "0x1C5B334", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1C5B344", Offset = "0x1C5B344", VA = "0x1C5B344", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000040")]
		protected float positionOffset
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x1C52278", Offset = "0x1C52278", VA = "0x1C52278")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1C5AABC", Offset = "0x1C5AABC", VA = "0x1C5AABC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1C5AC4C", Offset = "0x1C5AC4C", VA = "0x1C5AC4C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1C5AD94", Offset = "0x1C5AD94", VA = "0x1C5AD94", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1C5AE04", Offset = "0x1C5AE04", VA = "0x1C5AE04", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1C5AE88", Offset = "0x1C5AE88", VA = "0x1C5AE88", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1C5B218", Offset = "0x1C5B218", VA = "0x1C5B218", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1C5B220", Offset = "0x1C5B220", VA = "0x1C5B220", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1C5B33C", Offset = "0x1C5B33C", VA = "0x1C5B33C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1C5B340", Offset = "0x1C5B340", VA = "0x1C5B340", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1C51614", Offset = "0x1C51614", VA = "0x1C51614")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1C51ED4", Offset = "0x1C51ED4", VA = "0x1C51ED4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1C5B484", Offset = "0x1C5B484", VA = "0x1C5B484")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1C505BC", Offset = "0x1C505BC", VA = "0x1C505BC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2C40", Offset = "0xAD2C40")]
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
		[Address(RVA = "0x1C5B744", Offset = "0x1C5B744", VA = "0x1C5B744", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1C5BABC", Offset = "0x1C5BABC", VA = "0x1C5BABC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1C5BB2C", Offset = "0x1C5BB2C", VA = "0x1C5BB2C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1C5BC88", Offset = "0x1C5BC88", VA = "0x1C5BC88", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1C5BE24", Offset = "0x1C5BE24", VA = "0x1C5BE24", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1C5BE70", Offset = "0x1C5BE70", VA = "0x1C5BE70", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1C5BED0", Offset = "0x1C5BED0", VA = "0x1C5BED0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1C5C25C", Offset = "0x1C5C25C", VA = "0x1C5C25C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1C5C288", Offset = "0x1C5C288", VA = "0x1C5C288")]
		private void Solve()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1C5BF38", Offset = "0x1C5BF38", VA = "0x1C5BF38")]
		private void Read()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1C5C394", Offset = "0x1C5C394", VA = "0x1C5C394")]
		private void Write()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1C5C52C", Offset = "0x1C5C52C", VA = "0x1C5C52C")]
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
			[Address(RVA = "0xBC76DC", Offset = "0xBC76DC", VA = "0xBC76DC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2C58", Offset = "0xAD2C58")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2C70", Offset = "0xAD2C70")]
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
			[Address(RVA = "0x1C5DBA0", Offset = "0x1C5DBA0", VA = "0x1C5DBA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1C5C67C", Offset = "0x1C5C67C", VA = "0x1C5C67C")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1C5C6D0", Offset = "0x1C5C6D0", VA = "0x1C5C6D0")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1C5C71C", Offset = "0x1C5C71C", VA = "0x1C5C71C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1C5CDA4", Offset = "0x1C5CDA4", VA = "0x1C5CDA4", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1C5D950", Offset = "0x1C5D950", VA = "0x1C5D950", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1C5DA9C", Offset = "0x1C5DA9C", VA = "0x1C5DA9C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1C5DB14", Offset = "0x1C5DB14", VA = "0x1C5DB14")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1C5CA98", Offset = "0x1C5CA98", VA = "0x1C5CA98")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1C5CED4", Offset = "0x1C5CED4", VA = "0x1C5CED4")]
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
				[Address(RVA = "0x1C29D1C", Offset = "0x1C29D1C", VA = "0x1C29D1C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1C2A480", Offset = "0x1C2A480", VA = "0x1C2A480")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1C29090", Offset = "0x1C29090", VA = "0x1C29090")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1C293D8", Offset = "0x1C293D8", VA = "0x1C293D8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1C2A128", Offset = "0x1C2A128", VA = "0x1C2A128")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2C88", Offset = "0xAD2C88")]
		public float bodyWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2CA0", Offset = "0xAD2CA0")]
		public float headWeight;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2CB8", Offset = "0xAD2CB8")]
		public float eyesWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2CD0", Offset = "0xAD2CD0")]
		public float clampWeight;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2CE8", Offset = "0xAD2CE8")]
		public float clampWeightHead;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2D00", Offset = "0xAD2D00")]
		public float clampWeightEyes;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2D18", Offset = "0xAD2D18")]
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
			[Address(RVA = "0x1C287BC", Offset = "0x1C287BC", VA = "0x1C287BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1C289A4", Offset = "0x1C289A4", VA = "0x1C289A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		private bool headIsValid
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1C288A8", Offset = "0x1C288A8", VA = "0x1C288A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1C289CC", Offset = "0x1C289CC", VA = "0x1C289CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1C288B8", Offset = "0x1C288B8", VA = "0x1C288B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1C28A4C", Offset = "0x1C28A4C", VA = "0x1C28A4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1C27E78", Offset = "0x1C27E78", VA = "0x1C27E78")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1C27EFC", Offset = "0x1C27EFC", VA = "0x1C27EFC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1C27FA8", Offset = "0x1C27FA8", VA = "0x1C27FA8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1C28070", Offset = "0x1C28070", VA = "0x1C28070")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1C2815C", Offset = "0x1C2815C", VA = "0x1C2815C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1C28268", Offset = "0x1C28268", VA = "0x1C28268")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1C283B0", Offset = "0x1C283B0", VA = "0x1C283B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1C284E0", Offset = "0x1C284E0", VA = "0x1C284E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1C28624", Offset = "0x1C28624", VA = "0x1C28624", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1C28A74", Offset = "0x1C28A74", VA = "0x1C28A74", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1C28CAC", Offset = "0x1C28CAC", VA = "0x1C28CAC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1C28E54", Offset = "0x1C28E54", VA = "0x1C28E54")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1C290BC", Offset = "0x1C290BC", VA = "0x1C290BC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1C2951C", Offset = "0x1C2951C", VA = "0x1C2951C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1C29620", Offset = "0x1C29620", VA = "0x1C29620")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1C29850", Offset = "0x1C29850", VA = "0x1C29850")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1C29AB0", Offset = "0x1C29AB0", VA = "0x1C29AB0")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1C29DE8", Offset = "0x1C29DE8", VA = "0x1C29DE8")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1C28F04", Offset = "0x1C28F04", VA = "0x1C28F04")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1C2A298", Offset = "0x1C2A298", VA = "0x1C2A298")]
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
			[Address(RVA = "0x1C2BA80", Offset = "0x1C2BA80", VA = "0x1C2BA80")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1C2C700", Offset = "0x1C2C700", VA = "0x1C2C700")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1C2C334", Offset = "0x1C2C334", VA = "0x1C2C334")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1C2C8D8", Offset = "0x1C2C8D8", VA = "0x1C2C8D8")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2D30", Offset = "0xAD2D30")]
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
		[Address(RVA = "0x1C2A488", Offset = "0x1C2A488", VA = "0x1C2A488")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1C2A67C", Offset = "0x1C2A67C", VA = "0x1C2A67C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1C2A834", Offset = "0x1C2A834", VA = "0x1C2A834")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1C2A840", Offset = "0x1C2A840", VA = "0x1C2A840")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1C2A8C4", Offset = "0x1C2A8C4", VA = "0x1C2A8C4")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1C2A8D0", Offset = "0x1C2A8D0", VA = "0x1C2A8D0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1C2A8D8", Offset = "0x1C2A8D8", VA = "0x1C2A8D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1C2A9DC", Offset = "0x1C2A9DC", VA = "0x1C2A9DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1C2AB00", Offset = "0x1C2AB00", VA = "0x1C2AB00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1C2AB4C", Offset = "0x1C2AB4C", VA = "0x1C2AB4C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1C2ABAC", Offset = "0x1C2ABAC", VA = "0x1C2ABAC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1C2AF90", Offset = "0x1C2AF90", VA = "0x1C2AF90")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1C2AFEC", Offset = "0x1C2AFEC", VA = "0x1C2AFEC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1C2B598", Offset = "0x1C2B598", VA = "0x1C2B598")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1C2B7B0", Offset = "0x1C2B7B0", VA = "0x1C2B7B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1C2B974", Offset = "0x1C2B974", VA = "0x1C2B974")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1C2B8EC", Offset = "0x1C2B8EC", VA = "0x1C2B8EC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1C2BC20", Offset = "0x1C2BC20", VA = "0x1C2BC20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1C2C7BC", Offset = "0x1C2C7BC", VA = "0x1C2C7BC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1C2C7C0", Offset = "0x1C2C7C0", VA = "0x1C2C7C0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1C2C7C4", Offset = "0x1C2C7C4", VA = "0x1C2C7C4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1C2C400", Offset = "0x1C2C400", VA = "0x1C2C400")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1C2C7C8", Offset = "0x1C2C7C8", VA = "0x1C2C7C8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5FCC", Offset = "0xAD5FCC")]
			public Transform target;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6004", Offset = "0xAD6004")]
			public Transform bendGoal;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD603C", Offset = "0xAD603C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD603C", Offset = "0xAD603C")]
			public float positionWeight;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6090", Offset = "0xAD6090")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6090", Offset = "0xAD6090")]
			public float rotationWeight;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD60E4", Offset = "0xAD60E4")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD611C", Offset = "0xAD611C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD611C", Offset = "0xAD611C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6170", Offset = "0xAD6170")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6170", Offset = "0xAD6170")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD61C4", Offset = "0xAD61C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD61C4", Offset = "0xAD61C4")]
			public float bendGoalWeight;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6218", Offset = "0xAD6218")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6218", Offset = "0xAD6218")]
			public float swivelOffset;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6274", Offset = "0xAD6274")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD62AC", Offset = "0xAD62AC")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD62E4", Offset = "0xAD62E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD62E4", Offset = "0xAD62E4")]
			public float armLengthMlp;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD633C", Offset = "0xAD633C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6374", Offset = "0xAD6374")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6384", Offset = "0xAD6384")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6394", Offset = "0xAD6394")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD63A4", Offset = "0xAD63A4")]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD63B4", Offset = "0xAD63B4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD63C4", Offset = "0xAD63C4")]
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
				[Address(RVA = "0x1C35338", Offset = "0x1C35338", VA = "0x1C35338")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB024", Offset = "0xADB024")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x1C35344", Offset = "0x1C35344", VA = "0x1C35344")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB034", Offset = "0xADB034")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x1C35350", Offset = "0x1C35350", VA = "0x1C35350")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB044", Offset = "0xADB044")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x1C3535C", Offset = "0x1C3535C", VA = "0x1C3535C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB054", Offset = "0xADB054")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x1C35368", Offset = "0x1C35368", VA = "0x1C35368")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x1C353A4", Offset = "0x1C353A4", VA = "0x1C353A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x1C353EC", Offset = "0x1C353EC", VA = "0x1C353EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private VirtualBone hand
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x1C35440", Offset = "0x1C35440", VA = "0x1C35440")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1C35494", Offset = "0x1C35494", VA = "0x1C35494", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1C35C08", Offset = "0x1C35C08", VA = "0x1C35C08", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1C35E04", Offset = "0x1C35E04", VA = "0x1C35E04", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1C35EB0", Offset = "0x1C35EB0", VA = "0x1C35EB0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1C33318", Offset = "0x1C33318", VA = "0x1C33318")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1C37300", Offset = "0x1C37300", VA = "0x1C37300", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1C37370", Offset = "0x1C37370", VA = "0x1C37370", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1C362C8", Offset = "0x1C362C8", VA = "0x1C362C8")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x1C365D0", Offset = "0x1C365D0", VA = "0x1C365D0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x1C375C8", Offset = "0x1C375C8", VA = "0x1C375C8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x1C35034", Offset = "0x1C35034", VA = "0x1C35034")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD63D4", Offset = "0xAD63D4")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD63E4", Offset = "0xAD63E4")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD63F4", Offset = "0xAD63F4")]
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
				[Address(RVA = "0x1C3778C", Offset = "0x1C3778C", VA = "0x1C3778C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB064", Offset = "0xADB064")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x1C37794", Offset = "0x1C37794", VA = "0x1C37794")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB074", Offset = "0xADB074")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public float mag
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x1C3779C", Offset = "0x1C3779C", VA = "0x1C3779C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB084", Offset = "0xADB084")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x1C377A4", Offset = "0x1C377A4", VA = "0x1C377A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB094", Offset = "0xADB094")]
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
			[Address(RVA = "0x1C30BD0", Offset = "0x1C30BD0", VA = "0x1C30BD0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1C37AA8", Offset = "0x1C37AA8", VA = "0x1C37AA8")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x1C37C1C", Offset = "0x1C37C1C", VA = "0x1C37C1C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1C37EB8", Offset = "0x1C37EB8", VA = "0x1C37EB8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x1C32AE0", Offset = "0x1C32AE0", VA = "0x1C32AE0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x1C37154", Offset = "0x1C37154", VA = "0x1C37154")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x1C37F0C", Offset = "0x1C37F0C", VA = "0x1C37F0C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1C38054", Offset = "0x1C38054", VA = "0x1C38054")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x1C376F4", Offset = "0x1C376F4", VA = "0x1C376F4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD6404", Offset = "0xAD6404")]
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
				[Address(RVA = "0x1C3807C", Offset = "0x1C3807C", VA = "0x1C3807C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C9")]
			public float stepProgress
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x1C38090", Offset = "0x1C38090", VA = "0x1C38090")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB0A4", Offset = "0xADB0A4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x1C38098", Offset = "0x1C38098", VA = "0x1C38098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB0B4", Offset = "0xADB0B4")]
				private set
				{
				}
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1C380A0", Offset = "0x1C380A0", VA = "0x1C380A0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1C38234", Offset = "0x1C38234", VA = "0x1C38234")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1C3827C", Offset = "0x1C3827C", VA = "0x1C3827C")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x1C38388", Offset = "0x1C38388", VA = "0x1C38388")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1C38560", Offset = "0x1C38560", VA = "0x1C38560")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1C3874C", Offset = "0x1C3874C", VA = "0x1C3874C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6414", Offset = "0xAD6414")]
			public Transform target;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD644C", Offset = "0xAD644C")]
			public Transform bendGoal;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6484", Offset = "0xAD6484")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6484", Offset = "0xAD6484")]
			public float positionWeight;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD64D8", Offset = "0xAD64D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD64D8", Offset = "0xAD64D8")]
			public float rotationWeight;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD652C", Offset = "0xAD652C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD652C", Offset = "0xAD652C")]
			public float bendGoalWeight;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6580", Offset = "0xAD6580")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6580", Offset = "0xAD6580")]
			public float swivelOffset;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD65DC", Offset = "0xAD65DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD65DC", Offset = "0xAD65DC")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6630", Offset = "0xAD6630")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6630", Offset = "0xAD6630")]
			public float legLengthMlp;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6688", Offset = "0xAD6688")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD66C0", Offset = "0xAD66C0")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD66D0", Offset = "0xAD66D0")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD66E0", Offset = "0xAD66E0")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD66F0", Offset = "0xAD66F0")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6700", Offset = "0xAD6700")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6710", Offset = "0xAD6710")]
			public float currentMag;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD6720", Offset = "0xAD6720")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD6730", Offset = "0xAD6730")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD6740", Offset = "0xAD6740")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD6750", Offset = "0xAD6750")]
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
				[Address(RVA = "0x1C3896C", Offset = "0x1C3896C", VA = "0x1C3896C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB0C4", Offset = "0xADB0C4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x1C38978", Offset = "0x1C38978", VA = "0x1C38978")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB0D4", Offset = "0xADB0D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x1C38984", Offset = "0x1C38984", VA = "0x1C38984")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB0E4", Offset = "0xADB0E4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x1C38990", Offset = "0x1C38990", VA = "0x1C38990")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB0F4", Offset = "0xADB0F4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			public bool hasToes
			{
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x1C3899C", Offset = "0x1C3899C", VA = "0x1C3899C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB104", Offset = "0xADB104")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000658")]
				[Address(RVA = "0x1C389A4", Offset = "0x1C389A4", VA = "0x1C389A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB114", Offset = "0xADB114")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0x1C389B0", Offset = "0x1C389B0", VA = "0x1C389B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private VirtualBone calf
			{
				[Token(Token = "0x600065A")]
				[Address(RVA = "0x1C389EC", Offset = "0x1C389EC", VA = "0x1C389EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private VirtualBone foot
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0x1C38A2C", Offset = "0x1C38A2C", VA = "0x1C38A2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private VirtualBone toes
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0x1C38A6C", Offset = "0x1C38A6C", VA = "0x1C38A6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x1C3292C", Offset = "0x1C3292C", VA = "0x1C3292C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x1C38AAC", Offset = "0x1C38AAC", VA = "0x1C38AAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB124", Offset = "0xADB124")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x1C38AB8", Offset = "0x1C38AB8", VA = "0x1C38AB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB134", Offset = "0xADB134")]
				private set
				{
				}
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1C38AC4", Offset = "0x1C38AC4", VA = "0x1C38AC4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1C39100", Offset = "0x1C39100", VA = "0x1C39100", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1C39934", Offset = "0x1C39934", VA = "0x1C39934", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1C39830", Offset = "0x1C39830", VA = "0x1C39830")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x1C395F8", Offset = "0x1C395F8", VA = "0x1C395F8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1C32CD4", Offset = "0x1C32CD4", VA = "0x1C32CD4")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1C39EF4", Offset = "0x1C39EF4", VA = "0x1C39EF4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1C3A3F4", Offset = "0x1C3A3F4", VA = "0x1C3A3F4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1C3A648", Offset = "0x1C3A648", VA = "0x1C3A648", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1C3515C", Offset = "0x1C3515C", VA = "0x1C3515C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6760", Offset = "0xAD6760")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6760", Offset = "0xAD6760")]
			public float weight;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD67B4", Offset = "0xAD67B4")]
			public float footDistance;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD67EC", Offset = "0xAD67EC")]
			public float stepThreshold;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6824", Offset = "0xAD6824")]
			public float angleThreshold;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD685C", Offset = "0xAD685C")]
			public float comAngleMlp;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6894", Offset = "0xAD6894")]
			public float maxVelocity;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD68CC", Offset = "0xAD68CC")]
			public float velocityFactor;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6904", Offset = "0xAD6904")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6904", Offset = "0xAD6904")]
			public float maxLegStretch;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD695C", Offset = "0xAD695C")]
			public float rootSpeed;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6994", Offset = "0xAD6994")]
			public float stepSpeed;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD69CC", Offset = "0xAD69CC")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6A04", Offset = "0xAD6A04")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6A3C", Offset = "0xAD6A3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6A3C", Offset = "0xAD6A3C")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6A94", Offset = "0xAD6A94")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6ACC", Offset = "0xAD6ACC")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6B04", Offset = "0xAD6B04")]
			public Vector3 offset;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6B3C", Offset = "0xAD6B3C")]
			public bool blockingEnabled;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6B4C", Offset = "0xAD6B4C")]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6B5C", Offset = "0xAD6B5C")]
			public float raycastRadius;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD6B6C", Offset = "0xAD6B6C")]
			public float raycastHeight;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6B7C", Offset = "0xAD6B7C")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6BB4", Offset = "0xAD6BB4")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD6BEC", Offset = "0xAD6BEC")]
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
				[Address(RVA = "0x1C3A6F8", Offset = "0x1C3A6F8", VA = "0x1C3A6F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB144", Offset = "0xADB144")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x1C3A704", Offset = "0x1C3A704", VA = "0x1C3A704")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB154", Offset = "0xADB154")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x1C3AB54", Offset = "0x1C3AB54", VA = "0x1C3AB54")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D5")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x1C3AB9C", Offset = "0x1C3AB9C", VA = "0x1C3AB9C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D6")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x1C3ABE8", Offset = "0x1C3ABE8", VA = "0x1C3ABE8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000D7")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x1C3AC30", Offset = "0x1C3AC30", VA = "0x1C3AC30")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1C30CB8", Offset = "0x1C30CB8", VA = "0x1C30CB8")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1C2EA20", Offset = "0x1C2EA20", VA = "0x1C2EA20")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1C2DE14", Offset = "0x1C2DE14", VA = "0x1C2DE14")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1C2DC5C", Offset = "0x1C2DC5C", VA = "0x1C2DC5C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1C31518", Offset = "0x1C31518", VA = "0x1C31518")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1C3A758", Offset = "0x1C3A758", VA = "0x1C3A758")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1C3A8FC", Offset = "0x1C3A8FC", VA = "0x1C3A8FC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1C3A988", Offset = "0x1C3A988", VA = "0x1C3A988")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1C35250", Offset = "0x1C35250", VA = "0x1C35250")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6BFC", Offset = "0xAD6BFC")]
			public Transform headTarget;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6C34", Offset = "0xAD6C34")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6C6C", Offset = "0xAD6C6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6C6C", Offset = "0xAD6C6C")]
			public float positionWeight;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6CC0", Offset = "0xAD6CC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6CC0", Offset = "0xAD6CC0")]
			public float rotationWeight;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6D14", Offset = "0xAD6D14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6D14", Offset = "0xAD6D14")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6D68", Offset = "0xAD6D68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6D68", Offset = "0xAD6D68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6DBC", Offset = "0xAD6DBC")]
			public Transform chestGoal;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6DF4", Offset = "0xAD6DF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6DF4", Offset = "0xAD6DF4")]
			public float chestGoalWeight;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6E48", Offset = "0xAD6E48")]
			public float minHeadHeight;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6E80", Offset = "0xAD6E80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6E80", Offset = "0xAD6E80")]
			public float bodyPosStiffness;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6ED4", Offset = "0xAD6ED4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6ED4", Offset = "0xAD6ED4")]
			public float bodyRotStiffness;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6F28", Offset = "0xAD6F28")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAD6F28", Offset = "0xAD6F28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6F28", Offset = "0xAD6F28")]
			public float neckStiffness;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6FA0", Offset = "0xAD6FA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6FA0", Offset = "0xAD6FA0")]
			public float rotateChestByHands;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD6FF4", Offset = "0xAD6FF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD6FF4", Offset = "0xAD6FF4")]
			public float chestClampWeight;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7048", Offset = "0xAD7048")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD7048", Offset = "0xAD7048")]
			public float headClampWeight;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD709C", Offset = "0xAD709C")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD70D4", Offset = "0xAD70D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD70D4", Offset = "0xAD70D4")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7128", Offset = "0xAD7128")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD7128", Offset = "0xAD7128")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7180", Offset = "0xAD7180")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7190", Offset = "0xAD7190")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD71A0", Offset = "0xAD71A0")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD71B0", Offset = "0xAD71B0")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD71C0", Offset = "0xAD71C0")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD71D0", Offset = "0xAD71D0")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD71E0", Offset = "0xAD71E0")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD71F0", Offset = "0xAD71F0")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7200", Offset = "0xAD7200")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7210", Offset = "0xAD7210")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7220", Offset = "0xAD7220")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7230", Offset = "0xAD7230")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7240", Offset = "0xAD7240")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7250", Offset = "0xAD7250")]
			public Vector3 headPosition;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7260", Offset = "0xAD7260")]
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
				[Address(RVA = "0x1C2ECA0", Offset = "0x1C2ECA0", VA = "0x1C2ECA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x1C3AC7C", Offset = "0x1C3AC7C", VA = "0x1C3AC7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			public VirtualBone chest
			{
				[Token(Token = "0x600067B")]
				[Address(RVA = "0x1C332B8", Offset = "0x1C332B8", VA = "0x1C332B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private VirtualBone neck
			{
				[Token(Token = "0x600067C")]
				[Address(RVA = "0x1C3ACC4", Offset = "0x1C3ACC4", VA = "0x1C3ACC4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			public VirtualBone head
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x1C3A710", Offset = "0x1C3A710", VA = "0x1C3A710")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x1C3AD0C", Offset = "0x1C3AD0C", VA = "0x1C3AD0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB164", Offset = "0xADB164")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600067F")]
				[Address(RVA = "0x1C3AD20", Offset = "0x1C3AD20", VA = "0x1C3AD20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB174", Offset = "0xADB174")]
				private set
				{
				}
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1C3AD34", Offset = "0x1C3AD34", VA = "0x1C3AD34", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1C3B828", Offset = "0x1C3B828", VA = "0x1C3B828", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1C3BA38", Offset = "0x1C3BA38", VA = "0x1C3BA38", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1C3BFF0", Offset = "0x1C3BFF0", VA = "0x1C3BFF0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x1C30FB4", Offset = "0x1C30FB4", VA = "0x1C30FB4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1C3C9B8", Offset = "0x1C3C9B8", VA = "0x1C3C9B8")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x1C3D0A4", Offset = "0x1C3D0A4", VA = "0x1C3D0A4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1C3D850", Offset = "0x1C3D850", VA = "0x1C3D850", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1C3DA6C", Offset = "0x1C3DA6C", VA = "0x1C3DA6C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1C3C224", Offset = "0x1C3C224", VA = "0x1C3C224")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1C32974", Offset = "0x1C32974", VA = "0x1C32974")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1C3C5B0", Offset = "0x1C3C5B0", VA = "0x1C3C5B0")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1C3DB64", Offset = "0x1C3DB64", VA = "0x1C3DB64")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1C3CE40", Offset = "0x1C3CE40", VA = "0x1C3CE40")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1C3CB70", Offset = "0x1C3CB70", VA = "0x1C3CB70")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1C34E68", Offset = "0x1C34E68", VA = "0x1C34E68")]
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
			[Address(RVA = "0x1C30B34", Offset = "0x1C30B34", VA = "0x1C30B34")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1C30BB0", Offset = "0x1C30BB0", VA = "0x1C30BB0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1C3DE8C", Offset = "0x1C3DE8C", VA = "0x1C3DE8C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1C377AC", Offset = "0x1C377AC", VA = "0x1C377AC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1C37CD0", Offset = "0x1C37CD0", VA = "0x1C37CD0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1C3E114", Offset = "0x1C3E114", VA = "0x1C3E114")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1C363A0", Offset = "0x1C363A0", VA = "0x1C363A0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1C3E334", Offset = "0x1C3E334", VA = "0x1C3E334")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1C36B94", Offset = "0x1C36B94", VA = "0x1C36B94")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1C3E3F8", Offset = "0x1C3E3F8", VA = "0x1C3E3F8")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1C3D41C", Offset = "0x1C3D41C", VA = "0x1C3D41C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1C3E610", Offset = "0x1C3E610", VA = "0x1C3E610")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1C3E718", Offset = "0x1C3E718", VA = "0x1C3E718")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2D48", Offset = "0xAD2D48")]
		public bool plantFeet;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD2D80", Offset = "0xAD2D80")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2D90", Offset = "0xAD2D90")]
		public Spine spine;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2DC8", Offset = "0xAD2DC8")]
		public Arm leftArm;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2E00", Offset = "0xAD2E00")]
		public Arm rightArm;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2E38", Offset = "0xAD2E38")]
		public Leg leftLeg;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2E70", Offset = "0xAD2E70")]
		public Leg rightLeg;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2EA8", Offset = "0xAD2EA8")]
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
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xADB504", Offset = "0xADB504")]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1C34CB0", Offset = "0x1C34CB0", VA = "0x1C34CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9FCC", Offset = "0xAD9FCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1C34CB8", Offset = "0x1C34CB8", VA = "0x1C34CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9FDC", Offset = "0xAD9FDC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1C2C8E0", Offset = "0x1C2C8E0", VA = "0x1C2C8E0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1C2CD28", Offset = "0x1C2CD28", VA = "0x1C2CD28")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1C2CBCC", Offset = "0x1C2CBCC", VA = "0x1C2CBCC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1C2D724", Offset = "0x1C2D724", VA = "0x1C2D724")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1C2D894", Offset = "0x1C2D894", VA = "0x1C2D894")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1C2D938", Offset = "0x1C2D938", VA = "0x1C2D938")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1C2DAD0", Offset = "0x1C2DAD0", VA = "0x1C2DAD0")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1C2E1F4", Offset = "0x1C2E1F4", VA = "0x1C2E1F4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1C2ECE8", Offset = "0x1C2ECE8", VA = "0x1C2ECE8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1C2EE60", Offset = "0x1C2EE60", VA = "0x1C2EE60", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1C2F008", Offset = "0x1C2F008", VA = "0x1C2F008", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1C2F07C", Offset = "0x1C2F07C", VA = "0x1C2F07C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1C2F0F0", Offset = "0x1C2F0F0", VA = "0x1C2F0F0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1C2F308", Offset = "0x1C2F308", VA = "0x1C2F308")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1C2CFCC", Offset = "0x1C2CFCC", VA = "0x1C2CFCC")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1C2D1A8", Offset = "0x1C2D1A8", VA = "0x1C2D1A8")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1C2D5FC", Offset = "0x1C2D5FC", VA = "0x1C2D5FC")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1C2E368", Offset = "0x1C2E368", VA = "0x1C2E368")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1C2F5F0", Offset = "0x1C2F5F0", VA = "0x1C2F5F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1C2F638", Offset = "0x1C2F638", VA = "0x1C2F638", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1C30824", Offset = "0x1C30824", VA = "0x1C30824")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1C2E4D0", Offset = "0x1C2E4D0", VA = "0x1C2E4D0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1C2F6B4", Offset = "0x1C2F6B4", VA = "0x1C2F6B4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1C30A98", Offset = "0x1C30A98", VA = "0x1C30A98")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1C30AE8", Offset = "0x1C30AE8", VA = "0x1C30AE8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1C306C0", Offset = "0x1C306C0", VA = "0x1C306C0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1C346C4", Offset = "0x1C346C4", VA = "0x1C346C4")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1C34CC0", Offset = "0x1C34CC0", VA = "0x1C34CC0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2EE0", Offset = "0xAD2EE0")]
		public Transform parent;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2F18", Offset = "0xAD2F18")]
		public Transform child;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2F50", Offset = "0xAD2F50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2F50", Offset = "0xAD2F50")]
		public float weight;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2FA4", Offset = "0xAD2FA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2FA4", Offset = "0xAD2FA4")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD2FF8", Offset = "0xAD2FF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD2FF8", Offset = "0xAD2FF8")]
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
		[Address(RVA = "0x1867C9C", Offset = "0x1867C9C", VA = "0x1867C9C")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1868088", Offset = "0x1868088", VA = "0x1868088")]
		private void Start()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1868500", Offset = "0x1868500", VA = "0x1868500")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1868588", Offset = "0x1868588", VA = "0x1868588")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1868610", Offset = "0x1868610", VA = "0x1868610")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1868714", Offset = "0x1868714", VA = "0x1868714")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD3054", Offset = "0xAD3054")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD3064", Offset = "0xAD3064")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD3074", Offset = "0xAD3074")]
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
			[Address(RVA = "0x1C3EF6C", Offset = "0x1C3EF6C", VA = "0x1C3EF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9FEC", Offset = "0xAD9FEC")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1C3EF74", Offset = "0x1C3EF74", VA = "0x1C3EF74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD9FFC", Offset = "0xAD9FFC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool isPaused
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1C3EF7C", Offset = "0x1C3EF7C", VA = "0x1C3EF7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA00C", Offset = "0xADA00C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1C3EF84", Offset = "0x1C3EF84", VA = "0x1C3EF84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA01C", Offset = "0xADA01C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1C3EF90", Offset = "0x1C3EF90", VA = "0x1C3EF90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA02C", Offset = "0xADA02C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x1C3EF98", Offset = "0x1C3EF98", VA = "0x1C3EF98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA03C", Offset = "0xADA03C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool inInteraction
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1C3EFA0", Offset = "0x1C3EFA0", VA = "0x1C3EFA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public float progress
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x1C4117C", Offset = "0x1C4117C", VA = "0x1C4117C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1C3F010", Offset = "0x1C3F010", VA = "0x1C3F010")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1C3F094", Offset = "0x1C3F094", VA = "0x1C3F094")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1C3F13C", Offset = "0x1C3F13C", VA = "0x1C3F13C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1C3F280", Offset = "0x1C3F280", VA = "0x1C3F280")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1C3F688", Offset = "0x1C3F688", VA = "0x1C3F688")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1C3F7C0", Offset = "0x1C3F7C0", VA = "0x1C3F7C0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1C3F81C", Offset = "0x1C3F81C", VA = "0x1C3F81C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1C3FE5C", Offset = "0x1C3FE5C", VA = "0x1C3FE5C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1C40974", Offset = "0x1C40974", VA = "0x1C40974")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1C40BB0", Offset = "0x1C40BB0", VA = "0x1C40BB0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1C4101C", Offset = "0x1C4101C", VA = "0x1C4101C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1C41248", Offset = "0x1C41248", VA = "0x1C41248")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3084", Offset = "0xAD3084")]
		public LookAtIK ik;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD30BC", Offset = "0xAD30BC")]
		public float lerpSpeed;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD30F4", Offset = "0xAD30F4")]
		public float weightSpeed;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD312C", Offset = "0xAD312C")]
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
		[Address(RVA = "0x1C414B4", Offset = "0x1C414B4", VA = "0x1C414B4")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1C41630", Offset = "0x1C41630", VA = "0x1C41630")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1C416DC", Offset = "0x1C416DC", VA = "0x1C416DC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1C41928", Offset = "0x1C41928", VA = "0x1C41928")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1C41A24", Offset = "0x1C41A24", VA = "0x1C41A24")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1C41AF4", Offset = "0x1C41AF4", VA = "0x1C41AF4")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD06B8", Offset = "0xAD06B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD06B8", Offset = "0xAD06B8")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class InteractionEvent
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7270", Offset = "0xAD7270")]
			public float time;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD72A8", Offset = "0xAD72A8")]
			public bool pause;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD72E0", Offset = "0xAD72E0")]
			public bool pickUp;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7318", Offset = "0xAD7318")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7350", Offset = "0xAD7350")]
			public Message[] messages;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7388", Offset = "0xAD7388")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1857638", Offset = "0x1857638", VA = "0x1857638")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1857804", Offset = "0x1857804", VA = "0x1857804")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD73C0", Offset = "0xAD73C0")]
			public string function;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD73F8", Offset = "0xAD73F8")]
			public GameObject recipient;

			[Token(Token = "0x40005B5")]
			private const string empty = "";

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1857714", Offset = "0x1857714", VA = "0x1857714")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x185780C", Offset = "0x185780C", VA = "0x185780C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7430", Offset = "0xAD7430")]
			public Animator animator;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7468", Offset = "0xAD7468")]
			public Animation animation;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD74A0", Offset = "0xAD74A0")]
			public string animationState;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD74D8", Offset = "0xAD74D8")]
			public float crossfadeTime;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7510", Offset = "0xAD7510")]
			public int layer;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7548", Offset = "0xAD7548")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40005BC")]
			private const string empty = "";

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1857390", Offset = "0x1857390", VA = "0x1857390")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1857484", Offset = "0x1857484", VA = "0x1857484")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1857540", Offset = "0x1857540", VA = "0x1857540")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x1857624", Offset = "0x1857624", VA = "0x1857624")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7580", Offset = "0xAD7580")]
			public Type type;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD75B8", Offset = "0xAD75B8")]
			public AnimationCurve curve;

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x185784C", Offset = "0x185784C", VA = "0x185784C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1857878", Offset = "0x1857878", VA = "0x1857878")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD75F0", Offset = "0xAD75F0")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7628", Offset = "0xAD7628")]
			public float multiplier;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7660", Offset = "0xAD7660")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1857814", Offset = "0x1857814", VA = "0x1857814")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1857868", Offset = "0x1857868", VA = "0x1857868")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD313C", Offset = "0xAD313C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3174", Offset = "0xAD3174")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD31AC", Offset = "0xAD31AC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD31E4", Offset = "0xAD31E4")]
		private float <length>k__BackingField;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD31F4", Offset = "0xAD31F4")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004E")]
		public float length
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1C41CD0", Offset = "0x1C41CD0", VA = "0x1C41CD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA19C", Offset = "0xADA19C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x1C41CD8", Offset = "0x1C41CD8", VA = "0x1C41CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA1AC", Offset = "0xADA1AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1C41CE0", Offset = "0x1C41CE0", VA = "0x1C41CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA1BC", Offset = "0xADA1BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1C41CE8", Offset = "0x1C41CE8", VA = "0x1C41CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA1CC", Offset = "0xADA1CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1C41F10", Offset = "0x1C41F10", VA = "0x1C41F10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1C411B8", Offset = "0x1C411B8", VA = "0x1C411B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1C41B08", Offset = "0x1C41B08", VA = "0x1C41B08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA04C", Offset = "0xADA04C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1C41B54", Offset = "0x1C41B54", VA = "0x1C41B54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA084", Offset = "0xADA084")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1C41BA0", Offset = "0x1C41BA0", VA = "0x1C41BA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA0BC", Offset = "0xADA0BC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1C41BEC", Offset = "0x1C41BEC", VA = "0x1C41BEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA0F4", Offset = "0xADA0F4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1C41C38", Offset = "0x1C41C38", VA = "0x1C41C38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA12C", Offset = "0xADA12C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1C41C84", Offset = "0x1C41C84", VA = "0x1C41C84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA164", Offset = "0xADA164")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1C41CF0", Offset = "0x1C41CF0", VA = "0x1C41CF0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1C41FA0", Offset = "0x1C41FA0", VA = "0x1C41FA0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1C3FDA0", Offset = "0x1C3FDA0", VA = "0x1C3FDA0")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1C4212C", Offset = "0x1C4212C", VA = "0x1C4212C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1C3FC44", Offset = "0x1C3FC44", VA = "0x1C3FC44")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1C3FD98", Offset = "0x1C3FD98", VA = "0x1C3FD98")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1C4052C", Offset = "0x1C4052C", VA = "0x1C4052C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1C40DC8", Offset = "0x1C40DC8", VA = "0x1C40DC8")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1C42800", Offset = "0x1C42800", VA = "0x1C42800")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1C421AC", Offset = "0x1C421AC", VA = "0x1C421AC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1C42134", Offset = "0x1C42134", VA = "0x1C42134")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1C42790", Offset = "0x1C42790", VA = "0x1C42790")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1C42804", Offset = "0x1C42804", VA = "0x1C42804")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1C42874", Offset = "0x1C42874", VA = "0x1C42874")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA1DC", Offset = "0xADA1DC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1C428C0", Offset = "0x1C428C0", VA = "0x1C428C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA214", Offset = "0xADA214")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1C4290C", Offset = "0x1C4290C", VA = "0x1C4290C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0718", Offset = "0xAD0718")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0718", Offset = "0xAD0718")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000AF")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3204", Offset = "0xAD3204")]
		public string targetTag;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD323C", Offset = "0xAD323C")]
		public float fadeInTime;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3274", Offset = "0xAD3274")]
		public float speed;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD32AC", Offset = "0xAD32AC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD32E4", Offset = "0xAD32E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD32E4", Offset = "0xAD32E4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAD32E4", Offset = "0xAD32E4")]
		public Collider characterCollider;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3368", Offset = "0xAD3368")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAD3368", Offset = "0xAD3368")]
		public Transform FPSCamera;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD33C8", Offset = "0xAD33C8")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3400", Offset = "0xAD3400")]
		public float camRaycastDistance;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD3438", Offset = "0xAD3438")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAD3448", Offset = "0xAD3448")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3448", Offset = "0xAD3448")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD34A8", Offset = "0xAD34A8")]
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
			[Address(RVA = "0x1857A48", Offset = "0x1857A48", VA = "0x1857A48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1859874", Offset = "0x1859874", VA = "0x1859874")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x185987C", Offset = "0x185987C", VA = "0x185987C")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1859884", Offset = "0x1859884", VA = "0x1859884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA39C", Offset = "0xADA39C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x185988C", Offset = "0x185988C", VA = "0x185988C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADA3AC", Offset = "0xADA3AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1857880", Offset = "0x1857880", VA = "0x1857880")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA24C", Offset = "0xADA24C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x18578CC", Offset = "0x18578CC", VA = "0x18578CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA284", Offset = "0xADA284")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1857918", Offset = "0x1857918", VA = "0x1857918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA2BC", Offset = "0xADA2BC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1857964", Offset = "0x1857964", VA = "0x1857964")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA2F4", Offset = "0xADA2F4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x18579B0", Offset = "0x18579B0", VA = "0x18579B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA32C", Offset = "0xADA32C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x18579FC", Offset = "0x18579FC", VA = "0x18579FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA364", Offset = "0xADA364")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1857BF4", Offset = "0x1857BF4", VA = "0x1857BF4")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1857CD0", Offset = "0x1857CD0", VA = "0x1857CD0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1857DAC", Offset = "0x1857DAC", VA = "0x1857DAC")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1857E78", Offset = "0x1857E78", VA = "0x1857E78")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1857F88", Offset = "0x1857F88", VA = "0x1857F88")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x18580B4", Offset = "0x18580B4", VA = "0x18580B4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1858154", Offset = "0x1858154", VA = "0x1858154")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x18581F4", Offset = "0x18581F4", VA = "0x18581F4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1858294", Offset = "0x1858294", VA = "0x1858294")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1858314", Offset = "0x1858314", VA = "0x1858314")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1858394", Offset = "0x1858394", VA = "0x1858394")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1858408", Offset = "0x1858408", VA = "0x1858408")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x185849C", Offset = "0x185849C", VA = "0x185849C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x185853C", Offset = "0x185853C", VA = "0x185853C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x185861C", Offset = "0x185861C", VA = "0x185861C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x18588CC", Offset = "0x18588CC", VA = "0x18588CC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1858AB4", Offset = "0x1858AB4", VA = "0x1858AB4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1858D48", Offset = "0x1858D48", VA = "0x1858D48")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1859054", Offset = "0x1859054", VA = "0x1859054")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x18590A0", Offset = "0x18590A0", VA = "0x18590A0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1859128", Offset = "0x1859128", VA = "0x1859128")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1859254", Offset = "0x1859254", VA = "0x1859254")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x18593CC", Offset = "0x18593CC", VA = "0x18593CC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x185968C", Offset = "0x185968C", VA = "0x185968C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1858E50", Offset = "0x1858E50", VA = "0x1858E50")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1859894", Offset = "0x1859894", VA = "0x1859894")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1859F70", Offset = "0x1859F70", VA = "0x1859F70")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1859F94", Offset = "0x1859F94", VA = "0x1859F94")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1859FB4", Offset = "0x1859FB4", VA = "0x1859FB4")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1859FD4", Offset = "0x1859FD4", VA = "0x1859FD4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x185A040", Offset = "0x185A040", VA = "0x185A040")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x185A160", Offset = "0x185A160", VA = "0x185A160")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x185A260", Offset = "0x185A260", VA = "0x185A260")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x185A5D0", Offset = "0x185A5D0", VA = "0x185A5D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x185A6BC", Offset = "0x185A6BC", VA = "0x185A6BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x185A91C", Offset = "0x185A91C", VA = "0x185A91C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1859CE0", Offset = "0x1859CE0", VA = "0x1859CE0")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x185AA5C", Offset = "0x185AA5C", VA = "0x185AA5C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x185AB94", Offset = "0x185AB94", VA = "0x185AB94")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x185AC40", Offset = "0x185AC40", VA = "0x185AC40")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x185AD38", Offset = "0x185AD38", VA = "0x185AD38")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x185AD54", Offset = "0x185AD54", VA = "0x185AD54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1857B14", Offset = "0x1857B14", VA = "0x1857B14")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x18587C8", Offset = "0x18587C8", VA = "0x18587C8")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x185B05C", Offset = "0x185B05C", VA = "0x185B05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA3BC", Offset = "0xADA3BC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x185B0A8", Offset = "0x185B0A8", VA = "0x185B0A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA3F4", Offset = "0xADA3F4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x185B0F4", Offset = "0x185B0F4", VA = "0x185B0F4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD0778", Offset = "0xAD0778")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0778", Offset = "0xAD0778")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public class Multiplier
		{
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7698", Offset = "0xAD7698")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD76D0", Offset = "0xAD76D0")]
			public float multiplier;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x185C54C", Offset = "0x185C54C", VA = "0x185C54C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD34E0", Offset = "0xAD34E0")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3518", Offset = "0xAD3518")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3550", Offset = "0xAD3550")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3588", Offset = "0xAD3588")]
		public Transform pivot;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD35C0", Offset = "0xAD35C0")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD35F8", Offset = "0xAD35F8")]
		public float twistWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3630", Offset = "0xAD3630")]
		public float swingWeight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3668", Offset = "0xAD3668")]
		public bool rotateOnce;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x185BA9C", Offset = "0x185BA9C", VA = "0x185BA9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA42C", Offset = "0xADA42C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x185BAE8", Offset = "0x185BAE8", VA = "0x185BAE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA464", Offset = "0xADA464")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x185BB34", Offset = "0x185BB34", VA = "0x185BB34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA49C", Offset = "0xADA49C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x185BB80", Offset = "0x185BB80", VA = "0x185BB80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA4D4", Offset = "0xADA4D4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x185BBCC", Offset = "0x185BBCC", VA = "0x185BBCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA50C", Offset = "0xADA50C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x185BC18", Offset = "0x185BC18", VA = "0x185BC18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA544", Offset = "0xADA544")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x185BC64", Offset = "0x185BC64", VA = "0x185BC64")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x185BCDC", Offset = "0x185BCDC", VA = "0x185BCDC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x185BD78", Offset = "0x185BD78", VA = "0x185BD78")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x185C428", Offset = "0x185C428", VA = "0x185C428")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA57C", Offset = "0xADA57C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x185C474", Offset = "0x185C474", VA = "0x185C474")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA5B4", Offset = "0xADA5B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x185C4C0", Offset = "0x185C4C0", VA = "0x185C4C0")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD07D8", Offset = "0xAD07D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD07D8", Offset = "0xAD07D8")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class CharacterPosition
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7708", Offset = "0xAD7708")]
			public bool use;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7740", Offset = "0xAD7740")]
			public Vector2 offset;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7778", Offset = "0xAD7778")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD7778", Offset = "0xAD7778")]
			public float angleOffset;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD77D4", Offset = "0xAD77D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD77D4", Offset = "0xAD77D4")]
			public float maxAngle;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD782C", Offset = "0xAD782C")]
			public float radius;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7864", Offset = "0xAD7864")]
			public bool orbit;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD789C", Offset = "0xAD789C")]
			public bool fixYAxis;

			[Token(Token = "0x170000DE")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x185CCE0", Offset = "0x185CCE0", VA = "0x185CCE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DF")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x185CD1C", Offset = "0x185CD1C", VA = "0x185CD1C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x185CE14", Offset = "0x185CE14", VA = "0x185CE14")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x185D494", Offset = "0x185D494", VA = "0x185D494")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD78D4", Offset = "0xAD78D4")]
			public Collider lookAtTarget;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD790C", Offset = "0xAD790C")]
			public Vector3 direction;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7944", Offset = "0xAD7944")]
			public float maxDistance;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD797C", Offset = "0xAD797C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD797C", Offset = "0xAD797C")]
			public float maxAngle;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD79D4", Offset = "0xAD79D4")]
			public bool fixYAxis;

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x185C7C8", Offset = "0x185C7C8", VA = "0x185C7C8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x185C970", Offset = "0x185C970", VA = "0x185C970")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x185CC54", Offset = "0x185CC54", VA = "0x185CC54")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8A8C", Offset = "0xAD8A8C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8AC4", Offset = "0xAD8AC4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000736")]
				[Address(RVA = "0x185D4B8", Offset = "0x185D4B8", VA = "0x185D4B8")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7A0C", Offset = "0xAD7A0C")]
			[SerializeField]
			public string name;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD7A44", Offset = "0xAD7A44")]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7A7C", Offset = "0xAD7A7C")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7AB4", Offset = "0xAD7AB4")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7AEC", Offset = "0xAD7AEC")]
			public Interaction[] interactions;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x185C63C", Offset = "0x185C63C", VA = "0x185C63C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x185D4A8", Offset = "0x185D4A8", VA = "0x185D4A8")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD36A0", Offset = "0xAD36A0")]
		public Range[] ranges;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x185C554", Offset = "0x185C554", VA = "0x185C554")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA5EC", Offset = "0xADA5EC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x185C5A0", Offset = "0x185C5A0", VA = "0x185C5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA624", Offset = "0xADA624")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x185C5EC", Offset = "0x185C5EC", VA = "0x185C5EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA65C", Offset = "0xADA65C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x185C638", Offset = "0x185C638", VA = "0x185C638")]
		private void Start()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x185A40C", Offset = "0x185A40C", VA = "0x185A40C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x185C768", Offset = "0x185C768", VA = "0x185C768")]
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
			[Address(RVA = "0x18FB0C0", Offset = "0x18FB0C0", VA = "0x18FB0C0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x18FB4E0", Offset = "0x18FB4E0", VA = "0x18FB4E0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x18FB494", Offset = "0x18FB494", VA = "0x18FB494")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x18FB280", Offset = "0x18FB280", VA = "0x18FB280")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x18FADC4", Offset = "0x18FADC4", VA = "0x18FADC4", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA694", Offset = "0xADA694")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x18FB16C", Offset = "0x18FB16C", VA = "0x18FB16C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x18FB170", Offset = "0x18FB170", VA = "0x18FB170", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x18FB424", Offset = "0x18FB424", VA = "0x18FB424", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x18FB0FC", Offset = "0x18FB0FC", VA = "0x18FB0FC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x18FB014", Offset = "0x18FB014", VA = "0x18FB014")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x18FB530", Offset = "0x18FB530", VA = "0x18FB530")]
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
		[Address(RVA = "0x19053B4", Offset = "0x19053B4", VA = "0x19053B4", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1905468", Offset = "0x1905468", VA = "0x1905468", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1905620", Offset = "0x1905620", VA = "0x1905620", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x190570C", Offset = "0x190570C", VA = "0x190570C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x19054C4", Offset = "0x19054C4", VA = "0x19054C4")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1905AD4", Offset = "0x1905AD4", VA = "0x1905AD4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD36D8", Offset = "0xAD36D8")]
		public float weight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD36F0", Offset = "0xAD36F0")]
		public float localRotationWeight;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD3708", Offset = "0xAD3708")]
		public float localPositionWeight;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60003FC")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x18601EC", Offset = "0x18601EC", VA = "0x18601EC")]
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
		[Address(RVA = "0x18601F8", Offset = "0x18601F8", VA = "0x18601F8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x186024C", Offset = "0x186024C", VA = "0x186024C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1860288", Offset = "0x1860288", VA = "0x1860288", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x18602A0", Offset = "0x18602A0", VA = "0x18602A0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAD0838", Offset = "0xAD0838")]
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
			[Address(RVA = "0x1860838", Offset = "0x1860838", VA = "0x1860838")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x186148C", Offset = "0x186148C", VA = "0x186148C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1861268", Offset = "0x1861268", VA = "0x1861268")]
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
			[Address(RVA = "0x1860998", Offset = "0x1860998", VA = "0x1860998")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1861624", Offset = "0x1861624", VA = "0x1861624")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x18615D4", Offset = "0x18615D4", VA = "0x18615D4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0B68", Offset = "0xAD0B68")]
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
				[Address(RVA = "0x1861C08", Offset = "0x1861C08", VA = "0x1861C08", Slot = "4")]
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
				[Address(RVA = "0x1861C74", Offset = "0x1861C74", VA = "0x1861C74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x18609FC", Offset = "0x18609FC", VA = "0x18609FC")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x18619C0", Offset = "0x18619C0", VA = "0x18619C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x18619C4", Offset = "0x18619C4", VA = "0x18619C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1861C10", Offset = "0x1861C10", VA = "0x1861C10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3720", Offset = "0xAD3720")]
		public IK ik;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3758", Offset = "0xAD3758")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3790", Offset = "0xAD3790")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD37C8", Offset = "0xAD37C8")]
		public float applyVelocity;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3800", Offset = "0xAD3800")]
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
			[Address(RVA = "0x1860300", Offset = "0x1860300", VA = "0x1860300")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool ikUsed
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1860E00", Offset = "0x1860E00", VA = "0x1860E00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x18602C8", Offset = "0x18602C8", VA = "0x18602C8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1860384", Offset = "0x1860384", VA = "0x1860384")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x18604C4", Offset = "0x18604C4", VA = "0x18604C4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1860450", Offset = "0x1860450", VA = "0x1860450")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADA6CC", Offset = "0xADA6CC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1860A28", Offset = "0x1860A28", VA = "0x1860A28")]
		private void Update()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1860C80", Offset = "0x1860C80", VA = "0x1860C80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1860D44", Offset = "0x1860D44", VA = "0x1860D44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1860F90", Offset = "0x1860F90", VA = "0x1860F90")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1860DC4", Offset = "0x1860DC4", VA = "0x1860DC4")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1860F4C", Offset = "0x1860F4C", VA = "0x1860F4C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1861038", Offset = "0x1861038", VA = "0x1861038")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1860FC4", Offset = "0x1860FC4", VA = "0x1860FC4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x18603DC", Offset = "0x18603DC", VA = "0x18603DC")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1860CC0", Offset = "0x1860CC0", VA = "0x1860CC0")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x18617F0", Offset = "0x18617F0", VA = "0x18617F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x18618F4", Offset = "0x18618F4", VA = "0x18618F4")]
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
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD3838", Offset = "0xAD3838")]
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
			[Address(RVA = "0x186362C", Offset = "0x186362C", VA = "0x186362C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1863668", Offset = "0x1863668", VA = "0x1863668")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x18632A8", Offset = "0x18632A8", VA = "0x18632A8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x18632EC", Offset = "0x18632EC", VA = "0x18632EC")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x186357C", Offset = "0x186357C", VA = "0x186357C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x18635F4", Offset = "0x18635F4", VA = "0x18635F4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600041D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x186348C", Offset = "0x186348C", VA = "0x186348C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1863738", Offset = "0x1863738", VA = "0x1863738")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x186373C", Offset = "0x186373C", VA = "0x186373C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x186376C", Offset = "0x186376C", VA = "0x186376C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1863850", Offset = "0x1863850", VA = "0x1863850")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1863AD0", Offset = "0x1863AD0", VA = "0x1863AD0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1863B8C", Offset = "0x1863B8C", VA = "0x1863B8C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD089C", Offset = "0xAD089C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD089C", Offset = "0xAD089C")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD3848", Offset = "0xAD3848")]
		public float limit;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD3864", Offset = "0xAD3864")]
		public float twistLimit;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1863C04", Offset = "0x1863C04", VA = "0x1863C04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA730", Offset = "0xADA730")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1863C50", Offset = "0x1863C50", VA = "0x1863C50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA768", Offset = "0xADA768")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1863C9C", Offset = "0x1863C9C", VA = "0x1863C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA7A0", Offset = "0xADA7A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1863CE8", Offset = "0x1863CE8", VA = "0x1863CE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA7D8", Offset = "0xADA7D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1863D34", Offset = "0x1863D34", VA = "0x1863D34", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1863DEC", Offset = "0x1863DEC", VA = "0x1863DEC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1864034", Offset = "0x1864034", VA = "0x1864034")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD08FC", Offset = "0xAD08FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD08FC", Offset = "0xAD08FC")]
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
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD3880", Offset = "0xAD3880")]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1864044", Offset = "0x1864044", VA = "0x1864044")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA810", Offset = "0xADA810")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1864090", Offset = "0x1864090", VA = "0x1864090")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA848", Offset = "0xADA848")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x18640DC", Offset = "0x18640DC", VA = "0x18640DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA880", Offset = "0xADA880")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1864128", Offset = "0x1864128", VA = "0x1864128")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA8B8", Offset = "0xADA8B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1864174", Offset = "0x1864174", VA = "0x1864174", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x186419C", Offset = "0x186419C", VA = "0x186419C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x186449C", Offset = "0x186449C", VA = "0x186449C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD095C", Offset = "0xAD095C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD095C", Offset = "0xAD095C")]
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
				[Address(RVA = "0x1866428", Offset = "0x1866428", VA = "0x1866428")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E3")]
			public Vector3 a
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x1866468", Offset = "0x1866468", VA = "0x1866468")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E4")]
			public Vector3 b
			{
				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x18664AC", Offset = "0x18664AC", VA = "0x18664AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E5")]
			public Vector3 c
			{
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x18664F0", Offset = "0x18664F0", VA = "0x18664F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E6")]
			public bool isValid
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x1865598", Offset = "0x1865598", VA = "0x1865598")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1865BE0", Offset = "0x1865BE0", VA = "0x1865BE0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1865D4C", Offset = "0x1865D4C", VA = "0x1865D4C")]
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
			[Address(RVA = "0x18655A8", Offset = "0x18655A8", VA = "0x18655A8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD3890", Offset = "0xAD3890")]
		public float twistLimit;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD38AC", Offset = "0xAD38AC")]
		public int smoothIterations;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD38C4", Offset = "0xAD38C4")]
		public LimitPoint[] points;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD38FC", Offset = "0xAD38FC")]
		public Vector3[] P;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD3934", Offset = "0xAD3934")]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1864524", Offset = "0x1864524", VA = "0x1864524")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA8F0", Offset = "0xADA8F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1864570", Offset = "0x1864570", VA = "0x1864570")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA928", Offset = "0xADA928")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x18645BC", Offset = "0x18645BC", VA = "0x18645BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA960", Offset = "0xADA960")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1864608", Offset = "0x1864608", VA = "0x1864608")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA998", Offset = "0xADA998")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1864654", Offset = "0x1864654", VA = "0x1864654")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1864B24", Offset = "0x1864B24", VA = "0x1864B24", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1864C20", Offset = "0x1864C20", VA = "0x1864C20")]
		private void Start()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x18651E0", Offset = "0x18651E0", VA = "0x18651E0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x18646F4", Offset = "0x18646F4", VA = "0x18646F4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x186562C", Offset = "0x186562C", VA = "0x186562C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1865F0C", Offset = "0x1865F0C", VA = "0x1865F0C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1865F50", Offset = "0x1865F50", VA = "0x1865F50")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1866098", Offset = "0x1866098", VA = "0x1866098")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1864EA0", Offset = "0x1864EA0", VA = "0x1864EA0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1866228", Offset = "0x1866228", VA = "0x1866228")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x18663C4", Offset = "0x18663C4", VA = "0x18663C4")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xAD09BC", Offset = "0xAD09BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD09BC", Offset = "0xAD09BC")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD396C", Offset = "0xAD396C")]
		public float twistLimit;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD3988", Offset = "0xAD3988")]
		public AnimationCurve spline;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1866534", Offset = "0x1866534", VA = "0x1866534")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADA9D0", Offset = "0xADA9D0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1866580", Offset = "0x1866580", VA = "0x1866580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADAA08", Offset = "0xADAA08")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x18665CC", Offset = "0x18665CC", VA = "0x18665CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADAA40", Offset = "0xADAA40")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1866618", Offset = "0x1866618", VA = "0x1866618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xADAA78", Offset = "0xADAA78")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1866664", Offset = "0x1866664", VA = "0x1866664")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1866680", Offset = "0x1866680", VA = "0x1866680", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1866738", Offset = "0x1866738", VA = "0x1866738")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1866A64", Offset = "0x1866A64", VA = "0x1866A64")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0B78", Offset = "0xAD0B78")]
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
				[Address(RVA = "0x17CF524", Offset = "0x17CF524", VA = "0x17CF524", Slot = "4")]
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
				[Address(RVA = "0x17CF590", Offset = "0x17CF590", VA = "0x17CF590", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x17CF304", Offset = "0x17CF304", VA = "0x17CF304")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x17CF3FC", Offset = "0x17CF3FC", VA = "0x17CF3FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x17CF400", Offset = "0x17CF400", VA = "0x17CF400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x17CF52C", Offset = "0x17CF52C", VA = "0x17CF52C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD39C0", Offset = "0xAD39C0")]
		public AimIK ik;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD39F8", Offset = "0xAD39F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD39F8", Offset = "0xAD39F8")]
		public float weight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD3A4C", Offset = "0xAD3A4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3A4C", Offset = "0xAD3A4C")]
		public Transform target;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3AAC", Offset = "0xAD3AAC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3AE4", Offset = "0xAD3AE4")]
		public float weightSmoothTime;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD3B1C", Offset = "0xAD3B1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3B1C", Offset = "0xAD3B1C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3B7C", Offset = "0xAD3B7C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3BB4", Offset = "0xAD3BB4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3BEC", Offset = "0xAD3BEC")]
		public float slerpSpeed;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3C24", Offset = "0xAD3C24")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3C5C", Offset = "0xAD3C5C")]
		public float minDistance;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3C94", Offset = "0xAD3C94")]
		public Vector3 offset;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD3CCC", Offset = "0xAD3CCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3CCC", Offset = "0xAD3CCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD3CCC", Offset = "0xAD3CCC")]
		public float maxRootAngle;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3D48", Offset = "0xAD3D48")]
		public bool turnToTarget;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3D80", Offset = "0xAD3D80")]
		public float turnToTargetTime;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD3DB8", Offset = "0xAD3DB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3DB8", Offset = "0xAD3DB8")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3E18", Offset = "0xAD3E18")]
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
			[Address(RVA = "0x17CE50C", Offset = "0x17CE50C", VA = "0x17CE50C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x17CE40C", Offset = "0x17CE40C", VA = "0x17CE40C")]
		private void Start()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x17CE658", Offset = "0x17CE658", VA = "0x17CE658")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x17CED7C", Offset = "0x17CED7C", VA = "0x17CED7C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x17CEF1C", Offset = "0x17CEF1C", VA = "0x17CEF1C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x17CF290", Offset = "0x17CF290", VA = "0x17CF290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADAAB0", Offset = "0xADAAB0")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x17CF330", Offset = "0x17CF330", VA = "0x17CF330")]
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
			[Address(RVA = "0x18EC380", Offset = "0x18EC380", VA = "0x18EC380")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x18EC6F4", Offset = "0x18EC6F4", VA = "0x18EC6F4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x18EC6FC", Offset = "0x18EC6FC", VA = "0x18EC6FC")]
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
		[Address(RVA = "0x18EC298", Offset = "0x18EC298", VA = "0x18EC298")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x18EC61C", Offset = "0x18EC61C", VA = "0x18EC61C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x18EC68C", Offset = "0x18EC68C", VA = "0x18EC68C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8AFC", Offset = "0xAD8AFC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8B34", Offset = "0xAD8B34")]
				public float weight;

				[Token(Token = "0x6000737")]
				[Address(RVA = "0x18ECD0C", Offset = "0x18ECD0C", VA = "0x18ECD0C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7B24", Offset = "0xAD7B24")]
			public Transform transform;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7B5C", Offset = "0xAD7B5C")]
			public Transform relativeTo;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7B94", Offset = "0xAD7B94")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7BCC", Offset = "0xAD7BCC")]
			public float verticalWeight;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7C04", Offset = "0xAD7C04")]
			public float horizontalWeight;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7C3C", Offset = "0xAD7C3C")]
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
			[Address(RVA = "0x18EC860", Offset = "0x18EC860", VA = "0x18EC860")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x18ECCE4", Offset = "0x18ECCE4", VA = "0x18ECCE4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x18ECCF4", Offset = "0x18ECCF4", VA = "0x18ECCF4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3E50", Offset = "0xAD3E50")]
		public Body[] bodies;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x18EC718", Offset = "0x18EC718", VA = "0x18EC718", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x18ECCDC", Offset = "0x18ECCDC", VA = "0x18ECCDC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3E88", Offset = "0xAD3E88")]
		public float tiltSpeed;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3EC0", Offset = "0xAD3EC0")]
		public float tiltSensitivity;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3EF8", Offset = "0xAD3EF8")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3F30", Offset = "0xAD3F30")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x18EE2B0", Offset = "0x18EE2B0", VA = "0x18EE2B0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x18EE2F8", Offset = "0x18EE2F8", VA = "0x18EE2F8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x18EE530", Offset = "0x18EE530", VA = "0x18EE530")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7C74", Offset = "0xAD7C74")]
			public string name;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7CAC", Offset = "0xAD7CAC")]
			public Collider collider;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7CE4", Offset = "0xAD7CE4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7D30", Offset = "0xAD7D30")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7D40", Offset = "0xAD7D40")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7D50", Offset = "0xAD7D50")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7D60", Offset = "0xAD7D60")]
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
				[Address(RVA = "0x1C4396C", Offset = "0x1C4396C", VA = "0x1C4396C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EA")]
			protected float crossFader
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x1C43980", Offset = "0x1C43980", VA = "0x1C43980")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB224", Offset = "0xADB224")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x1C43988", Offset = "0x1C43988", VA = "0x1C43988")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB234", Offset = "0xADB234")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			protected float timer
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x1C43990", Offset = "0x1C43990", VA = "0x1C43990")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB244", Offset = "0xADB244")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x1C43998", Offset = "0x1C43998", VA = "0x1C43998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB254", Offset = "0xADB254")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EC")]
			protected Vector3 force
			{
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x1C439A0", Offset = "0x1C439A0", VA = "0x1C439A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB264", Offset = "0xADB264")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x1C439AC", Offset = "0x1C439AC", VA = "0x1C439AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB274", Offset = "0xADB274")]
				private set
				{
				}
			}

			[Token(Token = "0x170000ED")]
			protected Vector3 point
			{
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x1C439B8", Offset = "0x1C439B8", VA = "0x1C439B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB284", Offset = "0xADB284")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x1C439C4", Offset = "0x1C439C4", VA = "0x1C439C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB294", Offset = "0xADB294")]
				private set
				{
				}
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1C439D0", Offset = "0x1C439D0", VA = "0x1C439D0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1C43AFC", Offset = "0x1C43AFC", VA = "0x1C43AFC")]
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
			[Address(RVA = "0x1C43C48", Offset = "0x1C43C48", VA = "0x1C43C48")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8B6C", Offset = "0xAD8B6C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8BA4", Offset = "0xAD8BA4")]
				public float weight;

				[Token(Token = "0x400068E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400068F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000738")]
				[Address(RVA = "0x1C44618", Offset = "0x1C44618", VA = "0x1C44618")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000739")]
				[Address(RVA = "0x1C44404", Offset = "0x1C44404", VA = "0x1C44404")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600073A")]
				[Address(RVA = "0x1C4489C", Offset = "0x1C4489C", VA = "0x1C4489C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7D70", Offset = "0xAD7D70")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7DA8", Offset = "0xAD7DA8")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7DE0", Offset = "0xAD7DE0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x1C4420C", Offset = "0x1C4420C", VA = "0x1C4420C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x1C44390", Offset = "0x1C44390", VA = "0x1C44390", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1C44418", Offset = "0x1C44418", VA = "0x1C44418", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1C44740", Offset = "0x1C44740", VA = "0x1C44740")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8BDC", Offset = "0xAD8BDC")]
				public Transform bone;

				[Token(Token = "0x4000691")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8C14", Offset = "0xAD8C14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD8C14", Offset = "0xAD8C14")]
				public float weight;

				[Token(Token = "0x4000692")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000693")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600073B")]
				[Address(RVA = "0x1C44010", Offset = "0x1C44010", VA = "0x1C44010")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600073C")]
				[Address(RVA = "0x1C43D88", Offset = "0x1C43D88", VA = "0x1C43D88")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600073D")]
				[Address(RVA = "0x1C44184", Offset = "0x1C44184", VA = "0x1C44184")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7E18", Offset = "0xAD7E18")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7E50", Offset = "0xAD7E50")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1C43C5C", Offset = "0x1C43C5C", VA = "0x1C43C5C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1C43D0C", Offset = "0x1C43D0C", VA = "0x1C43D0C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x1C43DA4", Offset = "0x1C43DA4", VA = "0x1C43DA4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x1C44170", Offset = "0x1C44170", VA = "0x1C44170")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3F68", Offset = "0xAD3F68")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3FA0", Offset = "0xAD3FA0")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005A")]
		public bool inProgress
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1905ADC", Offset = "0x1905ADC", VA = "0x1905ADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1905BB8", Offset = "0x1905BB8", VA = "0x1905BB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1905C9C", Offset = "0x1905C9C", VA = "0x1905C9C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1905EEC", Offset = "0x1905EEC", VA = "0x1905EEC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7E88", Offset = "0xAD7E88")]
			public string name;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7EC0", Offset = "0xAD7EC0")]
			public Collider collider;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7EF8", Offset = "0xAD7EF8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7F44", Offset = "0xAD7F44")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7F54", Offset = "0xAD7F54")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7F64", Offset = "0xAD7F64")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD7F74", Offset = "0xAD7F74")]
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
				[Address(RVA = "0x1C44E68", Offset = "0x1C44E68", VA = "0x1C44E68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB2A4", Offset = "0xADB2A4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x1C44E70", Offset = "0x1C44E70", VA = "0x1C44E70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB2B4", Offset = "0xADB2B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EF")]
			protected float timer
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x1C44E78", Offset = "0x1C44E78", VA = "0x1C44E78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB2C4", Offset = "0xADB2C4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x1C44E80", Offset = "0x1C44E80", VA = "0x1C44E80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB2D4", Offset = "0xADB2D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F0")]
			protected Vector3 force
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1C44E88", Offset = "0x1C44E88", VA = "0x1C44E88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB2E4", Offset = "0xADB2E4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x1C44E94", Offset = "0x1C44E94", VA = "0x1C44E94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB2F4", Offset = "0xADB2F4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F1")]
			protected Vector3 point
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x1C44EA0", Offset = "0x1C44EA0", VA = "0x1C44EA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB304", Offset = "0xADB304")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0x1C44EAC", Offset = "0x1C44EAC", VA = "0x1C44EAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADB314", Offset = "0xADB314")]
				private set
				{
				}
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x1C44D20", Offset = "0x1C44D20", VA = "0x1C44D20")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1C4497C", Offset = "0x1C4497C", VA = "0x1C4497C")]
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
			[Address(RVA = "0x1C44EB8", Offset = "0x1C44EB8", VA = "0x1C44EB8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8C68", Offset = "0xAD8C68")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000695")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8CA0", Offset = "0xAD8CA0")]
				public float weight;

				[Token(Token = "0x4000696")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000697")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600073E")]
				[Address(RVA = "0x1C45390", Offset = "0x1C45390", VA = "0x1C45390")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600073F")]
				[Address(RVA = "0x1C45144", Offset = "0x1C45144", VA = "0x1C45144")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000740")]
				[Address(RVA = "0x1C454B0", Offset = "0x1C454B0", VA = "0x1C454B0")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7F84", Offset = "0xAD7F84")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7FBC", Offset = "0xAD7FBC")]
			public int upDirCurveIndex;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD7FF4", Offset = "0xAD7FF4")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1C44ECC", Offset = "0x1C44ECC", VA = "0x1C44ECC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1C450D0", Offset = "0x1C450D0", VA = "0x1C450D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1C45158", Offset = "0x1C45158", VA = "0x1C45158", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1C45494", Offset = "0x1C45494", VA = "0x1C45494")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8CD8", Offset = "0xAD8CD8")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000699")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8D10", Offset = "0xAD8D10")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD8D10", Offset = "0xAD8D10")]
				public float weight;

				[Token(Token = "0x400069A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400069B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000741")]
				[Address(RVA = "0x1C4595C", Offset = "0x1C4595C", VA = "0x1C4595C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000742")]
				[Address(RVA = "0x1C45624", Offset = "0x1C45624", VA = "0x1C45624")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000743")]
				[Address(RVA = "0x1C45A9C", Offset = "0x1C45A9C", VA = "0x1C45A9C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD802C", Offset = "0xAD802C")]
			public int curveIndex;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8064", Offset = "0xAD8064")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1C454B8", Offset = "0x1C454B8", VA = "0x1C454B8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1C455A8", Offset = "0x1C455A8", VA = "0x1C455A8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1C45640", Offset = "0x1C45640", VA = "0x1C45640", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x1C45A88", Offset = "0x1C45A88", VA = "0x1C45A88")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD3FD8", Offset = "0xAD3FD8")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4010", Offset = "0xAD4010")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1C448A4", Offset = "0x1C448A4", VA = "0x1C448A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1C44AD0", Offset = "0x1C44AD0", VA = "0x1C44AD0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1C44E60", Offset = "0x1C44E60", VA = "0x1C44E60")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8D64", Offset = "0xAD8D64")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400069D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8D9C", Offset = "0xAD8D9C")]
				public float weight;

				[Token(Token = "0x6000744")]
				[Address(RVA = "0x1C3EF64", Offset = "0x1C3EF64", VA = "0x1C3EF64")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD809C", Offset = "0xAD809C")]
			public Transform transform;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD80D4", Offset = "0xAD80D4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD810C", Offset = "0xAD810C")]
			public float speed;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8144", Offset = "0xAD8144")]
			public float acceleration;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD817C", Offset = "0xAD817C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD817C", Offset = "0xAD817C")]
			public float matchVelocity;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD81D0", Offset = "0xAD81D0")]
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
			[Address(RVA = "0x1C3EA18", Offset = "0x1C3EA18", VA = "0x1C3EA18")]
			public void Reset()
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1C3EBB8", Offset = "0x1C3EBB8", VA = "0x1C3EBB8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1C3EF48", Offset = "0x1C3EF48", VA = "0x1C3EF48")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4048", Offset = "0xAD4048")]
		public Body[] bodies;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4080", Offset = "0xAD4080")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1C3E994", Offset = "0x1C3E994", VA = "0x1C3E994")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1C3EAF4", Offset = "0x1C3EAF4", VA = "0x1C3EAF4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1C3EF40", Offset = "0x1C3EF40", VA = "0x1C3EF40")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD40B8", Offset = "0xAD40B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD40B8", Offset = "0xAD40B8")]
		public Transform target;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4118", Offset = "0xAD4118")]
		public float weight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4130", Offset = "0xAD4130")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4168", Offset = "0xAD4168")]
		public float weightSmoothTime;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD41A0", Offset = "0xAD41A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD41A0", Offset = "0xAD41A0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4200", Offset = "0xAD4200")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4238", Offset = "0xAD4238")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4270", Offset = "0xAD4270")]
		public float slerpSpeed;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD42A8", Offset = "0xAD42A8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD42E0", Offset = "0xAD42E0")]
		public float minDistance;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAD4318", Offset = "0xAD4318")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4318", Offset = "0xAD4318")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4318", Offset = "0xAD4318")]
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
			[Address(RVA = "0x185D92C", Offset = "0x185D92C", VA = "0x185D92C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x185D840", Offset = "0x185D840", VA = "0x185D840")]
		private void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x185DA78", Offset = "0x185DA78", VA = "0x185DA78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x185E118", Offset = "0x185E118", VA = "0x185E118")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x185E2B8", Offset = "0x185E2B8", VA = "0x185E2B8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x185E5D8", Offset = "0x185E5D8", VA = "0x185E5D8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8208", Offset = "0xAD8208")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8240", Offset = "0xAD8240")]
			public float spring;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8278", Offset = "0xAD8278")]
			public bool x;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD82B0", Offset = "0xAD82B0")]
			public bool y;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD82E8", Offset = "0xAD82E8")]
			public bool z;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8320", Offset = "0xAD8320")]
			public float minX;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8358", Offset = "0xAD8358")]
			public float maxX;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8390", Offset = "0xAD8390")]
			public float minY;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD83C8", Offset = "0xAD83C8")]
			public float maxY;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8400", Offset = "0xAD8400")]
			public float minZ;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8438", Offset = "0xAD8438")]
			public float maxZ;

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x185EAEC", Offset = "0x185EAEC", VA = "0x185EAEC")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x185F014", Offset = "0x185F014", VA = "0x185F014")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x185F044", Offset = "0x185F044", VA = "0x185F044")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x185F11C", Offset = "0x185F11C", VA = "0x185F11C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0B88", Offset = "0xAD0B88")]
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
				[Address(RVA = "0x185EFA0", Offset = "0x185EFA0", VA = "0x185EFA0", Slot = "4")]
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
				[Address(RVA = "0x185F00C", Offset = "0x185F00C", VA = "0x185F00C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x185E8F0", Offset = "0x185E8F0", VA = "0x185E8F0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x185EE5C", Offset = "0x185EE5C", VA = "0x185EE5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x185EE60", Offset = "0x185EE60", VA = "0x185EE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x185EFA8", Offset = "0x185EFA8", VA = "0x185EFA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4394", Offset = "0xAD4394")]
		public float weight;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD43CC", Offset = "0xAD43CC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700005C")]
		protected float deltaTime
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x185E824", Offset = "0x185E824", VA = "0x185E824")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600046B")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x185E850", Offset = "0x185E850", VA = "0x185E850", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x185E87C", Offset = "0x185E87C", VA = "0x185E87C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADAB14", Offset = "0xADAB14")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x185E91C", Offset = "0x185E91C", VA = "0x185E91C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x185EA28", Offset = "0x185EA28", VA = "0x185EA28")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x185ED50", Offset = "0x185ED50", VA = "0x185ED50", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x185EE4C", Offset = "0x185EE4C", VA = "0x185EE4C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0B98", Offset = "0xAD0B98")]
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
				[Address(RVA = "0x185F578", Offset = "0x185F578", VA = "0x185F578", Slot = "4")]
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
				[Address(RVA = "0x185F5E4", Offset = "0x185F5E4", VA = "0x185F5E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x185F1F0", Offset = "0x185F1F0", VA = "0x185F1F0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x185F434", Offset = "0x185F434", VA = "0x185F434", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x185F438", Offset = "0x185F438", VA = "0x185F438", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x185F580", Offset = "0x185F580", VA = "0x185F580", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4404", Offset = "0xAD4404")]
		public float weight;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD443C", Offset = "0xAD443C")]
		public VRIK ik;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700005D")]
		protected float deltaTime
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x185F124", Offset = "0x185F124", VA = "0x185F124")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000473")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x185F150", Offset = "0x185F150", VA = "0x185F150", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x185F17C", Offset = "0x185F17C", VA = "0x185F17C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADAB78", Offset = "0xADAB78")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x185F21C", Offset = "0x185F21C", VA = "0x185F21C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x185F328", Offset = "0x185F328", VA = "0x185F328", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x185F424", Offset = "0x185F424", VA = "0x185F424")]
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
			[Address(RVA = "0x185F6B0", Offset = "0x185F6B0", VA = "0x185F6B0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x185FB00", Offset = "0x185FB00", VA = "0x185FB00")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x185F5EC", Offset = "0x185F5EC", VA = "0x185F5EC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x185F9E0", Offset = "0x185F9E0", VA = "0x185F9E0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x185FAA0", Offset = "0x185FAA0", VA = "0x185FAA0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8DD4", Offset = "0xAD8DD4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400069F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8E0C", Offset = "0xAD8E0C")]
				public float weight;

				[Token(Token = "0x6000745")]
				[Address(RVA = "0x18601E4", Offset = "0x18601E4", VA = "0x18601E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8470", Offset = "0xAD8470")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD84A8", Offset = "0xAD84A8")]
			public Transform raycastTo;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD84E0", Offset = "0xAD84E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD84E0", Offset = "0xAD84E0")]
			public float raycastRadius;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8534", Offset = "0xAD8534")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD856C", Offset = "0xAD856C")]
			public float smoothTimeIn;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD85A4", Offset = "0xAD85A4")]
			public float smoothTimeOut;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD85DC", Offset = "0xAD85DC")]
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
			[Address(RVA = "0x185FB94", Offset = "0x185FB94", VA = "0x185FB94")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x185FDA8", Offset = "0x185FDA8", VA = "0x185FDA8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x185FF54", Offset = "0x185FF54", VA = "0x185FF54")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x18601C8", Offset = "0x18601C8", VA = "0x18601C8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4474", Offset = "0xAD4474")]
		public Avoider[] avoiders;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x185FB08", Offset = "0x185FB08", VA = "0x185FB08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x185FD98", Offset = "0x185FD98", VA = "0x185FD98")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8E44", Offset = "0xAD8E44")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8E7C", Offset = "0xAD8E7C")]
				public float weight;

				[Token(Token = "0x6000746")]
				[Address(RVA = "0x18632A0", Offset = "0x18632A0", VA = "0x18632A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8614", Offset = "0xAD8614")]
			public Vector3 offset;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD864C", Offset = "0xAD864C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD864C", Offset = "0xAD864C")]
			public float additivity;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD86A0", Offset = "0xAD86A0")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD86D8", Offset = "0xAD86D8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1862004", Offset = "0x1862004", VA = "0x1862004")]
			public void Start()
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1862B68", Offset = "0x1862B68", VA = "0x1862B68")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1863288", Offset = "0x1863288", VA = "0x1863288")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD44AC", Offset = "0xAD44AC")]
		public AimIK aimIK;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD44E4", Offset = "0xAD44E4")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD451C", Offset = "0xAD451C")]
		public Handedness handedness;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4554", Offset = "0xAD4554")]
		public bool twoHanded;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD458C", Offset = "0xAD458C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD45C4", Offset = "0xAD45C4")]
		public float magnitudeRandom;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD45FC", Offset = "0xAD45FC")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4634", Offset = "0xAD4634")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD466C", Offset = "0xAD466C")]
		public float blendTime;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAD46A4", Offset = "0xAD46A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD46A4", Offset = "0xAD46A4")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0xAD46F4", Offset = "0xAD46F4")]
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
			[Address(RVA = "0x1861DD0", Offset = "0x1861DD0", VA = "0x1861DD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1862E24", Offset = "0x1862E24", VA = "0x1862E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1862E68", Offset = "0x1862E68", VA = "0x1862E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1862DE4", Offset = "0x1862DE4", VA = "0x1862DE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1862E04", Offset = "0x1862E04", VA = "0x1862E04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1861E00", Offset = "0x1861E00", VA = "0x1861E00")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1861E2C", Offset = "0x1861E2C", VA = "0x1861E2C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x18620B4", Offset = "0x18620B4", VA = "0x18620B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1862EAC", Offset = "0x1862EAC", VA = "0x1862EAC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1862FF8", Offset = "0x1862FF8", VA = "0x1862FF8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1863038", Offset = "0x1863038", VA = "0x1863038", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x18631D4", Offset = "0x18631D4", VA = "0x18631D4")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4704", Offset = "0xAD4704")]
		public float weight;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD473C", Offset = "0xAD473C")]
		public float offset;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1867390", Offset = "0x1867390", VA = "0x1867390")]
		private void Start()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x186746C", Offset = "0x186746C", VA = "0x186746C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x186755C", Offset = "0x186755C", VA = "0x186755C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x18679AC", Offset = "0x18679AC", VA = "0x18679AC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x18679E8", Offset = "0x18679E8", VA = "0x18679E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1867AE4", Offset = "0x1867AE4", VA = "0x1867AE4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8710", Offset = "0xAD8710")]
			public float scaleMlp;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8748", Offset = "0xAD8748")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8780", Offset = "0xAD8780")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD87B8", Offset = "0xAD87B8")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD87F0", Offset = "0xAD87F0")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8828", Offset = "0xAD8828")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8860", Offset = "0xAD8860")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8898", Offset = "0xAD8898")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD88D0", Offset = "0xAD88D0")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAD8908", Offset = "0xAD8908")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8908", Offset = "0xAD8908")]
			public Vector3 headOffset;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8958", Offset = "0xAD8958")]
			public Vector3 handOffset;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8990", Offset = "0xAD8990")]
			public float footForwardOffset;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD89C8", Offset = "0xAD89C8")]
			public float footInwardOffset;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD8A00", Offset = "0xAD8A00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD8A00", Offset = "0xAD8A00")]
			public float footHeadingOffset;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD8A5C", Offset = "0xAD8A5C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD8A74", Offset = "0xAD8A74")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x186CB1C", Offset = "0x186CB1C", VA = "0x186CB1C")]
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
				[Address(RVA = "0x186BBE8", Offset = "0x186BBE8", VA = "0x186BBE8")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000748")]
				[Address(RVA = "0x186C70C", Offset = "0x186C70C", VA = "0x186C70C")]
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
			[Address(RVA = "0x186B084", Offset = "0x186B084", VA = "0x186B084")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1869C60", Offset = "0x1869C60", VA = "0x1869C60")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1869DCC", Offset = "0x1869DCC", VA = "0x1869DCC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x186B1FC", Offset = "0x186B1FC", VA = "0x186B1FC")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x186BCB0", Offset = "0x186BCB0", VA = "0x186BCB0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x186C770", Offset = "0x186C770", VA = "0x186C770")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD4774", Offset = "0xAD4774")]
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
			[Address(RVA = "0x186CC14", Offset = "0x186CC14", VA = "0x186CC14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADABDC", Offset = "0xADABDC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x186CC20", Offset = "0x186CC20", VA = "0x186CC20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADABEC", Offset = "0xADABEC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x186CC2C", Offset = "0x186CC2C", VA = "0x186CC2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x186B9C0", Offset = "0x186B9C0", VA = "0x186B9C0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x186C9A8", Offset = "0x186C9A8", VA = "0x186C9A8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x186CD0C", Offset = "0x186CD0C", VA = "0x186CD0C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x186D1B4", Offset = "0x186D1B4", VA = "0x186D1B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x186D2B0", Offset = "0x186D2B0", VA = "0x186D2B0")]
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
		[Address(RVA = "0x17BAD98", Offset = "0x17BAD98", VA = "0x17BAD98")]
		private void Start()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x17BAEE0", Offset = "0x17BAEE0", VA = "0x17BAEE0")]
		private void OnFPSLevelChanged(FPSLevel newLevel)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x17BAEE8", Offset = "0x17BAEE8", VA = "0x17BAEE8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x17BC230", Offset = "0x17BC230", VA = "0x17BC230")]
		private void DrawCommonTab()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x17BCF70", Offset = "0x17BCF70", VA = "0x17BCF70")]
		private void DrawLookFeelTab()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x17BDC88", Offset = "0x17BDC88", VA = "0x17BDC88")]
		private void DrawFPSCounterTab()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x17BF4C4", Offset = "0x17BF4C4", VA = "0x17BF4C4")]
		private void DrawMemoryCounterTab()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x17C03AC", Offset = "0x17C03AC", VA = "0x17C03AC")]
		private void DrawDeviceInfoTab()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x17C14D4", Offset = "0x17C14D4", VA = "0x17C14D4")]
		private static float SliderLabel(float sliderValue, float sliderMinValue, float sliderMaxValue)
		{
			return default(float);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x17C1A78", Offset = "0x17C1A78", VA = "0x17C1A78")]
		private Color ColorSliders(string caption, Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x17C17E0", Offset = "0x17C17E0", VA = "0x17C17E0")]
		private Vector2 Vector2Slider(Vector2 input, string label)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x17C2A38", Offset = "0x17C2A38", VA = "0x17C2A38")]
		public APITester()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0A1C", Offset = "0xAD0A1C")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0xAD0A1C", Offset = "0xAD0A1C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4784", Offset = "0xAD4784")]
		public KeyCode hotKey;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD47BC", Offset = "0xAD47BC")]
		public bool circleGesture;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD47F4", Offset = "0xAD47F4")]
		public bool hotKeyCtrl;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD482C", Offset = "0xAD482C")]
		public bool hotKeyShift;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4864", Offset = "0xAD4864")]
		public bool hotKeyAlt;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD489C", Offset = "0xAD489C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD48E8", Offset = "0xAD48E8")]
		[SerializeField]
		private OperationMode operationMode;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4934", Offset = "0xAD4934")]
		[SerializeField]
		private bool forceFrameRate;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4980", Offset = "0xAD4980")]
		[SerializeField]
		private int forcedFrameRate;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD49C4", Offset = "0xAD49C4")]
		[SerializeField]
		private bool background;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4A10", Offset = "0xAD4A10")]
		[SerializeField]
		private Color backgroundColor;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4A5C", Offset = "0xAD4A5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4A5C", Offset = "0xAD4A5C")]
		[SerializeField]
		private int backgroundPadding;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4AC0", Offset = "0xAD4AC0")]
		[SerializeField]
		private bool shadow;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4B0C", Offset = "0xAD4B0C")]
		[SerializeField]
		private Color shadowColor;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4B58", Offset = "0xAD4B58")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4BA4", Offset = "0xAD4BA4")]
		[SerializeField]
		private bool outline;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4BF0", Offset = "0xAD4BF0")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4C3C", Offset = "0xAD4C3C")]
		[SerializeField]
		private Vector2 outlineDistance;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4C88", Offset = "0xAD4C88")]
		[SerializeField]
		private bool autoScale;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4CD4", Offset = "0xAD4CD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4CD4", Offset = "0xAD4CD4")]
		[SerializeField]
		private float scaleFactor;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4D38", Offset = "0xAD4D38")]
		[SerializeField]
		private Font labelsFont;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4D84", Offset = "0xAD4D84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4D84", Offset = "0xAD4D84")]
		[SerializeField]
		private int fontSize;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4DEC", Offset = "0xAD4DEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4DEC", Offset = "0xAD4DEC")]
		[SerializeField]
		private float lineSpacing;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4E50", Offset = "0xAD4E50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD4E50", Offset = "0xAD4E50")]
		[SerializeField]
		private int countersSpacing;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4EB4", Offset = "0xAD4EB4")]
		[SerializeField]
		private Vector2 paddingOffset;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4F00", Offset = "0xAD4F00")]
		[SerializeField]
		private bool pixelPerfect;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4F4C", Offset = "0xAD4F4C")]
		[SerializeField]
		private int sortingOrder;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD4F98", Offset = "0xAD4F98")]
		private static AFPSCounter <Instance>k__BackingField;

		[Token(Token = "0x17000064")]
		public bool KeepAlive
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x17B6E54", Offset = "0x17B6E54", VA = "0x17B6E54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public OperationMode OperationMode
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x17B6E5C", Offset = "0x17B6E5C", VA = "0x17B6E5C")]
			get
			{
				return default(OperationMode);
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x17B6E64", Offset = "0x17B6E64", VA = "0x17B6E64")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool ForceFrameRate
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x17B74D4", Offset = "0x17B74D4", VA = "0x17B74D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x17B74DC", Offset = "0x17B74DC", VA = "0x17B74DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public int ForcedFrameRate
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x17B7548", Offset = "0x17B7548", VA = "0x17B7548")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x17B7550", Offset = "0x17B7550", VA = "0x17B7550")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool Background
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x17B75A8", Offset = "0x17B75A8", VA = "0x17B75A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x17B75B0", Offset = "0x17B75B0", VA = "0x17B75B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Color BackgroundColor
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x17B7690", Offset = "0x17B7690", VA = "0x17B7690")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x17B769C", Offset = "0x17B769C", VA = "0x17B769C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int BackgroundPadding
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x17B77B0", Offset = "0x17B77B0", VA = "0x17B77B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x17B77B8", Offset = "0x17B77B8", VA = "0x17B77B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public bool Shadow
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x17B7888", Offset = "0x17B7888", VA = "0x17B7888")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x17B7890", Offset = "0x17B7890", VA = "0x17B7890")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Color ShadowColor
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x17B7970", Offset = "0x17B7970", VA = "0x17B7970")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x17B797C", Offset = "0x17B797C", VA = "0x17B797C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Vector2 ShadowDistance
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x17B7A90", Offset = "0x17B7A90", VA = "0x17B7A90")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x17B7A98", Offset = "0x17B7A98", VA = "0x17B7A98")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool Outline
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x17B7BD4", Offset = "0x17B7BD4", VA = "0x17B7BD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x17B7BDC", Offset = "0x17B7BDC", VA = "0x17B7BDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Color OutlineColor
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x17B7CBC", Offset = "0x17B7CBC", VA = "0x17B7CBC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x17B7CC8", Offset = "0x17B7CC8", VA = "0x17B7CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Vector2 OutlineDistance
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x17B7DDC", Offset = "0x17B7DDC", VA = "0x17B7DDC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x17B7DE4", Offset = "0x17B7DE4", VA = "0x17B7DE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool AutoScale
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x17B7F20", Offset = "0x17B7F20", VA = "0x17B7F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x17B7F28", Offset = "0x17B7F28", VA = "0x17B7F28")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public float ScaleFactor
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x17B7FFC", Offset = "0x17B7FFC", VA = "0x17B7FFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x17B8004", Offset = "0x17B8004", VA = "0x17B8004")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public Font LabelsFont
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x17B813C", Offset = "0x17B813C", VA = "0x17B813C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x17B8144", Offset = "0x17B8144", VA = "0x17B8144")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public int FontSize
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x17B8280", Offset = "0x17B8280", VA = "0x17B8280")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x17B8288", Offset = "0x17B8288", VA = "0x17B8288")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public float LineSpacing
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x17B83DC", Offset = "0x17B83DC", VA = "0x17B83DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x17B83E4", Offset = "0x17B83E4", VA = "0x17B83E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public int CountersSpacing
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x17B8594", Offset = "0x17B8594", VA = "0x17B8594")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x17B859C", Offset = "0x17B859C", VA = "0x17B859C")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Vector2 PaddingOffset
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x17B8650", Offset = "0x17B8650", VA = "0x17B8650")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x17B8658", Offset = "0x17B8658", VA = "0x17B8658")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool PixelPerfect
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x17B8824", Offset = "0x17B8824", VA = "0x17B8824")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x17B882C", Offset = "0x17B882C", VA = "0x17B882C")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public int SortingOrder
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x17B88A4", Offset = "0x17B88A4", VA = "0x17B88A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x17B88AC", Offset = "0x17B88AC", VA = "0x17B88AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public static AFPSCounter Instance
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x17B8E10", Offset = "0x17B8E10", VA = "0x17B8E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADABFC", Offset = "0xADABFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x17B8E60", Offset = "0x17B8E60", VA = "0x17B8E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC0C", Offset = "0xADAC0C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x17B8978", Offset = "0x17B8978", VA = "0x17B8978")]
		private AFPSCounter()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x17B8EB4", Offset = "0x17B8EB4", VA = "0x17B8EB4")]
		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x17B9128", Offset = "0x17B9128", VA = "0x17B9128")]
		public static AFPSCounter AddToScene()
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x17B9130", Offset = "0x17B9130", VA = "0x17B9130")]
		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x17B9138", Offset = "0x17B9138", VA = "0x17B9138")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x17B9310", Offset = "0x17B9310", VA = "0x17B9310")]
		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x17B9024", Offset = "0x17B9024", VA = "0x17B9024")]
		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x17B93D0", Offset = "0x17B93D0", VA = "0x17B93D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x17B9A7C", Offset = "0x17B9A7C", VA = "0x17B9A7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x17B9B68", Offset = "0x17B9B68", VA = "0x17B9B68")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x17BA0B0", Offset = "0x17BA0B0", VA = "0x17BA0B0")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x17BA0B4", Offset = "0x17BA0B4", VA = "0x17BA0B4")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x17B704C", Offset = "0x17B704C", VA = "0x17B704C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x17B73EC", Offset = "0x17B73EC", VA = "0x17B73EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x17BA374", Offset = "0x17BA374", VA = "0x17BA374")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x17BA63C", Offset = "0x17BA63C", VA = "0x17BA63C")]
		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x17B70C8", Offset = "0x17B70C8", VA = "0x17B70C8")]
		internal void UpdateTexts()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x17B956C", Offset = "0x17B956C", VA = "0x17B956C")]
		private void ConfigureCanvas()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x17B97B8", Offset = "0x17B97B8", VA = "0x17B97B8")]
		private void ConfigureLabels()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x17B922C", Offset = "0x17B922C", VA = "0x17B922C")]
		private void DisposeInternal()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x17B9BB8", Offset = "0x17B9BB8", VA = "0x17B9BB8")]
		private void ProcessHotKey()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x17B9CBC", Offset = "0x17B9CBC", VA = "0x17B9CBC")]
		private bool CircleGestureMade()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x17BA08C", Offset = "0x17BA08C", VA = "0x17BA08C")]
		private void SwitchCounter()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x17BA14C", Offset = "0x17BA14C", VA = "0x17BA14C")]
		private void ActivateCounters()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x17BA1F0", Offset = "0x17BA1F0", VA = "0x17BA1F0")]
		private void DeactivateCounters()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x17B7540", Offset = "0x17B7540", VA = "0x17B7540")]
		private void RefreshForcedFrameRate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x17BA2E4", Offset = "0x17BA2E4", VA = "0x17BA2E4")]
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
		[Address(RVA = "0x17BAA04", Offset = "0x17BAA04", VA = "0x17BAA04")]
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x17C6780", Offset = "0x17C6780", VA = "0x17C6780")]
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
			[Address(RVA = "0x17C6998", Offset = "0x17C6998", VA = "0x17C6998", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x17C4F68", Offset = "0x17C4F68", VA = "0x17C4F68")]
		public new void Reset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x17C5AEC", Offset = "0x17C5AEC", VA = "0x17C5AEC")]
		public WaitForSecondsUnscaled(float time)
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0xAD0A68", Offset = "0xAD0A68")]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool recording;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float renderTime;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x17C6788", Offset = "0x17C6788", VA = "0x17C6788")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x17C6850", Offset = "0x17C6850", VA = "0x17C6850")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x17C6990", Offset = "0x17C6990", VA = "0x17C6990")]
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
		[Address(RVA = "0x17BACA4", Offset = "0x17BACA4", VA = "0x17BACA4")]
		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x17BA69C", Offset = "0x17BA69C", VA = "0x17BA69C")]
		internal void CheckAndUpdate()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x17B6F74", Offset = "0x17B6F74", VA = "0x17B6F74")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x17BA618", Offset = "0x17BA618", VA = "0x17BA618")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x17B8258", Offset = "0x17B8258", VA = "0x17B8258")]
		internal void ChangeFont(Font labelsFont)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x17B8338", Offset = "0x17B8338", VA = "0x17B8338")]
		internal void ChangeFontSize(int newSize)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x17B8774", Offset = "0x17B8774", VA = "0x17B8774")]
		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x17B84F0", Offset = "0x17B84F0", VA = "0x17B84F0")]
		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x17B766C", Offset = "0x17B766C", VA = "0x17B766C")]
		internal void ChangeBackground(bool enabled)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x17B778C", Offset = "0x17B778C", VA = "0x17B778C")]
		internal void ChangeBackgroundColor(Color color)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x17B7868", Offset = "0x17B7868", VA = "0x17B7868")]
		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x17B794C", Offset = "0x17B794C", VA = "0x17B794C")]
		internal void ChangeShadow(bool enabled)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x17B7A6C", Offset = "0x17B7A6C", VA = "0x17B7A6C")]
		internal void ChangeShadowColor(Color color)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x17B7BB4", Offset = "0x17B7BB4", VA = "0x17B7BB4")]
		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x17B7C98", Offset = "0x17B7C98", VA = "0x17B7C98")]
		internal void ChangeOutline(bool enabled)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x17B7DB8", Offset = "0x17B7DB8", VA = "0x17B7DB8")]
		internal void ChangeOutlineColor(Color color)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x17B7F00", Offset = "0x17B7F00", VA = "0x17B7F00")]
		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x17C5FF4", Offset = "0x17C5FF4", VA = "0x17C5FF4")]
		private void UpdateTextPosition()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x17C5B20", Offset = "0x17C5B20", VA = "0x17C5B20")]
		private void NormalizeOffset()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x17C64D8", Offset = "0x17C64D8", VA = "0x17C64D8")]
		private void ApplyBackground()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x17C5B88", Offset = "0x17C5B88", VA = "0x17C5B88")]
		private void ApplyShadow()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x17C5D44", Offset = "0x17C5D44", VA = "0x17C5D44")]
		private void ApplyOutline()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x17C5F00", Offset = "0x17C5F00", VA = "0x17C5F00")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0A78", Offset = "0xAD0A78")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD4FB8", Offset = "0xAD4FB8")]
		[SerializeField]
		protected LabelAnchor anchor;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5004", Offset = "0xAD5004")]
		[SerializeField]
		protected Color color;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5050", Offset = "0xAD5050")]
		[SerializeField]
		protected FontStyle style;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD509C", Offset = "0xAD509C")]
		protected string extraText;

		[Token(Token = "0x1700007C")]
		public bool Enabled
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x17C2BC4", Offset = "0x17C2BC4", VA = "0x17C2BC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x17C1D8C", Offset = "0x17C1D8C", VA = "0x17C1D8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public LabelAnchor Anchor
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x17C2BCC", Offset = "0x17C2BCC", VA = "0x17C2BCC")]
			get
			{
				return default(LabelAnchor);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x17C1EB4", Offset = "0x17C1EB4", VA = "0x17C1EB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Color Color
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x17C2BD4", Offset = "0x17C2BD4", VA = "0x17C2BD4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x17C2BE0", Offset = "0x17C2BE0", VA = "0x17C2BE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public FontStyle Style
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x17C2CE4", Offset = "0x17C2CE4", VA = "0x17C2CE4")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x17C1E08", Offset = "0x17C1E08", VA = "0x17C1E08")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public string ExtraText
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x17C2CEC", Offset = "0x17C2CEC", VA = "0x17C2CEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x17C1E5C", Offset = "0x17C1E5C", VA = "0x17C1E5C")]
			set
			{
			}
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x17C2C88", Offset = "0x17C2C88", VA = "0x17C2C88")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x17C2CF4", Offset = "0x17C2CF4", VA = "0x17C2CF4", Slot = "4")]
		internal virtual void UpdateValue()
		{
		}

		[Token(Token = "0x600051C")]
		internal abstract void UpdateValue(bool force);

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x17C2D04", Offset = "0x17C2D04", VA = "0x17C2D04")]
		internal void Init(AFPSCounter reference)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x17BA5CC", Offset = "0x17BA5CC", VA = "0x17BA5CC")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x17C2D0C", Offset = "0x17C2D0C", VA = "0x17C2D0C", Slot = "6")]
		internal virtual void Activate()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x17C2E30", Offset = "0x17C2E30", VA = "0x17C2E30", Slot = "7")]
		internal virtual void Deactivate()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x17C2EA4", Offset = "0x17C2EA4", VA = "0x17C2EA4", Slot = "8")]
		protected virtual void PerformInitActions()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x17C2EA8", Offset = "0x17C2EA8", VA = "0x17C2EA8", Slot = "9")]
		protected virtual void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x17C2EAC", Offset = "0x17C2EAC", VA = "0x17C2EAC", Slot = "10")]
		protected virtual void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000524")]
		protected abstract bool HasData();

		[Token(Token = "0x6000525")]
		protected abstract void CacheCurrentColor();

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x17C2EB0", Offset = "0x17C2EB0", VA = "0x17C2EB0")]
		protected void ApplyTextStyles()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x17C3048", Offset = "0x17C3048", VA = "0x17C3048")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD50D4", Offset = "0xAD50D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD50D4", Offset = "0xAD50D4")]
		[SerializeField]
		protected float updateInterval;

		[Token(Token = "0x17000081")]
		public float UpdateInterval
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x17C59FC", Offset = "0x17C59FC", VA = "0x17C59FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x17C1F28", Offset = "0x17C1F28", VA = "0x17C1F28")]
			set
			{
			}
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x17C5A74", Offset = "0x17C5A74", VA = "0x17C5A74", Slot = "8")]
		protected override void PerformInitActions()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x17C4C3C", Offset = "0x17C4C3C", VA = "0x17C4C3C", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x17C4C7C", Offset = "0x17C4C7C", VA = "0x17C4C7C", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600052D")]
		protected abstract IEnumerator UpdateCounter();

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x17C5A78", Offset = "0x17C5A78", VA = "0x17C5A78")]
		private void StartUpdateCoroutine()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x17C5AC8", Offset = "0x17C5AC8", VA = "0x17C5AC8")]
		private void StoptUpdateCoroutine()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x17C5A04", Offset = "0x17C5A04", VA = "0x17C5A04")]
		private void CacheWaitForSeconds()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x17C41F4", Offset = "0x17C41F4", VA = "0x17C41F4")]
		protected UpdatebleCounterData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0AB0", Offset = "0xAD0AB0")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD513C", Offset = "0xAD513C")]
		[SerializeField]
		private bool platform;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5188", Offset = "0xAD5188")]
		[SerializeField]
		private bool cpuModel;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD51D4", Offset = "0xAD51D4")]
		[SerializeField]
		private bool gpuModel;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5220", Offset = "0xAD5220")]
		[SerializeField]
		private bool gpuApi;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD526C", Offset = "0xAD526C")]
		[SerializeField]
		private bool gpuSpec;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD52B8", Offset = "0xAD52B8")]
		[SerializeField]
		private bool ramSize;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5304", Offset = "0xAD5304")]
		[SerializeField]
		private bool screenData;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5350", Offset = "0xAD5350")]
		[SerializeField]
		private bool deviceModel;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD539C", Offset = "0xAD539C")]
		private string <LastValue>k__BackingField;

		[Token(Token = "0x17000082")]
		public bool Platform
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x17C3058", Offset = "0x17C3058", VA = "0x17C3058")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x17C2738", Offset = "0x17C2738", VA = "0x17C2738")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool CpuModel
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x17C3060", Offset = "0x17C3060", VA = "0x17C3060")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x17C2798", Offset = "0x17C2798", VA = "0x17C2798")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool GpuModel
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x17C3068", Offset = "0x17C3068", VA = "0x17C3068")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x17C27F8", Offset = "0x17C27F8", VA = "0x17C27F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool GpuApi
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x17C3070", Offset = "0x17C3070", VA = "0x17C3070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x17C2858", Offset = "0x17C2858", VA = "0x17C2858")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool GpuSpec
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x17C3078", Offset = "0x17C3078", VA = "0x17C3078")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x17C28B8", Offset = "0x17C28B8", VA = "0x17C28B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool RamSize
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x17C3080", Offset = "0x17C3080", VA = "0x17C3080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x17C2918", Offset = "0x17C2918", VA = "0x17C2918")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public bool ScreenData
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x17C3088", Offset = "0x17C3088", VA = "0x17C3088")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x17C2978", Offset = "0x17C2978", VA = "0x17C2978")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public bool DeviceModel
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x17C3090", Offset = "0x17C3090", VA = "0x17C3090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x17C29D8", Offset = "0x17C29D8", VA = "0x17C29D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public string LastValue
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x17C3098", Offset = "0x17C3098", VA = "0x17C3098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC1C", Offset = "0xADAC1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x17C30A0", Offset = "0x17C30A0", VA = "0x17C30A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC2C", Offset = "0xADAC2C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x17B8D94", Offset = "0x17B8D94", VA = "0x17B8D94")]
		internal DeviceInfoCounterData()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x17C30A8", Offset = "0x17C30A8", VA = "0x17C30A8", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x17C3900", Offset = "0x17C3900", VA = "0x17C3900", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x17C3930", Offset = "0x17C3930", VA = "0x17C3930", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0AE8", Offset = "0xAD0AE8")]
	public class FPSCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0BA8", Offset = "0xAD0BA8")]
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
				[Address(RVA = "0x17C4F98", Offset = "0x17C4F98", VA = "0x17C4F98", Slot = "4")]
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
				[Address(RVA = "0x17C5004", Offset = "0x17C5004", VA = "0x17C5004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x17C4CF4", Offset = "0x17C4CF4", VA = "0x17C4CF4")]
			[DebuggerHidden]
			public <UpdateCounter>d__147(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x17C4E54", Offset = "0x17C4E54", VA = "0x17C4E54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x17C4E58", Offset = "0x17C4E58", VA = "0x17C4E58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x17C4FA0", Offset = "0x17C4FA0", VA = "0x17C4FA0", Slot = "8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD53AC", Offset = "0xAD53AC")]
		public bool resetAverageOnNewScene;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD53E4", Offset = "0xAD53E4")]
		public bool resetMinMaxOnNewScene;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD541C", Offset = "0xAD541C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD541C", Offset = "0xAD541C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5480", Offset = "0xAD5480")]
		[SerializeField]
		private bool milliseconds;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD54CC", Offset = "0xAD54CC")]
		[SerializeField]
		private bool average;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5518", Offset = "0xAD5518")]
		[SerializeField]
		private bool averageMilliseconds;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5564", Offset = "0xAD5564")]
		[SerializeField]
		private bool averageNewLine;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD55B0", Offset = "0xAD55B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAD55B0", Offset = "0xAD55B0")]
		[SerializeField]
		private int averageSamples;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5618", Offset = "0xAD5618")]
		[SerializeField]
		private bool minMax;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5664", Offset = "0xAD5664")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD56B0", Offset = "0xAD56B0")]
		[SerializeField]
		private bool minMaxNewLine;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD56FC", Offset = "0xAD56FC")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5748", Offset = "0xAD5748")]
		[SerializeField]
		private bool render;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5794", Offset = "0xAD5794")]
		[SerializeField]
		private bool renderNewLine;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD57E0", Offset = "0xAD57E0")]
		[SerializeField]
		private bool renderAutoAdd;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD582C", Offset = "0xAD582C")]
		[SerializeField]
		private Color colorWarning;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5878", Offset = "0xAD5878")]
		[SerializeField]
		private Color colorCritical;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD58C4", Offset = "0xAD58C4")]
		[SerializeField]
		protected Color colorRender;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5910", Offset = "0xAD5910")]
		private int <LastValue>k__BackingField;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5920", Offset = "0xAD5920")]
		private float <LastMillisecondsValue>k__BackingField;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5930", Offset = "0xAD5930")]
		private float <LastRenderValue>k__BackingField;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5940", Offset = "0xAD5940")]
		private int <LastAverageValue>k__BackingField;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5950", Offset = "0xAD5950")]
		private float <LastAverageMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5960", Offset = "0xAD5960")]
		private int <LastMinimumValue>k__BackingField;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5970", Offset = "0xAD5970")]
		private int <LastMaximumValue>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5980", Offset = "0xAD5980")]
		private float <LastMinMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5990", Offset = "0xAD5990")]
		private float <LastMaxMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD59A0", Offset = "0xAD59A0")]
		private FPSLevel <CurrentFpsLevel>k__BackingField;

		[Token(Token = "0x1700008B")]
		public bool Milliseconds
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x17C3A58", Offset = "0x17C3A58", VA = "0x17C3A58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x17C1FD4", Offset = "0x17C1FD4", VA = "0x17C1FD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool Average
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x17C3A60", Offset = "0x17C3A60", VA = "0x17C3A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x17C203C", Offset = "0x17C203C", VA = "0x17C203C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool AverageMilliseconds
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x17C3A68", Offset = "0x17C3A68", VA = "0x17C3A68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x17C2190", Offset = "0x17C2190", VA = "0x17C2190")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool AverageNewLine
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x17C3A70", Offset = "0x17C3A70", VA = "0x17C3A70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x17C21F8", Offset = "0x17C21F8", VA = "0x17C21F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public int AverageSamples
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x17C3A78", Offset = "0x17C3A78", VA = "0x17C3A78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x17C20A8", Offset = "0x17C20A8", VA = "0x17C20A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool MinMax
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x17C3A80", Offset = "0x17C3A80", VA = "0x17C3A80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x17C22B4", Offset = "0x17C22B4", VA = "0x17C22B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool MinMaxMilliseconds
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x17C3A88", Offset = "0x17C3A88", VA = "0x17C3A88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x17C2324", Offset = "0x17C2324", VA = "0x17C2324")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool MinMaxNewLine
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x17C3A90", Offset = "0x17C3A90", VA = "0x17C3A90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x17C2404", Offset = "0x17C2404", VA = "0x17C2404")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool MinMaxTwoLines
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x17C3A98", Offset = "0x17C3A98", VA = "0x17C3A98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x17C23A4", Offset = "0x17C23A4", VA = "0x17C23A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool Render
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x17C3AA0", Offset = "0x17C3AA0", VA = "0x17C3AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x17C24B8", Offset = "0x17C24B8", VA = "0x17C24B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool RenderNewLine
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x17C3CA4", Offset = "0x17C3CA4", VA = "0x17C3CA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x17C2540", Offset = "0x17C2540", VA = "0x17C2540")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool RenderAutoAdd
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x17C3CAC", Offset = "0x17C3CAC", VA = "0x17C3CAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x17C3CB4", Offset = "0x17C3CB4", VA = "0x17C3CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public Color ColorWarning
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x17C3D18", Offset = "0x17C3D18", VA = "0x17C3D18")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x17C3D2C", Offset = "0x17C3D2C", VA = "0x17C3D2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public Color ColorCritical
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x17C3ED0", Offset = "0x17C3ED0", VA = "0x17C3ED0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x17C3EE4", Offset = "0x17C3EE4", VA = "0x17C3EE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Color ColorRender
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x17C4088", Offset = "0x17C4088", VA = "0x17C4088")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x17C409C", Offset = "0x17C409C", VA = "0x17C409C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int LastValue
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x17C4154", Offset = "0x17C4154", VA = "0x17C4154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC5C", Offset = "0xADAC5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x17C415C", Offset = "0x17C415C", VA = "0x17C415C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC6C", Offset = "0xADAC6C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public float LastMillisecondsValue
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x17C4164", Offset = "0x17C4164", VA = "0x17C4164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC7C", Offset = "0xADAC7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x17C416C", Offset = "0x17C416C", VA = "0x17C416C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC8C", Offset = "0xADAC8C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public float LastRenderValue
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x17C4174", Offset = "0x17C4174", VA = "0x17C4174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC9C", Offset = "0xADAC9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x17C417C", Offset = "0x17C417C", VA = "0x17C417C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADACAC", Offset = "0xADACAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public int LastAverageValue
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x17C4184", Offset = "0x17C4184", VA = "0x17C4184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADACBC", Offset = "0xADACBC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x17C418C", Offset = "0x17C418C", VA = "0x17C418C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADACCC", Offset = "0xADACCC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public float LastAverageMillisecondsValue
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x17C4194", Offset = "0x17C4194", VA = "0x17C4194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADACDC", Offset = "0xADACDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x17C419C", Offset = "0x17C419C", VA = "0x17C419C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADACEC", Offset = "0xADACEC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public int LastMinimumValue
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x17C41A4", Offset = "0x17C41A4", VA = "0x17C41A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADACFC", Offset = "0xADACFC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x17C41AC", Offset = "0x17C41AC", VA = "0x17C41AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD0C", Offset = "0xADAD0C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public int LastMaximumValue
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x17C41B4", Offset = "0x17C41B4", VA = "0x17C41B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD1C", Offset = "0xADAD1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x17C41BC", Offset = "0x17C41BC", VA = "0x17C41BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD2C", Offset = "0xADAD2C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public float LastMinMillisecondsValue
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x17C41C4", Offset = "0x17C41C4", VA = "0x17C41C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD3C", Offset = "0xADAD3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x17C41CC", Offset = "0x17C41CC", VA = "0x17C41CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD4C", Offset = "0xADAD4C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float LastMaxMillisecondsValue
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x17C41D4", Offset = "0x17C41D4", VA = "0x17C41D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD5C", Offset = "0xADAD5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x17C41DC", Offset = "0x17C41DC", VA = "0x17C41DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD6C", Offset = "0xADAD6C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public FPSLevel CurrentFpsLevel
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x17C41E4", Offset = "0x17C41E4", VA = "0x17C41E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD7C", Offset = "0xADAD7C")]
			get
			{
				return default(FPSLevel);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x17C41EC", Offset = "0x17C41EC", VA = "0x17C41EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAD8C", Offset = "0xADAD8C")]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<FPSLevel> OnFPSLevelChange
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x17BAE3C", Offset = "0x17BAE3C", VA = "0x17BAE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC3C", Offset = "0xADAC3C")]
			add
			{
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x17C39B4", Offset = "0x17C39B4", VA = "0x17C39B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAC4C", Offset = "0xADAC4C")]
			remove
			{
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x17B8BA8", Offset = "0x17B8BA8", VA = "0x17B8BA8")]
		internal FPSCounterData()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x17C2258", Offset = "0x17C2258", VA = "0x17C2258")]
		public void ResetAverage()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x17C2464", Offset = "0x17C2464", VA = "0x17C2464")]
		public void ResetMinMax(bool withoutUpdate = false)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x17BA0E0", Offset = "0x17BA0E0", VA = "0x17BA0E0")]
		internal void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x17C420C", Offset = "0x17C420C", VA = "0x17C420C")]
		internal void AddRenderTime(float time)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x17C422C", Offset = "0x17C422C", VA = "0x17C422C", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x17C4B38", Offset = "0x17C4B38", VA = "0x17C4B38", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x17C4C40", Offset = "0x17C4C40", VA = "0x17C4C40", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x17C4C80", Offset = "0x17C4C80", VA = "0x17C4C80", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADAD9C", Offset = "0xADAD9C")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x17C4D20", Offset = "0x17C4D20", VA = "0x17C4D20", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x17C4D28", Offset = "0x17C4D28", VA = "0x17C4D28", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x17C3DDC", Offset = "0x17C3DDC", VA = "0x17C3DDC")]
		protected void CacheWarningColor()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x17C3F94", Offset = "0x17C3F94", VA = "0x17C3F94")]
		protected void CacheCriticalColor()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x17C4AB4", Offset = "0x17C4AB4", VA = "0x17C4AB4")]
		private float GetAverageFromAccumulatedSamples()
		{
			return default(float);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x17C3BA8", Offset = "0x17C3BA8", VA = "0x17C3BA8")]
		private static void TryToAddRenderRecorder()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x17C3AA8", Offset = "0x17C3AA8", VA = "0x17C3AA8")]
		private static void TryToRemoveRenderRecorder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAD0B20", Offset = "0xAD0B20")]
	public class MemoryCounterData : UpdatebleCounterData
	{
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD0BB8", Offset = "0xAD0BB8")]
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
				[Address(RVA = "0x17C5988", Offset = "0x17C5988", VA = "0x17C5988", Slot = "4")]
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
				[Address(RVA = "0x17C59F4", Offset = "0x17C59F4", VA = "0x17C59F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x17C5820", Offset = "0x17C5820", VA = "0x17C5820")]
			[DebuggerHidden]
			public <UpdateCounter>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x17C58EC", Offset = "0x17C58EC", VA = "0x17C58EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x17C58F0", Offset = "0x17C58F0", VA = "0x17C58F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x17C5990", Offset = "0x17C5990", VA = "0x17C5990", Slot = "8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD59B0", Offset = "0xAD59B0")]
		[SerializeField]
		private bool precise;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD59FC", Offset = "0xAD59FC")]
		[SerializeField]
		private bool total;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5A48", Offset = "0xAD5A48")]
		[SerializeField]
		private bool allocated;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAD5A94", Offset = "0xAD5A94")]
		[SerializeField]
		private bool monoUsage;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5AE0", Offset = "0xAD5AE0")]
		private long <LastTotalValue>k__BackingField;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5AF0", Offset = "0xAD5AF0")]
		private long <LastAllocatedValue>k__BackingField;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAD5B00", Offset = "0xAD5B00")]
		private long <LastMonoValue>k__BackingField;

		[Token(Token = "0x170000A4")]
		public bool Precise
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x17C500C", Offset = "0x17C500C", VA = "0x17C500C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x17C25A0", Offset = "0x17C25A0", VA = "0x17C25A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool Total
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x17C5014", Offset = "0x17C5014", VA = "0x17C5014")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x17C2600", Offset = "0x17C2600", VA = "0x17C2600")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool Allocated
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x17C501C", Offset = "0x17C501C", VA = "0x17C501C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x17C2668", Offset = "0x17C2668", VA = "0x17C2668")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool MonoUsage
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x17C5024", Offset = "0x17C5024", VA = "0x17C5024")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x17C26D0", Offset = "0x17C26D0", VA = "0x17C26D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public long LastTotalValue
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x17C502C", Offset = "0x17C502C", VA = "0x17C502C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAE00", Offset = "0xADAE00")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x17C5034", Offset = "0x17C5034", VA = "0x17C5034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAE10", Offset = "0xADAE10")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public long LastAllocatedValue
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x17C503C", Offset = "0x17C503C", VA = "0x17C503C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAE20", Offset = "0xADAE20")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x17C5044", Offset = "0x17C5044", VA = "0x17C5044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAE30", Offset = "0xADAE30")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public long LastMonoValue
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x17C504C", Offset = "0x17C504C", VA = "0x17C504C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAE40", Offset = "0xADAE40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x17C5054", Offset = "0x17C5054", VA = "0x17C5054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADAE50", Offset = "0xADAE50")]
			private set
			{
			}
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x17B8D14", Offset = "0x17B8D14", VA = "0x17B8D14")]
		internal MemoryCounterData()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x17C505C", Offset = "0x17C505C", VA = "0x17C505C", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x17C54BC", Offset = "0x17C54BC", VA = "0x17C54BC", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x17C5768", Offset = "0x17C5768", VA = "0x17C5768", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x17C57AC", Offset = "0x17C57AC", VA = "0x17C57AC", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADAE60", Offset = "0xADAE60")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x17C584C", Offset = "0x17C584C", VA = "0x17C584C", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x17C5874", Offset = "0x17C5874", VA = "0x17C5874", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
}
