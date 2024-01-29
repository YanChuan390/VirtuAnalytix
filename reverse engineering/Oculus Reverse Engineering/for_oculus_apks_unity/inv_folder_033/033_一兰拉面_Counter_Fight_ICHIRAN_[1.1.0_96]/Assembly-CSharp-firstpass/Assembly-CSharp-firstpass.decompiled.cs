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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B30A8", Offset = "0x9B30A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B30A8", Offset = "0x9B30A8")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public enum Mode
		{
			[Token(Token = "0x40005A3")]
			AnimationClips,
			[Token(Token = "0x40005A4")]
			AnimationStates,
			[Token(Token = "0x40005A5")]
			PlayableDirector,
			[Token(Token = "0x40005A6")]
			Realtime
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3B6C", Offset = "0x9B3B6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B3B6C", Offset = "0x9B3B6C")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3BC4", Offset = "0x9B3BC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B3BC4", Offset = "0x9B3BC4")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3C1C", Offset = "0x9B3C1C")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3C54", Offset = "0x9B3C54")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3C8C", Offset = "0x9B3C8C")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3CC4", Offset = "0x9B3CC4")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3CFC", Offset = "0x9B3CFC")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3D34", Offset = "0x9B3D34")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3D6C", Offset = "0x9B3D6C")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3DA4", Offset = "0x9B3DA4")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3DB4", Offset = "0x9B3DB4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3DE4", Offset = "0x9B3DE4")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x15EBAA8", Offset = "0x15EBAA8", VA = "0x15EBAA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC114", Offset = "0x9BC114")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x15EBAB0", Offset = "0x15EBAB0", VA = "0x15EBAB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC124", Offset = "0x9BC124")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x15EBABC", Offset = "0x15EBABC", VA = "0x15EBABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC134", Offset = "0x9BC134")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x15EBAC4", Offset = "0x15EBAC4", VA = "0x15EBAC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC144", Offset = "0x9BC144")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x15EBACC", Offset = "0x15EBACC", VA = "0x15EBACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC154", Offset = "0x9BC154")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x15EBAD4", Offset = "0x15EBAD4", VA = "0x15EBAD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC164", Offset = "0x9BC164")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x15EB978", Offset = "0x15EB978", VA = "0x15EB978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC034", Offset = "0x9BC034")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x15EB9C4", Offset = "0x15EB9C4", VA = "0x15EB9C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC06C", Offset = "0x9BC06C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x15EBA10", Offset = "0x15EBA10", VA = "0x15EBA10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC0A4", Offset = "0x9BC0A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x15EBA5C", Offset = "0x15EBA5C", VA = "0x15EBA5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC0DC", Offset = "0x9BC0DC")]
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
		[Address(RVA = "0x15EBADC", Offset = "0x15EBADC", VA = "0x15EBADC")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x15EBAE0", Offset = "0x15EBAE0", VA = "0x15EBAE0")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x15EBAE4", Offset = "0x15EBAE4", VA = "0x15EBAE4")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x15EBAE8", Offset = "0x15EBAE8", VA = "0x15EBAE8")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3DF4", Offset = "0x9B3DF4")]
		public bool markAsLegacy;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3E2C", Offset = "0x9B3E2C")]
		public Transform root;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3E64", Offset = "0x9B3E64")]
		public Transform rootNode;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3E9C", Offset = "0x9B3E9C")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3ED4", Offset = "0x9B3ED4")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x15ADB2C", Offset = "0x15ADB2C", VA = "0x15ADB2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x15ADF0C", Offset = "0x15ADF0C", VA = "0x15ADF0C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x15ADF14", Offset = "0x15ADF14", VA = "0x15ADF14", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x15AE024", Offset = "0x15AE024", VA = "0x15AE024", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x15AE0A0", Offset = "0x15AE0A0", VA = "0x15AE0A0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x15AE11C", Offset = "0x15AE11C", VA = "0x15AE11C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x15ADD5C", Offset = "0x15ADD5C", VA = "0x15ADD5C")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x15ADE34", Offset = "0x15ADE34", VA = "0x15ADE34")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x15AE198", Offset = "0x15AE198", VA = "0x15AE198")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class TQ
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x15B31E4", Offset = "0x15B31E4", VA = "0x15B31E4")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x15EA93C", Offset = "0x15EA93C", VA = "0x15EA93C")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x15EAB5C", Offset = "0x15EAB5C", VA = "0x15EAB5C")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x15EAB3C", Offset = "0x15EAB3C", VA = "0x15EAB3C")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x15EB1F4", Offset = "0x15EB1F4", VA = "0x15EB1F4")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x15ECE98", Offset = "0x15ECE98", VA = "0x15ECE98")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x15EE3E4", Offset = "0x15EE3E4", VA = "0x15EE3E4")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x15EC8AC", Offset = "0x15EC8AC", VA = "0x15EC8AC")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x15ECEE0", Offset = "0x15ECEE0", VA = "0x15ECEE0")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x15EC3E4", Offset = "0x15EC3E4", VA = "0x15EC3E4")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x15EBBD8", Offset = "0x15EBBD8", VA = "0x15EBBD8")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x15EBED0", Offset = "0x15EBED0", VA = "0x15EBED0")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x15EBD4C", Offset = "0x15EBD4C", VA = "0x15EBD4C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x15EC068", Offset = "0x15EC068", VA = "0x15EC068")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x15EC640", Offset = "0x15EC640", VA = "0x15EC640")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x15EC73C", Offset = "0x15EC73C", VA = "0x15EC73C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x15EC838", Offset = "0x15EC838", VA = "0x15EC838")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x15EC7B0", Offset = "0x15EC7B0", VA = "0x15EC7B0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x15ECAF8", Offset = "0x15ECAF8", VA = "0x15ECAF8")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x15ECBAC", Offset = "0x15ECBAC", VA = "0x15ECBAC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class BakerMuscle
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x15ECEE4", Offset = "0x15ECEE4", VA = "0x15ECEE4")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x15ECF60", Offset = "0x15ECF60", VA = "0x15ECF60")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x15ED650", Offset = "0x15ED650", VA = "0x15ED650")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x15ED704", Offset = "0x15ED704", VA = "0x15ED704")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x15ED5E8", Offset = "0x15ED5E8", VA = "0x15ED5E8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x15ED7E8", Offset = "0x15ED7E8", VA = "0x15ED7E8")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x15ED830", Offset = "0x15ED830", VA = "0x15ED830")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class BakerTransform
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x15ED838", Offset = "0x15ED838", VA = "0x15ED838")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x15EDA30", Offset = "0x15EDA30", VA = "0x15EDA30")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x15EDA44", Offset = "0x15EDA44", VA = "0x15EDA44")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x15EDCD4", Offset = "0x15EDCD4", VA = "0x15EDCD4")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x15ED8E8", Offset = "0x15ED8E8", VA = "0x15ED8E8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x15EDF20", Offset = "0x15EDF20", VA = "0x15EDF20")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x15EDF94", Offset = "0x15EDF94", VA = "0x15EDF94")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x15EE1E0", Offset = "0x15EE1E0", VA = "0x15EE1E0")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3F0C", Offset = "0x9B3F0C")]
		public bool bakeHandIK;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3F44", Offset = "0x9B3F44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B3F44", Offset = "0x9B3F44")]
		public float IKKeyReductionError;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B3F9C", Offset = "0x9B3F9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B3F9C", Offset = "0x9B3F9C")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x15AF0E4", Offset = "0x15AF0E4", VA = "0x15AF0E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x15AF5C8", Offset = "0x15AF5C8", VA = "0x15AF5C8", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x15AF5E4", Offset = "0x15AF5E4", VA = "0x15AF5E4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x15AF704", Offset = "0x15AF704", VA = "0x15AF704", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x15AF7E0", Offset = "0x15AF7E0", VA = "0x15AF7E0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x15AF9B0", Offset = "0x15AF9B0", VA = "0x15AF9B0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x15AFD48", Offset = "0x15AFD48", VA = "0x15AFD48")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x15AFE24", Offset = "0x15AFE24", VA = "0x15AFE24")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public enum UpdateMode
		{
			[Token(Token = "0x40005A8")]
			Update,
			[Token(Token = "0x40005A9")]
			FixedUpdate,
			[Token(Token = "0x40005AA")]
			LateUpdate,
			[Token(Token = "0x40005AB")]
			FixedLateUpdate
		}

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B3FF0", Offset = "0x9B3FF0")]
		public bool smoothFollow;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B4028", Offset = "0x9B4028")]
		public float rotationSensitivity;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B4060", Offset = "0x9B4060")]
		public float distance;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B4098", Offset = "0x9B4098")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B40D0", Offset = "0x9B40D0")]
		public float blockedOffset;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B40E8", Offset = "0x9B40E8")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B40F8", Offset = "0x9B40F8")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4108", Offset = "0x9B4108")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x15F5AB4", Offset = "0x15F5AB4", VA = "0x15F5AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC174", Offset = "0x9BC174")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x15F5ABC", Offset = "0x15F5ABC", VA = "0x15F5ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC184", Offset = "0x9BC184")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x15F5AC4", Offset = "0x15F5AC4", VA = "0x15F5AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC194", Offset = "0x9BC194")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x15F5ACC", Offset = "0x15F5ACC", VA = "0x15F5ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC1A4", Offset = "0x9BC1A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x15F5AD4", Offset = "0x15F5AD4", VA = "0x15F5AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC1B4", Offset = "0x9BC1B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x15F5ADC", Offset = "0x15F5ADC", VA = "0x15F5ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC1C4", Offset = "0x9BC1C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x15F6618", Offset = "0x15F6618", VA = "0x15F6618")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x15F5AE4", Offset = "0x15F5AE4", VA = "0x15F5AE4")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x15F5B20", Offset = "0x15F5B20", VA = "0x15F5B20")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x15F5B28", Offset = "0x15F5B28", VA = "0x15F5B28", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x15F5C50", Offset = "0x15F5C50", VA = "0x15F5C50", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x15F5CAC", Offset = "0x15F5CAC", VA = "0x15F5CAC", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x15F5D14", Offset = "0x15F5D14", VA = "0x15F5D14", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15F5D78", Offset = "0x15F5D78", VA = "0x15F5D78")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x15F5C84", Offset = "0x15F5C84", VA = "0x15F5C84")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x15F5EF8", Offset = "0x15F5EF8", VA = "0x15F5EF8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x15F6568", Offset = "0x15F6568", VA = "0x15F6568")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x15F668C", Offset = "0x15F668C", VA = "0x15F668C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x15F67A4", Offset = "0x15F67A4", VA = "0x15F67A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x15F67DC", Offset = "0x15F67DC", VA = "0x15F67DC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x15F6994", Offset = "0x15F6994", VA = "0x15F6994")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x15F6A44", Offset = "0x15F6A44", VA = "0x15F6A44")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public enum Axis
	{
		[Token(Token = "0x4000077")]
		X,
		[Token(Token = "0x4000078")]
		Y,
		[Token(Token = "0x4000079")]
		Z
	}
	[Token(Token = "0x200000E")]
	public class AxisTools
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x15EB1FC", Offset = "0x15EB1FC", VA = "0x15EB1FC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x15EB2B4", Offset = "0x15EB2B4", VA = "0x15EB2B4")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15EB360", Offset = "0x15EB360", VA = "0x15EB360")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15EB544", Offset = "0x15EB544", VA = "0x15EB544")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15EB47C", Offset = "0x15EB47C", VA = "0x15EB47C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15EB660", Offset = "0x15EB660", VA = "0x15EB660")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x15EB6A8", Offset = "0x15EB6A8", VA = "0x15EB6A8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15EB970", Offset = "0x15EB970", VA = "0x15EB970")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public class LimbOrientation
		{
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x15EEAC4", Offset = "0x15EEAC4", VA = "0x15EEAC4")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x15EE84C", Offset = "0x15EE84C", VA = "0x15EE84C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x15EEB3C", Offset = "0x15EEB3C", VA = "0x15EEB3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x15EE7CC", Offset = "0x15EE7CC", VA = "0x15EE7CC")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public enum BoneType
		{
			[Token(Token = "0x40005B0")]
			Unassigned,
			[Token(Token = "0x40005B1")]
			Spine,
			[Token(Token = "0x40005B2")]
			Head,
			[Token(Token = "0x40005B3")]
			Arm,
			[Token(Token = "0x40005B4")]
			Leg,
			[Token(Token = "0x40005B5")]
			Tail,
			[Token(Token = "0x40005B6")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public enum BoneSide
		{
			[Token(Token = "0x40005B8")]
			Center,
			[Token(Token = "0x40005B9")]
			Left,
			[Token(Token = "0x40005BA")]
			Right
		}

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x15EEDB4", Offset = "0x15EEDB4", VA = "0x15EEDB4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x15EF0BC", Offset = "0x15EF0BC", VA = "0x15EF0BC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x15EF314", Offset = "0x15EF314", VA = "0x15EF314")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15EF398", Offset = "0x15EF398", VA = "0x15EF398")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15EF444", Offset = "0x15EF444", VA = "0x15EF444")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x15EEF6C", Offset = "0x15EEF6C", VA = "0x15EEF6C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x15EF274", Offset = "0x15EF274", VA = "0x15EF274")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x15EFC84", Offset = "0x15EFC84", VA = "0x15EFC84")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x15EFA9C", Offset = "0x15EFA9C", VA = "0x15EFA9C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15EFB90", Offset = "0x15EFB90", VA = "0x15EFB90")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15EF664", Offset = "0x15EF664", VA = "0x15EF664")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x15EF718", Offset = "0x15EF718", VA = "0x15EF718")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15EF7CC", Offset = "0x15EF7CC", VA = "0x15EF7CC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15EF880", Offset = "0x15EF880", VA = "0x15EF880")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15EF934", Offset = "0x15EF934", VA = "0x15EF934")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x15EF9E8", Offset = "0x15EF9E8", VA = "0x15EF9E8")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x15EFE98", Offset = "0x15EFE98", VA = "0x15EFE98")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15EF578", Offset = "0x15EF578", VA = "0x15EF578")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x15EFE08", Offset = "0x15EFE08", VA = "0x15EFE08")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x15EFF08", Offset = "0x15EFF08", VA = "0x15EFF08")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x15EFFE0", Offset = "0x15EFFE0", VA = "0x15EFFE0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x15EFD8C", Offset = "0x15EFD8C", VA = "0x15EFD8C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x15EFD14", Offset = "0x15EFD14", VA = "0x15EFD14")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class BipedReferences
	{
		[Token(Token = "0x20000C5")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000078")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x15F5AAC", Offset = "0x15F5AAC", VA = "0x15F5AAC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0xA72B08", Offset = "0xA72B08", VA = "0xA72B08")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x15F2378", Offset = "0x15F2378", VA = "0x15F2378", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x15F2764", Offset = "0x15F2764", VA = "0x15F2764")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x15F2774", Offset = "0x15F2774", VA = "0x15F2774", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x15F2BA0", Offset = "0x15F2BA0", VA = "0x15F2BA0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x15F2FD8", Offset = "0x15F2FD8", VA = "0x15F2FD8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x15F36E4", Offset = "0x15F36E4", VA = "0x15F36E4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x15F3254", Offset = "0x15F3254", VA = "0x15F3254")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x15F3F18", Offset = "0x15F3F18", VA = "0x15F3F18")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x15F4018", Offset = "0x15F4018", VA = "0x15F4018")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x15F45CC", Offset = "0x15F45CC", VA = "0x15F45CC")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x15F43BC", Offset = "0x15F43BC", VA = "0x15F43BC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x15F4234", Offset = "0x15F4234", VA = "0x15F4234")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x15F40B8", Offset = "0x15F40B8", VA = "0x15F40B8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x15F44C0", Offset = "0x15F44C0", VA = "0x15F44C0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x15F46C8", Offset = "0x15F46C8", VA = "0x15F46C8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x15F522C", Offset = "0x15F522C", VA = "0x15F522C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x15F4CF8", Offset = "0x15F4CF8", VA = "0x15F4CF8")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x15F5574", Offset = "0x15F5574", VA = "0x15F5574")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x15F5044", Offset = "0x15F5044", VA = "0x15F5044")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15F557C", Offset = "0x15F557C", VA = "0x15F557C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x15F5584", Offset = "0x15F5584", VA = "0x15F5584")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x15F5750", Offset = "0x15F5750", VA = "0x15F5750")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x15F5974", Offset = "0x15F5974", VA = "0x15F5974")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x15F31CC", Offset = "0x15F31CC", VA = "0x15F31CC")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x15F6A60", Offset = "0x15F6A60", VA = "0x15F6A60")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x15F6A68", Offset = "0x15F6A68", VA = "0x15F6A68")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x15F6BA8", Offset = "0x15F6BA8", VA = "0x15F6BA8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class Hierarchy
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x15AE20C", Offset = "0x15AE20C", VA = "0x15AE20C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x15AE40C", Offset = "0x15AE40C", VA = "0x15AE40C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x15AE2A4", Offset = "0x15AE2A4", VA = "0x15AE2A4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x15AE530", Offset = "0x15AE530", VA = "0x15AE530")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x15AE654", Offset = "0x15AE654", VA = "0x15AE654")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x15AE904", Offset = "0x15AE904", VA = "0x15AE904")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x15AEA20", Offset = "0x15AEA20", VA = "0x15AEA20")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x15AEBA8", Offset = "0x15AEBA8", VA = "0x15AEBA8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x15AEF3C", Offset = "0x15AEF3C", VA = "0x15AEF3C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x15AED28", Offset = "0x15AED28", VA = "0x15AED28")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x15AF0DC", Offset = "0x15AF0DC", VA = "0x15AF0DC")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x15AFEE4", Offset = "0x15AFEE4", VA = "0x15AFEE4")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x15AFF74", Offset = "0x15AFF74", VA = "0x15AFF74")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000A7")]
		None,
		[Token(Token = "0x40000A8")]
		InOutCubic,
		[Token(Token = "0x40000A9")]
		InOutQuintic,
		[Token(Token = "0x40000AA")]
		InOutSine,
		[Token(Token = "0x40000AB")]
		InQuintic,
		[Token(Token = "0x40000AC")]
		InQuartic,
		[Token(Token = "0x40000AD")]
		InCubic,
		[Token(Token = "0x40000AE")]
		InQuadratic,
		[Token(Token = "0x40000AF")]
		InElastic,
		[Token(Token = "0x40000B0")]
		InElasticSmall,
		[Token(Token = "0x40000B1")]
		InElasticBig,
		[Token(Token = "0x40000B2")]
		InSine,
		[Token(Token = "0x40000B3")]
		InBack,
		[Token(Token = "0x40000B4")]
		OutQuintic,
		[Token(Token = "0x40000B5")]
		OutQuartic,
		[Token(Token = "0x40000B6")]
		OutCubic,
		[Token(Token = "0x40000B7")]
		OutInCubic,
		[Token(Token = "0x40000B8")]
		OutInQuartic,
		[Token(Token = "0x40000B9")]
		OutElastic,
		[Token(Token = "0x40000BA")]
		OutElasticSmall,
		[Token(Token = "0x40000BB")]
		OutElasticBig,
		[Token(Token = "0x40000BC")]
		OutSine,
		[Token(Token = "0x40000BD")]
		OutBack,
		[Token(Token = "0x40000BE")]
		OutBackCubic,
		[Token(Token = "0x40000BF")]
		OutBackQuartic,
		[Token(Token = "0x40000C0")]
		BackInCubic,
		[Token(Token = "0x40000C1")]
		BackInQuartic
	}
	[Token(Token = "0x2000017")]
	public class Interp
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x15B0008", Offset = "0x15B0008", VA = "0x15B0008")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x15B0A70", Offset = "0x15B0A70", VA = "0x15B0A70")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x15B0B78", Offset = "0x15B0B78", VA = "0x15B0B78")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x15B0374", Offset = "0x15B0374", VA = "0x15B0374")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x15B0380", Offset = "0x15B0380", VA = "0x15B0380")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x15B03A4", Offset = "0x15B03A4", VA = "0x15B03A4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x15B03E0", Offset = "0x15B03E0", VA = "0x15B03E0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x15B03F8", Offset = "0x15B03F8", VA = "0x15B03F8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x15B040C", Offset = "0x15B040C", VA = "0x15B040C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x15B0420", Offset = "0x15B0420", VA = "0x15B0420")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x15B0430", Offset = "0x15B0430", VA = "0x15B0430")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x15B0478", Offset = "0x15B0478", VA = "0x15B0478")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x15B04B0", Offset = "0x15B04B0", VA = "0x15B04B0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x15B04D8", Offset = "0x15B04D8", VA = "0x15B04D8")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x15B0C74", Offset = "0x15B0C74", VA = "0x15B0C74")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x15B050C", Offset = "0x15B050C", VA = "0x15B050C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x15B0534", Offset = "0x15B0534", VA = "0x15B0534")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x15B0564", Offset = "0x15B0564", VA = "0x15B0564")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x15B0598", Offset = "0x15B0598", VA = "0x15B0598")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x15B05DC", Offset = "0x15B05DC", VA = "0x15B05DC")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x15B0640", Offset = "0x15B0640", VA = "0x15B0640")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x15B06A4", Offset = "0x15B06A4", VA = "0x15B06A4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x15B06F8", Offset = "0x15B06F8", VA = "0x15B06F8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x15B074C", Offset = "0x15B074C", VA = "0x15B074C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x15B07E4", Offset = "0x15B07E4", VA = "0x15B07E4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x15B0878", Offset = "0x15B0878", VA = "0x15B0878")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x15B0CA8", Offset = "0x15B0CA8", VA = "0x15B0CA8")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x15B091C", Offset = "0x15B091C", VA = "0x15B091C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x15B0A00", Offset = "0x15B0A00", VA = "0x15B0A00")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x15B0A30", Offset = "0x15B0A30", VA = "0x15B0A30")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x15B0D90", Offset = "0x15B0D90", VA = "0x15B0D90")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x15B0D98", Offset = "0x15B0D98", VA = "0x15B0D98")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x15B0E28", Offset = "0x15B0E28", VA = "0x15B0E28")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x15B0EBC", Offset = "0x15B0EBC", VA = "0x15B0EBC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x15B0F14", Offset = "0x15B0F14", VA = "0x15B0F14")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x15B0FE0", Offset = "0x15B0FE0", VA = "0x15B0FE0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x15B0F2C", Offset = "0x15B0F2C", VA = "0x15B0F2C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x15B0FF8", Offset = "0x15B0FF8", VA = "0x15B0FF8")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x15B109C", Offset = "0x15B109C", VA = "0x15B109C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x15B10C8", Offset = "0x15B10C8", VA = "0x15B10C8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x15B1118", Offset = "0x15B1118", VA = "0x15B1118")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x15B1184", Offset = "0x15B1184", VA = "0x15B1184")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x15B1278", Offset = "0x15B1278", VA = "0x15B1278")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x15B1350", Offset = "0x15B1350", VA = "0x15B1350")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x15B13B0", Offset = "0x15B13B0", VA = "0x15B13B0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001A")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x15B13E0", Offset = "0x15B13E0", VA = "0x15B13E0")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x15B14E4", Offset = "0x15B14E4", VA = "0x15B14E4")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x15B15E4", Offset = "0x15B15E4", VA = "0x15B15E4")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x15B17E0", Offset = "0x15B17E0", VA = "0x15B17E0")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x15B1954", Offset = "0x15B1954", VA = "0x15B1954")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x15B1AC0", Offset = "0x15B1AC0", VA = "0x15B1AC0")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x15B1D1C", Offset = "0x15B1D1C", VA = "0x15B1D1C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x15B1E68", Offset = "0x15B1E68", VA = "0x15B1E68")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x15B1FB4", Offset = "0x15B1FB4", VA = "0x15B1FB4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x15B20C8", Offset = "0x15B20C8", VA = "0x15B20C8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x15B21DC", Offset = "0x15B21DC", VA = "0x15B21DC")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x15B2368", Offset = "0x15B2368", VA = "0x15B2368")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x15A0CC4", Offset = "0x15A0CC4", VA = "0x15A0CC4")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x15B2438", Offset = "0x15B2438", VA = "0x15B2438")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x15B26BC", Offset = "0x15B26BC", VA = "0x15B26BC")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x15B28D0", Offset = "0x15B28D0", VA = "0x15B28D0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x15AA054", Offset = "0x15AA054", VA = "0x15AA054")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x15B2A50", Offset = "0x15B2A50", VA = "0x15B2A50")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x15B2B60", Offset = "0x15B2B60", VA = "0x15B2B60")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001B")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000C")]
		public static T instance
		{
			[Token(Token = "0x60000E9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EA")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000EB")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4128", Offset = "0x9B4128")]
		public bool fixTransforms;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000D")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x15B2CF4", Offset = "0x15B2CF4", VA = "0x15B2CF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x15B3028", Offset = "0x15B3028", VA = "0x15B3028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x15B2BBC", Offset = "0x15B2BBC", VA = "0x15B2BBC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x15B2C54", Offset = "0x15B2C54", VA = "0x15B2C54", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x15B2C58", Offset = "0x15B2C58", VA = "0x15B2C58", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x15B2C5C", Offset = "0x15B2C5C", VA = "0x15B2C5C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x15B2C60", Offset = "0x15B2C60", VA = "0x15B2C60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x15B2CF0", Offset = "0x15B2CF0", VA = "0x15B2CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x15B2C98", Offset = "0x15B2C98", VA = "0x15B2C98")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x15B2FDC", Offset = "0x15B2FDC", VA = "0x15B2FDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x15B2DE4", Offset = "0x15B2DE4", VA = "0x15B2DE4")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x15B30E4", Offset = "0x15B30E4", VA = "0x15B30E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x15B3140", Offset = "0x15B3140", VA = "0x15B3140")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x15B319C", Offset = "0x15B319C", VA = "0x15B319C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x159F1B4", Offset = "0x159F1B4", VA = "0x159F1B4")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x15B3254", Offset = "0x15B3254", VA = "0x15B3254")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x15B330C", Offset = "0x15B330C", VA = "0x15B330C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x15B33C4", Offset = "0x15B33C4", VA = "0x15B33C4")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x15B347C", Offset = "0x15B347C", VA = "0x15B347C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class V2Tools
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x15B3484", Offset = "0x15B3484", VA = "0x15B3484")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x15B34B4", Offset = "0x15B34B4", VA = "0x15B34B4")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x15B3560", Offset = "0x15B3560", VA = "0x15B3560")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x15B360C", Offset = "0x15B360C", VA = "0x15B360C")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x15B37DC", Offset = "0x15B37DC", VA = "0x15B37DC")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001F")]
	public static class V3Tools
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1D3CD1C", Offset = "0x1D3CD1C", VA = "0x1D3CD1C")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1D3CDA0", Offset = "0x1D3CDA0", VA = "0x1D3CDA0")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1D3CE40", Offset = "0x1D3CE40", VA = "0x1D3CE40")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1D3CF84", Offset = "0x1D3CF84", VA = "0x1D3CF84")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1D3D0A4", Offset = "0x1D3D0A4", VA = "0x1D3D0A4")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1D3D1BC", Offset = "0x1D3D1BC", VA = "0x1D3D1BC")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1D3D380", Offset = "0x1D3D380", VA = "0x1D3D380")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1D3D478", Offset = "0x1D3D478", VA = "0x1D3D478")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1D3D570", Offset = "0x1D3D570", VA = "0x1D3D570")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1D3D668", Offset = "0x1D3D668", VA = "0x1D3D668")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1D3D768", Offset = "0x1D3D768", VA = "0x1D3D768")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1D3D98C", Offset = "0x1D3D98C", VA = "0x1D3D98C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1D3DBC8", Offset = "0x1D3DBC8", VA = "0x1D3DBC8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1D3DE18", Offset = "0x1D3DE18", VA = "0x1D3DE18")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1D3E018", Offset = "0x1D3E018", VA = "0x1D3E018")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1D3E1F4", Offset = "0x1D3E1F4", VA = "0x1D3E1F4")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1D3E328", Offset = "0x1D3E328", VA = "0x1D3E328")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1D3E480", Offset = "0x1D3E480", VA = "0x1D3E480")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1D3E60C", Offset = "0x1D3E60C", VA = "0x1D3E60C")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1D3E5CC", Offset = "0x1D3E5CC", VA = "0x1D3E5CC")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000020")]
	public static class Warning
	{
		[Token(Token = "0x20000C6")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1D3E748", Offset = "0x1D3E748", VA = "0x1D3E748")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1D3EB74", Offset = "0x1D3EB74", VA = "0x1D3EB74")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3118", Offset = "0x9B3118")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3118", Offset = "0x9B3118")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1252FE0", Offset = "0x1252FE0", VA = "0x1252FE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC244", Offset = "0x9BC244")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x125302C", Offset = "0x125302C", VA = "0x125302C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC27C", Offset = "0x9BC27C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1253078", Offset = "0x1253078", VA = "0x1253078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC2B4", Offset = "0x9BC2B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12530C4", Offset = "0x12530C4", VA = "0x12530C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC2EC", Offset = "0x9BC2EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1253110", Offset = "0x1253110", VA = "0x1253110")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x12531AC", Offset = "0x12531AC", VA = "0x12531AC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x12531CC", Offset = "0x12531CC", VA = "0x12531CC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x12531FC", Offset = "0x12531FC", VA = "0x12531FC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x125322C", Offset = "0x125322C", VA = "0x125322C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x125326C", Offset = "0x125326C", VA = "0x125326C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x12532B0", Offset = "0x12532B0", VA = "0x12532B0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x12532D4", Offset = "0x12532D4", VA = "0x12532D4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x12532F8", Offset = "0x12532F8", VA = "0x12532F8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1253320", Offset = "0x1253320", VA = "0x1253320")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x125334C", Offset = "0x125334C", VA = "0x125334C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1253378", Offset = "0x1253378", VA = "0x1253378")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1253130", Offset = "0x1253130", VA = "0x1253130")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x12533A0", Offset = "0x12533A0", VA = "0x12533A0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x12533AC", Offset = "0x12533AC", VA = "0x12533AC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x12533B8", Offset = "0x12533B8", VA = "0x12533B8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x12536E0", Offset = "0x12536E0", VA = "0x12536E0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1253788", Offset = "0x1253788", VA = "0x1253788", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1253AD4", Offset = "0x1253AD4", VA = "0x1253AD4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1253FBC", Offset = "0x1253FBC", VA = "0x1253FBC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1253FF0", Offset = "0x1253FF0", VA = "0x1253FF0")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000F")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1253558", Offset = "0x1253558", VA = "0x1253558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1254234", Offset = "0x1254234", VA = "0x1254234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1253958", Offset = "0x1253958", VA = "0x1253958")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x125408C", Offset = "0x125408C", VA = "0x125408C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000011")]
		public bool isValid
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1254DB0", Offset = "0x1254DB0", VA = "0x1254DB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000139")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1254E20", Offset = "0x1254E20", VA = "0x1254E20")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1254E28", Offset = "0x1254E28", VA = "0x1254E28", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1254F34", Offset = "0x1254F34", VA = "0x1254F34")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1254F3C", Offset = "0x1254F3C", VA = "0x1254F3C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000012")]
		private bool positionChanged
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x125510C", Offset = "0x125510C", VA = "0x125510C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1254F70", Offset = "0x1254F70", VA = "0x1254F70", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x12551C8", Offset = "0x12551C8", VA = "0x12551C8")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x12551D0", Offset = "0x12551D0", VA = "0x12551D0")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1255204", Offset = "0x1255204", VA = "0x1255204", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x125532C", Offset = "0x125532C", VA = "0x125532C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1255334", Offset = "0x1255334", VA = "0x1255334")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1255508", Offset = "0x1255508", VA = "0x1255508")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1255368", Offset = "0x1255368", VA = "0x1255368", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x12555D8", Offset = "0x12555D8", VA = "0x12555D8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x12555E0", Offset = "0x12555E0", VA = "0x12555E0")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class Constraints
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4160", Offset = "0x9B4160")]
		public float positionWeight;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4178", Offset = "0x9B4178")]
		public float rotationWeight;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1255614", Offset = "0x1255614", VA = "0x1255614")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1253A7C", Offset = "0x1253A7C", VA = "0x1253A7C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1253C5C", Offset = "0x1253C5C", VA = "0x1253C5C")]
		public void Update()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1254464", Offset = "0x1254464", VA = "0x1254464")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public enum DOF
		{
			[Token(Token = "0x40005BE")]
			One,
			[Token(Token = "0x40005BF")]
			Three
		}

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4190", Offset = "0x9B4190")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4190", Offset = "0x9B4190")]
		public float weight;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B41E4", Offset = "0x9B41E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B41E4", Offset = "0x9B41E4")]
		public float rotationWeight;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4238", Offset = "0x9B4238")]
		public DOF rotationDOF;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4270", Offset = "0x9B4270")]
		public bool fixBone1Twist;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B42A8", Offset = "0x9B42A8")]
		public Transform bone1;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B42E0", Offset = "0x9B42E0")]
		public Transform bone2;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4318", Offset = "0x9B4318")]
		public Transform bone3;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4350", Offset = "0x9B4350")]
		public Transform tip;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4388", Offset = "0x9B4388")]
		public Transform target;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B43C0", Offset = "0x9B43C0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x17A0AAC", Offset = "0x17A0AAC", VA = "0x17A0AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC324", Offset = "0x9BC324")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x17A0AB4", Offset = "0x17A0AB4", VA = "0x17A0AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC334", Offset = "0x9BC334")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x17A0AC0", Offset = "0x17A0AC0", VA = "0x17A0AC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x17A0AE0", Offset = "0x17A0AE0", VA = "0x17A0AE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x17A0B00", Offset = "0x17A0B00", VA = "0x17A0B00")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x17A0B20", Offset = "0x17A0B20", VA = "0x17A0B20")]
			set
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x17A0B40", Offset = "0x17A0B40", VA = "0x17A0B40")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x17A0C4C", Offset = "0x17A0C4C", VA = "0x17A0C4C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x17A1464", Offset = "0x17A1464", VA = "0x17A1464")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x17A1540", Offset = "0x17A1540", VA = "0x17A1540")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x17A1608", Offset = "0x17A1608", VA = "0x17A1608")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x17A1C94", Offset = "0x17A1C94", VA = "0x17A1C94")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B43D0", Offset = "0x9B43D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B43D0", Offset = "0x9B43D0")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4424", Offset = "0x9B4424")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool initiated
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x17A1CA4", Offset = "0x17A1CA4", VA = "0x17A1CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC344", Offset = "0x9BC344")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x17A1CAC", Offset = "0x17A1CAC", VA = "0x17A1CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC354", Offset = "0x9BC354")]
			private set
			{
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x17A1CB8", Offset = "0x17A1CB8", VA = "0x17A1CB8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x17A1D40", Offset = "0x17A1D40", VA = "0x17A1D40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC364", Offset = "0x9BC364")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x17A20B8", Offset = "0x17A20B8", VA = "0x17A20B8")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x17A2274", Offset = "0x17A2274", VA = "0x17A2274")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x17A1FA8", Offset = "0x17A1FA8", VA = "0x17A1FA8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x17A23F8", Offset = "0x17A23F8", VA = "0x17A23F8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x17A24B8", Offset = "0x17A24B8", VA = "0x17A24B8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x17A2530", Offset = "0x17A2530", VA = "0x17A2530")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x17A25A4", Offset = "0x17A25A4", VA = "0x17A25A4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x17A260C", Offset = "0x17A260C", VA = "0x17A260C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x17A2610", Offset = "0x17A2610", VA = "0x17A2610", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x17A2624", Offset = "0x17A2624", VA = "0x17A2624")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4434", Offset = "0x9B4434")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4434", Offset = "0x9B4434")]
		public float weight;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4488", Offset = "0x9B4488")]
		public Grounding solver;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B44C0", Offset = "0x9B44C0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x17A36FC", Offset = "0x17A36FC", VA = "0x17A36FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC39C", Offset = "0x9BC39C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x17A3704", Offset = "0x17A3704", VA = "0x17A3704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC3AC", Offset = "0x9BC3AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000167")]
		public abstract void ResetPosition();

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x17A3710", Offset = "0x17A3710", VA = "0x17A3710")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x17A39E4", Offset = "0x17A39E4", VA = "0x17A39E4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x17A3854", Offset = "0x17A3854", VA = "0x17A3854")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x17A3A18", Offset = "0x17A3A18", VA = "0x17A3A18")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600016F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x17A3C20", Offset = "0x17A3C20", VA = "0x17A3C20")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3178", Offset = "0x9B3178")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3178", Offset = "0x9B3178")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B44D0", Offset = "0x9B44D0")]
		public BipedIK ik;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4508", Offset = "0x9B4508")]
		public float spineBend;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4540", Offset = "0x9B4540")]
		public float spineSpeed;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x17A3F98", Offset = "0x17A3F98", VA = "0x17A3F98", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC3BC", Offset = "0x9BC3BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x17A3FE4", Offset = "0x17A3FE4", VA = "0x17A3FE4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC3F4", Offset = "0x9BC3F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x17A4030", Offset = "0x17A4030", VA = "0x17A4030", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x17A4134", Offset = "0x17A4134", VA = "0x17A4134")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x17A41E4", Offset = "0x17A41E4", VA = "0x17A41E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x17A4298", Offset = "0x17A4298", VA = "0x17A4298")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x17A4860", Offset = "0x17A4860", VA = "0x17A4860")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x17A48B4", Offset = "0x17A48B4", VA = "0x17A48B4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x17A50C8", Offset = "0x17A50C8", VA = "0x17A50C8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x17A5228", Offset = "0x17A5228", VA = "0x17A5228")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x17A53B8", Offset = "0x17A53B8", VA = "0x17A53B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x17A555C", Offset = "0x17A555C", VA = "0x17A555C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B31D8", Offset = "0x9B31D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B31D8", Offset = "0x9B31D8")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class SpineEffector
		{
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8A9C", Offset = "0x9B8A9C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8AD4", Offset = "0x9B8AD4")]
			public float horizontalWeight;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8B0C", Offset = "0x9B8B0C")]
			public float verticalWeight;

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x17A6478", Offset = "0x17A6478", VA = "0x17A6478")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x17A6488", Offset = "0x17A6488", VA = "0x17A6488")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4578", Offset = "0x9B4578")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B45B0", Offset = "0x9B45B0")]
		public float spineBend;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B45E8", Offset = "0x9B45E8")]
		public float spineSpeed;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x17A55F4", Offset = "0x17A55F4", VA = "0x17A55F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC42C", Offset = "0x9BC42C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x17A5640", Offset = "0x17A5640", VA = "0x17A5640", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC464", Offset = "0x9BC464")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x17A568C", Offset = "0x17A568C", VA = "0x17A568C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC49C", Offset = "0x9BC49C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x17A56D8", Offset = "0x17A56D8", VA = "0x17A56D8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x17A5758", Offset = "0x17A5758", VA = "0x17A5758")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x17A57F0", Offset = "0x17A57F0", VA = "0x17A57F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x17A5AE8", Offset = "0x17A5AE8", VA = "0x17A5AE8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x17A5AF4", Offset = "0x17A5AF4", VA = "0x17A5AF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x17A58AC", Offset = "0x17A58AC", VA = "0x17A58AC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x17A5B00", Offset = "0x17A5B00", VA = "0x17A5B00")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x17A5FA0", Offset = "0x17A5FA0", VA = "0x17A5FA0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x17A6160", Offset = "0x17A6160", VA = "0x17A6160")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x17A62BC", Offset = "0x17A62BC", VA = "0x17A62BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x17A63E0", Offset = "0x17A63E0", VA = "0x17A63E0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3238", Offset = "0x9B3238")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3238", Offset = "0x9B3238")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4620", Offset = "0x9B4620")]
		public Transform pelvis;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4658", Offset = "0x9B4658")]
		public Transform characterRoot;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4690", Offset = "0x9B4690")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4690", Offset = "0x9B4690")]
		public float rootRotationWeight;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B46E4", Offset = "0x9B46E4")]
		public float rootRotationSpeed;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B471C", Offset = "0x9B471C")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x17A64D0", Offset = "0x17A64D0", VA = "0x17A64D0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC4D4", Offset = "0x9BC4D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x17A651C", Offset = "0x17A651C", VA = "0x17A651C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC50C", Offset = "0x9BC50C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x17A6568", Offset = "0x17A6568", VA = "0x17A6568", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x17A6580", Offset = "0x17A6580", VA = "0x17A6580")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x17A6770", Offset = "0x17A6770", VA = "0x17A6770")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x17A6870", Offset = "0x17A6870", VA = "0x17A6870")]
		private void Update()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x17A6FB8", Offset = "0x17A6FB8", VA = "0x17A6FB8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x17A73F8", Offset = "0x17A73F8", VA = "0x17A73F8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x17A7668", Offset = "0x17A7668", VA = "0x17A7668")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x17A7988", Offset = "0x17A7988", VA = "0x17A7988")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x17A7B24", Offset = "0x17A7B24", VA = "0x17A7B24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x17A7D10", Offset = "0x17A7D10", VA = "0x17A7D10")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3298", Offset = "0x9B3298")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3298", Offset = "0x9B3298")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000CA")]
		public struct Foot
		{
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xA7CE20", Offset = "0xA7CE20", VA = "0xA7CE20")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4754", Offset = "0x9B4754")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B478C", Offset = "0x9B478C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B478C", Offset = "0x9B478C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B47E0", Offset = "0x9B47E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B47E0", Offset = "0x9B47E0")]
		public float minRootRotation;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4838", Offset = "0x9B4838")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4838", Offset = "0x9B4838")]
		public float maxRootRotation;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4890", Offset = "0x9B4890")]
		public float rootRotationSpeed;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B48C8", Offset = "0x9B48C8")]
		public float maxLegOffset;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4900", Offset = "0x9B4900")]
		public float maxForeLegOffset;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4938", Offset = "0x9B4938")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4938", Offset = "0x9B4938")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B498C", Offset = "0x9B498C")]
		public Transform characterRoot;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B49C4", Offset = "0x9B49C4")]
		public Transform pelvis;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B49FC", Offset = "0x9B49FC")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4A34", Offset = "0x9B4A34")]
		public Transform head;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x17A7DA8", Offset = "0x17A7DA8", VA = "0x17A7DA8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC544", Offset = "0x9BC544")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x17A7DF4", Offset = "0x17A7DF4", VA = "0x17A7DF4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC57C", Offset = "0x9BC57C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x17A7E40", Offset = "0x17A7E40", VA = "0x17A7E40", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x17A7E74", Offset = "0x17A7E74", VA = "0x17A7E74")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x17A7FA4", Offset = "0x17A7FA4", VA = "0x17A7FA4")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x17A8164", Offset = "0x17A8164", VA = "0x17A8164")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x17A81CC", Offset = "0x17A81CC", VA = "0x17A81CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x17A8284", Offset = "0x17A8284", VA = "0x17A8284")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x17A85B8", Offset = "0x17A85B8", VA = "0x17A85B8")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x17A8990", Offset = "0x17A8990", VA = "0x17A8990")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x17A8ADC", Offset = "0x17A8ADC", VA = "0x17A8ADC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x17A8F80", Offset = "0x17A8F80", VA = "0x17A8F80")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x17A9770", Offset = "0x17A9770", VA = "0x17A9770")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x17A9A30", Offset = "0x17A9A30", VA = "0x17A9A30")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x17A9B90", Offset = "0x17A9B90", VA = "0x17A9B90")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x17A9E6C", Offset = "0x17A9E6C", VA = "0x17A9E6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x17A9EA4", Offset = "0x17A9EA4", VA = "0x17A9EA4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x17AA088", Offset = "0x17AA088", VA = "0x17AA088")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B32F8", Offset = "0x9B32F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B32F8", Offset = "0x9B32F8")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4A7C", Offset = "0x9B4A7C")]
		public VRIK ik;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x17AA1BC", Offset = "0x17AA1BC", VA = "0x17AA1BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC5B4", Offset = "0x9BC5B4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x17AA208", Offset = "0x17AA208", VA = "0x17AA208", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC5EC", Offset = "0x9BC5EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x17AA254", Offset = "0x17AA254", VA = "0x17AA254", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC624", Offset = "0x9BC624")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x17AA2A0", Offset = "0x17AA2A0", VA = "0x17AA2A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x17AA2B8", Offset = "0x17AA2B8", VA = "0x17AA2B8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x17AA350", Offset = "0x17AA350", VA = "0x17AA350")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x17AA404", Offset = "0x17AA404", VA = "0x17AA404")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x17AA650", Offset = "0x17AA650", VA = "0x17AA650")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x17AA8E4", Offset = "0x17AA8E4", VA = "0x17AA8E4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x17AA9EC", Offset = "0x17AA9EC", VA = "0x17AA9EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x17AABEC", Offset = "0x17AABEC", VA = "0x17AABEC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x17AAD48", Offset = "0x17AAD48", VA = "0x17AAD48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x17AAEDC", Offset = "0x17AAEDC", VA = "0x17AAEDC")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public enum Quality
		{
			[Token(Token = "0x40005C8")]
			Fastest,
			[Token(Token = "0x40005C9")]
			Simple,
			[Token(Token = "0x40005CA")]
			Best
		}

		[Token(Token = "0x20000CC")]
		public class Leg
		{
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8B44", Offset = "0x9B8B44")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8B54", Offset = "0x9B8B54")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8B64", Offset = "0x9B8B64")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8B74", Offset = "0x9B8B74")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8B84", Offset = "0x9B8B84")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8B94", Offset = "0x9B8B94")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8BA4", Offset = "0x9B8BA4")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8BB4", Offset = "0x9B8BB4")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8BC4", Offset = "0x9B8BC4")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000079")]
			public bool isGrounded
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x17AC984", Offset = "0x17AC984", VA = "0x17AC984")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE200", Offset = "0x9BE200")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x17AC98C", Offset = "0x17AC98C", VA = "0x17AC98C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE210", Offset = "0x9BE210")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x17AC998", Offset = "0x17AC998", VA = "0x17AC998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE220", Offset = "0x9BE220")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x17AC9A4", Offset = "0x17AC9A4", VA = "0x17AC9A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE230", Offset = "0x9BE230")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public bool initiated
			{
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x17AC9B0", Offset = "0x17AC9B0", VA = "0x17AC9B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE240", Offset = "0x9BE240")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x17AC9B8", Offset = "0x17AC9B8", VA = "0x17AC9B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE250", Offset = "0x9BE250")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public float heightFromGround
			{
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x17AC9C4", Offset = "0x17AC9C4", VA = "0x17AC9C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE260", Offset = "0x9BE260")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x17AC9CC", Offset = "0x17AC9CC", VA = "0x17AC9CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE270", Offset = "0x9BE270")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x17AC9D4", Offset = "0x17AC9D4", VA = "0x17AC9D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE280", Offset = "0x9BE280")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x17AC9E0", Offset = "0x17AC9E0", VA = "0x17AC9E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE290", Offset = "0x9BE290")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			public Transform transform
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x17AC9EC", Offset = "0x17AC9EC", VA = "0x17AC9EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE2A0", Offset = "0x9BE2A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x17AC9F4", Offset = "0x17AC9F4", VA = "0x17AC9F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE2B0", Offset = "0x9BE2B0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public float IKOffset
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x17AC9FC", Offset = "0x17AC9FC", VA = "0x17AC9FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE2C0", Offset = "0x9BE2C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x17ACA04", Offset = "0x17ACA04", VA = "0x17ACA04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE2D0", Offset = "0x9BE2D0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x17ACA0C", Offset = "0x17ACA0C", VA = "0x17ACA0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE2E0", Offset = "0x9BE2E0")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x17ACA24", Offset = "0x17ACA24", VA = "0x17ACA24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE2F0", Offset = "0x9BE2F0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x17ACA44", Offset = "0x17ACA44", VA = "0x17ACA44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE300", Offset = "0x9BE300")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x17ACA5C", Offset = "0x17ACA5C", VA = "0x17ACA5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE310", Offset = "0x9BE310")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x17ACA7C", Offset = "0x17ACA7C", VA = "0x17ACA7C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000083")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x17AD840", Offset = "0x17AD840", VA = "0x17AD840")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000084")]
			private float rootYOffset
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x17ADB18", Offset = "0x17ADB18", VA = "0x17ADB18")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x17ACAC4", Offset = "0x17ACAC4", VA = "0x17ACAC4")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x17AB58C", Offset = "0x17AB58C", VA = "0x17AB58C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x17ACAD8", Offset = "0x17ACAD8", VA = "0x17ACAD8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x17AC4A4", Offset = "0x17AC4A4", VA = "0x17AC4A4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x17AB6D0", Offset = "0x17AB6D0", VA = "0x17AB6D0")]
			public void Process()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x17AD2B4", Offset = "0x17AD2B4", VA = "0x17AD2B4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x17ACB24", Offset = "0x17ACB24", VA = "0x17ACB24")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x17AD9C0", Offset = "0x17AD9C0", VA = "0x17AD9C0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x17ACF60", Offset = "0x17ACF60", VA = "0x17ACF60")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x17AD068", Offset = "0x17AD068", VA = "0x17AD068")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x17ADABC", Offset = "0x17ADABC", VA = "0x17ADABC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x17AD8CC", Offset = "0x17AD8CC", VA = "0x17AD8CC")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x17ADC40", Offset = "0x17ADC40", VA = "0x17ADC40")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x17AB4DC", Offset = "0x17AB4DC", VA = "0x17AB4DC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000CD")]
		public class Pelvis
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8BD4", Offset = "0x9B8BD4")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8BE4", Offset = "0x9B8BE4")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000085")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x17ADD30", Offset = "0x17ADD30", VA = "0x17ADD30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE320", Offset = "0x9BE320")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x17ADD3C", Offset = "0x17ADD3C", VA = "0x17ADD3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE330", Offset = "0x9BE330")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public float heightOffset
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x17ADD48", Offset = "0x17ADD48", VA = "0x17ADD48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE340", Offset = "0x9BE340")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x17ADD50", Offset = "0x17ADD50", VA = "0x17ADD50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE350", Offset = "0x9BE350")]
				private set
				{
				}
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x17AB688", Offset = "0x17AB688", VA = "0x17AB688")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x17AC3F4", Offset = "0x17AC3F4", VA = "0x17AC3F4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x17ADD58", Offset = "0x17ADD58", VA = "0x17ADD58")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x17AC188", Offset = "0x17AC188", VA = "0x17AC188")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x17AB584", Offset = "0x17AB584", VA = "0x17AB584")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4AB4", Offset = "0x9B4AB4")]
		public LayerMask layers;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4AEC", Offset = "0x9B4AEC")]
		public float maxStep;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4B24", Offset = "0x9B4B24")]
		public float heightOffset;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4B5C", Offset = "0x9B4B5C")]
		public float footSpeed;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4B94", Offset = "0x9B4B94")]
		public float footRadius;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4BCC", Offset = "0x9B4BCC")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4C18", Offset = "0x9B4C18")]
		public float prediction;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4C50", Offset = "0x9B4C50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4C50", Offset = "0x9B4C50")]
		public float footRotationWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4CA4", Offset = "0x9B4CA4")]
		public float footRotationSpeed;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4CDC", Offset = "0x9B4CDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4CDC", Offset = "0x9B4CDC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4D34", Offset = "0x9B4D34")]
		public bool rotateSolver;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4D6C", Offset = "0x9B4D6C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4DA4", Offset = "0x9B4DA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4DA4", Offset = "0x9B4DA4")]
		public float pelvisDamper;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4DF8", Offset = "0x9B4DF8")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4E30", Offset = "0x9B4E30")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4E68", Offset = "0x9B4E68")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4EA0", Offset = "0x9B4EA0")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4ED8", Offset = "0x9B4ED8")]
		public Quality quality;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4F10", Offset = "0x9B4F10")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4F20", Offset = "0x9B4F20")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4F30", Offset = "0x9B4F30")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4F40", Offset = "0x9B4F40")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4F50", Offset = "0x9B4F50")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000019")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x17AAF44", Offset = "0x17AAF44", VA = "0x17AAF44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC65C", Offset = "0x9BC65C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x17AAF4C", Offset = "0x17AAF4C", VA = "0x17AAF4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC66C", Offset = "0x9BC66C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x17AAF54", Offset = "0x17AAF54", VA = "0x17AAF54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC67C", Offset = "0x9BC67C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x17AAF5C", Offset = "0x17AAF5C", VA = "0x17AAF5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC68C", Offset = "0x9BC68C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x17AAF64", Offset = "0x17AAF64", VA = "0x17AAF64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC69C", Offset = "0x9BC69C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x17AAF6C", Offset = "0x17AAF6C", VA = "0x17AAF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC6AC", Offset = "0x9BC6AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Transform root
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x17AAF78", Offset = "0x17AAF78", VA = "0x17AAF78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC6BC", Offset = "0x9BC6BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x17AAF80", Offset = "0x17AAF80", VA = "0x17AAF80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC6CC", Offset = "0x9BC6CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x17AAF88", Offset = "0x17AAF88", VA = "0x17AAF88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC6DC", Offset = "0x9BC6DC")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x17AAFA0", Offset = "0x17AAFA0", VA = "0x17AAFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC6EC", Offset = "0x9BC6EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x17AAFC0", Offset = "0x17AAFC0", VA = "0x17AAFC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 up
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x17A519C", Offset = "0x17A519C", VA = "0x17A519C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x17AC558", Offset = "0x17AC558", VA = "0x17AC558")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x17AB014", Offset = "0x17AB014", VA = "0x17AB014")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x17AB3F4", Offset = "0x17AB3F4", VA = "0x17AB3F4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x17A45A8", Offset = "0x17A45A8", VA = "0x17A45A8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x17A4E20", Offset = "0x17A4E20", VA = "0x17A4E20")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x17A6DA0", Offset = "0x17A6DA0", VA = "0x17A6DA0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x17A40B0", Offset = "0x17A40B0", VA = "0x17A40B0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x17AB6B8", Offset = "0x17AB6B8", VA = "0x17AB6B8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x17AC628", Offset = "0x17AC628", VA = "0x17AC628")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x17AC790", Offset = "0x17AC790", VA = "0x17AC790")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x17AC894", Offset = "0x17AC894", VA = "0x17AC894")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x17A3CEC", Offset = "0x17A3CEC", VA = "0x17A3CEC")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3358", Offset = "0x9B3358")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3358", Offset = "0x9B3358")]
	public class AimIK : IK
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1252330", Offset = "0x1252330", VA = "0x1252330", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC6FC", Offset = "0x9BC6FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x125237C", Offset = "0x125237C", VA = "0x125237C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC734", Offset = "0x9BC734")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x12523C8", Offset = "0x12523C8", VA = "0x12523C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC76C", Offset = "0x9BC76C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1252414", Offset = "0x1252414", VA = "0x1252414")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC7A4", Offset = "0x9BC7A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1252460", Offset = "0x1252460", VA = "0x1252460")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC7DC", Offset = "0x9BC7DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x12524AC", Offset = "0x12524AC", VA = "0x12524AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x12524B4", Offset = "0x12524B4", VA = "0x12524B4")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B33B8", Offset = "0x9B33B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B33B8", Offset = "0x9B33B8")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1252E34", Offset = "0x1252E34", VA = "0x1252E34", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC814", Offset = "0x9BC814")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1252E80", Offset = "0x1252E80", VA = "0x1252E80", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC84C", Offset = "0x9BC84C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1252ECC", Offset = "0x1252ECC", VA = "0x1252ECC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC884", Offset = "0x9BC884")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1252F18", Offset = "0x1252F18", VA = "0x1252F18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC8BC", Offset = "0x9BC8BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1252F64", Offset = "0x1252F64", VA = "0x1252F64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1252F6C", Offset = "0x1252F6C", VA = "0x1252F6C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3418", Offset = "0x9B3418")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3418", Offset = "0x9B3418")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1254C04", Offset = "0x1254C04", VA = "0x1254C04", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC8F4", Offset = "0x9BC8F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1254C50", Offset = "0x1254C50", VA = "0x1254C50", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC92C", Offset = "0x9BC92C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1254C9C", Offset = "0x1254C9C", VA = "0x1254C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC964", Offset = "0x9BC964")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1254CE8", Offset = "0x1254CE8", VA = "0x1254CE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC99C", Offset = "0x9BC99C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1254D34", Offset = "0x1254D34", VA = "0x1254D34", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1254D3C", Offset = "0x1254D3C", VA = "0x1254D3C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3478", Offset = "0x9B3478")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3478", Offset = "0x9B3478")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x12563A0", Offset = "0x12563A0", VA = "0x12563A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BC9D4", Offset = "0x9BC9D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x12563EC", Offset = "0x12563EC", VA = "0x12563EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCA0C", Offset = "0x9BCA0C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1256438", Offset = "0x1256438", VA = "0x1256438")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCA44", Offset = "0x9BCA44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1256484", Offset = "0x1256484", VA = "0x1256484")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCA7C", Offset = "0x9BCA7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x12564D0", Offset = "0x12564D0", VA = "0x12564D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12564D8", Offset = "0x12564D8", VA = "0x12564D8")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B34D8", Offset = "0x9B34D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B34D8", Offset = "0x9B34D8")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1256B7C", Offset = "0x1256B7C", VA = "0x1256B7C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCAB4", Offset = "0x9BCAB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1256BC8", Offset = "0x1256BC8", VA = "0x1256BC8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCAEC", Offset = "0x9BCAEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1256C14", Offset = "0x1256C14", VA = "0x1256C14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCB24", Offset = "0x9BCB24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1256C60", Offset = "0x1256C60", VA = "0x1256C60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCB5C", Offset = "0x9BCB5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1256CAC", Offset = "0x1256CAC", VA = "0x1256CAC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1256CB4", Offset = "0x1256CB4", VA = "0x1256CB4")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3538", Offset = "0x9B3538")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3538", Offset = "0x9B3538")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x17A2698", Offset = "0x17A2698", VA = "0x17A2698", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCB94", Offset = "0x9BCB94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x17A26E4", Offset = "0x17A26E4", VA = "0x17A26E4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCBCC", Offset = "0x9BCBCC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x17A2730", Offset = "0x17A2730", VA = "0x17A2730")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCC04", Offset = "0x9BCC04")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x17A277C", Offset = "0x17A277C", VA = "0x17A277C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCC3C", Offset = "0x9BCC3C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x17A27C8", Offset = "0x17A27C8", VA = "0x17A27C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCC74", Offset = "0x9BCC74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x17A2814", Offset = "0x17A2814", VA = "0x17A2814")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCCAC", Offset = "0x9BCCAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x17A2860", Offset = "0x17A2860", VA = "0x17A2860")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x17A28A4", Offset = "0x17A28A4", VA = "0x17A28A4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x17A28AC", Offset = "0x17A28AC", VA = "0x17A28AC")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x17A2A74", Offset = "0x17A2A74", VA = "0x17A2A74")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x17A2DD4", Offset = "0x17A2DD4", VA = "0x17A2DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCCE4", Offset = "0x9BCCE4")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x17A2DF4", Offset = "0x17A2DF4", VA = "0x17A2DF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCD1C", Offset = "0x9BCD1C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x17A2EE8", Offset = "0x17A2EE8", VA = "0x17A2EE8")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60001FA")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x17B0930", Offset = "0x17B0930", VA = "0x17B0930", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x17B09B4", Offset = "0x17B09B4", VA = "0x17B09B4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x17B0A24", Offset = "0x17B0A24", VA = "0x17B0A24", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001FE")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001FF")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x17A2F88", Offset = "0x17A2F88", VA = "0x17A2F88")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4F60", Offset = "0x9B4F60")]
		public IK[] IKComponents;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4F98", Offset = "0x9B4F98")]
		public Animator animator;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x17B3AD4", Offset = "0x17B3AD4", VA = "0x17B3AD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x17B3B70", Offset = "0x17B3B70", VA = "0x17B3B70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x17B3BE0", Offset = "0x17B3BE0", VA = "0x17B3BE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x17B3C9C", Offset = "0x17B3C9C", VA = "0x17B3C9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x17B3CD8", Offset = "0x17B3CD8", VA = "0x17B3CD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x17B3C14", Offset = "0x17B3C14", VA = "0x17B3C14")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x17B3D64", Offset = "0x17B3D64", VA = "0x17B3D64")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3598", Offset = "0x9B3598")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3598", Offset = "0x9B3598")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x159C35C", Offset = "0x159C35C", VA = "0x159C35C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCD54", Offset = "0x9BCD54")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x159C3A8", Offset = "0x159C3A8", VA = "0x159C3A8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCD8C", Offset = "0x9BCD8C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x159C3F4", Offset = "0x159C3F4", VA = "0x159C3F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCDC4", Offset = "0x9BCDC4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x159C440", Offset = "0x159C440", VA = "0x159C440")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCDFC", Offset = "0x9BCDFC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x159C48C", Offset = "0x159C48C", VA = "0x159C48C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x159C494", Offset = "0x159C494", VA = "0x159C494")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B35F8", Offset = "0x9B35F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B35F8", Offset = "0x9B35F8")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x159C508", Offset = "0x159C508", VA = "0x159C508", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCE34", Offset = "0x9BCE34")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x159C554", Offset = "0x159C554", VA = "0x159C554", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCE6C", Offset = "0x9BCE6C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x159C5A0", Offset = "0x159C5A0", VA = "0x159C5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCEA4", Offset = "0x9BCEA4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x159C5EC", Offset = "0x159C5EC", VA = "0x159C5EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCEDC", Offset = "0x9BCEDC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x159C638", Offset = "0x159C638", VA = "0x159C638", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x159C640", Offset = "0x159C640", VA = "0x159C640")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3658", Offset = "0x9B3658")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3658", Offset = "0x9B3658")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x159D524", Offset = "0x159D524", VA = "0x159D524", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCF14", Offset = "0x9BCF14")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x159D570", Offset = "0x159D570", VA = "0x159D570", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCF4C", Offset = "0x9BCF4C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x159D5BC", Offset = "0x159D5BC", VA = "0x159D5BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCF84", Offset = "0x9BCF84")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x159D608", Offset = "0x159D608", VA = "0x159D608")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCFBC", Offset = "0x9BCFBC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x159D654", Offset = "0x159D654", VA = "0x159D654", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x159D65C", Offset = "0x159D65C", VA = "0x159D65C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B36B8", Offset = "0x9B36B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B36B8", Offset = "0x9B36B8")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x15A62E0", Offset = "0x15A62E0", VA = "0x15A62E0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BCFF4", Offset = "0x9BCFF4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x15A632C", Offset = "0x15A632C", VA = "0x15A632C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD02C", Offset = "0x9BD02C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x15A6378", Offset = "0x15A6378", VA = "0x15A6378")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD064", Offset = "0x9BD064")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x15A63C4", Offset = "0x15A63C4", VA = "0x15A63C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD09C", Offset = "0x9BD09C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x15A6410", Offset = "0x15A6410", VA = "0x15A6410", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x15A6418", Offset = "0x15A6418", VA = "0x15A6418")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3718", Offset = "0x9B3718")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class References
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8BF4", Offset = "0x9B8BF4")]
			public Transform chest;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8C2C", Offset = "0x9B8C2C")]
			public Transform neck;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8C64", Offset = "0x9B8C64")]
			public Transform leftShoulder;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8C9C", Offset = "0x9B8C9C")]
			public Transform rightShoulder;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8CD4", Offset = "0x9B8CD4")]
			public Transform leftThigh;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8D0C", Offset = "0x9B8D0C")]
			public Transform leftCalf;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8D44", Offset = "0x9B8D44")]
			public Transform leftFoot;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8D7C", Offset = "0x9B8D7C")]
			public Transform leftToes;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8DB4", Offset = "0x9B8DB4")]
			public Transform rightThigh;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8DEC", Offset = "0x9B8DEC")]
			public Transform rightCalf;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8E24", Offset = "0x9B8E24")]
			public Transform rightFoot;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8E5C", Offset = "0x9B8E5C")]
			public Transform rightToes;

			[Token(Token = "0x17000087")]
			public bool isFilled
			{
				[Token(Token = "0x600065A")]
				[Address(RVA = "0x15A7F3C", Offset = "0x15A7F3C", VA = "0x15A7F3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000088")]
			public bool isEmpty
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0x15A7AC0", Offset = "0x15A7AC0", VA = "0x15A7AC0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x15A85D8", Offset = "0x15A85D8", VA = "0x15A85D8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x15A759C", Offset = "0x15A759C", VA = "0x15A759C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x15A85D0", Offset = "0x15A85D0", VA = "0x15A85D0")]
			public References()
			{
			}
		}

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x9B4FD0", Offset = "0x9B4FD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4FD0", Offset = "0x9B4FD0")]
		public References references;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B504C", Offset = "0x9B504C")]
		public IKSolverVR solver;

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x15A7490", Offset = "0x15A7490", VA = "0x15A7490", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD0D4", Offset = "0x9BD0D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x15A74DC", Offset = "0x15A74DC", VA = "0x15A74DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD10C", Offset = "0x9BD10C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x15A7528", Offset = "0x15A7528", VA = "0x15A7528")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD144", Offset = "0x9BD144")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x15A7574", Offset = "0x15A7574", VA = "0x15A7574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD17C", Offset = "0x9BD17C")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x15A7A1C", Offset = "0x15A7A1C", VA = "0x15A7A1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD1B4", Offset = "0x9BD1B4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x15A7A44", Offset = "0x15A7A44", VA = "0x15A7A44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x15A7A4C", Offset = "0x15A7A4C", VA = "0x15A7A4C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x15A83B8", Offset = "0x15A83B8", VA = "0x15A83B8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x15A8530", Offset = "0x15A8530", VA = "0x15A8530")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class FABRIKChain
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5084", Offset = "0x9B5084")]
		public float pull;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B509C", Offset = "0x9B509C")]
		public float pin;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x125654C", Offset = "0x125654C", VA = "0x125654C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1256620", Offset = "0x1256620", VA = "0x1256620")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1256640", Offset = "0x1256640", VA = "0x1256640")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1256A10", Offset = "0x1256A10", VA = "0x1256A10")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1256714", Offset = "0x1256714", VA = "0x1256714")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1256B08", Offset = "0x1256B08", VA = "0x1256B08")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1256D28", Offset = "0x1256D28", VA = "0x1256D28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x12572A4", Offset = "0x12572A4", VA = "0x12572A4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1257464", Offset = "0x1257464", VA = "0x1257464")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1257580", Offset = "0x1257580", VA = "0x1257580")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class BendBone
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8E94", Offset = "0x9B8E94")]
			public Transform transform;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8ECC", Offset = "0x9B8ECC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8ECC", Offset = "0x9B8ECC")]
			public float weight;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x125A710", Offset = "0x125A710", VA = "0x125A710")]
			public BendBone()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x125A790", Offset = "0x125A790", VA = "0x125A790")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1257DD0", Offset = "0x1257DD0", VA = "0x1257DD0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x12581D4", Offset = "0x12581D4", VA = "0x12581D4")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B50B4", Offset = "0x9B50B4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B50EC", Offset = "0x9B50EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B50EC", Offset = "0x9B50EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B50EC", Offset = "0x9B50EC")]
		public float positionWeight;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5164", Offset = "0x9B5164")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5164", Offset = "0x9B5164")]
		public float bodyWeight;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B51B8", Offset = "0x9B51B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B51B8", Offset = "0x9B51B8")]
		public float thighWeight;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B520C", Offset = "0x9B520C")]
		public bool handsPullBody;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B5244", Offset = "0x9B5244")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5244", Offset = "0x9B5244")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5244", Offset = "0x9B5244")]
		public float rotationWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B52BC", Offset = "0x9B52BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B52BC", Offset = "0x9B52BC")]
		public float bodyClampWeight;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5310", Offset = "0x9B5310")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5310", Offset = "0x9B5310")]
		public float headClampWeight;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5364", Offset = "0x9B5364")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5364", Offset = "0x9B5364")]
		public float bendWeight;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B53B8", Offset = "0x9B53B8")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B53F0", Offset = "0x9B53F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B53F0", Offset = "0x9B53F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B53F0", Offset = "0x9B53F0")]
		public float CCDWeight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5468", Offset = "0x9B5468")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5468", Offset = "0x9B5468")]
		public float roll;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B54BC", Offset = "0x9B54BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B54BC", Offset = "0x9B54BC")]
		public float damper;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5514", Offset = "0x9B5514")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B554C", Offset = "0x9B554C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B554C", Offset = "0x9B554C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B554C", Offset = "0x9B554C")]
		public float postStretchWeight;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B55C4", Offset = "0x9B55C4")]
		public float maxStretch;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B55FC", Offset = "0x9B55FC")]
		public float stretchDamper;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5634", Offset = "0x9B5634")]
		public bool fixHead;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B566C", Offset = "0x9B566C")]
		public Transform[] stretchBones;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B56A4", Offset = "0x9B56A4")]
		public Vector3 chestDirection;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B56DC", Offset = "0x9B56DC")]
		public float chestDirectionWeight;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1257588", Offset = "0x1257588", VA = "0x1257588")]
		private void Start()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x125790C", Offset = "0x125790C", VA = "0x125790C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1257E08", Offset = "0x1257E08", VA = "0x1257E08")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x12581FC", Offset = "0x12581FC", VA = "0x12581FC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1258B74", Offset = "0x1258B74", VA = "0x1258B74")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1258EC0", Offset = "0x1258EC0", VA = "0x1258EC0")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x125925C", Offset = "0x125925C", VA = "0x125925C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1259CC8", Offset = "0x1259CC8", VA = "0x1259CC8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x12588A0", Offset = "0x12588A0", VA = "0x12588A0")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1259ED8", Offset = "0x1259ED8", VA = "0x1259ED8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1259B84", Offset = "0x1259B84", VA = "0x1259B84")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x12599E8", Offset = "0x12599E8", VA = "0x12599E8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x125A244", Offset = "0x125A244", VA = "0x125A244")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x125A528", Offset = "0x125A528", VA = "0x125A528")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8F40", Offset = "0x9B8F40")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8F50", Offset = "0x9B8F50")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000089")]
			public float nominalDistance
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x17A04C0", Offset = "0x17A04C0", VA = "0x17A04C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE360", Offset = "0x9BE360")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x17A04C8", Offset = "0x17A04C8", VA = "0x17A04C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE370", Offset = "0x9BE370")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isRigid
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x17A04D0", Offset = "0x17A04D0", VA = "0x17A04D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE380", Offset = "0x9BE380")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x17A04D8", Offset = "0x17A04D8", VA = "0x17A04D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE390", Offset = "0x9BE390")]
				private set
				{
				}
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x17A04E4", Offset = "0x17A04E4", VA = "0x17A04E4")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x17A054C", Offset = "0x17A054C", VA = "0x17A054C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x17A05A4", Offset = "0x17A05A4", VA = "0x17A05A4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x17A07A8", Offset = "0x17A07A8", VA = "0x17A07A8")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public enum Smoothing
		{
			[Token(Token = "0x400060B")]
			None,
			[Token(Token = "0x400060C")]
			Exponential,
			[Token(Token = "0x400060D")]
			Cubic
		}

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B56F4", Offset = "0x9B56F4")]
		public float pin;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B570C", Offset = "0x9B570C")]
		public float pull;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5724", Offset = "0x9B5724")]
		public float push;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B573C", Offset = "0x9B573C")]
		public float pushParent;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5754", Offset = "0x9B5754")]
		public float reach;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001BE")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x125A840", Offset = "0x125A840", VA = "0x125A840")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x125A93C", Offset = "0x125A93C", VA = "0x125A93C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x125AA8C", Offset = "0x125AA8C", VA = "0x125AA8C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x125ABC0", Offset = "0x125ABC0", VA = "0x125ABC0")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x125AC9C", Offset = "0x125AC9C", VA = "0x125AC9C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x125ADAC", Offset = "0x125ADAC", VA = "0x125ADAC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x125B4CC", Offset = "0x125B4CC", VA = "0x125B4CC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x125AF4C", Offset = "0x125AF4C", VA = "0x125AF4C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x125B9B8", Offset = "0x125B9B8", VA = "0x125B9B8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x125BD5C", Offset = "0x125BD5C", VA = "0x125BD5C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x125C140", Offset = "0x125C140", VA = "0x125C140")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x125C6C4", Offset = "0x125C6C4", VA = "0x125C6C4")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x125CC98", Offset = "0x125CC98", VA = "0x125CC98")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x125CF30", Offset = "0x125CF30", VA = "0x125CF30")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x125CB90", Offset = "0x125CB90", VA = "0x125CB90")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x125C4AC", Offset = "0x125C4AC", VA = "0x125C4AC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x125CB14", Offset = "0x125CB14", VA = "0x125CB14")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x125D018", Offset = "0x125D018", VA = "0x125D018")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x125CA34", Offset = "0x125CA34", VA = "0x125CA34")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x125CE18", Offset = "0x125CE18", VA = "0x125CE18")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B576C", Offset = "0x9B576C")]
		public float weight;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5784", Offset = "0x9B5784")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x17B0C4C", Offset = "0x17B0C4C", VA = "0x17B0C4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD1EC", Offset = "0x9BD1EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x17B0C54", Offset = "0x17B0C54", VA = "0x17B0C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD1FC", Offset = "0x9BD1FC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x17B0A84", Offset = "0x17B0A84", VA = "0x17B0A84")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x17B0C60", Offset = "0x17B0C60", VA = "0x17B0C60")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x17B0CE4", Offset = "0x17B0CE4", VA = "0x17B0CE4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x17B0D98", Offset = "0x17B0D98", VA = "0x17B0D98")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x17B0DE8", Offset = "0x17B0DE8", VA = "0x17B0DE8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x17B12D8", Offset = "0x17B12D8", VA = "0x17B12D8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x17B1510", Offset = "0x17B1510", VA = "0x17B1510")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x17B19AC", Offset = "0x17B19AC", VA = "0x17B19AC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x17B1098", Offset = "0x17B1098", VA = "0x17B1098")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x17B11B8", Offset = "0x17B11B8", VA = "0x17B11B8")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKEffector
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5794", Offset = "0x9B5794")]
		public float positionWeight;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B57AC", Offset = "0x9B57AC")]
		public float rotationWeight;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B57C4", Offset = "0x9B57C4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B57D4", Offset = "0x9B57D4")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000023")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x17B2018", Offset = "0x17B2018", VA = "0x17B2018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD20C", Offset = "0x9BD20C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x17B2020", Offset = "0x17B2020", VA = "0x17B2020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD21C", Offset = "0x9BD21C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x17B1FB0", Offset = "0x17B1FB0", VA = "0x17B1FB0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x17B202C", Offset = "0x17B202C", VA = "0x17B202C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x17B2100", Offset = "0x17B2100", VA = "0x17B2100")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x17B226C", Offset = "0x17B226C", VA = "0x17B226C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x17B2414", Offset = "0x17B2414", VA = "0x17B2414")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x17B2710", Offset = "0x17B2710", VA = "0x17B2710")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x17B29E8", Offset = "0x17B29E8", VA = "0x17B29E8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x17B2B28", Offset = "0x17B2B28", VA = "0x17B2B28")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x17B2BD4", Offset = "0x17B2BD4", VA = "0x17B2BD4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x17B3228", Offset = "0x17B3228", VA = "0x17B3228")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x17B3298", Offset = "0x17B3298", VA = "0x17B3298")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x17B34B0", Offset = "0x17B34B0", VA = "0x17B34B0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x17B37F8", Offset = "0x17B37F8", VA = "0x17B37F8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class BoneMap
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700008B")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x17B4008", Offset = "0x17B4008", VA = "0x17B4008")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008C")]
			public bool isNodeBone
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x17B4174", Offset = "0x17B4174", VA = "0x17B4174")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008D")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x17B4784", Offset = "0x17B4784", VA = "0x17B4784")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x17B3FB8", Offset = "0x17B3FB8", VA = "0x17B3FB8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x17B40D4", Offset = "0x17B40D4", VA = "0x17B40D4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x17B4124", Offset = "0x17B4124", VA = "0x17B4124")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x17B4184", Offset = "0x17B4184", VA = "0x17B4184")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x17B426C", Offset = "0x17B426C", VA = "0x17B426C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x17B4274", Offset = "0x17B4274", VA = "0x17B4274")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x17B4404", Offset = "0x17B4404", VA = "0x17B4404")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x17B4510", Offset = "0x17B4510", VA = "0x17B4510")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x17B45D4", Offset = "0x17B45D4", VA = "0x17B45D4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x17B49A8", Offset = "0x17B49A8", VA = "0x17B49A8")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x17B49E0", Offset = "0x17B49E0", VA = "0x17B49E0")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x17B4A18", Offset = "0x17B4A18", VA = "0x17B4A18")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x17B4A40", Offset = "0x17B4A40", VA = "0x17B4A40")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x17B4B6C", Offset = "0x17B4B6C", VA = "0x17B4B6C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x17B4EB4", Offset = "0x17B4EB4", VA = "0x17B4EB4")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x17B4EE4", Offset = "0x17B4EE4", VA = "0x17B4EE4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x17B507C", Offset = "0x17B507C", VA = "0x17B507C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x17B50EC", Offset = "0x17B50EC", VA = "0x17B50EC")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x17B5330", Offset = "0x17B5330", VA = "0x17B5330")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x17B5558", Offset = "0x17B5558", VA = "0x17B5558")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x17B5670", Offset = "0x17B5670", VA = "0x17B5670")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x17B4CB0", Offset = "0x17B4CB0", VA = "0x17B4CB0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x17B580C", Offset = "0x17B580C", VA = "0x17B580C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x17B3D6C", Offset = "0x17B3D6C", VA = "0x17B3D6C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x17B3D74", Offset = "0x17B3D74", VA = "0x17B3D74", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x17B3D78", Offset = "0x17B3D78", VA = "0x17B3D78")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x17B3EA8", Offset = "0x17B3EA8", VA = "0x17B3EA8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x17B3FB0", Offset = "0x17B3FB0", VA = "0x17B3FB0")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B57EC", Offset = "0x9B57EC")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x17B5828", Offset = "0x17B5828", VA = "0x17B5828", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x17B58D4", Offset = "0x17B58D4", VA = "0x17B58D4")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x17B5964", Offset = "0x17B5964", VA = "0x17B5964")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x17B5A10", Offset = "0x17B5A10", VA = "0x17B5A10")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x17B5A28", Offset = "0x17B5A28", VA = "0x17B5A28")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x17B5A44", Offset = "0x17B5A44", VA = "0x17B5A44", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x17B5AF0", Offset = "0x17B5AF0", VA = "0x17B5AF0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x17B5B08", Offset = "0x17B5B08", VA = "0x17B5B08")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000625")]
			Parent,
			[Token(Token = "0x4000626")]
			Bone1,
			[Token(Token = "0x4000627")]
			Bone2,
			[Token(Token = "0x4000628")]
			Bone3
		}

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5804", Offset = "0x9B5804")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B581C", Offset = "0x9B581C")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x17B5B2C", Offset = "0x17B5B2C", VA = "0x17B5B2C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x17B5BB0", Offset = "0x17B5BB0", VA = "0x17B5BB0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x17B5C84", Offset = "0x17B5C84", VA = "0x17B5C84")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x17B5FD8", Offset = "0x17B5FD8", VA = "0x17B5FD8")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x17B6110", Offset = "0x17B6110", VA = "0x17B6110")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x17B6280", Offset = "0x17B6280", VA = "0x17B6280")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x17B62E4", Offset = "0x17B62E4", VA = "0x17B62E4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x17B638C", Offset = "0x17B638C", VA = "0x17B638C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x17B6444", Offset = "0x17B6444", VA = "0x17B6444", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x17B670C", Offset = "0x17B670C", VA = "0x17B670C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x17B67C4", Offset = "0x17B67C4", VA = "0x17B67C4")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5834", Offset = "0x9B5834")]
		public int iterations;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B584C", Offset = "0x9B584C")]
		public float twistWeight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x17B6930", Offset = "0x17B6930", VA = "0x17B6930", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x17B6C28", Offset = "0x17B6C28", VA = "0x17B6C28")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x17B6D80", Offset = "0x17B6D80", VA = "0x17B6D80")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x17B6F20", Offset = "0x17B6F20", VA = "0x17B6F20")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x17B6FA0", Offset = "0x17B6FA0", VA = "0x17B6FA0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x17B7008", Offset = "0x17B7008", VA = "0x17B7008")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x17B7088", Offset = "0x17B7088", VA = "0x17B7088", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x17B7760", Offset = "0x17B7760", VA = "0x17B7760")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x17B7798", Offset = "0x17B7798", VA = "0x17B7798")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x17B7A78", Offset = "0x17B7A78", VA = "0x17B7A78")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x17B7E2C", Offset = "0x17B7E2C", VA = "0x17B7E2C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x17B7F18", Offset = "0x17B7F18", VA = "0x17B7F18")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x17B7FE0", Offset = "0x17B7FE0", VA = "0x17B7FE0")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public class Point
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8F60", Offset = "0x9B8F60")]
			public float weight;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x1786A04", Offset = "0x1786A04", VA = "0x1786A04")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1786A54", Offset = "0x1786A54", VA = "0x1786A54")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x1786BDC", Offset = "0x1786BDC", VA = "0x1786BDC")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1786C14", Offset = "0x1786C14", VA = "0x1786C14")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1786C4C", Offset = "0x1786C4C", VA = "0x1786C4C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1786C9C", Offset = "0x1786C9C", VA = "0x1786C9C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x17864AC", Offset = "0x17864AC", VA = "0x17864AC")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Bone : Point
		{
			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700008E")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600068B")]
				[Address(RVA = "0x1785A68", Offset = "0x1785A68", VA = "0x1785A68")]
				get
				{
					return null;
				}
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x1785B64", Offset = "0x1785B64", VA = "0x1785B64")]
				set
				{
				}
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1785BF8", Offset = "0x1785BF8", VA = "0x1785BF8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1785EB8", Offset = "0x1785EB8", VA = "0x1785EB8")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1786198", Offset = "0x1786198", VA = "0x1786198")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1786400", Offset = "0x1786400", VA = "0x1786400")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1786428", Offset = "0x1786428", VA = "0x1786428")]
			public Bone()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x178652C", Offset = "0x178652C", VA = "0x178652C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x17865CC", Offset = "0x17865CC", VA = "0x17865CC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Node : Point
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x178698C", Offset = "0x178698C", VA = "0x178698C")]
			public Node()
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1786990", Offset = "0x1786990", VA = "0x1786990")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x17869C0", Offset = "0x17869C0", VA = "0x17869C0")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000D7")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000D8")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5884", Offset = "0x9B5884")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5884", Offset = "0x9B5884")]
		public float IKPositionWeight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B58D8", Offset = "0x9B58D8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000024")]
		public bool initiated
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x17B83F0", Offset = "0x17B83F0", VA = "0x17B83F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD22C", Offset = "0x9BD22C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x17B83F8", Offset = "0x17B83F8", VA = "0x17B83F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD23C", Offset = "0x9BD23C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x17B82C8", Offset = "0x17B82C8", VA = "0x17B82C8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x17A12FC", Offset = "0x17A12FC", VA = "0x17A12FC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x17A1C24", Offset = "0x17A1C24", VA = "0x17A1C24")]
		public void Update()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x17B8344", Offset = "0x17B8344", VA = "0x17B8344", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x17B8350", Offset = "0x17B8350", VA = "0x17B8350")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x17B835C", Offset = "0x17B835C", VA = "0x17B835C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x17B8364", Offset = "0x17B8364", VA = "0x17B8364")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x17B83E8", Offset = "0x17B83E8", VA = "0x17B83E8")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002A1")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002A2")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002A3")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002A4")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002A5")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x17B8404", Offset = "0x17B8404", VA = "0x17B8404")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x17B841C", Offset = "0x17B841C", VA = "0x17B841C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x17B8558", Offset = "0x17B8558", VA = "0x17B8558")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x17B8604", Offset = "0x17B8604", VA = "0x17B8604")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x17B8988", Offset = "0x17B8988", VA = "0x17B8988")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5920", Offset = "0x9B5920")]
		public float poleWeight;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5938", Offset = "0x9B5938")]
		public float clampWeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5950", Offset = "0x9B5950")]
		public int clampSmoothing;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000025")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1787044", Offset = "0x1787044", VA = "0x1787044")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1787110", Offset = "0x1787110", VA = "0x1787110")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		protected override int minBones
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1787E9C", Offset = "0x1787E9C", VA = "0x1787E9C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1788440", Offset = "0x1788440", VA = "0x1788440", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1786F44", Offset = "0x1786F44", VA = "0x1786F44")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x17871DC", Offset = "0x17871DC", VA = "0x17871DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x178745C", Offset = "0x178745C", VA = "0x178745C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1787DE8", Offset = "0x1787DE8", VA = "0x1787DE8")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1787A10", Offset = "0x1787A10", VA = "0x1787A10")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1787EA4", Offset = "0x1787EA4", VA = "0x1787EA4")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x17884B4", Offset = "0x17884B4", VA = "0x17884B4")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5968", Offset = "0x9B5968")]
		public float IKRotationWeight;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x17885C4", Offset = "0x17885C4", VA = "0x17885C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1788980", Offset = "0x1788980", VA = "0x1788980")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1788A38", Offset = "0x1788A38", VA = "0x1788A38", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1788BD0", Offset = "0x1788BD0", VA = "0x1788BD0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1788D68", Offset = "0x1788D68", VA = "0x1788D68", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1788DB4", Offset = "0x1788DB4", VA = "0x1788DB4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1788E14", Offset = "0x1788E14", VA = "0x1788E14", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1789184", Offset = "0x1789184", VA = "0x1789184", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x17891B0", Offset = "0x17891B0", VA = "0x17891B0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1788E78", Offset = "0x1788E78", VA = "0x1788E78")]
		private void Read()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1789220", Offset = "0x1789220", VA = "0x1789220")]
		private void Write()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x17893AC", Offset = "0x17893AC", VA = "0x17893AC")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1789550", Offset = "0x1789550", VA = "0x1789550")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1789600", Offset = "0x1789600", VA = "0x1789600", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1789BF4", Offset = "0x1789BF4", VA = "0x1789BF4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x178A344", Offset = "0x178A344", VA = "0x178A344")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x178AA98", Offset = "0x178AA98", VA = "0x178AA98")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000029")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x178BCCC", Offset = "0x178BCCC", VA = "0x178BCCC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x178AA9C", Offset = "0x178AA9C", VA = "0x178AA9C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x178B1E0", Offset = "0x178B1E0", VA = "0x178B1E0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x178B314", Offset = "0x178B314", VA = "0x178B314", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x178B3AC", Offset = "0x178B3AC", VA = "0x178B3AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x178B96C", Offset = "0x178B96C", VA = "0x178B96C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x178BCD4", Offset = "0x178BCD4", VA = "0x178BCD4")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x178AB6C", Offset = "0x178AB6C", VA = "0x178AB6C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x178B2C0", Offset = "0x178B2C0", VA = "0x178B2C0")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x178BC70", Offset = "0x178BC70", VA = "0x178BC70")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x178B008", Offset = "0x178B008", VA = "0x178B008")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x178C514", Offset = "0x178C514", VA = "0x178C514")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x178C624", Offset = "0x178C624", VA = "0x178C624")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x178C750", Offset = "0x178C750", VA = "0x178C750")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x178C868", Offset = "0x178C868", VA = "0x178C868")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x178B6D4", Offset = "0x178B6D4", VA = "0x178B6D4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x178B820", Offset = "0x178B820", VA = "0x178B820")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x178CA54", Offset = "0x178CA54", VA = "0x178CA54")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x178BF8C", Offset = "0x178BF8C", VA = "0x178BF8C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x178B2B0", Offset = "0x178B2B0", VA = "0x178B2B0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x178D1BC", Offset = "0x178D1BC", VA = "0x178D1BC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x178CC28", Offset = "0x178CC28", VA = "0x178CC28")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x178BDEC", Offset = "0x178BDEC", VA = "0x178BDEC")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x178BEC8", Offset = "0x178BEC8", VA = "0x178BEC8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x178D288", Offset = "0x178D288", VA = "0x178D288")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5980", Offset = "0x9B5980")]
		public float rootPin;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x178D314", Offset = "0x178D314", VA = "0x178D314", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x178DCEC", Offset = "0x178DCEC", VA = "0x178DCEC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x178DD84", Offset = "0x178DD84", VA = "0x178DD84", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x178DE24", Offset = "0x178DE24", VA = "0x178DE24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x178DF34", Offset = "0x178DF34", VA = "0x178DF34")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x178DFD0", Offset = "0x178DFD0", VA = "0x178DFD0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x178E538", Offset = "0x178E538", VA = "0x178E538", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x178E750", Offset = "0x178E750", VA = "0x178E750", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x178E5E8", Offset = "0x178E5E8", VA = "0x178E5E8")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x178E204", Offset = "0x178E204", VA = "0x178E204")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x178E7E8", Offset = "0x178E7E8", VA = "0x178E7E8")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5998", Offset = "0x9B5998")]
		public int iterations;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x178E85C", Offset = "0x178E85C", VA = "0x178E85C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x178E950", Offset = "0x178E950", VA = "0x178E950")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x178E9AC", Offset = "0x178E9AC", VA = "0x178E9AC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x178EAE0", Offset = "0x178EAE0", VA = "0x178EAE0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x178EB3C", Offset = "0x178EB3C", VA = "0x178EB3C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x178EBBC", Offset = "0x178EBBC", VA = "0x178EBBC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x178ED6C", Offset = "0x178ED6C", VA = "0x178ED6C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x178EEE0", Offset = "0x178EEE0", VA = "0x178EEE0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x178F0E8", Offset = "0x178F0E8", VA = "0x178F0E8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x178F1BC", Offset = "0x178F1BC", VA = "0x178F1BC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x178F2A4", Offset = "0x178F2A4", VA = "0x178F2A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x178F418", Offset = "0x178F418", VA = "0x178F418", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x178F5D4", Offset = "0x178F5D4", VA = "0x178F5D4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x178F820", Offset = "0x178F820", VA = "0x178F820", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x178FAF0", Offset = "0x178FAF0", VA = "0x178FAF0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x178FB34", Offset = "0x178FB34", VA = "0x178FB34", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x178FC24", Offset = "0x178FC24", VA = "0x178FC24")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000249")]
		Body,
		[Token(Token = "0x400024A")]
		LeftShoulder,
		[Token(Token = "0x400024B")]
		RightShoulder,
		[Token(Token = "0x400024C")]
		LeftThigh,
		[Token(Token = "0x400024D")]
		RightThigh,
		[Token(Token = "0x400024E")]
		LeftHand,
		[Token(Token = "0x400024F")]
		RightHand,
		[Token(Token = "0x4000250")]
		LeftFoot,
		[Token(Token = "0x4000251")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000253")]
		LeftArm,
		[Token(Token = "0x4000254")]
		RightArm,
		[Token(Token = "0x4000255")]
		LeftLeg,
		[Token(Token = "0x4000256")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B59B0", Offset = "0x9B59B0")]
		public float spineStiffness;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B59C8", Offset = "0x9B59C8")]
		public float pullBodyVertical;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B59E0", Offset = "0x9B59E0")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B59F8", Offset = "0x9B59F8")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700002A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x178FD38", Offset = "0x178FD38", VA = "0x178FD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x178FE80", Offset = "0x178FE80", VA = "0x178FE80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x178FE88", Offset = "0x178FE88", VA = "0x178FE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x178FE90", Offset = "0x178FE90", VA = "0x178FE90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x178FE98", Offset = "0x178FE98", VA = "0x178FE98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x178FEA0", Offset = "0x178FEA0", VA = "0x178FEA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x178FEA8", Offset = "0x178FEA8", VA = "0x178FEA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x178FEB0", Offset = "0x178FEB0", VA = "0x178FEB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x178FEB8", Offset = "0x178FEB8", VA = "0x178FEB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x178FEC0", Offset = "0x178FEC0", VA = "0x178FEC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x178FEF8", Offset = "0x178FEF8", VA = "0x178FEF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x178FF30", Offset = "0x178FF30", VA = "0x178FF30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x178FF68", Offset = "0x178FF68", VA = "0x178FF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x178FFA0", Offset = "0x178FFA0", VA = "0x178FFA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x178FFD4", Offset = "0x178FFD4", VA = "0x178FFD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x179000C", Offset = "0x179000C", VA = "0x179000C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1790044", Offset = "0x1790044", VA = "0x1790044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x179007C", Offset = "0x179007C", VA = "0x179007C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1792308", Offset = "0x1792308", VA = "0x1792308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD24C", Offset = "0x9BD24C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1792314", Offset = "0x1792314", VA = "0x1792314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD25C", Offset = "0x9BD25C")]
			private set
			{
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x17900B0", Offset = "0x17900B0", VA = "0x17900B0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x17901BC", Offset = "0x17901BC", VA = "0x17901BC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1790104", Offset = "0x1790104", VA = "0x1790104")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1790298", Offset = "0x1790298", VA = "0x1790298")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x178FD40", Offset = "0x178FD40", VA = "0x178FD40")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1790368", Offset = "0x1790368", VA = "0x1790368")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1790420", Offset = "0x1790420", VA = "0x1790420")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x17904D4", Offset = "0x17904D4", VA = "0x17904D4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1790588", Offset = "0x1790588", VA = "0x1790588")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1790590", Offset = "0x1790590", VA = "0x1790590")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x17905C4", Offset = "0x17905C4", VA = "0x17905C4")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x179068C", Offset = "0x179068C", VA = "0x179068C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1790820", Offset = "0x1790820", VA = "0x1790820")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1791C20", Offset = "0x1791C20", VA = "0x1791C20")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x17920B4", Offset = "0x17920B4", VA = "0x17920B4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1792114", Offset = "0x1792114", VA = "0x1792114")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1791F34", Offset = "0x1791F34", VA = "0x1791F34")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1791FF4", Offset = "0x1791FF4", VA = "0x1791FF4")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1792320", Offset = "0x1792320", VA = "0x1792320")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x17923FC", Offset = "0x17923FC", VA = "0x17923FC", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1792544", Offset = "0x1792544", VA = "0x1792544")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x17926D4", Offset = "0x17926D4", VA = "0x17926D4")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x17928D4", Offset = "0x17928D4", VA = "0x17928D4")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1792AD4", Offset = "0x1792AD4", VA = "0x1792AD4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1792E08", Offset = "0x1792E08", VA = "0x1792E08", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1792F08", Offset = "0x1792F08", VA = "0x1792F08")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700003D")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x17937A0", Offset = "0x17937A0", VA = "0x17937A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x17937A8", Offset = "0x17937A8", VA = "0x17937A8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x17937B0", Offset = "0x17937B0", VA = "0x17937B0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x17937C0", Offset = "0x17937C0", VA = "0x17937C0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000041")]
		protected float positionOffset
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x178A280", Offset = "0x178A280", VA = "0x178A280")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1792F14", Offset = "0x1792F14", VA = "0x1792F14")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x17930C4", Offset = "0x17930C4", VA = "0x17930C4")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1793228", Offset = "0x1793228", VA = "0x1793228", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1793290", Offset = "0x1793290", VA = "0x1793290", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x179330C", Offset = "0x179330C", VA = "0x179330C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x17936A4", Offset = "0x17936A4", VA = "0x17936A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x17936AC", Offset = "0x17936AC", VA = "0x17936AC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x17937B8", Offset = "0x17937B8", VA = "0x17937B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x17937BC", Offset = "0x17937BC", VA = "0x17937BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1789680", Offset = "0x1789680", VA = "0x1789680")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1789EE8", Offset = "0x1789EE8", VA = "0x1789EE8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x17938F4", Offset = "0x17938F4", VA = "0x17938F4")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1788548", Offset = "0x1788548", VA = "0x1788548")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A08", Offset = "0x9B5A08")]
		public float IKRotationWeight;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1793BA8", Offset = "0x1793BA8", VA = "0x1793BA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1793F64", Offset = "0x1793F64", VA = "0x1793F64")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x179401C", Offset = "0x179401C", VA = "0x179401C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x17941B4", Offset = "0x17941B4", VA = "0x17941B4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x179434C", Offset = "0x179434C", VA = "0x179434C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1794398", Offset = "0x1794398", VA = "0x1794398", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x17943F8", Offset = "0x17943F8", VA = "0x17943F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1794768", Offset = "0x1794768", VA = "0x1794768", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1794794", Offset = "0x1794794", VA = "0x1794794")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x179445C", Offset = "0x179445C", VA = "0x179445C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x17948A0", Offset = "0x17948A0", VA = "0x17948A0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1794A2C", Offset = "0x1794A2C", VA = "0x1794A2C")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public enum BendModifier
		{
			[Token(Token = "0x4000639")]
			Animation,
			[Token(Token = "0x400063A")]
			Target,
			[Token(Token = "0x400063B")]
			Parent,
			[Token(Token = "0x400063C")]
			Arm,
			[Token(Token = "0x400063D")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000DA")]
		public struct AxisDirection
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xA7CDD0", Offset = "0xA7CDD0", VA = "0xA7CDD0")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A20", Offset = "0x9B5A20")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A38", Offset = "0x9B5A38")]
		public float bendModifierWeight;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000042")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1796314", Offset = "0x1796314", VA = "0x1796314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1794BD0", Offset = "0x1794BD0", VA = "0x1794BD0")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1794C20", Offset = "0x1794C20", VA = "0x1794C20")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1794D34", Offset = "0x1794D34", VA = "0x1794D34", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x179539C", Offset = "0x179539C", VA = "0x179539C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1795F78", Offset = "0x1795F78", VA = "0x1795F78", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x17960C0", Offset = "0x17960C0", VA = "0x17960C0")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1796274", Offset = "0x1796274", VA = "0x1796274")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x17950A8", Offset = "0x17950A8", VA = "0x17950A8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x17954C8", Offset = "0x17954C8", VA = "0x17954C8")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x1700008F")]
			public Vector3 forward
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x1798494", Offset = "0x1798494", VA = "0x1798494")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1798C34", Offset = "0x1798C34", VA = "0x1798C34")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x17975E8", Offset = "0x17975E8", VA = "0x17975E8")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x179796C", Offset = "0x179796C", VA = "0x179796C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1798898", Offset = "0x1798898", VA = "0x1798898")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A50", Offset = "0x9B5A50")]
		public float bodyWeight;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A68", Offset = "0x9B5A68")]
		public float headWeight;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A80", Offset = "0x9B5A80")]
		public float eyesWeight;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A98", Offset = "0x9B5A98")]
		public float clampWeight;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5AB0", Offset = "0x9B5AB0")]
		public float clampWeightHead;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5AC8", Offset = "0x9B5AC8")]
		public float clampWeightEyes;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5AE0", Offset = "0x9B5AE0")]
		public int clampSmoothing;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000043")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1796CD4", Offset = "0x1796CD4", VA = "0x1796CD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1796EAC", Offset = "0x1796EAC", VA = "0x1796EAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1796DB8", Offset = "0x1796DB8", VA = "0x1796DB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1796ED0", Offset = "0x1796ED0", VA = "0x1796ED0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1796DC8", Offset = "0x1796DC8", VA = "0x1796DC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1796F4C", Offset = "0x1796F4C", VA = "0x1796F4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1796390", Offset = "0x1796390", VA = "0x1796390")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1796414", Offset = "0x1796414", VA = "0x1796414")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x17964C0", Offset = "0x17964C0", VA = "0x17964C0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1796588", Offset = "0x1796588", VA = "0x1796588")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1796674", Offset = "0x1796674", VA = "0x1796674")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1796780", Offset = "0x1796780", VA = "0x1796780")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x17968C8", Offset = "0x17968C8", VA = "0x17968C8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x17969EC", Offset = "0x17969EC", VA = "0x17969EC")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x17969F8", Offset = "0x17969F8", VA = "0x17969F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1796B34", Offset = "0x1796B34", VA = "0x1796B34", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1796F70", Offset = "0x1796F70", VA = "0x1796F70", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x17971D8", Offset = "0x17971D8", VA = "0x17971D8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1797378", Offset = "0x1797378", VA = "0x1797378")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1797618", Offset = "0x1797618", VA = "0x1797618", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1797AA8", Offset = "0x1797AA8", VA = "0x1797AA8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1797BAC", Offset = "0x1797BAC", VA = "0x1797BAC")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1797DD8", Offset = "0x1797DD8", VA = "0x1797DD8")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1798034", Offset = "0x1798034", VA = "0x1798034")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1798560", Offset = "0x1798560", VA = "0x1798560")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x179743C", Offset = "0x179743C", VA = "0x179743C")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1798A00", Offset = "0x1798A00", VA = "0x1798A00")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x179A26C", Offset = "0x179A26C", VA = "0x179A26C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x179AE24", Offset = "0x179AE24", VA = "0x179AE24")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1794C68", Offset = "0x1794C68", VA = "0x1794C68")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x179AEEC", Offset = "0x179AEEC", VA = "0x179AEEC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5AF8", Offset = "0x9B5AF8")]
		public float IKRotationWeight;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1798C38", Offset = "0x1798C38", VA = "0x1798C38")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1798E28", Offset = "0x1798E28", VA = "0x1798E28")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1798FDC", Offset = "0x1798FDC", VA = "0x1798FDC")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1798FE8", Offset = "0x1798FE8", VA = "0x1798FE8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x179906C", Offset = "0x179906C", VA = "0x179906C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1799078", Offset = "0x1799078", VA = "0x1799078")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1799080", Offset = "0x1799080", VA = "0x1799080", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x17991A8", Offset = "0x17991A8", VA = "0x17991A8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x17992C8", Offset = "0x17992C8", VA = "0x17992C8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1799308", Offset = "0x1799308", VA = "0x1799308", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x179935C", Offset = "0x179935C", VA = "0x179935C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1799768", Offset = "0x1799768", VA = "0x1799768")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x17997E8", Offset = "0x17997E8", VA = "0x17997E8")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1799D90", Offset = "0x1799D90", VA = "0x1799D90")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1799FA8", Offset = "0x1799FA8", VA = "0x1799FA8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x179A164", Offset = "0x179A164", VA = "0x179A164")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x179A0E0", Offset = "0x179A0E0", VA = "0x179A0E0")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x179A40C", Offset = "0x179A40C", VA = "0x179A40C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x179AEE0", Offset = "0x179AEE0", VA = "0x179AEE0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x179AEE4", Offset = "0x179AEE4", VA = "0x179AEE4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x179AEE8", Offset = "0x179AEE8", VA = "0x179AEE8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x179AB18", Offset = "0x179AB18", VA = "0x179AB18")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x179614C", Offset = "0x179614C", VA = "0x179614C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000120")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400082A")]
				YawPitch,
				[Token(Token = "0x400082B")]
				FromTo
			}

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8F78", Offset = "0x9B8F78")]
			public Transform target;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8FB0", Offset = "0x9B8FB0")]
			public Transform bendGoal;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8FE8", Offset = "0x9B8FE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8FE8", Offset = "0x9B8FE8")]
			public float positionWeight;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B903C", Offset = "0x9B903C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B903C", Offset = "0x9B903C")]
			public float rotationWeight;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9090", Offset = "0x9B9090")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B90C8", Offset = "0x9B90C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B90C8", Offset = "0x9B90C8")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B911C", Offset = "0x9B911C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B911C", Offset = "0x9B911C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9170", Offset = "0x9B9170")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9170", Offset = "0x9B9170")]
			public float bendGoalWeight;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B91C4", Offset = "0x9B91C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B91C4", Offset = "0x9B91C4")]
			public float swivelOffset;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9220", Offset = "0x9B9220")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9258", Offset = "0x9B9258")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9290", Offset = "0x9B9290")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9290", Offset = "0x9B9290")]
			public float armLengthMlp;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B92E8", Offset = "0x9B92E8")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9360", Offset = "0x9B9360")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9370", Offset = "0x9B9370")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400065F")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000660")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000090")]
			public Vector3 position
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x1875618", Offset = "0x1875618", VA = "0x1875618")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE3A0", Offset = "0x9BE3A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x1875624", Offset = "0x1875624", VA = "0x1875624")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE3B0", Offset = "0x9BE3B0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000091")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x1875630", Offset = "0x1875630", VA = "0x1875630")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE3C0", Offset = "0x9BE3C0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x187563C", Offset = "0x187563C", VA = "0x187563C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE3D0", Offset = "0x9BE3D0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x1875648", Offset = "0x1875648", VA = "0x1875648")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x187567C", Offset = "0x187567C", VA = "0x187567C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0x18756BC", Offset = "0x18756BC", VA = "0x18756BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006B0")]
				[Address(RVA = "0x1875708", Offset = "0x1875708", VA = "0x1875708")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1875754", Offset = "0x1875754", VA = "0x1875754", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x18761C8", Offset = "0x18761C8", VA = "0x18761C8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x18763BC", Offset = "0x18763BC", VA = "0x18763BC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1876468", Offset = "0x1876468", VA = "0x1876468")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1876880", Offset = "0x1876880", VA = "0x1876880")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1878DF4", Offset = "0x1878DF4", VA = "0x1878DF4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1878E64", Offset = "0x1878E64", VA = "0x1878E64", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1877DE4", Offset = "0x1877DE4", VA = "0x1877DE4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x18780F0", Offset = "0x18780F0", VA = "0x18780F0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1879084", Offset = "0x1879084", VA = "0x1879084")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x18791AC", Offset = "0x18791AC", VA = "0x18791AC")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9380", Offset = "0x9B9380")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9390", Offset = "0x9B9390")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000096")]
			public float sqrMag
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x1879384", Offset = "0x1879384", VA = "0x1879384")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE3E0", Offset = "0x9BE3E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x187938C", Offset = "0x187938C", VA = "0x187938C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE3F0", Offset = "0x9BE3F0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public float mag
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x1879394", Offset = "0x1879394", VA = "0x1879394")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE400", Offset = "0x9BE400")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x187939C", Offset = "0x187939C", VA = "0x187939C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE410", Offset = "0x9BE410")]
				private set
				{
				}
			}

			[Token(Token = "0x60006BC")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60006BD")]
			public abstract void PreSolve();

			[Token(Token = "0x60006BE")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006BF")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x60006C0")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x18793A4", Offset = "0x18793A4", VA = "0x18793A4")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x18793AC", Offset = "0x18793AC", VA = "0x18793AC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1879768", Offset = "0x1879768", VA = "0x1879768")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x18798D4", Offset = "0x18798D4", VA = "0x18798D4")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1879B64", Offset = "0x1879B64", VA = "0x1879B64")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1879BB8", Offset = "0x1879BB8", VA = "0x1879BB8")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1878C54", Offset = "0x1878C54", VA = "0x1878C54")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1879DA4", Offset = "0x1879DA4", VA = "0x1879DA4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1879EE8", Offset = "0x1879EE8", VA = "0x1879EE8")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x18792E0", Offset = "0x18792E0", VA = "0x18792E0")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public class Footstep
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B93B0", Offset = "0x9B93B0")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000098")]
			public bool isStepping
			{
				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x1879F10", Offset = "0x1879F10", VA = "0x1879F10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000099")]
			public float stepProgress
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x1879F24", Offset = "0x1879F24", VA = "0x1879F24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE420", Offset = "0x9BE420")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006D1")]
				[Address(RVA = "0x1879F2C", Offset = "0x1879F2C", VA = "0x1879F2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE430", Offset = "0x9BE430")]
				private set
				{
				}
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1879F34", Offset = "0x1879F34", VA = "0x1879F34")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x187A0C4", Offset = "0x187A0C4", VA = "0x187A0C4")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x187A10C", Offset = "0x187A10C", VA = "0x187A10C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x187A2DC", Offset = "0x187A2DC", VA = "0x187A2DC")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x187A4B4", Offset = "0x187A4B4", VA = "0x187A4B4")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x187A6A0", Offset = "0x187A6A0", VA = "0x187A6A0")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B93C0", Offset = "0x9B93C0")]
			public Transform target;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B93F8", Offset = "0x9B93F8")]
			public Transform bendGoal;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9430", Offset = "0x9B9430")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9430", Offset = "0x9B9430")]
			public float positionWeight;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9484", Offset = "0x9B9484")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9484", Offset = "0x9B9484")]
			public float rotationWeight;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B94D8", Offset = "0x9B94D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B94D8", Offset = "0x9B94D8")]
			public float bendGoalWeight;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B952C", Offset = "0x9B952C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B952C", Offset = "0x9B952C")]
			public float swivelOffset;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9588", Offset = "0x9B9588")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9588", Offset = "0x9B9588")]
			public float bendToTargetWeight;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B95DC", Offset = "0x9B95DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B95DC", Offset = "0x9B95DC")]
			public float legLengthMlp;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9634", Offset = "0x9B9634")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B96DC", Offset = "0x9B96DC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B96EC", Offset = "0x9B96EC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B96FC", Offset = "0x9B96FC")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B970C", Offset = "0x9B970C")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700009A")]
			public Vector3 position
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x187A8BC", Offset = "0x187A8BC", VA = "0x187A8BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE440", Offset = "0x9BE440")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x187A8C8", Offset = "0x187A8C8", VA = "0x187A8C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE450", Offset = "0x9BE450")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x187A8D4", Offset = "0x187A8D4", VA = "0x187A8D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE460", Offset = "0x9BE460")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0x187A8E0", Offset = "0x187A8E0", VA = "0x187A8E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE470", Offset = "0x9BE470")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public bool hasToes
			{
				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x187A8EC", Offset = "0x187A8EC", VA = "0x187A8EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE480", Offset = "0x9BE480")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x187A8F4", Offset = "0x187A8F4", VA = "0x187A8F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE490", Offset = "0x9BE490")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x187A900", Offset = "0x187A900", VA = "0x187A900")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x187A934", Offset = "0x187A934", VA = "0x187A934")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x187A96C", Offset = "0x187A96C", VA = "0x187A96C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x187A9A4", Offset = "0x187A9A4", VA = "0x187A9A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x187A9DC", Offset = "0x187A9DC", VA = "0x187A9DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x187AA1C", Offset = "0x187AA1C", VA = "0x187AA1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4A0", Offset = "0x9BE4A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x187AA28", Offset = "0x187AA28", VA = "0x187AA28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4B0", Offset = "0x9BE4B0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x187AA34", Offset = "0x187AA34", VA = "0x187AA34", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x187B03C", Offset = "0x187B03C", VA = "0x187B03C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x187B93C", Offset = "0x187B93C", VA = "0x187B93C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x187B838", Offset = "0x187B838", VA = "0x187B838")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x187B600", Offset = "0x187B600", VA = "0x187B600")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x187BEF4", Offset = "0x187BEF4", VA = "0x187BEF4")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x187C650", Offset = "0x187C650", VA = "0x187C650")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x187C124", Offset = "0x187C124", VA = "0x187C124")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x187CAB8", Offset = "0x187CAB8", VA = "0x187CAB8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x187CCD4", Offset = "0x187CCD4", VA = "0x187CCD4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x187CD84", Offset = "0x187CD84", VA = "0x187CD84")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Locomotion
		{
			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B971C", Offset = "0x9B971C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B971C", Offset = "0x9B971C")]
			public float weight;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9770", Offset = "0x9B9770")]
			public float footDistance;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B97A8", Offset = "0x9B97A8")]
			public float stepThreshold;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B97E0", Offset = "0x9B97E0")]
			public float angleThreshold;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9818", Offset = "0x9B9818")]
			public float comAngleMlp;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9850", Offset = "0x9B9850")]
			public float maxVelocity;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9888", Offset = "0x9B9888")]
			public float velocityFactor;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B98C0", Offset = "0x9B98C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B98C0", Offset = "0x9B98C0")]
			public float maxLegStretch;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9918", Offset = "0x9B9918")]
			public float rootSpeed;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9950", Offset = "0x9B9950")]
			public float stepSpeed;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9988", Offset = "0x9B9988")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B99C0", Offset = "0x9B99C0")]
			public float maxBodyYOffset;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B99F8", Offset = "0x9B99F8")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9A30", Offset = "0x9B9A30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9A30", Offset = "0x9B9A30")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9A88", Offset = "0x9B9A88")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9AC0", Offset = "0x9B9AC0")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9AF8", Offset = "0x9B9AF8")]
			public Vector3 offset;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9B70", Offset = "0x9B9B70")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9BA8", Offset = "0x9B9BA8")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9BE0", Offset = "0x9B9BE0")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x170000A3")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006F0")]
				[Address(RVA = "0x187CE84", Offset = "0x187CE84", VA = "0x187CE84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4C0", Offset = "0x9BE4C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0x187CE90", Offset = "0x187CE90", VA = "0x187CE90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4D0", Offset = "0x9BE4D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x187F428", Offset = "0x187F428", VA = "0x187F428")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x187F468", Offset = "0x187F468", VA = "0x187F468")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x187F4AC", Offset = "0x187F4AC", VA = "0x187F4AC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000A7")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x187F4EC", Offset = "0x187F4EC", VA = "0x187F4EC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x187CE9C", Offset = "0x187CE9C", VA = "0x187CE9C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x187D1C0", Offset = "0x187D1C0", VA = "0x187D1C0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x187D434", Offset = "0x187D434", VA = "0x187D434")]
			public void Relax()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x187D498", Offset = "0x187D498", VA = "0x187D498")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x187D870", Offset = "0x187D870", VA = "0x187D870")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x187DA20", Offset = "0x187DA20", VA = "0x187DA20")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x187F034", Offset = "0x187F034", VA = "0x187F034")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x187F1D8", Offset = "0x187F1D8", VA = "0x187F1D8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x187F25C", Offset = "0x187F25C", VA = "0x187F25C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x187F530", Offset = "0x187F530", VA = "0x187F530")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9BF0", Offset = "0x9B9BF0")]
			public Transform headTarget;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9C28", Offset = "0x9B9C28")]
			public Transform pelvisTarget;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9C60", Offset = "0x9B9C60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9C60", Offset = "0x9B9C60")]
			public float positionWeight;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9CB4", Offset = "0x9B9CB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9CB4", Offset = "0x9B9CB4")]
			public float rotationWeight;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9D08", Offset = "0x9B9D08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9D08", Offset = "0x9B9D08")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9D5C", Offset = "0x9B9D5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9D5C", Offset = "0x9B9D5C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9DB0", Offset = "0x9B9DB0")]
			public Transform chestGoal;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9DE8", Offset = "0x9B9DE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9DE8", Offset = "0x9B9DE8")]
			public float chestGoalWeight;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9E3C", Offset = "0x9B9E3C")]
			public float minHeadHeight;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9E74", Offset = "0x9B9E74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9E74", Offset = "0x9B9E74")]
			public float bodyPosStiffness;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9EC8", Offset = "0x9B9EC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9EC8", Offset = "0x9B9EC8")]
			public float bodyRotStiffness;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9F1C", Offset = "0x9B9F1C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B9F1C", Offset = "0x9B9F1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9F1C", Offset = "0x9B9F1C")]
			public float neckStiffness;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9F94", Offset = "0x9B9F94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9F94", Offset = "0x9B9F94")]
			public float rotateChestByHands;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9FE8", Offset = "0x9B9FE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9FE8", Offset = "0x9B9FE8")]
			public float chestClampWeight;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA03C", Offset = "0x9BA03C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA03C", Offset = "0x9BA03C")]
			public float headClampWeight;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA090", Offset = "0x9BA090")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA0C8", Offset = "0x9BA0C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA0C8", Offset = "0x9BA0C8")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA11C", Offset = "0x9BA11C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA11C", Offset = "0x9BA11C")]
			public float maxRootAngle;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA174", Offset = "0x9BA174")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA174", Offset = "0x9BA174")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA2B0", Offset = "0x9BA2B0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA2C0", Offset = "0x9BA2C0")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000A8")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x187EFB4", Offset = "0x187EFB4", VA = "0x187EFB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x187F644", Offset = "0x187F644", VA = "0x187F644")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x187F684", Offset = "0x187F684", VA = "0x187F684")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x187F6D8", Offset = "0x187F6D8", VA = "0x187F6D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			public VirtualBone head
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x187EFF4", Offset = "0x187EFF4", VA = "0x187EFF4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x187F718", Offset = "0x187F718", VA = "0x187F718")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4E0", Offset = "0x9BE4E0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000706")]
				[Address(RVA = "0x187F72C", Offset = "0x187F72C", VA = "0x187F72C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4F0", Offset = "0x9BE4F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AE")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000707")]
				[Address(RVA = "0x187F740", Offset = "0x187F740", VA = "0x187F740")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE500", Offset = "0x9BE500")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x187F754", Offset = "0x187F754", VA = "0x187F754")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE510", Offset = "0x9BE510")]
				private set
				{
				}
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x187F768", Offset = "0x187F768", VA = "0x187F768", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1880274", Offset = "0x1880274", VA = "0x1880274", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x1880484", Offset = "0x1880484", VA = "0x1880484", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x1880B0C", Offset = "0x1880B0C", VA = "0x1880B0C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x18810CC", Offset = "0x18810CC", VA = "0x18810CC")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1881B54", Offset = "0x1881B54", VA = "0x1881B54")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1882380", Offset = "0x1882380", VA = "0x1882380")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1882AEC", Offset = "0x1882AEC", VA = "0x1882AEC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1882CC8", Offset = "0x1882CC8", VA = "0x1882CC8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1880D3C", Offset = "0x1880D3C", VA = "0x1880D3C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1881FC8", Offset = "0x1881FC8", VA = "0x1881FC8")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x18816F8", Offset = "0x18816F8", VA = "0x18816F8")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1882DC4", Offset = "0x1882DC4", VA = "0x1882DC4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1882134", Offset = "0x1882134", VA = "0x1882134")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1881D14", Offset = "0x1881D14", VA = "0x1881D14")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x18830EC", Offset = "0x18830EC", VA = "0x18830EC")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public enum PositionOffset
		{
			[Token(Token = "0x40006E8")]
			Pelvis,
			[Token(Token = "0x40006E9")]
			Chest,
			[Token(Token = "0x40006EA")]
			Head,
			[Token(Token = "0x40006EB")]
			LeftHand,
			[Token(Token = "0x40006EC")]
			RightHand,
			[Token(Token = "0x40006ED")]
			LeftFoot,
			[Token(Token = "0x40006EE")]
			RightFoot,
			[Token(Token = "0x40006EF")]
			LeftHeel,
			[Token(Token = "0x40006F0")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum RotationOffset
		{
			[Token(Token = "0x40006F2")]
			Pelvis,
			[Token(Token = "0x40006F3")]
			Chest,
			[Token(Token = "0x40006F4")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class VirtualBone
		{
			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x187612C", Offset = "0x187612C", VA = "0x187612C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x18761A8", Offset = "0x18761A8", VA = "0x18761A8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x18832A0", Offset = "0x18832A0", VA = "0x18832A0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x187947C", Offset = "0x187947C", VA = "0x187947C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x187997C", Offset = "0x187997C", VA = "0x187997C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1883530", Offset = "0x1883530", VA = "0x1883530")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1877EBC", Offset = "0x1877EBC", VA = "0x1877EBC")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1883768", Offset = "0x1883768", VA = "0x1883768")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x18786A8", Offset = "0x18786A8", VA = "0x18786A8")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1883820", Offset = "0x1883820", VA = "0x1883820")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x188268C", Offset = "0x188268C", VA = "0x188268C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1883A38", Offset = "0x1883A38", VA = "0x1883A38")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1883B40", Offset = "0x1883B40", VA = "0x1883B40")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5B10", Offset = "0x9B5B10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5B10", Offset = "0x9B5B10")]
		public int LOD;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5B64", Offset = "0x9B5B64")]
		public float scale;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5B9C", Offset = "0x9B5B9C")]
		public bool plantFeet;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5BD4", Offset = "0x9B5BD4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5BE4", Offset = "0x9B5BE4")]
		public Spine spine;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5C1C", Offset = "0x9B5C1C")]
		public Arm leftArm;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5C54", Offset = "0x9B5C54")]
		public Arm rightArm;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5C8C", Offset = "0x9B5C8C")]
		public Leg leftLeg;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5CC4", Offset = "0x9B5CC4")]
		public Leg rightLeg;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5CFC", Offset = "0x9B5CFC")]
		public Locomotion locomotion;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000049")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x179F234", Offset = "0x179F234", VA = "0x179F234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD26C", Offset = "0x9BD26C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x179F23C", Offset = "0x179F23C", VA = "0x179F23C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD27C", Offset = "0x9BD27C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x179AEF0", Offset = "0x179AEF0", VA = "0x179AEF0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x179B384", Offset = "0x179B384", VA = "0x179B384")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x179B20C", Offset = "0x179B20C", VA = "0x179B20C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x179B758", Offset = "0x179B758", VA = "0x179B758")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x179BA34", Offset = "0x179BA34", VA = "0x179BA34")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x179BAD8", Offset = "0x179BAD8", VA = "0x179BAD8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x179BC6C", Offset = "0x179BC6C", VA = "0x179BC6C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x179BDF8", Offset = "0x179BDF8", VA = "0x179BDF8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x179C674", Offset = "0x179C674", VA = "0x179C674", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x179C7E8", Offset = "0x179C7E8", VA = "0x179C7E8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x179C9F0", Offset = "0x179C9F0", VA = "0x179C9F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x179CA64", Offset = "0x179CA64", VA = "0x179CA64", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x179CAD8", Offset = "0x179CAD8", VA = "0x179CAD8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x179CCF8", Offset = "0x179CCF8", VA = "0x179CCF8")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x179B634", Offset = "0x179B634", VA = "0x179B634")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x179BF70", Offset = "0x179BF70", VA = "0x179BF70")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x179CFD8", Offset = "0x179CFD8", VA = "0x179CFD8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x179D020", Offset = "0x179D020", VA = "0x179D020", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x179E7BC", Offset = "0x179E7BC", VA = "0x179E7BC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x179C0D8", Offset = "0x179C0D8", VA = "0x179C0D8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x179D4E8", Offset = "0x179D4E8", VA = "0x179D4E8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x179EBA8", Offset = "0x179EBA8", VA = "0x179EBA8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x179EBF0", Offset = "0x179EBF0", VA = "0x179EBF0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x179E66C", Offset = "0x179E66C", VA = "0x179E66C")]
		private void Write()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x179EC34", Offset = "0x179EC34", VA = "0x179EC34")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x179F244", Offset = "0x179F244", VA = "0x179F244")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5D34", Offset = "0x9B5D34")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x15A648C", Offset = "0x15A648C", VA = "0x15A648C")]
		public void Start()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x15A6BE4", Offset = "0x15A6BE4", VA = "0x15A6BE4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x15A7168", Offset = "0x15A7168", VA = "0x15A7168")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x15A7230", Offset = "0x15A7230", VA = "0x15A7230")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x15A7358", Offset = "0x15A7358", VA = "0x15A7358")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class TwistSolver
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5D6C", Offset = "0x9B5D6C")]
		public Transform transform;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5DA4", Offset = "0x9B5DA4")]
		public Transform parent;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5DDC", Offset = "0x9B5DDC")]
		public Transform[] children;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5E14", Offset = "0x9B5E14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5E14", Offset = "0x9B5E14")]
		public float weight;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5E68", Offset = "0x9B5E68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5E68", Offset = "0x9B5E68")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5EBC", Offset = "0x9B5EBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5EBC", Offset = "0x9B5EBC")]
		public float twistAngleOffset;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x15A73C4", Offset = "0x15A73C4", VA = "0x15A73C4")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x15A6660", Offset = "0x15A6660", VA = "0x15A6660")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x15A6CAC", Offset = "0x15A6CAC", VA = "0x15A6CAC")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5F18", Offset = "0x9B5F18")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5F28", Offset = "0x9B5F28")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5F38", Offset = "0x9B5F38")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700004A")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1884368", Offset = "0x1884368", VA = "0x1884368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD28C", Offset = "0x9BD28C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1884370", Offset = "0x1884370", VA = "0x1884370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD29C", Offset = "0x9BD29C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isPaused
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1884378", Offset = "0x1884378", VA = "0x1884378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2AC", Offset = "0x9BD2AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x1884380", Offset = "0x1884380", VA = "0x1884380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2BC", Offset = "0x9BD2BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x188438C", Offset = "0x188438C", VA = "0x188438C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2CC", Offset = "0x9BD2CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1884394", Offset = "0x1884394", VA = "0x1884394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2DC", Offset = "0x9BD2DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool inInteraction
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x188439C", Offset = "0x188439C", VA = "0x188439C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public float progress
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x18870D4", Offset = "0x18870D4", VA = "0x18870D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x188440C", Offset = "0x188440C", VA = "0x188440C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x188449C", Offset = "0x188449C", VA = "0x188449C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1884560", Offset = "0x1884560", VA = "0x1884560")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x18846D8", Offset = "0x18846D8", VA = "0x18846D8")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1884B88", Offset = "0x1884B88", VA = "0x1884B88")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1884F48", Offset = "0x1884F48", VA = "0x1884F48")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1884F9C", Offset = "0x1884F9C", VA = "0x1884F9C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1885CB0", Offset = "0x1885CB0", VA = "0x1885CB0")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1886860", Offset = "0x1886860", VA = "0x1886860")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1886A88", Offset = "0x1886A88", VA = "0x1886A88")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1886F64", Offset = "0x1886F64", VA = "0x1886F64")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x18875BC", Offset = "0x18875BC", VA = "0x18875BC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5F48", Offset = "0x9B5F48")]
		public LookAtIK ik;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5F80", Offset = "0x9B5F80")]
		public float lerpSpeed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5FB8", Offset = "0x9B5FB8")]
		public float weightSpeed;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x18878A4", Offset = "0x18878A4", VA = "0x18878A4")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1887A28", Offset = "0x1887A28", VA = "0x1887A28")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1887AD0", Offset = "0x1887AD0", VA = "0x1887AD0")]
		public void Update()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1887D24", Offset = "0x1887D24", VA = "0x1887D24")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1887E1C", Offset = "0x1887E1C", VA = "0x1887E1C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1887EE8", Offset = "0x1887EE8", VA = "0x1887EE8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3750", Offset = "0x9B3750")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3750", Offset = "0x9B3750")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA2D0", Offset = "0x9BA2D0")]
			public float time;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA308", Offset = "0x9BA308")]
			public bool pause;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA340", Offset = "0x9BA340")]
			public bool pickUp;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA378", Offset = "0x9BA378")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA3B0", Offset = "0x9BA3B0")]
			public Message[] messages;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA3E8", Offset = "0x9BA3E8")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1887110", Offset = "0x1887110", VA = "0x1887110")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x18891F8", Offset = "0x18891F8", VA = "0x18891F8")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public class Message
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA420", Offset = "0x9BA420")]
			public string function;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA458", Offset = "0x9BA458")]
			public GameObject recipient;

			[Token(Token = "0x4000704")]
			private const string empty = "";

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1889108", Offset = "0x1889108", VA = "0x1889108")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1889200", Offset = "0x1889200", VA = "0x1889200")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA490", Offset = "0x9BA490")]
			public Animator animator;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA4C8", Offset = "0x9BA4C8")]
			public Animation animation;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA500", Offset = "0x9BA500")]
			public string animationState;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA538", Offset = "0x9BA538")]
			public float crossfadeTime;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA570", Offset = "0x9BA570")]
			public int layer;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA5A8", Offset = "0x9BA5A8")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400070B")]
			private const string empty = "";

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1888E68", Offset = "0x1888E68", VA = "0x1888E68")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1888F5C", Offset = "0x1888F5C", VA = "0x1888F5C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1889014", Offset = "0x1889014", VA = "0x1889014")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x18890F4", Offset = "0x18890F4", VA = "0x18890F4")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000121")]
			public enum Type
			{
				[Token(Token = "0x400082D")]
				PositionWeight,
				[Token(Token = "0x400082E")]
				RotationWeight,
				[Token(Token = "0x400082F")]
				PositionOffsetX,
				[Token(Token = "0x4000830")]
				PositionOffsetY,
				[Token(Token = "0x4000831")]
				PositionOffsetZ,
				[Token(Token = "0x4000832")]
				Pull,
				[Token(Token = "0x4000833")]
				Reach,
				[Token(Token = "0x4000834")]
				RotateBoneWeight,
				[Token(Token = "0x4000835")]
				Push,
				[Token(Token = "0x4000836")]
				PushParent,
				[Token(Token = "0x4000837")]
				PoserWeight,
				[Token(Token = "0x4000838")]
				BendGoalWeight
			}

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA5E0", Offset = "0x9BA5E0")]
			public Type type;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA618", Offset = "0x9BA618")]
			public AnimationCurve curve;

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1888674", Offset = "0x1888674", VA = "0x1888674")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1889218", Offset = "0x1889218", VA = "0x1889218")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Multiplier
		{
			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA650", Offset = "0x9BA650")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA688", Offset = "0x9BA688")]
			public float multiplier;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA6C0", Offset = "0x9BA6C0")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1888D54", Offset = "0x1888D54", VA = "0x1888D54")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1889208", Offset = "0x1889208", VA = "0x1889208")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6000", Offset = "0x9B6000")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6038", Offset = "0x9B6038")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6070", Offset = "0x9B6070")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B60A8", Offset = "0x9B60A8")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B60B8", Offset = "0x9B60B8")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004F")]
		public float length
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x188815C", Offset = "0x188815C", VA = "0x188815C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD4AC", Offset = "0x9BD4AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1888164", Offset = "0x1888164", VA = "0x1888164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD4BC", Offset = "0x9BD4BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x188816C", Offset = "0x188816C", VA = "0x188816C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD4CC", Offset = "0x9BD4CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1888174", Offset = "0x1888174", VA = "0x1888174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD4DC", Offset = "0x9BD4DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1888398", Offset = "0x1888398", VA = "0x1888398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1887490", Offset = "0x1887490", VA = "0x1887490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1887EFC", Offset = "0x1887EFC", VA = "0x1887EFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD2EC", Offset = "0x9BD2EC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1887F48", Offset = "0x1887F48", VA = "0x1887F48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD324", Offset = "0x9BD324")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1887F94", Offset = "0x1887F94", VA = "0x1887F94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD35C", Offset = "0x9BD35C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1887FE0", Offset = "0x1887FE0", VA = "0x1887FE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD394", Offset = "0x9BD394")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x188802C", Offset = "0x188802C", VA = "0x188802C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD3CC", Offset = "0x9BD3CC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1888078", Offset = "0x1888078", VA = "0x1888078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD404", Offset = "0x9BD404")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x18880C4", Offset = "0x18880C4", VA = "0x18880C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD43C", Offset = "0x9BD43C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1888110", Offset = "0x1888110", VA = "0x1888110")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD474", Offset = "0x9BD474")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x188817C", Offset = "0x188817C", VA = "0x188817C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1888428", Offset = "0x1888428", VA = "0x1888428")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1885554", Offset = "0x1885554", VA = "0x1885554")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x188858C", Offset = "0x188858C", VA = "0x188858C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1885410", Offset = "0x1885410", VA = "0x1885410")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x188554C", Offset = "0x188554C", VA = "0x188554C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1886444", Offset = "0x1886444", VA = "0x1886444")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1886D3C", Offset = "0x1886D3C", VA = "0x1886D3C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1888D90", Offset = "0x1888D90", VA = "0x1888D90")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1888690", Offset = "0x1888690", VA = "0x1888690")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1888594", Offset = "0x1888594", VA = "0x1888594")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1888CEC", Offset = "0x1888CEC", VA = "0x1888CEC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1888D94", Offset = "0x1888D94", VA = "0x1888D94")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1888DFC", Offset = "0x1888DFC", VA = "0x1888DFC")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B37B0", Offset = "0x9B37B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B37B0", Offset = "0x9B37B0")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000EB")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000EC")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B60C8", Offset = "0x9B60C8")]
		public string targetTag;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6100", Offset = "0x9B6100")]
		public float fadeInTime;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6138", Offset = "0x9B6138")]
		public float speed;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6170", Offset = "0x9B6170")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B61A8", Offset = "0x9B61A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B61A8", Offset = "0x9B61A8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B61A8", Offset = "0x9B61A8")]
		public Collider characterCollider;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B622C", Offset = "0x9B622C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B622C", Offset = "0x9B622C")]
		public Transform FPSCamera;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B628C", Offset = "0x9B628C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B62C4", Offset = "0x9B62C4")]
		public float camRaycastDistance;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B62FC", Offset = "0x9B62FC")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9B630C", Offset = "0x9B630C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B630C", Offset = "0x9B630C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B636C", Offset = "0x9B636C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B63A4", Offset = "0x9B63A4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000053")]
		public bool inInteraction
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1889480", Offset = "0x1889480", VA = "0x1889480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x188B0D8", Offset = "0x188B0D8", VA = "0x188B0D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x188B0E0", Offset = "0x188B0E0", VA = "0x188B0E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x188B0E8", Offset = "0x188B0E8", VA = "0x188B0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD6AC", Offset = "0x9BD6AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x188B0F0", Offset = "0x188B0F0", VA = "0x188B0F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD6BC", Offset = "0x9BD6BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool initiated
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x188B0F8", Offset = "0x188B0F8", VA = "0x188B0F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD6CC", Offset = "0x9BD6CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x188B100", Offset = "0x188B100", VA = "0x188B100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD6DC", Offset = "0x9BD6DC")]
			private set
			{
			}
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1889220", Offset = "0x1889220", VA = "0x1889220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD4EC", Offset = "0x9BD4EC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x188926C", Offset = "0x188926C", VA = "0x188926C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD524", Offset = "0x9BD524")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x18892B8", Offset = "0x18892B8", VA = "0x18892B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD55C", Offset = "0x9BD55C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1889304", Offset = "0x1889304", VA = "0x1889304")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD594", Offset = "0x9BD594")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1889350", Offset = "0x1889350", VA = "0x1889350")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD5CC", Offset = "0x9BD5CC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x188939C", Offset = "0x188939C", VA = "0x188939C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD604", Offset = "0x9BD604")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x18893E8", Offset = "0x18893E8", VA = "0x18893E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD63C", Offset = "0x9BD63C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1889434", Offset = "0x1889434", VA = "0x1889434")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD674", Offset = "0x9BD674")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1889610", Offset = "0x1889610", VA = "0x1889610")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x18896DC", Offset = "0x18896DC", VA = "0x18896DC")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x18897A8", Offset = "0x18897A8", VA = "0x18897A8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1889854", Offset = "0x1889854", VA = "0x1889854")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x188994C", Offset = "0x188994C", VA = "0x188994C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1889A68", Offset = "0x1889A68", VA = "0x1889A68")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1889AF8", Offset = "0x1889AF8", VA = "0x1889AF8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1889B88", Offset = "0x1889B88", VA = "0x1889B88")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1889C18", Offset = "0x1889C18", VA = "0x1889C18")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1889C8C", Offset = "0x1889C8C", VA = "0x1889C8C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1889D00", Offset = "0x1889D00", VA = "0x1889D00")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1889D68", Offset = "0x1889D68", VA = "0x1889D68")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1889DF4", Offset = "0x1889DF4", VA = "0x1889DF4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1889EA8", Offset = "0x1889EA8", VA = "0x1889EA8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1889F8C", Offset = "0x1889F8C", VA = "0x1889F8C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x188A230", Offset = "0x188A230", VA = "0x188A230")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x188A420", Offset = "0x188A420", VA = "0x188A420")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x188A6A4", Offset = "0x188A6A4", VA = "0x188A6A4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x188A998", Offset = "0x188A998", VA = "0x188A998")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x188A9DC", Offset = "0x188A9DC", VA = "0x188A9DC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x188AA54", Offset = "0x188AA54", VA = "0x188AA54")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x188AB8C", Offset = "0x188AB8C", VA = "0x188AB8C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x188AD04", Offset = "0x188AD04", VA = "0x188AD04")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x188AFAC", Offset = "0x188AFAC", VA = "0x188AFAC")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x188A7A4", Offset = "0x188A7A4", VA = "0x188A7A4")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x188B10C", Offset = "0x188B10C", VA = "0x188B10C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x188B8C0", Offset = "0x188B8C0", VA = "0x188B8C0")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x188B8E0", Offset = "0x188B8E0", VA = "0x188B8E0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x188B8FC", Offset = "0x188B8FC", VA = "0x188B8FC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x188B918", Offset = "0x188B918", VA = "0x188B918")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x188B978", Offset = "0x188B978", VA = "0x188B978")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x188BA94", Offset = "0x188BA94", VA = "0x188BA94")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x188BB90", Offset = "0x188BB90", VA = "0x188BB90")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x188BD38", Offset = "0x188BD38", VA = "0x188BD38")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x188BE50", Offset = "0x188BE50", VA = "0x188BE50")]
		public void Update()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x188C068", Offset = "0x188C068", VA = "0x188C068")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x188B620", Offset = "0x188B620", VA = "0x188B620")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x188C1A8", Offset = "0x188C1A8", VA = "0x188C1A8")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x188C2D4", Offset = "0x188C2D4", VA = "0x188C2D4")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x188C36C", Offset = "0x188C36C", VA = "0x188C36C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x188C444", Offset = "0x188C444", VA = "0x188C444")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x188C45C", Offset = "0x188C45C", VA = "0x188C45C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x188952C", Offset = "0x188952C", VA = "0x188952C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x188A12C", Offset = "0x188A12C", VA = "0x188A12C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x188C820", Offset = "0x188C820", VA = "0x188C820")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3810", Offset = "0x9B3810")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3810", Offset = "0x9B3810")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public enum RotationMode
		{
			[Token(Token = "0x4000712")]
			TwoDOF,
			[Token(Token = "0x4000713")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public class Multiplier
		{
			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA6F8", Offset = "0x9BA6F8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA730", Offset = "0x9BA730")]
			public float multiplier;

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x159B19C", Offset = "0x159B19C", VA = "0x159B19C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B63B4", Offset = "0x9B63B4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B63EC", Offset = "0x9B63EC")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6424", Offset = "0x9B6424")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B645C", Offset = "0x9B645C")]
		public Transform pivot;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6494", Offset = "0x9B6494")]
		public RotationMode rotationMode;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B64CC", Offset = "0x9B64CC")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6504", Offset = "0x9B6504")]
		public float twistWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B653C", Offset = "0x9B653C")]
		public float swingWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6574", Offset = "0x9B6574")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6574", Offset = "0x9B6574")]
		public float threeDOFWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B65C8", Offset = "0x9B65C8")]
		public bool rotateOnce;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x188CD80", Offset = "0x188CD80", VA = "0x188CD80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD6EC", Offset = "0x9BD6EC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x188CDCC", Offset = "0x188CDCC", VA = "0x188CDCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD724", Offset = "0x9BD724")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x188CE18", Offset = "0x188CE18", VA = "0x188CE18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD75C", Offset = "0x9BD75C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x188CE64", Offset = "0x188CE64", VA = "0x188CE64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD794", Offset = "0x9BD794")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x188CEB0", Offset = "0x188CEB0", VA = "0x188CEB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD7CC", Offset = "0x9BD7CC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x188CEFC", Offset = "0x188CEFC", VA = "0x188CEFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD804", Offset = "0x9BD804")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x188CF48", Offset = "0x188CF48", VA = "0x188CF48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD83C", Offset = "0x9BD83C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x188CF94", Offset = "0x188CF94", VA = "0x188CF94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD874", Offset = "0x9BD874")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1888604", Offset = "0x1888604", VA = "0x1888604")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1887520", Offset = "0x1887520", VA = "0x1887520")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1885608", Offset = "0x1885608", VA = "0x1885608")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x188CFE0", Offset = "0x188CFE0", VA = "0x188CFE0")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3870", Offset = "0x9B3870")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3870", Offset = "0x9B3870")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA768", Offset = "0x9BA768")]
			public bool use;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA7A0", Offset = "0x9BA7A0")]
			public Vector2 offset;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA7D8", Offset = "0x9BA7D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA7D8", Offset = "0x9BA7D8")]
			public float angleOffset;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA834", Offset = "0x9BA834")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA834", Offset = "0x9BA834")]
			public float maxAngle;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA88C", Offset = "0x9BA88C")]
			public float radius;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA8C4", Offset = "0x9BA8C4")]
			public bool orbit;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA8FC", Offset = "0x9BA8FC")]
			public bool fixYAxis;

			[Token(Token = "0x170000AF")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600073B")]
				[Address(RVA = "0x159BB80", Offset = "0x159BB80", VA = "0x159BB80")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600073C")]
				[Address(RVA = "0x159BBBC", Offset = "0x159BBBC", VA = "0x159BBBC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x159BCB4", Offset = "0x159BCB4", VA = "0x159BCB4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x159C330", Offset = "0x159C330", VA = "0x159C330")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public class CameraPosition
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA934", Offset = "0x9BA934")]
			public Collider lookAtTarget;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA96C", Offset = "0x9BA96C")]
			public Vector3 direction;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA9A4", Offset = "0x9BA9A4")]
			public float maxDistance;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA9DC", Offset = "0x9BA9DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA9DC", Offset = "0x9BA9DC")]
			public float maxAngle;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAA34", Offset = "0x9BAA34")]
			public bool fixYAxis;

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x159B66C", Offset = "0x159B66C", VA = "0x159B66C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x159B814", Offset = "0x159B814", VA = "0x159B814")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x159BAF4", Offset = "0x159BAF4", VA = "0x159BAF4")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000122")]
			public class Interaction
			{
				[Token(Token = "0x4000839")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBC0C", Offset = "0x9BBC0C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400083A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBC44", Offset = "0x9BBC44")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x159C354", Offset = "0x159C354", VA = "0x159C354")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAA8C", Offset = "0x9BAA8C")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAAC4", Offset = "0x9BAAC4")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAAFC", Offset = "0x9BAAFC")]
			public Interaction[] interactions;

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x159B4DC", Offset = "0x159B4DC", VA = "0x159B4DC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x159C344", Offset = "0x159C344", VA = "0x159C344")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6600", Offset = "0x9B6600")]
		public Range[] ranges;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x159B1A4", Offset = "0x159B1A4", VA = "0x159B1A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD8AC", Offset = "0x9BD8AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x159B1F0", Offset = "0x159B1F0", VA = "0x159B1F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD8E4", Offset = "0x9BD8E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x159B23C", Offset = "0x159B23C", VA = "0x159B23C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD91C", Offset = "0x9BD91C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x159B288", Offset = "0x159B288", VA = "0x159B288")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD954", Offset = "0x9BD954")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x159B2D4", Offset = "0x159B2D4", VA = "0x159B2D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD98C", Offset = "0x9BD98C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x159B320", Offset = "0x159B320", VA = "0x159B320")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x159B600", Offset = "0x159B600", VA = "0x159B600")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000F2")]
		public class Map
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x17A3284", Offset = "0x17A3284", VA = "0x17A3284")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x17A36A4", Offset = "0x17A36A4", VA = "0x17A36A4")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x17A3658", Offset = "0x17A3658", VA = "0x17A3658")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x17A3450", Offset = "0x17A3450", VA = "0x17A3450")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x17A2F90", Offset = "0x17A2F90", VA = "0x17A2F90", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD9C4", Offset = "0x9BD9C4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x17A3344", Offset = "0x17A3344", VA = "0x17A3344", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x17A3348", Offset = "0x17A3348", VA = "0x17A3348", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x17A35F0", Offset = "0x17A35F0", VA = "0x17A35F0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x17A32DC", Offset = "0x17A32DC", VA = "0x17A32DC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x17A31E4", Offset = "0x17A31E4", VA = "0x17A31E4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x17A36F4", Offset = "0x17A36F4", VA = "0x17A36F4")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000062")]
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

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x17ADDB8", Offset = "0x17ADDB8", VA = "0x17ADDB8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x17ADE80", Offset = "0x17ADE80", VA = "0x17ADE80", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x17AE064", Offset = "0x17AE064", VA = "0x17AE064", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x17AE160", Offset = "0x17AE160", VA = "0x17AE160", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x17ADEE8", Offset = "0x17ADEE8", VA = "0x17ADEE8")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x17AE59C", Offset = "0x17AE59C", VA = "0x17AE59C")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6638", Offset = "0x9B6638")]
		public float weight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6650", Offset = "0x9B6650")]
		public float localRotationWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6668", Offset = "0x9B6668")]
		public float localPositionWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600043A")]
		public abstract void AutoMapping();

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x159F0E8", Offset = "0x159F0E8", VA = "0x159F0E8")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600043C")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600043D")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x600043E")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x159F0F4", Offset = "0x159F0F4", VA = "0x159F0F4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x159F148", Offset = "0x159F148", VA = "0x159F148", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x159F184", Offset = "0x159F184", VA = "0x159F184", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x159F19C", Offset = "0x159F19C", VA = "0x159F19C")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		public class Rigidbone
		{
			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x159F7E4", Offset = "0x159F7E4", VA = "0x159F7E4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x15A045C", Offset = "0x15A045C", VA = "0x15A045C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x15A0240", Offset = "0x15A0240", VA = "0x15A0240")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000F4")]
		public class Child
		{
			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x159F994", Offset = "0x159F994", VA = "0x159F994")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x15A05F4", Offset = "0x15A05F4", VA = "0x15A05F4")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x15A05A4", Offset = "0x15A05A4", VA = "0x15A05A4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3ADC", Offset = "0x9B3ADC")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000751")]
				[Address(RVA = "0x15A0C54", Offset = "0x15A0C54", VA = "0x15A0C54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0x15A0CBC", Offset = "0x15A0CBC", VA = "0x15A0CBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x159FA0C", Offset = "0x159FA0C", VA = "0x159FA0C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x15A09EC", Offset = "0x15A09EC", VA = "0x15A09EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x15A09F0", Offset = "0x15A09F0", VA = "0x15A09F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x15A0C5C", Offset = "0x15A0C5C", VA = "0x15A0C5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6680", Offset = "0x9B6680")]
		public IK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B66B8", Offset = "0x9B66B8")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B66F0", Offset = "0x9B66F0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6728", Offset = "0x9B6728")]
		public float applyVelocity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6760", Offset = "0x9B6760")]
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
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x159F1FC", Offset = "0x159F1FC", VA = "0x159F1FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		private bool ikUsed
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x159FDF8", Offset = "0x159FDF8", VA = "0x159FDF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x159F1C4", Offset = "0x159F1C4", VA = "0x159F1C4")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x159F274", Offset = "0x159F274", VA = "0x159F274")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x159F3B0", Offset = "0x159F3B0", VA = "0x159F3B0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x159F334", Offset = "0x159F334", VA = "0x159F334")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BD9FC", Offset = "0x9BD9FC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x159FA38", Offset = "0x159FA38", VA = "0x159FA38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x159FC84", Offset = "0x159FC84", VA = "0x159FC84")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x159FD3C", Offset = "0x159FD3C", VA = "0x159FD3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x159FF7C", Offset = "0x159FF7C", VA = "0x159FF7C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x159FDBC", Offset = "0x159FDBC", VA = "0x159FDBC")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x159FF38", Offset = "0x159FF38", VA = "0x159FF38")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x15A0018", Offset = "0x15A0018", VA = "0x15A0018")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x159FFB0", Offset = "0x159FFB0", VA = "0x159FFB0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x159F2CC", Offset = "0x159F2CC", VA = "0x159F2CC")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x159FCC4", Offset = "0x159FCC4", VA = "0x159FCC4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x15A07BC", Offset = "0x15A07BC", VA = "0x15A07BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x15A08E4", Offset = "0x15A08E4", VA = "0x15A08E4")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000065")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B67A8", Offset = "0x9B67A8")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000059")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x15A26F4", Offset = "0x15A26F4", VA = "0x15A26F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x15A2730", Offset = "0x15A2730", VA = "0x15A2730")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005B")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x15A2800", Offset = "0x15A2800", VA = "0x15A2800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDA60", Offset = "0x9BDA60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x15A2808", Offset = "0x15A2808", VA = "0x15A2808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDA70", Offset = "0x9BDA70")]
			private set
			{
			}
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x15A2358", Offset = "0x15A2358", VA = "0x15A2358")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x15A23A0", Offset = "0x15A23A0", VA = "0x15A23A0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x15A23B8", Offset = "0x15A23B8", VA = "0x15A23B8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x15A264C", Offset = "0x15A264C", VA = "0x15A264C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x15A26BC", Offset = "0x15A26BC", VA = "0x15A26BC")]
		public void Disable()
		{
		}

		[Token(Token = "0x600045E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x15A255C", Offset = "0x15A255C", VA = "0x15A255C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x15A2814", Offset = "0x15A2814", VA = "0x15A2814")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x15A2818", Offset = "0x15A2818", VA = "0x15A2818")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x15A284C", Offset = "0x15A284C", VA = "0x15A284C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x15A2930", Offset = "0x15A2930", VA = "0x15A2930")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x15A2BAC", Offset = "0x15A2BAC", VA = "0x15A2BAC")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x15A2C68", Offset = "0x15A2C68", VA = "0x15A2C68")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B38D0", Offset = "0x9B38D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B38D0", Offset = "0x9B38D0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B67B8", Offset = "0x9B67B8")]
		public float limit;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B67D4", Offset = "0x9B67D4")]
		public float twistLimit;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x15A2CE0", Offset = "0x15A2CE0", VA = "0x15A2CE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDA80", Offset = "0x9BDA80")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x15A2D2C", Offset = "0x15A2D2C", VA = "0x15A2D2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDAB8", Offset = "0x9BDAB8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x15A2D78", Offset = "0x15A2D78", VA = "0x15A2D78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDAF0", Offset = "0x9BDAF0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x15A2DC4", Offset = "0x15A2DC4", VA = "0x15A2DC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDB28", Offset = "0x9BDB28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x15A2E10", Offset = "0x15A2E10", VA = "0x15A2E10", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x15A2EC8", Offset = "0x15A2EC8", VA = "0x15A2EC8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x15A3110", Offset = "0x15A3110", VA = "0x15A3110")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3930", Offset = "0x9B3930")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3930", Offset = "0x9B3930")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x15A3120", Offset = "0x15A3120", VA = "0x15A3120")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDB60", Offset = "0x9BDB60")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x15A316C", Offset = "0x15A316C", VA = "0x15A316C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDB98", Offset = "0x9BDB98")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x15A31B8", Offset = "0x15A31B8", VA = "0x15A31B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDBD0", Offset = "0x9BDBD0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x15A3204", Offset = "0x15A3204", VA = "0x15A3204")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDC08", Offset = "0x9BDC08")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x15A3250", Offset = "0x15A3250", VA = "0x15A3250", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x15A3254", Offset = "0x15A3254", VA = "0x15A3254")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x15A3500", Offset = "0x15A3500", VA = "0x15A3500")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3990", Offset = "0x9B3990")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3990", Offset = "0x9B3990")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		public class ReachCone
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000B3")]
			public Vector3 o
			{
				[Token(Token = "0x6000754")]
				[Address(RVA = "0x15A5528", Offset = "0x15A5528", VA = "0x15A5528")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B4")]
			public Vector3 a
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0x15A5560", Offset = "0x15A5560", VA = "0x15A5560")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B5")]
			public Vector3 b
			{
				[Token(Token = "0x6000756")]
				[Address(RVA = "0x15A559C", Offset = "0x15A559C", VA = "0x15A559C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 c
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0x15A55D8", Offset = "0x15A55D8", VA = "0x15A55D8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public bool isValid
			{
				[Token(Token = "0x6000759")]
				[Address(RVA = "0x15A466C", Offset = "0x15A466C", VA = "0x15A466C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x15A4CB8", Offset = "0x15A4CB8", VA = "0x15A4CB8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x15A4E2C", Offset = "0x15A4E2C", VA = "0x15A4E2C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F7")]
		public class LimitPoint
		{
			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x15A467C", Offset = "0x15A467C", VA = "0x15A467C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6800", Offset = "0x9B6800")]
		public float twistLimit;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B681C", Offset = "0x9B681C")]
		public int smoothIterations;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x15A3518", Offset = "0x15A3518", VA = "0x15A3518")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDC40", Offset = "0x9BDC40")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x15A3564", Offset = "0x15A3564", VA = "0x15A3564")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDC78", Offset = "0x9BDC78")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x15A35B0", Offset = "0x15A35B0", VA = "0x15A35B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDCB0", Offset = "0x9BDCB0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x15A35FC", Offset = "0x15A35FC", VA = "0x15A35FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDCE8", Offset = "0x9BDCE8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x15A3648", Offset = "0x15A3648", VA = "0x15A3648")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x15A3B8C", Offset = "0x15A3B8C", VA = "0x15A3B8C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x15A3C84", Offset = "0x15A3C84", VA = "0x15A3C84")]
		private void Start()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x15A428C", Offset = "0x15A428C", VA = "0x15A428C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x15A36F4", Offset = "0x15A36F4", VA = "0x15A36F4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x15A4700", Offset = "0x15A4700", VA = "0x15A4700")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x15A4FEC", Offset = "0x15A4FEC", VA = "0x15A4FEC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x15A5030", Offset = "0x15A5030", VA = "0x15A5030")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x15A5178", Offset = "0x15A5178", VA = "0x15A5178")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x15A3F50", Offset = "0x15A3F50", VA = "0x15A3F50")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x15A5308", Offset = "0x15A5308", VA = "0x15A5308")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x15A54B8", Offset = "0x15A54B8", VA = "0x15A54B8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B39F0", Offset = "0x9B39F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B39F0", Offset = "0x9B39F0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6864", Offset = "0x9B6864")]
		public float twistLimit;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x15A5614", Offset = "0x15A5614", VA = "0x15A5614")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDD20", Offset = "0x9BDD20")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x15A5660", Offset = "0x15A5660", VA = "0x15A5660")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDD58", Offset = "0x9BDD58")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x15A56AC", Offset = "0x15A56AC", VA = "0x15A56AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDD90", Offset = "0x9BDD90")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x15A56F8", Offset = "0x15A56F8", VA = "0x15A56F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDDC8", Offset = "0x9BDDC8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x15A5744", Offset = "0x15A5744", VA = "0x15A5744")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x15A5760", Offset = "0x15A5760", VA = "0x15A5760", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x15A5818", Offset = "0x15A5818", VA = "0x15A5818")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x15A5B44", Offset = "0x15A5B44", VA = "0x15A5B44")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3AEC", Offset = "0x9B3AEC")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x12522C0", Offset = "0x12522C0", VA = "0x12522C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x1252328", Offset = "0x1252328", VA = "0x1252328", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1252090", Offset = "0x1252090", VA = "0x1252090")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1252190", Offset = "0x1252190", VA = "0x1252190", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1252194", Offset = "0x1252194", VA = "0x1252194", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x12522C8", Offset = "0x12522C8", VA = "0x12522C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6890", Offset = "0x9B6890")]
		public AimIK ik;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B68C8", Offset = "0x9B68C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B68C8", Offset = "0x9B68C8")]
		public float weight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B691C", Offset = "0x9B691C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B691C", Offset = "0x9B691C")]
		public Transform target;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B697C", Offset = "0x9B697C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B69B4", Offset = "0x9B69B4")]
		public float weightSmoothTime;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B69EC", Offset = "0x9B69EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B69EC", Offset = "0x9B69EC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6A4C", Offset = "0x9B6A4C")]
		public float maxRadiansDelta;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6A84", Offset = "0x9B6A84")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6ABC", Offset = "0x9B6ABC")]
		public float slerpSpeed;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6AF4", Offset = "0x9B6AF4")]
		public float smoothDampTime;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6B2C", Offset = "0x9B6B2C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6B64", Offset = "0x9B6B64")]
		public float minDistance;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6B9C", Offset = "0x9B6B9C")]
		public Vector3 offset;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B6BD4", Offset = "0x9B6BD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6BD4", Offset = "0x9B6BD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6BD4", Offset = "0x9B6BD4")]
		public float maxRootAngle;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6C50", Offset = "0x9B6C50")]
		public bool turnToTarget;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6C88", Offset = "0x9B6C88")]
		public float turnToTargetTime;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B6CC0", Offset = "0x9B6CC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6CC0", Offset = "0x9B6CC0")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6D20", Offset = "0x9B6D20")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700005C")]
		private Vector3 pivot
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x125100C", Offset = "0x125100C", VA = "0x125100C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1250F0C", Offset = "0x1250F0C", VA = "0x1250F0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1251158", Offset = "0x1251158", VA = "0x1251158")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1251B08", Offset = "0x1251B08", VA = "0x1251B08")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1251CA4", Offset = "0x1251CA4", VA = "0x1251CA4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1252014", Offset = "0x1252014", VA = "0x1252014")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BDE00", Offset = "0x9BDE00")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x12520BC", Offset = "0x12520BC", VA = "0x12520BC")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public class Pose
		{
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1252528", Offset = "0x1252528", VA = "0x1252528")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1252834", Offset = "0x1252834", VA = "0x1252834")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x125283C", Offset = "0x125283C", VA = "0x125283C")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x124C6EC", Offset = "0x124C6EC", VA = "0x124C6EC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x124C7C8", Offset = "0x124C7C8", VA = "0x124C7C8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x12527C0", Offset = "0x12527C0", VA = "0x12527C0")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000123")]
			public class EffectorLink
			{
				[Token(Token = "0x400083B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBC7C", Offset = "0x9BBC7C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400083C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBCB4", Offset = "0x9BBCB4")]
				public float weight;

				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x1252E2C", Offset = "0x1252E2C", VA = "0x1252E2C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB34", Offset = "0x9BAB34")]
			public Transform transform;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB6C", Offset = "0x9BAB6C")]
			public Transform relativeTo;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BABA4", Offset = "0x9BABA4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BABDC", Offset = "0x9BABDC")]
			public float verticalWeight;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC14", Offset = "0x9BAC14")]
			public float horizontalWeight;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC4C", Offset = "0x9BAC4C")]
			public float speed;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1252998", Offset = "0x1252998", VA = "0x1252998")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1252E04", Offset = "0x1252E04", VA = "0x1252E04")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1252E14", Offset = "0x1252E14", VA = "0x1252E14")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6D58", Offset = "0x9B6D58")]
		public Body[] bodies;

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1252858", Offset = "0x1252858", VA = "0x1252858", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1252DFC", Offset = "0x1252DFC", VA = "0x1252DFC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6D90", Offset = "0x9B6D90")]
		public float tiltSpeed;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6DC8", Offset = "0x9B6DC8")]
		public float tiltSensitivity;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6E00", Offset = "0x9B6E00")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6E38", Offset = "0x9B6E38")]
		public OffsetPose poseRight;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x125446C", Offset = "0x125446C", VA = "0x125446C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x12544B4", Offset = "0x12544B4", VA = "0x12544B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x12546E4", Offset = "0x12546E4", VA = "0x12546E4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6E70", Offset = "0x9B6E70")]
		public float weight;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x12546F8", Offset = "0x12546F8", VA = "0x12546F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x12547C8", Offset = "0x12547C8", VA = "0x12547C8")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1254AD8", Offset = "0x1254AD8", VA = "0x1254AD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1254BF4", Offset = "0x1254BF4", VA = "0x1254BF4")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6E88", Offset = "0x9B6E88")]
		public Animator animator;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6EC0", Offset = "0x9B6EC0")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6F08", Offset = "0x9B6F08")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700005D")]
		public IK ik
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1255684", Offset = "0x1255684", VA = "0x1255684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDE64", Offset = "0x9BDE64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x125568C", Offset = "0x125568C", VA = "0x125568C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDE74", Offset = "0x9BDE74")]
			private set
			{
			}
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1255694", Offset = "0x1255694", VA = "0x1255694")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1255824", Offset = "0x1255824", VA = "0x1255824")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1255AAC", Offset = "0x1255AAC", VA = "0x1255AAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1255BFC", Offset = "0x1255BFC", VA = "0x1255BFC")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1255DE8", Offset = "0x1255DE8", VA = "0x1255DE8")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1256000", Offset = "0x1256000", VA = "0x1256000")]
		public void Update()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x12562A4", Offset = "0x12562A4", VA = "0x12562A4")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9B3A60", Offset = "0x9B3A60")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x1700005E")]
		public bool poseStored
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1255920", Offset = "0x1255920", VA = "0x1255920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1255C80", Offset = "0x1255C80", VA = "0x1255C80")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1255944", Offset = "0x1255944", VA = "0x1255944")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1256310", Offset = "0x1256310", VA = "0x1256310")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC84", Offset = "0x9BAC84")]
			public string name;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BACBC", Offset = "0x9BACBC")]
			public Collider collider;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BACF4", Offset = "0x9BACF4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAD40", Offset = "0x9BAD40")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAD50", Offset = "0x9BAD50")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAD60", Offset = "0x9BAD60")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAD70", Offset = "0x9BAD70")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000BA")]
			public bool inProgress
			{
				[Token(Token = "0x6000768")]
				[Address(RVA = "0x17AE660", Offset = "0x17AE660", VA = "0x17AE660")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BB")]
			protected float crossFader
			{
				[Token(Token = "0x6000769")]
				[Address(RVA = "0x17AEC08", Offset = "0x17AEC08", VA = "0x17AEC08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5C0", Offset = "0x9BE5C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600076A")]
				[Address(RVA = "0x17AEC10", Offset = "0x17AEC10", VA = "0x17AEC10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5D0", Offset = "0x9BE5D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			protected float timer
			{
				[Token(Token = "0x600076B")]
				[Address(RVA = "0x17AEC18", Offset = "0x17AEC18", VA = "0x17AEC18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5E0", Offset = "0x9BE5E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600076C")]
				[Address(RVA = "0x17AEC20", Offset = "0x17AEC20", VA = "0x17AEC20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5F0", Offset = "0x9BE5F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			protected Vector3 force
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0x17AEC28", Offset = "0x17AEC28", VA = "0x17AEC28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE600", Offset = "0x9BE600")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600076E")]
				[Address(RVA = "0x17AEC34", Offset = "0x17AEC34", VA = "0x17AEC34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE610", Offset = "0x9BE610")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			protected Vector3 point
			{
				[Token(Token = "0x600076F")]
				[Address(RVA = "0x17AEC40", Offset = "0x17AEC40", VA = "0x17AEC40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE620", Offset = "0x9BE620")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000770")]
				[Address(RVA = "0x17AEC4C", Offset = "0x17AEC4C", VA = "0x17AEC4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE630", Offset = "0x9BE630")]
				private set
				{
				}
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x17AEAD4", Offset = "0x17AEAD4", VA = "0x17AEAD4")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x17AE748", Offset = "0x17AE748", VA = "0x17AE748")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000773")]
			protected abstract float GetLength();

			[Token(Token = "0x6000774")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000775")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x17AEC58", Offset = "0x17AEC58", VA = "0x17AEC58")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FC")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000124")]
			public class EffectorLink
			{
				[Token(Token = "0x400083D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBCEC", Offset = "0x9BBCEC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400083E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD24", Offset = "0x9BBD24")]
				public float weight;

				[Token(Token = "0x400083F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000840")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x17AF5D4", Offset = "0x17AF5D4", VA = "0x17AF5D4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x17AF3C8", Offset = "0x17AF3C8", VA = "0x17AF3C8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x17AF710", Offset = "0x17AF710", VA = "0x17AF710")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAD80", Offset = "0x9BAD80")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BADB8", Offset = "0x9BADB8")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BADF0", Offset = "0x9BADF0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x17AF1E4", Offset = "0x17AF1E4", VA = "0x17AF1E4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x17AF35C", Offset = "0x17AF35C", VA = "0x17AF35C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x17AF3DC", Offset = "0x17AF3DC", VA = "0x17AF3DC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x17AF6FC", Offset = "0x17AF6FC", VA = "0x17AF6FC")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FD")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000125")]
			public class BoneLink
			{
				[Token(Token = "0x4000841")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD5C", Offset = "0x9BBD5C")]
				public Transform bone;

				[Token(Token = "0x4000842")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD94", Offset = "0x9BBD94")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBD94", Offset = "0x9BBD94")]
				public float weight;

				[Token(Token = "0x4000843")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000844")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x17AEFEC", Offset = "0x17AEFEC", VA = "0x17AEFEC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x17AED74", Offset = "0x17AED74", VA = "0x17AED74")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007F2")]
				[Address(RVA = "0x17AF15C", Offset = "0x17AF15C", VA = "0x17AF15C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAE28", Offset = "0x9BAE28")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAE60", Offset = "0x9BAE60")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x17AEC6C", Offset = "0x17AEC6C", VA = "0x17AEC6C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x17AED10", Offset = "0x17AED10", VA = "0x17AED10", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x17AED80", Offset = "0x17AED80", VA = "0x17AED80", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x17AF148", Offset = "0x17AF148", VA = "0x17AF148")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6F18", Offset = "0x9B6F18")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6F50", Offset = "0x9B6F50")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005F")]
		public bool inProgress
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x17AE5A4", Offset = "0x17AE5A4", VA = "0x17AE5A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x17AE674", Offset = "0x17AE674", VA = "0x17AE674", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x17AE894", Offset = "0x17AE894", VA = "0x17AE894")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x17AEC00", Offset = "0x17AEC00", VA = "0x17AEC00")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public abstract class Offset
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAE98", Offset = "0x9BAE98")]
			public string name;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAED0", Offset = "0x9BAED0")]
			public Collider collider;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF08", Offset = "0x9BAF08")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAF54", Offset = "0x9BAF54")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAF64", Offset = "0x9BAF64")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAF74", Offset = "0x9BAF74")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BAF84", Offset = "0x9BAF84")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000BF")]
			protected float crossFader
			{
				[Token(Token = "0x600077F")]
				[Address(RVA = "0x17AFCC8", Offset = "0x17AFCC8", VA = "0x17AFCC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE640", Offset = "0x9BE640")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000780")]
				[Address(RVA = "0x17AFCD0", Offset = "0x17AFCD0", VA = "0x17AFCD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE650", Offset = "0x9BE650")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected float timer
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0x17AFCD8", Offset = "0x17AFCD8", VA = "0x17AFCD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE660", Offset = "0x9BE660")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000782")]
				[Address(RVA = "0x17AFCE0", Offset = "0x17AFCE0", VA = "0x17AFCE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE670", Offset = "0x9BE670")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			protected Vector3 force
			{
				[Token(Token = "0x6000783")]
				[Address(RVA = "0x17AFCE8", Offset = "0x17AFCE8", VA = "0x17AFCE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE680", Offset = "0x9BE680")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000784")]
				[Address(RVA = "0x17AFCF4", Offset = "0x17AFCF4", VA = "0x17AFCF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE690", Offset = "0x9BE690")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			protected Vector3 point
			{
				[Token(Token = "0x6000785")]
				[Address(RVA = "0x17AFD00", Offset = "0x17AFD00", VA = "0x17AFD00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6A0", Offset = "0x9BE6A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000786")]
				[Address(RVA = "0x17AFD0C", Offset = "0x17AFD0C", VA = "0x17AFD0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6B0", Offset = "0x9BE6B0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x17AFB80", Offset = "0x17AFB80", VA = "0x17AFB80")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x17AF7E4", Offset = "0x17AF7E4", VA = "0x17AF7E4")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000789")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600078A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600078B")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x17AFD18", Offset = "0x17AFD18", VA = "0x17AFD18")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000126")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000845")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBDE8", Offset = "0x9BBDE8")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000846")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBE20", Offset = "0x9BBE20")]
				public float weight;

				[Token(Token = "0x4000847")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000848")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007F3")]
				[Address(RVA = "0x17B01D4", Offset = "0x17B01D4", VA = "0x17B01D4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x17AFF90", Offset = "0x17AFF90", VA = "0x17AFF90")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x17B02F0", Offset = "0x17B02F0", VA = "0x17B02F0")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF94", Offset = "0x9BAF94")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAFCC", Offset = "0x9BAFCC")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB004", Offset = "0x9BB004")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x17AFD2C", Offset = "0x17AFD2C", VA = "0x17AFD2C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x17AFF24", Offset = "0x17AFF24", VA = "0x17AFF24", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x17AFFA4", Offset = "0x17AFFA4", VA = "0x17AFFA4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x17B02D4", Offset = "0x17B02D4", VA = "0x17B02D4")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000127")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000849")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBE58", Offset = "0x9BBE58")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400084A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBE90", Offset = "0x9BBE90")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBE90", Offset = "0x9BBE90")]
				public float weight;

				[Token(Token = "0x400084B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400084C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x17B076C", Offset = "0x17B076C", VA = "0x17B076C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x17B0440", Offset = "0x17B0440", VA = "0x17B0440")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x17B08A8", Offset = "0x17B08A8", VA = "0x17B08A8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB03C", Offset = "0x9BB03C")]
			public int curveIndex;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB074", Offset = "0x9BB074")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x17B02F8", Offset = "0x17B02F8", VA = "0x17B02F8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x17B03DC", Offset = "0x17B03DC", VA = "0x17B03DC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x17B044C", Offset = "0x17B044C", VA = "0x17B044C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x17B0894", Offset = "0x17B0894", VA = "0x17B0894")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6F88", Offset = "0x9B6F88")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6FC0", Offset = "0x9B6FC0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x17AF718", Offset = "0x17AF718", VA = "0x17AF718", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x17AF938", Offset = "0x17AF938", VA = "0x17AF938")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x17AFCC0", Offset = "0x17AFCC0", VA = "0x17AFCC0")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000128")]
			public class EffectorLink
			{
				[Token(Token = "0x400084D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBEE4", Offset = "0x9BBEE4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400084E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF1C", Offset = "0x9BBF1C")]
				public float weight;

				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x1884360", Offset = "0x1884360", VA = "0x1884360")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB0AC", Offset = "0x9BB0AC")]
			public Transform transform;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB0E4", Offset = "0x9BB0E4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB11C", Offset = "0x9BB11C")]
			public float speed;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB154", Offset = "0x9BB154")]
			public float acceleration;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB18C", Offset = "0x9BB18C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB18C", Offset = "0x9BB18C")]
			public float matchVelocity;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB1E0", Offset = "0x9BB1E0")]
			public float gravity;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1883E2C", Offset = "0x1883E2C", VA = "0x1883E2C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1883FC4", Offset = "0x1883FC4", VA = "0x1883FC4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1884344", Offset = "0x1884344", VA = "0x1884344")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6FF8", Offset = "0x9B6FF8")]
		public Body[] bodies;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7030", Offset = "0x9B7030")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1883DB4", Offset = "0x1883DB4", VA = "0x1883DB4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1883F08", Offset = "0x1883F08", VA = "0x1883F08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x188433C", Offset = "0x188433C", VA = "0x188433C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B7068", Offset = "0x9B7068")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7068", Offset = "0x9B7068")]
		public Transform target;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B70C8", Offset = "0x9B70C8")]
		public float weight;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B70E0", Offset = "0x9B70E0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7118", Offset = "0x9B7118")]
		public float weightSmoothTime;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B7150", Offset = "0x9B7150")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7150", Offset = "0x9B7150")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B71B0", Offset = "0x9B71B0")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B71E8", Offset = "0x9B71E8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7220", Offset = "0x9B7220")]
		public float slerpSpeed;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7258", Offset = "0x9B7258")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7290", Offset = "0x9B7290")]
		public float minDistance;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B72C8", Offset = "0x9B72C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B72C8", Offset = "0x9B72C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B72C8", Offset = "0x9B72C8")]
		public float maxRootAngle;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000060")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x159C79C", Offset = "0x159C79C", VA = "0x159C79C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x159C6B4", Offset = "0x159C6B4", VA = "0x159C6B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x159C8E8", Offset = "0x159C8E8", VA = "0x159C8E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x159CFB8", Offset = "0x159CFB8", VA = "0x159CFB8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x159D154", Offset = "0x159D154", VA = "0x159D154")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x159D470", Offset = "0x159D470", VA = "0x159D470")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		public class OffsetLimits
		{
			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB218", Offset = "0x9BB218")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB250", Offset = "0x9BB250")]
			public float spring;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB288", Offset = "0x9BB288")]
			public bool x;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB2C0", Offset = "0x9BB2C0")]
			public bool y;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB2F8", Offset = "0x9BB2F8")]
			public bool z;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB330", Offset = "0x9BB330")]
			public float minX;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB368", Offset = "0x9BB368")]
			public float maxX;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB3A0", Offset = "0x9BB3A0")]
			public float minY;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB3D8", Offset = "0x9BB3D8")]
			public float maxY;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB410", Offset = "0x9BB410")]
			public float minZ;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB448", Offset = "0x9BB448")]
			public float maxZ;

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x159D998", Offset = "0x159D998", VA = "0x159D998")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x159DEF4", Offset = "0x159DEF4", VA = "0x159DEF4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x159DF24", Offset = "0x159DF24", VA = "0x159DF24")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x159DFFC", Offset = "0x159DFFC", VA = "0x159DFFC")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3AFC", Offset = "0x9B3AFC")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079F")]
				[Address(RVA = "0x159DE84", Offset = "0x159DE84", VA = "0x159DE84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A1")]
				[Address(RVA = "0x159DEEC", Offset = "0x159DEEC", VA = "0x159DEEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x159D7A4", Offset = "0x159D7A4", VA = "0x159D7A4")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x159DD24", Offset = "0x159DD24", VA = "0x159DD24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x159DD28", Offset = "0x159DD28", VA = "0x159DD28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x159DE8C", Offset = "0x159DE8C", VA = "0x159DE8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7344", Offset = "0x9B7344")]
		public float weight;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B737C", Offset = "0x9B737C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000061")]
		protected float deltaTime
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x159D6D0", Offset = "0x159D6D0", VA = "0x159D6D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004BD")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x159D6FC", Offset = "0x159D6FC", VA = "0x159D6FC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x159D728", Offset = "0x159D728", VA = "0x159D728")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BDE84", Offset = "0x9BDE84")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x159D7D0", Offset = "0x159D7D0", VA = "0x159D7D0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x159D8DC", Offset = "0x159D8DC", VA = "0x159D8DC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x159DBF8", Offset = "0x159DBF8", VA = "0x159DBF8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x159DD14", Offset = "0x159DD14", VA = "0x159DD14")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3B0C", Offset = "0x9B3B0C")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x159E49C", Offset = "0x159E49C", VA = "0x159E49C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A7")]
				[Address(RVA = "0x159E504", Offset = "0x159E504", VA = "0x159E504", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x159E0D8", Offset = "0x159E0D8", VA = "0x159E0D8")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x159E33C", Offset = "0x159E33C", VA = "0x159E33C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x159E340", Offset = "0x159E340", VA = "0x159E340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x159E4A4", Offset = "0x159E4A4", VA = "0x159E4A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B73B4", Offset = "0x9B73B4")]
		public float weight;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B73EC", Offset = "0x9B73EC")]
		public VRIK ik;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000062")]
		protected float deltaTime
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x159E004", Offset = "0x159E004", VA = "0x159E004")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004C5")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x159E030", Offset = "0x159E030", VA = "0x159E030", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x159E05C", Offset = "0x159E05C", VA = "0x159E05C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BDEE8", Offset = "0x9BDEE8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x159E104", Offset = "0x159E104", VA = "0x159E104")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x159E210", Offset = "0x159E210", VA = "0x159E210", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x159E32C", Offset = "0x159E32C", VA = "0x159E32C")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class EffectorLink
		{
			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x159E5CC", Offset = "0x159E5CC", VA = "0x159E5CC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x159EA28", Offset = "0x159EA28", VA = "0x159EA28")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x159E50C", Offset = "0x159E50C", VA = "0x159E50C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x159E904", Offset = "0x159E904", VA = "0x159E904")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x159E9BC", Offset = "0x159E9BC", VA = "0x159E9BC")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000106")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x2000129")]
			public class EffectorLink
			{
				[Token(Token = "0x400084F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF54", Offset = "0x9BBF54")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000850")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF8C", Offset = "0x9BBF8C")]
				public float weight;

				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x159F0E0", Offset = "0x159F0E0", VA = "0x159F0E0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB480", Offset = "0x9BB480")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB4B8", Offset = "0x9BB4B8")]
			public Transform raycastTo;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB4F0", Offset = "0x9BB4F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB4F0", Offset = "0x9BB4F0")]
			public float raycastRadius;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB544", Offset = "0x9BB544")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB57C", Offset = "0x9BB57C")]
			public float smoothTimeIn;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB5B4", Offset = "0x9BB5B4")]
			public float smoothTimeOut;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB5EC", Offset = "0x9BB5EC")]
			public LayerMask layers;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x159EAB4", Offset = "0x159EAB4", VA = "0x159EAB4")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x159ECC0", Offset = "0x159ECC0", VA = "0x159ECC0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x159EE58", Offset = "0x159EE58", VA = "0x159EE58")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x159F0CC", Offset = "0x159F0CC", VA = "0x159F0CC")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7424", Offset = "0x9B7424")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x159EA30", Offset = "0x159EA30", VA = "0x159EA30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x159ECB0", Offset = "0x159ECB0", VA = "0x159ECB0")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200012A")]
			public class EffectorLink
			{
				[Token(Token = "0x4000851")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBFC4", Offset = "0x9BBFC4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000852")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBFFC", Offset = "0x9BBFFC")]
				public float weight;

				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x15A2350", Offset = "0x15A2350", VA = "0x15A2350")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB624", Offset = "0x9BB624")]
			public Vector3 offset;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB65C", Offset = "0x9BB65C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB65C", Offset = "0x9BB65C")]
			public float additivity;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB6B0", Offset = "0x9BB6B0")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB6E8", Offset = "0x9BB6E8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x15A1040", Offset = "0x15A1040", VA = "0x15A1040")]
			public void Start()
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x15A1BF4", Offset = "0x15A1BF4", VA = "0x15A1BF4")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x15A233C", Offset = "0x15A233C", VA = "0x15A233C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public enum Handedness
		{
			[Token(Token = "0x40007A5")]
			Right,
			[Token(Token = "0x40007A6")]
			Left
		}

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B745C", Offset = "0x9B745C")]
		public AimIK aimIK;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7494", Offset = "0x9B7494")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B74CC", Offset = "0x9B74CC")]
		public Handedness handedness;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7504", Offset = "0x9B7504")]
		public bool twoHanded;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B753C", Offset = "0x9B753C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7574", Offset = "0x9B7574")]
		public float magnitudeRandom;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B75AC", Offset = "0x9B75AC")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B75E4", Offset = "0x9B75E4")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B761C", Offset = "0x9B761C")]
		public float blendTime;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9B7654", Offset = "0x9B7654")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7654", Offset = "0x9B7654")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000063")]
		public bool isFinished
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x15A0E18", Offset = "0x15A0E18", VA = "0x15A0E18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x15A1EA8", Offset = "0x15A1EA8", VA = "0x15A1EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x15A1EE8", Offset = "0x15A1EE8", VA = "0x15A1EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x15A1E68", Offset = "0x15A1E68", VA = "0x15A1E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x15A1E88", Offset = "0x15A1E88", VA = "0x15A1E88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x15A0E48", Offset = "0x15A0E48", VA = "0x15A0E48")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x15A0E74", Offset = "0x15A0E74", VA = "0x15A0E74")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x15A10F0", Offset = "0x15A10F0", VA = "0x15A10F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x15A1F28", Offset = "0x15A1F28", VA = "0x15A1F28")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x15A2080", Offset = "0x15A2080", VA = "0x15A2080")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x15A20BC", Offset = "0x15A20BC", VA = "0x15A20BC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x15A2288", Offset = "0x15A2288", VA = "0x15A2288")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B76B4", Offset = "0x9B76B4")]
		public float weight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B76EC", Offset = "0x9B76EC")]
		public float offset;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x15A5B50", Offset = "0x15A5B50", VA = "0x15A5B50")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x15A5C44", Offset = "0x15A5C44", VA = "0x15A5C44")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x15A5D30", Offset = "0x15A5D30", VA = "0x15A5D30")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x15A6178", Offset = "0x15A6178", VA = "0x15A6178")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x15A61B0", Offset = "0x15A61B0", VA = "0x15A61B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x15A62CC", Offset = "0x15A62CC", VA = "0x15A62CC")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class Settings
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB720", Offset = "0x9BB720")]
			public float scaleMlp;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB758", Offset = "0x9BB758")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB790", Offset = "0x9BB790")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB7C8", Offset = "0x9BB7C8")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB800", Offset = "0x9BB800")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB838", Offset = "0x9BB838")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB870", Offset = "0x9BB870")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BB8A8", Offset = "0x9BB8A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB8A8", Offset = "0x9BB8A8")]
			public Vector3 headOffset;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB8F8", Offset = "0x9BB8F8")]
			public Vector3 handOffset;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB930", Offset = "0x9BB930")]
			public float footForwardOffset;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB968", Offset = "0x9BB968")]
			public float footInwardOffset;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB9A0", Offset = "0x9BB9A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB9A0", Offset = "0x9BB9A0")]
			public float footHeadingOffset;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB9FC", Offset = "0x9BB9FC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBA14", Offset = "0x9BBA14")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x15AD144", Offset = "0x15AD144", VA = "0x15AD144")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x200012B")]
			public class Target
			{
				[Token(Token = "0x4000853")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000854")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000855")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x15AAC08", Offset = "0x15AAC08", VA = "0x15AAC08")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x15AB784", Offset = "0x15AB784", VA = "0x15AB784")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x15AA04C", Offset = "0x15AA04C", VA = "0x15AA04C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x15A8B2C", Offset = "0x15A8B2C", VA = "0x15A8B2C")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x15A8B44", Offset = "0x15A8B44", VA = "0x15A8B44")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x15A8CDC", Offset = "0x15A8CDC", VA = "0x15A8CDC")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x15A8B90", Offset = "0x15A8B90", VA = "0x15A8B90")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x15A8CF4", Offset = "0x15A8CF4", VA = "0x15A8CF4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x15AA1C4", Offset = "0x15AA1C4", VA = "0x15AA1C4")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x15AACCC", Offset = "0x15AACCC", VA = "0x15AACCC")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x15AB7E4", Offset = "0x15AB7E4", VA = "0x15AB7E4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x15ABC00", Offset = "0x15ABC00", VA = "0x15ABC00")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x15ABE24", Offset = "0x15ABE24", VA = "0x15ABE24")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x15AC544", Offset = "0x15AC544", VA = "0x15AC544")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x15AC2F8", Offset = "0x15AC2F8", VA = "0x15AC2F8")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x15AC820", Offset = "0x15AC820", VA = "0x15AC820")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x15ACB1C", Offset = "0x15ACB1C", VA = "0x15ACB1C")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x15ACCF4", Offset = "0x15ACCF4", VA = "0x15ACCF4")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200007C")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x15AD21C", Offset = "0x15AD21C", VA = "0x15AD21C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x15AD27C", Offset = "0x15AD27C", VA = "0x15AD27C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x15AD2B0", Offset = "0x15AD2B0", VA = "0x15AD2B0")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x15AD438", Offset = "0x15AD438", VA = "0x15AD438")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7724", Offset = "0x9B7724")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000068")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x15AD450", Offset = "0x15AD450", VA = "0x15AD450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDF4C", Offset = "0x9BDF4C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x15AD45C", Offset = "0x15AD45C", VA = "0x15AD45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDF5C", Offset = "0x9BDF5C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x15AD468", Offset = "0x15AD468", VA = "0x15AD468")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x15AA9AC", Offset = "0x15AA9AC", VA = "0x15AA9AC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x15ABA58", Offset = "0x15ABA58", VA = "0x15ABA58")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x15AD564", Offset = "0x15AD564", VA = "0x15AD564")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x15ADA08", Offset = "0x15ADA08", VA = "0x15ADA08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x15ADB24", Offset = "0x15ADB24", VA = "0x15ADB24")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200007E")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class Offset
		{
			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x15FF708", Offset = "0x15FF708", VA = "0x15FF708")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x15FF9B4", Offset = "0x15FF9B4", VA = "0x15FF9B4")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x15FF630", Offset = "0x15FF630", VA = "0x15FF630")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x15FF690", Offset = "0x15FF690", VA = "0x15FF690")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x15FF8C4", Offset = "0x15FF8C4", VA = "0x15FF8C4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x15FF9AC", Offset = "0x15FF9AC", VA = "0x15FF9AC")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x15F6BDC", Offset = "0x15F6BDC", VA = "0x15F6BDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x15F6C60", Offset = "0x15F6C60", VA = "0x15F6C60")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7734", Offset = "0x9B7734")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x15F6C68", Offset = "0x15F6C68", VA = "0x15F6C68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x15F6D70", Offset = "0x15F6D70", VA = "0x15F6D70")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x124BE98", Offset = "0x124BE98", VA = "0x124BE98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x124BEDC", Offset = "0x124BEDC", VA = "0x124BEDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x124C13C", Offset = "0x124C13C", VA = "0x124C13C")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B776C", Offset = "0x9B776C")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B77A4", Offset = "0x9B77A4")]
		public AimIK aim;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B77DC", Offset = "0x9B77DC")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7814", Offset = "0x9B7814")]
		public Animator animator;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B784C", Offset = "0x9B784C")]
		public float crossfadeTime;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7884", Offset = "0x9B7884")]
		public float minAimDistance;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x124C144", Offset = "0x124C144", VA = "0x124C144")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x124C188", Offset = "0x124C188", VA = "0x124C188")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x124C2DC", Offset = "0x124C2DC", VA = "0x124C2DC")]
		private void Pose()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x124C4F4", Offset = "0x124C4F4", VA = "0x124C4F4")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x124C834", Offset = "0x124C834", VA = "0x124C834")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x124C90C", Offset = "0x124C90C", VA = "0x124C90C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x124D6D8", Offset = "0x124D6D8", VA = "0x124D6D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x124D93C", Offset = "0x124D93C", VA = "0x124D93C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x124DB8C", Offset = "0x124DB8C", VA = "0x124DB8C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B78BC", Offset = "0x9B78BC")]
		public Animator animator;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B78F4", Offset = "0x9B78F4")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B792C", Offset = "0x9B792C")]
		public float lookAtWeight;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7944", Offset = "0x9B7944")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B795C", Offset = "0x9B795C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7974", Offset = "0x9B7974")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B798C", Offset = "0x9B798C")]
		public float lookAtClampWeight;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B79A4", Offset = "0x9B79A4")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B79BC", Offset = "0x9B79BC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B79D4", Offset = "0x9B79D4")]
		public Transform footTargetBiped;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7A0C", Offset = "0x9B7A0C")]
		public float footPositionWeight;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7A24", Offset = "0x9B7A24")]
		public float footRotationWeight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B7A3C", Offset = "0x9B7A3C")]
		public Transform handTargetBiped;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7A74", Offset = "0x9B7A74")]
		public float handPositionWeight;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7A8C", Offset = "0x9B7A8C")]
		public float handRotationWeight;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x15F8954", Offset = "0x15F8954", VA = "0x15F8954")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x15F8E00", Offset = "0x15F8E00", VA = "0x15F8E00")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7AA4", Offset = "0x9B7AA4")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x17000069")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1244FC4", Offset = "0x1244FC4", VA = "0x1244FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDF6C", Offset = "0x9BDF6C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1244FD0", Offset = "0x1244FD0", VA = "0x1244FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BDF7C", Offset = "0x9BDF7C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1244FDC", Offset = "0x1244FDC", VA = "0x1244FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1245018", Offset = "0x1245018", VA = "0x1245018")]
		private void Update()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1245AD0", Offset = "0x1245AD0", VA = "0x1245AD0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x12457B8", Offset = "0x12457B8", VA = "0x12457B8")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1245C78", Offset = "0x1245C78", VA = "0x1245C78")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700006A")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1245CA4", Offset = "0x1245CA4", VA = "0x1245CA4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1245D44", Offset = "0x1245D44", VA = "0x1245D44")]
		private void Update()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1245FDC", Offset = "0x1245FDC", VA = "0x1245FDC")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3B1C", Offset = "0x9B3B1C")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B8")]
				[Address(RVA = "0x12473EC", Offset = "0x12473EC", VA = "0x12473EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007BA")]
				[Address(RVA = "0x1247454", Offset = "0x1247454", VA = "0x1247454", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1246FD8", Offset = "0x1246FD8", VA = "0x1246FD8")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x12470AC", Offset = "0x12470AC", VA = "0x12470AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x12470B0", Offset = "0x12470B0", VA = "0x12470B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x12473F4", Offset = "0x12473F4", VA = "0x12473F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x1700006B")]
		public bool isStepping
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x1245FF0", Offset = "0x1245FF0", VA = "0x1245FF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 position
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1245C44", Offset = "0x1245C44", VA = "0x1245C44")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1246004", Offset = "0x1246004", VA = "0x1246004")]
			set
			{
			}
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1246054", Offset = "0x1246054", VA = "0x1246054")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x12462D8", Offset = "0x12462D8", VA = "0x12462D8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x12464F4", Offset = "0x12464F4", VA = "0x12464F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x12467AC", Offset = "0x12467AC", VA = "0x12467AC")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1246B44", Offset = "0x1246B44", VA = "0x1246B44")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1246DA0", Offset = "0x1246DA0", VA = "0x1246DA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x12466F4", Offset = "0x12466F4", VA = "0x12466F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BDF8C", Offset = "0x9BDF8C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1247004", Offset = "0x1247004", VA = "0x1247004")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x124745C", Offset = "0x124745C", VA = "0x124745C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1247518", Offset = "0x1247518", VA = "0x1247518")]
		private void Update()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x12477AC", Offset = "0x12477AC", VA = "0x12477AC")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public struct Warp
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBA3C", Offset = "0x9BBA3C")]
			public int animationLayer;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBA74", Offset = "0x9BBA74")]
			public string animationState;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBAAC", Offset = "0x9BBAAC")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBAE4", Offset = "0x9BBAE4")]
			public Transform warpFrom;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBB1C", Offset = "0x9BBB1C")]
			public Transform warpTo;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBB54", Offset = "0x9BBB54")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200010E")]
		public enum EffectorMode
		{
			[Token(Token = "0x40007D1")]
			PositionOffset,
			[Token(Token = "0x40007D2")]
			Position
		}

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7AB4", Offset = "0x9B7AB4")]
		public Animator animator;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7AEC", Offset = "0x9B7AEC")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9B7B24", Offset = "0x9B7B24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7B24", Offset = "0x9B7B24")]
		public Warp[] warps;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x15F6DE8", Offset = "0x15F6DE8", VA = "0x15F6DE8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x15F6E14", Offset = "0x15F6E14", VA = "0x15F6E14")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x15F701C", Offset = "0x15F701C", VA = "0x15F701C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x15F73D0", Offset = "0x15F73D0", VA = "0x15F73D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x15F7470", Offset = "0x15F7470", VA = "0x15F7470")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x15F7478", Offset = "0x15F7478", VA = "0x15F7478", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x15F74D8", Offset = "0x15F74D8", VA = "0x15F74D8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x15F7710", Offset = "0x15F7710", VA = "0x15F7710", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x15F7974", Offset = "0x15F7974", VA = "0x15F7974")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7B74", Offset = "0x9B7B74")]
		public float headLookWeight;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x15F7988", Offset = "0x15F7988", VA = "0x15F7988", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x15F7B34", Offset = "0x15F7B34", VA = "0x15F7B34", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x15F7BB0", Offset = "0x15F7BB0", VA = "0x15F7BB0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x15F7D08", Offset = "0x15F7D08", VA = "0x15F7D08")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x15F7D50", Offset = "0x15F7D50", VA = "0x15F7D50")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x15F8348", Offset = "0x15F8348", VA = "0x15F8348")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x15F810C", Offset = "0x15F810C", VA = "0x15F810C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x15F86A0", Offset = "0x15F86A0", VA = "0x15F86A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x15F87BC", Offset = "0x15F87BC", VA = "0x15F87BC")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x15F9DD0", Offset = "0x15F9DD0", VA = "0x15F9DD0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x15F9E38", Offset = "0x15F9E38", VA = "0x15F9E38", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x15FA0FC", Offset = "0x15FA0FC", VA = "0x15FA0FC")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x15FA2B4", Offset = "0x15FA2B4", VA = "0x15FA2B4")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700006D")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x15FB120", Offset = "0x15FB120", VA = "0x15FB120")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006E")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x15FB1C0", Offset = "0x15FB1C0", VA = "0x15FB1C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x15FAE64", Offset = "0x15FAE64", VA = "0x15FAE64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x15FAEDC", Offset = "0x15FAEDC", VA = "0x15FAEDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x15FB260", Offset = "0x15FB260", VA = "0x15FB260")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7B8C", Offset = "0x9B7B8C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x15FDC5C", Offset = "0x15FDC5C", VA = "0x15FDC5C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x15FE240", Offset = "0x15FE240", VA = "0x15FE240")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x15FE248", Offset = "0x15FE248", VA = "0x15FE248")]
		private void Start()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x15FE2FC", Offset = "0x15FE2FC", VA = "0x15FE2FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x15FE778", Offset = "0x15FE778", VA = "0x15FE778")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x15FE824", Offset = "0x15FE824", VA = "0x15FE824")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class Limb
		{
			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x15FE9F8", Offset = "0x15FE9F8", VA = "0x15FE9F8")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x15FEB2C", Offset = "0x15FEB2C", VA = "0x15FEB2C")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x15FE8AC", Offset = "0x15FE8AC", VA = "0x15FE8AC")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x15FEA7C", Offset = "0x15FEA7C", VA = "0x15FEA7C")]
		private void Start()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x15FEB18", Offset = "0x15FEB18", VA = "0x15FEB18")]
		private void Update()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x15FEB1C", Offset = "0x15FEB1C", VA = "0x15FEB1C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x15FEB3C", Offset = "0x15FEB3C", VA = "0x15FEB3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x15FEBA8", Offset = "0x15FEBA8", VA = "0x15FEBA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x15FEC8C", Offset = "0x15FEC8C", VA = "0x15FEC8C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7BA4", Offset = "0x9B7BA4")]
		public Transform target;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7BDC", Offset = "0x9B7BDC")]
		public Transform pin;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7C14", Offset = "0x9B7C14")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7C4C", Offset = "0x9B7C4C")]
		public AimIK aim;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7C84", Offset = "0x9B7C84")]
		public float weight;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7CBC", Offset = "0x9B7CBC")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7CF4", Offset = "0x9B7CF4")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x15FEC94", Offset = "0x15FEC94", VA = "0x15FEC94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x15FECF4", Offset = "0x15FECF4", VA = "0x15FECF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x15FEE90", Offset = "0x15FEE90", VA = "0x15FEE90")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x15FEE98", Offset = "0x15FEE98", VA = "0x15FEE98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x15FEF68", Offset = "0x15FEF68", VA = "0x15FEF68")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x15FEFF8", Offset = "0x15FEFF8", VA = "0x15FEFF8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x15FF50C", Offset = "0x15FF50C", VA = "0x15FF50C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x15FF628", Offset = "0x15FF628", VA = "0x15FF628")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7D2C", Offset = "0x9B7D2C")]
		public float aimWeight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7D44", Offset = "0x9B7D44")]
		public float sightWeight;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7D5C", Offset = "0x9B7D5C")]
		public float maxAngle;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7D78", Offset = "0x9B7D78")]
		public float cameraRecoilWeight;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x15FF9BC", Offset = "0x15FF9BC", VA = "0x15FF9BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x15FFB6C", Offset = "0x15FFB6C", VA = "0x15FFB6C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x15FFB78", Offset = "0x15FFB78", VA = "0x15FFB78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x15FFEB8", Offset = "0x15FFEB8", VA = "0x15FFEB8")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1600230", Offset = "0x1600230", VA = "0x1600230")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x15FFC3C", Offset = "0x15FFC3C", VA = "0x15FFC3C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1600C50", Offset = "0x1600C50", VA = "0x1600C50")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7D90", Offset = "0x9B7D90")]
		public float walkSpeed;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1600C70", Offset = "0x1600C70", VA = "0x1600C70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1600CF4", Offset = "0x1600CF4", VA = "0x1600CF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1600E18", Offset = "0x1600E18", VA = "0x1600E18")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1600EC8", Offset = "0x1600EC8", VA = "0x1600EC8")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x160125C", Offset = "0x160125C", VA = "0x160125C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1601428", Offset = "0x1601428", VA = "0x1601428")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x16015EC", Offset = "0x16015EC", VA = "0x16015EC")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x160199C", Offset = "0x160199C", VA = "0x160199C")]
		private void Start()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1601B48", Offset = "0x1601B48", VA = "0x1601B48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1601F04", Offset = "0x1601F04", VA = "0x1601F04")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1601F14", Offset = "0x1601F14", VA = "0x1601F14")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1602048", Offset = "0x1602048", VA = "0x1602048")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1602198", Offset = "0x1602198", VA = "0x1602198")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x16021A0", Offset = "0x16021A0", VA = "0x16021A0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1602870", Offset = "0x1602870", VA = "0x1602870")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7DA8", Offset = "0x9B7DA8")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7DE0", Offset = "0x9B7DE0")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1602878", Offset = "0x1602878", VA = "0x1602878")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x16028D8", Offset = "0x16028D8", VA = "0x16028D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1602BE4", Offset = "0x1602BE4", VA = "0x1602BE4")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Partner
		{
			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000C9")]
			private Transform neck
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x16034E8", Offset = "0x16034E8", VA = "0x16034E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1602C20", Offset = "0x1602C20", VA = "0x1602C20")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1602CA0", Offset = "0x1602CA0", VA = "0x1602CA0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x160330C", Offset = "0x160330C", VA = "0x160330C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1603540", Offset = "0x1603540", VA = "0x1603540")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1602BEC", Offset = "0x1602BEC", VA = "0x1602BEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1602C40", Offset = "0x1602C40", VA = "0x1602C40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x16032FC", Offset = "0x16032FC", VA = "0x16032FC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public enum Mode
		{
			[Token(Token = "0x40007E2")]
			Position,
			[Token(Token = "0x40007E3")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		public class Absorber
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBB8C", Offset = "0x9BBB8C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBBC4", Offset = "0x9BBBC4")]
			public float weight;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1247928", Offset = "0x1247928", VA = "0x1247928")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1247B1C", Offset = "0x1247B1C", VA = "0x1247B1C")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1247B58", Offset = "0x1247B58", VA = "0x1247B58")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1247D08", Offset = "0x1247D08", VA = "0x1247D08")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1247F50", Offset = "0x1247F50", VA = "0x1247F50")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7E18", Offset = "0x9B7E18")]
		public Mode mode;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7E50", Offset = "0x9B7E50")]
		public Absorber[] absorbers;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7E88", Offset = "0x9B7E88")]
		public AnimationCurve falloff;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7EC0", Offset = "0x9B7EC0")]
		public float falloffSpeed;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x12477B4", Offset = "0x12477B4", VA = "0x12477B4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x124789C", Offset = "0x124789C", VA = "0x124789C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1247A10", Offset = "0x1247A10", VA = "0x1247A10", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1247C80", Offset = "0x1247C80", VA = "0x1247C80")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1247E18", Offset = "0x1247E18", VA = "0x1247E18", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1247F40", Offset = "0x1247F40", VA = "0x1247F40")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1247FD0", Offset = "0x1247FD0", VA = "0x1247FD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1248050", Offset = "0x1248050", VA = "0x1248050")]
		private void Update()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1248104", Offset = "0x1248104", VA = "0x1248104")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1248264", Offset = "0x1248264", VA = "0x1248264")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class EffectorLink
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1249004", Offset = "0x1249004", VA = "0x1249004")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1248CD0", Offset = "0x1248CD0", VA = "0x1248CD0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1248DD0", Offset = "0x1248DD0", VA = "0x1248DD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1248FFC", Offset = "0x1248FFC", VA = "0x1248FFC")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7EF8", Offset = "0x9B7EF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7EF8", Offset = "0x9B7EF8")]
		public float weight;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7F4C", Offset = "0x9B7F4C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7F84", Offset = "0x9B7F84")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7FD0", Offset = "0x9B7FD0")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1249014", Offset = "0x1249014", VA = "0x1249014")]
		private void Start()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1249364", Offset = "0x1249364", VA = "0x1249364")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1249AB4", Offset = "0x1249AB4", VA = "0x1249AB4")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700006F")]
		private bool holding
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x124A024", Offset = "0x124A024", VA = "0x124A024")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private bool holdingLeft
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x124A114", Offset = "0x124A114", VA = "0x124A114")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		private bool holdingRight
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x124A05C", Offset = "0x124A05C", VA = "0x124A05C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1249B38", Offset = "0x1249B38", VA = "0x1249B38")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000588")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x124A1CC", Offset = "0x124A1CC", VA = "0x124A1CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x124A364", Offset = "0x124A364", VA = "0x124A364")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x124A4E0", Offset = "0x124A4E0", VA = "0x124A4E0")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x124A5C0", Offset = "0x124A5C0", VA = "0x124A5C0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x124A6F8", Offset = "0x124A6F8", VA = "0x124A6F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x124A914", Offset = "0x124A914", VA = "0x124A914")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x124AAF8", Offset = "0x124AAF8", VA = "0x124AAF8")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x124AB0C", Offset = "0x124AB0C", VA = "0x124AB0C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x124AD00", Offset = "0x124AD00", VA = "0x124AD00")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x124AD14", Offset = "0x124AD14", VA = "0x124AD14", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x124AEC0", Offset = "0x124AEC0", VA = "0x124AEC0")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x124B660", Offset = "0x124B660", VA = "0x124B660")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x124B738", Offset = "0x124B738", VA = "0x124B738")]
		private void Update()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x124B8E0", Offset = "0x124B8E0", VA = "0x124B8E0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x124B8E8", Offset = "0x124B8E8", VA = "0x124B8E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x124B948", Offset = "0x124B948", VA = "0x124B948")]
		private void Update()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x124B9A4", Offset = "0x124B9A4", VA = "0x124B9A4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x124BA7C", Offset = "0x124BA7C", VA = "0x124BA7C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3B2C", Offset = "0x9B3B2C")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CB")]
				[Address(RVA = "0x124BE28", Offset = "0x124BE28", VA = "0x124BE28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x124BE90", Offset = "0x124BE90", VA = "0x124BE90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x124BC2C", Offset = "0x124BC2C", VA = "0x124BC2C")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x124BC68", Offset = "0x124BC68", VA = "0x124BC68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x124BC6C", Offset = "0x124BC6C", VA = "0x124BC6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x124BE30", Offset = "0x124BE30", VA = "0x124BE30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x124BA8C", Offset = "0x124BA8C", VA = "0x124BA8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x124BB58", Offset = "0x124BB58", VA = "0x124BB58")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x124BBA0", Offset = "0x124BBA0", VA = "0x124BBA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BDFF0", Offset = "0x9BDFF0")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x124BC58", Offset = "0x124BC58", VA = "0x124BC58")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3B3C", Offset = "0x9B3B3C")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0x124D668", Offset = "0x124D668", VA = "0x124D668", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x124D6D0", Offset = "0x124D6D0", VA = "0x124D6D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x124D4F8", Offset = "0x124D4F8", VA = "0x124D4F8")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x124D52C", Offset = "0x124D52C", VA = "0x124D52C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x124D530", Offset = "0x124D530", VA = "0x124D530", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x124D670", Offset = "0x124D670", VA = "0x124D670", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x124D3C0", Offset = "0x124D3C0", VA = "0x124D3C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x124D47C", Offset = "0x124D47C", VA = "0x124D47C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BE054", Offset = "0x9BE054")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x124D524", Offset = "0x124D524", VA = "0x124D524")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public class EffectorLink
		{
			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x124DC78", Offset = "0x124DC78", VA = "0x124DC78")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x124E988", Offset = "0x124E988", VA = "0x124E988")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x124DFF4", Offset = "0x124DFF4", VA = "0x124DFF4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x124EA74", Offset = "0x124EA74", VA = "0x124EA74")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x124EC10", Offset = "0x124EC10", VA = "0x124EC10")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x124ECAC", Offset = "0x124ECAC", VA = "0x124ECAC")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x124ED44", Offset = "0x124ED44", VA = "0x124ED44")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x124E7D4", Offset = "0x124E7D4", VA = "0x124E7D4")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x124EDDC", Offset = "0x124EDDC", VA = "0x124EDDC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x124DC00", Offset = "0x124DC00", VA = "0x124DC00")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x124DF88", Offset = "0x124DF88", VA = "0x124DF88")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x124E70C", Offset = "0x124E70C", VA = "0x124E70C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x124E980", Offset = "0x124E980", VA = "0x124E980")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B801C", Offset = "0x9B801C")]
		public Transform to;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8054", Offset = "0x9B8054")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8054", Offset = "0x9B8054")]
		public float transferMotion;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x124EE18", Offset = "0x124EE18", VA = "0x124EE18")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x124EE54", Offset = "0x124EE54", VA = "0x124EE54")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x124EFAC", Offset = "0x124EFAC", VA = "0x124EFAC")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B80A8", Offset = "0x9B80A8")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x124F180", Offset = "0x124F180", VA = "0x124F180")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x124F360", Offset = "0x124F360", VA = "0x124F360")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x124F5FC", Offset = "0x124F5FC", VA = "0x124F5FC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x124F6C8", Offset = "0x124F6C8", VA = "0x124F6C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x124F7E4", Offset = "0x124F7E4", VA = "0x124F7E4")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x124FB50", Offset = "0x124FB50", VA = "0x124FB50", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x124FFC8", Offset = "0x124FFC8", VA = "0x124FFC8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1250220", Offset = "0x1250220", VA = "0x1250220")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1600ED8", Offset = "0x1600ED8", VA = "0x1600ED8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x16011D4", Offset = "0x16011D4", VA = "0x16011D4")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1601254", Offset = "0x1601254", VA = "0x1601254")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3B4C", Offset = "0x9B3B4C")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E0")]
				[Address(RVA = "0x124B5F0", Offset = "0x124B5F0", VA = "0x124B5F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x124B658", Offset = "0x124B658", VA = "0x124B658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x124B2A0", Offset = "0x124B2A0", VA = "0x124B2A0")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x124B4AC", Offset = "0x124B4AC", VA = "0x124B4AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x124B4B0", Offset = "0x124B4B0", VA = "0x124B4B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x124B5F8", Offset = "0x124B5F8", VA = "0x124B5F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x124AED4", Offset = "0x124AED4", VA = "0x124AED4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x124B078", Offset = "0x124B078", VA = "0x124B078")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x124AFFC", Offset = "0x124AFFC", VA = "0x124AFFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BE0B8", Offset = "0x9BE0B8")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x124B2CC", Offset = "0x124B2CC", VA = "0x124B2CC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x124B3B0", Offset = "0x124B3B0", VA = "0x124B3B0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x124B490", Offset = "0x124B490", VA = "0x124B490")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B80E0", Offset = "0x9B80E0")]
		public float weight;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x15F881C", Offset = "0x15F881C", VA = "0x15F881C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x15F8888", Offset = "0x15F8888", VA = "0x15F8888")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x15F8944", Offset = "0x15F8944", VA = "0x15F8944")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public class Part
		{
			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x124F038", Offset = "0x124F038", VA = "0x124F038")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x124F178", Offset = "0x124F178", VA = "0x124F178")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x124EFC0", Offset = "0x124EFC0", VA = "0x124EFC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x124F170", Offset = "0x124F170", VA = "0x124F170")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x16015FC", Offset = "0x16015FC", VA = "0x16015FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x16017C8", Offset = "0x16017C8", VA = "0x16017C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x160198C", Offset = "0x160198C", VA = "0x160198C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B80F8", Offset = "0x9B80F8")]
		public VRIK ik;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8130", Offset = "0x9B8130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8130", Offset = "0x9B8130")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8190", Offset = "0x9B8190")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B81C8", Offset = "0x9B81C8")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8200", Offset = "0x9B8200")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8200", Offset = "0x9B8200")]
		public Transform leftHandAnchor;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8260", Offset = "0x9B8260")]
		public Transform rightHandAnchor;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8298", Offset = "0x9B8298")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B82D0", Offset = "0x9B82D0")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8308", Offset = "0x9B8308")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8308", Offset = "0x9B8308")]
		public float scaleMlp;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8368", Offset = "0x9B8368")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1250244", Offset = "0x1250244", VA = "0x1250244")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x12503E0", Offset = "0x12503E0", VA = "0x12503E0")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B83A0", Offset = "0x9B83A0")]
		public VRIK ik;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B83D8", Offset = "0x9B83D8")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8410", Offset = "0x9B8410")]
		public Transform headTracker;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8448", Offset = "0x9B8448")]
		public Transform bodyTracker;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8480", Offset = "0x9B8480")]
		public Transform leftHandTracker;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B84B8", Offset = "0x9B84B8")]
		public Transform rightHandTracker;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B84F0", Offset = "0x9B84F0")]
		public Transform leftFootTracker;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8528", Offset = "0x9B8528")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8560", Offset = "0x9B8560")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x125045C", Offset = "0x125045C", VA = "0x125045C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x12505C8", Offset = "0x12505C8", VA = "0x12505C8")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x125063C", Offset = "0x125063C", VA = "0x125063C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1250698", Offset = "0x1250698", VA = "0x1250698")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x12508AC", Offset = "0x12508AC", VA = "0x12508AC")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1250924", Offset = "0x1250924", VA = "0x1250924")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1250E8C", Offset = "0x1250E8C", VA = "0x1250E8C")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000072")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x15F8E44", Offset = "0x15F8E44", VA = "0x15F8E44", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x15F8E20", Offset = "0x15F8E20", VA = "0x15F8E20", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x15F8E4C", Offset = "0x15F8E4C", VA = "0x15F8E4C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x15F8F10", Offset = "0x15F8F10", VA = "0x15F8F10", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x15F9088", Offset = "0x15F9088", VA = "0x15F9088", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x15F933C", Offset = "0x15F933C", VA = "0x15F933C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x15F9098", Offset = "0x15F9098", VA = "0x15F9098")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x15F934C", Offset = "0x15F934C", VA = "0x15F934C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x15F9364", Offset = "0x15F9364", VA = "0x15F9364", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x15F93CC", Offset = "0x15F93CC", VA = "0x15F93CC", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x15F94F8", Offset = "0x15F94F8", VA = "0x15F94F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x15F9674", Offset = "0x15F9674", VA = "0x15F9674")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B85C8", Offset = "0x9B85C8")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x400052D")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x400052E")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x17000073")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x15F9738", Offset = "0x15F9738", VA = "0x15F9738", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x15F968C", Offset = "0x15F968C", VA = "0x15F968C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x15F971C", Offset = "0x15F971C", VA = "0x15F971C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x15F9828", Offset = "0x15F9828", VA = "0x15F9828", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x15F9BF8", Offset = "0x15F9BF8", VA = "0x15F9BF8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x15F9DAC", Offset = "0x15F9DAC", VA = "0x15F9DAC")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B860C", Offset = "0x9B860C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B860C", Offset = "0x9B860C")]
		public Transform gravityTarget;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B866C", Offset = "0x9B866C")]
		public float gravityMultiplier;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400053C")]
		protected const float half = 0.5f;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60005E0")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x15FA2D8", Offset = "0x15FA2D8", VA = "0x15FA2D8")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x15FA45C", Offset = "0x15FA45C", VA = "0x15FA45C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x15FA624", Offset = "0x15FA624", VA = "0x15FA624", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x15FA89C", Offset = "0x15FA89C", VA = "0x15FA89C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x15FA960", Offset = "0x15FA960", VA = "0x15FA960")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x15FAB48", Offset = "0x15FAB48", VA = "0x15FAB48")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x15FACF8", Offset = "0x15FACF8", VA = "0x15FACF8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x15FAD1C", Offset = "0x15FAD1C", VA = "0x15FAD1C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x15FAD40", Offset = "0x15FAD40", VA = "0x15FAD40")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x15FAE44", Offset = "0x15FAE44", VA = "0x15FAE44")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public enum MoveMode
		{
			[Token(Token = "0x400080E")]
			Directional,
			[Token(Token = "0x400080F")]
			Strafe
		}

		[Token(Token = "0x200011A")]
		public struct AnimState
		{
			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3B5C", Offset = "0x9B3B5C")]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E8")]
				[Address(RVA = "0x15FDBEC", Offset = "0x15FDBEC", VA = "0x15FDBEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x15FDC54", Offset = "0x15FDC54", VA = "0x15FDC54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x15FD940", Offset = "0x15FD940", VA = "0x15FD940")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x15FDAA0", Offset = "0x15FDAA0", VA = "0x15FDAA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x15FDAA4", Offset = "0x15FDAA4", VA = "0x15FDAA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x15FDBF4", Offset = "0x15FDBF4", VA = "0x15FDBF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B86A4", Offset = "0x9B86A4")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B86DC", Offset = "0x9B86DC")]
		public MoveMode moveMode;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8714", Offset = "0x9B8714")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B874C", Offset = "0x9B874C")]
		public bool smoothJump;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8784", Offset = "0x9B8784")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B87BC", Offset = "0x9B87BC")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B87F4", Offset = "0x9B87F4")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x17000074")]
		public bool onGround
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x15FB268", Offset = "0x15FB268", VA = "0x15FB268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE11C", Offset = "0x9BE11C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x15FB270", Offset = "0x15FB270", VA = "0x15FB270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE12C", Offset = "0x9BE12C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x15FB27C", Offset = "0x15FB27C", VA = "0x15FB27C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x15FB428", Offset = "0x15FB428", VA = "0x15FB428")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x15FB4B8", Offset = "0x15FB4B8", VA = "0x15FB4B8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x15FB608", Offset = "0x15FB608", VA = "0x15FB608")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x15FC584", Offset = "0x15FC584", VA = "0x15FC584", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x15FC91C", Offset = "0x15FC91C", VA = "0x15FC91C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x15FBC18", Offset = "0x15FBC18", VA = "0x15FBC18")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x15FC9FC", Offset = "0x15FC9FC", VA = "0x15FC9FC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x15FCFEC", Offset = "0x15FCFEC", VA = "0x15FCFEC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x15FC660", Offset = "0x15FC660", VA = "0x15FC660")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x15FD08C", Offset = "0x15FD08C", VA = "0x15FD08C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x15FD4FC", Offset = "0x15FD4FC", VA = "0x15FD4FC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x15FD688", Offset = "0x15FD688", VA = "0x15FD688", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x15FD8A0", Offset = "0x15FD8A0", VA = "0x15FD8A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BE13C", Offset = "0x9BE13C")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x15FC164", Offset = "0x15FC164", VA = "0x15FC164")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x15FD96C", Offset = "0x15FD96C", VA = "0x15FD96C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public enum RotationMode
		{
			[Token(Token = "0x400081E")]
			Smooth,
			[Token(Token = "0x400081F")]
			Linear
		}

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8804", Offset = "0x9B8804")]
		public CameraController cameraController;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B883C", Offset = "0x9B883C")]
		public float accelerationTime;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8874", Offset = "0x9B8874")]
		public float turnTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B88AC", Offset = "0x9B88AC")]
		public bool walkByDefault;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B88E4", Offset = "0x9B88E4")]
		public RotationMode rotationMode;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B891C", Offset = "0x9B891C")]
		public float moveSpeed;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8954", Offset = "0x9B8954")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000075")]
		public bool isGrounded
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x124C920", Offset = "0x124C920", VA = "0x124C920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE1A0", Offset = "0x9BE1A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x124C928", Offset = "0x124C928", VA = "0x124C928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE1B0", Offset = "0x9BE1B0")]
			private set
			{
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x124C934", Offset = "0x124C934", VA = "0x124C934")]
		private void Start()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x124C9D0", Offset = "0x124C9D0", VA = "0x124C9D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x124D0CC", Offset = "0x124D0CC", VA = "0x124D0CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x124CA24", Offset = "0x124CA24", VA = "0x124CA24")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x124CE24", Offset = "0x124CE24", VA = "0x124CE24")]
		private void Move()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x124D108", Offset = "0x124D108", VA = "0x124D108")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x124D200", Offset = "0x124D200", VA = "0x124D200")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x124D2A0", Offset = "0x124D2A0", VA = "0x124D2A0")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x124F7EC", Offset = "0x124F7EC", VA = "0x124F7EC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x124F86C", Offset = "0x124F86C", VA = "0x124F86C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x124FB00", Offset = "0x124FB00", VA = "0x124FB00")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x124FB24", Offset = "0x124FB24", VA = "0x124FB24")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200011D")]
		public struct State
		{
			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x124F82C", Offset = "0x124F82C", VA = "0x124F82C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x124FC64", Offset = "0x124FC64", VA = "0x124FC64", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x124FB40", Offset = "0x124FB40", VA = "0x124FB40")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x15F87D8", Offset = "0x15F87D8", VA = "0x15F87D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x15F8814", Offset = "0x15F8814", VA = "0x15F8814")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x124D2C8", Offset = "0x124D2C8", VA = "0x124D2C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x124D2FC", Offset = "0x124D2FC", VA = "0x124D2FC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x124D3AC", Offset = "0x124D3AC", VA = "0x124D3AC")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class Navigator
	{
		[Token(Token = "0x200011E")]
		public enum State
		{
			[Token(Token = "0x4000826")]
			Idle,
			[Token(Token = "0x4000827")]
			Seeking,
			[Token(Token = "0x4000828")]
			OnPath
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8964", Offset = "0x9B8964")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B899C", Offset = "0x9B899C")]
		public float cornerRadius;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B89D4", Offset = "0x9B89D4")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8A0C", Offset = "0x9B8A0C")]
		public float maxSampleDistance;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8A44", Offset = "0x9B8A44")]
		public float nextPathInterval;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8A7C", Offset = "0x9B8A7C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8A8C", Offset = "0x9B8A8C")]
		private State <state>k__BackingField;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000076")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1248278", Offset = "0x1248278", VA = "0x1248278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE1C0", Offset = "0x9BE1C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1248284", Offset = "0x1248284", VA = "0x1248284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE1D0", Offset = "0x9BE1D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public State state
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1248290", Offset = "0x1248290", VA = "0x1248290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE1E0", Offset = "0x9BE1E0")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1248298", Offset = "0x1248298", VA = "0x1248298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE1F0", Offset = "0x9BE1F0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x12482A0", Offset = "0x12482A0", VA = "0x12482A0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1248398", Offset = "0x1248398", VA = "0x1248398")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x12488F0", Offset = "0x12488F0", VA = "0x12488F0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1248960", Offset = "0x1248960", VA = "0x1248960")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x12487B8", Offset = "0x12487B8", VA = "0x12487B8")]
		private void Stop()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x124882C", Offset = "0x124882C", VA = "0x124882C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1248AA8", Offset = "0x1248AA8", VA = "0x1248AA8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1248C58", Offset = "0x1248C58", VA = "0x1248C58")]
		public Navigator()
		{
		}
	}
}
