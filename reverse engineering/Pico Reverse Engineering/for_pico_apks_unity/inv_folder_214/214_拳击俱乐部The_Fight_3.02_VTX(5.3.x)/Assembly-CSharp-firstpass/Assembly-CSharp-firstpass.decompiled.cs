using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x177187C", Offset = "0x177187C", VA = "0x177187C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x177198C", Offset = "0x177198C", VA = "0x177198C")]
	public void OnRebuild()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1771A20", Offset = "0x1771A20", VA = "0x1771A20")]
	private void OnMuscleDisconnected(Muscle m)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1771AE4", Offset = "0x1771AE4", VA = "0x1771AE4")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1771C68", Offset = "0x1771C68", VA = "0x1771C68")]
	public Skeleton()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A454", Offset = "0x84A454")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A454", Offset = "0x84A454")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000004")]
		public enum Mode
		{
			[Token(Token = "0x4000016")]
			AnimationClips,
			[Token(Token = "0x4000017")]
			AnimationStates,
			[Token(Token = "0x4000018")]
			PlayableDirector,
			[Token(Token = "0x4000019")]
			Realtime
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BA24", Offset = "0x84BA24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84BA24", Offset = "0x84BA24")]
		public int frameRate;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BA7C", Offset = "0x84BA7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84BA7C", Offset = "0x84BA7C")]
		public float keyReductionError;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BAD4", Offset = "0x84BAD4")]
		public Mode mode;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BB0C", Offset = "0x84BB0C")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BB44", Offset = "0x84BB44")]
		public string[] animationStates;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BB7C", Offset = "0x84BB7C")]
		public bool loop;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BBB4", Offset = "0x84BBB4")]
		public string saveToFolder;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BBEC", Offset = "0x84BBEC")]
		public string appendName;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BC24", Offset = "0x84BC24")]
		public string saveName;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC5C", Offset = "0x84BC5C")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC6C", Offset = "0x84BC6C")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		public PlayableDirector director;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BCEC", Offset = "0x84BCEC")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x195203C", Offset = "0x195203C", VA = "0x195203C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8576F4", Offset = "0x8576F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1952044", Offset = "0x1952044", VA = "0x1952044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857704", Offset = "0x857704")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1952050", Offset = "0x1952050", VA = "0x1952050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857714", Offset = "0x857714")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1952058", Offset = "0x1952058", VA = "0x1952058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857724", Offset = "0x857724")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1952060", Offset = "0x1952060", VA = "0x1952060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857734", Offset = "0x857734")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x1952068", Offset = "0x1952068", VA = "0x1952068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857744", Offset = "0x857744")]
			private set
			{
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1951F1C", Offset = "0x1951F1C", VA = "0x1951F1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857614", Offset = "0x857614")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1951F64", Offset = "0x1951F64", VA = "0x1951F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85764C", Offset = "0x85764C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1951FAC", Offset = "0x1951FAC", VA = "0x1951FAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857684", Offset = "0x857684")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1951FF4", Offset = "0x1951FF4", VA = "0x1951FF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8576BC", Offset = "0x8576BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600000E")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x600000F")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000010")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000011")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000012")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1952070", Offset = "0x1952070", VA = "0x1952070")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1952074", Offset = "0x1952074", VA = "0x1952074")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1952078", Offset = "0x1952078", VA = "0x1952078")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x195207C", Offset = "0x195207C", VA = "0x195207C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BCFC", Offset = "0x84BCFC")]
		public bool markAsLegacy;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BD34", Offset = "0x84BD34")]
		public Transform root;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BD6C", Offset = "0x84BD6C")]
		public Transform rootNode;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BDA4", Offset = "0x84BDA4")]
		public Transform[] ignoreList;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BDDC", Offset = "0x84BDDC")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1AEE588", Offset = "0x1AEE588", VA = "0x1AEE588")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1AEE978", Offset = "0x1AEE978", VA = "0x1AEE978", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1AEE980", Offset = "0x1AEE980", VA = "0x1AEE980", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1AEEA90", Offset = "0x1AEEA90", VA = "0x1AEEA90", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1AEEB0C", Offset = "0x1AEEB0C", VA = "0x1AEEB0C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1AEEB88", Offset = "0x1AEEB88", VA = "0x1AEEB88", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1AEE7D0", Offset = "0x1AEE7D0", VA = "0x1AEE7D0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1AEE8A4", Offset = "0x1AEE8A4", VA = "0x1AEE8A4")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1AEEC04", Offset = "0x1AEEC04", VA = "0x1AEEC04")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class TQ
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1774298", Offset = "0x1774298", VA = "0x1774298")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1951314", Offset = "0x1951314", VA = "0x1951314")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1951570", Offset = "0x1951570", VA = "0x1951570")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1951550", Offset = "0x1951550", VA = "0x1951550")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1951B1C", Offset = "0x1951B1C", VA = "0x1951B1C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1953214", Offset = "0x1953214", VA = "0x1953214")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1954ACC", Offset = "0x1954ACC", VA = "0x1954ACC")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1952C68", Offset = "0x1952C68", VA = "0x1952C68")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x195325C", Offset = "0x195325C", VA = "0x195325C")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1952798", Offset = "0x1952798", VA = "0x1952798")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1952168", Offset = "0x1952168", VA = "0x1952168")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x19523D4", Offset = "0x19523D4", VA = "0x19523D4")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x19522CC", Offset = "0x19522CC", VA = "0x19522CC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1952550", Offset = "0x1952550", VA = "0x1952550")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x19529FC", Offset = "0x19529FC", VA = "0x19529FC")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1952AF8", Offset = "0x1952AF8", VA = "0x1952AF8")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1952BF4", Offset = "0x1952BF4", VA = "0x1952BF4")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1952B6C", Offset = "0x1952B6C", VA = "0x1952B6C")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1952E60", Offset = "0x1952E60", VA = "0x1952E60")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1952F14", Offset = "0x1952F14", VA = "0x1952F14")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1953260", Offset = "0x1953260", VA = "0x1953260")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x19532D0", Offset = "0x19532D0", VA = "0x19532D0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1953D64", Offset = "0x1953D64", VA = "0x1953D64")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1953E18", Offset = "0x1953E18", VA = "0x1953E18")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1953D08", Offset = "0x1953D08", VA = "0x1953D08")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1953F10", Offset = "0x1953F10", VA = "0x1953F10")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1953F58", Offset = "0x1953F58", VA = "0x1953F58")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BakerTransform
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1953F60", Offset = "0x1953F60", VA = "0x1953F60")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x19540EC", Offset = "0x19540EC", VA = "0x19540EC")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1954100", Offset = "0x1954100", VA = "0x1954100")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x19543EC", Offset = "0x19543EC", VA = "0x19543EC")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1953FF8", Offset = "0x1953FF8", VA = "0x1953FF8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x19546A0", Offset = "0x19546A0", VA = "0x19546A0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1954714", Offset = "0x1954714", VA = "0x1954714")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x19548C8", Offset = "0x19548C8", VA = "0x19548C8")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BE14", Offset = "0x84BE14")]
		public bool bakeHandIK;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84BE4C", Offset = "0x84BE4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BE4C", Offset = "0x84BE4C")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84BEA4", Offset = "0x84BEA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BEA4", Offset = "0x84BEA4")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1AF8AAC", Offset = "0x1AF8AAC", VA = "0x1AF8AAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1AF8F88", Offset = "0x1AF8F88", VA = "0x1AF8F88", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1AF8FA4", Offset = "0x1AF8FA4", VA = "0x1AF8FA4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1AF9080", Offset = "0x1AF9080", VA = "0x1AF9080", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1AF915C", Offset = "0x1AF915C", VA = "0x1AF915C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1AF932C", Offset = "0x1AF932C", VA = "0x1AF932C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1AF95F4", Offset = "0x1AF95F4", VA = "0x1AF95F4")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1AF96D0", Offset = "0x1AF96D0", VA = "0x1AF96D0")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000E")]
		public enum UpdateMode
		{
			[Token(Token = "0x400007C")]
			Update,
			[Token(Token = "0x400007D")]
			FixedUpdate,
			[Token(Token = "0x400007E")]
			LateUpdate,
			[Token(Token = "0x400007F")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84BEF8", Offset = "0x84BEF8")]
		public bool smoothFollow;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84BF30", Offset = "0x84BF30")]
		public float rotationSensitivity;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84BF68", Offset = "0x84BF68")]
		public float distance;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84BFA0", Offset = "0x84BFA0")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84BFD8", Offset = "0x84BFD8")]
		public float blockedOffset;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BFF0", Offset = "0x84BFF0")]
		private float <x>k__BackingField;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C000", Offset = "0x84C000")]
		private float <y>k__BackingField;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C010", Offset = "0x84C010")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1916B94", Offset = "0x1916B94", VA = "0x1916B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857754", Offset = "0x857754")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1916B9C", Offset = "0x1916B9C", VA = "0x1916B9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857764", Offset = "0x857764")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1916BA4", Offset = "0x1916BA4", VA = "0x1916BA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857774", Offset = "0x857774")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1916BAC", Offset = "0x1916BAC", VA = "0x1916BAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857784", Offset = "0x857784")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1916BB4", Offset = "0x1916BB4", VA = "0x1916BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857794", Offset = "0x857794")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1916BBC", Offset = "0x1916BBC", VA = "0x1916BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8577A4", Offset = "0x8577A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1917444", Offset = "0x1917444", VA = "0x1917444")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1916BC4", Offset = "0x1916BC4", VA = "0x1916BC4")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1916C00", Offset = "0x1916C00", VA = "0x1916C00")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1916C08", Offset = "0x1916C08", VA = "0x1916C08", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1916D0C", Offset = "0x1916D0C", VA = "0x1916D0C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1916D68", Offset = "0x1916D68", VA = "0x1916D68", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1916DD0", Offset = "0x1916DD0", VA = "0x1916DD0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1916E34", Offset = "0x1916E34", VA = "0x1916E34")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1916D40", Offset = "0x1916D40", VA = "0x1916D40")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1916FB4", Offset = "0x1916FB4", VA = "0x1916FB4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1917414", Offset = "0x1917414", VA = "0x1917414")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x19174B4", Offset = "0x19174B4", VA = "0x19174B4")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1917558", Offset = "0x1917558", VA = "0x1917558")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1917590", Offset = "0x1917590", VA = "0x1917590")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1917738", Offset = "0x1917738", VA = "0x1917738")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1917768", Offset = "0x1917768", VA = "0x1917768")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public enum Axis
	{
		[Token(Token = "0x4000086")]
		X,
		[Token(Token = "0x4000087")]
		Y,
		[Token(Token = "0x4000088")]
		Z
	}
	[Token(Token = "0x2000011")]
	public class AxisTools
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1951B24", Offset = "0x1951B24", VA = "0x1951B24")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1951B48", Offset = "0x1951B48", VA = "0x1951B48")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1951B80", Offset = "0x1951B80", VA = "0x1951B80")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1951C70", Offset = "0x1951C70", VA = "0x1951C70")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1951C18", Offset = "0x1951C18", VA = "0x1951C18")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1951D08", Offset = "0x1951D08", VA = "0x1951D08")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1951D50", Offset = "0x1951D50", VA = "0x1951D50")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1951F14", Offset = "0x1951F14", VA = "0x1951F14")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000013")]
		public class LimbOrientation
		{
			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x18616FC", Offset = "0x18616FC", VA = "0x18616FC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x195B4BC", Offset = "0x195B4BC", VA = "0x195B4BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x195B728", Offset = "0x195B728", VA = "0x195B728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x195B470", Offset = "0x195B470", VA = "0x195B470")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000015")]
		public enum BoneType
		{
			[Token(Token = "0x40000A3")]
			Unassigned,
			[Token(Token = "0x40000A4")]
			Spine,
			[Token(Token = "0x40000A5")]
			Head,
			[Token(Token = "0x40000A6")]
			Arm,
			[Token(Token = "0x40000A7")]
			Leg,
			[Token(Token = "0x40000A8")]
			Tail,
			[Token(Token = "0x40000A9")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000016")]
		public enum BoneSide
		{
			[Token(Token = "0x40000AB")]
			Center,
			[Token(Token = "0x40000AC")]
			Left,
			[Token(Token = "0x40000AD")]
			Right
		}

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x195B994", Offset = "0x195B994", VA = "0x195B994")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x195BCB0", Offset = "0x195BCB0", VA = "0x195BCB0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x195BF1C", Offset = "0x195BF1C", VA = "0x195BF1C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x195BF9C", Offset = "0x195BF9C", VA = "0x195BF9C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x195C044", Offset = "0x195C044", VA = "0x195C044")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x195BB64", Offset = "0x195BB64", VA = "0x195BB64")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x195BE80", Offset = "0x195BE80", VA = "0x195BE80")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x195C874", Offset = "0x195C874", VA = "0x195C874")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x195C67C", Offset = "0x195C67C", VA = "0x195C67C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x195C778", Offset = "0x195C778", VA = "0x195C778")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x195C25C", Offset = "0x195C25C", VA = "0x195C25C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x195C30C", Offset = "0x195C30C", VA = "0x195C30C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x195C3BC", Offset = "0x195C3BC", VA = "0x195C3BC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x195C46C", Offset = "0x195C46C", VA = "0x195C46C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x195C51C", Offset = "0x195C51C", VA = "0x195C51C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x195C5CC", Offset = "0x195C5CC", VA = "0x195C5CC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x195CA7C", Offset = "0x195CA7C", VA = "0x195CA7C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x195C174", Offset = "0x195C174", VA = "0x195C174")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x195C9EC", Offset = "0x195C9EC", VA = "0x195C9EC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x195CAE8", Offset = "0x195CAE8", VA = "0x195CAE8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x195CBBC", Offset = "0x195CBBC", VA = "0x195CBBC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x195C974", Offset = "0x195C974", VA = "0x195C974")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x195C900", Offset = "0x195C900", VA = "0x195C900")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class BipedReferences
	{
		[Token(Token = "0x2000018")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0x18617C0", Offset = "0x18617C0", VA = "0x18617C0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x18617AC", Offset = "0x18617AC", VA = "0x18617AC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x1912C70", Offset = "0x1912C70", VA = "0x1912C70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x1913058", Offset = "0x1913058", VA = "0x1913058")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1913068", Offset = "0x1913068", VA = "0x1913068", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1913490", Offset = "0x1913490", VA = "0x1913490", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x19138C4", Offset = "0x19138C4", VA = "0x19138C4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1913F1C", Offset = "0x1913F1C", VA = "0x1913F1C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1913B44", Offset = "0x1913B44", VA = "0x1913B44")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1914728", Offset = "0x1914728", VA = "0x1914728")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1914818", Offset = "0x1914818", VA = "0x1914818")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1914D7C", Offset = "0x1914D7C", VA = "0x1914D7C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1914B70", Offset = "0x1914B70", VA = "0x1914B70")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x19149EC", Offset = "0x19149EC", VA = "0x19149EC")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x19148B8", Offset = "0x19148B8", VA = "0x19148B8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1914C7C", Offset = "0x1914C7C", VA = "0x1914C7C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1914E74", Offset = "0x1914E74", VA = "0x1914E74")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1915998", Offset = "0x1915998", VA = "0x1915998")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1915420", Offset = "0x1915420", VA = "0x1915420")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1915C40", Offset = "0x1915C40", VA = "0x1915C40")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x191578C", Offset = "0x191578C", VA = "0x191578C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1915C48", Offset = "0x1915C48", VA = "0x1915C48")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1915C50", Offset = "0x1915C50", VA = "0x1915C50")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1915E18", Offset = "0x1915E18", VA = "0x1915E18")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1915FD4", Offset = "0x1915FD4", VA = "0x1915FD4")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1913AD8", Offset = "0x1913AD8", VA = "0x1913AD8")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x191B990", Offset = "0x191B990", VA = "0x191B990")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x191C9D0", Offset = "0x191C9D0", VA = "0x191C9D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x191CB18", Offset = "0x191CB18", VA = "0x191CB18")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class Hierarchy
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1AF6998", Offset = "0x1AF6998", VA = "0x1AF6998")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1AF6B84", Offset = "0x1AF6B84", VA = "0x1AF6B84")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1AF6A30", Offset = "0x1AF6A30", VA = "0x1AF6A30")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1AF6CA4", Offset = "0x1AF6CA4", VA = "0x1AF6CA4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1AF6DD0", Offset = "0x1AF6DD0", VA = "0x1AF6DD0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1AF701C", Offset = "0x1AF701C", VA = "0x1AF701C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1AF7124", Offset = "0x1AF7124", VA = "0x1AF7124")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1AF7298", Offset = "0x1AF7298", VA = "0x1AF7298")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1AF7674", Offset = "0x1AF7674", VA = "0x1AF7674")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1AF7438", Offset = "0x1AF7438", VA = "0x1AF7438")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1AF7828", Offset = "0x1AF7828", VA = "0x1AF7828")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1C0AFD4", Offset = "0x1C0AFD4", VA = "0x1C0AFD4")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1C0B040", Offset = "0x1C0B040", VA = "0x1C0B040")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C7")]
		None,
		[Token(Token = "0x40000C8")]
		InOutCubic,
		[Token(Token = "0x40000C9")]
		InOutQuintic,
		[Token(Token = "0x40000CA")]
		InOutSine,
		[Token(Token = "0x40000CB")]
		InQuintic,
		[Token(Token = "0x40000CC")]
		InQuartic,
		[Token(Token = "0x40000CD")]
		InCubic,
		[Token(Token = "0x40000CE")]
		InQuadratic,
		[Token(Token = "0x40000CF")]
		InElastic,
		[Token(Token = "0x40000D0")]
		InElasticSmall,
		[Token(Token = "0x40000D1")]
		InElasticBig,
		[Token(Token = "0x40000D2")]
		InSine,
		[Token(Token = "0x40000D3")]
		InBack,
		[Token(Token = "0x40000D4")]
		OutQuintic,
		[Token(Token = "0x40000D5")]
		OutQuartic,
		[Token(Token = "0x40000D6")]
		OutCubic,
		[Token(Token = "0x40000D7")]
		OutInCubic,
		[Token(Token = "0x40000D8")]
		OutInQuartic,
		[Token(Token = "0x40000D9")]
		OutElastic,
		[Token(Token = "0x40000DA")]
		OutElasticSmall,
		[Token(Token = "0x40000DB")]
		OutElasticBig,
		[Token(Token = "0x40000DC")]
		OutSine,
		[Token(Token = "0x40000DD")]
		OutBack,
		[Token(Token = "0x40000DE")]
		OutBackCubic,
		[Token(Token = "0x40000DF")]
		OutBackQuartic,
		[Token(Token = "0x40000E0")]
		BackInCubic,
		[Token(Token = "0x40000E1")]
		BackInQuartic
	}
	[Token(Token = "0x200001E")]
	public class Interp
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1C0E760", Offset = "0x1C0E760", VA = "0x1C0E760")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1C1410C", Offset = "0x1C1410C", VA = "0x1C1410C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1C14180", Offset = "0x1C14180", VA = "0x1C14180")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1C13B74", Offset = "0x1C13B74", VA = "0x1C13B74")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1C13B80", Offset = "0x1C13B80", VA = "0x1C13B80")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1C13BA4", Offset = "0x1C13BA4", VA = "0x1C13BA4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1C13BE0", Offset = "0x1C13BE0", VA = "0x1C13BE0")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1C13BF8", Offset = "0x1C13BF8", VA = "0x1C13BF8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1C13C0C", Offset = "0x1C13C0C", VA = "0x1C13C0C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1C13C20", Offset = "0x1C13C20", VA = "0x1C13C20")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1C13C30", Offset = "0x1C13C30", VA = "0x1C13C30")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1C13C78", Offset = "0x1C13C78", VA = "0x1C13C78")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1C13CB0", Offset = "0x1C13CB0", VA = "0x1C13CB0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1C13CD8", Offset = "0x1C13CD8", VA = "0x1C13CD8")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1C1420C", Offset = "0x1C1420C", VA = "0x1C1420C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1C13D0C", Offset = "0x1C13D0C", VA = "0x1C13D0C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1C13D34", Offset = "0x1C13D34", VA = "0x1C13D34")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1C13D64", Offset = "0x1C13D64", VA = "0x1C13D64")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1C13D98", Offset = "0x1C13D98", VA = "0x1C13D98")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1C13DDC", Offset = "0x1C13DDC", VA = "0x1C13DDC")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1C13E40", Offset = "0x1C13E40", VA = "0x1C13E40")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1C13EA4", Offset = "0x1C13EA4", VA = "0x1C13EA4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1C13EF8", Offset = "0x1C13EF8", VA = "0x1C13EF8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1C13F4C", Offset = "0x1C13F4C", VA = "0x1C13F4C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1C13F88", Offset = "0x1C13F88", VA = "0x1C13F88")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1C13FC0", Offset = "0x1C13FC0", VA = "0x1C13FC0")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1C14240", Offset = "0x1C14240", VA = "0x1C14240")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1C14008", Offset = "0x1C14008", VA = "0x1C14008")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1C1409C", Offset = "0x1C1409C", VA = "0x1C1409C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1C140CC", Offset = "0x1C140CC", VA = "0x1C140CC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1C142D4", Offset = "0x1C142D4", VA = "0x1C142D4")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1C15340", Offset = "0x1C15340", VA = "0x1C15340")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1C153AC", Offset = "0x1C153AC", VA = "0x1C153AC")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1C15418", Offset = "0x1C15418", VA = "0x1C15418")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1C15470", Offset = "0x1C15470", VA = "0x1C15470")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1C1553C", Offset = "0x1C1553C", VA = "0x1C1553C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1C15488", Offset = "0x1C15488", VA = "0x1C15488")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1C15554", Offset = "0x1C15554", VA = "0x1C15554")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1C155F8", Offset = "0x1C155F8", VA = "0x1C155F8")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1C15624", Offset = "0x1C15624", VA = "0x1C15624")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1C15674", Offset = "0x1C15674", VA = "0x1C15674")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1C156E0", Offset = "0x1C156E0", VA = "0x1C156E0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1C157F4", Offset = "0x1C157F4", VA = "0x1C157F4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1C158EC", Offset = "0x1C158EC", VA = "0x1C158EC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1C15948", Offset = "0x1C15948", VA = "0x1C15948")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000021")]
	public static class QuaTools
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1769400", Offset = "0x1769400", VA = "0x1769400")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1769450", Offset = "0x1769450", VA = "0x1769450")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x17694A0", Offset = "0x17694A0", VA = "0x17694A0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1769548", Offset = "0x1769548", VA = "0x1769548")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x17695F0", Offset = "0x17695F0", VA = "0x17695F0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x17696D0", Offset = "0x17696D0", VA = "0x17696D0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1769724", Offset = "0x1769724", VA = "0x1769724")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17697F8", Offset = "0x17697F8", VA = "0x17697F8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1769908", Offset = "0x1769908", VA = "0x1769908")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1769A98", Offset = "0x1769A98", VA = "0x1769A98")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1769B8C", Offset = "0x1769B8C", VA = "0x1769B8C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1769C98", Offset = "0x1769C98", VA = "0x1769C98")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1769D84", Offset = "0x1769D84", VA = "0x1769D84")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000022")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000EB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EC")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000ED")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C030", Offset = "0x84C030")]
		public bool fixTransforms;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x17726FC", Offset = "0x17726FC", VA = "0x17726FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1772A08", Offset = "0x1772A08", VA = "0x1772A08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x17725BC", Offset = "0x17725BC", VA = "0x17725BC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x177265C", Offset = "0x177265C", VA = "0x177265C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1772660", Offset = "0x1772660", VA = "0x1772660", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1772664", Offset = "0x1772664", VA = "0x1772664", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1772668", Offset = "0x1772668", VA = "0x1772668")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x17726F8", Offset = "0x17726F8", VA = "0x17726F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x17726A0", Offset = "0x17726A0", VA = "0x17726A0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17729BC", Offset = "0x17729BC", VA = "0x17729BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x17727E8", Offset = "0x17727E8", VA = "0x17727E8")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1772AC0", Offset = "0x1772AC0", VA = "0x1772AC0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1772B1C", Offset = "0x1772B1C", VA = "0x1772B1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1772B78", Offset = "0x1772B78", VA = "0x1772B78")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1772BC0", Offset = "0x1772BC0", VA = "0x1772BC0")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x17748FC", Offset = "0x17748FC", VA = "0x17748FC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x17749BC", Offset = "0x17749BC", VA = "0x17749BC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1774A7C", Offset = "0x1774A7C", VA = "0x1774A7C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1774B3C", Offset = "0x1774B3C", VA = "0x1774B3C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1776890", Offset = "0x1776890", VA = "0x1776890")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1776930", Offset = "0x1776930", VA = "0x1776930")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x177696C", Offset = "0x177696C", VA = "0x177696C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x17769B0", Offset = "0x17769B0", VA = "0x17769B0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1776A4C", Offset = "0x1776A4C", VA = "0x1776A4C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1776BA8", Offset = "0x1776BA8", VA = "0x1776BA8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1776D24", Offset = "0x1776D24", VA = "0x1776D24")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1776EA8", Offset = "0x1776EA8", VA = "0x1776EA8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1776F64", Offset = "0x1776F64", VA = "0x1776F64")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1777064", Offset = "0x1777064", VA = "0x1777064")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17770EC", Offset = "0x17770EC", VA = "0x17770EC")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000026")]
	public static class Warning
	{
		[Token(Token = "0x2000027")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x185F78C", Offset = "0x185F78C", VA = "0x185F78C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x185F824", Offset = "0x185F824", VA = "0x185F824")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000028")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x194FB84", Offset = "0x194FB84", VA = "0x194FB84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x194FBEC", Offset = "0x194FBEC", VA = "0x194FBEC")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x200002A")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x200002B")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x200002C")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x200002D")]
		public struct PuppetEvent
		{
			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C098", Offset = "0x84C098")]
			public string switchToBehaviour;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C0D0", Offset = "0x84C0D0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C108", Offset = "0x84C108")]
			public UnityEvent unityEvent;

			[Token(Token = "0x400010E")]
			private const string empty = "";

			[Token(Token = "0x17000011")]
			public bool switchBehaviour
			{
				[Token(Token = "0x600014F")]
				[Address(RVA = "0x1860D48", Offset = "0x1860D48", VA = "0x1860D48")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1860DD8", Offset = "0x1860DD8", VA = "0x1860DD8")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002E")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000113")]
			private const string empty = "";

			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1860038", Offset = "0x1860038", VA = "0x1860038")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1860108", Offset = "0x1860108", VA = "0x1860108")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1860208", Offset = "0x1860208", VA = "0x1860208")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x18602E4", Offset = "0x18602E4", VA = "0x18602E4")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C088", Offset = "0x84C088")]
		private bool <forceActive>k__BackingField;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x17000010")]
		public bool forceActive
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x195516C", Offset = "0x195516C", VA = "0x195516C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857824", Offset = "0x857824")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1955174", Offset = "0x1955174", VA = "0x1955174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857834", Offset = "0x857834")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000115")]
		public abstract void OnReactivate();

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x19550F0", Offset = "0x19550F0", VA = "0x19550F0", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x19550F4", Offset = "0x19550F4", VA = "0x19550F4", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x19550F8", Offset = "0x19550F8", VA = "0x19550F8", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x19550FC", Offset = "0x19550FC", VA = "0x19550FC", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1955100", Offset = "0x1955100", VA = "0x1955100", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1955104", Offset = "0x1955104", VA = "0x1955104", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1955108", Offset = "0x1955108", VA = "0x1955108", Slot = "11")]
		public virtual void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x195510C", Offset = "0x195510C", VA = "0x195510C", Slot = "12")]
		public virtual void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1955110", Offset = "0x1955110", VA = "0x1955110", Slot = "13")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1955124", Offset = "0x1955124", VA = "0x1955124", Slot = "14")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1955138", Offset = "0x1955138", VA = "0x1955138", Slot = "15")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x195513C", Offset = "0x195513C", VA = "0x195513C", Slot = "16")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1955140", Offset = "0x1955140", VA = "0x1955140", Slot = "17")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1955144", Offset = "0x1955144", VA = "0x1955144", Slot = "18")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1955148", Offset = "0x1955148", VA = "0x1955148", Slot = "19")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x195514C", Offset = "0x195514C", VA = "0x195514C", Slot = "20")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1955150", Offset = "0x1955150", VA = "0x1955150", Slot = "21")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1955154", Offset = "0x1955154", VA = "0x1955154", Slot = "22")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1955158", Offset = "0x1955158", VA = "0x1955158", Slot = "23")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x195515C", Offset = "0x195515C", VA = "0x195515C", Slot = "24")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1955160", Offset = "0x1955160", VA = "0x1955160", Slot = "25")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1955164", Offset = "0x1955164", VA = "0x1955164", Slot = "26")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1955168", Offset = "0x1955168", VA = "0x1955168", Slot = "27")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1955180", Offset = "0x1955180", VA = "0x1955180")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x19551E0", Offset = "0x19551E0", VA = "0x19551E0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x195524C", Offset = "0x195524C", VA = "0x195524C")]
		public void OnRead()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x19552B8", Offset = "0x19552B8", VA = "0x19552B8")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1955324", Offset = "0x1955324", VA = "0x1955324")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x19553B4", Offset = "0x19553B4", VA = "0x19553B4")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1955464", Offset = "0x1955464", VA = "0x1955464")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1955514", Offset = "0x1955514", VA = "0x1955514")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1955524", Offset = "0x1955524", VA = "0x1955524")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1955648", Offset = "0x1955648", VA = "0x1955648")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x19556A0", Offset = "0x19556A0", VA = "0x19556A0")]
		public void FixedUpdateB()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1955758", Offset = "0x1955758", VA = "0x1955758")]
		public void UpdateB()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1955810", Offset = "0x1955810", VA = "0x1955810")]
		public void LateUpdateB()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x19558C8", Offset = "0x19558C8", VA = "0x19558C8", Slot = "28")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x195590C", Offset = "0x195590C", VA = "0x195590C")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1955A40", Offset = "0x1955A40", VA = "0x1955A40")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1955B74", Offset = "0x1955B74", VA = "0x1955B74")]
		protected void RemovePropMuscles()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1955CA8", Offset = "0x1955CA8", VA = "0x1955CA8", Slot = "29")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1955C20", Offset = "0x1955C20", VA = "0x1955C20")]
		protected bool ContainsRemovablePropMuscle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1955EB4", Offset = "0x1955EB4", VA = "0x1955EB4")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A4C4", Offset = "0x84A4C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A4C4", Offset = "0x84A4C4")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84A524", Offset = "0x84A524")]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000165")]
				[Address(RVA = "0x1861250", Offset = "0x1861250", VA = "0x1861250", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000167")]
				[Address(RVA = "0x1861298", Offset = "0x1861298", VA = "0x1861298", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1861040", Offset = "0x1861040", VA = "0x1861040")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x186106C", Offset = "0x186106C", VA = "0x186106C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1861070", Offset = "0x1861070", VA = "0x1861070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1861258", Offset = "0x1861258", VA = "0x1861258", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C140", Offset = "0x84C140")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84C140", Offset = "0x84C140")]
		public string stateName;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C1A0", Offset = "0x84C1A0")]
		public float transitionDuration;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C1D8", Offset = "0x84C1D8")]
		public int layer;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C210", Offset = "0x84C210")]
		public float fixedTime;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84C248", Offset = "0x84C248")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C248", Offset = "0x84C248")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C2A8", Offset = "0x84C2A8")]
		public string blendParameter;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C2E0", Offset = "0x84C2E0")]
		public float writheHeight;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C318", Offset = "0x84C318")]
		public float writheYVelocity;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C350", Offset = "0x84C350")]
		public float blendSpeed;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C388", Offset = "0x84C388")]
		public float blendMappingSpeed;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C3C0", Offset = "0x84C3C0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84C3C0", Offset = "0x84C3C0")]
		public bool canEnd;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C420", Offset = "0x84C420")]
		public float minTime;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C458", Offset = "0x84C458")]
		public float maxEndVelocity;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C490", Offset = "0x84C490")]
		public PuppetEvent onEnd;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1955EBC", Offset = "0x1955EBC", VA = "0x1955EBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857844", Offset = "0x857844")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1955F04", Offset = "0x1955F04", VA = "0x1955F04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85787C", Offset = "0x85787C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1955F4C", Offset = "0x1955F4C", VA = "0x1955F4C", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1955FF8", Offset = "0x1955FF8", VA = "0x1955FF8", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1956000", Offset = "0x1956000", VA = "0x1956000", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1955F8C", Offset = "0x1955F8C", VA = "0x1955F8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8578B4", Offset = "0x8578B4")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x195600C", Offset = "0x195600C", VA = "0x195600C", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1956470", Offset = "0x1956470", VA = "0x1956470", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1956580", Offset = "0x1956580", VA = "0x1956580", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1956324", Offset = "0x1956324", VA = "0x1956324")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1956210", Offset = "0x1956210", VA = "0x1956210")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x19565E8", Offset = "0x19565E8", VA = "0x19565E8", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1956610", Offset = "0x1956610", VA = "0x1956610")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A534", Offset = "0x84A534")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A534", Offset = "0x84A534")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		public enum State
		{
			[Token(Token = "0x4000160")]
			Puppet,
			[Token(Token = "0x4000161")]
			Unpinned,
			[Token(Token = "0x4000162")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x2000033")]
		public enum NormalMode
		{
			[Token(Token = "0x4000164")]
			Active,
			[Token(Token = "0x4000165")]
			Unmapped,
			[Token(Token = "0x4000166")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x2000034")]
		public class MasterProps
		{
			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x18616EC", Offset = "0x18616EC", VA = "0x18616EC")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000035")]
		public struct MuscleProps
		{
			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CD18", Offset = "0x84CD18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CD18", Offset = "0x84CD18")]
			public float unpinParents;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CD6C", Offset = "0x84CD6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CD6C", Offset = "0x84CD6C")]
			public float unpinChildren;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CDC0", Offset = "0x84CDC0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CDC0", Offset = "0x84CDC0")]
			public float unpinGroup;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CE14", Offset = "0x84CE14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CE14", Offset = "0x84CE14")]
			public float minMappingWeight;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CE68", Offset = "0x84CE68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CE68", Offset = "0x84CE68")]
			public float maxMappingWeight;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CEBC", Offset = "0x84CEBC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CEBC", Offset = "0x84CEBC")]
			public float minPinWeight;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CF10", Offset = "0x84CF10")]
			public bool disableColliders;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CF48", Offset = "0x84CF48")]
			public float regainPinSpeed;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CF80", Offset = "0x84CF80")]
			public float collisionResistance;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CFB8", Offset = "0x84CFB8")]
			public float knockOutDistance;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CFF0", Offset = "0x84CFF0")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D028", Offset = "0x84D028")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D070", Offset = "0x84D070")]
			public Muscle.Group[] groups;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D0A8", Offset = "0x84D0A8")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x2000037")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D0E0", Offset = "0x84D0E0")]
			public float multiplier;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D118", Offset = "0x84D118")]
			public float collisionThreshold;
		}

		[Token(Token = "0x2000038")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84C4C8", Offset = "0x84C4C8")]
		public MasterProps masterProps;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C500", Offset = "0x84C500")]
		public LayerMask groundLayers;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C538", Offset = "0x84C538")]
		public LayerMask collisionLayers;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C570", Offset = "0x84C570")]
		public float collisionThreshold;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C5A8", Offset = "0x84C5A8")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C5E0", Offset = "0x84C5E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C5E0", Offset = "0x84C5E0")]
		public int maxCollisions;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C634", Offset = "0x84C634")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C634", Offset = "0x84C634")]
		public float regainPinSpeed;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C68C", Offset = "0x84C68C")]
		public float boostFalloff;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84C6C4", Offset = "0x84C6C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C6C4", Offset = "0x84C6C4")]
		public MuscleProps defaults;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C724", Offset = "0x84C724")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C75C", Offset = "0x84C75C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C75C", Offset = "0x84C75C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84C75C", Offset = "0x84C75C")]
		public float knockOutDistance;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C7D8", Offset = "0x84C7D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C7D8", Offset = "0x84C7D8")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C82C", Offset = "0x84C82C")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C864", Offset = "0x84C864")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C864", Offset = "0x84C864")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C8B8", Offset = "0x84C8B8")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C8F0", Offset = "0x84C8F0")]
		public bool dropProps;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C928", Offset = "0x84C928")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84C928", Offset = "0x84C928")]
		public bool canGetUp;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C988", Offset = "0x84C988")]
		public float getUpDelay;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C9C0", Offset = "0x84C9C0")]
		public float blendToAnimationTime;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C9F8", Offset = "0x84C9F8")]
		public float maxGetUpVelocity;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CA30", Offset = "0x84CA30")]
		public float minGetUpDuration;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CA68", Offset = "0x84CA68")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CAA0", Offset = "0x84CAA0")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CAD8", Offset = "0x84CAD8")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CB10", Offset = "0x84CB10")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CB48", Offset = "0x84CB48")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CB80", Offset = "0x84CB80")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84CB80", Offset = "0x84CB80")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CBE0", Offset = "0x84CBE0")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CC18", Offset = "0x84CC18")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CC50", Offset = "0x84CC50")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CC88", Offset = "0x84CC88")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CCC0", Offset = "0x84CCC0")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionDelegate OnCollision;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84CCF8", Offset = "0x84CCF8")]
		private State <state>k__BackingField;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private float unpinnedTimer;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private float getUpTimer;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Vector3 hipsForward;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		private Vector3 hipsUp;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool getUpTargetFixed;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private int collisions;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private bool eventsEnabled;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private float lastKnockOutDistance;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private bool getupDisabled;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A2")]
		private bool hasBoosted;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private Vector3 getUpPosition;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private bool dropPropFlag;

		[Token(Token = "0x17000014")]
		public State state
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x195673C", Offset = "0x195673C", VA = "0x195673C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8579D4", Offset = "0x8579D4")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1956744", Offset = "0x1956744", VA = "0x1956744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8579E4", Offset = "0x8579E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x19566AC", Offset = "0x19566AC", VA = "0x19566AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857964", Offset = "0x857964")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x19566F4", Offset = "0x19566F4", VA = "0x19566F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85799C", Offset = "0x85799C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x195674C", Offset = "0x195674C", VA = "0x195674C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x19569FC", Offset = "0x19569FC", VA = "0x19569FC")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1956A70", Offset = "0x1956A70", VA = "0x1956A70", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1956B0C", Offset = "0x1956B0C", VA = "0x1956B0C", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x195706C", Offset = "0x195706C", VA = "0x195706C", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1957770", Offset = "0x1957770", VA = "0x1957770", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1957814", Offset = "0x1957814", VA = "0x1957814", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x195781C", Offset = "0x195781C", VA = "0x195781C", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x19578A8", Offset = "0x19578A8", VA = "0x19578A8", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x19578B4", Offset = "0x19578B4", VA = "0x19578B4", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1958040", Offset = "0x1958040", VA = "0x1958040", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1958318", Offset = "0x1958318", VA = "0x1958318")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1958400", Offset = "0x1958400", VA = "0x1958400", Slot = "23")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x19581D0", Offset = "0x19581D0", VA = "0x19581D0")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x19586F0", Offset = "0x19586F0", VA = "0x19586F0", Slot = "13")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1958734", Offset = "0x1958734", VA = "0x1958734", Slot = "14")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x19586B8", Offset = "0x19586B8", VA = "0x19586B8")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1958770", Offset = "0x1958770", VA = "0x1958770")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x19587A8", Offset = "0x19587A8", VA = "0x19587A8", Slot = "29")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x19587BC", Offset = "0x19587BC", VA = "0x19587BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x19589B8", Offset = "0x19589B8", VA = "0x19589B8")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1958A48", Offset = "0x1958A48", VA = "0x1958A48")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1958B60", Offset = "0x1958B60", VA = "0x1958B60")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1958D24", Offset = "0x1958D24", VA = "0x1958D24")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1958A8C", Offset = "0x1958A8C", VA = "0x1958A8C")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1958D9C", Offset = "0x1958D9C", VA = "0x1958D9C")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1958E40", Offset = "0x1958E40", VA = "0x1958E40")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1958AF8", Offset = "0x1958AF8", VA = "0x1958AF8")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1958EB0", Offset = "0x1958EB0", VA = "0x1958EB0")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1958F54", Offset = "0x1958F54", VA = "0x1958F54")]
		public void Unpin()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1958FD8", Offset = "0x1958FD8", VA = "0x1958FD8", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x19591B0", Offset = "0x19591B0", VA = "0x19591B0", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x19595F8", Offset = "0x19595F8", VA = "0x19595F8")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x19590B4", Offset = "0x19590B4", VA = "0x19590B4")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x19598FC", Offset = "0x19598FC", VA = "0x19598FC")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1959780", Offset = "0x1959780", VA = "0x1959780")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1959AD4", Offset = "0x1959AD4", VA = "0x1959AD4")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1958C80", Offset = "0x1958C80", VA = "0x1958C80")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1959818", Offset = "0x1959818", VA = "0x1959818")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1959B94", Offset = "0x1959B94", VA = "0x1959B94")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1957F58", Offset = "0x1957F58", VA = "0x1957F58")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1957120", Offset = "0x1957120", VA = "0x1957120")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1959C74", Offset = "0x1959C74", VA = "0x1959C74")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x195682C", Offset = "0x195682C", VA = "0x195682C")]
		public void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1959D04", Offset = "0x1959D04", VA = "0x1959D04", Slot = "11")]
		public override void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1959D0C", Offset = "0x1959D0C", VA = "0x1959D0C", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1959DAC", Offset = "0x1959DAC", VA = "0x1959DAC")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A594", Offset = "0x84A594")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1959EAC", Offset = "0x1959EAC", VA = "0x1959EAC", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1959ED0", Offset = "0x1959ED0", VA = "0x1959ED0", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1959ED4", Offset = "0x1959ED4", VA = "0x1959ED4", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1959ED8", Offset = "0x1959ED8", VA = "0x1959ED8", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1959EDC", Offset = "0x1959EDC", VA = "0x1959EDC", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1959F18", Offset = "0x1959F18", VA = "0x1959F18", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1959F1C", Offset = "0x1959F1C", VA = "0x1959F1C", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1959F24", Offset = "0x1959F24", VA = "0x1959F24", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1959F2C", Offset = "0x1959F2C", VA = "0x1959F2C")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200003B")]
		public class Settings
		{
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D1B0", Offset = "0x84D1B0")]
			public float damperForSpring;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D1E8", Offset = "0x84D1E8")]
			public float maxForceMlp;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D220", Offset = "0x84D220")]
			public float IMlp;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D258", Offset = "0x84D258")]
			public float velocityF;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D290", Offset = "0x84D290")]
			public Vector3 copOffset;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D2C8", Offset = "0x84D2C8")]
			public float torqueMlp;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D300", Offset = "0x84D300")]
			public float maxTorqueMag;

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1BA815C", Offset = "0x1BA815C", VA = "0x1BA815C")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D150", Offset = "0x84D150")]
		private ConfigurableJoint <joint>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D160", Offset = "0x84D160")]
		private Vector3 <dir>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D170", Offset = "0x84D170")]
		private Vector3 <dirVel>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D180", Offset = "0x84D180")]
		private Vector3 <cop>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D190", Offset = "0x84D190")]
		private Vector3 <com>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D1A0", Offset = "0x84D1A0")]
		private Vector3 <comV>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000015")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x1772BD0", Offset = "0x1772BD0", VA = "0x1772BD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8579F4", Offset = "0x8579F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1772BD8", Offset = "0x1772BD8", VA = "0x1772BD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A04", Offset = "0x857A04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 dir
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1772BE0", Offset = "0x1772BE0", VA = "0x1772BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A14", Offset = "0x857A14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1772BEC", Offset = "0x1772BEC", VA = "0x1772BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A24", Offset = "0x857A24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Vector3 dirVel
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1772BF8", Offset = "0x1772BF8", VA = "0x1772BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A34", Offset = "0x857A34")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1772C04", Offset = "0x1772C04", VA = "0x1772C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A44", Offset = "0x857A44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 cop
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1772C10", Offset = "0x1772C10", VA = "0x1772C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A54", Offset = "0x857A54")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1772C1C", Offset = "0x1772C1C", VA = "0x1772C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A64", Offset = "0x857A64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Vector3 com
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1772C28", Offset = "0x1772C28", VA = "0x1772C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A74", Offset = "0x857A74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1772C34", Offset = "0x1772C34", VA = "0x1772C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A84", Offset = "0x857A84")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 comV
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1772C40", Offset = "0x1772C40", VA = "0x1772C40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857A94", Offset = "0x857A94")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x1772C4C", Offset = "0x1772C4C", VA = "0x1772C4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857AA4", Offset = "0x857AA4")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1772C58", Offset = "0x1772C58", VA = "0x1772C58")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1772D64", Offset = "0x1772D64", VA = "0x1772D64")]
		private void Solve()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x177318C", Offset = "0x177318C", VA = "0x177318C")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1773224", Offset = "0x1773224", VA = "0x1773224")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x177322C", Offset = "0x177322C", VA = "0x177322C")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1773238", Offset = "0x1773238", VA = "0x1773238")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1773240", Offset = "0x1773240", VA = "0x1773240")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x177321C", Offset = "0x177321C", VA = "0x177321C")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200003E")]
		public enum Mode
		{
			[Token(Token = "0x40001A9")]
			FeetCentroid,
			[Token(Token = "0x40001AA")]
			CenterOfPressure
		}

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D338", Offset = "0x84D338")]
		private Vector3 <position>k__BackingField;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D348", Offset = "0x84D348")]
		private Vector3 <direction>k__BackingField;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D358", Offset = "0x84D358")]
		private float <angle>k__BackingField;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D368", Offset = "0x84D368")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D378", Offset = "0x84D378")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D388", Offset = "0x84D388")]
		private Quaternion <rotation>k__BackingField;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D398", Offset = "0x84D398")]
		private Quaternion <inverseRotation>k__BackingField;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D3A8", Offset = "0x84D3A8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D3B8", Offset = "0x84D3B8")]
		private float <lastGroundedTime>k__BackingField;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x1700001B")]
		public Vector3 position
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1773248", Offset = "0x1773248", VA = "0x1773248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857AB4", Offset = "0x857AB4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1773254", Offset = "0x1773254", VA = "0x1773254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857AC4", Offset = "0x857AC4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 direction
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1773260", Offset = "0x1773260", VA = "0x1773260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857AD4", Offset = "0x857AD4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x177326C", Offset = "0x177326C", VA = "0x177326C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857AE4", Offset = "0x857AE4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public float angle
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1773278", Offset = "0x1773278", VA = "0x1773278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857AF4", Offset = "0x857AF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1773280", Offset = "0x1773280", VA = "0x1773280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B04", Offset = "0x857B04")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 velocity
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1773288", Offset = "0x1773288", VA = "0x1773288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B14", Offset = "0x857B14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1773294", Offset = "0x1773294", VA = "0x1773294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B24", Offset = "0x857B24")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x17732A0", Offset = "0x17732A0", VA = "0x17732A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B34", Offset = "0x857B34")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x17732AC", Offset = "0x17732AC", VA = "0x17732AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B44", Offset = "0x857B44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Quaternion rotation
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x17732B8", Offset = "0x17732B8", VA = "0x17732B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B54", Offset = "0x857B54")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x17732C4", Offset = "0x17732C4", VA = "0x17732C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B64", Offset = "0x857B64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x17732D0", Offset = "0x17732D0", VA = "0x17732D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B74", Offset = "0x857B74")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x17732DC", Offset = "0x17732DC", VA = "0x17732DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B84", Offset = "0x857B84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool isGrounded
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x17732E8", Offset = "0x17732E8", VA = "0x17732E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857B94", Offset = "0x857B94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x17732F0", Offset = "0x17732F0", VA = "0x17732F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857BA4", Offset = "0x857BA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public float lastGroundedTime
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x17732FC", Offset = "0x17732FC", VA = "0x17732FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857BB4", Offset = "0x857BB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1773304", Offset = "0x1773304", VA = "0x1773304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857BC4", Offset = "0x857BC4")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x177330C", Offset = "0x177330C", VA = "0x177330C")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1773628", Offset = "0x1773628", VA = "0x1773628")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x17736D0", Offset = "0x17736D0", VA = "0x17736D0")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x17738AC", Offset = "0x17738AC", VA = "0x17738AC")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x177396C", Offset = "0x177396C", VA = "0x177396C")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1773C18", Offset = "0x1773C18", VA = "0x1773C18")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1774134", Offset = "0x1774134", VA = "0x1774134")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x17737C8", Offset = "0x17737C8", VA = "0x17737C8")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1773E7C", Offset = "0x1773E7C", VA = "0x1773E7C")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1773A0C", Offset = "0x1773A0C", VA = "0x1773A0C")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1773FA8", Offset = "0x1773FA8", VA = "0x1773FA8")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1774160", Offset = "0x1774160", VA = "0x1774160")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1773EE0", Offset = "0x1773EE0", VA = "0x1773EE0")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1773B30", Offset = "0x1773B30", VA = "0x1773B30")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1774284", Offset = "0x1774284", VA = "0x1774284")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class Booster
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D3E8", Offset = "0x84D3E8")]
		public bool fullBody;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D420", Offset = "0x84D420")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D458", Offset = "0x84D458")]
		public Muscle.Group[] groups;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D490", Offset = "0x84D490")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D490", Offset = "0x84D490")]
		public float immunity;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D4E4", Offset = "0x84D4E4")]
		public float impulseMlp;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D51C", Offset = "0x84D51C")]
		public float boostParents;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D554", Offset = "0x84D554")]
		public float boostChildren;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D58C", Offset = "0x84D58C")]
		public float delay;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1916774", Offset = "0x1916774", VA = "0x1916774")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1916988", Offset = "0x1916988", VA = "0x1916988")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public int muscleIndex;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1C142DC", Offset = "0x1C142DC", VA = "0x1C142DC")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1C14360", Offset = "0x1C14360", VA = "0x1C14360")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x2000042")]
		public enum Group
		{
			[Token(Token = "0x4000202")]
			Hips,
			[Token(Token = "0x4000203")]
			Spine,
			[Token(Token = "0x4000204")]
			Head,
			[Token(Token = "0x4000205")]
			Arm,
			[Token(Token = "0x4000206")]
			Hand,
			[Token(Token = "0x4000207")]
			Leg,
			[Token(Token = "0x4000208")]
			Foot,
			[Token(Token = "0x4000209")]
			Tail,
			[Token(Token = "0x400020A")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x2000043")]
		public class InternalCollisionIgnoreSettings
		{
			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D8D4", Offset = "0x84D8D4")]
			public bool ignoreAll;

			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D90C", Offset = "0x84D90C")]
			public ConfigurableJoint[] muscles;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D944", Offset = "0x84D944")]
			public Group[] groups;

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1BA4024", Offset = "0x1BA4024", VA = "0x1BA4024")]
			public InternalCollisionIgnoreSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000044")]
		public class Props
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D97C", Offset = "0x84D97C")]
			public Group group;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D9B4", Offset = "0x84D9B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D9B4", Offset = "0x84D9B4")]
			public float mappingWeight;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DA08", Offset = "0x84DA08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DA08", Offset = "0x84DA08")]
			public float pinWeight;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DA5C", Offset = "0x84DA5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DA5C", Offset = "0x84DA5C")]
			public float muscleWeight;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DAB0", Offset = "0x84DAB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DAB0", Offset = "0x84DAB0")]
			public float muscleDamper;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DB04", Offset = "0x84DB04")]
			public bool mapPosition;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DB3C", Offset = "0x84DB3C")]
			public InternalCollisionIgnoreSettings internalCollisionIgnores;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DB74", Offset = "0x84DB74")]
			public Transform[] animatedTargetChildren;

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1BA40A4", Offset = "0x1BA40A4", VA = "0x1BA40A4")]
			public Props()
			{
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1BA4148", Offset = "0x1BA4148", VA = "0x1BA4148")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1BA421C", Offset = "0x1BA421C", VA = "0x1BA421C")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000045")]
		public struct State
		{
			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isDisconnected;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool resetFlag;

			[Token(Token = "0x17000036")]
			public static State Default
			{
				[Token(Token = "0x6000229")]
				[Address(RVA = "0x1BA42B0", Offset = "0x1BA42B0", VA = "0x1BA42B0")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1BA42D0", Offset = "0x1BA42D0", VA = "0x1BA42D0")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000046")]
		public class TargetChild
		{
			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x1BA4378", Offset = "0x1BA4378", VA = "0x1BA4378")]
			public TargetChild(Transform t)
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1BA43E8", Offset = "0x1BA43E8", VA = "0x1BA43E8")]
			public void Map()
			{
			}
		}

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D6B4", Offset = "0x84D6B4")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D6C4", Offset = "0x84D6C4")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D6D4", Offset = "0x84D6D4")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D6E4", Offset = "0x84D6E4")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D6F4", Offset = "0x84D6F4")]
		private Quaternion <targetAnimatedWorldRotation>k__BackingField;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D704", Offset = "0x84D704")]
		private Vector3 <targetVelocity>k__BackingField;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D714", Offset = "0x84D714")]
		private Rigidbody <additionalRigidbody>k__BackingField;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		[SerializeField]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[HideInInspector]
		public Transform additionalPinTarget;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[HideInInspector]
		[SerializeField]
		public float additionalPinWeight;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[HideInInspector]
		public Vector3 mappedVelocity;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[HideInInspector]
		public bool isPropMuscle;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		public int index;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D834", Offset = "0x84D834")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D844", Offset = "0x84D844")]
		private Rigidbody <rebuildConnectedBody>k__BackingField;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D854", Offset = "0x84D854")]
		private Transform <rebuildTargetParent>k__BackingField;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D864", Offset = "0x84D864")]
		private Vector3 <defaultTargetPosRelToMuscle>k__BackingField;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D874", Offset = "0x84D874")]
		private Quaternion <defaultTargetRotRelToMuscle>k__BackingField;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D884", Offset = "0x84D884")]
		private Quaternion <defaultMuscleRotRelToTarget>k__BackingField;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Transform rebuildParent;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 rebuildPosition;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion rebuildRotation;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 rebuildTargetPosition;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion rebuildTargetRotation;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ConfigurableJointMotion rebuildAngularXMotion;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private ConfigurableJointMotion rebuildAngularYMotion;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private ConfigurableJointMotion rebuildAngularZMotion;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[HideInInspector]
		public Vector3 targetMappedPosition;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[HideInInspector]
		public Quaternion targetMappedRotation;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		public Vector3 targetSampledPosition;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		[HideInInspector]
		public Quaternion targetSampledRotation;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private JointDrive slerpDrive;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private float lastRotationDamper;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Quaternion toParentSpace;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private Transform targetParent;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private bool directTargetParent;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FD")]
		private bool initiated;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private Collider[] _colliders;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private float lastReadTime;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float lastWriteTime;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private bool[] disabledColliders;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private TargetChild[] targetChildren;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Vector3 additionalTargetVelocity;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private Vector3 additionalPinTargetAnimatedCenterOfMass;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		private Quaternion defaultTargetRotRelToMuscleInverse;

		[Token(Token = "0x17000024")]
		public Transform transform
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xF18DAC", Offset = "0xF18DAC", VA = "0xF18DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857BD4", Offset = "0x857BD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xF18DB4", Offset = "0xF18DB4", VA = "0xF18DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857BE4", Offset = "0x857BE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xF18DBC", Offset = "0xF18DBC", VA = "0xF18DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857BF4", Offset = "0x857BF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xF18DC4", Offset = "0xF18DC4", VA = "0xF18DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C04", Offset = "0x857C04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xF18DCC", Offset = "0xF18DCC", VA = "0xF18DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C14", Offset = "0x857C14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xF18DD4", Offset = "0xF18DD4", VA = "0xF18DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C24", Offset = "0x857C24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xF18DDC", Offset = "0xF18DDC", VA = "0xF18DDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C34", Offset = "0x857C34")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xF18DE8", Offset = "0xF18DE8", VA = "0xF18DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C44", Offset = "0x857C44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Quaternion targetAnimatedWorldRotation
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xF18DF4", Offset = "0xF18DF4", VA = "0xF18DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C54", Offset = "0x857C54")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xF18E00", Offset = "0xF18E00", VA = "0xF18E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C64", Offset = "0x857C64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Collider[] colliders
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xF18E0C", Offset = "0xF18E0C", VA = "0xF18E0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xF18E14", Offset = "0xF18E14", VA = "0xF18E14")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xF18E1C", Offset = "0xF18E1C", VA = "0xF18E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C74", Offset = "0x857C74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xF18E28", Offset = "0xF18E28", VA = "0xF18E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C84", Offset = "0x857C84")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Rigidbody additionalRigidbody
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xF18E34", Offset = "0xF18E34", VA = "0xF18E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857C94", Offset = "0x857C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xF18E3C", Offset = "0xF18E3C", VA = "0xF18E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857CA4", Offset = "0x857CA4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xF18E44", Offset = "0xF18E44", VA = "0xF18E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857CB4", Offset = "0x857CB4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xF18E58", Offset = "0xF18E58", VA = "0xF18E58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857CC4", Offset = "0x857CC4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Rigidbody rebuildConnectedBody
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xF19088", Offset = "0xF19088", VA = "0xF19088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857CD4", Offset = "0x857CD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xF19090", Offset = "0xF19090", VA = "0xF19090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857CE4", Offset = "0x857CE4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Transform rebuildTargetParent
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xF19098", Offset = "0xF19098", VA = "0xF19098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857CF4", Offset = "0x857CF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xF190A0", Offset = "0xF190A0", VA = "0xF190A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D04", Offset = "0x857D04")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector3 defaultTargetPosRelToMuscle
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xF190A8", Offset = "0xF190A8", VA = "0xF190A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D14", Offset = "0x857D14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xF190B8", Offset = "0xF190B8", VA = "0xF190B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D24", Offset = "0x857D24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public Quaternion defaultTargetRotRelToMuscle
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xF190C8", Offset = "0xF190C8", VA = "0xF190C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D34", Offset = "0x857D34")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xF190DC", Offset = "0xF190DC", VA = "0xF190DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D44", Offset = "0x857D44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Quaternion defaultMuscleRotRelToTarget
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xF190F0", Offset = "0xF190F0", VA = "0xF190F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D54", Offset = "0x857D54")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xF19104", Offset = "0xF19104", VA = "0xF19104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D64", Offset = "0x857D64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		private Quaternion localRotation
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xF1A630", Offset = "0xF1A630", VA = "0xF1A630")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000033")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xF1A744", Offset = "0xF1A744", VA = "0xF1A744")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000034")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xF1A6B0", Offset = "0xF1A6B0", VA = "0xF1A6B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000035")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xF1A870", Offset = "0xF1A870", VA = "0xF1A870")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF18E6C", Offset = "0xF18E6C", VA = "0xF18E6C")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF19118", Offset = "0xF19118", VA = "0xF19118")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF1927C", Offset = "0xF1927C", VA = "0xF1927C", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF1A2BC", Offset = "0xF1A2BC", VA = "0xF1A2BC")]
		public void InitiateAdditionalPin()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xF1A4E0", Offset = "0xF1A4E0", VA = "0xF1A4E0")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xF1AEE8", Offset = "0xF1AEE8", VA = "0xF1AEE8")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xF1AFF0", Offset = "0xF1AFF0", VA = "0xF1AFF0")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xF1AB78", Offset = "0xF1AB78", VA = "0xF1AB78")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xF1ADD8", Offset = "0xF1ADD8", VA = "0xF1ADD8")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xF1B09C", Offset = "0xF1B09C", VA = "0xF1B09C")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xF1B270", Offset = "0xF1B270", VA = "0xF1B270")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF1B46C", Offset = "0xF1B46C", VA = "0xF1B46C")]
		private bool ForceIgnore(Muscle otherMuscle)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xF1B6D4", Offset = "0xF1B6D4", VA = "0xF1B6D4")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xF1B774", Offset = "0xF1B774", VA = "0xF1B774")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xF1B7E0", Offset = "0xF1B7E0", VA = "0xF1B7E0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xF1B998", Offset = "0xF1B998", VA = "0xF1B998")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xF1A410", Offset = "0xF1A410", VA = "0xF1A410")]
		public void SetKinematic(bool to)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xF1A908", Offset = "0xF1A908", VA = "0xF1A908")]
		public void Read()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xF1BB18", Offset = "0xF1BB18", VA = "0xF1BB18")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xF1BCA0", Offset = "0xF1BCA0", VA = "0xF1BCA0")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xF1BF08", Offset = "0xF1BF08", VA = "0xF1BF08", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xF1C480", Offset = "0xF1C480", VA = "0xF1C480")]
		public void StoreTargetMappedPosition()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xF1C4BC", Offset = "0xF1C4BC", VA = "0xF1C4BC")]
		public void StoreTargetMappedRotation()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xF1C4FC", Offset = "0xF1C4FC", VA = "0xF1C4FC")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xF1C8A4", Offset = "0xF1C8A4", VA = "0xF1C8A4")]
		public void ResetTargetLocalPosition()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xF1C8D0", Offset = "0xF1C8D0", VA = "0xF1C8D0")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xF1CA3C", Offset = "0xF1CA3C", VA = "0xF1CA3C")]
		public void MapDisconnected()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xF1C030", Offset = "0xF1C030", VA = "0xF1C030")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xF1CB28", Offset = "0xF1CB28", VA = "0xF1CB28")]
		private void Pin(Rigidbody r, Vector3 posOffset, Vector3 targetVel, float w, float pinDistanceFalloff, float deltaTime)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xF1C2C0", Offset = "0xF1C2C0", VA = "0xF1C2C0")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xF1CEFC", Offset = "0xF1CEFC", VA = "0xF1CEFC")]
		public void SetMuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xF1CE7C", Offset = "0xF1CE7C", VA = "0xF1CE7C")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xF1BEA4", Offset = "0xF1BEA4", VA = "0xF1BEA4")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xF1D068", Offset = "0xF1D068", VA = "0xF1D068")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public struct MuscleCollision
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xF1D264", Offset = "0xF1D264", VA = "0xF1D264")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x2000048")]
	public struct MuscleHit
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xF1D364", Offset = "0xF1D364", VA = "0xF1D364")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A5CC", Offset = "0x84A5CC")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public int muscleIndex;

		[Token(Token = "0x400022E")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x400022F")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x4000230")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xF1D278", Offset = "0xF1D278", VA = "0xF1D278")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xF1D37C", Offset = "0xF1D37C", VA = "0xF1D37C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xF1D55C", Offset = "0xF1D55C", VA = "0xF1D55C")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xF1D7E8", Offset = "0xF1D7E8", VA = "0xF1D7E8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xF1DA70", Offset = "0xF1DA70", VA = "0xF1DA70")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public static class PhysXTools
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xF1F774", Offset = "0xF1F774", VA = "0xF1F774")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xF1F810", Offset = "0xF1F810", VA = "0xF1F810")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xF1F910", Offset = "0xF1F910", VA = "0xF1F910")]
		public static void Predict(ref Vector3 position, ref Quaternion rotation, ref Vector3 velocity, ref Vector3 angularVelocity, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xF1FAA4", Offset = "0xF1FAA4", VA = "0xF1FAA4")]
		public static Vector3 GetCenterOfMass(PuppetMaster puppet)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xF1FC34", Offset = "0xF1FC34", VA = "0xF1FC34")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xF1FD80", Offset = "0xF1FD80", VA = "0xF1FD80")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xF1FECC", Offset = "0xF1FECC", VA = "0xF1FECC")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xF1FF78", Offset = "0xF1FF78", VA = "0xF1FF78")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xF20014", Offset = "0xF20014", VA = "0xF20014")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xF1CC3C", Offset = "0xF1CC3C", VA = "0xF1CC3C")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xF200E0", Offset = "0xF200E0", VA = "0xF200E0")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xF202C4", Offset = "0xF202C4", VA = "0xF202C4")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xF20480", Offset = "0xF20480", VA = "0xF20480")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xF205F0", Offset = "0xF205F0", VA = "0xF205F0")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xF20634", Offset = "0xF20634", VA = "0xF20634")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xF1A5FC", Offset = "0xF1A5FC", VA = "0xF1A5FC")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xF1FF68", Offset = "0xF1FF68", VA = "0xF1FF68")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200004B")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DC1C", Offset = "0x84DC1C")]
		private Vector3 <center>k__BackingField;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DC2C", Offset = "0x84DC2C")]
		private bool <inContact>k__BackingField;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DC3C", Offset = "0x84DC3C")]
		private Vector3 <bottom>k__BackingField;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DC4C", Offset = "0x84DC4C")]
		private Rigidbody <r>k__BackingField;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x17000037")]
		public Vector3 center
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xF21E30", Offset = "0xF21E30", VA = "0xF21E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D74", Offset = "0x857D74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xF21E3C", Offset = "0xF21E3C", VA = "0xF21E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D84", Offset = "0x857D84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool inContact
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xF21E48", Offset = "0xF21E48", VA = "0xF21E48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857D94", Offset = "0x857D94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xF21E50", Offset = "0xF21E50", VA = "0xF21E50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857DA4", Offset = "0x857DA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 bottom
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0xF21E5C", Offset = "0xF21E5C", VA = "0xF21E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857DB4", Offset = "0x857DB4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xF21E68", Offset = "0xF21E68", VA = "0xF21E68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857DC4", Offset = "0x857DC4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Rigidbody r
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0xF21E74", Offset = "0xF21E74", VA = "0xF21E74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857DD4", Offset = "0x857DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xF21E7C", Offset = "0xF21E7C", VA = "0xF21E7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857DE4", Offset = "0x857DE4")]
			private set
			{
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF21E84", Offset = "0xF21E84", VA = "0xF21E84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xF21EFC", Offset = "0xF21EFC", VA = "0xF21EFC")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xF22064", Offset = "0xF22064", VA = "0xF22064")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xF22068", Offset = "0xF22068", VA = "0xF22068")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xF22070", Offset = "0xF22070", VA = "0xF22070")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xF220C0", Offset = "0xF220C0", VA = "0xF220C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xF21F00", Offset = "0xF21F00", VA = "0xF21F00")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xF22100", Offset = "0xF22100", VA = "0xF22100")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xF22124", Offset = "0xF22124", VA = "0xF22124")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DC5C", Offset = "0x84DC5C")]
		public int propType;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84DC94", Offset = "0x84DC94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DC94", Offset = "0x84DC94")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DCF4", Offset = "0x84DCF4")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DD2C", Offset = "0x84DD2C")]
		public bool forceLayers;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84DD64", Offset = "0x84DD64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DD64", Offset = "0x84DD64")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DDC4", Offset = "0x84DDC4")]
		public Transform additionalPinTarget;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DDFC", Offset = "0x84DDFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DDFC", Offset = "0x84DDFC")]
		public float additionalPinWeight;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DE50", Offset = "0x84DE50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84DE50", Offset = "0x84DE50")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DEB0", Offset = "0x84DEB0")]
		public PhysicMaterial droppedMaterial;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DEE8", Offset = "0x84DEE8")]
		private PropRoot <propRoot>k__BackingField;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DEF8", Offset = "0x84DEF8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] colliders;

		[Token(Token = "0x1700003B")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xF2212C", Offset = "0xF2212C", VA = "0xF2212C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public PropRoot propRoot
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xF22198", Offset = "0xF22198", VA = "0xF22198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857DF4", Offset = "0x857DF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xF221A0", Offset = "0xF221A0", VA = "0xF221A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857E04", Offset = "0x857E04")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool initiated
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xF22468", Offset = "0xF22468", VA = "0xF22468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857E14", Offset = "0x857E14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xF22470", Offset = "0xF22470", VA = "0xF22470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857E24", Offset = "0x857E24")]
			private set
			{
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xF221A8", Offset = "0xF221A8", VA = "0xF221A8")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xF2242C", Offset = "0xF2242C", VA = "0xF2242C")]
		public void Drop()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xF22460", Offset = "0xF22460", VA = "0xF22460")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xF2247C", Offset = "0xF2247C", VA = "0xF2247C", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xF22480", Offset = "0xF22480", VA = "0xF22480", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xF22484", Offset = "0xF22484", VA = "0xF22484", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xF22488", Offset = "0xF22488", VA = "0xF22488")]
		private void Start()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xF226D0", Offset = "0xF226D0", VA = "0xF226D0")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xF22358", Offset = "0xF22358", VA = "0xF22358")]
		private void SetMaterial(PhysicMaterial material)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xF227D8", Offset = "0xF227D8", VA = "0xF227D8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xF22984", Offset = "0xF22984", VA = "0xF22984")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class PropMuscle : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		public delegate void PropDelegate(PuppetMasterProp prop);

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DF40", Offset = "0x84DF40")]
		public PuppetMasterProp currentProp;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DF78", Offset = "0x84DF78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84DF78", Offset = "0x84DF78")]
		public Vector3 additionalPinOffset;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DFD8", Offset = "0x84DFD8")]
		private PuppetMasterProp <activeProp>k__BackingField;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropDelegate OnPickUpProp;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PropDelegate OnDropProp;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Muscle _muscle;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PuppetMasterProp lastProp;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 targetDefaultLocalPos;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 lastAdditionalPinOffset;

		[Token(Token = "0x1700003E")]
		public Muscle muscle
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xF22DC0", Offset = "0xF22DC0", VA = "0xF22DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public PuppetMasterProp activeProp
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xF22E90", Offset = "0xF22E90", VA = "0xF22E90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857E34", Offset = "0x857E34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xF22E98", Offset = "0xF22E98", VA = "0xF22E98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857E44", Offset = "0x857E44")]
			private set
			{
			}
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xF22EA0", Offset = "0xF22EA0", VA = "0xF22EA0")]
		public bool AddAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xF23314", Offset = "0xF23314", VA = "0xF23314")]
		public bool RemoveAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xF234B0", Offset = "0xF234B0", VA = "0xF234B0")]
		public void OnInitiate()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xF23710", Offset = "0xF23710", VA = "0xF23710")]
		public void TakeOver()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xF23758", Offset = "0xF23758", VA = "0xF23758")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xF23F5C", Offset = "0xF23F5C", VA = "0xF23F5C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xF241EC", Offset = "0xF241EC", VA = "0xF241EC")]
		public PropMuscle()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A604", Offset = "0x84A604")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A604", Offset = "0x84A604")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DFE8", Offset = "0x84DFE8")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E020", Offset = "0x84E020")]
		public Rigidbody connectTo;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E058", Offset = "0x84E058")]
		public Prop currentProp;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xF243B4", Offset = "0xF243B4", VA = "0xF243B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857E54", Offset = "0x857E54")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xF243FC", Offset = "0xF243FC", VA = "0xF243FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857E8C", Offset = "0x857E8C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xF24444", Offset = "0xF24444", VA = "0xF24444")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xF2523C", Offset = "0xF2523C", VA = "0xF2523C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xF25324", Offset = "0xF25324", VA = "0xF25324")]
		private void Update()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xF25458", Offset = "0xF25458", VA = "0xF25458")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xF2566C", Offset = "0xF2566C", VA = "0xF2566C")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xF26264", Offset = "0xF26264", VA = "0xF26264")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A664", Offset = "0x84A664")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A664", Offset = "0x84A664")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xF2626C", Offset = "0xF2626C", VA = "0xF2626C", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xF26270", Offset = "0xF26270", VA = "0xF26270", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xF26274", Offset = "0xF26274", VA = "0xF26274", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xF26278", Offset = "0xF26278", VA = "0xF26278")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A6C4", Offset = "0x84A6C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A6C4", Offset = "0x84A6C4")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		public enum Mode
		{
			[Token(Token = "0x40002B1")]
			Active,
			[Token(Token = "0x40002B2")]
			Kinematic,
			[Token(Token = "0x40002B3")]
			Disabled
		}

		[Token(Token = "0x2000053")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000054")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x2000055")]
		public enum UpdateMode
		{
			[Token(Token = "0x40002B5")]
			Normal,
			[Token(Token = "0x40002B6")]
			AnimatePhysics,
			[Token(Token = "0x40002B7")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x2000056")]
		public enum State
		{
			[Token(Token = "0x40002B9")]
			Alive,
			[Token(Token = "0x40002BA")]
			Dead,
			[Token(Token = "0x40002BB")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x2000057")]
		public struct StateSettings
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E798", Offset = "0x84E798")]
			public float killDuration;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E7D0", Offset = "0x84E7D0")]
			public float deadMuscleWeight;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E808", Offset = "0x84E808")]
			public float deadMuscleDamper;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E840", Offset = "0x84E840")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E878", Offset = "0x84E878")]
			public bool freezePermanently;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E8B0", Offset = "0x84E8B0")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E8E8", Offset = "0x84E8E8")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x1700004F")]
			public static StateSettings Default
			{
				[Token(Token = "0x6000323")]
				[Address(RVA = "0x1BA6B68", Offset = "0x1BA6B68", VA = "0x1BA6B68")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1BA6B44", Offset = "0x1BA6B44", VA = "0x1BA6B44")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84A724", Offset = "0x84A724")]
		private sealed class <DisabledToActive>d__173 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000327")]
				[Address(RVA = "0x1BA6494", Offset = "0x1BA6494", VA = "0x1BA6494", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000329")]
				[Address(RVA = "0x1BA64DC", Offset = "0x1BA64DC", VA = "0x1BA64DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1BA6214", Offset = "0x1BA6214", VA = "0x1BA6214")]
			[DebuggerHidden]
			public <DisabledToActive>d__173(int <>1__state)
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1BA6240", Offset = "0x1BA6240", VA = "0x1BA6240", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1BA6244", Offset = "0x1BA6244", VA = "0x1BA6244", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x1BA649C", Offset = "0x1BA649C", VA = "0x1BA649C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84A734", Offset = "0x84A734")]
		private sealed class <KinematicToActive>d__175 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000052")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032D")]
				[Address(RVA = "0x1BA66EC", Offset = "0x1BA66EC", VA = "0x1BA66EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032F")]
				[Address(RVA = "0x1BA6734", Offset = "0x1BA6734", VA = "0x1BA6734", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1BA64E4", Offset = "0x1BA64E4", VA = "0x1BA64E4")]
			[DebuggerHidden]
			public <KinematicToActive>d__175(int <>1__state)
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1BA6510", Offset = "0x1BA6510", VA = "0x1BA6510", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1BA6514", Offset = "0x1BA6514", VA = "0x1BA6514", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1BA66F4", Offset = "0x1BA66F4", VA = "0x1BA66F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84A744", Offset = "0x84A744")]
		private sealed class <ActiveToDisabled>d__176 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000054")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0x1BA5A04", Offset = "0x1BA5A04", VA = "0x1BA5A04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000335")]
				[Address(RVA = "0x1BA5A4C", Offset = "0x1BA5A4C", VA = "0x1BA5A4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1BA589C", Offset = "0x1BA589C", VA = "0x1BA589C")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__176(int <>1__state)
			{
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1BA58C8", Offset = "0x1BA58C8", VA = "0x1BA58C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1BA58CC", Offset = "0x1BA58CC", VA = "0x1BA58CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1BA5A0C", Offset = "0x1BA5A0C", VA = "0x1BA5A0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84A754", Offset = "0x84A754")]
		private sealed class <ActiveToKinematic>d__177 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000339")]
				[Address(RVA = "0x1BA5BF4", Offset = "0x1BA5BF4", VA = "0x1BA5BF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600033B")]
				[Address(RVA = "0x1BA5C3C", Offset = "0x1BA5C3C", VA = "0x1BA5C3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1BA5A54", Offset = "0x1BA5A54", VA = "0x1BA5A54")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__177(int <>1__state)
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1BA5A80", Offset = "0x1BA5A80", VA = "0x1BA5A80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1BA5A84", Offset = "0x1BA5A84", VA = "0x1BA5A84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1BA5BFC", Offset = "0x1BA5BFC", VA = "0x1BA5BFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84A764", Offset = "0x84A764")]
		private sealed class <AliveToDead>d__228 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x1BA61C4", Offset = "0x1BA61C4", VA = "0x1BA61C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000341")]
				[Address(RVA = "0x1BA620C", Offset = "0x1BA620C", VA = "0x1BA620C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1BA5C44", Offset = "0x1BA5C44", VA = "0x1BA5C44")]
			[DebuggerHidden]
			public <AliveToDead>d__228(int <>1__state)
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x1BA5C70", Offset = "0x1BA5C70", VA = "0x1BA5C70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1BA5C74", Offset = "0x1BA5C74", VA = "0x1BA5C74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x1BA61CC", Offset = "0x1BA61CC", VA = "0x1BA61CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E090", Offset = "0x84E090")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84E0C8", Offset = "0x84E0C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E0C8", Offset = "0x84E0C8")]
		public State state;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x84E128", Offset = "0x84E128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E128", Offset = "0x84E128")]
		public StateSettings stateSettings;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E1A4", Offset = "0x84E1A4")]
		public Mode mode;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E1DC", Offset = "0x84E1DC")]
		public float blendTime;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E214", Offset = "0x84E214")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E24C", Offset = "0x84E24C")]
		public int solverIterationCount;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E284", Offset = "0x84E284")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E2BC", Offset = "0x84E2BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E2BC", Offset = "0x84E2BC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84E2BC", Offset = "0x84E2BC")]
		public float mappingWeight;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E334", Offset = "0x84E334")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E334", Offset = "0x84E334")]
		public float pinWeight;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E388", Offset = "0x84E388")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E388", Offset = "0x84E388")]
		public float muscleWeight;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84E3DC", Offset = "0x84E3DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E3DC", Offset = "0x84E3DC")]
		public float muscleSpring;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E43C", Offset = "0x84E43C")]
		public float muscleDamper;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E474", Offset = "0x84E474")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E474", Offset = "0x84E474")]
		public float pinPow;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E4C8", Offset = "0x84E4C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E4C8", Offset = "0x84E4C8")]
		public float pinDistanceFalloff;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E520", Offset = "0x84E520")]
		public bool angularPinning;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E558", Offset = "0x84E558")]
		public bool updateJointAnchors;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E590", Offset = "0x84E590")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E5C8", Offset = "0x84E5C8")]
		public bool angularLimits;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E600", Offset = "0x84E600")]
		public bool internalCollisions;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84E638", Offset = "0x84E638")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E638", Offset = "0x84E638")]
		public Muscle[] muscles;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		[SerializeField]
		public PropMuscle[] propMuscles;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public MuscleDelegate OnMuscleDisconnected;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public MuscleDelegate OnMuscleReconnected;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Animator _targetAnimator;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E6D0", Offset = "0x84E6D0")]
		private Animation <targetAnimation>k__BackingField;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E6E0", Offset = "0x84E6E0")]
		private BehaviourBase[] <behaviours>k__BackingField;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E6F0", Offset = "0x84E6F0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[NonSerialized]
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public bool manualInternalCollisionControl;

		[NonSerialized]
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[HideInInspector]
		public bool manualAngularLimitControl;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[SerializeField]
		[HideInInspector]
		public bool mapDisconnectedMuscles;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private bool fixedFrame;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int lastSolverIterationCount;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool isLegacy;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool animatorDisabled;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool awakeFailed;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		private bool interpolated;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool freezeFlag;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool hasBeenDisabled;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		private bool teleport;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 teleportPosition;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion teleportRotation;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool rebuildFlag;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		private bool onPostRebuildFlag;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool[] disconnectMuscleFlags;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private MuscleDisconnectMode[] muscleDisconnectModes;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool[] disconnectDeactivateFlags;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool[] reconnectMuscleFlags;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Muscle[] defaultMuscles;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 rebuildPelvisPos;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion rebuildPelvisRot;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private bool readInFixedUpdate;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E768", Offset = "0x84E768")]
		private bool <isSwitchingMode>k__BackingField;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Mode activeMode;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Mode lastMode;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float mappingBlend;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E778", Offset = "0x84E778")]
		private bool <isKilling>k__BackingField;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private State activeState;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private State lastState;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B3")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private bool targetMappedStateStored;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B6")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B7")]
		private bool hasProp;

		[Token(Token = "0x17000040")]
		public Animator targetAnimator
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xF266A8", Offset = "0xF266A8", VA = "0xF266A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xF267F8", Offset = "0xF267F8", VA = "0xF267F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Animation targetAnimation
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xF26800", Offset = "0xF26800", VA = "0xF26800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858014", Offset = "0x858014")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xF26808", Offset = "0xF26808", VA = "0xF26808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858024", Offset = "0x858024")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xF26810", Offset = "0xF26810", VA = "0xF26810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858034", Offset = "0x858034")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xF26818", Offset = "0xF26818", VA = "0xF26818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858044", Offset = "0x858044")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool isActive
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xF26820", Offset = "0xF26820", VA = "0xF26820")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public bool initiated
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xF268B4", Offset = "0xF268B4", VA = "0xF268B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858054", Offset = "0x858054")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xF268BC", Offset = "0xF268BC", VA = "0xF268BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858064", Offset = "0x858064")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xF268C8", Offset = "0xF268C8", VA = "0xF268C8")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x17000046")]
		public bool controlsAnimator
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xF26A00", Offset = "0xF26A00", VA = "0xF26A00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public bool isBlending
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xF26890", Offset = "0xF26890", VA = "0xF26890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool autoSimulate
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xF2738C", Offset = "0xF2738C", VA = "0xF2738C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xF26908", Offset = "0xF26908", VA = "0xF26908")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x1700004A")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xF2E62C", Offset = "0xF2E62C", VA = "0xF2E62C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858154", Offset = "0x858154")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xF2E634", Offset = "0xF2E634", VA = "0xF2E634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858164", Offset = "0x858164")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isSwitchingState
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xF26A60", Offset = "0xF26A60", VA = "0xF26A60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public bool isKilling
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xF31F48", Offset = "0xF31F48", VA = "0xF31F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8582F4", Offset = "0x8582F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xF31F50", Offset = "0xF31F50", VA = "0xF31F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858304", Offset = "0x858304")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool isAlive
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xF2B95C", Offset = "0xF2B95C", VA = "0xF2B95C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool isFrozen
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xF2A638", Offset = "0xF2A638", VA = "0xF2A638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xF264A8", Offset = "0xF264A8", VA = "0xF264A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857EC4", Offset = "0x857EC4")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xF264F0", Offset = "0xF264F0", VA = "0xF264F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857EFC", Offset = "0x857EFC")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xF26538", Offset = "0xF26538", VA = "0xF26538")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857F34", Offset = "0x857F34")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xF26580", Offset = "0xF26580", VA = "0xF26580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857F6C", Offset = "0x857F6C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xF265C8", Offset = "0xF265C8", VA = "0xF265C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857FA4", Offset = "0x857FA4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xF26610", Offset = "0xF26610", VA = "0xF26610")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x857FDC", Offset = "0x857FDC")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xF26658", Offset = "0xF26658", VA = "0xF26658")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xF26A74", Offset = "0xF26A74", VA = "0xF26A74")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xF27224", Offset = "0xF27224", VA = "0xF27224")]
		public void SetInternalCollisionsManual(bool collide, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xF27308", Offset = "0xF27308", VA = "0xF27308")]
		public void SetAngularLimitsManual(bool limited)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xF27394", Offset = "0xF27394", VA = "0xF27394")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xF2743C", Offset = "0xF2743C", VA = "0xF2743C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xF27B64", Offset = "0xF27B64", VA = "0xF27B64")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xF28608", Offset = "0xF28608", VA = "0xF28608")]
		public void Start()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xF286B8", Offset = "0xF286B8", VA = "0xF286B8")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xF27BA8", Offset = "0xF27BA8", VA = "0xF27BA8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xF298BC", Offset = "0xF298BC", VA = "0xF298BC")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xF299B4", Offset = "0xF299B4", VA = "0xF299B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xF29ABC", Offset = "0xF29ABC", VA = "0xF29ABC")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xF29B48", Offset = "0xF29B48", VA = "0xF29B48")]
		private void OnRebuild()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xF29E7C", Offset = "0xF29E7C", VA = "0xF29E7C")]
		public void OnPreSimulate(float deltaTime)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xF2A72C", Offset = "0xF2A72C", VA = "0xF2A72C")]
		public void OnPostSimulate()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xF2AE80", Offset = "0xF2AE80", VA = "0xF2AE80", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xF2B408", Offset = "0xF2B408", VA = "0xF2B408", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xF2B4EC", Offset = "0xF2B4EC", VA = "0xF2B4EC", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xF2B670", Offset = "0xF2B670", VA = "0xF2B670", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xF2AA54", Offset = "0xF2AA54", VA = "0xF2AA54")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xF26AB4", Offset = "0xF26AB4", VA = "0xF26AB4")]
		private void Read()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xF2A4F8", Offset = "0xF2A4F8", VA = "0xF2A4F8")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xF2B96C", Offset = "0xF2B96C", VA = "0xF2B96C")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xF2BC1C", Offset = "0xF2BC1C", VA = "0xF2BC1C")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xF297D0", Offset = "0xF297D0", VA = "0xF297D0")]
		public void FlagInternalCollisionsForUpdate()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xF2A648", Offset = "0xF2A648", VA = "0xF2A648")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xF2BF48", Offset = "0xF2BF48", VA = "0xF2BF48")]
		public void UpdateInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xF2BE74", Offset = "0xF2BE74", VA = "0xF2BE74")]
		private void IgnoreInternalCollisions()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xF2BFF8", Offset = "0xF2BFF8", VA = "0xF2BFF8")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xF2BD98", Offset = "0xF2BD98", VA = "0xF2BD98")]
		private void ResetInternalCollisions()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xF2C084", Offset = "0xF2C084", VA = "0xF2C084")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xF297EC", Offset = "0xF297EC", VA = "0xF297EC")]
		public void FlagAngularLimitsForUpdate()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xF2A680", Offset = "0xF2A680", VA = "0xF2A680")]
		private void UpdateAngularLimits()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xF2C120", Offset = "0xF2C120", VA = "0xF2C120")]
		public bool AddPropMuscle(ConfigurableJoint addPropMuscleTo, Vector3 position, Quaternion rotation, Vector3 additionalPinOffset, [Optional] Transform targetParent, [Optional] PuppetMasterProp initiateWithProp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xF23CD4", Offset = "0xF23CD4", VA = "0xF23CD4")]
		public bool IsDisconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xF23D10", Offset = "0xF23D10", VA = "0xF23D10")]
		public bool IsReconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xF235A8", Offset = "0xF235A8", VA = "0xF235A8")]
		public void DisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xF23D4C", Offset = "0xF23D4C", VA = "0xF23D4C")]
		public void ReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xF258C0", Offset = "0xF258C0", VA = "0xF258C0")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xF2CCDC", Offset = "0xF2CCDC", VA = "0xF2CCDC")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF2450C", Offset = "0xF2450C", VA = "0xF2450C")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xF2D02C", Offset = "0xF2D02C", VA = "0xF2D02C")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xF2D0D4", Offset = "0xF2D0D4", VA = "0xF2D0D4")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xF2D17C", Offset = "0xF2D17C", VA = "0xF2D17C")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xF2D224", Offset = "0xF2D224", VA = "0xF2D224")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xF2D2CC", Offset = "0xF2D2CC", VA = "0xF2D2CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858074", Offset = "0x858074")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xF2D3D8", Offset = "0xF2D3D8", VA = "0xF2D3D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8580AC", Offset = "0x8580AC")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xF2D548", Offset = "0xF2D548", VA = "0xF2D548")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8580E4", Offset = "0x8580E4")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xF2D680", Offset = "0xF2D680", VA = "0xF2D680")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85811C", Offset = "0x85811C")]
		public void FixMusclePositionsAndRotations()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xF296C4", Offset = "0xF296C4", VA = "0xF296C4")]
		public bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xF2C83C", Offset = "0xF2C83C", VA = "0xF2C83C")]
		private int GetHighestDisconnectedParentIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xF2A354", Offset = "0xF2A354", VA = "0xF2A354")]
		private void ProcessDisconnects()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xF2A450", Offset = "0xF2A450", VA = "0xF2A450")]
		private void ProcessReconnects()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xF2D7F0", Offset = "0xF2D7F0", VA = "0xF2D7F0")]
		private void OnDisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xF2DC34", Offset = "0xF2DC34", VA = "0xF2DC34")]
		private void DisconnectMuscle(Muscle m, bool sever, bool deactivate)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xF2DAB4", Offset = "0xF2DAB4", VA = "0xF2DAB4")]
		private void OnReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xF2E0CC", Offset = "0xF2E0CC", VA = "0xF2E0CC")]
		private void ReconnectMuscle(Muscle m)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xF2E4A0", Offset = "0xF2E4A0", VA = "0xF2E4A0")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xF2CEE0", Offset = "0xF2CEE0", VA = "0xF2CEE0")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xF2CFA8", Offset = "0xF2CFA8", VA = "0xF2CFA8")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xF2E60C", Offset = "0xF2E60C", VA = "0xF2E60C")]
		public void SwitchToActiveMode()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xF2E614", Offset = "0xF2E614", VA = "0xF2E614")]
		public void SwitchToKinematicMode()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xF2E620", Offset = "0xF2E620", VA = "0xF2E620")]
		public void SwitchToDisabledMode()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xF2E640", Offset = "0xF2E640", VA = "0xF2E640")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xF2E6DC", Offset = "0xF2E6DC", VA = "0xF2E6DC", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xF2E840", Offset = "0xF2E840", VA = "0xF2E840")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xF2E994", Offset = "0xF2E994", VA = "0xF2E994")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x858174", Offset = "0x858174")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xF2EA00", Offset = "0xF2EA00", VA = "0xF2EA00")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xF2EAA4", Offset = "0xF2EAA4", VA = "0xF2EAA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8581D4", Offset = "0x8581D4")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF2EB10", Offset = "0xF2EB10", VA = "0xF2EB10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x858234", Offset = "0x858234")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xF2EB7C", Offset = "0xF2EB7C", VA = "0xF2EB7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x858294", Offset = "0x858294")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF2EBE8", Offset = "0xF2EBE8", VA = "0xF2EBE8")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF2ECB8", Offset = "0xF2ECB8", VA = "0xF2ECB8")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF2F124", Offset = "0xF2F124", VA = "0xF2F124")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xF2F434", Offset = "0xF2F434", VA = "0xF2F434")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF2F564", Offset = "0xF2F564", VA = "0xF2F564")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF2F650", Offset = "0xF2F650", VA = "0xF2F650")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF2EF44", Offset = "0xF2EF44", VA = "0xF2EF44")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF2F6D8", Offset = "0xF2F6D8", VA = "0xF2F6D8")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF2C964", Offset = "0xF2C964", VA = "0xF2C964")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF22E34", Offset = "0xF22E34", VA = "0xF22E34")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF29D90", Offset = "0xF29D90", VA = "0xF29D90")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xF2F1AC", Offset = "0xF2F1AC", VA = "0xF2F1AC")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xF2ED40", Offset = "0xF2ED40", VA = "0xF2ED40")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF2F734", Offset = "0xF2F734", VA = "0xF2F734")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xF2CCE8", Offset = "0xF2CCE8", VA = "0xF2CCE8")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xF2F938", Offset = "0xF2F938", VA = "0xF2F938")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xF30644", Offset = "0xF30644", VA = "0xF30644")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xF2FA34", Offset = "0xF2FA34", VA = "0xF2FA34")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xF307B8", Offset = "0xF307B8", VA = "0xF307B8")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xF3103C", Offset = "0xF3103C", VA = "0xF3103C")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xF31AA4", Offset = "0xF31AA4", VA = "0xF31AA4")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF30C24", Offset = "0xF30C24", VA = "0xF30C24")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xF31794", Offset = "0xF31794", VA = "0xF31794")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xF31F5C", Offset = "0xF31F5C", VA = "0xF31F5C")]
		public void Kill()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xF31F68", Offset = "0xF31F68", VA = "0xF31F68")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xF31F84", Offset = "0xF31F84", VA = "0xF31F84")]
		public void Freeze()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xF31F90", Offset = "0xF31F90", VA = "0xF31F90")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xF31FAC", Offset = "0xF31FAC", VA = "0xF31FAC")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xF31FB4", Offset = "0xF31FB4", VA = "0xF31FB4", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xF320B4", Offset = "0xF320B4", VA = "0xF320B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x858314", Offset = "0x858314")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xF2AC00", Offset = "0xF2AC00", VA = "0xF2AC00")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xF32134", Offset = "0xF32134", VA = "0xF32134")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xF278D4", Offset = "0xF278D4", VA = "0xF278D4")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xF32244", Offset = "0xF32244", VA = "0xF32244")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xF32250", Offset = "0xF32250", VA = "0xF32250")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xF3246C", Offset = "0xF3246C", VA = "0xF3246C")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xF279D0", Offset = "0xF279D0", VA = "0xF279D0")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xF32540", Offset = "0xF32540", VA = "0xF32540")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF325FC", Offset = "0xF325FC", VA = "0xF325FC")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF326C8", Offset = "0xF326C8", VA = "0xF326C8")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xF29808", Offset = "0xF29808", VA = "0xF29808")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xF29428", Offset = "0xF29428", VA = "0xF29428")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xF32E6C", Offset = "0xF32E6C", VA = "0xF32E6C")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xF32D04", Offset = "0xF32D04", VA = "0xF32D04")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xF328E4", Offset = "0xF328E4", VA = "0xF328E4")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xF32EE4", Offset = "0xF32EE4", VA = "0xF32EE4")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xF33060", Offset = "0xF33060", VA = "0xF33060")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xF32BFC", Offset = "0xF32BFC", VA = "0xF32BFC")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF33350", Offset = "0xF33350", VA = "0xF33350")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xF334B0", Offset = "0xF334B0", VA = "0xF334B0")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xF33278", Offset = "0xF33278", VA = "0xF33278")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xF28A4C", Offset = "0xF28A4C", VA = "0xF28A4C")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xF2C9C0", Offset = "0xF2C9C0", VA = "0xF2C9C0")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xF2C8CC", Offset = "0xF2C8CC", VA = "0xF2C8CC")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF33710", Offset = "0xF33710", VA = "0xF33710")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x40002D6")]
		Sever,
		[Token(Token = "0x40002D7")]
		Explode,
		[Token(Token = "0x40002D8")]
		Numb
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public enum MuscleDisconnectMode
	{
		[Token(Token = "0x40002DA")]
		Sever,
		[Token(Token = "0x40002DB")]
		Explode
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x84A774", Offset = "0x84A774")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000060")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1BA6C28", Offset = "0x1BA6C28", VA = "0x1BA6C28")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84E920", Offset = "0x84E920")]
		public PuppetMaster.State state;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E958", Offset = "0x84E958")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84E958", Offset = "0x84E958")]
		public float mappingWeight;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E9AC", Offset = "0x84E9AC")]
		public float pinWeight;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E9C4", Offset = "0x84E9C4")]
		public float muscleWeight;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84E9DC", Offset = "0x84E9DC")]
		public float muscleSpring;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EA14", Offset = "0x84EA14")]
		public float pinPow;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EA2C", Offset = "0x84EA2C")]
		public float pinDistanceFalloff;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool angularPinning;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool updateJointAnchors;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool angularLimits;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool internalCollisions;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84EA48", Offset = "0x84EA48")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x17662D4", Offset = "0x17662D4", VA = "0x17662D4")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1766684", Offset = "0x1766684", VA = "0x1766684")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x17667B4", Offset = "0x17667B4", VA = "0x17667B4")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class PuppetMasterProp : MonoBehaviour
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EAB8", Offset = "0x84EAB8")]
		public Transform meshRoot;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EAF0", Offset = "0x84EAF0")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EB28", Offset = "0x84EB28")]
		public bool forceLayers;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EB60", Offset = "0x84EB60")]
		public float mass;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EB98", Offset = "0x84EB98")]
		public int propType;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84EBD0", Offset = "0x84EBD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EBD0", Offset = "0x84EBD0")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84EC30", Offset = "0x84EC30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EC30", Offset = "0x84EC30")]
		public Vector3 additionalPinOffsetAdd;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EC90", Offset = "0x84EC90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EC90", Offset = "0x84EC90")]
		public float additionalPinWeight;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84ECE4", Offset = "0x84ECE4")]
		public float additionalPinMass;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84ED1C", Offset = "0x84ED1C")]
		private bool <isPickedUp>k__BackingField;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84ED2C", Offset = "0x84ED2C")]
		private Muscle <propMuscle>k__BackingField;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int defaultLayer;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform defaultParent;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PhysicMaterial[] droppedMaterials;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody r;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _mass;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _drag;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _angularDrag;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _useGravity;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _isKinematic;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RigidbodyInterpolation _interpolation;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private CollisionDetectionMode _collisionDetectionMode;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RigidbodyConstraints _constraints;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] emptyColliders;

		[Token(Token = "0x1700005A")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1766884", Offset = "0x1766884", VA = "0x1766884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858504", Offset = "0x858504")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x176688C", Offset = "0x176688C", VA = "0x176688C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858514", Offset = "0x858514")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		protected Muscle propMuscle
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x1766944", Offset = "0x1766944", VA = "0x1766944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858524", Offset = "0x858524")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x176694C", Offset = "0x176694C", VA = "0x176694C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858534", Offset = "0x858534")]
			private set
			{
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1766898", Offset = "0x1766898", VA = "0x1766898")]
		public Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x176693C", Offset = "0x176693C", VA = "0x176693C", Slot = "4")]
		protected virtual void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1766940", Offset = "0x1766940", VA = "0x1766940", Slot = "5")]
		protected virtual void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1766954", Offset = "0x1766954", VA = "0x1766954")]
		public void PickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1766E6C", Offset = "0x1766E6C", VA = "0x1766E6C")]
		public void Drop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x176738C", Offset = "0x176738C", VA = "0x176738C", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x17674EC", Offset = "0x17674EC", VA = "0x17674EC", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1767720", Offset = "0x1767720", VA = "0x1767720", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1766D00", Offset = "0x1766D00", VA = "0x1766D00")]
		private void RemoveRigidbody()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1767240", Offset = "0x1767240", VA = "0x1767240")]
		private void ReattachRigidbody()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x176779C", Offset = "0x176779C", VA = "0x176779C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1767904", Offset = "0x1767904", VA = "0x1767904")]
		public PuppetMasterProp()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A7C8", Offset = "0x84A7C8")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x2000063")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EDA4", Offset = "0x84EDA4")]
			public int puppetsPerFrame;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1BA6DB8", Offset = "0x1BA6DB8", VA = "0x1BA6DB8")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x1BA6DE4", Offset = "0x1BA6DE4", VA = "0x1BA6DE4")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1BA6E00", Offset = "0x1BA6E00", VA = "0x1BA6E00")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84ED3C", Offset = "0x84ED3C")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84ED74", Offset = "0x84ED74")]
		private int <currentlyActivePuppets>k__BackingField;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84ED84", Offset = "0x84ED84")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84ED94", Offset = "0x84ED94")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x1700005C")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1767BF8", Offset = "0x1767BF8", VA = "0x1767BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858544", Offset = "0x858544")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1767C00", Offset = "0x1767C00", VA = "0x1767C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858554", Offset = "0x858554")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1767C08", Offset = "0x1767C08", VA = "0x1767C08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858564", Offset = "0x858564")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x1767C10", Offset = "0x1767C10", VA = "0x1767C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858574", Offset = "0x858574")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1767C18", Offset = "0x1767C18", VA = "0x1767C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858584", Offset = "0x858584")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1767C20", Offset = "0x1767C20", VA = "0x1767C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858594", Offset = "0x858594")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1767C28", Offset = "0x1767C28", VA = "0x1767C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1767C30", Offset = "0x1767C30", VA = "0x1767C30")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1767CD0", Offset = "0x1767CD0", VA = "0x1767CD0")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1767D34", Offset = "0x1767D34", VA = "0x1767D34")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1767D5C", Offset = "0x1767D5C", VA = "0x1767D5C")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1767D84", Offset = "0x1767D84", VA = "0x1767D84")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1767DAC", Offset = "0x1767DAC", VA = "0x1767DAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1767FA8", Offset = "0x1767FA8", VA = "0x1767FA8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1768000", Offset = "0x1768000", VA = "0x1768000")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1768124", Offset = "0x1768124", VA = "0x1768124")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x17686E4", Offset = "0x17686E4", VA = "0x17686E4")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1768FB8", Offset = "0x1768FB8", VA = "0x1768FB8")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1768FDC", Offset = "0x1768FDC", VA = "0x1768FDC")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		public enum Mode
		{
			[Token(Token = "0x400031D")]
			Float,
			[Token(Token = "0x400031E")]
			Curve
		}

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x185F8E4", Offset = "0x185F8E4", VA = "0x185F8E4")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x185F94C", Offset = "0x185F94C", VA = "0x185F94C")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x185F9C4", Offset = "0x185F9C4", VA = "0x185F9C4")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000067")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1C0AF68", Offset = "0x1C0AF68", VA = "0x1C0AF68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1C0AFCC", Offset = "0x1C0AFCC", VA = "0x1C0AFCC")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A800", Offset = "0x84A800")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A800", Offset = "0x84A800")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x2000069")]
		public struct Options
		{
			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84EDC0", Offset = "0x84EDC0")]
			public bool spine;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84EDF8", Offset = "0x84EDF8")]
			public JointType joints;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84EE30", Offset = "0x84EE30")]
			public float colliderLengthOverlap;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x17000060")]
			public static Options Default
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0x1861774", Offset = "0x1861774", VA = "0x1861774")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x195EC00", Offset = "0x195EC00", VA = "0x195EC00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8585A4", Offset = "0x8585A4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x195EC48", Offset = "0x195EC48", VA = "0x195EC48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8585DC", Offset = "0x8585DC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x195EC90", Offset = "0x195EC90", VA = "0x195EC90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858614", Offset = "0x858614")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x195ECD8", Offset = "0x195ECD8", VA = "0x195ECD8")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x195EF80", Offset = "0x195EF80", VA = "0x195EF80")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x195F0D4", Offset = "0x195F0D4", VA = "0x195F0D4")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x19608C0", Offset = "0x19608C0", VA = "0x19608C0")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1960AEC", Offset = "0x1960AEC", VA = "0x1960AEC")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1960EE0", Offset = "0x1960EE0", VA = "0x1960EE0")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x195FBB0", Offset = "0x195FBB0", VA = "0x195FBB0")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x196001C", Offset = "0x196001C", VA = "0x196001C")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1960FC0", Offset = "0x1960FC0", VA = "0x1960FC0")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1961570", Offset = "0x1961570", VA = "0x1961570")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x19615EC", Offset = "0x19615EC", VA = "0x19615EC")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1960810", Offset = "0x1960810", VA = "0x1960810")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x195EEE0", Offset = "0x195EEE0", VA = "0x195EEE0")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x19616F4", Offset = "0x19616F4", VA = "0x19616F4")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x191163C", Offset = "0x191163C", VA = "0x191163C")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1911E44", Offset = "0x1911E44", VA = "0x1911E44")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1911F40", Offset = "0x1911F40", VA = "0x1911F40")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x19122D8", Offset = "0x19122D8", VA = "0x19122D8")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1912674", Offset = "0x1912674", VA = "0x1912674")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x19129B0", Offset = "0x19129B0", VA = "0x19129B0")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1912BCC", Offset = "0x1912BCC", VA = "0x1912BCC")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x200006B")]
	public static class JointConverter
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1C14368", Offset = "0x1C14368", VA = "0x1C14368")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1C1489C", Offset = "0x1C1489C", VA = "0x1C1489C")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1C14B70", Offset = "0x1C14B70", VA = "0x1C14B70")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1C14CA4", Offset = "0x1C14CA4", VA = "0x1C14CA4")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1C14654", Offset = "0x1C14654", VA = "0x1C14654")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1C14E54", Offset = "0x1C14E54", VA = "0x1C14E54")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1C14F8C", Offset = "0x1C14F8C", VA = "0x1C14F8C")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1C15048", Offset = "0x1C15048", VA = "0x1C15048")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1C14FF0", Offset = "0x1C14FF0", VA = "0x1C14FF0")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1C150AC", Offset = "0x1C150AC", VA = "0x1C150AC")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1C1510C", Offset = "0x1C1510C", VA = "0x1C1510C")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x200006C")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006D")]
		public enum ColliderType
		{
			[Token(Token = "0x4000343")]
			Box,
			[Token(Token = "0x4000344")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x200006E")]
		public enum JointType
		{
			[Token(Token = "0x4000346")]
			Configurable,
			[Token(Token = "0x4000347")]
			Character
		}

		[Serializable]
		[Token(Token = "0x200006F")]
		public enum Direction
		{
			[Token(Token = "0x4000349")]
			X,
			[Token(Token = "0x400034A")]
			Y,
			[Token(Token = "0x400034B")]
			Z
		}

		[Token(Token = "0x2000070")]
		public struct CreateJointParams
		{
			[Token(Token = "0x2000071")]
			public struct Limits
			{
				[Token(Token = "0x4000352")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x4000353")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x4000354")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x4000355")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x60003A5")]
				[Address(RVA = "0x1BAA8F8", Offset = "0x1BAA8F8", VA = "0x1BAA8F8")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x1BA6F2C", Offset = "0x1BA6F2C", VA = "0x1BA6F2C")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1769DE0", Offset = "0x1769DE0", VA = "0x1769DE0")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1769FF4", Offset = "0x1769FF4", VA = "0x1769FF4")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x176A248", Offset = "0x176A248", VA = "0x176A248")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x176A630", Offset = "0x176A630", VA = "0x176A630")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x176A544", Offset = "0x176A544", VA = "0x176A544")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x176A954", Offset = "0x176A954", VA = "0x176A954")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x176A964", Offset = "0x176A964", VA = "0x176A964")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x176A980", Offset = "0x176A980", VA = "0x176A980")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x176A9A4", Offset = "0x176A9A4", VA = "0x176A9A4")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x176A574", Offset = "0x176A574", VA = "0x176A574")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x176A9C8", Offset = "0x176A9C8", VA = "0x176A9C8")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x176AB68", Offset = "0x176AB68", VA = "0x176AB68")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x176AD18", Offset = "0x176AD18", VA = "0x176AD18")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x176B2A4", Offset = "0x176B2A4", VA = "0x176B2A4")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x176B2D8", Offset = "0x176B2D8", VA = "0x176B2D8")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A860", Offset = "0x84A860")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A860", Offset = "0x84A860")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000073")]
		public enum Mode
		{
			[Token(Token = "0x400035B")]
			Colliders,
			[Token(Token = "0x400035C")]
			Joints
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x176B2E0", Offset = "0x176B2E0", VA = "0x176B2E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85864C", Offset = "0x85864C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x176B328", Offset = "0x176B328", VA = "0x176B328")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858684", Offset = "0x858684")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x176B370", Offset = "0x176B370", VA = "0x176B370")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8586BC", Offset = "0x8586BC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x176B3B8", Offset = "0x176B3B8", VA = "0x176B3B8")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A8C0", Offset = "0x84A8C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A8C0", Offset = "0x84A8C0")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x195A078", Offset = "0x195A078", VA = "0x195A078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8586F4", Offset = "0x8586F4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x195A0C0", Offset = "0x195A0C0", VA = "0x195A0C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85872C", Offset = "0x85872C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x195A108", Offset = "0x195A108", VA = "0x195A108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858764", Offset = "0x858764")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x195A150", Offset = "0x195A150", VA = "0x195A150")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85879C", Offset = "0x85879C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x195A198", Offset = "0x195A198", VA = "0x195A198")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x195A234", Offset = "0x195A234", VA = "0x195A234")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x195A254", Offset = "0x195A254", VA = "0x195A254")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x195A284", Offset = "0x195A284", VA = "0x195A284")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x195A2B4", Offset = "0x195A2B4", VA = "0x195A2B4")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x195A2F4", Offset = "0x195A2F4", VA = "0x195A2F4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x195A338", Offset = "0x195A338", VA = "0x195A338")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x195A35C", Offset = "0x195A35C", VA = "0x195A35C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x195A380", Offset = "0x195A380", VA = "0x195A380")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x195A3A8", Offset = "0x195A3A8", VA = "0x195A3A8")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x195A3D4", Offset = "0x195A3D4", VA = "0x195A3D4")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x195A400", Offset = "0x195A400", VA = "0x195A400")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x195A1B8", Offset = "0x195A1B8", VA = "0x195A1B8")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x195A428", Offset = "0x195A428", VA = "0x195A428")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x195A434", Offset = "0x195A434", VA = "0x195A434")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x195A440", Offset = "0x195A440", VA = "0x195A440")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x195A724", Offset = "0x195A724", VA = "0x195A724", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x195A7CC", Offset = "0x195A7CC", VA = "0x195A7CC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x195AAC0", Offset = "0x195AAC0", VA = "0x195AAC0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x195AC4C", Offset = "0x195AC4C", VA = "0x195AC4C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x195AC80", Offset = "0x195AC80", VA = "0x195AC80")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000061")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x195A5E0", Offset = "0x195A5E0", VA = "0x195A5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x195AE80", Offset = "0x195AE80", VA = "0x195AE80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x195A99C", Offset = "0x195A99C", VA = "0x195A99C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x195AD0C", Offset = "0x195AD0C", VA = "0x195AD0C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000063")]
		public bool isValid
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x191B998", Offset = "0x191B998", VA = "0x191B998")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C8")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x191BA04", Offset = "0x191BA04", VA = "0x191BA04")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x191BA0C", Offset = "0x191BA0C", VA = "0x191BA0C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x191BACC", Offset = "0x191BACC", VA = "0x191BACC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x191BAD4", Offset = "0x191BAD4", VA = "0x191BAD4")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000064")]
		private bool positionChanged
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x191BC08", Offset = "0x191BC08", VA = "0x191BC08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x191BB00", Offset = "0x191BB00", VA = "0x191BB00", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x191BC44", Offset = "0x191BC44", VA = "0x191BC44")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x191BC4C", Offset = "0x191BC4C", VA = "0x191BC4C")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x191BC78", Offset = "0x191BC78", VA = "0x191BC78", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x191BCF8", Offset = "0x191BCF8", VA = "0x191BCF8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x191BD00", Offset = "0x191BD00", VA = "0x191BD00")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000065")]
		private bool rotationChanged
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x191BE34", Offset = "0x191BE34", VA = "0x191BE34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x191BD2C", Offset = "0x191BD2C", VA = "0x191BD2C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x191BE70", Offset = "0x191BE70", VA = "0x191BE70")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x191BE78", Offset = "0x191BE78", VA = "0x191BE78")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class Constraints
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EEA8", Offset = "0x84EEA8")]
		public float positionWeight;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EEC0", Offset = "0x84EEC0")]
		public float rotationWeight;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x191BEA4", Offset = "0x191BEA4", VA = "0x191BEA4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x191BF10", Offset = "0x191BF10", VA = "0x191BF10")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x191BF64", Offset = "0x191BF64", VA = "0x191BF64")]
		public void Update()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x191C214", Offset = "0x191C214", VA = "0x191C214")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public enum DOF
		{
			[Token(Token = "0x4000391")]
			One,
			[Token(Token = "0x4000392")]
			Three
		}

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EED8", Offset = "0x84EED8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EED8", Offset = "0x84EED8")]
		public float weight;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EF2C", Offset = "0x84EF2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EF2C", Offset = "0x84EF2C")]
		public float rotationWeight;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EF80", Offset = "0x84EF80")]
		public DOF rotationDOF;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EFB8", Offset = "0x84EFB8")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EFF0", Offset = "0x84EFF0")]
		public Transform bone1;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F028", Offset = "0x84F028")]
		public Transform bone2;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F060", Offset = "0x84F060")]
		public Transform bone3;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F098", Offset = "0x84F098")]
		public Transform tip;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F0D0", Offset = "0x84F0D0")]
		public Transform target;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F108", Offset = "0x84F108")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000066")]
		public bool initiated
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1AEC72C", Offset = "0x1AEC72C", VA = "0x1AEC72C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8587D4", Offset = "0x8587D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1AEC734", Offset = "0x1AEC734", VA = "0x1AEC734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8587E4", Offset = "0x8587E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1AEC740", Offset = "0x1AEC740", VA = "0x1AEC740")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1AEC760", Offset = "0x1AEC760", VA = "0x1AEC760")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1AEC780", Offset = "0x1AEC780", VA = "0x1AEC780")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1AEC7A0", Offset = "0x1AEC7A0", VA = "0x1AEC7A0")]
			set
			{
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1AEC7C0", Offset = "0x1AEC7C0", VA = "0x1AEC7C0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1AEC8C8", Offset = "0x1AEC8C8", VA = "0x1AEC8C8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1AECD6C", Offset = "0x1AECD6C", VA = "0x1AECD6C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1AECE44", Offset = "0x1AECE44", VA = "0x1AECE44")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1AECF08", Offset = "0x1AECF08", VA = "0x1AECF08")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1AED450", Offset = "0x1AED450", VA = "0x1AED450")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F118", Offset = "0x84F118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F118", Offset = "0x84F118")]
		public float weight;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F16C", Offset = "0x84F16C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000069")]
		public bool initiated
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1AED460", Offset = "0x1AED460", VA = "0x1AED460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8587F4", Offset = "0x8587F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1AED468", Offset = "0x1AED468", VA = "0x1AED468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858804", Offset = "0x858804")]
			private set
			{
			}
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1AED474", Offset = "0x1AED474", VA = "0x1AED474")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1AED4FC", Offset = "0x1AED4FC", VA = "0x1AED4FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858814", Offset = "0x858814")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1AED834", Offset = "0x1AED834", VA = "0x1AED834")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1AED9AC", Offset = "0x1AED9AC", VA = "0x1AED9AC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1AED738", Offset = "0x1AED738", VA = "0x1AED738")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1AEDB1C", Offset = "0x1AEDB1C", VA = "0x1AEDB1C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1AEDBDC", Offset = "0x1AEDBDC", VA = "0x1AEDBDC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1AEDC54", Offset = "0x1AEDC54", VA = "0x1AEDC54")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1AEDCC8", Offset = "0x1AEDCC8", VA = "0x1AEDCC8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1AEDD30", Offset = "0x1AEDD30", VA = "0x1AEDD30", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1AEDD34", Offset = "0x1AEDD34", VA = "0x1AEDD34", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1AEDD48", Offset = "0x1AEDD48", VA = "0x1AEDD48")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000080")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F17C", Offset = "0x84F17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F17C", Offset = "0x84F17C")]
		public float weight;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F1D0", Offset = "0x84F1D0")]
		public Grounding solver;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F208", Offset = "0x84F208")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700006A")]
		public bool initiated
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1AEF6D4", Offset = "0x1AEF6D4", VA = "0x1AEF6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85884C", Offset = "0x85884C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1AEF6DC", Offset = "0x1AEF6DC", VA = "0x1AEF6DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85885C", Offset = "0x85885C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60003F6")]
		public abstract void ResetPosition();

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1AEF6E8", Offset = "0x1AEF6E8", VA = "0x1AEF6E8")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1AEF894", Offset = "0x1AEF894", VA = "0x1AEF894")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1AEF794", Offset = "0x1AEF794", VA = "0x1AEF794")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1AEF8C8", Offset = "0x1AEF8C8", VA = "0x1AEF8C8")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FD")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60003FE")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1AEFA04", Offset = "0x1AEFA04", VA = "0x1AEFA04")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A920", Offset = "0x84A920")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A920", Offset = "0x84A920")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F218", Offset = "0x84F218")]
		public BipedIK ik;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F250", Offset = "0x84F250")]
		public float spineBend;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F288", Offset = "0x84F288")]
		public float spineSpeed;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1AEFB14", Offset = "0x1AEFB14", VA = "0x1AEFB14", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85886C", Offset = "0x85886C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1AEFB5C", Offset = "0x1AEFB5C", VA = "0x1AEFB5C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8588A4", Offset = "0x8588A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1AEFBA4", Offset = "0x1AEFBA4", VA = "0x1AEFBA4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1AEFC6C", Offset = "0x1AEFC6C", VA = "0x1AEFC6C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1AEFD18", Offset = "0x1AEFD18", VA = "0x1AEFD18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1AEFD78", Offset = "0x1AEFD78", VA = "0x1AEFD78")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1AF02C0", Offset = "0x1AF02C0", VA = "0x1AF02C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1AF0314", Offset = "0x1AF0314", VA = "0x1AF0314")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1AF0950", Offset = "0x1AF0950", VA = "0x1AF0950")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1AF0A68", Offset = "0x1AF0A68", VA = "0x1AF0A68")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1AF0BA8", Offset = "0x1AF0BA8", VA = "0x1AF0BA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1AF0D38", Offset = "0x1AF0D38", VA = "0x1AF0D38")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A980", Offset = "0x84A980")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A980", Offset = "0x84A980")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public class SpineEffector
		{
			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F368", Offset = "0x84F368")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F3A0", Offset = "0x84F3A0")]
			public float horizontalWeight;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F3D8", Offset = "0x84F3D8")]
			public float verticalWeight;

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1862C94", Offset = "0x1862C94", VA = "0x1862C94")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1862CA4", Offset = "0x1862CA4", VA = "0x1862CA4")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F2C0", Offset = "0x84F2C0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F2F8", Offset = "0x84F2F8")]
		public float spineBend;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F330", Offset = "0x84F330")]
		public float spineSpeed;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1AF1170", Offset = "0x1AF1170", VA = "0x1AF1170")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8588DC", Offset = "0x8588DC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1AF11B8", Offset = "0x1AF11B8", VA = "0x1AF11B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858914", Offset = "0x858914")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1AF1200", Offset = "0x1AF1200", VA = "0x1AF1200", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85894C", Offset = "0x85894C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1AF1248", Offset = "0x1AF1248", VA = "0x1AF1248", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1AF1284", Offset = "0x1AF1284", VA = "0x1AF1284")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1AF1318", Offset = "0x1AF1318", VA = "0x1AF1318")]
		private void Update()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1AF1594", Offset = "0x1AF1594", VA = "0x1AF1594")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1AF15A0", Offset = "0x1AF15A0", VA = "0x1AF15A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1AF1380", Offset = "0x1AF1380", VA = "0x1AF1380")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1AF15AC", Offset = "0x1AF15AC", VA = "0x1AF15AC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1AF18C8", Offset = "0x1AF18C8", VA = "0x1AF18C8")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1AF19D8", Offset = "0x1AF19D8", VA = "0x1AF19D8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1AF1B30", Offset = "0x1AF1B30", VA = "0x1AF1B30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1AF1C44", Offset = "0x1AF1C44", VA = "0x1AF1C44")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84A9E0", Offset = "0x84A9E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84A9E0", Offset = "0x84A9E0")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F410", Offset = "0x84F410")]
		public Transform pelvis;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F448", Offset = "0x84F448")]
		public Transform characterRoot;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F480", Offset = "0x84F480")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F480", Offset = "0x84F480")]
		public float rootRotationWeight;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F4D4", Offset = "0x84F4D4")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F50C", Offset = "0x84F50C")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1AF1CCC", Offset = "0x1AF1CCC", VA = "0x1AF1CCC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858984", Offset = "0x858984")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1AF1D14", Offset = "0x1AF1D14", VA = "0x1AF1D14", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8589BC", Offset = "0x8589BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1AF1D5C", Offset = "0x1AF1D5C", VA = "0x1AF1D5C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1AF1D74", Offset = "0x1AF1D74", VA = "0x1AF1D74")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1AF1FA8", Offset = "0x1AF1FA8", VA = "0x1AF1FA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1AF20A4", Offset = "0x1AF20A4", VA = "0x1AF20A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1AF264C", Offset = "0x1AF264C", VA = "0x1AF264C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1AF2A54", Offset = "0x1AF2A54", VA = "0x1AF2A54")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1AF2BE0", Offset = "0x1AF2BE0", VA = "0x1AF2BE0")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1AF2EE4", Offset = "0x1AF2EE4", VA = "0x1AF2EE4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1AF3030", Offset = "0x1AF3030", VA = "0x1AF3030")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1AF3218", Offset = "0x1AF3218", VA = "0x1AF3218")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AA40", Offset = "0x84AA40")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AA40", Offset = "0x84AA40")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000086")]
		public struct Foot
		{
			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1862CEC", Offset = "0x1862CEC", VA = "0x1862CEC")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F544", Offset = "0x84F544")]
		public Grounding forelegSolver;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F57C", Offset = "0x84F57C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F57C", Offset = "0x84F57C")]
		public float rootRotationWeight;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F5D0", Offset = "0x84F5D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F5D0", Offset = "0x84F5D0")]
		public float minRootRotation;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F628", Offset = "0x84F628")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F628", Offset = "0x84F628")]
		public float maxRootRotation;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F680", Offset = "0x84F680")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F6B8", Offset = "0x84F6B8")]
		public float maxLegOffset;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F6F0", Offset = "0x84F6F0")]
		public float maxForeLegOffset;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F728", Offset = "0x84F728")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F728", Offset = "0x84F728")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F77C", Offset = "0x84F77C")]
		public Transform characterRoot;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F7B4", Offset = "0x84F7B4")]
		public Transform pelvis;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F7EC", Offset = "0x84F7EC")]
		public Transform lastSpineBone;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F824", Offset = "0x84F824")]
		public Transform head;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1AF32A0", Offset = "0x1AF32A0", VA = "0x1AF32A0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8589F4", Offset = "0x8589F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1AF32E8", Offset = "0x1AF32E8", VA = "0x1AF32E8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858A2C", Offset = "0x858A2C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1AF3330", Offset = "0x1AF3330", VA = "0x1AF3330", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1AF3364", Offset = "0x1AF3364", VA = "0x1AF3364")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1AF3490", Offset = "0x1AF3490", VA = "0x1AF3490")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1AF3694", Offset = "0x1AF3694", VA = "0x1AF3694")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1AF36FC", Offset = "0x1AF36FC", VA = "0x1AF36FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1AF3760", Offset = "0x1AF3760", VA = "0x1AF3760")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1AF3A8C", Offset = "0x1AF3A8C", VA = "0x1AF3A8C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1AF3DD0", Offset = "0x1AF3DD0", VA = "0x1AF3DD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1AF3EC8", Offset = "0x1AF3EC8", VA = "0x1AF3EC8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1AF4294", Offset = "0x1AF4294", VA = "0x1AF4294")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1AF48B0", Offset = "0x1AF48B0", VA = "0x1AF48B0")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1AF4A80", Offset = "0x1AF4A80", VA = "0x1AF4A80")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1AF4B5C", Offset = "0x1AF4B5C", VA = "0x1AF4B5C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1AF4DA4", Offset = "0x1AF4DA4", VA = "0x1AF4DA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1AF4DDC", Offset = "0x1AF4DDC", VA = "0x1AF4DDC")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1AF4FBC", Offset = "0x1AF4FBC", VA = "0x1AF4FBC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AAA0", Offset = "0x84AAA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AAA0", Offset = "0x84AAA0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F86C", Offset = "0x84F86C")]
		public VRIK ik;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1AF50BC", Offset = "0x1AF50BC", VA = "0x1AF50BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858A64", Offset = "0x858A64")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1AF5104", Offset = "0x1AF5104", VA = "0x1AF5104", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858A9C", Offset = "0x858A9C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1AF514C", Offset = "0x1AF514C", VA = "0x1AF514C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858AD4", Offset = "0x858AD4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1AF5194", Offset = "0x1AF5194", VA = "0x1AF5194", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1AF51AC", Offset = "0x1AF51AC", VA = "0x1AF51AC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1AF5240", Offset = "0x1AF5240", VA = "0x1AF5240")]
		private void Update()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1AF52A0", Offset = "0x1AF52A0", VA = "0x1AF52A0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1AF54C0", Offset = "0x1AF54C0", VA = "0x1AF54C0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1AF56B0", Offset = "0x1AF56B0", VA = "0x1AF56B0")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1AF5740", Offset = "0x1AF5740", VA = "0x1AF5740")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1AF58FC", Offset = "0x1AF58FC", VA = "0x1AF58FC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1AF5A54", Offset = "0x1AF5A54", VA = "0x1AF5A54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1AF5BD4", Offset = "0x1AF5BD4", VA = "0x1AF5BD4")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000089")]
		public enum Quality
		{
			[Token(Token = "0x40003F8")]
			Fastest,
			[Token(Token = "0x40003F9")]
			Simple,
			[Token(Token = "0x40003FA")]
			Best
		}

		[Token(Token = "0x200008A")]
		public class Leg
		{
			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD50", Offset = "0x84FD50")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD60", Offset = "0x84FD60")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD70", Offset = "0x84FD70")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD80", Offset = "0x84FD80")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD90", Offset = "0x84FD90")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FDA0", Offset = "0x84FDA0")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FDB0", Offset = "0x84FDB0")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FDC0", Offset = "0x84FDC0")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FDD0", Offset = "0x84FDD0")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000073")]
			public bool isGrounded
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x1862D2C", Offset = "0x1862D2C", VA = "0x1862D2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858BAC", Offset = "0x858BAC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x1862D34", Offset = "0x1862D34", VA = "0x1862D34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858BBC", Offset = "0x858BBC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x1862D40", Offset = "0x1862D40", VA = "0x1862D40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858BCC", Offset = "0x858BCC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x1862D4C", Offset = "0x1862D4C", VA = "0x1862D4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858BDC", Offset = "0x858BDC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public bool initiated
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x1862D58", Offset = "0x1862D58", VA = "0x1862D58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858BEC", Offset = "0x858BEC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000469")]
				[Address(RVA = "0x1862D60", Offset = "0x1862D60", VA = "0x1862D60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858BFC", Offset = "0x858BFC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public float heightFromGround
			{
				[Token(Token = "0x600046A")]
				[Address(RVA = "0x1862D6C", Offset = "0x1862D6C", VA = "0x1862D6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C0C", Offset = "0x858C0C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046B")]
				[Address(RVA = "0x1862D74", Offset = "0x1862D74", VA = "0x1862D74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C1C", Offset = "0x858C1C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 velocity
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x1862D7C", Offset = "0x1862D7C", VA = "0x1862D7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C2C", Offset = "0x858C2C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x1862D88", Offset = "0x1862D88", VA = "0x1862D88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C3C", Offset = "0x858C3C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public Transform transform
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x1862D94", Offset = "0x1862D94", VA = "0x1862D94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C4C", Offset = "0x858C4C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x1862D9C", Offset = "0x1862D9C", VA = "0x1862D9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C5C", Offset = "0x858C5C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public float IKOffset
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x1862DA4", Offset = "0x1862DA4", VA = "0x1862DA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C6C", Offset = "0x858C6C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x1862DAC", Offset = "0x1862DAC", VA = "0x1862DAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C7C", Offset = "0x858C7C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x1862DB4", Offset = "0x1862DB4", VA = "0x1862DB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C8C", Offset = "0x858C8C")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x1862DCC", Offset = "0x1862DCC", VA = "0x1862DCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858C9C", Offset = "0x858C9C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x1862DEC", Offset = "0x1862DEC", VA = "0x1862DEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858CAC", Offset = "0x858CAC")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x1862E04", Offset = "0x1862E04", VA = "0x1862E04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858CBC", Offset = "0x858CBC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x1862E24", Offset = "0x1862E24", VA = "0x1862E24")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700007D")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x1863E20", Offset = "0x1863E20", VA = "0x1863E20")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700007E")]
			private float rootYOffset
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x1863F84", Offset = "0x1863F84", VA = "0x1863F84")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1862E6C", Offset = "0x1862E6C", VA = "0x1862E6C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x1862E80", Offset = "0x1862E80", VA = "0x1862E80")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x1862EF4", Offset = "0x1862EF4", VA = "0x1862EF4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x1862F40", Offset = "0x1862F40", VA = "0x1862F40")]
			public void Reset()
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x1862FB0", Offset = "0x1862FB0", VA = "0x1862FB0")]
			public void Process()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1863A98", Offset = "0x1863A98", VA = "0x1863A98")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1863638", Offset = "0x1863638", VA = "0x1863638")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1863EB4", Offset = "0x1863EB4", VA = "0x1863EB4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x18638D4", Offset = "0x18638D4", VA = "0x18638D4")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x1863960", Offset = "0x1863960", VA = "0x1863960")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1863F24", Offset = "0x1863F24", VA = "0x1863F24")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x1863E48", Offset = "0x1863E48", VA = "0x1863E48")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1864018", Offset = "0x1864018", VA = "0x1864018")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x18640A4", Offset = "0x18640A4", VA = "0x18640A4")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200008B")]
		public class Pelvis
		{
			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FDE0", Offset = "0x84FDE0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FDF0", Offset = "0x84FDF0")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700007F")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x18640E8", Offset = "0x18640E8", VA = "0x18640E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858CCC", Offset = "0x858CCC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x18640F4", Offset = "0x18640F4", VA = "0x18640F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858CDC", Offset = "0x858CDC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public float heightOffset
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x1864100", Offset = "0x1864100", VA = "0x1864100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858CEC", Offset = "0x858CEC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600048A")]
				[Address(RVA = "0x1864108", Offset = "0x1864108", VA = "0x1864108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858CFC", Offset = "0x858CFC")]
				private set
				{
				}
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1864110", Offset = "0x1864110", VA = "0x1864110")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1864180", Offset = "0x1864180", VA = "0x1864180")]
			public void Reset()
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1864120", Offset = "0x1864120", VA = "0x1864120")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x18641EC", Offset = "0x18641EC", VA = "0x18641EC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x186438C", Offset = "0x186438C", VA = "0x186438C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F8A4", Offset = "0x84F8A4")]
		public LayerMask layers;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F8DC", Offset = "0x84F8DC")]
		public float maxStep;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F914", Offset = "0x84F914")]
		public float heightOffset;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F94C", Offset = "0x84F94C")]
		public float footSpeed;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F984", Offset = "0x84F984")]
		public float footRadius;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F9BC", Offset = "0x84F9BC")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FA08", Offset = "0x84FA08")]
		public float prediction;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FA40", Offset = "0x84FA40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FA40", Offset = "0x84FA40")]
		public float footRotationWeight;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FA94", Offset = "0x84FA94")]
		public float footRotationSpeed;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FACC", Offset = "0x84FACC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FACC", Offset = "0x84FACC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FB24", Offset = "0x84FB24")]
		public bool rotateSolver;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FB5C", Offset = "0x84FB5C")]
		public float pelvisSpeed;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FB94", Offset = "0x84FB94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FB94", Offset = "0x84FB94")]
		public float pelvisDamper;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FBE8", Offset = "0x84FBE8")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FC20", Offset = "0x84FC20")]
		public float liftPelvisWeight;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FC58", Offset = "0x84FC58")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FC90", Offset = "0x84FC90")]
		public bool overstepFallsDown;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FCC8", Offset = "0x84FCC8")]
		public Quality quality;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD00", Offset = "0x84FD00")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD10", Offset = "0x84FD10")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD20", Offset = "0x84FD20")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD30", Offset = "0x84FD30")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FD40", Offset = "0x84FD40")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700006B")]
		public Leg[] legs
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1AF5C2C", Offset = "0x1AF5C2C", VA = "0x1AF5C2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B0C", Offset = "0x858B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x1AF5C34", Offset = "0x1AF5C34", VA = "0x1AF5C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B1C", Offset = "0x858B1C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1AF5C3C", Offset = "0x1AF5C3C", VA = "0x1AF5C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B2C", Offset = "0x858B2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1AF5C44", Offset = "0x1AF5C44", VA = "0x1AF5C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B3C", Offset = "0x858B3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool isGrounded
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1AF5C4C", Offset = "0x1AF5C4C", VA = "0x1AF5C4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B4C", Offset = "0x858B4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1AF5C54", Offset = "0x1AF5C54", VA = "0x1AF5C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B5C", Offset = "0x858B5C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Transform root
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1AF5C60", Offset = "0x1AF5C60", VA = "0x1AF5C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B6C", Offset = "0x858B6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1AF5C68", Offset = "0x1AF5C68", VA = "0x1AF5C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B7C", Offset = "0x858B7C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1AF5C70", Offset = "0x1AF5C70", VA = "0x1AF5C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B8C", Offset = "0x858B8C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1AF5C88", Offset = "0x1AF5C88", VA = "0x1AF5C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x858B9C", Offset = "0x858B9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1AF5CA8", Offset = "0x1AF5CA8", VA = "0x1AF5CA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public Vector3 up
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1AF0A24", Offset = "0x1AF0A24", VA = "0x1AF0A24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000072")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1AF6068", Offset = "0x1AF6068", VA = "0x1AF6068")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1AF5CFC", Offset = "0x1AF5CFC", VA = "0x1AF5CFC")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1AF5F48", Offset = "0x1AF5F48", VA = "0x1AF5F48")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1AF0038", Offset = "0x1AF0038", VA = "0x1AF0038")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1AF0708", Offset = "0x1AF0708", VA = "0x1AF0708")]
		public void Update()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1AF24EC", Offset = "0x1AF24EC", VA = "0x1AF24EC")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1AEFBE0", Offset = "0x1AEFBE0", VA = "0x1AEFBE0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1AF6050", Offset = "0x1AF6050", VA = "0x1AF6050")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1AF60E8", Offset = "0x1AF60E8", VA = "0x1AF60E8")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1AF6178", Offset = "0x1AF6178", VA = "0x1AF6178")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1AF6234", Offset = "0x1AF6234", VA = "0x1AF6234")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1AEFAC0", Offset = "0x1AEFAC0", VA = "0x1AEFAC0")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AB00", Offset = "0x84AB00")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AB00", Offset = "0x84AB00")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x194F600", Offset = "0x194F600", VA = "0x194F600", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858D0C", Offset = "0x858D0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x194F648", Offset = "0x194F648", VA = "0x194F648", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858D44", Offset = "0x858D44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x194F690", Offset = "0x194F690", VA = "0x194F690")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858D7C", Offset = "0x858D7C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x194F6D8", Offset = "0x194F6D8", VA = "0x194F6D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858DB4", Offset = "0x858DB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x194F720", Offset = "0x194F720", VA = "0x194F720")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858DEC", Offset = "0x858DEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x194F768", Offset = "0x194F768", VA = "0x194F768", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x194F770", Offset = "0x194F770", VA = "0x194F770")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AB60", Offset = "0x84AB60")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AB60", Offset = "0x84AB60")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1951188", Offset = "0x1951188", VA = "0x1951188", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858E24", Offset = "0x858E24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x19511D0", Offset = "0x19511D0", VA = "0x19511D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858E5C", Offset = "0x858E5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1951218", Offset = "0x1951218", VA = "0x1951218")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858E94", Offset = "0x858E94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1951260", Offset = "0x1951260", VA = "0x1951260")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858ECC", Offset = "0x858ECC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x19512A8", Offset = "0x19512A8", VA = "0x19512A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x19512B0", Offset = "0x19512B0", VA = "0x19512B0")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84ABC0", Offset = "0x84ABC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84ABC0", Offset = "0x84ABC0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1916A08", Offset = "0x1916A08", VA = "0x1916A08", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858F04", Offset = "0x858F04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1916A50", Offset = "0x1916A50", VA = "0x1916A50", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858F3C", Offset = "0x858F3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1916A98", Offset = "0x1916A98", VA = "0x1916A98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858F74", Offset = "0x858F74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1916AE0", Offset = "0x1916AE0", VA = "0x1916AE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858FAC", Offset = "0x858FAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1916B28", Offset = "0x1916B28", VA = "0x1916B28", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1916B30", Offset = "0x1916B30", VA = "0x1916B30")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AC20", Offset = "0x84AC20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AC20", Offset = "0x84AC20")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x191DA84", Offset = "0x191DA84", VA = "0x191DA84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x858FE4", Offset = "0x858FE4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x191DACC", Offset = "0x191DACC", VA = "0x191DACC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85901C", Offset = "0x85901C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x191DB14", Offset = "0x191DB14", VA = "0x191DB14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859054", Offset = "0x859054")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x191DB5C", Offset = "0x191DB5C", VA = "0x191DB5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85908C", Offset = "0x85908C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x191DBA4", Offset = "0x191DBA4", VA = "0x191DBA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x191DBAC", Offset = "0x191DBAC", VA = "0x191DBAC")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AC80", Offset = "0x84AC80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AC80", Offset = "0x84AC80")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x191E0D0", Offset = "0x191E0D0", VA = "0x191E0D0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8590C4", Offset = "0x8590C4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x191E118", Offset = "0x191E118", VA = "0x191E118", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8590FC", Offset = "0x8590FC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x191E160", Offset = "0x191E160", VA = "0x191E160")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859134", Offset = "0x859134")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x191E1A8", Offset = "0x191E1A8", VA = "0x191E1A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85916C", Offset = "0x85916C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x191E1F0", Offset = "0x191E1F0", VA = "0x191E1F0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x191E1F8", Offset = "0x191E1F8", VA = "0x191E1F8")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84ACE0", Offset = "0x84ACE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84ACE0", Offset = "0x84ACE0")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1AEDDAC", Offset = "0x1AEDDAC", VA = "0x1AEDDAC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8591A4", Offset = "0x8591A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1AEDDF4", Offset = "0x1AEDDF4", VA = "0x1AEDDF4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8591DC", Offset = "0x8591DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1AEDE3C", Offset = "0x1AEDE3C", VA = "0x1AEDE3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859214", Offset = "0x859214")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1AEDE84", Offset = "0x1AEDE84", VA = "0x1AEDE84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85924C", Offset = "0x85924C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1AEDECC", Offset = "0x1AEDECC", VA = "0x1AEDECC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859284", Offset = "0x859284")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1AEDF14", Offset = "0x1AEDF14", VA = "0x1AEDF14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8592BC", Offset = "0x8592BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1AEDF5C", Offset = "0x1AEDF5C", VA = "0x1AEDF5C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1AEDF80", Offset = "0x1AEDF80", VA = "0x1AEDF80", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1AEDF88", Offset = "0x1AEDF88", VA = "0x1AEDF88")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1AEE164", Offset = "0x1AEE164", VA = "0x1AEE164")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1AEE3F8", Offset = "0x1AEE3F8", VA = "0x1AEE3F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8592F4", Offset = "0x8592F4")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1AEE418", Offset = "0x1AEE418", VA = "0x1AEE418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85932C", Offset = "0x85932C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1AEE4F0", Offset = "0x1AEE4F0", VA = "0x1AEE4F0")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60004BC")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1AF9760", Offset = "0x1AF9760", VA = "0x1AF9760", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1AF97E8", Offset = "0x1AF97E8", VA = "0x1AF97E8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1AF985C", Offset = "0x1AF985C", VA = "0x1AF985C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004C0")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60004C1")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1AEE580", Offset = "0x1AEE580", VA = "0x1AEE580")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FE00", Offset = "0x84FE00")]
		public IK[] IKComponents;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FE38", Offset = "0x84FE38")]
		public Animator animator;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000081")]
		private bool animatePhysics
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x1DC54B4", Offset = "0x1DC54B4", VA = "0x1DC54B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1DC554C", Offset = "0x1DC554C", VA = "0x1DC554C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1DC55BC", Offset = "0x1DC55BC", VA = "0x1DC55BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1DC5678", Offset = "0x1DC5678", VA = "0x1DC5678")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1DC56B4", Offset = "0x1DC56B4", VA = "0x1DC56B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1DC55F0", Offset = "0x1DC55F0", VA = "0x1DC55F0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1DC57B0", Offset = "0x1DC57B0", VA = "0x1DC57B0")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AD40", Offset = "0x84AD40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AD40", Offset = "0x84AD40")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1C15B7C", Offset = "0x1C15B7C", VA = "0x1C15B7C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859364", Offset = "0x859364")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1C15BC4", Offset = "0x1C15BC4", VA = "0x1C15BC4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85939C", Offset = "0x85939C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1C15C0C", Offset = "0x1C15C0C", VA = "0x1C15C0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8593D4", Offset = "0x8593D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1C15C54", Offset = "0x1C15C54", VA = "0x1C15C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85940C", Offset = "0x85940C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1C15C9C", Offset = "0x1C15C9C", VA = "0x1C15C9C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1C15CA4", Offset = "0x1C15CA4", VA = "0x1C15CA4")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84ADA0", Offset = "0x84ADA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84ADA0", Offset = "0x84ADA0")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xF15DD0", Offset = "0xF15DD0", VA = "0xF15DD0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859444", Offset = "0x859444")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xF15E18", Offset = "0xF15E18", VA = "0xF15E18", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85947C", Offset = "0x85947C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xF15E60", Offset = "0xF15E60", VA = "0xF15E60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8594B4", Offset = "0x8594B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xF15EA8", Offset = "0xF15EA8", VA = "0xF15EA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8594EC", Offset = "0x8594EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xF15EF0", Offset = "0xF15EF0", VA = "0xF15EF0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xF15EF8", Offset = "0xF15EF8", VA = "0xF15EF8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AE00", Offset = "0x84AE00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AE00", Offset = "0x84AE00")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xF168D0", Offset = "0xF168D0", VA = "0xF168D0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859524", Offset = "0x859524")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xF16918", Offset = "0xF16918", VA = "0xF16918", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85955C", Offset = "0x85955C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xF16960", Offset = "0xF16960", VA = "0xF16960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859594", Offset = "0x859594")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xF169A8", Offset = "0xF169A8", VA = "0xF169A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8595CC", Offset = "0x8595CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xF169F0", Offset = "0xF169F0", VA = "0xF169F0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xF169F8", Offset = "0xF169F8", VA = "0xF169F8")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AE60", Offset = "0x84AE60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AE60", Offset = "0x84AE60")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1774B44", Offset = "0x1774B44", VA = "0x1774B44", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859604", Offset = "0x859604")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1774B8C", Offset = "0x1774B8C", VA = "0x1774B8C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85963C", Offset = "0x85963C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1774BD4", Offset = "0x1774BD4", VA = "0x1774BD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859674", Offset = "0x859674")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1774C1C", Offset = "0x1774C1C", VA = "0x1774C1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8596AC", Offset = "0x8596AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1774C64", Offset = "0x1774C64", VA = "0x1774C64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1774C6C", Offset = "0x1774C6C", VA = "0x1774C6C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AEC0", Offset = "0x84AEC0")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000099")]
		public class References
		{
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FF24", Offset = "0x84FF24")]
			public Transform chest;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FF5C", Offset = "0x84FF5C")]
			public Transform neck;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FF94", Offset = "0x84FF94")]
			public Transform leftShoulder;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FFCC", Offset = "0x84FFCC")]
			public Transform rightShoulder;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850004", Offset = "0x850004")]
			public Transform leftThigh;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85003C", Offset = "0x85003C")]
			public Transform leftCalf;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850074", Offset = "0x850074")]
			public Transform leftFoot;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8500AC", Offset = "0x8500AC")]
			public Transform leftToes;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8500E4", Offset = "0x8500E4")]
			public Transform rightThigh;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85011C", Offset = "0x85011C")]
			public Transform rightCalf;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850154", Offset = "0x850154")]
			public Transform rightFoot;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85018C", Offset = "0x85018C")]
			public Transform rightToes;

			[Token(Token = "0x17000082")]
			public bool isFilled
			{
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x1BA936C", Offset = "0x1BA936C", VA = "0x1BA936C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000083")]
			public bool isEmpty
			{
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x1BA97E4", Offset = "0x1BA97E4", VA = "0x1BA97E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1BA8F24", Offset = "0x1BA8F24", VA = "0x1BA8F24")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x1BA9C5C", Offset = "0x1BA9C5C", VA = "0x1BA9C5C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x1BA9FF8", Offset = "0x1BA9FF8", VA = "0x1BA9FF8")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x84FE70", Offset = "0x84FE70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FE70", Offset = "0x84FE70")]
		public References references;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FEEC", Offset = "0x84FEEC")]
		public IKSolverVR solver;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x185B910", Offset = "0x185B910", VA = "0x185B910", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8596E4", Offset = "0x8596E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x185B958", Offset = "0x185B958", VA = "0x185B958", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85971C", Offset = "0x85971C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x185B9A0", Offset = "0x185B9A0", VA = "0x185B9A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859754", Offset = "0x859754")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x185B9E8", Offset = "0x185B9E8", VA = "0x185B9E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85978C", Offset = "0x85978C")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x185BA14", Offset = "0x185BA14", VA = "0x185BA14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8597C4", Offset = "0x8597C4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x185BA3C", Offset = "0x185BA3C", VA = "0x185BA3C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x185BA44", Offset = "0x185BA44", VA = "0x185BA44", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x185BAC4", Offset = "0x185BAC4", VA = "0x185BAC4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x185BC30", Offset = "0x185BC30", VA = "0x185BC30")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class FABRIKChain
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8501C4", Offset = "0x8501C4")]
		public float pull;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8501DC", Offset = "0x8501DC")]
		public float pin;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x191DC10", Offset = "0x191DC10", VA = "0x191DC10")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x191DCE0", Offset = "0x191DCE0", VA = "0x191DCE0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x191DD00", Offset = "0x191DD00", VA = "0x191DD00")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x191DF74", Offset = "0x191DF74", VA = "0x191DF74")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x191DDD4", Offset = "0x191DDD4", VA = "0x191DDD4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x191E06C", Offset = "0x191E06C", VA = "0x191E06C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x191E25C", Offset = "0x191E25C", VA = "0x191E25C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x191E6C0", Offset = "0x191E6C0", VA = "0x191E6C0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x191E87C", Offset = "0x191E87C", VA = "0x191E87C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x191E988", Offset = "0x191E988", VA = "0x191E988")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009D")]
		public class BendBone
		{
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850834", Offset = "0x850834")]
			public Transform transform;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85086C", Offset = "0x85086C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85086C", Offset = "0x85086C")]
			public float weight;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1862074", Offset = "0x1862074", VA = "0x1862074")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x18620B0", Offset = "0x18620B0", VA = "0x18620B0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x1862108", Offset = "0x1862108", VA = "0x1862108")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1862140", Offset = "0x1862140", VA = "0x1862140")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8501F4", Offset = "0x8501F4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85022C", Offset = "0x85022C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x85022C", Offset = "0x85022C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85022C", Offset = "0x85022C")]
		public float positionWeight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8502A4", Offset = "0x8502A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8502A4", Offset = "0x8502A4")]
		public float bodyWeight;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8502F8", Offset = "0x8502F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8502F8", Offset = "0x8502F8")]
		public float thighWeight;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85034C", Offset = "0x85034C")]
		public bool handsPullBody;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x850384", Offset = "0x850384")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850384", Offset = "0x850384")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850384", Offset = "0x850384")]
		public float rotationWeight;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8503FC", Offset = "0x8503FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8503FC", Offset = "0x8503FC")]
		public float bodyClampWeight;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850450", Offset = "0x850450")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850450", Offset = "0x850450")]
		public float headClampWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8504A4", Offset = "0x8504A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8504A4", Offset = "0x8504A4")]
		public float bendWeight;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8504F8", Offset = "0x8504F8")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x850530", Offset = "0x850530")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850530", Offset = "0x850530")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850530", Offset = "0x850530")]
		public float CCDWeight;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8505A8", Offset = "0x8505A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8505A8", Offset = "0x8505A8")]
		public float roll;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8505FC", Offset = "0x8505FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8505FC", Offset = "0x8505FC")]
		public float damper;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850654", Offset = "0x850654")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85068C", Offset = "0x85068C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85068C", Offset = "0x85068C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x85068C", Offset = "0x85068C")]
		public float postStretchWeight;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850704", Offset = "0x850704")]
		public float maxStretch;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85073C", Offset = "0x85073C")]
		public float stretchDamper;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850774", Offset = "0x850774")]
		public bool fixHead;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8507AC", Offset = "0x8507AC")]
		public Transform[] stretchBones;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8507E4", Offset = "0x8507E4")]
		public Vector3 chestDirection;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85081C", Offset = "0x85081C")]
		public float chestDirectionWeight;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x191E990", Offset = "0x191E990", VA = "0x191E990")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x191ECC4", Offset = "0x191ECC4", VA = "0x191ECC4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x191F164", Offset = "0x191F164", VA = "0x191F164")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x191F530", Offset = "0x191F530", VA = "0x191F530")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x191FCBC", Offset = "0x191FCBC", VA = "0x191FCBC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x191FF9C", Offset = "0x191FF9C", VA = "0x191FF9C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x19202A0", Offset = "0x19202A0", VA = "0x19202A0")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1920A74", Offset = "0x1920A74", VA = "0x1920A74")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x191FAA0", Offset = "0x191FAA0", VA = "0x191FAA0")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1920C3C", Offset = "0x1920C3C", VA = "0x1920C3C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x192098C", Offset = "0x192098C", VA = "0x192098C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x19208C0", Offset = "0x19208C0", VA = "0x19208C0")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1920EC0", Offset = "0x1920EC0", VA = "0x1920EC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1921190", Offset = "0x1921190", VA = "0x1921190")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850958", Offset = "0x850958")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850968", Offset = "0x850968")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000084")]
			public float nominalDistance
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x18621FC", Offset = "0x18621FC", VA = "0x18621FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8597FC", Offset = "0x8597FC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000521")]
				[Address(RVA = "0x1862204", Offset = "0x1862204", VA = "0x1862204")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85980C", Offset = "0x85980C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public bool isRigid
			{
				[Token(Token = "0x6000522")]
				[Address(RVA = "0x186220C", Offset = "0x186220C", VA = "0x186220C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85981C", Offset = "0x85981C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000523")]
				[Address(RVA = "0x1862214", Offset = "0x1862214", VA = "0x1862214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85982C", Offset = "0x85982C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1862220", Offset = "0x1862220", VA = "0x1862220")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x186226C", Offset = "0x186226C", VA = "0x186226C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x18622C4", Offset = "0x18622C4", VA = "0x18622C4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1862468", Offset = "0x1862468", VA = "0x1862468")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public enum Smoothing
		{
			[Token(Token = "0x400049C")]
			None,
			[Token(Token = "0x400049D")]
			Exponential,
			[Token(Token = "0x400049E")]
			Cubic
		}

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8508C0", Offset = "0x8508C0")]
		public float pin;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8508D8", Offset = "0x8508D8")]
		public float pull;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8508F0", Offset = "0x8508F0")]
		public float push;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850908", Offset = "0x850908")]
		public float pushParent;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850920", Offset = "0x850920")]
		public float reach;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000490")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x192183C", Offset = "0x192183C", VA = "0x192183C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1921928", Offset = "0x1921928", VA = "0x1921928")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1921A54", Offset = "0x1921A54", VA = "0x1921A54")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1921B80", Offset = "0x1921B80", VA = "0x1921B80")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1921C58", Offset = "0x1921C58", VA = "0x1921C58")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1921D70", Offset = "0x1921D70", VA = "0x1921D70")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x19223EC", Offset = "0x19223EC", VA = "0x19223EC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1921F00", Offset = "0x1921F00", VA = "0x1921F00")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x19227DC", Offset = "0x19227DC", VA = "0x19227DC")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1922A3C", Offset = "0x1922A3C", VA = "0x1922A3C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1922CA8", Offset = "0x1922CA8", VA = "0x1922CA8")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x192304C", Offset = "0x192304C", VA = "0x192304C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x19234E0", Offset = "0x19234E0", VA = "0x19234E0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1923704", Offset = "0x1923704", VA = "0x1923704")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1923470", Offset = "0x1923470", VA = "0x1923470")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1922ED8", Offset = "0x1922ED8", VA = "0x1922ED8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x19233F4", Offset = "0x19233F4", VA = "0x19233F4")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x19237EC", Offset = "0x19237EC", VA = "0x19237EC")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1923314", Offset = "0x1923314", VA = "0x1923314")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x19235EC", Offset = "0x19235EC", VA = "0x19235EC")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850978", Offset = "0x850978")]
		public float weight;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850990", Offset = "0x850990")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000086")]
		public bool initiated
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1AF9AA4", Offset = "0x1AF9AA4", VA = "0x1AF9AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85983C", Offset = "0x85983C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x1AF9AAC", Offset = "0x1AF9AAC", VA = "0x1AF9AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85984C", Offset = "0x85984C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1AF98BC", Offset = "0x1AF98BC", VA = "0x1AF98BC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1AF9AB8", Offset = "0x1AF9AB8", VA = "0x1AF9AB8")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1AF9AF8", Offset = "0x1AF9AF8", VA = "0x1AF9AF8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1AF9B58", Offset = "0x1AF9B58", VA = "0x1AF9B58")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1AF9B64", Offset = "0x1AF9B64", VA = "0x1AF9B64")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1AF9E78", Offset = "0x1AF9E78", VA = "0x1AF9E78")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1AFA068", Offset = "0x1AFA068", VA = "0x1AFA068")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1AFA3B4", Offset = "0x1AFA3B4", VA = "0x1AFA3B4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1AF9D28", Offset = "0x1AF9D28", VA = "0x1AF9D28")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1AF9DD0", Offset = "0x1AF9DD0", VA = "0x1AF9DD0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class IKEffector
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8509A0", Offset = "0x8509A0")]
		public float positionWeight;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8509B8", Offset = "0x8509B8")]
		public float rotationWeight;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8509D0", Offset = "0x8509D0")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8509E0", Offset = "0x8509E0")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000087")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1AFA850", Offset = "0x1AFA850", VA = "0x1AFA850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85985C", Offset = "0x85985C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1AFA858", Offset = "0x1AFA858", VA = "0x1AFA858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85986C", Offset = "0x85986C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1AFA7E8", Offset = "0x1AFA7E8", VA = "0x1AFA7E8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1AFA864", Offset = "0x1AFA864", VA = "0x1AFA864")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1AFA8F4", Offset = "0x1AFA8F4", VA = "0x1AFA8F4")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1AFAA08", Offset = "0x1AFAA08", VA = "0x1AFAA08")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1AFAB38", Offset = "0x1AFAB38", VA = "0x1AFAB38")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1AFAE54", Offset = "0x1AFAE54", VA = "0x1AFAE54")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1AFB0E8", Offset = "0x1AFB0E8", VA = "0x1AFB0E8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1AFB1BC", Offset = "0x1AFB1BC", VA = "0x1AFB1BC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1AFB264", Offset = "0x1AFB264", VA = "0x1AFB264")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1AFB7A0", Offset = "0x1AFB7A0", VA = "0x1AFB7A0")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1AFB7CC", Offset = "0x1AFB7CC", VA = "0x1AFB7CC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1AFB92C", Offset = "0x1AFB92C", VA = "0x1AFB92C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1AFBBB8", Offset = "0x1AFBBB8", VA = "0x1AFBBB8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public class BoneMap
		{
			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000088")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x18656F4", Offset = "0x18656F4", VA = "0x18656F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000089")]
			public bool isNodeBone
			{
				[Token(Token = "0x600054C")]
				[Address(RVA = "0x18657D0", Offset = "0x18657D0", VA = "0x18657D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008A")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0x1865B74", Offset = "0x1865B74", VA = "0x1865B74")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x18656C8", Offset = "0x18656C8", VA = "0x18656C8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1865730", Offset = "0x1865730", VA = "0x1865730")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x1865780", Offset = "0x1865780", VA = "0x1865780")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x18657E0", Offset = "0x18657E0", VA = "0x18657E0")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1865868", Offset = "0x1865868", VA = "0x1865868")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x1865870", Offset = "0x1865870", VA = "0x1865870")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x1865948", Offset = "0x1865948", VA = "0x1865948")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x18659C0", Offset = "0x18659C0", VA = "0x18659C0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x1865A58", Offset = "0x1865A58", VA = "0x1865A58")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x1865CB4", Offset = "0x1865CB4", VA = "0x1865CB4")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x1865CEC", Offset = "0x1865CEC", VA = "0x1865CEC")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x1865D24", Offset = "0x1865D24", VA = "0x1865D24")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x1865D4C", Offset = "0x1865D4C", VA = "0x1865D4C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x1865E38", Offset = "0x1865E38", VA = "0x1865E38")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x1865FC4", Offset = "0x1865FC4", VA = "0x1865FC4")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x1865FF4", Offset = "0x1865FF4", VA = "0x1865FF4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x18660BC", Offset = "0x18660BC", VA = "0x18660BC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x186612C", Offset = "0x186612C", VA = "0x186612C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x186627C", Offset = "0x186627C", VA = "0x186627C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x18663CC", Offset = "0x18663CC", VA = "0x18663CC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0x186644C", Offset = "0x186644C", VA = "0x186644C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0x1865EB4", Offset = "0x1865EB4", VA = "0x1865EB4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1866584", Offset = "0x1866584", VA = "0x1866584")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1DC57B8", Offset = "0x1DC57B8", VA = "0x1DC57B8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1DC57C0", Offset = "0x1DC57C0", VA = "0x1DC57C0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1DC57C4", Offset = "0x1DC57C4", VA = "0x1DC57C4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1DC5908", Offset = "0x1DC5908", VA = "0x1DC5908")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1DC5978", Offset = "0x1DC5978", VA = "0x1DC5978")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8509F8", Offset = "0x8509F8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1DC5980", Offset = "0x1DC5980", VA = "0x1DC5980", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1DC5A28", Offset = "0x1DC5A28", VA = "0x1DC5A28")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1DC5A94", Offset = "0x1DC5A94", VA = "0x1DC5A94")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1DC5B14", Offset = "0x1DC5B14", VA = "0x1DC5B14")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1DC5B30", Offset = "0x1DC5B30", VA = "0x1DC5B30")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1DC5B50", Offset = "0x1DC5B50", VA = "0x1DC5B50", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1DC5BD8", Offset = "0x1DC5BD8", VA = "0x1DC5BD8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1DC5BF4", Offset = "0x1DC5BF4", VA = "0x1DC5BF4")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public enum BoneMapType
		{
			[Token(Token = "0x40004F6")]
			Parent,
			[Token(Token = "0x40004F7")]
			Bone1,
			[Token(Token = "0x40004F8")]
			Bone2,
			[Token(Token = "0x40004F9")]
			Bone3
		}

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850A10", Offset = "0x850A10")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850A28", Offset = "0x850A28")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1DC5C1C", Offset = "0x1DC5C1C", VA = "0x1DC5C1C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1DC5CA0", Offset = "0x1DC5CA0", VA = "0x1DC5CA0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1DC5D7C", Offset = "0x1DC5D7C", VA = "0x1DC5D7C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1DC5FA0", Offset = "0x1DC5FA0", VA = "0x1DC5FA0")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1DC6064", Offset = "0x1DC6064", VA = "0x1DC6064")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1DC6154", Offset = "0x1DC6154", VA = "0x1DC6154")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1DC6160", Offset = "0x1DC6160", VA = "0x1DC6160")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1DC6214", Offset = "0x1DC6214", VA = "0x1DC6214")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1DC62D8", Offset = "0x1DC62D8", VA = "0x1DC62D8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1DC6518", Offset = "0x1DC6518", VA = "0x1DC6518")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1DC658C", Offset = "0x1DC658C", VA = "0x1DC658C")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850A40", Offset = "0x850A40")]
		public int iterations;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850A58", Offset = "0x850A58")]
		public float twistWeight;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1DC6764", Offset = "0x1DC6764", VA = "0x1DC6764", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1DC6AC8", Offset = "0x1DC6AC8", VA = "0x1DC6AC8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1DC6BAC", Offset = "0x1DC6BAC", VA = "0x1DC6BAC")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1DC6CC4", Offset = "0x1DC6CC4", VA = "0x1DC6CC4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1DC6CD4", Offset = "0x1DC6CD4", VA = "0x1DC6CD4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1DC6D40", Offset = "0x1DC6D40", VA = "0x1DC6D40")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1DC6DC4", Offset = "0x1DC6DC4", VA = "0x1DC6DC4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1DC739C", Offset = "0x1DC739C", VA = "0x1DC739C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1DC73D4", Offset = "0x1DC73D4", VA = "0x1DC73D4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1DC7658", Offset = "0x1DC7658", VA = "0x1DC7658")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1DC7958", Offset = "0x1DC7958", VA = "0x1DC7958")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1DC7A44", Offset = "0x1DC7A44", VA = "0x1DC7A44")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1DC7B0C", Offset = "0x1DC7B0C", VA = "0x1DC7B0C")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class Point
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B1C", Offset = "0x850B1C")]
			public float weight;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x18670E0", Offset = "0x18670E0", VA = "0x18670E0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1867130", Offset = "0x1867130", VA = "0x1867130")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x18671D0", Offset = "0x18671D0", VA = "0x18671D0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1867208", Offset = "0x1867208", VA = "0x1867208")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1867240", Offset = "0x1867240", VA = "0x1867240")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x1867290", Offset = "0x1867290", VA = "0x1867290")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1866C70", Offset = "0x1866C70", VA = "0x1866C70")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public class Bone : Point
		{
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700008C")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600059F")]
				[Address(RVA = "0x18665A0", Offset = "0x18665A0", VA = "0x18665A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005A0")]
				[Address(RVA = "0x186669C", Offset = "0x186669C", VA = "0x186669C")]
				set
				{
				}
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1866720", Offset = "0x1866720", VA = "0x1866720")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x18668D0", Offset = "0x18668D0", VA = "0x18668D0")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1866AA4", Offset = "0x1866AA4", VA = "0x1866AA4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1866C04", Offset = "0x1866C04", VA = "0x1866C04")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x1866C2C", Offset = "0x1866C2C", VA = "0x1866C2C")]
			public Bone()
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x1866CAC", Offset = "0x1866CAC", VA = "0x1866CAC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1866CFC", Offset = "0x1866CFC", VA = "0x1866CFC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public class Node : Point
		{
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x186707C", Offset = "0x186707C", VA = "0x186707C")]
			public Node()
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1867080", Offset = "0x1867080", VA = "0x1867080")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x18670A8", Offset = "0x18670A8", VA = "0x18670A8")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000AD")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000AE")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850A80", Offset = "0x850A80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850A80", Offset = "0x850A80")]
		public float IKPositionWeight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850AD4", Offset = "0x850AD4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x1700008B")]
		public bool initiated
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1DC7FB0", Offset = "0x1DC7FB0", VA = "0x1DC7FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85987C", Offset = "0x85987C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1DC7FB8", Offset = "0x1DC7FB8", VA = "0x1DC7FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85988C", Offset = "0x85988C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1DC7D6C", Offset = "0x1DC7D6C", VA = "0x1DC7D6C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000583")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1DC7DE4", Offset = "0x1DC7DE4", VA = "0x1DC7DE4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1DC5740", Offset = "0x1DC5740", VA = "0x1DC5740")]
		public void Update()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1DC7F58", Offset = "0x1DC7F58", VA = "0x1DC7F58", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1DC7F64", Offset = "0x1DC7F64", VA = "0x1DC7F64")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1DC7F70", Offset = "0x1DC7F70", VA = "0x1DC7F70")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1DC7F78", Offset = "0x1DC7F78", VA = "0x1DC7F78")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1DC7FA8", Offset = "0x1DC7FA8", VA = "0x1DC7FA8")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600058E")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600058F")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000590")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000591")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000592")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1DC7FC4", Offset = "0x1DC7FC4", VA = "0x1DC7FC4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1DC7FDC", Offset = "0x1DC7FDC", VA = "0x1DC7FDC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1DC8114", Offset = "0x1DC8114", VA = "0x1DC8114")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1DC81C0", Offset = "0x1DC81C0", VA = "0x1DC81C0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1DC8448", Offset = "0x1DC8448", VA = "0x1DC8448")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B34", Offset = "0x850B34")]
		public float poleWeight;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B4C", Offset = "0x850B4C")]
		public float clampWeight;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B64", Offset = "0x850B64")]
		public int clampSmoothing;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700008D")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1DC84DC", Offset = "0x1DC84DC", VA = "0x1DC84DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008E")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x1DC8518", Offset = "0x1DC8518", VA = "0x1DC8518")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008F")]
		protected override int minBones
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x1DC8FA8", Offset = "0x1DC8FA8", VA = "0x1DC8FA8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000090")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1DC938C", Offset = "0x1DC938C", VA = "0x1DC938C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1DC8460", Offset = "0x1DC8460", VA = "0x1DC8460")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1DC8554", Offset = "0x1DC8554", VA = "0x1DC8554", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1DC8774", Offset = "0x1DC8774", VA = "0x1DC8774", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1DC8EF4", Offset = "0x1DC8EF4", VA = "0x1DC8EF4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1DC8C84", Offset = "0x1DC8C84", VA = "0x1DC8C84")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1DC8FB0", Offset = "0x1DC8FB0", VA = "0x1DC8FB0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1DC9400", Offset = "0x1DC9400", VA = "0x1DC9400")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B7C", Offset = "0x850B7C")]
		public float IKRotationWeight;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1DC94C8", Offset = "0x1DC94C8", VA = "0x1DC94C8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1DC9868", Offset = "0x1DC9868", VA = "0x1DC9868")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1DC98D4", Offset = "0x1DC98D4", VA = "0x1DC98D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1DC9A2C", Offset = "0x1DC9A2C", VA = "0x1DC9A2C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1DC9BC0", Offset = "0x1DC9BC0", VA = "0x1DC9BC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1DC9C1C", Offset = "0x1DC9C1C", VA = "0x1DC9C1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1DC9C8C", Offset = "0x1DC9C8C", VA = "0x1DC9C8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1DC9FFC", Offset = "0x1DC9FFC", VA = "0x1DC9FFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1DCA028", Offset = "0x1DCA028", VA = "0x1DCA028")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1DC9CF0", Offset = "0x1DC9CF0", VA = "0x1DC9CF0")]
		private void Read()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1DCA094", Offset = "0x1DCA094", VA = "0x1DCA094")]
		private void Write()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1DCA220", Offset = "0x1DCA220", VA = "0x1DCA220")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1DCA384", Offset = "0x1DCA384", VA = "0x1DCA384")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1DCA434", Offset = "0x1DCA434", VA = "0x1DCA434", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1DCA92C", Offset = "0x1DCA92C", VA = "0x1DCA92C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1DCAF24", Offset = "0x1DCAF24", VA = "0x1DCAF24")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1DCB500", Offset = "0x1DCB500", VA = "0x1DCB500")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000091")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1DCC434", Offset = "0x1DCC434", VA = "0x1DCC434", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1DCB504", Offset = "0x1DCB504", VA = "0x1DCB504")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1DCBAC8", Offset = "0x1DCBAC8", VA = "0x1DCBAC8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1DCBC08", Offset = "0x1DCBC08", VA = "0x1DCBC08", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1DCBC9C", Offset = "0x1DCBC9C", VA = "0x1DCBC9C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1DCC174", Offset = "0x1DCC174", VA = "0x1DCC174", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1DCC43C", Offset = "0x1DCC43C", VA = "0x1DCC43C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1DCB5E0", Offset = "0x1DCB5E0", VA = "0x1DCB5E0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1DCBBB4", Offset = "0x1DCBBB4", VA = "0x1DCBBB4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1DCC3D8", Offset = "0x1DCC3D8", VA = "0x1DCC3D8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1DCB93C", Offset = "0x1DCB93C", VA = "0x1DCB93C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1DCCA8C", Offset = "0x1DCCA8C", VA = "0x1DCCA8C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1DCCB00", Offset = "0x1DCCB00", VA = "0x1DCCB00")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1DCCBC8", Offset = "0x1DCCBC8", VA = "0x1DCCBC8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1DCCC78", Offset = "0x1DCCC78", VA = "0x1DCCC78")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1DCBF24", Offset = "0x1DCBF24", VA = "0x1DCBF24")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1DCC04C", Offset = "0x1DCC04C", VA = "0x1DCC04C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1DCCD7C", Offset = "0x1DCCD7C", VA = "0x1DCCD7C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1DCC65C", Offset = "0x1DCC65C", VA = "0x1DCC65C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1DCBBA4", Offset = "0x1DCBBA4", VA = "0x1DCBBA4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1DCD30C", Offset = "0x1DCD30C", VA = "0x1DCD30C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1DCCEC0", Offset = "0x1DCCEC0", VA = "0x1DCCEC0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1DCC4B8", Offset = "0x1DCC4B8", VA = "0x1DCC4B8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1DCC598", Offset = "0x1DCC598", VA = "0x1DCC598")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1DCD3D8", Offset = "0x1DCD3D8", VA = "0x1DCD3D8")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B94", Offset = "0x850B94")]
		public float rootPin;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1DCD454", Offset = "0x1DCD454", VA = "0x1DCD454", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1DCDA94", Offset = "0x1DCDA94", VA = "0x1DCDA94", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1DCDB2C", Offset = "0x1DCDB2C", VA = "0x1DCDB2C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1DCDBCC", Offset = "0x1DCDBCC", VA = "0x1DCDBCC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1DCDCC8", Offset = "0x1DCDCC8", VA = "0x1DCDCC8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1DCDD64", Offset = "0x1DCDD64", VA = "0x1DCDD64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1DCE194", Offset = "0x1DCE194", VA = "0x1DCE194", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1DCE38C", Offset = "0x1DCE38C", VA = "0x1DCE38C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1DCE240", Offset = "0x1DCE240", VA = "0x1DCE240")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1DCDF50", Offset = "0x1DCDF50", VA = "0x1DCDF50")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1DCE424", Offset = "0x1DCE424", VA = "0x1DCE424")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850BAC", Offset = "0x850BAC")]
		public int iterations;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1DCE498", Offset = "0x1DCE498", VA = "0x1DCE498")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1DCE588", Offset = "0x1DCE588", VA = "0x1DCE588")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1DCE5E4", Offset = "0x1DCE5E4", VA = "0x1DCE5E4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1DC6708", Offset = "0x1DC6708", VA = "0x1DC6708")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1DCE714", Offset = "0x1DCE714", VA = "0x1DCE714")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1DCE794", Offset = "0x1DCE794", VA = "0x1DCE794", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1DCE938", Offset = "0x1DCE938", VA = "0x1DCE938", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1DCEAA8", Offset = "0x1DCEAA8", VA = "0x1DCEAA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1DCECB4", Offset = "0x1DCECB4", VA = "0x1DCECB4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1DCED8C", Offset = "0x1DCED8C", VA = "0x1DCED8C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1DCEE6C", Offset = "0x1DCEE6C", VA = "0x1DCEE6C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1DCEFE0", Offset = "0x1DCEFE0", VA = "0x1DCEFE0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1DCF138", Offset = "0x1DCF138", VA = "0x1DCF138", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1DCF384", Offset = "0x1DCF384", VA = "0x1DCF384", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1DCF660", Offset = "0x1DCF660", VA = "0x1DCF660", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1DCF6A4", Offset = "0x1DCF6A4", VA = "0x1DCF6A4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1DCF788", Offset = "0x1DCF788", VA = "0x1DCF788")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000552")]
		Body,
		[Token(Token = "0x4000553")]
		LeftShoulder,
		[Token(Token = "0x4000554")]
		RightShoulder,
		[Token(Token = "0x4000555")]
		LeftThigh,
		[Token(Token = "0x4000556")]
		RightThigh,
		[Token(Token = "0x4000557")]
		LeftHand,
		[Token(Token = "0x4000558")]
		RightHand,
		[Token(Token = "0x4000559")]
		LeftFoot,
		[Token(Token = "0x400055A")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400055C")]
		LeftArm,
		[Token(Token = "0x400055D")]
		RightArm,
		[Token(Token = "0x400055E")]
		LeftLeg,
		[Token(Token = "0x400055F")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850BC4", Offset = "0x850BC4")]
		public float spineStiffness;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850BDC", Offset = "0x850BDC")]
		public float pullBodyVertical;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850BF4", Offset = "0x850BF4")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850C0C", Offset = "0x850C0C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000092")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1DCF894", Offset = "0x1DCF894", VA = "0x1DCF894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1DCF9DC", Offset = "0x1DCF9DC", VA = "0x1DCF9DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1DCF9E4", Offset = "0x1DCF9E4", VA = "0x1DCF9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1DCF9EC", Offset = "0x1DCF9EC", VA = "0x1DCF9EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1DCF9F4", Offset = "0x1DCF9F4", VA = "0x1DCF9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1DCF9FC", Offset = "0x1DCF9FC", VA = "0x1DCF9FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1DCFA04", Offset = "0x1DCFA04", VA = "0x1DCFA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1DCFA0C", Offset = "0x1DCFA0C", VA = "0x1DCFA0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1DCFA14", Offset = "0x1DCFA14", VA = "0x1DCFA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1DCFA1C", Offset = "0x1DCFA1C", VA = "0x1DCFA1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x1DCFA54", Offset = "0x1DCFA54", VA = "0x1DCFA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1DCFA8C", Offset = "0x1DCFA8C", VA = "0x1DCFA8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1DCFAC4", Offset = "0x1DCFAC4", VA = "0x1DCFAC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1DCFAFC", Offset = "0x1DCFAFC", VA = "0x1DCFAFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1DCFB30", Offset = "0x1DCFB30", VA = "0x1DCFB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1DCFB68", Offset = "0x1DCFB68", VA = "0x1DCFB68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1DCFBA0", Offset = "0x1DCFBA0", VA = "0x1DCFBA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1DCFBD8", Offset = "0x1DCFBD8", VA = "0x1DCFBD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1DD1A58", Offset = "0x1DD1A58", VA = "0x1DD1A58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85989C", Offset = "0x85989C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1DD1A64", Offset = "0x1DD1A64", VA = "0x1DD1A64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8598AC", Offset = "0x8598AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1DCFC0C", Offset = "0x1DCFC0C", VA = "0x1DCFC0C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1DCFD18", Offset = "0x1DCFD18", VA = "0x1DCFD18")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1DCFC60", Offset = "0x1DCFC60", VA = "0x1DCFC60")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1DCFDA4", Offset = "0x1DCFDA4", VA = "0x1DCFDA4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1DCF89C", Offset = "0x1DCF89C", VA = "0x1DCF89C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1DCFE74", Offset = "0x1DCFE74", VA = "0x1DCFE74")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1DCFF2C", Offset = "0x1DCFF2C", VA = "0x1DCFF2C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1DCFFE0", Offset = "0x1DCFFE0", VA = "0x1DCFFE0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1DD0094", Offset = "0x1DD0094", VA = "0x1DD0094")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1DD009C", Offset = "0x1DD009C", VA = "0x1DD009C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1DD00D0", Offset = "0x1DD00D0", VA = "0x1DD00D0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1DD0198", Offset = "0x1DD0198", VA = "0x1DD0198", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1DD033C", Offset = "0x1DD033C", VA = "0x1DD033C")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1DD14D8", Offset = "0x1DD14D8", VA = "0x1DD14D8")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1DD18EC", Offset = "0x1DD18EC", VA = "0x1DD18EC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1DD194C", Offset = "0x1DD194C", VA = "0x1DD194C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1DD1774", Offset = "0x1DD1774", VA = "0x1DD1774")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1DD1830", Offset = "0x1DD1830", VA = "0x1DD1830")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1DD1A70", Offset = "0x1DD1A70", VA = "0x1DD1A70")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1DD1B48", Offset = "0x1DD1B48", VA = "0x1DD1B48", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1DD1C44", Offset = "0x1DD1C44", VA = "0x1DD1C44")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1DD1D6C", Offset = "0x1DD1D6C", VA = "0x1DD1D6C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1DD1EB0", Offset = "0x1DD1EB0", VA = "0x1DD1EB0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1DD1FE0", Offset = "0x1DD1FE0", VA = "0x1DD1FE0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1DD2220", Offset = "0x1DD2220", VA = "0x1DD2220", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1DD22A4", Offset = "0x1DD22A4", VA = "0x1DD22A4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000A5")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x1DD2B04", Offset = "0x1DD2B04", VA = "0x1DD2B04", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A6")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x1DD2B0C", Offset = "0x1DD2B0C", VA = "0x1DD2B0C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x1DD2B14", Offset = "0x1DD2B14", VA = "0x1DD2B14", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1DD2B24", Offset = "0x1DD2B24", VA = "0x1DD2B24", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A9")]
		protected float positionOffset
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1DCAED0", Offset = "0x1DCAED0", VA = "0x1DCAED0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1DD22B0", Offset = "0x1DD22B0", VA = "0x1DD22B0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1DD2448", Offset = "0x1DD2448", VA = "0x1DD2448")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1DD2580", Offset = "0x1DD2580", VA = "0x1DD2580", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1DD25EC", Offset = "0x1DD25EC", VA = "0x1DD25EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1DD266C", Offset = "0x1DD266C", VA = "0x1DD266C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1DD2A0C", Offset = "0x1DD2A0C", VA = "0x1DD2A0C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1DD2A14", Offset = "0x1DD2A14", VA = "0x1DD2A14", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1DD2B1C", Offset = "0x1DD2B1C", VA = "0x1DD2B1C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1DD2B20", Offset = "0x1DD2B20", VA = "0x1DD2B20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1DCA4B4", Offset = "0x1DCA4B4", VA = "0x1DCA4B4")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1DCABB8", Offset = "0x1DCABB8", VA = "0x1DCABB8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1DD2BEC", Offset = "0x1DD2BEC", VA = "0x1DD2BEC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1DC9450", Offset = "0x1DC9450", VA = "0x1DC9450")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850C1C", Offset = "0x850C1C")]
		public float IKRotationWeight;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1DD2DE0", Offset = "0x1DD2DE0", VA = "0x1DD2DE0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1DD3180", Offset = "0x1DD3180", VA = "0x1DD3180")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1DD31EC", Offset = "0x1DD31EC", VA = "0x1DD31EC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1DD3344", Offset = "0x1DD3344", VA = "0x1DD3344", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1DD34D8", Offset = "0x1DD34D8", VA = "0x1DD34D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1DD3534", Offset = "0x1DD3534", VA = "0x1DD3534", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1DD35A4", Offset = "0x1DD35A4", VA = "0x1DD35A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1DD3914", Offset = "0x1DD3914", VA = "0x1DD3914", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1DD3940", Offset = "0x1DD3940", VA = "0x1DD3940")]
		private void Solve()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1DD3608", Offset = "0x1DD3608", VA = "0x1DD3608")]
		private void Read()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1DD39D4", Offset = "0x1DD39D4", VA = "0x1DD39D4")]
		private void Write()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1DD3B60", Offset = "0x1DD3B60", VA = "0x1DD3B60")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public enum BendModifier
		{
			[Token(Token = "0x400058A")]
			Animation,
			[Token(Token = "0x400058B")]
			Target,
			[Token(Token = "0x400058C")]
			Parent,
			[Token(Token = "0x400058D")]
			Arm,
			[Token(Token = "0x400058E")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public struct AxisDirection
		{
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1867524", Offset = "0x1867524", VA = "0x1867524")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850C34", Offset = "0x850C34")]
		public float maintainRotationWeight;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850C4C", Offset = "0x850C4C")]
		public float bendModifierWeight;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000AA")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1DD4D28", Offset = "0x1DD4D28", VA = "0x1DD4D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1DD3CC4", Offset = "0x1DD3CC4", VA = "0x1DD3CC4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1DD3D14", Offset = "0x1DD3D14", VA = "0x1DD3D14")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1DD3D60", Offset = "0x1DD3D60", VA = "0x1DD3D60", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1DD4234", Offset = "0x1DD4234", VA = "0x1DD4234", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1DD4B80", Offset = "0x1DD4B80", VA = "0x1DD4B80", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1DD4C2C", Offset = "0x1DD4C2C", VA = "0x1DD4C2C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1DD4CA0", Offset = "0x1DD4CA0", VA = "0x1DD4CA0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1DD405C", Offset = "0x1DD405C", VA = "0x1DD405C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1DD4318", Offset = "0x1DD4318", VA = "0x1DD4318")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000BE")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x170000B1")]
			public Vector3 forward
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0x18677B0", Offset = "0x18677B0", VA = "0x18677B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1867584", Offset = "0x1867584", VA = "0x1867584")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1867588", Offset = "0x1867588", VA = "0x1867588")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x18675B0", Offset = "0x18675B0", VA = "0x18675B0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x18676A8", Offset = "0x18676A8", VA = "0x18676A8")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850C64", Offset = "0x850C64")]
		public float bodyWeight;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850C7C", Offset = "0x850C7C")]
		public float headWeight;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850C94", Offset = "0x850C94")]
		public float eyesWeight;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850CAC", Offset = "0x850CAC")]
		public float clampWeight;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850CC4", Offset = "0x850CC4")]
		public float clampWeightHead;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850CDC", Offset = "0x850CDC")]
		public float clampWeightEyes;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850CF4", Offset = "0x850CF4")]
		public int clampSmoothing;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x170000AB")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1DD54C0", Offset = "0x1DD54C0", VA = "0x1DD54C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1DD5690", Offset = "0x1DD5690", VA = "0x1DD5690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		protected bool headIsValid
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1DD55A0", Offset = "0x1DD55A0", VA = "0x1DD55A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1DD56B4", Offset = "0x1DD56B4", VA = "0x1DD56B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1DD55B0", Offset = "0x1DD55B0", VA = "0x1DD55B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1DD572C", Offset = "0x1DD572C", VA = "0x1DD572C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1DD4D44", Offset = "0x1DD4D44", VA = "0x1DD4D44")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1DD4D74", Offset = "0x1DD4D74", VA = "0x1DD4D74")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1DD4DCC", Offset = "0x1DD4DCC", VA = "0x1DD4DCC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1DD4E48", Offset = "0x1DD4E48", VA = "0x1DD4E48")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1DD4EE0", Offset = "0x1DD4EE0", VA = "0x1DD4EE0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1DD4FA0", Offset = "0x1DD4FA0", VA = "0x1DD4FA0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1DD509C", Offset = "0x1DD509C", VA = "0x1DD509C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1DD51C8", Offset = "0x1DD51C8", VA = "0x1DD51C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1DD5308", Offset = "0x1DD5308", VA = "0x1DD5308", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1DD5750", Offset = "0x1DD5750", VA = "0x1DD5750", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1DD5990", Offset = "0x1DD5990", VA = "0x1DD5990", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1DD5B2C", Offset = "0x1DD5B2C", VA = "0x1DD5B2C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1DD5D58", Offset = "0x1DD5D58", VA = "0x1DD5D58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1DD602C", Offset = "0x1DD602C", VA = "0x1DD602C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1DD60FC", Offset = "0x1DD60FC", VA = "0x1DD60FC")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1DD629C", Offset = "0x1DD629C", VA = "0x1DD629C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1DD64C0", Offset = "0x1DD64C0", VA = "0x1DD64C0")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1DD6874", Offset = "0x1DD6874", VA = "0x1DD6874")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1DD5BD4", Offset = "0x1DD5BD4", VA = "0x1DD5BD4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1DD6AE4", Offset = "0x1DD6AE4", VA = "0x1DD6AE4")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BF")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x18677EC", Offset = "0x18677EC", VA = "0x18677EC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x18678E8", Offset = "0x18678E8", VA = "0x18678E8")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1867918", Offset = "0x1867918", VA = "0x1867918")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1867954", Offset = "0x1867954", VA = "0x1867954")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850D0C", Offset = "0x850D0C")]
		public float IKRotationWeight;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1C0567C", Offset = "0x1C0567C", VA = "0x1C0567C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1C057D8", Offset = "0x1C057D8", VA = "0x1C057D8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1C0591C", Offset = "0x1C0591C", VA = "0x1C0591C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1C05928", Offset = "0x1C05928", VA = "0x1C05928")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1C05958", Offset = "0x1C05958", VA = "0x1C05958")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1C05964", Offset = "0x1C05964", VA = "0x1C05964")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1C0596C", Offset = "0x1C0596C", VA = "0x1C0596C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1C05A6C", Offset = "0x1C05A6C", VA = "0x1C05A6C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1C05B88", Offset = "0x1C05B88", VA = "0x1C05B88", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1C05BD4", Offset = "0x1C05BD4", VA = "0x1C05BD4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1C05C34", Offset = "0x1C05C34", VA = "0x1C05C34", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1C05FFC", Offset = "0x1C05FFC", VA = "0x1C05FFC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1C06054", Offset = "0x1C06054", VA = "0x1C06054")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1C06410", Offset = "0x1C06410", VA = "0x1C06410")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1C06578", Offset = "0x1C06578", VA = "0x1C06578", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1C066E0", Offset = "0x1C066E0", VA = "0x1C066E0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1C06654", Offset = "0x1C06654", VA = "0x1C06654")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1C067E4", Offset = "0x1C067E4", VA = "0x1C067E4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1C06FB8", Offset = "0x1C06FB8", VA = "0x1C06FB8", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1C06FBC", Offset = "0x1C06FBC", VA = "0x1C06FBC", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1C06FC0", Offset = "0x1C06FC0", VA = "0x1C06FC0", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1C06DD0", Offset = "0x1C06DD0", VA = "0x1C06DD0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1C06FC4", Offset = "0x1C06FC4", VA = "0x1C06FC4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000C3")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40005F0")]
				YawPitch,
				[Token(Token = "0x40005F1")]
				FromTo
			}

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850F10", Offset = "0x850F10")]
			public Transform target;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850F48", Offset = "0x850F48")]
			public Transform bendGoal;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850F80", Offset = "0x850F80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850F80", Offset = "0x850F80")]
			public float positionWeight;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850FD4", Offset = "0x850FD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850FD4", Offset = "0x850FD4")]
			public float rotationWeight;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851028", Offset = "0x851028")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851060", Offset = "0x851060")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851060", Offset = "0x851060")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8510B4", Offset = "0x8510B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8510B4", Offset = "0x8510B4")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851108", Offset = "0x851108")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851108", Offset = "0x851108")]
			public float bendGoalWeight;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85115C", Offset = "0x85115C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85115C", Offset = "0x85115C")]
			public float swivelOffset;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8511B8", Offset = "0x8511B8")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8511F0", Offset = "0x8511F0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851228", Offset = "0x851228")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851228", Offset = "0x851228")]
			public float armLengthMlp;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851280", Offset = "0x851280")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8512F8", Offset = "0x8512F8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851308", Offset = "0x851308")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x40005ED")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40005EE")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000B3")]
			public Vector3 position
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x1867958", Offset = "0x1867958", VA = "0x1867958")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8598DC", Offset = "0x8598DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006B4")]
				[Address(RVA = "0x1867964", Offset = "0x1867964", VA = "0x1867964")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8598EC", Offset = "0x8598EC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006B5")]
				[Address(RVA = "0x1867970", Offset = "0x1867970", VA = "0x1867970")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8598FC", Offset = "0x8598FC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0x186797C", Offset = "0x186797C", VA = "0x186797C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85990C", Offset = "0x85990C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x1867988", Offset = "0x1867988", VA = "0x1867988")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x18679BC", Offset = "0x18679BC", VA = "0x18679BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x18679FC", Offset = "0x18679FC", VA = "0x18679FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x1867A48", Offset = "0x1867A48", VA = "0x1867A48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1867A94", Offset = "0x1867A94", VA = "0x1867A94", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x18682BC", Offset = "0x18682BC", VA = "0x18682BC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1868478", Offset = "0x1868478", VA = "0x1868478", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x186849C", Offset = "0x186849C", VA = "0x186849C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x186873C", Offset = "0x186873C", VA = "0x186873C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1869C98", Offset = "0x1869C98", VA = "0x1869C98", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1869CC4", Offset = "0x1869CC4", VA = "0x1869CC4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x18696D4", Offset = "0x18696D4", VA = "0x18696D4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1869750", Offset = "0x1869750", VA = "0x1869750")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1869EE4", Offset = "0x1869EE4", VA = "0x1869EE4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x186A008", Offset = "0x186A008", VA = "0x186A008")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851318", Offset = "0x851318")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851328", Offset = "0x851328")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x170000B9")]
			public float sqrMag
			{
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x186A160", Offset = "0x186A160", VA = "0x186A160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85991C", Offset = "0x85991C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x186A168", Offset = "0x186A168", VA = "0x186A168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85992C", Offset = "0x85992C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BA")]
			public float mag
			{
				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x186A170", Offset = "0x186A170", VA = "0x186A170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85993C", Offset = "0x85993C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x186A178", Offset = "0x186A178", VA = "0x186A178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85994C", Offset = "0x85994C")]
				private set
				{
				}
			}

			[Token(Token = "0x60006C6")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60006C7")]
			public abstract void PreSolve();

			[Token(Token = "0x60006C8")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006C9")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60006CA")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x186A180", Offset = "0x186A180", VA = "0x186A180")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x186A188", Offset = "0x186A188", VA = "0x186A188")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x186A25C", Offset = "0x186A25C", VA = "0x186A25C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x186A2F0", Offset = "0x186A2F0", VA = "0x186A2F0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x186A39C", Offset = "0x186A39C", VA = "0x186A39C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x186A3F0", Offset = "0x186A3F0", VA = "0x186A3F0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1869B54", Offset = "0x1869B54", VA = "0x1869B54")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x186A52C", Offset = "0x186A52C", VA = "0x186A52C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x186A66C", Offset = "0x186A66C", VA = "0x186A66C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x186A0EC", Offset = "0x186A0EC", VA = "0x186A0EC")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class Footstep
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851348", Offset = "0x851348")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000BB")]
			public bool isStepping
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x186A694", Offset = "0x186A694", VA = "0x186A694")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BC")]
			public float stepProgress
			{
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x186A6A8", Offset = "0x186A6A8", VA = "0x186A6A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85995C", Offset = "0x85995C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0x186A6B0", Offset = "0x186A6B0", VA = "0x186A6B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85996C", Offset = "0x85996C")]
				private set
				{
				}
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x186A6B8", Offset = "0x186A6B8", VA = "0x186A6B8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x186A7F0", Offset = "0x186A7F0", VA = "0x186A7F0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x186A838", Offset = "0x186A838", VA = "0x186A838")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x186A9FC", Offset = "0x186A9FC", VA = "0x186A9FC")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x186AB70", Offset = "0x186AB70", VA = "0x186AB70")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x186ACC8", Offset = "0x186ACC8", VA = "0x186ACC8")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C6")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851358", Offset = "0x851358")]
			public Transform target;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851390", Offset = "0x851390")]
			public Transform bendGoal;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8513C8", Offset = "0x8513C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8513C8", Offset = "0x8513C8")]
			public float positionWeight;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85141C", Offset = "0x85141C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85141C", Offset = "0x85141C")]
			public float rotationWeight;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851470", Offset = "0x851470")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851470", Offset = "0x851470")]
			public float bendGoalWeight;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8514C4", Offset = "0x8514C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8514C4", Offset = "0x8514C4")]
			public float swivelOffset;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851520", Offset = "0x851520")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851520", Offset = "0x851520")]
			public float bendToTargetWeight;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851574", Offset = "0x851574")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851574", Offset = "0x851574")]
			public float legLengthMlp;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8515CC", Offset = "0x8515CC")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851674", Offset = "0x851674")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851684", Offset = "0x851684")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851694", Offset = "0x851694")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8516A4", Offset = "0x8516A4")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000BD")]
			public Vector3 position
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x186AE04", Offset = "0x186AE04", VA = "0x186AE04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85997C", Offset = "0x85997C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x186AE10", Offset = "0x186AE10", VA = "0x186AE10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85998C", Offset = "0x85998C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x186AE1C", Offset = "0x186AE1C", VA = "0x186AE1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85999C", Offset = "0x85999C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x186AE28", Offset = "0x186AE28", VA = "0x186AE28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8599AC", Offset = "0x8599AC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public bool hasToes
			{
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x186AE34", Offset = "0x186AE34", VA = "0x186AE34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8599BC", Offset = "0x8599BC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x186AE3C", Offset = "0x186AE3C", VA = "0x186AE3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8599CC", Offset = "0x8599CC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x186AE48", Offset = "0x186AE48", VA = "0x186AE48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x186AE7C", Offset = "0x186AE7C", VA = "0x186AE7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x186AEB4", Offset = "0x186AEB4", VA = "0x186AEB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0x186AEEC", Offset = "0x186AEEC", VA = "0x186AEEC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x186AF24", Offset = "0x186AF24", VA = "0x186AF24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0x186AF64", Offset = "0x186AF64", VA = "0x186AF64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8599DC", Offset = "0x8599DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x186AF70", Offset = "0x186AF70", VA = "0x186AF70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8599EC", Offset = "0x8599EC")]
				private set
				{
				}
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x186AF7C", Offset = "0x186AF7C", VA = "0x186AF7C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x186B5B0", Offset = "0x186B5B0", VA = "0x186B5B0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x186BB6C", Offset = "0x186BB6C", VA = "0x186BB6C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x186BB1C", Offset = "0x186BB1C", VA = "0x186BB1C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x186B9AC", Offset = "0x186B9AC", VA = "0x186B9AC")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x186BF54", Offset = "0x186BF54", VA = "0x186BF54")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x186C404", Offset = "0x186C404", VA = "0x186C404")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x186C0E4", Offset = "0x186C0E4", VA = "0x186C0E4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x186C6FC", Offset = "0x186C6FC", VA = "0x186C6FC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x186C918", Offset = "0x186C918", VA = "0x186C918", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x186C964", Offset = "0x186C964", VA = "0x186C964")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Locomotion
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8516B4", Offset = "0x8516B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8516B4", Offset = "0x8516B4")]
			public float weight;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851708", Offset = "0x851708")]
			public float footDistance;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851740", Offset = "0x851740")]
			public float stepThreshold;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851778", Offset = "0x851778")]
			public float angleThreshold;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8517B0", Offset = "0x8517B0")]
			public float comAngleMlp;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8517E8", Offset = "0x8517E8")]
			public float maxVelocity;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851820", Offset = "0x851820")]
			public float velocityFactor;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851858", Offset = "0x851858")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851858", Offset = "0x851858")]
			public float maxLegStretch;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8518B0", Offset = "0x8518B0")]
			public float rootSpeed;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8518E8", Offset = "0x8518E8")]
			public float stepSpeed;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851920", Offset = "0x851920")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851958", Offset = "0x851958")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851990", Offset = "0x851990")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851990", Offset = "0x851990")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8519E8", Offset = "0x8519E8")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851A20", Offset = "0x851A20")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851A58", Offset = "0x851A58")]
			public Vector3 offset;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851AD0", Offset = "0x851AD0")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851B08", Offset = "0x851B08")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851B40", Offset = "0x851B40")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000C6")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1B9BD54", Offset = "0x1B9BD54", VA = "0x1B9BD54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8599FC", Offset = "0x8599FC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x1B9BD60", Offset = "0x1B9BD60", VA = "0x1B9BD60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A0C", Offset = "0x859A0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x1B9D8C4", Offset = "0x1B9D8C4", VA = "0x1B9D8C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C8")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x1B9D904", Offset = "0x1B9D904", VA = "0x1B9D904")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C9")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x1B9D948", Offset = "0x1B9D948", VA = "0x1B9D948")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000CA")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x1B9D988", Offset = "0x1B9D988", VA = "0x1B9D988")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1B9BD6C", Offset = "0x1B9BD6C", VA = "0x1B9BD6C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1B9C014", Offset = "0x1B9C014", VA = "0x1B9C014")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x1B9C1EC", Offset = "0x1B9C1EC", VA = "0x1B9C1EC")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1B9C434", Offset = "0x1B9C434", VA = "0x1B9C434")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1B9C4F8", Offset = "0x1B9C4F8", VA = "0x1B9C4F8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1B9D61C", Offset = "0x1B9D61C", VA = "0x1B9D61C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1B9D754", Offset = "0x1B9D754", VA = "0x1B9D754")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1B9D7F8", Offset = "0x1B9D7F8", VA = "0x1B9D7F8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1B9D9CC", Offset = "0x1B9D9CC", VA = "0x1B9D9CC")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851B50", Offset = "0x851B50")]
			public Transform headTarget;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851B88", Offset = "0x851B88")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851BC0", Offset = "0x851BC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851BC0", Offset = "0x851BC0")]
			public float positionWeight;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851C14", Offset = "0x851C14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851C14", Offset = "0x851C14")]
			public float rotationWeight;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851C68", Offset = "0x851C68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851C68", Offset = "0x851C68")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851CBC", Offset = "0x851CBC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851CBC", Offset = "0x851CBC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851D10", Offset = "0x851D10")]
			public Transform chestGoal;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851D48", Offset = "0x851D48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851D48", Offset = "0x851D48")]
			public float chestGoalWeight;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851D9C", Offset = "0x851D9C")]
			public float minHeadHeight;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851DD4", Offset = "0x851DD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851DD4", Offset = "0x851DD4")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851E28", Offset = "0x851E28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851E28", Offset = "0x851E28")]
			public float bodyRotStiffness;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851E7C", Offset = "0x851E7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851E7C", Offset = "0x851E7C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x851E7C", Offset = "0x851E7C")]
			public float neckStiffness;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851EF4", Offset = "0x851EF4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851EF4", Offset = "0x851EF4")]
			public float rotateChestByHands;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851F48", Offset = "0x851F48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851F48", Offset = "0x851F48")]
			public float chestClampWeight;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851F9C", Offset = "0x851F9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851F9C", Offset = "0x851F9C")]
			public float headClampWeight;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851FF0", Offset = "0x851FF0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852028", Offset = "0x852028")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x852028", Offset = "0x852028")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85207C", Offset = "0x85207C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85207C", Offset = "0x85207C")]
			public float maxRootAngle;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8520D4", Offset = "0x8520D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8520D4", Offset = "0x8520D4")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x852210", Offset = "0x852210")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x852220", Offset = "0x852220")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000CB")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000709")]
				[Address(RVA = "0x1B9D59C", Offset = "0x1B9D59C", VA = "0x1B9D59C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x1B9DAB8", Offset = "0x1B9DAB8", VA = "0x1B9DAB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			public VirtualBone chest
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x1B9DAF8", Offset = "0x1B9DAF8", VA = "0x1B9DAF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private VirtualBone neck
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x1B9DB4C", Offset = "0x1B9DB4C", VA = "0x1B9DB4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			public VirtualBone head
			{
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x1B9D5DC", Offset = "0x1B9D5DC", VA = "0x1B9D5DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x1B9DB8C", Offset = "0x1B9DB8C", VA = "0x1B9DB8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A1C", Offset = "0x859A1C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600070F")]
				[Address(RVA = "0x1B9DBA0", Offset = "0x1B9DBA0", VA = "0x1B9DBA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A2C", Offset = "0x859A2C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D1")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000710")]
				[Address(RVA = "0x1B9DBB4", Offset = "0x1B9DBB4", VA = "0x1B9DBB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A3C", Offset = "0x859A3C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x1B9DBC8", Offset = "0x1B9DBC8", VA = "0x1B9DBC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A4C", Offset = "0x859A4C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1B9DBDC", Offset = "0x1B9DBDC", VA = "0x1B9DBDC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1B9E684", Offset = "0x1B9E684", VA = "0x1B9E684", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1B9E890", Offset = "0x1B9E890", VA = "0x1B9E890", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1B9ECD4", Offset = "0x1B9ECD4", VA = "0x1B9ECD4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1B9F110", Offset = "0x1B9F110", VA = "0x1B9F110")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1B9F868", Offset = "0x1B9F868", VA = "0x1B9F868")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1B9FEEC", Offset = "0x1B9FEEC", VA = "0x1B9FEEC")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1BA08F0", Offset = "0x1BA08F0", VA = "0x1BA08F0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1BA0ACC", Offset = "0x1BA0ACC", VA = "0x1BA0ACC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1B9EE6C", Offset = "0x1B9EE6C", VA = "0x1B9EE6C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1B9FC38", Offset = "0x1B9FC38", VA = "0x1B9FC38")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1B9F520", Offset = "0x1B9F520", VA = "0x1B9F520")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1BA0B64", Offset = "0x1BA0B64", VA = "0x1BA0B64")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1B9FD18", Offset = "0x1B9FD18", VA = "0x1B9FD18")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1B9F9E4", Offset = "0x1B9F9E4", VA = "0x1B9F9E4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1BA0E8C", Offset = "0x1BA0E8C", VA = "0x1BA0E8C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000677")]
			Pelvis,
			[Token(Token = "0x4000678")]
			Chest,
			[Token(Token = "0x4000679")]
			Head,
			[Token(Token = "0x400067A")]
			LeftHand,
			[Token(Token = "0x400067B")]
			RightHand,
			[Token(Token = "0x400067C")]
			LeftFoot,
			[Token(Token = "0x400067D")]
			RightFoot,
			[Token(Token = "0x400067E")]
			LeftHeel,
			[Token(Token = "0x400067F")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000681")]
			Pelvis,
			[Token(Token = "0x4000682")]
			Chest,
			[Token(Token = "0x4000683")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000CB")]
		public class VirtualBone
		{
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1B9E5E8", Offset = "0x1B9E5E8", VA = "0x1B9E5E8")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1B9E664", Offset = "0x1B9E664", VA = "0x1B9E664")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1BA1000", Offset = "0x1BA1000", VA = "0x1BA1000")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1BA1184", Offset = "0x1BA1184", VA = "0x1BA1184")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1BA0D64", Offset = "0x1BA0D64", VA = "0x1BA0D64")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1BA1374", Offset = "0x1BA1374", VA = "0x1BA1374")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1BA14D4", Offset = "0x1BA14D4", VA = "0x1BA14D4")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1BA1610", Offset = "0x1BA1610", VA = "0x1BA1610")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1BA04EC", Offset = "0x1BA04EC", VA = "0x1BA04EC")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1BA16C8", Offset = "0x1BA16C8", VA = "0x1BA16C8")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1BA015C", Offset = "0x1BA015C", VA = "0x1BA015C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1BA1830", Offset = "0x1BA1830", VA = "0x1BA1830")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1BA18A0", Offset = "0x1BA18A0", VA = "0x1BA18A0")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850D24", Offset = "0x850D24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850D24", Offset = "0x850D24")]
		public int LOD;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850D78", Offset = "0x850D78")]
		public bool plantFeet;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850DB0", Offset = "0x850DB0")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850DC0", Offset = "0x850DC0")]
		public Spine spine;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850DF8", Offset = "0x850DF8")]
		public Arm leftArm;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850E30", Offset = "0x850E30")]
		public Arm rightArm;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850E68", Offset = "0x850E68")]
		public Leg leftLeg;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850EA0", Offset = "0x850EA0")]
		public Leg rightLeg;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850ED8", Offset = "0x850ED8")]
		public Locomotion locomotion;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000B2")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1C0ABF8", Offset = "0x1C0ABF8", VA = "0x1C0ABF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8598BC", Offset = "0x8598BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1C0AC00", Offset = "0x1C0AC00", VA = "0x1C0AC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8598CC", Offset = "0x8598CC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1C07090", Offset = "0x1C07090", VA = "0x1C07090")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1C074F4", Offset = "0x1C074F4", VA = "0x1C074F4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1C073A0", Offset = "0x1C073A0", VA = "0x1C073A0")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1C07C54", Offset = "0x1C07C54", VA = "0x1C07C54")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1C07D98", Offset = "0x1C07D98", VA = "0x1C07D98")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1C07DC8", Offset = "0x1C07DC8", VA = "0x1C07DC8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1C07E78", Offset = "0x1C07E78", VA = "0x1C07E78")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1C07F60", Offset = "0x1C07F60", VA = "0x1C07F60")]
		public void Reset()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1C086C4", Offset = "0x1C086C4", VA = "0x1C086C4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1C08834", Offset = "0x1C08834", VA = "0x1C08834", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1C08A38", Offset = "0x1C08A38", VA = "0x1C08A38", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1C08AB4", Offset = "0x1C08AB4", VA = "0x1C08AB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1C08B30", Offset = "0x1C08B30", VA = "0x1C08B30", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1C08D08", Offset = "0x1C08D08", VA = "0x1C08D08")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1C07728", Offset = "0x1C07728", VA = "0x1C07728")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1C07818", Offset = "0x1C07818", VA = "0x1C07818")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1C07B34", Offset = "0x1C07B34", VA = "0x1C07B34")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1C08054", Offset = "0x1C08054", VA = "0x1C08054")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1C08EC8", Offset = "0x1C08EC8", VA = "0x1C08EC8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1C08F10", Offset = "0x1C08F10", VA = "0x1C08F10", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1C0A328", Offset = "0x1C0A328", VA = "0x1C0A328")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1C081B8", Offset = "0x1C081B8", VA = "0x1C081B8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1C09284", Offset = "0x1C09284", VA = "0x1C09284")]
		private void Solve()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1C0A6D8", Offset = "0x1C0A6D8", VA = "0x1C0A6D8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1C0A720", Offset = "0x1C0A720", VA = "0x1C0A720")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1C0A1D8", Offset = "0x1C0A1D8", VA = "0x1C0A1D8")]
		private void Write()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1C0A764", Offset = "0x1C0A764", VA = "0x1C0A764")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1C0AC08", Offset = "0x1C0AC08", VA = "0x1C0AC08")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852230", Offset = "0x852230")]
		public Transform parent;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852268", Offset = "0x852268")]
		public Transform child;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8522A0", Offset = "0x8522A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8522A0", Offset = "0x8522A0")]
		public float weight;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8522F4", Offset = "0x8522F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8522F4", Offset = "0x8522F4")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x852348", Offset = "0x852348")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852348", Offset = "0x852348")]
		public float twistAngleOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1774D54", Offset = "0x1774D54", VA = "0x1774D54")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1775070", Offset = "0x1775070", VA = "0x1775070")]
		private void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1775430", Offset = "0x1775430", VA = "0x1775430")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x17754B4", Offset = "0x17754B4", VA = "0x17754B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1775538", Offset = "0x1775538", VA = "0x1775538")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1775650", Offset = "0x1775650", VA = "0x1775650")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CD")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8523A4", Offset = "0x8523A4")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8523B4", Offset = "0x8523B4")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8523C4", Offset = "0x8523C4")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x170000D2")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1C0BC28", Offset = "0x1C0BC28", VA = "0x1C0BC28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A5C", Offset = "0x859A5C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1C0BC30", Offset = "0x1C0BC30", VA = "0x1C0BC30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A6C", Offset = "0x859A6C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool isPaused
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1C0BC38", Offset = "0x1C0BC38", VA = "0x1C0BC38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A7C", Offset = "0x859A7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x1C0BC40", Offset = "0x1C0BC40", VA = "0x1C0BC40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A8C", Offset = "0x859A8C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1C0BC4C", Offset = "0x1C0BC4C", VA = "0x1C0BC4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859A9C", Offset = "0x859A9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1C0BC54", Offset = "0x1C0BC54", VA = "0x1C0BC54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859AAC", Offset = "0x859AAC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public bool inInteraction
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1C0BC5C", Offset = "0x1C0BC5C", VA = "0x1C0BC5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D6")]
		public float progress
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1C0E02C", Offset = "0x1C0E02C", VA = "0x1C0E02C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1C0BCC8", Offset = "0x1C0BCC8", VA = "0x1C0BCC8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1C0BD54", Offset = "0x1C0BD54", VA = "0x1C0BD54")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1C0BDF4", Offset = "0x1C0BDF4", VA = "0x1C0BDF4")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1C0BF6C", Offset = "0x1C0BF6C", VA = "0x1C0BF6C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1C0C2D0", Offset = "0x1C0C2D0", VA = "0x1C0C2D0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1C0C38C", Offset = "0x1C0C38C", VA = "0x1C0C38C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1C0C3E4", Offset = "0x1C0C3E4", VA = "0x1C0C3E4")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1C0CDD4", Offset = "0x1C0CDD4", VA = "0x1C0CDD4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1C0D83C", Offset = "0x1C0D83C", VA = "0x1C0D83C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1C0DA80", Offset = "0x1C0DA80", VA = "0x1C0DA80")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1C0DED8", Offset = "0x1C0DED8", VA = "0x1C0DED8")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1C0E18C", Offset = "0x1C0E18C", VA = "0x1C0E18C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8523D4", Offset = "0x8523D4")]
		public LookAtIK ik;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85240C", Offset = "0x85240C")]
		public float lerpSpeed;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852444", Offset = "0x852444")]
		public float weightSpeed;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1C0E37C", Offset = "0x1C0E37C", VA = "0x1C0E37C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1C0E498", Offset = "0x1C0E498", VA = "0x1C0E498")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1C0E53C", Offset = "0x1C0E53C", VA = "0x1C0E53C")]
		public void Update()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1C0EB74", Offset = "0x1C0EB74", VA = "0x1C0EB74")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1C0EC68", Offset = "0x1C0EC68", VA = "0x1C0EC68")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1C0ED30", Offset = "0x1C0ED30", VA = "0x1C0ED30")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AEF8", Offset = "0x84AEF8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AEF8", Offset = "0x84AEF8")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852554", Offset = "0x852554")]
			public float time;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85258C", Offset = "0x85258C")]
			public bool pause;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8525C4", Offset = "0x8525C4")]
			public bool pickUp;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8525FC", Offset = "0x8525FC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852634", Offset = "0x852634")]
			public Message[] messages;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85266C", Offset = "0x85266C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1BA204C", Offset = "0x1BA204C", VA = "0x1BA204C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x1BA2220", Offset = "0x1BA2220", VA = "0x1BA2220")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public class Message
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8526A4", Offset = "0x8526A4")]
			public string function;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8526DC", Offset = "0x8526DC")]
			public GameObject recipient;

			[Token(Token = "0x40006D2")]
			private const string empty = "";

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1BA211C", Offset = "0x1BA211C", VA = "0x1BA211C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1BA2228", Offset = "0x1BA2228", VA = "0x1BA2228")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852714", Offset = "0x852714")]
			public Animator animator;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85274C", Offset = "0x85274C")]
			public Animation animation;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852784", Offset = "0x852784")]
			public string animationState;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8527BC", Offset = "0x8527BC")]
			public float crossfadeTime;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8527F4", Offset = "0x8527F4")]
			public int layer;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85282C", Offset = "0x85282C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006D9")]
			private const string empty = "";

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1BA1DB8", Offset = "0x1BA1DB8", VA = "0x1BA1DB8")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1BA1EA8", Offset = "0x1BA1EA8", VA = "0x1BA1EA8")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1BA1F5C", Offset = "0x1BA1F5C", VA = "0x1BA1F5C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1BA2038", Offset = "0x1BA2038", VA = "0x1BA2038")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D3")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000D4")]
			public enum Type
			{
				[Token(Token = "0x40006DD")]
				PositionWeight,
				[Token(Token = "0x40006DE")]
				RotationWeight,
				[Token(Token = "0x40006DF")]
				PositionOffsetX,
				[Token(Token = "0x40006E0")]
				PositionOffsetY,
				[Token(Token = "0x40006E1")]
				PositionOffsetZ,
				[Token(Token = "0x40006E2")]
				Pull,
				[Token(Token = "0x40006E3")]
				Reach,
				[Token(Token = "0x40006E4")]
				RotateBoneWeight,
				[Token(Token = "0x40006E5")]
				Push,
				[Token(Token = "0x40006E6")]
				PushParent,
				[Token(Token = "0x40006E7")]
				PoserWeight,
				[Token(Token = "0x40006E8")]
				BendGoalWeight
			}

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852864", Offset = "0x852864")]
			public Type type;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85289C", Offset = "0x85289C")]
			public AnimationCurve curve;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1BA226C", Offset = "0x1BA226C", VA = "0x1BA226C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1BA2298", Offset = "0x1BA2298", VA = "0x1BA2298")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Multiplier
		{
			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8528D4", Offset = "0x8528D4")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85290C", Offset = "0x85290C")]
			public float multiplier;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852944", Offset = "0x852944")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x1BA2230", Offset = "0x1BA2230", VA = "0x1BA2230")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x1BA2288", Offset = "0x1BA2288", VA = "0x1BA2288")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85248C", Offset = "0x85248C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8524C4", Offset = "0x8524C4")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8524FC", Offset = "0x8524FC")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x852534", Offset = "0x852534")]
		private float <length>k__BackingField;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x852544", Offset = "0x852544")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000D7")]
		public float length
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x1C0EF84", Offset = "0x1C0EF84", VA = "0x1C0EF84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859C7C", Offset = "0x859C7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1C0EF8C", Offset = "0x1C0EF8C", VA = "0x1C0EF8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859C8C", Offset = "0x859C8C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1C0EF94", Offset = "0x1C0EF94", VA = "0x1C0EF94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859C9C", Offset = "0x859C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1C0EF9C", Offset = "0x1C0EF9C", VA = "0x1C0EF9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859CAC", Offset = "0x859CAC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1C0F164", Offset = "0x1C0F164", VA = "0x1C0F164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1C0E068", Offset = "0x1C0E068", VA = "0x1C0E068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1C0ED44", Offset = "0x1C0ED44", VA = "0x1C0ED44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859ABC", Offset = "0x859ABC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1C0ED8C", Offset = "0x1C0ED8C", VA = "0x1C0ED8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859AF4", Offset = "0x859AF4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1C0EDD4", Offset = "0x1C0EDD4", VA = "0x1C0EDD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859B2C", Offset = "0x859B2C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1C0EE1C", Offset = "0x1C0EE1C", VA = "0x1C0EE1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859B64", Offset = "0x859B64")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1C0EE64", Offset = "0x1C0EE64", VA = "0x1C0EE64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859B9C", Offset = "0x859B9C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1C0EEAC", Offset = "0x1C0EEAC", VA = "0x1C0EEAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859BD4", Offset = "0x859BD4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1C0EEF4", Offset = "0x1C0EEF4", VA = "0x1C0EEF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859C0C", Offset = "0x859C0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1C0EF3C", Offset = "0x1C0EF3C", VA = "0x1C0EF3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859C44", Offset = "0x859C44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1C0EFA4", Offset = "0x1C0EFA4", VA = "0x1C0EFA4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1C0F1F0", Offset = "0x1C0F1F0", VA = "0x1C0F1F0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1C0C94C", Offset = "0x1C0C94C", VA = "0x1C0C94C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1C0F37C", Offset = "0x1C0F37C", VA = "0x1C0F37C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1C0C7F8", Offset = "0x1C0C7F8", VA = "0x1C0C7F8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1C0C944", Offset = "0x1C0C944", VA = "0x1C0C944")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1C0D3E0", Offset = "0x1C0D3E0", VA = "0x1C0D3E0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1C0DCB8", Offset = "0x1C0DCB8", VA = "0x1C0DCB8")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1C0F960", Offset = "0x1C0F960", VA = "0x1C0F960")]
		private void Start()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1C0F464", Offset = "0x1C0F464", VA = "0x1C0F464")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1C0F384", Offset = "0x1C0F384", VA = "0x1C0F384")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1C0F8F8", Offset = "0x1C0F8F8", VA = "0x1C0F8F8")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1C0F964", Offset = "0x1C0F964", VA = "0x1C0F964")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1C0F9CC", Offset = "0x1C0F9CC", VA = "0x1C0F9CC")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AF58", Offset = "0x84AF58")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AF58", Offset = "0x84AF58")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000D8")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85297C", Offset = "0x85297C")]
		public string targetTag;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8529B4", Offset = "0x8529B4")]
		public float fadeInTime;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8529EC", Offset = "0x8529EC")]
		public float speed;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852A24", Offset = "0x852A24")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x852A5C", Offset = "0x852A5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852A5C", Offset = "0x852A5C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x852A5C", Offset = "0x852A5C")]
		public Collider characterCollider;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852AE0", Offset = "0x852AE0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x852AE0", Offset = "0x852AE0")]
		public Transform FPSCamera;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852B40", Offset = "0x852B40")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852B78", Offset = "0x852B78")]
		public float camRaycastDistance;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x852BB0", Offset = "0x852BB0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852BC0", Offset = "0x852BC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x852BC0", Offset = "0x852BC0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852C20", Offset = "0x852C20")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000DB")]
		public bool inInteraction
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1C0BB00", Offset = "0x1C0BB00", VA = "0x1C0BB00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DC")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1C116DC", Offset = "0x1C116DC", VA = "0x1C116DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1C116E4", Offset = "0x1C116E4", VA = "0x1C116E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1C116EC", Offset = "0x1C116EC", VA = "0x1C116EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859E7C", Offset = "0x859E7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1C116F4", Offset = "0x1C116F4", VA = "0x1C116F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x859E8C", Offset = "0x859E8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1C0FA28", Offset = "0x1C0FA28", VA = "0x1C0FA28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859CBC", Offset = "0x859CBC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1C0FA70", Offset = "0x1C0FA70", VA = "0x1C0FA70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859CF4", Offset = "0x859CF4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1C0FAB8", Offset = "0x1C0FAB8", VA = "0x1C0FAB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859D2C", Offset = "0x859D2C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1C0FB00", Offset = "0x1C0FB00", VA = "0x1C0FB00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859D64", Offset = "0x859D64")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1C0FB48", Offset = "0x1C0FB48", VA = "0x1C0FB48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859D9C", Offset = "0x859D9C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1C0FB90", Offset = "0x1C0FB90", VA = "0x1C0FB90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859DD4", Offset = "0x859DD4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1C0FBD8", Offset = "0x1C0FBD8", VA = "0x1C0FBD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859E0C", Offset = "0x859E0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1C0FC20", Offset = "0x1C0FC20", VA = "0x1C0FC20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859E44", Offset = "0x859E44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1C0FD60", Offset = "0x1C0FD60", VA = "0x1C0FD60")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1C0FE2C", Offset = "0x1C0FE2C", VA = "0x1C0FE2C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1C0FEF8", Offset = "0x1C0FEF8", VA = "0x1C0FEF8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1C0FFA4", Offset = "0x1C0FFA4", VA = "0x1C0FFA4")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1C0B1E0", Offset = "0x1C0B1E0", VA = "0x1C0B1E0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1C1009C", Offset = "0x1C1009C", VA = "0x1C1009C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1C1012C", Offset = "0x1C1012C", VA = "0x1C1012C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1C101BC", Offset = "0x1C101BC", VA = "0x1C101BC")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1C1024C", Offset = "0x1C1024C", VA = "0x1C1024C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1C0BBAC", Offset = "0x1C0BBAC", VA = "0x1C0BBAC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1C102C0", Offset = "0x1C102C0", VA = "0x1C102C0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1C10328", Offset = "0x1C10328", VA = "0x1C10328")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1C103B4", Offset = "0x1C103B4", VA = "0x1C103B4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1C10468", Offset = "0x1C10468", VA = "0x1C10468")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1C1054C", Offset = "0x1C1054C", VA = "0x1C1054C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1C10824", Offset = "0x1C10824", VA = "0x1C10824")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1C10A04", Offset = "0x1C10A04", VA = "0x1C10A04")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1C10C98", Offset = "0x1C10C98", VA = "0x1C10C98")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1C10F70", Offset = "0x1C10F70", VA = "0x1C10F70")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1C10FB4", Offset = "0x1C10FB4", VA = "0x1C10FB4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1C1102C", Offset = "0x1C1102C", VA = "0x1C1102C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1C11148", Offset = "0x1C11148", VA = "0x1C11148")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1C112EC", Offset = "0x1C112EC", VA = "0x1C112EC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1C11590", Offset = "0x1C11590", VA = "0x1C11590")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1C10DAC", Offset = "0x1C10DAC", VA = "0x1C10DAC")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1C116FC", Offset = "0x1C116FC", VA = "0x1C116FC")]
		public void Start()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1C11E68", Offset = "0x1C11E68", VA = "0x1C11E68")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1C11E88", Offset = "0x1C11E88", VA = "0x1C11E88")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1C11EA4", Offset = "0x1C11EA4", VA = "0x1C11EA4")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1C11EC0", Offset = "0x1C11EC0", VA = "0x1C11EC0")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1C11F20", Offset = "0x1C11F20", VA = "0x1C11F20")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1C1205C", Offset = "0x1C1205C", VA = "0x1C1205C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1C1216C", Offset = "0x1C1216C", VA = "0x1C1216C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1C12510", Offset = "0x1C12510", VA = "0x1C12510")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1C12610", Offset = "0x1C12610", VA = "0x1C12610")]
		public void Update()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1C128A0", Offset = "0x1C128A0", VA = "0x1C128A0")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1C11BCC", Offset = "0x1C11BCC", VA = "0x1C11BCC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1C129DC", Offset = "0x1C129DC", VA = "0x1C129DC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1C12B04", Offset = "0x1C12B04", VA = "0x1C12B04")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1C12B98", Offset = "0x1C12B98", VA = "0x1C12B98")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1C12C6C", Offset = "0x1C12C6C", VA = "0x1C12C6C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1C12C84", Offset = "0x1C12C84", VA = "0x1C12C84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1C0FC68", Offset = "0x1C0FC68", VA = "0x1C0FC68")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1C106F4", Offset = "0x1C106F4", VA = "0x1C106F4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1C12FEC", Offset = "0x1C12FEC", VA = "0x1C12FEC")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84AFB8", Offset = "0x84AFB8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84AFB8", Offset = "0x84AFB8")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public class Multiplier
		{
			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852E18", Offset = "0x852E18")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852E50", Offset = "0x852E50")]
			public float multiplier;

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1BA29B4", Offset = "0x1BA29B4", VA = "0x1BA29B4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852C58", Offset = "0x852C58")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852C90", Offset = "0x852C90")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852CC8", Offset = "0x852CC8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852D00", Offset = "0x852D00")]
		public Transform pivot;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852D38", Offset = "0x852D38")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852D70", Offset = "0x852D70")]
		public float twistWeight;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852DA8", Offset = "0x852DA8")]
		public float swingWeight;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852DE0", Offset = "0x852DE0")]
		public bool rotateOnce;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1C13724", Offset = "0x1C13724", VA = "0x1C13724")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859E9C", Offset = "0x859E9C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1C1376C", Offset = "0x1C1376C", VA = "0x1C1376C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859ED4", Offset = "0x859ED4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1C137B4", Offset = "0x1C137B4", VA = "0x1C137B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859F0C", Offset = "0x859F0C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1C137FC", Offset = "0x1C137FC", VA = "0x1C137FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859F44", Offset = "0x859F44")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1C13844", Offset = "0x1C13844", VA = "0x1C13844")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859F7C", Offset = "0x859F7C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1C1388C", Offset = "0x1C1388C", VA = "0x1C1388C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859FB4", Offset = "0x859FB4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1C138D4", Offset = "0x1C138D4", VA = "0x1C138D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x859FEC", Offset = "0x859FEC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1C1391C", Offset = "0x1C1391C", VA = "0x1C1391C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A024", Offset = "0x85A024")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1C0F3F4", Offset = "0x1C0F3F4", VA = "0x1C0F3F4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1C0E0F4", Offset = "0x1C0E0F4", VA = "0x1C0E0F4")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1C0CA00", Offset = "0x1C0CA00", VA = "0x1C0CA00")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1C13964", Offset = "0x1C13964", VA = "0x1C13964")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B018", Offset = "0x84B018")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B018", Offset = "0x84B018")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852EC0", Offset = "0x852EC0")]
			public bool use;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852EF8", Offset = "0x852EF8")]
			public Vector2 offset;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852F30", Offset = "0x852F30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x852F30", Offset = "0x852F30")]
			public float angleOffset;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852F8C", Offset = "0x852F8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x852F8C", Offset = "0x852F8C")]
			public float maxAngle;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852FE4", Offset = "0x852FE4")]
			public float radius;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85301C", Offset = "0x85301C")]
			public bool orbit;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853054", Offset = "0x853054")]
			public bool fixYAxis;

			[Token(Token = "0x170000DE")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60007CE")]
				[Address(RVA = "0x1BA2D24", Offset = "0x1BA2D24", VA = "0x1BA2D24")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DF")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x1BA2D30", Offset = "0x1BA2D30", VA = "0x1BA2D30")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1BA2DB8", Offset = "0x1BA2DB8", VA = "0x1BA2DB8")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1BA31FC", Offset = "0x1BA31FC", VA = "0x1BA31FC")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public class CameraPosition
		{
			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85308C", Offset = "0x85308C")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8530C4", Offset = "0x8530C4")]
			public Vector3 direction;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8530FC", Offset = "0x8530FC")]
			public float maxDistance;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853134", Offset = "0x853134")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x853134", Offset = "0x853134")]
			public float maxAngle;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85318C", Offset = "0x85318C")]
			public bool fixYAxis;

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1BA29BC", Offset = "0x1BA29BC", VA = "0x1BA29BC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x1BA2AB0", Offset = "0x1BA2AB0", VA = "0x1BA2AB0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1BA2CD8", Offset = "0x1BA2CD8", VA = "0x1BA2CD8")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000DF")]
			public class Interaction
			{
				[Token(Token = "0x4000722")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8532DC", Offset = "0x8532DC")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000723")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853314", Offset = "0x853314")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x1BAA8E8", Offset = "0x1BAA8E8", VA = "0x1BAA8E8")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853234", Offset = "0x853234")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85326C", Offset = "0x85326C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8532A4", Offset = "0x8532A4")]
			public Interaction[] interactions;

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1BA3210", Offset = "0x1BA3210", VA = "0x1BA3210")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1BA32C4", Offset = "0x1BA32C4", VA = "0x1BA32C4")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852E88", Offset = "0x852E88")]
		public Range[] ranges;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1C139AC", Offset = "0x1C139AC", VA = "0x1C139AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A05C", Offset = "0x85A05C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1C139F4", Offset = "0x1C139F4", VA = "0x1C139F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A094", Offset = "0x85A094")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1C13A3C", Offset = "0x1C13A3C", VA = "0x1C13A3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A0CC", Offset = "0x85A0CC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1C13A84", Offset = "0x1C13A84", VA = "0x1C13A84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A104", Offset = "0x85A104")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1C13ACC", Offset = "0x1C13ACC", VA = "0x1C13ACC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A13C", Offset = "0x85A13C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1C13B14", Offset = "0x1C13B14", VA = "0x1C13B14")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1C1233C", Offset = "0x1C1233C", VA = "0x1C1233C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1C13B18", Offset = "0x1C13B18", VA = "0x1C13B18")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Map
		{
			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x18627E8", Offset = "0x18627E8", VA = "0x18627E8")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1862824", Offset = "0x1862824", VA = "0x1862824")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1862874", Offset = "0x1862874", VA = "0x1862874")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x18628C0", Offset = "0x18628C0", VA = "0x18628C0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1AEEC68", Offset = "0x1AEEC68", VA = "0x1AEEC68", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A174", Offset = "0x85A174")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1AEEFE4", Offset = "0x1AEEFE4", VA = "0x1AEEFE4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1AEEFE8", Offset = "0x1AEEFE8", VA = "0x1AEEFE8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1AEF0F0", Offset = "0x1AEF0F0", VA = "0x1AEF0F0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1AEEF78", Offset = "0x1AEEF78", VA = "0x1AEEF78")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1AEEED8", Offset = "0x1AEEED8", VA = "0x1AEEED8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1AEF15C", Offset = "0x1AEF15C", VA = "0x1AEF15C")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1AF62B0", Offset = "0x1AF62B0", VA = "0x1AF62B0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1AF6378", Offset = "0x1AF6378", VA = "0x1AF6378", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1AF6534", Offset = "0x1AF6534", VA = "0x1AF6534", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1AF6630", Offset = "0x1AF6630", VA = "0x1AF6630", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1AF63D0", Offset = "0x1AF63D0", VA = "0x1AF63D0")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1AF6990", Offset = "0x1AF6990", VA = "0x1AF6990")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85334C", Offset = "0x85334C")]
		public float weight;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x853364", Offset = "0x853364")]
		public float localRotationWeight;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85337C", Offset = "0x85337C")]
		public float localPositionWeight;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60007E9")]
		public abstract void AutoMapping();

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xF21D6C", Offset = "0xF21D6C", VA = "0xF21D6C")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60007EB")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60007EC")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60007ED")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xF21D78", Offset = "0xF21D78", VA = "0xF21D78", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xF21DCC", Offset = "0xF21DCC", VA = "0xF21DCC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xF21E08", Offset = "0xF21E08", VA = "0xF21E08", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xF21E20", Offset = "0xF21E20", VA = "0xF21E20")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B078", Offset = "0x84B078")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000E5")]
		public class Rigidbone
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1BA73A8", Offset = "0x1BA73A8", VA = "0x1BA73A8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1BA7518", Offset = "0x1BA7518", VA = "0x1BA7518")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1BA75F8", Offset = "0x1BA75F8", VA = "0x1BA75F8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		public class Child
		{
			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1BA71B8", Offset = "0x1BA71B8", VA = "0x1BA71B8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1BA7218", Offset = "0x1BA7218", VA = "0x1BA7218")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1BA7358", Offset = "0x1BA7358", VA = "0x1BA7358")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B0D8", Offset = "0x84B0D8")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600080D")]
				[Address(RVA = "0x1BA7168", Offset = "0x1BA7168", VA = "0x1BA7168", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080F")]
				[Address(RVA = "0x1BA71B0", Offset = "0x1BA71B0", VA = "0x1BA71B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x1BA6F4C", Offset = "0x1BA6F4C", VA = "0x1BA6F4C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x1BA6F78", Offset = "0x1BA6F78", VA = "0x1BA6F78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x1BA6F7C", Offset = "0x1BA6F7C", VA = "0x1BA6F7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1BA7170", Offset = "0x1BA7170", VA = "0x1BA7170", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853394", Offset = "0x853394")]
		public IK ik;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8533CC", Offset = "0x8533CC")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853404", Offset = "0x853404")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85343C", Offset = "0x85343C")]
		public float applyVelocity;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853474", Offset = "0x853474")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000E0")]
		private bool isRagdoll
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x176B400", Offset = "0x176B400", VA = "0x176B400")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E1")]
		private bool ikUsed
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x176BD88", Offset = "0x176BD88", VA = "0x176BD88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x176B3C8", Offset = "0x176B3C8", VA = "0x176B3C8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x176B478", Offset = "0x176B478", VA = "0x176B478")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x176B5A8", Offset = "0x176B5A8", VA = "0x176B5A8")]
		public void Start()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x176B53C", Offset = "0x176B53C", VA = "0x176B53C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A1AC", Offset = "0x85A1AC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x176B9C4", Offset = "0x176B9C4", VA = "0x176B9C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x176BC10", Offset = "0x176BC10", VA = "0x176BC10")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x176BCCC", Offset = "0x176BCCC", VA = "0x176BCCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x176BF08", Offset = "0x176BF08", VA = "0x176BF08")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x176BD4C", Offset = "0x176BD4C", VA = "0x176BD4C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x176BEC4", Offset = "0x176BEC4", VA = "0x176BEC4")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x176BFA8", Offset = "0x176BFA8", VA = "0x176BFA8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x176BF3C", Offset = "0x176BF3C", VA = "0x176BF3C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x176B4D0", Offset = "0x176B4D0", VA = "0x176B4D0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x176BC50", Offset = "0x176BC50", VA = "0x176BC50")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x176C1D4", Offset = "0x176C1D4", VA = "0x176C1D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x176C2EC", Offset = "0x176C2EC", VA = "0x176C2EC")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8534BC", Offset = "0x8534BC")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000E4")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x176E09C", Offset = "0x176E09C", VA = "0x176E09C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E5")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x176E0A8", Offset = "0x176E0A8", VA = "0x176E0A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E6")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x176E0C4", Offset = "0x176E0C4", VA = "0x176E0C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A25C", Offset = "0x85A25C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x176E0CC", Offset = "0x176E0CC", VA = "0x176E0CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A26C", Offset = "0x85A26C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x176DD9C", Offset = "0x176DD9C", VA = "0x176DD9C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x176DDE4", Offset = "0x176DDE4", VA = "0x176DDE4")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x176DDFC", Offset = "0x176DDFC", VA = "0x176DDFC")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x176DFF4", Offset = "0x176DFF4", VA = "0x176DFF4")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x176E064", Offset = "0x176E064", VA = "0x176E064")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000819")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x176DF1C", Offset = "0x176DF1C", VA = "0x176DF1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x176E0D8", Offset = "0x176E0D8", VA = "0x176E0D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x176E0DC", Offset = "0x176E0DC", VA = "0x176E0DC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x176E110", Offset = "0x176E110", VA = "0x176E110")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x176E18C", Offset = "0x176E18C", VA = "0x176E18C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x176E320", Offset = "0x176E320", VA = "0x176E320")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x176E390", Offset = "0x176E390", VA = "0x176E390")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B0E8", Offset = "0x84B0E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B0E8", Offset = "0x84B0E8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8534CC", Offset = "0x8534CC")]
		public float limit;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8534E8", Offset = "0x8534E8")]
		public float twistLimit;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x176E3C4", Offset = "0x176E3C4", VA = "0x176E3C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A27C", Offset = "0x85A27C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x176E40C", Offset = "0x176E40C", VA = "0x176E40C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A2B4", Offset = "0x85A2B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x176E454", Offset = "0x176E454", VA = "0x176E454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A2EC", Offset = "0x85A2EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x176E49C", Offset = "0x176E49C", VA = "0x176E49C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A324", Offset = "0x85A324")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x176E4E4", Offset = "0x176E4E4", VA = "0x176E4E4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x176E528", Offset = "0x176E528", VA = "0x176E528")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x176E6E8", Offset = "0x176E6E8", VA = "0x176E6E8")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B148", Offset = "0x84B148")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B148", Offset = "0x84B148")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x176E728", Offset = "0x176E728", VA = "0x176E728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A35C", Offset = "0x85A35C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x176E770", Offset = "0x176E770", VA = "0x176E770")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A394", Offset = "0x85A394")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x176E7B8", Offset = "0x176E7B8", VA = "0x176E7B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A3CC", Offset = "0x85A3CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x176E800", Offset = "0x176E800", VA = "0x176E800")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A404", Offset = "0x85A404")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x176E848", Offset = "0x176E848", VA = "0x176E848", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x176E870", Offset = "0x176E870", VA = "0x176E870")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x176EA6C", Offset = "0x176EA6C", VA = "0x176EA6C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B1A8", Offset = "0x84B1A8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B1A8", Offset = "0x84B1A8")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class ReachCone
		{
			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000E7")]
			public Vector3 o
			{
				[Token(Token = "0x600083F")]
				[Address(RVA = "0x1BA7C2C", Offset = "0x1BA7C2C", VA = "0x1BA7C2C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E8")]
			public Vector3 a
			{
				[Token(Token = "0x6000840")]
				[Address(RVA = "0x1BA7C64", Offset = "0x1BA7C64", VA = "0x1BA7C64")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E9")]
			public Vector3 b
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0x1BA7CA0", Offset = "0x1BA7CA0", VA = "0x1BA7CA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EA")]
			public Vector3 c
			{
				[Token(Token = "0x6000842")]
				[Address(RVA = "0x1BA7CDC", Offset = "0x1BA7CDC", VA = "0x1BA7CDC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EB")]
			public bool isValid
			{
				[Token(Token = "0x6000844")]
				[Address(RVA = "0x1BA7E54", Offset = "0x1BA7E54", VA = "0x1BA7E54")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1BA7D18", Offset = "0x1BA7D18", VA = "0x1BA7D18")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x1BA7E64", Offset = "0x1BA7E64", VA = "0x1BA7E64")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		public class LimitPoint
		{
			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1BA7BF0", Offset = "0x1BA7BF0", VA = "0x1BA7BF0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x853514", Offset = "0x853514")]
		public float twistLimit;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x853530", Offset = "0x853530")]
		public int smoothIterations;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public Vector3[] P;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x176EAC4", Offset = "0x176EAC4", VA = "0x176EAC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A43C", Offset = "0x85A43C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x176EB0C", Offset = "0x176EB0C", VA = "0x176EB0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A474", Offset = "0x85A474")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x176EB54", Offset = "0x176EB54", VA = "0x176EB54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A4AC", Offset = "0x85A4AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x176EB9C", Offset = "0x176EB9C", VA = "0x176EB9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A4E4", Offset = "0x85A4E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x176EBE4", Offset = "0x176EBE4", VA = "0x176EBE4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x176F084", Offset = "0x176F084", VA = "0x176F084", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x176F118", Offset = "0x176F118", VA = "0x176F118")]
		private void Start()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x176F644", Offset = "0x176F644", VA = "0x176F644")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x176EC80", Offset = "0x176EC80", VA = "0x176EC80")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x176F9C4", Offset = "0x176F9C4", VA = "0x176F9C4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x176FDD0", Offset = "0x176FDD0", VA = "0x176FDD0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x176FE14", Offset = "0x176FE14", VA = "0x176FE14")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x176FE74", Offset = "0x176FE74", VA = "0x176FE74")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x176F3D4", Offset = "0x176F3D4", VA = "0x176F3D4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x176FEE0", Offset = "0x176FEE0", VA = "0x176FEE0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x176FFBC", Offset = "0x176FFBC", VA = "0x176FFBC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B208", Offset = "0x84B208")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B208", Offset = "0x84B208")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8535F0", Offset = "0x8535F0")]
		public float twistLimit;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1770030", Offset = "0x1770030", VA = "0x1770030")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A51C", Offset = "0x85A51C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x1770078", Offset = "0x1770078", VA = "0x1770078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A554", Offset = "0x85A554")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x17700C0", Offset = "0x17700C0", VA = "0x17700C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A58C", Offset = "0x85A58C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1770108", Offset = "0x1770108", VA = "0x1770108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85A5C4", Offset = "0x85A5C4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1770150", Offset = "0x1770150", VA = "0x1770150")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x177016C", Offset = "0x177016C", VA = "0x177016C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x17701B0", Offset = "0x17701B0", VA = "0x17701B0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x17703D4", Offset = "0x17703D4", VA = "0x17703D4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B268", Offset = "0x84B268")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000859")]
				[Address(RVA = "0x185FAE4", Offset = "0x185FAE4", VA = "0x185FAE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600085B")]
				[Address(RVA = "0x185FB2C", Offset = "0x185FB2C", VA = "0x185FB2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x185F9F4", Offset = "0x185F9F4", VA = "0x185F9F4")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x185FA20", Offset = "0x185FA20", VA = "0x185FA20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x185FA24", Offset = "0x185FA24", VA = "0x185FA24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x185FAEC", Offset = "0x185FAEC", VA = "0x185FAEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853644", Offset = "0x853644")]
		public AimIK ik;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85367C", Offset = "0x85367C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85367C", Offset = "0x85367C")]
		public float weight;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8536D0", Offset = "0x8536D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8536D0", Offset = "0x8536D0")]
		public Transform target;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853730", Offset = "0x853730")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853768", Offset = "0x853768")]
		public float weightSmoothTime;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8537A0", Offset = "0x8537A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8537A0", Offset = "0x8537A0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853800", Offset = "0x853800")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853838", Offset = "0x853838")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853870", Offset = "0x853870")]
		public float slerpSpeed;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8538A8", Offset = "0x8538A8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8538E0", Offset = "0x8538E0")]
		public float minDistance;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853918", Offset = "0x853918")]
		public Vector3 offset;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x853950", Offset = "0x853950")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x853950", Offset = "0x853950")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853950", Offset = "0x853950")]
		public float maxRootAngle;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8539CC", Offset = "0x8539CC")]
		public bool turnToTarget;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853A04", Offset = "0x853A04")]
		public float turnToTargetTime;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x853A3C", Offset = "0x853A3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853A3C", Offset = "0x853A3C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853A9C", Offset = "0x853A9C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x170000EC")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x194EBE0", Offset = "0x194EBE0", VA = "0x194EBE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x194EB58", Offset = "0x194EB58", VA = "0x194EB58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x194EC70", Offset = "0x194EC70", VA = "0x194EC70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x194F1C8", Offset = "0x194F1C8", VA = "0x194F1C8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x194F2B4", Offset = "0x194F2B4", VA = "0x194F2B4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x194F504", Offset = "0x194F504", VA = "0x194F504")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A5FC", Offset = "0x85A5FC")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x194F570", Offset = "0x194F570", VA = "0x194F570")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F2")]
		public class Pose
		{
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x185FB34", Offset = "0x185FB34", VA = "0x185FB34")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x185FCC0", Offset = "0x185FCC0", VA = "0x185FCC0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x185FCC8", Offset = "0x185FCC8", VA = "0x185FCC8")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x194F7D4", Offset = "0x194F7D4", VA = "0x194F7D4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x194F8B4", Offset = "0x194F8B4", VA = "0x194F8B4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x194F920", Offset = "0x194F920", VA = "0x194F920")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000F5")]
			public class EffectorLink
			{
				[Token(Token = "0x400079F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853C5C", Offset = "0x853C5C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853C94", Offset = "0x853C94")]
				public float weight;

				[Token(Token = "0x6000867")]
				[Address(RVA = "0x1BAA4C4", Offset = "0x1BAA4C4", VA = "0x1BAA4C4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853B0C", Offset = "0x853B0C")]
			public Transform transform;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853B44", Offset = "0x853B44")]
			public Transform relativeTo;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853B7C", Offset = "0x853B7C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853BB4", Offset = "0x853BB4")]
			public float verticalWeight;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853BEC", Offset = "0x853BEC")]
			public float horizontalWeight;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853C24", Offset = "0x853C24")]
			public float speed;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x185FCE4", Offset = "0x185FCE4", VA = "0x185FCE4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1860010", Offset = "0x1860010", VA = "0x1860010")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x1860020", Offset = "0x1860020", VA = "0x1860020")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853AD4", Offset = "0x853AD4")]
		public Body[] bodies;

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x194FA30", Offset = "0x194FA30", VA = "0x194FA30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x194FB7C", Offset = "0x194FB7C", VA = "0x194FB7C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853CCC", Offset = "0x853CCC")]
		public float tiltSpeed;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853D04", Offset = "0x853D04")]
		public float tiltSensitivity;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853D3C", Offset = "0x853D3C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853D74", Offset = "0x853D74")]
		public OffsetPose poseRight;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1916560", Offset = "0x1916560", VA = "0x1916560", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x19165A8", Offset = "0x19165A8", VA = "0x19165A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1916760", Offset = "0x1916760", VA = "0x1916760")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x191CF9C", Offset = "0x191CF9C", VA = "0x191CF9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x191D02C", Offset = "0x191D02C", VA = "0x191D02C")]
		private void Update()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x191D0F8", Offset = "0x191D0F8", VA = "0x191D0F8")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853E1C", Offset = "0x853E1C")]
			public string name;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853E54", Offset = "0x853E54")]
			public Collider collider;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853E8C", Offset = "0x853E8C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x853ED8", Offset = "0x853ED8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x853EE8", Offset = "0x853EE8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x853EF8", Offset = "0x853EF8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x853F08", Offset = "0x853F08")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000F0")]
			public bool inProgress
			{
				[Token(Token = "0x6000872")]
				[Address(RVA = "0x1864394", Offset = "0x1864394", VA = "0x1864394")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F1")]
			protected float crossFader
			{
				[Token(Token = "0x6000873")]
				[Address(RVA = "0x18643A8", Offset = "0x18643A8", VA = "0x18643A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A6AC", Offset = "0x85A6AC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000874")]
				[Address(RVA = "0x18643B0", Offset = "0x18643B0", VA = "0x18643B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A6BC", Offset = "0x85A6BC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			protected float timer
			{
				[Token(Token = "0x6000875")]
				[Address(RVA = "0x18643B8", Offset = "0x18643B8", VA = "0x18643B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A6CC", Offset = "0x85A6CC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000876")]
				[Address(RVA = "0x18643C0", Offset = "0x18643C0", VA = "0x18643C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A6DC", Offset = "0x85A6DC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F3")]
			protected Vector3 force
			{
				[Token(Token = "0x6000877")]
				[Address(RVA = "0x18643C8", Offset = "0x18643C8", VA = "0x18643C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A6EC", Offset = "0x85A6EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000878")]
				[Address(RVA = "0x18643D4", Offset = "0x18643D4", VA = "0x18643D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A6FC", Offset = "0x85A6FC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F4")]
			protected Vector3 point
			{
				[Token(Token = "0x6000879")]
				[Address(RVA = "0x18643E0", Offset = "0x18643E0", VA = "0x18643E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A70C", Offset = "0x85A70C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600087A")]
				[Address(RVA = "0x18643EC", Offset = "0x18643EC", VA = "0x18643EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A71C", Offset = "0x85A71C")]
				private set
				{
				}
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x18643F8", Offset = "0x18643F8", VA = "0x18643F8")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x186452C", Offset = "0x186452C", VA = "0x186452C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600087D")]
			protected abstract float GetLength();

			[Token(Token = "0x600087E")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600087F")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x1864600", Offset = "0x1864600", VA = "0x1864600")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000FB")]
			public class EffectorLink
			{
				[Token(Token = "0x40007B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853FC0", Offset = "0x853FC0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853FF8", Offset = "0x853FF8")]
				public float weight;

				[Token(Token = "0x40007B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000885")]
				[Address(RVA = "0x1BAA63C", Offset = "0x1BAA63C", VA = "0x1BAA63C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000886")]
				[Address(RVA = "0x1BAA6EC", Offset = "0x1BAA6EC", VA = "0x1BAA6EC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000887")]
				[Address(RVA = "0x1BAA700", Offset = "0x1BAA700", VA = "0x1BAA700")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853F18", Offset = "0x853F18")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853F50", Offset = "0x853F50")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853F88", Offset = "0x853F88")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x186492C", Offset = "0x186492C", VA = "0x186492C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x1864A5C", Offset = "0x1864A5C", VA = "0x1864A5C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x1864AC8", Offset = "0x1864AC8", VA = "0x1864AC8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x1864C30", Offset = "0x1864C30", VA = "0x1864C30")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FC")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000FD")]
			public class BoneLink
			{
				[Token(Token = "0x40007BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8540A0", Offset = "0x8540A0")]
				public Transform bone;

				[Token(Token = "0x40007BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8540D8", Offset = "0x8540D8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8540D8", Offset = "0x8540D8")]
				public float weight;

				[Token(Token = "0x40007C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40007C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600088C")]
				[Address(RVA = "0x1BAA4D4", Offset = "0x1BAA4D4", VA = "0x1BAA4D4")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600088D")]
				[Address(RVA = "0x1BAA5EC", Offset = "0x1BAA5EC", VA = "0x1BAA5EC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600088E")]
				[Address(RVA = "0x1BAA5F8", Offset = "0x1BAA5F8", VA = "0x1BAA5F8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854030", Offset = "0x854030")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854068", Offset = "0x854068")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1864614", Offset = "0x1864614", VA = "0x1864614", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x18646B8", Offset = "0x18646B8", VA = "0x18646B8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x1864724", Offset = "0x1864724", VA = "0x1864724", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x1864918", Offset = "0x1864918", VA = "0x1864918")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853DAC", Offset = "0x853DAC")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x853DE4", Offset = "0x853DE4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000EF")]
		public bool inProgress
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x1AF7830", Offset = "0x1AF7830", VA = "0x1AF7830")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1AF7900", Offset = "0x1AF7900", VA = "0x1AF7900", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x1AF79DC", Offset = "0x1AF79DC", VA = "0x1AF79DC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1AF7C38", Offset = "0x1AF7C38", VA = "0x1AF7C38")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public abstract class Offset
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85419C", Offset = "0x85419C")]
			public string name;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8541D4", Offset = "0x8541D4")]
			public Collider collider;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85420C", Offset = "0x85420C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854258", Offset = "0x854258")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854268", Offset = "0x854268")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854278", Offset = "0x854278")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854288", Offset = "0x854288")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000F5")]
			protected float crossFader
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x1864C44", Offset = "0x1864C44", VA = "0x1864C44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A72C", Offset = "0x85A72C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000893")]
				[Address(RVA = "0x1864C4C", Offset = "0x1864C4C", VA = "0x1864C4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A73C", Offset = "0x85A73C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F6")]
			protected float timer
			{
				[Token(Token = "0x6000894")]
				[Address(RVA = "0x1864C54", Offset = "0x1864C54", VA = "0x1864C54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A74C", Offset = "0x85A74C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000895")]
				[Address(RVA = "0x1864C5C", Offset = "0x1864C5C", VA = "0x1864C5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A75C", Offset = "0x85A75C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000896")]
				[Address(RVA = "0x1864C64", Offset = "0x1864C64", VA = "0x1864C64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A76C", Offset = "0x85A76C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000897")]
				[Address(RVA = "0x1864C70", Offset = "0x1864C70", VA = "0x1864C70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A77C", Offset = "0x85A77C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000898")]
				[Address(RVA = "0x1864C7C", Offset = "0x1864C7C", VA = "0x1864C7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A78C", Offset = "0x85A78C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000899")]
				[Address(RVA = "0x1864C88", Offset = "0x1864C88", VA = "0x1864C88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A79C", Offset = "0x85A79C")]
				private set
				{
				}
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1864C94", Offset = "0x1864C94", VA = "0x1864C94")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1864DDC", Offset = "0x1864DDC", VA = "0x1864DDC")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600089C")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600089D")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600089E")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1864EC4", Offset = "0x1864EC4", VA = "0x1864EC4")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000101")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40007D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854340", Offset = "0x854340")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40007D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854378", Offset = "0x854378")]
				public float weight;

				[Token(Token = "0x40007D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40007D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60008A4")]
				[Address(RVA = "0x1BAA708", Offset = "0x1BAA708", VA = "0x1BAA708")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x1BAA798", Offset = "0x1BAA798", VA = "0x1BAA798")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008A6")]
				[Address(RVA = "0x1BAA7AC", Offset = "0x1BAA7AC", VA = "0x1BAA7AC")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854298", Offset = "0x854298")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8542D0", Offset = "0x8542D0")]
			public int upDirCurveIndex;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854308", Offset = "0x854308")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1864ED8", Offset = "0x1864ED8", VA = "0x1864ED8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1865088", Offset = "0x1865088", VA = "0x1865088", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x18650F4", Offset = "0x18650F4", VA = "0x18650F4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1865294", Offset = "0x1865294", VA = "0x1865294")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000103")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40007D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854420", Offset = "0x854420")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40007DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x854458", Offset = "0x854458")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854458", Offset = "0x854458")]
				public float weight;

				[Token(Token = "0x40007DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40007DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x1BAA7B4", Offset = "0x1BAA7B4", VA = "0x1BAA7B4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60008AC")]
				[Address(RVA = "0x1BAA890", Offset = "0x1BAA890", VA = "0x1BAA890")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x1BAA89C", Offset = "0x1BAA89C", VA = "0x1BAA89C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8543B0", Offset = "0x8543B0")]
			public int curveIndex;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8543E8", Offset = "0x8543E8")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x18652B0", Offset = "0x18652B0", VA = "0x18652B0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1865394", Offset = "0x1865394", VA = "0x1865394", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1865400", Offset = "0x1865400", VA = "0x1865400", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x18656B4", Offset = "0x18656B4", VA = "0x18656B4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85412C", Offset = "0x85412C")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854164", Offset = "0x854164")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1AF7F8C", Offset = "0x1AF7F8C", VA = "0x1AF7F8C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1AF8060", Offset = "0x1AF8060", VA = "0x1AF8060")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1AF82C4", Offset = "0x1AF82C4", VA = "0x1AF82C4")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000106")]
			public class EffectorLink
			{
				[Token(Token = "0x40007EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854688", Offset = "0x854688")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8546C0", Offset = "0x8546C0")]
				public float weight;

				[Token(Token = "0x60008B4")]
				[Address(RVA = "0x1BAA8E0", Offset = "0x1BAA8E0", VA = "0x1BAA8E0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85451C", Offset = "0x85451C")]
			public Transform transform;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854554", Offset = "0x854554")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85458C", Offset = "0x85458C")]
			public float speed;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8545C4", Offset = "0x8545C4")]
			public float acceleration;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8545FC", Offset = "0x8545FC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8545FC", Offset = "0x8545FC")]
			public float matchVelocity;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854650", Offset = "0x854650")]
			public float gravity;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1BA1A28", Offset = "0x1BA1A28", VA = "0x1BA1A28")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1BA1AE0", Offset = "0x1BA1AE0", VA = "0x1BA1AE0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1BA1D9C", Offset = "0x1BA1D9C", VA = "0x1BA1D9C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8544AC", Offset = "0x8544AC")]
		public Body[] bodies;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8544E4", Offset = "0x8544E4")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1C0AE24", Offset = "0x1C0AE24", VA = "0x1C0AE24")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1C0AEA0", Offset = "0x1C0AEA0", VA = "0x1C0AEA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x1C0AF60", Offset = "0x1C0AF60", VA = "0x1C0AF60")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8546F8", Offset = "0x8546F8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8546F8", Offset = "0x8546F8")]
		public Transform target;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x854758", Offset = "0x854758")]
		public float weight;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854770", Offset = "0x854770")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8547A8", Offset = "0x8547A8")]
		public float weightSmoothTime;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8547E0", Offset = "0x8547E0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8547E0", Offset = "0x8547E0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854840", Offset = "0x854840")]
		public float maxRadiansDelta;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854878", Offset = "0x854878")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8548B0", Offset = "0x8548B0")]
		public float slerpSpeed;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8548E8", Offset = "0x8548E8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854920", Offset = "0x854920")]
		public float minDistance;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x854958", Offset = "0x854958")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854958", Offset = "0x854958")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x854958", Offset = "0x854958")]
		public float maxRootAngle;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000F9")]
		private Vector3 pivot
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xF15FD0", Offset = "0xF15FD0", VA = "0xF15FD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xF15F5C", Offset = "0xF15F5C", VA = "0xF15F5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xF16060", Offset = "0xF16060", VA = "0xF16060")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xF1657C", Offset = "0xF1657C", VA = "0xF1657C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xF16668", Offset = "0xF16668", VA = "0xF16668")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xF16860", Offset = "0xF16860", VA = "0xF16860")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854A44", Offset = "0x854A44")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854A7C", Offset = "0x854A7C")]
			public float spring;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854AB4", Offset = "0x854AB4")]
			public bool x;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854AEC", Offset = "0x854AEC")]
			public bool y;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854B24", Offset = "0x854B24")]
			public bool z;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854B5C", Offset = "0x854B5C")]
			public float minX;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854B94", Offset = "0x854B94")]
			public float maxX;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854BCC", Offset = "0x854BCC")]
			public float minY;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854C04", Offset = "0x854C04")]
			public float maxY;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854C3C", Offset = "0x854C3C")]
			public float minZ;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854C74", Offset = "0x854C74")]
			public float maxZ;

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x1BA4614", Offset = "0x1BA4614", VA = "0x1BA4614")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1BA476C", Offset = "0x1BA476C", VA = "0x1BA476C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1BA47E4", Offset = "0x1BA47E4", VA = "0x1BA47E4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1BA483C", Offset = "0x1BA483C", VA = "0x1BA483C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B288", Offset = "0x84B288")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000FB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008CA")]
				[Address(RVA = "0x1BA45C4", Offset = "0x1BA45C4", VA = "0x1BA45C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008CC")]
				[Address(RVA = "0x1BA460C", Offset = "0x1BA460C", VA = "0x1BA460C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1BA4444", Offset = "0x1BA4444", VA = "0x1BA4444")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1BA4470", Offset = "0x1BA4470", VA = "0x1BA4470", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1BA4474", Offset = "0x1BA4474", VA = "0x1BA4474", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x1BA45CC", Offset = "0x1BA45CC", VA = "0x1BA45CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8549D4", Offset = "0x8549D4")]
		public float weight;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854A0C", Offset = "0x854A0C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000FA")]
		protected float deltaTime
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xF1E6C4", Offset = "0xF1E6C4", VA = "0xF1E6C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008BC")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xF186E8", Offset = "0xF186E8", VA = "0xF186E8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xF1E6F0", Offset = "0xF1E6F0", VA = "0xF1E6F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A7AC", Offset = "0x85A7AC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xF1E75C", Offset = "0xF1E75C", VA = "0xF1E75C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xF1E838", Offset = "0xF1E838", VA = "0xF1E838")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xF18A58", Offset = "0xF18A58", VA = "0xF18A58", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xF18B78", Offset = "0xF18B78", VA = "0xF18B78")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B298", Offset = "0x84B298")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D7")]
				[Address(RVA = "0x1BA49C4", Offset = "0x1BA49C4", VA = "0x1BA49C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008D9")]
				[Address(RVA = "0x1BA4A0C", Offset = "0x1BA4A0C", VA = "0x1BA4A0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x1BA4844", Offset = "0x1BA4844", VA = "0x1BA4844")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1BA4870", Offset = "0x1BA4870", VA = "0x1BA4870", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1BA4874", Offset = "0x1BA4874", VA = "0x1BA4874", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x1BA49CC", Offset = "0x1BA49CC", VA = "0x1BA49CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854CAC", Offset = "0x854CAC")]
		public float weight;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854CE4", Offset = "0x854CE4")]
		public VRIK ik;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000FD")]
		protected float deltaTime
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xF1E8F8", Offset = "0xF1E8F8", VA = "0xF1E8F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008CE")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xF1E924", Offset = "0xF1E924", VA = "0xF1E924", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xF1E950", Offset = "0xF1E950", VA = "0xF1E950")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A85C", Offset = "0x85A85C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xF1E9BC", Offset = "0xF1E9BC", VA = "0xF1E9BC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xF1EA98", Offset = "0xF1EA98", VA = "0xF1EA98", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xF1EBA4", Offset = "0xF1EBA4", VA = "0xF1EBA4")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class EffectorLink
		{
			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x1BA4A14", Offset = "0x1BA4A14", VA = "0x1BA4A14")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1BA4C30", Offset = "0x1BA4C30", VA = "0x1BA4C30")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xF1EBB4", Offset = "0xF1EBB4", VA = "0xF1EBB4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xF1EC78", Offset = "0xF1EC78", VA = "0xF1EC78")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xF1ED34", Offset = "0xF1ED34", VA = "0xF1ED34")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x2000111")]
			public class EffectorLink
			{
				[Token(Token = "0x4000827")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854EF8", Offset = "0x854EF8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000828")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854F30", Offset = "0x854F30")]
				public float weight;

				[Token(Token = "0x60008E5")]
				[Address(RVA = "0x1BAA8F0", Offset = "0x1BAA8F0", VA = "0x1BAA8F0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854D54", Offset = "0x854D54")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854D8C", Offset = "0x854D8C")]
			public Transform raycastTo;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x854DC4", Offset = "0x854DC4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854DC4", Offset = "0x854DC4")]
			public float raycastRadius;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854E18", Offset = "0x854E18")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854E50", Offset = "0x854E50")]
			public float smoothTimeIn;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854E88", Offset = "0x854E88")]
			public float smoothTimeOut;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854EC0", Offset = "0x854EC0")]
			public LayerMask layers;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1BA4C38", Offset = "0x1BA4C38", VA = "0x1BA4C38")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x1BA4D7C", Offset = "0x1BA4D7C", VA = "0x1BA4D7C")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x1BA4E74", Offset = "0x1BA4E74", VA = "0x1BA4E74")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x1BA5044", Offset = "0x1BA5044", VA = "0x1BA5044")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854D1C", Offset = "0x854D1C")]
		public Avoider[] avoiders;

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xF1F6DC", Offset = "0xF1F6DC", VA = "0xF1F6DC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xF1F764", Offset = "0xF1F764", VA = "0xF1F764")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000114")]
			public class EffectorLink
			{
				[Token(Token = "0x4000846")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8552BC", Offset = "0x8552BC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000847")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8552F4", Offset = "0x8552F4")]
				public float weight;

				[Token(Token = "0x60008F5")]
				[Address(RVA = "0x1BAA904", Offset = "0x1BAA904", VA = "0x1BAA904")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8551C0", Offset = "0x8551C0")]
			public Vector3 offset;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8551F8", Offset = "0x8551F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8551F8", Offset = "0x8551F8")]
			public float additivity;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85524C", Offset = "0x85524C")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855284", Offset = "0x855284")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1BA779C", Offset = "0x1BA779C", VA = "0x1BA779C")]
			public void Start()
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1BA77EC", Offset = "0x1BA77EC", VA = "0x1BA77EC")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1BA79B0", Offset = "0x1BA79B0", VA = "0x1BA79B0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public enum Handedness
		{
			[Token(Token = "0x4000849")]
			Right,
			[Token(Token = "0x400084A")]
			Left
		}

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854F68", Offset = "0x854F68")]
		public AimIK aimIK;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854FA0", Offset = "0x854FA0")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x854FD8", Offset = "0x854FD8")]
		public Handedness handedness;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855010", Offset = "0x855010")]
		public bool twoHanded;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855048", Offset = "0x855048")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855080", Offset = "0x855080")]
		public float magnitudeRandom;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8550B8", Offset = "0x8550B8")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8550F0", Offset = "0x8550F0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855128", Offset = "0x855128")]
		public float blendTime;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855160", Offset = "0x855160")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x855160", Offset = "0x855160")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000100")]
		public bool isFinished
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x176C844", Offset = "0x176C844", VA = "0x176C844")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000101")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x176D2BC", Offset = "0x176D2BC", VA = "0x176D2BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x176D2FC", Offset = "0x176D2FC", VA = "0x176D2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		private Transform primaryHand
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x176D27C", Offset = "0x176D27C", VA = "0x176D27C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x176D29C", Offset = "0x176D29C", VA = "0x176D29C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x176C874", Offset = "0x176C874", VA = "0x176C874")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x176C8A0", Offset = "0x176C8A0", VA = "0x176C8A0")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x176C9E8", Offset = "0x176C9E8", VA = "0x176C9E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x176D33C", Offset = "0x176D33C", VA = "0x176D33C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x176D3F0", Offset = "0x176D3F0", VA = "0x176D3F0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x176D42C", Offset = "0x176D42C", VA = "0x176D42C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x176D5E8", Offset = "0x176D5E8", VA = "0x176D5E8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85532C", Offset = "0x85532C")]
		public float weight;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855364", Offset = "0x855364")]
		public float offset;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1770610", Offset = "0x1770610", VA = "0x1770610")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x17706F8", Offset = "0x17706F8", VA = "0x17706F8")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x17707E0", Offset = "0x17707E0", VA = "0x17707E0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x1770B34", Offset = "0x1770B34", VA = "0x1770B34")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x1770B6C", Offset = "0x1770B6C", VA = "0x1770B6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x1770C78", Offset = "0x1770C78", VA = "0x1770C78")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public class Settings
		{
			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85539C", Offset = "0x85539C")]
			public float scaleMlp;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8553D4", Offset = "0x8553D4")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85540C", Offset = "0x85540C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855444", Offset = "0x855444")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85547C", Offset = "0x85547C")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8554B4", Offset = "0x8554B4")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8554EC", Offset = "0x8554EC")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855524", Offset = "0x855524")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85555C", Offset = "0x85555C")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855594", Offset = "0x855594")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x855594", Offset = "0x855594")]
			public Vector3 headOffset;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8555E4", Offset = "0x8555E4")]
			public Vector3 handOffset;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85561C", Offset = "0x85561C")]
			public float footForwardOffset;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855654", Offset = "0x855654")]
			public float footInwardOffset;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85568C", Offset = "0x85568C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85568C", Offset = "0x85568C")]
			public float footHeadingOffset;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8556E8", Offset = "0x8556E8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855700", Offset = "0x855700")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1BAA008", Offset = "0x1BAA008", VA = "0x1BAA008")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000119")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x200011A")]
			public class Target
			{
				[Token(Token = "0x400086B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400086C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400086D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000903")]
				[Address(RVA = "0x1BAA90C", Offset = "0x1BAA90C", VA = "0x1BAA90C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000904")]
				[Address(RVA = "0x1BAA9CC", Offset = "0x1BAA9CC", VA = "0x1BAA9CC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1BAA000", Offset = "0x1BAA000", VA = "0x1BAA000")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x185DB10", Offset = "0x185DB10", VA = "0x185DB10")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x185BE24", Offset = "0x185BE24", VA = "0x185BE24")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x185DC6C", Offset = "0x185DC6C", VA = "0x185DC6C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x185D030", Offset = "0x185D030", VA = "0x185D030")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x185E458", Offset = "0x185E458", VA = "0x185E458")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x185E84C", Offset = "0x185E84C", VA = "0x185E84C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x185E8A0", Offset = "0x185E8A0", VA = "0x185E8A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x185E8D4", Offset = "0x185E8D4", VA = "0x185E8D4")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x185EA10", Offset = "0x185EA10", VA = "0x185EA10")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855718", Offset = "0x855718")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000105")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x185F100", Offset = "0x185F100", VA = "0x185F100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A90C", Offset = "0x85A90C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x185F10C", Offset = "0x185F10C", VA = "0x185F10C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85A91C", Offset = "0x85A91C")]
			private set
			{
			}
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x185F118", Offset = "0x185F118", VA = "0x185F118")]
		private void Awake()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x185E260", Offset = "0x185E260", VA = "0x185E260")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x185E6C8", Offset = "0x185E6C8", VA = "0x185E6C8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x185F260", Offset = "0x185F260", VA = "0x185F260")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x185F67C", Offset = "0x185F67C", VA = "0x185F67C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x185F784", Offset = "0x185F784", VA = "0x185F784")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200011D")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011E")]
		public class Offset
		{
			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x1862680", Offset = "0x1862680", VA = "0x1862680")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x18627E0", Offset = "0x18627E0", VA = "0x18627E0")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1AEB01C", Offset = "0x1AEB01C", VA = "0x1AEB01C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1AEB070", Offset = "0x1AEB070", VA = "0x1AEB070")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1AEB0EC", Offset = "0x1AEB0EC", VA = "0x1AEB0EC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1AEB1C4", Offset = "0x1AEB1C4", VA = "0x1AEB1C4")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x194EACC", Offset = "0x194EACC", VA = "0x194EACC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x194EB50", Offset = "0x194EB50", VA = "0x194EB50")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855760", Offset = "0x855760")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x194F984", Offset = "0x194F984", VA = "0x194F984")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x194F9FC", Offset = "0x194F9FC", VA = "0x194F9FC")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x1770410", Offset = "0x1770410", VA = "0x1770410")]
		private void Start()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1770454", Offset = "0x1770454", VA = "0x1770454")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x1770608", Offset = "0x1770608", VA = "0x1770608")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855798", Offset = "0x855798")]
		public AimPoser aimPoser;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8557D0", Offset = "0x8557D0")]
		public AimIK aim;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855808", Offset = "0x855808")]
		public LookAtIK lookAt;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855840", Offset = "0x855840")]
		public Animator animator;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855878", Offset = "0x855878")]
		public float crossfadeTime;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8558B0", Offset = "0x8558B0")]
		public float minAimDistance;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1770C8C", Offset = "0x1770C8C", VA = "0x1770C8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x1770CD0", Offset = "0x1770CD0", VA = "0x1770CD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1770E38", Offset = "0x1770E38", VA = "0x1770E38")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1770FC8", Offset = "0x1770FC8", VA = "0x1770FC8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x1771104", Offset = "0x1771104", VA = "0x1771104")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1771180", Offset = "0x1771180", VA = "0x1771180")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x1774308", Offset = "0x1774308", VA = "0x1774308")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1774478", Offset = "0x1774478", VA = "0x1774478")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x177460C", Offset = "0x177460C", VA = "0x177460C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8558E8", Offset = "0x8558E8")]
		public Animator animator;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x855920", Offset = "0x855920")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855958", Offset = "0x855958")]
		public float lookAtWeight;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855970", Offset = "0x855970")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855988", Offset = "0x855988")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8559A0", Offset = "0x8559A0")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8559B8", Offset = "0x8559B8")]
		public float lookAtClampWeight;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8559D0", Offset = "0x8559D0")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8559E8", Offset = "0x8559E8")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x855A00", Offset = "0x855A00")]
		public Transform footTargetBiped;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855A38", Offset = "0x855A38")]
		public float footPositionWeight;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855A50", Offset = "0x855A50")]
		public float footRotationWeight;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x855A68", Offset = "0x855A68")]
		public Transform handTargetBiped;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855AA0", Offset = "0x855AA0")]
		public float handPositionWeight;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855AB8", Offset = "0x855AB8")]
		public float handRotationWeight;

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x195B048", Offset = "0x195B048", VA = "0x195B048")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x195B450", Offset = "0x195B450", VA = "0x195B450")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xF16A5C", Offset = "0xF16A5C", VA = "0xF16A5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xF17268", Offset = "0xF17268", VA = "0xF17268")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xF17018", Offset = "0xF17018", VA = "0xF17018")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xF17364", Offset = "0xF17364", VA = "0xF17364")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000106")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0xF17390", Offset = "0xF17390", VA = "0xF17390")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xF17414", Offset = "0xF17414", VA = "0xF17414")]
		private void Update()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xF17638", Offset = "0xF17638", VA = "0xF17638")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B2A8", Offset = "0x84B2A8")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000109")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600093E")]
				[Address(RVA = "0x1BA3D7C", Offset = "0x1BA3D7C", VA = "0x1BA3D7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000940")]
				[Address(RVA = "0x1BA3DC4", Offset = "0x1BA3DC4", VA = "0x1BA3DC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1BA3A8C", Offset = "0x1BA3A8C", VA = "0x1BA3A8C")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x1BA3AB8", Offset = "0x1BA3AB8", VA = "0x1BA3AB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x1BA3ABC", Offset = "0x1BA3ABC", VA = "0x1BA3ABC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x1BA3D84", Offset = "0x1BA3D84", VA = "0x1BA3D84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x17000107")]
		public bool isStepping
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0xF1764C", Offset = "0xF1764C", VA = "0xF1764C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000108")]
		public Vector3 position
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0xF17330", Offset = "0xF17330", VA = "0xF17330")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0xF17660", Offset = "0xF17660", VA = "0xF17660")]
			set
			{
			}
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xF176B0", Offset = "0xF176B0", VA = "0xF176B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xF178A4", Offset = "0xF178A4", VA = "0xF178A4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xF17A40", Offset = "0xF17A40", VA = "0xF17A40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xF17C68", Offset = "0xF17C68", VA = "0xF17C68")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xF17F0C", Offset = "0xF17F0C", VA = "0xF17F0C")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xF18084", Offset = "0xF18084", VA = "0xF18084")]
		private void Update()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xF17BC0", Offset = "0xF17BC0", VA = "0xF17BC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A92C", Offset = "0x85A92C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xF18280", Offset = "0xF18280", VA = "0xF18280")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xF182E4", Offset = "0xF182E4", VA = "0xF182E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xF183A4", Offset = "0xF183A4", VA = "0xF183A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xF185F8", Offset = "0xF185F8", VA = "0xF185F8")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200012B")]
		public struct Warp
		{
			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855B90", Offset = "0x855B90")]
			public int animationLayer;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855BC8", Offset = "0x855BC8")]
			public string animationState;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855C00", Offset = "0x855C00")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855C38", Offset = "0x855C38")]
			public Transform warpFrom;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855C70", Offset = "0x855C70")]
			public Transform warpTo;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855CA8", Offset = "0x855CA8")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200012C")]
		public enum EffectorMode
		{
			[Token(Token = "0x40008E9")]
			PositionOffset,
			[Token(Token = "0x40008EA")]
			Position
		}

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855AD0", Offset = "0x855AD0")]
		public Animator animator;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855B08", Offset = "0x855B08")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x855B40", Offset = "0x855B40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855B40", Offset = "0x855B40")]
		public Warp[] warps;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x194FBF4", Offset = "0x194FBF4", VA = "0x194FBF4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x194FC20", Offset = "0x194FC20", VA = "0x194FC20")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x194FE60", Offset = "0x194FE60", VA = "0x194FE60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1950124", Offset = "0x1950124", VA = "0x1950124")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x19501C4", Offset = "0x19501C4", VA = "0x19501C4")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B2B8", Offset = "0x84B2B8")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x19501CC", Offset = "0x19501CC", VA = "0x19501CC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1950220", Offset = "0x1950220", VA = "0x1950220")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x19503BC", Offset = "0x19503BC", VA = "0x19503BC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x19505C4", Offset = "0x19505C4", VA = "0x19505C4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B318", Offset = "0x84B318")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B318", Offset = "0x84B318")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855CE0", Offset = "0x855CE0")]
		public float headLookWeight;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x19505D8", Offset = "0x19505D8", VA = "0x19505D8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1950764", Offset = "0x1950764", VA = "0x1950764", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x19507E0", Offset = "0x19507E0", VA = "0x19507E0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x19508D4", Offset = "0x19508D4", VA = "0x19508D4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x195091C", Offset = "0x195091C", VA = "0x195091C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1950D08", Offset = "0x1950D08", VA = "0x1950D08")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1950B90", Offset = "0x1950B90", VA = "0x1950B90")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x1950F64", Offset = "0x1950F64", VA = "0x1950F64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x1951070", Offset = "0x1951070", VA = "0x1951070")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B3AC", Offset = "0x84B3AC")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x1918690", Offset = "0x1918690", VA = "0x1918690", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x19186EC", Offset = "0x19186EC", VA = "0x19186EC", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1918928", Offset = "0x1918928", VA = "0x1918928")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1918A1C", Offset = "0x1918A1C", VA = "0x1918A1C")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B40C", Offset = "0x84B40C")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700010B")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1919440", Offset = "0x1919440", VA = "0x1919440")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700010C")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x19194C4", Offset = "0x19194C4", VA = "0x19194C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x1919248", Offset = "0x1919248", VA = "0x1919248")]
		private void Start()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x19192B4", Offset = "0x19192B4", VA = "0x19192B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x1919548", Offset = "0x1919548", VA = "0x1919548")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855CF8", Offset = "0x855CF8")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x191D100", Offset = "0x191D100", VA = "0x191D100", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x191D560", Offset = "0x191D560", VA = "0x191D560")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x191D568", Offset = "0x191D568", VA = "0x191D568")]
		private void Start()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x191D610", Offset = "0x191D610", VA = "0x191D610")]
		private void Update()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x191D994", Offset = "0x191D994", VA = "0x191D994")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x191DA40", Offset = "0x191DA40", VA = "0x191DA40")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000134")]
		public class Limb
		{
			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1862168", Offset = "0x1862168", VA = "0x1862168")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x18621EC", Offset = "0x18621EC", VA = "0x18621EC")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x192130C", Offset = "0x192130C", VA = "0x192130C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x1921464", Offset = "0x1921464", VA = "0x1921464")]
		private void Start()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x1921508", Offset = "0x1921508", VA = "0x1921508")]
		private void Update()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x192150C", Offset = "0x192150C", VA = "0x192150C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x192151C", Offset = "0x192151C", VA = "0x192151C")]
		private void Start()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1921590", Offset = "0x1921590", VA = "0x1921590")]
		private void Update()
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1921664", Offset = "0x1921664", VA = "0x1921664")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855D10", Offset = "0x855D10")]
		public Transform target;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855D48", Offset = "0x855D48")]
		public Transform pin;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855D80", Offset = "0x855D80")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855DB8", Offset = "0x855DB8")]
		public AimIK aim;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855DF0", Offset = "0x855DF0")]
		public float weight;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855E28", Offset = "0x855E28")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855E60", Offset = "0x855E60")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x192166C", Offset = "0x192166C", VA = "0x192166C")]
		private void Start()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x19216C0", Offset = "0x19216C0", VA = "0x19216C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1921834", Offset = "0x1921834", VA = "0x1921834")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1AEA9D8", Offset = "0x1AEA9D8", VA = "0x1AEA9D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1AEAAA0", Offset = "0x1AEAAA0", VA = "0x1AEAAA0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x1AEAB30", Offset = "0x1AEAB30", VA = "0x1AEAB30")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1AEAF08", Offset = "0x1AEAF08", VA = "0x1AEAF08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1AEB014", Offset = "0x1AEB014", VA = "0x1AEB014")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855E98", Offset = "0x855E98")]
		public float aimWeight;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855EB0", Offset = "0x855EB0")]
		public float sightWeight;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855EC8", Offset = "0x855EC8")]
		public float maxAngle;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855EE4", Offset = "0x855EE4")]
		public float cameraRecoilWeight;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1AEB1CC", Offset = "0x1AEB1CC", VA = "0x1AEB1CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1AEB340", Offset = "0x1AEB340", VA = "0x1AEB340")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1AEB34C", Offset = "0x1AEB34C", VA = "0x1AEB34C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1AEB5CC", Offset = "0x1AEB5CC", VA = "0x1AEB5CC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1AEB778", Offset = "0x1AEB778", VA = "0x1AEB778")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1AEB414", Offset = "0x1AEB414", VA = "0x1AEB414")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1AEC06C", Offset = "0x1AEC06C", VA = "0x1AEC06C")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B46C", Offset = "0x84B46C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B46C", Offset = "0x84B46C")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x855EFC", Offset = "0x855EFC")]
		public float walkSpeed;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1AEC08C", Offset = "0x1AEC08C", VA = "0x1AEC08C")]
		private void Start()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1AEC104", Offset = "0x1AEC104", VA = "0x1AEC104")]
		private void Update()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1AEC1F0", Offset = "0x1AEC1F0", VA = "0x1AEC1F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1AEC2A8", Offset = "0x1AEC2A8", VA = "0x1AEC2A8")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1AF7C40", Offset = "0x1AF7C40", VA = "0x1AF7C40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1AF7D98", Offset = "0x1AF7D98", VA = "0x1AF7D98")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1AF7F7C", Offset = "0x1AF7F7C", VA = "0x1AF7F7C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1AF8618", Offset = "0x1AF8618", VA = "0x1AF8618")]
		private void Start()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x1AF8760", Offset = "0x1AF8760", VA = "0x1AF8760")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1AF8A9C", Offset = "0x1AF8A9C", VA = "0x1AF8A9C")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x1C0B0AC", Offset = "0x1C0B0AC", VA = "0x1C0B0AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1C0B2F8", Offset = "0x1C0B2F8", VA = "0x1C0B2F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1C0B404", Offset = "0x1C0B404", VA = "0x1C0B404")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1C0B40C", Offset = "0x1C0B40C", VA = "0x1C0B40C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1C0BC20", Offset = "0x1C0BC20", VA = "0x1C0BC20")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B500", Offset = "0x84B500")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855F14", Offset = "0x855F14")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855F4C", Offset = "0x855F4C")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1C13390", Offset = "0x1C13390", VA = "0x1C13390")]
		private void Awake()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1C133E4", Offset = "0x1C133E4", VA = "0x1C133E4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1C1371C", Offset = "0x1C1371C", VA = "0x1C1371C")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public class Partner
		{
			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700010D")]
			private Transform neck
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x1BA3A20", Offset = "0x1BA3A20", VA = "0x1BA3A20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x1BA32D4", Offset = "0x1BA32D4", VA = "0x1BA32D4")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x1BA32F4", Offset = "0x1BA32F4", VA = "0x1BA32F4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x1BA388C", Offset = "0x1BA388C", VA = "0x1BA388C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x1BA3A78", Offset = "0x1BA3A78", VA = "0x1BA3A78")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1C1528C", Offset = "0x1C1528C", VA = "0x1C1528C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1C152C8", Offset = "0x1C152C8", VA = "0x1C152C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1C15330", Offset = "0x1C15330", VA = "0x1C15330")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000142")]
		public enum Mode
		{
			[Token(Token = "0x4000975")]
			Position,
			[Token(Token = "0x4000976")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000143")]
		public class Absorber
		{
			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856064", Offset = "0x856064")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85609C", Offset = "0x85609C")]
			public float weight;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1BA3DCC", Offset = "0x1BA3DCC", VA = "0x1BA3DCC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x1BA3EA0", Offset = "0x1BA3EA0", VA = "0x1BA3EA0")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x1BA3EDC", Offset = "0x1BA3EDC", VA = "0x1BA3EDC")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x1BA3F74", Offset = "0x1BA3F74", VA = "0x1BA3F74")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x1BA3FE8", Offset = "0x1BA3FE8", VA = "0x1BA3FE8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855F84", Offset = "0x855F84")]
		public Mode mode;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855FBC", Offset = "0x855FBC")]
		public Absorber[] absorbers;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x855FF4", Offset = "0x855FF4")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85602C", Offset = "0x85602C")]
		public float falloffSpeed;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xF18600", Offset = "0xF18600", VA = "0xF18600", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xF18714", Offset = "0xF18714", VA = "0xF18714")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xF187A4", Offset = "0xF187A4", VA = "0xF187A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xF188B8", Offset = "0xF188B8", VA = "0xF188B8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xF18944", Offset = "0xF18944", VA = "0xF18944", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xF18B64", Offset = "0xF18B64", VA = "0xF18B64")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xF18B88", Offset = "0xF18B88", VA = "0xF18B88")]
		private void Start()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xF18BFC", Offset = "0xF18BFC", VA = "0xF18BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xF18CD8", Offset = "0xF18CD8", VA = "0xF18CD8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xF18D98", Offset = "0xF18D98", VA = "0xF18D98")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public class EffectorLink
		{
			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x1BA4434", Offset = "0x1BA4434", VA = "0x1BA4434")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xF1E41C", Offset = "0xF1E41C", VA = "0xF1E41C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xF1E528", Offset = "0xF1E528", VA = "0xF1E528", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xF1E6B4", Offset = "0xF1E6B4", VA = "0xF1E6B4")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B560", Offset = "0x84B560")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8560E4", Offset = "0x8560E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8560E4", Offset = "0x8560E4")]
		public float weight;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856138", Offset = "0x856138")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856170", Offset = "0x856170")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8561BC", Offset = "0x8561BC")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xF1ED90", Offset = "0xF1ED90", VA = "0xF1ED90")]
		private void Start()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xF1F054", Offset = "0xF1F054", VA = "0xF1F054")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xF1F69C", Offset = "0xF1F69C", VA = "0xF1F69C")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700010E")]
		private bool holding
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0xF209D0", Offset = "0xF209D0", VA = "0xF209D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xF206FC", Offset = "0xF206FC", VA = "0xF206FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009AE")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xF209F0", Offset = "0xF209F0", VA = "0xF209F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xF20B78", Offset = "0xF20B78", VA = "0xF20B78")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xF20CFC", Offset = "0xF20CFC", VA = "0xF20CFC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xF20DD8", Offset = "0xF20DD8", VA = "0xF20DD8")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xF20F0C", Offset = "0xF20F0C", VA = "0xF20F0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xF21070", Offset = "0xF21070", VA = "0xF21070")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xF2123C", Offset = "0xF2123C", VA = "0xF2123C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xF21250", Offset = "0xF21250", VA = "0xF21250", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xF213AC", Offset = "0xF213AC", VA = "0xF213AC")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xF213C0", Offset = "0xF213C0", VA = "0xF213C0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xF214F4", Offset = "0xF214F4", VA = "0xF214F4")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x176C3D8", Offset = "0x176C3D8", VA = "0x176C3D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x176C4B8", Offset = "0x176C4B8", VA = "0x176C4B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x176C5CC", Offset = "0x176C5CC", VA = "0x176C5CC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B5C0", Offset = "0x84B5C0")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x176D654", Offset = "0x176D654", VA = "0x176D654")]
		private void Start()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x176D6A8", Offset = "0x176D6A8", VA = "0x176D6A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x176D700", Offset = "0x176D700", VA = "0x176D700")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x176D7E0", Offset = "0x176D7E0", VA = "0x176D7E0")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B620", Offset = "0x84B620")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x1700010F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C9")]
				[Address(RVA = "0x1BA7BA0", Offset = "0x1BA7BA0", VA = "0x1BA7BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000110")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0x1BA7BE8", Offset = "0x1BA7BE8", VA = "0x1BA7BE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x1BA79C4", Offset = "0x1BA79C4", VA = "0x1BA79C4")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x1BA79F0", Offset = "0x1BA79F0", VA = "0x1BA79F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x1BA79F4", Offset = "0x1BA79F4", VA = "0x1BA79F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x1BA7BA8", Offset = "0x1BA7BA8", VA = "0x1BA7BA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x176D7F0", Offset = "0x176D7F0", VA = "0x176D7F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x176D8A4", Offset = "0x176D8A4", VA = "0x176D8A4")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x176D8EC", Offset = "0x176D8EC", VA = "0x176D8EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85A9DC", Offset = "0x85A9DC")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x176D968", Offset = "0x176D968", VA = "0x176D968")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B630", Offset = "0x84B630")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B690", Offset = "0x84B690")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000111")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D2")]
				[Address(RVA = "0x1BA810C", Offset = "0x1BA810C", VA = "0x1BA810C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000112")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D4")]
				[Address(RVA = "0x1BA8154", Offset = "0x1BA8154", VA = "0x1BA8154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x1BA7FB4", Offset = "0x1BA7FB4", VA = "0x1BA7FB4")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x1BA7FE0", Offset = "0x1BA7FE0", VA = "0x1BA7FE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x1BA7FE4", Offset = "0x1BA7FE4", VA = "0x1BA7FE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x1BA8114", Offset = "0x1BA8114", VA = "0x1BA8114", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x177249C", Offset = "0x177249C", VA = "0x177249C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x1772548", Offset = "0x1772548", VA = "0x1772548")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AA8C", Offset = "0x85AA8C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x17725B4", Offset = "0x17725B4", VA = "0x17725B4")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000152")]
		public class EffectorLink
		{
			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1BA8178", Offset = "0x1BA8178", VA = "0x1BA8178")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1BA8418", Offset = "0x1BA8418", VA = "0x1BA8418")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1BA8500", Offset = "0x1BA8500", VA = "0x1BA8500")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1BA8994", Offset = "0x1BA8994", VA = "0x1BA8994")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1BA8A88", Offset = "0x1BA8A88", VA = "0x1BA8A88")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1BA8B20", Offset = "0x1BA8B20", VA = "0x1BA8B20")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x1BA8BB4", Offset = "0x1BA8BB4", VA = "0x1BA8BB4")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1BA8C48", Offset = "0x1BA8C48", VA = "0x1BA8C48")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1BA8DBC", Offset = "0x1BA8DBC", VA = "0x1BA8DBC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x177463C", Offset = "0x177463C", VA = "0x177463C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x17746B8", Offset = "0x17746B8", VA = "0x17746B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1774728", Offset = "0x1774728", VA = "0x1774728")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x17747F0", Offset = "0x17747F0", VA = "0x17747F0")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856208", Offset = "0x856208")]
		public Transform to;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856240", Offset = "0x856240")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x856240", Offset = "0x856240")]
		public float transferMotion;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x17747F8", Offset = "0x17747F8", VA = "0x17747F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x1774834", Offset = "0x1774834", VA = "0x1774834")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x17748E8", Offset = "0x17748E8", VA = "0x17748E8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856294", Offset = "0x856294")]
		public Transform leftHandTarget;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x17756A0", Offset = "0x17756A0", VA = "0x17756A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x1775890", Offset = "0x1775890", VA = "0x1775890")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1775A80", Offset = "0x1775A80", VA = "0x1775A80")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1775B4C", Offset = "0x1775B4C", VA = "0x1775B4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1775C58", Offset = "0x1775C58", VA = "0x1775C58")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x1776230", Offset = "0x1776230", VA = "0x1776230", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x17765BC", Offset = "0x17765BC", VA = "0x17765BC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1776828", Offset = "0x1776828", VA = "0x1776828")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1AF0DC0", Offset = "0x1AF0DC0", VA = "0x1AF0DC0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1AF10E8", Offset = "0x1AF10E8", VA = "0x1AF10E8")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x1AF1168", Offset = "0x1AF1168", VA = "0x1AF1168")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B6A0", Offset = "0x84B6A0")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0x1BA5198", Offset = "0x1BA5198", VA = "0x1BA5198", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FB")]
				[Address(RVA = "0x1BA51E0", Offset = "0x1BA51E0", VA = "0x1BA51E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x1BA5058", Offset = "0x1BA5058", VA = "0x1BA5058")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x1BA5084", Offset = "0x1BA5084", VA = "0x1BA5084", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x1BA5088", Offset = "0x1BA5088", VA = "0x1BA5088", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1BA51A0", Offset = "0x1BA51A0", VA = "0x1BA51A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xF218CC", Offset = "0xF218CC", VA = "0xF218CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xF219F8", Offset = "0xF219F8", VA = "0xF219F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xF2198C", Offset = "0xF2198C", VA = "0xF2198C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AB3C", Offset = "0x85AB3C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xF21B7C", Offset = "0xF21B7C", VA = "0xF21B7C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xF21C68", Offset = "0xF21C68", VA = "0xF21C68")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xF21D50", Offset = "0xF21D50", VA = "0xF21D50")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8562CC", Offset = "0x8562CC")]
		public float weight;

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1959F3C", Offset = "0x1959F3C", VA = "0x1959F3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1959FB0", Offset = "0x1959FB0", VA = "0x1959FB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x195A068", Offset = "0x195A068", VA = "0x195A068")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public class Part
		{
			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x1BA8DF0", Offset = "0x1BA8DF0", VA = "0x1BA8DF0")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1BA8F1C", Offset = "0x1BA8F1C", VA = "0x1BA8F1C")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1774CD0", Offset = "0x1774CD0", VA = "0x1774CD0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1774D4C", Offset = "0x1774D4C", VA = "0x1774D4C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1AF82CC", Offset = "0x1AF82CC", VA = "0x1AF82CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1AF8424", Offset = "0x1AF8424", VA = "0x1AF8424")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1AF8608", Offset = "0x1AF8608", VA = "0x1AF8608")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8562E4", Offset = "0x8562E4")]
		public VRIK ik;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85631C", Offset = "0x85631C")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856354", Offset = "0x856354")]
		public Transform headTracker;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85638C", Offset = "0x85638C")]
		public Transform bodyTracker;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8563C4", Offset = "0x8563C4")]
		public Transform leftHandTracker;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8563FC", Offset = "0x8563FC")]
		public Transform rightHandTracker;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856434", Offset = "0x856434")]
		public Transform leftFootTracker;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85646C", Offset = "0x85646C")]
		public Transform rightFootTracker;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8564A4", Offset = "0x8564A4")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x185BCC0", Offset = "0x185BCC0", VA = "0x185BCC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x185DC08", Offset = "0x185DC08", VA = "0x185DC08")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x185EA28", Offset = "0x185EA28", VA = "0x185EA28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x185EA84", Offset = "0x185EA84", VA = "0x185EA84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x185EC0C", Offset = "0x185EC0C", VA = "0x185EC0C")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x185EC40", Offset = "0x185EC40", VA = "0x185EC40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x185F0C4", Offset = "0x185F0C4", VA = "0x185F0C4")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B6B0", Offset = "0x84B6B0")]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x195108C", Offset = "0x195108C", VA = "0x195108C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x19510E0", Offset = "0x19510E0", VA = "0x19510E0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x195113C", Offset = "0x195113C", VA = "0x195113C")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1954E9C", Offset = "0x1954E9C", VA = "0x1954E9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x19550C4", Offset = "0x19550C4", VA = "0x19550C4")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class BoardController : MonoBehaviour
	{
		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int groundLayer;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationTarget;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float torque;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float skidDrag;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float turnSensitivity;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isGrounded;

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x1916040", Offset = "0x1916040", VA = "0x1916040")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x1916094", Offset = "0x1916094", VA = "0x1916094")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x19161EC", Offset = "0x19161EC", VA = "0x19161EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x191642C", Offset = "0x191642C", VA = "0x191642C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x1916488", Offset = "0x1916488", VA = "0x1916488")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x19164E4", Offset = "0x19164E4", VA = "0x19164E4")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x191653C", Offset = "0x191653C", VA = "0x191653C")]
		public BoardController()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x17000115")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x1917BF8", Offset = "0x1917BF8", VA = "0x1917BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x1917C78", Offset = "0x1917C78", VA = "0x1917C78", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x1918184", Offset = "0x1918184", VA = "0x1918184")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x2000165")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x2000166")]
			public class Anim
			{
				[Token(Token = "0x4000A1D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x4000A1E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x4000A1F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x4000A20")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x6000A22")]
				[Address(RVA = "0x1BAA4CC", Offset = "0x1BAA4CC", VA = "0x1BAA4CC")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x18617C8", Offset = "0x18617C8", VA = "0x18617C8")]
			public Action()
			{
			}
		}

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8564DC", Offset = "0x8564DC")]
		public Action[] actions;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private float lastActionMoveMag;

		[Token(Token = "0x17000116")]
		public Action currentAction
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x1918138", Offset = "0x1918138", VA = "0x1918138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x1919550", Offset = "0x1919550", VA = "0x1919550", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x19195D4", Offset = "0x19195D4", VA = "0x19195D4", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x19197F4", Offset = "0x19197F4", VA = "0x19197F4")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1919A14", Offset = "0x1919A14", VA = "0x1919A14")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x856534", Offset = "0x856534")]
		public PropMuscle propMuscle;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85656C", Offset = "0x85656C")]
		private BehaviourPuppet <puppet>k__BackingField;

		[Token(Token = "0x17000117")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1919A24", Offset = "0x1919A24", VA = "0x1919A24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85ABEC", Offset = "0x85ABEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1919A2C", Offset = "0x1919A2C", VA = "0x1919A2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85ABFC", Offset = "0x85ABFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x191955C", Offset = "0x191955C", VA = "0x191955C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x1919B74", Offset = "0x1919B74", VA = "0x1919B74", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1919C40", Offset = "0x1919C40", VA = "0x1919C40", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x191A134", Offset = "0x191A134", VA = "0x191A134", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1919A20", Offset = "0x1919A20", VA = "0x1919A20")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85657C", Offset = "0x85657C")]
		public Transform ragdollPrefab;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8565B4", Offset = "0x8565B4")]
		public string instanceName;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8565EC", Offset = "0x8565EC")]
		public int characterControllerLayer;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856624", Offset = "0x856624")]
		public int ragdollLayer;

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x191C21C", Offset = "0x191C21C", VA = "0x191C21C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x191C394", Offset = "0x191C394", VA = "0x191C394")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85665C", Offset = "0x85665C")]
		public GameObject prefab;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x191C3E8", Offset = "0x191C3E8", VA = "0x191C3E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x191C578", Offset = "0x191C578", VA = "0x191C578")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x191C57C", Offset = "0x191C57C", VA = "0x191C57C")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class DeathBaker : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B710", Offset = "0x84B710")]
		private sealed class <Bake>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x17000118")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A38")]
				[Address(RVA = "0x1861A48", Offset = "0x1861A48", VA = "0x1861A48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000119")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A3A")]
				[Address(RVA = "0x1861A90", Offset = "0x1861A90", VA = "0x1861A90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x186194C", Offset = "0x186194C", VA = "0x186194C")]
			[DebuggerHidden]
			public <Bake>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x1861978", Offset = "0x1861978", VA = "0x1861978", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x186197C", Offset = "0x186197C", VA = "0x186197C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x1861A50", Offset = "0x1861A50", VA = "0x1861A50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B720", Offset = "0x84B720")]
		private sealed class <FadeOutPinWeight>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x1700011A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0x1861C7C", Offset = "0x1861C7C", VA = "0x1861C7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x1861CC4", Offset = "0x1861CC4", VA = "0x1861CC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1861BB4", Offset = "0x1861BB4", VA = "0x1861BB4")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1861BE0", Offset = "0x1861BE0", VA = "0x1861BE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1861BE4", Offset = "0x1861BE4", VA = "0x1861BE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1861C84", Offset = "0x1861C84", VA = "0x1861C84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B730", Offset = "0x84B730")]
		private sealed class <FadeOutMuscleWeight>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x1700011C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x1861B64", Offset = "0x1861B64", VA = "0x1861B64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x1861BAC", Offset = "0x1861BAC", VA = "0x1861BAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x1861A98", Offset = "0x1861A98", VA = "0x1861A98")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x1861AC4", Offset = "0x1861AC4", VA = "0x1861AC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x1861AC8", Offset = "0x1861AC8", VA = "0x1861AC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x1861B6C", Offset = "0x1861B6C", VA = "0x1861B6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856694", Offset = "0x856694")]
		public HumanoidBaker baker;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8566CC", Offset = "0x8566CC")]
		public float bakeTime;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856704", Offset = "0x856704")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85673C", Offset = "0x85673C")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856774", Offset = "0x856774")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8567AC", Offset = "0x8567AC")]
		public float deadMuscleWeight;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool isDead;

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x191C584", Offset = "0x191C584", VA = "0x191C584")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x191C61C", Offset = "0x191C61C", VA = "0x191C61C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x191C914", Offset = "0x191C914", VA = "0x191C914")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AC0C", Offset = "0x85AC0C")]
		private IEnumerator Bake()
		{
			return null;
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x191C83C", Offset = "0x191C83C", VA = "0x191C83C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AC6C", Offset = "0x85AC6C")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x191C8A8", Offset = "0x191C8A8", VA = "0x191C8A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85ACCC", Offset = "0x85ACCC")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x191C980", Offset = "0x191C980", VA = "0x191C980")]
		public DeathBaker()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B740", Offset = "0x84B740")]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x1700011E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A4D")]
				[Address(RVA = "0x1861DF0", Offset = "0x1861DF0", VA = "0x1861DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A4F")]
				[Address(RVA = "0x1861E38", Offset = "0x1861E38", VA = "0x1861E38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x1861CCC", Offset = "0x1861CCC", VA = "0x1861CCC")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x1861CF8", Offset = "0x1861CF8", VA = "0x1861CF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x1861CFC", Offset = "0x1861CFC", VA = "0x1861CFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x1861DF8", Offset = "0x1861DF8", VA = "0x1861DF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x191CB4C", Offset = "0x191CB4C", VA = "0x191CB4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x191CB78", Offset = "0x191CB78", VA = "0x191CB78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AE1C", Offset = "0x85AE1C")]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x191CBE4", Offset = "0x191CBE4", VA = "0x191CBE4")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B750", Offset = "0x84B750")]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A58")]
				[Address(RVA = "0x1862024", Offset = "0x1862024", VA = "0x1862024", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A5A")]
				[Address(RVA = "0x186206C", Offset = "0x186206C", VA = "0x186206C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1861F5C", Offset = "0x1861F5C", VA = "0x1861F5C")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x1861F88", Offset = "0x1861F88", VA = "0x1861F88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1861F8C", Offset = "0x1861F8C", VA = "0x1861F8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x186202C", Offset = "0x186202C", VA = "0x186202C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B760", Offset = "0x84B760")]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x17000122")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x1861F0C", Offset = "0x1861F0C", VA = "0x1861F0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0x1861F54", Offset = "0x1861F54", VA = "0x1861F54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x1861E40", Offset = "0x1861E40", VA = "0x1861E40")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x1861E6C", Offset = "0x1861E6C", VA = "0x1861E6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x1861E70", Offset = "0x1861E70", VA = "0x1861E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x1861F14", Offset = "0x1861F14", VA = "0x1861F14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8567E4", Offset = "0x8567E4")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85681C", Offset = "0x85681C")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856854", Offset = "0x856854")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85688C", Offset = "0x85688C")]
		public float deadMuscleWeight;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x191CBF4", Offset = "0x191CBF4", VA = "0x191CBF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x191CC8C", Offset = "0x191CC8C", VA = "0x191CC8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x191CE7C", Offset = "0x191CE7C", VA = "0x191CE7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AECC", Offset = "0x85AECC")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x191CEE8", Offset = "0x191CEE8", VA = "0x191CEE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85AF2C", Offset = "0x85AF2C")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x191CF54", Offset = "0x191CF54", VA = "0x191CF54")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B770", Offset = "0x84B770")]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x1AEC2B8", Offset = "0x1AEC2B8", VA = "0x1AEC2B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x1AEC39C", Offset = "0x1AEC39C", VA = "0x1AEC39C")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1AEC608", Offset = "0x1AEC608", VA = "0x1AEC608")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1AEC70C", Offset = "0x1AEC70C", VA = "0x1AEC70C")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8568C4", Offset = "0x8568C4")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8568FC", Offset = "0x8568FC")]
		public UserControlMelee userControl;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856934", Offset = "0x856934")]
		public int grabLayer;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000A5D")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000A5E")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x1AEF164", Offset = "0x1AEF164", VA = "0x1AEF164")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x1AEF1DC", Offset = "0x1AEF1DC", VA = "0x1AEF1DC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x1AEF5A4", Offset = "0x1AEF5A4", VA = "0x1AEF5A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x1AEF6CC", Offset = "0x1AEF6CC", VA = "0x1AEF6CC")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85696C", Offset = "0x85696C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8569A4", Offset = "0x8569A4")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x1C15160", Offset = "0x1C15160", VA = "0x1C15160")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x1C15230", Offset = "0x1C15230", VA = "0x1C15230")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B7D0", Offset = "0x84B7D0")]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8569DC", Offset = "0x8569DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8569DC", Offset = "0x8569DC")]
		public Transform characterController;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856A3C", Offset = "0x856A3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x856A3C", Offset = "0x856A3C")]
		public int characterControllerLayer;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856A9C", Offset = "0x856A9C")]
		public int ragdollLayer;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856AD4", Offset = "0x856AD4")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856B0C", Offset = "0x856B0C")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x1C15978", Offset = "0x1C15978", VA = "0x1C15978")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x1C15B74", Offset = "0x1C15B74", VA = "0x1C15B74")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class NavMeshPuppet : MonoBehaviour
	{
		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NavMeshAgent agent;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xF1DA78", Offset = "0xF1DA78", VA = "0xF1DA78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xF1DB70", Offset = "0xF1DB70", VA = "0xF1DB70")]
		public NavMeshPuppet()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xF21508", Offset = "0xF21508", VA = "0xF21508")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xF21604", Offset = "0xF21604", VA = "0xF21604")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class PlanetaryGravity : MonoBehaviour
	{
		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Planet planet;

		[Token(Token = "0x4000A6D")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody _r;

		[Token(Token = "0x17000124")]
		private Rigidbody r
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0xF21614", Offset = "0xF21614", VA = "0xF21614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xF216B4", Offset = "0xF216B4", VA = "0xF216B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xF21790", Offset = "0xF21790", VA = "0xF21790")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xF218C4", Offset = "0xF218C4", VA = "0xF218C4")]
		public PlanetaryGravity()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856B44", Offset = "0x856B44")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856B7C", Offset = "0x856B7C")]
		public PropMuscle propMuscleLeft;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856BB4", Offset = "0x856BB4")]
		public PropMuscle propMuscleRight;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856BEC", Offset = "0x856BEC")]
		public bool pickUpOnAwake;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x17000125")]
		private PropMuscle connectTo
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xF22A58", Offset = "0xF22A58", VA = "0xF22A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xF22A1C", Offset = "0xF22A1C", VA = "0xF22A1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xF22A74", Offset = "0xF22A74", VA = "0xF22A74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xF22B34", Offset = "0xF22B34", VA = "0xF22B34")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x200017C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B830", Offset = "0x84B830")]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x17000126")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A82")]
				[Address(RVA = "0x1BA5444", Offset = "0x1BA5444", VA = "0x1BA5444", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A84")]
				[Address(RVA = "0x1BA548C", Offset = "0x1BA548C", VA = "0x1BA548C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1BA51E8", Offset = "0x1BA51E8", VA = "0x1BA51E8")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1BA5214", Offset = "0x1BA5214", VA = "0x1BA5214", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1BA5218", Offset = "0x1BA5218", VA = "0x1BA5218", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1BA544C", Offset = "0x1BA544C", VA = "0x1BA544C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856C24", Offset = "0x856C24")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x856C24", Offset = "0x856C24")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856C84", Offset = "0x856C84")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856CBC", Offset = "0x856CBC")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856CF4", Offset = "0x856CF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x856CF4", Offset = "0x856CF4")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x856D48", Offset = "0x856D48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856D48", Offset = "0x856D48")]
		public float actionMassMlp;

		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856DA0", Offset = "0x856DA0")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float defaultMass;

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float defaultAddMass;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Rigidbody r;

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xF22B44", Offset = "0xF22B44", VA = "0xF22B44")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xF22B8C", Offset = "0xF22B8C", VA = "0xF22B8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85B02C", Offset = "0x85B02C")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xF22C08", Offset = "0xF22C08", VA = "0xF22C08", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xF22CBC", Offset = "0xF22CBC", VA = "0xF22CBC", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xF22D34", Offset = "0xF22D34", VA = "0xF22D34", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xF22DAC", Offset = "0xF22DAC", VA = "0xF22DAC")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xF24220", Offset = "0xF24220", VA = "0xF24220")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xF243AC", Offset = "0xF243AC", VA = "0xF243AC")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856DD8", Offset = "0x856DD8")]
		public Rigidbody target;

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856E10", Offset = "0x856E10")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856E48", Offset = "0x856E48")]
		public Transform bodyTarget;

		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xF2627C", Offset = "0xF2627C", VA = "0xF2627C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xF26320", Offset = "0xF26320", VA = "0xF26320")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xF264A0", Offset = "0xF264A0", VA = "0xF264A0")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class PuppetMasterPropMelee : PuppetMasterProp
	{
		[Token(Token = "0x2000180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B840", Offset = "0x84B840")]
		private sealed class <Action>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterPropMelee <>4__this;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x17000128")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A93")]
				[Address(RVA = "0x1BA6D68", Offset = "0x1BA6D68", VA = "0x1BA6D68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A95")]
				[Address(RVA = "0x1BA6DB0", Offset = "0x1BA6DB0", VA = "0x1BA6DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1BA6C30", Offset = "0x1BA6C30", VA = "0x1BA6C30")]
			[DebuggerHidden]
			public <Action>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1BA6C5C", Offset = "0x1BA6C5C", VA = "0x1BA6C5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x1BA6C60", Offset = "0x1BA6C60", VA = "0x1BA6C60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1BA6D70", Offset = "0x1BA6D70", VA = "0x1BA6D70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x856E80", Offset = "0x856E80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856E80", Offset = "0x856E80")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856EE0", Offset = "0x856EE0")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856F18", Offset = "0x856F18")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856F50", Offset = "0x856F50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x856F50", Offset = "0x856F50")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x856FA4", Offset = "0x856FA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856FA4", Offset = "0x856FA4")]
		public float actionMassMlp;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x856FF8", Offset = "0x856FF8")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float defaultMass;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float defaultAdditionalPinWeight;

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x17679AC", Offset = "0x17679AC", VA = "0x17679AC")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x17679F4", Offset = "0x17679F4", VA = "0x17679F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85B0DC", Offset = "0x85B0DC")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1767A70", Offset = "0x1767A70", VA = "0x1767A70", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x1767AD8", Offset = "0x1767AD8", VA = "0x1767AD8", Slot = "4")]
		protected override void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x1767B80", Offset = "0x1767B80", VA = "0x1767B80", Slot = "5")]
		protected override void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x1767BE4", Offset = "0x1767BE4", VA = "0x1767BE4")]
		public PuppetMasterPropMelee()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x857030", Offset = "0x857030")]
		public float masterScale;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85704C", Offset = "0x85704C")]
		public float muscleScale;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1769098", Offset = "0x1769098", VA = "0x1769098")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x17690D8", Offset = "0x17690D8", VA = "0x17690D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x17693EC", Offset = "0x17693EC", VA = "0x17693EC")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x176C5D4", Offset = "0x176C5D4", VA = "0x176C5D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x176C834", Offset = "0x176C834", VA = "0x176C834")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x857068", Offset = "0x857068")]
		public Transform pool;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8570A0", Offset = "0x8570A0")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8570D8", Offset = "0x8570D8")]
		public string idleAnimation;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x1700012A")]
		private bool isPooled
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x176D978", Offset = "0x176D978", VA = "0x176D978")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x176DA0C", Offset = "0x176DA0C", VA = "0x176DA0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x176DA6C", Offset = "0x176DA6C", VA = "0x176DA6C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x176DBA0", Offset = "0x176DBA0", VA = "0x176DBA0")]
		private void Pool()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x176DBC4", Offset = "0x176DBC4", VA = "0x176DBC4")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x176DCF4", Offset = "0x176DCF4", VA = "0x176DCF4")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x176DCFC", Offset = "0x176DCFC", VA = "0x176DCFC")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x176DD94", Offset = "0x176DD94", VA = "0x176DD94")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class SkeletonDisconnector : MonoBehaviour
	{
		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleDisconnectMode disconnectMuscleMode;

		[Token(Token = "0x4000AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropMuscle propMuscle;

		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PuppetMasterProp prop;

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x1771C70", Offset = "0x1771C70", VA = "0x1771C70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1772038", Offset = "0x1772038", VA = "0x1772038")]
		public SkeletonDisconnector()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x1772048", Offset = "0x1772048", VA = "0x1772048")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1772394", Offset = "0x1772394", VA = "0x1772394")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x1700012B")]
		private Transform moveTarget
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x1775EF4", Offset = "0x1775EF4", VA = "0x1775EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x1775F48", Offset = "0x1775F48", VA = "0x1775F48", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x17760F8", Offset = "0x17760F8", VA = "0x17760F8")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1776214", Offset = "0x1776214", VA = "0x1776214")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x177684C", Offset = "0x177684C", VA = "0x177684C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1776880", Offset = "0x1776880", VA = "0x1776880")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700012C")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x19177A8", Offset = "0x19177A8", VA = "0x19177A8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1917784", Offset = "0x1917784", VA = "0x1917784", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x19177B0", Offset = "0x19177B0", VA = "0x19177B0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x1917814", Offset = "0x1917814", VA = "0x1917814", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x19179AC", Offset = "0x19179AC", VA = "0x19179AC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x1917BD0", Offset = "0x1917BD0", VA = "0x1917BD0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x19179BC", Offset = "0x19179BC", VA = "0x19179BC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x1917BE0", Offset = "0x1917BE0", VA = "0x1917BE0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B850", Offset = "0x84B850")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x19181CC", Offset = "0x19181CC", VA = "0x19181CC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x1918228", Offset = "0x1918228", VA = "0x1918228", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x19182C4", Offset = "0x19182C4", VA = "0x19182C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x19183DC", Offset = "0x19183DC", VA = "0x19183DC")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200018B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B8B0", Offset = "0x84B8B0")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x857140", Offset = "0x857140")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000ACE")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000ACF")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x1700012D")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1918490", Offset = "0x1918490", VA = "0x1918490", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x19183F4", Offset = "0x19183F4", VA = "0x19183F4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x1918474", Offset = "0x1918474", VA = "0x1918474", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x1917D70", Offset = "0x1917D70", VA = "0x1917D70", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x1918588", Offset = "0x1918588", VA = "0x1918588")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x19181A8", Offset = "0x19181A8", VA = "0x19181A8")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B910", Offset = "0x84B910")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B910", Offset = "0x84B910")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x857184", Offset = "0x857184")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x857184", Offset = "0x857184")]
		public Transform gravityTarget;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8571E4", Offset = "0x8571E4")]
		public float gravityMultiplier;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000ADB")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000ABF")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x1918A40", Offset = "0x1918A40", VA = "0x1918A40")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x1918B70", Offset = "0x1918B70", VA = "0x1918B70", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x1918D28", Offset = "0x1918D28", VA = "0x1918D28", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x1918ED8", Offset = "0x1918ED8", VA = "0x1918ED8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x1918F3C", Offset = "0x1918F3C", VA = "0x1918F3C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x191905C", Offset = "0x191905C", VA = "0x191905C")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x1919180", Offset = "0x1919180", VA = "0x1919180")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x19191A4", Offset = "0x19191A4", VA = "0x19191A4")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x19191C8", Offset = "0x19191C8", VA = "0x19191C8")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x1919228", Offset = "0x1919228", VA = "0x1919228")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200018E")]
		public enum MoveMode
		{
			[Token(Token = "0x4000B18")]
			Directional,
			[Token(Token = "0x4000B19")]
			Strafe
		}

		[Token(Token = "0x200018F")]
		public struct AnimState
		{
			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84B9A4", Offset = "0x84B9A4")]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x1700012F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0x18618FC", Offset = "0x18618FC", VA = "0x18618FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000130")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0x1861944", Offset = "0x1861944", VA = "0x1861944", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x18617D8", Offset = "0x18617D8", VA = "0x18617D8")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x1861804", Offset = "0x1861804", VA = "0x1861804", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x1861808", Offset = "0x1861808", VA = "0x1861808", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x1861904", Offset = "0x1861904", VA = "0x1861904", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x85721C", Offset = "0x85721C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x857254", Offset = "0x857254")]
		public MoveMode moveMode;

		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x85728C", Offset = "0x85728C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8572C4", Offset = "0x8572C4")]
		public bool smoothJump;

		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8572FC", Offset = "0x8572FC")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x857334", Offset = "0x857334")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85736C", Offset = "0x85736C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x1700012E")]
		public bool onGround
		{
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x191A38C", Offset = "0x191A38C", VA = "0x191A38C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B18C", Offset = "0x85B18C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x191A394", Offset = "0x191A394", VA = "0x191A394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B19C", Offset = "0x85B19C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1919A34", Offset = "0x1919A34", VA = "0x1919A34", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x191A3A0", Offset = "0x191A3A0", VA = "0x191A3A0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1919BC4", Offset = "0x1919BC4", VA = "0x1919BC4", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x191A430", Offset = "0x191A430", VA = "0x191A430")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x191998C", Offset = "0x191998C", VA = "0x191998C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x191B1EC", Offset = "0x191B1EC", VA = "0x191B1EC", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x191A924", Offset = "0x191A924", VA = "0x191A924")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x191B2C8", Offset = "0x191B2C8", VA = "0x191B2C8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x191B770", Offset = "0x191B770", VA = "0x191B770")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x191B01C", Offset = "0x191B01C", VA = "0x191B01C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x1919DF8", Offset = "0x1919DF8", VA = "0x1919DF8", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x191B810", Offset = "0x191B810", VA = "0x191B810")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x191A15C", Offset = "0x191A15C", VA = "0x191A15C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x191B900", Offset = "0x191B900", VA = "0x191B900")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85B1AC", Offset = "0x85B1AC")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x191AC74", Offset = "0x191AC74", VA = "0x191AC74")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x191A2BC", Offset = "0x191A2BC", VA = "0x191A2BC")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B9B4", Offset = "0x84B9B4")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000192")]
		public enum RotationMode
		{
			[Token(Token = "0x4000B35")]
			Smooth,
			[Token(Token = "0x4000B36")]
			Linear
		}

		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85737C", Offset = "0x85737C")]
		public CameraController cameraController;

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8573B4", Offset = "0x8573B4")]
		public float accelerationTime;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8573EC", Offset = "0x8573EC")]
		public float turnTime;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x857424", Offset = "0x857424")]
		public bool walkByDefault;

		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85745C", Offset = "0x85745C")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x857494", Offset = "0x857494")]
		public float moveSpeed;

		[Token(Token = "0x4000B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8574CC", Offset = "0x8574CC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000131")]
		public bool isGrounded
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x1771194", Offset = "0x1771194", VA = "0x1771194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B25C", Offset = "0x85B25C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x177119C", Offset = "0x177119C", VA = "0x177119C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B26C", Offset = "0x85B26C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x17711A8", Offset = "0x17711A8", VA = "0x17711A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x1771238", Offset = "0x1771238", VA = "0x1771238")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x17716F8", Offset = "0x17716F8", VA = "0x17716F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x177128C", Offset = "0x177128C", VA = "0x177128C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x177150C", Offset = "0x177150C", VA = "0x177150C")]
		private void Move()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1771734", Offset = "0x1771734", VA = "0x1771734")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x17717D0", Offset = "0x17717D0", VA = "0x17717D0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1771854", Offset = "0x1771854", VA = "0x1771854")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1775C60", Offset = "0x1775C60", VA = "0x1775C60", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x1775CDC", Offset = "0x1775CDC", VA = "0x1775CDC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1775EA0", Offset = "0x1775EA0", VA = "0x1775EA0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1775EC8", Offset = "0x1775EC8", VA = "0x1775EC8")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000195")]
		public struct State
		{
			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x1775CA4", Offset = "0x1775CA4", VA = "0x1775CA4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x1776320", Offset = "0x1776320", VA = "0x1776320", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x1775EE4", Offset = "0x1775EE4", VA = "0x1775EE4")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x1951144", Offset = "0x1951144", VA = "0x1951144")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x1951180", Offset = "0x1951180", VA = "0x1951180")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x17723A4", Offset = "0x17723A4", VA = "0x17723A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x17723D8", Offset = "0x17723D8", VA = "0x17723D8")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x1772488", Offset = "0x1772488", VA = "0x1772488")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000198")]
	public class Navigator
	{
		[Token(Token = "0x2000199")]
		public enum State
		{
			[Token(Token = "0x4000B58")]
			Idle,
			[Token(Token = "0x4000B59")]
			Seeking,
			[Token(Token = "0x4000B5A")]
			OnPath
		}

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8574DC", Offset = "0x8574DC")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x857514", Offset = "0x857514")]
		public float cornerRadius;

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85754C", Offset = "0x85754C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x857584", Offset = "0x857584")]
		public float maxSampleDistance;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8575BC", Offset = "0x8575BC")]
		public float nextPathInterval;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8575F4", Offset = "0x8575F4")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x857604", Offset = "0x857604")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000132")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0xF1DB78", Offset = "0xF1DB78", VA = "0xF1DB78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B27C", Offset = "0x85B27C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0xF1DB84", Offset = "0xF1DB84", VA = "0xF1DB84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B28C", Offset = "0x85B28C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public State state
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xF1DB90", Offset = "0xF1DB90", VA = "0xF1DB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B29C", Offset = "0x85B29C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0xF1DB98", Offset = "0xF1DB98", VA = "0xF1DB98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85B2AC", Offset = "0x85B2AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0xF1DBA0", Offset = "0xF1DBA0", VA = "0xF1DBA0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0xF1DC50", Offset = "0xF1DC50", VA = "0xF1DC50")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0xF1E03C", Offset = "0xF1E03C", VA = "0xF1E03C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xF1E0B8", Offset = "0xF1E0B8", VA = "0xF1E0B8")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0xF1DFF8", Offset = "0xF1DFF8", VA = "0xF1DFF8")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xF1E028", Offset = "0xF1E028", VA = "0xF1E028")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xF1E204", Offset = "0xF1E204", VA = "0xF1E204")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xF1E3B4", Offset = "0xF1E3B4", VA = "0xF1E3B4")]
		public Navigator()
		{
		}
	}
}
