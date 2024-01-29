using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73456C", Offset = "0x73456C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73456C", Offset = "0x73456C")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000003")]
		public enum Mode
		{
			[Token(Token = "0x4000010")]
			AnimationClips,
			[Token(Token = "0x4000011")]
			AnimationStates,
			[Token(Token = "0x4000012")]
			PlayableDirector,
			[Token(Token = "0x4000013")]
			Realtime
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735018", Offset = "0x735018")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735018", Offset = "0x735018")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735070", Offset = "0x735070")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735070", Offset = "0x735070")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7350C8", Offset = "0x7350C8")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735100", Offset = "0x735100")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735138", Offset = "0x735138")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735170", Offset = "0x735170")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7351A8", Offset = "0x7351A8")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7351E0", Offset = "0x7351E0")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735218", Offset = "0x735218")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735250", Offset = "0x735250")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735260", Offset = "0x735260")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735290", Offset = "0x735290")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x15B0D70", Offset = "0x15B0D70", VA = "0x15B0D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5B8", Offset = "0x73D5B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x15B0D78", Offset = "0x15B0D78", VA = "0x15B0D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5C8", Offset = "0x73D5C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x15B0D84", Offset = "0x15B0D84", VA = "0x15B0D84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5D8", Offset = "0x73D5D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x15B0D8C", Offset = "0x15B0D8C", VA = "0x15B0D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5E8", Offset = "0x73D5E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x15B0D94", Offset = "0x15B0D94", VA = "0x15B0D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D5F8", Offset = "0x73D5F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x15B0D9C", Offset = "0x15B0D9C", VA = "0x15B0D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D608", Offset = "0x73D608")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x15B0C50", Offset = "0x15B0C50", VA = "0x15B0C50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D4D8", Offset = "0x73D4D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x15B0C98", Offset = "0x15B0C98", VA = "0x15B0C98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D510", Offset = "0x73D510")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x15B0CE0", Offset = "0x15B0CE0", VA = "0x15B0CE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D548", Offset = "0x73D548")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x15B0D28", Offset = "0x15B0D28", VA = "0x15B0D28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D580", Offset = "0x73D580")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000009")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x600000A")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x600000B")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600000C")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x600000D")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x15B0DA4", Offset = "0x15B0DA4", VA = "0x15B0DA4")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x15B0DA8", Offset = "0x15B0DA8", VA = "0x15B0DA8")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x15B0DAC", Offset = "0x15B0DAC", VA = "0x15B0DAC")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x15B0DB0", Offset = "0x15B0DB0", VA = "0x15B0DB0")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7352A0", Offset = "0x7352A0")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7352D8", Offset = "0x7352D8")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735310", Offset = "0x735310")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735348", Offset = "0x735348")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735380", Offset = "0x735380")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x15E1AA0", Offset = "0x15E1AA0", VA = "0x15E1AA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x15E1E90", Offset = "0x15E1E90", VA = "0x15E1E90", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x15E1E98", Offset = "0x15E1E98", VA = "0x15E1E98", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x15E1FA8", Offset = "0x15E1FA8", VA = "0x15E1FA8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x15E2024", Offset = "0x15E2024", VA = "0x15E2024", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x15E20A0", Offset = "0x15E20A0", VA = "0x15E20A0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x15E1CE8", Offset = "0x15E1CE8", VA = "0x15E1CE8")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x15E1DBC", Offset = "0x15E1DBC", VA = "0x15E1DBC")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x15E211C", Offset = "0x15E211C", VA = "0x15E211C")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class TQ
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x14A004C", Offset = "0x14A004C", VA = "0x14A004C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x15B0048", Offset = "0x15B0048", VA = "0x15B0048")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x15B02A4", Offset = "0x15B02A4", VA = "0x15B02A4")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x15B0284", Offset = "0x15B0284", VA = "0x15B0284")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x15B0850", Offset = "0x15B0850", VA = "0x15B0850")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x15B202C", Offset = "0x15B202C", VA = "0x15B202C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x15B38E4", Offset = "0x15B38E4", VA = "0x15B38E4")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x15B1A80", Offset = "0x15B1A80", VA = "0x15B1A80")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x15B2074", Offset = "0x15B2074", VA = "0x15B2074")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x15B15B0", Offset = "0x15B15B0", VA = "0x15B15B0")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x15B0E9C", Offset = "0x15B0E9C", VA = "0x15B0E9C")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x15B1108", Offset = "0x15B1108", VA = "0x15B1108")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x15B1000", Offset = "0x15B1000", VA = "0x15B1000")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x15B1284", Offset = "0x15B1284", VA = "0x15B1284")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x15B1814", Offset = "0x15B1814", VA = "0x15B1814")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x15B1910", Offset = "0x15B1910", VA = "0x15B1910")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x15B1A0C", Offset = "0x15B1A0C", VA = "0x15B1A0C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x15B1984", Offset = "0x15B1984", VA = "0x15B1984")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x15B1C78", Offset = "0x15B1C78", VA = "0x15B1C78")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x15B1D2C", Offset = "0x15B1D2C", VA = "0x15B1D2C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x15B2078", Offset = "0x15B2078", VA = "0x15B2078")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x15B20E8", Offset = "0x15B20E8", VA = "0x15B20E8")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x15B2B7C", Offset = "0x15B2B7C", VA = "0x15B2B7C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x15B2C30", Offset = "0x15B2C30", VA = "0x15B2C30")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x15B2B20", Offset = "0x15B2B20", VA = "0x15B2B20")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x15B2D28", Offset = "0x15B2D28", VA = "0x15B2D28")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x15B2D70", Offset = "0x15B2D70", VA = "0x15B2D70")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BakerTransform
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x15B2D78", Offset = "0x15B2D78", VA = "0x15B2D78")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x15B2F04", Offset = "0x15B2F04", VA = "0x15B2F04")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x15B2F18", Offset = "0x15B2F18", VA = "0x15B2F18")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x15B3204", Offset = "0x15B3204", VA = "0x15B3204")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x15B2E10", Offset = "0x15B2E10", VA = "0x15B2E10")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x15B34B8", Offset = "0x15B34B8", VA = "0x15B34B8")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x15B352C", Offset = "0x15B352C", VA = "0x15B352C")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x15B36E0", Offset = "0x15B36E0", VA = "0x15B36E0")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7353B8", Offset = "0x7353B8")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7353F0", Offset = "0x7353F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7353F0", Offset = "0x7353F0")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735448", Offset = "0x735448")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735448", Offset = "0x735448")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1631BE0", Offset = "0x1631BE0", VA = "0x1631BE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x16320BC", Offset = "0x16320BC", VA = "0x16320BC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x16320D8", Offset = "0x16320D8", VA = "0x16320D8", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x16321B4", Offset = "0x16321B4", VA = "0x16321B4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1632290", Offset = "0x1632290", VA = "0x1632290", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1632460", Offset = "0x1632460", VA = "0x1632460", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1632798", Offset = "0x1632798", VA = "0x1632798")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1632874", Offset = "0x1632874", VA = "0x1632874")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000D")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000077")]
			Update,
			[Token(Token = "0x4000078")]
			FixedUpdate,
			[Token(Token = "0x4000079")]
			LateUpdate,
			[Token(Token = "0x400007A")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73549C", Offset = "0x73549C")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7354D4", Offset = "0x7354D4")]
		public float rotationSensitivity;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73550C", Offset = "0x73550C")]
		public float distance;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x735544", Offset = "0x735544")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73557C", Offset = "0x73557C")]
		public float blockedOffset;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735594", Offset = "0x735594")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7355A4", Offset = "0x7355A4")]
		private float <y>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7355B4", Offset = "0x7355B4")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x15BC4DC", Offset = "0x15BC4DC", VA = "0x15BC4DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D618", Offset = "0x73D618")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x15BC4E4", Offset = "0x15BC4E4", VA = "0x15BC4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D628", Offset = "0x73D628")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x15BC4EC", Offset = "0x15BC4EC", VA = "0x15BC4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D638", Offset = "0x73D638")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x15BC4F4", Offset = "0x15BC4F4", VA = "0x15BC4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D648", Offset = "0x73D648")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x15BC4FC", Offset = "0x15BC4FC", VA = "0x15BC4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D658", Offset = "0x73D658")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x15BC504", Offset = "0x15BC504", VA = "0x15BC504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D668", Offset = "0x73D668")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x15BCDE0", Offset = "0x15BCDE0", VA = "0x15BCDE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x15BC50C", Offset = "0x15BC50C", VA = "0x15BC50C")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x15BC548", Offset = "0x15BC548", VA = "0x15BC548")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x15BC550", Offset = "0x15BC550", VA = "0x15BC550", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x15BC654", Offset = "0x15BC654", VA = "0x15BC654", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x15BC6B0", Offset = "0x15BC6B0", VA = "0x15BC6B0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x15BC718", Offset = "0x15BC718", VA = "0x15BC718", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15BC77C", Offset = "0x15BC77C", VA = "0x15BC77C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x15BC688", Offset = "0x15BC688", VA = "0x15BC688")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x15BC8FC", Offset = "0x15BC8FC", VA = "0x15BC8FC")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x15BCDB0", Offset = "0x15BCDB0", VA = "0x15BCDB0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x15BCE50", Offset = "0x15BCE50", VA = "0x15BCE50")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x15BCEFC", Offset = "0x15BCEFC", VA = "0x15BCEFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x15BCF34", Offset = "0x15BCF34", VA = "0x15BCF34")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x15BD0DC", Offset = "0x15BD0DC", VA = "0x15BD0DC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x15BD10C", Offset = "0x15BD10C", VA = "0x15BD10C")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public enum Axis
	{
		[Token(Token = "0x4000081")]
		X,
		[Token(Token = "0x4000082")]
		Y,
		[Token(Token = "0x4000083")]
		Z
	}
	[Token(Token = "0x2000010")]
	public class AxisTools
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x15B0858", Offset = "0x15B0858", VA = "0x15B0858")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x15B087C", Offset = "0x15B087C", VA = "0x15B087C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15B08B4", Offset = "0x15B08B4", VA = "0x15B08B4")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15B09A4", Offset = "0x15B09A4", VA = "0x15B09A4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15B094C", Offset = "0x15B094C", VA = "0x15B094C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15B0A3C", Offset = "0x15B0A3C", VA = "0x15B0A3C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x15B0A84", Offset = "0x15B0A84", VA = "0x15B0A84")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15B0C48", Offset = "0x15B0C48", VA = "0x15B0C48")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000012")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x14A9114", Offset = "0x14A9114", VA = "0x14A9114")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x15B5388", Offset = "0x15B5388", VA = "0x15B5388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x15B55F4", Offset = "0x15B55F4", VA = "0x15B55F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x15B533C", Offset = "0x15B533C", VA = "0x15B533C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000014")]
		public enum BoneType
		{
			[Token(Token = "0x400009E")]
			Unassigned,
			[Token(Token = "0x400009F")]
			Spine,
			[Token(Token = "0x40000A0")]
			Head,
			[Token(Token = "0x40000A1")]
			Arm,
			[Token(Token = "0x40000A2")]
			Leg,
			[Token(Token = "0x40000A3")]
			Tail,
			[Token(Token = "0x40000A4")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000015")]
		public enum BoneSide
		{
			[Token(Token = "0x40000A6")]
			Center,
			[Token(Token = "0x40000A7")]
			Left,
			[Token(Token = "0x40000A8")]
			Right
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x15B5860", Offset = "0x15B5860", VA = "0x15B5860")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x15B5B7C", Offset = "0x15B5B7C", VA = "0x15B5B7C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15B5DE8", Offset = "0x15B5DE8", VA = "0x15B5DE8")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15B5E68", Offset = "0x15B5E68", VA = "0x15B5E68")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x15B5F10", Offset = "0x15B5F10", VA = "0x15B5F10")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x15B5A30", Offset = "0x15B5A30", VA = "0x15B5A30")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x15B5D4C", Offset = "0x15B5D4C", VA = "0x15B5D4C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x15B6740", Offset = "0x15B6740", VA = "0x15B6740")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15B6548", Offset = "0x15B6548", VA = "0x15B6548")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15B6644", Offset = "0x15B6644", VA = "0x15B6644")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x15B6128", Offset = "0x15B6128", VA = "0x15B6128")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15B61D8", Offset = "0x15B61D8", VA = "0x15B61D8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15B6288", Offset = "0x15B6288", VA = "0x15B6288")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15B6338", Offset = "0x15B6338", VA = "0x15B6338")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x15B63E8", Offset = "0x15B63E8", VA = "0x15B63E8")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x15B6498", Offset = "0x15B6498", VA = "0x15B6498")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15B6948", Offset = "0x15B6948", VA = "0x15B6948")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x15B6040", Offset = "0x15B6040", VA = "0x15B6040")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x15B68B8", Offset = "0x15B68B8", VA = "0x15B68B8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x15B69B4", Offset = "0x15B69B4", VA = "0x15B69B4")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x15B6A88", Offset = "0x15B6A88", VA = "0x15B6A88")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x15B6840", Offset = "0x15B6840", VA = "0x15B6840")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x15B67CC", Offset = "0x15B67CC", VA = "0x15B67CC")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class BipedReferences
	{
		[Token(Token = "0x2000017")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x14A91A0", Offset = "0x14A91A0", VA = "0x14A91A0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x14A918C", Offset = "0x14A918C", VA = "0x14A918C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x15B8ACC", Offset = "0x15B8ACC", VA = "0x15B8ACC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x15B8EB4", Offset = "0x15B8EB4", VA = "0x15B8EB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x15B8EC4", Offset = "0x15B8EC4", VA = "0x15B8EC4", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x15B92EC", Offset = "0x15B92EC", VA = "0x15B92EC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x15B9720", Offset = "0x15B9720", VA = "0x15B9720")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x15B9D0C", Offset = "0x15B9D0C", VA = "0x15B9D0C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x15B9934", Offset = "0x15B9934", VA = "0x15B9934")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x15B4710", Offset = "0x15B4710", VA = "0x15B4710")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x15BA50C", Offset = "0x15BA50C", VA = "0x15BA50C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x15BAA6C", Offset = "0x15BAA6C", VA = "0x15BAA6C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x15BA860", Offset = "0x15BA860", VA = "0x15BA860")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x15BA6DC", Offset = "0x15BA6DC", VA = "0x15BA6DC")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x15BA5AC", Offset = "0x15BA5AC", VA = "0x15BA5AC")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x15BA96C", Offset = "0x15BA96C", VA = "0x15BA96C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x15BAB64", Offset = "0x15BAB64", VA = "0x15BAB64")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x15BB688", Offset = "0x15BB688", VA = "0x15BB688")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x15BB110", Offset = "0x15BB110", VA = "0x15BB110")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x15BB930", Offset = "0x15BB930", VA = "0x15BB930")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15BB47C", Offset = "0x15BB47C", VA = "0x15BB47C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x15BB938", Offset = "0x15BB938", VA = "0x15BB938")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x15BB940", Offset = "0x15BB940", VA = "0x15BB940")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x15BBB08", Offset = "0x15BBB08", VA = "0x15BBB08")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x15BBCC4", Offset = "0x15BBCC4", VA = "0x15BBCC4")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x15B4B6C", Offset = "0x15B4B6C", VA = "0x15B4B6C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x15D62E4", Offset = "0x15D62E4", VA = "0x15D62E4")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x15D6B70", Offset = "0x15D6B70", VA = "0x15D6B70")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x15D6CB8", Offset = "0x15D6CB8", VA = "0x15D6CB8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x162FACC", Offset = "0x162FACC", VA = "0x162FACC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x162FCB8", Offset = "0x162FCB8", VA = "0x162FCB8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x162FB64", Offset = "0x162FB64", VA = "0x162FB64")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x162FDD8", Offset = "0x162FDD8", VA = "0x162FDD8")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x162FF04", Offset = "0x162FF04", VA = "0x162FF04")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1630150", Offset = "0x1630150", VA = "0x1630150")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1630258", Offset = "0x1630258", VA = "0x1630258")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x16303CC", Offset = "0x16303CC", VA = "0x16303CC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x16307A8", Offset = "0x16307A8", VA = "0x16307A8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x163056C", Offset = "0x163056C", VA = "0x163056C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x163095C", Offset = "0x163095C", VA = "0x163095C")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x162A01C", Offset = "0x162A01C", VA = "0x162A01C")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x162A088", Offset = "0x162A088", VA = "0x162A088")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C2")]
		None,
		[Token(Token = "0x40000C3")]
		InOutCubic,
		[Token(Token = "0x40000C4")]
		InOutQuintic,
		[Token(Token = "0x40000C5")]
		InOutSine,
		[Token(Token = "0x40000C6")]
		InQuintic,
		[Token(Token = "0x40000C7")]
		InQuartic,
		[Token(Token = "0x40000C8")]
		InCubic,
		[Token(Token = "0x40000C9")]
		InQuadratic,
		[Token(Token = "0x40000CA")]
		InElastic,
		[Token(Token = "0x40000CB")]
		InElasticSmall,
		[Token(Token = "0x40000CC")]
		InElasticBig,
		[Token(Token = "0x40000CD")]
		InSine,
		[Token(Token = "0x40000CE")]
		InBack,
		[Token(Token = "0x40000CF")]
		OutQuintic,
		[Token(Token = "0x40000D0")]
		OutQuartic,
		[Token(Token = "0x40000D1")]
		OutCubic,
		[Token(Token = "0x40000D2")]
		OutInCubic,
		[Token(Token = "0x40000D3")]
		OutInQuartic,
		[Token(Token = "0x40000D4")]
		OutElastic,
		[Token(Token = "0x40000D5")]
		OutElasticSmall,
		[Token(Token = "0x40000D6")]
		OutElasticBig,
		[Token(Token = "0x40000D7")]
		OutSine,
		[Token(Token = "0x40000D8")]
		OutBack,
		[Token(Token = "0x40000D9")]
		OutBackCubic,
		[Token(Token = "0x40000DA")]
		OutBackQuartic,
		[Token(Token = "0x40000DB")]
		BackInCubic,
		[Token(Token = "0x40000DC")]
		BackInQuartic
	}
	[Token(Token = "0x200001D")]
	public class Interp
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x14F70EC", Offset = "0x14F70EC", VA = "0x14F70EC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x14F7A98", Offset = "0x14F7A98", VA = "0x14F7A98")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x14F7B0C", Offset = "0x14F7B0C", VA = "0x14F7B0C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x14F7500", Offset = "0x14F7500", VA = "0x14F7500")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x14F750C", Offset = "0x14F750C", VA = "0x14F750C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x14F7530", Offset = "0x14F7530", VA = "0x14F7530")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x14F756C", Offset = "0x14F756C", VA = "0x14F756C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x14F7584", Offset = "0x14F7584", VA = "0x14F7584")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x14F7598", Offset = "0x14F7598", VA = "0x14F7598")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x14F75AC", Offset = "0x14F75AC", VA = "0x14F75AC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x14F75BC", Offset = "0x14F75BC", VA = "0x14F75BC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x14F7604", Offset = "0x14F7604", VA = "0x14F7604")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x14F763C", Offset = "0x14F763C", VA = "0x14F763C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x14F7664", Offset = "0x14F7664", VA = "0x14F7664")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x14F7B98", Offset = "0x14F7B98", VA = "0x14F7B98")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x14F7698", Offset = "0x14F7698", VA = "0x14F7698")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x14F76C0", Offset = "0x14F76C0", VA = "0x14F76C0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x14F76F0", Offset = "0x14F76F0", VA = "0x14F76F0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x14F7724", Offset = "0x14F7724", VA = "0x14F7724")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x14F7768", Offset = "0x14F7768", VA = "0x14F7768")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x14F77CC", Offset = "0x14F77CC", VA = "0x14F77CC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x14F7830", Offset = "0x14F7830", VA = "0x14F7830")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x14F7884", Offset = "0x14F7884", VA = "0x14F7884")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x14F78D8", Offset = "0x14F78D8", VA = "0x14F78D8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x14F7914", Offset = "0x14F7914", VA = "0x14F7914")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x14F794C", Offset = "0x14F794C", VA = "0x14F794C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x14F7BCC", Offset = "0x14F7BCC", VA = "0x14F7BCC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x14F7994", Offset = "0x14F7994", VA = "0x14F7994")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x14F7A28", Offset = "0x14F7A28", VA = "0x14F7A28")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x14F7A58", Offset = "0x14F7A58", VA = "0x14F7A58")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x14F7C60", Offset = "0x14F7C60", VA = "0x14F7C60")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x14F7D1C", Offset = "0x14F7D1C", VA = "0x14F7D1C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x14F7D88", Offset = "0x14F7D88", VA = "0x14F7D88")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x14F7DF4", Offset = "0x14F7DF4", VA = "0x14F7DF4")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x14F7E4C", Offset = "0x14F7E4C", VA = "0x14F7E4C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x14F7F18", Offset = "0x14F7F18", VA = "0x14F7F18")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x14F7E64", Offset = "0x14F7E64", VA = "0x14F7E64")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x14F7F30", Offset = "0x14F7F30", VA = "0x14F7F30")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x14F7FD4", Offset = "0x14F7FD4", VA = "0x14F7FD4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x14F8000", Offset = "0x14F8000", VA = "0x14F8000")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x14F8050", Offset = "0x14F8050", VA = "0x14F8050")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x14F80BC", Offset = "0x14F80BC", VA = "0x14F80BC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x14F81D0", Offset = "0x14F81D0", VA = "0x14F81D0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x14F82C8", Offset = "0x14F82C8", VA = "0x14F82C8")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x14F8324", Offset = "0x14F8324", VA = "0x14F8324")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x14FE988", Offset = "0x14FE988", VA = "0x14FE988")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x14FE9E4", Offset = "0x14FE9E4", VA = "0x14FE9E4")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x14FEA74", Offset = "0x14FEA74", VA = "0x14FEA74")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x14FEBD4", Offset = "0x14FEBD4", VA = "0x14FEBD4")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x14FEC90", Offset = "0x14FEC90", VA = "0x14FEC90")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x14FED4C", Offset = "0x14FED4C", VA = "0x14FED4C")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x14FEEF8", Offset = "0x14FEEF8", VA = "0x14FEEF8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x14FEF48", Offset = "0x14FEF48", VA = "0x14FEF48")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x14FEF98", Offset = "0x14FEF98", VA = "0x14FEF98")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x14FF040", Offset = "0x14FF040", VA = "0x14FF040")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x14F6D28", Offset = "0x14F6D28", VA = "0x14F6D28")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x14FF0E8", Offset = "0x14FF0E8", VA = "0x14FF0E8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x14F6E08", Offset = "0x14F6E08", VA = "0x14F6E08")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x14FE1B8", Offset = "0x14FE1B8", VA = "0x14FE1B8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x14FF13C", Offset = "0x14FF13C", VA = "0x14FF13C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x14FF2CC", Offset = "0x14FF2CC", VA = "0x14FF2CC")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x14FF3C0", Offset = "0x14FF3C0", VA = "0x14FF3C0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x14FF4CC", Offset = "0x14FF4CC", VA = "0x14FF4CC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x14FF5B8", Offset = "0x14FF5B8", VA = "0x14FF5B8")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000021")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000ED")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000EE")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7355D4", Offset = "0x7355D4")]
		public bool fixTransforms;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x149FB78", Offset = "0x149FB78", VA = "0x149FB78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x149FE84", Offset = "0x149FE84", VA = "0x149FE84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x149FA38", Offset = "0x149FA38", VA = "0x149FA38")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x149FAD8", Offset = "0x149FAD8", VA = "0x149FAD8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x149FADC", Offset = "0x149FADC", VA = "0x149FADC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x149FAE0", Offset = "0x149FAE0", VA = "0x149FAE0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x149FAE4", Offset = "0x149FAE4", VA = "0x149FAE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x149FB74", Offset = "0x149FB74", VA = "0x149FB74")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x149FB1C", Offset = "0x149FB1C", VA = "0x149FB1C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x149FE38", Offset = "0x149FE38", VA = "0x149FE38")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x149FC64", Offset = "0x149FC64", VA = "0x149FC64")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x149FF3C", Offset = "0x149FF3C", VA = "0x149FF3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x149FF98", Offset = "0x149FF98", VA = "0x149FF98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x149FFF4", Offset = "0x149FFF4", VA = "0x149FFF4")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x14A003C", Offset = "0x14A003C", VA = "0x14A003C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x14A06B0", Offset = "0x14A06B0", VA = "0x14A06B0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x14A0770", Offset = "0x14A0770", VA = "0x14A0770")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x14A0830", Offset = "0x14A0830", VA = "0x14A0830")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x14A08F0", Offset = "0x14A08F0", VA = "0x14A08F0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V2Tools
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x14A281C", Offset = "0x14A281C", VA = "0x14A281C")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x14A2824", Offset = "0x14A2824", VA = "0x14A2824")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x14A2874", Offset = "0x14A2874", VA = "0x14A2874")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x14A28C8", Offset = "0x14A28C8", VA = "0x14A28C8")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x14A29A0", Offset = "0x14A29A0", VA = "0x14A29A0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x14A2A34", Offset = "0x14A2A34", VA = "0x14A2A34")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x14A2A58", Offset = "0x14A2A58", VA = "0x14A2A58")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x14A2AA0", Offset = "0x14A2AA0", VA = "0x14A2AA0")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x14A2B2C", Offset = "0x14A2B2C", VA = "0x14A2B2C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x14A2B8C", Offset = "0x14A2B8C", VA = "0x14A2B8C")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x14A2BEC", Offset = "0x14A2BEC", VA = "0x14A2BEC")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x14A2D08", Offset = "0x14A2D08", VA = "0x14A2D08")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x14A2DA8", Offset = "0x14A2DA8", VA = "0x14A2DA8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x14A2DE4", Offset = "0x14A2DE4", VA = "0x14A2DE4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x14A2E28", Offset = "0x14A2E28", VA = "0x14A2E28")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x14A2EC4", Offset = "0x14A2EC4", VA = "0x14A2EC4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x14A3020", Offset = "0x14A3020", VA = "0x14A3020")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x14A319C", Offset = "0x14A319C", VA = "0x14A319C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x14A3320", Offset = "0x14A3320", VA = "0x14A3320")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x14A33DC", Offset = "0x14A33DC", VA = "0x14A33DC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x14A34DC", Offset = "0x14A34DC", VA = "0x14A34DC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x14A3564", Offset = "0x14A3564", VA = "0x14A3564")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x14A3600", Offset = "0x14A3600", VA = "0x14A3600")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x14A36A4", Offset = "0x14A36A4", VA = "0x14A36A4")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x14A3694", Offset = "0x14A3694", VA = "0x14A3694")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000026")]
	public static class Warning
	{
		[Token(Token = "0x2000027")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x14A8980", Offset = "0x14A8980", VA = "0x14A8980")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x14A8A18", Offset = "0x14A8A18", VA = "0x14A8A18")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7345DC", Offset = "0x7345DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7345DC", Offset = "0x7345DC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x15B3DF0", Offset = "0x15B3DF0", VA = "0x15B3DF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D6E8", Offset = "0x73D6E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x15B3E38", Offset = "0x15B3E38", VA = "0x15B3E38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D720", Offset = "0x73D720")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15B3E80", Offset = "0x15B3E80", VA = "0x15B3E80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D758", Offset = "0x73D758")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x15B3EC8", Offset = "0x15B3EC8", VA = "0x15B3EC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D790", Offset = "0x73D790")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x15B3F10", Offset = "0x15B3F10", VA = "0x15B3F10")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x15B3FAC", Offset = "0x15B3FAC", VA = "0x15B3FAC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x15B3FCC", Offset = "0x15B3FCC", VA = "0x15B3FCC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15B3FFC", Offset = "0x15B3FFC", VA = "0x15B3FFC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15B402C", Offset = "0x15B402C", VA = "0x15B402C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x15B406C", Offset = "0x15B406C", VA = "0x15B406C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x15B40B0", Offset = "0x15B40B0", VA = "0x15B40B0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x15B40D4", Offset = "0x15B40D4", VA = "0x15B40D4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x15B40F8", Offset = "0x15B40F8", VA = "0x15B40F8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x15B4120", Offset = "0x15B4120", VA = "0x15B4120")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x15B414C", Offset = "0x15B414C", VA = "0x15B414C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x15B4178", Offset = "0x15B4178", VA = "0x15B4178")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x15B3F30", Offset = "0x15B3F30", VA = "0x15B3F30")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x15B41A0", Offset = "0x15B41A0", VA = "0x15B41A0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x15B41AC", Offset = "0x15B41AC", VA = "0x15B41AC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x15B41B8", Offset = "0x15B41B8", VA = "0x15B41B8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x15B449C", Offset = "0x15B449C", VA = "0x15B449C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x15B4544", Offset = "0x15B4544", VA = "0x15B4544", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x15B4924", Offset = "0x15B4924", VA = "0x15B4924", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x15B4AB0", Offset = "0x15B4AB0", VA = "0x15B4AB0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x15B4AE4", Offset = "0x15B4AE4", VA = "0x15B4AE4")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000010")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x15B4358", Offset = "0x15B4358", VA = "0x15B4358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x15B4D4C", Offset = "0x15B4D4C", VA = "0x15B4D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x15B4800", Offset = "0x15B4800", VA = "0x15B4800")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x15B4BD8", Offset = "0x15B4BD8", VA = "0x15B4BD8")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000012")]
		public bool isValid
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x15D62EC", Offset = "0x15D62EC", VA = "0x15D62EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x15D6358", Offset = "0x15D6358", VA = "0x15D6358")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x15D6360", Offset = "0x15D6360", VA = "0x15D6360", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x15D6420", Offset = "0x15D6420", VA = "0x15D6420")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x15D6428", Offset = "0x15D6428", VA = "0x15D6428")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool positionChanged
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x15D655C", Offset = "0x15D655C", VA = "0x15D655C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x15D6454", Offset = "0x15D6454", VA = "0x15D6454", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x15D6598", Offset = "0x15D6598", VA = "0x15D6598")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x15D65A0", Offset = "0x15D65A0", VA = "0x15D65A0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x15D65CC", Offset = "0x15D65CC", VA = "0x15D65CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x15D664C", Offset = "0x15D664C", VA = "0x15D664C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x15D6654", Offset = "0x15D6654", VA = "0x15D6654")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		private bool rotationChanged
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x15D6788", Offset = "0x15D6788", VA = "0x15D6788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x15D6680", Offset = "0x15D6680", VA = "0x15D6680", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x15D67C4", Offset = "0x15D67C4", VA = "0x15D67C4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x15D67CC", Offset = "0x15D67CC", VA = "0x15D67CC")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class Constraints
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73560C", Offset = "0x73560C")]
		public float positionWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735624", Offset = "0x735624")]
		public float rotationWeight;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x15D67F8", Offset = "0x15D67F8", VA = "0x15D67F8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x15D6864", Offset = "0x15D6864", VA = "0x15D6864")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x15D68B8", Offset = "0x15D68B8", VA = "0x15D68B8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x15D6B68", Offset = "0x15D6B68", VA = "0x15D6B68")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000031")]
		public enum DOF
		{
			[Token(Token = "0x400011D")]
			One,
			[Token(Token = "0x400011E")]
			Three
		}

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73563C", Offset = "0x73563C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73563C", Offset = "0x73563C")]
		public float weight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735690", Offset = "0x735690")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735690", Offset = "0x735690")]
		public float rotationWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7356E4", Offset = "0x7356E4")]
		public DOF rotationDOF;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73571C", Offset = "0x73571C")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735754", Offset = "0x735754")]
		public Transform bone1;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73578C", Offset = "0x73578C")]
		public Transform bone2;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7357C4", Offset = "0x7357C4")]
		public Transform bone3;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7357FC", Offset = "0x7357FC")]
		public Transform tip;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735834", Offset = "0x735834")]
		public Transform target;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73586C", Offset = "0x73586C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x15DFC3C", Offset = "0x15DFC3C", VA = "0x15DFC3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D7C8", Offset = "0x73D7C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x15DFC44", Offset = "0x15DFC44", VA = "0x15DFC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D7D8", Offset = "0x73D7D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x15DFC50", Offset = "0x15DFC50", VA = "0x15DFC50")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x15DFC70", Offset = "0x15DFC70", VA = "0x15DFC70")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x15DFC90", Offset = "0x15DFC90", VA = "0x15DFC90")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x15DFCB0", Offset = "0x15DFCB0", VA = "0x15DFCB0")]
			set
			{
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x15DFCD0", Offset = "0x15DFCD0", VA = "0x15DFCD0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x15DFDD8", Offset = "0x15DFDD8", VA = "0x15DFDD8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x15E0350", Offset = "0x15E0350", VA = "0x15E0350")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x15E0428", Offset = "0x15E0428", VA = "0x15E0428")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x15E04EC", Offset = "0x15E04EC", VA = "0x15E04EC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x15E0970", Offset = "0x15E0970", VA = "0x15E0970")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73587C", Offset = "0x73587C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73587C", Offset = "0x73587C")]
		public float weight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7358D0", Offset = "0x7358D0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x15E0980", Offset = "0x15E0980", VA = "0x15E0980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D7E8", Offset = "0x73D7E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x15E0988", Offset = "0x15E0988", VA = "0x15E0988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D7F8", Offset = "0x73D7F8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x15E0994", Offset = "0x15E0994", VA = "0x15E0994")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x15E0A1C", Offset = "0x15E0A1C", VA = "0x15E0A1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D808", Offset = "0x73D808")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x15E0D54", Offset = "0x15E0D54", VA = "0x15E0D54")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x15E0ECC", Offset = "0x15E0ECC", VA = "0x15E0ECC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x15E0C58", Offset = "0x15E0C58", VA = "0x15E0C58")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x15E103C", Offset = "0x15E103C", VA = "0x15E103C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x15E10FC", Offset = "0x15E10FC", VA = "0x15E10FC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x15E1174", Offset = "0x15E1174", VA = "0x15E1174")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x15E11E8", Offset = "0x15E11E8", VA = "0x15E11E8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x15E1250", Offset = "0x15E1250", VA = "0x15E1250", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x15E1254", Offset = "0x15E1254", VA = "0x15E1254", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x15E1268", Offset = "0x15E1268", VA = "0x15E1268")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7358E0", Offset = "0x7358E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7358E0", Offset = "0x7358E0")]
		public float weight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735934", Offset = "0x735934")]
		public Grounding solver;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73596C", Offset = "0x73596C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x15E267C", Offset = "0x15E267C", VA = "0x15E267C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D840", Offset = "0x73D840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x15E2684", Offset = "0x15E2684", VA = "0x15E2684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D850", Offset = "0x73D850")]
			protected set
			{
			}
		}

		[Token(Token = "0x600016E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x15E2690", Offset = "0x15E2690", VA = "0x15E2690")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x15E283C", Offset = "0x15E283C", VA = "0x15E283C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x15E273C", Offset = "0x15E273C", VA = "0x15E273C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x15E2870", Offset = "0x15E2870", VA = "0x15E2870")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000175")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000176")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x15E29AC", Offset = "0x15E29AC", VA = "0x15E29AC")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73463C", Offset = "0x73463C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73463C", Offset = "0x73463C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73597C", Offset = "0x73597C")]
		public BipedIK ik;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7359B4", Offset = "0x7359B4")]
		public float spineBend;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7359EC", Offset = "0x7359EC")]
		public float spineSpeed;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x15E2A18", Offset = "0x15E2A18", VA = "0x15E2A18", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D860", Offset = "0x73D860")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x15E2A60", Offset = "0x15E2A60", VA = "0x15E2A60", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D898", Offset = "0x73D898")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x15E2AA8", Offset = "0x15E2AA8", VA = "0x15E2AA8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x15E2AE8", Offset = "0x15E2AE8", VA = "0x15E2AE8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x15E2B94", Offset = "0x15E2B94", VA = "0x15E2B94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x15E2BF4", Offset = "0x15E2BF4", VA = "0x15E2BF4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x15E2EB8", Offset = "0x15E2EB8", VA = "0x15E2EB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x15E2F0C", Offset = "0x15E2F0C", VA = "0x15E2F0C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x15E3328", Offset = "0x15E3328", VA = "0x15E3328")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x15E33FC", Offset = "0x15E33FC", VA = "0x15E33FC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x15E353C", Offset = "0x15E353C", VA = "0x15E353C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x15E36CC", Offset = "0x15E36CC", VA = "0x15E36CC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73469C", Offset = "0x73469C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73469C", Offset = "0x73469C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class SpineEffector
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735ACC", Offset = "0x735ACC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735B04", Offset = "0x735B04")]
			public float horizontalWeight;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735B3C", Offset = "0x735B3C")]
			public float verticalWeight;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x14A9EEC", Offset = "0x14A9EEC", VA = "0x14A9EEC")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x14A9EFC", Offset = "0x14A9EFC", VA = "0x14A9EFC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735A24", Offset = "0x735A24")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735A5C", Offset = "0x735A5C")]
		public float spineBend;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735A94", Offset = "0x735A94")]
		public float spineSpeed;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x15E3B04", Offset = "0x15E3B04", VA = "0x15E3B04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D8D0", Offset = "0x73D8D0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x15E3B4C", Offset = "0x15E3B4C", VA = "0x15E3B4C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D908", Offset = "0x73D908")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x15E3B94", Offset = "0x15E3B94", VA = "0x15E3B94", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D940", Offset = "0x73D940")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x15E3BDC", Offset = "0x15E3BDC", VA = "0x15E3BDC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x15E3C1C", Offset = "0x15E3C1C", VA = "0x15E3C1C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x15E3CB0", Offset = "0x15E3CB0", VA = "0x15E3CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x15E3F30", Offset = "0x15E3F30", VA = "0x15E3F30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x15E3F3C", Offset = "0x15E3F3C", VA = "0x15E3F3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x15E3D18", Offset = "0x15E3D18", VA = "0x15E3D18")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x15E3F48", Offset = "0x15E3F48", VA = "0x15E3F48")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x15E4268", Offset = "0x15E4268", VA = "0x15E4268")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x15E4378", Offset = "0x15E4378", VA = "0x15E4378")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x15E44D0", Offset = "0x15E44D0", VA = "0x15E44D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x15E45E4", Offset = "0x15E45E4", VA = "0x15E45E4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7346FC", Offset = "0x7346FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7346FC", Offset = "0x7346FC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735B74", Offset = "0x735B74")]
		public Transform pelvis;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735BAC", Offset = "0x735BAC")]
		public Transform characterRoot;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735BE4", Offset = "0x735BE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735BE4", Offset = "0x735BE4")]
		public float rootRotationWeight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735C38", Offset = "0x735C38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735C70", Offset = "0x735C70")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x15E466C", Offset = "0x15E466C", VA = "0x15E466C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D978", Offset = "0x73D978")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x15E46B4", Offset = "0x15E46B4", VA = "0x15E46B4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D9B0", Offset = "0x73D9B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x15E46FC", Offset = "0x15E46FC", VA = "0x15E46FC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x15E4718", Offset = "0x15E4718", VA = "0x15E4718")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x15E494C", Offset = "0x15E494C", VA = "0x15E494C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x15E4A48", Offset = "0x15E4A48", VA = "0x15E4A48")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x15E4E9C", Offset = "0x15E4E9C", VA = "0x15E4E9C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x15E52A8", Offset = "0x15E52A8", VA = "0x15E52A8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x15E5438", Offset = "0x15E5438", VA = "0x15E5438")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x15E573C", Offset = "0x15E573C", VA = "0x15E573C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x15E5888", Offset = "0x15E5888", VA = "0x15E5888")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x15E5A70", Offset = "0x15E5A70", VA = "0x15E5A70")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73475C", Offset = "0x73475C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73475C", Offset = "0x73475C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200003A")]
		public struct Foot
		{
			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x14A9F44", Offset = "0x14A9F44", VA = "0x14A9F44")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735CA8", Offset = "0x735CA8")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735CE0", Offset = "0x735CE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735CE0", Offset = "0x735CE0")]
		public float rootRotationWeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735D34", Offset = "0x735D34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735D34", Offset = "0x735D34")]
		public float minRootRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735D8C", Offset = "0x735D8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735D8C", Offset = "0x735D8C")]
		public float maxRootRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735DE4", Offset = "0x735DE4")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735E1C", Offset = "0x735E1C")]
		public float maxLegOffset;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735E54", Offset = "0x735E54")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735E8C", Offset = "0x735E8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735E8C", Offset = "0x735E8C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735EE0", Offset = "0x735EE0")]
		public Transform characterRoot;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735F18", Offset = "0x735F18")]
		public Transform pelvis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735F50", Offset = "0x735F50")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735F88", Offset = "0x735F88")]
		public Transform head;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x15E5AF8", Offset = "0x15E5AF8", VA = "0x15E5AF8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73D9E8", Offset = "0x73D9E8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x15E5B40", Offset = "0x15E5B40", VA = "0x15E5B40", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DA20", Offset = "0x73DA20")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x15E5B88", Offset = "0x15E5B88", VA = "0x15E5B88", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x15E5BC4", Offset = "0x15E5BC4", VA = "0x15E5BC4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x15E5CF0", Offset = "0x15E5CF0", VA = "0x15E5CF0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x15E5EF4", Offset = "0x15E5EF4", VA = "0x15E5EF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x15E5F5C", Offset = "0x15E5F5C", VA = "0x15E5F5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x15E5FC0", Offset = "0x15E5FC0", VA = "0x15E5FC0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x15E62F4", Offset = "0x15E62F4", VA = "0x15E62F4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x15E6638", Offset = "0x15E6638", VA = "0x15E6638")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x15E6730", Offset = "0x15E6730", VA = "0x15E6730")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x15E6AFC", Offset = "0x15E6AFC", VA = "0x15E6AFC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x15E7120", Offset = "0x15E7120", VA = "0x15E7120")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x15E72F0", Offset = "0x15E72F0", VA = "0x15E72F0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x15E73CC", Offset = "0x15E73CC", VA = "0x15E73CC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x15E7614", Offset = "0x15E7614", VA = "0x15E7614")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x15E764C", Offset = "0x15E764C", VA = "0x15E764C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x15E782C", Offset = "0x15E782C", VA = "0x15E782C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7347BC", Offset = "0x7347BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7347BC", Offset = "0x7347BC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735FD0", Offset = "0x735FD0")]
		public VRIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x162DA70", Offset = "0x162DA70", VA = "0x162DA70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DA58", Offset = "0x73DA58")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x162DAB8", Offset = "0x162DAB8", VA = "0x162DAB8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DA90", Offset = "0x73DA90")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x162DB00", Offset = "0x162DB00", VA = "0x162DB00", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DAC8", Offset = "0x73DAC8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x162DB48", Offset = "0x162DB48", VA = "0x162DB48", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x162DBEC", Offset = "0x162DBEC", VA = "0x162DBEC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x162DC80", Offset = "0x162DC80", VA = "0x162DC80")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x162DCE0", Offset = "0x162DCE0", VA = "0x162DCE0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x162E188", Offset = "0x162E188", VA = "0x162E188")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x162E5E8", Offset = "0x162E5E8", VA = "0x162E5E8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x162E678", Offset = "0x162E678", VA = "0x162E678")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x162E834", Offset = "0x162E834", VA = "0x162E834")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x162E98C", Offset = "0x162E98C", VA = "0x162E98C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x162EB0C", Offset = "0x162EB0C", VA = "0x162EB0C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200003D")]
		public enum Quality
		{
			[Token(Token = "0x4000184")]
			Fastest,
			[Token(Token = "0x4000185")]
			Simple,
			[Token(Token = "0x4000186")]
			Best
		}

		[Token(Token = "0x200003E")]
		public class Leg
		{
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7364B4", Offset = "0x7364B4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7364C4", Offset = "0x7364C4")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7364D4", Offset = "0x7364D4")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7364E4", Offset = "0x7364E4")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7364F4", Offset = "0x7364F4")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736504", Offset = "0x736504")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736514", Offset = "0x736514")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736524", Offset = "0x736524")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736534", Offset = "0x736534")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000022")]
			public bool isGrounded
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x14A9F84", Offset = "0x14A9F84", VA = "0x14A9F84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBA0", Offset = "0x73DBA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x14A9F8C", Offset = "0x14A9F8C", VA = "0x14A9F8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBB0", Offset = "0x73DBB0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x14A9F98", Offset = "0x14A9F98", VA = "0x14A9F98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBC0", Offset = "0x73DBC0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x14A9FA4", Offset = "0x14A9FA4", VA = "0x14A9FA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBD0", Offset = "0x73DBD0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x14A9FB0", Offset = "0x14A9FB0", VA = "0x14A9FB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBE0", Offset = "0x73DBE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x14A9FB8", Offset = "0x14A9FB8", VA = "0x14A9FB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBF0", Offset = "0x73DBF0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x14A9FC4", Offset = "0x14A9FC4", VA = "0x14A9FC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC00", Offset = "0x73DC00")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x14A9FCC", Offset = "0x14A9FCC", VA = "0x14A9FCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC10", Offset = "0x73DC10")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x14A9FD4", Offset = "0x14A9FD4", VA = "0x14A9FD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC20", Offset = "0x73DC20")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x14A9FE0", Offset = "0x14A9FE0", VA = "0x14A9FE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC30", Offset = "0x73DC30")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x14A9FEC", Offset = "0x14A9FEC", VA = "0x14A9FEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC40", Offset = "0x73DC40")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x14A9FF4", Offset = "0x14A9FF4", VA = "0x14A9FF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC50", Offset = "0x73DC50")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x14A9FFC", Offset = "0x14A9FFC", VA = "0x14A9FFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC60", Offset = "0x73DC60")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x14AA004", Offset = "0x14AA004", VA = "0x14AA004")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC70", Offset = "0x73DC70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x14AA00C", Offset = "0x14AA00C", VA = "0x14AA00C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC80", Offset = "0x73DC80")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x14AA024", Offset = "0x14AA024", VA = "0x14AA024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC90", Offset = "0x73DC90")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x14AA044", Offset = "0x14AA044", VA = "0x14AA044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCA0", Offset = "0x73DCA0")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x14AA05C", Offset = "0x14AA05C", VA = "0x14AA05C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCB0", Offset = "0x73DCB0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x14AA07C", Offset = "0x14AA07C", VA = "0x14AA07C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x14AB240", Offset = "0x14AB240", VA = "0x14AB240")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x14AB3A4", Offset = "0x14AB3A4", VA = "0x14AB3A4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x14AA0C4", Offset = "0x14AA0C4", VA = "0x14AA0C4")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x14AA0D8", Offset = "0x14AA0D8", VA = "0x14AA0D8")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x14AA14C", Offset = "0x14AA14C", VA = "0x14AA14C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x14AA198", Offset = "0x14AA198", VA = "0x14AA198")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x14AA208", Offset = "0x14AA208", VA = "0x14AA208")]
			public void Process()
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x14AAEB4", Offset = "0x14AAEB4", VA = "0x14AAEB4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x14AAA54", Offset = "0x14AAA54", VA = "0x14AAA54")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x14AB2D4", Offset = "0x14AB2D4", VA = "0x14AB2D4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x14AACF4", Offset = "0x14AACF4", VA = "0x14AACF4")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x14AAD80", Offset = "0x14AAD80", VA = "0x14AAD80")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x14AB344", Offset = "0x14AB344", VA = "0x14AB344")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x14AB268", Offset = "0x14AB268", VA = "0x14AB268")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x14AB438", Offset = "0x14AB438", VA = "0x14AB438")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x14AB4C4", Offset = "0x14AB4C4", VA = "0x14AB4C4")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003F")]
		public class Pelvis
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736544", Offset = "0x736544")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736554", Offset = "0x736554")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700002E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001FF")]
				[Address(RVA = "0x14AB508", Offset = "0x14AB508", VA = "0x14AB508")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCC0", Offset = "0x73DCC0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x14AB514", Offset = "0x14AB514", VA = "0x14AB514")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCD0", Offset = "0x73DCD0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x14AB520", Offset = "0x14AB520", VA = "0x14AB520")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCE0", Offset = "0x73DCE0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x14AB528", Offset = "0x14AB528", VA = "0x14AB528")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCF0", Offset = "0x73DCF0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x14AB530", Offset = "0x14AB530", VA = "0x14AB530")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x14AB5A0", Offset = "0x14AB5A0", VA = "0x14AB5A0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x14AB540", Offset = "0x14AB540", VA = "0x14AB540")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x14AB60C", Offset = "0x14AB60C", VA = "0x14AB60C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x14AB7AC", Offset = "0x14AB7AC", VA = "0x14AB7AC")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736008", Offset = "0x736008")]
		public LayerMask layers;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736040", Offset = "0x736040")]
		public float maxStep;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736078", Offset = "0x736078")]
		public float heightOffset;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7360B0", Offset = "0x7360B0")]
		public float footSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7360E8", Offset = "0x7360E8")]
		public float footRadius;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736120", Offset = "0x736120")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73616C", Offset = "0x73616C")]
		public float prediction;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7361A4", Offset = "0x7361A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7361A4", Offset = "0x7361A4")]
		public float footRotationWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7361F8", Offset = "0x7361F8")]
		public float footRotationSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736230", Offset = "0x736230")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736230", Offset = "0x736230")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736288", Offset = "0x736288")]
		public bool rotateSolver;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7362C0", Offset = "0x7362C0")]
		public float pelvisSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7362F8", Offset = "0x7362F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7362F8", Offset = "0x7362F8")]
		public float pelvisDamper;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73634C", Offset = "0x73634C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736384", Offset = "0x736384")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7363BC", Offset = "0x7363BC")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7363F4", Offset = "0x7363F4")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73642C", Offset = "0x73642C")]
		public Quality quality;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736464", Offset = "0x736464")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736474", Offset = "0x736474")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736484", Offset = "0x736484")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736494", Offset = "0x736494")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7364A4", Offset = "0x7364A4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x162EB68", Offset = "0x162EB68", VA = "0x162EB68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB00", Offset = "0x73DB00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x162EB70", Offset = "0x162EB70", VA = "0x162EB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB10", Offset = "0x73DB10")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x162EB78", Offset = "0x162EB78", VA = "0x162EB78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB20", Offset = "0x73DB20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x162EB80", Offset = "0x162EB80", VA = "0x162EB80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB30", Offset = "0x73DB30")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x162EB88", Offset = "0x162EB88", VA = "0x162EB88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB40", Offset = "0x73DB40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x162EB90", Offset = "0x162EB90", VA = "0x162EB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB50", Offset = "0x73DB50")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x162EB9C", Offset = "0x162EB9C", VA = "0x162EB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB60", Offset = "0x73DB60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x162EBA4", Offset = "0x162EBA4", VA = "0x162EBA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB70", Offset = "0x73DB70")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x162EBAC", Offset = "0x162EBAC", VA = "0x162EBAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB80", Offset = "0x73DB80")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x162EBC4", Offset = "0x162EBC4", VA = "0x162EBC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB90", Offset = "0x73DB90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x162EBE4", Offset = "0x162EBE4", VA = "0x162EBE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x162EE84", Offset = "0x162EE84", VA = "0x162EE84")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x162F148", Offset = "0x162F148", VA = "0x162F148")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x162EC38", Offset = "0x162EC38", VA = "0x162EC38")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x162EEC8", Offset = "0x162EEC8", VA = "0x162EEC8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x162DF00", Offset = "0x162DF00", VA = "0x162DF00")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x162E378", Offset = "0x162E378", VA = "0x162E378")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x162EFE8", Offset = "0x162EFE8", VA = "0x162EFE8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x162DB60", Offset = "0x162DB60", VA = "0x162DB60")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x162EFD0", Offset = "0x162EFD0", VA = "0x162EFD0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x162F1C8", Offset = "0x162F1C8", VA = "0x162F1C8")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x162F258", Offset = "0x162F258", VA = "0x162F258")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x162F314", Offset = "0x162F314", VA = "0x162F314")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x162F390", Offset = "0x162F390", VA = "0x162F390")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73481C", Offset = "0x73481C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73481C", Offset = "0x73481C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x15AE45C", Offset = "0x15AE45C", VA = "0x15AE45C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DD00", Offset = "0x73DD00")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x15AE4A4", Offset = "0x15AE4A4", VA = "0x15AE4A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DD38", Offset = "0x73DD38")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x15AE4EC", Offset = "0x15AE4EC", VA = "0x15AE4EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DD70", Offset = "0x73DD70")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x15AE534", Offset = "0x15AE534", VA = "0x15AE534")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DDA8", Offset = "0x73DDA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x15AE57C", Offset = "0x15AE57C", VA = "0x15AE57C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DDE0", Offset = "0x73DDE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x15AE5C4", Offset = "0x15AE5C4", VA = "0x15AE5C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x15AE5CC", Offset = "0x15AE5CC", VA = "0x15AE5CC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73487C", Offset = "0x73487C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73487C", Offset = "0x73487C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x15AFEBC", Offset = "0x15AFEBC", VA = "0x15AFEBC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DE18", Offset = "0x73DE18")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x15AFF04", Offset = "0x15AFF04", VA = "0x15AFF04", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DE50", Offset = "0x73DE50")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x15AFF4C", Offset = "0x15AFF4C", VA = "0x15AFF4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DE88", Offset = "0x73DE88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x15AFF94", Offset = "0x15AFF94", VA = "0x15AFF94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DEC0", Offset = "0x73DEC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x15AFFDC", Offset = "0x15AFFDC", VA = "0x15AFFDC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x15AFFE4", Offset = "0x15AFFE4", VA = "0x15AFFE4")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7348DC", Offset = "0x7348DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7348DC", Offset = "0x7348DC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x15BC350", Offset = "0x15BC350", VA = "0x15BC350", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DEF8", Offset = "0x73DEF8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x15BC398", Offset = "0x15BC398", VA = "0x15BC398", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DF30", Offset = "0x73DF30")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x15BC3E0", Offset = "0x15BC3E0", VA = "0x15BC3E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DF68", Offset = "0x73DF68")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x15BC428", Offset = "0x15BC428", VA = "0x15BC428")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DFA0", Offset = "0x73DFA0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x15BC470", Offset = "0x15BC470", VA = "0x15BC470", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x15BC478", Offset = "0x15BC478", VA = "0x15BC478")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73493C", Offset = "0x73493C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73493C", Offset = "0x73493C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x15D8364", Offset = "0x15D8364", VA = "0x15D8364", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73DFD8", Offset = "0x73DFD8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x15D83AC", Offset = "0x15D83AC", VA = "0x15D83AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E010", Offset = "0x73E010")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x15D83F4", Offset = "0x15D83F4", VA = "0x15D83F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E048", Offset = "0x73E048")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x15D843C", Offset = "0x15D843C", VA = "0x15D843C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E080", Offset = "0x73E080")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x15D8484", Offset = "0x15D8484", VA = "0x15D8484", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x15D848C", Offset = "0x15D848C", VA = "0x15D848C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73499C", Offset = "0x73499C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73499C", Offset = "0x73499C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x15D89B0", Offset = "0x15D89B0", VA = "0x15D89B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E0B8", Offset = "0x73E0B8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x15D89F8", Offset = "0x15D89F8", VA = "0x15D89F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E0F0", Offset = "0x73E0F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x15D8A40", Offset = "0x15D8A40", VA = "0x15D8A40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E128", Offset = "0x73E128")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x15D8A88", Offset = "0x15D8A88", VA = "0x15D8A88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E160", Offset = "0x73E160")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x15D8AD0", Offset = "0x15D8AD0", VA = "0x15D8AD0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x15D8AD8", Offset = "0x15D8AD8", VA = "0x15D8AD8")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7349FC", Offset = "0x7349FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7349FC", Offset = "0x7349FC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x15E12CC", Offset = "0x15E12CC", VA = "0x15E12CC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E198", Offset = "0x73E198")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x15E1314", Offset = "0x15E1314", VA = "0x15E1314", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E1D0", Offset = "0x73E1D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x15E135C", Offset = "0x15E135C", VA = "0x15E135C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E208", Offset = "0x73E208")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x15E13A4", Offset = "0x15E13A4", VA = "0x15E13A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E240", Offset = "0x73E240")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x15E13EC", Offset = "0x15E13EC", VA = "0x15E13EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E278", Offset = "0x73E278")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x15E1434", Offset = "0x15E1434", VA = "0x15E1434")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E2B0", Offset = "0x73E2B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x15E147C", Offset = "0x15E147C", VA = "0x15E147C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x15E14A0", Offset = "0x15E14A0", VA = "0x15E14A0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x15E14A8", Offset = "0x15E14A8", VA = "0x15E14A8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x15E1684", Offset = "0x15E1684", VA = "0x15E1684")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x15E1918", Offset = "0x15E1918", VA = "0x15E1918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E2E8", Offset = "0x73E2E8")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x15E1938", Offset = "0x15E1938", VA = "0x15E1938")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E320", Offset = "0x73E320")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x15E1A10", Offset = "0x15E1A10", VA = "0x15E1A10")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000234")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1632904", Offset = "0x1632904", VA = "0x1632904", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1632A08", Offset = "0x1632A08", VA = "0x1632A08", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1632BF4", Offset = "0x1632BF4", VA = "0x1632BF4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000238")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000239")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1632C54", Offset = "0x1632C54", VA = "0x1632C54")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736564", Offset = "0x736564")]
		public IK[] IKComponents;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73659C", Offset = "0x73659C")]
		public Animator animator;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x16351C4", Offset = "0x16351C4", VA = "0x16351C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x163525C", Offset = "0x163525C", VA = "0x163525C")]
		private void Start()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x16352CC", Offset = "0x16352CC", VA = "0x16352CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1635388", Offset = "0x1635388", VA = "0x1635388")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x16353C4", Offset = "0x16353C4", VA = "0x16353C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1635300", Offset = "0x1635300", VA = "0x1635300")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1635450", Offset = "0x1635450", VA = "0x1635450")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734A5C", Offset = "0x734A5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734A5C", Offset = "0x734A5C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x14F8354", Offset = "0x14F8354", VA = "0x14F8354", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E358", Offset = "0x73E358")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x14F839C", Offset = "0x14F839C", VA = "0x14F839C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E390", Offset = "0x73E390")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x14F83E4", Offset = "0x14F83E4", VA = "0x14F83E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E3C8", Offset = "0x73E3C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x14F842C", Offset = "0x14F842C", VA = "0x14F842C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E400", Offset = "0x73E400")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x14F8474", Offset = "0x14F8474", VA = "0x14F8474", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x14F847C", Offset = "0x14F847C", VA = "0x14F847C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734ABC", Offset = "0x734ABC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734ABC", Offset = "0x734ABC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x14F84E0", Offset = "0x14F84E0", VA = "0x14F84E0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E438", Offset = "0x73E438")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x14F8528", Offset = "0x14F8528", VA = "0x14F8528", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E470", Offset = "0x73E470")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x14F8570", Offset = "0x14F8570", VA = "0x14F8570")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E4A8", Offset = "0x73E4A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x14F85B8", Offset = "0x14F85B8", VA = "0x14F85B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E4E0", Offset = "0x73E4E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x14F8600", Offset = "0x14F8600", VA = "0x14F8600", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x14F8608", Offset = "0x14F8608", VA = "0x14F8608")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734B1C", Offset = "0x734B1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734B1C", Offset = "0x734B1C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x14F8FF4", Offset = "0x14F8FF4", VA = "0x14F8FF4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E518", Offset = "0x73E518")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x14F903C", Offset = "0x14F903C", VA = "0x14F903C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E550", Offset = "0x73E550")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x14F9084", Offset = "0x14F9084", VA = "0x14F9084")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E588", Offset = "0x73E588")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x14F90CC", Offset = "0x14F90CC", VA = "0x14F90CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E5C0", Offset = "0x73E5C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x14F9114", Offset = "0x14F9114", VA = "0x14F9114", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x14F911C", Offset = "0x14F911C", VA = "0x14F911C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734B7C", Offset = "0x734B7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734B7C", Offset = "0x734B7C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x14A08F8", Offset = "0x14A08F8", VA = "0x14A08F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E5F8", Offset = "0x73E5F8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x14A0940", Offset = "0x14A0940", VA = "0x14A0940", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E630", Offset = "0x73E630")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x14A0988", Offset = "0x14A0988", VA = "0x14A0988")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E668", Offset = "0x73E668")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x14A09D0", Offset = "0x14A09D0", VA = "0x14A09D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E6A0", Offset = "0x73E6A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x14A0A18", Offset = "0x14A0A18", VA = "0x14A0A18", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x14A0A20", Offset = "0x14A0A20", VA = "0x14A0A20")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734BDC", Offset = "0x734BDC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200004D")]
		public class References
		{
			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736680", Offset = "0x736680")]
			public Transform chest;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7366B8", Offset = "0x7366B8")]
			public Transform neck;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7366F0", Offset = "0x7366F0")]
			public Transform leftShoulder;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736728", Offset = "0x736728")]
			public Transform rightShoulder;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736760", Offset = "0x736760")]
			public Transform leftThigh;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736798", Offset = "0x736798")]
			public Transform leftCalf;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7367D0", Offset = "0x7367D0")]
			public Transform leftFoot;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736808", Offset = "0x736808")]
			public Transform leftToes;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736840", Offset = "0x736840")]
			public Transform rightThigh;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736878", Offset = "0x736878")]
			public Transform rightCalf;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7368B0", Offset = "0x7368B0")]
			public Transform rightFoot;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7368E8", Offset = "0x7368E8")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x17B987C", Offset = "0x17B987C", VA = "0x17B987C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x17B9CF4", Offset = "0x17B9CF4", VA = "0x17B9CF4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x17B9434", Offset = "0x17B9434", VA = "0x17B9434")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x17BA16C", Offset = "0x17BA16C", VA = "0x17BA16C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x17BA508", Offset = "0x17BA508", VA = "0x17BA508")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7365D4", Offset = "0x7365D4")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x7365D4", Offset = "0x7365D4")]
		public References references;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736648", Offset = "0x736648")]
		public IKSolverVR solver;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x14A3724", Offset = "0x14A3724", VA = "0x14A3724", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E6D8", Offset = "0x73E6D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x14A376C", Offset = "0x14A376C", VA = "0x14A376C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E710", Offset = "0x73E710")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x14A37B4", Offset = "0x14A37B4", VA = "0x14A37B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E748", Offset = "0x73E748")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x14A37FC", Offset = "0x14A37FC", VA = "0x14A37FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E780", Offset = "0x73E780")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x14A3828", Offset = "0x14A3828", VA = "0x14A3828")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73E7B8", Offset = "0x73E7B8")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x14A3850", Offset = "0x14A3850", VA = "0x14A3850", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x14A3858", Offset = "0x14A3858", VA = "0x14A3858", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x14A38D8", Offset = "0x14A38D8", VA = "0x14A38D8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x14A3A44", Offset = "0x14A3A44", VA = "0x14A3A44")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736920", Offset = "0x736920")]
		public float pull;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736938", Offset = "0x736938")]
		public float pin;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x15D84F0", Offset = "0x15D84F0", VA = "0x15D84F0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x15D85C0", Offset = "0x15D85C0", VA = "0x15D85C0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x15D85E0", Offset = "0x15D85E0", VA = "0x15D85E0")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x15D8854", Offset = "0x15D8854", VA = "0x15D8854")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x15D86B4", Offset = "0x15D86B4", VA = "0x15D86B4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x15D894C", Offset = "0x15D894C", VA = "0x15D894C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x15D8B3C", Offset = "0x15D8B3C", VA = "0x15D8B3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x15D8FA0", Offset = "0x15D8FA0", VA = "0x15D8FA0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x15D915C", Offset = "0x15D915C", VA = "0x15D915C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x15D9268", Offset = "0x15D9268", VA = "0x15D9268")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000051")]
		public class BendBone
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736F90", Offset = "0x736F90")]
			public Transform transform;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736FC8", Offset = "0x736FC8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736FC8", Offset = "0x736FC8")]
			public float weight;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x14A931C", Offset = "0x14A931C", VA = "0x14A931C")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x14A9358", Offset = "0x14A9358", VA = "0x14A9358")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x14A93B0", Offset = "0x14A93B0", VA = "0x14A93B0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x14A93E8", Offset = "0x14A93E8", VA = "0x14A93E8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736950", Offset = "0x736950")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736988", Offset = "0x736988")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736988", Offset = "0x736988")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x736988", Offset = "0x736988")]
		public float positionWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736A00", Offset = "0x736A00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736A00", Offset = "0x736A00")]
		public float bodyWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736A54", Offset = "0x736A54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736A54", Offset = "0x736A54")]
		public float thighWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736AA8", Offset = "0x736AA8")]
		public bool handsPullBody;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736AE0", Offset = "0x736AE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736AE0", Offset = "0x736AE0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x736AE0", Offset = "0x736AE0")]
		public float rotationWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736B58", Offset = "0x736B58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736B58", Offset = "0x736B58")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736BAC", Offset = "0x736BAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736BAC", Offset = "0x736BAC")]
		public float headClampWeight;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736C00", Offset = "0x736C00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736C00", Offset = "0x736C00")]
		public float bendWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736C54", Offset = "0x736C54")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736C8C", Offset = "0x736C8C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x736C8C", Offset = "0x736C8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736C8C", Offset = "0x736C8C")]
		public float CCDWeight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736D04", Offset = "0x736D04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736D04", Offset = "0x736D04")]
		public float roll;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736D58", Offset = "0x736D58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736D58", Offset = "0x736D58")]
		public float damper;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736DB0", Offset = "0x736DB0")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x736DE8", Offset = "0x736DE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736DE8", Offset = "0x736DE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736DE8", Offset = "0x736DE8")]
		public float postStretchWeight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736E60", Offset = "0x736E60")]
		public float maxStretch;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736E98", Offset = "0x736E98")]
		public float stretchDamper;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736ED0", Offset = "0x736ED0")]
		public bool fixHead;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736F08", Offset = "0x736F08")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x736F40", Offset = "0x736F40")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736F78", Offset = "0x736F78")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x15D9270", Offset = "0x15D9270", VA = "0x15D9270")]
		private void Start()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x15D95A4", Offset = "0x15D95A4", VA = "0x15D95A4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x15D9A44", Offset = "0x15D9A44", VA = "0x15D9A44")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x15D9E10", Offset = "0x15D9E10", VA = "0x15D9E10")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x15DA59C", Offset = "0x15DA59C", VA = "0x15DA59C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x15DA87C", Offset = "0x15DA87C", VA = "0x15DA87C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x15DAB80", Offset = "0x15DAB80", VA = "0x15DAB80")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x15DB354", Offset = "0x15DB354", VA = "0x15DB354")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x15DA380", Offset = "0x15DA380", VA = "0x15DA380")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x15DB51C", Offset = "0x15DB51C", VA = "0x15DB51C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x15DB26C", Offset = "0x15DB26C", VA = "0x15DB26C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x15DB1A0", Offset = "0x15DB1A0", VA = "0x15DB1A0")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x15DB7A0", Offset = "0x15DB7A0", VA = "0x15DB7A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x15DBA70", Offset = "0x15DBA70", VA = "0x15DBA70")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000053")]
		public class ChildConstraint
		{
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7370B4", Offset = "0x7370B4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7370C4", Offset = "0x7370C4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000033")]
			public float nominalDistance
			{
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x14A94A4", Offset = "0x14A94A4", VA = "0x14A94A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E7F0", Offset = "0x73E7F0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x14A94AC", Offset = "0x14A94AC", VA = "0x14A94AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E800", Offset = "0x73E800")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x14A94B4", Offset = "0x14A94B4", VA = "0x14A94B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E810", Offset = "0x73E810")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029B")]
				[Address(RVA = "0x14A94BC", Offset = "0x14A94BC", VA = "0x14A94BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E820", Offset = "0x73E820")]
				private set
				{
				}
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x14A94C8", Offset = "0x14A94C8", VA = "0x14A94C8")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x14A9514", Offset = "0x14A9514", VA = "0x14A9514")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x14A956C", Offset = "0x14A956C", VA = "0x14A956C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x14A9710", Offset = "0x14A9710", VA = "0x14A9710")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000054")]
		public enum Smoothing
		{
			[Token(Token = "0x4000228")]
			None,
			[Token(Token = "0x4000229")]
			Exponential,
			[Token(Token = "0x400022A")]
			Cubic
		}

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73701C", Offset = "0x73701C")]
		public float pin;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737034", Offset = "0x737034")]
		public float pull;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73704C", Offset = "0x73704C")]
		public float push;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737064", Offset = "0x737064")]
		public float pushParent;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73707C", Offset = "0x73707C")]
		public float reach;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400021C")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x15DC14C", Offset = "0x15DC14C", VA = "0x15DC14C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x15DC238", Offset = "0x15DC238", VA = "0x15DC238")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15DC364", Offset = "0x15DC364", VA = "0x15DC364")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x15DC490", Offset = "0x15DC490", VA = "0x15DC490")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x15DC568", Offset = "0x15DC568", VA = "0x15DC568")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x15DC680", Offset = "0x15DC680", VA = "0x15DC680")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x15DCCFC", Offset = "0x15DCCFC", VA = "0x15DCCFC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x15DC810", Offset = "0x15DC810", VA = "0x15DC810")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x15DD0EC", Offset = "0x15DD0EC", VA = "0x15DD0EC")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x15DD34C", Offset = "0x15DD34C", VA = "0x15DD34C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x15DD5B8", Offset = "0x15DD5B8", VA = "0x15DD5B8")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x15DD95C", Offset = "0x15DD95C", VA = "0x15DD95C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x15DDDF0", Offset = "0x15DDDF0", VA = "0x15DDDF0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x15DE014", Offset = "0x15DE014", VA = "0x15DE014")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x15DDD80", Offset = "0x15DDD80", VA = "0x15DDD80")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x15DD7E8", Offset = "0x15DD7E8", VA = "0x15DD7E8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x15DDD04", Offset = "0x15DDD04", VA = "0x15DDD04")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x15DE0FC", Offset = "0x15DE0FC", VA = "0x15DE0FC")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x15DDC24", Offset = "0x15DDC24", VA = "0x15DDC24")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x15DDEFC", Offset = "0x15DDEFC", VA = "0x15DDEFC")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7370D4", Offset = "0x7370D4")]
		public float weight;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7370EC", Offset = "0x7370EC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1632E44", Offset = "0x1632E44", VA = "0x1632E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E830", Offset = "0x73E830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1632E4C", Offset = "0x1632E4C", VA = "0x1632E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E840", Offset = "0x73E840")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1632C5C", Offset = "0x1632C5C", VA = "0x1632C5C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1632E58", Offset = "0x1632E58", VA = "0x1632E58")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1632E98", Offset = "0x1632E98", VA = "0x1632E98")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1632EF8", Offset = "0x1632EF8", VA = "0x1632EF8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1632F04", Offset = "0x1632F04", VA = "0x1632F04")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x163327C", Offset = "0x163327C", VA = "0x163327C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x163346C", Offset = "0x163346C", VA = "0x163346C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x16337B8", Offset = "0x16337B8", VA = "0x16337B8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x163313C", Offset = "0x163313C", VA = "0x163313C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x16331DC", Offset = "0x16331DC", VA = "0x16331DC")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKEffector
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7370FC", Offset = "0x7370FC")]
		public float positionWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737114", Offset = "0x737114")]
		public float rotationWeight;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73712C", Offset = "0x73712C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73713C", Offset = "0x73713C")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000036")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1633C98", Offset = "0x1633C98", VA = "0x1633C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E850", Offset = "0x73E850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1633CA0", Offset = "0x1633CA0", VA = "0x1633CA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E860", Offset = "0x73E860")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1633C30", Offset = "0x1633C30", VA = "0x1633C30")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1633CAC", Offset = "0x1633CAC", VA = "0x1633CAC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1633D3C", Offset = "0x1633D3C", VA = "0x1633D3C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1633E50", Offset = "0x1633E50", VA = "0x1633E50")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1633F80", Offset = "0x1633F80", VA = "0x1633F80")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x163429C", Offset = "0x163429C", VA = "0x163429C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x163451C", Offset = "0x163451C", VA = "0x163451C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x16345E8", Offset = "0x16345E8", VA = "0x16345E8")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1634690", Offset = "0x1634690", VA = "0x1634690")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1634BB8", Offset = "0x1634BB8", VA = "0x1634BB8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1634BE4", Offset = "0x1634BE4", VA = "0x1634BE4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1634D38", Offset = "0x1634D38", VA = "0x1634D38")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1634FB0", Offset = "0x1634FB0", VA = "0x1634FB0")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000058")]
		public class BoneMap
		{
			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000037")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002C1")]
				[Address(RVA = "0x149EAD4", Offset = "0x149EAD4", VA = "0x149EAD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x14ACBB4", Offset = "0x14ACBB4", VA = "0x14ACBB4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0x14ACF58", Offset = "0x14ACF58", VA = "0x14ACF58")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x14ACAE8", Offset = "0x14ACAE8", VA = "0x14ACAE8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x14ACB14", Offset = "0x14ACB14", VA = "0x14ACB14")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x14ACB64", Offset = "0x14ACB64", VA = "0x14ACB64")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x14ACBC4", Offset = "0x14ACBC4", VA = "0x14ACBC4")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x14ACC4C", Offset = "0x14ACC4C", VA = "0x14ACC4C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x14ACC54", Offset = "0x14ACC54", VA = "0x14ACC54")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x14ACD2C", Offset = "0x14ACD2C", VA = "0x14ACD2C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x14ACDA4", Offset = "0x14ACDA4", VA = "0x14ACDA4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x14ACE3C", Offset = "0x14ACE3C", VA = "0x14ACE3C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x14AD098", Offset = "0x14AD098", VA = "0x14AD098")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x14AD0D0", Offset = "0x14AD0D0", VA = "0x14AD0D0")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x14AD108", Offset = "0x14AD108", VA = "0x14AD108")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x14AD130", Offset = "0x14AD130", VA = "0x14AD130")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x14AD21C", Offset = "0x14AD21C", VA = "0x14AD21C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x14AD3A8", Offset = "0x14AD3A8", VA = "0x14AD3A8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x14AD3D8", Offset = "0x14AD3D8", VA = "0x14AD3D8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x14AD4A0", Offset = "0x14AD4A0", VA = "0x14AD4A0")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x14AD510", Offset = "0x14AD510", VA = "0x14AD510")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x14AD660", Offset = "0x14AD660", VA = "0x14AD660")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x14AD7B0", Offset = "0x14AD7B0", VA = "0x14AD7B0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x14AD830", Offset = "0x14AD830", VA = "0x14AD830")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x14AD298", Offset = "0x14AD298", VA = "0x14AD298")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x14AD968", Offset = "0x14AD968", VA = "0x14AD968")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1635458", Offset = "0x1635458", VA = "0x1635458", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1635460", Offset = "0x1635460", VA = "0x1635460", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1635464", Offset = "0x1635464", VA = "0x1635464")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x16355A8", Offset = "0x16355A8", VA = "0x16355A8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1635618", Offset = "0x1635618", VA = "0x1635618")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737154", Offset = "0x737154")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1635620", Offset = "0x1635620", VA = "0x1635620", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x16356C8", Offset = "0x16356C8", VA = "0x16356C8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1635734", Offset = "0x1635734", VA = "0x1635734")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x16357B4", Offset = "0x16357B4", VA = "0x16357B4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x16357D0", Offset = "0x16357D0", VA = "0x16357D0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x16357F0", Offset = "0x16357F0", VA = "0x16357F0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1635878", Offset = "0x1635878", VA = "0x1635878")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1635894", Offset = "0x1635894", VA = "0x1635894")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000282")]
			Parent,
			[Token(Token = "0x4000283")]
			Bone1,
			[Token(Token = "0x4000284")]
			Bone2,
			[Token(Token = "0x4000285")]
			Bone3
		}

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73716C", Offset = "0x73716C")]
		public float maintainRotationWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737184", Offset = "0x737184")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x16358BC", Offset = "0x16358BC", VA = "0x16358BC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1635940", Offset = "0x1635940", VA = "0x1635940")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1635A1C", Offset = "0x1635A1C", VA = "0x1635A1C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1635C40", Offset = "0x1635C40", VA = "0x1635C40")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1635D04", Offset = "0x1635D04", VA = "0x1635D04")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1635DF4", Offset = "0x1635DF4", VA = "0x1635DF4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1635E00", Offset = "0x1635E00", VA = "0x1635E00")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1635EB4", Offset = "0x1635EB4", VA = "0x1635EB4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1635F78", Offset = "0x1635F78", VA = "0x1635F78", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x16361B8", Offset = "0x16361B8", VA = "0x16361B8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x163622C", Offset = "0x163622C", VA = "0x163622C")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73719C", Offset = "0x73719C")]
		public int iterations;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7371B4", Offset = "0x7371B4")]
		public float twistWeight;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x16363A8", Offset = "0x16363A8", VA = "0x16363A8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x163670C", Offset = "0x163670C", VA = "0x163670C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x16367F0", Offset = "0x16367F0", VA = "0x16367F0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1636908", Offset = "0x1636908", VA = "0x1636908")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1636918", Offset = "0x1636918", VA = "0x1636918")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1636984", Offset = "0x1636984", VA = "0x1636984")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1636A08", Offset = "0x1636A08", VA = "0x1636A08", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1636FE0", Offset = "0x1636FE0", VA = "0x1636FE0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1637018", Offset = "0x1637018", VA = "0x1637018")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x163729C", Offset = "0x163729C", VA = "0x163729C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x163759C", Offset = "0x163759C", VA = "0x163759C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1637688", Offset = "0x1637688", VA = "0x1637688")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1637750", Offset = "0x1637750", VA = "0x1637750")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200005E")]
		public class Point
		{
			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737288", Offset = "0x737288")]
			public float weight;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x16AB3AC", Offset = "0x16AB3AC", VA = "0x16AB3AC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x16AB3FC", Offset = "0x16AB3FC", VA = "0x16AB3FC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x16AB49C", Offset = "0x16AB49C", VA = "0x16AB49C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x16AB4D4", Offset = "0x16AB4D4", VA = "0x16AB4D4")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x16AB50C", Offset = "0x16AB50C", VA = "0x16AB50C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x16AB55C", Offset = "0x16AB55C", VA = "0x16AB55C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x16AB310", Offset = "0x16AB310", VA = "0x16AB310")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public class Bone : Point
		{
			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700003B")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000317")]
				[Address(RVA = "0x14AD984", Offset = "0x14AD984", VA = "0x14AD984")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x14ADA80", Offset = "0x14ADA80", VA = "0x14ADA80")]
				set
				{
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x14ADB04", Offset = "0x14ADB04", VA = "0x14ADB04")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x14ADCB4", Offset = "0x14ADCB4", VA = "0x14ADCB4")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x14ADE88", Offset = "0x14ADE88", VA = "0x14ADE88")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x14ADFE8", Offset = "0x14ADFE8", VA = "0x14ADFE8")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x14AE010", Offset = "0x14AE010", VA = "0x14AE010")]
			public Bone()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x14AE058", Offset = "0x14AE058", VA = "0x14AE058")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x14AE0AC", Offset = "0x14AE0AC", VA = "0x14AE0AC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000060")]
		public class Node : Point
		{
			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x16AB30C", Offset = "0x16AB30C", VA = "0x16AB30C")]
			public Node()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x16AB34C", Offset = "0x16AB34C", VA = "0x16AB34C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x16AB374", Offset = "0x16AB374", VA = "0x16AB374")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000061")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000062")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7371EC", Offset = "0x7371EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7371EC", Offset = "0x7371EC")]
		public float IKPositionWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737240", Offset = "0x737240")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UpdateDelegate OnLatePostUpdate;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected bool firstInitiation;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1637A80", Offset = "0x1637A80", VA = "0x1637A80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E870", Offset = "0x73E870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1637A88", Offset = "0x1637A88", VA = "0x1637A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E880", Offset = "0x73E880")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x16379B0", Offset = "0x16379B0", VA = "0x16379B0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1632A78", Offset = "0x1632A78", VA = "0x1632A78")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1632988", Offset = "0x1632988", VA = "0x1632988")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1637A28", Offset = "0x1637A28", VA = "0x1637A28", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1637A34", Offset = "0x1637A34", VA = "0x1637A34")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1637A40", Offset = "0x1637A40", VA = "0x1637A40")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1637A48", Offset = "0x1637A48", VA = "0x1637A48")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1637A78", Offset = "0x1637A78", VA = "0x1637A78")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000306")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000307")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000308")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000309")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600030A")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1637A94", Offset = "0x1637A94", VA = "0x1637A94")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1637AAC", Offset = "0x1637AAC", VA = "0x1637AAC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1637BE4", Offset = "0x1637BE4", VA = "0x1637BE4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1637C8C", Offset = "0x1637C8C", VA = "0x1637C8C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1637F14", Offset = "0x1637F14", VA = "0x1637F14")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform transform;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 axis;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Vector3 polePosition;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7372A0", Offset = "0x7372A0")]
		public float poleWeight;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Transform poleTarget;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7372B8", Offset = "0x7372B8")]
		public float clampWeight;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7372D0", Offset = "0x7372D0")]
		public int clampSmoothing;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float step;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Transform lastTransform;

		[Token(Token = "0x1700003C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1637FA8", Offset = "0x1637FA8", VA = "0x1637FA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1637FE4", Offset = "0x1637FE4", VA = "0x1637FE4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1638A74", Offset = "0x1638A74", VA = "0x1638A74", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1638E58", Offset = "0x1638E58", VA = "0x1638E58", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1637F2C", Offset = "0x1637F2C", VA = "0x1637F2C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1638020", Offset = "0x1638020", VA = "0x1638020", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1638240", Offset = "0x1638240", VA = "0x1638240", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x16389C0", Offset = "0x16389C0", VA = "0x16389C0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1638750", Offset = "0x1638750", VA = "0x1638750")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1638A7C", Offset = "0x1638A7C", VA = "0x1638A7C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1638ECC", Offset = "0x1638ECC", VA = "0x1638ECC")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7372E8", Offset = "0x7372E8")]
		public float IKRotationWeight;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point chest;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point shoulder;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point upperArm;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point forearm;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Point hand;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isLeft;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1638F20", Offset = "0x1638F20", VA = "0x1638F20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x16392BC", Offset = "0x16392BC", VA = "0x16392BC")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1639328", Offset = "0x1639328", VA = "0x1639328", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1639480", Offset = "0x1639480", VA = "0x1639480", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1639614", Offset = "0x1639614", VA = "0x1639614", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1639670", Offset = "0x1639670", VA = "0x1639670", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x16396E0", Offset = "0x16396E0", VA = "0x16396E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1639A50", Offset = "0x1639A50", VA = "0x1639A50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1639A7C", Offset = "0x1639A7C", VA = "0x1639A7C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1639744", Offset = "0x1639744", VA = "0x1639744")]
		private void Read()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1639AEC", Offset = "0x1639AEC", VA = "0x1639AEC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1639C78", Offset = "0x1639C78", VA = "0x1639C78")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1639DDC", Offset = "0x1639DDC", VA = "0x1639DDC")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1639E8C", Offset = "0x1639E8C", VA = "0x1639E8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1639F10", Offset = "0x1639F10", VA = "0x1639F10", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x163A140", Offset = "0x163A140", VA = "0x163A140")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x163A71C", Offset = "0x163A71C", VA = "0x163A71C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool[] limitedBones;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000040")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x163B62C", Offset = "0x163B62C", VA = "0x163B62C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x163A724", Offset = "0x163A724", VA = "0x163A724")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x163ACE8", Offset = "0x163ACE8", VA = "0x163ACE8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x163AE28", Offset = "0x163AE28", VA = "0x163AE28", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x163AEBC", Offset = "0x163AEBC", VA = "0x163AEBC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x163B398", Offset = "0x163B398", VA = "0x163B398", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x163B634", Offset = "0x163B634", VA = "0x163B634")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x163A800", Offset = "0x163A800", VA = "0x163A800")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x163ADD4", Offset = "0x163ADD4", VA = "0x163ADD4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x163B5D0", Offset = "0x163B5D0", VA = "0x163B5D0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x163AB5C", Offset = "0x163AB5C", VA = "0x163AB5C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x163BC84", Offset = "0x163BC84", VA = "0x163BC84")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x163BCF8", Offset = "0x163BCF8", VA = "0x163BCF8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x163BDC0", Offset = "0x163BDC0", VA = "0x163BDC0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x163BE70", Offset = "0x163BE70", VA = "0x163BE70")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x163B148", Offset = "0x163B148", VA = "0x163B148")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x163B270", Offset = "0x163B270", VA = "0x163B270")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x163BF74", Offset = "0x163BF74", VA = "0x163BF74")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x163B854", Offset = "0x163B854", VA = "0x163B854")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x163ADC4", Offset = "0x163ADC4", VA = "0x163ADC4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x163C504", Offset = "0x163C504", VA = "0x163C504")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x163C0B8", Offset = "0x163C0B8", VA = "0x163C0B8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x163B6B0", Offset = "0x163B6B0", VA = "0x163B6B0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x163B790", Offset = "0x163B790", VA = "0x163B790")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x163C5D0", Offset = "0x163C5D0", VA = "0x163C5D0")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int iterations;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737300", Offset = "0x737300")]
		public float rootPin;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool[] isRoot;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x163C650", Offset = "0x163C650", VA = "0x163C650", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x163CC90", Offset = "0x163CC90", VA = "0x163CC90", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x163CD28", Offset = "0x163CD28", VA = "0x163CD28", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x163CDC8", Offset = "0x163CDC8", VA = "0x163CDC8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x163CEC4", Offset = "0x163CEC4", VA = "0x163CEC4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x163CF60", Offset = "0x163CF60", VA = "0x163CF60", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x163D390", Offset = "0x163D390", VA = "0x163D390", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x163D588", Offset = "0x163D588", VA = "0x163D588", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x163D43C", Offset = "0x163D43C", VA = "0x163D43C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x163D14C", Offset = "0x163D14C", VA = "0x163D14C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x163D620", Offset = "0x163D620", VA = "0x163D620")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737318", Offset = "0x737318")]
		public int iterations;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool FABRIKPass;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x163D694", Offset = "0x163D694", VA = "0x163D694")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x163D784", Offset = "0x163D784", VA = "0x163D784")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x163D7E0", Offset = "0x163D7E0", VA = "0x163D7E0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1633BD4", Offset = "0x1633BD4", VA = "0x1633BD4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x16330BC", Offset = "0x16330BC", VA = "0x16330BC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x163D910", Offset = "0x163D910", VA = "0x163D910", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x163DAB4", Offset = "0x163DAB4", VA = "0x163DAB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x163DC24", Offset = "0x163DC24", VA = "0x163DC24", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x163DE2C", Offset = "0x163DE2C", VA = "0x163DE2C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x163DF04", Offset = "0x163DF04", VA = "0x163DF04", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x163DFE4", Offset = "0x163DFE4", VA = "0x163DFE4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x163E154", Offset = "0x163E154", VA = "0x163E154", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x163E2B4", Offset = "0x163E2B4", VA = "0x163E2B4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x163E4F4", Offset = "0x163E4F4", VA = "0x163E4F4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x163E7C0", Offset = "0x163E7C0", VA = "0x163E7C0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x163E804", Offset = "0x163E804", VA = "0x163E804", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x163E8E8", Offset = "0x163E8E8", VA = "0x163E8E8")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002E0")]
		Body,
		[Token(Token = "0x40002E1")]
		LeftShoulder,
		[Token(Token = "0x40002E2")]
		RightShoulder,
		[Token(Token = "0x40002E3")]
		LeftThigh,
		[Token(Token = "0x40002E4")]
		RightThigh,
		[Token(Token = "0x40002E5")]
		LeftHand,
		[Token(Token = "0x40002E6")]
		RightHand,
		[Token(Token = "0x40002E7")]
		LeftFoot,
		[Token(Token = "0x40002E8")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002EA")]
		LeftArm,
		[Token(Token = "0x40002EB")]
		RightArm,
		[Token(Token = "0x40002EC")]
		LeftLeg,
		[Token(Token = "0x40002ED")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Transform rootNode;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737330", Offset = "0x737330")]
		public float spineStiffness;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737348", Offset = "0x737348")]
		public float pullBodyVertical;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737360", Offset = "0x737360")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737378", Offset = "0x737378")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x161CD6C", Offset = "0x161CD6C", VA = "0x161CD6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x161CEB4", Offset = "0x161CEB4", VA = "0x161CEB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x161CEBC", Offset = "0x161CEBC", VA = "0x161CEBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x161CEC4", Offset = "0x161CEC4", VA = "0x161CEC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x161CECC", Offset = "0x161CECC", VA = "0x161CECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x161CED4", Offset = "0x161CED4", VA = "0x161CED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x161CEDC", Offset = "0x161CEDC", VA = "0x161CEDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x161CEE4", Offset = "0x161CEE4", VA = "0x161CEE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x161CEEC", Offset = "0x161CEEC", VA = "0x161CEEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x161CEF4", Offset = "0x161CEF4", VA = "0x161CEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x161CF2C", Offset = "0x161CF2C", VA = "0x161CF2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x161CF64", Offset = "0x161CF64", VA = "0x161CF64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x161CF9C", Offset = "0x161CF9C", VA = "0x161CF9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x161CFD4", Offset = "0x161CFD4", VA = "0x161CFD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x161D008", Offset = "0x161D008", VA = "0x161D008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x161D040", Offset = "0x161D040", VA = "0x161D040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x161D078", Offset = "0x161D078", VA = "0x161D078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x161D0B0", Offset = "0x161D0B0", VA = "0x161D0B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x161EF7C", Offset = "0x161EF7C", VA = "0x161EF7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E890", Offset = "0x73E890")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x161EF88", Offset = "0x161EF88", VA = "0x161EF88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E8A0", Offset = "0x73E8A0")]
			private set
			{
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x161D0E4", Offset = "0x161D0E4", VA = "0x161D0E4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x161D1F0", Offset = "0x161D1F0", VA = "0x161D1F0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x161D138", Offset = "0x161D138", VA = "0x161D138")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x161D27C", Offset = "0x161D27C", VA = "0x161D27C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x161CD74", Offset = "0x161CD74", VA = "0x161CD74")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x161D34C", Offset = "0x161D34C", VA = "0x161D34C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x161D404", Offset = "0x161D404", VA = "0x161D404")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x161D4B8", Offset = "0x161D4B8", VA = "0x161D4B8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x161D56C", Offset = "0x161D56C", VA = "0x161D56C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x161D574", Offset = "0x161D574", VA = "0x161D574")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x161D5A8", Offset = "0x161D5A8", VA = "0x161D5A8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x161D670", Offset = "0x161D670", VA = "0x161D670", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x161D818", Offset = "0x161D818", VA = "0x161D818")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x161E9F8", Offset = "0x161E9F8", VA = "0x161E9F8")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x161EE0C", Offset = "0x161EE0C", VA = "0x161EE0C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x161EE6C", Offset = "0x161EE6C", VA = "0x161EE6C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x161EC94", Offset = "0x161EC94", VA = "0x161EC94")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x161ED50", Offset = "0x161ED50", VA = "0x161ED50")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x161EF94", Offset = "0x161EF94", VA = "0x161EF94")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x161F06C", Offset = "0x161F06C", VA = "0x161F06C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x161F16C", Offset = "0x161F16C", VA = "0x161F16C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x161F294", Offset = "0x161F294", VA = "0x161F294")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x161F3D8", Offset = "0x161F3D8", VA = "0x161F3D8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x161F508", Offset = "0x161F508", VA = "0x161F508", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x161F74C", Offset = "0x161F74C", VA = "0x161F74C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x161F7D4", Offset = "0x161F7D4", VA = "0x161F7D4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform target;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float tolerance;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxIterations;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRotationLimits;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool XY;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Bone[] bones;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float chainLength;

		[Token(Token = "0x17000054")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1620044", Offset = "0x1620044", VA = "0x1620044", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x162004C", Offset = "0x162004C", VA = "0x162004C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1620054", Offset = "0x1620054", VA = "0x1620054", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x16204DC", Offset = "0x16204DC", VA = "0x16204DC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x16205A4", Offset = "0x16205A4", VA = "0x16205A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x161F7E4", Offset = "0x161F7E4", VA = "0x161F7E4")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x161F980", Offset = "0x161F980", VA = "0x161F980")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x161FAB8", Offset = "0x161FAB8", VA = "0x161FAB8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x161FB24", Offset = "0x161FB24", VA = "0x161FB24", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x161FBA4", Offset = "0x161FBA4", VA = "0x161FBA4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x161FF4C", Offset = "0x161FF4C", VA = "0x161FF4C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x161FF54", Offset = "0x161FF54", VA = "0x161FF54", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x162005C", Offset = "0x162005C", VA = "0x162005C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1620060", Offset = "0x1620060", VA = "0x1620060", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1620064", Offset = "0x1620064", VA = "0x1620064")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x16205F8", Offset = "0x16205F8", VA = "0x16205F8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1620910", Offset = "0x1620910", VA = "0x1620910")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1620B04", Offset = "0x1620B04", VA = "0x1620B04")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737388", Offset = "0x737388")]
		public float IKRotationWeight;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point pelvis;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point thigh;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point calf;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point foot;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Point toe;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] positions;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1620B70", Offset = "0x1620B70", VA = "0x1620B70", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1620F10", Offset = "0x1620F10", VA = "0x1620F10")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1620F80", Offset = "0x1620F80", VA = "0x1620F80", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x16210D8", Offset = "0x16210D8", VA = "0x16210D8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x162126C", Offset = "0x162126C", VA = "0x162126C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x16212C8", Offset = "0x16212C8", VA = "0x16212C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1621338", Offset = "0x1621338", VA = "0x1621338", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x16216A8", Offset = "0x16216A8", VA = "0x16216A8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x16216D4", Offset = "0x16216D4", VA = "0x16216D4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x162139C", Offset = "0x162139C", VA = "0x162139C")]
		private void Read()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x162176C", Offset = "0x162176C", VA = "0x162176C")]
		private void Write()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x16218F8", Offset = "0x16218F8", VA = "0x16218F8")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200006F")]
		public enum BendModifier
		{
			[Token(Token = "0x4000318")]
			Animation,
			[Token(Token = "0x4000319")]
			Target,
			[Token(Token = "0x400031A")]
			Parent,
			[Token(Token = "0x400031B")]
			Arm,
			[Token(Token = "0x400031C")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000070")]
		public struct AxisDirection
		{
			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x16AB800", Offset = "0x16AB800", VA = "0x16AB800")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7373A0", Offset = "0x7373A0")]
		public float maintainRotationWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7373B8", Offset = "0x7373B8")]
		public float bendModifierWeight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Transform bendGoal;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000059")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1622B7C", Offset = "0x1622B7C", VA = "0x1622B7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1621A50", Offset = "0x1621A50", VA = "0x1621A50")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1621AA4", Offset = "0x1621AA4", VA = "0x1621AA4")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1621AF0", Offset = "0x1621AF0", VA = "0x1621AF0", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1621FC4", Offset = "0x1621FC4", VA = "0x1621FC4", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1622910", Offset = "0x1622910", VA = "0x1622910", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x16229BC", Offset = "0x16229BC", VA = "0x16229BC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1622AF8", Offset = "0x1622AF8", VA = "0x1622AF8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1621DEC", Offset = "0x1621DEC", VA = "0x1621DEC")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x16220AC", Offset = "0x16220AC", VA = "0x16220AC")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000060")]
			public Vector3 forward
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0x16ABA94", Offset = "0x16ABA94", VA = "0x16ABA94")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x16AB860", Offset = "0x16AB860", VA = "0x16AB860")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x16AB868", Offset = "0x16AB868", VA = "0x16AB868")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x16AB894", Offset = "0x16AB894", VA = "0x16AB894")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x16AB98C", Offset = "0x16AB98C", VA = "0x16AB98C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform target;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone head;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7373D0", Offset = "0x7373D0")]
		public float bodyWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7373E8", Offset = "0x7373E8")]
		public float headWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737400", Offset = "0x737400")]
		public float eyesWeight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737418", Offset = "0x737418")]
		public float clampWeight;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737430", Offset = "0x737430")]
		public float clampWeightHead;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737448", Offset = "0x737448")]
		public float clampWeightEyes;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737460", Offset = "0x737460")]
		public int clampSmoothing;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool isDirty;

		[Token(Token = "0x1700005A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x162332C", Offset = "0x162332C", VA = "0x162332C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x16234FC", Offset = "0x16234FC", VA = "0x16234FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x162340C", Offset = "0x162340C", VA = "0x162340C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1623520", Offset = "0x1623520", VA = "0x1623520")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x162341C", Offset = "0x162341C", VA = "0x162341C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1623598", Offset = "0x1623598", VA = "0x1623598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1622B98", Offset = "0x1622B98", VA = "0x1622B98")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1622BC8", Offset = "0x1622BC8", VA = "0x1622BC8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1622C20", Offset = "0x1622C20", VA = "0x1622C20")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1622C9C", Offset = "0x1622C9C", VA = "0x1622C9C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1622D34", Offset = "0x1622D34", VA = "0x1622D34")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1622DF4", Offset = "0x1622DF4", VA = "0x1622DF4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1622EF0", Offset = "0x1622EF0", VA = "0x1622EF0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x162301C", Offset = "0x162301C", VA = "0x162301C")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1623028", Offset = "0x1623028", VA = "0x1623028", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x162316C", Offset = "0x162316C", VA = "0x162316C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x16235BC", Offset = "0x16235BC", VA = "0x16235BC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x16237FC", Offset = "0x16237FC", VA = "0x16237FC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1623998", Offset = "0x1623998", VA = "0x1623998")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1623BC8", Offset = "0x1623BC8", VA = "0x1623BC8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1623E9C", Offset = "0x1623E9C", VA = "0x1623E9C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1623F6C", Offset = "0x1623F6C", VA = "0x1623F6C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x162410C", Offset = "0x162410C", VA = "0x162410C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1624330", Offset = "0x1624330", VA = "0x1624330")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x16246E4", Offset = "0x16246E4", VA = "0x16246E4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1623A44", Offset = "0x1623A44", VA = "0x1623A44")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1624954", Offset = "0x1624954", VA = "0x1624954")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000074")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x16ABAD0", Offset = "0x16ABAD0", VA = "0x16ABAD0")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x16ABBCC", Offset = "0x16ABBCC", VA = "0x16ABBCC")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x16ABBFC", Offset = "0x16ABBFC", VA = "0x16ABBFC")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x16ABC38", Offset = "0x16ABC38", VA = "0x16ABC38")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform target;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737478", Offset = "0x737478")]
		public float IKRotationWeight;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		protected bool directHierarchy;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1624B60", Offset = "0x1624B60", VA = "0x1624B60")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1624CBC", Offset = "0x1624CBC", VA = "0x1624CBC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1624E00", Offset = "0x1624E00", VA = "0x1624E00")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1624E0C", Offset = "0x1624E0C", VA = "0x1624E0C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1624E3C", Offset = "0x1624E3C", VA = "0x1624E3C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1624E48", Offset = "0x1624E48", VA = "0x1624E48")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1624E50", Offset = "0x1624E50", VA = "0x1624E50", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1624F50", Offset = "0x1624F50", VA = "0x1624F50", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x162506C", Offset = "0x162506C", VA = "0x162506C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x16250B8", Offset = "0x16250B8", VA = "0x16250B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1625118", Offset = "0x1625118", VA = "0x1625118", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x16254E0", Offset = "0x16254E0", VA = "0x16254E0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1625538", Offset = "0x1625538", VA = "0x1625538")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x16258F4", Offset = "0x16258F4", VA = "0x16258F4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1625A5C", Offset = "0x1625A5C", VA = "0x1625A5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1625BC4", Offset = "0x1625BC4", VA = "0x1625BC4")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1625B38", Offset = "0x1625B38", VA = "0x1625B38")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1625CC8", Offset = "0x1625CC8", VA = "0x1625CC8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x162649C", Offset = "0x162649C", VA = "0x162649C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x16264A0", Offset = "0x16264A0", VA = "0x16264A0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x16264A4", Offset = "0x16264A4", VA = "0x16264A4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x16262B4", Offset = "0x16262B4", VA = "0x16262B4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1622A2C", Offset = "0x1622A2C", VA = "0x1622A2C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000077")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000380")]
				YawPitch,
				[Token(Token = "0x4000381")]
				FromTo
			}

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7376B4", Offset = "0x7376B4")]
			public Transform target;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7376EC", Offset = "0x7376EC")]
			public Transform bendGoal;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737724", Offset = "0x737724")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737724", Offset = "0x737724")]
			public float positionWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737778", Offset = "0x737778")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737778", Offset = "0x737778")]
			public float rotationWeight;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7377CC", Offset = "0x7377CC")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737804", Offset = "0x737804")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737804", Offset = "0x737804")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737858", Offset = "0x737858")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737858", Offset = "0x737858")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7378AC", Offset = "0x7378AC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7378AC", Offset = "0x7378AC")]
			public float bendGoalWeight;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737900", Offset = "0x737900")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737900", Offset = "0x737900")]
			public float swivelOffset;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73795C", Offset = "0x73795C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737994", Offset = "0x737994")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7379CC", Offset = "0x7379CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7379CC", Offset = "0x7379CC")]
			public float armLengthMlp;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737A24", Offset = "0x737A24")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737A9C", Offset = "0x737A9C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737AAC", Offset = "0x737AAC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400037D")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400037E")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000062")]
			public Vector3 position
			{
				[Token(Token = "0x600042A")]
				[Address(RVA = "0x16ABC40", Offset = "0x16ABC40", VA = "0x16ABC40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E8D0", Offset = "0x73E8D0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600042B")]
				[Address(RVA = "0x16ABC4C", Offset = "0x16ABC4C", VA = "0x16ABC4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E8E0", Offset = "0x73E8E0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x600042C")]
				[Address(RVA = "0x16ABC58", Offset = "0x16ABC58", VA = "0x16ABC58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E8F0", Offset = "0x73E8F0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600042D")]
				[Address(RVA = "0x16ABC64", Offset = "0x16ABC64", VA = "0x16ABC64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E900", Offset = "0x73E900")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x16ABC70", Offset = "0x16ABC70", VA = "0x16ABC70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x16ABCA4", Offset = "0x16ABCA4", VA = "0x16ABCA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x16ABCE4", Offset = "0x16ABCE4", VA = "0x16ABCE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x16ABD30", Offset = "0x16ABD30", VA = "0x16ABD30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x16ABD7C", Offset = "0x16ABD7C", VA = "0x16ABD7C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x16AC6C0", Offset = "0x16AC6C0", VA = "0x16AC6C0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x16AC87C", Offset = "0x16AC87C", VA = "0x16AC87C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x16AC8A0", Offset = "0x16AC8A0", VA = "0x16AC8A0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x16ACB40", Offset = "0x16ACB40", VA = "0x16ACB40")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x16AE5D4", Offset = "0x16AE5D4", VA = "0x16AE5D4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x16AE600", Offset = "0x16AE600", VA = "0x16AE600", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x16ADAD4", Offset = "0x16ADAD4", VA = "0x16ADAD4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x16ADC8C", Offset = "0x16ADC8C", VA = "0x16ADC8C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x16AE820", Offset = "0x16AE820", VA = "0x16AE820")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x16AE944", Offset = "0x16AE944", VA = "0x16AE944")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737ABC", Offset = "0x737ABC")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737ACC", Offset = "0x737ACC")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000068")]
			public float sqrMag
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0x16AEA9C", Offset = "0x16AEA9C", VA = "0x16AEA9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E910", Offset = "0x73E910")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x16AEAA4", Offset = "0x16AEAA4", VA = "0x16AEAA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E920", Offset = "0x73E920")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x16AEAAC", Offset = "0x16AEAAC", VA = "0x16AEAAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E930", Offset = "0x73E930")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x16AEAB4", Offset = "0x16AEAB4", VA = "0x16AEAB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E940", Offset = "0x73E940")]
				private set
				{
				}
			}

			[Token(Token = "0x600043D")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600043E")]
			public abstract void PreSolve();

			[Token(Token = "0x600043F")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000440")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000441")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x16AEABC", Offset = "0x16AEABC", VA = "0x16AEABC")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x16AEAC4", Offset = "0x16AEAC4", VA = "0x16AEAC4")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x16AED84", Offset = "0x16AED84", VA = "0x16AED84")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x16AEE18", Offset = "0x16AEE18", VA = "0x16AEE18")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x16AEFE8", Offset = "0x16AEFE8", VA = "0x16AEFE8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x16AF03C", Offset = "0x16AF03C", VA = "0x16AF03C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x16AE494", Offset = "0x16AE494", VA = "0x16AE494")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x16AF174", Offset = "0x16AF174", VA = "0x16AF174")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x16AF2B4", Offset = "0x16AF2B4", VA = "0x16AF2B4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x16AEA28", Offset = "0x16AEA28", VA = "0x16AEA28")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public class Footstep
		{
			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737AEC", Offset = "0x737AEC")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006A")]
			public bool isStepping
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x16AF2DC", Offset = "0x16AF2DC", VA = "0x16AF2DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x16AF2F0", Offset = "0x16AF2F0", VA = "0x16AF2F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E950", Offset = "0x73E950")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x16AF2F8", Offset = "0x16AF2F8", VA = "0x16AF2F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E960", Offset = "0x73E960")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x16AF300", Offset = "0x16AF300", VA = "0x16AF300")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x16AF438", Offset = "0x16AF438", VA = "0x16AF438")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x16AF480", Offset = "0x16AF480", VA = "0x16AF480")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x16AF64C", Offset = "0x16AF64C", VA = "0x16AF64C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x16AF7C0", Offset = "0x16AF7C0", VA = "0x16AF7C0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x16AF918", Offset = "0x16AF918", VA = "0x16AF918")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737AFC", Offset = "0x737AFC")]
			public Transform target;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737B34", Offset = "0x737B34")]
			public Transform bendGoal;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737B6C", Offset = "0x737B6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737B6C", Offset = "0x737B6C")]
			public float positionWeight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737BC0", Offset = "0x737BC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737BC0", Offset = "0x737BC0")]
			public float rotationWeight;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C14", Offset = "0x737C14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737C14", Offset = "0x737C14")]
			public float bendGoalWeight;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C68", Offset = "0x737C68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737C68", Offset = "0x737C68")]
			public float swivelOffset;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737CC4", Offset = "0x737CC4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737CC4", Offset = "0x737CC4")]
			public float bendToTargetWeight;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737D18", Offset = "0x737D18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737D18", Offset = "0x737D18")]
			public float legLengthMlp;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737D70", Offset = "0x737D70")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737E18", Offset = "0x737E18")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737E28", Offset = "0x737E28")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737E38", Offset = "0x737E38")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737E48", Offset = "0x737E48")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x16AFA54", Offset = "0x16AFA54", VA = "0x16AFA54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E970", Offset = "0x73E970")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x16AFA60", Offset = "0x16AFA60", VA = "0x16AFA60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E980", Offset = "0x73E980")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x16AFA6C", Offset = "0x16AFA6C", VA = "0x16AFA6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E990", Offset = "0x73E990")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x16AFA78", Offset = "0x16AFA78", VA = "0x16AFA78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E9A0", Offset = "0x73E9A0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x16AFA84", Offset = "0x16AFA84", VA = "0x16AFA84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E9B0", Offset = "0x73E9B0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x16AFA8C", Offset = "0x16AFA8C", VA = "0x16AFA8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E9C0", Offset = "0x73E9C0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x16AFA98", Offset = "0x16AFA98", VA = "0x16AFA98")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x16AFACC", Offset = "0x16AFACC", VA = "0x16AFACC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x16AFB04", Offset = "0x16AFB04", VA = "0x16AFB04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x16AFB3C", Offset = "0x16AFB3C", VA = "0x16AFB3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x16AFB74", Offset = "0x16AFB74", VA = "0x16AFB74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x16AFBB4", Offset = "0x16AFBB4", VA = "0x16AFBB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E9D0", Offset = "0x73E9D0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x16AFBC0", Offset = "0x16AFBC0", VA = "0x16AFBC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E9E0", Offset = "0x73E9E0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x16AFBCC", Offset = "0x16AFBCC", VA = "0x16AFBCC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x16B01A8", Offset = "0x16B01A8", VA = "0x16B01A8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x16B077C", Offset = "0x16B077C", VA = "0x16B077C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x16B072C", Offset = "0x16B072C", VA = "0x16B072C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x16B05BC", Offset = "0x16B05BC", VA = "0x16B05BC")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x16B0B64", Offset = "0x16B0B64", VA = "0x16B0B64")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x16B1020", Offset = "0x16B1020", VA = "0x16B1020")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x16B0D00", Offset = "0x16B0D00", VA = "0x16B0D00")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x16B1318", Offset = "0x16B1318", VA = "0x16B1318", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x16B1534", Offset = "0x16B1534", VA = "0x16B1534", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x16B1580", Offset = "0x16B1580", VA = "0x16B1580")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Locomotion
		{
			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737E58", Offset = "0x737E58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737E58", Offset = "0x737E58")]
			public float weight;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737EAC", Offset = "0x737EAC")]
			public float footDistance;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737EE4", Offset = "0x737EE4")]
			public float stepThreshold;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F1C", Offset = "0x737F1C")]
			public float angleThreshold;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F54", Offset = "0x737F54")]
			public float comAngleMlp;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F8C", Offset = "0x737F8C")]
			public float maxVelocity;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737FC4", Offset = "0x737FC4")]
			public float velocityFactor;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737FFC", Offset = "0x737FFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737FFC", Offset = "0x737FFC")]
			public float maxLegStretch;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738054", Offset = "0x738054")]
			public float rootSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73808C", Offset = "0x73808C")]
			public float stepSpeed;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7380C4", Offset = "0x7380C4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7380FC", Offset = "0x7380FC")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738134", Offset = "0x738134")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73816C", Offset = "0x73816C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73816C", Offset = "0x73816C")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7381C4", Offset = "0x7381C4")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7381FC", Offset = "0x7381FC")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738234", Offset = "0x738234")]
			public Vector3 offset;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7382AC", Offset = "0x7382AC")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7382E4", Offset = "0x7382E4")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73831C", Offset = "0x73831C")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x17000075")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x16B1650", Offset = "0x16B1650", VA = "0x16B1650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E9F0", Offset = "0x73E9F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x16B165C", Offset = "0x16B165C", VA = "0x16B165C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA00", Offset = "0x73EA00")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x16B326C", Offset = "0x16B326C", VA = "0x16B326C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x16B32AC", Offset = "0x16B32AC", VA = "0x16B32AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x16B32F0", Offset = "0x16B32F0", VA = "0x16B32F0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x16B3330", Offset = "0x16B3330", VA = "0x16B3330")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x16B1668", Offset = "0x16B1668", VA = "0x16B1668")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x16B1924", Offset = "0x16B1924", VA = "0x16B1924")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x16B1AF4", Offset = "0x16B1AF4", VA = "0x16B1AF4")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x16B1B58", Offset = "0x16B1B58", VA = "0x16B1B58")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x16B1DA0", Offset = "0x16B1DA0", VA = "0x16B1DA0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x16B1E64", Offset = "0x16B1E64", VA = "0x16B1E64")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x16B2FE4", Offset = "0x16B2FE4", VA = "0x16B2FE4")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x16B311C", Offset = "0x16B311C", VA = "0x16B311C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x16B31A0", Offset = "0x16B31A0", VA = "0x16B31A0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x16B3374", Offset = "0x16B3374", VA = "0x16B3374")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73832C", Offset = "0x73832C")]
			public Transform headTarget;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738364", Offset = "0x738364")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73839C", Offset = "0x73839C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73839C", Offset = "0x73839C")]
			public float positionWeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7383F0", Offset = "0x7383F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7383F0", Offset = "0x7383F0")]
			public float rotationWeight;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738444", Offset = "0x738444")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738444", Offset = "0x738444")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738498", Offset = "0x738498")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738498", Offset = "0x738498")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7384EC", Offset = "0x7384EC")]
			public Transform chestGoal;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738524", Offset = "0x738524")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738524", Offset = "0x738524")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738578", Offset = "0x738578")]
			public float minHeadHeight;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7385B0", Offset = "0x7385B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7385B0", Offset = "0x7385B0")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738604", Offset = "0x738604")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738604", Offset = "0x738604")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738658", Offset = "0x738658")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738658", Offset = "0x738658")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x738658", Offset = "0x738658")]
			public float neckStiffness;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7386D0", Offset = "0x7386D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7386D0", Offset = "0x7386D0")]
			public float rotateChestByHands;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738724", Offset = "0x738724")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738724", Offset = "0x738724")]
			public float chestClampWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738778", Offset = "0x738778")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738778", Offset = "0x738778")]
			public float headClampWeight;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7387CC", Offset = "0x7387CC")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738804", Offset = "0x738804")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738804", Offset = "0x738804")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738858", Offset = "0x738858")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738858", Offset = "0x738858")]
			public float maxRootAngle;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7388B0", Offset = "0x7388B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7388B0", Offset = "0x7388B0")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7389EC", Offset = "0x7389EC")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7389FC", Offset = "0x7389FC")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007A")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0x16B2F64", Offset = "0x16B2F64", VA = "0x16B2F64")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x16B346C", Offset = "0x16B346C", VA = "0x16B346C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x16B34AC", Offset = "0x16B34AC", VA = "0x16B34AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x16B3500", Offset = "0x16B3500", VA = "0x16B3500")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x16B2FA4", Offset = "0x16B2FA4", VA = "0x16B2FA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x16B3540", Offset = "0x16B3540", VA = "0x16B3540")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA10", Offset = "0x73EA10")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x16B3554", Offset = "0x16B3554", VA = "0x16B3554")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA20", Offset = "0x73EA20")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x16B3568", Offset = "0x16B3568", VA = "0x16B3568")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA30", Offset = "0x73EA30")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x16B357C", Offset = "0x16B357C", VA = "0x16B357C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA40", Offset = "0x73EA40")]
				private set
				{
				}
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x16B3590", Offset = "0x16B3590", VA = "0x16B3590", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x16B3F9C", Offset = "0x16B3F9C", VA = "0x16B3F9C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x16B41A8", Offset = "0x16B41A8", VA = "0x16B41A8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x16B45F4", Offset = "0x16B45F4", VA = "0x16B45F4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x16B4A30", Offset = "0x16B4A30", VA = "0x16B4A30")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x16B51A0", Offset = "0x16B51A0", VA = "0x16B51A0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x16B5820", Offset = "0x16B5820", VA = "0x16B5820")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x16B5DA4", Offset = "0x16B5DA4", VA = "0x16B5DA4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x16B5F80", Offset = "0x16B5F80", VA = "0x16B5F80", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x16B478C", Offset = "0x16B478C", VA = "0x16B478C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x16B5570", Offset = "0x16B5570", VA = "0x16B5570")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x16B4E48", Offset = "0x16B4E48", VA = "0x16B4E48")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x16B6018", Offset = "0x16B6018", VA = "0x16B6018")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x16B564C", Offset = "0x16B564C", VA = "0x16B564C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x16B531C", Offset = "0x16B531C", VA = "0x16B531C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x16B620C", Offset = "0x16B620C", VA = "0x16B620C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000409")]
			Pelvis,
			[Token(Token = "0x400040A")]
			Chest,
			[Token(Token = "0x400040B")]
			Head,
			[Token(Token = "0x400040C")]
			LeftHand,
			[Token(Token = "0x400040D")]
			RightHand,
			[Token(Token = "0x400040E")]
			LeftFoot,
			[Token(Token = "0x400040F")]
			RightFoot,
			[Token(Token = "0x4000410")]
			LeftHeel,
			[Token(Token = "0x4000411")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000413")]
			Pelvis,
			[Token(Token = "0x4000414")]
			Chest,
			[Token(Token = "0x4000415")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public class VirtualBone
		{
			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x16AC624", Offset = "0x16AC624", VA = "0x16AC624")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x16AC6A0", Offset = "0x16AC6A0", VA = "0x16AC6A0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x16B637C", Offset = "0x16B637C", VA = "0x16B637C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x16AEB94", Offset = "0x16AEB94", VA = "0x16AEB94")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x16AEEC0", Offset = "0x16AEEC0", VA = "0x16AEEC0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x16B6500", Offset = "0x16B6500", VA = "0x16B6500")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x16ADB50", Offset = "0x16ADB50", VA = "0x16ADB50")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x16B6660", Offset = "0x16B6660", VA = "0x16B6660")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x16AE090", Offset = "0x16AE090", VA = "0x16AE090")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x16B6718", Offset = "0x16B6718", VA = "0x16B6718")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x16B5A14", Offset = "0x16B5A14", VA = "0x16B5A14")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x16B6880", Offset = "0x16B6880", VA = "0x16B6880")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x16B68F0", Offset = "0x16B68F0", VA = "0x16B68F0")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737490", Offset = "0x737490")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737490", Offset = "0x737490")]
		public int LOD;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7374E4", Offset = "0x7374E4")]
		public float scale;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73751C", Offset = "0x73751C")]
		public bool plantFeet;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737554", Offset = "0x737554")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737564", Offset = "0x737564")]
		public Spine spine;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73759C", Offset = "0x73759C")]
		public Arm leftArm;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7375D4", Offset = "0x7375D4")]
		public Arm rightArm;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73760C", Offset = "0x73760C")]
		public Leg leftLeg;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737644", Offset = "0x737644")]
		public Leg rightLeg;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73767C", Offset = "0x73767C")]
		public Locomotion locomotion;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Leg[] legs;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Arm[] arms;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headPosition;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Vector3 lastOffset;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3 debugPos1;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000061")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1629CA4", Offset = "0x1629CA4", VA = "0x1629CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E8B0", Offset = "0x73E8B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1629CAC", Offset = "0x1629CAC", VA = "0x1629CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E8C0", Offset = "0x73E8C0")]
			private set
			{
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x16264A8", Offset = "0x16264A8", VA = "0x16264A8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x162690C", Offset = "0x162690C", VA = "0x162690C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x16267B8", Offset = "0x16267B8", VA = "0x16267B8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1626C70", Offset = "0x1626C70", VA = "0x1626C70")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1626DB4", Offset = "0x1626DB4", VA = "0x1626DB4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1626DE4", Offset = "0x1626DE4", VA = "0x1626DE4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1626E94", Offset = "0x1626E94", VA = "0x1626E94")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1626F7C", Offset = "0x1626F7C", VA = "0x1626F7C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x16276E4", Offset = "0x16276E4", VA = "0x16276E4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1627854", Offset = "0x1627854", VA = "0x1627854", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1627A58", Offset = "0x1627A58", VA = "0x1627A58", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1627AD4", Offset = "0x1627AD4", VA = "0x1627AD4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1627B50", Offset = "0x1627B50", VA = "0x1627B50", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1627D28", Offset = "0x1627D28", VA = "0x1627D28")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1626B50", Offset = "0x1626B50", VA = "0x1626B50")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1627070", Offset = "0x1627070", VA = "0x1627070")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1627EE8", Offset = "0x1627EE8", VA = "0x1627EE8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1627F30", Offset = "0x1627F30", VA = "0x1627F30", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x16293D4", Offset = "0x16293D4", VA = "0x16293D4")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x16271D4", Offset = "0x16271D4", VA = "0x16271D4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x16282A4", Offset = "0x16282A4", VA = "0x16282A4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1629784", Offset = "0x1629784", VA = "0x1629784")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x16297CC", Offset = "0x16297CC", VA = "0x16297CC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1629284", Offset = "0x1629284", VA = "0x1629284")]
		private void Write()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1629810", Offset = "0x1629810", VA = "0x1629810")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1629CB4", Offset = "0x1629CB4", VA = "0x1629CB4")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool alreadyRelaxed;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A0C", Offset = "0x738A0C")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x14A0B08", Offset = "0x14A0B08", VA = "0x14A0B08")]
		public void Awake()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x14A10C8", Offset = "0x14A10C8", VA = "0x14A10C8")]
		public void Start()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x14A11E0", Offset = "0x14A11E0", VA = "0x14A11E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x14A12E8", Offset = "0x14A12E8", VA = "0x14A12E8")]
		public void TwistRelaxerUpdate()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x14A1790", Offset = "0x14A1790", VA = "0x14A1790")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x14A18A8", Offset = "0x14A18A8", VA = "0x14A18A8")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class TwistSolver
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A44", Offset = "0x738A44")]
		public Transform transform;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A7C", Offset = "0x738A7C")]
		public Transform parent;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738AB4", Offset = "0x738AB4")]
		public Transform[] children;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738AEC", Offset = "0x738AEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738AEC", Offset = "0x738AEC")]
		public float weight;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738B40", Offset = "0x738B40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738B40", Offset = "0x738B40")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738B94", Offset = "0x738B94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738B94", Offset = "0x738B94")]
		public float twistAngleOffset;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x14A1904", Offset = "0x14A1904", VA = "0x14A1904")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x14A0C04", Offset = "0x14A0C04", VA = "0x14A0C04")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x14A12C0", Offset = "0x14A12C0", VA = "0x14A12C0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x14A13C4", Offset = "0x14A13C4", VA = "0x14A13C4")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionEffector
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738BF0", Offset = "0x738BF0")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C00", Offset = "0x738C00")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C10", Offset = "0x738C10")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x162AA78", Offset = "0x162AA78", VA = "0x162AA78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA50", Offset = "0x73EA50")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x162AA80", Offset = "0x162AA80", VA = "0x162AA80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA60", Offset = "0x73EA60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x162AA88", Offset = "0x162AA88", VA = "0x162AA88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA70", Offset = "0x73EA70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x162AA90", Offset = "0x162AA90", VA = "0x162AA90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA80", Offset = "0x73EA80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x162AA9C", Offset = "0x162AA9C", VA = "0x162AA9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EA90", Offset = "0x73EA90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x162AAA4", Offset = "0x162AAA4", VA = "0x162AAA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EAA0", Offset = "0x73EAA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x162AAAC", Offset = "0x162AAAC", VA = "0x162AAAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x162C280", Offset = "0x162C280", VA = "0x162C280")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x162AB18", Offset = "0x162AB18", VA = "0x162AB18")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x162ABA4", Offset = "0x162ABA4", VA = "0x162ABA4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x162AC38", Offset = "0x162AC38", VA = "0x162AC38")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x162AD94", Offset = "0x162AD94", VA = "0x162AD94")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x162B0D0", Offset = "0x162B0D0", VA = "0x162B0D0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x162B18C", Offset = "0x162B18C", VA = "0x162B18C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x162B1E4", Offset = "0x162B1E4", VA = "0x162B1E4")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x162B614", Offset = "0x162B614", VA = "0x162B614")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x162BC5C", Offset = "0x162BC5C", VA = "0x162BC5C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x162BEA0", Offset = "0x162BEA0", VA = "0x162BEA0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x162C128", Offset = "0x162C128", VA = "0x162C128")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x162C2BC", Offset = "0x162C2BC", VA = "0x162C2BC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738C20", Offset = "0x738C20")]
		public LookAtIK ik;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738C58", Offset = "0x738C58")]
		public float lerpSpeed;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738C90", Offset = "0x738C90")]
		public float weightSpeed;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x162C4E8", Offset = "0x162C4E8", VA = "0x162C4E8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x162C604", Offset = "0x162C604", VA = "0x162C604")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x162C6A8", Offset = "0x162C6A8", VA = "0x162C6A8")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x162C8A0", Offset = "0x162C8A0", VA = "0x162C8A0")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x162C994", Offset = "0x162C994", VA = "0x162C994")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x162CA5C", Offset = "0x162CA5C", VA = "0x162CA5C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734C14", Offset = "0x734C14")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734C14", Offset = "0x734C14")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738DA0", Offset = "0x738DA0")]
			public float time;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738DD8", Offset = "0x738DD8")]
			public bool pause;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738E10", Offset = "0x738E10")]
			public bool pickUp;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738E48", Offset = "0x738E48")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738E80", Offset = "0x738E80")]
			public Message[] messages;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738EB8", Offset = "0x738EB8")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x16B709C", Offset = "0x16B709C", VA = "0x16B709C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x16B7270", Offset = "0x16B7270", VA = "0x16B7270")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Message
		{
			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738EF0", Offset = "0x738EF0")]
			public string function;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738F28", Offset = "0x738F28")]
			public GameObject recipient;

			[Token(Token = "0x400046A")]
			private const string empty = "";

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x16B716C", Offset = "0x16B716C", VA = "0x16B716C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x16B7278", Offset = "0x16B7278", VA = "0x16B7278")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738F60", Offset = "0x738F60")]
			public Animator animator;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738F98", Offset = "0x738F98")]
			public Animation animation;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738FD0", Offset = "0x738FD0")]
			public string animationState;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739008", Offset = "0x739008")]
			public float crossfadeTime;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739040", Offset = "0x739040")]
			public int layer;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739078", Offset = "0x739078")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000471")]
			private const string empty = "";

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x16B6E08", Offset = "0x16B6E08", VA = "0x16B6E08")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x16B6EF8", Offset = "0x16B6EF8", VA = "0x16B6EF8")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x16B6FAC", Offset = "0x16B6FAC", VA = "0x16B6FAC")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x16B7088", Offset = "0x16B7088", VA = "0x16B7088")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000089")]
			public enum Type
			{
				[Token(Token = "0x4000475")]
				PositionWeight,
				[Token(Token = "0x4000476")]
				RotationWeight,
				[Token(Token = "0x4000477")]
				PositionOffsetX,
				[Token(Token = "0x4000478")]
				PositionOffsetY,
				[Token(Token = "0x4000479")]
				PositionOffsetZ,
				[Token(Token = "0x400047A")]
				Pull,
				[Token(Token = "0x400047B")]
				Reach,
				[Token(Token = "0x400047C")]
				RotateBoneWeight,
				[Token(Token = "0x400047D")]
				Push,
				[Token(Token = "0x400047E")]
				PushParent,
				[Token(Token = "0x400047F")]
				PoserWeight,
				[Token(Token = "0x4000480")]
				BendGoalWeight
			}

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7390B0", Offset = "0x7390B0")]
			public Type type;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7390E8", Offset = "0x7390E8")]
			public AnimationCurve curve;

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x16B72BC", Offset = "0x16B72BC", VA = "0x16B72BC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x16B72E8", Offset = "0x16B72E8", VA = "0x16B72E8")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class Multiplier
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739120", Offset = "0x739120")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739158", Offset = "0x739158")]
			public float multiplier;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739190", Offset = "0x739190")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x16B7280", Offset = "0x16B7280", VA = "0x16B7280")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x16B72D8", Offset = "0x16B72D8", VA = "0x16B72D8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738CD8", Offset = "0x738CD8")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738D10", Offset = "0x738D10")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738D48", Offset = "0x738D48")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738D80", Offset = "0x738D80")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738D90", Offset = "0x738D90")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x14F1268", Offset = "0x14F1268", VA = "0x14F1268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC70", Offset = "0x73EC70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x14F1270", Offset = "0x14F1270", VA = "0x14F1270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC80", Offset = "0x73EC80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x14F1278", Offset = "0x14F1278", VA = "0x14F1278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EC90", Offset = "0x73EC90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x14F1280", Offset = "0x14F1280", VA = "0x14F1280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ECA0", Offset = "0x73ECA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x14F14D4", Offset = "0x14F14D4", VA = "0x14F14D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x14F1448", Offset = "0x14F1448", VA = "0x14F1448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x14F1028", Offset = "0x14F1028", VA = "0x14F1028")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EAB0", Offset = "0x73EAB0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x14F1070", Offset = "0x14F1070", VA = "0x14F1070")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EAE8", Offset = "0x73EAE8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x14F10B8", Offset = "0x14F10B8", VA = "0x14F10B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EB20", Offset = "0x73EB20")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x14F1100", Offset = "0x14F1100", VA = "0x14F1100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EB58", Offset = "0x73EB58")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x14F1148", Offset = "0x14F1148", VA = "0x14F1148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EB90", Offset = "0x73EB90")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x14F1190", Offset = "0x14F1190", VA = "0x14F1190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EBC8", Offset = "0x73EBC8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x14F11D8", Offset = "0x14F11D8", VA = "0x14F11D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EC00", Offset = "0x73EC00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x14F1220", Offset = "0x14F1220", VA = "0x14F1220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EC38", Offset = "0x73EC38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x14F1288", Offset = "0x14F1288", VA = "0x14F1288")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x14F1560", Offset = "0x14F1560", VA = "0x14F1560")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x14F16CC", Offset = "0x14F16CC", VA = "0x14F16CC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x14F1780", Offset = "0x14F1780", VA = "0x14F1780")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x14F1788", Offset = "0x14F1788", VA = "0x14F1788")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x14F193C", Offset = "0x14F193C", VA = "0x14F193C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x14F1944", Offset = "0x14F1944", VA = "0x14F1944")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x14F230C", Offset = "0x14F230C", VA = "0x14F230C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x14F252C", Offset = "0x14F252C", VA = "0x14F252C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x14F1E10", Offset = "0x14F1E10", VA = "0x14F1E10")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x14F18CC", Offset = "0x14F18CC", VA = "0x14F18CC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x14F22A4", Offset = "0x14F22A4", VA = "0x14F22A4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x14F2530", Offset = "0x14F2530", VA = "0x14F2530")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x14F2598", Offset = "0x14F2598", VA = "0x14F2598")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734C74", Offset = "0x734C74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734C74", Offset = "0x734C74")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7391C8", Offset = "0x7391C8")]
		public string targetTag;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739200", Offset = "0x739200")]
		public float fadeInTime;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739238", Offset = "0x739238")]
		public float speed;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739270", Offset = "0x739270")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7392A8", Offset = "0x7392A8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7392A8", Offset = "0x7392A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7392A8", Offset = "0x7392A8")]
		public Collider characterCollider;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x73932C", Offset = "0x73932C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73932C", Offset = "0x73932C")]
		public Transform FPSCamera;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73938C", Offset = "0x73938C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7393C4", Offset = "0x7393C4")]
		public float camRaycastDistance;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7393FC", Offset = "0x7393FC")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73940C", Offset = "0x73940C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x73940C", Offset = "0x73940C")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73946C", Offset = "0x73946C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7394A4", Offset = "0x7394A4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x14F2834", Offset = "0x14F2834", VA = "0x14F2834")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x14F44D8", Offset = "0x14F44D8", VA = "0x14F44D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x14F44E0", Offset = "0x14F44E0", VA = "0x14F44E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x14F44E8", Offset = "0x14F44E8", VA = "0x14F44E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EE70", Offset = "0x73EE70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x14F44F0", Offset = "0x14F44F0", VA = "0x14F44F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EE80", Offset = "0x73EE80")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x14F44F8", Offset = "0x14F44F8", VA = "0x14F44F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EE90", Offset = "0x73EE90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x14F4500", Offset = "0x14F4500", VA = "0x14F4500")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EEA0", Offset = "0x73EEA0")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x14F25F4", Offset = "0x14F25F4", VA = "0x14F25F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ECB0", Offset = "0x73ECB0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x14F263C", Offset = "0x14F263C", VA = "0x14F263C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ECE8", Offset = "0x73ECE8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x14F2684", Offset = "0x14F2684", VA = "0x14F2684")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ED20", Offset = "0x73ED20")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x14F26CC", Offset = "0x14F26CC", VA = "0x14F26CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ED58", Offset = "0x73ED58")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x14F2714", Offset = "0x14F2714", VA = "0x14F2714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ED90", Offset = "0x73ED90")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x14F275C", Offset = "0x14F275C", VA = "0x14F275C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EDC8", Offset = "0x73EDC8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x14F27A4", Offset = "0x14F27A4", VA = "0x14F27A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE00", Offset = "0x73EE00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x14F27EC", Offset = "0x14F27EC", VA = "0x14F27EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EE38", Offset = "0x73EE38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x14F29DC", Offset = "0x14F29DC", VA = "0x14F29DC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x14F2AAC", Offset = "0x14F2AAC", VA = "0x14F2AAC")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x14F2B7C", Offset = "0x14F2B7C", VA = "0x14F2B7C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x14F2C2C", Offset = "0x14F2C2C", VA = "0x14F2C2C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x14F2D28", Offset = "0x14F2D28", VA = "0x14F2D28")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x14F2E44", Offset = "0x14F2E44", VA = "0x14F2E44")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x14F2ED8", Offset = "0x14F2ED8", VA = "0x14F2ED8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x14F2F6C", Offset = "0x14F2F6C", VA = "0x14F2F6C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x14F3000", Offset = "0x14F3000", VA = "0x14F3000")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x14F3078", Offset = "0x14F3078", VA = "0x14F3078")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x14F30F0", Offset = "0x14F30F0", VA = "0x14F30F0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x14F315C", Offset = "0x14F315C", VA = "0x14F315C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x14F31E8", Offset = "0x14F31E8", VA = "0x14F31E8")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x14F327C", Offset = "0x14F327C", VA = "0x14F327C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x14F3348", Offset = "0x14F3348", VA = "0x14F3348")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x14F3620", Offset = "0x14F3620", VA = "0x14F3620")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x14F3800", Offset = "0x14F3800", VA = "0x14F3800")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x14F3A94", Offset = "0x14F3A94", VA = "0x14F3A94")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x14F3D6C", Offset = "0x14F3D6C", VA = "0x14F3D6C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x14F3DB0", Offset = "0x14F3DB0", VA = "0x14F3DB0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x14F3E28", Offset = "0x14F3E28", VA = "0x14F3E28")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x14F3F44", Offset = "0x14F3F44", VA = "0x14F3F44")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x14F40E8", Offset = "0x14F40E8", VA = "0x14F40E8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x14F438C", Offset = "0x14F438C", VA = "0x14F438C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x14F3BA8", Offset = "0x14F3BA8", VA = "0x14F3BA8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x14F450C", Offset = "0x14F450C", VA = "0x14F450C")]
		public void Start()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x14F4C7C", Offset = "0x14F4C7C", VA = "0x14F4C7C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x14F4C9C", Offset = "0x14F4C9C", VA = "0x14F4C9C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x14F4CB8", Offset = "0x14F4CB8", VA = "0x14F4CB8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x14F4CD4", Offset = "0x14F4CD4", VA = "0x14F4CD4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x14F4D38", Offset = "0x14F4D38", VA = "0x14F4D38")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x14F4E74", Offset = "0x14F4E74", VA = "0x14F4E74")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x14F4F84", Offset = "0x14F4F84", VA = "0x14F4F84")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x14F5328", Offset = "0x14F5328", VA = "0x14F5328")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x14F5428", Offset = "0x14F5428", VA = "0x14F5428")]
		public void Update()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x14F5688", Offset = "0x14F5688", VA = "0x14F5688")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x14F49E0", Offset = "0x14F49E0", VA = "0x14F49E0")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x14F57C4", Offset = "0x14F57C4", VA = "0x14F57C4")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x14F58F4", Offset = "0x14F58F4", VA = "0x14F58F4")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x14F598C", Offset = "0x14F598C", VA = "0x14F598C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x14F5A68", Offset = "0x14F5A68", VA = "0x14F5A68")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x14F5A84", Offset = "0x14F5A84", VA = "0x14F5A84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x14F28E4", Offset = "0x14F28E4", VA = "0x14F28E4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x14F34F0", Offset = "0x14F34F0", VA = "0x14F34F0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x14F5DEC", Offset = "0x14F5DEC", VA = "0x14F5DEC")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734CD4", Offset = "0x734CD4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734CD4", Offset = "0x734CD4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public enum RotationMode
		{
			[Token(Token = "0x40004A9")]
			TwoDOF,
			[Token(Token = "0x40004AA")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class Multiplier
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739700", Offset = "0x739700")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739738", Offset = "0x739738")]
			public float multiplier;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x16B7954", Offset = "0x16B7954", VA = "0x16B7954")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7394B4", Offset = "0x7394B4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7394EC", Offset = "0x7394EC")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739524", Offset = "0x739524")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73955C", Offset = "0x73955C")]
		public Transform pivot;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739594", Offset = "0x739594")]
		public RotationMode rotationMode;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7395CC", Offset = "0x7395CC")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739604", Offset = "0x739604")]
		public float twistWeight;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73963C", Offset = "0x73963C")]
		public float swingWeight;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739674", Offset = "0x739674")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739674", Offset = "0x739674")]
		public float threeDOFWeight;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7396C8", Offset = "0x7396C8")]
		public bool rotateOnce;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x14F653C", Offset = "0x14F653C", VA = "0x14F653C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EEB0", Offset = "0x73EEB0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x14F6584", Offset = "0x14F6584", VA = "0x14F6584")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EEE8", Offset = "0x73EEE8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x14F65CC", Offset = "0x14F65CC", VA = "0x14F65CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EF20", Offset = "0x73EF20")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x14F6614", Offset = "0x14F6614", VA = "0x14F6614")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EF58", Offset = "0x73EF58")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x14F665C", Offset = "0x14F665C", VA = "0x14F665C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EF90", Offset = "0x73EF90")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x14F66A4", Offset = "0x14F66A4", VA = "0x14F66A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73EFC8", Offset = "0x73EFC8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x14F66EC", Offset = "0x14F66EC", VA = "0x14F66EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F000", Offset = "0x73F000")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x14F6734", Offset = "0x14F6734", VA = "0x14F6734")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F038", Offset = "0x73F038")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x14F1DA0", Offset = "0x14F1DA0", VA = "0x14F1DA0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x14F677C", Offset = "0x14F677C", VA = "0x14F677C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x14F6814", Offset = "0x14F6814", VA = "0x14F6814")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x14F6EDC", Offset = "0x14F6EDC", VA = "0x14F6EDC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734D34", Offset = "0x734D34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734D34", Offset = "0x734D34")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7397A8", Offset = "0x7397A8")]
			public bool use;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7397E0", Offset = "0x7397E0")]
			public Vector2 offset;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739818", Offset = "0x739818")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739818", Offset = "0x739818")]
			public float angleOffset;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739874", Offset = "0x739874")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739874", Offset = "0x739874")]
			public float maxAngle;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7398CC", Offset = "0x7398CC")]
			public float radius;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739904", Offset = "0x739904")]
			public bool orbit;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73993C", Offset = "0x73993C")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600054B")]
				[Address(RVA = "0x16B7CC4", Offset = "0x16B7CC4", VA = "0x16B7CC4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600054C")]
				[Address(RVA = "0x16B7CD0", Offset = "0x16B7CD0", VA = "0x16B7CD0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x16B7D58", Offset = "0x16B7D58", VA = "0x16B7D58")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x16B819C", Offset = "0x16B819C", VA = "0x16B819C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class CameraPosition
		{
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739974", Offset = "0x739974")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7399AC", Offset = "0x7399AC")]
			public Vector3 direction;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7399E4", Offset = "0x7399E4")]
			public float maxDistance;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739A1C", Offset = "0x739A1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739A1C", Offset = "0x739A1C")]
			public float maxAngle;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739A74", Offset = "0x739A74")]
			public bool fixYAxis;

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x16B795C", Offset = "0x16B795C", VA = "0x16B795C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x16B7A50", Offset = "0x16B7A50", VA = "0x16B7A50")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x16B7C78", Offset = "0x16B7C78", VA = "0x16B7C78")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000095")]
			public class Interaction
			{
				[Token(Token = "0x40004BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739B74", Offset = "0x739B74")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739BAC", Offset = "0x739BAC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000554")]
				[Address(RVA = "0x17BAD7C", Offset = "0x17BAD7C", VA = "0x17BAD7C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739ACC", Offset = "0x739ACC")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739B04", Offset = "0x739B04")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739B3C", Offset = "0x739B3C")]
			public Interaction[] interactions;

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x16B81B0", Offset = "0x16B81B0", VA = "0x16B81B0")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x16B8264", Offset = "0x16B8264", VA = "0x16B8264")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739770", Offset = "0x739770")]
		public Range[] ranges;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x14F6F28", Offset = "0x14F6F28", VA = "0x14F6F28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F070", Offset = "0x73F070")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x14F6F70", Offset = "0x14F6F70", VA = "0x14F6F70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F0A8", Offset = "0x73F0A8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x14F6FB8", Offset = "0x14F6FB8", VA = "0x14F6FB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F0E0", Offset = "0x73F0E0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x14F7000", Offset = "0x14F7000", VA = "0x14F7000")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F118", Offset = "0x73F118")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x14F7048", Offset = "0x14F7048", VA = "0x14F7048")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F150", Offset = "0x73F150")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x14F5154", Offset = "0x14F5154", VA = "0x14F5154")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x14F7090", Offset = "0x14F7090", VA = "0x14F7090")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public class Map
		{
			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x14A9A90", Offset = "0x14A9A90", VA = "0x14A9A90")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x14A9ACC", Offset = "0x14A9ACC", VA = "0x14A9ACC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0x14A9B1C", Offset = "0x14A9B1C", VA = "0x14A9B1C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0x14A9B68", Offset = "0x14A9B68", VA = "0x14A9B68")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x15E2180", Offset = "0x15E2180", VA = "0x15E2180", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F188", Offset = "0x73F188")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x15E24FC", Offset = "0x15E24FC", VA = "0x15E24FC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x15E2500", Offset = "0x15E2500", VA = "0x15E2500", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x15E2608", Offset = "0x15E2608", VA = "0x15E2608", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x15E2490", Offset = "0x15E2490", VA = "0x15E2490")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x15E23F0", Offset = "0x15E23F0", VA = "0x15E23F0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x15E2674", Offset = "0x15E2674", VA = "0x15E2674")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x162F3E4", Offset = "0x162F3E4", VA = "0x162F3E4", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x162F4AC", Offset = "0x162F4AC", VA = "0x162F4AC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x162F668", Offset = "0x162F668", VA = "0x162F668", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x162F764", Offset = "0x162F764", VA = "0x162F764", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x162F504", Offset = "0x162F504", VA = "0x162F504")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x162FAC4", Offset = "0x162FAC4", VA = "0x162FAC4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739BE4", Offset = "0x739BE4")]
		public float weight;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739BFC", Offset = "0x739BFC")]
		public float localRotationWeight;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739C14", Offset = "0x739C14")]
		public float localPositionWeight;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000566")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x14FE8C4", Offset = "0x14FE8C4", VA = "0x14FE8C4")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000568")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000569")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x600056A")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x14FE8D0", Offset = "0x14FE8D0", VA = "0x14FE8D0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x14FE924", Offset = "0x14FE924", VA = "0x14FE924", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x14FE960", Offset = "0x14FE960", VA = "0x14FE960", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x14FE978", Offset = "0x14FE978", VA = "0x14FE978")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public class Rigidbone
		{
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x16BA1BC", Offset = "0x16BA1BC", VA = "0x16BA1BC")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x16BA32C", Offset = "0x16BA32C", VA = "0x16BA32C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x16BA40C", Offset = "0x16BA40C", VA = "0x16BA40C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009C")]
		public class Child
		{
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x16B9FCC", Offset = "0x16B9FCC", VA = "0x16B9FCC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x16BA02C", Offset = "0x16BA02C", VA = "0x16BA02C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x16BA16C", Offset = "0x16BA16C", VA = "0x16BA16C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734D94", Offset = "0x734D94")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600058A")]
				[Address(RVA = "0x16B9F7C", Offset = "0x16B9F7C", VA = "0x16B9F7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600058C")]
				[Address(RVA = "0x16B9FC4", Offset = "0x16B9FC4", VA = "0x16B9FC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x16B9D60", Offset = "0x16B9D60", VA = "0x16B9D60")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x16B9D8C", Offset = "0x16B9D8C", VA = "0x16B9D8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x16B9D90", Offset = "0x16B9D90", VA = "0x16B9D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x16B9F84", Offset = "0x16B9F84", VA = "0x16B9F84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739C2C", Offset = "0x739C2C")]
		public IK ik;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739C64", Offset = "0x739C64")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739C9C", Offset = "0x739C9C")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739CD4", Offset = "0x739CD4")]
		public float applyVelocity;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739D0C", Offset = "0x739D0C")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000090")]
		private bool isRagdoll
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x14FF64C", Offset = "0x14FF64C", VA = "0x14FF64C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x14FFFD4", Offset = "0x14FFFD4", VA = "0x14FFFD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x14FF614", Offset = "0x14FF614", VA = "0x14FF614")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x14FF6C4", Offset = "0x14FF6C4", VA = "0x14FF6C4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x14FF7F4", Offset = "0x14FF7F4", VA = "0x14FF7F4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x14FF788", Offset = "0x14FF788", VA = "0x14FF788")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F1C0", Offset = "0x73F1C0")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x14FFC10", Offset = "0x14FFC10", VA = "0x14FFC10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x14FFE5C", Offset = "0x14FFE5C", VA = "0x14FFE5C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x14FFF18", Offset = "0x14FFF18", VA = "0x14FFF18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1500154", Offset = "0x1500154", VA = "0x1500154")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x14FFF98", Offset = "0x14FFF98", VA = "0x14FFF98")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1500110", Offset = "0x1500110", VA = "0x1500110")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x15001F4", Offset = "0x15001F4", VA = "0x15001F4")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1500188", Offset = "0x1500188", VA = "0x1500188")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x14FF71C", Offset = "0x14FF71C", VA = "0x14FF71C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x14FFE9C", Offset = "0x14FFE9C", VA = "0x14FFE9C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1500420", Offset = "0x1500420", VA = "0x1500420")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1500538", Offset = "0x1500538", VA = "0x1500538")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739D54", Offset = "0x739D54")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000094")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1501C54", Offset = "0x1501C54", VA = "0x1501C54")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1501C60", Offset = "0x1501C60", VA = "0x1501C60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1501C7C", Offset = "0x1501C7C", VA = "0x1501C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F270", Offset = "0x73F270")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1501C84", Offset = "0x1501C84", VA = "0x1501C84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F280", Offset = "0x73F280")]
			private set
			{
			}
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1501954", Offset = "0x1501954", VA = "0x1501954")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x150199C", Offset = "0x150199C", VA = "0x150199C")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x15019B4", Offset = "0x15019B4", VA = "0x15019B4")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1501BAC", Offset = "0x1501BAC", VA = "0x1501BAC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1501C1C", Offset = "0x1501C1C", VA = "0x1501C1C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000596")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1501AD4", Offset = "0x1501AD4", VA = "0x1501AD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1501C90", Offset = "0x1501C90", VA = "0x1501C90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1501C94", Offset = "0x1501C94", VA = "0x1501C94")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1501CC8", Offset = "0x1501CC8", VA = "0x1501CC8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1501D44", Offset = "0x1501D44", VA = "0x1501D44")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1501ED8", Offset = "0x1501ED8", VA = "0x1501ED8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1501F48", Offset = "0x1501F48", VA = "0x1501F48")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734DA4", Offset = "0x734DA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734DA4", Offset = "0x734DA4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739D64", Offset = "0x739D64")]
		public float limit;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739D80", Offset = "0x739D80")]
		public float twistLimit;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1501F7C", Offset = "0x1501F7C", VA = "0x1501F7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F290", Offset = "0x73F290")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1501FC4", Offset = "0x1501FC4", VA = "0x1501FC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F2C8", Offset = "0x73F2C8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x150200C", Offset = "0x150200C", VA = "0x150200C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F300", Offset = "0x73F300")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1502054", Offset = "0x1502054", VA = "0x1502054")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F338", Offset = "0x73F338")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x150209C", Offset = "0x150209C", VA = "0x150209C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x15020E0", Offset = "0x15020E0", VA = "0x15020E0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x15022A0", Offset = "0x15022A0", VA = "0x15022A0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734E04", Offset = "0x734E04")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734E04", Offset = "0x734E04")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x15022E0", Offset = "0x15022E0", VA = "0x15022E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F370", Offset = "0x73F370")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1502328", Offset = "0x1502328", VA = "0x1502328")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F3A8", Offset = "0x73F3A8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1502370", Offset = "0x1502370", VA = "0x1502370")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F3E0", Offset = "0x73F3E0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x15023B8", Offset = "0x15023B8", VA = "0x15023B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F418", Offset = "0x73F418")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1502400", Offset = "0x1502400", VA = "0x1502400", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1502404", Offset = "0x1502404", VA = "0x1502404")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1502588", Offset = "0x1502588", VA = "0x1502588")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734E64", Offset = "0x734E64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734E64", Offset = "0x734E64")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class ReachCone
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000097")]
			public Vector3 o
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x16BAA40", Offset = "0x16BAA40", VA = "0x16BAA40")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x16BAA78", Offset = "0x16BAA78", VA = "0x16BAA78")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x16BAAB4", Offset = "0x16BAAB4", VA = "0x16BAAB4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x16BAAF0", Offset = "0x16BAAF0", VA = "0x16BAAF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x16BAC68", Offset = "0x16BAC68", VA = "0x16BAC68")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x16BAB2C", Offset = "0x16BAB2C", VA = "0x16BAB2C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x16BAC78", Offset = "0x16BAC78", VA = "0x16BAC78")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class LimitPoint
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x16BAA04", Offset = "0x16BAA04", VA = "0x16BAA04")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739DAC", Offset = "0x739DAC")]
		public float twistLimit;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739DC8", Offset = "0x739DC8")]
		public int smoothIterations;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x15025D0", Offset = "0x15025D0", VA = "0x15025D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F450", Offset = "0x73F450")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1502618", Offset = "0x1502618", VA = "0x1502618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F488", Offset = "0x73F488")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1502660", Offset = "0x1502660", VA = "0x1502660")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F4C0", Offset = "0x73F4C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x15026A8", Offset = "0x15026A8", VA = "0x15026A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F4F8", Offset = "0x73F4F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x15026F0", Offset = "0x15026F0", VA = "0x15026F0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1502B90", Offset = "0x1502B90", VA = "0x1502B90", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1502C24", Offset = "0x1502C24", VA = "0x1502C24")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1503150", Offset = "0x1503150", VA = "0x1503150")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x150278C", Offset = "0x150278C", VA = "0x150278C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x15034D0", Offset = "0x15034D0", VA = "0x15034D0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x15038DC", Offset = "0x15038DC", VA = "0x15038DC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1503920", Offset = "0x1503920", VA = "0x1503920")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1503980", Offset = "0x1503980", VA = "0x1503980")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1502EE0", Offset = "0x1502EE0", VA = "0x1502EE0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x15039EC", Offset = "0x15039EC", VA = "0x15039EC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1503AC8", Offset = "0x1503AC8", VA = "0x1503AC8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x734EC4", Offset = "0x734EC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x734EC4", Offset = "0x734EC4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739E10", Offset = "0x739E10")]
		public float twistLimit;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x149DF54", Offset = "0x149DF54", VA = "0x149DF54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F530", Offset = "0x73F530")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x149DF9C", Offset = "0x149DF9C", VA = "0x149DF9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F568", Offset = "0x73F568")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x149DFE4", Offset = "0x149DFE4", VA = "0x149DFE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F5A0", Offset = "0x73F5A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x149E02C", Offset = "0x149E02C", VA = "0x149E02C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73F5D8", Offset = "0x73F5D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x149E074", Offset = "0x149E074", VA = "0x149E074")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x149E090", Offset = "0x149E090", VA = "0x149E090", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x149E130", Offset = "0x149E130", VA = "0x149E130")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x149E36C", Offset = "0x149E36C", VA = "0x149E36C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734F24", Offset = "0x734F24")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x14A8BC8", Offset = "0x14A8BC8", VA = "0x14A8BC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x14A8C10", Offset = "0x14A8C10", VA = "0x14A8C10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x14A8AD8", Offset = "0x14A8AD8", VA = "0x14A8AD8")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x14A8B04", Offset = "0x14A8B04", VA = "0x14A8B04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x14A8B08", Offset = "0x14A8B08", VA = "0x14A8B08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x14A8BD0", Offset = "0x14A8BD0", VA = "0x14A8BD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739E3C", Offset = "0x739E3C")]
		public AimIK ik;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x739E74", Offset = "0x739E74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739E74", Offset = "0x739E74")]
		public float weight;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739EC8", Offset = "0x739EC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739EC8", Offset = "0x739EC8")]
		public Transform target;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F28", Offset = "0x739F28")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F60", Offset = "0x739F60")]
		public float weightSmoothTime;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x739F98", Offset = "0x739F98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739F98", Offset = "0x739F98")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x739FF8", Offset = "0x739FF8")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A030", Offset = "0x73A030")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A068", Offset = "0x73A068")]
		public float slerpSpeed;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A0A0", Offset = "0x73A0A0")]
		public float smoothDampTime;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A0D8", Offset = "0x73A0D8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A110", Offset = "0x73A110")]
		public float minDistance;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A148", Offset = "0x73A148")]
		public Vector3 offset;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73A180", Offset = "0x73A180")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A180", Offset = "0x73A180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A180", Offset = "0x73A180")]
		public float maxRootAngle;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A1FC", Offset = "0x73A1FC")]
		public bool turnToTarget;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A234", Offset = "0x73A234")]
		public float turnToTargetTime;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A26C", Offset = "0x73A26C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73A26C", Offset = "0x73A26C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A2CC", Offset = "0x73A2CC")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700009C")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x15AD8C0", Offset = "0x15AD8C0", VA = "0x15AD8C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x15AD838", Offset = "0x15AD838", VA = "0x15AD838")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x15AD950", Offset = "0x15AD950", VA = "0x15AD950")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x15AE024", Offset = "0x15AE024", VA = "0x15AE024")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x15AE110", Offset = "0x15AE110", VA = "0x15AE110")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x15AE360", Offset = "0x15AE360", VA = "0x15AE360")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F610", Offset = "0x73F610")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x15AE3CC", Offset = "0x15AE3CC", VA = "0x15AE3CC")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A8")]
		public class Pose
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x14A8C18", Offset = "0x14A8C18", VA = "0x14A8C18")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x14A8DA4", Offset = "0x14A8DA4", VA = "0x14A8DA4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x14A8DAC", Offset = "0x14A8DAC", VA = "0x14A8DAC")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x15AE630", Offset = "0x15AE630", VA = "0x15AE630")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x15AE710", Offset = "0x15AE710", VA = "0x15AE710")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x15AE77C", Offset = "0x15AE77C", VA = "0x15AE77C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000AB")]
			public class EffectorLink
			{
				[Token(Token = "0x400053F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A48C", Offset = "0x73A48C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000540")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A4C4", Offset = "0x73A4C4")]
				public float weight;

				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x17BA960", Offset = "0x17BA960", VA = "0x17BA960")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A33C", Offset = "0x73A33C")]
			public Transform transform;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A374", Offset = "0x73A374")]
			public Transform relativeTo;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A3AC", Offset = "0x73A3AC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A3E4", Offset = "0x73A3E4")]
			public float verticalWeight;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A41C", Offset = "0x73A41C")]
			public float horizontalWeight;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A454", Offset = "0x73A454")]
			public float speed;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x14A8DC8", Offset = "0x14A8DC8", VA = "0x14A8DC8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x14A90EC", Offset = "0x14A90EC", VA = "0x14A90EC")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x14A90FC", Offset = "0x14A90FC", VA = "0x14A90FC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A304", Offset = "0x73A304")]
		public Body[] bodies;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x15AE88C", Offset = "0x15AE88C", VA = "0x15AE88C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x15AE9D8", Offset = "0x15AE9D8", VA = "0x15AE9D8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A4FC", Offset = "0x73A4FC")]
		public float tiltSpeed;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A534", Offset = "0x73A534")]
		public float tiltSensitivity;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A56C", Offset = "0x73A56C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A5A4", Offset = "0x73A5A4")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x15BBD30", Offset = "0x15BBD30", VA = "0x15BBD30", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x15BBD78", Offset = "0x15BBD78", VA = "0x15BBD78", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x15BBF30", Offset = "0x15BBF30", VA = "0x15BBF30")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A5DC", Offset = "0x73A5DC")]
		public float weight;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x15BBF44", Offset = "0x15BBF44", VA = "0x15BBF44")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x15BC00C", Offset = "0x15BC00C", VA = "0x15BC00C")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x15BC234", Offset = "0x15BC234", VA = "0x15BC234")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x15BC340", Offset = "0x15BC340", VA = "0x15BC340")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A5F4", Offset = "0x73A5F4")]
		public Animator animator;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A62C", Offset = "0x73A62C")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A674", Offset = "0x73A674")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700009F")]
		public IK ik
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x15D6CEC", Offset = "0x15D6CEC", VA = "0x15D6CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F6C0", Offset = "0x73F6C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x15D6CF4", Offset = "0x15D6CF4", VA = "0x15D6CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F6D0", Offset = "0x73F6D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x15D6CFC", Offset = "0x15D6CFC", VA = "0x15D6CFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x15D6E98", Offset = "0x15D6E98", VA = "0x15D6E98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x15D7124", Offset = "0x15D7124", VA = "0x15D7124")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x15D726C", Offset = "0x15D726C", VA = "0x15D726C")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x15D7438", Offset = "0x15D7438", VA = "0x15D7438")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x15D7668", Offset = "0x15D7668", VA = "0x15D7668")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x15D7904", Offset = "0x15D7904", VA = "0x15D7904")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x734F44", Offset = "0x734F44")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000A0")]
		public bool poseStored
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x15D6F90", Offset = "0x15D6F90", VA = "0x15D6F90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x15D72E4", Offset = "0x15D72E4", VA = "0x15D72E4")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x15D6FB4", Offset = "0x15D6FB4", VA = "0x15D6FB4")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x15D7960", Offset = "0x15D7960", VA = "0x15D7960")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A6F4", Offset = "0x73A6F4")]
			public string name;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A72C", Offset = "0x73A72C")]
			public Collider collider;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A764", Offset = "0x73A764")]
			private float crossFadeTime;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7B0", Offset = "0x73A7B0")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7C0", Offset = "0x73A7C0")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7D0", Offset = "0x73A7D0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A7E0", Offset = "0x73A7E0")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A2")]
			public bool inProgress
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x14AB7B4", Offset = "0x14AB7B4", VA = "0x14AB7B4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A3")]
			protected float crossFader
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x14AB7C8", Offset = "0x14AB7C8", VA = "0x14AB7C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F6E0", Offset = "0x73F6E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x14AB7D0", Offset = "0x14AB7D0", VA = "0x14AB7D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F6F0", Offset = "0x73F6F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected float timer
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x14AB7D8", Offset = "0x14AB7D8", VA = "0x14AB7D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F700", Offset = "0x73F700")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x14AB7E0", Offset = "0x14AB7E0", VA = "0x14AB7E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F710", Offset = "0x73F710")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected Vector3 force
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x14AB7E8", Offset = "0x14AB7E8", VA = "0x14AB7E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F720", Offset = "0x73F720")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x14AB7F4", Offset = "0x14AB7F4", VA = "0x14AB7F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F730", Offset = "0x73F730")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x14AB800", Offset = "0x14AB800", VA = "0x14AB800")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F740", Offset = "0x73F740")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000605")]
				[Address(RVA = "0x14AB80C", Offset = "0x14AB80C", VA = "0x14AB80C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F750", Offset = "0x73F750")]
				private set
				{
				}
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x14AB818", Offset = "0x14AB818", VA = "0x14AB818")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x14AB94C", Offset = "0x14AB94C", VA = "0x14AB94C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000608")]
			protected abstract float GetLength();

			[Token(Token = "0x6000609")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600060A")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x14ABA20", Offset = "0x14ABA20", VA = "0x14ABA20")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B3")]
			public class EffectorLink
			{
				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A898", Offset = "0x73A898")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A8D0", Offset = "0x73A8D0")]
				public float weight;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000561")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x17BAAD0", Offset = "0x17BAAD0", VA = "0x17BAAD0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x17BAB80", Offset = "0x17BAB80", VA = "0x17BAB80")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000612")]
				[Address(RVA = "0x17BAB94", Offset = "0x17BAB94", VA = "0x17BAB94")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A7F0", Offset = "0x73A7F0")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A828", Offset = "0x73A828")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A860", Offset = "0x73A860")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x14ABD4C", Offset = "0x14ABD4C", VA = "0x14ABD4C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x14ABE7C", Offset = "0x14ABE7C", VA = "0x14ABE7C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x14ABEE8", Offset = "0x14ABEE8", VA = "0x14ABEE8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x14AC050", Offset = "0x14AC050", VA = "0x14AC050")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B5")]
			public class BoneLink
			{
				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A978", Offset = "0x73A978")]
				public Transform bone;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A9B0", Offset = "0x73A9B0")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73A9B0", Offset = "0x73A9B0")]
				public float weight;

				[Token(Token = "0x4000567")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000568")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000617")]
				[Address(RVA = "0x17BA968", Offset = "0x17BA968", VA = "0x17BA968")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000618")]
				[Address(RVA = "0x17BAA80", Offset = "0x17BAA80", VA = "0x17BAA80")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000619")]
				[Address(RVA = "0x17BAA8C", Offset = "0x17BAA8C", VA = "0x17BAA8C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A908", Offset = "0x73A908")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A940", Offset = "0x73A940")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x14ABA34", Offset = "0x14ABA34", VA = "0x14ABA34", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x14ABAD8", Offset = "0x14ABAD8", VA = "0x14ABAD8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x14ABB44", Offset = "0x14ABB44", VA = "0x14ABB44", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x14ABD38", Offset = "0x14ABD38", VA = "0x14ABD38")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A684", Offset = "0x73A684")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73A6BC", Offset = "0x73A6BC")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A1")]
		public bool inProgress
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1630964", Offset = "0x1630964", VA = "0x1630964")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1630A34", Offset = "0x1630A34", VA = "0x1630A34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1630B10", Offset = "0x1630B10", VA = "0x1630B10")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1630D6C", Offset = "0x1630D6C", VA = "0x1630D6C")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public abstract class Offset
		{
			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AA74", Offset = "0x73AA74")]
			public string name;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AAAC", Offset = "0x73AAAC")]
			public Collider collider;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AAE4", Offset = "0x73AAE4")]
			private float crossFadeTime;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AB30", Offset = "0x73AB30")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AB40", Offset = "0x73AB40")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AB50", Offset = "0x73AB50")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AB60", Offset = "0x73AB60")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A7")]
			protected float crossFader
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x14AC064", Offset = "0x14AC064", VA = "0x14AC064")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F760", Offset = "0x73F760")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x14AC06C", Offset = "0x14AC06C", VA = "0x14AC06C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F770", Offset = "0x73F770")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected float timer
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x14AC074", Offset = "0x14AC074", VA = "0x14AC074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F780", Offset = "0x73F780")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x14AC07C", Offset = "0x14AC07C", VA = "0x14AC07C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F790", Offset = "0x73F790")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 force
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x14AC084", Offset = "0x14AC084", VA = "0x14AC084")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7A0", Offset = "0x73F7A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x14AC090", Offset = "0x14AC090", VA = "0x14AC090")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7B0", Offset = "0x73F7B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected Vector3 point
			{
				[Token(Token = "0x6000623")]
				[Address(RVA = "0x14AC09C", Offset = "0x14AC09C", VA = "0x14AC09C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7C0", Offset = "0x73F7C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x14AC0A8", Offset = "0x14AC0A8", VA = "0x14AC0A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F7D0", Offset = "0x73F7D0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x14AC0B4", Offset = "0x14AC0B4", VA = "0x14AC0B4")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x14AC1FC", Offset = "0x14AC1FC", VA = "0x14AC1FC")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000627")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000628")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000629")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x14AC2E4", Offset = "0x14AC2E4", VA = "0x14AC2E4")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B8")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B9")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AC18", Offset = "0x73AC18")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400057A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AC50", Offset = "0x73AC50")]
				public float weight;

				[Token(Token = "0x400057B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400057C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600062F")]
				[Address(RVA = "0x17BAB9C", Offset = "0x17BAB9C", VA = "0x17BAB9C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000630")]
				[Address(RVA = "0x17BAC2C", Offset = "0x17BAC2C", VA = "0x17BAC2C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000631")]
				[Address(RVA = "0x17BAC40", Offset = "0x17BAC40", VA = "0x17BAC40")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AB70", Offset = "0x73AB70")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ABA8", Offset = "0x73ABA8")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ABE0", Offset = "0x73ABE0")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x14AC2F8", Offset = "0x14AC2F8", VA = "0x14AC2F8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x14AC4A8", Offset = "0x14AC4A8", VA = "0x14AC4A8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x14AC514", Offset = "0x14AC514", VA = "0x14AC514", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x14AC6B4", Offset = "0x14AC6B4", VA = "0x14AC6B4")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000BB")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ACF8", Offset = "0x73ACF8")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000581")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AD30", Offset = "0x73AD30")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AD30", Offset = "0x73AD30")]
				public float weight;

				[Token(Token = "0x4000582")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000583")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000636")]
				[Address(RVA = "0x17BAC48", Offset = "0x17BAC48", VA = "0x17BAC48")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000637")]
				[Address(RVA = "0x17BAD24", Offset = "0x17BAD24", VA = "0x17BAD24")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000638")]
				[Address(RVA = "0x17BAD30", Offset = "0x17BAD30", VA = "0x17BAD30")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AC88", Offset = "0x73AC88")]
			public int curveIndex;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ACC0", Offset = "0x73ACC0")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x14AC6D0", Offset = "0x14AC6D0", VA = "0x14AC6D0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x14AC7B4", Offset = "0x14AC7B4", VA = "0x14AC7B4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x14AC820", Offset = "0x14AC820", VA = "0x14AC820", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x14ACAD4", Offset = "0x14ACAD4", VA = "0x14ACAD4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AA04", Offset = "0x73AA04")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AA3C", Offset = "0x73AA3C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x16310C0", Offset = "0x16310C0", VA = "0x16310C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1631194", Offset = "0x1631194", VA = "0x1631194")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x16313F8", Offset = "0x16313F8", VA = "0x16313F8")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BE")]
			public class EffectorLink
			{
				[Token(Token = "0x4000591")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AF60", Offset = "0x73AF60")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000592")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AF98", Offset = "0x73AF98")]
				public float weight;

				[Token(Token = "0x600063F")]
				[Address(RVA = "0x17BAD74", Offset = "0x17BAD74", VA = "0x17BAD74")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ADF4", Offset = "0x73ADF4")]
			public Transform transform;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AE2C", Offset = "0x73AE2C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AE64", Offset = "0x73AE64")]
			public float speed;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AE9C", Offset = "0x73AE9C")]
			public float acceleration;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AED4", Offset = "0x73AED4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73AED4", Offset = "0x73AED4")]
			public float matchVelocity;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AF28", Offset = "0x73AF28")]
			public float gravity;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x16B6A78", Offset = "0x16B6A78", VA = "0x16B6A78")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x16B6B30", Offset = "0x16B6B30", VA = "0x16B6B30")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x16B6DEC", Offset = "0x16B6DEC", VA = "0x16B6DEC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AD84", Offset = "0x73AD84")]
		public Body[] bodies;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73ADBC", Offset = "0x73ADBC")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1629ED8", Offset = "0x1629ED8", VA = "0x1629ED8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1629F54", Offset = "0x1629F54", VA = "0x1629F54", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x162A014", Offset = "0x162A014", VA = "0x162A014")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73AFD0", Offset = "0x73AFD0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73AFD0", Offset = "0x73AFD0")]
		public Transform target;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B030", Offset = "0x73B030")]
		public float weight;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B048", Offset = "0x73B048")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B080", Offset = "0x73B080")]
		public float weightSmoothTime;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B0B8", Offset = "0x73B0B8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73B0B8", Offset = "0x73B0B8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B118", Offset = "0x73B118")]
		public float maxRadiansDelta;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B150", Offset = "0x73B150")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B188", Offset = "0x73B188")]
		public float slerpSpeed;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B1C0", Offset = "0x73B1C0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B1F8", Offset = "0x73B1F8")]
		public float minDistance;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B230", Offset = "0x73B230")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B230", Offset = "0x73B230")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73B230", Offset = "0x73B230")]
		public float maxRootAngle;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000AB")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x14F86E0", Offset = "0x14F86E0", VA = "0x14F86E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x14F866C", Offset = "0x14F866C", VA = "0x14F866C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x14F8770", Offset = "0x14F8770", VA = "0x14F8770")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x14F8CA0", Offset = "0x14F8CA0", VA = "0x14F8CA0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x14F8D8C", Offset = "0x14F8D8C", VA = "0x14F8D8C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x14F8F84", Offset = "0x14F8F84", VA = "0x14F8F84")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class OffsetLimits
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B31C", Offset = "0x73B31C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B354", Offset = "0x73B354")]
			public float spring;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B38C", Offset = "0x73B38C")]
			public bool x;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B3C4", Offset = "0x73B3C4")]
			public bool y;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B3FC", Offset = "0x73B3FC")]
			public bool z;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B434", Offset = "0x73B434")]
			public float minX;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B46C", Offset = "0x73B46C")]
			public float maxX;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B4A4", Offset = "0x73B4A4")]
			public float minY;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B4DC", Offset = "0x73B4DC")]
			public float maxY;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B514", Offset = "0x73B514")]
			public float minZ;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B54C", Offset = "0x73B54C")]
			public float maxZ;

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x16B9198", Offset = "0x16B9198", VA = "0x16B9198")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x16B92F0", Offset = "0x16B92F0", VA = "0x16B92F0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x16B9368", Offset = "0x16B9368", VA = "0x16B9368")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x16B93C0", Offset = "0x16B93C0", VA = "0x16B93C0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734F98", Offset = "0x734F98")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x16B9148", Offset = "0x16B9148", VA = "0x16B9148", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x16B9190", Offset = "0x16B9190", VA = "0x16B9190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x16B8FD4", Offset = "0x16B8FD4", VA = "0x16B8FD4")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x16B9000", Offset = "0x16B9000", VA = "0x16B9000", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x16B9004", Offset = "0x16B9004", VA = "0x16B9004", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x16B9150", Offset = "0x16B9150", VA = "0x16B9150", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B2AC", Offset = "0x73B2AC")]
		public float weight;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B2E4", Offset = "0x73B2E4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x14FC0A8", Offset = "0x14FC0A8", VA = "0x14FC0A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000647")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x14FAE98", Offset = "0x14FAE98", VA = "0x14FAE98", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x14FC0D4", Offset = "0x14FC0D4", VA = "0x14FC0D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F7E0", Offset = "0x73F7E0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x14FC140", Offset = "0x14FC140", VA = "0x14FC140")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x14FC21C", Offset = "0x14FC21C", VA = "0x14FC21C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x14FB208", Offset = "0x14FB208", VA = "0x14FB208", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x14FB328", Offset = "0x14FB328", VA = "0x14FB328")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734FA8", Offset = "0x734FA8")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x16B953C", Offset = "0x16B953C", VA = "0x16B953C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x16B9584", Offset = "0x16B9584", VA = "0x16B9584", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x16B93C8", Offset = "0x16B93C8", VA = "0x16B93C8")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x16B93F4", Offset = "0x16B93F4", VA = "0x16B93F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x16B93F8", Offset = "0x16B93F8", VA = "0x16B93F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x16B9544", Offset = "0x16B9544", VA = "0x16B9544", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B584", Offset = "0x73B584")]
		public float weight;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B5BC", Offset = "0x73B5BC")]
		public VRIK ik;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AF")]
		protected float deltaTime
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x14FC2DC", Offset = "0x14FC2DC", VA = "0x14FC2DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000659")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x14FC308", Offset = "0x14FC308", VA = "0x14FC308", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x14FC334", Offset = "0x14FC334", VA = "0x14FC334")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F890", Offset = "0x73F890")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x14FC3A0", Offset = "0x14FC3A0", VA = "0x14FC3A0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x14FC47C", Offset = "0x14FC47C", VA = "0x14FC47C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x14FC588", Offset = "0x14FC588", VA = "0x14FC588")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public class EffectorLink
		{
			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x16B958C", Offset = "0x16B958C", VA = "0x16B958C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x16B97A8", Offset = "0x16B97A8", VA = "0x16B97A8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x14FC598", Offset = "0x14FC598", VA = "0x14FC598")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x14FC65C", Offset = "0x14FC65C", VA = "0x14FC65C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x14FC718", Offset = "0x14FC718", VA = "0x14FC718")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000C9")]
			public class EffectorLink
			{
				[Token(Token = "0x40005CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B7D0", Offset = "0x73B7D0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B808", Offset = "0x73B808")]
				public float weight;

				[Token(Token = "0x6000670")]
				[Address(RVA = "0x17BAD84", Offset = "0x17BAD84", VA = "0x17BAD84")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B62C", Offset = "0x73B62C")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B664", Offset = "0x73B664")]
			public Transform raycastTo;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B69C", Offset = "0x73B69C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73B69C", Offset = "0x73B69C")]
			public float raycastRadius;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B6F0", Offset = "0x73B6F0")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B728", Offset = "0x73B728")]
			public float smoothTimeIn;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B760", Offset = "0x73B760")]
			public float smoothTimeOut;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B798", Offset = "0x73B798")]
			public LayerMask layers;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x16B97B0", Offset = "0x16B97B0", VA = "0x16B97B0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x16B98F4", Offset = "0x16B98F4", VA = "0x16B98F4")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x16B99EC", Offset = "0x16B99EC", VA = "0x16B99EC")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x16B9BBC", Offset = "0x16B9BBC", VA = "0x16B9BBC")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B5F4", Offset = "0x73B5F4")]
		public Avoider[] avoiders;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x14FD0C0", Offset = "0x14FD0C0", VA = "0x14FD0C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x14FD148", Offset = "0x14FD148", VA = "0x14FD148")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000CC")]
			public class EffectorLink
			{
				[Token(Token = "0x40005ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB94", Offset = "0x73BB94")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BBCC", Offset = "0x73BBCC")]
				public float weight;

				[Token(Token = "0x6000680")]
				[Address(RVA = "0x17BAD8C", Offset = "0x17BAD8C", VA = "0x17BAD8C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BA98", Offset = "0x73BA98")]
			public Vector3 offset;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BAD0", Offset = "0x73BAD0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BAD0", Offset = "0x73BAD0")]
			public float additivity;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB24", Offset = "0x73BB24")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BB5C", Offset = "0x73BB5C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x16BA5B0", Offset = "0x16BA5B0", VA = "0x16BA5B0")]
			public void Start()
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x16BA600", Offset = "0x16BA600", VA = "0x16BA600")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x16BA7C4", Offset = "0x16BA7C4", VA = "0x16BA7C4")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public enum Handedness
		{
			[Token(Token = "0x40005F0")]
			Right,
			[Token(Token = "0x40005F1")]
			Left
		}

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B840", Offset = "0x73B840")]
		public AimIK aimIK;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B878", Offset = "0x73B878")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B8B0", Offset = "0x73B8B0")]
		public Handedness handedness;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B8E8", Offset = "0x73B8E8")]
		public bool twoHanded;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B920", Offset = "0x73B920")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B958", Offset = "0x73B958")]
		public float magnitudeRandom;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B990", Offset = "0x73B990")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73B9C8", Offset = "0x73B9C8")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BA00", Offset = "0x73BA00")]
		public float blendTime;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x73BA38", Offset = "0x73BA38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BA38", Offset = "0x73BA38")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B2")]
		public bool isFinished
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x1500820", Offset = "0x1500820", VA = "0x1500820")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1501298", Offset = "0x1501298", VA = "0x1501298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x15012D8", Offset = "0x15012D8", VA = "0x15012D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1501258", Offset = "0x1501258", VA = "0x1501258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1501278", Offset = "0x1501278", VA = "0x1501278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1500850", Offset = "0x1500850", VA = "0x1500850")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x150087C", Offset = "0x150087C", VA = "0x150087C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x15009C4", Offset = "0x15009C4", VA = "0x15009C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1501318", Offset = "0x1501318", VA = "0x1501318")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x15013CC", Offset = "0x15013CC", VA = "0x15013CC")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1501408", Offset = "0x1501408", VA = "0x1501408", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x15015C0", Offset = "0x15015C0", VA = "0x15015C0")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BC04", Offset = "0x73BC04")]
		public float weight;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BC3C", Offset = "0x73BC3C")]
		public float offset;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x149E57C", Offset = "0x149E57C", VA = "0x149E57C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x149E664", Offset = "0x149E664", VA = "0x149E664")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x149E74C", Offset = "0x149E74C", VA = "0x149E74C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x149EA9C", Offset = "0x149EA9C", VA = "0x149EA9C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x149EB10", Offset = "0x149EB10", VA = "0x149EB10")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x149EC1C", Offset = "0x149EC1C", VA = "0x149EC1C")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Settings
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BC74", Offset = "0x73BC74")]
			public float scaleMlp;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BCAC", Offset = "0x73BCAC")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BCE4", Offset = "0x73BCE4")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BD1C", Offset = "0x73BD1C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BD54", Offset = "0x73BD54")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BD8C", Offset = "0x73BD8C")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BDC4", Offset = "0x73BDC4")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BDFC", Offset = "0x73BDFC")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x73BDFC", Offset = "0x73BDFC")]
			public Vector3 headOffset;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BE4C", Offset = "0x73BE4C")]
			public Vector3 handOffset;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BE84", Offset = "0x73BE84")]
			public float footForwardOffset;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BEBC", Offset = "0x73BEBC")]
			public float footInwardOffset;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BEF4", Offset = "0x73BEF4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BEF4", Offset = "0x73BEF4")]
			public float footHeadingOffset;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BF50", Offset = "0x73BF50")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73BF68", Offset = "0x73BF68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x17BA518", Offset = "0x17BA518", VA = "0x17BA518")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000D2")]
			public class Target
			{
				[Token(Token = "0x4000610")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000611")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000612")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000698")]
				[Address(RVA = "0x17BAD94", Offset = "0x17BAD94", VA = "0x17BAD94")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000699")]
				[Address(RVA = "0x17BAE54", Offset = "0x17BAE54", VA = "0x17BAE54")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x17BA510", Offset = "0x17BA510", VA = "0x17BA510")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x14A5DA0", Offset = "0x14A5DA0", VA = "0x14A5DA0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x14A4968", Offset = "0x14A4968", VA = "0x14A4968")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x14A5F08", Offset = "0x14A5F08", VA = "0x14A5F08")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x14A5E1C", Offset = "0x14A5E1C", VA = "0x14A5E1C")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x14A4B94", Offset = "0x14A4B94", VA = "0x14A4B94")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x14A5F20", Offset = "0x14A5F20", VA = "0x14A5F20")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x14A3E80", Offset = "0x14A3E80", VA = "0x14A3E80")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x14A670C", Offset = "0x14A670C", VA = "0x14A670C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x14A3C6C", Offset = "0x14A3C6C", VA = "0x14A3C6C")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x14A6B1C", Offset = "0x14A6B1C", VA = "0x14A6B1C")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x14A71C0", Offset = "0x14A71C0", VA = "0x14A71C0")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x14A6F6C", Offset = "0x14A6F6C", VA = "0x14A6F6C")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x14A7430", Offset = "0x14A7430", VA = "0x14A7430")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x14A768C", Offset = "0x14A768C", VA = "0x14A768C")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x14A777C", Offset = "0x14A777C", VA = "0x14A777C")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D3")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x14A7A98", Offset = "0x14A7A98", VA = "0x14A7A98")]
		private void Start()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x14A7AEC", Offset = "0x14A7AEC", VA = "0x14A7AEC")]
		private void Update()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x14A7B20", Offset = "0x14A7B20", VA = "0x14A7B20")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x14A7C5C", Offset = "0x14A7C5C", VA = "0x14A7C5C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BF80", Offset = "0x73BF80")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B7")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x14A834C", Offset = "0x14A834C", VA = "0x14A834C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F940", Offset = "0x73F940")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x14A8358", Offset = "0x14A8358", VA = "0x14A8358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F950", Offset = "0x73F950")]
			private set
			{
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x14A8364", Offset = "0x14A8364", VA = "0x14A8364")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x14A6514", Offset = "0x14A6514", VA = "0x14A6514")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x14A6998", Offset = "0x14A6998", VA = "0x14A6998")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x14A8450", Offset = "0x14A8450", VA = "0x14A8450")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x14A886C", Offset = "0x14A886C", VA = "0x14A886C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x14A8978", Offset = "0x14A8978", VA = "0x14A8978")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000D5")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Offset
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x14A9928", Offset = "0x14A9928", VA = "0x14A9928")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x14A9A88", Offset = "0x14A9A88", VA = "0x14A9A88")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x15DE82C", Offset = "0x15DE82C", VA = "0x15DE82C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x15DE880", Offset = "0x15DE880", VA = "0x15DE880")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x15DE8FC", Offset = "0x15DE8FC", VA = "0x15DE8FC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x15DE9D4", Offset = "0x15DE9D4", VA = "0x15DE9D4")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x15AD7AC", Offset = "0x15AD7AC", VA = "0x15AD7AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x15AD830", Offset = "0x15AD830", VA = "0x15AD830")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BFA0", Offset = "0x73BFA0")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x15AE7E0", Offset = "0x15AE7E0", VA = "0x15AE7E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x15AE858", Offset = "0x15AE858", VA = "0x15AE858")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x149E37C", Offset = "0x149E37C", VA = "0x149E37C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x149E3C0", Offset = "0x149E3C0", VA = "0x149E3C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x149E574", Offset = "0x149E574", VA = "0x149E574")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73BFD8", Offset = "0x73BFD8")]
		public AimPoser aimPoser;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C010", Offset = "0x73C010")]
		public AimIK aim;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C048", Offset = "0x73C048")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C080", Offset = "0x73C080")]
		public Animator animator;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C0B8", Offset = "0x73C0B8")]
		public float crossfadeTime;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C0F0", Offset = "0x73C0F0")]
		public float minAimDistance;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x149EC30", Offset = "0x149EC30", VA = "0x149EC30")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x149EC74", Offset = "0x149EC74", VA = "0x149EC74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x149EDDC", Offset = "0x149EDDC", VA = "0x149EDDC")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x149EF6C", Offset = "0x149EF6C", VA = "0x149EF6C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x149F0A8", Offset = "0x149F0A8", VA = "0x149F0A8")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x149F124", Offset = "0x149F124", VA = "0x149F124")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x14A00BC", Offset = "0x14A00BC", VA = "0x14A00BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x14A022C", Offset = "0x14A022C", VA = "0x14A022C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x14A03C0", Offset = "0x14A03C0", VA = "0x14A03C0")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73C128", Offset = "0x73C128")]
		public Animator animator;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73C160", Offset = "0x73C160")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C198", Offset = "0x73C198")]
		public float lookAtWeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C1B0", Offset = "0x73C1B0")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C1C8", Offset = "0x73C1C8")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C1E0", Offset = "0x73C1E0")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C1F8", Offset = "0x73C1F8")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C210", Offset = "0x73C210")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C228", Offset = "0x73C228")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73C240", Offset = "0x73C240")]
		public Transform footTargetBiped;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C278", Offset = "0x73C278")]
		public float footPositionWeight;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C290", Offset = "0x73C290")]
		public float footRotationWeight;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73C2A8", Offset = "0x73C2A8")]
		public Transform handTargetBiped;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C2E0", Offset = "0x73C2E0")]
		public float handPositionWeight;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C2F8", Offset = "0x73C2F8")]
		public float handRotationWeight;

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x15B4F14", Offset = "0x15B4F14", VA = "0x15B4F14")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x15B531C", Offset = "0x15B531C", VA = "0x15B531C")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C310", Offset = "0x73C310")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000B8")]
		public Vector3 velocity
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x14F9180", Offset = "0x14F9180", VA = "0x14F9180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F960", Offset = "0x73F960")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x14F918C", Offset = "0x14F918C", VA = "0x14F918C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F970", Offset = "0x73F970")]
			private set
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x14F9198", Offset = "0x14F9198", VA = "0x14F9198")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x14F91D4", Offset = "0x14F91D4", VA = "0x14F91D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x14F9A48", Offset = "0x14F9A48", VA = "0x14F9A48")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x14F97F8", Offset = "0x14F97F8", VA = "0x14F97F8")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x14F9B44", Offset = "0x14F9B44", VA = "0x14F9B44")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B9")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x14F9B70", Offset = "0x14F9B70", VA = "0x14F9B70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x14F9BF4", Offset = "0x14F9BF4", VA = "0x14F9BF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x14F9E18", Offset = "0x14F9E18", VA = "0x14F9E18")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734FB8", Offset = "0x734FB8")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x16B8D1C", Offset = "0x16B8D1C", VA = "0x16B8D1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x16B8D64", Offset = "0x16B8D64", VA = "0x16B8D64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x16B8A2C", Offset = "0x16B8A2C", VA = "0x16B8A2C")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x16B8A58", Offset = "0x16B8A58", VA = "0x16B8A58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x16B8A5C", Offset = "0x16B8A5C", VA = "0x16B8A5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x16B8D24", Offset = "0x16B8D24", VA = "0x16B8D24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000BA")]
		public bool isStepping
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x14F9E2C", Offset = "0x14F9E2C", VA = "0x14F9E2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public Vector3 position
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x14F9B10", Offset = "0x14F9B10", VA = "0x14F9B10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x14F9E40", Offset = "0x14F9E40", VA = "0x14F9E40")]
			set
			{
			}
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x14F9E90", Offset = "0x14F9E90", VA = "0x14F9E90")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x14FA084", Offset = "0x14FA084", VA = "0x14FA084")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x14FA220", Offset = "0x14FA220", VA = "0x14FA220")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x14FA448", Offset = "0x14FA448", VA = "0x14FA448")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x14FA6BC", Offset = "0x14FA6BC", VA = "0x14FA6BC")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x14FA834", Offset = "0x14FA834", VA = "0x14FA834")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x14FA3A0", Offset = "0x14FA3A0", VA = "0x14FA3A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73F980", Offset = "0x73F980")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x14FAA30", Offset = "0x14FAA30", VA = "0x14FAA30")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x14FAA94", Offset = "0x14FAA94", VA = "0x14FAA94")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x14FAB54", Offset = "0x14FAB54", VA = "0x14FAB54")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x14FADA8", Offset = "0x14FADA8", VA = "0x14FADA8")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public struct Warp
		{
			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C3E0", Offset = "0x73C3E0")]
			public int animationLayer;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C418", Offset = "0x73C418")]
			public string animationState;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C450", Offset = "0x73C450")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C488", Offset = "0x73C488")]
			public Transform warpFrom;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C4C0", Offset = "0x73C4C0")]
			public Transform warpTo;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C4F8", Offset = "0x73C4F8")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum EffectorMode
		{
			[Token(Token = "0x400068F")]
			PositionOffset,
			[Token(Token = "0x4000690")]
			Position
		}

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C320", Offset = "0x73C320")]
		public Animator animator;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C358", Offset = "0x73C358")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x73C390", Offset = "0x73C390")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C390", Offset = "0x73C390")]
		public Warp[] warps;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x15AE9E0", Offset = "0x15AE9E0", VA = "0x15AE9E0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x15AEA0C", Offset = "0x15AEA0C", VA = "0x15AEA0C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x15AEC4C", Offset = "0x15AEC4C", VA = "0x15AEC4C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x15AEF10", Offset = "0x15AEF10", VA = "0x15AEF10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x15AEFB0", Offset = "0x15AEFB0", VA = "0x15AEFB0")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x15AEFB8", Offset = "0x15AEFB8", VA = "0x15AEFB8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x15AF00C", Offset = "0x15AF00C", VA = "0x15AF00C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x15AF1A8", Offset = "0x15AF1A8", VA = "0x15AF1A8", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x15AF3B0", Offset = "0x15AF3B0", VA = "0x15AF3B0")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C530", Offset = "0x73C530")]
		public float headLookWeight;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x15AF3C4", Offset = "0x15AF3C4", VA = "0x15AF3C4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x15AF550", Offset = "0x15AF550", VA = "0x15AF550", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x15AF5CC", Offset = "0x15AF5CC", VA = "0x15AF5CC")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x15AF6C0", Offset = "0x15AF6C0", VA = "0x15AF6C0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x15AF708", Offset = "0x15AF708", VA = "0x15AF708")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x15AFAF4", Offset = "0x15AFAF4", VA = "0x15AFAF4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x15AF97C", Offset = "0x15AF97C", VA = "0x15AF97C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x15AFD50", Offset = "0x15AFD50", VA = "0x15AFD50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x15AFE5C", Offset = "0x15AFE5C", VA = "0x15AFE5C")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x15BDE68", Offset = "0x15BDE68", VA = "0x15BDE68", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x15BDEC4", Offset = "0x15BDEC4", VA = "0x15BDEC4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x15BE100", Offset = "0x15BE100", VA = "0x15BE100")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x15BE1F4", Offset = "0x15BE1F4", VA = "0x15BE1F4")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BE")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x15BEC18", Offset = "0x15BEC18", VA = "0x15BEC18")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x15BEC9C", Offset = "0x15BEC9C", VA = "0x15BEC9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x15BEA20", Offset = "0x15BEA20", VA = "0x15BEA20")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x15BEA8C", Offset = "0x15BEA8C", VA = "0x15BEA8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x15BED20", Offset = "0x15BED20", VA = "0x15BED20")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C548", Offset = "0x73C548")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x15D79E0", Offset = "0x15D79E0", VA = "0x15D79E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x15D7E40", Offset = "0x15D7E40", VA = "0x15D7E40")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x15D7E48", Offset = "0x15D7E48", VA = "0x15D7E48")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x15D7EF0", Offset = "0x15D7EF0", VA = "0x15D7EF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x15D8274", Offset = "0x15D8274", VA = "0x15D8274")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x15D8320", Offset = "0x15D8320", VA = "0x15D8320")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Limb
		{
			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x14A9410", Offset = "0x14A9410", VA = "0x14A9410")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x14A9494", Offset = "0x14A9494", VA = "0x14A9494")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x15DBBEC", Offset = "0x15DBBEC", VA = "0x15DBBEC")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x15DBD44", Offset = "0x15DBD44", VA = "0x15DBD44")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x15DBDE8", Offset = "0x15DBDE8", VA = "0x15DBDE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x15DBDEC", Offset = "0x15DBDEC", VA = "0x15DBDEC")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x15DBDFC", Offset = "0x15DBDFC", VA = "0x15DBDFC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x15DBE70", Offset = "0x15DBE70", VA = "0x15DBE70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x15DBF44", Offset = "0x15DBF44", VA = "0x15DBF44")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C560", Offset = "0x73C560")]
		public Transform target;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C598", Offset = "0x73C598")]
		public Transform pin;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C5D0", Offset = "0x73C5D0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C608", Offset = "0x73C608")]
		public AimIK aim;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C640", Offset = "0x73C640")]
		public float weight;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C678", Offset = "0x73C678")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C6B0", Offset = "0x73C6B0")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x15DBF4C", Offset = "0x15DBF4C", VA = "0x15DBF4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x15DBFA0", Offset = "0x15DBFA0", VA = "0x15DBFA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x15DC144", Offset = "0x15DC144", VA = "0x15DC144")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x15DE1E8", Offset = "0x15DE1E8", VA = "0x15DE1E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x15DE2B0", Offset = "0x15DE2B0", VA = "0x15DE2B0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x15DE340", Offset = "0x15DE340", VA = "0x15DE340")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x15DE718", Offset = "0x15DE718", VA = "0x15DE718")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x15DE824", Offset = "0x15DE824", VA = "0x15DE824")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C6E8", Offset = "0x73C6E8")]
		public float aimWeight;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C700", Offset = "0x73C700")]
		public float sightWeight;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C718", Offset = "0x73C718")]
		public float maxAngle;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C734", Offset = "0x73C734")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x15DE9DC", Offset = "0x15DE9DC", VA = "0x15DE9DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x15DEBA0", Offset = "0x15DEBA0", VA = "0x15DEBA0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x15DEBAC", Offset = "0x15DEBAC", VA = "0x15DEBAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x15DEE2C", Offset = "0x15DEE2C", VA = "0x15DEE2C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x15DF0FC", Offset = "0x15DF0FC", VA = "0x15DF0FC")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x15DEC74", Offset = "0x15DEC74", VA = "0x15DEC74")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x15DF9F0", Offset = "0x15DF9F0", VA = "0x15DF9F0")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C74C", Offset = "0x73C74C")]
		public float walkSpeed;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x15DFA10", Offset = "0x15DFA10", VA = "0x15DFA10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x15DFA88", Offset = "0x15DFA88", VA = "0x15DFA88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x15DFB74", Offset = "0x15DFB74", VA = "0x15DFB74")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x15DFC2C", Offset = "0x15DFC2C", VA = "0x15DFC2C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1630D74", Offset = "0x1630D74", VA = "0x1630D74")]
		private void Update()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1630ECC", Offset = "0x1630ECC", VA = "0x1630ECC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x16310B0", Offset = "0x16310B0", VA = "0x16310B0")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x163174C", Offset = "0x163174C", VA = "0x163174C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1631894", Offset = "0x1631894", VA = "0x1631894")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1631BD0", Offset = "0x1631BD0", VA = "0x1631BD0")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x162A0F4", Offset = "0x162A0F4", VA = "0x162A0F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x162A230", Offset = "0x162A230", VA = "0x162A230")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x162A33C", Offset = "0x162A33C", VA = "0x162A33C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x162A344", Offset = "0x162A344", VA = "0x162A344")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x162AA70", Offset = "0x162AA70", VA = "0x162AA70")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C764", Offset = "0x73C764")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C79C", Offset = "0x73C79C")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x14F61A8", Offset = "0x14F61A8", VA = "0x14F61A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x14F61FC", Offset = "0x14F61FC", VA = "0x14F61FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x14F6534", Offset = "0x14F6534", VA = "0x14F6534")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Partner
		{
			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000C0")]
			private Transform neck
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x16B89C0", Offset = "0x16B89C0", VA = "0x16B89C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x16B8274", Offset = "0x16B8274", VA = "0x16B8274")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x16B8294", Offset = "0x16B8294", VA = "0x16B8294")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x16B882C", Offset = "0x16B882C", VA = "0x16B882C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x16B8A18", Offset = "0x16B8A18", VA = "0x16B8A18")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x14F7C68", Offset = "0x14F7C68", VA = "0x14F7C68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x14F7CA4", Offset = "0x14F7CA4", VA = "0x14F7CA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x14F7D0C", Offset = "0x14F7D0C", VA = "0x14F7D0C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public enum Mode
		{
			[Token(Token = "0x400071C")]
			Position,
			[Token(Token = "0x400071D")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Absorber
		{
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C8B4", Offset = "0x73C8B4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C8EC", Offset = "0x73C8EC")]
			public float weight;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x16B8D6C", Offset = "0x16B8D6C", VA = "0x16B8D6C")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x16B8E40", Offset = "0x16B8E40", VA = "0x16B8E40")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x16B8E7C", Offset = "0x16B8E7C", VA = "0x16B8E7C")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x16B8F14", Offset = "0x16B8F14", VA = "0x16B8F14")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x16B8F88", Offset = "0x16B8F88", VA = "0x16B8F88")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C7D4", Offset = "0x73C7D4")]
		public Mode mode;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C80C", Offset = "0x73C80C")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C844", Offset = "0x73C844")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C87C", Offset = "0x73C87C")]
		public float falloffSpeed;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x14FADB0", Offset = "0x14FADB0", VA = "0x14FADB0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x14FAEC4", Offset = "0x14FAEC4", VA = "0x14FAEC4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x14FAF54", Offset = "0x14FAF54", VA = "0x14FAF54", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x14FB068", Offset = "0x14FB068", VA = "0x14FB068")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x14FB0F4", Offset = "0x14FB0F4", VA = "0x14FB0F4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x14FB314", Offset = "0x14FB314", VA = "0x14FB314")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x14FB338", Offset = "0x14FB338", VA = "0x14FB338")]
		private void Start()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x14FB3AC", Offset = "0x14FB3AC", VA = "0x14FB3AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x14FB488", Offset = "0x14FB488", VA = "0x14FB488")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x14FB548", Offset = "0x14FB548", VA = "0x14FB548")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public class EffectorLink
		{
			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x16B8FC4", Offset = "0x16B8FC4", VA = "0x16B8FC4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x14FBE00", Offset = "0x14FBE00", VA = "0x14FBE00", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x14FBF0C", Offset = "0x14FBF0C", VA = "0x14FBF0C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x14FC098", Offset = "0x14FC098", VA = "0x14FC098")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73C934", Offset = "0x73C934")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C934", Offset = "0x73C934")]
		public float weight;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C988", Offset = "0x73C988")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C9C0", Offset = "0x73C9C0")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CA0C", Offset = "0x73CA0C")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x14FC774", Offset = "0x14FC774", VA = "0x14FC774")]
		private void Start()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x14FCA38", Offset = "0x14FCA38", VA = "0x14FCA38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x14FD080", Offset = "0x14FD080", VA = "0x14FD080")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000C1")]
		private bool holding
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x14FD65C", Offset = "0x14FD65C", VA = "0x14FD65C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private bool holdingLeft
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x14FD740", Offset = "0x14FD740", VA = "0x14FD740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool holdingRight
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x14FD694", Offset = "0x14FD694", VA = "0x14FD694")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x14FD158", Offset = "0x14FD158", VA = "0x14FD158")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000746")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x14FD7EC", Offset = "0x14FD7EC", VA = "0x14FD7EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x14FD974", Offset = "0x14FD974", VA = "0x14FD974")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x14FDAF8", Offset = "0x14FDAF8", VA = "0x14FDAF8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x14FDBD4", Offset = "0x14FDBD4", VA = "0x14FDBD4")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x14FDD14", Offset = "0x14FDD14", VA = "0x14FDD14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x14FDE84", Offset = "0x14FDE84", VA = "0x14FDE84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x14FE050", Offset = "0x14FE050", VA = "0x14FE050")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x14FE064", Offset = "0x14FE064", VA = "0x14FE064", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x14FE2C8", Offset = "0x14FE2C8", VA = "0x14FE2C8")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x14FE2DC", Offset = "0x14FE2DC", VA = "0x14FE2DC", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x14FE410", Offset = "0x14FE410", VA = "0x14FE410")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1500624", Offset = "0x1500624", VA = "0x1500624")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1500704", Offset = "0x1500704", VA = "0x1500704")]
		private void Update()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1500818", Offset = "0x1500818", VA = "0x1500818")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1501630", Offset = "0x1501630", VA = "0x1501630")]
		private void Start()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1501684", Offset = "0x1501684", VA = "0x1501684")]
		private void Update()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x15016DC", Offset = "0x15016DC", VA = "0x15016DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x15017BC", Offset = "0x15017BC", VA = "0x15017BC")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734FC8", Offset = "0x734FC8")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x16BA9B4", Offset = "0x16BA9B4", VA = "0x16BA9B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0x16BA9FC", Offset = "0x16BA9FC", VA = "0x16BA9FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x16BA7D8", Offset = "0x16BA7D8", VA = "0x16BA7D8")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x16BA804", Offset = "0x16BA804", VA = "0x16BA804", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x16BA808", Offset = "0x16BA808", VA = "0x16BA808", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x16BA9BC", Offset = "0x16BA9BC", VA = "0x16BA9BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x15017CC", Offset = "0x15017CC", VA = "0x15017CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1501880", Offset = "0x1501880", VA = "0x1501880")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x15018C8", Offset = "0x15018C8", VA = "0x15018C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73FA30", Offset = "0x73FA30")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1501944", Offset = "0x1501944", VA = "0x1501944")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734FD8", Offset = "0x734FD8")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076C")]
				[Address(RVA = "0x17B8614", Offset = "0x17B8614", VA = "0x17B8614", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076E")]
				[Address(RVA = "0x17B865C", Offset = "0x17B865C", VA = "0x17B865C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x17B84BC", Offset = "0x17B84BC", VA = "0x17B84BC")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x17B84E8", Offset = "0x17B84E8", VA = "0x17B84E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x17B84EC", Offset = "0x17B84EC", VA = "0x17B84EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x17B861C", Offset = "0x17B861C", VA = "0x17B861C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x149F918", Offset = "0x149F918", VA = "0x149F918")]
		private void Start()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x149F9C4", Offset = "0x149F9C4", VA = "0x149F9C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73FAE0", Offset = "0x73FAE0")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x149FA30", Offset = "0x149FA30", VA = "0x149FA30")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public class EffectorLink
		{
			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x17B8664", Offset = "0x17B8664", VA = "0x17B8664")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x17B8910", Offset = "0x17B8910", VA = "0x17B8910")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x17B89FC", Offset = "0x17B89FC", VA = "0x17B89FC")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x17B8E90", Offset = "0x17B8E90", VA = "0x17B8E90")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x17B8F84", Offset = "0x17B8F84", VA = "0x17B8F84")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x17B901C", Offset = "0x17B901C", VA = "0x17B901C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x17B90B0", Offset = "0x17B90B0", VA = "0x17B90B0")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x17B9144", Offset = "0x17B9144", VA = "0x17B9144")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x17B92C4", Offset = "0x17B92C4", VA = "0x17B92C4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x14A03F0", Offset = "0x14A03F0", VA = "0x14A03F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x14A046C", Offset = "0x14A046C", VA = "0x14A046C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x14A04DC", Offset = "0x14A04DC", VA = "0x14A04DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x14A05A4", Offset = "0x14A05A4", VA = "0x14A05A4")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CA58", Offset = "0x73CA58")]
		public Transform to;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CA90", Offset = "0x73CA90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73CA90", Offset = "0x73CA90")]
		public float transferMotion;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x14A05AC", Offset = "0x14A05AC", VA = "0x14A05AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x14A05E8", Offset = "0x14A05E8", VA = "0x14A05E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x14A069C", Offset = "0x14A069C", VA = "0x14A069C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CAE4", Offset = "0x73CAE4")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x14A19AC", Offset = "0x14A19AC", VA = "0x14A19AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x14A1B9C", Offset = "0x14A1B9C", VA = "0x14A1B9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x14A1D8C", Offset = "0x14A1D8C", VA = "0x14A1D8C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x14A1E58", Offset = "0x14A1E58", VA = "0x14A1E58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x14A1F64", Offset = "0x14A1F64", VA = "0x14A1F64")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x14A2200", Offset = "0x14A2200", VA = "0x14A2200", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x14A258C", Offset = "0x14A258C", VA = "0x14A258C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x14A27F8", Offset = "0x14A27F8", VA = "0x14A27F8")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x15E3754", Offset = "0x15E3754", VA = "0x15E3754")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x15E3A7C", Offset = "0x15E3A7C", VA = "0x15E3A7C")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x15E3AFC", Offset = "0x15E3AFC", VA = "0x15E3AFC")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734FE8", Offset = "0x734FE8")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000793")]
				[Address(RVA = "0x16B9D10", Offset = "0x16B9D10", VA = "0x16B9D10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x16B9D58", Offset = "0x16B9D58", VA = "0x16B9D58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x16B9BD0", Offset = "0x16B9BD0", VA = "0x16B9BD0")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x16B9BFC", Offset = "0x16B9BFC", VA = "0x16B9BFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x16B9C00", Offset = "0x16B9C00", VA = "0x16B9C00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x16B9D18", Offset = "0x16B9D18", VA = "0x16B9D18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x14FE424", Offset = "0x14FE424", VA = "0x14FE424")]
		private void Start()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x14FE550", Offset = "0x14FE550", VA = "0x14FE550")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x14FE4E4", Offset = "0x14FE4E4", VA = "0x14FE4E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73FB90", Offset = "0x73FB90")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x14FE6D4", Offset = "0x14FE6D4", VA = "0x14FE6D4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x14FE7C0", Offset = "0x14FE7C0", VA = "0x14FE7C0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x14FE8A8", Offset = "0x14FE8A8", VA = "0x14FE8A8")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73CB1C", Offset = "0x73CB1C")]
		public float weight;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x15B3CB4", Offset = "0x15B3CB4", VA = "0x15B3CB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x15B3D28", Offset = "0x15B3D28", VA = "0x15B3D28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x15B3DE0", Offset = "0x15B3DE0", VA = "0x15B3DE0")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class Part
		{
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x17B9300", Offset = "0x17B9300", VA = "0x17B9300")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x17B942C", Offset = "0x17B942C", VA = "0x17B942C")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x14A0A84", Offset = "0x14A0A84", VA = "0x14A0A84")]
		private void Update()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x14A0B00", Offset = "0x14A0B00", VA = "0x14A0B00")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1631400", Offset = "0x1631400", VA = "0x1631400")]
		private void Update()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1631558", Offset = "0x1631558", VA = "0x1631558")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x163173C", Offset = "0x163173C", VA = "0x163173C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CB34", Offset = "0x73CB34")]
		public VRIK ik;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CB6C", Offset = "0x73CB6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CB6C", Offset = "0x73CB6C")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CBCC", Offset = "0x73CBCC")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CC04", Offset = "0x73CC04")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CC3C", Offset = "0x73CC3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CC3C", Offset = "0x73CC3C")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CC9C", Offset = "0x73CC9C")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CCD4", Offset = "0x73CCD4")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD0C", Offset = "0x73CD0C")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CD44", Offset = "0x73CD44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CD44", Offset = "0x73CD44")]
		public float scaleMlp;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CDA4", Offset = "0x73CDA4")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x14A3AD4", Offset = "0x14A3AD4", VA = "0x14A3AD4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x14A49B4", Offset = "0x14A49B4", VA = "0x14A49B4")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CDDC", Offset = "0x73CDDC")]
		public VRIK ik;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE14", Offset = "0x73CE14")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE4C", Offset = "0x73CE4C")]
		public Transform headTracker;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CE84", Offset = "0x73CE84")]
		public Transform bodyTracker;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CEBC", Offset = "0x73CEBC")]
		public Transform leftHandTracker;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CEF4", Offset = "0x73CEF4")]
		public Transform rightHandTracker;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CF2C", Offset = "0x73CF2C")]
		public Transform leftFootTracker;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73CF64", Offset = "0x73CF64")]
		public Transform rightFootTracker;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CF9C", Offset = "0x73CF9C")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x14A4A20", Offset = "0x14A4A20", VA = "0x14A4A20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x14A5DB8", Offset = "0x14A5DB8", VA = "0x14A5DB8")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x14A7C74", Offset = "0x14A7C74", VA = "0x14A7C74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x14A7CD0", Offset = "0x14A7CD0", VA = "0x14A7CD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x14A7E58", Offset = "0x14A7E58", VA = "0x14A7E58")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x14A7E8C", Offset = "0x14A7E8C", VA = "0x14A7E8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x14A8310", Offset = "0x14A8310", VA = "0x14A8310")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000CA")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x15BD14C", Offset = "0x15BD14C", VA = "0x15BD14C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x15BD128", Offset = "0x15BD128", VA = "0x15BD128", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x15BD154", Offset = "0x15BD154", VA = "0x15BD154")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x15BD1B8", Offset = "0x15BD1B8", VA = "0x15BD1B8", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x15BD350", Offset = "0x15BD350", VA = "0x15BD350", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x15BD574", Offset = "0x15BD574", VA = "0x15BD574", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x15BD360", Offset = "0x15BD360", VA = "0x15BD360")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x15BD584", Offset = "0x15BD584", VA = "0x15BD584")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x15BD59C", Offset = "0x15BD59C", VA = "0x15BD59C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x15BD5F8", Offset = "0x15BD5F8", VA = "0x15BD5F8", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x15BD694", Offset = "0x15BD694", VA = "0x15BD694")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x15BD7AC", Offset = "0x15BD7AC", VA = "0x15BD7AC")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73D004", Offset = "0x73D004")]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007C8")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007C9")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000CB")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x15BD860", Offset = "0x15BD860", VA = "0x15BD860", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x15BD7C4", Offset = "0x15BD7C4", VA = "0x15BD7C4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x15BD844", Offset = "0x15BD844", VA = "0x15BD844", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x15BD958", Offset = "0x15BD958", VA = "0x15BD958", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x15BDD3C", Offset = "0x15BDD3C", VA = "0x15BDD3C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x15BDE44", Offset = "0x15BDE44", VA = "0x15BDE44")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73D048", Offset = "0x73D048")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D048", Offset = "0x73D048")]
		public Transform gravityTarget;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D0A8", Offset = "0x73D0A8")]
		public float gravityMultiplier;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007D7")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60007BB")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x15BE218", Offset = "0x15BE218", VA = "0x15BE218")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x15BE348", Offset = "0x15BE348", VA = "0x15BE348", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x15BE500", Offset = "0x15BE500", VA = "0x15BE500", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x15BE6B0", Offset = "0x15BE6B0", VA = "0x15BE6B0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x15BE714", Offset = "0x15BE714", VA = "0x15BE714")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x15BE834", Offset = "0x15BE834", VA = "0x15BE834")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x15BE958", Offset = "0x15BE958", VA = "0x15BE958")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x15BE97C", Offset = "0x15BE97C", VA = "0x15BE97C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x15BE9A0", Offset = "0x15BE9A0", VA = "0x15BE9A0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x15BEA00", Offset = "0x15BEA00", VA = "0x15BEA00")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011E")]
		public enum MoveMode
		{
			[Token(Token = "0x4000815")]
			Directional,
			[Token(Token = "0x4000816")]
			Strafe
		}

		[Token(Token = "0x200011F")]
		public struct AnimState
		{
			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734FF8", Offset = "0x734FF8")]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x14A92CC", Offset = "0x14A92CC", VA = "0x14A92CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DD")]
				[Address(RVA = "0x14A9314", Offset = "0x14A9314", VA = "0x14A9314", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x14A91A8", Offset = "0x14A91A8", VA = "0x14A91A8")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x14A91D4", Offset = "0x14A91D4", VA = "0x14A91D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x14A91D8", Offset = "0x14A91D8", VA = "0x14A91D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x14A92D4", Offset = "0x14A92D4", VA = "0x14A92D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73D0E0", Offset = "0x73D0E0")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73D118", Offset = "0x73D118")]
		public MoveMode moveMode;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73D150", Offset = "0x73D150")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73D188", Offset = "0x73D188")]
		public bool smoothJump;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73D1C0", Offset = "0x73D1C0")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73D1F8", Offset = "0x73D1F8")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D230", Offset = "0x73D230")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000CC")]
		public bool onGround
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x15BED28", Offset = "0x15BED28", VA = "0x15BED28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FC40", Offset = "0x73FC40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x15BED30", Offset = "0x15BED30", VA = "0x15BED30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FC50", Offset = "0x73FC50")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x15BED3C", Offset = "0x15BED3C", VA = "0x15BED3C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x15BEE7C", Offset = "0x15BEE7C", VA = "0x15BEE7C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x15BEF0C", Offset = "0x15BEF0C", VA = "0x15BEF0C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x15BEFD4", Offset = "0x15BEFD4", VA = "0x15BEFD4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x15BFBD8", Offset = "0x15BFBD8", VA = "0x15BFBD8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x15BFE30", Offset = "0x15BFE30", VA = "0x15BFE30", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x15BF4CC", Offset = "0x15BF4CC", VA = "0x15BF4CC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x15BFF0C", Offset = "0x15BFF0C", VA = "0x15BFF0C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x15C03B4", Offset = "0x15C03B4", VA = "0x15C03B4")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x15BFC60", Offset = "0x15BFC60", VA = "0x15BFC60")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x15C0454", Offset = "0x15C0454", VA = "0x15C0454", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x15C0790", Offset = "0x15C0790", VA = "0x15C0790")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x15C0880", Offset = "0x15C0880", VA = "0x15C0880", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x15C09E0", Offset = "0x15C09E0", VA = "0x15C09E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73FC60", Offset = "0x73FC60")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x15BF830", Offset = "0x15BF830", VA = "0x15BF830")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x15C0A70", Offset = "0x15C0A70", VA = "0x15C0A70")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000122")]
		public enum RotationMode
		{
			[Token(Token = "0x4000832")]
			Smooth,
			[Token(Token = "0x4000833")]
			Linear
		}

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D240", Offset = "0x73D240")]
		public CameraController cameraController;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D278", Offset = "0x73D278")]
		public float accelerationTime;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D2B0", Offset = "0x73D2B0")]
		public float turnTime;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D2E8", Offset = "0x73D2E8")]
		public bool walkByDefault;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D320", Offset = "0x73D320")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D358", Offset = "0x73D358")]
		public float moveSpeed;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D390", Offset = "0x73D390")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000CF")]
		public bool isGrounded
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x149F138", Offset = "0x149F138", VA = "0x149F138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD10", Offset = "0x73FD10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x149F140", Offset = "0x149F140", VA = "0x149F140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD20", Offset = "0x73FD20")]
			private set
			{
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x149F14C", Offset = "0x149F14C", VA = "0x149F14C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x149F1DC", Offset = "0x149F1DC", VA = "0x149F1DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x149F69C", Offset = "0x149F69C", VA = "0x149F69C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x149F230", Offset = "0x149F230", VA = "0x149F230")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x149F4B0", Offset = "0x149F4B0", VA = "0x149F4B0")]
		private void Move()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x149F6D8", Offset = "0x149F6D8", VA = "0x149F6D8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x149F774", Offset = "0x149F774", VA = "0x149F774")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x149F7F8", Offset = "0x149F7F8", VA = "0x149F7F8")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x14A1F6C", Offset = "0x14A1F6C", VA = "0x14A1F6C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x14A1FE8", Offset = "0x14A1FE8", VA = "0x14A1FE8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x14A21AC", Offset = "0x14A21AC", VA = "0x14A21AC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x14A21D4", Offset = "0x14A21D4", VA = "0x14A21D4")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
		public struct State
		{
			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x14A1FB0", Offset = "0x14A1FB0", VA = "0x14A1FB0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x14A22F0", Offset = "0x14A22F0", VA = "0x14A22F0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x14A21F0", Offset = "0x14A21F0", VA = "0x14A21F0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x15AFE78", Offset = "0x15AFE78", VA = "0x15AFE78")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x15AFEB4", Offset = "0x15AFEB4", VA = "0x15AFEB4")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x149F820", Offset = "0x149F820", VA = "0x149F820")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x149F854", Offset = "0x149F854", VA = "0x149F854")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x149F904", Offset = "0x149F904", VA = "0x149F904")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000128")]
	public class Navigator
	{
		[Token(Token = "0x2000129")]
		public enum State
		{
			[Token(Token = "0x4000855")]
			Idle,
			[Token(Token = "0x4000856")]
			Seeking,
			[Token(Token = "0x4000857")]
			OnPath
		}

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D3A0", Offset = "0x73D3A0")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D3D8", Offset = "0x73D3D8")]
		public float cornerRadius;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D410", Offset = "0x73D410")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D448", Offset = "0x73D448")]
		public float maxSampleDistance;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73D480", Offset = "0x73D480")]
		public float nextPathInterval;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D4B8", Offset = "0x73D4B8")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D4C8", Offset = "0x73D4C8")]
		private State <state>k__BackingField;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000D0")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x14FB55C", Offset = "0x14FB55C", VA = "0x14FB55C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD30", Offset = "0x73FD30")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x14FB568", Offset = "0x14FB568", VA = "0x14FB568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD40", Offset = "0x73FD40")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public State state
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x14FB574", Offset = "0x14FB574", VA = "0x14FB574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD50", Offset = "0x73FD50")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x14FB57C", Offset = "0x14FB57C", VA = "0x14FB57C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD60", Offset = "0x73FD60")]
			private set
			{
			}
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x14FB584", Offset = "0x14FB584", VA = "0x14FB584")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x14FB634", Offset = "0x14FB634", VA = "0x14FB634")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x14FBA20", Offset = "0x14FBA20", VA = "0x14FBA20")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x14FBA9C", Offset = "0x14FBA9C", VA = "0x14FBA9C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x14FB9DC", Offset = "0x14FB9DC", VA = "0x14FB9DC")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x14FBA0C", Offset = "0x14FBA0C", VA = "0x14FBA0C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x14FBBE8", Offset = "0x14FBBE8", VA = "0x14FBBE8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x14FBD98", Offset = "0x14FBD98", VA = "0x14FBD98")]
		public Navigator()
		{
		}
	}
}
