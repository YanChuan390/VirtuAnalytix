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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978620", Offset = "0x978620")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978620", Offset = "0x978620")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9790E4", Offset = "0x9790E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9790E4", Offset = "0x9790E4")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97913C", Offset = "0x97913C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97913C", Offset = "0x97913C")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979194", Offset = "0x979194")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9791CC", Offset = "0x9791CC")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979204", Offset = "0x979204")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97923C", Offset = "0x97923C")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979274", Offset = "0x979274")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9792AC", Offset = "0x9792AC")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9792E4", Offset = "0x9792E4")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97931C", Offset = "0x97931C")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97932C", Offset = "0x97932C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97935C", Offset = "0x97935C")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1FB3D48", Offset = "0x1FB3D48", VA = "0x1FB3D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9813E4", Offset = "0x9813E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1FB3D50", Offset = "0x1FB3D50", VA = "0x1FB3D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9813F4", Offset = "0x9813F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1FB3D5C", Offset = "0x1FB3D5C", VA = "0x1FB3D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981404", Offset = "0x981404")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1FB3D64", Offset = "0x1FB3D64", VA = "0x1FB3D64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981414", Offset = "0x981414")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1FB3D6C", Offset = "0x1FB3D6C", VA = "0x1FB3D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981424", Offset = "0x981424")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1FB3D74", Offset = "0x1FB3D74", VA = "0x1FB3D74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981434", Offset = "0x981434")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1FB3C28", Offset = "0x1FB3C28", VA = "0x1FB3C28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981304", Offset = "0x981304")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1FB3C70", Offset = "0x1FB3C70", VA = "0x1FB3C70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98133C", Offset = "0x98133C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1FB3CB8", Offset = "0x1FB3CB8", VA = "0x1FB3CB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981374", Offset = "0x981374")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1FB3D00", Offset = "0x1FB3D00", VA = "0x1FB3D00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9813AC", Offset = "0x9813AC")]
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
		[Address(RVA = "0x1FB3D7C", Offset = "0x1FB3D7C", VA = "0x1FB3D7C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1FB3D80", Offset = "0x1FB3D80", VA = "0x1FB3D80")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1FB3D84", Offset = "0x1FB3D84", VA = "0x1FB3D84")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1FB3D88", Offset = "0x1FB3D88", VA = "0x1FB3D88")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97936C", Offset = "0x97936C")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9793A4", Offset = "0x9793A4")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9793DC", Offset = "0x9793DC")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979414", Offset = "0x979414")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97944C", Offset = "0x97944C")]
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
		[Address(RVA = "0x1FF2FD8", Offset = "0x1FF2FD8", VA = "0x1FF2FD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1FF33DC", Offset = "0x1FF33DC", VA = "0x1FF33DC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1FF33E4", Offset = "0x1FF33E4", VA = "0x1FF33E4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1FF34F4", Offset = "0x1FF34F4", VA = "0x1FF34F4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1FF3570", Offset = "0x1FF3570", VA = "0x1FF3570", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1FF35EC", Offset = "0x1FF35EC", VA = "0x1FF35EC", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1FF3234", Offset = "0x1FF3234", VA = "0x1FF3234")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1FF3308", Offset = "0x1FF3308", VA = "0x1FF3308")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1FF3668", Offset = "0x1FF3668", VA = "0x1FF3668")]
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
		[Address(RVA = "0x1D1704C", Offset = "0x1D1704C", VA = "0x1D1704C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1FB2FFC", Offset = "0x1FB2FFC", VA = "0x1FB2FFC")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1FB3264", Offset = "0x1FB3264", VA = "0x1FB3264")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1FB3244", Offset = "0x1FB3244", VA = "0x1FB3244")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1FB3828", Offset = "0x1FB3828", VA = "0x1FB3828")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1FB513C", Offset = "0x1FB513C", VA = "0x1FB513C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1FB6A6C", Offset = "0x1FB6A6C", VA = "0x1FB6A6C")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1FB4B90", Offset = "0x1FB4B90", VA = "0x1FB4B90")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1FB5184", Offset = "0x1FB5184", VA = "0x1FB5184")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1FB46C0", Offset = "0x1FB46C0", VA = "0x1FB46C0")]
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
		[Address(RVA = "0x1FB3EA4", Offset = "0x1FB3EA4", VA = "0x1FB3EA4")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1FB41B8", Offset = "0x1FB41B8", VA = "0x1FB41B8")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1FB405C", Offset = "0x1FB405C", VA = "0x1FB405C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1FB4394", Offset = "0x1FB4394", VA = "0x1FB4394")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1FB4924", Offset = "0x1FB4924", VA = "0x1FB4924")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1FB4A20", Offset = "0x1FB4A20", VA = "0x1FB4A20")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1FB4B1C", Offset = "0x1FB4B1C", VA = "0x1FB4B1C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1FB4A94", Offset = "0x1FB4A94", VA = "0x1FB4A94")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1FB4D88", Offset = "0x1FB4D88", VA = "0x1FB4D88")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1FB4E3C", Offset = "0x1FB4E3C", VA = "0x1FB4E3C")]
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
		[Address(RVA = "0x1FB5188", Offset = "0x1FB5188", VA = "0x1FB5188")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1FB5204", Offset = "0x1FB5204", VA = "0x1FB5204")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1FB5CA0", Offset = "0x1FB5CA0", VA = "0x1FB5CA0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1FB5D54", Offset = "0x1FB5D54", VA = "0x1FB5D54")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1FB5C3C", Offset = "0x1FB5C3C", VA = "0x1FB5C3C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1FB5E4C", Offset = "0x1FB5E4C", VA = "0x1FB5E4C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1FB5E94", Offset = "0x1FB5E94", VA = "0x1FB5E94")]
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
		[Address(RVA = "0x1FB5E9C", Offset = "0x1FB5E9C", VA = "0x1FB5E9C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1FB608C", Offset = "0x1FB608C", VA = "0x1FB608C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1FB60A0", Offset = "0x1FB60A0", VA = "0x1FB60A0")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1FB638C", Offset = "0x1FB638C", VA = "0x1FB638C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1FB5F48", Offset = "0x1FB5F48", VA = "0x1FB5F48")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1FB6640", Offset = "0x1FB6640", VA = "0x1FB6640")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1FB66B4", Offset = "0x1FB66B4", VA = "0x1FB66B4")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1FB6868", Offset = "0x1FB6868", VA = "0x1FB6868")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979484", Offset = "0x979484")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9794BC", Offset = "0x9794BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9794BC", Offset = "0x9794BC")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979514", Offset = "0x979514")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979514", Offset = "0x979514")]
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
		[Address(RVA = "0x2043A00", Offset = "0x2043A00", VA = "0x2043A00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2043F94", Offset = "0x2043F94", VA = "0x2043F94", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2043FB0", Offset = "0x2043FB0", VA = "0x2043FB0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x204408C", Offset = "0x204408C", VA = "0x204408C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2044168", Offset = "0x2044168", VA = "0x2044168", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2044338", Offset = "0x2044338", VA = "0x2044338", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2044670", Offset = "0x2044670", VA = "0x2044670")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x204474C", Offset = "0x204474C", VA = "0x204474C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x979568", Offset = "0x979568")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9795A0", Offset = "0x9795A0")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9795D8", Offset = "0x9795D8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x979610", Offset = "0x979610")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979648", Offset = "0x979648")]
		public float blockedOffset;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979660", Offset = "0x979660")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979670", Offset = "0x979670")]
		private float <y>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979680", Offset = "0x979680")]
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
			[Address(RVA = "0x1FC0348", Offset = "0x1FC0348", VA = "0x1FC0348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981444", Offset = "0x981444")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1FC0350", Offset = "0x1FC0350", VA = "0x1FC0350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981454", Offset = "0x981454")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1FC0358", Offset = "0x1FC0358", VA = "0x1FC0358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981464", Offset = "0x981464")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1FC0360", Offset = "0x1FC0360", VA = "0x1FC0360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981474", Offset = "0x981474")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1FC0368", Offset = "0x1FC0368", VA = "0x1FC0368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981484", Offset = "0x981484")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1FC0370", Offset = "0x1FC0370", VA = "0x1FC0370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981494", Offset = "0x981494")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1FC0C58", Offset = "0x1FC0C58", VA = "0x1FC0C58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1FC0378", Offset = "0x1FC0378", VA = "0x1FC0378")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1FC03B4", Offset = "0x1FC03B4", VA = "0x1FC03B4")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1FC03BC", Offset = "0x1FC03BC", VA = "0x1FC03BC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1FC04CC", Offset = "0x1FC04CC", VA = "0x1FC04CC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1FC0528", Offset = "0x1FC0528", VA = "0x1FC0528", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1FC0590", Offset = "0x1FC0590", VA = "0x1FC0590", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1FC05F4", Offset = "0x1FC05F4", VA = "0x1FC05F4")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1FC0500", Offset = "0x1FC0500", VA = "0x1FC0500")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1FC0774", Offset = "0x1FC0774", VA = "0x1FC0774")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1FC0C28", Offset = "0x1FC0C28", VA = "0x1FC0C28")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1FC0CC8", Offset = "0x1FC0CC8", VA = "0x1FC0CC8")]
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
		[Address(RVA = "0x1FC0D74", Offset = "0x1FC0D74", VA = "0x1FC0D74")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1FC0DAC", Offset = "0x1FC0DAC", VA = "0x1FC0DAC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1FC0F54", Offset = "0x1FC0F54", VA = "0x1FC0F54")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1FC0F84", Offset = "0x1FC0F84", VA = "0x1FC0F84")]
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
		[Address(RVA = "0x1FB3830", Offset = "0x1FB3830", VA = "0x1FB3830")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1FB3854", Offset = "0x1FB3854", VA = "0x1FB3854")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1FB388C", Offset = "0x1FB388C", VA = "0x1FB388C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1FB397C", Offset = "0x1FB397C", VA = "0x1FB397C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1FB3924", Offset = "0x1FB3924", VA = "0x1FB3924")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1FB3A14", Offset = "0x1FB3A14", VA = "0x1FB3A14")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1FB3A5C", Offset = "0x1FB3A5C", VA = "0x1FB3A5C")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1FB3C20", Offset = "0x1FB3C20", VA = "0x1FB3C20")]
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
			[Address(RVA = "0x1D201A0", Offset = "0x1D201A0", VA = "0x1D201A0")]
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
			[Address(RVA = "0x1FB8684", Offset = "0x1FB8684", VA = "0x1FB8684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1FB88F4", Offset = "0x1FB88F4", VA = "0x1FB88F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1FB8604", Offset = "0x1FB8604", VA = "0x1FB8604")]
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
		[Address(RVA = "0x1FB8B64", Offset = "0x1FB8B64", VA = "0x1FB8B64")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1FB8E88", Offset = "0x1FB8E88", VA = "0x1FB8E88")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1FB90FC", Offset = "0x1FB90FC", VA = "0x1FB90FC")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1FB917C", Offset = "0x1FB917C", VA = "0x1FB917C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1FB9224", Offset = "0x1FB9224", VA = "0x1FB9224")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1FB8D3C", Offset = "0x1FB8D3C", VA = "0x1FB8D3C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1FB9060", Offset = "0x1FB9060", VA = "0x1FB9060")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1FB9A54", Offset = "0x1FB9A54", VA = "0x1FB9A54")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1FB985C", Offset = "0x1FB985C", VA = "0x1FB985C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1FB9958", Offset = "0x1FB9958", VA = "0x1FB9958")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1FB943C", Offset = "0x1FB943C", VA = "0x1FB943C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1FB94EC", Offset = "0x1FB94EC", VA = "0x1FB94EC")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1FB959C", Offset = "0x1FB959C", VA = "0x1FB959C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1FB964C", Offset = "0x1FB964C", VA = "0x1FB964C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1FB96FC", Offset = "0x1FB96FC", VA = "0x1FB96FC")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1FB97AC", Offset = "0x1FB97AC", VA = "0x1FB97AC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1FB9C5C", Offset = "0x1FB9C5C", VA = "0x1FB9C5C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1FB9354", Offset = "0x1FB9354", VA = "0x1FB9354")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1FB9BCC", Offset = "0x1FB9BCC", VA = "0x1FB9BCC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1FB9CC8", Offset = "0x1FB9CC8", VA = "0x1FB9CC8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1FB9D9C", Offset = "0x1FB9D9C", VA = "0x1FB9D9C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1FB9B54", Offset = "0x1FB9B54", VA = "0x1FB9B54")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1FB9AE0", Offset = "0x1FB9AE0", VA = "0x1FB9AE0")]
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
				[Address(RVA = "0x1D2022C", Offset = "0x1D2022C", VA = "0x1D2022C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1D20218", Offset = "0x1D20218", VA = "0x1D20218")]
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
			[Address(RVA = "0x1FBC604", Offset = "0x1FBC604", VA = "0x1FBC604", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1FBC9EC", Offset = "0x1FBC9EC", VA = "0x1FBC9EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1FBC9FC", Offset = "0x1FBC9FC", VA = "0x1FBC9FC", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1FBCE24", Offset = "0x1FBCE24", VA = "0x1FBCE24", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1FBD258", Offset = "0x1FBD258", VA = "0x1FBD258")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1FBD928", Offset = "0x1FBD928", VA = "0x1FBD928")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1FBD484", Offset = "0x1FBD484", VA = "0x1FBD484")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1FB78D8", Offset = "0x1FB78D8", VA = "0x1FB78D8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1FBE1AC", Offset = "0x1FBE1AC", VA = "0x1FBE1AC")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1FBE768", Offset = "0x1FBE768", VA = "0x1FBE768")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1FBE548", Offset = "0x1FBE548", VA = "0x1FBE548")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1FBE3C4", Offset = "0x1FBE3C4", VA = "0x1FBE3C4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1FBE24C", Offset = "0x1FBE24C", VA = "0x1FBE24C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1FBE654", Offset = "0x1FBE654", VA = "0x1FBE654")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1FBE860", Offset = "0x1FBE860", VA = "0x1FBE860")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1FBF448", Offset = "0x1FBF448", VA = "0x1FBF448")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1FBEEB8", Offset = "0x1FBEEB8", VA = "0x1FBEEB8")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1FBF744", Offset = "0x1FBF744", VA = "0x1FBF744")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1FBF230", Offset = "0x1FBF230", VA = "0x1FBF230")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1FBF74C", Offset = "0x1FBF74C", VA = "0x1FBF74C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1FBF754", Offset = "0x1FBF754", VA = "0x1FBF754")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1FBF928", Offset = "0x1FBF928", VA = "0x1FBF928")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1FBFAF0", Offset = "0x1FBFAF0", VA = "0x1FBFAF0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1FB7D58", Offset = "0x1FB7D58", VA = "0x1FB7D58")]
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
		[Address(RVA = "0x1FE72E0", Offset = "0x1FE72E0", VA = "0x1FE72E0")]
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
		[Address(RVA = "0x1FE7B90", Offset = "0x1FE7B90", VA = "0x1FE7B90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1FE7CD8", Offset = "0x1FE7CD8", VA = "0x1FE7CD8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x20418CC", Offset = "0x20418CC", VA = "0x20418CC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2041AB8", Offset = "0x2041AB8", VA = "0x2041AB8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2041964", Offset = "0x2041964", VA = "0x2041964")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2041BD8", Offset = "0x2041BD8", VA = "0x2041BD8")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2041D04", Offset = "0x2041D04", VA = "0x2041D04")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2041F58", Offset = "0x2041F58", VA = "0x2041F58")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2042060", Offset = "0x2042060", VA = "0x2042060")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x20421D4", Offset = "0x20421D4", VA = "0x20421D4")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x20425B0", Offset = "0x20425B0", VA = "0x20425B0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2042374", Offset = "0x2042374", VA = "0x2042374")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2042764", Offset = "0x2042764", VA = "0x2042764")]
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
		[Address(RVA = "0x206F3BC", Offset = "0x206F3BC", VA = "0x206F3BC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x206F448", Offset = "0x206F448", VA = "0x206F448")]
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
		[Address(RVA = "0x1E052B8", Offset = "0x1E052B8", VA = "0x1E052B8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1E05C64", Offset = "0x1E05C64", VA = "0x1E05C64")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1E05CD8", Offset = "0x1E05CD8", VA = "0x1E05CD8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1E056CC", Offset = "0x1E056CC", VA = "0x1E056CC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1E056D8", Offset = "0x1E056D8", VA = "0x1E056D8")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1E056FC", Offset = "0x1E056FC", VA = "0x1E056FC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1E05738", Offset = "0x1E05738", VA = "0x1E05738")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1E05750", Offset = "0x1E05750", VA = "0x1E05750")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1E05764", Offset = "0x1E05764", VA = "0x1E05764")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E05778", Offset = "0x1E05778", VA = "0x1E05778")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E05788", Offset = "0x1E05788", VA = "0x1E05788")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1E057D0", Offset = "0x1E057D0", VA = "0x1E057D0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1E05808", Offset = "0x1E05808", VA = "0x1E05808")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1E05830", Offset = "0x1E05830", VA = "0x1E05830")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1E05D64", Offset = "0x1E05D64", VA = "0x1E05D64")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1E05864", Offset = "0x1E05864", VA = "0x1E05864")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1E0588C", Offset = "0x1E0588C", VA = "0x1E0588C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1E058BC", Offset = "0x1E058BC", VA = "0x1E058BC")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1E058F0", Offset = "0x1E058F0", VA = "0x1E058F0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1E05934", Offset = "0x1E05934", VA = "0x1E05934")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1E05998", Offset = "0x1E05998", VA = "0x1E05998")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1E059FC", Offset = "0x1E059FC", VA = "0x1E059FC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1E05A50", Offset = "0x1E05A50", VA = "0x1E05A50")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1E05AA4", Offset = "0x1E05AA4", VA = "0x1E05AA4")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1E05AE0", Offset = "0x1E05AE0", VA = "0x1E05AE0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1E05B18", Offset = "0x1E05B18", VA = "0x1E05B18")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1E05D98", Offset = "0x1E05D98", VA = "0x1E05D98")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1E05B60", Offset = "0x1E05B60", VA = "0x1E05B60")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1E05BF4", Offset = "0x1E05BF4", VA = "0x1E05BF4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1E05C24", Offset = "0x1E05C24", VA = "0x1E05C24")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1E05E2C", Offset = "0x1E05E2C", VA = "0x1E05E2C")]
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
		[Address(RVA = "0x1E05EE8", Offset = "0x1E05EE8", VA = "0x1E05EE8")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1E05F74", Offset = "0x1E05F74", VA = "0x1E05F74")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1E06004", Offset = "0x1E06004", VA = "0x1E06004")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1E0605C", Offset = "0x1E0605C", VA = "0x1E0605C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1E06128", Offset = "0x1E06128", VA = "0x1E06128")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1E06074", Offset = "0x1E06074", VA = "0x1E06074")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1E06140", Offset = "0x1E06140", VA = "0x1E06140")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1E061E4", Offset = "0x1E061E4", VA = "0x1E061E4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1E06210", Offset = "0x1E06210", VA = "0x1E06210")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1E06260", Offset = "0x1E06260", VA = "0x1E06260")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1E062CC", Offset = "0x1E062CC", VA = "0x1E062CC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1E063E0", Offset = "0x1E063E0", VA = "0x1E063E0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1E064D8", Offset = "0x1E064D8", VA = "0x1E064D8")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1E06534", Offset = "0x1E06534", VA = "0x1E06534")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1E0CDAC", Offset = "0x1E0CDAC", VA = "0x1E0CDAC")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1E0CE08", Offset = "0x1E0CE08", VA = "0x1E0CE08")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1E0CE98", Offset = "0x1E0CE98", VA = "0x1E0CE98")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1E0CFF8", Offset = "0x1E0CFF8", VA = "0x1E0CFF8")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1E0D0B4", Offset = "0x1E0D0B4", VA = "0x1E0D0B4")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1E0D170", Offset = "0x1E0D170", VA = "0x1E0D170")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1E0D31C", Offset = "0x1E0D31C", VA = "0x1E0D31C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1E0D36C", Offset = "0x1E0D36C", VA = "0x1E0D36C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1E0D3BC", Offset = "0x1E0D3BC", VA = "0x1E0D3BC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1E0D464", Offset = "0x1E0D464", VA = "0x1E0D464")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1E04EE8", Offset = "0x1E04EE8", VA = "0x1E04EE8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1E0D50C", Offset = "0x1E0D50C", VA = "0x1E0D50C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1E04FC8", Offset = "0x1E04FC8", VA = "0x1E04FC8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1E0C5C4", Offset = "0x1E0C5C4", VA = "0x1E0C5C4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1E0D560", Offset = "0x1E0D560", VA = "0x1E0D560")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1E0D6F0", Offset = "0x1E0D6F0", VA = "0x1E0D6F0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1E0D7E4", Offset = "0x1E0D7E4", VA = "0x1E0D7E4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1E0D8F0", Offset = "0x1E0D8F0", VA = "0x1E0D8F0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1E0D9DC", Offset = "0x1E0D9DC", VA = "0x1E0D9DC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9796A0", Offset = "0x9796A0")]
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
			[Address(RVA = "0x1D16B38", Offset = "0x1D16B38", VA = "0x1D16B38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1D16E84", Offset = "0x1D16E84", VA = "0x1D16E84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1D169F8", Offset = "0x1D169F8", VA = "0x1D169F8")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1D16A98", Offset = "0x1D16A98", VA = "0x1D16A98", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1D16A9C", Offset = "0x1D16A9C", VA = "0x1D16A9C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1D16AA0", Offset = "0x1D16AA0", VA = "0x1D16AA0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1D16AA4", Offset = "0x1D16AA4", VA = "0x1D16AA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1D16B34", Offset = "0x1D16B34", VA = "0x1D16B34")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1D16ADC", Offset = "0x1D16ADC", VA = "0x1D16ADC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1D16E38", Offset = "0x1D16E38", VA = "0x1D16E38")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1D16C24", Offset = "0x1D16C24", VA = "0x1D16C24")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1D16F3C", Offset = "0x1D16F3C", VA = "0x1D16F3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1D16F98", Offset = "0x1D16F98", VA = "0x1D16F98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1D16FF4", Offset = "0x1D16FF4", VA = "0x1D16FF4")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1D1703C", Offset = "0x1D1703C", VA = "0x1D1703C")]
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
		[Address(RVA = "0x1D176B0", Offset = "0x1D176B0", VA = "0x1D176B0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1D17770", Offset = "0x1D17770", VA = "0x1D17770")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1D17830", Offset = "0x1D17830", VA = "0x1D17830")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1D178F0", Offset = "0x1D178F0", VA = "0x1D178F0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V2Tools
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1D1985C", Offset = "0x1D1985C", VA = "0x1D1985C")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1D19864", Offset = "0x1D19864", VA = "0x1D19864")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1D198B4", Offset = "0x1D198B4", VA = "0x1D198B4")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1D19908", Offset = "0x1D19908", VA = "0x1D19908")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1D199E0", Offset = "0x1D199E0", VA = "0x1D199E0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1D19A74", Offset = "0x1D19A74", VA = "0x1D19A74")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1D19A98", Offset = "0x1D19A98", VA = "0x1D19A98")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1D19AE0", Offset = "0x1D19AE0", VA = "0x1D19AE0")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1D19B6C", Offset = "0x1D19B6C", VA = "0x1D19B6C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1D19BCC", Offset = "0x1D19BCC", VA = "0x1D19BCC")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1D19C2C", Offset = "0x1D19C2C", VA = "0x1D19C2C")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1D19D48", Offset = "0x1D19D48", VA = "0x1D19D48")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1D19DE8", Offset = "0x1D19DE8", VA = "0x1D19DE8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1D19E24", Offset = "0x1D19E24", VA = "0x1D19E24")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1D19E68", Offset = "0x1D19E68", VA = "0x1D19E68")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1D19F04", Offset = "0x1D19F04", VA = "0x1D19F04")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1D1A060", Offset = "0x1D1A060", VA = "0x1D1A060")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1D1A1DC", Offset = "0x1D1A1DC", VA = "0x1D1A1DC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1D1A360", Offset = "0x1D1A360", VA = "0x1D1A360")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1D1A41C", Offset = "0x1D1A41C", VA = "0x1D1A41C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1D1A51C", Offset = "0x1D1A51C", VA = "0x1D1A51C")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1D1A5A4", Offset = "0x1D1A5A4", VA = "0x1D1A5A4")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1D1A640", Offset = "0x1D1A640", VA = "0x1D1A640")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1D1A6E4", Offset = "0x1D1A6E4", VA = "0x1D1A6E4")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1D1A6D4", Offset = "0x1D1A6D4", VA = "0x1D1A6D4")]
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
		[Address(RVA = "0x1D1FA00", Offset = "0x1D1FA00", VA = "0x1D1FA00")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1D1FA98", Offset = "0x1D1FA98", VA = "0x1D1FA98")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978690", Offset = "0x978690")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978690", Offset = "0x978690")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1FB6F78", Offset = "0x1FB6F78", VA = "0x1FB6F78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981514", Offset = "0x981514")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1FB6FC0", Offset = "0x1FB6FC0", VA = "0x1FB6FC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98154C", Offset = "0x98154C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1FB7008", Offset = "0x1FB7008", VA = "0x1FB7008")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981584", Offset = "0x981584")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1FB7050", Offset = "0x1FB7050", VA = "0x1FB7050")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9815BC", Offset = "0x9815BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1FB7098", Offset = "0x1FB7098", VA = "0x1FB7098")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1FB7134", Offset = "0x1FB7134", VA = "0x1FB7134")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1FB7154", Offset = "0x1FB7154", VA = "0x1FB7154")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1FB7184", Offset = "0x1FB7184", VA = "0x1FB7184")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1FB71B4", Offset = "0x1FB71B4", VA = "0x1FB71B4")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1FB71F4", Offset = "0x1FB71F4", VA = "0x1FB71F4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1FB7238", Offset = "0x1FB7238", VA = "0x1FB7238")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1FB725C", Offset = "0x1FB725C", VA = "0x1FB725C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1FB7280", Offset = "0x1FB7280", VA = "0x1FB7280")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1FB72A8", Offset = "0x1FB72A8", VA = "0x1FB72A8")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1FB72D4", Offset = "0x1FB72D4", VA = "0x1FB72D4")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1FB7300", Offset = "0x1FB7300", VA = "0x1FB7300")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1FB70B8", Offset = "0x1FB70B8", VA = "0x1FB70B8")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1FB7328", Offset = "0x1FB7328", VA = "0x1FB7328")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1FB7334", Offset = "0x1FB7334", VA = "0x1FB7334")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1FB7340", Offset = "0x1FB7340", VA = "0x1FB7340")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1FB7664", Offset = "0x1FB7664", VA = "0x1FB7664", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1FB770C", Offset = "0x1FB770C", VA = "0x1FB770C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1FB7AF8", Offset = "0x1FB7AF8", VA = "0x1FB7AF8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1FB7C84", Offset = "0x1FB7C84", VA = "0x1FB7C84")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1FB7CB8", Offset = "0x1FB7CB8", VA = "0x1FB7CB8")]
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
			[Address(RVA = "0x1FB74E0", Offset = "0x1FB74E0", VA = "0x1FB74E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1FB7FB0", Offset = "0x1FB7FB0", VA = "0x1FB7FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1FB79D4", Offset = "0x1FB79D4", VA = "0x1FB79D4")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1FB7DDC", Offset = "0x1FB7DDC", VA = "0x1FB7DDC")]
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
			[Address(RVA = "0x1FE72E8", Offset = "0x1FE72E8", VA = "0x1FE72E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1FE7354", Offset = "0x1FE7354", VA = "0x1FE7354")]
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
		[Address(RVA = "0x1FE735C", Offset = "0x1FE735C", VA = "0x1FE735C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1FE741C", Offset = "0x1FE741C", VA = "0x1FE741C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1FE7424", Offset = "0x1FE7424", VA = "0x1FE7424")]
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
			[Address(RVA = "0x1FE7560", Offset = "0x1FE7560", VA = "0x1FE7560")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1FE7458", Offset = "0x1FE7458", VA = "0x1FE7458", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1FE759C", Offset = "0x1FE759C", VA = "0x1FE759C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1FE75A4", Offset = "0x1FE75A4", VA = "0x1FE75A4")]
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
		[Address(RVA = "0x1FE75D8", Offset = "0x1FE75D8", VA = "0x1FE75D8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1FE7658", Offset = "0x1FE7658", VA = "0x1FE7658")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1FE7660", Offset = "0x1FE7660", VA = "0x1FE7660")]
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
			[Address(RVA = "0x1FE779C", Offset = "0x1FE779C", VA = "0x1FE779C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1FE7694", Offset = "0x1FE7694", VA = "0x1FE7694", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1FE77D8", Offset = "0x1FE77D8", VA = "0x1FE77D8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1FE77E0", Offset = "0x1FE77E0", VA = "0x1FE77E0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9796D8", Offset = "0x9796D8")]
		public float positionWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9796F0", Offset = "0x9796F0")]
		public float rotationWeight;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1FE7814", Offset = "0x1FE7814", VA = "0x1FE7814")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1FE7880", Offset = "0x1FE7880", VA = "0x1FE7880")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1FE78D8", Offset = "0x1FE78D8", VA = "0x1FE78D8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1FE7B88", Offset = "0x1FE7B88", VA = "0x1FE7B88")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979708", Offset = "0x979708")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979708", Offset = "0x979708")]
		public float weight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97975C", Offset = "0x97975C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97975C", Offset = "0x97975C")]
		public float rotationWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9797B0", Offset = "0x9797B0")]
		public DOF rotationDOF;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9797E8", Offset = "0x9797E8")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979820", Offset = "0x979820")]
		public Transform bone1;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979858", Offset = "0x979858")]
		public Transform bone2;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979890", Offset = "0x979890")]
		public Transform bone3;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9798C8", Offset = "0x9798C8")]
		public Transform tip;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979900", Offset = "0x979900")]
		public Transform target;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979938", Offset = "0x979938")]
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
			[Address(RVA = "0x1FF101C", Offset = "0x1FF101C", VA = "0x1FF101C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9815F4", Offset = "0x9815F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1FF1024", Offset = "0x1FF1024", VA = "0x1FF1024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981604", Offset = "0x981604")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1FF1030", Offset = "0x1FF1030", VA = "0x1FF1030")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1FF1050", Offset = "0x1FF1050", VA = "0x1FF1050")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1FF1070", Offset = "0x1FF1070", VA = "0x1FF1070")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1FF1090", Offset = "0x1FF1090", VA = "0x1FF1090")]
			set
			{
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1FF10B0", Offset = "0x1FF10B0", VA = "0x1FF10B0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1FF11C4", Offset = "0x1FF11C4", VA = "0x1FF11C4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1FF1754", Offset = "0x1FF1754", VA = "0x1FF1754")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1FF182C", Offset = "0x1FF182C", VA = "0x1FF182C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1FF18F0", Offset = "0x1FF18F0", VA = "0x1FF18F0")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1FF1D78", Offset = "0x1FF1D78", VA = "0x1FF1D78")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979948", Offset = "0x979948")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979948", Offset = "0x979948")]
		public float weight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97999C", Offset = "0x97999C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1FF1D88", Offset = "0x1FF1D88", VA = "0x1FF1D88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981614", Offset = "0x981614")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1FF1D90", Offset = "0x1FF1D90", VA = "0x1FF1D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981624", Offset = "0x981624")]
			private set
			{
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1FF1D9C", Offset = "0x1FF1D9C", VA = "0x1FF1D9C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1FF1E24", Offset = "0x1FF1E24", VA = "0x1FF1E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981634", Offset = "0x981634")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1FF21B0", Offset = "0x1FF21B0", VA = "0x1FF21B0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1FF2374", Offset = "0x1FF2374", VA = "0x1FF2374")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1FF20AC", Offset = "0x1FF20AC", VA = "0x1FF20AC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1FF2500", Offset = "0x1FF2500", VA = "0x1FF2500", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1FF25C0", Offset = "0x1FF25C0", VA = "0x1FF25C0")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1FF2638", Offset = "0x1FF2638", VA = "0x1FF2638")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1FF26AC", Offset = "0x1FF26AC", VA = "0x1FF26AC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1FF2714", Offset = "0x1FF2714", VA = "0x1FF2714", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1FF2718", Offset = "0x1FF2718", VA = "0x1FF2718", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1FF272C", Offset = "0x1FF272C", VA = "0x1FF272C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9799AC", Offset = "0x9799AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9799AC", Offset = "0x9799AC")]
		public float weight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979A00", Offset = "0x979A00")]
		public Grounding solver;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979A38", Offset = "0x979A38")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1FF3BE8", Offset = "0x1FF3BE8", VA = "0x1FF3BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98166C", Offset = "0x98166C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1FF3BF0", Offset = "0x1FF3BF0", VA = "0x1FF3BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98167C", Offset = "0x98167C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600016E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1FF3BFC", Offset = "0x1FF3BFC", VA = "0x1FF3BFC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1FF3DA8", Offset = "0x1FF3DA8", VA = "0x1FF3DA8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1FF3CA8", Offset = "0x1FF3CA8", VA = "0x1FF3CA8")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1FF3DDC", Offset = "0x1FF3DDC", VA = "0x1FF3DDC")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000175")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000176")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1FF3F18", Offset = "0x1FF3F18", VA = "0x1FF3F18")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9786F0", Offset = "0x9786F0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9786F0", Offset = "0x9786F0")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979A48", Offset = "0x979A48")]
		public BipedIK ik;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979A80", Offset = "0x979A80")]
		public float spineBend;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979AB8", Offset = "0x979AB8")]
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
		[Address(RVA = "0x1FF3F90", Offset = "0x1FF3F90", VA = "0x1FF3F90", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98168C", Offset = "0x98168C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1FF3FD8", Offset = "0x1FF3FD8", VA = "0x1FF3FD8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9816C4", Offset = "0x9816C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1FF4020", Offset = "0x1FF4020", VA = "0x1FF4020", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1FF4060", Offset = "0x1FF4060", VA = "0x1FF4060")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1FF410C", Offset = "0x1FF410C", VA = "0x1FF410C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1FF416C", Offset = "0x1FF416C", VA = "0x1FF416C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1FF448C", Offset = "0x1FF448C", VA = "0x1FF448C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1FF44E0", Offset = "0x1FF44E0", VA = "0x1FF44E0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1FF48FC", Offset = "0x1FF48FC", VA = "0x1FF48FC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1FF49D0", Offset = "0x1FF49D0", VA = "0x1FF49D0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1FF4B10", Offset = "0x1FF4B10", VA = "0x1FF4B10")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1FF4CD4", Offset = "0x1FF4CD4", VA = "0x1FF4CD4")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978750", Offset = "0x978750")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978750", Offset = "0x978750")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class SpineEffector
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979B98", Offset = "0x979B98")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979BD0", Offset = "0x979BD0")]
			public float horizontalWeight;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979C08", Offset = "0x979C08")]
			public float verticalWeight;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1D21038", Offset = "0x1D21038", VA = "0x1D21038")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1D21048", Offset = "0x1D21048", VA = "0x1D21048")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979AF0", Offset = "0x979AF0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979B28", Offset = "0x979B28")]
		public float spineBend;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979B60", Offset = "0x979B60")]
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
		[Address(RVA = "0x1FF5124", Offset = "0x1FF5124", VA = "0x1FF5124")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9816FC", Offset = "0x9816FC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1FF516C", Offset = "0x1FF516C", VA = "0x1FF516C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981734", Offset = "0x981734")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1FF51B4", Offset = "0x1FF51B4", VA = "0x1FF51B4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98176C", Offset = "0x98176C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1FF51FC", Offset = "0x1FF51FC", VA = "0x1FF51FC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1FF523C", Offset = "0x1FF523C", VA = "0x1FF523C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1FF52D0", Offset = "0x1FF52D0", VA = "0x1FF52D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1FF558C", Offset = "0x1FF558C", VA = "0x1FF558C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1FF5598", Offset = "0x1FF5598", VA = "0x1FF5598")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1FF5338", Offset = "0x1FF5338", VA = "0x1FF5338")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1FF55A4", Offset = "0x1FF55A4", VA = "0x1FF55A4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1FF58C4", Offset = "0x1FF58C4", VA = "0x1FF58C4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1FF59D4", Offset = "0x1FF59D4", VA = "0x1FF59D4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1FF5B50", Offset = "0x1FF5B50", VA = "0x1FF5B50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1FF5C88", Offset = "0x1FF5C88", VA = "0x1FF5C88")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9787B0", Offset = "0x9787B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9787B0", Offset = "0x9787B0")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979C40", Offset = "0x979C40")]
		public Transform pelvis;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979C78", Offset = "0x979C78")]
		public Transform characterRoot;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979CB0", Offset = "0x979CB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979CB0", Offset = "0x979CB0")]
		public float rootRotationWeight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979D04", Offset = "0x979D04")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979D3C", Offset = "0x979D3C")]
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
		[Address(RVA = "0x1FF5D28", Offset = "0x1FF5D28", VA = "0x1FF5D28", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9817A4", Offset = "0x9817A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1FF5D70", Offset = "0x1FF5D70", VA = "0x1FF5D70", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9817DC", Offset = "0x9817DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1FF5DB8", Offset = "0x1FF5DB8", VA = "0x1FF5DB8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1FF5DD4", Offset = "0x1FF5DD4", VA = "0x1FF5DD4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1FF6008", Offset = "0x1FF6008", VA = "0x1FF6008")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1FF6104", Offset = "0x1FF6104", VA = "0x1FF6104")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1FF6558", Offset = "0x1FF6558", VA = "0x1FF6558")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1FF69C0", Offset = "0x1FF69C0", VA = "0x1FF69C0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1FF6B50", Offset = "0x1FF6B50", VA = "0x1FF6B50")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1FF6E54", Offset = "0x1FF6E54", VA = "0x1FF6E54")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1FF6FA0", Offset = "0x1FF6FA0", VA = "0x1FF6FA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1FF71AC", Offset = "0x1FF71AC", VA = "0x1FF71AC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978810", Offset = "0x978810")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978810", Offset = "0x978810")]
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
			[Address(RVA = "0x1D21090", Offset = "0x1D21090", VA = "0x1D21090")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979D74", Offset = "0x979D74")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979DAC", Offset = "0x979DAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979DAC", Offset = "0x979DAC")]
		public float rootRotationWeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979E00", Offset = "0x979E00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979E00", Offset = "0x979E00")]
		public float minRootRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979E58", Offset = "0x979E58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979E58", Offset = "0x979E58")]
		public float maxRootRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979EB0", Offset = "0x979EB0")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979EE8", Offset = "0x979EE8")]
		public float maxLegOffset;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979F20", Offset = "0x979F20")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x979F58", Offset = "0x979F58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979F58", Offset = "0x979F58")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979FAC", Offset = "0x979FAC")]
		public Transform characterRoot;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x979FE4", Offset = "0x979FE4")]
		public Transform pelvis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A01C", Offset = "0x97A01C")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A054", Offset = "0x97A054")]
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
		[Address(RVA = "0x1FF724C", Offset = "0x1FF724C", VA = "0x1FF724C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981814", Offset = "0x981814")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1FF7294", Offset = "0x1FF7294", VA = "0x1FF7294", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98184C", Offset = "0x98184C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1FF72DC", Offset = "0x1FF72DC", VA = "0x1FF72DC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1FF7318", Offset = "0x1FF7318", VA = "0x1FF7318")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1FF7444", Offset = "0x1FF7444", VA = "0x1FF7444")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1FF7648", Offset = "0x1FF7648", VA = "0x1FF7648")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1FF76B0", Offset = "0x1FF76B0", VA = "0x1FF76B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1FF7714", Offset = "0x1FF7714", VA = "0x1FF7714")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1FF7A7C", Offset = "0x1FF7A7C", VA = "0x1FF7A7C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1FF7E14", Offset = "0x1FF7E14", VA = "0x1FF7E14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1FF7F0C", Offset = "0x1FF7F0C", VA = "0x1FF7F0C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1FF82D8", Offset = "0x1FF82D8", VA = "0x1FF82D8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1FF88FC", Offset = "0x1FF88FC", VA = "0x1FF88FC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1FF8ACC", Offset = "0x1FF8ACC", VA = "0x1FF8ACC")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1FF8BA8", Offset = "0x1FF8BA8", VA = "0x1FF8BA8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1FF8DF0", Offset = "0x1FF8DF0", VA = "0x1FF8DF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1FF8E28", Offset = "0x1FF8E28", VA = "0x1FF8E28")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1FF902C", Offset = "0x1FF902C", VA = "0x1FF902C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978870", Offset = "0x978870")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978870", Offset = "0x978870")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A09C", Offset = "0x97A09C")]
		public VRIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x203F72C", Offset = "0x203F72C", VA = "0x203F72C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981884", Offset = "0x981884")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x203F774", Offset = "0x203F774", VA = "0x203F774", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9818BC", Offset = "0x9818BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x203F7BC", Offset = "0x203F7BC", VA = "0x203F7BC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9818F4", Offset = "0x9818F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x203F804", Offset = "0x203F804", VA = "0x203F804", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x203F8A8", Offset = "0x203F8A8", VA = "0x203F8A8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x203F93C", Offset = "0x203F93C", VA = "0x203F93C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x203F99C", Offset = "0x203F99C", VA = "0x203F99C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x203FED8", Offset = "0x203FED8", VA = "0x203FED8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2040338", Offset = "0x2040338", VA = "0x2040338")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x20403C8", Offset = "0x20403C8", VA = "0x20403C8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2040584", Offset = "0x2040584", VA = "0x2040584")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2040700", Offset = "0x2040700", VA = "0x2040700")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x20408B4", Offset = "0x20408B4", VA = "0x20408B4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A580", Offset = "0x97A580")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A590", Offset = "0x97A590")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A5A0", Offset = "0x97A5A0")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A5B0", Offset = "0x97A5B0")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A5C0", Offset = "0x97A5C0")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A5D0", Offset = "0x97A5D0")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A5E0", Offset = "0x97A5E0")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A5F0", Offset = "0x97A5F0")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A600", Offset = "0x97A600")]
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
				[Address(RVA = "0x1D210F4", Offset = "0x1D210F4", VA = "0x1D210F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819CC", Offset = "0x9819CC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x1D210FC", Offset = "0x1D210FC", VA = "0x1D210FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819DC", Offset = "0x9819DC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x1D21108", Offset = "0x1D21108", VA = "0x1D21108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819EC", Offset = "0x9819EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x1D21114", Offset = "0x1D21114", VA = "0x1D21114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819FC", Offset = "0x9819FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x1D21120", Offset = "0x1D21120", VA = "0x1D21120")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A0C", Offset = "0x981A0C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x1D21128", Offset = "0x1D21128", VA = "0x1D21128")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A1C", Offset = "0x981A1C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x1D21134", Offset = "0x1D21134", VA = "0x1D21134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A2C", Offset = "0x981A2C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x1D2113C", Offset = "0x1D2113C", VA = "0x1D2113C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A3C", Offset = "0x981A3C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x1D21144", Offset = "0x1D21144", VA = "0x1D21144")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A4C", Offset = "0x981A4C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x1D21150", Offset = "0x1D21150", VA = "0x1D21150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A5C", Offset = "0x981A5C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x1D2115C", Offset = "0x1D2115C", VA = "0x1D2115C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A6C", Offset = "0x981A6C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x1D21164", Offset = "0x1D21164", VA = "0x1D21164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A7C", Offset = "0x981A7C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x1D2116C", Offset = "0x1D2116C", VA = "0x1D2116C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A8C", Offset = "0x981A8C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x1D21174", Offset = "0x1D21174", VA = "0x1D21174")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A9C", Offset = "0x981A9C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x1D2117C", Offset = "0x1D2117C", VA = "0x1D2117C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981AAC", Offset = "0x981AAC")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x1D21194", Offset = "0x1D21194", VA = "0x1D21194")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981ABC", Offset = "0x981ABC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x1D211B4", Offset = "0x1D211B4", VA = "0x1D211B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981ACC", Offset = "0x981ACC")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x1D211CC", Offset = "0x1D211CC", VA = "0x1D211CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981ADC", Offset = "0x981ADC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x1D211EC", Offset = "0x1D211EC", VA = "0x1D211EC")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x1D223CC", Offset = "0x1D223CC", VA = "0x1D223CC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x1D22530", Offset = "0x1D22530", VA = "0x1D22530")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x1D21234", Offset = "0x1D21234", VA = "0x1D21234")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x1D21248", Offset = "0x1D21248", VA = "0x1D21248")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x1D212D8", Offset = "0x1D212D8", VA = "0x1D212D8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1D21324", Offset = "0x1D21324", VA = "0x1D21324")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1D21394", Offset = "0x1D21394", VA = "0x1D21394")]
			public void Process()
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1D22040", Offset = "0x1D22040", VA = "0x1D22040")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x1D21BE0", Offset = "0x1D21BE0", VA = "0x1D21BE0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x1D22460", Offset = "0x1D22460", VA = "0x1D22460")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x1D21E80", Offset = "0x1D21E80", VA = "0x1D21E80")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1D21F0C", Offset = "0x1D21F0C", VA = "0x1D21F0C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1D224D0", Offset = "0x1D224D0", VA = "0x1D224D0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x1D223F4", Offset = "0x1D223F4", VA = "0x1D223F4")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1D225C4", Offset = "0x1D225C4", VA = "0x1D225C4")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1D22650", Offset = "0x1D22650", VA = "0x1D22650")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003F")]
		public class Pelvis
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A610", Offset = "0x97A610")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A620", Offset = "0x97A620")]
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
				[Address(RVA = "0x1D22694", Offset = "0x1D22694", VA = "0x1D22694")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981AEC", Offset = "0x981AEC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x1D226A0", Offset = "0x1D226A0", VA = "0x1D226A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981AFC", Offset = "0x981AFC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x1D226AC", Offset = "0x1D226AC", VA = "0x1D226AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B0C", Offset = "0x981B0C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x1D226B4", Offset = "0x1D226B4", VA = "0x1D226B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B1C", Offset = "0x981B1C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1D226BC", Offset = "0x1D226BC", VA = "0x1D226BC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x1D2274C", Offset = "0x1D2274C", VA = "0x1D2274C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1D226EC", Offset = "0x1D226EC", VA = "0x1D226EC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x1D227B8", Offset = "0x1D227B8", VA = "0x1D227B8")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1D22958", Offset = "0x1D22958", VA = "0x1D22958")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A0D4", Offset = "0x97A0D4")]
		public LayerMask layers;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A10C", Offset = "0x97A10C")]
		public float maxStep;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A144", Offset = "0x97A144")]
		public float heightOffset;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A17C", Offset = "0x97A17C")]
		public float footSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A1B4", Offset = "0x97A1B4")]
		public float footRadius;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A1EC", Offset = "0x97A1EC")]
		public float footCenterOffset;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A238", Offset = "0x97A238")]
		public float prediction;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A270", Offset = "0x97A270")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97A270", Offset = "0x97A270")]
		public float footRotationWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A2C4", Offset = "0x97A2C4")]
		public float footRotationSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A2FC", Offset = "0x97A2FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97A2FC", Offset = "0x97A2FC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A354", Offset = "0x97A354")]
		public bool rotateSolver;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A38C", Offset = "0x97A38C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97A3C4", Offset = "0x97A3C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A3C4", Offset = "0x97A3C4")]
		public float pelvisDamper;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A418", Offset = "0x97A418")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A450", Offset = "0x97A450")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A488", Offset = "0x97A488")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A4C0", Offset = "0x97A4C0")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A4F8", Offset = "0x97A4F8")]
		public Quality quality;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A530", Offset = "0x97A530")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A540", Offset = "0x97A540")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A550", Offset = "0x97A550")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A560", Offset = "0x97A560")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97A570", Offset = "0x97A570")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x204091C", Offset = "0x204091C", VA = "0x204091C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98192C", Offset = "0x98192C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2040924", Offset = "0x2040924", VA = "0x2040924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98193C", Offset = "0x98193C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x204092C", Offset = "0x204092C", VA = "0x204092C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98194C", Offset = "0x98194C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2040934", Offset = "0x2040934", VA = "0x2040934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98195C", Offset = "0x98195C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x204093C", Offset = "0x204093C", VA = "0x204093C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98196C", Offset = "0x98196C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2040944", Offset = "0x2040944", VA = "0x2040944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98197C", Offset = "0x98197C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2040950", Offset = "0x2040950", VA = "0x2040950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98198C", Offset = "0x98198C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2040958", Offset = "0x2040958", VA = "0x2040958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98199C", Offset = "0x98199C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2040960", Offset = "0x2040960", VA = "0x2040960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819AC", Offset = "0x9819AC")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2040978", Offset = "0x2040978", VA = "0x2040978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819BC", Offset = "0x9819BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2040998", Offset = "0x2040998", VA = "0x2040998")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x2040C38", Offset = "0x2040C38", VA = "0x2040C38")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x2040F08", Offset = "0x2040F08", VA = "0x2040F08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x20409EC", Offset = "0x20409EC", VA = "0x20409EC")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2040C7C", Offset = "0x2040C7C", VA = "0x2040C7C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x203FC08", Offset = "0x203FC08", VA = "0x203FC08")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x20400C8", Offset = "0x20400C8", VA = "0x20400C8")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2040DA8", Offset = "0x2040DA8", VA = "0x2040DA8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x203F81C", Offset = "0x203F81C", VA = "0x203F81C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2040D90", Offset = "0x2040D90", VA = "0x2040D90")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2040F88", Offset = "0x2040F88", VA = "0x2040F88")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2041018", Offset = "0x2041018", VA = "0x2041018")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x20410D4", Offset = "0x20410D4", VA = "0x20410D4")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2041150", Offset = "0x2041150", VA = "0x2041150")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9788D0", Offset = "0x9788D0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9788D0", Offset = "0x9788D0")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1FB1380", Offset = "0x1FB1380", VA = "0x1FB1380", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981B2C", Offset = "0x981B2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1FB13C8", Offset = "0x1FB13C8", VA = "0x1FB13C8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981B64", Offset = "0x981B64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1FB1410", Offset = "0x1FB1410", VA = "0x1FB1410")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981B9C", Offset = "0x981B9C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1FB1458", Offset = "0x1FB1458", VA = "0x1FB1458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981BD4", Offset = "0x981BD4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1FB14A0", Offset = "0x1FB14A0", VA = "0x1FB14A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981C0C", Offset = "0x981C0C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1FB14E8", Offset = "0x1FB14E8", VA = "0x1FB14E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1FB14F0", Offset = "0x1FB14F0", VA = "0x1FB14F0")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978930", Offset = "0x978930")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978930", Offset = "0x978930")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1FB2E64", Offset = "0x1FB2E64", VA = "0x1FB2E64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981C44", Offset = "0x981C44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1FB2EAC", Offset = "0x1FB2EAC", VA = "0x1FB2EAC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981C7C", Offset = "0x981C7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1FB2EF4", Offset = "0x1FB2EF4", VA = "0x1FB2EF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981CB4", Offset = "0x981CB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1FB2F3C", Offset = "0x1FB2F3C", VA = "0x1FB2F3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981CEC", Offset = "0x981CEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1FB2F84", Offset = "0x1FB2F84", VA = "0x1FB2F84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1FB2F8C", Offset = "0x1FB2F8C", VA = "0x1FB2F8C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978990", Offset = "0x978990")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978990", Offset = "0x978990")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1FC01B0", Offset = "0x1FC01B0", VA = "0x1FC01B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981D24", Offset = "0x981D24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1FC01F8", Offset = "0x1FC01F8", VA = "0x1FC01F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981D5C", Offset = "0x981D5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1FC0240", Offset = "0x1FC0240", VA = "0x1FC0240")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981D94", Offset = "0x981D94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1FC0288", Offset = "0x1FC0288", VA = "0x1FC0288")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981DCC", Offset = "0x981DCC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1FC02D0", Offset = "0x1FC02D0", VA = "0x1FC02D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1FC02D8", Offset = "0x1FC02D8", VA = "0x1FC02D8")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9789F0", Offset = "0x9789F0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9789F0", Offset = "0x9789F0")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1FE9428", Offset = "0x1FE9428", VA = "0x1FE9428", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981E04", Offset = "0x981E04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1FE9470", Offset = "0x1FE9470", VA = "0x1FE9470", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981E3C", Offset = "0x981E3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1FE94B8", Offset = "0x1FE94B8", VA = "0x1FE94B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981E74", Offset = "0x981E74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1FE9500", Offset = "0x1FE9500", VA = "0x1FE9500")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981EAC", Offset = "0x981EAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1FE9548", Offset = "0x1FE9548", VA = "0x1FE9548", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1FE9550", Offset = "0x1FE9550", VA = "0x1FE9550")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978A50", Offset = "0x978A50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978A50", Offset = "0x978A50")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1FE9A98", Offset = "0x1FE9A98", VA = "0x1FE9A98", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981EE4", Offset = "0x981EE4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1FE9AE0", Offset = "0x1FE9AE0", VA = "0x1FE9AE0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981F1C", Offset = "0x981F1C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1FE9B28", Offset = "0x1FE9B28", VA = "0x1FE9B28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981F54", Offset = "0x981F54")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1FE9B70", Offset = "0x1FE9B70", VA = "0x1FE9B70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981F8C", Offset = "0x981F8C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1FE9BB8", Offset = "0x1FE9BB8", VA = "0x1FE9BB8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1FE9BC0", Offset = "0x1FE9BC0", VA = "0x1FE9BC0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978AB0", Offset = "0x978AB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978AB0", Offset = "0x978AB0")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1FF279C", Offset = "0x1FF279C", VA = "0x1FF279C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981FC4", Offset = "0x981FC4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1FF27E4", Offset = "0x1FF27E4", VA = "0x1FF27E4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x981FFC", Offset = "0x981FFC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1FF282C", Offset = "0x1FF282C", VA = "0x1FF282C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982034", Offset = "0x982034")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1FF2874", Offset = "0x1FF2874", VA = "0x1FF2874")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98206C", Offset = "0x98206C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1FF28BC", Offset = "0x1FF28BC", VA = "0x1FF28BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9820A4", Offset = "0x9820A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1FF2904", Offset = "0x1FF2904", VA = "0x1FF2904")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9820DC", Offset = "0x9820DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1FF294C", Offset = "0x1FF294C", VA = "0x1FF294C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1FF2990", Offset = "0x1FF2990", VA = "0x1FF2990", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1FF2998", Offset = "0x1FF2998", VA = "0x1FF2998")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1FF2B80", Offset = "0x1FF2B80", VA = "0x1FF2B80")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1FF2E20", Offset = "0x1FF2E20", VA = "0x1FF2E20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982114", Offset = "0x982114")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1FF2E40", Offset = "0x1FF2E40", VA = "0x1FF2E40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98214C", Offset = "0x98214C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1FF2F30", Offset = "0x1FF2F30", VA = "0x1FF2F30")]
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
		[Address(RVA = "0x20447E8", Offset = "0x20447E8", VA = "0x20447E8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x20448DC", Offset = "0x20448DC", VA = "0x20448DC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2044AD4", Offset = "0x2044AD4", VA = "0x2044AD4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000238")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000239")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2044B34", Offset = "0x2044B34", VA = "0x2044B34")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A630", Offset = "0x97A630")]
		public IK[] IKComponents;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A668", Offset = "0x97A668")]
		public Animator animator;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x20471B4", Offset = "0x20471B4", VA = "0x20471B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x204724C", Offset = "0x204724C", VA = "0x204724C")]
		private void Start()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x20472BC", Offset = "0x20472BC", VA = "0x20472BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2047378", Offset = "0x2047378", VA = "0x2047378")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x20473B4", Offset = "0x20473B4", VA = "0x20473B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x20472F0", Offset = "0x20472F0", VA = "0x20472F0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2047440", Offset = "0x2047440", VA = "0x2047440")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978B10", Offset = "0x978B10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978B10", Offset = "0x978B10")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1E06564", Offset = "0x1E06564", VA = "0x1E06564", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982184", Offset = "0x982184")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1E065AC", Offset = "0x1E065AC", VA = "0x1E065AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9821BC", Offset = "0x9821BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1E065F4", Offset = "0x1E065F4", VA = "0x1E065F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9821F4", Offset = "0x9821F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1E0663C", Offset = "0x1E0663C", VA = "0x1E0663C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98222C", Offset = "0x98222C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1E06684", Offset = "0x1E06684", VA = "0x1E06684", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1E0668C", Offset = "0x1E0668C", VA = "0x1E0668C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978B70", Offset = "0x978B70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978B70", Offset = "0x978B70")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1E066FC", Offset = "0x1E066FC", VA = "0x1E066FC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982264", Offset = "0x982264")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1E06744", Offset = "0x1E06744", VA = "0x1E06744", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98229C", Offset = "0x98229C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1E0678C", Offset = "0x1E0678C", VA = "0x1E0678C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9822D4", Offset = "0x9822D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1E067D4", Offset = "0x1E067D4", VA = "0x1E067D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98230C", Offset = "0x98230C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1E0681C", Offset = "0x1E0681C", VA = "0x1E0681C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1E06824", Offset = "0x1E06824", VA = "0x1E06824")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978BD0", Offset = "0x978BD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978BD0", Offset = "0x978BD0")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1E07230", Offset = "0x1E07230", VA = "0x1E07230", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982344", Offset = "0x982344")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1E07278", Offset = "0x1E07278", VA = "0x1E07278", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98237C", Offset = "0x98237C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1E072C0", Offset = "0x1E072C0", VA = "0x1E072C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9823B4", Offset = "0x9823B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1E07308", Offset = "0x1E07308", VA = "0x1E07308")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9823EC", Offset = "0x9823EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1E07350", Offset = "0x1E07350", VA = "0x1E07350", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1E07358", Offset = "0x1E07358", VA = "0x1E07358")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978C30", Offset = "0x978C30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978C30", Offset = "0x978C30")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1D178F8", Offset = "0x1D178F8", VA = "0x1D178F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982424", Offset = "0x982424")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1D17940", Offset = "0x1D17940", VA = "0x1D17940", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98245C", Offset = "0x98245C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1D17988", Offset = "0x1D17988", VA = "0x1D17988")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982494", Offset = "0x982494")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1D179D0", Offset = "0x1D179D0", VA = "0x1D179D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9824CC", Offset = "0x9824CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1D17A18", Offset = "0x1D17A18", VA = "0x1D17A18", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1D17A20", Offset = "0x1D17A20", VA = "0x1D17A20")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978C90", Offset = "0x978C90")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A754", Offset = "0x97A754")]
			public Transform chest;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A78C", Offset = "0x97A78C")]
			public Transform neck;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A7C4", Offset = "0x97A7C4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A7FC", Offset = "0x97A7FC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A834", Offset = "0x97A834")]
			public Transform leftThigh;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A86C", Offset = "0x97A86C")]
			public Transform leftCalf;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A8A4", Offset = "0x97A8A4")]
			public Transform leftFoot;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A8DC", Offset = "0x97A8DC")]
			public Transform leftToes;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A914", Offset = "0x97A914")]
			public Transform rightThigh;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A94C", Offset = "0x97A94C")]
			public Transform rightCalf;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A984", Offset = "0x97A984")]
			public Transform rightFoot;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A9BC", Offset = "0x97A9BC")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x2418500", Offset = "0x2418500", VA = "0x2418500")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x2418978", Offset = "0x2418978", VA = "0x2418978")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2417FB0", Offset = "0x2417FB0", VA = "0x2417FB0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2418DF0", Offset = "0x2418DF0", VA = "0x2418DF0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x241929C", Offset = "0x241929C", VA = "0x241929C")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x97A6A0", Offset = "0x97A6A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A6A0", Offset = "0x97A6A0")]
		public References references;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97A71C", Offset = "0x97A71C")]
		public IKSolverVR solver;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1D1A764", Offset = "0x1D1A764", VA = "0x1D1A764", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982504", Offset = "0x982504")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1D1A7AC", Offset = "0x1D1A7AC", VA = "0x1D1A7AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98253C", Offset = "0x98253C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1D1A7F4", Offset = "0x1D1A7F4", VA = "0x1D1A7F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982574", Offset = "0x982574")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1D1A83C", Offset = "0x1D1A83C", VA = "0x1D1A83C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9825AC", Offset = "0x9825AC")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1D1A868", Offset = "0x1D1A868", VA = "0x1D1A868")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9825E4", Offset = "0x9825E4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1D1A890", Offset = "0x1D1A890", VA = "0x1D1A890", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1D1A898", Offset = "0x1D1A898", VA = "0x1D1A898", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1D1A918", Offset = "0x1D1A918", VA = "0x1D1A918", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1D1AA84", Offset = "0x1D1AA84", VA = "0x1D1AA84")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97A9F4", Offset = "0x97A9F4")]
		public float pull;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AA0C", Offset = "0x97AA0C")]
		public float pin;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1FE95C0", Offset = "0x1FE95C0", VA = "0x1FE95C0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1FE969C", Offset = "0x1FE969C", VA = "0x1FE969C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1FE96BC", Offset = "0x1FE96BC", VA = "0x1FE96BC")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1FE9930", Offset = "0x1FE9930", VA = "0x1FE9930")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1FE9790", Offset = "0x1FE9790", VA = "0x1FE9790")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1FE9A28", Offset = "0x1FE9A28", VA = "0x1FE9A28")]
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
		[Address(RVA = "0x1FE9C30", Offset = "0x1FE9C30", VA = "0x1FE9C30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1FEA0A8", Offset = "0x1FEA0A8", VA = "0x1FEA0A8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1FEA264", Offset = "0x1FEA264", VA = "0x1FEA264")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1FEA394", Offset = "0x1FEA394", VA = "0x1FEA394")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B064", Offset = "0x97B064")]
			public Transform transform;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B09C", Offset = "0x97B09C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B09C", Offset = "0x97B09C")]
			public float weight;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1D203B4", Offset = "0x1D203B4", VA = "0x1D203B4")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1D203F0", Offset = "0x1D203F0", VA = "0x1D203F0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1D20454", Offset = "0x1D20454", VA = "0x1D20454")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1D2048C", Offset = "0x1D2048C", VA = "0x1D2048C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AA24", Offset = "0x97AA24")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AA5C", Offset = "0x97AA5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AA5C", Offset = "0x97AA5C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x97AA5C", Offset = "0x97AA5C")]
		public float positionWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AAD4", Offset = "0x97AAD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AAD4", Offset = "0x97AAD4")]
		public float bodyWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AB28", Offset = "0x97AB28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AB28", Offset = "0x97AB28")]
		public float thighWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AB7C", Offset = "0x97AB7C")]
		public bool handsPullBody;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ABB4", Offset = "0x97ABB4")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x97ABB4", Offset = "0x97ABB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97ABB4", Offset = "0x97ABB4")]
		public float rotationWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AC2C", Offset = "0x97AC2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AC2C", Offset = "0x97AC2C")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AC80", Offset = "0x97AC80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AC80", Offset = "0x97AC80")]
		public float headClampWeight;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ACD4", Offset = "0x97ACD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97ACD4", Offset = "0x97ACD4")]
		public float bendWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AD28", Offset = "0x97AD28")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x97AD60", Offset = "0x97AD60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AD60", Offset = "0x97AD60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AD60", Offset = "0x97AD60")]
		public float CCDWeight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ADD8", Offset = "0x97ADD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97ADD8", Offset = "0x97ADD8")]
		public float roll;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AE2C", Offset = "0x97AE2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AE2C", Offset = "0x97AE2C")]
		public float damper;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AE84", Offset = "0x97AE84")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x97AEBC", Offset = "0x97AEBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AEBC", Offset = "0x97AEBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97AEBC", Offset = "0x97AEBC")]
		public float postStretchWeight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AF34", Offset = "0x97AF34")]
		public float maxStretch;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AF6C", Offset = "0x97AF6C")]
		public float stretchDamper;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AFA4", Offset = "0x97AFA4")]
		public bool fixHead;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97AFDC", Offset = "0x97AFDC")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x97B014", Offset = "0x97B014")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B04C", Offset = "0x97B04C")]
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
		[Address(RVA = "0x1FEA39C", Offset = "0x1FEA39C", VA = "0x1FEA39C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1FEA724", Offset = "0x1FEA724", VA = "0x1FEA724")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1FEAC00", Offset = "0x1FEAC00", VA = "0x1FEAC00")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1FEAFCC", Offset = "0x1FEAFCC", VA = "0x1FEAFCC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1FEB758", Offset = "0x1FEB758", VA = "0x1FEB758")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1FEBA38", Offset = "0x1FEBA38", VA = "0x1FEBA38")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1FEBD3C", Offset = "0x1FEBD3C", VA = "0x1FEBD3C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1FEC510", Offset = "0x1FEC510", VA = "0x1FEC510")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1FEB53C", Offset = "0x1FEB53C", VA = "0x1FEB53C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1FEC6D8", Offset = "0x1FEC6D8", VA = "0x1FEC6D8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1FEC428", Offset = "0x1FEC428", VA = "0x1FEC428")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1FEC35C", Offset = "0x1FEC35C", VA = "0x1FEC35C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1FEC95C", Offset = "0x1FEC95C", VA = "0x1FEC95C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1FECC90", Offset = "0x1FECC90", VA = "0x1FECC90")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97B188", Offset = "0x97B188")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97B198", Offset = "0x97B198")]
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
				[Address(RVA = "0x1D20548", Offset = "0x1D20548", VA = "0x1D20548")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98261C", Offset = "0x98261C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x1D20550", Offset = "0x1D20550", VA = "0x1D20550")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98262C", Offset = "0x98262C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x1D20558", Offset = "0x1D20558", VA = "0x1D20558")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98263C", Offset = "0x98263C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029B")]
				[Address(RVA = "0x1D20560", Offset = "0x1D20560", VA = "0x1D20560")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98264C", Offset = "0x98264C")]
				private set
				{
				}
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x1D2056C", Offset = "0x1D2056C", VA = "0x1D2056C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1D205D4", Offset = "0x1D205D4", VA = "0x1D205D4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1D2062C", Offset = "0x1D2062C", VA = "0x1D2062C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1D207D0", Offset = "0x1D207D0", VA = "0x1D207D0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B0F0", Offset = "0x97B0F0")]
		public float pin;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B108", Offset = "0x97B108")]
		public float pull;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B120", Offset = "0x97B120")]
		public float push;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B138", Offset = "0x97B138")]
		public float pushParent;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B150", Offset = "0x97B150")]
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
		[Address(RVA = "0x1FED3EC", Offset = "0x1FED3EC", VA = "0x1FED3EC")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1FED508", Offset = "0x1FED508", VA = "0x1FED508")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1FED678", Offset = "0x1FED678", VA = "0x1FED678")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1FED7B4", Offset = "0x1FED7B4", VA = "0x1FED7B4")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1FED88C", Offset = "0x1FED88C", VA = "0x1FED88C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1FED9B0", Offset = "0x1FED9B0", VA = "0x1FED9B0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1FEE080", Offset = "0x1FEE080", VA = "0x1FEE080")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1FEDB4C", Offset = "0x1FEDB4C", VA = "0x1FEDB4C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1FEE470", Offset = "0x1FEE470", VA = "0x1FEE470")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1FEE6D0", Offset = "0x1FEE6D0", VA = "0x1FEE6D0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1FEE93C", Offset = "0x1FEE93C", VA = "0x1FEE93C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1FEECE0", Offset = "0x1FEECE0", VA = "0x1FEECE0")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1FEF174", Offset = "0x1FEF174", VA = "0x1FEF174")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1FEF398", Offset = "0x1FEF398", VA = "0x1FEF398")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1FEF104", Offset = "0x1FEF104", VA = "0x1FEF104")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1FEEB6C", Offset = "0x1FEEB6C", VA = "0x1FEEB6C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1FEF088", Offset = "0x1FEF088", VA = "0x1FEF088")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1FEF480", Offset = "0x1FEF480", VA = "0x1FEF480")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1FEEFA8", Offset = "0x1FEEFA8", VA = "0x1FEEFA8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1FEF280", Offset = "0x1FEF280", VA = "0x1FEF280")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B1A8", Offset = "0x97B1A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97B1C0", Offset = "0x97B1C0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x2044D24", Offset = "0x2044D24", VA = "0x2044D24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98265C", Offset = "0x98265C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x2044D2C", Offset = "0x2044D2C", VA = "0x2044D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98266C", Offset = "0x98266C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2044B3C", Offset = "0x2044B3C", VA = "0x2044B3C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2044D38", Offset = "0x2044D38", VA = "0x2044D38")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2044D78", Offset = "0x2044D78", VA = "0x2044D78")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2044DE0", Offset = "0x2044DE0", VA = "0x2044DE0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2044E30", Offset = "0x2044E30", VA = "0x2044E30")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x20451A8", Offset = "0x20451A8", VA = "0x20451A8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2045398", Offset = "0x2045398", VA = "0x2045398")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x20456E4", Offset = "0x20456E4", VA = "0x20456E4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2045068", Offset = "0x2045068", VA = "0x2045068")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2045108", Offset = "0x2045108", VA = "0x2045108")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B1D0", Offset = "0x97B1D0")]
		public float positionWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B1E8", Offset = "0x97B1E8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97B200", Offset = "0x97B200")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B210", Offset = "0x97B210")]
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
			[Address(RVA = "0x2045BC4", Offset = "0x2045BC4", VA = "0x2045BC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98267C", Offset = "0x98267C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2045BCC", Offset = "0x2045BCC", VA = "0x2045BCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98268C", Offset = "0x98268C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2045B5C", Offset = "0x2045B5C", VA = "0x2045B5C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2045BD8", Offset = "0x2045BD8", VA = "0x2045BD8")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2045C68", Offset = "0x2045C68", VA = "0x2045C68")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2045DAC", Offset = "0x2045DAC", VA = "0x2045DAC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2045F2C", Offset = "0x2045F2C", VA = "0x2045F2C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2046254", Offset = "0x2046254", VA = "0x2046254")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x204650C", Offset = "0x204650C", VA = "0x204650C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x20465D8", Offset = "0x20465D8", VA = "0x20465D8")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2046680", Offset = "0x2046680", VA = "0x2046680")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2046BA8", Offset = "0x2046BA8", VA = "0x2046BA8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2046BD4", Offset = "0x2046BD4", VA = "0x2046BD4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2046D28", Offset = "0x2046D28", VA = "0x2046D28")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2046FA0", Offset = "0x2046FA0", VA = "0x2046FA0")]
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
				[Address(RVA = "0x1D15A28", Offset = "0x1D15A28", VA = "0x1D15A28")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x1D23D9C", Offset = "0x1D23D9C", VA = "0x1D23D9C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0x1D2416C", Offset = "0x1D2416C", VA = "0x1D2416C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1D23CAC", Offset = "0x1D23CAC", VA = "0x1D23CAC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1D23CFC", Offset = "0x1D23CFC", VA = "0x1D23CFC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1D23D4C", Offset = "0x1D23D4C", VA = "0x1D23D4C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1D23DAC", Offset = "0x1D23DAC", VA = "0x1D23DAC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1D23E34", Offset = "0x1D23E34", VA = "0x1D23E34")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1D23E3C", Offset = "0x1D23E3C", VA = "0x1D23E3C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1D23F14", Offset = "0x1D23F14", VA = "0x1D23F14")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1D23F8C", Offset = "0x1D23F8C", VA = "0x1D23F8C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1D24050", Offset = "0x1D24050", VA = "0x1D24050")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1D242AC", Offset = "0x1D242AC", VA = "0x1D242AC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1D242E4", Offset = "0x1D242E4", VA = "0x1D242E4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1D2431C", Offset = "0x1D2431C", VA = "0x1D2431C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1D24344", Offset = "0x1D24344", VA = "0x1D24344")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1D24430", Offset = "0x1D24430", VA = "0x1D24430")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1D245BC", Offset = "0x1D245BC", VA = "0x1D245BC")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1D245EC", Offset = "0x1D245EC", VA = "0x1D245EC")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1D246B4", Offset = "0x1D246B4", VA = "0x1D246B4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1D24724", Offset = "0x1D24724", VA = "0x1D24724")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1D24874", Offset = "0x1D24874", VA = "0x1D24874")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1D249C4", Offset = "0x1D249C4", VA = "0x1D249C4")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x1D24A44", Offset = "0x1D24A44", VA = "0x1D24A44")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1D244AC", Offset = "0x1D244AC", VA = "0x1D244AC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1D24B7C", Offset = "0x1D24B7C", VA = "0x1D24B7C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2047448", Offset = "0x2047448", VA = "0x2047448", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2047450", Offset = "0x2047450", VA = "0x2047450", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2047454", Offset = "0x2047454", VA = "0x2047454")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x20475A4", Offset = "0x20475A4", VA = "0x20475A4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2047614", Offset = "0x2047614", VA = "0x2047614")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B228", Offset = "0x97B228")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x204761C", Offset = "0x204761C", VA = "0x204761C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x20476D0", Offset = "0x20476D0", VA = "0x20476D0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2047748", Offset = "0x2047748", VA = "0x2047748")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x20477DC", Offset = "0x20477DC", VA = "0x20477DC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x20477F8", Offset = "0x20477F8", VA = "0x20477F8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2047818", Offset = "0x2047818", VA = "0x2047818", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x20478B0", Offset = "0x20478B0", VA = "0x20478B0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x20478CC", Offset = "0x20478CC", VA = "0x20478CC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B240", Offset = "0x97B240")]
		public float maintainRotationWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B258", Offset = "0x97B258")]
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
		[Address(RVA = "0x20478F4", Offset = "0x20478F4", VA = "0x20478F4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2047978", Offset = "0x2047978", VA = "0x2047978")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2047A54", Offset = "0x2047A54", VA = "0x2047A54")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2047C78", Offset = "0x2047C78", VA = "0x2047C78")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2047D6C", Offset = "0x2047D6C", VA = "0x2047D6C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2047E98", Offset = "0x2047E98", VA = "0x2047E98")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2047EFC", Offset = "0x2047EFC", VA = "0x2047EFC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2047FB0", Offset = "0x2047FB0", VA = "0x2047FB0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2048074", Offset = "0x2048074", VA = "0x2048074", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x204830C", Offset = "0x204830C", VA = "0x204830C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2048380", Offset = "0x2048380", VA = "0x2048380")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B270", Offset = "0x97B270")]
		public int iterations;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B288", Offset = "0x97B288")]
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
		[Address(RVA = "0x20484FC", Offset = "0x20484FC", VA = "0x20484FC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2048868", Offset = "0x2048868", VA = "0x2048868")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2048988", Offset = "0x2048988", VA = "0x2048988")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2048AE8", Offset = "0x2048AE8", VA = "0x2048AE8")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2048B68", Offset = "0x2048B68", VA = "0x2048B68")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2048BD4", Offset = "0x2048BD4", VA = "0x2048BD4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2048C58", Offset = "0x2048C58", VA = "0x2048C58", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x204929C", Offset = "0x204929C", VA = "0x204929C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x20492D4", Offset = "0x20492D4", VA = "0x20492D4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2049558", Offset = "0x2049558", VA = "0x2049558")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2049858", Offset = "0x2049858", VA = "0x2049858")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2049944", Offset = "0x2049944", VA = "0x2049944")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2049A0C", Offset = "0x2049A0C", VA = "0x2049A0C")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B35C", Offset = "0x97B35C")]
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
			[Address(RVA = "0x1D25720", Offset = "0x1D25720", VA = "0x1D25720")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1D25770", Offset = "0x1D25770", VA = "0x1D25770")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x1D25810", Offset = "0x1D25810", VA = "0x1D25810")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1D25848", Offset = "0x1D25848", VA = "0x1D25848")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x1D25880", Offset = "0x1D25880", VA = "0x1D25880")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1D258D0", Offset = "0x1D258D0", VA = "0x1D258D0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1D2527C", Offset = "0x1D2527C", VA = "0x1D2527C")]
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
				[Address(RVA = "0x1D24B98", Offset = "0x1D24B98", VA = "0x1D24B98")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x1D24C9C", Offset = "0x1D24C9C", VA = "0x1D24C9C")]
				set
				{
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1D24D2C", Offset = "0x1D24D2C", VA = "0x1D24D2C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1D24EDC", Offset = "0x1D24EDC", VA = "0x1D24EDC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1D250B0", Offset = "0x1D250B0", VA = "0x1D250B0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1D25210", Offset = "0x1D25210", VA = "0x1D25210")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1D25238", Offset = "0x1D25238", VA = "0x1D25238")]
			public Bone()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1D252B8", Offset = "0x1D252B8", VA = "0x1D252B8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1D25310", Offset = "0x1D25310", VA = "0x1D25310")]
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
			[Address(RVA = "0x1D256A8", Offset = "0x1D256A8", VA = "0x1D256A8")]
			public Node()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1D256AC", Offset = "0x1D256AC", VA = "0x1D256AC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1D256DC", Offset = "0x1D256DC", VA = "0x1D256DC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B2C0", Offset = "0x97B2C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B2C0", Offset = "0x97B2C0")]
		public float IKPositionWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97B314", Offset = "0x97B314")]
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
			[Address(RVA = "0x2049D3C", Offset = "0x2049D3C", VA = "0x2049D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98269C", Offset = "0x98269C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x2049D44", Offset = "0x2049D44", VA = "0x2049D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9826AC", Offset = "0x9826AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2049C6C", Offset = "0x2049C6C", VA = "0x2049C6C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x204494C", Offset = "0x204494C", VA = "0x204494C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x204486C", Offset = "0x204486C", VA = "0x204486C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2049CE4", Offset = "0x2049CE4", VA = "0x2049CE4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2049CF0", Offset = "0x2049CF0", VA = "0x2049CF0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2049CFC", Offset = "0x2049CFC", VA = "0x2049CFC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2049D04", Offset = "0x2049D04", VA = "0x2049D04")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2049D34", Offset = "0x2049D34", VA = "0x2049D34")]
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
		[Address(RVA = "0x2049D50", Offset = "0x2049D50", VA = "0x2049D50")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2049D68", Offset = "0x2049D68", VA = "0x2049D68")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2049EA0", Offset = "0x2049EA0", VA = "0x2049EA0")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2049F48", Offset = "0x2049F48", VA = "0x2049F48")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x204A1D0", Offset = "0x204A1D0", VA = "0x204A1D0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B374", Offset = "0x97B374")]
		public float poleWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B38C", Offset = "0x97B38C")]
		public float clampWeight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B3A4", Offset = "0x97B3A4")]
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
			[Address(RVA = "0x204A264", Offset = "0x204A264", VA = "0x204A264")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x204A2A0", Offset = "0x204A2A0", VA = "0x204A2A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x204AD50", Offset = "0x204AD50", VA = "0x204AD50", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x204B134", Offset = "0x204B134", VA = "0x204B134", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x204A1E8", Offset = "0x204A1E8", VA = "0x204A1E8")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x204A2DC", Offset = "0x204A2DC", VA = "0x204A2DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x204A4FC", Offset = "0x204A4FC", VA = "0x204A4FC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x204AC9C", Offset = "0x204AC9C", VA = "0x204AC9C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x204AA2C", Offset = "0x204AA2C", VA = "0x204AA2C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x204AD58", Offset = "0x204AD58", VA = "0x204AD58")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x204B1A8", Offset = "0x204B1A8", VA = "0x204B1A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B3BC", Offset = "0x97B3BC")]
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
		[Address(RVA = "0x204B1FC", Offset = "0x204B1FC", VA = "0x204B1FC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x204B5E0", Offset = "0x204B5E0", VA = "0x204B5E0")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x204B694", Offset = "0x204B694", VA = "0x204B694", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x204B828", Offset = "0x204B828", VA = "0x204B828", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x204B9BC", Offset = "0x204B9BC", VA = "0x204B9BC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x204BA18", Offset = "0x204BA18", VA = "0x204BA18", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x204BA88", Offset = "0x204BA88", VA = "0x204BA88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x204BDF8", Offset = "0x204BDF8", VA = "0x204BDF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x204BE24", Offset = "0x204BE24", VA = "0x204BE24")]
		private void Solve()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x204BAEC", Offset = "0x204BAEC", VA = "0x204BAEC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x204BE94", Offset = "0x204BE94", VA = "0x204BE94")]
		private void Write()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x204C020", Offset = "0x204C020", VA = "0x204C020")]
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
		[Address(RVA = "0x204C1E4", Offset = "0x204C1E4", VA = "0x204C1E4")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x204C294", Offset = "0x204C294", VA = "0x204C294", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x204C318", Offset = "0x204C318", VA = "0x204C318", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x204C548", Offset = "0x204C548", VA = "0x204C548")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x204CB24", Offset = "0x204CB24", VA = "0x204CB24")]
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
			[Address(RVA = "0x204DA50", Offset = "0x204DA50", VA = "0x204DA50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x204CB2C", Offset = "0x204CB2C", VA = "0x204CB2C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x204D0F0", Offset = "0x204D0F0", VA = "0x204D0F0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x204D230", Offset = "0x204D230", VA = "0x204D230", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x204D2C4", Offset = "0x204D2C4", VA = "0x204D2C4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x204D7BC", Offset = "0x204D7BC", VA = "0x204D7BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x204DA58", Offset = "0x204DA58", VA = "0x204DA58")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x204CC08", Offset = "0x204CC08", VA = "0x204CC08")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x204D1DC", Offset = "0x204D1DC", VA = "0x204D1DC")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x204D9F4", Offset = "0x204D9F4", VA = "0x204D9F4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x204CF64", Offset = "0x204CF64", VA = "0x204CF64")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x204E0A8", Offset = "0x204E0A8", VA = "0x204E0A8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x204E11C", Offset = "0x204E11C", VA = "0x204E11C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x204E1E4", Offset = "0x204E1E4", VA = "0x204E1E4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x204E294", Offset = "0x204E294", VA = "0x204E294")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x204D56C", Offset = "0x204D56C", VA = "0x204D56C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x204D694", Offset = "0x204D694", VA = "0x204D694")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x204E398", Offset = "0x204E398", VA = "0x204E398")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x204DC78", Offset = "0x204DC78", VA = "0x204DC78")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x204D1CC", Offset = "0x204D1CC", VA = "0x204D1CC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x204E928", Offset = "0x204E928", VA = "0x204E928")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x204E4DC", Offset = "0x204E4DC", VA = "0x204E4DC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x204DAD4", Offset = "0x204DAD4", VA = "0x204DAD4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x204DBB4", Offset = "0x204DBB4", VA = "0x204DBB4")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x204E9F4", Offset = "0x204E9F4", VA = "0x204E9F4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B3D4", Offset = "0x97B3D4")]
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
		[Address(RVA = "0x204EA8C", Offset = "0x204EA8C", VA = "0x204EA8C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x204F118", Offset = "0x204F118", VA = "0x204F118", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x204F1B0", Offset = "0x204F1B0", VA = "0x204F1B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x204F250", Offset = "0x204F250", VA = "0x204F250", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x204F35C", Offset = "0x204F35C", VA = "0x204F35C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x204F3F8", Offset = "0x204F3F8", VA = "0x204F3F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x204F828", Offset = "0x204F828", VA = "0x204F828", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x204FA38", Offset = "0x204FA38", VA = "0x204FA38", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x204F8D4", Offset = "0x204F8D4", VA = "0x204F8D4")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x204F5E4", Offset = "0x204F5E4", VA = "0x204F5E4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x204FAD0", Offset = "0x204FAD0", VA = "0x204FAD0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B3EC", Offset = "0x97B3EC")]
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
		[Address(RVA = "0x204FB50", Offset = "0x204FB50", VA = "0x204FB50")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x204FC40", Offset = "0x204FC40", VA = "0x204FC40")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x204FC9C", Offset = "0x204FC9C", VA = "0x204FC9C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2045B00", Offset = "0x2045B00", VA = "0x2045B00")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2044FE8", Offset = "0x2044FE8", VA = "0x2044FE8")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x204FDCC", Offset = "0x204FDCC", VA = "0x204FDCC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x204FF78", Offset = "0x204FF78", VA = "0x204FF78", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x20500E8", Offset = "0x20500E8", VA = "0x20500E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x20502F4", Offset = "0x20502F4", VA = "0x20502F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x20503CC", Offset = "0x20503CC", VA = "0x20503CC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x20504AC", Offset = "0x20504AC", VA = "0x20504AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x205061C", Offset = "0x205061C", VA = "0x205061C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x205077C", Offset = "0x205077C", VA = "0x205077C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x20509BC", Offset = "0x20509BC", VA = "0x20509BC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2050C88", Offset = "0x2050C88", VA = "0x2050C88", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2050CCC", Offset = "0x2050CCC", VA = "0x2050CCC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2050DB0", Offset = "0x2050DB0", VA = "0x2050DB0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B404", Offset = "0x97B404")]
		public float spineStiffness;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B41C", Offset = "0x97B41C")]
		public float pullBodyVertical;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B434", Offset = "0x97B434")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97B44C", Offset = "0x97B44C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x206197C", Offset = "0x206197C", VA = "0x206197C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x2061AC4", Offset = "0x2061AC4", VA = "0x2061AC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x2061ACC", Offset = "0x2061ACC", VA = "0x2061ACC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x2061AD4", Offset = "0x2061AD4", VA = "0x2061AD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x2061ADC", Offset = "0x2061ADC", VA = "0x2061ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x2061AE4", Offset = "0x2061AE4", VA = "0x2061AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x2061AEC", Offset = "0x2061AEC", VA = "0x2061AEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x2061AF4", Offset = "0x2061AF4", VA = "0x2061AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x2061AFC", Offset = "0x2061AFC", VA = "0x2061AFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x2061B04", Offset = "0x2061B04", VA = "0x2061B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x2061B3C", Offset = "0x2061B3C", VA = "0x2061B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x2061B74", Offset = "0x2061B74", VA = "0x2061B74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x2061BAC", Offset = "0x2061BAC", VA = "0x2061BAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x2061BE4", Offset = "0x2061BE4", VA = "0x2061BE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x2061C18", Offset = "0x2061C18", VA = "0x2061C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x2061C50", Offset = "0x2061C50", VA = "0x2061C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x2061C88", Offset = "0x2061C88", VA = "0x2061C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x2061CC0", Offset = "0x2061CC0", VA = "0x2061CC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2063E54", Offset = "0x2063E54", VA = "0x2063E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9826BC", Offset = "0x9826BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2063E60", Offset = "0x2063E60", VA = "0x2063E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9826CC", Offset = "0x9826CC")]
			private set
			{
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2061CF4", Offset = "0x2061CF4", VA = "0x2061CF4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2061E00", Offset = "0x2061E00", VA = "0x2061E00")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2061D48", Offset = "0x2061D48", VA = "0x2061D48")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2061E8C", Offset = "0x2061E8C", VA = "0x2061E8C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2061984", Offset = "0x2061984", VA = "0x2061984")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2061F5C", Offset = "0x2061F5C", VA = "0x2061F5C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2062014", Offset = "0x2062014", VA = "0x2062014")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x20620C8", Offset = "0x20620C8", VA = "0x20620C8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x206217C", Offset = "0x206217C", VA = "0x206217C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2062184", Offset = "0x2062184", VA = "0x2062184")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x20621B8", Offset = "0x20621B8", VA = "0x20621B8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2062280", Offset = "0x2062280", VA = "0x2062280", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x206242C", Offset = "0x206242C", VA = "0x206242C")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x20638D0", Offset = "0x20638D0", VA = "0x20638D0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2063CE4", Offset = "0x2063CE4", VA = "0x2063CE4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2063D44", Offset = "0x2063D44", VA = "0x2063D44")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2063B6C", Offset = "0x2063B6C", VA = "0x2063B6C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2063C28", Offset = "0x2063C28", VA = "0x2063C28")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2063E6C", Offset = "0x2063E6C", VA = "0x2063E6C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2063F44", Offset = "0x2063F44", VA = "0x2063F44", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2064044", Offset = "0x2064044", VA = "0x2064044")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x206416C", Offset = "0x206416C", VA = "0x206416C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x20642B0", Offset = "0x20642B0", VA = "0x20642B0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x20643E0", Offset = "0x20643E0", VA = "0x20643E0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2064624", Offset = "0x2064624", VA = "0x2064624", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x20646AC", Offset = "0x20646AC", VA = "0x20646AC")]
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
			[Address(RVA = "0x2064F70", Offset = "0x2064F70", VA = "0x2064F70", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2064F78", Offset = "0x2064F78", VA = "0x2064F78", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2064F80", Offset = "0x2064F80", VA = "0x2064F80", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x2065408", Offset = "0x2065408", VA = "0x2065408", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x20654D0", Offset = "0x20654D0", VA = "0x20654D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x20646BC", Offset = "0x20646BC", VA = "0x20646BC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2064878", Offset = "0x2064878", VA = "0x2064878")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x20649D8", Offset = "0x20649D8", VA = "0x20649D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2064A44", Offset = "0x2064A44", VA = "0x2064A44", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2064AC4", Offset = "0x2064AC4", VA = "0x2064AC4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2064E78", Offset = "0x2064E78", VA = "0x2064E78", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2064E80", Offset = "0x2064E80", VA = "0x2064E80", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2064F88", Offset = "0x2064F88", VA = "0x2064F88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2064F8C", Offset = "0x2064F8C", VA = "0x2064F8C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2064F90", Offset = "0x2064F90", VA = "0x2064F90")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2065524", Offset = "0x2065524", VA = "0x2065524")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x206583C", Offset = "0x206583C", VA = "0x206583C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2065A30", Offset = "0x2065A30", VA = "0x2065A30")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B45C", Offset = "0x97B45C")]
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
		[Address(RVA = "0x2065AA8", Offset = "0x2065AA8", VA = "0x2065AA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2065E90", Offset = "0x2065E90", VA = "0x2065E90")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2065F48", Offset = "0x2065F48", VA = "0x2065F48", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x20660DC", Offset = "0x20660DC", VA = "0x20660DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2066270", Offset = "0x2066270", VA = "0x2066270", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x20662CC", Offset = "0x20662CC", VA = "0x20662CC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x206633C", Offset = "0x206633C", VA = "0x206633C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x20666AC", Offset = "0x20666AC", VA = "0x20666AC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x20666D8", Offset = "0x20666D8", VA = "0x20666D8")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x20663A0", Offset = "0x20663A0", VA = "0x20663A0")]
		private void Read()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2066770", Offset = "0x2066770", VA = "0x2066770")]
		private void Write()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x20668FC", Offset = "0x20668FC", VA = "0x20668FC")]
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
			[Address(RVA = "0x20511A8", Offset = "0x20511A8", VA = "0x20511A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B474", Offset = "0x97B474")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B48C", Offset = "0x97B48C")]
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
			[Address(RVA = "0x2067C2C", Offset = "0x2067C2C", VA = "0x2067C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2066AB4", Offset = "0x2066AB4", VA = "0x2066AB4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2066B04", Offset = "0x2066B04", VA = "0x2066B04")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2066B50", Offset = "0x2066B50", VA = "0x2066B50", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2067024", Offset = "0x2067024", VA = "0x2067024", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x206796C", Offset = "0x206796C", VA = "0x206796C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2067A18", Offset = "0x2067A18", VA = "0x2067A18")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2067B90", Offset = "0x2067B90", VA = "0x2067B90")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2066E4C", Offset = "0x2066E4C", VA = "0x2066E4C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2067108", Offset = "0x2067108", VA = "0x2067108")]
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
				[Address(RVA = "0x2051444", Offset = "0x2051444", VA = "0x2051444")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x2051208", Offset = "0x2051208", VA = "0x2051208")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x2051210", Offset = "0x2051210", VA = "0x2051210")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x2051244", Offset = "0x2051244", VA = "0x2051244")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x205133C", Offset = "0x205133C", VA = "0x205133C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B4A4", Offset = "0x97B4A4")]
		public float bodyWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B4BC", Offset = "0x97B4BC")]
		public float headWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B4D4", Offset = "0x97B4D4")]
		public float eyesWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B4EC", Offset = "0x97B4EC")]
		public float clampWeight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B504", Offset = "0x97B504")]
		public float clampWeightHead;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B51C", Offset = "0x97B51C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B534", Offset = "0x97B534")]
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
			[Address(RVA = "0x20683E8", Offset = "0x20683E8", VA = "0x20683E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x20685B8", Offset = "0x20685B8", VA = "0x20685B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x20684C8", Offset = "0x20684C8", VA = "0x20684C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x20685DC", Offset = "0x20685DC", VA = "0x20685DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x20684D8", Offset = "0x20684D8", VA = "0x20684D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x2068654", Offset = "0x2068654", VA = "0x2068654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2067C48", Offset = "0x2067C48", VA = "0x2067C48")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2067C78", Offset = "0x2067C78", VA = "0x2067C78")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2067CD0", Offset = "0x2067CD0", VA = "0x2067CD0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2067D4C", Offset = "0x2067D4C", VA = "0x2067D4C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2067DE4", Offset = "0x2067DE4", VA = "0x2067DE4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2067EA4", Offset = "0x2067EA4", VA = "0x2067EA4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2067FA0", Offset = "0x2067FA0", VA = "0x2067FA0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x20680CC", Offset = "0x20680CC", VA = "0x20680CC")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x20680D8", Offset = "0x20680D8", VA = "0x20680D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x206821C", Offset = "0x206821C", VA = "0x206821C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2068678", Offset = "0x2068678", VA = "0x2068678", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x20688E8", Offset = "0x20688E8", VA = "0x20688E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2068A84", Offset = "0x2068A84", VA = "0x2068A84")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2068CE8", Offset = "0x2068CE8", VA = "0x2068CE8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2068FFC", Offset = "0x2068FFC", VA = "0x2068FFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x20690CC", Offset = "0x20690CC", VA = "0x20690CC")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x206926C", Offset = "0x206926C", VA = "0x206926C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2069490", Offset = "0x2069490", VA = "0x2069490")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2069844", Offset = "0x2069844", VA = "0x2069844")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2068B3C", Offset = "0x2068B3C", VA = "0x2068B3C")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2069AB4", Offset = "0x2069AB4", VA = "0x2069AB4")]
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
			[Address(RVA = "0x2051480", Offset = "0x2051480", VA = "0x2051480")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x205157C", Offset = "0x205157C", VA = "0x205157C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x20515AC", Offset = "0x20515AC", VA = "0x20515AC")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x20515E8", Offset = "0x20515E8", VA = "0x20515E8")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B54C", Offset = "0x97B54C")]
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
		[Address(RVA = "0x2069D18", Offset = "0x2069D18", VA = "0x2069D18")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2069E74", Offset = "0x2069E74", VA = "0x2069E74")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2069FB8", Offset = "0x2069FB8", VA = "0x2069FB8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2069FC4", Offset = "0x2069FC4", VA = "0x2069FC4")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2069FF4", Offset = "0x2069FF4", VA = "0x2069FF4")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x206A000", Offset = "0x206A000", VA = "0x206A000")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x206A008", Offset = "0x206A008", VA = "0x206A008", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x206A12C", Offset = "0x206A12C", VA = "0x206A12C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x206A248", Offset = "0x206A248", VA = "0x206A248", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x206A294", Offset = "0x206A294", VA = "0x206A294", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x206A2F4", Offset = "0x206A2F4", VA = "0x206A2F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x206A6EC", Offset = "0x206A6EC", VA = "0x206A6EC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x206A76C", Offset = "0x206A76C", VA = "0x206A76C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x206AB28", Offset = "0x206AB28", VA = "0x206AB28")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x206AC90", Offset = "0x206AC90", VA = "0x206AC90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x206ADF8", Offset = "0x206ADF8", VA = "0x206ADF8")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x206AD6C", Offset = "0x206AD6C", VA = "0x206AD6C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x206AEFC", Offset = "0x206AEFC", VA = "0x206AEFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x206B6D0", Offset = "0x206B6D0", VA = "0x206B6D0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x206B6D4", Offset = "0x206B6D4", VA = "0x206B6D4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x206B6D8", Offset = "0x206B6D8", VA = "0x206B6D8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x206B4E8", Offset = "0x206B4E8", VA = "0x206B4E8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2067AA0", Offset = "0x2067AA0", VA = "0x2067AA0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B788", Offset = "0x97B788")]
			public Transform target;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B7C0", Offset = "0x97B7C0")]
			public Transform bendGoal;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B7F8", Offset = "0x97B7F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B7F8", Offset = "0x97B7F8")]
			public float positionWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B84C", Offset = "0x97B84C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B84C", Offset = "0x97B84C")]
			public float rotationWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B8A0", Offset = "0x97B8A0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B8D8", Offset = "0x97B8D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B8D8", Offset = "0x97B8D8")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B92C", Offset = "0x97B92C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B92C", Offset = "0x97B92C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B980", Offset = "0x97B980")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B980", Offset = "0x97B980")]
			public float bendGoalWeight;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B9D4", Offset = "0x97B9D4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B9D4", Offset = "0x97B9D4")]
			public float swivelOffset;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BA30", Offset = "0x97BA30")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BA68", Offset = "0x97BA68")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BAA0", Offset = "0x97BAA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BAA0", Offset = "0x97BAA0")]
			public float armLengthMlp;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BAF8", Offset = "0x97BAF8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BB70", Offset = "0x97BB70")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BB80", Offset = "0x97BB80")]
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
				[Address(RVA = "0x20515F0", Offset = "0x20515F0", VA = "0x20515F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9826FC", Offset = "0x9826FC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600042B")]
				[Address(RVA = "0x20515FC", Offset = "0x20515FC", VA = "0x20515FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98270C", Offset = "0x98270C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x600042C")]
				[Address(RVA = "0x2051608", Offset = "0x2051608", VA = "0x2051608")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98271C", Offset = "0x98271C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600042D")]
				[Address(RVA = "0x2051614", Offset = "0x2051614", VA = "0x2051614")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98272C", Offset = "0x98272C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x2051620", Offset = "0x2051620", VA = "0x2051620")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x2051654", Offset = "0x2051654", VA = "0x2051654")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x2051694", Offset = "0x2051694", VA = "0x2051694")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x20516E0", Offset = "0x20516E0", VA = "0x20516E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x205172C", Offset = "0x205172C", VA = "0x205172C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x20520C0", Offset = "0x20520C0", VA = "0x20520C0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x205227C", Offset = "0x205227C", VA = "0x205227C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x20522A0", Offset = "0x20522A0", VA = "0x20522A0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x2052540", Offset = "0x2052540", VA = "0x2052540")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x2053FD4", Offset = "0x2053FD4", VA = "0x2053FD4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2054000", Offset = "0x2054000", VA = "0x2054000", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x20534D4", Offset = "0x20534D4", VA = "0x20534D4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x205368C", Offset = "0x205368C", VA = "0x205368C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x2054220", Offset = "0x2054220", VA = "0x2054220")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x2054344", Offset = "0x2054344", VA = "0x2054344")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BB90", Offset = "0x97BB90")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BBA0", Offset = "0x97BBA0")]
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
				[Address(RVA = "0x20544B4", Offset = "0x20544B4", VA = "0x20544B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98273C", Offset = "0x98273C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x20544BC", Offset = "0x20544BC", VA = "0x20544BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98274C", Offset = "0x98274C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x20544C4", Offset = "0x20544C4", VA = "0x20544C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98275C", Offset = "0x98275C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x20544CC", Offset = "0x20544CC", VA = "0x20544CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98276C", Offset = "0x98276C")]
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
			[Address(RVA = "0x20544D4", Offset = "0x20544D4", VA = "0x20544D4")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x20544DC", Offset = "0x20544DC", VA = "0x20544DC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x205479C", Offset = "0x205479C", VA = "0x205479C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2054830", Offset = "0x2054830", VA = "0x2054830")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2054A00", Offset = "0x2054A00", VA = "0x2054A00")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2054A54", Offset = "0x2054A54", VA = "0x2054A54")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2053E94", Offset = "0x2053E94", VA = "0x2053E94")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2054B8C", Offset = "0x2054B8C", VA = "0x2054B8C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x2054CCC", Offset = "0x2054CCC", VA = "0x2054CCC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x2054434", Offset = "0x2054434", VA = "0x2054434")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BBC0", Offset = "0x97BBC0")]
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
				[Address(RVA = "0x2054CF4", Offset = "0x2054CF4", VA = "0x2054CF4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x2054D08", Offset = "0x2054D08", VA = "0x2054D08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98277C", Offset = "0x98277C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x2054D10", Offset = "0x2054D10", VA = "0x2054D10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98278C", Offset = "0x98278C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x2054D18", Offset = "0x2054D18", VA = "0x2054D18")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2054E50", Offset = "0x2054E50", VA = "0x2054E50")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2054E98", Offset = "0x2054E98", VA = "0x2054E98")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x2055064", Offset = "0x2055064", VA = "0x2055064")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x20551D8", Offset = "0x20551D8", VA = "0x20551D8")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x2055330", Offset = "0x2055330", VA = "0x2055330")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BBD0", Offset = "0x97BBD0")]
			public Transform target;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BC08", Offset = "0x97BC08")]
			public Transform bendGoal;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BC40", Offset = "0x97BC40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BC40", Offset = "0x97BC40")]
			public float positionWeight;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BC94", Offset = "0x97BC94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BC94", Offset = "0x97BC94")]
			public float rotationWeight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BCE8", Offset = "0x97BCE8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BCE8", Offset = "0x97BCE8")]
			public float bendGoalWeight;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BD3C", Offset = "0x97BD3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BD3C", Offset = "0x97BD3C")]
			public float swivelOffset;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BD98", Offset = "0x97BD98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BD98", Offset = "0x97BD98")]
			public float bendToTargetWeight;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BDEC", Offset = "0x97BDEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BDEC", Offset = "0x97BDEC")]
			public float legLengthMlp;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BE44", Offset = "0x97BE44")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BEEC", Offset = "0x97BEEC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BEFC", Offset = "0x97BEFC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BF0C", Offset = "0x97BF0C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97BF1C", Offset = "0x97BF1C")]
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
				[Address(RVA = "0x205546C", Offset = "0x205546C", VA = "0x205546C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98279C", Offset = "0x98279C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x2055478", Offset = "0x2055478", VA = "0x2055478")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9827AC", Offset = "0x9827AC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x2055484", Offset = "0x2055484", VA = "0x2055484")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9827BC", Offset = "0x9827BC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x2055490", Offset = "0x2055490", VA = "0x2055490")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9827CC", Offset = "0x9827CC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x205549C", Offset = "0x205549C", VA = "0x205549C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9827DC", Offset = "0x9827DC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x20554A4", Offset = "0x20554A4", VA = "0x20554A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9827EC", Offset = "0x9827EC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x20554B0", Offset = "0x20554B0", VA = "0x20554B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x20554E4", Offset = "0x20554E4", VA = "0x20554E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x205551C", Offset = "0x205551C", VA = "0x205551C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x2055554", Offset = "0x2055554", VA = "0x2055554")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x205558C", Offset = "0x205558C", VA = "0x205558C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x20555CC", Offset = "0x20555CC", VA = "0x20555CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9827FC", Offset = "0x9827FC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x20555D8", Offset = "0x20555D8", VA = "0x20555D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98280C", Offset = "0x98280C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x20555E4", Offset = "0x20555E4", VA = "0x20555E4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x2055C04", Offset = "0x2055C04", VA = "0x2055C04", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x20561D8", Offset = "0x20561D8", VA = "0x20561D8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2056188", Offset = "0x2056188", VA = "0x2056188")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2056018", Offset = "0x2056018", VA = "0x2056018")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x20565C0", Offset = "0x20565C0", VA = "0x20565C0")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2056A7C", Offset = "0x2056A7C", VA = "0x2056A7C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x205675C", Offset = "0x205675C", VA = "0x205675C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2056D74", Offset = "0x2056D74", VA = "0x2056D74", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2056F90", Offset = "0x2056F90", VA = "0x2056F90", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2056FDC", Offset = "0x2056FDC", VA = "0x2056FDC")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97BF2C", Offset = "0x97BF2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BF2C", Offset = "0x97BF2C")]
			public float weight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BF80", Offset = "0x97BF80")]
			public float footDistance;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BFB8", Offset = "0x97BFB8")]
			public float stepThreshold;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97BFF0", Offset = "0x97BFF0")]
			public float angleThreshold;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C028", Offset = "0x97C028")]
			public float comAngleMlp;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C060", Offset = "0x97C060")]
			public float maxVelocity;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C098", Offset = "0x97C098")]
			public float velocityFactor;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C0D0", Offset = "0x97C0D0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C0D0", Offset = "0x97C0D0")]
			public float maxLegStretch;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C128", Offset = "0x97C128")]
			public float rootSpeed;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C160", Offset = "0x97C160")]
			public float stepSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C198", Offset = "0x97C198")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C1D0", Offset = "0x97C1D0")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C208", Offset = "0x97C208")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C240", Offset = "0x97C240")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C240", Offset = "0x97C240")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C298", Offset = "0x97C298")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C2D0", Offset = "0x97C2D0")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C308", Offset = "0x97C308")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C380", Offset = "0x97C380")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C3B8", Offset = "0x97C3B8")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97C3F0", Offset = "0x97C3F0")]
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
				[Address(RVA = "0x20570B8", Offset = "0x20570B8", VA = "0x20570B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98281C", Offset = "0x98281C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x20570C4", Offset = "0x20570C4", VA = "0x20570C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98282C", Offset = "0x98282C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x2058CF4", Offset = "0x2058CF4", VA = "0x2058CF4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x2058D34", Offset = "0x2058D34", VA = "0x2058D34")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x2058D78", Offset = "0x2058D78", VA = "0x2058D78")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x2058DB8", Offset = "0x2058DB8", VA = "0x2058DB8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x20570D0", Offset = "0x20570D0", VA = "0x20570D0")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x20573AC", Offset = "0x20573AC", VA = "0x20573AC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x205757C", Offset = "0x205757C", VA = "0x205757C")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x20575E0", Offset = "0x20575E0", VA = "0x20575E0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x2057828", Offset = "0x2057828", VA = "0x2057828")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x20578EC", Offset = "0x20578EC", VA = "0x20578EC")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x2058A6C", Offset = "0x2058A6C", VA = "0x2058A6C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x2058BA4", Offset = "0x2058BA4", VA = "0x2058BA4")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2058C28", Offset = "0x2058C28", VA = "0x2058C28")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2058DFC", Offset = "0x2058DFC", VA = "0x2058DFC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C400", Offset = "0x97C400")]
			public Transform headTarget;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C438", Offset = "0x97C438")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C470", Offset = "0x97C470")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C470", Offset = "0x97C470")]
			public float positionWeight;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C4C4", Offset = "0x97C4C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C4C4", Offset = "0x97C4C4")]
			public float rotationWeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C518", Offset = "0x97C518")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C518", Offset = "0x97C518")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C56C", Offset = "0x97C56C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C56C", Offset = "0x97C56C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C5C0", Offset = "0x97C5C0")]
			public Transform chestGoal;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C5F8", Offset = "0x97C5F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C5F8", Offset = "0x97C5F8")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C64C", Offset = "0x97C64C")]
			public float minHeadHeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C684", Offset = "0x97C684")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C684", Offset = "0x97C684")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C6D8", Offset = "0x97C6D8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C6D8", Offset = "0x97C6D8")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C72C", Offset = "0x97C72C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x97C72C", Offset = "0x97C72C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C72C", Offset = "0x97C72C")]
			public float neckStiffness;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C7A4", Offset = "0x97C7A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C7A4", Offset = "0x97C7A4")]
			public float rotateChestByHands;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C7F8", Offset = "0x97C7F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C7F8", Offset = "0x97C7F8")]
			public float chestClampWeight;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C84C", Offset = "0x97C84C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C84C", Offset = "0x97C84C")]
			public float headClampWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C8A0", Offset = "0x97C8A0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C8D8", Offset = "0x97C8D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C8D8", Offset = "0x97C8D8")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C92C", Offset = "0x97C92C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C92C", Offset = "0x97C92C")]
			public float maxRootAngle;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97C984", Offset = "0x97C984")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97C984", Offset = "0x97C984")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97CAC0", Offset = "0x97CAC0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97CAD0", Offset = "0x97CAD0")]
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
				[Address(RVA = "0x20589EC", Offset = "0x20589EC", VA = "0x20589EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x2058F18", Offset = "0x2058F18", VA = "0x2058F18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x2058F58", Offset = "0x2058F58", VA = "0x2058F58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x2058FAC", Offset = "0x2058FAC", VA = "0x2058FAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x2058A2C", Offset = "0x2058A2C", VA = "0x2058A2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x2058FEC", Offset = "0x2058FEC", VA = "0x2058FEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98283C", Offset = "0x98283C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x2059000", Offset = "0x2059000", VA = "0x2059000")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98284C", Offset = "0x98284C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x2059014", Offset = "0x2059014", VA = "0x2059014")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98285C", Offset = "0x98285C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x2059028", Offset = "0x2059028", VA = "0x2059028")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98286C", Offset = "0x98286C")]
				private set
				{
				}
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x205903C", Offset = "0x205903C", VA = "0x205903C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x2059A88", Offset = "0x2059A88", VA = "0x2059A88", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2059C94", Offset = "0x2059C94", VA = "0x2059C94", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x205A0E0", Offset = "0x205A0E0", VA = "0x205A0E0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x205A51C", Offset = "0x205A51C", VA = "0x205A51C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x205AC8C", Offset = "0x205AC8C", VA = "0x205AC8C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x205B30C", Offset = "0x205B30C", VA = "0x205B30C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x205B890", Offset = "0x205B890", VA = "0x205B890", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x205BA6C", Offset = "0x205BA6C", VA = "0x205BA6C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x205A278", Offset = "0x205A278", VA = "0x205A278")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x205B05C", Offset = "0x205B05C", VA = "0x205B05C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x205A934", Offset = "0x205A934", VA = "0x205A934")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x205BB04", Offset = "0x205BB04", VA = "0x205BB04")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x205B138", Offset = "0x205B138", VA = "0x205B138")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x205AE08", Offset = "0x205AE08", VA = "0x205AE08")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x205BCF8", Offset = "0x205BCF8", VA = "0x205BCF8")]
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
			[Address(RVA = "0x2052024", Offset = "0x2052024", VA = "0x2052024")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x20520A0", Offset = "0x20520A0", VA = "0x20520A0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x205BE68", Offset = "0x205BE68", VA = "0x205BE68")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x20545AC", Offset = "0x20545AC", VA = "0x20545AC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x20548D8", Offset = "0x20548D8", VA = "0x20548D8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x205BFEC", Offset = "0x205BFEC", VA = "0x205BFEC")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x2053550", Offset = "0x2053550", VA = "0x2053550")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x205C14C", Offset = "0x205C14C", VA = "0x205C14C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x2053A90", Offset = "0x2053A90", VA = "0x2053A90")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x205C204", Offset = "0x205C204", VA = "0x205C204")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x205B500", Offset = "0x205B500", VA = "0x205B500")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x205C36C", Offset = "0x205C36C", VA = "0x205C36C")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x205C3DC", Offset = "0x205C3DC", VA = "0x205C3DC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B564", Offset = "0x97B564")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97B564", Offset = "0x97B564")]
		public int LOD;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B5B8", Offset = "0x97B5B8")]
		public float scale;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B5F0", Offset = "0x97B5F0")]
		public bool plantFeet;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97B628", Offset = "0x97B628")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B638", Offset = "0x97B638")]
		public Spine spine;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B670", Offset = "0x97B670")]
		public Arm leftArm;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B6A8", Offset = "0x97B6A8")]
		public Arm rightArm;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B6E0", Offset = "0x97B6E0")]
		public Leg leftLeg;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B718", Offset = "0x97B718")]
		public Leg rightLeg;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97B750", Offset = "0x97B750")]
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
			[Address(RVA = "0x206EF90", Offset = "0x206EF90", VA = "0x206EF90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9826DC", Offset = "0x9826DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x206EF98", Offset = "0x206EF98", VA = "0x206EF98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9826EC", Offset = "0x9826EC")]
			private set
			{
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x206B6DC", Offset = "0x206B6DC", VA = "0x206B6DC")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x206BB98", Offset = "0x206BB98", VA = "0x206BB98")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x206BA24", Offset = "0x206BA24", VA = "0x206BA24")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x206BEFC", Offset = "0x206BEFC", VA = "0x206BEFC")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x206C040", Offset = "0x206C040", VA = "0x206C040")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x206C070", Offset = "0x206C070", VA = "0x206C070")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x206C120", Offset = "0x206C120", VA = "0x206C120")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x206C208", Offset = "0x206C208", VA = "0x206C208")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x206C9C4", Offset = "0x206C9C4", VA = "0x206C9C4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x206CB34", Offset = "0x206CB34", VA = "0x206CB34", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x206CD38", Offset = "0x206CD38", VA = "0x206CD38", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x206CDB4", Offset = "0x206CDB4", VA = "0x206CDB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x206CE30", Offset = "0x206CE30", VA = "0x206CE30", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x206D014", Offset = "0x206D014", VA = "0x206D014")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x206BDDC", Offset = "0x206BDDC", VA = "0x206BDDC")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x206C2FC", Offset = "0x206C2FC", VA = "0x206C2FC")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x206D1D4", Offset = "0x206D1D4", VA = "0x206D1D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x206D21C", Offset = "0x206D21C", VA = "0x206D21C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x206E6C0", Offset = "0x206E6C0", VA = "0x206E6C0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x206C460", Offset = "0x206C460", VA = "0x206C460")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x206D590", Offset = "0x206D590", VA = "0x206D590")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x206EA70", Offset = "0x206EA70", VA = "0x206EA70")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x206EAB8", Offset = "0x206EAB8", VA = "0x206EAB8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x206E570", Offset = "0x206E570", VA = "0x206E570")]
		private void Write()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x206EAFC", Offset = "0x206EAFC", VA = "0x206EAFC")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x206EFA0", Offset = "0x206EFA0", VA = "0x206EFA0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CAE0", Offset = "0x97CAE0")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1D17B14", Offset = "0x1D17B14", VA = "0x1D17B14")]
		public void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1D181FC", Offset = "0x1D181FC", VA = "0x1D181FC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1D1868C", Offset = "0x1D1868C", VA = "0x1D1868C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1D18750", Offset = "0x1D18750", VA = "0x1D18750")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1D1888C", Offset = "0x1D1888C", VA = "0x1D1888C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class TwistSolver
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CB18", Offset = "0x97CB18")]
		public Transform transform;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CB50", Offset = "0x97CB50")]
		public Transform parent;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CB88", Offset = "0x97CB88")]
		public Transform[] children;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97CBC0", Offset = "0x97CBC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CBC0", Offset = "0x97CBC0")]
		public float weight;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97CC14", Offset = "0x97CC14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CC14", Offset = "0x97CC14")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CC68", Offset = "0x97CC68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97CC68", Offset = "0x97CC68")]
		public float twistAngleOffset;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1D188F4", Offset = "0x1D188F4", VA = "0x1D188F4")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1D17D14", Offset = "0x1D17D14", VA = "0x1D17D14")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1D182C0", Offset = "0x1D182C0", VA = "0x1D182C0")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionEffector
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97CCC4", Offset = "0x97CCC4")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97CCD4", Offset = "0x97CCD4")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97CCE4", Offset = "0x97CCE4")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x206FE5C", Offset = "0x206FE5C", VA = "0x206FE5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98287C", Offset = "0x98287C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x206FE64", Offset = "0x206FE64", VA = "0x206FE64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98288C", Offset = "0x98288C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x206FE6C", Offset = "0x206FE6C", VA = "0x206FE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98289C", Offset = "0x98289C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x206FE74", Offset = "0x206FE74", VA = "0x206FE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9828AC", Offset = "0x9828AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x206FE80", Offset = "0x206FE80", VA = "0x206FE80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9828BC", Offset = "0x9828BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x206FE88", Offset = "0x206FE88", VA = "0x206FE88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9828CC", Offset = "0x9828CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x206FE90", Offset = "0x206FE90", VA = "0x206FE90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x2071748", Offset = "0x2071748", VA = "0x2071748")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x206FEFC", Offset = "0x206FEFC", VA = "0x206FEFC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x206FF94", Offset = "0x206FF94", VA = "0x206FF94")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2070050", Offset = "0x2070050", VA = "0x2070050")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x20701AC", Offset = "0x20701AC", VA = "0x20701AC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x20704E8", Offset = "0x20704E8", VA = "0x20704E8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x20705A4", Offset = "0x20705A4", VA = "0x20705A4")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x20705FC", Offset = "0x20705FC", VA = "0x20705FC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2070A78", Offset = "0x2070A78", VA = "0x2070A78")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2071108", Offset = "0x2071108", VA = "0x2071108")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x207134C", Offset = "0x207134C", VA = "0x207134C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x20715D4", Offset = "0x20715D4", VA = "0x20715D4")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2071784", Offset = "0x2071784", VA = "0x2071784")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CCF4", Offset = "0x97CCF4")]
		public LookAtIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CD2C", Offset = "0x97CD2C")]
		public float lerpSpeed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CD64", Offset = "0x97CD64")]
		public float weightSpeed;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x20719B0", Offset = "0x20719B0", VA = "0x20719B0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2071AD8", Offset = "0x2071AD8", VA = "0x2071AD8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2071B7C", Offset = "0x2071B7C", VA = "0x2071B7C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2071D84", Offset = "0x2071D84", VA = "0x2071D84")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2071E78", Offset = "0x2071E78", VA = "0x2071E78")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2071F40", Offset = "0x2071F40", VA = "0x2071F40")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978CC8", Offset = "0x978CC8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978CC8", Offset = "0x978CC8")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class InteractionEvent
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CE74", Offset = "0x97CE74")]
			public float time;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CEAC", Offset = "0x97CEAC")]
			public bool pause;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CEE4", Offset = "0x97CEE4")]
			public bool pickUp;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CF1C", Offset = "0x97CF1C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CF54", Offset = "0x97CF54")]
			public Message[] messages;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CF8C", Offset = "0x97CF8C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x205CB88", Offset = "0x205CB88", VA = "0x205CB88")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x205CD5C", Offset = "0x205CD5C", VA = "0x205CD5C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Message
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CFC4", Offset = "0x97CFC4")]
			public string function;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CFFC", Offset = "0x97CFFC")]
			public GameObject recipient;

			[Token(Token = "0x4000467")]
			private const string empty = "";

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x205CC58", Offset = "0x205CC58", VA = "0x205CC58")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x205CD64", Offset = "0x205CD64", VA = "0x205CD64")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D034", Offset = "0x97D034")]
			public Animator animator;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D06C", Offset = "0x97D06C")]
			public Animation animation;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D0A4", Offset = "0x97D0A4")]
			public string animationState;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D0DC", Offset = "0x97D0DC")]
			public float crossfadeTime;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D114", Offset = "0x97D114")]
			public int layer;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D14C", Offset = "0x97D14C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400046E")]
			private const string empty = "";

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x205C8F4", Offset = "0x205C8F4", VA = "0x205C8F4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x205C9E4", Offset = "0x205C9E4", VA = "0x205C9E4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x205CA98", Offset = "0x205CA98", VA = "0x205CA98")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x205CB74", Offset = "0x205CB74", VA = "0x205CB74")]
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
				[Token(Token = "0x4000472")]
				PositionWeight,
				[Token(Token = "0x4000473")]
				RotationWeight,
				[Token(Token = "0x4000474")]
				PositionOffsetX,
				[Token(Token = "0x4000475")]
				PositionOffsetY,
				[Token(Token = "0x4000476")]
				PositionOffsetZ,
				[Token(Token = "0x4000477")]
				Pull,
				[Token(Token = "0x4000478")]
				Reach,
				[Token(Token = "0x4000479")]
				RotateBoneWeight,
				[Token(Token = "0x400047A")]
				Push,
				[Token(Token = "0x400047B")]
				PushParent,
				[Token(Token = "0x400047C")]
				PoserWeight,
				[Token(Token = "0x400047D")]
				BendGoalWeight
			}

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D184", Offset = "0x97D184")]
			public Type type;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D1BC", Offset = "0x97D1BC")]
			public AnimationCurve curve;

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x205CDA8", Offset = "0x205CDA8", VA = "0x205CDA8")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x205CDD4", Offset = "0x205CDD4", VA = "0x205CDD4")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class Multiplier
		{
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D1F4", Offset = "0x97D1F4")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D22C", Offset = "0x97D22C")]
			public float multiplier;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D264", Offset = "0x97D264")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x205CD6C", Offset = "0x205CD6C", VA = "0x205CD6C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x205CDC4", Offset = "0x205CDC4", VA = "0x205CDC4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CDAC", Offset = "0x97CDAC")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CDE4", Offset = "0x97CDE4")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97CE1C", Offset = "0x97CE1C")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97CE54", Offset = "0x97CE54")]
		private float <length>k__BackingField;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97CE64", Offset = "0x97CE64")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1DFF198", Offset = "0x1DFF198", VA = "0x1DFF198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982A9C", Offset = "0x982A9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1DFF1A0", Offset = "0x1DFF1A0", VA = "0x1DFF1A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982AAC", Offset = "0x982AAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1DFF1A8", Offset = "0x1DFF1A8", VA = "0x1DFF1A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982ABC", Offset = "0x982ABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1DFF1B0", Offset = "0x1DFF1B0", VA = "0x1DFF1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982ACC", Offset = "0x982ACC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1DFF40C", Offset = "0x1DFF40C", VA = "0x1DFF40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1DFF380", Offset = "0x1DFF380", VA = "0x1DFF380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1DFEF58", Offset = "0x1DFEF58", VA = "0x1DFEF58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9828DC", Offset = "0x9828DC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1DFEFA0", Offset = "0x1DFEFA0", VA = "0x1DFEFA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982914", Offset = "0x982914")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1DFEFE8", Offset = "0x1DFEFE8", VA = "0x1DFEFE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98294C", Offset = "0x98294C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1DFF030", Offset = "0x1DFF030", VA = "0x1DFF030")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982984", Offset = "0x982984")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1DFF078", Offset = "0x1DFF078", VA = "0x1DFF078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9829BC", Offset = "0x9829BC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1DFF0C0", Offset = "0x1DFF0C0", VA = "0x1DFF0C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9829F4", Offset = "0x9829F4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1DFF108", Offset = "0x1DFF108", VA = "0x1DFF108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982A2C", Offset = "0x982A2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1DFF150", Offset = "0x1DFF150", VA = "0x1DFF150")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982A64", Offset = "0x982A64")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1DFF1B8", Offset = "0x1DFF1B8", VA = "0x1DFF1B8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1DFF498", Offset = "0x1DFF498", VA = "0x1DFF498")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1DFF604", Offset = "0x1DFF604", VA = "0x1DFF604")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1DFF6B8", Offset = "0x1DFF6B8", VA = "0x1DFF6B8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1DFF6C0", Offset = "0x1DFF6C0", VA = "0x1DFF6C0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1DFF874", Offset = "0x1DFF874", VA = "0x1DFF874")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1DFF87C", Offset = "0x1DFF87C", VA = "0x1DFF87C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1E00244", Offset = "0x1E00244", VA = "0x1E00244")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1E00464", Offset = "0x1E00464", VA = "0x1E00464")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1DFFD48", Offset = "0x1DFFD48", VA = "0x1DFFD48")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1DFF804", Offset = "0x1DFF804", VA = "0x1DFF804")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1E001DC", Offset = "0x1E001DC", VA = "0x1E001DC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1E00468", Offset = "0x1E00468", VA = "0x1E00468")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1E004D0", Offset = "0x1E004D0", VA = "0x1E004D0")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978D28", Offset = "0x978D28")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978D28", Offset = "0x978D28")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D29C", Offset = "0x97D29C")]
		public string targetTag;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D2D4", Offset = "0x97D2D4")]
		public float fadeInTime;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D30C", Offset = "0x97D30C")]
		public float speed;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D344", Offset = "0x97D344")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x97D37C", Offset = "0x97D37C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D37C", Offset = "0x97D37C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97D37C", Offset = "0x97D37C")]
		public Collider characterCollider;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x97D400", Offset = "0x97D400")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D400", Offset = "0x97D400")]
		public Transform FPSCamera;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D460", Offset = "0x97D460")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D498", Offset = "0x97D498")]
		public float camRaycastDistance;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97D4D0", Offset = "0x97D4D0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D4E0", Offset = "0x97D4E0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x97D4E0", Offset = "0x97D4E0")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D540", Offset = "0x97D540")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97D578", Offset = "0x97D578")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1E00778", Offset = "0x1E00778", VA = "0x1E00778")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1E0245C", Offset = "0x1E0245C", VA = "0x1E0245C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1E02464", Offset = "0x1E02464", VA = "0x1E02464")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1E0246C", Offset = "0x1E0246C", VA = "0x1E0246C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982C9C", Offset = "0x982C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1E02474", Offset = "0x1E02474", VA = "0x1E02474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CAC", Offset = "0x982CAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1E0247C", Offset = "0x1E0247C", VA = "0x1E0247C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CBC", Offset = "0x982CBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1E02484", Offset = "0x1E02484", VA = "0x1E02484")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CCC", Offset = "0x982CCC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1E00538", Offset = "0x1E00538", VA = "0x1E00538")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982ADC", Offset = "0x982ADC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1E00580", Offset = "0x1E00580", VA = "0x1E00580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982B14", Offset = "0x982B14")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1E005C8", Offset = "0x1E005C8", VA = "0x1E005C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982B4C", Offset = "0x982B4C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1E00610", Offset = "0x1E00610", VA = "0x1E00610")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982B84", Offset = "0x982B84")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1E00658", Offset = "0x1E00658", VA = "0x1E00658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982BBC", Offset = "0x982BBC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1E006A0", Offset = "0x1E006A0", VA = "0x1E006A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982BF4", Offset = "0x982BF4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1E006E8", Offset = "0x1E006E8", VA = "0x1E006E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982C2C", Offset = "0x982C2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1E00730", Offset = "0x1E00730", VA = "0x1E00730")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982C64", Offset = "0x982C64")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1E00920", Offset = "0x1E00920", VA = "0x1E00920")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1E009F0", Offset = "0x1E009F0", VA = "0x1E009F0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1E00AC0", Offset = "0x1E00AC0", VA = "0x1E00AC0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1E00B70", Offset = "0x1E00B70", VA = "0x1E00B70")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1E00C6C", Offset = "0x1E00C6C", VA = "0x1E00C6C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1E00D88", Offset = "0x1E00D88", VA = "0x1E00D88")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1E00E1C", Offset = "0x1E00E1C", VA = "0x1E00E1C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1E00EB0", Offset = "0x1E00EB0", VA = "0x1E00EB0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1E00F44", Offset = "0x1E00F44", VA = "0x1E00F44")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1E00FBC", Offset = "0x1E00FBC", VA = "0x1E00FBC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1E01034", Offset = "0x1E01034", VA = "0x1E01034")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1E010A0", Offset = "0x1E010A0", VA = "0x1E010A0")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1E0112C", Offset = "0x1E0112C", VA = "0x1E0112C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1E011C0", Offset = "0x1E011C0", VA = "0x1E011C0")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1E0128C", Offset = "0x1E0128C", VA = "0x1E0128C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1E01564", Offset = "0x1E01564", VA = "0x1E01564")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1E0175C", Offset = "0x1E0175C", VA = "0x1E0175C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1E01A00", Offset = "0x1E01A00", VA = "0x1E01A00")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1E01CD8", Offset = "0x1E01CD8", VA = "0x1E01CD8")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1E01D1C", Offset = "0x1E01D1C", VA = "0x1E01D1C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1E01D94", Offset = "0x1E01D94", VA = "0x1E01D94")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1E01EC8", Offset = "0x1E01EC8", VA = "0x1E01EC8")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1E0206C", Offset = "0x1E0206C", VA = "0x1E0206C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1E02310", Offset = "0x1E02310", VA = "0x1E02310")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1E01B14", Offset = "0x1E01B14", VA = "0x1E01B14")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1E02490", Offset = "0x1E02490", VA = "0x1E02490")]
		public void Start()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1E02CBC", Offset = "0x1E02CBC", VA = "0x1E02CBC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1E02CDC", Offset = "0x1E02CDC", VA = "0x1E02CDC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1E02CF8", Offset = "0x1E02CF8", VA = "0x1E02CF8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1E02D14", Offset = "0x1E02D14", VA = "0x1E02D14")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1E02D78", Offset = "0x1E02D78", VA = "0x1E02D78")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1E02EB4", Offset = "0x1E02EB4", VA = "0x1E02EB4")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1E02FC4", Offset = "0x1E02FC4", VA = "0x1E02FC4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1E03368", Offset = "0x1E03368", VA = "0x1E03368")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1E03494", Offset = "0x1E03494", VA = "0x1E03494")]
		public void Update()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1E036F4", Offset = "0x1E036F4", VA = "0x1E036F4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1E02A08", Offset = "0x1E02A08", VA = "0x1E02A08")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1E03830", Offset = "0x1E03830", VA = "0x1E03830")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1E03960", Offset = "0x1E03960", VA = "0x1E03960")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1E039F8", Offset = "0x1E039F8", VA = "0x1E039F8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1E03AD4", Offset = "0x1E03AD4", VA = "0x1E03AD4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1E03AF0", Offset = "0x1E03AF0", VA = "0x1E03AF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1E00828", Offset = "0x1E00828", VA = "0x1E00828")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1E01434", Offset = "0x1E01434", VA = "0x1E01434")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1E03EEC", Offset = "0x1E03EEC", VA = "0x1E03EEC")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978D88", Offset = "0x978D88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978D88", Offset = "0x978D88")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public enum RotationMode
		{
			[Token(Token = "0x40004A6")]
			TwoDOF,
			[Token(Token = "0x40004A7")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class Multiplier
		{
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D7D4", Offset = "0x97D7D4")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D80C", Offset = "0x97D80C")]
			public float multiplier;

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x205D508", Offset = "0x205D508", VA = "0x205D508")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D588", Offset = "0x97D588")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D5C0", Offset = "0x97D5C0")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D5F8", Offset = "0x97D5F8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D630", Offset = "0x97D630")]
		public Transform pivot;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D668", Offset = "0x97D668")]
		public RotationMode rotationMode;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D6A0", Offset = "0x97D6A0")]
		public Vector3 twistAxis;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D6D8", Offset = "0x97D6D8")]
		public float twistWeight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D710", Offset = "0x97D710")]
		public float swingWeight;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D748", Offset = "0x97D748")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97D748", Offset = "0x97D748")]
		public float threeDOFWeight;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D79C", Offset = "0x97D79C")]
		public bool rotateOnce;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1E046EC", Offset = "0x1E046EC", VA = "0x1E046EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982CDC", Offset = "0x982CDC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1E04734", Offset = "0x1E04734", VA = "0x1E04734")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982D14", Offset = "0x982D14")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1E0477C", Offset = "0x1E0477C", VA = "0x1E0477C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982D4C", Offset = "0x982D4C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1E047C4", Offset = "0x1E047C4", VA = "0x1E047C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982D84", Offset = "0x982D84")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1E0480C", Offset = "0x1E0480C", VA = "0x1E0480C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982DBC", Offset = "0x982DBC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1E04854", Offset = "0x1E04854", VA = "0x1E04854")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982DF4", Offset = "0x982DF4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1E0489C", Offset = "0x1E0489C", VA = "0x1E0489C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982E2C", Offset = "0x982E2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1E048E4", Offset = "0x1E048E4", VA = "0x1E048E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982E64", Offset = "0x982E64")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1DFFCD8", Offset = "0x1DFFCD8", VA = "0x1DFFCD8")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1E0492C", Offset = "0x1E0492C", VA = "0x1E0492C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1E049C4", Offset = "0x1E049C4", VA = "0x1E049C4")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1E0509C", Offset = "0x1E0509C", VA = "0x1E0509C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978DE8", Offset = "0x978DE8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978DE8", Offset = "0x978DE8")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D87C", Offset = "0x97D87C")]
			public bool use;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D8B4", Offset = "0x97D8B4")]
			public Vector2 offset;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D8EC", Offset = "0x97D8EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97D8EC", Offset = "0x97D8EC")]
			public float angleOffset;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D948", Offset = "0x97D948")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97D948", Offset = "0x97D948")]
			public float maxAngle;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D9A0", Offset = "0x97D9A0")]
			public float radius;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D9D8", Offset = "0x97D9D8")]
			public bool orbit;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DA10", Offset = "0x97DA10")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x205D878", Offset = "0x205D878", VA = "0x205D878")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0x205D884", Offset = "0x205D884", VA = "0x205D884")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x205D90C", Offset = "0x205D90C", VA = "0x205D90C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x205DD50", Offset = "0x205DD50", VA = "0x205DD50")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class CameraPosition
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DA48", Offset = "0x97DA48")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DA80", Offset = "0x97DA80")]
			public Vector3 direction;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DAB8", Offset = "0x97DAB8")]
			public float maxDistance;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DAF0", Offset = "0x97DAF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DAF0", Offset = "0x97DAF0")]
			public float maxAngle;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DB48", Offset = "0x97DB48")]
			public bool fixYAxis;

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x205D510", Offset = "0x205D510", VA = "0x205D510")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x205D604", Offset = "0x205D604", VA = "0x205D604")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x205D82C", Offset = "0x205D82C", VA = "0x205D82C")]
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
				[Token(Token = "0x40004BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DC48", Offset = "0x97DC48")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DC80", Offset = "0x97DC80")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000552")]
				[Address(RVA = "0x2419B70", Offset = "0x2419B70", VA = "0x2419B70")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DBA0", Offset = "0x97DBA0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DBD8", Offset = "0x97DBD8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DC10", Offset = "0x97DC10")]
			public Interaction[] interactions;

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x205DD64", Offset = "0x205DD64", VA = "0x205DD64")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x205DE18", Offset = "0x205DE18", VA = "0x205DE18")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97D844", Offset = "0x97D844")]
		public Range[] ranges;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1E050E8", Offset = "0x1E050E8", VA = "0x1E050E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982E9C", Offset = "0x982E9C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1E05130", Offset = "0x1E05130", VA = "0x1E05130")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982ED4", Offset = "0x982ED4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1E05178", Offset = "0x1E05178", VA = "0x1E05178")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982F0C", Offset = "0x982F0C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1E051C0", Offset = "0x1E051C0", VA = "0x1E051C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982F44", Offset = "0x982F44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1E05208", Offset = "0x1E05208", VA = "0x1E05208")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982F7C", Offset = "0x982F7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1E03194", Offset = "0x1E03194", VA = "0x1E03194")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1E05250", Offset = "0x1E05250", VA = "0x1E05250")]
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
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x1D20B64", Offset = "0x1D20B64", VA = "0x1D20B64")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1D20BBC", Offset = "0x1D20BBC", VA = "0x1D20BBC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1D20C0C", Offset = "0x1D20C0C", VA = "0x1D20C0C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1D20C58", Offset = "0x1D20C58", VA = "0x1D20C58")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1FF36D8", Offset = "0x1FF36D8", VA = "0x1FF36D8", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x982FB4", Offset = "0x982FB4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1FF3A68", Offset = "0x1FF3A68", VA = "0x1FF3A68", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1FF3A6C", Offset = "0x1FF3A6C", VA = "0x1FF3A6C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1FF3B74", Offset = "0x1FF3B74", VA = "0x1FF3B74", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1FF39FC", Offset = "0x1FF39FC", VA = "0x1FF39FC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1FF395C", Offset = "0x1FF395C", VA = "0x1FF395C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1FF3BE0", Offset = "0x1FF3BE0", VA = "0x1FF3BE0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x20411A4", Offset = "0x20411A4", VA = "0x20411A4", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2041280", Offset = "0x2041280", VA = "0x2041280", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2041468", Offset = "0x2041468", VA = "0x2041468", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2041564", Offset = "0x2041564", VA = "0x2041564", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x20412E4", Offset = "0x20412E4", VA = "0x20412E4")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x20418C4", Offset = "0x20418C4", VA = "0x20418C4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DCB8", Offset = "0x97DCB8")]
		public float weight;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DCD0", Offset = "0x97DCD0")]
		public float localRotationWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DCE8", Offset = "0x97DCE8")]
		public float localPositionWeight;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000564")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1E0CCE8", Offset = "0x1E0CCE8", VA = "0x1E0CCE8")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000566")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000567")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000568")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1E0CCF4", Offset = "0x1E0CCF4", VA = "0x1E0CCF4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1E0CD48", Offset = "0x1E0CD48", VA = "0x1E0CD48", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1E0CD84", Offset = "0x1E0CD84", VA = "0x1E0CD84", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1E0CD9C", Offset = "0x1E0CD9C", VA = "0x1E0CD9C")]
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
			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x205FE24", Offset = "0x205FE24", VA = "0x205FE24")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x205FFE8", Offset = "0x205FFE8", VA = "0x205FFE8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x20600C8", Offset = "0x20600C8", VA = "0x20600C8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009C")]
		public class Child
		{
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x205FC1C", Offset = "0x205FC1C", VA = "0x205FC1C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x205FC94", Offset = "0x205FC94", VA = "0x205FC94")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x205FDD4", Offset = "0x205FDD4", VA = "0x205FDD4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x978E48", Offset = "0x978E48")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000588")]
				[Address(RVA = "0x205FBCC", Offset = "0x205FBCC", VA = "0x205FBCC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600058A")]
				[Address(RVA = "0x205FC14", Offset = "0x205FC14", VA = "0x205FC14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x205F990", Offset = "0x205F990", VA = "0x205F990")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x205F9BC", Offset = "0x205F9BC", VA = "0x205F9BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x205F9C0", Offset = "0x205F9C0", VA = "0x205F9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x205FBD4", Offset = "0x205FBD4", VA = "0x205FBD4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DD00", Offset = "0x97DD00")]
		public IK ik;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DD38", Offset = "0x97DD38")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DD70", Offset = "0x97DD70")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DDA8", Offset = "0x97DDA8")]
		public float applyVelocity;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DDE0", Offset = "0x97DDE0")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000090")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1E0DA70", Offset = "0x1E0DA70", VA = "0x1E0DA70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1E0E4A4", Offset = "0x1E0E4A4", VA = "0x1E0E4A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1E0DA38", Offset = "0x1E0DA38", VA = "0x1E0DA38")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1E0DAE8", Offset = "0x1E0DAE8", VA = "0x1E0DAE8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1E0DC24", Offset = "0x1E0DC24", VA = "0x1E0DC24")]
		public void Start()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1E0DBAC", Offset = "0x1E0DBAC", VA = "0x1E0DBAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x982FEC", Offset = "0x982FEC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1E0E0E0", Offset = "0x1E0E0E0", VA = "0x1E0E0E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1E0E32C", Offset = "0x1E0E32C", VA = "0x1E0E32C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1E0E3E8", Offset = "0x1E0E3E8", VA = "0x1E0E3E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1E0E624", Offset = "0x1E0E624", VA = "0x1E0E624")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1E0E468", Offset = "0x1E0E468", VA = "0x1E0E468")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1E0E5E0", Offset = "0x1E0E5E0", VA = "0x1E0E5E0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1E0E6C4", Offset = "0x1E0E6C4", VA = "0x1E0E6C4")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1E0E658", Offset = "0x1E0E658", VA = "0x1E0E658")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1E0DB40", Offset = "0x1E0DB40", VA = "0x1E0DB40")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1E0E36C", Offset = "0x1E0E36C", VA = "0x1E0E36C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1E0E8F0", Offset = "0x1E0E8F0", VA = "0x1E0E8F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1E0EA2C", Offset = "0x1E0EA2C", VA = "0x1E0EA2C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97DE28", Offset = "0x97DE28")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000094")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1E10204", Offset = "0x1E10204", VA = "0x1E10204")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1E10210", Offset = "0x1E10210", VA = "0x1E10210")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1E1022C", Offset = "0x1E1022C", VA = "0x1E1022C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98309C", Offset = "0x98309C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1E10234", Offset = "0x1E10234", VA = "0x1E10234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9830AC", Offset = "0x9830AC")]
			private set
			{
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1E0FF04", Offset = "0x1E0FF04", VA = "0x1E0FF04")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1E0FF4C", Offset = "0x1E0FF4C", VA = "0x1E0FF4C")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1E0FF64", Offset = "0x1E0FF64", VA = "0x1E0FF64")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1E1015C", Offset = "0x1E1015C", VA = "0x1E1015C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1E101CC", Offset = "0x1E101CC", VA = "0x1E101CC")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000594")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1E10084", Offset = "0x1E10084", VA = "0x1E10084")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1E10240", Offset = "0x1E10240", VA = "0x1E10240")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1E10244", Offset = "0x1E10244", VA = "0x1E10244")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1E10278", Offset = "0x1E10278", VA = "0x1E10278")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1E102F4", Offset = "0x1E102F4", VA = "0x1E102F4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1E10488", Offset = "0x1E10488", VA = "0x1E10488")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1E104F8", Offset = "0x1E104F8", VA = "0x1E104F8")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978E58", Offset = "0x978E58")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978E58", Offset = "0x978E58")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DE38", Offset = "0x97DE38")]
		public float limit;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DE54", Offset = "0x97DE54")]
		public float twistLimit;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1E1052C", Offset = "0x1E1052C", VA = "0x1E1052C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9830BC", Offset = "0x9830BC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1E10574", Offset = "0x1E10574", VA = "0x1E10574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9830F4", Offset = "0x9830F4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1E105BC", Offset = "0x1E105BC", VA = "0x1E105BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98312C", Offset = "0x98312C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1E10604", Offset = "0x1E10604", VA = "0x1E10604")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x983164", Offset = "0x983164")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1E1064C", Offset = "0x1E1064C", VA = "0x1E1064C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1E10690", Offset = "0x1E10690", VA = "0x1E10690")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1E10850", Offset = "0x1E10850", VA = "0x1E10850")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978EB8", Offset = "0x978EB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978EB8", Offset = "0x978EB8")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1E10890", Offset = "0x1E10890", VA = "0x1E10890")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98319C", Offset = "0x98319C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1E108D8", Offset = "0x1E108D8", VA = "0x1E108D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9831D4", Offset = "0x9831D4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1E10920", Offset = "0x1E10920", VA = "0x1E10920")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98320C", Offset = "0x98320C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1E10968", Offset = "0x1E10968", VA = "0x1E10968")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x983244", Offset = "0x983244")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1E109B0", Offset = "0x1E109B0", VA = "0x1E109B0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1E109B4", Offset = "0x1E109B4", VA = "0x1E109B4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1E10B38", Offset = "0x1E10B38", VA = "0x1E10B38")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978F18", Offset = "0x978F18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978F18", Offset = "0x978F18")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class ReachCone
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000097")]
			public Vector3 o
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x2060714", Offset = "0x2060714", VA = "0x2060714")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x206074C", Offset = "0x206074C", VA = "0x206074C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x2060788", Offset = "0x2060788", VA = "0x2060788")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x20607C4", Offset = "0x20607C4", VA = "0x20607C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x2060950", Offset = "0x2060950", VA = "0x2060950")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2060800", Offset = "0x2060800", VA = "0x2060800")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x2060960", Offset = "0x2060960", VA = "0x2060960")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class LimitPoint
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x20606D8", Offset = "0x20606D8", VA = "0x20606D8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DE80", Offset = "0x97DE80")]
		public float twistLimit;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DE9C", Offset = "0x97DE9C")]
		public int smoothIterations;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1E10B80", Offset = "0x1E10B80", VA = "0x1E10B80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98327C", Offset = "0x98327C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1E10BC8", Offset = "0x1E10BC8", VA = "0x1E10BC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9832B4", Offset = "0x9832B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1E10C10", Offset = "0x1E10C10", VA = "0x1E10C10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9832EC", Offset = "0x9832EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1E10C58", Offset = "0x1E10C58", VA = "0x1E10C58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x983324", Offset = "0x983324")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1E10CA0", Offset = "0x1E10CA0", VA = "0x1E10CA0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1E1119C", Offset = "0x1E1119C", VA = "0x1E1119C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1E11230", Offset = "0x1E11230", VA = "0x1E11230")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1E117A4", Offset = "0x1E117A4", VA = "0x1E117A4")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1E10D48", Offset = "0x1E10D48", VA = "0x1E10D48")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1E11B50", Offset = "0x1E11B50", VA = "0x1E11B50")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1E11F5C", Offset = "0x1E11F5C", VA = "0x1E11F5C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1E11FA0", Offset = "0x1E11FA0", VA = "0x1E11FA0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1E12000", Offset = "0x1E12000", VA = "0x1E12000")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1E11534", Offset = "0x1E11534", VA = "0x1E11534")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1E1206C", Offset = "0x1E1206C", VA = "0x1E1206C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1E12148", Offset = "0x1E12148", VA = "0x1E12148")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x978F78", Offset = "0x978F78")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x978F78", Offset = "0x978F78")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DEE4", Offset = "0x97DEE4")]
		public float twistLimit;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1D14E88", Offset = "0x1D14E88", VA = "0x1D14E88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x98335C", Offset = "0x98335C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1D14ED0", Offset = "0x1D14ED0", VA = "0x1D14ED0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x983394", Offset = "0x983394")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1D14F18", Offset = "0x1D14F18", VA = "0x1D14F18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9833CC", Offset = "0x9833CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1D14F60", Offset = "0x1D14F60", VA = "0x1D14F60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x983404", Offset = "0x983404")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1D14FA8", Offset = "0x1D14FA8", VA = "0x1D14FA8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1D14FC4", Offset = "0x1D14FC4", VA = "0x1D14FC4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1D15064", Offset = "0x1D15064", VA = "0x1D15064")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1D152A0", Offset = "0x1D152A0", VA = "0x1D152A0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x978FD8", Offset = "0x978FD8")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x1D1FC54", Offset = "0x1D1FC54", VA = "0x1D1FC54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x1D1FC9C", Offset = "0x1D1FC9C", VA = "0x1D1FC9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1D1FB58", Offset = "0x1D1FB58", VA = "0x1D1FB58")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1D1FB84", Offset = "0x1D1FB84", VA = "0x1D1FB84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1D1FB88", Offset = "0x1D1FB88", VA = "0x1D1FB88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1D1FC5C", Offset = "0x1D1FC5C", VA = "0x1D1FC5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DF10", Offset = "0x97DF10")]
		public AimIK ik;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DF48", Offset = "0x97DF48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97DF48", Offset = "0x97DF48")]
		public float weight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DF9C", Offset = "0x97DF9C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97DF9C", Offset = "0x97DF9C")]
		public Transform target;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97DFFC", Offset = "0x97DFFC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E034", Offset = "0x97E034")]
		public float weightSmoothTime;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97E06C", Offset = "0x97E06C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E06C", Offset = "0x97E06C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E0CC", Offset = "0x97E0CC")]
		public float maxRadiansDelta;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E104", Offset = "0x97E104")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E13C", Offset = "0x97E13C")]
		public float slerpSpeed;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E174", Offset = "0x97E174")]
		public float smoothDampTime;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E1AC", Offset = "0x97E1AC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E1E4", Offset = "0x97E1E4")]
		public float minDistance;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E21C", Offset = "0x97E21C")]
		public Vector3 offset;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97E254", Offset = "0x97E254")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97E254", Offset = "0x97E254")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E254", Offset = "0x97E254")]
		public float maxRootAngle;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E2D0", Offset = "0x97E2D0")]
		public bool turnToTarget;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E308", Offset = "0x97E308")]
		public float turnToTargetTime;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97E340", Offset = "0x97E340")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E340", Offset = "0x97E340")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E3A0", Offset = "0x97E3A0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700009C")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1FB07C8", Offset = "0x1FB07C8", VA = "0x1FB07C8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1FB073C", Offset = "0x1FB073C", VA = "0x1FB073C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1FB0858", Offset = "0x1FB0858", VA = "0x1FB0858")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1FB0F3C", Offset = "0x1FB0F3C", VA = "0x1FB0F3C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1FB1028", Offset = "0x1FB1028", VA = "0x1FB1028")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1FB1278", Offset = "0x1FB1278", VA = "0x1FB1278")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x98343C", Offset = "0x98343C")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1FB12F0", Offset = "0x1FB12F0", VA = "0x1FB12F0")]
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
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1D1FCA4", Offset = "0x1D1FCA4", VA = "0x1D1FCA4")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1D1FE30", Offset = "0x1D1FE30", VA = "0x1D1FE30")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1D1FE38", Offset = "0x1D1FE38", VA = "0x1D1FE38")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1FB1560", Offset = "0x1FB1560", VA = "0x1FB1560")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1FB1640", Offset = "0x1FB1640", VA = "0x1FB1640")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1FB16AC", Offset = "0x1FB16AC", VA = "0x1FB16AC")]
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
				[Token(Token = "0x400053C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E560", Offset = "0x97E560")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400053D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E598", Offset = "0x97E598")]
				public float weight;

				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x2419754", Offset = "0x2419754", VA = "0x2419754")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E410", Offset = "0x97E410")]
			public Transform transform;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E448", Offset = "0x97E448")]
			public Transform relativeTo;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E480", Offset = "0x97E480")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E4B8", Offset = "0x97E4B8")]
			public float verticalWeight;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E4F0", Offset = "0x97E4F0")]
			public float horizontalWeight;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E528", Offset = "0x97E528")]
			public float speed;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1D1FE54", Offset = "0x1D1FE54", VA = "0x1D1FE54")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1D20178", Offset = "0x1D20178", VA = "0x1D20178")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1D20188", Offset = "0x1D20188", VA = "0x1D20188")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E3D8", Offset = "0x97E3D8")]
		public Body[] bodies;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1FB17C8", Offset = "0x1FB17C8", VA = "0x1FB17C8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1FB1914", Offset = "0x1FB1914", VA = "0x1FB1914")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E5D0", Offset = "0x97E5D0")]
		public float tiltSpeed;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E608", Offset = "0x97E608")]
		public float tiltSensitivity;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E640", Offset = "0x97E640")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E678", Offset = "0x97E678")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1FBFB5C", Offset = "0x1FBFB5C", VA = "0x1FBFB5C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1FBFBA4", Offset = "0x1FBFBA4", VA = "0x1FBFBA4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1FBFD5C", Offset = "0x1FBFD5C", VA = "0x1FBFD5C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97E6B0", Offset = "0x97E6B0")]
		public float weight;

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1FBFD70", Offset = "0x1FBFD70", VA = "0x1FBFD70")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1FBFE48", Offset = "0x1FBFE48", VA = "0x1FBFE48")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1FC0070", Offset = "0x1FC0070", VA = "0x1FC0070")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1FC01A0", Offset = "0x1FC01A0", VA = "0x1FC01A0")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E6C8", Offset = "0x97E6C8")]
		public Animator animator;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E700", Offset = "0x97E700")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97E748", Offset = "0x97E748")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700009F")]
		public IK ik
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1FE7D0C", Offset = "0x1FE7D0C", VA = "0x1FE7D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9834EC", Offset = "0x9834EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1FE7D14", Offset = "0x1FE7D14", VA = "0x1FE7D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9834FC", Offset = "0x9834FC")]
			private set
			{
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1FE7D1C", Offset = "0x1FE7D1C", VA = "0x1FE7D1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1FE7ED8", Offset = "0x1FE7ED8", VA = "0x1FE7ED8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1FE8164", Offset = "0x1FE8164", VA = "0x1FE8164")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1FE82BC", Offset = "0x1FE82BC", VA = "0x1FE82BC")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1FE84AC", Offset = "0x1FE84AC", VA = "0x1FE84AC")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1FE86E4", Offset = "0x1FE86E4", VA = "0x1FE86E4")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1FE8990", Offset = "0x1FE8990", VA = "0x1FE8990")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x978FF8", Offset = "0x978FF8")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000A0")]
		public bool poseStored
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1FE7FD0", Offset = "0x1FE7FD0", VA = "0x1FE7FD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1FE833C", Offset = "0x1FE833C", VA = "0x1FE833C")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1FE7FF4", Offset = "0x1FE7FF4", VA = "0x1FE7FF4")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1FE89F8", Offset = "0x1FE89F8", VA = "0x1FE89F8")]
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
			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E7C8", Offset = "0x97E7C8")]
			public string name;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E800", Offset = "0x97E800")]
			public Collider collider;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E838", Offset = "0x97E838")]
			private float crossFadeTime;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97E884", Offset = "0x97E884")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97E894", Offset = "0x97E894")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97E8A4", Offset = "0x97E8A4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97E8B4", Offset = "0x97E8B4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A2")]
			public bool inProgress
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x1D22960", Offset = "0x1D22960", VA = "0x1D22960")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A3")]
			protected float crossFader
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x1D22974", Offset = "0x1D22974", VA = "0x1D22974")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98350C", Offset = "0x98350C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x1D2297C", Offset = "0x1D2297C", VA = "0x1D2297C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98351C", Offset = "0x98351C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected float timer
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x1D22984", Offset = "0x1D22984", VA = "0x1D22984")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98352C", Offset = "0x98352C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x1D2298C", Offset = "0x1D2298C", VA = "0x1D2298C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98353C", Offset = "0x98353C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected Vector3 force
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x1D22994", Offset = "0x1D22994", VA = "0x1D22994")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98354C", Offset = "0x98354C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x1D229A0", Offset = "0x1D229A0", VA = "0x1D229A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98355C", Offset = "0x98355C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x1D229AC", Offset = "0x1D229AC", VA = "0x1D229AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98356C", Offset = "0x98356C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x1D229B8", Offset = "0x1D229B8", VA = "0x1D229B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98357C", Offset = "0x98357C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1D229C4", Offset = "0x1D229C4", VA = "0x1D229C4")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1D22AF8", Offset = "0x1D22AF8", VA = "0x1D22AF8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000606")]
			protected abstract float GetLength();

			[Token(Token = "0x6000607")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000608")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1D22BCC", Offset = "0x1D22BCC", VA = "0x1D22BCC")]
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
				[Token(Token = "0x400055B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E96C", Offset = "0x97E96C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400055C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E9A4", Offset = "0x97E9A4")]
				public float weight;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x24198C4", Offset = "0x24198C4", VA = "0x24198C4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x2419974", Offset = "0x2419974", VA = "0x2419974")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x2419988", Offset = "0x2419988", VA = "0x2419988")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E8C4", Offset = "0x97E8C4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E8FC", Offset = "0x97E8FC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E934", Offset = "0x97E934")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1D22F08", Offset = "0x1D22F08", VA = "0x1D22F08", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1D23038", Offset = "0x1D23038", VA = "0x1D23038", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1D230A4", Offset = "0x1D230A4", VA = "0x1D230A4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1D2320C", Offset = "0x1D2320C", VA = "0x1D2320C")]
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
				[Token(Token = "0x4000562")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EA4C", Offset = "0x97EA4C")]
				public Transform bone;

				[Token(Token = "0x4000563")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EA84", Offset = "0x97EA84")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97EA84", Offset = "0x97EA84")]
				public float weight;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000615")]
				[Address(RVA = "0x241975C", Offset = "0x241975C", VA = "0x241975C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000616")]
				[Address(RVA = "0x2419874", Offset = "0x2419874", VA = "0x2419874")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000617")]
				[Address(RVA = "0x2419880", Offset = "0x2419880", VA = "0x2419880")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E9DC", Offset = "0x97E9DC")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EA14", Offset = "0x97EA14")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1D22BE0", Offset = "0x1D22BE0", VA = "0x1D22BE0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1D22C84", Offset = "0x1D22C84", VA = "0x1D22C84", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1D22CF0", Offset = "0x1D22CF0", VA = "0x1D22CF0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1D22EF4", Offset = "0x1D22EF4", VA = "0x1D22EF4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E758", Offset = "0x97E758")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97E790", Offset = "0x97E790")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A1")]
		public bool inProgress
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x204276C", Offset = "0x204276C", VA = "0x204276C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x204283C", Offset = "0x204283C", VA = "0x204283C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2042918", Offset = "0x2042918", VA = "0x2042918")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2042B74", Offset = "0x2042B74", VA = "0x2042B74")]
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
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EB48", Offset = "0x97EB48")]
			public string name;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EB80", Offset = "0x97EB80")]
			public Collider collider;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EBB8", Offset = "0x97EBB8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97EC04", Offset = "0x97EC04")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97EC14", Offset = "0x97EC14")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97EC24", Offset = "0x97EC24")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x97EC34", Offset = "0x97EC34")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A7")]
			protected float crossFader
			{
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x1D23220", Offset = "0x1D23220", VA = "0x1D23220")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98358C", Offset = "0x98358C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x1D23228", Offset = "0x1D23228", VA = "0x1D23228")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98359C", Offset = "0x98359C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected float timer
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x1D23230", Offset = "0x1D23230", VA = "0x1D23230")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835AC", Offset = "0x9835AC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x1D23238", Offset = "0x1D23238", VA = "0x1D23238")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835BC", Offset = "0x9835BC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 force
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x1D23240", Offset = "0x1D23240", VA = "0x1D23240")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835CC", Offset = "0x9835CC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x1D2324C", Offset = "0x1D2324C", VA = "0x1D2324C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835DC", Offset = "0x9835DC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected Vector3 point
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x1D23258", Offset = "0x1D23258", VA = "0x1D23258")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835EC", Offset = "0x9835EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x1D23264", Offset = "0x1D23264", VA = "0x1D23264")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835FC", Offset = "0x9835FC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1D23270", Offset = "0x1D23270", VA = "0x1D23270")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1D233B8", Offset = "0x1D233B8", VA = "0x1D233B8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000625")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000626")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000627")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x1D234A0", Offset = "0x1D234A0", VA = "0x1D234A0")]
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
				[Token(Token = "0x4000576")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ECEC", Offset = "0x97ECEC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ED24", Offset = "0x97ED24")]
				public float weight;

				[Token(Token = "0x4000578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600062D")]
				[Address(RVA = "0x2419990", Offset = "0x2419990", VA = "0x2419990")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600062E")]
				[Address(RVA = "0x2419A20", Offset = "0x2419A20", VA = "0x2419A20")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600062F")]
				[Address(RVA = "0x2419A34", Offset = "0x2419A34", VA = "0x2419A34")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EC44", Offset = "0x97EC44")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EC7C", Offset = "0x97EC7C")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ECB4", Offset = "0x97ECB4")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1D234B4", Offset = "0x1D234B4", VA = "0x1D234B4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1D23664", Offset = "0x1D23664", VA = "0x1D23664", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1D236D0", Offset = "0x1D236D0", VA = "0x1D236D0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1D23870", Offset = "0x1D23870", VA = "0x1D23870")]
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
				[Token(Token = "0x400057D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EDCC", Offset = "0x97EDCC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400057E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97EE04", Offset = "0x97EE04")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EE04", Offset = "0x97EE04")]
				public float weight;

				[Token(Token = "0x400057F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000634")]
				[Address(RVA = "0x2419A3C", Offset = "0x2419A3C", VA = "0x2419A3C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000635")]
				[Address(RVA = "0x2419B18", Offset = "0x2419B18", VA = "0x2419B18")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000636")]
				[Address(RVA = "0x2419B24", Offset = "0x2419B24", VA = "0x2419B24")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ED5C", Offset = "0x97ED5C")]
			public int curveIndex;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97ED94", Offset = "0x97ED94")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1D2388C", Offset = "0x1D2388C", VA = "0x1D2388C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1D23970", Offset = "0x1D23970", VA = "0x1D23970", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1D239DC", Offset = "0x1D239DC", VA = "0x1D239DC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1D23C98", Offset = "0x1D23C98", VA = "0x1D23C98")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EAD8", Offset = "0x97EAD8")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EB10", Offset = "0x97EB10")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2042ED4", Offset = "0x2042ED4", VA = "0x2042ED4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2042FA8", Offset = "0x2042FA8", VA = "0x2042FA8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x204320C", Offset = "0x204320C", VA = "0x204320C")]
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
				[Token(Token = "0x400058E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F034", Offset = "0x97F034")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400058F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F06C", Offset = "0x97F06C")]
				public float weight;

				[Token(Token = "0x600063D")]
				[Address(RVA = "0x2419B68", Offset = "0x2419B68", VA = "0x2419B68")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EEC8", Offset = "0x97EEC8")]
			public Transform transform;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EF00", Offset = "0x97EF00")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EF38", Offset = "0x97EF38")]
			public float speed;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EF70", Offset = "0x97EF70")]
			public float acceleration;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97EFA8", Offset = "0x97EFA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EFA8", Offset = "0x97EFA8")]
			public float matchVelocity;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EFFC", Offset = "0x97EFFC")]
			public float gravity;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x205C564", Offset = "0x205C564", VA = "0x205C564")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x205C61C", Offset = "0x205C61C", VA = "0x205C61C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x205C8D8", Offset = "0x205C8D8", VA = "0x205C8D8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EE58", Offset = "0x97EE58")]
		public Body[] bodies;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97EE90", Offset = "0x97EE90")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x206F278", Offset = "0x206F278", VA = "0x206F278")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x206F2F4", Offset = "0x206F2F4", VA = "0x206F2F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x206F3B4", Offset = "0x206F3B4", VA = "0x206F3B4")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97F0A4", Offset = "0x97F0A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F0A4", Offset = "0x97F0A4")]
		public Transform target;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97F104", Offset = "0x97F104")]
		public float weight;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F11C", Offset = "0x97F11C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F154", Offset = "0x97F154")]
		public float weightSmoothTime;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97F18C", Offset = "0x97F18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F18C", Offset = "0x97F18C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F1EC", Offset = "0x97F1EC")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F224", Offset = "0x97F224")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F25C", Offset = "0x97F25C")]
		public float slerpSpeed;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F294", Offset = "0x97F294")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F2CC", Offset = "0x97F2CC")]
		public float minDistance;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x97F304", Offset = "0x97F304")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F304", Offset = "0x97F304")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97F304", Offset = "0x97F304")]
		public float maxRootAngle;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000AB")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1E06908", Offset = "0x1E06908", VA = "0x1E06908")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1E06894", Offset = "0x1E06894", VA = "0x1E06894")]
		private void Start()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1E06998", Offset = "0x1E06998", VA = "0x1E06998")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1E06EDC", Offset = "0x1E06EDC", VA = "0x1E06EDC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1E06FC8", Offset = "0x1E06FC8", VA = "0x1E06FC8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1E071C0", Offset = "0x1E071C0", VA = "0x1E071C0")]
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
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F3F0", Offset = "0x97F3F0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F428", Offset = "0x97F428")]
			public float spring;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F460", Offset = "0x97F460")]
			public bool x;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F498", Offset = "0x97F498")]
			public bool y;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F4D0", Offset = "0x97F4D0")]
			public bool z;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F508", Offset = "0x97F508")]
			public float minX;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F540", Offset = "0x97F540")]
			public float maxX;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F578", Offset = "0x97F578")]
			public float minY;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F5B0", Offset = "0x97F5B0")]
			public float maxY;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F5E8", Offset = "0x97F5E8")]
			public float minZ;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F620", Offset = "0x97F620")]
			public float maxZ;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x205ED94", Offset = "0x205ED94", VA = "0x205ED94")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x205EEEC", Offset = "0x205EEEC", VA = "0x205EEEC")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x205EF64", Offset = "0x205EF64", VA = "0x205EF64")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x205EFBC", Offset = "0x205EFBC", VA = "0x205EFBC")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979064", Offset = "0x979064")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x205ED44", Offset = "0x205ED44", VA = "0x205ED44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x205ED8C", Offset = "0x205ED8C", VA = "0x205ED8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x205EBA8", Offset = "0x205EBA8", VA = "0x205EBA8")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x205EBD4", Offset = "0x205EBD4", VA = "0x205EBD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x205EBD8", Offset = "0x205EBD8", VA = "0x205EBD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x205ED4C", Offset = "0x205ED4C", VA = "0x205ED4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F380", Offset = "0x97F380")]
		public float weight;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F3B8", Offset = "0x97F3B8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1E0A3EC", Offset = "0x1E0A3EC", VA = "0x1E0A3EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000645")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1E09148", Offset = "0x1E09148", VA = "0x1E09148", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1E0A418", Offset = "0x1E0A418", VA = "0x1E0A418")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x98360C", Offset = "0x98360C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1E0A490", Offset = "0x1E0A490", VA = "0x1E0A490")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1E0A56C", Offset = "0x1E0A56C", VA = "0x1E0A56C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1E094DC", Offset = "0x1E094DC", VA = "0x1E094DC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1E09620", Offset = "0x1E09620", VA = "0x1E09620")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979074", Offset = "0x979074")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x205F160", Offset = "0x205F160", VA = "0x205F160", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x205F1A8", Offset = "0x205F1A8", VA = "0x205F1A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x205EFC4", Offset = "0x205EFC4", VA = "0x205EFC4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x205EFF0", Offset = "0x205EFF0", VA = "0x205EFF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x205EFF4", Offset = "0x205EFF4", VA = "0x205EFF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x205F168", Offset = "0x205F168", VA = "0x205F168", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F658", Offset = "0x97F658")]
		public float weight;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F690", Offset = "0x97F690")]
		public VRIK ik;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AF")]
		protected float deltaTime
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x1E0A62C", Offset = "0x1E0A62C", VA = "0x1E0A62C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000657")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1E0A658", Offset = "0x1E0A658", VA = "0x1E0A658", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1E0A684", Offset = "0x1E0A684", VA = "0x1E0A684")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9836BC", Offset = "0x9836BC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1E0A6FC", Offset = "0x1E0A6FC", VA = "0x1E0A6FC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1E0A7D8", Offset = "0x1E0A7D8", VA = "0x1E0A7D8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1E0A908", Offset = "0x1E0A908", VA = "0x1E0A908")]
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
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x205F1B0", Offset = "0x205F1B0", VA = "0x205F1B0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x205F3CC", Offset = "0x205F3CC", VA = "0x205F3CC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1E0A918", Offset = "0x1E0A918", VA = "0x1E0A918")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1E0A9DC", Offset = "0x1E0A9DC", VA = "0x1E0A9DC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1E0AA98", Offset = "0x1E0AA98", VA = "0x1E0AA98")]
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
				[Token(Token = "0x40005CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F8A4", Offset = "0x97F8A4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F8DC", Offset = "0x97F8DC")]
				public float weight;

				[Token(Token = "0x600066E")]
				[Address(RVA = "0x2419B78", Offset = "0x2419B78", VA = "0x2419B78")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F700", Offset = "0x97F700")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F738", Offset = "0x97F738")]
			public Transform raycastTo;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F770", Offset = "0x97F770")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97F770", Offset = "0x97F770")]
			public float raycastRadius;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F7C4", Offset = "0x97F7C4")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F7FC", Offset = "0x97F7FC")]
			public float smoothTimeIn;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F834", Offset = "0x97F834")]
			public float smoothTimeOut;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F86C", Offset = "0x97F86C")]
			public LayerMask layers;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x205F3D4", Offset = "0x205F3D4", VA = "0x205F3D4")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x205F518", Offset = "0x205F518", VA = "0x205F518")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x205F610", Offset = "0x205F610", VA = "0x205F610")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x205F7E0", Offset = "0x205F7E0", VA = "0x205F7E0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F6C8", Offset = "0x97F6C8")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1E0B458", Offset = "0x1E0B458", VA = "0x1E0B458", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1E0B4E0", Offset = "0x1E0B4E0", VA = "0x1E0B4E0")]
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
				[Token(Token = "0x40005EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FC68", Offset = "0x97FC68")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FCA0", Offset = "0x97FCA0")]
				public float weight;

				[Token(Token = "0x600067E")]
				[Address(RVA = "0x2419B80", Offset = "0x2419B80", VA = "0x2419B80")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FB6C", Offset = "0x97FB6C")]
			public Vector3 offset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FBA4", Offset = "0x97FBA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97FBA4", Offset = "0x97FBA4")]
			public float additivity;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FBF8", Offset = "0x97FBF8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FC30", Offset = "0x97FC30")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x206026C", Offset = "0x206026C", VA = "0x206026C")]
			public void Start()
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x20602BC", Offset = "0x20602BC", VA = "0x20602BC")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x2060480", Offset = "0x2060480", VA = "0x2060480")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public enum Handedness
		{
			[Token(Token = "0x40005ED")]
			Right,
			[Token(Token = "0x40005EE")]
			Left
		}

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F914", Offset = "0x97F914")]
		public AimIK aimIK;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F94C", Offset = "0x97F94C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F984", Offset = "0x97F984")]
		public Handedness handedness;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F9BC", Offset = "0x97F9BC")]
		public bool twoHanded;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97F9F4", Offset = "0x97F9F4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FA2C", Offset = "0x97FA2C")]
		public float magnitudeRandom;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FA64", Offset = "0x97FA64")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FA9C", Offset = "0x97FA9C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FAD4", Offset = "0x97FAD4")]
		public float blendTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FB0C", Offset = "0x97FB0C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x97FB0C", Offset = "0x97FB0C")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B2")]
		public bool isFinished
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1E0ED50", Offset = "0x1E0ED50", VA = "0x1E0ED50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1E0F7EC", Offset = "0x1E0F7EC", VA = "0x1E0F7EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1E0F82C", Offset = "0x1E0F82C", VA = "0x1E0F82C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1E0F7AC", Offset = "0x1E0F7AC", VA = "0x1E0F7AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1E0F7CC", Offset = "0x1E0F7CC", VA = "0x1E0F7CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1E0ED80", Offset = "0x1E0ED80", VA = "0x1E0ED80")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1E0EDAC", Offset = "0x1E0EDAC", VA = "0x1E0EDAC")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1E0EEF4", Offset = "0x1E0EEF4", VA = "0x1E0EEF4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1E0F86C", Offset = "0x1E0F86C", VA = "0x1E0F86C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1E0F920", Offset = "0x1E0F920", VA = "0x1E0F920")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1E0F95C", Offset = "0x1E0F95C", VA = "0x1E0F95C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1E0FB48", Offset = "0x1E0FB48", VA = "0x1E0FB48")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FCD8", Offset = "0x97FCD8")]
		public float weight;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FD10", Offset = "0x97FD10")]
		public float offset;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1D154B0", Offset = "0x1D154B0", VA = "0x1D154B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1D155B8", Offset = "0x1D155B8", VA = "0x1D155B8")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1D156A0", Offset = "0x1D156A0", VA = "0x1D156A0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1D159F0", Offset = "0x1D159F0", VA = "0x1D159F0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1D15A64", Offset = "0x1D15A64", VA = "0x1D15A64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1D15B94", Offset = "0x1D15B94", VA = "0x1D15B94")]
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
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FD48", Offset = "0x97FD48")]
			public float scaleMlp;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FD80", Offset = "0x97FD80")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FDB8", Offset = "0x97FDB8")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FDF0", Offset = "0x97FDF0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FE28", Offset = "0x97FE28")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FE60", Offset = "0x97FE60")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FE98", Offset = "0x97FE98")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x97FED0", Offset = "0x97FED0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FED0", Offset = "0x97FED0")]
			public Vector3 headOffset;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FF20", Offset = "0x97FF20")]
			public Vector3 handOffset;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FF58", Offset = "0x97FF58")]
			public float footForwardOffset;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FF90", Offset = "0x97FF90")]
			public float footInwardOffset;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x97FFC8", Offset = "0x97FFC8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x97FFC8", Offset = "0x97FFC8")]
			public float footHeadingOffset;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980024", Offset = "0x980024")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x98003C", Offset = "0x98003C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x24192AC", Offset = "0x24192AC", VA = "0x24192AC")]
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
				[Token(Token = "0x400060D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400060E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400060F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000696")]
				[Address(RVA = "0x2419B88", Offset = "0x2419B88", VA = "0x2419B88")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000697")]
				[Address(RVA = "0x2419C48", Offset = "0x2419C48", VA = "0x2419C48")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x24192A4", Offset = "0x24192A4", VA = "0x24192A4")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1D1CA40", Offset = "0x1D1CA40", VA = "0x1D1CA40")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1D1CAC8", Offset = "0x1D1CAC8", VA = "0x1D1CAC8")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1D1CC00", Offset = "0x1D1CC00", VA = "0x1D1CC00")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1D1CB14", Offset = "0x1D1CB14", VA = "0x1D1CB14")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1D1ACAC", Offset = "0x1D1ACAC", VA = "0x1D1ACAC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1D1CC18", Offset = "0x1D1CC18", VA = "0x1D1CC18")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1D1BF38", Offset = "0x1D1BF38", VA = "0x1D1BF38")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1D1D45C", Offset = "0x1D1D45C", VA = "0x1D1D45C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1D1D8CC", Offset = "0x1D1D8CC", VA = "0x1D1D8CC")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1D1DB04", Offset = "0x1D1DB04", VA = "0x1D1DB04")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1D1E1CC", Offset = "0x1D1E1CC", VA = "0x1D1E1CC")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1D1DF60", Offset = "0x1D1DF60", VA = "0x1D1DF60")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1D1E448", Offset = "0x1D1E448", VA = "0x1D1E448")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1D1E6A4", Offset = "0x1D1E6A4", VA = "0x1D1E6A4")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1D1E794", Offset = "0x1D1E794", VA = "0x1D1E794")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D3")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1D1EAB0", Offset = "0x1D1EAB0", VA = "0x1D1EAB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1D1EB0C", Offset = "0x1D1EB0C", VA = "0x1D1EB0C")]
		private void Update()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1D1EB40", Offset = "0x1D1EB40", VA = "0x1D1EB40")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1D1EC7C", Offset = "0x1D1EC7C", VA = "0x1D1EC7C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x980054", Offset = "0x980054")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B7")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1D1F384", Offset = "0x1D1F384", VA = "0x1D1F384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98376C", Offset = "0x98376C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1D1F390", Offset = "0x1D1F390", VA = "0x1D1F390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98377C", Offset = "0x98377C")]
			private set
			{
			}
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1D1F39C", Offset = "0x1D1F39C", VA = "0x1D1F39C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1D1D22C", Offset = "0x1D1D22C", VA = "0x1D1D22C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1D1D710", Offset = "0x1D1D710", VA = "0x1D1D710")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1D1F4AC", Offset = "0x1D1F4AC", VA = "0x1D1F4AC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1D1F8C8", Offset = "0x1D1F8C8", VA = "0x1D1F8C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1D1F9F8", Offset = "0x1D1F9F8", VA = "0x1D1F9F8")]
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
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1D209E8", Offset = "0x1D209E8", VA = "0x1D209E8")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1D20B5C", Offset = "0x1D20B5C", VA = "0x1D20B5C")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1FEFBE4", Offset = "0x1FEFBE4", VA = "0x1FEFBE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1FEFC40", Offset = "0x1FEFC40", VA = "0x1FEFC40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1FEFCBC", Offset = "0x1FEFCBC", VA = "0x1FEFCBC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1FEFDA0", Offset = "0x1FEFDA0", VA = "0x1FEFDA0")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1FB06B0", Offset = "0x1FB06B0", VA = "0x1FB06B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1FB0734", Offset = "0x1FB0734", VA = "0x1FB0734")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980074", Offset = "0x980074")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1FB171C", Offset = "0x1FB171C", VA = "0x1FB171C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1FB1794", Offset = "0x1FB1794", VA = "0x1FB1794")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1D152B0", Offset = "0x1D152B0", VA = "0x1D152B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1D152F4", Offset = "0x1D152F4", VA = "0x1D152F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1D154A8", Offset = "0x1D154A8", VA = "0x1D154A8")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9800AC", Offset = "0x9800AC")]
		public AimPoser aimPoser;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9800E4", Offset = "0x9800E4")]
		public AimIK aim;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98011C", Offset = "0x98011C")]
		public LookAtIK lookAt;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980154", Offset = "0x980154")]
		public Animator animator;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98018C", Offset = "0x98018C")]
		public float crossfadeTime;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9801C4", Offset = "0x9801C4")]
		public float minAimDistance;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1D15BA8", Offset = "0x1D15BA8", VA = "0x1D15BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1D15BEC", Offset = "0x1D15BEC", VA = "0x1D15BEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1D15D54", Offset = "0x1D15D54", VA = "0x1D15D54")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1D15F00", Offset = "0x1D15F00", VA = "0x1D15F00")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1D1603C", Offset = "0x1D1603C", VA = "0x1D1603C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1D160B8", Offset = "0x1D160B8", VA = "0x1D160B8")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1D170BC", Offset = "0x1D170BC", VA = "0x1D170BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1D1722C", Offset = "0x1D1722C", VA = "0x1D1722C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1D173C0", Offset = "0x1D173C0", VA = "0x1D173C0")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9801FC", Offset = "0x9801FC")]
		public Animator animator;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x980234", Offset = "0x980234")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x98026C", Offset = "0x98026C")]
		public float lookAtWeight;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980284", Offset = "0x980284")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x98029C", Offset = "0x98029C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9802B4", Offset = "0x9802B4")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9802CC", Offset = "0x9802CC")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9802E4", Offset = "0x9802E4")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9802FC", Offset = "0x9802FC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x980314", Offset = "0x980314")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x98034C", Offset = "0x98034C")]
		public float footPositionWeight;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980364", Offset = "0x980364")]
		public float footRotationWeight;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x98037C", Offset = "0x98037C")]
		public Transform handTargetBiped;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9803B4", Offset = "0x9803B4")]
		public float handPositionWeight;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9803CC", Offset = "0x9803CC")]
		public float handRotationWeight;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1FB81DC", Offset = "0x1FB81DC", VA = "0x1FB81DC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1FB85E4", Offset = "0x1FB85E4", VA = "0x1FB85E4")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9803E4", Offset = "0x9803E4")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000B8")]
		public Vector3 velocity
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1E073C8", Offset = "0x1E073C8", VA = "0x1E073C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98378C", Offset = "0x98378C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1E073D4", Offset = "0x1E073D4", VA = "0x1E073D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98379C", Offset = "0x98379C")]
			private set
			{
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1E073E0", Offset = "0x1E073E0", VA = "0x1E073E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1E0741C", Offset = "0x1E0741C", VA = "0x1E0741C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1E07C90", Offset = "0x1E07C90", VA = "0x1E07C90")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1E07A40", Offset = "0x1E07A40", VA = "0x1E07A40")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1E07D8C", Offset = "0x1E07D8C", VA = "0x1E07D8C")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B9")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1E07DB8", Offset = "0x1E07DB8", VA = "0x1E07DB8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1E07E3C", Offset = "0x1E07E3C", VA = "0x1E07E3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1E08060", Offset = "0x1E08060", VA = "0x1E08060")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979084", Offset = "0x979084")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x205E8DC", Offset = "0x205E8DC", VA = "0x205E8DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x205E924", Offset = "0x205E924", VA = "0x205E924", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x205E5E0", Offset = "0x205E5E0", VA = "0x205E5E0")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x205E60C", Offset = "0x205E60C", VA = "0x205E60C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x205E610", Offset = "0x205E610", VA = "0x205E610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x205E8E4", Offset = "0x205E8E4", VA = "0x205E8E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000BA")]
		public bool isStepping
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1E08074", Offset = "0x1E08074", VA = "0x1E08074")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public Vector3 position
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1E07D58", Offset = "0x1E07D58", VA = "0x1E07D58")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1E08088", Offset = "0x1E08088", VA = "0x1E08088")]
			set
			{
			}
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1E080D8", Offset = "0x1E080D8", VA = "0x1E080D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1E08304", Offset = "0x1E08304", VA = "0x1E08304")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1E084A0", Offset = "0x1E084A0", VA = "0x1E084A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1E086D4", Offset = "0x1E086D4", VA = "0x1E086D4")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1E08948", Offset = "0x1E08948", VA = "0x1E08948")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1E08AC0", Offset = "0x1E08AC0", VA = "0x1E08AC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1E08620", Offset = "0x1E08620", VA = "0x1E08620")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9837AC", Offset = "0x9837AC")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1E08CBC", Offset = "0x1E08CBC", VA = "0x1E08CBC")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1E08D20", Offset = "0x1E08D20", VA = "0x1E08D20")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1E08DF0", Offset = "0x1E08DF0", VA = "0x1E08DF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1E09044", Offset = "0x1E09044", VA = "0x1E09044")]
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
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9804B4", Offset = "0x9804B4")]
			public int animationLayer;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9804EC", Offset = "0x9804EC")]
			public string animationState;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980524", Offset = "0x980524")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98055C", Offset = "0x98055C")]
			public Transform warpFrom;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980594", Offset = "0x980594")]
			public Transform warpTo;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9805CC", Offset = "0x9805CC")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum EffectorMode
		{
			[Token(Token = "0x400068C")]
			PositionOffset,
			[Token(Token = "0x400068D")]
			Position
		}

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9803F4", Offset = "0x9803F4")]
		public Animator animator;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98042C", Offset = "0x98042C")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x980464", Offset = "0x980464")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980464", Offset = "0x980464")]
		public Warp[] warps;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1FB191C", Offset = "0x1FB191C", VA = "0x1FB191C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1FB1948", Offset = "0x1FB1948", VA = "0x1FB1948")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1FB1B88", Offset = "0x1FB1B88", VA = "0x1FB1B88", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1FB1E4C", Offset = "0x1FB1E4C", VA = "0x1FB1E4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1FB1EEC", Offset = "0x1FB1EEC", VA = "0x1FB1EEC")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1FB1EF4", Offset = "0x1FB1EF4", VA = "0x1FB1EF4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1FB1F50", Offset = "0x1FB1F50", VA = "0x1FB1F50")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1FB20EC", Offset = "0x1FB20EC", VA = "0x1FB20EC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1FB22F4", Offset = "0x1FB22F4", VA = "0x1FB22F4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980604", Offset = "0x980604")]
		public float headLookWeight;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1FB2308", Offset = "0x1FB2308", VA = "0x1FB2308", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1FB24D4", Offset = "0x1FB24D4", VA = "0x1FB24D4", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1FB2550", Offset = "0x1FB2550", VA = "0x1FB2550")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1FB2644", Offset = "0x1FB2644", VA = "0x1FB2644")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1FB268C", Offset = "0x1FB268C", VA = "0x1FB268C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1FB2A78", Offset = "0x1FB2A78", VA = "0x1FB2A78")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1FB2900", Offset = "0x1FB2900", VA = "0x1FB2900")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1FB2CD4", Offset = "0x1FB2CD4", VA = "0x1FB2CD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1FB2E04", Offset = "0x1FB2E04", VA = "0x1FB2E04")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1FC1CF4", Offset = "0x1FC1CF4", VA = "0x1FC1CF4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1FC1D58", Offset = "0x1FC1D58", VA = "0x1FC1D58", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1FC1F94", Offset = "0x1FC1F94", VA = "0x1FC1F94")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1FC2088", Offset = "0x1FC2088", VA = "0x1FC2088")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BE")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1FC2AE4", Offset = "0x1FC2AE4", VA = "0x1FC2AE4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1FC2B68", Offset = "0x1FC2B68", VA = "0x1FC2B68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1FC28E4", Offset = "0x1FC28E4", VA = "0x1FC28E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1FC2958", Offset = "0x1FC2958", VA = "0x1FC2958")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1FC2BEC", Offset = "0x1FC2BEC", VA = "0x1FC2BEC")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x98061C", Offset = "0x98061C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1FE8A90", Offset = "0x1FE8A90", VA = "0x1FE8A90", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1FE8EF0", Offset = "0x1FE8EF0", VA = "0x1FE8EF0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1FE8EF8", Offset = "0x1FE8EF8", VA = "0x1FE8EF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1FE8FB4", Offset = "0x1FE8FB4", VA = "0x1FE8FB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1FE9338", Offset = "0x1FE9338", VA = "0x1FE9338")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1FE93E4", Offset = "0x1FE93E4", VA = "0x1FE93E4")]
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
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1D204B4", Offset = "0x1D204B4", VA = "0x1D204B4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1D20538", Offset = "0x1D20538", VA = "0x1D20538")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1FECE78", Offset = "0x1FECE78", VA = "0x1FECE78")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1FECFD0", Offset = "0x1FECFD0", VA = "0x1FECFD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1FED074", Offset = "0x1FED074", VA = "0x1FED074")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1FED078", Offset = "0x1FED078", VA = "0x1FED078")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1FED088", Offset = "0x1FED088", VA = "0x1FED088")]
		private void Start()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1FED0FC", Offset = "0x1FED0FC", VA = "0x1FED0FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1FED1DC", Offset = "0x1FED1DC", VA = "0x1FED1DC")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980634", Offset = "0x980634")]
		public Transform target;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98066C", Offset = "0x98066C")]
		public Transform pin;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9806A4", Offset = "0x9806A4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9806DC", Offset = "0x9806DC")]
		public AimIK aim;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980714", Offset = "0x980714")]
		public float weight;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98074C", Offset = "0x98074C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980784", Offset = "0x980784")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1FED1E4", Offset = "0x1FED1E4", VA = "0x1FED1E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1FED240", Offset = "0x1FED240", VA = "0x1FED240")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1FED3E4", Offset = "0x1FED3E4", VA = "0x1FED3E4")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1FEF56C", Offset = "0x1FEF56C", VA = "0x1FEF56C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1FEF644", Offset = "0x1FEF644", VA = "0x1FEF644")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1FEF6D4", Offset = "0x1FEF6D4", VA = "0x1FEF6D4")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1FEFAAC", Offset = "0x1FEFAAC", VA = "0x1FEFAAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1FEFBDC", Offset = "0x1FEFBDC", VA = "0x1FEFBDC")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9807BC", Offset = "0x9807BC")]
		public float aimWeight;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9807D4", Offset = "0x9807D4")]
		public float sightWeight;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9807EC", Offset = "0x9807EC")]
		public float maxAngle;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980808", Offset = "0x980808")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1FEFDA8", Offset = "0x1FEFDA8", VA = "0x1FEFDA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1FEFF6C", Offset = "0x1FEFF6C", VA = "0x1FEFF6C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1FEFF78", Offset = "0x1FEFF78", VA = "0x1FEFF78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1FF01F8", Offset = "0x1FF01F8", VA = "0x1FF01F8")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1FF04C8", Offset = "0x1FF04C8", VA = "0x1FF04C8")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1FF0040", Offset = "0x1FF0040", VA = "0x1FF0040")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1FF0DBC", Offset = "0x1FF0DBC", VA = "0x1FF0DBC")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980820", Offset = "0x980820")]
		public float walkSpeed;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1FF0DDC", Offset = "0x1FF0DDC", VA = "0x1FF0DDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1FF0E68", Offset = "0x1FF0E68", VA = "0x1FF0E68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1FF0F54", Offset = "0x1FF0F54", VA = "0x1FF0F54")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1FF100C", Offset = "0x1FF100C", VA = "0x1FF100C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x2042B7C", Offset = "0x2042B7C", VA = "0x2042B7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2042CE0", Offset = "0x2042CE0", VA = "0x2042CE0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2042EC4", Offset = "0x2042EC4", VA = "0x2042EC4")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x204356C", Offset = "0x204356C", VA = "0x204356C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x20436B4", Offset = "0x20436B4", VA = "0x20436B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x20439F0", Offset = "0x20439F0", VA = "0x20439F0")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x206F4D8", Offset = "0x206F4D8", VA = "0x206F4D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x206F614", Offset = "0x206F614", VA = "0x206F614")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x206F720", Offset = "0x206F720", VA = "0x206F720")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x206F728", Offset = "0x206F728", VA = "0x206F728")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x206FE54", Offset = "0x206FE54", VA = "0x206FE54")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980838", Offset = "0x980838")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980870", Offset = "0x980870")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1E04350", Offset = "0x1E04350", VA = "0x1E04350")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1E043AC", Offset = "0x1E043AC", VA = "0x1E043AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1E046E4", Offset = "0x1E046E4", VA = "0x1E046E4")]
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
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000C0")]
			private Transform neck
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0x205E574", Offset = "0x205E574", VA = "0x205E574")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x205DE28", Offset = "0x205DE28", VA = "0x205DE28")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x205DE48", Offset = "0x205DE48", VA = "0x205DE48")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x205E3E0", Offset = "0x205E3E0", VA = "0x205E3E0")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x205E5CC", Offset = "0x205E5CC", VA = "0x205E5CC")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1E05E34", Offset = "0x1E05E34", VA = "0x1E05E34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1E05E70", Offset = "0x1E05E70", VA = "0x1E05E70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1E05ED8", Offset = "0x1E05ED8", VA = "0x1E05ED8")]
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
			[Token(Token = "0x4000719")]
			Position,
			[Token(Token = "0x400071A")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Absorber
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980988", Offset = "0x980988")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9809C0", Offset = "0x9809C0")]
			public float weight;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x205E92C", Offset = "0x205E92C", VA = "0x205E92C")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x205EA14", Offset = "0x205EA14", VA = "0x205EA14")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x205EA50", Offset = "0x205EA50", VA = "0x205EA50")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x205EAE8", Offset = "0x205EAE8", VA = "0x205EAE8")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x205EB5C", Offset = "0x205EB5C", VA = "0x205EB5C")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9808A8", Offset = "0x9808A8")]
		public Mode mode;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9808E0", Offset = "0x9808E0")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980918", Offset = "0x980918")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980950", Offset = "0x980950")]
		public float falloffSpeed;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1E0904C", Offset = "0x1E0904C", VA = "0x1E0904C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1E09174", Offset = "0x1E09174", VA = "0x1E09174")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1E09204", Offset = "0x1E09204", VA = "0x1E09204", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1E09318", Offset = "0x1E09318", VA = "0x1E09318")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1E093A4", Offset = "0x1E093A4", VA = "0x1E093A4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1E0960C", Offset = "0x1E0960C", VA = "0x1E0960C")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1E09630", Offset = "0x1E09630", VA = "0x1E09630")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1E096AC", Offset = "0x1E096AC", VA = "0x1E096AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1E09788", Offset = "0x1E09788", VA = "0x1E09788")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1E09848", Offset = "0x1E09848", VA = "0x1E09848")]
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
			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x205EB98", Offset = "0x205EB98", VA = "0x205EB98")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1E0A144", Offset = "0x1E0A144", VA = "0x1E0A144", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1E0A250", Offset = "0x1E0A250", VA = "0x1E0A250", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1E0A3DC", Offset = "0x1E0A3DC", VA = "0x1E0A3DC")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980A08", Offset = "0x980A08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980A08", Offset = "0x980A08")]
		public float weight;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980A5C", Offset = "0x980A5C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980A94", Offset = "0x980A94")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980AE0", Offset = "0x980AE0")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1E0AB00", Offset = "0x1E0AB00", VA = "0x1E0AB00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1E0ADD0", Offset = "0x1E0ADD0", VA = "0x1E0ADD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1E0B418", Offset = "0x1E0B418", VA = "0x1E0B418")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000C1")]
		private bool holding
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x1E0B9F4", Offset = "0x1E0B9F4", VA = "0x1E0B9F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private bool holdingLeft
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1E0BAD8", Offset = "0x1E0BAD8", VA = "0x1E0BAD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool holdingRight
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1E0BA2C", Offset = "0x1E0BA2C", VA = "0x1E0BA2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1E0B4F0", Offset = "0x1E0B4F0", VA = "0x1E0B4F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000744")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1E0BB84", Offset = "0x1E0BB84", VA = "0x1E0BB84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1E0BD3C", Offset = "0x1E0BD3C", VA = "0x1E0BD3C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1E0BEC0", Offset = "0x1E0BEC0", VA = "0x1E0BEC0")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1E0BF9C", Offset = "0x1E0BF9C", VA = "0x1E0BF9C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1E0C0DC", Offset = "0x1E0C0DC", VA = "0x1E0C0DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1E0C24C", Offset = "0x1E0C24C", VA = "0x1E0C24C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1E0C45C", Offset = "0x1E0C45C", VA = "0x1E0C45C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1E0C470", Offset = "0x1E0C470", VA = "0x1E0C470", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1E0C6D4", Offset = "0x1E0C6D4", VA = "0x1E0C6D4")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1E0C6E8", Offset = "0x1E0C6E8", VA = "0x1E0C6E8", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1E0C81C", Offset = "0x1E0C81C", VA = "0x1E0C81C")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1E0EB54", Offset = "0x1E0EB54", VA = "0x1E0EB54")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1E0EC34", Offset = "0x1E0EC34", VA = "0x1E0EC34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1E0ED48", Offset = "0x1E0ED48", VA = "0x1E0ED48")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1E0FBB8", Offset = "0x1E0FBB8", VA = "0x1E0FBB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1E0FC14", Offset = "0x1E0FC14", VA = "0x1E0FC14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1E0FC6C", Offset = "0x1E0FC6C", VA = "0x1E0FC6C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1E0FD4C", Offset = "0x1E0FD4C", VA = "0x1E0FD4C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x979094", Offset = "0x979094")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x2060688", Offset = "0x2060688", VA = "0x2060688", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x20606D0", Offset = "0x20606D0", VA = "0x20606D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x2060494", Offset = "0x2060494", VA = "0x2060494")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x20604C0", Offset = "0x20604C0", VA = "0x20604C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x20604C4", Offset = "0x20604C4", VA = "0x20604C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x2060690", Offset = "0x2060690", VA = "0x2060690", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1E0FD5C", Offset = "0x1E0FD5C", VA = "0x1E0FD5C")]
		private void Start()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1E0FE24", Offset = "0x1E0FE24", VA = "0x1E0FE24")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1E0FE6C", Offset = "0x1E0FE6C", VA = "0x1E0FE6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x98385C", Offset = "0x98385C")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1E0FEF4", Offset = "0x1E0FEF4", VA = "0x1E0FEF4")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9790A4", Offset = "0x9790A4")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076A")]
				[Address(RVA = "0x2060C20", Offset = "0x2060C20", VA = "0x2060C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076C")]
				[Address(RVA = "0x2060C68", Offset = "0x2060C68", VA = "0x2060C68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x2060AB0", Offset = "0x2060AB0", VA = "0x2060AB0")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x2060ADC", Offset = "0x2060ADC", VA = "0x2060ADC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x2060AE0", Offset = "0x2060AE0", VA = "0x2060AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x2060C28", Offset = "0x2060C28", VA = "0x2060C28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1D168C0", Offset = "0x1D168C0", VA = "0x1D168C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1D16978", Offset = "0x1D16978", VA = "0x1D16978")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x98390C", Offset = "0x98390C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1D169F0", Offset = "0x1D169F0", VA = "0x1D169F0")]
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
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x2060C70", Offset = "0x2060C70", VA = "0x2060C70")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x2060F4C", Offset = "0x2060F4C", VA = "0x2060F4C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x2061038", Offset = "0x2061038", VA = "0x2061038")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x20614CC", Offset = "0x20614CC", VA = "0x20614CC")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x20615C0", Offset = "0x20615C0", VA = "0x20615C0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x2061658", Offset = "0x2061658", VA = "0x2061658")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x20616EC", Offset = "0x20616EC", VA = "0x20616EC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x2061780", Offset = "0x2061780", VA = "0x2061780")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x2061940", Offset = "0x2061940", VA = "0x2061940")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1D173F0", Offset = "0x1D173F0", VA = "0x1D173F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1D1746C", Offset = "0x1D1746C", VA = "0x1D1746C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1D174DC", Offset = "0x1D174DC", VA = "0x1D174DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1D175A4", Offset = "0x1D175A4", VA = "0x1D175A4")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980B2C", Offset = "0x980B2C")]
		public Transform to;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980B64", Offset = "0x980B64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980B64", Offset = "0x980B64")]
		public float transferMotion;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1D175AC", Offset = "0x1D175AC", VA = "0x1D175AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1D175E8", Offset = "0x1D175E8", VA = "0x1D175E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1D1769C", Offset = "0x1D1769C", VA = "0x1D1769C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980BB8", Offset = "0x980BB8")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1D18998", Offset = "0x1D18998", VA = "0x1D18998")]
		private void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1D18BB0", Offset = "0x1D18BB0", VA = "0x1D18BB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1D18DA0", Offset = "0x1D18DA0", VA = "0x1D18DA0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1D18E6C", Offset = "0x1D18E6C", VA = "0x1D18E6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1D18F9C", Offset = "0x1D18F9C", VA = "0x1D18F9C")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1D19240", Offset = "0x1D19240", VA = "0x1D19240", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1D195CC", Offset = "0x1D195CC", VA = "0x1D195CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1D19838", Offset = "0x1D19838", VA = "0x1D19838")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1FF4D74", Offset = "0x1FF4D74", VA = "0x1FF4D74")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1FF509C", Offset = "0x1FF509C", VA = "0x1FF509C")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1FF511C", Offset = "0x1FF511C", VA = "0x1FF511C")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9790B4", Offset = "0x9790B4")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000791")]
				[Address(RVA = "0x205F940", Offset = "0x205F940", VA = "0x205F940", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000793")]
				[Address(RVA = "0x205F988", Offset = "0x205F988", VA = "0x205F988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x205F7F4", Offset = "0x205F7F4", VA = "0x205F7F4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x205F820", Offset = "0x205F820", VA = "0x205F820", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x205F824", Offset = "0x205F824", VA = "0x205F824", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x205F948", Offset = "0x205F948", VA = "0x205F948", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1E0C830", Offset = "0x1E0C830", VA = "0x1E0C830")]
		private void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1E0C974", Offset = "0x1E0C974", VA = "0x1E0C974")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1E0C8FC", Offset = "0x1E0C8FC", VA = "0x1E0C8FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9839BC", Offset = "0x9839BC")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1E0CAF8", Offset = "0x1E0CAF8", VA = "0x1E0CAF8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1E0CBE4", Offset = "0x1E0CBE4", VA = "0x1E0CBE4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1E0CCCC", Offset = "0x1E0CCCC", VA = "0x1E0CCCC")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980BF0", Offset = "0x980BF0")]
		public float weight;

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1FB6E3C", Offset = "0x1FB6E3C", VA = "0x1FB6E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1FB6EB0", Offset = "0x1FB6EB0", VA = "0x1FB6EB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1FB6F68", Offset = "0x1FB6F68", VA = "0x1FB6F68")]
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
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x2417E68", Offset = "0x2417E68", VA = "0x2417E68")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x2417FA8", Offset = "0x2417FA8", VA = "0x2417FA8")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1D17A90", Offset = "0x1D17A90", VA = "0x1D17A90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1D17B0C", Offset = "0x1D17B0C", VA = "0x1D17B0C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2043214", Offset = "0x2043214", VA = "0x2043214")]
		private void Update()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2043378", Offset = "0x2043378", VA = "0x2043378")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x204355C", Offset = "0x204355C", VA = "0x204355C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980C08", Offset = "0x980C08")]
		public VRIK ik;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980C40", Offset = "0x980C40")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980C78", Offset = "0x980C78")]
		public Transform headTracker;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980CB0", Offset = "0x980CB0")]
		public Transform bodyTracker;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980CE8", Offset = "0x980CE8")]
		public Transform leftHandTracker;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980D20", Offset = "0x980D20")]
		public Transform rightHandTracker;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980D58", Offset = "0x980D58")]
		public Transform leftFootTracker;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980D90", Offset = "0x980D90")]
		public Transform rightFootTracker;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x980DC8", Offset = "0x980DC8")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1D1AB2C", Offset = "0x1D1AB2C", VA = "0x1D1AB2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1D1CA58", Offset = "0x1D1CA58", VA = "0x1D1CA58")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1D1EC94", Offset = "0x1D1EC94", VA = "0x1D1EC94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1D1ECF0", Offset = "0x1D1ECF0", VA = "0x1D1ECF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1D1EE78", Offset = "0x1D1EE78", VA = "0x1D1EE78")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1D1EEAC", Offset = "0x1D1EEAC", VA = "0x1D1EEAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1D1F348", Offset = "0x1D1F348", VA = "0x1D1F348")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000CA")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1FC0FC4", Offset = "0x1FC0FC4", VA = "0x1FC0FC4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1FC0FA0", Offset = "0x1FC0FA0", VA = "0x1FC0FA0", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1FC0FCC", Offset = "0x1FC0FCC", VA = "0x1FC0FCC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1FC1030", Offset = "0x1FC1030", VA = "0x1FC1030", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1FC11C8", Offset = "0x1FC11C8", VA = "0x1FC11C8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1FC13EC", Offset = "0x1FC13EC", VA = "0x1FC13EC", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1FC11D8", Offset = "0x1FC11D8", VA = "0x1FC11D8")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1FC13FC", Offset = "0x1FC13FC", VA = "0x1FC13FC")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1FC1414", Offset = "0x1FC1414", VA = "0x1FC1414", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1FC1478", Offset = "0x1FC1478", VA = "0x1FC1478", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1FC1514", Offset = "0x1FC1514", VA = "0x1FC1514")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1FC162C", Offset = "0x1FC162C", VA = "0x1FC162C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x980E30", Offset = "0x980E30")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007BB")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007BC")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000CB")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x1FC16EC", Offset = "0x1FC16EC", VA = "0x1FC16EC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1FC1644", Offset = "0x1FC1644", VA = "0x1FC1644", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1FC16D0", Offset = "0x1FC16D0", VA = "0x1FC16D0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1FC17E4", Offset = "0x1FC17E4", VA = "0x1FC17E4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1FC1BC8", Offset = "0x1FC1BC8", VA = "0x1FC1BC8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1FC1CD0", Offset = "0x1FC1CD0", VA = "0x1FC1CD0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x980E74", Offset = "0x980E74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980E74", Offset = "0x980E74")]
		public Transform gravityTarget;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x980ED4", Offset = "0x980ED4")]
		public float gravityMultiplier;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007CA")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60007B7")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1FC20AC", Offset = "0x1FC20AC", VA = "0x1FC20AC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1FC21DC", Offset = "0x1FC21DC", VA = "0x1FC21DC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1FC23C4", Offset = "0x1FC23C4", VA = "0x1FC23C4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1FC2574", Offset = "0x1FC2574", VA = "0x1FC2574")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1FC25D8", Offset = "0x1FC25D8", VA = "0x1FC25D8")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1FC26F8", Offset = "0x1FC26F8", VA = "0x1FC26F8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1FC281C", Offset = "0x1FC281C", VA = "0x1FC281C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1FC2840", Offset = "0x1FC2840", VA = "0x1FC2840")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1FC2864", Offset = "0x1FC2864", VA = "0x1FC2864")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1FC28C4", Offset = "0x1FC28C4", VA = "0x1FC28C4")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011D")]
		public enum MoveMode
		{
			[Token(Token = "0x4000808")]
			Directional,
			[Token(Token = "0x4000809")]
			Strafe
		}

		[Token(Token = "0x200011E")]
		public struct AnimState
		{
			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9790C4", Offset = "0x9790C4")]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x1D20364", Offset = "0x1D20364", VA = "0x1D20364", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x1D203AC", Offset = "0x1D203AC", VA = "0x1D203AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1D20234", Offset = "0x1D20234", VA = "0x1D20234")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1D20260", Offset = "0x1D20260", VA = "0x1D20260", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1D20264", Offset = "0x1D20264", VA = "0x1D20264", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1D2036C", Offset = "0x1D2036C", VA = "0x1D2036C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x980F0C", Offset = "0x980F0C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x980F44", Offset = "0x980F44")]
		public MoveMode moveMode;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x980F7C", Offset = "0x980F7C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x980FB4", Offset = "0x980FB4")]
		public bool smoothJump;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x980FEC", Offset = "0x980FEC")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x981024", Offset = "0x981024")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98105C", Offset = "0x98105C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000CC")]
		public bool onGround
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1FC2BF4", Offset = "0x1FC2BF4", VA = "0x1FC2BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A6C", Offset = "0x983A6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1FC2BFC", Offset = "0x1FC2BFC", VA = "0x1FC2BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A7C", Offset = "0x983A7C")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1FC2C08", Offset = "0x1FC2C08", VA = "0x1FC2C08", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1FC2D70", Offset = "0x1FC2D70", VA = "0x1FC2D70")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1FC2E00", Offset = "0x1FC2E00", VA = "0x1FC2E00", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1FC2EC8", Offset = "0x1FC2EC8", VA = "0x1FC2EC8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1FC3ACC", Offset = "0x1FC3ACC", VA = "0x1FC3ACC", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1FC3D24", Offset = "0x1FC3D24", VA = "0x1FC3D24", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1FC33C0", Offset = "0x1FC33C0", VA = "0x1FC33C0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1FC3E00", Offset = "0x1FC3E00", VA = "0x1FC3E00")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1FC42A8", Offset = "0x1FC42A8", VA = "0x1FC42A8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1FC3B54", Offset = "0x1FC3B54", VA = "0x1FC3B54")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1FC4348", Offset = "0x1FC4348", VA = "0x1FC4348", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1FC4684", Offset = "0x1FC4684", VA = "0x1FC4684")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1FC4774", Offset = "0x1FC4774", VA = "0x1FC4774", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1FC48D4", Offset = "0x1FC48D4", VA = "0x1FC48D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983A8C", Offset = "0x983A8C")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1FC3724", Offset = "0x1FC3724", VA = "0x1FC3724")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1FC4970", Offset = "0x1FC4970", VA = "0x1FC4970")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000121")]
		public enum RotationMode
		{
			[Token(Token = "0x4000825")]
			Smooth,
			[Token(Token = "0x4000826")]
			Linear
		}

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98106C", Offset = "0x98106C")]
		public CameraController cameraController;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9810A4", Offset = "0x9810A4")]
		public float accelerationTime;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9810DC", Offset = "0x9810DC")]
		public float turnTime;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x981114", Offset = "0x981114")]
		public bool walkByDefault;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98114C", Offset = "0x98114C")]
		public RotationMode rotationMode;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x981184", Offset = "0x981184")]
		public float moveSpeed;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9811BC", Offset = "0x9811BC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000CF")]
		public bool isGrounded
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1D160CC", Offset = "0x1D160CC", VA = "0x1D160CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B3C", Offset = "0x983B3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1D160D4", Offset = "0x1D160D4", VA = "0x1D160D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B4C", Offset = "0x983B4C")]
			private set
			{
			}
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1D160E0", Offset = "0x1D160E0", VA = "0x1D160E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1D16184", Offset = "0x1D16184", VA = "0x1D16184")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1D16644", Offset = "0x1D16644", VA = "0x1D16644")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1D161D8", Offset = "0x1D161D8", VA = "0x1D161D8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1D16458", Offset = "0x1D16458", VA = "0x1D16458")]
		private void Move()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1D16680", Offset = "0x1D16680", VA = "0x1D16680")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1D1671C", Offset = "0x1D1671C", VA = "0x1D1671C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1D167A0", Offset = "0x1D167A0", VA = "0x1D167A0")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1D18FA4", Offset = "0x1D18FA4", VA = "0x1D18FA4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1D19028", Offset = "0x1D19028", VA = "0x1D19028", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1D191EC", Offset = "0x1D191EC", VA = "0x1D191EC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1D19214", Offset = "0x1D19214", VA = "0x1D19214")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000124")]
		public struct State
		{
			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1D18FE8", Offset = "0x1D18FE8", VA = "0x1D18FE8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1D19330", Offset = "0x1D19330", VA = "0x1D19330", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1D19230", Offset = "0x1D19230", VA = "0x1D19230")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1FB2E20", Offset = "0x1FB2E20", VA = "0x1FB2E20")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1FB2E5C", Offset = "0x1FB2E5C", VA = "0x1FB2E5C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1D167C8", Offset = "0x1D167C8", VA = "0x1D167C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1D167FC", Offset = "0x1D167FC", VA = "0x1D167FC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1D168AC", Offset = "0x1D168AC", VA = "0x1D168AC")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000127")]
	public class Navigator
	{
		[Token(Token = "0x2000128")]
		public enum State
		{
			[Token(Token = "0x4000848")]
			Idle,
			[Token(Token = "0x4000849")]
			Seeking,
			[Token(Token = "0x400084A")]
			OnPath
		}

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9811CC", Offset = "0x9811CC")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x981204", Offset = "0x981204")]
		public float cornerRadius;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98123C", Offset = "0x98123C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x981274", Offset = "0x981274")]
		public float maxSampleDistance;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9812AC", Offset = "0x9812AC")]
		public float nextPathInterval;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9812E4", Offset = "0x9812E4")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9812F4", Offset = "0x9812F4")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000D0")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1E0985C", Offset = "0x1E0985C", VA = "0x1E0985C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B5C", Offset = "0x983B5C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1E09868", Offset = "0x1E09868", VA = "0x1E09868")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B6C", Offset = "0x983B6C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public State state
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1E09874", Offset = "0x1E09874", VA = "0x1E09874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B7C", Offset = "0x983B7C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1E0987C", Offset = "0x1E0987C", VA = "0x1E0987C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B8C", Offset = "0x983B8C")]
			private set
			{
			}
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1E09884", Offset = "0x1E09884", VA = "0x1E09884")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1E09958", Offset = "0x1E09958", VA = "0x1E09958")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1E09D58", Offset = "0x1E09D58", VA = "0x1E09D58")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1E09DD4", Offset = "0x1E09DD4", VA = "0x1E09DD4")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1E09D14", Offset = "0x1E09D14", VA = "0x1E09D14")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1E09D44", Offset = "0x1E09D44", VA = "0x1E09D44")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1E09F20", Offset = "0x1E09F20", VA = "0x1E09F20")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1E0A0D0", Offset = "0x1E0A0D0", VA = "0x1E0A0D0")]
		public Navigator()
		{
		}
	}
}
