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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FB80", Offset = "0x72FB80")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FB80", Offset = "0x72FB80")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73062C", Offset = "0x73062C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73062C", Offset = "0x73062C")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730684", Offset = "0x730684")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730684", Offset = "0x730684")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7306DC", Offset = "0x7306DC")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730714", Offset = "0x730714")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73074C", Offset = "0x73074C")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730784", Offset = "0x730784")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7307BC", Offset = "0x7307BC")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7307F4", Offset = "0x7307F4")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73082C", Offset = "0x73082C")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730864", Offset = "0x730864")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730874", Offset = "0x730874")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7308A4", Offset = "0x7308A4")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x156EFDC", Offset = "0x156EFDC", VA = "0x156EFDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738BCC", Offset = "0x738BCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x156EFE4", Offset = "0x156EFE4", VA = "0x156EFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738BDC", Offset = "0x738BDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x156EFF0", Offset = "0x156EFF0", VA = "0x156EFF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738BEC", Offset = "0x738BEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x156EFF8", Offset = "0x156EFF8", VA = "0x156EFF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738BFC", Offset = "0x738BFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x156F000", Offset = "0x156F000", VA = "0x156F000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C0C", Offset = "0x738C0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x156F008", Offset = "0x156F008", VA = "0x156F008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C1C", Offset = "0x738C1C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x156EEBC", Offset = "0x156EEBC", VA = "0x156EEBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738AEC", Offset = "0x738AEC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x156EF04", Offset = "0x156EF04", VA = "0x156EF04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738B24", Offset = "0x738B24")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x156EF4C", Offset = "0x156EF4C", VA = "0x156EF4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738B5C", Offset = "0x738B5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x156EF94", Offset = "0x156EF94", VA = "0x156EF94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738B94", Offset = "0x738B94")]
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
		[Address(RVA = "0x156F010", Offset = "0x156F010", VA = "0x156F010")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x156F014", Offset = "0x156F014", VA = "0x156F014")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x156F018", Offset = "0x156F018", VA = "0x156F018")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x156F01C", Offset = "0x156F01C", VA = "0x156F01C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7308B4", Offset = "0x7308B4")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7308EC", Offset = "0x7308EC")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730924", Offset = "0x730924")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73095C", Offset = "0x73095C")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730994", Offset = "0x730994")]
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
		[Address(RVA = "0x158A568", Offset = "0x158A568", VA = "0x158A568")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x158A958", Offset = "0x158A958", VA = "0x158A958", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x158A960", Offset = "0x158A960", VA = "0x158A960", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x158AA70", Offset = "0x158AA70", VA = "0x158AA70", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x158AAEC", Offset = "0x158AAEC", VA = "0x158AAEC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x158AB68", Offset = "0x158AB68", VA = "0x158AB68", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x158A7B0", Offset = "0x158A7B0", VA = "0x158A7B0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x158A884", Offset = "0x158A884", VA = "0x158A884")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x158ABE4", Offset = "0x158ABE4", VA = "0x158ABE4")]
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
		[Address(RVA = "0x1472CA8", Offset = "0x1472CA8", VA = "0x1472CA8")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x156E2B4", Offset = "0x156E2B4", VA = "0x156E2B4")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x156E510", Offset = "0x156E510", VA = "0x156E510")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x156E4F0", Offset = "0x156E4F0", VA = "0x156E4F0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x156EABC", Offset = "0x156EABC", VA = "0x156EABC")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1570298", Offset = "0x1570298", VA = "0x1570298")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1571B50", Offset = "0x1571B50", VA = "0x1571B50")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x156FCEC", Offset = "0x156FCEC", VA = "0x156FCEC")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x15702E0", Offset = "0x15702E0", VA = "0x15702E0")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x156F81C", Offset = "0x156F81C", VA = "0x156F81C")]
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
		[Address(RVA = "0x156F108", Offset = "0x156F108", VA = "0x156F108")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x156F374", Offset = "0x156F374", VA = "0x156F374")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x156F26C", Offset = "0x156F26C", VA = "0x156F26C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x156F4F0", Offset = "0x156F4F0", VA = "0x156F4F0")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x156FA80", Offset = "0x156FA80", VA = "0x156FA80")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x156FB7C", Offset = "0x156FB7C", VA = "0x156FB7C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x156FC78", Offset = "0x156FC78", VA = "0x156FC78")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x156FBF0", Offset = "0x156FBF0", VA = "0x156FBF0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x156FEE4", Offset = "0x156FEE4", VA = "0x156FEE4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x156FF98", Offset = "0x156FF98", VA = "0x156FF98")]
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
		[Address(RVA = "0x15702E4", Offset = "0x15702E4", VA = "0x15702E4")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1570354", Offset = "0x1570354", VA = "0x1570354")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1570DE8", Offset = "0x1570DE8", VA = "0x1570DE8")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1570E9C", Offset = "0x1570E9C", VA = "0x1570E9C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1570D8C", Offset = "0x1570D8C", VA = "0x1570D8C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1570F94", Offset = "0x1570F94", VA = "0x1570F94")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1570FDC", Offset = "0x1570FDC", VA = "0x1570FDC")]
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
		[Address(RVA = "0x1570FE4", Offset = "0x1570FE4", VA = "0x1570FE4")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1571170", Offset = "0x1571170", VA = "0x1571170")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1571184", Offset = "0x1571184", VA = "0x1571184")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1571470", Offset = "0x1571470", VA = "0x1571470")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x157107C", Offset = "0x157107C", VA = "0x157107C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1571724", Offset = "0x1571724", VA = "0x1571724")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1571798", Offset = "0x1571798", VA = "0x1571798")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x157194C", Offset = "0x157194C", VA = "0x157194C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7309CC", Offset = "0x7309CC")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730A04", Offset = "0x730A04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730A04", Offset = "0x730A04")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730A5C", Offset = "0x730A5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730A5C", Offset = "0x730A5C")]
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
		[Address(RVA = "0x1631F9C", Offset = "0x1631F9C", VA = "0x1631F9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1632478", Offset = "0x1632478", VA = "0x1632478", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1632494", Offset = "0x1632494", VA = "0x1632494", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1632570", Offset = "0x1632570", VA = "0x1632570", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x163264C", Offset = "0x163264C", VA = "0x163264C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x163281C", Offset = "0x163281C", VA = "0x163281C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1632B54", Offset = "0x1632B54", VA = "0x1632B54")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1632C30", Offset = "0x1632C30", VA = "0x1632C30")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x730AB0", Offset = "0x730AB0")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x730AE8", Offset = "0x730AE8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x730B20", Offset = "0x730B20")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x730B58", Offset = "0x730B58")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730B90", Offset = "0x730B90")]
		public float blockedOffset;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730BA8", Offset = "0x730BA8")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730BB8", Offset = "0x730BB8")]
		private float <y>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730BC8", Offset = "0x730BC8")]
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
			[Address(RVA = "0x157A748", Offset = "0x157A748", VA = "0x157A748")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C2C", Offset = "0x738C2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x157A750", Offset = "0x157A750", VA = "0x157A750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C3C", Offset = "0x738C3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x157A758", Offset = "0x157A758", VA = "0x157A758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C4C", Offset = "0x738C4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x157A760", Offset = "0x157A760", VA = "0x157A760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C5C", Offset = "0x738C5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x157A768", Offset = "0x157A768", VA = "0x157A768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C6C", Offset = "0x738C6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x157A770", Offset = "0x157A770", VA = "0x157A770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738C7C", Offset = "0x738C7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x157B04C", Offset = "0x157B04C", VA = "0x157B04C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x157A778", Offset = "0x157A778", VA = "0x157A778")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x157A7B4", Offset = "0x157A7B4", VA = "0x157A7B4")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x157A7BC", Offset = "0x157A7BC", VA = "0x157A7BC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x157A8C0", Offset = "0x157A8C0", VA = "0x157A8C0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x157A91C", Offset = "0x157A91C", VA = "0x157A91C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x157A984", Offset = "0x157A984", VA = "0x157A984", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x157A9E8", Offset = "0x157A9E8", VA = "0x157A9E8")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x157A8F4", Offset = "0x157A8F4", VA = "0x157A8F4")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x157AB68", Offset = "0x157AB68", VA = "0x157AB68")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x157B01C", Offset = "0x157B01C", VA = "0x157B01C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x157B0BC", Offset = "0x157B0BC", VA = "0x157B0BC")]
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
		[Address(RVA = "0x157B168", Offset = "0x157B168", VA = "0x157B168")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x157B1A0", Offset = "0x157B1A0", VA = "0x157B1A0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x157B348", Offset = "0x157B348", VA = "0x157B348")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x157B378", Offset = "0x157B378", VA = "0x157B378")]
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
		[Address(RVA = "0x156EAC4", Offset = "0x156EAC4", VA = "0x156EAC4")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x156EAE8", Offset = "0x156EAE8", VA = "0x156EAE8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x156EB20", Offset = "0x156EB20", VA = "0x156EB20")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x156EC10", Offset = "0x156EC10", VA = "0x156EC10")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x156EBB8", Offset = "0x156EBB8", VA = "0x156EBB8")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x156ECA8", Offset = "0x156ECA8", VA = "0x156ECA8")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x156ECF0", Offset = "0x156ECF0", VA = "0x156ECF0")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x156EEB4", Offset = "0x156EEB4", VA = "0x156EEB4")]
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
			[Address(RVA = "0x147BD70", Offset = "0x147BD70", VA = "0x147BD70")]
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
			[Address(RVA = "0x15735F4", Offset = "0x15735F4", VA = "0x15735F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1573860", Offset = "0x1573860", VA = "0x1573860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x15735A8", Offset = "0x15735A8", VA = "0x15735A8")]
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
		[Address(RVA = "0x1573ACC", Offset = "0x1573ACC", VA = "0x1573ACC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1573DE8", Offset = "0x1573DE8", VA = "0x1573DE8")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1574054", Offset = "0x1574054", VA = "0x1574054")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15740D4", Offset = "0x15740D4", VA = "0x15740D4")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x157417C", Offset = "0x157417C", VA = "0x157417C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1573C9C", Offset = "0x1573C9C", VA = "0x1573C9C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1573FB8", Offset = "0x1573FB8", VA = "0x1573FB8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x15749AC", Offset = "0x15749AC", VA = "0x15749AC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15747B4", Offset = "0x15747B4", VA = "0x15747B4")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15748B0", Offset = "0x15748B0", VA = "0x15748B0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1574394", Offset = "0x1574394", VA = "0x1574394")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1574444", Offset = "0x1574444", VA = "0x1574444")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15744F4", Offset = "0x15744F4", VA = "0x15744F4")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15745A4", Offset = "0x15745A4", VA = "0x15745A4")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1574654", Offset = "0x1574654", VA = "0x1574654")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1574704", Offset = "0x1574704", VA = "0x1574704")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1574BB4", Offset = "0x1574BB4", VA = "0x1574BB4")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x15742AC", Offset = "0x15742AC", VA = "0x15742AC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1574B24", Offset = "0x1574B24", VA = "0x1574B24")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1574C20", Offset = "0x1574C20", VA = "0x1574C20")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1574CF4", Offset = "0x1574CF4", VA = "0x1574CF4")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1574AAC", Offset = "0x1574AAC", VA = "0x1574AAC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1574A38", Offset = "0x1574A38", VA = "0x1574A38")]
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
				[Address(RVA = "0x147BDFC", Offset = "0x147BDFC", VA = "0x147BDFC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x147BDE8", Offset = "0x147BDE8", VA = "0x147BDE8")]
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
			[Address(RVA = "0x1576D38", Offset = "0x1576D38", VA = "0x1576D38", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1577120", Offset = "0x1577120", VA = "0x1577120")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1577130", Offset = "0x1577130", VA = "0x1577130", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1577558", Offset = "0x1577558", VA = "0x1577558", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x157798C", Offset = "0x157798C", VA = "0x157798C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1577F78", Offset = "0x1577F78", VA = "0x1577F78")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1577BA0", Offset = "0x1577BA0", VA = "0x1577BA0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x157297C", Offset = "0x157297C", VA = "0x157297C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1578778", Offset = "0x1578778", VA = "0x1578778")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1578CD8", Offset = "0x1578CD8", VA = "0x1578CD8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1578ACC", Offset = "0x1578ACC", VA = "0x1578ACC")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1578948", Offset = "0x1578948", VA = "0x1578948")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1578818", Offset = "0x1578818", VA = "0x1578818")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1578BD8", Offset = "0x1578BD8", VA = "0x1578BD8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1578DD0", Offset = "0x1578DD0", VA = "0x1578DD0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x15798F4", Offset = "0x15798F4", VA = "0x15798F4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x157937C", Offset = "0x157937C", VA = "0x157937C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1579B9C", Offset = "0x1579B9C", VA = "0x1579B9C")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15796E8", Offset = "0x15796E8", VA = "0x15796E8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1579BA4", Offset = "0x1579BA4", VA = "0x1579BA4")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1579BAC", Offset = "0x1579BAC", VA = "0x1579BAC")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1579D74", Offset = "0x1579D74", VA = "0x1579D74")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1579F30", Offset = "0x1579F30", VA = "0x1579F30")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1572DD8", Offset = "0x1572DD8", VA = "0x1572DD8")]
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
		[Address(RVA = "0x157EDAC", Offset = "0x157EDAC", VA = "0x157EDAC")]
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
		[Address(RVA = "0x157F638", Offset = "0x157F638", VA = "0x157F638")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x157F780", Offset = "0x157F780", VA = "0x157F780")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x162FE88", Offset = "0x162FE88", VA = "0x162FE88")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1630074", Offset = "0x1630074", VA = "0x1630074")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x162FF20", Offset = "0x162FF20", VA = "0x162FF20")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1630194", Offset = "0x1630194", VA = "0x1630194")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x16302C0", Offset = "0x16302C0", VA = "0x16302C0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x163050C", Offset = "0x163050C", VA = "0x163050C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1630614", Offset = "0x1630614", VA = "0x1630614")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1630788", Offset = "0x1630788", VA = "0x1630788")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1630B64", Offset = "0x1630B64", VA = "0x1630B64")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1630928", Offset = "0x1630928", VA = "0x1630928")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1630D18", Offset = "0x1630D18", VA = "0x1630D18")]
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
		[Address(RVA = "0x161018C", Offset = "0x161018C", VA = "0x161018C")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x16101F8", Offset = "0x16101F8", VA = "0x16101F8")]
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
		[Address(RVA = "0x14DD6E0", Offset = "0x14DD6E0", VA = "0x14DD6E0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x14DE08C", Offset = "0x14DE08C", VA = "0x14DE08C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x14DE100", Offset = "0x14DE100", VA = "0x14DE100")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x14DDAF4", Offset = "0x14DDAF4", VA = "0x14DDAF4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x14DDB00", Offset = "0x14DDB00", VA = "0x14DDB00")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x14DDB24", Offset = "0x14DDB24", VA = "0x14DDB24")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x14DDB60", Offset = "0x14DDB60", VA = "0x14DDB60")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x14DDB78", Offset = "0x14DDB78", VA = "0x14DDB78")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x14DDB8C", Offset = "0x14DDB8C", VA = "0x14DDB8C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x14DDBA0", Offset = "0x14DDBA0", VA = "0x14DDBA0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x14DDBB0", Offset = "0x14DDBB0", VA = "0x14DDBB0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x14DDBF8", Offset = "0x14DDBF8", VA = "0x14DDBF8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x14DDC30", Offset = "0x14DDC30", VA = "0x14DDC30")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x14DDC58", Offset = "0x14DDC58", VA = "0x14DDC58")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x14DE18C", Offset = "0x14DE18C", VA = "0x14DE18C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x14DDC8C", Offset = "0x14DDC8C", VA = "0x14DDC8C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x14DDCB4", Offset = "0x14DDCB4", VA = "0x14DDCB4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x14DDCE4", Offset = "0x14DDCE4", VA = "0x14DDCE4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x14DDD18", Offset = "0x14DDD18", VA = "0x14DDD18")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x14DDD5C", Offset = "0x14DDD5C", VA = "0x14DDD5C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x14DDDC0", Offset = "0x14DDDC0", VA = "0x14DDDC0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x14DDE24", Offset = "0x14DDE24", VA = "0x14DDE24")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x14DDE78", Offset = "0x14DDE78", VA = "0x14DDE78")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x14DDECC", Offset = "0x14DDECC", VA = "0x14DDECC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x14DDF08", Offset = "0x14DDF08", VA = "0x14DDF08")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x14DDF40", Offset = "0x14DDF40", VA = "0x14DDF40")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x14DE1C0", Offset = "0x14DE1C0", VA = "0x14DE1C0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x14DDF88", Offset = "0x14DDF88", VA = "0x14DDF88")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x14DE01C", Offset = "0x14DE01C", VA = "0x14DE01C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x14DE04C", Offset = "0x14DE04C", VA = "0x14DE04C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x14DE254", Offset = "0x14DE254", VA = "0x14DE254")]
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
		[Address(RVA = "0x14DE310", Offset = "0x14DE310", VA = "0x14DE310")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x14DE37C", Offset = "0x14DE37C", VA = "0x14DE37C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x14DE3E8", Offset = "0x14DE3E8", VA = "0x14DE3E8")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x14DE440", Offset = "0x14DE440", VA = "0x14DE440")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x14DE50C", Offset = "0x14DE50C", VA = "0x14DE50C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x14DE458", Offset = "0x14DE458", VA = "0x14DE458")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x14DE524", Offset = "0x14DE524", VA = "0x14DE524")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x14DE5C8", Offset = "0x14DE5C8", VA = "0x14DE5C8")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x14DE5F4", Offset = "0x14DE5F4", VA = "0x14DE5F4")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x14DE644", Offset = "0x14DE644", VA = "0x14DE644")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x14DE6B0", Offset = "0x14DE6B0", VA = "0x14DE6B0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x14DE7C4", Offset = "0x14DE7C4", VA = "0x14DE7C4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x14DE8BC", Offset = "0x14DE8BC", VA = "0x14DE8BC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x14DE918", Offset = "0x14DE918", VA = "0x14DE918")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x14E4F7C", Offset = "0x14E4F7C", VA = "0x14E4F7C")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x14E4FD8", Offset = "0x14E4FD8", VA = "0x14E4FD8")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x14E5068", Offset = "0x14E5068", VA = "0x14E5068")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x14E51C8", Offset = "0x14E51C8", VA = "0x14E51C8")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x14E5284", Offset = "0x14E5284", VA = "0x14E5284")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x14E5340", Offset = "0x14E5340", VA = "0x14E5340")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x14E54EC", Offset = "0x14E54EC", VA = "0x14E54EC")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x14E553C", Offset = "0x14E553C", VA = "0x14E553C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x14E558C", Offset = "0x14E558C", VA = "0x14E558C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x14E5634", Offset = "0x14E5634", VA = "0x14E5634")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x14DD31C", Offset = "0x14DD31C", VA = "0x14DD31C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x14E56DC", Offset = "0x14E56DC", VA = "0x14E56DC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x14DD3FC", Offset = "0x14DD3FC", VA = "0x14DD3FC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x14E47AC", Offset = "0x14E47AC", VA = "0x14E47AC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x14E5730", Offset = "0x14E5730", VA = "0x14E5730")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x14E58C0", Offset = "0x14E58C0", VA = "0x14E58C0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x14E59B4", Offset = "0x14E59B4", VA = "0x14E59B4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x14E5AC0", Offset = "0x14E5AC0", VA = "0x14E5AC0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x14E5BAC", Offset = "0x14E5BAC", VA = "0x14E5BAC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730BE8", Offset = "0x730BE8")]
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
			[Address(RVA = "0x14727D4", Offset = "0x14727D4", VA = "0x14727D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1472AE0", Offset = "0x1472AE0", VA = "0x1472AE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1472694", Offset = "0x1472694", VA = "0x1472694")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1472734", Offset = "0x1472734", VA = "0x1472734", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1472738", Offset = "0x1472738", VA = "0x1472738", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x147273C", Offset = "0x147273C", VA = "0x147273C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1472740", Offset = "0x1472740", VA = "0x1472740")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x14727D0", Offset = "0x14727D0", VA = "0x14727D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1472778", Offset = "0x1472778", VA = "0x1472778")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1472A94", Offset = "0x1472A94", VA = "0x1472A94")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x14728C0", Offset = "0x14728C0", VA = "0x14728C0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1472B98", Offset = "0x1472B98", VA = "0x1472B98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1472BF4", Offset = "0x1472BF4", VA = "0x1472BF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1472C50", Offset = "0x1472C50", VA = "0x1472C50")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1472C98", Offset = "0x1472C98", VA = "0x1472C98")]
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
		[Address(RVA = "0x147330C", Offset = "0x147330C", VA = "0x147330C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x14733CC", Offset = "0x14733CC", VA = "0x14733CC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x147348C", Offset = "0x147348C", VA = "0x147348C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x147354C", Offset = "0x147354C", VA = "0x147354C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V2Tools
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1475478", Offset = "0x1475478", VA = "0x1475478")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1475480", Offset = "0x1475480", VA = "0x1475480")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x14754D0", Offset = "0x14754D0", VA = "0x14754D0")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1475524", Offset = "0x1475524", VA = "0x1475524")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x14755FC", Offset = "0x14755FC", VA = "0x14755FC")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1475690", Offset = "0x1475690", VA = "0x1475690")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x14756B4", Offset = "0x14756B4", VA = "0x14756B4")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x14756FC", Offset = "0x14756FC", VA = "0x14756FC")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1475788", Offset = "0x1475788", VA = "0x1475788")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x14757E8", Offset = "0x14757E8", VA = "0x14757E8")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1475848", Offset = "0x1475848", VA = "0x1475848")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1475964", Offset = "0x1475964", VA = "0x1475964")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1475A04", Offset = "0x1475A04", VA = "0x1475A04")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1475A40", Offset = "0x1475A40", VA = "0x1475A40")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1475A84", Offset = "0x1475A84", VA = "0x1475A84")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1475B20", Offset = "0x1475B20", VA = "0x1475B20")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1475C7C", Offset = "0x1475C7C", VA = "0x1475C7C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1475DF8", Offset = "0x1475DF8", VA = "0x1475DF8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1475F7C", Offset = "0x1475F7C", VA = "0x1475F7C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1476038", Offset = "0x1476038", VA = "0x1476038")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1476138", Offset = "0x1476138", VA = "0x1476138")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x14761C0", Offset = "0x14761C0", VA = "0x14761C0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x147625C", Offset = "0x147625C", VA = "0x147625C")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1476300", Offset = "0x1476300", VA = "0x1476300")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x14762F0", Offset = "0x14762F0", VA = "0x14762F0")]
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
		[Address(RVA = "0x147B5DC", Offset = "0x147B5DC", VA = "0x147B5DC")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x147B674", Offset = "0x147B674", VA = "0x147B674")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FBF0", Offset = "0x72FBF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FBF0", Offset = "0x72FBF0")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x157205C", Offset = "0x157205C", VA = "0x157205C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738CFC", Offset = "0x738CFC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x15720A4", Offset = "0x15720A4", VA = "0x15720A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738D34", Offset = "0x738D34")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15720EC", Offset = "0x15720EC", VA = "0x15720EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738D6C", Offset = "0x738D6C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1572134", Offset = "0x1572134", VA = "0x1572134")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738DA4", Offset = "0x738DA4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x157217C", Offset = "0x157217C", VA = "0x157217C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1572218", Offset = "0x1572218", VA = "0x1572218")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1572238", Offset = "0x1572238", VA = "0x1572238")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1572268", Offset = "0x1572268", VA = "0x1572268")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1572298", Offset = "0x1572298", VA = "0x1572298")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x15722D8", Offset = "0x15722D8", VA = "0x15722D8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x157231C", Offset = "0x157231C", VA = "0x157231C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1572340", Offset = "0x1572340", VA = "0x1572340")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1572364", Offset = "0x1572364", VA = "0x1572364")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x157238C", Offset = "0x157238C", VA = "0x157238C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x15723B8", Offset = "0x15723B8", VA = "0x15723B8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x15723E4", Offset = "0x15723E4", VA = "0x15723E4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x157219C", Offset = "0x157219C", VA = "0x157219C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x157240C", Offset = "0x157240C", VA = "0x157240C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1572418", Offset = "0x1572418", VA = "0x1572418")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1572424", Offset = "0x1572424", VA = "0x1572424")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1572708", Offset = "0x1572708", VA = "0x1572708", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x15727B0", Offset = "0x15727B0", VA = "0x15727B0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1572B90", Offset = "0x1572B90", VA = "0x1572B90", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1572D1C", Offset = "0x1572D1C", VA = "0x1572D1C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1572D50", Offset = "0x1572D50", VA = "0x1572D50")]
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
			[Address(RVA = "0x15725C4", Offset = "0x15725C4", VA = "0x15725C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1572FB8", Offset = "0x1572FB8", VA = "0x1572FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1572A6C", Offset = "0x1572A6C", VA = "0x1572A6C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1572E44", Offset = "0x1572E44", VA = "0x1572E44")]
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
			[Address(RVA = "0x157EDB4", Offset = "0x157EDB4", VA = "0x157EDB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x157EE20", Offset = "0x157EE20", VA = "0x157EE20")]
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
		[Address(RVA = "0x157EE28", Offset = "0x157EE28", VA = "0x157EE28", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x157EEE8", Offset = "0x157EEE8", VA = "0x157EEE8")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x157EEF0", Offset = "0x157EEF0", VA = "0x157EEF0")]
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
			[Address(RVA = "0x157F024", Offset = "0x157F024", VA = "0x157F024")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x157EF1C", Offset = "0x157EF1C", VA = "0x157EF1C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x157F060", Offset = "0x157F060", VA = "0x157F060")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x157F068", Offset = "0x157F068", VA = "0x157F068")]
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
		[Address(RVA = "0x157F094", Offset = "0x157F094", VA = "0x157F094", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x157F114", Offset = "0x157F114", VA = "0x157F114")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x157F11C", Offset = "0x157F11C", VA = "0x157F11C")]
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
			[Address(RVA = "0x157F250", Offset = "0x157F250", VA = "0x157F250")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x157F148", Offset = "0x157F148", VA = "0x157F148", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x157F28C", Offset = "0x157F28C", VA = "0x157F28C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x157F294", Offset = "0x157F294", VA = "0x157F294")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730C20", Offset = "0x730C20")]
		public float positionWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730C38", Offset = "0x730C38")]
		public float rotationWeight;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x157F2C0", Offset = "0x157F2C0", VA = "0x157F2C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x157F32C", Offset = "0x157F32C", VA = "0x157F32C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x157F380", Offset = "0x157F380", VA = "0x157F380")]
		public void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x157F630", Offset = "0x157F630", VA = "0x157F630")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730C50", Offset = "0x730C50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730C50", Offset = "0x730C50")]
		public float weight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730CA4", Offset = "0x730CA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730CA4", Offset = "0x730CA4")]
		public float rotationWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730CF8", Offset = "0x730CF8")]
		public DOF rotationDOF;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730D30", Offset = "0x730D30")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730D68", Offset = "0x730D68")]
		public Transform bone1;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730DA0", Offset = "0x730DA0")]
		public Transform bone2;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730DD8", Offset = "0x730DD8")]
		public Transform bone3;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730E10", Offset = "0x730E10")]
		public Transform tip;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730E48", Offset = "0x730E48")]
		public Transform target;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730E80", Offset = "0x730E80")]
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
			[Address(RVA = "0x1588704", Offset = "0x1588704", VA = "0x1588704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738DDC", Offset = "0x738DDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x158870C", Offset = "0x158870C", VA = "0x158870C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738DEC", Offset = "0x738DEC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1588718", Offset = "0x1588718", VA = "0x1588718")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1588738", Offset = "0x1588738", VA = "0x1588738")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1588758", Offset = "0x1588758", VA = "0x1588758")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1588778", Offset = "0x1588778", VA = "0x1588778")]
			set
			{
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1588798", Offset = "0x1588798", VA = "0x1588798")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x15888A0", Offset = "0x15888A0", VA = "0x15888A0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1588E18", Offset = "0x1588E18", VA = "0x1588E18")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1588EF0", Offset = "0x1588EF0", VA = "0x1588EF0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1588FB4", Offset = "0x1588FB4", VA = "0x1588FB4")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1589438", Offset = "0x1589438", VA = "0x1589438")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730E90", Offset = "0x730E90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730E90", Offset = "0x730E90")]
		public float weight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730EE4", Offset = "0x730EE4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1589448", Offset = "0x1589448", VA = "0x1589448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738DFC", Offset = "0x738DFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1589450", Offset = "0x1589450", VA = "0x1589450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738E0C", Offset = "0x738E0C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x158945C", Offset = "0x158945C", VA = "0x158945C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x15894E4", Offset = "0x15894E4", VA = "0x15894E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738E1C", Offset = "0x738E1C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x158981C", Offset = "0x158981C", VA = "0x158981C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1589994", Offset = "0x1589994", VA = "0x1589994")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1589720", Offset = "0x1589720", VA = "0x1589720")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1589B04", Offset = "0x1589B04", VA = "0x1589B04", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1589BC4", Offset = "0x1589BC4", VA = "0x1589BC4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1589C3C", Offset = "0x1589C3C", VA = "0x1589C3C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1589CB0", Offset = "0x1589CB0", VA = "0x1589CB0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1589D18", Offset = "0x1589D18", VA = "0x1589D18", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1589D1C", Offset = "0x1589D1C", VA = "0x1589D1C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1589D30", Offset = "0x1589D30", VA = "0x1589D30")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730EF4", Offset = "0x730EF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x730EF4", Offset = "0x730EF4")]
		public float weight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730F48", Offset = "0x730F48")]
		public Grounding solver;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730F80", Offset = "0x730F80")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x158B144", Offset = "0x158B144", VA = "0x158B144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738E54", Offset = "0x738E54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x158B14C", Offset = "0x158B14C", VA = "0x158B14C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738E64", Offset = "0x738E64")]
			protected set
			{
			}
		}

		[Token(Token = "0x600016E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x158B158", Offset = "0x158B158", VA = "0x158B158")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x158B304", Offset = "0x158B304", VA = "0x158B304")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x158B204", Offset = "0x158B204", VA = "0x158B204")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x158B338", Offset = "0x158B338", VA = "0x158B338")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000175")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000176")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x158B474", Offset = "0x158B474", VA = "0x158B474")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FC50", Offset = "0x72FC50")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FC50", Offset = "0x72FC50")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730F90", Offset = "0x730F90")]
		public BipedIK ik;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x730FC8", Offset = "0x730FC8")]
		public float spineBend;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731000", Offset = "0x731000")]
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
		[Address(RVA = "0x158B4E0", Offset = "0x158B4E0", VA = "0x158B4E0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738E74", Offset = "0x738E74")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x158B528", Offset = "0x158B528", VA = "0x158B528", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738EAC", Offset = "0x738EAC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x158B570", Offset = "0x158B570", VA = "0x158B570", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x158B5B0", Offset = "0x158B5B0", VA = "0x158B5B0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x158B65C", Offset = "0x158B65C", VA = "0x158B65C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x158B6BC", Offset = "0x158B6BC", VA = "0x158B6BC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x158B980", Offset = "0x158B980", VA = "0x158B980")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x158B9D4", Offset = "0x158B9D4", VA = "0x158B9D4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x158BDF0", Offset = "0x158BDF0", VA = "0x158BDF0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x158BEC4", Offset = "0x158BEC4", VA = "0x158BEC4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x158C004", Offset = "0x158C004", VA = "0x158C004")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x158C194", Offset = "0x158C194", VA = "0x158C194")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FCB0", Offset = "0x72FCB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FCB0", Offset = "0x72FCB0")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class SpineEffector
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7310E0", Offset = "0x7310E0")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731118", Offset = "0x731118")]
			public float horizontalWeight;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731150", Offset = "0x731150")]
			public float verticalWeight;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x147CB48", Offset = "0x147CB48", VA = "0x147CB48")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x147CB58", Offset = "0x147CB58", VA = "0x147CB58")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731038", Offset = "0x731038")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731070", Offset = "0x731070")]
		public float spineBend;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7310A8", Offset = "0x7310A8")]
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
		[Address(RVA = "0x158C5CC", Offset = "0x158C5CC", VA = "0x158C5CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738EE4", Offset = "0x738EE4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x158C614", Offset = "0x158C614", VA = "0x158C614", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738F1C", Offset = "0x738F1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x158C65C", Offset = "0x158C65C", VA = "0x158C65C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738F54", Offset = "0x738F54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x158C6A4", Offset = "0x158C6A4", VA = "0x158C6A4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x158C6E4", Offset = "0x158C6E4", VA = "0x158C6E4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x158C778", Offset = "0x158C778", VA = "0x158C778")]
		private void Update()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x158C9F8", Offset = "0x158C9F8", VA = "0x158C9F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x158CA04", Offset = "0x158CA04", VA = "0x158CA04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x158C7E0", Offset = "0x158C7E0", VA = "0x158C7E0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x158CA10", Offset = "0x158CA10", VA = "0x158CA10")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x158CD30", Offset = "0x158CD30", VA = "0x158CD30")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x158CE40", Offset = "0x158CE40", VA = "0x158CE40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x158CF98", Offset = "0x158CF98", VA = "0x158CF98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x158D0AC", Offset = "0x158D0AC", VA = "0x158D0AC")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FD10", Offset = "0x72FD10")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FD10", Offset = "0x72FD10")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731188", Offset = "0x731188")]
		public Transform pelvis;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7311C0", Offset = "0x7311C0")]
		public Transform characterRoot;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7311F8", Offset = "0x7311F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7311F8", Offset = "0x7311F8")]
		public float rootRotationWeight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73124C", Offset = "0x73124C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731284", Offset = "0x731284")]
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
		[Address(RVA = "0x158D134", Offset = "0x158D134", VA = "0x158D134", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738F8C", Offset = "0x738F8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x158D17C", Offset = "0x158D17C", VA = "0x158D17C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738FC4", Offset = "0x738FC4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x158D1C4", Offset = "0x158D1C4", VA = "0x158D1C4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x158D1E0", Offset = "0x158D1E0", VA = "0x158D1E0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x158D414", Offset = "0x158D414", VA = "0x158D414")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x158D510", Offset = "0x158D510", VA = "0x158D510")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x158D964", Offset = "0x158D964", VA = "0x158D964")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x158DD70", Offset = "0x158DD70", VA = "0x158DD70")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x158DF00", Offset = "0x158DF00", VA = "0x158DF00")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x158E204", Offset = "0x158E204", VA = "0x158E204")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x158E350", Offset = "0x158E350", VA = "0x158E350")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x158E538", Offset = "0x158E538", VA = "0x158E538")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FD70", Offset = "0x72FD70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FD70", Offset = "0x72FD70")]
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
			[Address(RVA = "0x147CBA0", Offset = "0x147CBA0", VA = "0x147CBA0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7312BC", Offset = "0x7312BC")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7312F4", Offset = "0x7312F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7312F4", Offset = "0x7312F4")]
		public float rootRotationWeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x731348", Offset = "0x731348")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731348", Offset = "0x731348")]
		public float minRootRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7313A0", Offset = "0x7313A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7313A0", Offset = "0x7313A0")]
		public float maxRootRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7313F8", Offset = "0x7313F8")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731430", Offset = "0x731430")]
		public float maxLegOffset;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731468", Offset = "0x731468")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7314A0", Offset = "0x7314A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7314A0", Offset = "0x7314A0")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7314F4", Offset = "0x7314F4")]
		public Transform characterRoot;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73152C", Offset = "0x73152C")]
		public Transform pelvis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731564", Offset = "0x731564")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73159C", Offset = "0x73159C")]
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
		[Address(RVA = "0x158E5C0", Offset = "0x158E5C0", VA = "0x158E5C0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x738FFC", Offset = "0x738FFC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x158E608", Offset = "0x158E608", VA = "0x158E608", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739034", Offset = "0x739034")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x158E650", Offset = "0x158E650", VA = "0x158E650", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x158E68C", Offset = "0x158E68C", VA = "0x158E68C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x158E7B8", Offset = "0x158E7B8", VA = "0x158E7B8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x158E9BC", Offset = "0x158E9BC", VA = "0x158E9BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x158EA24", Offset = "0x158EA24", VA = "0x158EA24")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x158EA88", Offset = "0x158EA88", VA = "0x158EA88")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x158EDBC", Offset = "0x158EDBC", VA = "0x158EDBC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x158F100", Offset = "0x158F100", VA = "0x158F100")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x158F1F8", Offset = "0x158F1F8", VA = "0x158F1F8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x158F5C4", Offset = "0x158F5C4", VA = "0x158F5C4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x158FBE8", Offset = "0x158FBE8", VA = "0x158FBE8")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x158FDB8", Offset = "0x158FDB8", VA = "0x158FDB8")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x158FE94", Offset = "0x158FE94", VA = "0x158FE94")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x15900DC", Offset = "0x15900DC", VA = "0x15900DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1590114", Offset = "0x1590114", VA = "0x1590114")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x15902F4", Offset = "0x15902F4", VA = "0x15902F4")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FDD0", Offset = "0x72FDD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FDD0", Offset = "0x72FDD0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7315E4", Offset = "0x7315E4")]
		public VRIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x162DE2C", Offset = "0x162DE2C", VA = "0x162DE2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73906C", Offset = "0x73906C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x162DE74", Offset = "0x162DE74", VA = "0x162DE74", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7390A4", Offset = "0x7390A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x162DEBC", Offset = "0x162DEBC", VA = "0x162DEBC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7390DC", Offset = "0x7390DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x162DF04", Offset = "0x162DF04", VA = "0x162DF04", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x162DFA8", Offset = "0x162DFA8", VA = "0x162DFA8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x162E03C", Offset = "0x162E03C", VA = "0x162E03C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x162E09C", Offset = "0x162E09C", VA = "0x162E09C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x162E544", Offset = "0x162E544", VA = "0x162E544")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x162E9A4", Offset = "0x162E9A4", VA = "0x162E9A4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x162EA34", Offset = "0x162EA34", VA = "0x162EA34")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x162EBF0", Offset = "0x162EBF0", VA = "0x162EBF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x162ED48", Offset = "0x162ED48", VA = "0x162ED48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x162EEC8", Offset = "0x162EEC8", VA = "0x162EEC8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731AC8", Offset = "0x731AC8")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731AD8", Offset = "0x731AD8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731AE8", Offset = "0x731AE8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731AF8", Offset = "0x731AF8")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731B08", Offset = "0x731B08")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731B18", Offset = "0x731B18")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731B28", Offset = "0x731B28")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731B38", Offset = "0x731B38")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731B48", Offset = "0x731B48")]
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
				[Address(RVA = "0x147CBE0", Offset = "0x147CBE0", VA = "0x147CBE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7391B4", Offset = "0x7391B4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x147CBE8", Offset = "0x147CBE8", VA = "0x147CBE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7391C4", Offset = "0x7391C4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x147CBF4", Offset = "0x147CBF4", VA = "0x147CBF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7391D4", Offset = "0x7391D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x147CC00", Offset = "0x147CC00", VA = "0x147CC00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7391E4", Offset = "0x7391E4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x147CC0C", Offset = "0x147CC0C", VA = "0x147CC0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7391F4", Offset = "0x7391F4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x147CC14", Offset = "0x147CC14", VA = "0x147CC14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739204", Offset = "0x739204")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x147CC20", Offset = "0x147CC20", VA = "0x147CC20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739214", Offset = "0x739214")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x147CC28", Offset = "0x147CC28", VA = "0x147CC28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739224", Offset = "0x739224")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x147CC30", Offset = "0x147CC30", VA = "0x147CC30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739234", Offset = "0x739234")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x147CC3C", Offset = "0x147CC3C", VA = "0x147CC3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739244", Offset = "0x739244")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x147CC48", Offset = "0x147CC48", VA = "0x147CC48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739254", Offset = "0x739254")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x147CC50", Offset = "0x147CC50", VA = "0x147CC50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739264", Offset = "0x739264")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x147CC58", Offset = "0x147CC58", VA = "0x147CC58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739274", Offset = "0x739274")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x147CC60", Offset = "0x147CC60", VA = "0x147CC60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739284", Offset = "0x739284")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x147CC68", Offset = "0x147CC68", VA = "0x147CC68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739294", Offset = "0x739294")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x147CC80", Offset = "0x147CC80", VA = "0x147CC80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392A4", Offset = "0x7392A4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x147CCA0", Offset = "0x147CCA0", VA = "0x147CCA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392B4", Offset = "0x7392B4")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x147CCB8", Offset = "0x147CCB8", VA = "0x147CCB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392C4", Offset = "0x7392C4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x147CCD8", Offset = "0x147CCD8", VA = "0x147CCD8")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x147DE9C", Offset = "0x147DE9C", VA = "0x147DE9C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x147E000", Offset = "0x147E000", VA = "0x147E000")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x147CD20", Offset = "0x147CD20", VA = "0x147CD20")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x147CD34", Offset = "0x147CD34", VA = "0x147CD34")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x147CDA8", Offset = "0x147CDA8", VA = "0x147CDA8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x147CDF4", Offset = "0x147CDF4", VA = "0x147CDF4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x147CE64", Offset = "0x147CE64", VA = "0x147CE64")]
			public void Process()
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x147DB10", Offset = "0x147DB10", VA = "0x147DB10")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x147D6B0", Offset = "0x147D6B0", VA = "0x147D6B0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x147DF30", Offset = "0x147DF30", VA = "0x147DF30")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x147D950", Offset = "0x147D950", VA = "0x147D950")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x147D9DC", Offset = "0x147D9DC", VA = "0x147D9DC")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x147DFA0", Offset = "0x147DFA0", VA = "0x147DFA0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x147DEC4", Offset = "0x147DEC4", VA = "0x147DEC4")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x147E094", Offset = "0x147E094", VA = "0x147E094")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x147E120", Offset = "0x147E120", VA = "0x147E120")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003F")]
		public class Pelvis
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731B58", Offset = "0x731B58")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731B68", Offset = "0x731B68")]
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
				[Address(RVA = "0x147E164", Offset = "0x147E164", VA = "0x147E164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392D4", Offset = "0x7392D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x147E170", Offset = "0x147E170", VA = "0x147E170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392E4", Offset = "0x7392E4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x147E17C", Offset = "0x147E17C", VA = "0x147E17C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7392F4", Offset = "0x7392F4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x147E184", Offset = "0x147E184", VA = "0x147E184")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739304", Offset = "0x739304")]
				private set
				{
				}
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x147E18C", Offset = "0x147E18C", VA = "0x147E18C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x147E1FC", Offset = "0x147E1FC", VA = "0x147E1FC")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x147E19C", Offset = "0x147E19C", VA = "0x147E19C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x147E268", Offset = "0x147E268", VA = "0x147E268")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x147E408", Offset = "0x147E408", VA = "0x147E408")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73161C", Offset = "0x73161C")]
		public LayerMask layers;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731654", Offset = "0x731654")]
		public float maxStep;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73168C", Offset = "0x73168C")]
		public float heightOffset;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7316C4", Offset = "0x7316C4")]
		public float footSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7316FC", Offset = "0x7316FC")]
		public float footRadius;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731734", Offset = "0x731734")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731780", Offset = "0x731780")]
		public float prediction;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7317B8", Offset = "0x7317B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7317B8", Offset = "0x7317B8")]
		public float footRotationWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73180C", Offset = "0x73180C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x731844", Offset = "0x731844")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731844", Offset = "0x731844")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73189C", Offset = "0x73189C")]
		public bool rotateSolver;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7318D4", Offset = "0x7318D4")]
		public float pelvisSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73190C", Offset = "0x73190C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73190C", Offset = "0x73190C")]
		public float pelvisDamper;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731960", Offset = "0x731960")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731998", Offset = "0x731998")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7319D0", Offset = "0x7319D0")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731A08", Offset = "0x731A08")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731A40", Offset = "0x731A40")]
		public Quality quality;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731A78", Offset = "0x731A78")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731A88", Offset = "0x731A88")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731A98", Offset = "0x731A98")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731AA8", Offset = "0x731AA8")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x731AB8", Offset = "0x731AB8")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x162EF24", Offset = "0x162EF24", VA = "0x162EF24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739114", Offset = "0x739114")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x162EF2C", Offset = "0x162EF2C", VA = "0x162EF2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739124", Offset = "0x739124")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x162EF34", Offset = "0x162EF34", VA = "0x162EF34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739134", Offset = "0x739134")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x162EF3C", Offset = "0x162EF3C", VA = "0x162EF3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739144", Offset = "0x739144")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x162EF44", Offset = "0x162EF44", VA = "0x162EF44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739154", Offset = "0x739154")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x162EF4C", Offset = "0x162EF4C", VA = "0x162EF4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739164", Offset = "0x739164")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x162EF58", Offset = "0x162EF58", VA = "0x162EF58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739174", Offset = "0x739174")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x162EF60", Offset = "0x162EF60", VA = "0x162EF60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739184", Offset = "0x739184")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x162EF68", Offset = "0x162EF68", VA = "0x162EF68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739194", Offset = "0x739194")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x162EF80", Offset = "0x162EF80", VA = "0x162EF80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7391A4", Offset = "0x7391A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x162EFA0", Offset = "0x162EFA0", VA = "0x162EFA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x162F240", Offset = "0x162F240", VA = "0x162F240")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x162F504", Offset = "0x162F504", VA = "0x162F504")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x162EFF4", Offset = "0x162EFF4", VA = "0x162EFF4")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x162F284", Offset = "0x162F284", VA = "0x162F284")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x162E2BC", Offset = "0x162E2BC", VA = "0x162E2BC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x162E734", Offset = "0x162E734", VA = "0x162E734")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x162F3A4", Offset = "0x162F3A4", VA = "0x162F3A4")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x162DF1C", Offset = "0x162DF1C", VA = "0x162DF1C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x162F38C", Offset = "0x162F38C", VA = "0x162F38C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x162F584", Offset = "0x162F584", VA = "0x162F584")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x162F614", Offset = "0x162F614", VA = "0x162F614")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x162F6D0", Offset = "0x162F6D0", VA = "0x162F6D0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x162F74C", Offset = "0x162F74C", VA = "0x162F74C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FE30", Offset = "0x72FE30")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FE30", Offset = "0x72FE30")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x156C6C8", Offset = "0x156C6C8", VA = "0x156C6C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739314", Offset = "0x739314")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x156C710", Offset = "0x156C710", VA = "0x156C710", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73934C", Offset = "0x73934C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x156C758", Offset = "0x156C758", VA = "0x156C758")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739384", Offset = "0x739384")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x156C7A0", Offset = "0x156C7A0", VA = "0x156C7A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7393BC", Offset = "0x7393BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x156C7E8", Offset = "0x156C7E8", VA = "0x156C7E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7393F4", Offset = "0x7393F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x156C830", Offset = "0x156C830", VA = "0x156C830", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x156C838", Offset = "0x156C838", VA = "0x156C838")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FE90", Offset = "0x72FE90")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FE90", Offset = "0x72FE90")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x156E128", Offset = "0x156E128", VA = "0x156E128", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73942C", Offset = "0x73942C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x156E170", Offset = "0x156E170", VA = "0x156E170", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739464", Offset = "0x739464")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x156E1B8", Offset = "0x156E1B8", VA = "0x156E1B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73949C", Offset = "0x73949C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x156E200", Offset = "0x156E200", VA = "0x156E200")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7394D4", Offset = "0x7394D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x156E248", Offset = "0x156E248", VA = "0x156E248", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x156E250", Offset = "0x156E250", VA = "0x156E250")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FEF0", Offset = "0x72FEF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FEF0", Offset = "0x72FEF0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x157A5BC", Offset = "0x157A5BC", VA = "0x157A5BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73950C", Offset = "0x73950C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x157A604", Offset = "0x157A604", VA = "0x157A604", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739544", Offset = "0x739544")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x157A64C", Offset = "0x157A64C", VA = "0x157A64C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73957C", Offset = "0x73957C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x157A694", Offset = "0x157A694", VA = "0x157A694")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7395B4", Offset = "0x7395B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x157A6DC", Offset = "0x157A6DC", VA = "0x157A6DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x157A6E4", Offset = "0x157A6E4", VA = "0x157A6E4")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FF50", Offset = "0x72FF50")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FF50", Offset = "0x72FF50")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1580E2C", Offset = "0x1580E2C", VA = "0x1580E2C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7395EC", Offset = "0x7395EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1580E74", Offset = "0x1580E74", VA = "0x1580E74", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739624", Offset = "0x739624")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1580EBC", Offset = "0x1580EBC", VA = "0x1580EBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73965C", Offset = "0x73965C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1580F04", Offset = "0x1580F04", VA = "0x1580F04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739694", Offset = "0x739694")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1580F4C", Offset = "0x1580F4C", VA = "0x1580F4C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1580F54", Offset = "0x1580F54", VA = "0x1580F54")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x72FFB0", Offset = "0x72FFB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x72FFB0", Offset = "0x72FFB0")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1581478", Offset = "0x1581478", VA = "0x1581478", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7396CC", Offset = "0x7396CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x15814C0", Offset = "0x15814C0", VA = "0x15814C0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739704", Offset = "0x739704")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1581508", Offset = "0x1581508", VA = "0x1581508")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73973C", Offset = "0x73973C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1581550", Offset = "0x1581550", VA = "0x1581550")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739774", Offset = "0x739774")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1581598", Offset = "0x1581598", VA = "0x1581598", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x15815A0", Offset = "0x15815A0", VA = "0x15815A0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730010", Offset = "0x730010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730010", Offset = "0x730010")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1589D94", Offset = "0x1589D94", VA = "0x1589D94", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7397AC", Offset = "0x7397AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1589DDC", Offset = "0x1589DDC", VA = "0x1589DDC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7397E4", Offset = "0x7397E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1589E24", Offset = "0x1589E24", VA = "0x1589E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73981C", Offset = "0x73981C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1589E6C", Offset = "0x1589E6C", VA = "0x1589E6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739854", Offset = "0x739854")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1589EB4", Offset = "0x1589EB4", VA = "0x1589EB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73988C", Offset = "0x73988C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1589EFC", Offset = "0x1589EFC", VA = "0x1589EFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7398C4", Offset = "0x7398C4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1589F44", Offset = "0x1589F44", VA = "0x1589F44")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1589F68", Offset = "0x1589F68", VA = "0x1589F68", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1589F70", Offset = "0x1589F70", VA = "0x1589F70")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x158A14C", Offset = "0x158A14C", VA = "0x158A14C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x158A3E0", Offset = "0x158A3E0", VA = "0x158A3E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7398FC", Offset = "0x7398FC")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x158A400", Offset = "0x158A400", VA = "0x158A400")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739934", Offset = "0x739934")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x158A4D8", Offset = "0x158A4D8", VA = "0x158A4D8")]
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
		[Address(RVA = "0x1632CC0", Offset = "0x1632CC0", VA = "0x1632CC0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1632DB4", Offset = "0x1632DB4", VA = "0x1632DB4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1632FA0", Offset = "0x1632FA0", VA = "0x1632FA0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000238")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000239")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1633000", Offset = "0x1633000", VA = "0x1633000")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731B78", Offset = "0x731B78")]
		public IK[] IKComponents;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731BB0", Offset = "0x731BB0")]
		public Animator animator;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1635570", Offset = "0x1635570", VA = "0x1635570")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1635608", Offset = "0x1635608", VA = "0x1635608")]
		private void Start()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1635678", Offset = "0x1635678", VA = "0x1635678")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1635734", Offset = "0x1635734", VA = "0x1635734")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1635770", Offset = "0x1635770", VA = "0x1635770")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x16356AC", Offset = "0x16356AC", VA = "0x16356AC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x16357FC", Offset = "0x16357FC", VA = "0x16357FC")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730070", Offset = "0x730070")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730070", Offset = "0x730070")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x14DE948", Offset = "0x14DE948", VA = "0x14DE948", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73996C", Offset = "0x73996C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x14DE990", Offset = "0x14DE990", VA = "0x14DE990", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7399A4", Offset = "0x7399A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x14DE9D8", Offset = "0x14DE9D8", VA = "0x14DE9D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7399DC", Offset = "0x7399DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x14DEA20", Offset = "0x14DEA20", VA = "0x14DEA20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739A14", Offset = "0x739A14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x14DEA68", Offset = "0x14DEA68", VA = "0x14DEA68", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x14DEA70", Offset = "0x14DEA70", VA = "0x14DEA70")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7300D0", Offset = "0x7300D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7300D0", Offset = "0x7300D0")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x14DEAD4", Offset = "0x14DEAD4", VA = "0x14DEAD4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739A4C", Offset = "0x739A4C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x14DEB1C", Offset = "0x14DEB1C", VA = "0x14DEB1C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739A84", Offset = "0x739A84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x14DEB64", Offset = "0x14DEB64", VA = "0x14DEB64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739ABC", Offset = "0x739ABC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x14DEBAC", Offset = "0x14DEBAC", VA = "0x14DEBAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739AF4", Offset = "0x739AF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x14DEBF4", Offset = "0x14DEBF4", VA = "0x14DEBF4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x14DEBFC", Offset = "0x14DEBFC", VA = "0x14DEBFC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730130", Offset = "0x730130")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730130", Offset = "0x730130")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x14DF5E8", Offset = "0x14DF5E8", VA = "0x14DF5E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739B2C", Offset = "0x739B2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x14DF630", Offset = "0x14DF630", VA = "0x14DF630", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739B64", Offset = "0x739B64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x14DF678", Offset = "0x14DF678", VA = "0x14DF678")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739B9C", Offset = "0x739B9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x14DF6C0", Offset = "0x14DF6C0", VA = "0x14DF6C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739BD4", Offset = "0x739BD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x14DF708", Offset = "0x14DF708", VA = "0x14DF708", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x14DF710", Offset = "0x14DF710", VA = "0x14DF710")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730190", Offset = "0x730190")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730190", Offset = "0x730190")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1473554", Offset = "0x1473554", VA = "0x1473554", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739C0C", Offset = "0x739C0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x147359C", Offset = "0x147359C", VA = "0x147359C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739C44", Offset = "0x739C44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x14735E4", Offset = "0x14735E4", VA = "0x14735E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739C7C", Offset = "0x739C7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x147362C", Offset = "0x147362C", VA = "0x147362C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739CB4", Offset = "0x739CB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1473674", Offset = "0x1473674", VA = "0x1473674", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x147367C", Offset = "0x147367C", VA = "0x147367C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7301F0", Offset = "0x7301F0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731C94", Offset = "0x731C94")]
			public Transform chest;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731CCC", Offset = "0x731CCC")]
			public Transform neck;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731D04", Offset = "0x731D04")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731D3C", Offset = "0x731D3C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731D74", Offset = "0x731D74")]
			public Transform leftThigh;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731DAC", Offset = "0x731DAC")]
			public Transform leftCalf;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731DE4", Offset = "0x731DE4")]
			public Transform leftFoot;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731E1C", Offset = "0x731E1C")]
			public Transform leftToes;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731E54", Offset = "0x731E54")]
			public Transform rightThigh;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731E8C", Offset = "0x731E8C")]
			public Transform rightCalf;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731EC4", Offset = "0x731EC4")]
			public Transform rightFoot;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731EFC", Offset = "0x731EFC")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x17ED7BC", Offset = "0x17ED7BC", VA = "0x17ED7BC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x17EDC34", Offset = "0x17EDC34", VA = "0x17EDC34")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x17ED374", Offset = "0x17ED374", VA = "0x17ED374")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x17EE0AC", Offset = "0x17EE0AC", VA = "0x17EE0AC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x17EE448", Offset = "0x17EE448", VA = "0x17EE448")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731BE8", Offset = "0x731BE8")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x731BE8", Offset = "0x731BE8")]
		public References references;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731C5C", Offset = "0x731C5C")]
		public IKSolverVR solver;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1476380", Offset = "0x1476380", VA = "0x1476380", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739CEC", Offset = "0x739CEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x14763C8", Offset = "0x14763C8", VA = "0x14763C8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739D24", Offset = "0x739D24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1476410", Offset = "0x1476410", VA = "0x1476410")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739D5C", Offset = "0x739D5C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1476458", Offset = "0x1476458", VA = "0x1476458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739D94", Offset = "0x739D94")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1476484", Offset = "0x1476484", VA = "0x1476484")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x739DCC", Offset = "0x739DCC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x14764AC", Offset = "0x14764AC", VA = "0x14764AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x14764B4", Offset = "0x14764B4", VA = "0x14764B4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1476534", Offset = "0x1476534", VA = "0x1476534", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x14766A0", Offset = "0x14766A0", VA = "0x14766A0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x731F34", Offset = "0x731F34")]
		public float pull;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x731F4C", Offset = "0x731F4C")]
		public float pin;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1580FB8", Offset = "0x1580FB8", VA = "0x1580FB8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1581088", Offset = "0x1581088", VA = "0x1581088")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x15810A8", Offset = "0x15810A8", VA = "0x15810A8")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x158131C", Offset = "0x158131C", VA = "0x158131C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x158117C", Offset = "0x158117C", VA = "0x158117C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1581414", Offset = "0x1581414", VA = "0x1581414")]
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
		[Address(RVA = "0x1581604", Offset = "0x1581604", VA = "0x1581604")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1581A68", Offset = "0x1581A68", VA = "0x1581A68")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1581C24", Offset = "0x1581C24", VA = "0x1581C24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1581D30", Offset = "0x1581D30", VA = "0x1581D30")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7325A4", Offset = "0x7325A4")]
			public Transform transform;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7325DC", Offset = "0x7325DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7325DC", Offset = "0x7325DC")]
			public float weight;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x147BF78", Offset = "0x147BF78", VA = "0x147BF78")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x147BFB4", Offset = "0x147BFB4", VA = "0x147BFB4")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x147C00C", Offset = "0x147C00C", VA = "0x147C00C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x147C044", Offset = "0x147C044", VA = "0x147C044")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731F64", Offset = "0x731F64")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x731F9C", Offset = "0x731F9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x731F9C", Offset = "0x731F9C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x731F9C", Offset = "0x731F9C")]
		public float positionWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732014", Offset = "0x732014")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732014", Offset = "0x732014")]
		public float bodyWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732068", Offset = "0x732068")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732068", Offset = "0x732068")]
		public float thighWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7320BC", Offset = "0x7320BC")]
		public bool handsPullBody;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7320F4", Offset = "0x7320F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7320F4", Offset = "0x7320F4")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7320F4", Offset = "0x7320F4")]
		public float rotationWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73216C", Offset = "0x73216C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73216C", Offset = "0x73216C")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7321C0", Offset = "0x7321C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7321C0", Offset = "0x7321C0")]
		public float headClampWeight;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732214", Offset = "0x732214")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732214", Offset = "0x732214")]
		public float bendWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732268", Offset = "0x732268")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7322A0", Offset = "0x7322A0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7322A0", Offset = "0x7322A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7322A0", Offset = "0x7322A0")]
		public float CCDWeight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732318", Offset = "0x732318")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732318", Offset = "0x732318")]
		public float roll;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73236C", Offset = "0x73236C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73236C", Offset = "0x73236C")]
		public float damper;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7323C4", Offset = "0x7323C4")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7323FC", Offset = "0x7323FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7323FC", Offset = "0x7323FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7323FC", Offset = "0x7323FC")]
		public float postStretchWeight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732474", Offset = "0x732474")]
		public float maxStretch;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7324AC", Offset = "0x7324AC")]
		public float stretchDamper;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7324E4", Offset = "0x7324E4")]
		public bool fixHead;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73251C", Offset = "0x73251C")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x732554", Offset = "0x732554")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73258C", Offset = "0x73258C")]
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
		[Address(RVA = "0x1581D38", Offset = "0x1581D38", VA = "0x1581D38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x158206C", Offset = "0x158206C", VA = "0x158206C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x158250C", Offset = "0x158250C", VA = "0x158250C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x15828D8", Offset = "0x15828D8", VA = "0x15828D8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1583064", Offset = "0x1583064", VA = "0x1583064")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1583344", Offset = "0x1583344", VA = "0x1583344")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1583648", Offset = "0x1583648", VA = "0x1583648")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1583E1C", Offset = "0x1583E1C", VA = "0x1583E1C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1582E48", Offset = "0x1582E48", VA = "0x1582E48")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1583FE4", Offset = "0x1583FE4", VA = "0x1583FE4")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1583D34", Offset = "0x1583D34", VA = "0x1583D34")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1583C68", Offset = "0x1583C68", VA = "0x1583C68")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1584268", Offset = "0x1584268", VA = "0x1584268")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1584538", Offset = "0x1584538", VA = "0x1584538")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7326C8", Offset = "0x7326C8")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7326D8", Offset = "0x7326D8")]
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
				[Address(RVA = "0x147C100", Offset = "0x147C100", VA = "0x147C100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E04", Offset = "0x739E04")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x147C108", Offset = "0x147C108", VA = "0x147C108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E14", Offset = "0x739E14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x147C110", Offset = "0x147C110", VA = "0x147C110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E24", Offset = "0x739E24")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029B")]
				[Address(RVA = "0x147C118", Offset = "0x147C118", VA = "0x147C118")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E34", Offset = "0x739E34")]
				private set
				{
				}
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x147C124", Offset = "0x147C124", VA = "0x147C124")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x147C170", Offset = "0x147C170", VA = "0x147C170")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x147C1C8", Offset = "0x147C1C8", VA = "0x147C1C8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x147C36C", Offset = "0x147C36C", VA = "0x147C36C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732630", Offset = "0x732630")]
		public float pin;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732648", Offset = "0x732648")]
		public float pull;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732660", Offset = "0x732660")]
		public float push;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732678", Offset = "0x732678")]
		public float pushParent;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732690", Offset = "0x732690")]
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
		[Address(RVA = "0x1584C14", Offset = "0x1584C14", VA = "0x1584C14")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1584D00", Offset = "0x1584D00", VA = "0x1584D00")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1584E2C", Offset = "0x1584E2C", VA = "0x1584E2C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1584F58", Offset = "0x1584F58", VA = "0x1584F58")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1585030", Offset = "0x1585030", VA = "0x1585030")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1585148", Offset = "0x1585148", VA = "0x1585148")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x15857C4", Offset = "0x15857C4", VA = "0x15857C4")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x15852D8", Offset = "0x15852D8", VA = "0x15852D8")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1585BB4", Offset = "0x1585BB4", VA = "0x1585BB4")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1585E14", Offset = "0x1585E14", VA = "0x1585E14")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1586080", Offset = "0x1586080", VA = "0x1586080")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1586424", Offset = "0x1586424", VA = "0x1586424")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x15868B8", Offset = "0x15868B8", VA = "0x15868B8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1586ADC", Offset = "0x1586ADC", VA = "0x1586ADC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1586848", Offset = "0x1586848", VA = "0x1586848")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x15862B0", Offset = "0x15862B0", VA = "0x15862B0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x15867CC", Offset = "0x15867CC", VA = "0x15867CC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1586BC4", Offset = "0x1586BC4", VA = "0x1586BC4")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x15866EC", Offset = "0x15866EC", VA = "0x15866EC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x15869C4", Offset = "0x15869C4", VA = "0x15869C4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7326E8", Offset = "0x7326E8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x732700", Offset = "0x732700")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x16331F0", Offset = "0x16331F0", VA = "0x16331F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E44", Offset = "0x739E44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x16331F8", Offset = "0x16331F8", VA = "0x16331F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E54", Offset = "0x739E54")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1633008", Offset = "0x1633008", VA = "0x1633008")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1633204", Offset = "0x1633204", VA = "0x1633204")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1633244", Offset = "0x1633244", VA = "0x1633244")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x16332A4", Offset = "0x16332A4", VA = "0x16332A4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x16332B0", Offset = "0x16332B0", VA = "0x16332B0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1633628", Offset = "0x1633628", VA = "0x1633628")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1633818", Offset = "0x1633818", VA = "0x1633818")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1633B64", Offset = "0x1633B64", VA = "0x1633B64")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x16334E8", Offset = "0x16334E8", VA = "0x16334E8")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1633588", Offset = "0x1633588", VA = "0x1633588")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732710", Offset = "0x732710")]
		public float positionWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732728", Offset = "0x732728")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x732740", Offset = "0x732740")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732750", Offset = "0x732750")]
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
			[Address(RVA = "0x1634044", Offset = "0x1634044", VA = "0x1634044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E64", Offset = "0x739E64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x163404C", Offset = "0x163404C", VA = "0x163404C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E74", Offset = "0x739E74")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1633FDC", Offset = "0x1633FDC", VA = "0x1633FDC")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1634058", Offset = "0x1634058", VA = "0x1634058")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x16340E8", Offset = "0x16340E8", VA = "0x16340E8")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x16341FC", Offset = "0x16341FC", VA = "0x16341FC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x163432C", Offset = "0x163432C", VA = "0x163432C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1634648", Offset = "0x1634648", VA = "0x1634648")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x16348C8", Offset = "0x16348C8", VA = "0x16348C8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1634994", Offset = "0x1634994", VA = "0x1634994")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1634A3C", Offset = "0x1634A3C", VA = "0x1634A3C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1634F64", Offset = "0x1634F64", VA = "0x1634F64")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1634F90", Offset = "0x1634F90", VA = "0x1634F90")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x16350E4", Offset = "0x16350E4", VA = "0x16350E4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x163535C", Offset = "0x163535C", VA = "0x163535C")]
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
				[Address(RVA = "0x1471730", Offset = "0x1471730", VA = "0x1471730")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x147F810", Offset = "0x147F810", VA = "0x147F810")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0x147FBB4", Offset = "0x147FBB4", VA = "0x147FBB4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x147F744", Offset = "0x147F744", VA = "0x147F744")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x147F770", Offset = "0x147F770", VA = "0x147F770")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x147F7C0", Offset = "0x147F7C0", VA = "0x147F7C0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x147F820", Offset = "0x147F820", VA = "0x147F820")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x147F8A8", Offset = "0x147F8A8", VA = "0x147F8A8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x147F8B0", Offset = "0x147F8B0", VA = "0x147F8B0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x147F988", Offset = "0x147F988", VA = "0x147F988")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x147FA00", Offset = "0x147FA00", VA = "0x147FA00")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x147FA98", Offset = "0x147FA98", VA = "0x147FA98")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x147FCF4", Offset = "0x147FCF4", VA = "0x147FCF4")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x147FD2C", Offset = "0x147FD2C", VA = "0x147FD2C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x147FD64", Offset = "0x147FD64", VA = "0x147FD64")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x147FD8C", Offset = "0x147FD8C", VA = "0x147FD8C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x147FE78", Offset = "0x147FE78", VA = "0x147FE78")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1480004", Offset = "0x1480004", VA = "0x1480004")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1480034", Offset = "0x1480034", VA = "0x1480034")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x14800FC", Offset = "0x14800FC", VA = "0x14800FC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x148016C", Offset = "0x148016C", VA = "0x148016C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x14802BC", Offset = "0x14802BC", VA = "0x14802BC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x148040C", Offset = "0x148040C", VA = "0x148040C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x148048C", Offset = "0x148048C", VA = "0x148048C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x147FEF4", Offset = "0x147FEF4", VA = "0x147FEF4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x14805C4", Offset = "0x14805C4", VA = "0x14805C4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1635804", Offset = "0x1635804", VA = "0x1635804", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x163580C", Offset = "0x163580C", VA = "0x163580C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1635810", Offset = "0x1635810", VA = "0x1635810")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1635954", Offset = "0x1635954", VA = "0x1635954")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x16359C4", Offset = "0x16359C4", VA = "0x16359C4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732768", Offset = "0x732768")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x16359CC", Offset = "0x16359CC", VA = "0x16359CC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1635A74", Offset = "0x1635A74", VA = "0x1635A74")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1635AE0", Offset = "0x1635AE0", VA = "0x1635AE0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1635B60", Offset = "0x1635B60", VA = "0x1635B60")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1635B7C", Offset = "0x1635B7C", VA = "0x1635B7C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1635B9C", Offset = "0x1635B9C", VA = "0x1635B9C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1635C24", Offset = "0x1635C24", VA = "0x1635C24")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1635C40", Offset = "0x1635C40", VA = "0x1635C40")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732780", Offset = "0x732780")]
		public float maintainRotationWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732798", Offset = "0x732798")]
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
		[Address(RVA = "0x1635C68", Offset = "0x1635C68", VA = "0x1635C68", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1635CEC", Offset = "0x1635CEC", VA = "0x1635CEC")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1635DC8", Offset = "0x1635DC8", VA = "0x1635DC8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1635FEC", Offset = "0x1635FEC", VA = "0x1635FEC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x16360B0", Offset = "0x16360B0", VA = "0x16360B0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x16361A0", Offset = "0x16361A0", VA = "0x16361A0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x16361AC", Offset = "0x16361AC", VA = "0x16361AC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1636260", Offset = "0x1636260", VA = "0x1636260")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1636324", Offset = "0x1636324", VA = "0x1636324", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1636564", Offset = "0x1636564", VA = "0x1636564")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x16365D8", Offset = "0x16365D8", VA = "0x16365D8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7327B0", Offset = "0x7327B0")]
		public int iterations;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7327C8", Offset = "0x7327C8")]
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
		[Address(RVA = "0x1636754", Offset = "0x1636754", VA = "0x1636754", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1636AB8", Offset = "0x1636AB8", VA = "0x1636AB8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1636B9C", Offset = "0x1636B9C", VA = "0x1636B9C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1636CB4", Offset = "0x1636CB4", VA = "0x1636CB4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1636CC4", Offset = "0x1636CC4", VA = "0x1636CC4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1636D30", Offset = "0x1636D30", VA = "0x1636D30")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1636DB4", Offset = "0x1636DB4", VA = "0x1636DB4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x163738C", Offset = "0x163738C", VA = "0x163738C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x16373C4", Offset = "0x16373C4", VA = "0x16373C4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1637648", Offset = "0x1637648", VA = "0x1637648")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1637948", Offset = "0x1637948", VA = "0x1637948")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1637A34", Offset = "0x1637A34", VA = "0x1637A34")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1637AFC", Offset = "0x1637AFC", VA = "0x1637AFC")]
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
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73289C", Offset = "0x73289C")]
			public float weight;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x169E220", Offset = "0x169E220", VA = "0x169E220")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x169E270", Offset = "0x169E270", VA = "0x169E270")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x169E310", Offset = "0x169E310", VA = "0x169E310")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x169E348", Offset = "0x169E348", VA = "0x169E348")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x169E380", Offset = "0x169E380", VA = "0x169E380")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x169E3D0", Offset = "0x169E3D0", VA = "0x169E3D0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x169E184", Offset = "0x169E184", VA = "0x169E184")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public class Bone : Point
		{
			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700003B")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000317")]
				[Address(RVA = "0x14805E0", Offset = "0x14805E0", VA = "0x14805E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x14806DC", Offset = "0x14806DC", VA = "0x14806DC")]
				set
				{
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1480760", Offset = "0x1480760", VA = "0x1480760")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1480910", Offset = "0x1480910", VA = "0x1480910")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1480AE4", Offset = "0x1480AE4", VA = "0x1480AE4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1480C44", Offset = "0x1480C44", VA = "0x1480C44")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1480C6C", Offset = "0x1480C6C", VA = "0x1480C6C")]
			public Bone()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1480CB4", Offset = "0x1480CB4", VA = "0x1480CB4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1480D08", Offset = "0x1480D08", VA = "0x1480D08")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000060")]
		public class Node : Point
		{
			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x169E180", Offset = "0x169E180", VA = "0x169E180")]
			public Node()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x169E1C0", Offset = "0x169E1C0", VA = "0x169E1C0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x169E1E8", Offset = "0x169E1E8", VA = "0x169E1E8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732800", Offset = "0x732800")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732800", Offset = "0x732800")]
		public float IKPositionWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x732854", Offset = "0x732854")]
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
		protected bool firstInitiation;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1637E2C", Offset = "0x1637E2C", VA = "0x1637E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E84", Offset = "0x739E84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1637E34", Offset = "0x1637E34", VA = "0x1637E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739E94", Offset = "0x739E94")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1637D5C", Offset = "0x1637D5C", VA = "0x1637D5C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1632E24", Offset = "0x1632E24", VA = "0x1632E24")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1632D44", Offset = "0x1632D44", VA = "0x1632D44")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1637DD4", Offset = "0x1637DD4", VA = "0x1637DD4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1637DE0", Offset = "0x1637DE0", VA = "0x1637DE0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1637DEC", Offset = "0x1637DEC", VA = "0x1637DEC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1637DF4", Offset = "0x1637DF4", VA = "0x1637DF4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1637E24", Offset = "0x1637E24", VA = "0x1637E24")]
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
		[Address(RVA = "0x1637E40", Offset = "0x1637E40", VA = "0x1637E40")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1637E58", Offset = "0x1637E58", VA = "0x1637E58")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1637F90", Offset = "0x1637F90", VA = "0x1637F90")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1638038", Offset = "0x1638038", VA = "0x1638038")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x16382C0", Offset = "0x16382C0", VA = "0x16382C0")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7328B4", Offset = "0x7328B4")]
		public float poleWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7328CC", Offset = "0x7328CC")]
		public float clampWeight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7328E4", Offset = "0x7328E4")]
		public int clampSmoothing;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700003C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1638354", Offset = "0x1638354", VA = "0x1638354")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1638390", Offset = "0x1638390", VA = "0x1638390")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1638E20", Offset = "0x1638E20", VA = "0x1638E20", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1639204", Offset = "0x1639204", VA = "0x1639204", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x16382D8", Offset = "0x16382D8", VA = "0x16382D8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x16383CC", Offset = "0x16383CC", VA = "0x16383CC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x16385EC", Offset = "0x16385EC", VA = "0x16385EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1638D6C", Offset = "0x1638D6C", VA = "0x1638D6C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1638AFC", Offset = "0x1638AFC", VA = "0x1638AFC")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1638E28", Offset = "0x1638E28", VA = "0x1638E28")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1639278", Offset = "0x1639278", VA = "0x1639278")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7328FC", Offset = "0x7328FC")]
		public float IKRotationWeight;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x16392CC", Offset = "0x16392CC", VA = "0x16392CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1639668", Offset = "0x1639668", VA = "0x1639668")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x16396D4", Offset = "0x16396D4", VA = "0x16396D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x163982C", Offset = "0x163982C", VA = "0x163982C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x16399C0", Offset = "0x16399C0", VA = "0x16399C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1639A1C", Offset = "0x1639A1C", VA = "0x1639A1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1639A8C", Offset = "0x1639A8C", VA = "0x1639A8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1639DFC", Offset = "0x1639DFC", VA = "0x1639DFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1639E28", Offset = "0x1639E28", VA = "0x1639E28")]
		private void Solve()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1639AF0", Offset = "0x1639AF0", VA = "0x1639AF0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1639E98", Offset = "0x1639E98", VA = "0x1639E98")]
		private void Write()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x163A024", Offset = "0x163A024", VA = "0x163A024")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x163A188", Offset = "0x163A188", VA = "0x163A188")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x163A238", Offset = "0x163A238", VA = "0x163A238", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x163A2BC", Offset = "0x163A2BC", VA = "0x163A2BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x163A4EC", Offset = "0x163A4EC", VA = "0x163A4EC")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x163AAC8", Offset = "0x163AAC8", VA = "0x163AAC8")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000040")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x163B9D8", Offset = "0x163B9D8", VA = "0x163B9D8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x163AAD0", Offset = "0x163AAD0", VA = "0x163AAD0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x163B094", Offset = "0x163B094", VA = "0x163B094")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x163B1D4", Offset = "0x163B1D4", VA = "0x163B1D4", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x163B268", Offset = "0x163B268", VA = "0x163B268", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x163B744", Offset = "0x163B744", VA = "0x163B744", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x163B9E0", Offset = "0x163B9E0", VA = "0x163B9E0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x163ABAC", Offset = "0x163ABAC", VA = "0x163ABAC")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x163B180", Offset = "0x163B180", VA = "0x163B180")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x163B97C", Offset = "0x163B97C", VA = "0x163B97C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x163AF08", Offset = "0x163AF08", VA = "0x163AF08")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x163C030", Offset = "0x163C030", VA = "0x163C030")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x163C0A4", Offset = "0x163C0A4", VA = "0x163C0A4")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x163C16C", Offset = "0x163C16C", VA = "0x163C16C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x163C21C", Offset = "0x163C21C", VA = "0x163C21C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x163B4F4", Offset = "0x163B4F4", VA = "0x163B4F4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x163B61C", Offset = "0x163B61C", VA = "0x163B61C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x163C320", Offset = "0x163C320", VA = "0x163C320")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x163BC00", Offset = "0x163BC00", VA = "0x163BC00")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x163B170", Offset = "0x163B170", VA = "0x163B170")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x163C8B0", Offset = "0x163C8B0", VA = "0x163C8B0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x163C464", Offset = "0x163C464", VA = "0x163C464")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x163BA5C", Offset = "0x163BA5C", VA = "0x163BA5C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x163BB3C", Offset = "0x163BB3C", VA = "0x163BB3C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x163C97C", Offset = "0x163C97C", VA = "0x163C97C")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732914", Offset = "0x732914")]
		public float rootPin;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x163C9FC", Offset = "0x163C9FC", VA = "0x163C9FC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x163D03C", Offset = "0x163D03C", VA = "0x163D03C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x163D0D4", Offset = "0x163D0D4", VA = "0x163D0D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x163D174", Offset = "0x163D174", VA = "0x163D174", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x163D270", Offset = "0x163D270", VA = "0x163D270")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x163D30C", Offset = "0x163D30C", VA = "0x163D30C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x163D73C", Offset = "0x163D73C", VA = "0x163D73C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x163D934", Offset = "0x163D934", VA = "0x163D934", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x163D7E8", Offset = "0x163D7E8", VA = "0x163D7E8")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x163D4F8", Offset = "0x163D4F8", VA = "0x163D4F8")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x163D9CC", Offset = "0x163D9CC", VA = "0x163D9CC")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73292C", Offset = "0x73292C")]
		public int iterations;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x163DA40", Offset = "0x163DA40", VA = "0x163DA40")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x163DB30", Offset = "0x163DB30", VA = "0x163DB30")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x163DB8C", Offset = "0x163DB8C", VA = "0x163DB8C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1633F80", Offset = "0x1633F80", VA = "0x1633F80")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1633468", Offset = "0x1633468", VA = "0x1633468")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x163DCBC", Offset = "0x163DCBC", VA = "0x163DCBC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x163DE60", Offset = "0x163DE60", VA = "0x163DE60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x163DFD0", Offset = "0x163DFD0", VA = "0x163DFD0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x163E1D8", Offset = "0x163E1D8", VA = "0x163E1D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x163E2B0", Offset = "0x163E2B0", VA = "0x163E2B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x163E390", Offset = "0x163E390", VA = "0x163E390", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x163E500", Offset = "0x163E500", VA = "0x163E500", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x163E660", Offset = "0x163E660", VA = "0x163E660", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x163E8A0", Offset = "0x163E8A0", VA = "0x163E8A0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x163EB6C", Offset = "0x163EB6C", VA = "0x163EB6C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x163EBB0", Offset = "0x163EBB0", VA = "0x163EBB0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x163EC94", Offset = "0x163EC94", VA = "0x163EC94")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002DF")]
		Body,
		[Token(Token = "0x40002E0")]
		LeftShoulder,
		[Token(Token = "0x40002E1")]
		RightShoulder,
		[Token(Token = "0x40002E2")]
		LeftThigh,
		[Token(Token = "0x40002E3")]
		RightThigh,
		[Token(Token = "0x40002E4")]
		LeftHand,
		[Token(Token = "0x40002E5")]
		RightHand,
		[Token(Token = "0x40002E6")]
		LeftFoot,
		[Token(Token = "0x40002E7")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002E9")]
		LeftArm,
		[Token(Token = "0x40002EA")]
		RightArm,
		[Token(Token = "0x40002EB")]
		LeftLeg,
		[Token(Token = "0x40002EC")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732944", Offset = "0x732944")]
		public float spineStiffness;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73295C", Offset = "0x73295C")]
		public float pullBodyVertical;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732974", Offset = "0x732974")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73298C", Offset = "0x73298C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x1602EE4", Offset = "0x1602EE4", VA = "0x1602EE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x160302C", Offset = "0x160302C", VA = "0x160302C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1603034", Offset = "0x1603034", VA = "0x1603034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x160303C", Offset = "0x160303C", VA = "0x160303C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1603044", Offset = "0x1603044", VA = "0x1603044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x160304C", Offset = "0x160304C", VA = "0x160304C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1603054", Offset = "0x1603054", VA = "0x1603054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x160305C", Offset = "0x160305C", VA = "0x160305C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1603064", Offset = "0x1603064", VA = "0x1603064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x160306C", Offset = "0x160306C", VA = "0x160306C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x16030A4", Offset = "0x16030A4", VA = "0x16030A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x16030DC", Offset = "0x16030DC", VA = "0x16030DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x1603114", Offset = "0x1603114", VA = "0x1603114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x160314C", Offset = "0x160314C", VA = "0x160314C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1603180", Offset = "0x1603180", VA = "0x1603180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x16031B8", Offset = "0x16031B8", VA = "0x16031B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x16031F0", Offset = "0x16031F0", VA = "0x16031F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1603228", Offset = "0x1603228", VA = "0x1603228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x16050F4", Offset = "0x16050F4", VA = "0x16050F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739EA4", Offset = "0x739EA4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x1605100", Offset = "0x1605100", VA = "0x1605100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739EB4", Offset = "0x739EB4")]
			private set
			{
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x160325C", Offset = "0x160325C", VA = "0x160325C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1603368", Offset = "0x1603368", VA = "0x1603368")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x16032B0", Offset = "0x16032B0", VA = "0x16032B0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x16033F4", Offset = "0x16033F4", VA = "0x16033F4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1602EEC", Offset = "0x1602EEC", VA = "0x1602EEC")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x16034C4", Offset = "0x16034C4", VA = "0x16034C4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x160357C", Offset = "0x160357C", VA = "0x160357C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1603630", Offset = "0x1603630", VA = "0x1603630")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x16036E4", Offset = "0x16036E4", VA = "0x16036E4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x16036EC", Offset = "0x16036EC", VA = "0x16036EC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1603720", Offset = "0x1603720", VA = "0x1603720")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x16037E8", Offset = "0x16037E8", VA = "0x16037E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1603990", Offset = "0x1603990", VA = "0x1603990")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1604B70", Offset = "0x1604B70", VA = "0x1604B70")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1604F84", Offset = "0x1604F84", VA = "0x1604F84")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1604FE4", Offset = "0x1604FE4", VA = "0x1604FE4")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1604E0C", Offset = "0x1604E0C", VA = "0x1604E0C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1604EC8", Offset = "0x1604EC8", VA = "0x1604EC8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x160510C", Offset = "0x160510C", VA = "0x160510C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x16051E4", Offset = "0x16051E4", VA = "0x16051E4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x16052E4", Offset = "0x16052E4", VA = "0x16052E4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x160540C", Offset = "0x160540C", VA = "0x160540C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1605550", Offset = "0x1605550", VA = "0x1605550")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1605680", Offset = "0x1605680", VA = "0x1605680", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x16058C4", Offset = "0x16058C4", VA = "0x16058C4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x160594C", Offset = "0x160594C", VA = "0x160594C")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000054")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x16061BC", Offset = "0x16061BC", VA = "0x16061BC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x16061C4", Offset = "0x16061C4", VA = "0x16061C4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x16061CC", Offset = "0x16061CC", VA = "0x16061CC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1606654", Offset = "0x1606654", VA = "0x1606654", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x160671C", Offset = "0x160671C", VA = "0x160671C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x160595C", Offset = "0x160595C", VA = "0x160595C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1605AF8", Offset = "0x1605AF8", VA = "0x1605AF8")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1605C30", Offset = "0x1605C30", VA = "0x1605C30", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1605C9C", Offset = "0x1605C9C", VA = "0x1605C9C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1605D1C", Offset = "0x1605D1C", VA = "0x1605D1C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x16060C4", Offset = "0x16060C4", VA = "0x16060C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x16060CC", Offset = "0x16060CC", VA = "0x16060CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x16061D4", Offset = "0x16061D4", VA = "0x16061D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x16061D8", Offset = "0x16061D8", VA = "0x16061D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x16061DC", Offset = "0x16061DC", VA = "0x16061DC")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1606770", Offset = "0x1606770", VA = "0x1606770")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1606A88", Offset = "0x1606A88", VA = "0x1606A88")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1606C7C", Offset = "0x1606C7C", VA = "0x1606C7C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73299C", Offset = "0x73299C")]
		public float IKRotationWeight;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1606CE8", Offset = "0x1606CE8", VA = "0x1606CE8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1607088", Offset = "0x1607088", VA = "0x1607088")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x16070F8", Offset = "0x16070F8", VA = "0x16070F8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1607250", Offset = "0x1607250", VA = "0x1607250", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x16073E4", Offset = "0x16073E4", VA = "0x16073E4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1607440", Offset = "0x1607440", VA = "0x1607440", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x16074B0", Offset = "0x16074B0", VA = "0x16074B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1607820", Offset = "0x1607820", VA = "0x1607820", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x160784C", Offset = "0x160784C", VA = "0x160784C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1607514", Offset = "0x1607514", VA = "0x1607514")]
		private void Read()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x16078E4", Offset = "0x16078E4", VA = "0x16078E4")]
		private void Write()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1607A70", Offset = "0x1607A70", VA = "0x1607A70")]
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
			[Token(Token = "0x4000317")]
			Animation,
			[Token(Token = "0x4000318")]
			Target,
			[Token(Token = "0x4000319")]
			Parent,
			[Token(Token = "0x400031A")]
			Arm,
			[Token(Token = "0x400031B")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000070")]
		public struct AxisDirection
		{
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x169E674", Offset = "0x169E674", VA = "0x169E674")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7329B4", Offset = "0x7329B4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7329CC", Offset = "0x7329CC")]
		public float bendModifierWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000059")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1608CEC", Offset = "0x1608CEC", VA = "0x1608CEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1607BC8", Offset = "0x1607BC8", VA = "0x1607BC8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1607C18", Offset = "0x1607C18", VA = "0x1607C18")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1607C64", Offset = "0x1607C64", VA = "0x1607C64", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1608138", Offset = "0x1608138", VA = "0x1608138", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1608A80", Offset = "0x1608A80", VA = "0x1608A80", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1608B2C", Offset = "0x1608B2C", VA = "0x1608B2C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1608C68", Offset = "0x1608C68", VA = "0x1608C68")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1607F60", Offset = "0x1607F60", VA = "0x1607F60")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x160821C", Offset = "0x160821C", VA = "0x160821C")]
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
			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000060")]
			public Vector3 forward
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0x169E908", Offset = "0x169E908", VA = "0x169E908")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x169E6D4", Offset = "0x169E6D4", VA = "0x169E6D4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x169E6DC", Offset = "0x169E6DC", VA = "0x169E6DC")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x169E708", Offset = "0x169E708", VA = "0x169E708")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x169E800", Offset = "0x169E800", VA = "0x169E800")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7329E4", Offset = "0x7329E4")]
		public float bodyWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7329FC", Offset = "0x7329FC")]
		public float headWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732A14", Offset = "0x732A14")]
		public float eyesWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732A2C", Offset = "0x732A2C")]
		public float clampWeight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732A44", Offset = "0x732A44")]
		public float clampWeightHead;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732A5C", Offset = "0x732A5C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732A74", Offset = "0x732A74")]
		public int clampSmoothing;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x1700005A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x160949C", Offset = "0x160949C", VA = "0x160949C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x160966C", Offset = "0x160966C", VA = "0x160966C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x160957C", Offset = "0x160957C", VA = "0x160957C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1609690", Offset = "0x1609690", VA = "0x1609690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x160958C", Offset = "0x160958C", VA = "0x160958C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1609708", Offset = "0x1609708", VA = "0x1609708")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1608D08", Offset = "0x1608D08", VA = "0x1608D08")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1608D38", Offset = "0x1608D38", VA = "0x1608D38")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1608D90", Offset = "0x1608D90", VA = "0x1608D90")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1608E0C", Offset = "0x1608E0C", VA = "0x1608E0C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1608EA4", Offset = "0x1608EA4", VA = "0x1608EA4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1608F64", Offset = "0x1608F64", VA = "0x1608F64")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1609060", Offset = "0x1609060", VA = "0x1609060", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x160918C", Offset = "0x160918C", VA = "0x160918C")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1609198", Offset = "0x1609198", VA = "0x1609198", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x16092DC", Offset = "0x16092DC", VA = "0x16092DC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x160972C", Offset = "0x160972C", VA = "0x160972C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x160996C", Offset = "0x160996C", VA = "0x160996C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1609B08", Offset = "0x1609B08", VA = "0x1609B08")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1609D38", Offset = "0x1609D38", VA = "0x1609D38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x160A00C", Offset = "0x160A00C", VA = "0x160A00C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x160A0DC", Offset = "0x160A0DC", VA = "0x160A0DC")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x160A27C", Offset = "0x160A27C", VA = "0x160A27C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x160A4A0", Offset = "0x160A4A0", VA = "0x160A4A0")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x160A854", Offset = "0x160A854", VA = "0x160A854")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1609BB4", Offset = "0x1609BB4", VA = "0x1609BB4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x160AAC4", Offset = "0x160AAC4", VA = "0x160AAC4")]
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
			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x169E944", Offset = "0x169E944", VA = "0x169E944")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x169EA40", Offset = "0x169EA40", VA = "0x169EA40")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x169EA70", Offset = "0x169EA70", VA = "0x169EA70")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x169EAAC", Offset = "0x169EAAC", VA = "0x169EAAC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732A8C", Offset = "0x732A8C")]
		public float IKRotationWeight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x160ACD0", Offset = "0x160ACD0", VA = "0x160ACD0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x160AE2C", Offset = "0x160AE2C", VA = "0x160AE2C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x160AF70", Offset = "0x160AF70", VA = "0x160AF70")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x160AF7C", Offset = "0x160AF7C", VA = "0x160AF7C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x160AFAC", Offset = "0x160AFAC", VA = "0x160AFAC")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x160AFB8", Offset = "0x160AFB8", VA = "0x160AFB8")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x160AFC0", Offset = "0x160AFC0", VA = "0x160AFC0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x160B0C0", Offset = "0x160B0C0", VA = "0x160B0C0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x160B1DC", Offset = "0x160B1DC", VA = "0x160B1DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x160B228", Offset = "0x160B228", VA = "0x160B228", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x160B288", Offset = "0x160B288", VA = "0x160B288", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x160B650", Offset = "0x160B650", VA = "0x160B650")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x160B6A8", Offset = "0x160B6A8", VA = "0x160B6A8")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x160BA64", Offset = "0x160BA64", VA = "0x160BA64")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x160BBCC", Offset = "0x160BBCC", VA = "0x160BBCC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x160BD34", Offset = "0x160BD34", VA = "0x160BD34")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x160BCA8", Offset = "0x160BCA8", VA = "0x160BCA8")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x160BE38", Offset = "0x160BE38", VA = "0x160BE38", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x160C60C", Offset = "0x160C60C", VA = "0x160C60C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x160C610", Offset = "0x160C610", VA = "0x160C610", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x160C614", Offset = "0x160C614", VA = "0x160C614", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x160C424", Offset = "0x160C424", VA = "0x160C424")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1608B9C", Offset = "0x1608B9C", VA = "0x1608B9C")]
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
				[Token(Token = "0x400037F")]
				YawPitch,
				[Token(Token = "0x4000380")]
				FromTo
			}

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732CC8", Offset = "0x732CC8")]
			public Transform target;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732D00", Offset = "0x732D00")]
			public Transform bendGoal;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732D38", Offset = "0x732D38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732D38", Offset = "0x732D38")]
			public float positionWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732D8C", Offset = "0x732D8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732D8C", Offset = "0x732D8C")]
			public float rotationWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732DE0", Offset = "0x732DE0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732E18", Offset = "0x732E18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732E18", Offset = "0x732E18")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732E6C", Offset = "0x732E6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732E6C", Offset = "0x732E6C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732EC0", Offset = "0x732EC0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732EC0", Offset = "0x732EC0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732F14", Offset = "0x732F14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732F14", Offset = "0x732F14")]
			public float swivelOffset;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732F70", Offset = "0x732F70")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732FA8", Offset = "0x732FA8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732FE0", Offset = "0x732FE0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732FE0", Offset = "0x732FE0")]
			public float armLengthMlp;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733038", Offset = "0x733038")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7330B0", Offset = "0x7330B0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7330C0", Offset = "0x7330C0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400037C")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400037D")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000062")]
			public Vector3 position
			{
				[Token(Token = "0x600042A")]
				[Address(RVA = "0x169EAB4", Offset = "0x169EAB4", VA = "0x169EAB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739EE4", Offset = "0x739EE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600042B")]
				[Address(RVA = "0x169EAC0", Offset = "0x169EAC0", VA = "0x169EAC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739EF4", Offset = "0x739EF4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x600042C")]
				[Address(RVA = "0x169EACC", Offset = "0x169EACC", VA = "0x169EACC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F04", Offset = "0x739F04")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600042D")]
				[Address(RVA = "0x169EAD8", Offset = "0x169EAD8", VA = "0x169EAD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F14", Offset = "0x739F14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x169EAE4", Offset = "0x169EAE4", VA = "0x169EAE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x169EB18", Offset = "0x169EB18", VA = "0x169EB18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x169EB58", Offset = "0x169EB58", VA = "0x169EB58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x169EBA4", Offset = "0x169EBA4", VA = "0x169EBA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x169EBF0", Offset = "0x169EBF0", VA = "0x169EBF0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x169F534", Offset = "0x169F534", VA = "0x169F534", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x169F6F0", Offset = "0x169F6F0", VA = "0x169F6F0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x169F714", Offset = "0x169F714", VA = "0x169F714")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x169F9B4", Offset = "0x169F9B4", VA = "0x169F9B4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x16A1448", Offset = "0x16A1448", VA = "0x16A1448", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x16A1474", Offset = "0x16A1474", VA = "0x16A1474", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x16A0948", Offset = "0x16A0948", VA = "0x16A0948")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x16A0B00", Offset = "0x16A0B00", VA = "0x16A0B00")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x16A1694", Offset = "0x16A1694", VA = "0x16A1694")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x16A17B8", Offset = "0x16A17B8", VA = "0x16A17B8")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7330D0", Offset = "0x7330D0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7330E0", Offset = "0x7330E0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000068")]
			public float sqrMag
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0x16A1910", Offset = "0x16A1910", VA = "0x16A1910")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F24", Offset = "0x739F24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x16A1918", Offset = "0x16A1918", VA = "0x16A1918")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F34", Offset = "0x739F34")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x16A1920", Offset = "0x16A1920", VA = "0x16A1920")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F44", Offset = "0x739F44")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x16A1928", Offset = "0x16A1928", VA = "0x16A1928")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F54", Offset = "0x739F54")]
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
			[Address(RVA = "0x16A1930", Offset = "0x16A1930", VA = "0x16A1930")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x16A1938", Offset = "0x16A1938", VA = "0x16A1938")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x16A1BF8", Offset = "0x16A1BF8", VA = "0x16A1BF8")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x16A1C8C", Offset = "0x16A1C8C", VA = "0x16A1C8C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x16A1E5C", Offset = "0x16A1E5C", VA = "0x16A1E5C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x16A1EB0", Offset = "0x16A1EB0", VA = "0x16A1EB0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x16A1308", Offset = "0x16A1308", VA = "0x16A1308")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x16A1FE8", Offset = "0x16A1FE8", VA = "0x16A1FE8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x16A2128", Offset = "0x16A2128", VA = "0x16A2128")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x16A189C", Offset = "0x16A189C", VA = "0x16A189C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public class Footstep
		{
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x733100", Offset = "0x733100")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006A")]
			public bool isStepping
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x16A2150", Offset = "0x16A2150", VA = "0x16A2150")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x16A2164", Offset = "0x16A2164", VA = "0x16A2164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F64", Offset = "0x739F64")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x16A216C", Offset = "0x16A216C", VA = "0x16A216C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F74", Offset = "0x739F74")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x16A2174", Offset = "0x16A2174", VA = "0x16A2174")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x16A22AC", Offset = "0x16A22AC", VA = "0x16A22AC")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x16A22F4", Offset = "0x16A22F4", VA = "0x16A22F4")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x16A24C0", Offset = "0x16A24C0", VA = "0x16A24C0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x16A2634", Offset = "0x16A2634", VA = "0x16A2634")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x16A278C", Offset = "0x16A278C", VA = "0x16A278C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733110", Offset = "0x733110")]
			public Transform target;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733148", Offset = "0x733148")]
			public Transform bendGoal;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733180", Offset = "0x733180")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733180", Offset = "0x733180")]
			public float positionWeight;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7331D4", Offset = "0x7331D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7331D4", Offset = "0x7331D4")]
			public float rotationWeight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733228", Offset = "0x733228")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733228", Offset = "0x733228")]
			public float bendGoalWeight;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73327C", Offset = "0x73327C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73327C", Offset = "0x73327C")]
			public float swivelOffset;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7332D8", Offset = "0x7332D8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7332D8", Offset = "0x7332D8")]
			public float bendToTargetWeight;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73332C", Offset = "0x73332C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73332C", Offset = "0x73332C")]
			public float legLengthMlp;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733384", Offset = "0x733384")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73342C", Offset = "0x73342C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73343C", Offset = "0x73343C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73344C", Offset = "0x73344C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73345C", Offset = "0x73345C")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x16A28C8", Offset = "0x16A28C8", VA = "0x16A28C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F84", Offset = "0x739F84")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x16A28D4", Offset = "0x16A28D4", VA = "0x16A28D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739F94", Offset = "0x739F94")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x16A28E0", Offset = "0x16A28E0", VA = "0x16A28E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739FA4", Offset = "0x739FA4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x16A28EC", Offset = "0x16A28EC", VA = "0x16A28EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739FB4", Offset = "0x739FB4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x16A28F8", Offset = "0x16A28F8", VA = "0x16A28F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739FC4", Offset = "0x739FC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x16A2900", Offset = "0x16A2900", VA = "0x16A2900")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739FD4", Offset = "0x739FD4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x16A290C", Offset = "0x16A290C", VA = "0x16A290C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x16A2940", Offset = "0x16A2940", VA = "0x16A2940")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x16A2978", Offset = "0x16A2978", VA = "0x16A2978")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x16A29B0", Offset = "0x16A29B0", VA = "0x16A29B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x16A29E8", Offset = "0x16A29E8", VA = "0x16A29E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x16A2A28", Offset = "0x16A2A28", VA = "0x16A2A28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739FE4", Offset = "0x739FE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x16A2A34", Offset = "0x16A2A34", VA = "0x16A2A34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739FF4", Offset = "0x739FF4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x16A2A40", Offset = "0x16A2A40", VA = "0x16A2A40", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x16A301C", Offset = "0x16A301C", VA = "0x16A301C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x16A35F0", Offset = "0x16A35F0", VA = "0x16A35F0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x16A35A0", Offset = "0x16A35A0", VA = "0x16A35A0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x16A3430", Offset = "0x16A3430", VA = "0x16A3430")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x16A39D8", Offset = "0x16A39D8", VA = "0x16A39D8")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x16A3E94", Offset = "0x16A3E94", VA = "0x16A3E94")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x16A3B74", Offset = "0x16A3B74", VA = "0x16A3B74")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x16A418C", Offset = "0x16A418C", VA = "0x16A418C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x16A43A8", Offset = "0x16A43A8", VA = "0x16A43A8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x16A43F4", Offset = "0x16A43F4", VA = "0x16A43F4")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Locomotion
		{
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73346C", Offset = "0x73346C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73346C", Offset = "0x73346C")]
			public float weight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7334C0", Offset = "0x7334C0")]
			public float footDistance;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7334F8", Offset = "0x7334F8")]
			public float stepThreshold;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733530", Offset = "0x733530")]
			public float angleThreshold;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733568", Offset = "0x733568")]
			public float comAngleMlp;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7335A0", Offset = "0x7335A0")]
			public float maxVelocity;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7335D8", Offset = "0x7335D8")]
			public float velocityFactor;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733610", Offset = "0x733610")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733610", Offset = "0x733610")]
			public float maxLegStretch;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733668", Offset = "0x733668")]
			public float rootSpeed;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7336A0", Offset = "0x7336A0")]
			public float stepSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7336D8", Offset = "0x7336D8")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733710", Offset = "0x733710")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733748", Offset = "0x733748")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733780", Offset = "0x733780")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733780", Offset = "0x733780")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7337D8", Offset = "0x7337D8")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733810", Offset = "0x733810")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733848", Offset = "0x733848")]
			public Vector3 offset;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7338C0", Offset = "0x7338C0")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7338F8", Offset = "0x7338F8")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x733930", Offset = "0x733930")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x17000075")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x16A44C4", Offset = "0x16A44C4", VA = "0x16A44C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A004", Offset = "0x73A004")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x16A44D0", Offset = "0x16A44D0", VA = "0x16A44D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A014", Offset = "0x73A014")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x16A60E0", Offset = "0x16A60E0", VA = "0x16A60E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x16A6120", Offset = "0x16A6120", VA = "0x16A6120")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x16A6164", Offset = "0x16A6164", VA = "0x16A6164")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x16A61A4", Offset = "0x16A61A4", VA = "0x16A61A4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x16A44DC", Offset = "0x16A44DC", VA = "0x16A44DC")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x16A4798", Offset = "0x16A4798", VA = "0x16A4798")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x16A4968", Offset = "0x16A4968", VA = "0x16A4968")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x16A49CC", Offset = "0x16A49CC", VA = "0x16A49CC")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x16A4C14", Offset = "0x16A4C14", VA = "0x16A4C14")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x16A4CD8", Offset = "0x16A4CD8", VA = "0x16A4CD8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x16A5E58", Offset = "0x16A5E58", VA = "0x16A5E58")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x16A5F90", Offset = "0x16A5F90", VA = "0x16A5F90")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x16A6014", Offset = "0x16A6014", VA = "0x16A6014")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x16A61E8", Offset = "0x16A61E8", VA = "0x16A61E8")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733940", Offset = "0x733940")]
			public Transform headTarget;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733978", Offset = "0x733978")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7339B0", Offset = "0x7339B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7339B0", Offset = "0x7339B0")]
			public float positionWeight;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733A04", Offset = "0x733A04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733A04", Offset = "0x733A04")]
			public float rotationWeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733A58", Offset = "0x733A58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733A58", Offset = "0x733A58")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733AAC", Offset = "0x733AAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733AAC", Offset = "0x733AAC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733B00", Offset = "0x733B00")]
			public Transform chestGoal;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733B38", Offset = "0x733B38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733B38", Offset = "0x733B38")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733B8C", Offset = "0x733B8C")]
			public float minHeadHeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733BC4", Offset = "0x733BC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733BC4", Offset = "0x733BC4")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733C18", Offset = "0x733C18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733C18", Offset = "0x733C18")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733C6C", Offset = "0x733C6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733C6C", Offset = "0x733C6C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x733C6C", Offset = "0x733C6C")]
			public float neckStiffness;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733CE4", Offset = "0x733CE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733CE4", Offset = "0x733CE4")]
			public float rotateChestByHands;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733D38", Offset = "0x733D38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733D38", Offset = "0x733D38")]
			public float chestClampWeight;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733D8C", Offset = "0x733D8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733D8C", Offset = "0x733D8C")]
			public float headClampWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733DE0", Offset = "0x733DE0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733E18", Offset = "0x733E18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733E18", Offset = "0x733E18")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733E6C", Offset = "0x733E6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733E6C", Offset = "0x733E6C")]
			public float maxRootAngle;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x733EC4", Offset = "0x733EC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x733EC4", Offset = "0x733EC4")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734000", Offset = "0x734000")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734010", Offset = "0x734010")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007A")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0x16A5DD8", Offset = "0x16A5DD8", VA = "0x16A5DD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x16A62E0", Offset = "0x16A62E0", VA = "0x16A62E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x16A6320", Offset = "0x16A6320", VA = "0x16A6320")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x16A6374", Offset = "0x16A6374", VA = "0x16A6374")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x16A5E18", Offset = "0x16A5E18", VA = "0x16A5E18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x16A63B4", Offset = "0x16A63B4", VA = "0x16A63B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A024", Offset = "0x73A024")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x16A63C8", Offset = "0x16A63C8", VA = "0x16A63C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A034", Offset = "0x73A034")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x16A63DC", Offset = "0x16A63DC", VA = "0x16A63DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A044", Offset = "0x73A044")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x16A63F0", Offset = "0x16A63F0", VA = "0x16A63F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A054", Offset = "0x73A054")]
				private set
				{
				}
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x16A6404", Offset = "0x16A6404", VA = "0x16A6404", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x16A6E10", Offset = "0x16A6E10", VA = "0x16A6E10", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x16A701C", Offset = "0x16A701C", VA = "0x16A701C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x16A7468", Offset = "0x16A7468", VA = "0x16A7468")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x16A78A4", Offset = "0x16A78A4", VA = "0x16A78A4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x16A8014", Offset = "0x16A8014", VA = "0x16A8014")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x16A8694", Offset = "0x16A8694", VA = "0x16A8694")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x16A8C18", Offset = "0x16A8C18", VA = "0x16A8C18", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x16A8DF4", Offset = "0x16A8DF4", VA = "0x16A8DF4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x16A7600", Offset = "0x16A7600", VA = "0x16A7600")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x16A83E4", Offset = "0x16A83E4", VA = "0x16A83E4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x16A7CBC", Offset = "0x16A7CBC", VA = "0x16A7CBC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x16A8E8C", Offset = "0x16A8E8C", VA = "0x16A8E8C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x16A84C0", Offset = "0x16A84C0", VA = "0x16A84C0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x16A8190", Offset = "0x16A8190", VA = "0x16A8190")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x16A9080", Offset = "0x16A9080", VA = "0x16A9080")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000408")]
			Pelvis,
			[Token(Token = "0x4000409")]
			Chest,
			[Token(Token = "0x400040A")]
			Head,
			[Token(Token = "0x400040B")]
			LeftHand,
			[Token(Token = "0x400040C")]
			RightHand,
			[Token(Token = "0x400040D")]
			LeftFoot,
			[Token(Token = "0x400040E")]
			RightFoot,
			[Token(Token = "0x400040F")]
			LeftHeel,
			[Token(Token = "0x4000410")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000412")]
			Pelvis,
			[Token(Token = "0x4000413")]
			Chest,
			[Token(Token = "0x4000414")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public class VirtualBone
		{
			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x169F498", Offset = "0x169F498", VA = "0x169F498")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x169F514", Offset = "0x169F514", VA = "0x169F514")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x16A91F0", Offset = "0x16A91F0", VA = "0x16A91F0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x16A1A08", Offset = "0x16A1A08", VA = "0x16A1A08")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x16A1D34", Offset = "0x16A1D34", VA = "0x16A1D34")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x16A9374", Offset = "0x16A9374", VA = "0x16A9374")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x16A09C4", Offset = "0x16A09C4", VA = "0x16A09C4")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x16A94D4", Offset = "0x16A94D4", VA = "0x16A94D4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x16A0F04", Offset = "0x16A0F04", VA = "0x16A0F04")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x16A958C", Offset = "0x16A958C", VA = "0x16A958C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x16A8888", Offset = "0x16A8888", VA = "0x16A8888")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x16A96F4", Offset = "0x16A96F4", VA = "0x16A96F4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x16A9764", Offset = "0x16A9764", VA = "0x16A9764")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732AA4", Offset = "0x732AA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x732AA4", Offset = "0x732AA4")]
		public int LOD;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732AF8", Offset = "0x732AF8")]
		public float scale;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732B30", Offset = "0x732B30")]
		public bool plantFeet;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x732B68", Offset = "0x732B68")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732B78", Offset = "0x732B78")]
		public Spine spine;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732BB0", Offset = "0x732BB0")]
		public Arm leftArm;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732BE8", Offset = "0x732BE8")]
		public Arm rightArm;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732C20", Offset = "0x732C20")]
		public Leg leftLeg;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732C58", Offset = "0x732C58")]
		public Leg rightLeg;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x732C90", Offset = "0x732C90")]
		public Locomotion locomotion;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000061")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x160FE14", Offset = "0x160FE14", VA = "0x160FE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739EC4", Offset = "0x739EC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x160FE1C", Offset = "0x160FE1C", VA = "0x160FE1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739ED4", Offset = "0x739ED4")]
			private set
			{
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x160C618", Offset = "0x160C618", VA = "0x160C618")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x160CA7C", Offset = "0x160CA7C", VA = "0x160CA7C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x160C928", Offset = "0x160C928", VA = "0x160C928")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x160CDE0", Offset = "0x160CDE0", VA = "0x160CDE0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x160CF24", Offset = "0x160CF24", VA = "0x160CF24")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x160CF54", Offset = "0x160CF54", VA = "0x160CF54")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x160D004", Offset = "0x160D004", VA = "0x160D004")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x160D0EC", Offset = "0x160D0EC", VA = "0x160D0EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x160D854", Offset = "0x160D854", VA = "0x160D854", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x160D9C4", Offset = "0x160D9C4", VA = "0x160D9C4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x160DBC8", Offset = "0x160DBC8", VA = "0x160DBC8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x160DC44", Offset = "0x160DC44", VA = "0x160DC44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x160DCC0", Offset = "0x160DCC0", VA = "0x160DCC0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x160DE98", Offset = "0x160DE98", VA = "0x160DE98")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x160CCC0", Offset = "0x160CCC0", VA = "0x160CCC0")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x160D1E0", Offset = "0x160D1E0", VA = "0x160D1E0")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x160E058", Offset = "0x160E058", VA = "0x160E058", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x160E0A0", Offset = "0x160E0A0", VA = "0x160E0A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x160F544", Offset = "0x160F544", VA = "0x160F544")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x160D344", Offset = "0x160D344", VA = "0x160D344")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x160E414", Offset = "0x160E414", VA = "0x160E414")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x160F8F4", Offset = "0x160F8F4", VA = "0x160F8F4")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x160F93C", Offset = "0x160F93C", VA = "0x160F93C")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x160F3F4", Offset = "0x160F3F4", VA = "0x160F3F4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x160F980", Offset = "0x160F980", VA = "0x160F980")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x160FE24", Offset = "0x160FE24", VA = "0x160FE24")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool alreadyRelaxed;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734020", Offset = "0x734020")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1473764", Offset = "0x1473764", VA = "0x1473764")]
		public void Awake()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1473D24", Offset = "0x1473D24", VA = "0x1473D24")]
		public void Start()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1473E3C", Offset = "0x1473E3C", VA = "0x1473E3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1473F44", Offset = "0x1473F44", VA = "0x1473F44")]
		public void TwistRelaxerUpdate()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x14743EC", Offset = "0x14743EC", VA = "0x14743EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1474504", Offset = "0x1474504", VA = "0x1474504")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class TwistSolver
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734058", Offset = "0x734058")]
		public Transform transform;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734090", Offset = "0x734090")]
		public Transform parent;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7340C8", Offset = "0x7340C8")]
		public Transform[] children;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734100", Offset = "0x734100")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x734100", Offset = "0x734100")]
		public float weight;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734154", Offset = "0x734154")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x734154", Offset = "0x734154")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7341A8", Offset = "0x7341A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7341A8", Offset = "0x7341A8")]
		public float twistAngleOffset;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1474560", Offset = "0x1474560", VA = "0x1474560")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1473860", Offset = "0x1473860", VA = "0x1473860")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1473F1C", Offset = "0x1473F1C", VA = "0x1473F1C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1474020", Offset = "0x1474020", VA = "0x1474020")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionEffector
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734204", Offset = "0x734204")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734214", Offset = "0x734214")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734224", Offset = "0x734224")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1610BE8", Offset = "0x1610BE8", VA = "0x1610BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A064", Offset = "0x73A064")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1610BF0", Offset = "0x1610BF0", VA = "0x1610BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A074", Offset = "0x73A074")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1610BF8", Offset = "0x1610BF8", VA = "0x1610BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A084", Offset = "0x73A084")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1610C00", Offset = "0x1610C00", VA = "0x1610C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A094", Offset = "0x73A094")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1610C0C", Offset = "0x1610C0C", VA = "0x1610C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A0A4", Offset = "0x73A0A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1610C14", Offset = "0x1610C14", VA = "0x1610C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A0B4", Offset = "0x73A0B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1610C1C", Offset = "0x1610C1C", VA = "0x1610C1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x16123F0", Offset = "0x16123F0", VA = "0x16123F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1610C88", Offset = "0x1610C88", VA = "0x1610C88")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1610D14", Offset = "0x1610D14", VA = "0x1610D14")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1610DA8", Offset = "0x1610DA8", VA = "0x1610DA8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1610F04", Offset = "0x1610F04", VA = "0x1610F04")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1611240", Offset = "0x1611240", VA = "0x1611240")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x16112FC", Offset = "0x16112FC", VA = "0x16112FC")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1611354", Offset = "0x1611354", VA = "0x1611354")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1611784", Offset = "0x1611784", VA = "0x1611784")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1611DCC", Offset = "0x1611DCC", VA = "0x1611DCC")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1612010", Offset = "0x1612010", VA = "0x1612010")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1612298", Offset = "0x1612298", VA = "0x1612298")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x161242C", Offset = "0x161242C", VA = "0x161242C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734234", Offset = "0x734234")]
		public LookAtIK ik;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73426C", Offset = "0x73426C")]
		public float lerpSpeed;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7342A4", Offset = "0x7342A4")]
		public float weightSpeed;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1612658", Offset = "0x1612658", VA = "0x1612658")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1612774", Offset = "0x1612774", VA = "0x1612774")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1612818", Offset = "0x1612818", VA = "0x1612818")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1612A10", Offset = "0x1612A10", VA = "0x1612A10")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1612B04", Offset = "0x1612B04", VA = "0x1612B04")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1612BCC", Offset = "0x1612BCC", VA = "0x1612BCC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730228", Offset = "0x730228")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730228", Offset = "0x730228")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7343B4", Offset = "0x7343B4")]
			public float time;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7343EC", Offset = "0x7343EC")]
			public bool pause;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734424", Offset = "0x734424")]
			public bool pickUp;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73445C", Offset = "0x73445C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734494", Offset = "0x734494")]
			public Message[] messages;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7344CC", Offset = "0x7344CC")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x16A9F10", Offset = "0x16A9F10", VA = "0x16A9F10")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x16AA0E4", Offset = "0x16AA0E4", VA = "0x16AA0E4")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Message
		{
			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734504", Offset = "0x734504")]
			public string function;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73453C", Offset = "0x73453C")]
			public GameObject recipient;

			[Token(Token = "0x4000469")]
			private const string empty = "";

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x16A9FE0", Offset = "0x16A9FE0", VA = "0x16A9FE0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x16AA0EC", Offset = "0x16AA0EC", VA = "0x16AA0EC")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734574", Offset = "0x734574")]
			public Animator animator;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7345AC", Offset = "0x7345AC")]
			public Animation animation;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7345E4", Offset = "0x7345E4")]
			public string animationState;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73461C", Offset = "0x73461C")]
			public float crossfadeTime;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734654", Offset = "0x734654")]
			public int layer;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73468C", Offset = "0x73468C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000470")]
			private const string empty = "";

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x16A9C7C", Offset = "0x16A9C7C", VA = "0x16A9C7C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x16A9D6C", Offset = "0x16A9D6C", VA = "0x16A9D6C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x16A9E20", Offset = "0x16A9E20", VA = "0x16A9E20")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x16A9EFC", Offset = "0x16A9EFC", VA = "0x16A9EFC")]
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
				[Token(Token = "0x4000474")]
				PositionWeight,
				[Token(Token = "0x4000475")]
				RotationWeight,
				[Token(Token = "0x4000476")]
				PositionOffsetX,
				[Token(Token = "0x4000477")]
				PositionOffsetY,
				[Token(Token = "0x4000478")]
				PositionOffsetZ,
				[Token(Token = "0x4000479")]
				Pull,
				[Token(Token = "0x400047A")]
				Reach,
				[Token(Token = "0x400047B")]
				RotateBoneWeight,
				[Token(Token = "0x400047C")]
				Push,
				[Token(Token = "0x400047D")]
				PushParent,
				[Token(Token = "0x400047E")]
				PoserWeight,
				[Token(Token = "0x400047F")]
				BendGoalWeight
			}

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7346C4", Offset = "0x7346C4")]
			public Type type;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7346FC", Offset = "0x7346FC")]
			public AnimationCurve curve;

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x16AA130", Offset = "0x16AA130", VA = "0x16AA130")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x16AA15C", Offset = "0x16AA15C", VA = "0x16AA15C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class Multiplier
		{
			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734734", Offset = "0x734734")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73476C", Offset = "0x73476C")]
			public float multiplier;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7347A4", Offset = "0x7347A4")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x16AA0F4", Offset = "0x16AA0F4", VA = "0x16AA0F4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x16AA14C", Offset = "0x16AA14C", VA = "0x16AA14C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7342EC", Offset = "0x7342EC")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734324", Offset = "0x734324")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73435C", Offset = "0x73435C")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734394", Offset = "0x734394")]
		private float <length>k__BackingField;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7343A4", Offset = "0x7343A4")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x14D785C", Offset = "0x14D785C", VA = "0x14D785C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A284", Offset = "0x73A284")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x14D7864", Offset = "0x14D7864", VA = "0x14D7864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A294", Offset = "0x73A294")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x14D786C", Offset = "0x14D786C", VA = "0x14D786C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A2A4", Offset = "0x73A2A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x14D7874", Offset = "0x14D7874", VA = "0x14D7874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A2B4", Offset = "0x73A2B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x14D7AC8", Offset = "0x14D7AC8", VA = "0x14D7AC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x14D7A3C", Offset = "0x14D7A3C", VA = "0x14D7A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x14D761C", Offset = "0x14D761C", VA = "0x14D761C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A0C4", Offset = "0x73A0C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x14D7664", Offset = "0x14D7664", VA = "0x14D7664")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A0FC", Offset = "0x73A0FC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x14D76AC", Offset = "0x14D76AC", VA = "0x14D76AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A134", Offset = "0x73A134")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x14D76F4", Offset = "0x14D76F4", VA = "0x14D76F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A16C", Offset = "0x73A16C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x14D773C", Offset = "0x14D773C", VA = "0x14D773C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A1A4", Offset = "0x73A1A4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x14D7784", Offset = "0x14D7784", VA = "0x14D7784")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A1DC", Offset = "0x73A1DC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x14D77CC", Offset = "0x14D77CC", VA = "0x14D77CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A214", Offset = "0x73A214")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x14D7814", Offset = "0x14D7814", VA = "0x14D7814")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A24C", Offset = "0x73A24C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x14D787C", Offset = "0x14D787C", VA = "0x14D787C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x14D7B54", Offset = "0x14D7B54", VA = "0x14D7B54")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x14D7CC0", Offset = "0x14D7CC0", VA = "0x14D7CC0")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x14D7D74", Offset = "0x14D7D74", VA = "0x14D7D74")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x14D7D7C", Offset = "0x14D7D7C", VA = "0x14D7D7C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x14D7F30", Offset = "0x14D7F30", VA = "0x14D7F30")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x14D7F38", Offset = "0x14D7F38", VA = "0x14D7F38")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x14D8900", Offset = "0x14D8900", VA = "0x14D8900")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x14D8B20", Offset = "0x14D8B20", VA = "0x14D8B20")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x14D8404", Offset = "0x14D8404", VA = "0x14D8404")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x14D7EC0", Offset = "0x14D7EC0", VA = "0x14D7EC0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x14D8898", Offset = "0x14D8898", VA = "0x14D8898")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x14D8B24", Offset = "0x14D8B24", VA = "0x14D8B24")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x14D8B8C", Offset = "0x14D8B8C", VA = "0x14D8B8C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730288", Offset = "0x730288")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730288", Offset = "0x730288")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7347DC", Offset = "0x7347DC")]
		public string targetTag;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734814", Offset = "0x734814")]
		public float fadeInTime;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73484C", Offset = "0x73484C")]
		public float speed;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734884", Offset = "0x734884")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7348BC", Offset = "0x7348BC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7348BC", Offset = "0x7348BC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7348BC", Offset = "0x7348BC")]
		public Collider characterCollider;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734940", Offset = "0x734940")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x734940", Offset = "0x734940")]
		public Transform FPSCamera;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7349A0", Offset = "0x7349A0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7349D8", Offset = "0x7349D8")]
		public float camRaycastDistance;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734A10", Offset = "0x734A10")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734A20", Offset = "0x734A20")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x734A20", Offset = "0x734A20")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734A80", Offset = "0x734A80")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x734AB8", Offset = "0x734AB8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x14D8E28", Offset = "0x14D8E28", VA = "0x14D8E28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x14DAACC", Offset = "0x14DAACC", VA = "0x14DAACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x14DAAD4", Offset = "0x14DAAD4", VA = "0x14DAAD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x14DAADC", Offset = "0x14DAADC", VA = "0x14DAADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A484", Offset = "0x73A484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x14DAAE4", Offset = "0x14DAAE4", VA = "0x14DAAE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A494", Offset = "0x73A494")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x14DAAEC", Offset = "0x14DAAEC", VA = "0x14DAAEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A4A4", Offset = "0x73A4A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x14DAAF4", Offset = "0x14DAAF4", VA = "0x14DAAF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A4B4", Offset = "0x73A4B4")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x14D8BE8", Offset = "0x14D8BE8", VA = "0x14D8BE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A2C4", Offset = "0x73A2C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x14D8C30", Offset = "0x14D8C30", VA = "0x14D8C30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A2FC", Offset = "0x73A2FC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x14D8C78", Offset = "0x14D8C78", VA = "0x14D8C78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A334", Offset = "0x73A334")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x14D8CC0", Offset = "0x14D8CC0", VA = "0x14D8CC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A36C", Offset = "0x73A36C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x14D8D08", Offset = "0x14D8D08", VA = "0x14D8D08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A3A4", Offset = "0x73A3A4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x14D8D50", Offset = "0x14D8D50", VA = "0x14D8D50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A3DC", Offset = "0x73A3DC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x14D8D98", Offset = "0x14D8D98", VA = "0x14D8D98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A414", Offset = "0x73A414")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x14D8DE0", Offset = "0x14D8DE0", VA = "0x14D8DE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A44C", Offset = "0x73A44C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x14D8FD0", Offset = "0x14D8FD0", VA = "0x14D8FD0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x14D90A0", Offset = "0x14D90A0", VA = "0x14D90A0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x14D9170", Offset = "0x14D9170", VA = "0x14D9170")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x14D9220", Offset = "0x14D9220", VA = "0x14D9220")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x14D931C", Offset = "0x14D931C", VA = "0x14D931C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x14D9438", Offset = "0x14D9438", VA = "0x14D9438")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x14D94CC", Offset = "0x14D94CC", VA = "0x14D94CC")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x14D9560", Offset = "0x14D9560", VA = "0x14D9560")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x14D95F4", Offset = "0x14D95F4", VA = "0x14D95F4")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x14D966C", Offset = "0x14D966C", VA = "0x14D966C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x14D96E4", Offset = "0x14D96E4", VA = "0x14D96E4")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x14D9750", Offset = "0x14D9750", VA = "0x14D9750")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x14D97DC", Offset = "0x14D97DC", VA = "0x14D97DC")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x14D9870", Offset = "0x14D9870", VA = "0x14D9870")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x14D993C", Offset = "0x14D993C", VA = "0x14D993C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x14D9C14", Offset = "0x14D9C14", VA = "0x14D9C14")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x14D9DF4", Offset = "0x14D9DF4", VA = "0x14D9DF4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x14DA088", Offset = "0x14DA088", VA = "0x14DA088")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x14DA360", Offset = "0x14DA360", VA = "0x14DA360")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x14DA3A4", Offset = "0x14DA3A4", VA = "0x14DA3A4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x14DA41C", Offset = "0x14DA41C", VA = "0x14DA41C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x14DA538", Offset = "0x14DA538", VA = "0x14DA538")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x14DA6DC", Offset = "0x14DA6DC", VA = "0x14DA6DC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x14DA980", Offset = "0x14DA980", VA = "0x14DA980")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x14DA19C", Offset = "0x14DA19C", VA = "0x14DA19C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x14DAB00", Offset = "0x14DAB00", VA = "0x14DAB00")]
		public void Start()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x14DB270", Offset = "0x14DB270", VA = "0x14DB270")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x14DB290", Offset = "0x14DB290", VA = "0x14DB290")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x14DB2AC", Offset = "0x14DB2AC", VA = "0x14DB2AC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x14DB2C8", Offset = "0x14DB2C8", VA = "0x14DB2C8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x14DB32C", Offset = "0x14DB32C", VA = "0x14DB32C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x14DB468", Offset = "0x14DB468", VA = "0x14DB468")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x14DB578", Offset = "0x14DB578", VA = "0x14DB578")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x14DB91C", Offset = "0x14DB91C", VA = "0x14DB91C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x14DBA1C", Offset = "0x14DBA1C", VA = "0x14DBA1C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x14DBC7C", Offset = "0x14DBC7C", VA = "0x14DBC7C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x14DAFD4", Offset = "0x14DAFD4", VA = "0x14DAFD4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x14DBDB8", Offset = "0x14DBDB8", VA = "0x14DBDB8")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x14DBEE8", Offset = "0x14DBEE8", VA = "0x14DBEE8")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x14DBF80", Offset = "0x14DBF80", VA = "0x14DBF80")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x14DC05C", Offset = "0x14DC05C", VA = "0x14DC05C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x14DC078", Offset = "0x14DC078", VA = "0x14DC078")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x14D8ED8", Offset = "0x14D8ED8", VA = "0x14D8ED8")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x14D9AE4", Offset = "0x14D9AE4", VA = "0x14D9AE4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x14DC3E0", Offset = "0x14DC3E0", VA = "0x14DC3E0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7302E8", Offset = "0x7302E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7302E8", Offset = "0x7302E8")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public enum RotationMode
		{
			[Token(Token = "0x40004A8")]
			TwoDOF,
			[Token(Token = "0x40004A9")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class Multiplier
		{
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734D14", Offset = "0x734D14")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734D4C", Offset = "0x734D4C")]
			public float multiplier;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x16AA7C8", Offset = "0x16AA7C8", VA = "0x16AA7C8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734AC8", Offset = "0x734AC8")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734B00", Offset = "0x734B00")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734B38", Offset = "0x734B38")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734B70", Offset = "0x734B70")]
		public Transform pivot;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734BA8", Offset = "0x734BA8")]
		public RotationMode rotationMode;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734BE0", Offset = "0x734BE0")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734C18", Offset = "0x734C18")]
		public float twistWeight;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734C50", Offset = "0x734C50")]
		public float swingWeight;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734C88", Offset = "0x734C88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x734C88", Offset = "0x734C88")]
		public float threeDOFWeight;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734CDC", Offset = "0x734CDC")]
		public bool rotateOnce;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x14DCB30", Offset = "0x14DCB30", VA = "0x14DCB30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A4C4", Offset = "0x73A4C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x14DCB78", Offset = "0x14DCB78", VA = "0x14DCB78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A4FC", Offset = "0x73A4FC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x14DCBC0", Offset = "0x14DCBC0", VA = "0x14DCBC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A534", Offset = "0x73A534")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x14DCC08", Offset = "0x14DCC08", VA = "0x14DCC08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A56C", Offset = "0x73A56C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x14DCC50", Offset = "0x14DCC50", VA = "0x14DCC50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A5A4", Offset = "0x73A5A4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x14DCC98", Offset = "0x14DCC98", VA = "0x14DCC98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A5DC", Offset = "0x73A5DC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x14DCCE0", Offset = "0x14DCCE0", VA = "0x14DCCE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A614", Offset = "0x73A614")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x14DCD28", Offset = "0x14DCD28", VA = "0x14DCD28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A64C", Offset = "0x73A64C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x14D8394", Offset = "0x14D8394", VA = "0x14D8394")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x14DCD70", Offset = "0x14DCD70", VA = "0x14DCD70")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x14DCE08", Offset = "0x14DCE08", VA = "0x14DCE08")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x14DD4D0", Offset = "0x14DD4D0", VA = "0x14DD4D0")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730348", Offset = "0x730348")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730348", Offset = "0x730348")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734DBC", Offset = "0x734DBC")]
			public bool use;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734DF4", Offset = "0x734DF4")]
			public Vector2 offset;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734E2C", Offset = "0x734E2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x734E2C", Offset = "0x734E2C")]
			public float angleOffset;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x734E88", Offset = "0x734E88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734E88", Offset = "0x734E88")]
			public float maxAngle;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734EE0", Offset = "0x734EE0")]
			public float radius;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734F18", Offset = "0x734F18")]
			public bool orbit;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734F50", Offset = "0x734F50")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600054B")]
				[Address(RVA = "0x16AAB38", Offset = "0x16AAB38", VA = "0x16AAB38")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600054C")]
				[Address(RVA = "0x16AAB44", Offset = "0x16AAB44", VA = "0x16AAB44")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x16AABCC", Offset = "0x16AABCC", VA = "0x16AABCC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x16AB010", Offset = "0x16AB010", VA = "0x16AB010")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class CameraPosition
		{
			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734F88", Offset = "0x734F88")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734FC0", Offset = "0x734FC0")]
			public Vector3 direction;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734FF8", Offset = "0x734FF8")]
			public float maxDistance;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735030", Offset = "0x735030")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735030", Offset = "0x735030")]
			public float maxAngle;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735088", Offset = "0x735088")]
			public bool fixYAxis;

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x16AA7D0", Offset = "0x16AA7D0", VA = "0x16AA7D0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x16AA8C4", Offset = "0x16AA8C4", VA = "0x16AA8C4")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x16AAAEC", Offset = "0x16AAAEC", VA = "0x16AAAEC")]
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
				[Token(Token = "0x40004BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735188", Offset = "0x735188")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7351C0", Offset = "0x7351C0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000554")]
				[Address(RVA = "0x17EECBC", Offset = "0x17EECBC", VA = "0x17EECBC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7350E0", Offset = "0x7350E0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735118", Offset = "0x735118")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735150", Offset = "0x735150")]
			public Interaction[] interactions;

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x16AB024", Offset = "0x16AB024", VA = "0x16AB024")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x16AB0D8", Offset = "0x16AB0D8", VA = "0x16AB0D8")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x734D84", Offset = "0x734D84")]
		public Range[] ranges;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x14DD51C", Offset = "0x14DD51C", VA = "0x14DD51C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A684", Offset = "0x73A684")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x14DD564", Offset = "0x14DD564", VA = "0x14DD564")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A6BC", Offset = "0x73A6BC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x14DD5AC", Offset = "0x14DD5AC", VA = "0x14DD5AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A6F4", Offset = "0x73A6F4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x14DD5F4", Offset = "0x14DD5F4", VA = "0x14DD5F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A72C", Offset = "0x73A72C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x14DD63C", Offset = "0x14DD63C", VA = "0x14DD63C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A764", Offset = "0x73A764")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x14DB748", Offset = "0x14DB748", VA = "0x14DB748")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x14DD684", Offset = "0x14DD684", VA = "0x14DD684")]
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
			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x147C6EC", Offset = "0x147C6EC", VA = "0x147C6EC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x147C728", Offset = "0x147C728", VA = "0x147C728")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0x147C778", Offset = "0x147C778", VA = "0x147C778")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0x147C7C4", Offset = "0x147C7C4", VA = "0x147C7C4")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x158AC48", Offset = "0x158AC48", VA = "0x158AC48", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A79C", Offset = "0x73A79C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x158AFC4", Offset = "0x158AFC4", VA = "0x158AFC4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x158AFC8", Offset = "0x158AFC8", VA = "0x158AFC8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x158B0D0", Offset = "0x158B0D0", VA = "0x158B0D0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x158AF58", Offset = "0x158AF58", VA = "0x158AF58")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x158AEB8", Offset = "0x158AEB8", VA = "0x158AEB8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x158B13C", Offset = "0x158B13C", VA = "0x158B13C")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x162F7A0", Offset = "0x162F7A0", VA = "0x162F7A0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x162F868", Offset = "0x162F868", VA = "0x162F868", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x162FA24", Offset = "0x162FA24", VA = "0x162FA24", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x162FB20", Offset = "0x162FB20", VA = "0x162FB20", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x162F8C0", Offset = "0x162F8C0", VA = "0x162F8C0")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x162FE80", Offset = "0x162FE80", VA = "0x162FE80")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7351F8", Offset = "0x7351F8")]
		public float weight;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735210", Offset = "0x735210")]
		public float localRotationWeight;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735228", Offset = "0x735228")]
		public float localPositionWeight;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000566")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x14E4EB8", Offset = "0x14E4EB8", VA = "0x14E4EB8")]
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
		[Address(RVA = "0x14E4EC4", Offset = "0x14E4EC4", VA = "0x14E4EC4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x14E4F18", Offset = "0x14E4F18", VA = "0x14E4F18", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x14E4F54", Offset = "0x14E4F54", VA = "0x14E4F54", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x14E4F6C", Offset = "0x14E4F6C", VA = "0x14E4F6C")]
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
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x16AD030", Offset = "0x16AD030", VA = "0x16AD030")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x16AD1A0", Offset = "0x16AD1A0", VA = "0x16AD1A0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x16AD280", Offset = "0x16AD280", VA = "0x16AD280")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009C")]
		public class Child
		{
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x16ACE40", Offset = "0x16ACE40", VA = "0x16ACE40")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x16ACEA0", Offset = "0x16ACEA0", VA = "0x16ACEA0")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x16ACFE0", Offset = "0x16ACFE0", VA = "0x16ACFE0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7303A8", Offset = "0x7303A8")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600058A")]
				[Address(RVA = "0x16ACDF0", Offset = "0x16ACDF0", VA = "0x16ACDF0", Slot = "4")]
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
				[Address(RVA = "0x16ACE38", Offset = "0x16ACE38", VA = "0x16ACE38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x16ACBD4", Offset = "0x16ACBD4", VA = "0x16ACBD4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x16ACC00", Offset = "0x16ACC00", VA = "0x16ACC00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x16ACC04", Offset = "0x16ACC04", VA = "0x16ACC04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x16ACDF8", Offset = "0x16ACDF8", VA = "0x16ACDF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735240", Offset = "0x735240")]
		public IK ik;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735278", Offset = "0x735278")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7352B0", Offset = "0x7352B0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7352E8", Offset = "0x7352E8")]
		public float applyVelocity;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735320", Offset = "0x735320")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000090")]
		private bool isRagdoll
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x14E5C40", Offset = "0x14E5C40", VA = "0x14E5C40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x14E65C8", Offset = "0x14E65C8", VA = "0x14E65C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x14E5C08", Offset = "0x14E5C08", VA = "0x14E5C08")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x14E5CB8", Offset = "0x14E5CB8", VA = "0x14E5CB8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x14E5DE8", Offset = "0x14E5DE8", VA = "0x14E5DE8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x14E5D7C", Offset = "0x14E5D7C", VA = "0x14E5D7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73A7D4", Offset = "0x73A7D4")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x14E6204", Offset = "0x14E6204", VA = "0x14E6204")]
		private void Update()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x14E6450", Offset = "0x14E6450", VA = "0x14E6450")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x14E650C", Offset = "0x14E650C", VA = "0x14E650C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x14E6748", Offset = "0x14E6748", VA = "0x14E6748")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x14E658C", Offset = "0x14E658C", VA = "0x14E658C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x14E6704", Offset = "0x14E6704", VA = "0x14E6704")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x14E67E8", Offset = "0x14E67E8", VA = "0x14E67E8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x14E677C", Offset = "0x14E677C", VA = "0x14E677C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x14E5D10", Offset = "0x14E5D10", VA = "0x14E5D10")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x14E6490", Offset = "0x14E6490", VA = "0x14E6490")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x14E6A14", Offset = "0x14E6A14", VA = "0x14E6A14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x14E6B2C", Offset = "0x14E6B2C", VA = "0x14E6B2C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735368", Offset = "0x735368")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000094")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x14E8248", Offset = "0x14E8248", VA = "0x14E8248")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x14E8254", Offset = "0x14E8254", VA = "0x14E8254")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x14E8270", Offset = "0x14E8270", VA = "0x14E8270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A884", Offset = "0x73A884")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x14E8278", Offset = "0x14E8278", VA = "0x14E8278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73A894", Offset = "0x73A894")]
			private set
			{
			}
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x14E7F48", Offset = "0x14E7F48", VA = "0x14E7F48")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x14E7F90", Offset = "0x14E7F90", VA = "0x14E7F90")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x14E7FA8", Offset = "0x14E7FA8", VA = "0x14E7FA8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x14E81A0", Offset = "0x14E81A0", VA = "0x14E81A0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x14E8210", Offset = "0x14E8210", VA = "0x14E8210")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000596")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x14E80C8", Offset = "0x14E80C8", VA = "0x14E80C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x14E8284", Offset = "0x14E8284", VA = "0x14E8284")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x14E8288", Offset = "0x14E8288", VA = "0x14E8288")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x14E82BC", Offset = "0x14E82BC", VA = "0x14E82BC")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x14E8338", Offset = "0x14E8338", VA = "0x14E8338")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x14E84CC", Offset = "0x14E84CC", VA = "0x14E84CC")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x14E853C", Offset = "0x14E853C", VA = "0x14E853C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7303B8", Offset = "0x7303B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7303B8", Offset = "0x7303B8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735378", Offset = "0x735378")]
		public float limit;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735394", Offset = "0x735394")]
		public float twistLimit;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x14E8570", Offset = "0x14E8570", VA = "0x14E8570")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A8A4", Offset = "0x73A8A4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x14E85B8", Offset = "0x14E85B8", VA = "0x14E85B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A8DC", Offset = "0x73A8DC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x14E8600", Offset = "0x14E8600", VA = "0x14E8600")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A914", Offset = "0x73A914")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x14E8648", Offset = "0x14E8648", VA = "0x14E8648")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A94C", Offset = "0x73A94C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x14E8690", Offset = "0x14E8690", VA = "0x14E8690", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x14E86D4", Offset = "0x14E86D4", VA = "0x14E86D4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x14E8894", Offset = "0x14E8894", VA = "0x14E8894")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730418", Offset = "0x730418")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730418", Offset = "0x730418")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x14E88D4", Offset = "0x14E88D4", VA = "0x14E88D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A984", Offset = "0x73A984")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x14E891C", Offset = "0x14E891C", VA = "0x14E891C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A9BC", Offset = "0x73A9BC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x14E8964", Offset = "0x14E8964", VA = "0x14E8964")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73A9F4", Offset = "0x73A9F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x14E89AC", Offset = "0x14E89AC", VA = "0x14E89AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73AA2C", Offset = "0x73AA2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x14E89F4", Offset = "0x14E89F4", VA = "0x14E89F4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x14E89F8", Offset = "0x14E89F8", VA = "0x14E89F8")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x14E8B7C", Offset = "0x14E8B7C", VA = "0x14E8B7C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x730478", Offset = "0x730478")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x730478", Offset = "0x730478")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class ReachCone
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000097")]
			public Vector3 o
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x16AD8B4", Offset = "0x16AD8B4", VA = "0x16AD8B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x16AD8EC", Offset = "0x16AD8EC", VA = "0x16AD8EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x16AD928", Offset = "0x16AD928", VA = "0x16AD928")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x16AD964", Offset = "0x16AD964", VA = "0x16AD964")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x16ADADC", Offset = "0x16ADADC", VA = "0x16ADADC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x16AD9A0", Offset = "0x16AD9A0", VA = "0x16AD9A0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x16ADAEC", Offset = "0x16ADAEC", VA = "0x16ADAEC")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class LimitPoint
		{
			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x16AD878", Offset = "0x16AD878", VA = "0x16AD878")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7353C0", Offset = "0x7353C0")]
		public float twistLimit;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7353DC", Offset = "0x7353DC")]
		public int smoothIterations;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x14E8BC4", Offset = "0x14E8BC4", VA = "0x14E8BC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73AA64", Offset = "0x73AA64")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x14E8C0C", Offset = "0x14E8C0C", VA = "0x14E8C0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73AA9C", Offset = "0x73AA9C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x14E8C54", Offset = "0x14E8C54", VA = "0x14E8C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73AAD4", Offset = "0x73AAD4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x14E8C9C", Offset = "0x14E8C9C", VA = "0x14E8C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73AB0C", Offset = "0x73AB0C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x14E8CE4", Offset = "0x14E8CE4", VA = "0x14E8CE4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x14E9184", Offset = "0x14E9184", VA = "0x14E9184", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x14E9218", Offset = "0x14E9218", VA = "0x14E9218")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x14E9744", Offset = "0x14E9744", VA = "0x14E9744")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x14E8D80", Offset = "0x14E8D80", VA = "0x14E8D80")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x14E9AC4", Offset = "0x14E9AC4", VA = "0x14E9AC4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x14E9ED0", Offset = "0x14E9ED0", VA = "0x14E9ED0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x14E9F14", Offset = "0x14E9F14", VA = "0x14E9F14")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x14E9F74", Offset = "0x14E9F74", VA = "0x14E9F74")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x14E94D4", Offset = "0x14E94D4", VA = "0x14E94D4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x14E9FE0", Offset = "0x14E9FE0", VA = "0x14E9FE0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x14EA0BC", Offset = "0x14EA0BC", VA = "0x14EA0BC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7304D8", Offset = "0x7304D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7304D8", Offset = "0x7304D8")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735424", Offset = "0x735424")]
		public float twistLimit;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1470BB0", Offset = "0x1470BB0", VA = "0x1470BB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73AB44", Offset = "0x73AB44")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1470BF8", Offset = "0x1470BF8", VA = "0x1470BF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73AB7C", Offset = "0x73AB7C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1470C40", Offset = "0x1470C40", VA = "0x1470C40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ABB4", Offset = "0x73ABB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1470C88", Offset = "0x1470C88", VA = "0x1470C88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x73ABEC", Offset = "0x73ABEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1470CD0", Offset = "0x1470CD0", VA = "0x1470CD0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1470CEC", Offset = "0x1470CEC", VA = "0x1470CEC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1470D8C", Offset = "0x1470D8C", VA = "0x1470D8C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1470FC8", Offset = "0x1470FC8", VA = "0x1470FC8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x730538", Offset = "0x730538")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x147B824", Offset = "0x147B824", VA = "0x147B824", Slot = "4")]
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
				[Address(RVA = "0x147B86C", Offset = "0x147B86C", VA = "0x147B86C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x147B734", Offset = "0x147B734", VA = "0x147B734")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x147B760", Offset = "0x147B760", VA = "0x147B760", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x147B764", Offset = "0x147B764", VA = "0x147B764", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x147B82C", Offset = "0x147B82C", VA = "0x147B82C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735450", Offset = "0x735450")]
		public AimIK ik;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735488", Offset = "0x735488")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735488", Offset = "0x735488")]
		public float weight;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7354DC", Offset = "0x7354DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7354DC", Offset = "0x7354DC")]
		public Transform target;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73553C", Offset = "0x73553C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735574", Offset = "0x735574")]
		public float weightSmoothTime;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7355AC", Offset = "0x7355AC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7355AC", Offset = "0x7355AC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73560C", Offset = "0x73560C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735644", Offset = "0x735644")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73567C", Offset = "0x73567C")]
		public float slerpSpeed;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7356B4", Offset = "0x7356B4")]
		public float smoothDampTime;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7356EC", Offset = "0x7356EC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735724", Offset = "0x735724")]
		public float minDistance;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73575C", Offset = "0x73575C")]
		public Vector3 offset;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x735794", Offset = "0x735794")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735794", Offset = "0x735794")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735794", Offset = "0x735794")]
		public float maxRootAngle;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735810", Offset = "0x735810")]
		public bool turnToTarget;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735848", Offset = "0x735848")]
		public float turnToTargetTime;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735880", Offset = "0x735880")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x735880", Offset = "0x735880")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7358E0", Offset = "0x7358E0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700009C")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x156BB2C", Offset = "0x156BB2C", VA = "0x156BB2C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x156BAA4", Offset = "0x156BAA4", VA = "0x156BAA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x156BBBC", Offset = "0x156BBBC", VA = "0x156BBBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x156C290", Offset = "0x156C290", VA = "0x156C290")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x156C37C", Offset = "0x156C37C", VA = "0x156C37C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x156C5CC", Offset = "0x156C5CC", VA = "0x156C5CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73AC24", Offset = "0x73AC24")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x156C638", Offset = "0x156C638", VA = "0x156C638")]
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
			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x147B874", Offset = "0x147B874", VA = "0x147B874")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x147BA00", Offset = "0x147BA00", VA = "0x147BA00")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x147BA08", Offset = "0x147BA08", VA = "0x147BA08")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x156C89C", Offset = "0x156C89C", VA = "0x156C89C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x156C97C", Offset = "0x156C97C", VA = "0x156C97C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x156C9E8", Offset = "0x156C9E8", VA = "0x156C9E8")]
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
				[Token(Token = "0x400053E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735AA0", Offset = "0x735AA0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400053F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735AD8", Offset = "0x735AD8")]
				public float weight;

				[Token(Token = "0x60005E4")]
				[Address(RVA = "0x17EE8A0", Offset = "0x17EE8A0", VA = "0x17EE8A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735950", Offset = "0x735950")]
			public Transform transform;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735988", Offset = "0x735988")]
			public Transform relativeTo;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7359C0", Offset = "0x7359C0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7359F8", Offset = "0x7359F8")]
			public float verticalWeight;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735A30", Offset = "0x735A30")]
			public float horizontalWeight;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735A68", Offset = "0x735A68")]
			public float speed;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x147BA24", Offset = "0x147BA24", VA = "0x147BA24")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x147BD48", Offset = "0x147BD48", VA = "0x147BD48")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x147BD58", Offset = "0x147BD58", VA = "0x147BD58")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735918", Offset = "0x735918")]
		public Body[] bodies;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x156CAF8", Offset = "0x156CAF8", VA = "0x156CAF8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x156CC44", Offset = "0x156CC44", VA = "0x156CC44")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735B10", Offset = "0x735B10")]
		public float tiltSpeed;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735B48", Offset = "0x735B48")]
		public float tiltSensitivity;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735B80", Offset = "0x735B80")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735BB8", Offset = "0x735BB8")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1579F9C", Offset = "0x1579F9C", VA = "0x1579F9C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1579FE4", Offset = "0x1579FE4", VA = "0x1579FE4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x157A19C", Offset = "0x157A19C", VA = "0x157A19C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735BF0", Offset = "0x735BF0")]
		public float weight;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x157A1B0", Offset = "0x157A1B0", VA = "0x157A1B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x157A278", Offset = "0x157A278", VA = "0x157A278")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x157A4A0", Offset = "0x157A4A0", VA = "0x157A4A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x157A5AC", Offset = "0x157A5AC", VA = "0x157A5AC")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735C08", Offset = "0x735C08")]
		public Animator animator;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735C40", Offset = "0x735C40")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735C88", Offset = "0x735C88")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700009F")]
		public IK ik
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x157F7B4", Offset = "0x157F7B4", VA = "0x157F7B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACD4", Offset = "0x73ACD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x157F7BC", Offset = "0x157F7BC", VA = "0x157F7BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACE4", Offset = "0x73ACE4")]
			private set
			{
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x157F7C4", Offset = "0x157F7C4", VA = "0x157F7C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x157F960", Offset = "0x157F960", VA = "0x157F960")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x157FBEC", Offset = "0x157FBEC", VA = "0x157FBEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x157FD34", Offset = "0x157FD34", VA = "0x157FD34")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x157FF00", Offset = "0x157FF00", VA = "0x157FF00")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1580130", Offset = "0x1580130", VA = "0x1580130")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x15803CC", Offset = "0x15803CC", VA = "0x15803CC")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x730558", Offset = "0x730558")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000A0")]
		public bool poseStored
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x157FA58", Offset = "0x157FA58", VA = "0x157FA58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x157FDAC", Offset = "0x157FDAC", VA = "0x157FDAC")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x157FA7C", Offset = "0x157FA7C", VA = "0x157FA7C")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1580428", Offset = "0x1580428", VA = "0x1580428")]
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
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735D08", Offset = "0x735D08")]
			public string name;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735D40", Offset = "0x735D40")]
			public Collider collider;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735D78", Offset = "0x735D78")]
			private float crossFadeTime;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735DC4", Offset = "0x735DC4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735DD4", Offset = "0x735DD4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735DE4", Offset = "0x735DE4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x735DF4", Offset = "0x735DF4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A2")]
			public bool inProgress
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x147E410", Offset = "0x147E410", VA = "0x147E410")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A3")]
			protected float crossFader
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x147E424", Offset = "0x147E424", VA = "0x147E424")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ACF4", Offset = "0x73ACF4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x147E42C", Offset = "0x147E42C", VA = "0x147E42C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD04", Offset = "0x73AD04")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected float timer
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x147E434", Offset = "0x147E434", VA = "0x147E434")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD14", Offset = "0x73AD14")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x147E43C", Offset = "0x147E43C", VA = "0x147E43C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD24", Offset = "0x73AD24")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected Vector3 force
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x147E444", Offset = "0x147E444", VA = "0x147E444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD34", Offset = "0x73AD34")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x147E450", Offset = "0x147E450", VA = "0x147E450")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD44", Offset = "0x73AD44")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x147E45C", Offset = "0x147E45C", VA = "0x147E45C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD54", Offset = "0x73AD54")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000605")]
				[Address(RVA = "0x147E468", Offset = "0x147E468", VA = "0x147E468")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD64", Offset = "0x73AD64")]
				private set
				{
				}
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x147E474", Offset = "0x147E474", VA = "0x147E474")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x147E5A8", Offset = "0x147E5A8", VA = "0x147E5A8")]
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
			[Address(RVA = "0x147E67C", Offset = "0x147E67C", VA = "0x147E67C")]
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
				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735EAC", Offset = "0x735EAC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735EE4", Offset = "0x735EE4")]
				public float weight;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x17EEA10", Offset = "0x17EEA10", VA = "0x17EEA10")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x17EEAC0", Offset = "0x17EEAC0", VA = "0x17EEAC0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000612")]
				[Address(RVA = "0x17EEAD4", Offset = "0x17EEAD4", VA = "0x17EEAD4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735E04", Offset = "0x735E04")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735E3C", Offset = "0x735E3C")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735E74", Offset = "0x735E74")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x147E9A8", Offset = "0x147E9A8", VA = "0x147E9A8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x147EAD8", Offset = "0x147EAD8", VA = "0x147EAD8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x147EB44", Offset = "0x147EB44", VA = "0x147EB44", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x147ECAC", Offset = "0x147ECAC", VA = "0x147ECAC")]
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
				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735F8C", Offset = "0x735F8C")]
				public Transform bone;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x735FC4", Offset = "0x735FC4")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735FC4", Offset = "0x735FC4")]
				public float weight;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000567")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000617")]
				[Address(RVA = "0x17EE8A8", Offset = "0x17EE8A8", VA = "0x17EE8A8")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000618")]
				[Address(RVA = "0x17EE9C0", Offset = "0x17EE9C0", VA = "0x17EE9C0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000619")]
				[Address(RVA = "0x17EE9CC", Offset = "0x17EE9CC", VA = "0x17EE9CC")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735F1C", Offset = "0x735F1C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735F54", Offset = "0x735F54")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x147E690", Offset = "0x147E690", VA = "0x147E690", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x147E734", Offset = "0x147E734", VA = "0x147E734", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x147E7A0", Offset = "0x147E7A0", VA = "0x147E7A0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x147E994", Offset = "0x147E994", VA = "0x147E994")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735C98", Offset = "0x735C98")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x735CD0", Offset = "0x735CD0")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A1")]
		public bool inProgress
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1630D20", Offset = "0x1630D20", VA = "0x1630D20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1630DF0", Offset = "0x1630DF0", VA = "0x1630DF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1630ECC", Offset = "0x1630ECC", VA = "0x1630ECC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1631128", Offset = "0x1631128", VA = "0x1631128")]
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
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736088", Offset = "0x736088")]
			public string name;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7360C0", Offset = "0x7360C0")]
			public Collider collider;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7360F8", Offset = "0x7360F8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736144", Offset = "0x736144")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736154", Offset = "0x736154")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736164", Offset = "0x736164")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736174", Offset = "0x736174")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A7")]
			protected float crossFader
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x147ECC0", Offset = "0x147ECC0", VA = "0x147ECC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD74", Offset = "0x73AD74")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x147ECC8", Offset = "0x147ECC8", VA = "0x147ECC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD84", Offset = "0x73AD84")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected float timer
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x147ECD0", Offset = "0x147ECD0", VA = "0x147ECD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AD94", Offset = "0x73AD94")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x147ECD8", Offset = "0x147ECD8", VA = "0x147ECD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ADA4", Offset = "0x73ADA4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 force
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x147ECE0", Offset = "0x147ECE0", VA = "0x147ECE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ADB4", Offset = "0x73ADB4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x147ECEC", Offset = "0x147ECEC", VA = "0x147ECEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ADC4", Offset = "0x73ADC4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected Vector3 point
			{
				[Token(Token = "0x6000623")]
				[Address(RVA = "0x147ECF8", Offset = "0x147ECF8", VA = "0x147ECF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ADD4", Offset = "0x73ADD4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x147ED04", Offset = "0x147ED04", VA = "0x147ED04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73ADE4", Offset = "0x73ADE4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x147ED10", Offset = "0x147ED10", VA = "0x147ED10")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x147EE58", Offset = "0x147EE58", VA = "0x147EE58")]
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
			[Address(RVA = "0x147EF40", Offset = "0x147EF40", VA = "0x147EF40")]
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
				[Token(Token = "0x4000578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73622C", Offset = "0x73622C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736264", Offset = "0x736264")]
				public float weight;

				[Token(Token = "0x400057A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400057B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600062F")]
				[Address(RVA = "0x17EEADC", Offset = "0x17EEADC", VA = "0x17EEADC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000630")]
				[Address(RVA = "0x17EEB6C", Offset = "0x17EEB6C", VA = "0x17EEB6C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000631")]
				[Address(RVA = "0x17EEB80", Offset = "0x17EEB80", VA = "0x17EEB80")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736184", Offset = "0x736184")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7361BC", Offset = "0x7361BC")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7361F4", Offset = "0x7361F4")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x147EF54", Offset = "0x147EF54", VA = "0x147EF54", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x147F104", Offset = "0x147F104", VA = "0x147F104", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x147F170", Offset = "0x147F170", VA = "0x147F170", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x147F310", Offset = "0x147F310", VA = "0x147F310")]
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
				[Token(Token = "0x400057F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73630C", Offset = "0x73630C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736344", Offset = "0x736344")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736344", Offset = "0x736344")]
				public float weight;

				[Token(Token = "0x4000581")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000582")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000636")]
				[Address(RVA = "0x17EEB88", Offset = "0x17EEB88", VA = "0x17EEB88")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000637")]
				[Address(RVA = "0x17EEC64", Offset = "0x17EEC64", VA = "0x17EEC64")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000638")]
				[Address(RVA = "0x17EEC70", Offset = "0x17EEC70", VA = "0x17EEC70")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73629C", Offset = "0x73629C")]
			public int curveIndex;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7362D4", Offset = "0x7362D4")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x147F32C", Offset = "0x147F32C", VA = "0x147F32C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x147F410", Offset = "0x147F410", VA = "0x147F410", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x147F47C", Offset = "0x147F47C", VA = "0x147F47C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x147F730", Offset = "0x147F730", VA = "0x147F730")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736018", Offset = "0x736018")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736050", Offset = "0x736050")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x163147C", Offset = "0x163147C", VA = "0x163147C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1631550", Offset = "0x1631550", VA = "0x1631550")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x16317B4", Offset = "0x16317B4", VA = "0x16317B4")]
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
				[Token(Token = "0x4000590")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736574", Offset = "0x736574")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000591")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7365AC", Offset = "0x7365AC")]
				public float weight;

				[Token(Token = "0x600063F")]
				[Address(RVA = "0x17EECB4", Offset = "0x17EECB4", VA = "0x17EECB4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736408", Offset = "0x736408")]
			public Transform transform;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736440", Offset = "0x736440")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736478", Offset = "0x736478")]
			public float speed;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7364B0", Offset = "0x7364B0")]
			public float acceleration;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7364E8", Offset = "0x7364E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7364E8", Offset = "0x7364E8")]
			public float matchVelocity;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73653C", Offset = "0x73653C")]
			public float gravity;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x16A98EC", Offset = "0x16A98EC", VA = "0x16A98EC")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x16A99A4", Offset = "0x16A99A4", VA = "0x16A99A4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x16A9C60", Offset = "0x16A9C60", VA = "0x16A9C60")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736398", Offset = "0x736398")]
		public Body[] bodies;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7363D0", Offset = "0x7363D0")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1610048", Offset = "0x1610048", VA = "0x1610048")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x16100C4", Offset = "0x16100C4", VA = "0x16100C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1610184", Offset = "0x1610184", VA = "0x1610184")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7365E4", Offset = "0x7365E4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7365E4", Offset = "0x7365E4")]
		public Transform target;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736644", Offset = "0x736644")]
		public float weight;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73665C", Offset = "0x73665C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736694", Offset = "0x736694")]
		public float weightSmoothTime;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7366CC", Offset = "0x7366CC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7366CC", Offset = "0x7366CC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73672C", Offset = "0x73672C")]
		public float maxRadiansDelta;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736764", Offset = "0x736764")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73679C", Offset = "0x73679C")]
		public float slerpSpeed;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7367D4", Offset = "0x7367D4")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73680C", Offset = "0x73680C")]
		public float minDistance;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736844", Offset = "0x736844")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x736844", Offset = "0x736844")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736844", Offset = "0x736844")]
		public float maxRootAngle;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000AB")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x14DECD4", Offset = "0x14DECD4", VA = "0x14DECD4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x14DEC60", Offset = "0x14DEC60", VA = "0x14DEC60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x14DED64", Offset = "0x14DED64", VA = "0x14DED64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x14DF294", Offset = "0x14DF294", VA = "0x14DF294")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x14DF380", Offset = "0x14DF380", VA = "0x14DF380")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x14DF578", Offset = "0x14DF578", VA = "0x14DF578")]
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
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736930", Offset = "0x736930")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736968", Offset = "0x736968")]
			public float spring;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7369A0", Offset = "0x7369A0")]
			public bool x;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7369D8", Offset = "0x7369D8")]
			public bool y;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736A10", Offset = "0x736A10")]
			public bool z;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736A48", Offset = "0x736A48")]
			public float minX;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736A80", Offset = "0x736A80")]
			public float maxX;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736AB8", Offset = "0x736AB8")]
			public float minY;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736AF0", Offset = "0x736AF0")]
			public float maxY;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736B28", Offset = "0x736B28")]
			public float minZ;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736B60", Offset = "0x736B60")]
			public float maxZ;

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x16AC00C", Offset = "0x16AC00C", VA = "0x16AC00C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x16AC164", Offset = "0x16AC164", VA = "0x16AC164")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x16AC1DC", Offset = "0x16AC1DC", VA = "0x16AC1DC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x16AC234", Offset = "0x16AC234", VA = "0x16AC234")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7305AC", Offset = "0x7305AC")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x16ABFBC", Offset = "0x16ABFBC", VA = "0x16ABFBC", Slot = "4")]
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
				[Address(RVA = "0x16AC004", Offset = "0x16AC004", VA = "0x16AC004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x16ABE48", Offset = "0x16ABE48", VA = "0x16ABE48")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x16ABE74", Offset = "0x16ABE74", VA = "0x16ABE74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x16ABE78", Offset = "0x16ABE78", VA = "0x16ABE78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x16ABFC4", Offset = "0x16ABFC4", VA = "0x16ABFC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7368C0", Offset = "0x7368C0")]
		public float weight;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7368F8", Offset = "0x7368F8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x14E269C", Offset = "0x14E269C", VA = "0x14E269C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000647")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x14E148C", Offset = "0x14E148C", VA = "0x14E148C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x14E26C8", Offset = "0x14E26C8", VA = "0x14E26C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73ADF4", Offset = "0x73ADF4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x14E2734", Offset = "0x14E2734", VA = "0x14E2734")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x14E2810", Offset = "0x14E2810", VA = "0x14E2810")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x14E17FC", Offset = "0x14E17FC", VA = "0x14E17FC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x14E191C", Offset = "0x14E191C", VA = "0x14E191C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7305BC", Offset = "0x7305BC")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x16AC3B0", Offset = "0x16AC3B0", VA = "0x16AC3B0", Slot = "4")]
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
				[Address(RVA = "0x16AC3F8", Offset = "0x16AC3F8", VA = "0x16AC3F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x16AC23C", Offset = "0x16AC23C", VA = "0x16AC23C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x16AC268", Offset = "0x16AC268", VA = "0x16AC268", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x16AC26C", Offset = "0x16AC26C", VA = "0x16AC26C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x16AC3B8", Offset = "0x16AC3B8", VA = "0x16AC3B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736B98", Offset = "0x736B98")]
		public float weight;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736BD0", Offset = "0x736BD0")]
		public VRIK ik;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AF")]
		protected float deltaTime
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x14E28D0", Offset = "0x14E28D0", VA = "0x14E28D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000659")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x14E28FC", Offset = "0x14E28FC", VA = "0x14E28FC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x14E2928", Offset = "0x14E2928", VA = "0x14E2928")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73AEA4", Offset = "0x73AEA4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x14E2994", Offset = "0x14E2994", VA = "0x14E2994")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x14E2A70", Offset = "0x14E2A70", VA = "0x14E2A70", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x14E2B7C", Offset = "0x14E2B7C", VA = "0x14E2B7C")]
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
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x16AC400", Offset = "0x16AC400", VA = "0x16AC400")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x16AC61C", Offset = "0x16AC61C", VA = "0x16AC61C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x14E2B8C", Offset = "0x14E2B8C", VA = "0x14E2B8C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x14E2C50", Offset = "0x14E2C50", VA = "0x14E2C50")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x14E2D0C", Offset = "0x14E2D0C", VA = "0x14E2D0C")]
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
				[Token(Token = "0x40005CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736DE4", Offset = "0x736DE4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736E1C", Offset = "0x736E1C")]
				public float weight;

				[Token(Token = "0x6000670")]
				[Address(RVA = "0x17EECC4", Offset = "0x17EECC4", VA = "0x17EECC4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736C40", Offset = "0x736C40")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736C78", Offset = "0x736C78")]
			public Transform raycastTo;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x736CB0", Offset = "0x736CB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736CB0", Offset = "0x736CB0")]
			public float raycastRadius;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736D04", Offset = "0x736D04")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736D3C", Offset = "0x736D3C")]
			public float smoothTimeIn;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736D74", Offset = "0x736D74")]
			public float smoothTimeOut;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736DAC", Offset = "0x736DAC")]
			public LayerMask layers;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x16AC624", Offset = "0x16AC624", VA = "0x16AC624")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x16AC768", Offset = "0x16AC768", VA = "0x16AC768")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x16AC860", Offset = "0x16AC860", VA = "0x16AC860")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x16ACA30", Offset = "0x16ACA30", VA = "0x16ACA30")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736C08", Offset = "0x736C08")]
		public Avoider[] avoiders;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x14E36B4", Offset = "0x14E36B4", VA = "0x14E36B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x14E373C", Offset = "0x14E373C", VA = "0x14E373C")]
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
				[Token(Token = "0x40005EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7371A8", Offset = "0x7371A8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7371E0", Offset = "0x7371E0")]
				public float weight;

				[Token(Token = "0x6000680")]
				[Address(RVA = "0x17EECCC", Offset = "0x17EECCC", VA = "0x17EECCC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7370AC", Offset = "0x7370AC")]
			public Vector3 offset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7370E4", Offset = "0x7370E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7370E4", Offset = "0x7370E4")]
			public float additivity;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737138", Offset = "0x737138")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737170", Offset = "0x737170")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x16AD424", Offset = "0x16AD424", VA = "0x16AD424")]
			public void Start()
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x16AD474", Offset = "0x16AD474", VA = "0x16AD474")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x16AD638", Offset = "0x16AD638", VA = "0x16AD638")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public enum Handedness
		{
			[Token(Token = "0x40005EF")]
			Right,
			[Token(Token = "0x40005F0")]
			Left
		}

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736E54", Offset = "0x736E54")]
		public AimIK aimIK;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736E8C", Offset = "0x736E8C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736EC4", Offset = "0x736EC4")]
		public Handedness handedness;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736EFC", Offset = "0x736EFC")]
		public bool twoHanded;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736F34", Offset = "0x736F34")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736F6C", Offset = "0x736F6C")]
		public float magnitudeRandom;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736FA4", Offset = "0x736FA4")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x736FDC", Offset = "0x736FDC")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737014", Offset = "0x737014")]
		public float blendTime;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x73704C", Offset = "0x73704C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73704C", Offset = "0x73704C")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B2")]
		public bool isFinished
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x14E6E14", Offset = "0x14E6E14", VA = "0x14E6E14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x14E788C", Offset = "0x14E788C", VA = "0x14E788C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x14E78CC", Offset = "0x14E78CC", VA = "0x14E78CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x14E784C", Offset = "0x14E784C", VA = "0x14E784C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x14E786C", Offset = "0x14E786C", VA = "0x14E786C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x14E6E44", Offset = "0x14E6E44", VA = "0x14E6E44")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x14E6E70", Offset = "0x14E6E70", VA = "0x14E6E70")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x14E6FB8", Offset = "0x14E6FB8", VA = "0x14E6FB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x14E790C", Offset = "0x14E790C", VA = "0x14E790C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x14E79C0", Offset = "0x14E79C0", VA = "0x14E79C0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x14E79FC", Offset = "0x14E79FC", VA = "0x14E79FC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x14E7BB4", Offset = "0x14E7BB4", VA = "0x14E7BB4")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737218", Offset = "0x737218")]
		public float weight;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737250", Offset = "0x737250")]
		public float offset;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x14711D8", Offset = "0x14711D8", VA = "0x14711D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x14712C0", Offset = "0x14712C0", VA = "0x14712C0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x14713A8", Offset = "0x14713A8", VA = "0x14713A8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x14716F8", Offset = "0x14716F8", VA = "0x14716F8")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x147176C", Offset = "0x147176C", VA = "0x147176C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1471878", Offset = "0x1471878", VA = "0x1471878")]
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
			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737288", Offset = "0x737288")]
			public float scaleMlp;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7372C0", Offset = "0x7372C0")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7372F8", Offset = "0x7372F8")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737330", Offset = "0x737330")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737368", Offset = "0x737368")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7373A0", Offset = "0x7373A0")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7373D8", Offset = "0x7373D8")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x737410", Offset = "0x737410")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737410", Offset = "0x737410")]
			public Vector3 headOffset;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737460", Offset = "0x737460")]
			public Vector3 handOffset;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737498", Offset = "0x737498")]
			public float footForwardOffset;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7374D0", Offset = "0x7374D0")]
			public float footInwardOffset;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737508", Offset = "0x737508")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737508", Offset = "0x737508")]
			public float footHeadingOffset;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737564", Offset = "0x737564")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73757C", Offset = "0x73757C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x17EE458", Offset = "0x17EE458", VA = "0x17EE458")]
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
				[Token(Token = "0x400060F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000610")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000611")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000698")]
				[Address(RVA = "0x17EECD4", Offset = "0x17EECD4", VA = "0x17EECD4")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000699")]
				[Address(RVA = "0x17EED94", Offset = "0x17EED94", VA = "0x17EED94")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x17EE450", Offset = "0x17EE450", VA = "0x17EE450")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x14789FC", Offset = "0x14789FC", VA = "0x14789FC")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x14775C4", Offset = "0x14775C4", VA = "0x14775C4")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1478B64", Offset = "0x1478B64", VA = "0x1478B64")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1478A78", Offset = "0x1478A78", VA = "0x1478A78")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x14777F0", Offset = "0x14777F0", VA = "0x14777F0")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1478B7C", Offset = "0x1478B7C", VA = "0x1478B7C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1476ADC", Offset = "0x1476ADC", VA = "0x1476ADC")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1479368", Offset = "0x1479368", VA = "0x1479368")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x14768C8", Offset = "0x14768C8", VA = "0x14768C8")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1479778", Offset = "0x1479778", VA = "0x1479778")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1479E1C", Offset = "0x1479E1C", VA = "0x1479E1C")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1479BC8", Offset = "0x1479BC8", VA = "0x1479BC8")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x147A08C", Offset = "0x147A08C", VA = "0x147A08C")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x147A2E8", Offset = "0x147A2E8", VA = "0x147A2E8")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x147A3D8", Offset = "0x147A3D8", VA = "0x147A3D8")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D3")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x147A6F4", Offset = "0x147A6F4", VA = "0x147A6F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x147A748", Offset = "0x147A748", VA = "0x147A748")]
		private void Update()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x147A77C", Offset = "0x147A77C", VA = "0x147A77C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x147A8B8", Offset = "0x147A8B8", VA = "0x147A8B8")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737594", Offset = "0x737594")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B7")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x147AFA8", Offset = "0x147AFA8", VA = "0x147AFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF54", Offset = "0x73AF54")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x147AFB4", Offset = "0x147AFB4", VA = "0x147AFB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF64", Offset = "0x73AF64")]
			private set
			{
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x147AFC0", Offset = "0x147AFC0", VA = "0x147AFC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1479170", Offset = "0x1479170", VA = "0x1479170")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x14795F4", Offset = "0x14795F4", VA = "0x14795F4")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x147B0AC", Offset = "0x147B0AC", VA = "0x147B0AC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x147B4C8", Offset = "0x147B4C8", VA = "0x147B4C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x147B5D4", Offset = "0x147B5D4", VA = "0x147B5D4")]
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
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x147C584", Offset = "0x147C584", VA = "0x147C584")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x147C6E4", Offset = "0x147C6E4", VA = "0x147C6E4")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x15872F4", Offset = "0x15872F4", VA = "0x15872F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1587348", Offset = "0x1587348", VA = "0x1587348")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x15873C4", Offset = "0x15873C4", VA = "0x15873C4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x158749C", Offset = "0x158749C", VA = "0x158749C")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x156BA18", Offset = "0x156BA18", VA = "0x156BA18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x156BA9C", Offset = "0x156BA9C", VA = "0x156BA9C")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7375B4", Offset = "0x7375B4")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x156CA4C", Offset = "0x156CA4C", VA = "0x156CA4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x156CAC4", Offset = "0x156CAC4", VA = "0x156CAC4")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1470FD8", Offset = "0x1470FD8", VA = "0x1470FD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x147101C", Offset = "0x147101C", VA = "0x147101C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x14711D0", Offset = "0x14711D0", VA = "0x14711D0")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7375EC", Offset = "0x7375EC")]
		public AimPoser aimPoser;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737624", Offset = "0x737624")]
		public AimIK aim;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73765C", Offset = "0x73765C")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737694", Offset = "0x737694")]
		public Animator animator;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7376CC", Offset = "0x7376CC")]
		public float crossfadeTime;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737704", Offset = "0x737704")]
		public float minAimDistance;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x147188C", Offset = "0x147188C", VA = "0x147188C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x14718D0", Offset = "0x14718D0", VA = "0x14718D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1471A38", Offset = "0x1471A38", VA = "0x1471A38")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1471BC8", Offset = "0x1471BC8", VA = "0x1471BC8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1471D04", Offset = "0x1471D04", VA = "0x1471D04")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1471D80", Offset = "0x1471D80", VA = "0x1471D80")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1472D18", Offset = "0x1472D18", VA = "0x1472D18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1472E88", Offset = "0x1472E88", VA = "0x1472E88")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x147301C", Offset = "0x147301C", VA = "0x147301C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x73773C", Offset = "0x73773C")]
		public Animator animator;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x737774", Offset = "0x737774")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7377AC", Offset = "0x7377AC")]
		public float lookAtWeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7377C4", Offset = "0x7377C4")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7377DC", Offset = "0x7377DC")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7377F4", Offset = "0x7377F4")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73780C", Offset = "0x73780C")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737824", Offset = "0x737824")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73783C", Offset = "0x73783C")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x737854", Offset = "0x737854")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73788C", Offset = "0x73788C")]
		public float footPositionWeight;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7378A4", Offset = "0x7378A4")]
		public float footRotationWeight;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7378BC", Offset = "0x7378BC")]
		public Transform handTargetBiped;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7378F4", Offset = "0x7378F4")]
		public float handPositionWeight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73790C", Offset = "0x73790C")]
		public float handRotationWeight;

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1573180", Offset = "0x1573180", VA = "0x1573180")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1573588", Offset = "0x1573588", VA = "0x1573588")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x737924", Offset = "0x737924")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000B8")]
		public Vector3 velocity
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x14DF774", Offset = "0x14DF774", VA = "0x14DF774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF74", Offset = "0x73AF74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x14DF780", Offset = "0x14DF780", VA = "0x14DF780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73AF84", Offset = "0x73AF84")]
			private set
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x14DF78C", Offset = "0x14DF78C", VA = "0x14DF78C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x14DF7C8", Offset = "0x14DF7C8", VA = "0x14DF7C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x14E003C", Offset = "0x14E003C", VA = "0x14E003C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x14DFDEC", Offset = "0x14DFDEC", VA = "0x14DFDEC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x14E0138", Offset = "0x14E0138", VA = "0x14E0138")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B9")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x14E0164", Offset = "0x14E0164", VA = "0x14E0164")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x14E01E8", Offset = "0x14E01E8", VA = "0x14E01E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x14E040C", Offset = "0x14E040C", VA = "0x14E040C")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7305CC", Offset = "0x7305CC")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x16ABB90", Offset = "0x16ABB90", VA = "0x16ABB90", Slot = "4")]
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
				[Address(RVA = "0x16ABBD8", Offset = "0x16ABBD8", VA = "0x16ABBD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x16AB8A0", Offset = "0x16AB8A0", VA = "0x16AB8A0")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x16AB8CC", Offset = "0x16AB8CC", VA = "0x16AB8CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x16AB8D0", Offset = "0x16AB8D0", VA = "0x16AB8D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x16ABB98", Offset = "0x16ABB98", VA = "0x16ABB98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000BA")]
		public bool isStepping
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x14E0420", Offset = "0x14E0420", VA = "0x14E0420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public Vector3 position
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x14E0104", Offset = "0x14E0104", VA = "0x14E0104")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x14E0434", Offset = "0x14E0434", VA = "0x14E0434")]
			set
			{
			}
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x14E0484", Offset = "0x14E0484", VA = "0x14E0484")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x14E0678", Offset = "0x14E0678", VA = "0x14E0678")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x14E0814", Offset = "0x14E0814", VA = "0x14E0814")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x14E0A3C", Offset = "0x14E0A3C", VA = "0x14E0A3C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x14E0CB0", Offset = "0x14E0CB0", VA = "0x14E0CB0")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x14E0E28", Offset = "0x14E0E28", VA = "0x14E0E28")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x14E0994", Offset = "0x14E0994", VA = "0x14E0994")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73AF94", Offset = "0x73AF94")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x14E1024", Offset = "0x14E1024", VA = "0x14E1024")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x14E1088", Offset = "0x14E1088", VA = "0x14E1088")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x14E1148", Offset = "0x14E1148", VA = "0x14E1148")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x14E139C", Offset = "0x14E139C", VA = "0x14E139C")]
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
			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7379F4", Offset = "0x7379F4")]
			public int animationLayer;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737A2C", Offset = "0x737A2C")]
			public string animationState;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737A64", Offset = "0x737A64")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737A9C", Offset = "0x737A9C")]
			public Transform warpFrom;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737AD4", Offset = "0x737AD4")]
			public Transform warpTo;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737B0C", Offset = "0x737B0C")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum EffectorMode
		{
			[Token(Token = "0x400068E")]
			PositionOffset,
			[Token(Token = "0x400068F")]
			Position
		}

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737934", Offset = "0x737934")]
		public Animator animator;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73796C", Offset = "0x73796C")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7379A4", Offset = "0x7379A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7379A4", Offset = "0x7379A4")]
		public Warp[] warps;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x156CC4C", Offset = "0x156CC4C", VA = "0x156CC4C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x156CC78", Offset = "0x156CC78", VA = "0x156CC78")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x156CEB8", Offset = "0x156CEB8", VA = "0x156CEB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x156D17C", Offset = "0x156D17C", VA = "0x156D17C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x156D21C", Offset = "0x156D21C", VA = "0x156D21C")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x156D224", Offset = "0x156D224", VA = "0x156D224", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x156D278", Offset = "0x156D278", VA = "0x156D278")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x156D414", Offset = "0x156D414", VA = "0x156D414", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x156D61C", Offset = "0x156D61C", VA = "0x156D61C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737B44", Offset = "0x737B44")]
		public float headLookWeight;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x156D630", Offset = "0x156D630", VA = "0x156D630", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x156D7BC", Offset = "0x156D7BC", VA = "0x156D7BC", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x156D838", Offset = "0x156D838", VA = "0x156D838")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x156D92C", Offset = "0x156D92C", VA = "0x156D92C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x156D974", Offset = "0x156D974", VA = "0x156D974")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x156DD60", Offset = "0x156DD60", VA = "0x156DD60")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x156DBE8", Offset = "0x156DBE8", VA = "0x156DBE8")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x156DFBC", Offset = "0x156DFBC", VA = "0x156DFBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x156E0C8", Offset = "0x156E0C8", VA = "0x156E0C8")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x157C0D4", Offset = "0x157C0D4", VA = "0x157C0D4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x157C130", Offset = "0x157C130", VA = "0x157C130", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x157C36C", Offset = "0x157C36C", VA = "0x157C36C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x157C460", Offset = "0x157C460", VA = "0x157C460")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BE")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x157CE84", Offset = "0x157CE84", VA = "0x157CE84")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x157CF08", Offset = "0x157CF08", VA = "0x157CF08")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x157CC8C", Offset = "0x157CC8C", VA = "0x157CC8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x157CCF8", Offset = "0x157CCF8", VA = "0x157CCF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x157CF8C", Offset = "0x157CF8C", VA = "0x157CF8C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737B5C", Offset = "0x737B5C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x15804A8", Offset = "0x15804A8", VA = "0x15804A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1580908", Offset = "0x1580908", VA = "0x1580908")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1580910", Offset = "0x1580910", VA = "0x1580910")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x15809B8", Offset = "0x15809B8", VA = "0x15809B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1580D3C", Offset = "0x1580D3C", VA = "0x1580D3C")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1580DE8", Offset = "0x1580DE8", VA = "0x1580DE8")]
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
			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x147C06C", Offset = "0x147C06C", VA = "0x147C06C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x147C0F0", Offset = "0x147C0F0", VA = "0x147C0F0")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x15846B4", Offset = "0x15846B4", VA = "0x15846B4")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x158480C", Offset = "0x158480C", VA = "0x158480C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x15848B0", Offset = "0x15848B0", VA = "0x15848B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x15848B4", Offset = "0x15848B4", VA = "0x15848B4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x15848C4", Offset = "0x15848C4", VA = "0x15848C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1584938", Offset = "0x1584938", VA = "0x1584938")]
		private void Update()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1584A0C", Offset = "0x1584A0C", VA = "0x1584A0C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737B74", Offset = "0x737B74")]
		public Transform target;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737BAC", Offset = "0x737BAC")]
		public Transform pin;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737BE4", Offset = "0x737BE4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C1C", Offset = "0x737C1C")]
		public AimIK aim;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C54", Offset = "0x737C54")]
		public float weight;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737C8C", Offset = "0x737C8C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737CC4", Offset = "0x737CC4")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1584A14", Offset = "0x1584A14", VA = "0x1584A14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1584A68", Offset = "0x1584A68", VA = "0x1584A68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1584C0C", Offset = "0x1584C0C", VA = "0x1584C0C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1586CB0", Offset = "0x1586CB0", VA = "0x1586CB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1586D78", Offset = "0x1586D78", VA = "0x1586D78")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1586E08", Offset = "0x1586E08", VA = "0x1586E08")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x15871E0", Offset = "0x15871E0", VA = "0x15871E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x15872EC", Offset = "0x15872EC", VA = "0x15872EC")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737CFC", Offset = "0x737CFC")]
		public float aimWeight;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737D14", Offset = "0x737D14")]
		public float sightWeight;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737D2C", Offset = "0x737D2C")]
		public float maxAngle;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737D48", Offset = "0x737D48")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x15874A4", Offset = "0x15874A4", VA = "0x15874A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1587668", Offset = "0x1587668", VA = "0x1587668")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1587674", Offset = "0x1587674", VA = "0x1587674")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x15878F4", Offset = "0x15878F4", VA = "0x15878F4")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1587BC4", Offset = "0x1587BC4", VA = "0x1587BC4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x158773C", Offset = "0x158773C", VA = "0x158773C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x15884B8", Offset = "0x15884B8", VA = "0x15884B8")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737D60", Offset = "0x737D60")]
		public float walkSpeed;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x15884D8", Offset = "0x15884D8", VA = "0x15884D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1588550", Offset = "0x1588550", VA = "0x1588550")]
		private void Update()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x158863C", Offset = "0x158863C", VA = "0x158863C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x15886F4", Offset = "0x15886F4", VA = "0x15886F4")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1631130", Offset = "0x1631130", VA = "0x1631130")]
		private void Update()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1631288", Offset = "0x1631288", VA = "0x1631288")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x163146C", Offset = "0x163146C", VA = "0x163146C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1631B08", Offset = "0x1631B08", VA = "0x1631B08")]
		private void Start()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1631C50", Offset = "0x1631C50", VA = "0x1631C50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1631F8C", Offset = "0x1631F8C", VA = "0x1631F8C")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1610264", Offset = "0x1610264", VA = "0x1610264")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x16103A0", Offset = "0x16103A0", VA = "0x16103A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x16104AC", Offset = "0x16104AC", VA = "0x16104AC")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x16104B4", Offset = "0x16104B4", VA = "0x16104B4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1610BE0", Offset = "0x1610BE0", VA = "0x1610BE0")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737D78", Offset = "0x737D78")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737DB0", Offset = "0x737DB0")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x14DC79C", Offset = "0x14DC79C", VA = "0x14DC79C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x14DC7F0", Offset = "0x14DC7F0", VA = "0x14DC7F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x14DCB28", Offset = "0x14DCB28", VA = "0x14DCB28")]
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
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000C0")]
			private Transform neck
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x16AB834", Offset = "0x16AB834", VA = "0x16AB834")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x16AB0E8", Offset = "0x16AB0E8", VA = "0x16AB0E8")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x16AB108", Offset = "0x16AB108", VA = "0x16AB108")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x16AB6A0", Offset = "0x16AB6A0", VA = "0x16AB6A0")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x16AB88C", Offset = "0x16AB88C", VA = "0x16AB88C")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x14DE25C", Offset = "0x14DE25C", VA = "0x14DE25C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x14DE298", Offset = "0x14DE298", VA = "0x14DE298")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x14DE300", Offset = "0x14DE300", VA = "0x14DE300")]
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
			[Token(Token = "0x400071B")]
			Position,
			[Token(Token = "0x400071C")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Absorber
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737EC8", Offset = "0x737EC8")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F00", Offset = "0x737F00")]
			public float weight;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x16ABBE0", Offset = "0x16ABBE0", VA = "0x16ABBE0")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x16ABCB4", Offset = "0x16ABCB4", VA = "0x16ABCB4")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x16ABCF0", Offset = "0x16ABCF0", VA = "0x16ABCF0")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x16ABD88", Offset = "0x16ABD88", VA = "0x16ABD88")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x16ABDFC", Offset = "0x16ABDFC", VA = "0x16ABDFC")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737DE8", Offset = "0x737DE8")]
		public Mode mode;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737E20", Offset = "0x737E20")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737E58", Offset = "0x737E58")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737E90", Offset = "0x737E90")]
		public float falloffSpeed;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x14E13A4", Offset = "0x14E13A4", VA = "0x14E13A4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x14E14B8", Offset = "0x14E14B8", VA = "0x14E14B8")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x14E1548", Offset = "0x14E1548", VA = "0x14E1548", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x14E165C", Offset = "0x14E165C", VA = "0x14E165C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x14E16E8", Offset = "0x14E16E8", VA = "0x14E16E8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x14E1908", Offset = "0x14E1908", VA = "0x14E1908")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x14E192C", Offset = "0x14E192C", VA = "0x14E192C")]
		private void Start()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x14E19A0", Offset = "0x14E19A0", VA = "0x14E19A0")]
		private void Update()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x14E1A7C", Offset = "0x14E1A7C", VA = "0x14E1A7C")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x14E1B3C", Offset = "0x14E1B3C", VA = "0x14E1B3C")]
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
			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x16ABE38", Offset = "0x16ABE38", VA = "0x16ABE38")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x14E23F4", Offset = "0x14E23F4", VA = "0x14E23F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x14E2500", Offset = "0x14E2500", VA = "0x14E2500", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x14E268C", Offset = "0x14E268C", VA = "0x14E268C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x737F48", Offset = "0x737F48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F48", Offset = "0x737F48")]
		public float weight;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737F9C", Offset = "0x737F9C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x737FD4", Offset = "0x737FD4")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738020", Offset = "0x738020")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x14E2D68", Offset = "0x14E2D68", VA = "0x14E2D68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x14E302C", Offset = "0x14E302C", VA = "0x14E302C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x14E3674", Offset = "0x14E3674", VA = "0x14E3674")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000C1")]
		private bool holding
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x14E3C50", Offset = "0x14E3C50", VA = "0x14E3C50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private bool holdingLeft
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x14E3D34", Offset = "0x14E3D34", VA = "0x14E3D34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool holdingRight
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x14E3C88", Offset = "0x14E3C88", VA = "0x14E3C88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x14E374C", Offset = "0x14E374C", VA = "0x14E374C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000746")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x14E3DE0", Offset = "0x14E3DE0", VA = "0x14E3DE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x14E3F68", Offset = "0x14E3F68", VA = "0x14E3F68")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x14E40EC", Offset = "0x14E40EC", VA = "0x14E40EC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x14E41C8", Offset = "0x14E41C8", VA = "0x14E41C8")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x14E4308", Offset = "0x14E4308", VA = "0x14E4308")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x14E4478", Offset = "0x14E4478", VA = "0x14E4478")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x14E4644", Offset = "0x14E4644", VA = "0x14E4644")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x14E4658", Offset = "0x14E4658", VA = "0x14E4658", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x14E48BC", Offset = "0x14E48BC", VA = "0x14E48BC")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x14E48D0", Offset = "0x14E48D0", VA = "0x14E48D0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x14E4A04", Offset = "0x14E4A04", VA = "0x14E4A04")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x14E6C18", Offset = "0x14E6C18", VA = "0x14E6C18")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x14E6CF8", Offset = "0x14E6CF8", VA = "0x14E6CF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x14E6E0C", Offset = "0x14E6E0C", VA = "0x14E6E0C")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x14E7C24", Offset = "0x14E7C24", VA = "0x14E7C24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x14E7C78", Offset = "0x14E7C78", VA = "0x14E7C78")]
		private void Update()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x14E7CD0", Offset = "0x14E7CD0", VA = "0x14E7CD0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x14E7DB0", Offset = "0x14E7DB0", VA = "0x14E7DB0")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7305DC", Offset = "0x7305DC")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x16AD828", Offset = "0x16AD828", VA = "0x16AD828", Slot = "4")]
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
				[Address(RVA = "0x16AD870", Offset = "0x16AD870", VA = "0x16AD870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x16AD64C", Offset = "0x16AD64C", VA = "0x16AD64C")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x16AD678", Offset = "0x16AD678", VA = "0x16AD678", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x16AD67C", Offset = "0x16AD67C", VA = "0x16AD67C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x16AD830", Offset = "0x16AD830", VA = "0x16AD830", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x14E7DC0", Offset = "0x14E7DC0", VA = "0x14E7DC0")]
		private void Start()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x14E7E74", Offset = "0x14E7E74", VA = "0x14E7E74")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x14E7EBC", Offset = "0x14E7EBC", VA = "0x14E7EBC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73B044", Offset = "0x73B044")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x14E7F38", Offset = "0x14E7F38", VA = "0x14E7F38")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7305EC", Offset = "0x7305EC")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076C")]
				[Address(RVA = "0x17EC554", Offset = "0x17EC554", VA = "0x17EC554", Slot = "4")]
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
				[Address(RVA = "0x17EC59C", Offset = "0x17EC59C", VA = "0x17EC59C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x17EC3FC", Offset = "0x17EC3FC", VA = "0x17EC3FC")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x17EC428", Offset = "0x17EC428", VA = "0x17EC428", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x17EC42C", Offset = "0x17EC42C", VA = "0x17EC42C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x17EC55C", Offset = "0x17EC55C", VA = "0x17EC55C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1472574", Offset = "0x1472574", VA = "0x1472574")]
		private void Start()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1472620", Offset = "0x1472620", VA = "0x1472620")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73B0F4", Offset = "0x73B0F4")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x147268C", Offset = "0x147268C", VA = "0x147268C")]
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
			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x17EC5A4", Offset = "0x17EC5A4", VA = "0x17EC5A4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x17EC850", Offset = "0x17EC850", VA = "0x17EC850")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x17EC93C", Offset = "0x17EC93C", VA = "0x17EC93C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x17ECDD0", Offset = "0x17ECDD0", VA = "0x17ECDD0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x17ECEC4", Offset = "0x17ECEC4", VA = "0x17ECEC4")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x17ECF5C", Offset = "0x17ECF5C", VA = "0x17ECF5C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x17ECFF0", Offset = "0x17ECFF0", VA = "0x17ECFF0")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x17ED084", Offset = "0x17ED084", VA = "0x17ED084")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x17ED204", Offset = "0x17ED204", VA = "0x17ED204")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x147304C", Offset = "0x147304C", VA = "0x147304C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x14730C8", Offset = "0x14730C8", VA = "0x14730C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1473138", Offset = "0x1473138", VA = "0x1473138")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1473200", Offset = "0x1473200", VA = "0x1473200")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73806C", Offset = "0x73806C")]
		public Transform to;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7380A4", Offset = "0x7380A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7380A4", Offset = "0x7380A4")]
		public float transferMotion;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1473208", Offset = "0x1473208", VA = "0x1473208")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1473244", Offset = "0x1473244", VA = "0x1473244")]
		private void Update()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x14732F8", Offset = "0x14732F8", VA = "0x14732F8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7380F8", Offset = "0x7380F8")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1474608", Offset = "0x1474608", VA = "0x1474608")]
		private void Start()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x14747F8", Offset = "0x14747F8", VA = "0x14747F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x14749E8", Offset = "0x14749E8", VA = "0x14749E8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1474AB4", Offset = "0x1474AB4", VA = "0x1474AB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1474BC0", Offset = "0x1474BC0", VA = "0x1474BC0")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1474E5C", Offset = "0x1474E5C", VA = "0x1474E5C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x14751E8", Offset = "0x14751E8", VA = "0x14751E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1475454", Offset = "0x1475454", VA = "0x1475454")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x158C21C", Offset = "0x158C21C", VA = "0x158C21C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x158C544", Offset = "0x158C544", VA = "0x158C544")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x158C5C4", Offset = "0x158C5C4", VA = "0x158C5C4")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7305FC", Offset = "0x7305FC")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000793")]
				[Address(RVA = "0x16ACB84", Offset = "0x16ACB84", VA = "0x16ACB84", Slot = "4")]
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
				[Address(RVA = "0x16ACBCC", Offset = "0x16ACBCC", VA = "0x16ACBCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x16ACA44", Offset = "0x16ACA44", VA = "0x16ACA44")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x16ACA70", Offset = "0x16ACA70", VA = "0x16ACA70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x16ACA74", Offset = "0x16ACA74", VA = "0x16ACA74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x16ACB8C", Offset = "0x16ACB8C", VA = "0x16ACB8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x14E4A18", Offset = "0x14E4A18", VA = "0x14E4A18")]
		private void Start()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x14E4B44", Offset = "0x14E4B44", VA = "0x14E4B44")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x14E4AD8", Offset = "0x14E4AD8", VA = "0x14E4AD8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73B1A4", Offset = "0x73B1A4")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x14E4CC8", Offset = "0x14E4CC8", VA = "0x14E4CC8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x14E4DB4", Offset = "0x14E4DB4", VA = "0x14E4DB4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x14E4E9C", Offset = "0x14E4E9C", VA = "0x14E4E9C")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738130", Offset = "0x738130")]
		public float weight;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1571F20", Offset = "0x1571F20", VA = "0x1571F20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1571F94", Offset = "0x1571F94", VA = "0x1571F94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x157204C", Offset = "0x157204C", VA = "0x157204C")]
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
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x17ED240", Offset = "0x17ED240", VA = "0x17ED240")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x17ED36C", Offset = "0x17ED36C", VA = "0x17ED36C")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x14736E0", Offset = "0x14736E0", VA = "0x14736E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x147375C", Offset = "0x147375C", VA = "0x147375C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x16317BC", Offset = "0x16317BC", VA = "0x16317BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1631914", Offset = "0x1631914", VA = "0x1631914")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1631AF8", Offset = "0x1631AF8", VA = "0x1631AF8")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738148", Offset = "0x738148")]
		public VRIK ik;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x738180", Offset = "0x738180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738180", Offset = "0x738180")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7381E0", Offset = "0x7381E0")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738218", Offset = "0x738218")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x738250", Offset = "0x738250")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738250", Offset = "0x738250")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7382B0", Offset = "0x7382B0")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7382E8", Offset = "0x7382E8")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738320", Offset = "0x738320")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x738358", Offset = "0x738358")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738358", Offset = "0x738358")]
		public float scaleMlp;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7383B8", Offset = "0x7383B8")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1476730", Offset = "0x1476730", VA = "0x1476730")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1477610", Offset = "0x1477610", VA = "0x1477610")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7383F0", Offset = "0x7383F0")]
		public VRIK ik;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738428", Offset = "0x738428")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738460", Offset = "0x738460")]
		public Transform headTracker;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738498", Offset = "0x738498")]
		public Transform bodyTracker;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7384D0", Offset = "0x7384D0")]
		public Transform leftHandTracker;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738508", Offset = "0x738508")]
		public Transform rightHandTracker;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738540", Offset = "0x738540")]
		public Transform leftFootTracker;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738578", Offset = "0x738578")]
		public Transform rightFootTracker;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7385B0", Offset = "0x7385B0")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x147767C", Offset = "0x147767C", VA = "0x147767C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1478A14", Offset = "0x1478A14", VA = "0x1478A14")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x147A8D0", Offset = "0x147A8D0", VA = "0x147A8D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x147A92C", Offset = "0x147A92C", VA = "0x147A92C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x147AAB4", Offset = "0x147AAB4", VA = "0x147AAB4")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x147AAE8", Offset = "0x147AAE8", VA = "0x147AAE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x147AF6C", Offset = "0x147AF6C", VA = "0x147AF6C")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000CA")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x157B3B8", Offset = "0x157B3B8", VA = "0x157B3B8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x157B394", Offset = "0x157B394", VA = "0x157B394", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x157B3C0", Offset = "0x157B3C0", VA = "0x157B3C0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x157B424", Offset = "0x157B424", VA = "0x157B424", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x157B5BC", Offset = "0x157B5BC", VA = "0x157B5BC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x157B7E0", Offset = "0x157B7E0", VA = "0x157B7E0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x157B5CC", Offset = "0x157B5CC", VA = "0x157B5CC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x157B7F0", Offset = "0x157B7F0", VA = "0x157B7F0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x157B808", Offset = "0x157B808", VA = "0x157B808", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x157B864", Offset = "0x157B864", VA = "0x157B864", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x157B900", Offset = "0x157B900", VA = "0x157B900")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x157BA18", Offset = "0x157BA18", VA = "0x157BA18")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x738618", Offset = "0x738618")]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007C7")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007C8")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000CB")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x157BACC", Offset = "0x157BACC", VA = "0x157BACC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x157BA30", Offset = "0x157BA30", VA = "0x157BA30", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x157BAB0", Offset = "0x157BAB0", VA = "0x157BAB0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x157BBC4", Offset = "0x157BBC4", VA = "0x157BBC4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x157BFA8", Offset = "0x157BFA8", VA = "0x157BFA8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x157C0B0", Offset = "0x157C0B0", VA = "0x157C0B0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73865C", Offset = "0x73865C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73865C", Offset = "0x73865C")]
		public Transform gravityTarget;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7386BC", Offset = "0x7386BC")]
		public float gravityMultiplier;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007D6")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60007BB")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x157C484", Offset = "0x157C484", VA = "0x157C484")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x157C5B4", Offset = "0x157C5B4", VA = "0x157C5B4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x157C76C", Offset = "0x157C76C", VA = "0x157C76C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x157C91C", Offset = "0x157C91C", VA = "0x157C91C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x157C980", Offset = "0x157C980", VA = "0x157C980")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x157CAA0", Offset = "0x157CAA0", VA = "0x157CAA0")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x157CBC4", Offset = "0x157CBC4", VA = "0x157CBC4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x157CBE8", Offset = "0x157CBE8", VA = "0x157CBE8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x157CC0C", Offset = "0x157CC0C", VA = "0x157CC0C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x157CC6C", Offset = "0x157CC6C", VA = "0x157CC6C")]
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
			[Token(Token = "0x4000814")]
			Directional,
			[Token(Token = "0x4000815")]
			Strafe
		}

		[Token(Token = "0x200011F")]
		public struct AnimState
		{
			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73060C", Offset = "0x73060C")]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x147BF28", Offset = "0x147BF28", VA = "0x147BF28", Slot = "4")]
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
				[Address(RVA = "0x147BF70", Offset = "0x147BF70", VA = "0x147BF70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x147BE04", Offset = "0x147BE04", VA = "0x147BE04")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x147BE30", Offset = "0x147BE30", VA = "0x147BE30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x147BE34", Offset = "0x147BE34", VA = "0x147BE34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x147BF30", Offset = "0x147BF30", VA = "0x147BF30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7386F4", Offset = "0x7386F4")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73872C", Offset = "0x73872C")]
		public MoveMode moveMode;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x738764", Offset = "0x738764")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73879C", Offset = "0x73879C")]
		public bool smoothJump;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7387D4", Offset = "0x7387D4")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73880C", Offset = "0x73880C")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738844", Offset = "0x738844")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000CC")]
		public bool onGround
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x157CF94", Offset = "0x157CF94", VA = "0x157CF94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B254", Offset = "0x73B254")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x157CF9C", Offset = "0x157CF9C", VA = "0x157CF9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B264", Offset = "0x73B264")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x157CFA8", Offset = "0x157CFA8", VA = "0x157CFA8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x157D0E8", Offset = "0x157D0E8", VA = "0x157D0E8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x157D178", Offset = "0x157D178", VA = "0x157D178", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x157D240", Offset = "0x157D240", VA = "0x157D240")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x157DE44", Offset = "0x157DE44", VA = "0x157DE44", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x157E09C", Offset = "0x157E09C", VA = "0x157E09C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x157D738", Offset = "0x157D738", VA = "0x157D738")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x157E178", Offset = "0x157E178", VA = "0x157E178")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x157E620", Offset = "0x157E620", VA = "0x157E620")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x157DECC", Offset = "0x157DECC", VA = "0x157DECC")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x157E6C0", Offset = "0x157E6C0", VA = "0x157E6C0", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x157E9FC", Offset = "0x157E9FC", VA = "0x157E9FC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x157EAEC", Offset = "0x157EAEC", VA = "0x157EAEC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x157EC4C", Offset = "0x157EC4C", VA = "0x157EC4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73B274", Offset = "0x73B274")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x157DA9C", Offset = "0x157DA9C", VA = "0x157DA9C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x157ECDC", Offset = "0x157ECDC", VA = "0x157ECDC")]
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
			[Token(Token = "0x4000831")]
			Smooth,
			[Token(Token = "0x4000832")]
			Linear
		}

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738854", Offset = "0x738854")]
		public CameraController cameraController;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73888C", Offset = "0x73888C")]
		public float accelerationTime;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7388C4", Offset = "0x7388C4")]
		public float turnTime;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7388FC", Offset = "0x7388FC")]
		public bool walkByDefault;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738934", Offset = "0x738934")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73896C", Offset = "0x73896C")]
		public float moveSpeed;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7389A4", Offset = "0x7389A4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000CF")]
		public bool isGrounded
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1471D94", Offset = "0x1471D94", VA = "0x1471D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B324", Offset = "0x73B324")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1471D9C", Offset = "0x1471D9C", VA = "0x1471D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B334", Offset = "0x73B334")]
			private set
			{
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1471DA8", Offset = "0x1471DA8", VA = "0x1471DA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1471E38", Offset = "0x1471E38", VA = "0x1471E38")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x14722F8", Offset = "0x14722F8", VA = "0x14722F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1471E8C", Offset = "0x1471E8C", VA = "0x1471E8C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x147210C", Offset = "0x147210C", VA = "0x147210C")]
		private void Move()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1472334", Offset = "0x1472334", VA = "0x1472334")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x14723D0", Offset = "0x14723D0", VA = "0x14723D0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1472454", Offset = "0x1472454", VA = "0x1472454")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1474BC8", Offset = "0x1474BC8", VA = "0x1474BC8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1474C44", Offset = "0x1474C44", VA = "0x1474C44", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1474E08", Offset = "0x1474E08", VA = "0x1474E08")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1474E30", Offset = "0x1474E30", VA = "0x1474E30")]
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
			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1474C0C", Offset = "0x1474C0C", VA = "0x1474C0C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1474F4C", Offset = "0x1474F4C", VA = "0x1474F4C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1474E4C", Offset = "0x1474E4C", VA = "0x1474E4C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x156E0E4", Offset = "0x156E0E4", VA = "0x156E0E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x156E120", Offset = "0x156E120", VA = "0x156E120")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x147247C", Offset = "0x147247C", VA = "0x147247C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x14724B0", Offset = "0x14724B0", VA = "0x14724B0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1472560", Offset = "0x1472560", VA = "0x1472560")]
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
			[Token(Token = "0x4000854")]
			Idle,
			[Token(Token = "0x4000855")]
			Seeking,
			[Token(Token = "0x4000856")]
			OnPath
		}

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7389B4", Offset = "0x7389B4")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7389EC", Offset = "0x7389EC")]
		public float cornerRadius;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A24", Offset = "0x738A24")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A5C", Offset = "0x738A5C")]
		public float maxSampleDistance;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x738A94", Offset = "0x738A94")]
		public float nextPathInterval;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738ACC", Offset = "0x738ACC")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x738ADC", Offset = "0x738ADC")]
		private State <state>k__BackingField;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000D0")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x14E1B50", Offset = "0x14E1B50", VA = "0x14E1B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B344", Offset = "0x73B344")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x14E1B5C", Offset = "0x14E1B5C", VA = "0x14E1B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B354", Offset = "0x73B354")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public State state
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x14E1B68", Offset = "0x14E1B68", VA = "0x14E1B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B364", Offset = "0x73B364")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x14E1B70", Offset = "0x14E1B70", VA = "0x14E1B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73B374", Offset = "0x73B374")]
			private set
			{
			}
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x14E1B78", Offset = "0x14E1B78", VA = "0x14E1B78")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x14E1C28", Offset = "0x14E1C28", VA = "0x14E1C28")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x14E2014", Offset = "0x14E2014", VA = "0x14E2014")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x14E2090", Offset = "0x14E2090", VA = "0x14E2090")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x14E1FD0", Offset = "0x14E1FD0", VA = "0x14E1FD0")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x14E2000", Offset = "0x14E2000", VA = "0x14E2000")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x14E21DC", Offset = "0x14E21DC", VA = "0x14E21DC")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x14E238C", Offset = "0x14E238C", VA = "0x14E238C")]
		public Navigator()
		{
		}
	}
}
