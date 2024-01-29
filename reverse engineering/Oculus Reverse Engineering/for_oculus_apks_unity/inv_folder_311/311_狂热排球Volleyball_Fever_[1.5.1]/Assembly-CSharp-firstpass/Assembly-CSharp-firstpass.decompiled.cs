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
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x736D94", Offset = "0x736D94")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x736D94", Offset = "0x736D94")]
public class SSAOEffect : MonoBehaviour
{
	[Token(Token = "0x200006B")]
	public enum SSAOSamples
	{
		[Token(Token = "0x400031A")]
		Low,
		[Token(Token = "0x400031B")]
		Medium,
		[Token(Token = "0x400031C")]
		High
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x15B2C2C", Offset = "0x15B2C2C", VA = "0x15B2C2C")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x15B2CDC", Offset = "0x15B2CDC", VA = "0x15B2CDC")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x15B2D78", Offset = "0x15B2D78", VA = "0x15B2D78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x15B2D80", Offset = "0x15B2D80", VA = "0x15B2D80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x15B2F14", Offset = "0x15B2F14", VA = "0x15B2F14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x15B2E58", Offset = "0x15B2E58", VA = "0x15B2E58")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x15B2F88", Offset = "0x15B2F88", VA = "0x15B2F88")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x15B3644", Offset = "0x15B3644", VA = "0x15B3644")]
	public SSAOEffect()
	{
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public enum Axis
	{
		[Token(Token = "0x400000D")]
		X,
		[Token(Token = "0x400000E")]
		Y,
		[Token(Token = "0x400000F")]
		Z
	}
	[Token(Token = "0x2000004")]
	public class AxisTools
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x10AD2A0", Offset = "0x10AD2A0", VA = "0x10AD2A0")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x10AD358", Offset = "0x10AD358", VA = "0x10AD358")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x10AD404", Offset = "0x10AD404", VA = "0x10AD404")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x10AD5E8", Offset = "0x10AD5E8", VA = "0x10AD5E8")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x10AD520", Offset = "0x10AD520", VA = "0x10AD520")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x10AD704", Offset = "0x10AD704", VA = "0x10AD704")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x10AD930", Offset = "0x10AD930", VA = "0x10AD930")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200006C")]
		public class LimbOrientation
		{
			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x10ADBF8", Offset = "0x10ADBF8", VA = "0x10ADBF8")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000001")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x10AD984", Offset = "0x10AD984", VA = "0x10AD984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x10ADC70", Offset = "0x10ADC70", VA = "0x10ADC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x10AD938", Offset = "0x10AD938", VA = "0x10AD938")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200006D")]
		public enum BoneType
		{
			[Token(Token = "0x4000321")]
			Unassigned,
			[Token(Token = "0x4000322")]
			Spine,
			[Token(Token = "0x4000323")]
			Head,
			[Token(Token = "0x4000324")]
			Arm,
			[Token(Token = "0x4000325")]
			Leg,
			[Token(Token = "0x4000326")]
			Tail,
			[Token(Token = "0x4000327")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200006E")]
		public enum BoneSide
		{
			[Token(Token = "0x4000329")]
			Center,
			[Token(Token = "0x400032A")]
			Left,
			[Token(Token = "0x400032B")]
			Right
		}

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x10ADEE4", Offset = "0x10ADEE4", VA = "0x10ADEE4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x10AE1E4", Offset = "0x10AE1E4", VA = "0x10AE1E4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x10AE434", Offset = "0x10AE434", VA = "0x10AE434")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x10AE4B8", Offset = "0x10AE4B8", VA = "0x10AE4B8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x10AE564", Offset = "0x10AE564", VA = "0x10AE564")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x10AE094", Offset = "0x10AE094", VA = "0x10AE094")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x10AE394", Offset = "0x10AE394", VA = "0x10AE394")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x10AEDA4", Offset = "0x10AEDA4", VA = "0x10AEDA4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x10AEBBC", Offset = "0x10AEBBC", VA = "0x10AEBBC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x10AECB0", Offset = "0x10AECB0", VA = "0x10AECB0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x10AE784", Offset = "0x10AE784", VA = "0x10AE784")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x10AE838", Offset = "0x10AE838", VA = "0x10AE838")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x10AE8EC", Offset = "0x10AE8EC", VA = "0x10AE8EC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x10AE9A0", Offset = "0x10AE9A0", VA = "0x10AE9A0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x10AEA54", Offset = "0x10AEA54", VA = "0x10AEA54")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x10AEB08", Offset = "0x10AEB08", VA = "0x10AEB08")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x10AEFB8", Offset = "0x10AEFB8", VA = "0x10AEFB8")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x10AE698", Offset = "0x10AE698", VA = "0x10AE698")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x10AEF28", Offset = "0x10AEF28", VA = "0x10AEF28")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x10AF028", Offset = "0x10AF028", VA = "0x10AF028")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x10AF100", Offset = "0x10AF100", VA = "0x10AF100")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x10AEEAC", Offset = "0x10AEEAC", VA = "0x10AEEAC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x10AEE34", Offset = "0x10AEE34", VA = "0x10AEE34")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class BipedReferences
	{
		[Token(Token = "0x200006F")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700005B")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x10B4090", Offset = "0x10B4090", VA = "0x10B4090")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x7E5474", Offset = "0x7E5474", VA = "0x7E5474")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000003")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x10B0C74", Offset = "0x10B0C74", VA = "0x10B0C74", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool isEmpty
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x10B1060", Offset = "0x10B1060", VA = "0x10B1060")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x10B1070", Offset = "0x10B1070", VA = "0x10B1070", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x10B149C", Offset = "0x10B149C", VA = "0x10B149C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x10B18D4", Offset = "0x10B18D4", VA = "0x10B18D4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10B1EE4", Offset = "0x10B1EE4", VA = "0x10B1EE4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10B1B20", Offset = "0x10B1B20", VA = "0x10B1B20")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x10B2694", Offset = "0x10B2694", VA = "0x10B2694")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x10B2788", Offset = "0x10B2788", VA = "0x10B2788")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x10B2CE0", Offset = "0x10B2CE0", VA = "0x10B2CE0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x10B2AE4", Offset = "0x10B2AE4", VA = "0x10B2AE4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x10B295C", Offset = "0x10B295C", VA = "0x10B295C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x10B2828", Offset = "0x10B2828", VA = "0x10B2828")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x10B2BE8", Offset = "0x10B2BE8", VA = "0x10B2BE8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x10B2DDC", Offset = "0x10B2DDC", VA = "0x10B2DDC")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x10B387C", Offset = "0x10B387C", VA = "0x10B387C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x10B3360", Offset = "0x10B3360", VA = "0x10B3360")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x10B3B70", Offset = "0x10B3B70", VA = "0x10B3B70")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x10B36A0", Offset = "0x10B36A0", VA = "0x10B36A0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x10B3B78", Offset = "0x10B3B78", VA = "0x10B3B78")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x10B3B80", Offset = "0x10B3B80", VA = "0x10B3B80")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x10B3D40", Offset = "0x10B3D40", VA = "0x10B3D40")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x10B3F58", Offset = "0x10B3F58", VA = "0x10B3F58")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x10B1AB0", Offset = "0x10B1AB0", VA = "0x10B1AB0")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x10B4098", Offset = "0x10B4098", VA = "0x10B4098")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x10B40A0", Offset = "0x10B40A0", VA = "0x10B40A0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x10B41E0", Offset = "0x10B41E0", VA = "0x10B41E0")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class Hierarchy
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x15AE178", Offset = "0x15AE178", VA = "0x15AE178")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x15AE378", Offset = "0x15AE378", VA = "0x15AE378")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x15AE210", Offset = "0x15AE210", VA = "0x15AE210")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x15AE49C", Offset = "0x15AE49C", VA = "0x15AE49C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x15AE5C0", Offset = "0x15AE5C0", VA = "0x15AE5C0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x15AE868", Offset = "0x15AE868", VA = "0x15AE868")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x15AE984", Offset = "0x15AE984", VA = "0x15AE984")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x15AEB0C", Offset = "0x15AEB0C", VA = "0x15AEB0C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x15AEEA0", Offset = "0x15AEEA0", VA = "0x15AEEA0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x15AEC8C", Offset = "0x15AEC8C", VA = "0x15AEC8C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x15AF040", Offset = "0x15AF040", VA = "0x15AF040")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400003B")]
		None,
		[Token(Token = "0x400003C")]
		InOutCubic,
		[Token(Token = "0x400003D")]
		InOutQuintic,
		[Token(Token = "0x400003E")]
		InOutSine,
		[Token(Token = "0x400003F")]
		InQuintic,
		[Token(Token = "0x4000040")]
		InQuartic,
		[Token(Token = "0x4000041")]
		InCubic,
		[Token(Token = "0x4000042")]
		InQuadratic,
		[Token(Token = "0x4000043")]
		InElastic,
		[Token(Token = "0x4000044")]
		InElasticSmall,
		[Token(Token = "0x4000045")]
		InElasticBig,
		[Token(Token = "0x4000046")]
		InSine,
		[Token(Token = "0x4000047")]
		InBack,
		[Token(Token = "0x4000048")]
		OutQuintic,
		[Token(Token = "0x4000049")]
		OutQuartic,
		[Token(Token = "0x400004A")]
		OutCubic,
		[Token(Token = "0x400004B")]
		OutInCubic,
		[Token(Token = "0x400004C")]
		OutInQuartic,
		[Token(Token = "0x400004D")]
		OutElastic,
		[Token(Token = "0x400004E")]
		OutElasticSmall,
		[Token(Token = "0x400004F")]
		OutElasticBig,
		[Token(Token = "0x4000050")]
		OutSine,
		[Token(Token = "0x4000051")]
		OutBack,
		[Token(Token = "0x4000052")]
		OutBackCubic,
		[Token(Token = "0x4000053")]
		OutBackQuartic,
		[Token(Token = "0x4000054")]
		BackInCubic,
		[Token(Token = "0x4000055")]
		BackInQuartic
	}
	[Token(Token = "0x200000C")]
	public class Interp
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x15AF048", Offset = "0x15AF048", VA = "0x15AF048")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x15AFAB0", Offset = "0x15AFAB0", VA = "0x15AFAB0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x15AFBB8", Offset = "0x15AFBB8", VA = "0x15AFBB8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15AF3B4", Offset = "0x15AF3B4", VA = "0x15AF3B4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x15AF3C0", Offset = "0x15AF3C0", VA = "0x15AF3C0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x15AF3E4", Offset = "0x15AF3E4", VA = "0x15AF3E4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x15AF420", Offset = "0x15AF420", VA = "0x15AF420")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x15AF438", Offset = "0x15AF438", VA = "0x15AF438")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x15AF44C", Offset = "0x15AF44C", VA = "0x15AF44C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x15AF460", Offset = "0x15AF460", VA = "0x15AF460")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x15AF470", Offset = "0x15AF470", VA = "0x15AF470")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x15AF4B8", Offset = "0x15AF4B8", VA = "0x15AF4B8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x15AF4F0", Offset = "0x15AF4F0", VA = "0x15AF4F0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x15AF518", Offset = "0x15AF518", VA = "0x15AF518")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x15AFCB4", Offset = "0x15AFCB4", VA = "0x15AFCB4")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15AF54C", Offset = "0x15AF54C", VA = "0x15AF54C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15AF574", Offset = "0x15AF574", VA = "0x15AF574")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15AF5A4", Offset = "0x15AF5A4", VA = "0x15AF5A4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15AF5D8", Offset = "0x15AF5D8", VA = "0x15AF5D8")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x15AF61C", Offset = "0x15AF61C", VA = "0x15AF61C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15AF680", Offset = "0x15AF680", VA = "0x15AF680")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x15AF6E4", Offset = "0x15AF6E4", VA = "0x15AF6E4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x15AF738", Offset = "0x15AF738", VA = "0x15AF738")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x15AF78C", Offset = "0x15AF78C", VA = "0x15AF78C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x15AF824", Offset = "0x15AF824", VA = "0x15AF824")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x15AF8B8", Offset = "0x15AF8B8", VA = "0x15AF8B8")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x15AFCE8", Offset = "0x15AFCE8", VA = "0x15AFCE8")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15AF95C", Offset = "0x15AF95C", VA = "0x15AF95C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15AFA40", Offset = "0x15AFA40", VA = "0x15AFA40")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x15AFA70", Offset = "0x15AFA70", VA = "0x15AFA70")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x15AFDD0", Offset = "0x15AFDD0", VA = "0x15AFDD0")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x15AFDD8", Offset = "0x15AFDD8", VA = "0x15AFDD8")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x15AFE48", Offset = "0x15AFE48", VA = "0x15AFE48")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15AFEB8", Offset = "0x15AFEB8", VA = "0x15AFEB8")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15AFF10", Offset = "0x15AFF10", VA = "0x15AFF10")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x15AFFDC", Offset = "0x15AFFDC", VA = "0x15AFFDC")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15AFF28", Offset = "0x15AFF28", VA = "0x15AFF28")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15AFFF4", Offset = "0x15AFFF4", VA = "0x15AFFF4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15B0098", Offset = "0x15B0098", VA = "0x15B0098")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x15B00C4", Offset = "0x15B00C4", VA = "0x15B00C4")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x15B0114", Offset = "0x15B0114", VA = "0x15B0114")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15B0180", Offset = "0x15B0180", VA = "0x15B0180")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x15B0274", Offset = "0x15B0274", VA = "0x15B0274")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x15B034C", Offset = "0x15B034C", VA = "0x15B034C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x15B03AC", Offset = "0x15B03AC", VA = "0x15B03AC")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	public static class QuaTools
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x15B03DC", Offset = "0x15B03DC", VA = "0x15B03DC")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x15B0528", Offset = "0x15B0528", VA = "0x15B0528")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x15B0674", Offset = "0x15B0674", VA = "0x15B0674")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x15B0788", Offset = "0x15B0788", VA = "0x15B0788")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x15B089C", Offset = "0x15B089C", VA = "0x15B089C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x15B0A28", Offset = "0x15B0A28", VA = "0x15B0A28")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x15B0AF8", Offset = "0x15B0AF8", VA = "0x15B0AF8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x15B0C4C", Offset = "0x15B0C4C", VA = "0x15B0C4C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x15B0ED0", Offset = "0x15B0ED0", VA = "0x15B0ED0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x15B10E4", Offset = "0x15B10E4", VA = "0x15B10E4")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x15AD060", Offset = "0x15AD060", VA = "0x15AD060")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000010")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000005")]
		public static T instance
		{
			[Token(Token = "0x6000089")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008A")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600008B")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737778", Offset = "0x737778")]
		public bool fixTransforms;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000006")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x15B139C", Offset = "0x15B139C", VA = "0x15B139C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		private bool isAnimated
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x15B1698", Offset = "0x15B1698", VA = "0x15B1698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x15B1264", Offset = "0x15B1264", VA = "0x15B1264")]
		public void Disable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x15B12FC", Offset = "0x15B12FC", VA = "0x15B12FC", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x15B1300", Offset = "0x15B1300", VA = "0x15B1300", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x15B1304", Offset = "0x15B1304", VA = "0x15B1304", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x15B1308", Offset = "0x15B1308", VA = "0x15B1308")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x15B1398", Offset = "0x15B1398", VA = "0x15B1398")]
		private void Start()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15B1340", Offset = "0x15B1340", VA = "0x15B1340")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x15B164C", Offset = "0x15B164C", VA = "0x15B164C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x15B148C", Offset = "0x15B148C", VA = "0x15B148C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x15B1754", Offset = "0x15B1754", VA = "0x15B1754")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x15B17B0", Offset = "0x15B17B0", VA = "0x15B17B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x15B180C", Offset = "0x15B180C", VA = "0x15B180C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x15B1854", Offset = "0x15B1854", VA = "0x15B1854")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x15B1864", Offset = "0x15B1864", VA = "0x15B1864")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x15B191C", Offset = "0x15B191C", VA = "0x15B191C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x15B19D4", Offset = "0x15B19D4", VA = "0x15B19D4")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x15B1A8C", Offset = "0x15B1A8C", VA = "0x15B1A8C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public static class V3Tools
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x15B1A94", Offset = "0x15B1A94", VA = "0x15B1A94")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x15B1B8C", Offset = "0x15B1B8C", VA = "0x15B1B8C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x15B1C84", Offset = "0x15B1C84", VA = "0x15B1C84")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x15B1D7C", Offset = "0x15B1D7C", VA = "0x15B1D7C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x15B1E7C", Offset = "0x15B1E7C", VA = "0x15B1E7C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x15B20B8", Offset = "0x15B20B8", VA = "0x15B20B8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x15B2308", Offset = "0x15B2308", VA = "0x15B2308")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x15B2508", Offset = "0x15B2508", VA = "0x15B2508")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000014")]
	public static class Warning
	{
		[Token(Token = "0x2000070")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x15B26E4", Offset = "0x15B26E4", VA = "0x15B26E4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x15B2B34", Offset = "0x15B2B34", VA = "0x15B2B34")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000015")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x10B4214", Offset = "0x10B4214", VA = "0x10B4214")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10B4270", Offset = "0x10B4270", VA = "0x10B4270")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x10B4484", Offset = "0x10B4484", VA = "0x10B4484")]
		public VRIKPlatform()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x736E3C", Offset = "0x736E3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x736E3C", Offset = "0x736E3C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x10B6010", Offset = "0x10B6010", VA = "0x10B6010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D4C0", Offset = "0x73D4C0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x10B605C", Offset = "0x10B605C", VA = "0x10B605C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D4F8", Offset = "0x73D4F8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x10B60A8", Offset = "0x10B60A8", VA = "0x10B60A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D530", Offset = "0x73D530")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x10B60F4", Offset = "0x10B60F4", VA = "0x10B60F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D568", Offset = "0x73D568")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x10B6140", Offset = "0x10B6140", VA = "0x10B6140")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x10B61DC", Offset = "0x10B61DC", VA = "0x10B61DC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10B61FC", Offset = "0x10B61FC", VA = "0x10B61FC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x10B622C", Offset = "0x10B622C", VA = "0x10B622C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x10B625C", Offset = "0x10B625C", VA = "0x10B625C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x10B629C", Offset = "0x10B629C", VA = "0x10B629C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x10B62E0", Offset = "0x10B62E0", VA = "0x10B62E0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x10B6304", Offset = "0x10B6304", VA = "0x10B6304")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x10B6328", Offset = "0x10B6328", VA = "0x10B6328")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x10B6350", Offset = "0x10B6350", VA = "0x10B6350")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x10B637C", Offset = "0x10B637C", VA = "0x10B637C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x10B63A8", Offset = "0x10B63A8", VA = "0x10B63A8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x10B6160", Offset = "0x10B6160", VA = "0x10B6160")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x10B63D0", Offset = "0x10B63D0", VA = "0x10B63D0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x10B63DC", Offset = "0x10B63DC", VA = "0x10B63DC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x10B63E8", Offset = "0x10B63E8", VA = "0x10B63E8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x10B66D0", Offset = "0x10B66D0", VA = "0x10B66D0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x10B6778", Offset = "0x10B6778", VA = "0x10B6778", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x10B6ABC", Offset = "0x10B6ABC", VA = "0x10B6ABC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x10B6FA4", Offset = "0x10B6FA4", VA = "0x10B6FA4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x10B6FD8", Offset = "0x10B6FD8", VA = "0x10B6FD8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000008")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x10B6588", Offset = "0x10B6588", VA = "0x10B6588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x10B71A0", Offset = "0x10B71A0", VA = "0x10B71A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x10B6944", Offset = "0x10B6944", VA = "0x10B6944")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x10B7058", Offset = "0x10B7058", VA = "0x10B7058")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700000A")]
		public bool isValid
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x10B77A0", Offset = "0x10B77A0", VA = "0x10B77A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CB")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x10B7810", Offset = "0x10B7810", VA = "0x10B7810")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x10B7818", Offset = "0x10B7818", VA = "0x10B7818", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x10B7924", Offset = "0x10B7924", VA = "0x10B7924")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x10B792C", Offset = "0x10B792C", VA = "0x10B792C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700000B")]
		private bool positionChanged
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x10B7AF4", Offset = "0x10B7AF4", VA = "0x10B7AF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x10B7958", Offset = "0x10B7958", VA = "0x10B7958", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x10B7BB0", Offset = "0x10B7BB0", VA = "0x10B7BB0")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x10B7BB8", Offset = "0x10B7BB8", VA = "0x10B7BB8")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x10B7BE4", Offset = "0x10B7BE4", VA = "0x10B7BE4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x10B7D0C", Offset = "0x10B7D0C", VA = "0x10B7D0C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x10B7D14", Offset = "0x10B7D14", VA = "0x10B7D14")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700000C")]
		private bool rotationChanged
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x10B7EE0", Offset = "0x10B7EE0", VA = "0x10B7EE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x10B7D40", Offset = "0x10B7D40", VA = "0x10B7D40", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x10B7FB0", Offset = "0x10B7FB0", VA = "0x10B7FB0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x10B7FB8", Offset = "0x10B7FB8", VA = "0x10B7FB8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class Constraints
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7377B0", Offset = "0x7377B0")]
		public float positionWeight;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7377C8", Offset = "0x7377C8")]
		public float rotationWeight;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x10B7FE4", Offset = "0x10B7FE4", VA = "0x10B7FE4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x10B6A68", Offset = "0x10B6A68", VA = "0x10B6A68")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x10B6C44", Offset = "0x10B6C44", VA = "0x10B6C44")]
		public void Update()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x10B736C", Offset = "0x10B736C", VA = "0x10B736C")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000071")]
		public enum DOF
		{
			[Token(Token = "0x400032F")]
			One,
			[Token(Token = "0x4000330")]
			Three
		}

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7377E0", Offset = "0x7377E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7377E0", Offset = "0x7377E0")]
		public float weight;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737834", Offset = "0x737834")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737834", Offset = "0x737834")]
		public float rotationWeight;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737888", Offset = "0x737888")]
		public DOF rotationDOF;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7378C0", Offset = "0x7378C0")]
		public Transform bone1;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7378F8", Offset = "0x7378F8")]
		public Transform bone2;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737930", Offset = "0x737930")]
		public Transform bone3;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737968", Offset = "0x737968")]
		public Transform tip;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7379A0", Offset = "0x7379A0")]
		public Transform target;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7379D8", Offset = "0x7379D8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700000D")]
		public bool initiated
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x10BF1B0", Offset = "0x10BF1B0", VA = "0x10BF1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5A0", Offset = "0x73D5A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x10BF1B8", Offset = "0x10BF1B8", VA = "0x10BF1B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5B0", Offset = "0x73D5B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x10BF1C4", Offset = "0x10BF1C4", VA = "0x10BF1C4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x10BF1E4", Offset = "0x10BF1E4", VA = "0x10BF1E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x10BF204", Offset = "0x10BF204", VA = "0x10BF204")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x10BF224", Offset = "0x10BF224", VA = "0x10BF224")]
			set
			{
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x10BF244", Offset = "0x10BF244", VA = "0x10BF244")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x10BF344", Offset = "0x10BF344", VA = "0x10BF344")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x10BF758", Offset = "0x10BF758", VA = "0x10BF758")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x10BF828", Offset = "0x10BF828", VA = "0x10BF828")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x10BFBDC", Offset = "0x10BFBDC", VA = "0x10BFBDC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7379E8", Offset = "0x7379E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7379E8", Offset = "0x7379E8")]
		public float weight;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737A3C", Offset = "0x737A3C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000010")]
		public bool initiated
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x10BFBEC", Offset = "0x10BFBEC", VA = "0x10BFBEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5C0", Offset = "0x73D5C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x10BFBF4", Offset = "0x10BFBF4", VA = "0x10BFBF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5D0", Offset = "0x73D5D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x10BFC00", Offset = "0x10BFC00", VA = "0x10BFC00")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x10BFC88", Offset = "0x10BFC88", VA = "0x10BFC88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D5E0", Offset = "0x73D5E0")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x10BFFAC", Offset = "0x10BFFAC", VA = "0x10BFFAC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x10C011C", Offset = "0x10C011C", VA = "0x10C011C")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x10BFEA4", Offset = "0x10BFEA4", VA = "0x10BFEA4")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x10C0284", Offset = "0x10C0284", VA = "0x10C0284", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x10C0344", Offset = "0x10C0344", VA = "0x10C0344")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x10C03C8", Offset = "0x10C03C8", VA = "0x10C03C8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x10C0430", Offset = "0x10C0430", VA = "0x10C0430", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x10C0434", Offset = "0x10C0434", VA = "0x10C0434", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x10C0438", Offset = "0x10C0438", VA = "0x10C0438")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000072")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737A4C", Offset = "0x737A4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737A4C", Offset = "0x737A4C")]
		public float weight;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737AA0", Offset = "0x737AA0")]
		public Grounding solver;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x60000F7")]
		public abstract void ResetPosition();

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x10C1438", Offset = "0x10C1438", VA = "0x10C1438")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x10C170C", Offset = "0x10C170C", VA = "0x10C170C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x10C157C", Offset = "0x10C157C", VA = "0x10C157C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10C1740", Offset = "0x10C1740", VA = "0x10C1740")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FC")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60000FD")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x10C1948", Offset = "0x10C1948", VA = "0x10C1948")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x736E9C", Offset = "0x736E9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x736E9C", Offset = "0x736E9C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737AD8", Offset = "0x737AD8")]
		public BipedIK ik;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737B10", Offset = "0x737B10")]
		public float spineBend;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737B48", Offset = "0x737B48")]
		public float spineSpeed;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10C1C0C", Offset = "0x10C1C0C", VA = "0x10C1C0C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D618", Offset = "0x73D618")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10C1C58", Offset = "0x10C1C58", VA = "0x10C1C58", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D650", Offset = "0x73D650")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x10C1CA4", Offset = "0x10C1CA4", VA = "0x10C1CA4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x10C1D28", Offset = "0x10C1D28", VA = "0x10C1D28")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x10C1DD8", Offset = "0x10C1DD8", VA = "0x10C1DD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x10C1E8C", Offset = "0x10C1E8C", VA = "0x10C1E8C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x10C2144", Offset = "0x10C2144", VA = "0x10C2144")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x10C2198", Offset = "0x10C2198", VA = "0x10C2198")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x10C26EC", Offset = "0x10C26EC", VA = "0x10C26EC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x10C27C0", Offset = "0x10C27C0", VA = "0x10C27C0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x10C2950", Offset = "0x10C2950", VA = "0x10C2950")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10C2AC0", Offset = "0x10C2AC0", VA = "0x10C2AC0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x736EFC", Offset = "0x736EFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x736EFC", Offset = "0x736EFC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000073")]
		public class SpineEffector
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A6F0", Offset = "0x73A6F0")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A728", Offset = "0x73A728")]
			public float horizontalWeight;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A760", Offset = "0x73A760")]
			public float verticalWeight;

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x10C3934", Offset = "0x10C3934", VA = "0x10C3934")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x10C3944", Offset = "0x10C3944", VA = "0x10C3944")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737B80", Offset = "0x737B80")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737BB8", Offset = "0x737BB8")]
		public float spineBend;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737BF0", Offset = "0x737BF0")]
		public float spineSpeed;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10C2B40", Offset = "0x10C2B40", VA = "0x10C2B40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D688", Offset = "0x73D688")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x10C2B8C", Offset = "0x10C2B8C", VA = "0x10C2B8C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D6C0", Offset = "0x73D6C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10C2BD8", Offset = "0x10C2BD8", VA = "0x10C2BD8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D6F8", Offset = "0x73D6F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10C2C24", Offset = "0x10C2C24", VA = "0x10C2C24", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10C2CA8", Offset = "0x10C2CA8", VA = "0x10C2CA8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x10C2D40", Offset = "0x10C2D40", VA = "0x10C2D40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x10C3000", Offset = "0x10C3000", VA = "0x10C3000")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x10C300C", Offset = "0x10C300C", VA = "0x10C300C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x10C2DFC", Offset = "0x10C2DFC", VA = "0x10C2DFC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x10C3018", Offset = "0x10C3018", VA = "0x10C3018")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x10C34BC", Offset = "0x10C34BC", VA = "0x10C34BC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10C367C", Offset = "0x10C367C", VA = "0x10C367C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x10C37B4", Offset = "0x10C37B4", VA = "0x10C37B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x10C38B4", Offset = "0x10C38B4", VA = "0x10C38B4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x736F5C", Offset = "0x736F5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x736F5C", Offset = "0x736F5C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C28", Offset = "0x737C28")]
		public Transform pelvis;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C60", Offset = "0x737C60")]
		public Transform characterRoot;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C98", Offset = "0x737C98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737C98", Offset = "0x737C98")]
		public float rootRotationWeight;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737CEC", Offset = "0x737CEC")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737D24", Offset = "0x737D24")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x10C398C", Offset = "0x10C398C", VA = "0x10C398C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D730", Offset = "0x73D730")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x10C39D8", Offset = "0x10C39D8", VA = "0x10C39D8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D768", Offset = "0x73D768")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10C3A24", Offset = "0x10C3A24", VA = "0x10C3A24", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x10C3A40", Offset = "0x10C3A40", VA = "0x10C3A40")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x10C3C30", Offset = "0x10C3C30", VA = "0x10C3C30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x10C3D30", Offset = "0x10C3D30", VA = "0x10C3D30")]
		private void Update()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x10C4160", Offset = "0x10C4160", VA = "0x10C4160")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x10C452C", Offset = "0x10C452C", VA = "0x10C452C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10C47A0", Offset = "0x10C47A0", VA = "0x10C47A0")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10C4AC0", Offset = "0x10C4AC0", VA = "0x10C4AC0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x10C4C4C", Offset = "0x10C4C4C", VA = "0x10C4C4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x10C4E14", Offset = "0x10C4E14", VA = "0x10C4E14")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x736FBC", Offset = "0x736FBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x736FBC", Offset = "0x736FBC")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000074")]
		public struct Foot
		{
			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x7E7D68", Offset = "0x7E7D68", VA = "0x7E7D68")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737D5C", Offset = "0x737D5C")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737D94", Offset = "0x737D94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737D94", Offset = "0x737D94")]
		public float rootRotationWeight;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737DE8", Offset = "0x737DE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737DE8", Offset = "0x737DE8")]
		public float minRootRotation;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737E40", Offset = "0x737E40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737E40", Offset = "0x737E40")]
		public float maxRootRotation;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737E98", Offset = "0x737E98")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737ED0", Offset = "0x737ED0")]
		public float maxLegOffset;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F08", Offset = "0x737F08")]
		public float maxForeLegOffset;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F40", Offset = "0x737F40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737F40", Offset = "0x737F40")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F94", Offset = "0x737F94")]
		public Transform characterRoot;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737FCC", Offset = "0x737FCC")]
		public Transform pelvis;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738004", Offset = "0x738004")]
		public Transform lastSpineBone;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73803C", Offset = "0x73803C")]
		public Transform head;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x11F8090", Offset = "0x11F8090", VA = "0x11F8090", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D7A0", Offset = "0x73D7A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x11F80DC", Offset = "0x11F80DC", VA = "0x11F80DC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D7D8", Offset = "0x73D7D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x11F8128", Offset = "0x11F8128", VA = "0x11F8128", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x11F81E0", Offset = "0x11F81E0", VA = "0x11F81E0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x11F8310", Offset = "0x11F8310", VA = "0x11F8310")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x11F84BC", Offset = "0x11F84BC", VA = "0x11F84BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x11F8524", Offset = "0x11F8524", VA = "0x11F8524")]
		private void Update()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x11F85DC", Offset = "0x11F85DC", VA = "0x11F85DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x11F88C0", Offset = "0x11F88C0", VA = "0x11F88C0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x11F8E74", Offset = "0x11F8E74", VA = "0x11F8E74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x11F8FC0", Offset = "0x11F8FC0", VA = "0x11F8FC0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x11F9350", Offset = "0x11F9350", VA = "0x11F9350")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x11F9B48", Offset = "0x11F9B48", VA = "0x11F9B48")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x11FA070", Offset = "0x11FA070", VA = "0x11FA070")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x11FA1D0", Offset = "0x11FA1D0", VA = "0x11FA1D0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x11FA4AC", Offset = "0x11FA4AC", VA = "0x11FA4AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x11FA4E4", Offset = "0x11FA4E4", VA = "0x11FA4E4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x11FA69C", Offset = "0x11FA69C", VA = "0x11FA69C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73701C", Offset = "0x73701C")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738084", Offset = "0x738084")]
		public VRIK ik;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x11FA7F4", Offset = "0x11FA7F4", VA = "0x11FA7F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D810", Offset = "0x73D810")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x11FA7F8", Offset = "0x11FA7F8", VA = "0x11FA7F8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D848", Offset = "0x73D848")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x11FA7FC", Offset = "0x11FA7FC", VA = "0x11FA7FC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D880", Offset = "0x73D880")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x11FA800", Offset = "0x11FA800", VA = "0x11FA800", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x11FA818", Offset = "0x11FA818", VA = "0x11FA818")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x11FA8B0", Offset = "0x11FA8B0", VA = "0x11FA8B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x11FA964", Offset = "0x11FA964", VA = "0x11FA964")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x11FAB54", Offset = "0x11FAB54", VA = "0x11FAB54")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x11FADF0", Offset = "0x11FADF0", VA = "0x11FADF0")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x11FAEF8", Offset = "0x11FAEF8", VA = "0x11FAEF8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x11FB0F8", Offset = "0x11FB0F8", VA = "0x11FB0F8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x11FB230", Offset = "0x11FB230", VA = "0x11FB230")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x11FB380", Offset = "0x11FB380", VA = "0x11FB380")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		public enum Quality
		{
			[Token(Token = "0x4000339")]
			Fastest,
			[Token(Token = "0x400033A")]
			Simple,
			[Token(Token = "0x400033B")]
			Best
		}

		[Token(Token = "0x2000076")]
		public class Leg
		{
			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A798", Offset = "0x73A798")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7A8", Offset = "0x73A7A8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7B8", Offset = "0x73A7B8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7C8", Offset = "0x73A7C8")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7D8", Offset = "0x73A7D8")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7E8", Offset = "0x73A7E8")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7F8", Offset = "0x73A7F8")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x1700005C")]
			public bool isGrounded
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x11FCE38", Offset = "0x11FCE38", VA = "0x11FCE38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF94", Offset = "0x73EF94")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x11FCE40", Offset = "0x11FCE40", VA = "0x11FCE40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFA4", Offset = "0x73EFA4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005D")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x11FCE4C", Offset = "0x11FCE4C", VA = "0x11FCE4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFB4", Offset = "0x73EFB4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x11FCE58", Offset = "0x11FCE58", VA = "0x11FCE58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFC4", Offset = "0x73EFC4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005E")]
			public bool initiated
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x11FCE64", Offset = "0x11FCE64", VA = "0x11FCE64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFD4", Offset = "0x73EFD4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x11FCE6C", Offset = "0x11FCE6C", VA = "0x11FCE6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFE4", Offset = "0x73EFE4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			public float heightFromGround
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x11FCE78", Offset = "0x11FCE78", VA = "0x11FCE78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFF4", Offset = "0x73EFF4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x11FCE80", Offset = "0x11FCE80", VA = "0x11FCE80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F004", Offset = "0x73F004")]
				private set
				{
				}
			}

			[Token(Token = "0x17000060")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x11FCE88", Offset = "0x11FCE88", VA = "0x11FCE88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F014", Offset = "0x73F014")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x11FCE94", Offset = "0x11FCE94", VA = "0x11FCE94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F024", Offset = "0x73F024")]
				private set
				{
				}
			}

			[Token(Token = "0x17000061")]
			public Transform transform
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x11FCEA0", Offset = "0x11FCEA0", VA = "0x11FCEA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F034", Offset = "0x73F034")]
				get
				{
					return null;
				}
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x11FCEA8", Offset = "0x11FCEA8", VA = "0x11FCEA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F044", Offset = "0x73F044")]
				private set
				{
				}
			}

			[Token(Token = "0x17000062")]
			public float IKOffset
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x11FCEB0", Offset = "0x11FCEB0", VA = "0x11FCEB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F054", Offset = "0x73F054")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x11FCEB8", Offset = "0x11FCEB8", VA = "0x11FCEB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F064", Offset = "0x73F064")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x11FD838", Offset = "0x11FD838", VA = "0x11FD838")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000064")]
			private float rootYOffset
			{
				[Token(Token = "0x600046B")]
				[Address(RVA = "0x11FDB2C", Offset = "0x11FDB2C", VA = "0x11FDB2C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x11FBAA8", Offset = "0x11FBAA8", VA = "0x11FBAA8")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x11FCEC0", Offset = "0x11FCEC0", VA = "0x11FCEC0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x11FC958", Offset = "0x11FC958", VA = "0x11FC958")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x11FBBB4", Offset = "0x11FBBB4", VA = "0x11FBBB4")]
			public void Process()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x11FD4D0", Offset = "0x11FD4D0", VA = "0x11FD4D0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x11FCF0C", Offset = "0x11FCF0C", VA = "0x11FCF0C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x11FD9B8", Offset = "0x11FD9B8", VA = "0x11FD9B8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x11FD160", Offset = "0x11FD160", VA = "0x11FD160")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x11FD268", Offset = "0x11FD268", VA = "0x11FD268")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x11FDAB4", Offset = "0x11FDAB4", VA = "0x11FDAB4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x11FD8C4", Offset = "0x11FD8C4", VA = "0x11FD8C4")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x11FDC60", Offset = "0x11FDC60", VA = "0x11FDC60")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x11FB9F8", Offset = "0x11FB9F8", VA = "0x11FB9F8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000077")]
		public class Pelvis
		{
			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A808", Offset = "0x73A808")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A818", Offset = "0x73A818")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000065")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x11FDD50", Offset = "0x11FDD50", VA = "0x11FDD50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F074", Offset = "0x73F074")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x11FDD5C", Offset = "0x11FDD5C", VA = "0x11FDD5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F084", Offset = "0x73F084")]
				private set
				{
				}
			}

			[Token(Token = "0x17000066")]
			public float heightOffset
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x11FDD68", Offset = "0x11FDD68", VA = "0x11FDD68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F094", Offset = "0x73F094")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x11FDD70", Offset = "0x11FDD70", VA = "0x11FDD70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0A4", Offset = "0x73F0A4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x11FBB8C", Offset = "0x11FBB8C", VA = "0x11FBB8C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x11FC8A8", Offset = "0x11FC8A8", VA = "0x11FC8A8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x11FDD78", Offset = "0x11FDD78", VA = "0x11FDD78")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x11FC424", Offset = "0x11FC424", VA = "0x11FC424")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x11FBAA0", Offset = "0x11FBAA0", VA = "0x11FBAA0")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7380BC", Offset = "0x7380BC")]
		public LayerMask layers;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7380F4", Offset = "0x7380F4")]
		public float maxStep;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73812C", Offset = "0x73812C")]
		public float heightOffset;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738164", Offset = "0x738164")]
		public float footSpeed;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73819C", Offset = "0x73819C")]
		public float footRadius;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7381D4", Offset = "0x7381D4")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738220", Offset = "0x738220")]
		public float prediction;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738258", Offset = "0x738258")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738258", Offset = "0x738258")]
		public float footRotationWeight;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7382AC", Offset = "0x7382AC")]
		public float footRotationSpeed;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7382E4", Offset = "0x7382E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7382E4", Offset = "0x7382E4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73833C", Offset = "0x73833C")]
		public bool rotateSolver;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738374", Offset = "0x738374")]
		public float pelvisSpeed;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7383AC", Offset = "0x7383AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7383AC", Offset = "0x7383AC")]
		public float pelvisDamper;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738400", Offset = "0x738400")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738438", Offset = "0x738438")]
		public float liftPelvisWeight;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738470", Offset = "0x738470")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7384A8", Offset = "0x7384A8")]
		public Quality quality;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7384E0", Offset = "0x7384E0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7384F0", Offset = "0x7384F0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738500", Offset = "0x738500")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738510", Offset = "0x738510")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738520", Offset = "0x738520")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000011")]
		public Leg[] legs
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x11FB3E0", Offset = "0x11FB3E0", VA = "0x11FB3E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8B8", Offset = "0x73D8B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x11FB3E8", Offset = "0x11FB3E8", VA = "0x11FB3E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8C8", Offset = "0x73D8C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x11FB3F0", Offset = "0x11FB3F0", VA = "0x11FB3F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8D8", Offset = "0x73D8D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x11FB3F8", Offset = "0x11FB3F8", VA = "0x11FB3F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8E8", Offset = "0x73D8E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool isGrounded
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x11FB400", Offset = "0x11FB400", VA = "0x11FB400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8F8", Offset = "0x73D8F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x11FB408", Offset = "0x11FB408", VA = "0x11FB408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D908", Offset = "0x73D908")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Transform root
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x11FB414", Offset = "0x11FB414", VA = "0x11FB414")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D918", Offset = "0x73D918")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x11FB41C", Offset = "0x11FB41C", VA = "0x11FB41C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D928", Offset = "0x73D928")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x11FB424", Offset = "0x11FB424", VA = "0x11FB424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D938", Offset = "0x73D938")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x11FB43C", Offset = "0x11FB43C", VA = "0x11FB43C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D948", Offset = "0x73D948")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool rootGrounded
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x11FB45C", Offset = "0x11FB45C", VA = "0x11FB45C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public Vector3 up
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x11FB890", Offset = "0x11FB890", VA = "0x11FB890")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000018")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x11FCA0C", Offset = "0x11FCA0C", VA = "0x11FCA0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x11FB4B0", Offset = "0x11FB4B0", VA = "0x11FB4B0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x11FB91C", Offset = "0x11FB91C", VA = "0x11FB91C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x11F8BC4", Offset = "0x11F8BC4", VA = "0x11F8BC4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x11F9E08", Offset = "0x11F9E08", VA = "0x11F9E08")]
		public void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x11FC690", Offset = "0x11FC690", VA = "0x11FC690")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x11F815C", Offset = "0x11F815C", VA = "0x11F815C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x11FBB9C", Offset = "0x11FBB9C", VA = "0x11FBB9C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x11FCADC", Offset = "0x11FCADC", VA = "0x11FCADC")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x11FCC44", Offset = "0x11FCC44", VA = "0x11FCC44")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x11FCD48", Offset = "0x11FCD48", VA = "0x11FCD48")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x11FA7AC", Offset = "0x11FA7AC", VA = "0x11FA7AC")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x737054", Offset = "0x737054")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737054", Offset = "0x737054")]
	public class AimIK : IK
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x10B53DC", Offset = "0x10B53DC", VA = "0x10B53DC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D958", Offset = "0x73D958")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x10B5428", Offset = "0x10B5428", VA = "0x10B5428", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D990", Offset = "0x73D990")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x10B5474", Offset = "0x10B5474", VA = "0x10B5474")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D9C8", Offset = "0x73D9C8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10B54C0", Offset = "0x10B54C0", VA = "0x10B54C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DA00", Offset = "0x73DA00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10B550C", Offset = "0x10B550C", VA = "0x10B550C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DA38", Offset = "0x73DA38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x10B5558", Offset = "0x10B5558", VA = "0x10B5558", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x10B5560", Offset = "0x10B5560", VA = "0x10B5560")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7370B4", Offset = "0x7370B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7370B4", Offset = "0x7370B4")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x10B7600", Offset = "0x10B7600", VA = "0x10B7600", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DA70", Offset = "0x73DA70")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10B764C", Offset = "0x10B764C", VA = "0x10B764C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DAA8", Offset = "0x73DAA8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x10B7698", Offset = "0x10B7698", VA = "0x10B7698")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DAE0", Offset = "0x73DAE0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10B76E4", Offset = "0x10B76E4", VA = "0x10B76E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DB18", Offset = "0x73DB18")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x10B7730", Offset = "0x10B7730", VA = "0x10B7730", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x10B7738", Offset = "0x10B7738", VA = "0x10B7738")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x737114", Offset = "0x737114")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737114", Offset = "0x737114")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x10B8054", Offset = "0x10B8054", VA = "0x10B8054", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DB50", Offset = "0x73DB50")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x10B80A0", Offset = "0x10B80A0", VA = "0x10B80A0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DB88", Offset = "0x73DB88")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x10B80EC", Offset = "0x10B80EC", VA = "0x10B80EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DBC0", Offset = "0x73DBC0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x10B8138", Offset = "0x10B8138", VA = "0x10B8138")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DBF8", Offset = "0x73DBF8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x10B8184", Offset = "0x10B8184", VA = "0x10B8184", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10B818C", Offset = "0x10B818C", VA = "0x10B818C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x737174", Offset = "0x737174")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737174", Offset = "0x737174")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10B880C", Offset = "0x10B880C", VA = "0x10B880C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DC30", Offset = "0x73DC30")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x10B8858", Offset = "0x10B8858", VA = "0x10B8858", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DC68", Offset = "0x73DC68")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x10B88A4", Offset = "0x10B88A4", VA = "0x10B88A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DCA0", Offset = "0x73DCA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x10B88F0", Offset = "0x10B88F0", VA = "0x10B88F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DCD8", Offset = "0x73DCD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x10B893C", Offset = "0x10B893C", VA = "0x10B893C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x10B8944", Offset = "0x10B8944", VA = "0x10B8944")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7371D4", Offset = "0x7371D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7371D4", Offset = "0x7371D4")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x10C04A0", Offset = "0x10C04A0", VA = "0x10C04A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DD10", Offset = "0x73DD10")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x10C04EC", Offset = "0x10C04EC", VA = "0x10C04EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DD48", Offset = "0x73DD48")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x10C0538", Offset = "0x10C0538", VA = "0x10C0538")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DD80", Offset = "0x73DD80")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x10C0584", Offset = "0x10C0584", VA = "0x10C0584")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DDB8", Offset = "0x73DDB8")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x10C05D0", Offset = "0x10C05D0", VA = "0x10C05D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DDF0", Offset = "0x73DDF0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x10C061C", Offset = "0x10C061C", VA = "0x10C061C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DE28", Offset = "0x73DE28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x10C0668", Offset = "0x10C0668", VA = "0x10C0668")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x10C068C", Offset = "0x10C068C", VA = "0x10C068C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x10C0694", Offset = "0x10C0694", VA = "0x10C0694")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x10C084C", Offset = "0x10C084C", VA = "0x10C084C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x10C0B9C", Offset = "0x10C0B9C", VA = "0x10C0B9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DE60", Offset = "0x73DE60")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x10C0BBC", Offset = "0x10C0BBC", VA = "0x10C0BBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DE98", Offset = "0x73DE98")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x10C0C70", Offset = "0x10C0C70", VA = "0x10C0C70")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000182")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1200864", Offset = "0x1200864", VA = "0x1200864", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1200950", Offset = "0x1200950", VA = "0x1200950", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1200B0C", Offset = "0x1200B0C", VA = "0x1200B0C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000186")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000187")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1200B6C", Offset = "0x1200B6C", VA = "0x1200B6C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738530", Offset = "0x738530")]
		public IK[] IKComponents;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738568", Offset = "0x738568")]
		public Animator animator;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000019")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1203A80", Offset = "0x1203A80", VA = "0x1203A80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1203B1C", Offset = "0x1203B1C", VA = "0x1203B1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1203B8C", Offset = "0x1203B8C", VA = "0x1203B8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1203C48", Offset = "0x1203C48", VA = "0x1203C48")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1203C84", Offset = "0x1203C84", VA = "0x1203C84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1203BC0", Offset = "0x1203BC0", VA = "0x1203BC0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1203D10", Offset = "0x1203D10", VA = "0x1203D10")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737234", Offset = "0x737234")]
	public class LegIK : IK
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xF46AE4", Offset = "0xF46AE4", VA = "0xF46AE4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DED0", Offset = "0x73DED0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xF46B50", Offset = "0xF46B50", VA = "0xF46B50", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DF08", Offset = "0x73DF08")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xF46BBC", Offset = "0xF46BBC", VA = "0xF46BBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DF40", Offset = "0x73DF40")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xF46C08", Offset = "0xF46C08", VA = "0xF46C08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DF78", Offset = "0x73DF78")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xF46C54", Offset = "0xF46C54", VA = "0xF46C54", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xF46C5C", Offset = "0xF46C5C", VA = "0xF46C5C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73726C", Offset = "0x73726C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73726C", Offset = "0x73726C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xF46CC4", Offset = "0xF46CC4", VA = "0xF46CC4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DFB0", Offset = "0x73DFB0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xF46D10", Offset = "0xF46D10", VA = "0xF46D10", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DFE8", Offset = "0x73DFE8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xF46D5C", Offset = "0xF46D5C", VA = "0xF46D5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E020", Offset = "0x73E020")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xF46DA8", Offset = "0xF46DA8", VA = "0xF46DA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E058", Offset = "0x73E058")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xF46DF4", Offset = "0xF46DF4", VA = "0xF46DF4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xF46DFC", Offset = "0xF46DFC", VA = "0xF46DFC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7372CC", Offset = "0x7372CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7372CC", Offset = "0x7372CC")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xF46E64", Offset = "0xF46E64", VA = "0xF46E64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E090", Offset = "0x73E090")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xF46EB0", Offset = "0xF46EB0", VA = "0xF46EB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E0C8", Offset = "0x73E0C8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xF46EFC", Offset = "0xF46EFC", VA = "0xF46EFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E100", Offset = "0x73E100")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xF46F48", Offset = "0xF46F48", VA = "0xF46F48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E138", Offset = "0x73E138")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xF46F94", Offset = "0xF46F94", VA = "0xF46F94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xF46F9C", Offset = "0xF46F9C", VA = "0xF46F9C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73732C", Offset = "0x73732C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73732C", Offset = "0x73732C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x15AA190", Offset = "0x15AA190", VA = "0x15AA190", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E170", Offset = "0x73E170")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x15AA1DC", Offset = "0x15AA1DC", VA = "0x15AA1DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E1A8", Offset = "0x73E1A8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x15AA228", Offset = "0x15AA228", VA = "0x15AA228")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E1E0", Offset = "0x73E1E0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x15AA274", Offset = "0x15AA274", VA = "0x15AA274")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E218", Offset = "0x73E218")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x15AA2C0", Offset = "0x15AA2C0", VA = "0x15AA2C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x15AA2C8", Offset = "0x15AA2C8", VA = "0x15AA2C8")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73738C", Offset = "0x73738C")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		public class References
		{
			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x17000067")]
			public bool isFilled
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x15AB7B0", Offset = "0x15AB7B0", VA = "0x15AB7B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000068")]
			public bool isEmpty
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x15AB334", Offset = "0x15AB334", VA = "0x15AB334")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x15ABB9C", Offset = "0x15ABB9C", VA = "0x15ABB9C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x15AAF20", Offset = "0x15AAF20", VA = "0x15AAF20")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x15ABB94", Offset = "0x15ABB94", VA = "0x15ABB94")]
			public References()
			{
			}
		}

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x7385A0", Offset = "0x7385A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7385A0", Offset = "0x7385A0")]
		public References references;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73861C", Offset = "0x73861C")]
		public IKSolverVR solver;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x15AADD4", Offset = "0x15AADD4", VA = "0x15AADD4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E250", Offset = "0x73E250")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x15AAE40", Offset = "0x15AAE40", VA = "0x15AAE40", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E288", Offset = "0x73E288")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x15AAEAC", Offset = "0x15AAEAC", VA = "0x15AAEAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E2C0", Offset = "0x73E2C0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x15AAEF8", Offset = "0x15AAEF8", VA = "0x15AAEF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E2F8", Offset = "0x73E2F8")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x15AB290", Offset = "0x15AB290", VA = "0x15AB290")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E330", Offset = "0x73E330")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x15AB2B8", Offset = "0x15AB2B8", VA = "0x15AB2B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x15AB2C0", Offset = "0x15AB2C0", VA = "0x15AB2C0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x15ABB0C", Offset = "0x15ABB0C", VA = "0x15ABB0C")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class FABRIKChain
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738654", Offset = "0x738654")]
		public float pull;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73866C", Offset = "0x73866C")]
		public float pin;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x10B81F4", Offset = "0x10B81F4", VA = "0x10B81F4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x10B82BC", Offset = "0x10B82BC", VA = "0x10B82BC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x10B82DC", Offset = "0x10B82DC", VA = "0x10B82DC")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x10B86AC", Offset = "0x10B86AC", VA = "0x10B86AC")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x10B83B0", Offset = "0x10B83B0", VA = "0x10B83B0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10B87A4", Offset = "0x10B87A4", VA = "0x10B87A4")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10B89AC", Offset = "0x10B89AC", VA = "0x10B89AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x10B8F14", Offset = "0x10B8F14", VA = "0x10B8F14")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x10B90D4", Offset = "0x10B90D4", VA = "0x10B90D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10B91CC", Offset = "0x10B91CC", VA = "0x10B91CC")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public class BendBone
		{
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A828", Offset = "0x73A828")]
			public Transform transform;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A860", Offset = "0x73A860")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A860", Offset = "0x73A860")]
			public float weight;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x10BC1FC", Offset = "0x10BC1FC", VA = "0x10BC1FC")]
			public BendBone()
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x10BC27C", Offset = "0x10BC27C", VA = "0x10BC27C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x10B998C", Offset = "0x10B998C", VA = "0x10B998C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x10B9D90", Offset = "0x10B9D90", VA = "0x10B9D90")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738684", Offset = "0x738684")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7386BC", Offset = "0x7386BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7386BC", Offset = "0x7386BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7386BC", Offset = "0x7386BC")]
		public float positionWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738734", Offset = "0x738734")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738734", Offset = "0x738734")]
		public float bodyWeight;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738788", Offset = "0x738788")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738788", Offset = "0x738788")]
		public float thighWeight;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7387DC", Offset = "0x7387DC")]
		public bool handsPullBody;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x738814", Offset = "0x738814")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738814", Offset = "0x738814")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738814", Offset = "0x738814")]
		public float rotationWeight;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73888C", Offset = "0x73888C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73888C", Offset = "0x73888C")]
		public float bodyClampWeight;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7388E0", Offset = "0x7388E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7388E0", Offset = "0x7388E0")]
		public float headClampWeight;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738934", Offset = "0x738934")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738934", Offset = "0x738934")]
		public float bendWeight;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738988", Offset = "0x738988")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7389C0", Offset = "0x7389C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7389C0", Offset = "0x7389C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7389C0", Offset = "0x7389C0")]
		public float CCDWeight;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A38", Offset = "0x738A38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738A38", Offset = "0x738A38")]
		public float roll;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A8C", Offset = "0x738A8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738A8C", Offset = "0x738A8C")]
		public float damper;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738AE4", Offset = "0x738AE4")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x738B1C", Offset = "0x738B1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738B1C", Offset = "0x738B1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738B1C", Offset = "0x738B1C")]
		public float postStretchWeight;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738B94", Offset = "0x738B94")]
		public float maxStretch;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738BCC", Offset = "0x738BCC")]
		public float stretchDamper;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738C04", Offset = "0x738C04")]
		public bool fixHead;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738C3C", Offset = "0x738C3C")]
		public Transform[] stretchBones;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x738C74", Offset = "0x738C74")]
		public Vector3 chestDirection;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738CAC", Offset = "0x738CAC")]
		public float chestDirectionWeight;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10B91D4", Offset = "0x10B91D4", VA = "0x10B91D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10B9504", Offset = "0x10B9504", VA = "0x10B9504")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x10B99C4", Offset = "0x10B99C4", VA = "0x10B99C4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x10B9DB8", Offset = "0x10B9DB8", VA = "0x10B9DB8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x10BA730", Offset = "0x10BA730", VA = "0x10BA730")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10BAA7C", Offset = "0x10BAA7C", VA = "0x10BAA7C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10BAE18", Offset = "0x10BAE18", VA = "0x10BAE18")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x10BB884", Offset = "0x10BB884", VA = "0x10BB884")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x10BA45C", Offset = "0x10BA45C", VA = "0x10BA45C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x10BBA94", Offset = "0x10BBA94", VA = "0x10BBA94")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x10BB740", Offset = "0x10BB740", VA = "0x10BB740")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x10BB5A4", Offset = "0x10BB5A4", VA = "0x10BB5A4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x10BBE00", Offset = "0x10BBE00", VA = "0x10BBE00")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x10BC080", Offset = "0x10BC080", VA = "0x10BC080")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200007A")]
		public class ChildConstraint
		{
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8D4", Offset = "0x73A8D4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A8E4", Offset = "0x73A8E4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000069")]
			public float nominalDistance
			{
				[Token(Token = "0x600047F")]
				[Address(RVA = "0x10BF140", Offset = "0x10BF140", VA = "0x10BF140")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0B4", Offset = "0x73F0B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000480")]
				[Address(RVA = "0x10BF148", Offset = "0x10BF148", VA = "0x10BF148")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0C4", Offset = "0x73F0C4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public bool isRigid
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0x10BF150", Offset = "0x10BF150", VA = "0x10BF150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0D4", Offset = "0x73F0D4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x10BF158", Offset = "0x10BF158", VA = "0x10BF158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0E4", Offset = "0x73F0E4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x10BF164", Offset = "0x10BF164", VA = "0x10BF164")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x10BCEC4", Offset = "0x10BCEC4", VA = "0x10BCEC4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x10BD404", Offset = "0x10BD404", VA = "0x10BD404")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x10BEE3C", Offset = "0x10BEE3C", VA = "0x10BEE3C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public enum Smoothing
		{
			[Token(Token = "0x4000378")]
			None,
			[Token(Token = "0x4000379")]
			Exponential,
			[Token(Token = "0x400037A")]
			Cubic
		}

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738CC4", Offset = "0x738CC4")]
		public float pin;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738CDC", Offset = "0x738CDC")]
		public float pull;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738CF4", Offset = "0x738CF4")]
		public float push;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738D0C", Offset = "0x738D0C")]
		public float pushParent;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738D24", Offset = "0x738D24")]
		public float reach;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400014E")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x10BC320", Offset = "0x10BC320", VA = "0x10BC320")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x10BC3EC", Offset = "0x10BC3EC", VA = "0x10BC3EC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x10BC4F8", Offset = "0x10BC4F8", VA = "0x10BC4F8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x10BC61C", Offset = "0x10BC61C", VA = "0x10BC61C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x10BC6F8", Offset = "0x10BC6F8", VA = "0x10BC6F8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x10BC7FC", Offset = "0x10BC7FC", VA = "0x10BC7FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10BCF1C", Offset = "0x10BCF1C", VA = "0x10BCF1C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x10BC98C", Offset = "0x10BC98C", VA = "0x10BC98C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10BD608", Offset = "0x10BD608", VA = "0x10BD608")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x10BD9AC", Offset = "0x10BD9AC", VA = "0x10BD9AC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x10BDD90", Offset = "0x10BDD90", VA = "0x10BDD90")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x10BE314", Offset = "0x10BE314", VA = "0x10BE314")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x10BE8E4", Offset = "0x10BE8E4", VA = "0x10BE8E4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x10BEB7C", Offset = "0x10BEB7C", VA = "0x10BEB7C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x10BE7DC", Offset = "0x10BE7DC", VA = "0x10BE7DC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x10BE0FC", Offset = "0x10BE0FC", VA = "0x10BE0FC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x10BE764", Offset = "0x10BE764", VA = "0x10BE764")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x10BEC64", Offset = "0x10BEC64", VA = "0x10BEC64")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x10BE684", Offset = "0x10BE684", VA = "0x10BE684")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x10BEA64", Offset = "0x10BEA64", VA = "0x10BEA64")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738D3C", Offset = "0x738D3C")]
		public float weight;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738D54", Offset = "0x738D54")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001A")]
		public bool initiated
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1200D3C", Offset = "0x1200D3C", VA = "0x1200D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E368", Offset = "0x73E368")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x1200D44", Offset = "0x1200D44", VA = "0x1200D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E378", Offset = "0x73E378")]
			private set
			{
			}
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1200B74", Offset = "0x1200B74", VA = "0x1200B74")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1200D50", Offset = "0x1200D50", VA = "0x1200D50")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1200DD4", Offset = "0x1200DD4", VA = "0x1200DD4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1200E80", Offset = "0x1200E80", VA = "0x1200E80")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1200E8C", Offset = "0x1200E8C", VA = "0x1200E8C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1201350", Offset = "0x1201350", VA = "0x1201350")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1201580", Offset = "0x1201580", VA = "0x1201580")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1201A1C", Offset = "0x1201A1C", VA = "0x1201A1C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1201110", Offset = "0x1201110", VA = "0x1201110")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1201230", Offset = "0x1201230", VA = "0x1201230")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class IKEffector
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738D64", Offset = "0x738D64")]
		public float positionWeight;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738D7C", Offset = "0x738D7C")]
		public float rotationWeight;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738D94", Offset = "0x738D94")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738DA4", Offset = "0x738DA4")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700001B")]
		public bool isEndEffector
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x1202088", Offset = "0x1202088", VA = "0x1202088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E388", Offset = "0x73E388")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1202090", Offset = "0x1202090", VA = "0x1202090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E398", Offset = "0x73E398")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1202020", Offset = "0x1202020", VA = "0x1202020")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x120209C", Offset = "0x120209C", VA = "0x120209C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1202170", Offset = "0x1202170", VA = "0x1202170")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x12022AC", Offset = "0x12022AC", VA = "0x12022AC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1202404", Offset = "0x1202404", VA = "0x1202404")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x12026F4", Offset = "0x12026F4", VA = "0x12026F4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1202994", Offset = "0x1202994", VA = "0x1202994")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1202AD4", Offset = "0x1202AD4", VA = "0x1202AD4")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1202B80", Offset = "0x1202B80", VA = "0x1202B80")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x12031D4", Offset = "0x12031D4", VA = "0x12031D4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1203244", Offset = "0x1203244", VA = "0x1203244")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x120345C", Offset = "0x120345C", VA = "0x120345C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x12037A4", Offset = "0x12037A4", VA = "0x12037A4")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200007C")]
		public class BoneMap
		{
			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700006B")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x1203F84", Offset = "0x1203F84", VA = "0x1203F84")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700006C")]
			public bool isNodeBone
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0x12040F0", Offset = "0x12040F0", VA = "0x12040F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006D")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600049F")]
				[Address(RVA = "0x12046D4", Offset = "0x12046D4", VA = "0x12046D4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1203F58", Offset = "0x1203F58", VA = "0x1203F58")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1204050", Offset = "0x1204050", VA = "0x1204050")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x12040A0", Offset = "0x12040A0", VA = "0x12040A0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1204100", Offset = "0x1204100", VA = "0x1204100")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x12041E8", Offset = "0x12041E8", VA = "0x12041E8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x12041F0", Offset = "0x12041F0", VA = "0x12041F0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1204380", Offset = "0x1204380", VA = "0x1204380")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x120448C", Offset = "0x120448C", VA = "0x120448C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1204524", Offset = "0x1204524", VA = "0x1204524")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x12048F8", Offset = "0x12048F8", VA = "0x12048F8")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1204930", Offset = "0x1204930", VA = "0x1204930")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1204968", Offset = "0x1204968", VA = "0x1204968")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1204990", Offset = "0x1204990", VA = "0x1204990")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1204ABC", Offset = "0x1204ABC", VA = "0x1204ABC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1204E04", Offset = "0x1204E04", VA = "0x1204E04")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1204E34", Offset = "0x1204E34", VA = "0x1204E34")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1204FCC", Offset = "0x1204FCC", VA = "0x1204FCC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x120503C", Offset = "0x120503C", VA = "0x120503C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1205280", Offset = "0x1205280", VA = "0x1205280")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x12054A8", Offset = "0x12054A8", VA = "0x12054A8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x12055C0", Offset = "0x12055C0", VA = "0x12055C0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1204C00", Offset = "0x1204C00", VA = "0x1204C00")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x120575C", Offset = "0x120575C", VA = "0x120575C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1203D18", Offset = "0x1203D18", VA = "0x1203D18", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1203D20", Offset = "0x1203D20", VA = "0x1203D20", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1203D24", Offset = "0x1203D24", VA = "0x1203D24")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1203E48", Offset = "0x1203E48", VA = "0x1203E48")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1203F50", Offset = "0x1203F50", VA = "0x1203F50")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738DBC", Offset = "0x738DBC")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1205778", Offset = "0x1205778", VA = "0x1205778", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1205818", Offset = "0x1205818", VA = "0x1205818")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x120589C", Offset = "0x120589C", VA = "0x120589C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1205934", Offset = "0x1205934", VA = "0x1205934")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x120594C", Offset = "0x120594C", VA = "0x120594C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1205968", Offset = "0x1205968", VA = "0x1205968", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1205A04", Offset = "0x1205A04", VA = "0x1205A04")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1205A1C", Offset = "0x1205A1C", VA = "0x1205A1C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000392")]
			Parent,
			[Token(Token = "0x4000393")]
			Bone1,
			[Token(Token = "0x4000394")]
			Bone2,
			[Token(Token = "0x4000395")]
			Bone3
		}

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738DD4", Offset = "0x738DD4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738DEC", Offset = "0x738DEC")]
		public float weight;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1205A40", Offset = "0x1205A40", VA = "0x1205A40", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1205AC4", Offset = "0x1205AC4", VA = "0x1205AC4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1205B98", Offset = "0x1205B98", VA = "0x1205B98")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1205EEC", Offset = "0x1205EEC", VA = "0x1205EEC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1205FEC", Offset = "0x1205FEC", VA = "0x1205FEC")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1206118", Offset = "0x1206118", VA = "0x1206118")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1206124", Offset = "0x1206124", VA = "0x1206124")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x12061CC", Offset = "0x12061CC", VA = "0x12061CC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1206284", Offset = "0x1206284", VA = "0x1206284", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x12064F4", Offset = "0x12064F4", VA = "0x12064F4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x12065AC", Offset = "0x12065AC", VA = "0x12065AC")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738E04", Offset = "0x738E04")]
		public int iterations;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738E1C", Offset = "0x738E1C")]
		public float twistWeight;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1206718", Offset = "0x1206718", VA = "0x1206718", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1206A08", Offset = "0x1206A08", VA = "0x1206A08")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1206B24", Offset = "0x1206B24", VA = "0x1206B24")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1206C7C", Offset = "0x1206C7C", VA = "0x1206C7C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1206C8C", Offset = "0x1206C8C", VA = "0x1206C8C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1206CF4", Offset = "0x1206CF4", VA = "0x1206CF4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1206D74", Offset = "0x1206D74", VA = "0x1206D74", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x12073C8", Offset = "0x12073C8", VA = "0x12073C8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1207400", Offset = "0x1207400", VA = "0x1207400")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x12076E0", Offset = "0x12076E0", VA = "0x12076E0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1207A94", Offset = "0x1207A94", VA = "0x1207A94")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1207B80", Offset = "0x1207B80", VA = "0x1207B80")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1207C48", Offset = "0x1207C48", VA = "0x1207C48")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200007E")]
		public class Point
		{
			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A8F4", Offset = "0x73A8F4")]
			public float weight;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x120977C", Offset = "0x120977C", VA = "0x120977C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x12097CC", Offset = "0x12097CC", VA = "0x12097CC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1209954", Offset = "0x1209954", VA = "0x1209954")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x120998C", Offset = "0x120998C", VA = "0x120998C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x12099C4", Offset = "0x12099C4", VA = "0x12099C4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1209A14", Offset = "0x1209A14", VA = "0x1209A14")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1209244", Offset = "0x1209244", VA = "0x1209244")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public class Bone : Point
		{
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700006E")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60004A8")]
				[Address(RVA = "0x1208814", Offset = "0x1208814", VA = "0x1208814")]
				get
				{
					return null;
				}
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0x1208908", Offset = "0x1208908", VA = "0x1208908")]
				set
				{
				}
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1208990", Offset = "0x1208990", VA = "0x1208990")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1208C50", Offset = "0x1208C50", VA = "0x1208C50")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1208F30", Offset = "0x1208F30", VA = "0x1208F30")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1209198", Offset = "0x1209198", VA = "0x1209198")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x12091C0", Offset = "0x12091C0", VA = "0x12091C0")]
			public Bone()
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x12092C4", Offset = "0x12092C4", VA = "0x12092C4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x120935C", Offset = "0x120935C", VA = "0x120935C")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public class Node : Point
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1209718", Offset = "0x1209718", VA = "0x1209718")]
			public Node()
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x120971C", Offset = "0x120971C", VA = "0x120971C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1209744", Offset = "0x1209744", VA = "0x1209744")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000081")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000082")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738E44", Offset = "0x738E44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738E44", Offset = "0x738E44")]
		public float IKPositionWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738E98", Offset = "0x738E98")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700001C")]
		public bool initiated
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1208264", Offset = "0x1208264", VA = "0x1208264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3A8", Offset = "0x73E3A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x120826C", Offset = "0x120826C", VA = "0x120826C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3B8", Offset = "0x73E3B8")]
			private set
			{
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1207F30", Offset = "0x1207F30", VA = "0x1207F30")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x12009C0", Offset = "0x12009C0", VA = "0x12009C0")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x12008E8", Offset = "0x12008E8", VA = "0x12008E8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x12081B8", Offset = "0x12081B8", VA = "0x12081B8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x12081C4", Offset = "0x12081C4", VA = "0x12081C4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x12081D0", Offset = "0x12081D0", VA = "0x12081D0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x12081D8", Offset = "0x12081D8", VA = "0x12081D8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x120825C", Offset = "0x120825C", VA = "0x120825C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000228")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000229")]
		public abstract void FixTransforms();

		[Token(Token = "0x600022A")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600022B")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600022C")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1208278", Offset = "0x1208278", VA = "0x1208278")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1208290", Offset = "0x1208290", VA = "0x1208290")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x12083CC", Offset = "0x12083CC", VA = "0x12083CC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1208478", Offset = "0x1208478", VA = "0x1208478")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x12087FC", Offset = "0x12087FC", VA = "0x12087FC")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738EE0", Offset = "0x738EE0")]
		public float poleWeight;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738EF8", Offset = "0x738EF8")]
		public float clampWeight;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738F10", Offset = "0x738F10")]
		public int clampSmoothing;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700001D")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1209B9C", Offset = "0x1209B9C", VA = "0x1209B9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1209C68", Offset = "0x1209C68", VA = "0x1209C68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001F")]
		protected override int minBones
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x120A9D8", Offset = "0x120A9D8", VA = "0x120A9D8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000020")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x120AF7C", Offset = "0x120AF7C", VA = "0x120AF7C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1209A9C", Offset = "0x1209A9C", VA = "0x1209A9C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1209D34", Offset = "0x1209D34", VA = "0x1209D34", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1209FB4", Offset = "0x1209FB4", VA = "0x1209FB4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x120A924", Offset = "0x120A924", VA = "0x120A924")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x120A54C", Offset = "0x120A54C", VA = "0x120A54C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x120A9E0", Offset = "0x120A9E0", VA = "0x120A9E0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x120AFF0", Offset = "0x120AFF0", VA = "0x120AFF0")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x120B088", Offset = "0x120B088", VA = "0x120B088")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x120B138", Offset = "0x120B138", VA = "0x120B138", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x120B1BC", Offset = "0x120B1BC", VA = "0x120B1BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x120B4B8", Offset = "0x120B4B8", VA = "0x120B4B8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x120BC0C", Offset = "0x120BC0C", VA = "0x120BC0C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000021")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x120CE3C", Offset = "0x120CE3C", VA = "0x120CE3C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x120BC14", Offset = "0x120BC14", VA = "0x120BC14")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x120C35C", Offset = "0x120C35C", VA = "0x120C35C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x120C494", Offset = "0x120C494", VA = "0x120C494", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x120C52C", Offset = "0x120C52C", VA = "0x120C52C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x120CAD4", Offset = "0x120CAD4", VA = "0x120CAD4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x120CE44", Offset = "0x120CE44", VA = "0x120CE44")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x120BCE8", Offset = "0x120BCE8", VA = "0x120BCE8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x120C440", Offset = "0x120C440", VA = "0x120C440")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x120CDE0", Offset = "0x120CDE0", VA = "0x120CDE0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x120C184", Offset = "0x120C184", VA = "0x120C184")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x120D684", Offset = "0x120D684", VA = "0x120D684")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x120D794", Offset = "0x120D794", VA = "0x120D794")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x120D8C0", Offset = "0x120D8C0", VA = "0x120D8C0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x120D9D8", Offset = "0x120D9D8", VA = "0x120D9D8")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x120C83C", Offset = "0x120C83C", VA = "0x120C83C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x120C988", Offset = "0x120C988", VA = "0x120C988")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x120DBC4", Offset = "0x120DBC4", VA = "0x120DBC4")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x120D0FC", Offset = "0x120D0FC", VA = "0x120D0FC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x120C430", Offset = "0x120C430", VA = "0x120C430")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x120E32C", Offset = "0x120E32C", VA = "0x120E32C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x120DD98", Offset = "0x120DD98", VA = "0x120DD98")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x120CF5C", Offset = "0x120CF5C", VA = "0x120CF5C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x120D038", Offset = "0x120D038", VA = "0x120D038")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x120E3F8", Offset = "0x120E3F8", VA = "0x120E3F8")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738F28", Offset = "0x738F28")]
		public float rootPin;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x120E470", Offset = "0x120E470", VA = "0x120E470", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x120ED3C", Offset = "0x120ED3C", VA = "0x120ED3C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x120EDD4", Offset = "0x120EDD4", VA = "0x120EDD4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x120EE74", Offset = "0x120EE74", VA = "0x120EE74", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x120EF74", Offset = "0x120EF74", VA = "0x120EF74")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x120F010", Offset = "0x120F010", VA = "0x120F010", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x120F578", Offset = "0x120F578", VA = "0x120F578", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x120F778", Offset = "0x120F778", VA = "0x120F778", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x120F628", Offset = "0x120F628", VA = "0x120F628")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x120F244", Offset = "0x120F244", VA = "0x120F244")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x120F810", Offset = "0x120F810", VA = "0x120F810")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738F40", Offset = "0x738F40")]
		public int iterations;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x11A0750", Offset = "0x11A0750", VA = "0x11A0750")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x11A0844", Offset = "0x11A0844", VA = "0x11A0844")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x11A08A0", Offset = "0x11A08A0", VA = "0x11A08A0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x11A09D4", Offset = "0x11A09D4", VA = "0x11A09D4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x11A0A30", Offset = "0x11A0A30", VA = "0x11A0A30")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x11A0AB0", Offset = "0x11A0AB0", VA = "0x11A0AB0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x11A0C38", Offset = "0x11A0C38", VA = "0x11A0C38", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x11A0DAC", Offset = "0x11A0DAC", VA = "0x11A0DAC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x11A0FB0", Offset = "0x11A0FB0", VA = "0x11A0FB0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x11A1088", Offset = "0x11A1088", VA = "0x11A1088", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x11A1174", Offset = "0x11A1174", VA = "0x11A1174", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x11A12E8", Offset = "0x11A12E8", VA = "0x11A12E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x11A14B0", Offset = "0x11A14B0", VA = "0x11A14B0", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x11A16FC", Offset = "0x11A16FC", VA = "0x11A16FC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x11A19D8", Offset = "0x11A19D8", VA = "0x11A19D8", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x11A1A1C", Offset = "0x11A1A1C", VA = "0x11A1A1C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x11A1B0C", Offset = "0x11A1B0C", VA = "0x11A1B0C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40001CB")]
		Body,
		[Token(Token = "0x40001CC")]
		LeftShoulder,
		[Token(Token = "0x40001CD")]
		RightShoulder,
		[Token(Token = "0x40001CE")]
		LeftThigh,
		[Token(Token = "0x40001CF")]
		RightThigh,
		[Token(Token = "0x40001D0")]
		LeftHand,
		[Token(Token = "0x40001D1")]
		RightHand,
		[Token(Token = "0x40001D2")]
		LeftFoot,
		[Token(Token = "0x40001D3")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40001D5")]
		LeftArm,
		[Token(Token = "0x40001D6")]
		RightArm,
		[Token(Token = "0x40001D7")]
		LeftLeg,
		[Token(Token = "0x40001D8")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738F58", Offset = "0x738F58")]
		public float spineStiffness;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738F70", Offset = "0x738F70")]
		public float pullBodyVertical;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738F88", Offset = "0x738F88")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738FA0", Offset = "0x738FA0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000022")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x11A1BE4", Offset = "0x11A1BE4", VA = "0x11A1BE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x11A1D2C", Offset = "0x11A1D2C", VA = "0x11A1D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x11A1D34", Offset = "0x11A1D34", VA = "0x11A1D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x11A1D3C", Offset = "0x11A1D3C", VA = "0x11A1D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x11A1D44", Offset = "0x11A1D44", VA = "0x11A1D44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x11A1D4C", Offset = "0x11A1D4C", VA = "0x11A1D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x11A1D54", Offset = "0x11A1D54", VA = "0x11A1D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x11A1D5C", Offset = "0x11A1D5C", VA = "0x11A1D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x11A1D64", Offset = "0x11A1D64", VA = "0x11A1D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x11A1D6C", Offset = "0x11A1D6C", VA = "0x11A1D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x11A1DA4", Offset = "0x11A1DA4", VA = "0x11A1DA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x11A1DDC", Offset = "0x11A1DDC", VA = "0x11A1DDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x11A1E14", Offset = "0x11A1E14", VA = "0x11A1E14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x11A1E4C", Offset = "0x11A1E4C", VA = "0x11A1E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x11A1E80", Offset = "0x11A1E80", VA = "0x11A1E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x11A1EB8", Offset = "0x11A1EB8", VA = "0x11A1EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x11A1EF0", Offset = "0x11A1EF0", VA = "0x11A1EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x11A1F28", Offset = "0x11A1F28", VA = "0x11A1F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x11A3EEC", Offset = "0x11A3EEC", VA = "0x11A3EEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3C8", Offset = "0x73E3C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x11A3EF8", Offset = "0x11A3EF8", VA = "0x11A3EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3D8", Offset = "0x73E3D8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x11A1F5C", Offset = "0x11A1F5C", VA = "0x11A1F5C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x11A2068", Offset = "0x11A2068", VA = "0x11A2068")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x11A1FB0", Offset = "0x11A1FB0", VA = "0x11A1FB0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x11A2144", Offset = "0x11A2144", VA = "0x11A2144")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x11A1BEC", Offset = "0x11A1BEC", VA = "0x11A1BEC")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x11A2214", Offset = "0x11A2214", VA = "0x11A2214")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x11A22CC", Offset = "0x11A22CC", VA = "0x11A22CC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x11A2380", Offset = "0x11A2380", VA = "0x11A2380")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x11A2434", Offset = "0x11A2434", VA = "0x11A2434")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x11A243C", Offset = "0x11A243C", VA = "0x11A243C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x11A2470", Offset = "0x11A2470", VA = "0x11A2470")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x11A2538", Offset = "0x11A2538", VA = "0x11A2538", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x11A26C8", Offset = "0x11A26C8", VA = "0x11A26C8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x11A3804", Offset = "0x11A3804", VA = "0x11A3804")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x11A3C98", Offset = "0x11A3C98", VA = "0x11A3C98")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x11A3CF8", Offset = "0x11A3CF8", VA = "0x11A3CF8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x11A3B18", Offset = "0x11A3B18", VA = "0x11A3B18")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x11A3BD8", Offset = "0x11A3BD8", VA = "0x11A3BD8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x11A3F04", Offset = "0x11A3F04", VA = "0x11A3F04")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x11A3FE0", Offset = "0x11A3FE0", VA = "0x11A3FE0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x11A4128", Offset = "0x11A4128", VA = "0x11A4128")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x11A42B8", Offset = "0x11A42B8", VA = "0x11A42B8")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x11A44B8", Offset = "0x11A44B8", VA = "0x11A44B8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x11A46B8", Offset = "0x11A46B8", VA = "0x11A46B8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x11A49EC", Offset = "0x11A49EC", VA = "0x11A49EC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x11A4AEC", Offset = "0x11A4AEC", VA = "0x11A4AEC")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000035")]
		protected virtual int minBones
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x11A533C", Offset = "0x11A533C", VA = "0x11A533C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x11A5344", Offset = "0x11A5344", VA = "0x11A5344", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x11A534C", Offset = "0x11A534C", VA = "0x11A534C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x11A58DC", Offset = "0x11A58DC", VA = "0x11A58DC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000039")]
		protected float positionOffset
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x11A5A10", Offset = "0x11A5A10", VA = "0x11A5A10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x11A4AF8", Offset = "0x11A4AF8", VA = "0x11A4AF8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x11A4C8C", Offset = "0x11A4C8C", VA = "0x11A4C8C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x11A4DC8", Offset = "0x11A4DC8", VA = "0x11A4DC8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x11A4E34", Offset = "0x11A4E34", VA = "0x11A4E34", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x11A4EB4", Offset = "0x11A4EB4", VA = "0x11A4EB4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x11A5240", Offset = "0x11A5240", VA = "0x11A5240", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x11A5248", Offset = "0x11A5248", VA = "0x11A5248", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x11A5354", Offset = "0x11A5354", VA = "0x11A5354", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x11A5358", Offset = "0x11A5358", VA = "0x11A5358", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x11A535C", Offset = "0x11A535C", VA = "0x11A535C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x11A5AD4", Offset = "0x11A5AD4", VA = "0x11A5AD4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x11A5E78", Offset = "0x11A5E78", VA = "0x11A5E78")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x11A612C", Offset = "0x11A612C", VA = "0x11A612C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738FB0", Offset = "0x738FB0")]
		public float IKRotationWeight;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x11A619C", Offset = "0x11A619C", VA = "0x11A619C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x11A6510", Offset = "0x11A6510", VA = "0x11A6510")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x11A6580", Offset = "0x11A6580", VA = "0x11A6580", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x11A66DC", Offset = "0x11A66DC", VA = "0x11A66DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x11A6874", Offset = "0x11A6874", VA = "0x11A6874", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x11A68D0", Offset = "0x11A68D0", VA = "0x11A68D0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x11A6940", Offset = "0x11A6940", VA = "0x11A6940", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x11A6CA4", Offset = "0x11A6CA4", VA = "0x11A6CA4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x11A6CD0", Offset = "0x11A6CD0", VA = "0x11A6CD0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x11A69A4", Offset = "0x11A69A4", VA = "0x11A69A4")]
		private void Read()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x11A6DD0", Offset = "0x11A6DD0", VA = "0x11A6DD0")]
		private void Write()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x11A72F4", Offset = "0x11A72F4", VA = "0x11A72F4")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public enum BendModifier
		{
			[Token(Token = "0x40003A6")]
			Animation,
			[Token(Token = "0x40003A7")]
			Target,
			[Token(Token = "0x40003A8")]
			Parent,
			[Token(Token = "0x40003A9")]
			Arm,
			[Token(Token = "0x40003AA")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public struct AxisDirection
		{
			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x7E7AF8", Offset = "0x7E7AF8", VA = "0x7E7AF8")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738FC8", Offset = "0x738FC8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738FE0", Offset = "0x738FE0")]
		public float bendModifierWeight;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700003A")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x11A8BF8", Offset = "0x11A8BF8", VA = "0x11A8BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x11A74F4", Offset = "0x11A74F4", VA = "0x11A74F4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x11A7544", Offset = "0x11A7544", VA = "0x11A7544")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x11A7658", Offset = "0x11A7658", VA = "0x11A7658", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11A7CC8", Offset = "0x11A7CC8", VA = "0x11A7CC8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11A88A4", Offset = "0x11A88A4", VA = "0x11A88A4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x11A89EC", Offset = "0x11A89EC", VA = "0x11A89EC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x11A8B70", Offset = "0x11A8B70", VA = "0x11A8B70")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11A79D4", Offset = "0x11A79D4", VA = "0x11A79D4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x11A7DF4", Offset = "0x11A7DF4", VA = "0x11A7DF4")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x1700006F")]
			public Vector3 forward
			{
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0x11AAAB4", Offset = "0x11AAAB4", VA = "0x11AAAB4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x11AB200", Offset = "0x11AB200", VA = "0x11AB200")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x11A9E50", Offset = "0x11A9E50", VA = "0x11A9E50")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x11AA18C", Offset = "0x11AA18C", VA = "0x11AA18C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x11AAEB8", Offset = "0x11AAEB8", VA = "0x11AAEB8")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738FF8", Offset = "0x738FF8")]
		public float bodyWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739010", Offset = "0x739010")]
		public float headWeight;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739028", Offset = "0x739028")]
		public float eyesWeight;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739040", Offset = "0x739040")]
		public float clampWeight;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739058", Offset = "0x739058")]
		public float clampWeightHead;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739070", Offset = "0x739070")]
		public float clampWeightEyes;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739088", Offset = "0x739088")]
		public int clampSmoothing;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x1700003B")]
		private bool spineIsValid
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x11A95B4", Offset = "0x11A95B4", VA = "0x11A95B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x11A978C", Offset = "0x11A978C", VA = "0x11A978C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		private bool headIsValid
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x11A9698", Offset = "0x11A9698", VA = "0x11A9698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x11A97B0", Offset = "0x11A97B0", VA = "0x11A97B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x11A96A8", Offset = "0x11A96A8", VA = "0x11A96A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x11A982C", Offset = "0x11A982C", VA = "0x11A982C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x11A8C74", Offset = "0x11A8C74", VA = "0x11A8C74")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x11A8CF8", Offset = "0x11A8CF8", VA = "0x11A8CF8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x11A8DA4", Offset = "0x11A8DA4", VA = "0x11A8DA4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x11A8E6C", Offset = "0x11A8E6C", VA = "0x11A8E6C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x11A8F58", Offset = "0x11A8F58", VA = "0x11A8F58")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x11A9064", Offset = "0x11A9064", VA = "0x11A9064")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x11A91AC", Offset = "0x11A91AC", VA = "0x11A91AC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x11A92DC", Offset = "0x11A92DC", VA = "0x11A92DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11A9420", Offset = "0x11A9420", VA = "0x11A9420", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x11A9850", Offset = "0x11A9850", VA = "0x11A9850", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x11A9A88", Offset = "0x11A9A88", VA = "0x11A9A88", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x11A9C28", Offset = "0x11A9C28", VA = "0x11A9C28")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x11A9E7C", Offset = "0x11A9E7C", VA = "0x11A9E7C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x11AA2C8", Offset = "0x11AA2C8", VA = "0x11AA2C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x11AA3CC", Offset = "0x11AA3CC", VA = "0x11AA3CC")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x11AA5F8", Offset = "0x11AA5F8", VA = "0x11AA5F8")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x11AA854", Offset = "0x11AA854", VA = "0x11AA854")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11AAB80", Offset = "0x11AAB80", VA = "0x11AAB80")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11A9CD8", Offset = "0x11A9CD8", VA = "0x11A9CD8")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x11AB020", Offset = "0x11AB020", VA = "0x11AB020")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000086")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x11AC7D8", Offset = "0x11AC7D8", VA = "0x11AC7D8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x11AD380", Offset = "0x11AD380", VA = "0x11AD380")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x11A758C", Offset = "0x11A758C", VA = "0x11A758C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x11AD448", Offset = "0x11AD448", VA = "0x11AD448")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7390A0", Offset = "0x7390A0")]
		public float IKRotationWeight;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11AB208", Offset = "0x11AB208", VA = "0x11AB208")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11AB3F8", Offset = "0x11AB3F8", VA = "0x11AB3F8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x11AB5AC", Offset = "0x11AB5AC", VA = "0x11AB5AC")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x11AB5B8", Offset = "0x11AB5B8", VA = "0x11AB5B8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x11AB63C", Offset = "0x11AB63C", VA = "0x11AB63C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x11AB648", Offset = "0x11AB648", VA = "0x11AB648")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x11AB650", Offset = "0x11AB650", VA = "0x11AB650", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x11AB754", Offset = "0x11AB754", VA = "0x11AB754", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x11AB874", Offset = "0x11AB874", VA = "0x11AB874", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x11AB8C0", Offset = "0x11AB8C0", VA = "0x11AB8C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x11AB920", Offset = "0x11AB920", VA = "0x11AB920", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x11ABCFC", Offset = "0x11ABCFC", VA = "0x11ABCFC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x11ABD54", Offset = "0x11ABD54", VA = "0x11ABD54")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11AC2FC", Offset = "0x11AC2FC", VA = "0x11AC2FC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x11AC514", Offset = "0x11AC514", VA = "0x11AC514", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x11AC6D0", Offset = "0x11AC6D0", VA = "0x11AC6D0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x11AC64C", Offset = "0x11AC64C", VA = "0x11AC64C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x11AC978", Offset = "0x11AC978", VA = "0x11AC978", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11AD43C", Offset = "0x11AD43C", VA = "0x11AD43C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x11AD440", Offset = "0x11AD440", VA = "0x11AD440", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x11AD444", Offset = "0x11AD444", VA = "0x11AD444", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x11AD084", Offset = "0x11AD084", VA = "0x11AD084")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x11A8A60", Offset = "0x11A8A60", VA = "0x11A8A60")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000B2")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000501")]
				YawPitch,
				[Token(Token = "0x4000502")]
				FromTo
			}

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A90C", Offset = "0x73A90C")]
			public Transform target;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A944", Offset = "0x73A944")]
			public Transform bendGoal;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A97C", Offset = "0x73A97C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A97C", Offset = "0x73A97C")]
			public float positionWeight;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A9D0", Offset = "0x73A9D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A9D0", Offset = "0x73A9D0")]
			public float rotationWeight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AA24", Offset = "0x73AA24")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AA5C", Offset = "0x73AA5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AA5C", Offset = "0x73AA5C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AAB0", Offset = "0x73AAB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AAB0", Offset = "0x73AAB0")]
			public float bendGoalWeight;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AB04", Offset = "0x73AB04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AB04", Offset = "0x73AB04")]
			public float swivelOffset;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AB60", Offset = "0x73AB60")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AB98", Offset = "0x73AB98")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ABD0", Offset = "0x73ABD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73ABD0", Offset = "0x73ABD0")]
			public float armLengthMlp;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AC28", Offset = "0x73AC28")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACA0", Offset = "0x73ACA0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACB0", Offset = "0x73ACB0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40003C9")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40003CA")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000070")]
			public Vector3 position
			{
				[Token(Token = "0x60004C6")]
				[Address(RVA = "0x11B4C40", Offset = "0x11B4C40", VA = "0x11B4C40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0F4", Offset = "0x73F0F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004C7")]
				[Address(RVA = "0x11B4C4C", Offset = "0x11B4C4C", VA = "0x11B4C4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F104", Offset = "0x73F104")]
				private set
				{
				}
			}

			[Token(Token = "0x17000071")]
			public Quaternion rotation
			{
				[Token(Token = "0x60004C8")]
				[Address(RVA = "0x11B4C58", Offset = "0x11B4C58", VA = "0x11B4C58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F114", Offset = "0x73F114")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0x11B4C64", Offset = "0x11B4C64", VA = "0x11B4C64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F124", Offset = "0x73F124")]
				private set
				{
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0x11B4C70", Offset = "0x11B4C70", VA = "0x11B4C70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60004CB")]
				[Address(RVA = "0x11B4CA4", Offset = "0x11B4CA4", VA = "0x11B4CA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0x11B4CDC", Offset = "0x11B4CDC", VA = "0x11B4CDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private VirtualBone hand
			{
				[Token(Token = "0x60004CD")]
				[Address(RVA = "0x11B4D14", Offset = "0x11B4D14", VA = "0x11B4D14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x11B4D4C", Offset = "0x11B4D4C", VA = "0x11B4D4C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x11B54CC", Offset = "0x11B54CC", VA = "0x11B54CC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x11B56C0", Offset = "0x11B56C0", VA = "0x11B56C0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x11B576C", Offset = "0x11B576C", VA = "0x11B576C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x11B2F6C", Offset = "0x11B2F6C", VA = "0x11B2F6C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x11B647C", Offset = "0x11B647C", VA = "0x11B647C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x11B64EC", Offset = "0x11B64EC", VA = "0x11B64EC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x11B5B84", Offset = "0x11B5B84", VA = "0x11B5B84")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x11B5C5C", Offset = "0x11B5C5C", VA = "0x11B5C5C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x11B670C", Offset = "0x11B670C", VA = "0x11B670C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x11B4A54", Offset = "0x11B4A54", VA = "0x11B4A54")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACC0", Offset = "0x73ACC0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACD0", Offset = "0x73ACD0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x17000076")]
			public float sqrMag
			{
				[Token(Token = "0x60004DE")]
				[Address(RVA = "0x11B68CC", Offset = "0x11B68CC", VA = "0x11B68CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F134", Offset = "0x73F134")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004DF")]
				[Address(RVA = "0x11B68D4", Offset = "0x11B68D4", VA = "0x11B68D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F144", Offset = "0x73F144")]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public float mag
			{
				[Token(Token = "0x60004E0")]
				[Address(RVA = "0x11B68DC", Offset = "0x11B68DC", VA = "0x11B68DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F154", Offset = "0x73F154")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004E1")]
				[Address(RVA = "0x11B68E4", Offset = "0x11B68E4", VA = "0x11B68E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F164", Offset = "0x73F164")]
				private set
				{
				}
			}

			[Token(Token = "0x60004D9")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x60004DA")]
			public abstract void PreSolve();

			[Token(Token = "0x60004DB")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60004DC")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60004DD")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x11A722C", Offset = "0x11A722C", VA = "0x11A722C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x11B68EC", Offset = "0x11B68EC", VA = "0x11B68EC")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x11B6A58", Offset = "0x11B6A58", VA = "0x11B6A58")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x11B6B04", Offset = "0x11B6B04", VA = "0x11B6B04")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x11B2D7C", Offset = "0x11B2D7C", VA = "0x11B2D7C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x11B62D8", Offset = "0x11B62D8", VA = "0x11B62D8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x11B6B58", Offset = "0x11B6B58", VA = "0x11B6B58")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x11B6C9C", Offset = "0x11B6C9C", VA = "0x11B6C9C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x11B6834", Offset = "0x11B6834", VA = "0x11B6834")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public class Footstep
		{
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACF0", Offset = "0x73ACF0")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000078")]
			public bool isStepping
			{
				[Token(Token = "0x60004EB")]
				[Address(RVA = "0x11B6CC4", Offset = "0x11B6CC4", VA = "0x11B6CC4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000079")]
			public float stepProgress
			{
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x11B6CD8", Offset = "0x11B6CD8", VA = "0x11B6CD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F174", Offset = "0x73F174")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x11B6CE0", Offset = "0x11B6CE0", VA = "0x11B6CE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F184", Offset = "0x73F184")]
				private set
				{
				}
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x11B6CE8", Offset = "0x11B6CE8", VA = "0x11B6CE8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x11B6E18", Offset = "0x11B6E18", VA = "0x11B6E18")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x11B6F48", Offset = "0x11B6F48", VA = "0x11B6F48")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x11B7048", Offset = "0x11B7048", VA = "0x11B7048")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x11B7220", Offset = "0x11B7220", VA = "0x11B7220")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x11B740C", Offset = "0x11B740C", VA = "0x11B740C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AD00", Offset = "0x73AD00")]
			public Transform target;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AD38", Offset = "0x73AD38")]
			public Transform bendGoal;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AD70", Offset = "0x73AD70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AD70", Offset = "0x73AD70")]
			public float positionWeight;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ADC4", Offset = "0x73ADC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73ADC4", Offset = "0x73ADC4")]
			public float rotationWeight;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AE18", Offset = "0x73AE18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AE18", Offset = "0x73AE18")]
			public float bendGoalWeight;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AE6C", Offset = "0x73AE6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AE6C", Offset = "0x73AE6C")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF28", Offset = "0x73AF28")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF38", Offset = "0x73AF38")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF48", Offset = "0x73AF48")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF58", Offset = "0x73AF58")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x1700007A")]
			public Vector3 position
			{
				[Token(Token = "0x60004F4")]
				[Address(RVA = "0x11B7628", Offset = "0x11B7628", VA = "0x11B7628")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F194", Offset = "0x73F194")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004F5")]
				[Address(RVA = "0x11B7634", Offset = "0x11B7634", VA = "0x11B7634")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F1A4", Offset = "0x73F1A4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public Quaternion rotation
			{
				[Token(Token = "0x60004F6")]
				[Address(RVA = "0x11B7640", Offset = "0x11B7640", VA = "0x11B7640")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F1B4", Offset = "0x73F1B4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004F7")]
				[Address(RVA = "0x11B764C", Offset = "0x11B764C", VA = "0x11B764C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F1C4", Offset = "0x73F1C4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public bool hasToes
			{
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0x11B7658", Offset = "0x11B7658", VA = "0x11B7658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F1D4", Offset = "0x73F1D4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004F9")]
				[Address(RVA = "0x11B7660", Offset = "0x11B7660", VA = "0x11B7660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F1E4", Offset = "0x73F1E4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60004FA")]
				[Address(RVA = "0x11B766C", Offset = "0x11B766C", VA = "0x11B766C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private VirtualBone calf
			{
				[Token(Token = "0x60004FB")]
				[Address(RVA = "0x11B76A0", Offset = "0x11B76A0", VA = "0x11B76A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private VirtualBone foot
			{
				[Token(Token = "0x60004FC")]
				[Address(RVA = "0x11B76D8", Offset = "0x11B76D8", VA = "0x11B76D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private VirtualBone toes
			{
				[Token(Token = "0x60004FD")]
				[Address(RVA = "0x11B7710", Offset = "0x11B7710", VA = "0x11B7710")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0x11B2D3C", Offset = "0x11B2D3C", VA = "0x11B2D3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60004FF")]
				[Address(RVA = "0x11B7748", Offset = "0x11B7748", VA = "0x11B7748")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F1F4", Offset = "0x73F1F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000500")]
				[Address(RVA = "0x11B7754", Offset = "0x11B7754", VA = "0x11B7754")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F204", Offset = "0x73F204")]
				private set
				{
				}
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x11B7760", Offset = "0x11B7760", VA = "0x11B7760", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x11B7C28", Offset = "0x11B7C28", VA = "0x11B7C28", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x11B8308", Offset = "0x11B8308", VA = "0x11B8308", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x11B8204", Offset = "0x11B8204", VA = "0x11B8204")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x11B7FDC", Offset = "0x11B7FDC", VA = "0x11B7FDC")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x11A6EE8", Offset = "0x11A6EE8", VA = "0x11A6EE8")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x11B88AC", Offset = "0x11B88AC", VA = "0x11B88AC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x11B89B4", Offset = "0x11B89B4", VA = "0x11B89B4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x11A7448", Offset = "0x11A7448", VA = "0x11A7448")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Locomotion
		{
			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AF68", Offset = "0x73AF68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AF68", Offset = "0x73AF68")]
			public float weight;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AFBC", Offset = "0x73AFBC")]
			public float footDistance;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AFF4", Offset = "0x73AFF4")]
			public float stepThreshold;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B02C", Offset = "0x73B02C")]
			public float angleThreshold;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B064", Offset = "0x73B064")]
			public float comAngleMlp;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B09C", Offset = "0x73B09C")]
			public float maxVelocity;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B0D4", Offset = "0x73B0D4")]
			public float velocityFactor;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B10C", Offset = "0x73B10C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B10C", Offset = "0x73B10C")]
			public float maxLegStretch;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B164", Offset = "0x73B164")]
			public float rootSpeed;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B19C", Offset = "0x73B19C")]
			public float stepSpeed;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B1D4", Offset = "0x73B1D4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B20C", Offset = "0x73B20C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B244", Offset = "0x73B244")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B244", Offset = "0x73B244")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B29C", Offset = "0x73B29C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B2D4", Offset = "0x73B2D4")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B30C", Offset = "0x73B30C")]
			public Vector3 offset;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B384", Offset = "0x73B384")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B3BC", Offset = "0x73B3BC")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B3F4", Offset = "0x73B3F4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000083")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0x11B8A64", Offset = "0x11B8A64", VA = "0x11B8A64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F214", Offset = "0x73F214")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600050B")]
				[Address(RVA = "0x11B8A70", Offset = "0x11B8A70", VA = "0x11B8A70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F224", Offset = "0x73F224")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000511")]
				[Address(RVA = "0x11B8E70", Offset = "0x11B8E70", VA = "0x11B8E70")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000085")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000512")]
				[Address(RVA = "0x11B8EB0", Offset = "0x11B8EB0", VA = "0x11B8EB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000086")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000513")]
				[Address(RVA = "0x11B8EF4", Offset = "0x11B8EF4", VA = "0x11B8EF4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000087")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000514")]
				[Address(RVA = "0x11B8F34", Offset = "0x11B8F34", VA = "0x11B8F34")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x11B1568", Offset = "0x11B1568", VA = "0x11B1568")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x11AF608", Offset = "0x11AF608", VA = "0x11AF608")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0x11AEA70", Offset = "0x11AEA70", VA = "0x11AEA70")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x11AE8C0", Offset = "0x11AE8C0", VA = "0x11AE8C0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x11B1860", Offset = "0x11B1860", VA = "0x11B1860")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x11B8A7C", Offset = "0x11B8A7C", VA = "0x11B8A7C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x11B8C20", Offset = "0x11B8C20", VA = "0x11B8C20")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x11B8CA4", Offset = "0x11B8CA4", VA = "0x11B8CA4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x11B4B5C", Offset = "0x11B4B5C", VA = "0x11B4B5C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B404", Offset = "0x73B404")]
			public Transform headTarget;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B43C", Offset = "0x73B43C")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B474", Offset = "0x73B474")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B474", Offset = "0x73B474")]
			public float positionWeight;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B4C8", Offset = "0x73B4C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B4C8", Offset = "0x73B4C8")]
			public float rotationWeight;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B51C", Offset = "0x73B51C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B51C", Offset = "0x73B51C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B570", Offset = "0x73B570")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B570", Offset = "0x73B570")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B5C4", Offset = "0x73B5C4")]
			public Transform chestGoal;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B5FC", Offset = "0x73B5FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B5FC", Offset = "0x73B5FC")]
			public float chestGoalWeight;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B650", Offset = "0x73B650")]
			public float minHeadHeight;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B688", Offset = "0x73B688")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B688", Offset = "0x73B688")]
			public float bodyPosStiffness;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B6DC", Offset = "0x73B6DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B6DC", Offset = "0x73B6DC")]
			public float bodyRotStiffness;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B730", Offset = "0x73B730")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x73B730", Offset = "0x73B730")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B730", Offset = "0x73B730")]
			public float neckStiffness;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B7A8", Offset = "0x73B7A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B7A8", Offset = "0x73B7A8")]
			public float rotateChestByHands;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B7FC", Offset = "0x73B7FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B7FC", Offset = "0x73B7FC")]
			public float chestClampWeight;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B850", Offset = "0x73B850")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B850", Offset = "0x73B850")]
			public float headClampWeight;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B8A4", Offset = "0x73B8A4")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B8DC", Offset = "0x73B8DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B8DC", Offset = "0x73B8DC")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B930", Offset = "0x73B930")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B930", Offset = "0x73B930")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BA68", Offset = "0x73BA68")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x17000088")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000519")]
				[Address(RVA = "0xF37C04", Offset = "0xF37C04", VA = "0xF37C04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600051A")]
				[Address(RVA = "0xF37C44", Offset = "0xF37C44", VA = "0xF37C44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			public VirtualBone chest
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0xF37C84", Offset = "0xF37C84", VA = "0xF37C84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private VirtualBone neck
			{
				[Token(Token = "0x600051C")]
				[Address(RVA = "0xF37CD8", Offset = "0xF37CD8", VA = "0xF37CD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			public VirtualBone head
			{
				[Token(Token = "0x600051D")]
				[Address(RVA = "0xF37D18", Offset = "0xF37D18", VA = "0xF37D18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600051E")]
				[Address(RVA = "0xF37D58", Offset = "0xF37D58", VA = "0xF37D58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F234", Offset = "0x73F234")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600051F")]
				[Address(RVA = "0xF37D6C", Offset = "0xF37D6C", VA = "0xF37D6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F244", Offset = "0x73F244")]
				private set
				{
				}
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0xF37D80", Offset = "0xF37D80", VA = "0xF37D80", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xF38878", Offset = "0xF38878", VA = "0xF38878", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0xF38A4C", Offset = "0xF38A4C", VA = "0xF38A4C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xF38F70", Offset = "0xF38F70", VA = "0xF38F70")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xF39524", Offset = "0xF39524", VA = "0xF39524")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xF39EC0", Offset = "0xF39EC0", VA = "0xF39EC0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xF3A6EC", Offset = "0xF3A6EC", VA = "0xF3A6EC")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xF3B478", Offset = "0xF3B478", VA = "0xF3B478", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0xF3B654", Offset = "0xF3B654", VA = "0xF3B654", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0xF391A0", Offset = "0xF391A0", VA = "0xF391A0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0xF3A31C", Offset = "0xF3A31C", VA = "0xF3A31C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xF39AB4", Offset = "0xF39AB4", VA = "0xF39AB4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0xF3B74C", Offset = "0xF3B74C", VA = "0xF3B74C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xF3A4A0", Offset = "0xF3A4A0", VA = "0xF3A4A0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xF3A0B4", Offset = "0xF3A0B4", VA = "0xF3A0B4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xF3BC60", Offset = "0xF3BC60", VA = "0xF3BC60")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000444")]
			Pelvis,
			[Token(Token = "0x4000445")]
			Chest,
			[Token(Token = "0x4000446")]
			Head,
			[Token(Token = "0x4000447")]
			LeftHand,
			[Token(Token = "0x4000448")]
			RightHand,
			[Token(Token = "0x4000449")]
			LeftFoot,
			[Token(Token = "0x400044A")]
			RightFoot,
			[Token(Token = "0x400044B")]
			LeftHeel,
			[Token(Token = "0x400044C")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public enum RotationOffset
		{
			[Token(Token = "0x400044E")]
			Pelvis,
			[Token(Token = "0x400044F")]
			Chest,
			[Token(Token = "0x4000450")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class VirtualBone
		{
			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xF387DC", Offset = "0xF387DC", VA = "0xF387DC")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xF38858", Offset = "0xF38858", VA = "0xF38858")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xF3BE00", Offset = "0xF3BE00", VA = "0xF3BE00")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xF3C090", Offset = "0xF3C090", VA = "0xF3C090")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0xF3BA78", Offset = "0xF3BA78", VA = "0xF3BA78")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0xF3C37C", Offset = "0xF3C37C", VA = "0xF3C37C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0xF3C5B4", Offset = "0xF3C5B4", VA = "0xF3C5B4")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xF3C7E8", Offset = "0xF3C7E8", VA = "0xF3C7E8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0xF3AECC", Offset = "0xF3AECC", VA = "0xF3AECC")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF3C8A0", Offset = "0xF3C8A0", VA = "0xF3C8A0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0xF3AA8C", Offset = "0xF3AA8C", VA = "0xF3AA8C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xF3CAB8", Offset = "0xF3CAB8", VA = "0xF3CAB8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0xF3CBC0", Offset = "0xF3CBC0", VA = "0xF3CBC0")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7390B8", Offset = "0x7390B8")]
		public bool plantFeet;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7390F0", Offset = "0x7390F0")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739100", Offset = "0x739100")]
		public Spine spine;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739138", Offset = "0x739138")]
		public Arm leftArm;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739170", Offset = "0x739170")]
		public Arm rightArm;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7391A8", Offset = "0x7391A8")]
		public Leg leftLeg;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7391E0", Offset = "0x7391E0")]
		public Leg rightLeg;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739218", Offset = "0x739218")]
		public Locomotion locomotion;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000041")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x11B4898", Offset = "0x11B4898", VA = "0x11B4898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3E8", Offset = "0x73E3E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x11B48A0", Offset = "0x11B48A0", VA = "0x11B48A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E3F8", Offset = "0x73E3F8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x11AD450", Offset = "0x11AD450", VA = "0x11AD450")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x11AD844", Offset = "0x11AD844", VA = "0x11AD844")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x11AD6EC", Offset = "0x11AD6EC", VA = "0x11AD6EC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x11AE228", Offset = "0x11AE228", VA = "0x11AE228")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x11AE504", Offset = "0x11AE504", VA = "0x11AE504")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x11AE5A8", Offset = "0x11AE5A8", VA = "0x11AE5A8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x11AE73C", Offset = "0x11AE73C", VA = "0x11AE73C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x11AEE48", Offset = "0x11AEE48", VA = "0x11AEE48")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x11AF87C", Offset = "0x11AF87C", VA = "0x11AF87C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x11AF9F0", Offset = "0x11AF9F0", VA = "0x11AF9F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x11AFB8C", Offset = "0x11AFB8C", VA = "0x11AFB8C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x11AFC00", Offset = "0x11AFC00", VA = "0x11AFC00", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x11AFC74", Offset = "0x11AFC74", VA = "0x11AFC74", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x11AFE88", Offset = "0x11AFE88", VA = "0x11AFE88")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x11ADADC", Offset = "0x11ADADC", VA = "0x11ADADC")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x11ADCB4", Offset = "0x11ADCB4", VA = "0x11ADCB4")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x11AE104", Offset = "0x11AE104", VA = "0x11AE104")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x11AEFA8", Offset = "0x11AEFA8", VA = "0x11AEFA8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x11B0168", Offset = "0x11B0168", VA = "0x11B0168", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x11B01A0", Offset = "0x11B01A0", VA = "0x11B01A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11B12F4", Offset = "0x11B12F4", VA = "0x11B12F4")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x11AF110", Offset = "0x11AF110", VA = "0x11AF110")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x11B0200", Offset = "0x11B0200", VA = "0x11B0200")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x11B14DC", Offset = "0x11B14DC", VA = "0x11B14DC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x11B1524", Offset = "0x11B1524", VA = "0x11B1524")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x11B11AC", Offset = "0x11B11AC", VA = "0x11B11AC")]
		private void Write()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x11B4298", Offset = "0x11B4298", VA = "0x11B4298")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x11B48A8", Offset = "0x11B48A8", VA = "0x11B48A8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739250", Offset = "0x739250")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739250", Offset = "0x739250")]
		public float weight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7392A4", Offset = "0x7392A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7392A4", Offset = "0x7392A4")]
		public float parentChildCrossfade;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7392F8", Offset = "0x7392F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7392F8", Offset = "0x7392F8")]
		public float twistAngleOffset;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x15AA330", Offset = "0x15AA330", VA = "0x15AA330")]
		public void Relax()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x15AA710", Offset = "0x15AA710", VA = "0x15AA710")]
		private void Start()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x15AAB2C", Offset = "0x15AAB2C", VA = "0x15AAB2C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x15AABB4", Offset = "0x15AABB4", VA = "0x15AABB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x15AAC3C", Offset = "0x15AAC3C", VA = "0x15AAC3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x15AAD40", Offset = "0x15AAD40", VA = "0x15AAD40")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739354", Offset = "0x739354")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739364", Offset = "0x739364")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739374", Offset = "0x739374")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000042")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0xF3D4E4", Offset = "0xF3D4E4", VA = "0xF3D4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E408", Offset = "0x73E408")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000323")]
			[Address(RVA = "0xF3D4EC", Offset = "0xF3D4EC", VA = "0xF3D4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E418", Offset = "0x73E418")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool isPaused
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0xF3D4F4", Offset = "0xF3D4F4", VA = "0xF3D4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E428", Offset = "0x73E428")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0xF3D4FC", Offset = "0xF3D4FC", VA = "0xF3D4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E438", Offset = "0x73E438")]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xF3D508", Offset = "0xF3D508", VA = "0xF3D508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E448", Offset = "0x73E448")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xF3D510", Offset = "0xF3D510", VA = "0xF3D510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E458", Offset = "0x73E458")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool inInteraction
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xF3D518", Offset = "0xF3D518", VA = "0xF3D518")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public float progress
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0xF3FDD0", Offset = "0xF3FDD0", VA = "0xF3FDD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xF3D588", Offset = "0xF3D588", VA = "0xF3D588")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xF3D60C", Offset = "0xF3D60C", VA = "0xF3D60C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xF3D6B0", Offset = "0xF3D6B0", VA = "0xF3D6B0")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xF3D7F0", Offset = "0xF3D7F0", VA = "0xF3D7F0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xF3DBF4", Offset = "0xF3DBF4", VA = "0xF3DBF4")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xF3DFAC", Offset = "0xF3DFAC", VA = "0xF3DFAC")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xF3E000", Offset = "0xF3E000", VA = "0xF3E000")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xF3EB40", Offset = "0xF3EB40", VA = "0xF3EB40")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xF3F620", Offset = "0xF3F620", VA = "0xF3F620")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xF3F848", Offset = "0xF3F848", VA = "0xF3F848")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xF3FC7C", Offset = "0xF3FC7C", VA = "0xF3FC7C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xF402AC", Offset = "0xF402AC", VA = "0xF402AC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739384", Offset = "0x739384")]
		public LookAtIK ik;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7393BC", Offset = "0x7393BC")]
		public float lerpSpeed;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7393F4", Offset = "0x7393F4")]
		public float weightSpeed;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xF40510", Offset = "0xF40510", VA = "0xF40510")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF40688", Offset = "0xF40688", VA = "0xF40688")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF40730", Offset = "0xF40730", VA = "0xF40730")]
		public void Update()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF40974", Offset = "0xF40974", VA = "0xF40974")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xF40A6C", Offset = "0xF40A6C", VA = "0xF40A6C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xF40B38", Offset = "0xF40B38", VA = "0xF40B38")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7373C4", Offset = "0x7373C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7373C4", Offset = "0x7373C4")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000090")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BA78", Offset = "0x73BA78")]
			public float time;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BAB0", Offset = "0x73BAB0")]
			public bool pause;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BAE8", Offset = "0x73BAE8")]
			public bool pickUp;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB20", Offset = "0x73BB20")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB58", Offset = "0x73BB58")]
			public Message[] messages;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB90", Offset = "0x73BB90")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600053D")]
			[Address(RVA = "0xF3FE0C", Offset = "0xF3FE0C", VA = "0xF3FE0C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0xF41DD8", Offset = "0xF41DD8", VA = "0xF41DD8")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public class Message
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BBC8", Offset = "0x73BBC8")]
			public string function;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BC00", Offset = "0x73BC00")]
			public GameObject recipient;

			[Token(Token = "0x4000460")]
			private const string empty = "";

			[Token(Token = "0x600053F")]
			[Address(RVA = "0xF41CE8", Offset = "0xF41CE8", VA = "0xF41CE8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000540")]
			[Address(RVA = "0xF41DE0", Offset = "0xF41DE0", VA = "0xF41DE0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BC38", Offset = "0x73BC38")]
			public Animator animator;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BC70", Offset = "0x73BC70")]
			public Animation animation;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BCA8", Offset = "0x73BCA8")]
			public string animationState;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BCE0", Offset = "0x73BCE0")]
			public float crossfadeTime;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BD18", Offset = "0x73BD18")]
			public int layer;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BD50", Offset = "0x73BD50")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000467")]
			private const string empty = "";

			[Token(Token = "0x6000541")]
			[Address(RVA = "0xF41A48", Offset = "0xF41A48", VA = "0xF41A48")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0xF41B3C", Offset = "0xF41B3C", VA = "0xF41B3C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xF41BF4", Offset = "0xF41BF4", VA = "0xF41BF4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xF41CD4", Offset = "0xF41CD4", VA = "0xF41CD4")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000B3")]
			public enum Type
			{
				[Token(Token = "0x4000504")]
				PositionWeight,
				[Token(Token = "0x4000505")]
				RotationWeight,
				[Token(Token = "0x4000506")]
				PositionOffsetX,
				[Token(Token = "0x4000507")]
				PositionOffsetY,
				[Token(Token = "0x4000508")]
				PositionOffsetZ,
				[Token(Token = "0x4000509")]
				Pull,
				[Token(Token = "0x400050A")]
				Reach,
				[Token(Token = "0x400050B")]
				RotateBoneWeight,
				[Token(Token = "0x400050C")]
				Push,
				[Token(Token = "0x400050D")]
				PushParent,
				[Token(Token = "0x400050E")]
				PoserWeight
			}

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BD88", Offset = "0x73BD88")]
			public Type type;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BDC0", Offset = "0x73BDC0")]
			public AnimationCurve curve;

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xF41244", Offset = "0xF41244", VA = "0xF41244")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xF41DF8", Offset = "0xF41DF8", VA = "0xF41DF8")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class Multiplier
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BDF8", Offset = "0x73BDF8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BE30", Offset = "0x73BE30")]
			public float multiplier;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BE68", Offset = "0x73BE68")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xF418A8", Offset = "0xF418A8", VA = "0xF418A8")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0xF41DE8", Offset = "0xF41DE8", VA = "0xF41DE8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73943C", Offset = "0x73943C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739474", Offset = "0x739474")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7394AC", Offset = "0x7394AC")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7394E4", Offset = "0x7394E4")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7394F4", Offset = "0x7394F4")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000047")]
		public float length
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xF40D14", Offset = "0xF40D14", VA = "0xF40D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5B8", Offset = "0x73E5B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0xF40D1C", Offset = "0xF40D1C", VA = "0xF40D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5C8", Offset = "0x73E5C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0xF40D24", Offset = "0xF40D24", VA = "0xF40D24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5D8", Offset = "0x73E5D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0xF40D2C", Offset = "0xF40D2C", VA = "0xF40D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E5E8", Offset = "0x73E5E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xF40F48", Offset = "0xF40F48", VA = "0xF40F48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0xF40180", Offset = "0xF40180", VA = "0xF40180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xF40B4C", Offset = "0xF40B4C", VA = "0xF40B4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E468", Offset = "0x73E468")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF40B98", Offset = "0xF40B98", VA = "0xF40B98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E4A0", Offset = "0x73E4A0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF40BE4", Offset = "0xF40BE4", VA = "0xF40BE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E4D8", Offset = "0x73E4D8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xF40C30", Offset = "0xF40C30", VA = "0xF40C30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E510", Offset = "0x73E510")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xF40C7C", Offset = "0xF40C7C", VA = "0xF40C7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E548", Offset = "0x73E548")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF40CC8", Offset = "0xF40CC8", VA = "0xF40CC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E580", Offset = "0x73E580")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xF40D34", Offset = "0xF40D34", VA = "0xF40D34")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF40FD8", Offset = "0xF40FD8", VA = "0xF40FD8")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF3E568", Offset = "0xF3E568", VA = "0xF3E568")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xF4115C", Offset = "0xF4115C", VA = "0xF4115C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF3E41C", Offset = "0xF3E41C", VA = "0xF3E41C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xF3E560", Offset = "0xF3E560", VA = "0xF3E560")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xF3F204", Offset = "0xF3F204", VA = "0xF3F204")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xF3FA54", Offset = "0xF3FA54", VA = "0xF3FA54")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xF418E4", Offset = "0xF418E4", VA = "0xF418E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xF41260", Offset = "0xF41260", VA = "0xF41260")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xF41164", Offset = "0xF41164", VA = "0xF41164")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xF41840", Offset = "0xF41840", VA = "0xF41840")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xF418E8", Offset = "0xF418E8", VA = "0xF418E8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xF41950", Offset = "0xF41950", VA = "0xF41950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E5F8", Offset = "0x73E5F8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xF4199C", Offset = "0xF4199C", VA = "0xF4199C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E630", Offset = "0x73E630")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xF419E8", Offset = "0xF419E8", VA = "0xF419E8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x737424", Offset = "0x737424")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737424", Offset = "0x737424")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000095")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000096")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739504", Offset = "0x739504")]
		public string targetTag;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73953C", Offset = "0x73953C")]
		public float fadeInTime;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739574", Offset = "0x739574")]
		public float speed;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7395AC", Offset = "0x7395AC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7395E4", Offset = "0x7395E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7395E4", Offset = "0x7395E4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7395E4", Offset = "0x7395E4")]
		public Collider characterCollider;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739668", Offset = "0x739668")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x739668", Offset = "0x739668")]
		public Transform FPSCamera;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7396C8", Offset = "0x7396C8")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739700", Offset = "0x739700")]
		public float camRaycastDistance;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739738", Offset = "0x739738")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x739748", Offset = "0x739748")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739748", Offset = "0x739748")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7397A8", Offset = "0x7397A8")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700004B")]
		public bool inInteraction
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xF41FC8", Offset = "0xF41FC8", VA = "0xF41FC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xF43BE0", Offset = "0xF43BE0", VA = "0xF43BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xF43BE8", Offset = "0xF43BE8", VA = "0xF43BE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xF43BF0", Offset = "0xF43BF0", VA = "0xF43BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E7B8", Offset = "0x73E7B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xF43BF8", Offset = "0xF43BF8", VA = "0xF43BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E7C8", Offset = "0x73E7C8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xF41E00", Offset = "0xF41E00", VA = "0xF41E00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E668", Offset = "0x73E668")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xF41E4C", Offset = "0xF41E4C", VA = "0xF41E4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E6A0", Offset = "0x73E6A0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF41E98", Offset = "0xF41E98", VA = "0xF41E98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E6D8", Offset = "0x73E6D8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xF41EE4", Offset = "0xF41EE4", VA = "0xF41EE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E710", Offset = "0x73E710")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF41F30", Offset = "0xF41F30", VA = "0xF41F30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E748", Offset = "0x73E748")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xF41F7C", Offset = "0xF41F7C", VA = "0xF41F7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E780", Offset = "0x73E780")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF42158", Offset = "0xF42158", VA = "0xF42158")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF42224", Offset = "0xF42224", VA = "0xF42224")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xF422F0", Offset = "0xF422F0", VA = "0xF422F0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF4239C", Offset = "0xF4239C", VA = "0xF4239C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF42494", Offset = "0xF42494", VA = "0xF42494")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF425B0", Offset = "0xF425B0", VA = "0xF425B0")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xF42640", Offset = "0xF42640", VA = "0xF42640")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF426D0", Offset = "0xF426D0", VA = "0xF426D0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF42760", Offset = "0xF42760", VA = "0xF42760")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF427D4", Offset = "0xF427D4", VA = "0xF427D4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF42848", Offset = "0xF42848", VA = "0xF42848")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF428B0", Offset = "0xF428B0", VA = "0xF428B0")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF4293C", Offset = "0xF4293C", VA = "0xF4293C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xF429F0", Offset = "0xF429F0", VA = "0xF429F0")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xF42AD4", Offset = "0xF42AD4", VA = "0xF42AD4")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF42D78", Offset = "0xF42D78", VA = "0xF42D78")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF42F50", Offset = "0xF42F50", VA = "0xF42F50")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xF431C4", Offset = "0xF431C4", VA = "0xF431C4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xF434B8", Offset = "0xF434B8", VA = "0xF434B8")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xF434FC", Offset = "0xF434FC", VA = "0xF434FC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xF43574", Offset = "0xF43574", VA = "0xF43574")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xF43694", Offset = "0xF43694", VA = "0xF43694")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xF4380C", Offset = "0xF4380C", VA = "0xF4380C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xF43AB4", Offset = "0xF43AB4", VA = "0xF43AB4")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xF432C4", Offset = "0xF432C4", VA = "0xF432C4")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xF43C00", Offset = "0xF43C00", VA = "0xF43C00", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xF442B4", Offset = "0xF442B4", VA = "0xF442B4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xF442D4", Offset = "0xF442D4", VA = "0xF442D4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xF442F0", Offset = "0xF442F0", VA = "0xF442F0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xF4430C", Offset = "0xF4430C", VA = "0xF4430C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xF4436C", Offset = "0xF4436C", VA = "0xF4436C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xF44488", Offset = "0xF44488", VA = "0xF44488")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xF44584", Offset = "0xF44584", VA = "0xF44584")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xF448E4", Offset = "0xF448E4", VA = "0xF448E4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xF449D0", Offset = "0xF449D0", VA = "0xF449D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xF44C1C", Offset = "0xF44C1C", VA = "0xF44C1C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xF4402C", Offset = "0xF4402C", VA = "0xF4402C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xF44D5C", Offset = "0xF44D5C", VA = "0xF44D5C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xF44E88", Offset = "0xF44E88", VA = "0xF44E88")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xF44F44", Offset = "0xF44F44", VA = "0xF44F44")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xF45040", Offset = "0xF45040", VA = "0xF45040")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xF45058", Offset = "0xF45058", VA = "0xF45058")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xF42074", Offset = "0xF42074", VA = "0xF42074")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xF42C74", Offset = "0xF42C74", VA = "0xF42C74")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xF45348", Offset = "0xF45348", VA = "0xF45348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E7D8", Offset = "0x73E7D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xF45394", Offset = "0xF45394", VA = "0xF45394")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E810", Offset = "0x73E810")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xF453E0", Offset = "0xF453E0", VA = "0xF453E0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x737484", Offset = "0x737484")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737484", Offset = "0x737484")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public class Multiplier
		{
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BEA0", Offset = "0x73BEA0")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BED8", Offset = "0x73BED8")]
			public float multiplier;

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xF45B80", Offset = "0xF45B80", VA = "0xF45B80")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7397E0", Offset = "0x7397E0")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739818", Offset = "0x739818")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739850", Offset = "0x739850")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739888", Offset = "0x739888")]
		public Transform pivot;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7398C0", Offset = "0x7398C0")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7398F8", Offset = "0x7398F8")]
		public float twistWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739930", Offset = "0x739930")]
		public float swingWeight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739968", Offset = "0x739968")]
		public bool rotateOnce;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xF45894", Offset = "0xF45894", VA = "0xF45894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E848", Offset = "0x73E848")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xF458E0", Offset = "0xF458E0", VA = "0xF458E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E880", Offset = "0x73E880")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xF4592C", Offset = "0xF4592C", VA = "0xF4592C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E8B8", Offset = "0x73E8B8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xF45978", Offset = "0xF45978", VA = "0xF45978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E8F0", Offset = "0x73E8F0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xF459C4", Offset = "0xF459C4", VA = "0xF459C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E928", Offset = "0x73E928")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xF45A10", Offset = "0xF45A10", VA = "0xF45A10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E960", Offset = "0x73E960")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xF411D4", Offset = "0xF411D4", VA = "0xF411D4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xF40210", Offset = "0xF40210", VA = "0xF40210")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xF3E61C", Offset = "0xF3E61C", VA = "0xF3E61C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xF45A5C", Offset = "0xF45A5C", VA = "0xF45A5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E998", Offset = "0x73E998")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xF45AA8", Offset = "0xF45AA8", VA = "0xF45AA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E9D0", Offset = "0x73E9D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xF45AF4", Offset = "0xF45AF4", VA = "0xF45AF4")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7374E4", Offset = "0x7374E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7374E4", Offset = "0x7374E4")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000098")]
		public class CharacterPosition
		{
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BF10", Offset = "0x73BF10")]
			public bool use;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BF48", Offset = "0x73BF48")]
			public Vector2 offset;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BF80", Offset = "0x73BF80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BF80", Offset = "0x73BF80")]
			public float angleOffset;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BFDC", Offset = "0x73BFDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BFDC", Offset = "0x73BFDC")]
			public float maxAngle;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C034", Offset = "0x73C034")]
			public float radius;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C06C", Offset = "0x73C06C")]
			public bool orbit;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C0A4", Offset = "0x73C0A4")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000552")]
				[Address(RVA = "0xF46308", Offset = "0xF46308", VA = "0xF46308")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000553")]
				[Address(RVA = "0xF46344", Offset = "0xF46344", VA = "0xF46344")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0xF4643C", Offset = "0xF4643C", VA = "0xF4643C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xF46AB8", Offset = "0xF46AB8", VA = "0xF46AB8")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class CameraPosition
		{
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C0DC", Offset = "0x73C0DC")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C114", Offset = "0x73C114")]
			public Vector3 direction;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C14C", Offset = "0x73C14C")]
			public float maxDistance;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C184", Offset = "0x73C184")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C184", Offset = "0x73C184")]
			public float maxAngle;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C1DC", Offset = "0x73C1DC")]
			public bool fixYAxis;

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xF45DF4", Offset = "0xF45DF4", VA = "0xF45DF4")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0xF45F9C", Offset = "0xF45F9C", VA = "0xF45F9C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0xF4627C", Offset = "0xF4627C", VA = "0xF4627C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009A")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000B4")]
			public class Interaction
			{
				[Token(Token = "0x400050F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D088", Offset = "0x73D088")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000510")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D0C0", Offset = "0x73D0C0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60005BF")]
				[Address(RVA = "0xF46ADC", Offset = "0xF46ADC", VA = "0xF46ADC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C284", Offset = "0x73C284")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C2BC", Offset = "0x73C2BC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C2F4", Offset = "0x73C2F4")]
			public Interaction[] interactions;

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xF45C70", Offset = "0xF45C70", VA = "0xF45C70")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xF46ACC", Offset = "0xF46ACC", VA = "0xF46ACC")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7399A0", Offset = "0x7399A0")]
		public Range[] ranges;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xF45B88", Offset = "0xF45B88", VA = "0xF45B88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EA08", Offset = "0x73EA08")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xF45BD4", Offset = "0xF45BD4", VA = "0xF45BD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EA40", Offset = "0x73EA40")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xF45C20", Offset = "0xF45C20", VA = "0xF45C20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EA78", Offset = "0x73EA78")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xF45C6C", Offset = "0xF45C6C", VA = "0xF45C6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xF44728", Offset = "0xF44728", VA = "0xF44728")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xF45D94", Offset = "0xF45D94", VA = "0xF45D94")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public class Map
		{
			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x10C0FDC", Offset = "0x10C0FDC", VA = "0x10C0FDC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x10C13E0", Offset = "0x10C13E0", VA = "0x10C13E0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x10C1394", Offset = "0x10C1394", VA = "0x10C1394")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0x10C118C", Offset = "0x10C118C", VA = "0x10C118C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x10C0CF4", Offset = "0x10C0CF4", VA = "0x10C0CF4", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EAB0", Offset = "0x73EAB0")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x10C1080", Offset = "0x10C1080", VA = "0x10C1080", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x10C1084", Offset = "0x10C1084", VA = "0x10C1084", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x10C132C", Offset = "0x10C132C", VA = "0x10C132C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x10C1018", Offset = "0x10C1018", VA = "0x10C1018")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x10C0F3C", Offset = "0x10C0F3C", VA = "0x10C0F3C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x10C1430", Offset = "0x10C1430", VA = "0x10C1430")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x11FDDD8", Offset = "0x11FDDD8", VA = "0x11FDDD8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x11FDE90", Offset = "0x11FDE90", VA = "0x11FDE90", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x11FE048", Offset = "0x11FE048", VA = "0x11FE048", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x11FE144", Offset = "0x11FE144", VA = "0x11FE144", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x11FDEEC", Offset = "0x11FDEEC", VA = "0x11FDEEC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x11FE4F4", Offset = "0x11FE4F4", VA = "0x11FE4F4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7399D8", Offset = "0x7399D8")]
		public float weight;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7399F0", Offset = "0x7399F0")]
		public float localRotationWeight;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739A08", Offset = "0x739A08")]
		public float localPositionWeight;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60003B1")]
		public abstract void AutoMapping();

		[Token(Token = "0x60003B2")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60003B3")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60003B4")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF481C0", Offset = "0xF481C0", VA = "0xF481C0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xF48214", Offset = "0xF48214", VA = "0xF48214", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xF48250", Offset = "0xF48250", VA = "0xF48250", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xF48268", Offset = "0xF48268", VA = "0xF48268")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x737544", Offset = "0x737544")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200009C")]
		public class Rigidbone
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xF487EC", Offset = "0xF487EC", VA = "0xF487EC")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xF493F8", Offset = "0xF493F8", VA = "0xF493F8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xF491DC", Offset = "0xF491DC", VA = "0xF491DC")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009D")]
		public class Child
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000562")]
			[Address(RVA = "0xF48948", Offset = "0xF48948", VA = "0xF48948")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0xF49594", Offset = "0xF49594", VA = "0xF49594")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0xF49544", Offset = "0xF49544", VA = "0xF49544")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737738", Offset = "0x737738")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000568")]
				[Address(RVA = "0xF49B74", Offset = "0xF49B74", VA = "0xF49B74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0xF49BDC", Offset = "0xF49BDC", VA = "0xF49BDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0xF489A8", Offset = "0xF489A8", VA = "0xF489A8")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0xF4992C", Offset = "0xF4992C", VA = "0xF4992C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xF49930", Offset = "0xF49930", VA = "0xF49930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xF49B7C", Offset = "0xF49B7C", VA = "0xF49B7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739A20", Offset = "0x739A20")]
		public IK ik;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739A58", Offset = "0x739A58")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739A90", Offset = "0x739A90")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739AC8", Offset = "0x739AC8")]
		public float applyVelocity;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739B00", Offset = "0x739B00")]
		public float applyAngularVelocity;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700004E")]
		private bool isRagdoll
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xF482B0", Offset = "0xF482B0", VA = "0xF482B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		private bool ikUsed
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xF48D94", Offset = "0xF48D94", VA = "0xF48D94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xF48278", Offset = "0xF48278", VA = "0xF48278")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xF48328", Offset = "0xF48328", VA = "0xF48328")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xF48458", Offset = "0xF48458", VA = "0xF48458")]
		public void Start()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xF483E8", Offset = "0xF483E8", VA = "0xF483E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EAE8", Offset = "0x73EAE8")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xF489D4", Offset = "0xF489D4", VA = "0xF489D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xF48C20", Offset = "0xF48C20", VA = "0xF48C20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xF48CD8", Offset = "0xF48CD8", VA = "0xF48CD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xF48F18", Offset = "0xF48F18", VA = "0xF48F18")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xF48D58", Offset = "0xF48D58", VA = "0xF48D58")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xF48ED4", Offset = "0xF48ED4", VA = "0xF48ED4")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xF48FB4", Offset = "0xF48FB4", VA = "0xF48FB4")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xF48F4C", Offset = "0xF48F4C", VA = "0xF48F4C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xF48380", Offset = "0xF48380", VA = "0xF48380")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xF48C60", Offset = "0xF48C60", VA = "0xF48C60")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xF4975C", Offset = "0xF4975C", VA = "0xF4975C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xF49860", Offset = "0xF49860", VA = "0xF49860")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000050")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xF4B444", Offset = "0xF4B444", VA = "0xF4B444")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xF4B480", Offset = "0xF4B480", VA = "0xF4B480")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xF4B0CC", Offset = "0xF4B0CC", VA = "0xF4B0CC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xF4B110", Offset = "0xF4B110", VA = "0xF4B110")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xF4B39C", Offset = "0xF4B39C", VA = "0xF4B39C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xF4B40C", Offset = "0xF4B40C", VA = "0xF4B40C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003D1")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xF4B2AC", Offset = "0xF4B2AC", VA = "0xF4B2AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xF4B550", Offset = "0xF4B550", VA = "0xF4B550")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xF4B554", Offset = "0xF4B554", VA = "0xF4B554")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xF4B588", Offset = "0xF4B588", VA = "0xF4B588")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xF4B66C", Offset = "0xF4B66C", VA = "0xF4B66C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xF4B8E8", Offset = "0xF4B8E8", VA = "0xF4B8E8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xF4B9A4", Offset = "0xF4B9A4", VA = "0xF4B9A4")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7375A8", Offset = "0x7375A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7375A8", Offset = "0x7375A8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739B48", Offset = "0x739B48")]
		public float limit;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739B64", Offset = "0x739B64")]
		public float twistLimit;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xF4BA1C", Offset = "0xF4BA1C", VA = "0xF4BA1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EB4C", Offset = "0x73EB4C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xF4BA68", Offset = "0xF4BA68", VA = "0xF4BA68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EB84", Offset = "0x73EB84")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xF4BAB4", Offset = "0xF4BAB4", VA = "0xF4BAB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EBBC", Offset = "0x73EBBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xF4BB00", Offset = "0xF4BB00", VA = "0xF4BB00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EBF4", Offset = "0x73EBF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xF4BB4C", Offset = "0xF4BB4C", VA = "0xF4BB4C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xF4BC04", Offset = "0xF4BC04", VA = "0xF4BC04")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xF4BE4C", Offset = "0xF4BE4C", VA = "0xF4BE4C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x737608", Offset = "0x737608")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737608", Offset = "0x737608")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xF4BE5C", Offset = "0xF4BE5C", VA = "0xF4BE5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EC2C", Offset = "0x73EC2C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xF4BEA8", Offset = "0xF4BEA8", VA = "0xF4BEA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EC64", Offset = "0x73EC64")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xF4BEF4", Offset = "0xF4BEF4", VA = "0xF4BEF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EC9C", Offset = "0x73EC9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xF4BF40", Offset = "0xF4BF40", VA = "0xF4BF40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ECD4", Offset = "0x73ECD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xF4BF8C", Offset = "0xF4BF8C", VA = "0xF4BF8C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xF4BFB4", Offset = "0xF4BFB4", VA = "0xF4BFB4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xF4C2B4", Offset = "0xF4C2B4", VA = "0xF4C2B4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x737668", Offset = "0x737668")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x737668", Offset = "0x737668")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class ReachCone
		{
			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000092")]
			public Vector3 o
			{
				[Token(Token = "0x600056B")]
				[Address(RVA = "0xF4E25C", Offset = "0xF4E25C", VA = "0xF4E25C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000093")]
			public Vector3 a
			{
				[Token(Token = "0x600056C")]
				[Address(RVA = "0xF4E294", Offset = "0xF4E294", VA = "0xF4E294")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000094")]
			public Vector3 b
			{
				[Token(Token = "0x600056D")]
				[Address(RVA = "0xF4E2D0", Offset = "0xF4E2D0", VA = "0xF4E2D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000095")]
			public Vector3 c
			{
				[Token(Token = "0x600056E")]
				[Address(RVA = "0xF4E30C", Offset = "0xF4E30C", VA = "0xF4E30C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000096")]
			public bool isValid
			{
				[Token(Token = "0x6000570")]
				[Address(RVA = "0xF4D3C0", Offset = "0xF4D3C0", VA = "0xF4D3C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xF4DA0C", Offset = "0xF4DA0C", VA = "0xF4DA0C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xF4DB6C", Offset = "0xF4DB6C", VA = "0xF4DB6C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class LimitPoint
		{
			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000572")]
			[Address(RVA = "0xF4D3D0", Offset = "0xF4D3D0", VA = "0xF4D3D0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739B90", Offset = "0x739B90")]
		public float twistLimit;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739BAC", Offset = "0x739BAC")]
		public int smoothIterations;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xF4C33C", Offset = "0xF4C33C", VA = "0xF4C33C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ED0C", Offset = "0x73ED0C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xF4C388", Offset = "0xF4C388", VA = "0xF4C388")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ED44", Offset = "0x73ED44")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xF4C3D4", Offset = "0xF4C3D4", VA = "0xF4C3D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ED7C", Offset = "0x73ED7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xF4C420", Offset = "0xF4C420", VA = "0xF4C420")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EDB4", Offset = "0x73EDB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xF4C46C", Offset = "0xF4C46C", VA = "0xF4C46C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xF4C954", Offset = "0xF4C954", VA = "0xF4C954", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xF4CA4C", Offset = "0xF4CA4C", VA = "0xF4CA4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xF4D00C", Offset = "0xF4D00C", VA = "0xF4D00C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xF4C50C", Offset = "0xF4C50C", VA = "0xF4C50C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xF4D454", Offset = "0xF4D454", VA = "0xF4D454")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xF4DD2C", Offset = "0xF4DD2C", VA = "0xF4DD2C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xF4DD70", Offset = "0xF4DD70", VA = "0xF4DD70")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xF4DEB8", Offset = "0xF4DEB8", VA = "0xF4DEB8")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xF4CCD0", Offset = "0xF4CCD0", VA = "0xF4CCD0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xF4E048", Offset = "0xF4E048", VA = "0xF4E048")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xF4E1F8", Offset = "0xF4E1F8", VA = "0xF4E1F8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7376C8", Offset = "0x7376C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7376C8", Offset = "0x7376C8")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739C6C", Offset = "0x739C6C")]
		public float twistLimit;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xF4E348", Offset = "0xF4E348", VA = "0xF4E348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EDEC", Offset = "0x73EDEC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xF4E394", Offset = "0xF4E394", VA = "0xF4E394")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE24", Offset = "0x73EE24")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xF4E3E0", Offset = "0xF4E3E0", VA = "0xF4E3E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE5C", Offset = "0x73EE5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xF4E42C", Offset = "0xF4E42C", VA = "0xF4E42C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE94", Offset = "0x73EE94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF4E478", Offset = "0xF4E478", VA = "0xF4E478")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xF4E494", Offset = "0xF4E494", VA = "0xF4E494", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xF4E54C", Offset = "0xF4E54C", VA = "0xF4E54C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xF4E878", Offset = "0xF4E878", VA = "0xF4E878")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739CC0", Offset = "0x739CC0")]
		public AimIK ik;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739CF8", Offset = "0x739CF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739CF8", Offset = "0x739CF8")]
		public float weight;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739D4C", Offset = "0x739D4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739D4C", Offset = "0x739D4C")]
		public Transform target;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739DAC", Offset = "0x739DAC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739DE4", Offset = "0x739DE4")]
		public float weightSmoothTime;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739E1C", Offset = "0x739E1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739E1C", Offset = "0x739E1C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739E7C", Offset = "0x739E7C")]
		public float maxRadiansDelta;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739EB4", Offset = "0x739EB4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739EEC", Offset = "0x739EEC")]
		public float slerpSpeed;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F24", Offset = "0x739F24")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F5C", Offset = "0x739F5C")]
		public float minDistance;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F94", Offset = "0x739F94")]
		public Vector3 offset;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739FCC", Offset = "0x739FCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739FCC", Offset = "0x739FCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739FCC", Offset = "0x739FCC")]
		public float maxRootAngle;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73A048", Offset = "0x73A048")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A048", Offset = "0x73A048")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A0A8", Offset = "0x73A0A8")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000052")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x10B45F8", Offset = "0x10B45F8", VA = "0x10B45F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x10B44FC", Offset = "0x10B44FC", VA = "0x10B44FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x10B4744", Offset = "0x10B4744", VA = "0x10B4744")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x10B4E60", Offset = "0x10B4E60", VA = "0x10B4E60")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x10B4FFC", Offset = "0x10B4FFC", VA = "0x10B4FFC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x10B5318", Offset = "0x10B5318", VA = "0x10B5318")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class Pose
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x10B56A4", Offset = "0x10B56A4", VA = "0x10B56A4")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x10B5A10", Offset = "0x10B5A10", VA = "0x10B5A10")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x10B5A18", Offset = "0x10B5A18", VA = "0x10B5A18")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x10B55C8", Offset = "0x10B55C8", VA = "0x10B55C8")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x10B593C", Offset = "0x10B593C", VA = "0x10B593C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x10B59A8", Offset = "0x10B59A8", VA = "0x10B59A8")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000B5")]
			public class EffectorLink
			{
				[Token(Token = "0x4000511")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D0F8", Offset = "0x73D0F8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000512")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D130", Offset = "0x73D130")]
				public float weight;

				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x10B6008", Offset = "0x10B6008", VA = "0x10B6008")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C32C", Offset = "0x73C32C")]
			public Transform transform;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C364", Offset = "0x73C364")]
			public Transform relativeTo;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C39C", Offset = "0x73C39C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C3D4", Offset = "0x73C3D4")]
			public float verticalWeight;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C40C", Offset = "0x73C40C")]
			public float horizontalWeight;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C444", Offset = "0x73C444")]
			public float speed;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x10B5B74", Offset = "0x10B5B74", VA = "0x10B5B74")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x10B5FE0", Offset = "0x10B5FE0", VA = "0x10B5FE0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x10B5FF0", Offset = "0x10B5FF0", VA = "0x10B5FF0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A0E0", Offset = "0x73A0E0")]
		public Body[] bodies;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x10B5A34", Offset = "0x10B5A34", VA = "0x10B5A34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10B5FD8", Offset = "0x10B5FD8", VA = "0x10B5FD8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A118", Offset = "0x73A118")]
		public float tiltSpeed;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A150", Offset = "0x73A150")]
		public float tiltSensitivity;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A188", Offset = "0x73A188")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A1C0", Offset = "0x73A1C0")]
		public OffsetPose poseRight;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10B7374", Offset = "0x10B7374", VA = "0x10B7374", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10B73BC", Offset = "0x10B73BC", VA = "0x10B73BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10B75EC", Offset = "0x10B75EC", VA = "0x10B75EC")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A3")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C47C", Offset = "0x73C47C")]
			public string name;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C4B4", Offset = "0x73C4B4")]
			public Collider collider;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C4EC", Offset = "0x73C4EC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C538", Offset = "0x73C538")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C548", Offset = "0x73C548")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C558", Offset = "0x73C558")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C568", Offset = "0x73C568")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000097")]
			public bool inProgress
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x11FE5B8", Offset = "0x11FE5B8", VA = "0x11FE5B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000098")]
			protected float crossFader
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0x11FEB60", Offset = "0x11FEB60", VA = "0x11FEB60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2A4", Offset = "0x73F2A4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600057B")]
				[Address(RVA = "0x11FEB68", Offset = "0x11FEB68", VA = "0x11FEB68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2B4", Offset = "0x73F2B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			protected float timer
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0x11FEB70", Offset = "0x11FEB70", VA = "0x11FEB70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2C4", Offset = "0x73F2C4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600057D")]
				[Address(RVA = "0x11FEB78", Offset = "0x11FEB78", VA = "0x11FEB78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2D4", Offset = "0x73F2D4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			protected Vector3 force
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0x11FEB80", Offset = "0x11FEB80", VA = "0x11FEB80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2E4", Offset = "0x73F2E4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600057F")]
				[Address(RVA = "0x11FEB8C", Offset = "0x11FEB8C", VA = "0x11FEB8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F2F4", Offset = "0x73F2F4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			protected Vector3 point
			{
				[Token(Token = "0x6000580")]
				[Address(RVA = "0x11FEB98", Offset = "0x11FEB98", VA = "0x11FEB98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F304", Offset = "0x73F304")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000581")]
				[Address(RVA = "0x11FEBA4", Offset = "0x11FEBA4", VA = "0x11FEBA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F314", Offset = "0x73F314")]
				private set
				{
				}
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x11FEA2C", Offset = "0x11FEA2C", VA = "0x11FEA2C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x11FE6A0", Offset = "0x11FE6A0", VA = "0x11FE6A0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000584")]
			protected abstract float GetLength();

			[Token(Token = "0x6000585")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000586")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x11FEBB0", Offset = "0x11FEBB0", VA = "0x11FEBB0")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A4")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B6")]
			public class EffectorLink
			{
				[Token(Token = "0x4000513")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D168", Offset = "0x73D168")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000514")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D1A0", Offset = "0x73D1A0")]
				public float weight;

				[Token(Token = "0x4000515")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000516")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x11FF51C", Offset = "0x11FF51C", VA = "0x11FF51C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x11FF310", Offset = "0x11FF310", VA = "0x11FF310")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x11FF658", Offset = "0x11FF658", VA = "0x11FF658")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C578", Offset = "0x73C578")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C5B0", Offset = "0x73C5B0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C5E8", Offset = "0x73C5E8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x11FF12C", Offset = "0x11FF12C", VA = "0x11FF12C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x11FF2A4", Offset = "0x11FF2A4", VA = "0x11FF2A4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x11FF324", Offset = "0x11FF324", VA = "0x11FF324", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x11FF644", Offset = "0x11FF644", VA = "0x11FF644")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B7")]
			public class BoneLink
			{
				[Token(Token = "0x4000517")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D1D8", Offset = "0x73D1D8")]
				public Transform bone;

				[Token(Token = "0x4000518")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D210", Offset = "0x73D210")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D210", Offset = "0x73D210")]
				public float weight;

				[Token(Token = "0x4000519")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400051A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005C4")]
				[Address(RVA = "0x11FEF34", Offset = "0x11FEF34", VA = "0x11FEF34")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x11FECCC", Offset = "0x11FECCC", VA = "0x11FECCC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005C6")]
				[Address(RVA = "0x11FF0A4", Offset = "0x11FF0A4", VA = "0x11FF0A4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C620", Offset = "0x73C620")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C658", Offset = "0x73C658")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x11FEBC4", Offset = "0x11FEBC4", VA = "0x11FEBC4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0x11FEC68", Offset = "0x11FEC68", VA = "0x11FEC68", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x11FECD8", Offset = "0x11FECD8", VA = "0x11FECD8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x11FF090", Offset = "0x11FF090", VA = "0x11FF090")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A1F8", Offset = "0x73A1F8")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A230", Offset = "0x73A230")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000053")]
		public bool inProgress
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x11FE4FC", Offset = "0x11FE4FC", VA = "0x11FE4FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x11FE5CC", Offset = "0x11FE5CC", VA = "0x11FE5CC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x11FE7EC", Offset = "0x11FE7EC", VA = "0x11FE7EC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x11FEB58", Offset = "0x11FEB58", VA = "0x11FEB58")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public abstract class Offset
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C690", Offset = "0x73C690")]
			public string name;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C6C8", Offset = "0x73C6C8")]
			public Collider collider;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C700", Offset = "0x73C700")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C74C", Offset = "0x73C74C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C75C", Offset = "0x73C75C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C76C", Offset = "0x73C76C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C77C", Offset = "0x73C77C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700009C")]
			protected float crossFader
			{
				[Token(Token = "0x6000590")]
				[Address(RVA = "0x11FFC10", Offset = "0x11FFC10", VA = "0x11FFC10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F324", Offset = "0x73F324")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000591")]
				[Address(RVA = "0x11FFC18", Offset = "0x11FFC18", VA = "0x11FFC18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F334", Offset = "0x73F334")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			protected float timer
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0x11FFC20", Offset = "0x11FFC20", VA = "0x11FFC20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F344", Offset = "0x73F344")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x11FFC28", Offset = "0x11FFC28", VA = "0x11FFC28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F354", Offset = "0x73F354")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			protected Vector3 force
			{
				[Token(Token = "0x6000594")]
				[Address(RVA = "0x11FFC30", Offset = "0x11FFC30", VA = "0x11FFC30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F364", Offset = "0x73F364")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000595")]
				[Address(RVA = "0x11FFC3C", Offset = "0x11FFC3C", VA = "0x11FFC3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F374", Offset = "0x73F374")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			protected Vector3 point
			{
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x11FFC48", Offset = "0x11FFC48", VA = "0x11FFC48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F384", Offset = "0x73F384")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x11FFC54", Offset = "0x11FFC54", VA = "0x11FFC54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F394", Offset = "0x73F394")]
				private set
				{
				}
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x11FFAC8", Offset = "0x11FFAC8", VA = "0x11FFAC8")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x11FF72C", Offset = "0x11FF72C", VA = "0x11FF72C")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600059A")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600059B")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600059C")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x11FFC60", Offset = "0x11FFC60", VA = "0x11FFC60")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B8")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400051B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D264", Offset = "0x73D264")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400051C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D29C", Offset = "0x73D29C")]
				public float weight;

				[Token(Token = "0x400051D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400051E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x120011C", Offset = "0x120011C", VA = "0x120011C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005C8")]
				[Address(RVA = "0x11FFED8", Offset = "0x11FFED8", VA = "0x11FFED8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x1200238", Offset = "0x1200238", VA = "0x1200238")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C78C", Offset = "0x73C78C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C7C4", Offset = "0x73C7C4")]
			public int upDirCurveIndex;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C7FC", Offset = "0x73C7FC")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x11FFC74", Offset = "0x11FFC74", VA = "0x11FFC74", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x11FFE6C", Offset = "0x11FFE6C", VA = "0x11FFE6C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x11FFEEC", Offset = "0x11FFEEC", VA = "0x11FFEEC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x120021C", Offset = "0x120021C", VA = "0x120021C")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A8")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B9")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400051F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D2D4", Offset = "0x73D2D4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000520")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D30C", Offset = "0x73D30C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D30C", Offset = "0x73D30C")]
				public float weight;

				[Token(Token = "0x4000521")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000522")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x12006A0", Offset = "0x12006A0", VA = "0x12006A0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x1200388", Offset = "0x1200388", VA = "0x1200388")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x12007DC", Offset = "0x12007DC", VA = "0x12007DC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C834", Offset = "0x73C834")]
			public int curveIndex;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C86C", Offset = "0x73C86C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1200240", Offset = "0x1200240", VA = "0x1200240", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1200324", Offset = "0x1200324", VA = "0x1200324", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1200394", Offset = "0x1200394", VA = "0x1200394", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x12007C8", Offset = "0x12007C8", VA = "0x12007C8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A268", Offset = "0x73A268")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A2A0", Offset = "0x73A2A0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x11FF660", Offset = "0x11FF660", VA = "0x11FF660", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x11FF880", Offset = "0x11FF880", VA = "0x11FF880")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x11FFC08", Offset = "0x11FFC08", VA = "0x11FFC08")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BA")]
			public class EffectorLink
			{
				[Token(Token = "0x4000523")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D360", Offset = "0x73D360")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000524")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D398", Offset = "0x73D398")]
				public float weight;

				[Token(Token = "0x60005CD")]
				[Address(RVA = "0xF3D4DC", Offset = "0xF3D4DC", VA = "0xF3D4DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C8A4", Offset = "0x73C8A4")]
			public Transform transform;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C8DC", Offset = "0x73C8DC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C914", Offset = "0x73C914")]
			public float speed;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C94C", Offset = "0x73C94C")]
			public float acceleration;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C984", Offset = "0x73C984")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C984", Offset = "0x73C984")]
			public float matchVelocity;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C9D8", Offset = "0x73C9D8")]
			public float gravity;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xF3CEAC", Offset = "0xF3CEAC", VA = "0xF3CEAC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xF3D06C", Offset = "0xF3D06C", VA = "0xF3D06C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xF3D4C0", Offset = "0xF3D4C0", VA = "0xF3D4C0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A2D8", Offset = "0x73A2D8")]
		public Body[] bodies;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A310", Offset = "0x73A310")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF3CE34", Offset = "0xF3CE34", VA = "0xF3CE34")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF3CF88", Offset = "0xF3CF88", VA = "0xF3CF88", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF3D4A0", Offset = "0xF3D4A0", VA = "0xF3D4A0")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class OffsetLimits
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CA10", Offset = "0x73CA10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CA48", Offset = "0x73CA48")]
			public float spring;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CA80", Offset = "0x73CA80")]
			public bool x;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CAB8", Offset = "0x73CAB8")]
			public bool y;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CAF0", Offset = "0x73CAF0")]
			public bool z;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CB28", Offset = "0x73CB28")]
			public float minX;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CB60", Offset = "0x73CB60")]
			public float maxX;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CB98", Offset = "0x73CB98")]
			public float minY;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CBD0", Offset = "0x73CBD0")]
			public float maxY;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CC08", Offset = "0x73CC08")]
			public float minZ;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CC40", Offset = "0x73CC40")]
			public float maxZ;

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xF471D8", Offset = "0xF471D8", VA = "0xF471D8")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xF476E0", Offset = "0xF476E0", VA = "0xF476E0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xF47710", Offset = "0xF47710", VA = "0xF47710")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xF477E8", Offset = "0xF477E8", VA = "0xF477E8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737748", Offset = "0x737748")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0xF47670", Offset = "0xF47670", VA = "0xF47670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0xF476D8", Offset = "0xF476D8", VA = "0xF476D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xF470A0", Offset = "0xF470A0", VA = "0xF470A0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xF47530", Offset = "0xF47530", VA = "0xF47530", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xF47534", Offset = "0xF47534", VA = "0xF47534", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xF47678", Offset = "0xF47678", VA = "0xF47678", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A348", Offset = "0x73A348")]
		public float weight;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A380", Offset = "0x73A380")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000054")]
		protected float deltaTime
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xF3D040", Offset = "0xF3D040", VA = "0xF3D040")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000418")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF47004", Offset = "0xF47004", VA = "0xF47004", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xF47030", Offset = "0xF47030", VA = "0xF47030")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EECC", Offset = "0x73EECC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xF470CC", Offset = "0xF470CC", VA = "0xF470CC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xF3D3E4", Offset = "0xF3D3E4", VA = "0xF3D3E4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xF47438", Offset = "0xF47438", VA = "0xF47438", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xF3D4B0", Offset = "0xF3D4B0", VA = "0xF3D4B0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737758", Offset = "0x737758")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B6")]
				[Address(RVA = "0xF47C38", Offset = "0xF47C38", VA = "0xF47C38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0xF47CA0", Offset = "0xF47CA0", VA = "0xF47CA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xF478B8", Offset = "0xF478B8", VA = "0xF478B8")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xF47AF8", Offset = "0xF47AF8", VA = "0xF47AF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xF47AFC", Offset = "0xF47AFC", VA = "0xF47AFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xF47C40", Offset = "0xF47C40", VA = "0xF47C40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A3B8", Offset = "0x73A3B8")]
		public float weight;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A3F0", Offset = "0x73A3F0")]
		public VRIK ik;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000055")]
		protected float deltaTime
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xF477F0", Offset = "0xF477F0", VA = "0xF477F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000420")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xF4781C", Offset = "0xF4781C", VA = "0xF4781C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF47848", Offset = "0xF47848", VA = "0xF47848")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EF30", Offset = "0x73EF30")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF478E4", Offset = "0xF478E4", VA = "0xF478E4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF479F0", Offset = "0xF479F0", VA = "0xF479F0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xF47AE8", Offset = "0xF47AE8", VA = "0xF47AE8")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public class EffectorLink
		{
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xF47D68", Offset = "0xF47D68", VA = "0xF47D68")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xF481B8", Offset = "0xF481B8", VA = "0xF481B8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xF47CA8", Offset = "0xF47CA8", VA = "0xF47CA8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xF480A0", Offset = "0xF480A0", VA = "0xF480A0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xF48158", Offset = "0xF48158", VA = "0xF48158")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000BB")]
			public class EffectorLink
			{
				[Token(Token = "0x4000525")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D3D0", Offset = "0x73D3D0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000526")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D408", Offset = "0x73D408")]
				public float weight;

				[Token(Token = "0x60005CE")]
				[Address(RVA = "0xF4B0C4", Offset = "0xF4B0C4", VA = "0xF4B0C4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CC78", Offset = "0x73CC78")]
			public Vector3 offset;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CCB0", Offset = "0x73CCB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73CCB0", Offset = "0x73CCB0")]
			public float additivity;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD04", Offset = "0x73CD04")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD3C", Offset = "0x73CD3C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xF49E0C", Offset = "0xF49E0C", VA = "0xF49E0C")]
			public void Start()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xF4A99C", Offset = "0xF4A99C", VA = "0xF4A99C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xF4B0B0", Offset = "0xF4B0B0", VA = "0xF4B0B0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public enum Handedness
		{
			[Token(Token = "0x40004F1")]
			Right,
			[Token(Token = "0x40004F2")]
			Left
		}

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A428", Offset = "0x73A428")]
		public AimIK aimIK;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A460", Offset = "0x73A460")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A498", Offset = "0x73A498")]
		public Handedness handedness;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A4D0", Offset = "0x73A4D0")]
		public bool twoHanded;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A508", Offset = "0x73A508")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A540", Offset = "0x73A540")]
		public float magnitudeRandom;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A578", Offset = "0x73A578")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A5B0", Offset = "0x73A5B0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A5E8", Offset = "0x73A5E8")]
		public float blendTime;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x73A620", Offset = "0x73A620")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A620", Offset = "0x73A620")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000056")]
		public bool isFinished
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xF49BE4", Offset = "0xF49BE4", VA = "0xF49BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xF4AC50", Offset = "0xF4AC50", VA = "0xF4AC50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xF4AC90", Offset = "0xF4AC90", VA = "0xF4AC90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xF4AC10", Offset = "0xF4AC10", VA = "0xF4AC10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0xF4AC30", Offset = "0xF4AC30", VA = "0xF4AC30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xF49C14", Offset = "0xF49C14", VA = "0xF49C14")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xF49C40", Offset = "0xF49C40", VA = "0xF49C40")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xF49EBC", Offset = "0xF49EBC", VA = "0xF49EBC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF4ACD0", Offset = "0xF4ACD0", VA = "0xF4ACD0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF4AE28", Offset = "0xF4AE28", VA = "0xF4AE28")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xF4AE64", Offset = "0xF4AE64", VA = "0xF4AE64", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xF4AFFC", Offset = "0xF4AFFC", VA = "0xF4AFFC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A680", Offset = "0x73A680")]
		public float weight;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A6B8", Offset = "0x73A6B8")]
		public float offset;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xF4E884", Offset = "0xF4E884", VA = "0xF4E884")]
		private void Start()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xF4E958", Offset = "0xF4E958", VA = "0xF4E958")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xF4EA44", Offset = "0xF4EA44", VA = "0xF4EA44")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xF4EE8C", Offset = "0xF4EE8C", VA = "0xF4EE8C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xF4EEC4", Offset = "0xF4EEC4", VA = "0xF4EEC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xF4EFBC", Offset = "0xF4EFBC", VA = "0xF4EFBC")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public class Settings
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD74", Offset = "0x73CD74")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CDAC", Offset = "0x73CDAC")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CDE4", Offset = "0x73CDE4")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE1C", Offset = "0x73CE1C")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE54", Offset = "0x73CE54")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE8C", Offset = "0x73CE8C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CEC4", Offset = "0x73CEC4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CEFC", Offset = "0x73CEFC")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x73CF34", Offset = "0x73CF34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CF34", Offset = "0x73CF34")]
			public Vector3 headOffset;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CF84", Offset = "0x73CF84")]
			public Vector3 handOffset;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CFBC", Offset = "0x73CFBC")]
			public float footForwardOffset;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CFF4", Offset = "0x73CFF4")]
			public float footInwardOffset;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D02C", Offset = "0x73D02C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D02C", Offset = "0x73D02C")]
			public float footHeadingOffset;

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x15ADAD0", Offset = "0x15ADAD0", VA = "0x15ADAD0")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x15ABFE8", Offset = "0x15ABFE8", VA = "0x15ABFE8")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x15AD1D0", Offset = "0x15AD1D0", VA = "0x15AD1D0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x15ADBB8", Offset = "0x15ADBB8", VA = "0x15ADBB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x15AD990", Offset = "0x15AD990", VA = "0x15AD990")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x15ADC8C", Offset = "0x15ADC8C", VA = "0x15ADC8C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x15AE078", Offset = "0x15AE078", VA = "0x15AE078")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x15AE170", Offset = "0x15AE170", VA = "0x15AE170")]
		public VRIKRootController()
		{
		}
	}
}
