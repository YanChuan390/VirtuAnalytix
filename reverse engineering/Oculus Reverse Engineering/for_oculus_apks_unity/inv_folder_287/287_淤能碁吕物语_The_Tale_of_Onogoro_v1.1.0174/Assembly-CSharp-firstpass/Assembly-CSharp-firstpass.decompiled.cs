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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10020C4", Offset = "0x10020C4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10020C4", Offset = "0x10020C4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10030F8", Offset = "0x10030F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10030F8", Offset = "0x10030F8")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003150", Offset = "0x1003150")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003150", Offset = "0x1003150")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10031A8", Offset = "0x10031A8")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10031E0", Offset = "0x10031E0")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003218", Offset = "0x1003218")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003250", Offset = "0x1003250")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003288", Offset = "0x1003288")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10032C0", Offset = "0x10032C0")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10032F8", Offset = "0x10032F8")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1003330", Offset = "0x1003330")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1003340", Offset = "0x1003340")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		public PlayableDirector director;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10033C0", Offset = "0x10033C0")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2D38418", Offset = "0x2D38418", VA = "0x2D38418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B34C", Offset = "0x100B34C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2D38420", Offset = "0x2D38420", VA = "0x2D38420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B35C", Offset = "0x100B35C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2D3842C", Offset = "0x2D3842C", VA = "0x2D3842C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B36C", Offset = "0x100B36C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2D38434", Offset = "0x2D38434", VA = "0x2D38434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B37C", Offset = "0x100B37C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2D3843C", Offset = "0x2D3843C", VA = "0x2D3843C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B38C", Offset = "0x100B38C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2D38444", Offset = "0x2D38444", VA = "0x2D38444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B39C", Offset = "0x100B39C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2D382F8", Offset = "0x2D382F8", VA = "0x2D382F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B26C", Offset = "0x100B26C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2D38340", Offset = "0x2D38340", VA = "0x2D38340")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B2A4", Offset = "0x100B2A4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2D38388", Offset = "0x2D38388", VA = "0x2D38388")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B2DC", Offset = "0x100B2DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2D383D0", Offset = "0x2D383D0", VA = "0x2D383D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B314", Offset = "0x100B314")]
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
		[Address(RVA = "0x2D3844C", Offset = "0x2D3844C", VA = "0x2D3844C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2D38450", Offset = "0x2D38450", VA = "0x2D38450")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2D38454", Offset = "0x2D38454", VA = "0x2D38454")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2D38458", Offset = "0x2D38458", VA = "0x2D38458")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10033D0", Offset = "0x10033D0")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003408", Offset = "0x1003408")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003440", Offset = "0x1003440")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003478", Offset = "0x1003478")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10034B0", Offset = "0x10034B0")]
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
		[Address(RVA = "0x2D72C68", Offset = "0x2D72C68", VA = "0x2D72C68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2D73058", Offset = "0x2D73058", VA = "0x2D73058", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2D73060", Offset = "0x2D73060", VA = "0x2D73060", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2D73170", Offset = "0x2D73170", VA = "0x2D73170", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2D731EC", Offset = "0x2D731EC", VA = "0x2D731EC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2D73268", Offset = "0x2D73268", VA = "0x2D73268", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2D72EB0", Offset = "0x2D72EB0", VA = "0x2D72EB0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2D72F84", Offset = "0x2D72F84", VA = "0x2D72F84")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2D732E4", Offset = "0x2D732E4", VA = "0x2D732E4")]
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
		[Address(RVA = "0x2AE0118", Offset = "0x2AE0118", VA = "0x2AE0118")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2D376F0", Offset = "0x2D376F0", VA = "0x2D376F0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2D3794C", Offset = "0x2D3794C", VA = "0x2D3794C")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2D3792C", Offset = "0x2D3792C", VA = "0x2D3792C")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2D37EF8", Offset = "0x2D37EF8", VA = "0x2D37EF8")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2D395F0", Offset = "0x2D395F0", VA = "0x2D395F0")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2D3AEA8", Offset = "0x2D3AEA8", VA = "0x2D3AEA8")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2D39044", Offset = "0x2D39044", VA = "0x2D39044")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2D39638", Offset = "0x2D39638", VA = "0x2D39638")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2D38B74", Offset = "0x2D38B74", VA = "0x2D38B74")]
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
		[Address(RVA = "0x2D38544", Offset = "0x2D38544", VA = "0x2D38544")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2D387B0", Offset = "0x2D387B0", VA = "0x2D387B0")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D386A8", Offset = "0x2D386A8", VA = "0x2D386A8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2D3892C", Offset = "0x2D3892C", VA = "0x2D3892C")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2D38DD8", Offset = "0x2D38DD8", VA = "0x2D38DD8")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2D38ED4", Offset = "0x2D38ED4", VA = "0x2D38ED4")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2D38FD0", Offset = "0x2D38FD0", VA = "0x2D38FD0")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2D38F48", Offset = "0x2D38F48", VA = "0x2D38F48")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2D3923C", Offset = "0x2D3923C", VA = "0x2D3923C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2D392F0", Offset = "0x2D392F0", VA = "0x2D392F0")]
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
		[Address(RVA = "0x2D3963C", Offset = "0x2D3963C", VA = "0x2D3963C")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2D396AC", Offset = "0x2D396AC", VA = "0x2D396AC")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2D3A140", Offset = "0x2D3A140", VA = "0x2D3A140")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2D3A1F4", Offset = "0x2D3A1F4", VA = "0x2D3A1F4")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2D3A0E4", Offset = "0x2D3A0E4", VA = "0x2D3A0E4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2D3A2EC", Offset = "0x2D3A2EC", VA = "0x2D3A2EC")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2D3A334", Offset = "0x2D3A334", VA = "0x2D3A334")]
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
		[Address(RVA = "0x2D3A33C", Offset = "0x2D3A33C", VA = "0x2D3A33C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2D3A4C8", Offset = "0x2D3A4C8", VA = "0x2D3A4C8")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2D3A4DC", Offset = "0x2D3A4DC", VA = "0x2D3A4DC")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2D3A7C8", Offset = "0x2D3A7C8", VA = "0x2D3A7C8")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2D3A3D4", Offset = "0x2D3A3D4", VA = "0x2D3A3D4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2D3AA7C", Offset = "0x2D3AA7C", VA = "0x2D3AA7C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2D3AAF0", Offset = "0x2D3AAF0", VA = "0x2D3AAF0")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2D3ACA4", Offset = "0x2D3ACA4", VA = "0x2D3ACA4")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10034E8", Offset = "0x10034E8")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003520", Offset = "0x1003520")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003520", Offset = "0x1003520")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003578", Offset = "0x1003578")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003578", Offset = "0x1003578")]
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
		[Address(RVA = "0x2E0EE60", Offset = "0x2E0EE60", VA = "0x2E0EE60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2E0F33C", Offset = "0x2E0F33C", VA = "0x2E0F33C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2E0F358", Offset = "0x2E0F358", VA = "0x2E0F358", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2E0F434", Offset = "0x2E0F434", VA = "0x2E0F434", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2E0F510", Offset = "0x2E0F510", VA = "0x2E0F510", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2E0F6E0", Offset = "0x2E0F6E0", VA = "0x2E0F6E0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2E0F9A8", Offset = "0x2E0F9A8", VA = "0x2E0F9A8")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2E0FA84", Offset = "0x2E0FA84", VA = "0x2E0FA84")]
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
			[Token(Token = "0x4000076")]
			Update,
			[Token(Token = "0x4000077")]
			FixedUpdate,
			[Token(Token = "0x4000078")]
			LateUpdate,
			[Token(Token = "0x4000079")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10035CC", Offset = "0x10035CC")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1003604", Offset = "0x1003604")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100363C", Offset = "0x100363C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1003674", Offset = "0x1003674")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10036AC", Offset = "0x10036AC")]
		public float blockedOffset;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10036C4", Offset = "0x10036C4")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10036D4", Offset = "0x10036D4")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10036E4", Offset = "0x10036E4")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2D43694", Offset = "0x2D43694", VA = "0x2D43694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B3AC", Offset = "0x100B3AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2D4369C", Offset = "0x2D4369C", VA = "0x2D4369C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B3BC", Offset = "0x100B3BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2D436A4", Offset = "0x2D436A4", VA = "0x2D436A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B3CC", Offset = "0x100B3CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2D436AC", Offset = "0x2D436AC", VA = "0x2D436AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B3DC", Offset = "0x100B3DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2D436B4", Offset = "0x2D436B4", VA = "0x2D436B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B3EC", Offset = "0x100B3EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2D436BC", Offset = "0x2D436BC", VA = "0x2D436BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B3FC", Offset = "0x100B3FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2D43F44", Offset = "0x2D43F44", VA = "0x2D43F44")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2D436C4", Offset = "0x2D436C4", VA = "0x2D436C4")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2D43700", Offset = "0x2D43700", VA = "0x2D43700")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2D43708", Offset = "0x2D43708", VA = "0x2D43708", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2D4380C", Offset = "0x2D4380C", VA = "0x2D4380C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2D43868", Offset = "0x2D43868", VA = "0x2D43868", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2D438D0", Offset = "0x2D438D0", VA = "0x2D438D0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2D43934", Offset = "0x2D43934", VA = "0x2D43934")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2D43840", Offset = "0x2D43840", VA = "0x2D43840")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2D43AB4", Offset = "0x2D43AB4", VA = "0x2D43AB4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2D43F14", Offset = "0x2D43F14", VA = "0x2D43F14")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2D43FB4", Offset = "0x2D43FB4", VA = "0x2D43FB4")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2D44058", Offset = "0x2D44058", VA = "0x2D44058")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2D44090", Offset = "0x2D44090", VA = "0x2D44090")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2D44238", Offset = "0x2D44238", VA = "0x2D44238")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2D44268", Offset = "0x2D44268", VA = "0x2D44268")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public enum Axis
	{
		[Token(Token = "0x4000080")]
		X,
		[Token(Token = "0x4000081")]
		Y,
		[Token(Token = "0x4000082")]
		Z
	}
	[Token(Token = "0x2000010")]
	public class AxisTools
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2D37F00", Offset = "0x2D37F00", VA = "0x2D37F00")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2D37F24", Offset = "0x2D37F24", VA = "0x2D37F24")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2D37F5C", Offset = "0x2D37F5C", VA = "0x2D37F5C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2D3804C", Offset = "0x2D3804C", VA = "0x2D3804C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2D37FF4", Offset = "0x2D37FF4", VA = "0x2D37FF4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2D380E4", Offset = "0x2D380E4", VA = "0x2D380E4")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2D3812C", Offset = "0x2D3812C", VA = "0x2D3812C")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2D382F0", Offset = "0x2D382F0", VA = "0x2D382F0")]
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
			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2AE71FC", Offset = "0x2AE71FC", VA = "0x2AE71FC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2D3C94C", Offset = "0x2D3C94C", VA = "0x2D3C94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2D3CBB8", Offset = "0x2D3CBB8", VA = "0x2D3CBB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2D3C900", Offset = "0x2D3C900", VA = "0x2D3C900")]
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
			[Token(Token = "0x400009D")]
			Unassigned,
			[Token(Token = "0x400009E")]
			Spine,
			[Token(Token = "0x400009F")]
			Head,
			[Token(Token = "0x40000A0")]
			Arm,
			[Token(Token = "0x40000A1")]
			Leg,
			[Token(Token = "0x40000A2")]
			Tail,
			[Token(Token = "0x40000A3")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000015")]
		public enum BoneSide
		{
			[Token(Token = "0x40000A5")]
			Center,
			[Token(Token = "0x40000A6")]
			Left,
			[Token(Token = "0x40000A7")]
			Right
		}

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2D3CE24", Offset = "0x2D3CE24", VA = "0x2D3CE24")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2D3D140", Offset = "0x2D3D140", VA = "0x2D3D140")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2D3D3AC", Offset = "0x2D3D3AC", VA = "0x2D3D3AC")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2D3D42C", Offset = "0x2D3D42C", VA = "0x2D3D42C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2D3D4D4", Offset = "0x2D3D4D4", VA = "0x2D3D4D4")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2D3CFF4", Offset = "0x2D3CFF4", VA = "0x2D3CFF4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2D3D310", Offset = "0x2D3D310", VA = "0x2D3D310")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2D3DD04", Offset = "0x2D3DD04", VA = "0x2D3DD04")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2D3DB0C", Offset = "0x2D3DB0C", VA = "0x2D3DB0C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2D3DC08", Offset = "0x2D3DC08", VA = "0x2D3DC08")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2D3D6EC", Offset = "0x2D3D6EC", VA = "0x2D3D6EC")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2D3D79C", Offset = "0x2D3D79C", VA = "0x2D3D79C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2D3D84C", Offset = "0x2D3D84C", VA = "0x2D3D84C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2D3D8FC", Offset = "0x2D3D8FC", VA = "0x2D3D8FC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2D3D9AC", Offset = "0x2D3D9AC", VA = "0x2D3D9AC")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2D3DA5C", Offset = "0x2D3DA5C", VA = "0x2D3DA5C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2D3DF0C", Offset = "0x2D3DF0C", VA = "0x2D3DF0C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2D3D604", Offset = "0x2D3D604", VA = "0x2D3D604")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2D3DE7C", Offset = "0x2D3DE7C", VA = "0x2D3DE7C")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2D3DF78", Offset = "0x2D3DF78", VA = "0x2D3DF78")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2D3E04C", Offset = "0x2D3E04C", VA = "0x2D3E04C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2D3DE04", Offset = "0x2D3DE04", VA = "0x2D3DE04")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2D3DD90", Offset = "0x2D3DD90", VA = "0x2D3DD90")]
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
			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x2AE7288", Offset = "0x2AE7288", VA = "0x2AE7288")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2AE7274", Offset = "0x2AE7274", VA = "0x2AE7274")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2D40090", Offset = "0x2D40090", VA = "0x2D40090", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2D40478", Offset = "0x2D40478", VA = "0x2D40478")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2D40488", Offset = "0x2D40488", VA = "0x2D40488", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2D408B0", Offset = "0x2D408B0", VA = "0x2D408B0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2D40CE4", Offset = "0x2D40CE4", VA = "0x2D40CE4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2D412D0", Offset = "0x2D412D0", VA = "0x2D412D0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2D40EF8", Offset = "0x2D40EF8", VA = "0x2D40EF8")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2D3BCD4", Offset = "0x2D3BCD4", VA = "0x2D3BCD4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2D41AD0", Offset = "0x2D41AD0", VA = "0x2D41AD0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2D42030", Offset = "0x2D42030", VA = "0x2D42030")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2D41E24", Offset = "0x2D41E24", VA = "0x2D41E24")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2D41CA0", Offset = "0x2D41CA0", VA = "0x2D41CA0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2D41B70", Offset = "0x2D41B70", VA = "0x2D41B70")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2D41F30", Offset = "0x2D41F30", VA = "0x2D41F30")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2D42128", Offset = "0x2D42128", VA = "0x2D42128")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2D42C4C", Offset = "0x2D42C4C", VA = "0x2D42C4C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2D426D4", Offset = "0x2D426D4", VA = "0x2D426D4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2D42EF4", Offset = "0x2D42EF4", VA = "0x2D42EF4")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2D42A40", Offset = "0x2D42A40", VA = "0x2D42A40")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2D42EFC", Offset = "0x2D42EFC", VA = "0x2D42EFC")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2D42F04", Offset = "0x2D42F04", VA = "0x2D42F04")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2D430CC", Offset = "0x2D430CC", VA = "0x2D430CC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2D43288", Offset = "0x2D43288", VA = "0x2D43288")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2D3C130", Offset = "0x2D3C130", VA = "0x2D3C130")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2D681C0", Offset = "0x2D681C0", VA = "0x2D681C0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2D68A4C", Offset = "0x2D68A4C", VA = "0x2D68A4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2D68B94", Offset = "0x2D68B94", VA = "0x2D68B94")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2E0CD4C", Offset = "0x2E0CD4C", VA = "0x2E0CD4C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2E0CF38", Offset = "0x2E0CF38", VA = "0x2E0CF38")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2E0CDE4", Offset = "0x2E0CDE4", VA = "0x2E0CDE4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2E0D058", Offset = "0x2E0D058", VA = "0x2E0D058")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2E0D184", Offset = "0x2E0D184", VA = "0x2E0D184")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2E0D3D0", Offset = "0x2E0D3D0", VA = "0x2E0D3D0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2E0D4D8", Offset = "0x2E0D4D8", VA = "0x2E0D4D8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2E0D64C", Offset = "0x2E0D64C", VA = "0x2E0D64C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2E0DA28", Offset = "0x2E0DA28", VA = "0x2E0DA28")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2E0D7EC", Offset = "0x2E0D7EC", VA = "0x2E0D7EC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2E0DBDC", Offset = "0x2E0DBDC", VA = "0x2E0DBDC")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2D98170", Offset = "0x2D98170", VA = "0x2D98170")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2D981DC", Offset = "0x2D981DC", VA = "0x2D981DC")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C1")]
		None,
		[Token(Token = "0x40000C2")]
		InOutCubic,
		[Token(Token = "0x40000C3")]
		InOutQuintic,
		[Token(Token = "0x40000C4")]
		InOutSine,
		[Token(Token = "0x40000C5")]
		InQuintic,
		[Token(Token = "0x40000C6")]
		InQuartic,
		[Token(Token = "0x40000C7")]
		InCubic,
		[Token(Token = "0x40000C8")]
		InQuadratic,
		[Token(Token = "0x40000C9")]
		InElastic,
		[Token(Token = "0x40000CA")]
		InElasticSmall,
		[Token(Token = "0x40000CB")]
		InElasticBig,
		[Token(Token = "0x40000CC")]
		InSine,
		[Token(Token = "0x40000CD")]
		InBack,
		[Token(Token = "0x40000CE")]
		OutQuintic,
		[Token(Token = "0x40000CF")]
		OutQuartic,
		[Token(Token = "0x40000D0")]
		OutCubic,
		[Token(Token = "0x40000D1")]
		OutInCubic,
		[Token(Token = "0x40000D2")]
		OutInQuartic,
		[Token(Token = "0x40000D3")]
		OutElastic,
		[Token(Token = "0x40000D4")]
		OutElasticSmall,
		[Token(Token = "0x40000D5")]
		OutElasticBig,
		[Token(Token = "0x40000D6")]
		OutSine,
		[Token(Token = "0x40000D7")]
		OutBack,
		[Token(Token = "0x40000D8")]
		OutBackCubic,
		[Token(Token = "0x40000D9")]
		OutBackQuartic,
		[Token(Token = "0x40000DA")]
		BackInCubic,
		[Token(Token = "0x40000DB")]
		BackInQuartic
	}
	[Token(Token = "0x200001D")]
	public class Interp
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2C3D7FC", Offset = "0x2C3D7FC", VA = "0x2C3D7FC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2C3E1A8", Offset = "0x2C3E1A8", VA = "0x2C3E1A8")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2C3E21C", Offset = "0x2C3E21C", VA = "0x2C3E21C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2C3DC10", Offset = "0x2C3DC10", VA = "0x2C3DC10")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2C3DC1C", Offset = "0x2C3DC1C", VA = "0x2C3DC1C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2C3DC40", Offset = "0x2C3DC40", VA = "0x2C3DC40")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2C3DC7C", Offset = "0x2C3DC7C", VA = "0x2C3DC7C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2C3DC94", Offset = "0x2C3DC94", VA = "0x2C3DC94")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2C3DCA8", Offset = "0x2C3DCA8", VA = "0x2C3DCA8")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2C3DCBC", Offset = "0x2C3DCBC", VA = "0x2C3DCBC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2C3DCCC", Offset = "0x2C3DCCC", VA = "0x2C3DCCC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2C3DD14", Offset = "0x2C3DD14", VA = "0x2C3DD14")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2C3DD4C", Offset = "0x2C3DD4C", VA = "0x2C3DD4C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2C3DD74", Offset = "0x2C3DD74", VA = "0x2C3DD74")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2C3E2A8", Offset = "0x2C3E2A8", VA = "0x2C3E2A8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2C3DDA8", Offset = "0x2C3DDA8", VA = "0x2C3DDA8")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2C3DDD0", Offset = "0x2C3DDD0", VA = "0x2C3DDD0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2C3DE00", Offset = "0x2C3DE00", VA = "0x2C3DE00")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2C3DE34", Offset = "0x2C3DE34", VA = "0x2C3DE34")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2C3DE78", Offset = "0x2C3DE78", VA = "0x2C3DE78")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2C3DEDC", Offset = "0x2C3DEDC", VA = "0x2C3DEDC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2C3DF40", Offset = "0x2C3DF40", VA = "0x2C3DF40")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2C3DF94", Offset = "0x2C3DF94", VA = "0x2C3DF94")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2C3DFE8", Offset = "0x2C3DFE8", VA = "0x2C3DFE8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2C3E024", Offset = "0x2C3E024", VA = "0x2C3E024")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2C3E05C", Offset = "0x2C3E05C", VA = "0x2C3E05C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2C3E2DC", Offset = "0x2C3E2DC", VA = "0x2C3E2DC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2C3E0A4", Offset = "0x2C3E0A4", VA = "0x2C3E0A4")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2C3E138", Offset = "0x2C3E138", VA = "0x2C3E138")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2C3E168", Offset = "0x2C3E168", VA = "0x2C3E168")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2C3E370", Offset = "0x2C3E370", VA = "0x2C3E370")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2C3E42C", Offset = "0x2C3E42C", VA = "0x2C3E42C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2C3E498", Offset = "0x2C3E498", VA = "0x2C3E498")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2C3E504", Offset = "0x2C3E504", VA = "0x2C3E504")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2C3E55C", Offset = "0x2C3E55C", VA = "0x2C3E55C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2C3E628", Offset = "0x2C3E628", VA = "0x2C3E628")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2C3E574", Offset = "0x2C3E574", VA = "0x2C3E574")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2C3E640", Offset = "0x2C3E640", VA = "0x2C3E640")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2C3E6E4", Offset = "0x2C3E6E4", VA = "0x2C3E6E4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2C3E710", Offset = "0x2C3E710", VA = "0x2C3E710")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2C3E760", Offset = "0x2C3E760", VA = "0x2C3E760")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2C3E7CC", Offset = "0x2C3E7CC", VA = "0x2C3E7CC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2C3E8E0", Offset = "0x2C3E8E0", VA = "0x2C3E8E0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2C3E9D8", Offset = "0x2C3E9D8", VA = "0x2C3E9D8")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2C3EA34", Offset = "0x2C3EA34", VA = "0x2C3EA34")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2C44C30", Offset = "0x2C44C30", VA = "0x2C44C30")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2C44C80", Offset = "0x2C44C80", VA = "0x2C44C80")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2C44CD0", Offset = "0x2C44CD0", VA = "0x2C44CD0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2C44D78", Offset = "0x2C44D78", VA = "0x2C44D78")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2C3D50C", Offset = "0x2C3D50C", VA = "0x2C3D50C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2C44E20", Offset = "0x2C44E20", VA = "0x2C44E20")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2C44E74", Offset = "0x2C44E74", VA = "0x2C44E74")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2C44460", Offset = "0x2C44460", VA = "0x2C44460")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2C44F48", Offset = "0x2C44F48", VA = "0x2C44F48")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2C450D8", Offset = "0x2C450D8", VA = "0x2C450D8")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2C451CC", Offset = "0x2C451CC", VA = "0x2C451CC")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2C452D8", Offset = "0x2C452D8", VA = "0x2C452D8")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2C453C4", Offset = "0x2C453C4", VA = "0x2C453C4")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000021")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000E6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000E8")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003704", Offset = "0x1003704")]
		public bool fixTransforms;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x2ADFC44", Offset = "0x2ADFC44", VA = "0x2ADFC44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2ADFF50", Offset = "0x2ADFF50", VA = "0x2ADFF50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2ADFB04", Offset = "0x2ADFB04", VA = "0x2ADFB04")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2ADFBA4", Offset = "0x2ADFBA4", VA = "0x2ADFBA4", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2ADFBA8", Offset = "0x2ADFBA8", VA = "0x2ADFBA8", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2ADFBAC", Offset = "0x2ADFBAC", VA = "0x2ADFBAC", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2ADFBB0", Offset = "0x2ADFBB0", VA = "0x2ADFBB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2ADFC40", Offset = "0x2ADFC40", VA = "0x2ADFC40")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2ADFBE8", Offset = "0x2ADFBE8", VA = "0x2ADFBE8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2ADFF04", Offset = "0x2ADFF04", VA = "0x2ADFF04")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2ADFD30", Offset = "0x2ADFD30", VA = "0x2ADFD30")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2AE0008", Offset = "0x2AE0008", VA = "0x2AE0008")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2AE0064", Offset = "0x2AE0064", VA = "0x2AE0064")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2AE00C0", Offset = "0x2AE00C0", VA = "0x2AE00C0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2AE0108", Offset = "0x2AE0108", VA = "0x2AE0108")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2AE077C", Offset = "0x2AE077C", VA = "0x2AE077C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2AE083C", Offset = "0x2AE083C", VA = "0x2AE083C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2AE08FC", Offset = "0x2AE08FC", VA = "0x2AE08FC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2AE09BC", Offset = "0x2AE09BC", VA = "0x2AE09BC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V3Tools
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2AE2364", Offset = "0x2AE2364", VA = "0x2AE2364")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2AE2404", Offset = "0x2AE2404", VA = "0x2AE2404")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2AE2440", Offset = "0x2AE2440", VA = "0x2AE2440")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2AE2484", Offset = "0x2AE2484", VA = "0x2AE2484")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2AE2520", Offset = "0x2AE2520", VA = "0x2AE2520")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2AE267C", Offset = "0x2AE267C", VA = "0x2AE267C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2AE27F8", Offset = "0x2AE27F8", VA = "0x2AE27F8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2AE297C", Offset = "0x2AE297C", VA = "0x2AE297C")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2AE2A38", Offset = "0x2AE2A38", VA = "0x2AE2A38")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2AE2B38", Offset = "0x2AE2B38", VA = "0x2AE2B38")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2AE2BC0", Offset = "0x2AE2BC0", VA = "0x2AE2BC0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000025")]
	public static class Warning
	{
		[Token(Token = "0x2000026")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2AE6A68", Offset = "0x2AE6A68", VA = "0x2AE6A68")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2AE6B00", Offset = "0x2AE6B00", VA = "0x2AE6B00")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002134", Offset = "0x1002134")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002134", Offset = "0x1002134")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2D3B3B4", Offset = "0x2D3B3B4", VA = "0x2D3B3B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B47C", Offset = "0x100B47C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2D3B3FC", Offset = "0x2D3B3FC", VA = "0x2D3B3FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B4B4", Offset = "0x100B4B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2D3B444", Offset = "0x2D3B444", VA = "0x2D3B444")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B4EC", Offset = "0x100B4EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2D3B48C", Offset = "0x2D3B48C", VA = "0x2D3B48C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B524", Offset = "0x100B524")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2D3B4D4", Offset = "0x2D3B4D4", VA = "0x2D3B4D4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2D3B570", Offset = "0x2D3B570", VA = "0x2D3B570")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2D3B590", Offset = "0x2D3B590", VA = "0x2D3B590")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2D3B5C0", Offset = "0x2D3B5C0", VA = "0x2D3B5C0")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2D3B5F0", Offset = "0x2D3B5F0", VA = "0x2D3B5F0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2D3B630", Offset = "0x2D3B630", VA = "0x2D3B630")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2D3B674", Offset = "0x2D3B674", VA = "0x2D3B674")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2D3B698", Offset = "0x2D3B698", VA = "0x2D3B698")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2D3B6BC", Offset = "0x2D3B6BC", VA = "0x2D3B6BC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2D3B6E4", Offset = "0x2D3B6E4", VA = "0x2D3B6E4")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2D3B710", Offset = "0x2D3B710", VA = "0x2D3B710")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2D3B73C", Offset = "0x2D3B73C", VA = "0x2D3B73C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2D3B4F4", Offset = "0x2D3B4F4", VA = "0x2D3B4F4")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2D3B764", Offset = "0x2D3B764", VA = "0x2D3B764")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2D3B770", Offset = "0x2D3B770", VA = "0x2D3B770")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2D3B77C", Offset = "0x2D3B77C", VA = "0x2D3B77C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2D3BA60", Offset = "0x2D3BA60", VA = "0x2D3BA60", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2D3BB08", Offset = "0x2D3BB08", VA = "0x2D3BB08", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2D3BEE8", Offset = "0x2D3BEE8", VA = "0x2D3BEE8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2D3C074", Offset = "0x2D3C074", VA = "0x2D3C074")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2D3C0A8", Offset = "0x2D3C0A8", VA = "0x2D3C0A8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000010")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2D3B91C", Offset = "0x2D3B91C", VA = "0x2D3B91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2D3C310", Offset = "0x2D3C310", VA = "0x2D3C310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2D3BDC4", Offset = "0x2D3BDC4", VA = "0x2D3BDC4")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2D3C19C", Offset = "0x2D3C19C", VA = "0x2D3C19C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000012")]
		public bool isValid
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2D681C8", Offset = "0x2D681C8", VA = "0x2D681C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2D68234", Offset = "0x2D68234", VA = "0x2D68234")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2D6823C", Offset = "0x2D6823C", VA = "0x2D6823C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2D682FC", Offset = "0x2D682FC", VA = "0x2D682FC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2D68304", Offset = "0x2D68304", VA = "0x2D68304")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool positionChanged
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2D68438", Offset = "0x2D68438", VA = "0x2D68438")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2D68330", Offset = "0x2D68330", VA = "0x2D68330", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2D68474", Offset = "0x2D68474", VA = "0x2D68474")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2D6847C", Offset = "0x2D6847C", VA = "0x2D6847C")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2D684A8", Offset = "0x2D684A8", VA = "0x2D684A8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2D68528", Offset = "0x2D68528", VA = "0x2D68528")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2D68530", Offset = "0x2D68530", VA = "0x2D68530")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		private bool rotationChanged
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2D68664", Offset = "0x2D68664", VA = "0x2D68664")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2D6855C", Offset = "0x2D6855C", VA = "0x2D6855C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2D686A0", Offset = "0x2D686A0", VA = "0x2D686A0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2D686A8", Offset = "0x2D686A8", VA = "0x2D686A8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class Constraints
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100373C", Offset = "0x100373C")]
		public float positionWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003754", Offset = "0x1003754")]
		public float rotationWeight;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2D686D4", Offset = "0x2D686D4", VA = "0x2D686D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2D68740", Offset = "0x2D68740", VA = "0x2D68740")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2D68794", Offset = "0x2D68794", VA = "0x2D68794")]
		public void Update()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2D68A44", Offset = "0x2D68A44", VA = "0x2D68A44")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000030")]
		public enum DOF
		{
			[Token(Token = "0x400011B")]
			One,
			[Token(Token = "0x400011C")]
			Three
		}

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100376C", Offset = "0x100376C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100376C", Offset = "0x100376C")]
		public float weight;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10037C0", Offset = "0x10037C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10037C0", Offset = "0x10037C0")]
		public float rotationWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003814", Offset = "0x1003814")]
		public DOF rotationDOF;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100384C", Offset = "0x100384C")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003884", Offset = "0x1003884")]
		public Transform bone1;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10038BC", Offset = "0x10038BC")]
		public Transform bone2;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10038F4", Offset = "0x10038F4")]
		public Transform bone3;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100392C", Offset = "0x100392C")]
		public Transform tip;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003964", Offset = "0x1003964")]
		public Transform target;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100399C", Offset = "0x100399C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2D70E14", Offset = "0x2D70E14", VA = "0x2D70E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B55C", Offset = "0x100B55C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2D70E1C", Offset = "0x2D70E1C", VA = "0x2D70E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B56C", Offset = "0x100B56C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2D70E28", Offset = "0x2D70E28", VA = "0x2D70E28")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2D70E48", Offset = "0x2D70E48", VA = "0x2D70E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2D70E68", Offset = "0x2D70E68", VA = "0x2D70E68")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2D70E88", Offset = "0x2D70E88", VA = "0x2D70E88")]
			set
			{
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2D70EA8", Offset = "0x2D70EA8", VA = "0x2D70EA8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2D70FB0", Offset = "0x2D70FB0", VA = "0x2D70FB0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2D71454", Offset = "0x2D71454", VA = "0x2D71454")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2D7152C", Offset = "0x2D7152C", VA = "0x2D7152C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2D715F0", Offset = "0x2D715F0", VA = "0x2D715F0")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2D71B38", Offset = "0x2D71B38", VA = "0x2D71B38")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10039AC", Offset = "0x10039AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10039AC", Offset = "0x10039AC")]
		public float weight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1003A00", Offset = "0x1003A00")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2D71B48", Offset = "0x2D71B48", VA = "0x2D71B48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B57C", Offset = "0x100B57C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2D71B50", Offset = "0x2D71B50", VA = "0x2D71B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B58C", Offset = "0x100B58C")]
			private set
			{
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2D71B5C", Offset = "0x2D71B5C", VA = "0x2D71B5C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2D71BE4", Offset = "0x2D71BE4", VA = "0x2D71BE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B59C", Offset = "0x100B59C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2D71F1C", Offset = "0x2D71F1C", VA = "0x2D71F1C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2D72094", Offset = "0x2D72094", VA = "0x2D72094")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2D71E20", Offset = "0x2D71E20", VA = "0x2D71E20")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2D72204", Offset = "0x2D72204", VA = "0x2D72204", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2D722C4", Offset = "0x2D722C4", VA = "0x2D722C4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2D7233C", Offset = "0x2D7233C", VA = "0x2D7233C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2D723B0", Offset = "0x2D723B0", VA = "0x2D723B0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2D72418", Offset = "0x2D72418", VA = "0x2D72418", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2D7241C", Offset = "0x2D7241C", VA = "0x2D7241C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2D72430", Offset = "0x2D72430", VA = "0x2D72430")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003A10", Offset = "0x1003A10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003A10", Offset = "0x1003A10")]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003A64", Offset = "0x1003A64")]
		public Grounding solver;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1003A9C", Offset = "0x1003A9C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2D73844", Offset = "0x2D73844", VA = "0x2D73844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B5D4", Offset = "0x100B5D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2D7384C", Offset = "0x2D7384C", VA = "0x2D7384C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B5E4", Offset = "0x100B5E4")]
			protected set
			{
			}
		}

		[Token(Token = "0x600015A")]
		public abstract void ResetPosition();

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2D73858", Offset = "0x2D73858", VA = "0x2D73858")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2D73A04", Offset = "0x2D73A04", VA = "0x2D73A04")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2D73904", Offset = "0x2D73904", VA = "0x2D73904")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2D73A38", Offset = "0x2D73A38", VA = "0x2D73A38")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000162")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2D73B74", Offset = "0x2D73B74", VA = "0x2D73B74")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002194", Offset = "0x1002194")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002194", Offset = "0x1002194")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003AAC", Offset = "0x1003AAC")]
		public BipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003AE4", Offset = "0x1003AE4")]
		public float spineBend;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003B1C", Offset = "0x1003B1C")]
		public float spineSpeed;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2D73BE0", Offset = "0x2D73BE0", VA = "0x2D73BE0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B5F4", Offset = "0x100B5F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2D73C28", Offset = "0x2D73C28", VA = "0x2D73C28", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B62C", Offset = "0x100B62C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2D73C70", Offset = "0x2D73C70", VA = "0x2D73C70", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2D73CB0", Offset = "0x2D73CB0", VA = "0x2D73CB0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2D73D5C", Offset = "0x2D73D5C", VA = "0x2D73D5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2D73DBC", Offset = "0x2D73DBC", VA = "0x2D73DBC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2D74080", Offset = "0x2D74080", VA = "0x2D74080")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2D740D4", Offset = "0x2D740D4", VA = "0x2D740D4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2D744D0", Offset = "0x2D744D0", VA = "0x2D744D0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2D745A4", Offset = "0x2D745A4", VA = "0x2D745A4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2D746E4", Offset = "0x2D746E4", VA = "0x2D746E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2D74874", Offset = "0x2D74874", VA = "0x2D74874")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10021F4", Offset = "0x10021F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10021F4", Offset = "0x10021F4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class SpineEffector
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003BFC", Offset = "0x1003BFC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003C34", Offset = "0x1003C34")]
			public float horizontalWeight;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003C6C", Offset = "0x1003C6C")]
			public float verticalWeight;

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2AE7FD4", Offset = "0x2AE7FD4", VA = "0x2AE7FD4")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2AE7FE4", Offset = "0x2AE7FE4", VA = "0x2AE7FE4")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003B54", Offset = "0x1003B54")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003B8C", Offset = "0x1003B8C")]
		public float spineBend;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003BC4", Offset = "0x1003BC4")]
		public float spineSpeed;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2D74CAC", Offset = "0x2D74CAC", VA = "0x2D74CAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B664", Offset = "0x100B664")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2D74CF4", Offset = "0x2D74CF4", VA = "0x2D74CF4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B69C", Offset = "0x100B69C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2D74D3C", Offset = "0x2D74D3C", VA = "0x2D74D3C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B6D4", Offset = "0x100B6D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2D74D84", Offset = "0x2D74D84", VA = "0x2D74D84", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2D74DC4", Offset = "0x2D74DC4", VA = "0x2D74DC4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2D74E58", Offset = "0x2D74E58", VA = "0x2D74E58")]
		private void Update()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2D750D8", Offset = "0x2D750D8", VA = "0x2D750D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2D750E4", Offset = "0x2D750E4", VA = "0x2D750E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2D74EC0", Offset = "0x2D74EC0", VA = "0x2D74EC0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2D750F0", Offset = "0x2D750F0", VA = "0x2D750F0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2D75410", Offset = "0x2D75410", VA = "0x2D75410")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2D75520", Offset = "0x2D75520", VA = "0x2D75520")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2D75678", Offset = "0x2D75678", VA = "0x2D75678")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2D7578C", Offset = "0x2D7578C", VA = "0x2D7578C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002254", Offset = "0x1002254")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002254", Offset = "0x1002254")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003CA4", Offset = "0x1003CA4")]
		public Transform pelvis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003CDC", Offset = "0x1003CDC")]
		public Transform characterRoot;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003D14", Offset = "0x1003D14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003D14", Offset = "0x1003D14")]
		public float rootRotationWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003D68", Offset = "0x1003D68")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003DA0", Offset = "0x1003DA0")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2D75814", Offset = "0x2D75814", VA = "0x2D75814", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B70C", Offset = "0x100B70C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2D7585C", Offset = "0x2D7585C", VA = "0x2D7585C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B744", Offset = "0x100B744")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2D758A4", Offset = "0x2D758A4", VA = "0x2D758A4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2D758C0", Offset = "0x2D758C0", VA = "0x2D758C0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2D75AF4", Offset = "0x2D75AF4", VA = "0x2D75AF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2D75BF0", Offset = "0x2D75BF0", VA = "0x2D75BF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2D7603C", Offset = "0x2D7603C", VA = "0x2D7603C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2D76448", Offset = "0x2D76448", VA = "0x2D76448")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2D765D8", Offset = "0x2D765D8", VA = "0x2D765D8")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2D768DC", Offset = "0x2D768DC", VA = "0x2D768DC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2D76A28", Offset = "0x2D76A28", VA = "0x2D76A28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2D76C10", Offset = "0x2D76C10", VA = "0x2D76C10")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10022B4", Offset = "0x10022B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10022B4", Offset = "0x10022B4")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000039")]
		public struct Foot
		{
			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x2AE802C", Offset = "0x2AE802C", VA = "0x2AE802C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003DD8", Offset = "0x1003DD8")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003E10", Offset = "0x1003E10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003E10", Offset = "0x1003E10")]
		public float rootRotationWeight;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003E64", Offset = "0x1003E64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003E64", Offset = "0x1003E64")]
		public float minRootRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003EBC", Offset = "0x1003EBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003EBC", Offset = "0x1003EBC")]
		public float maxRootRotation;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003F14", Offset = "0x1003F14")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003F4C", Offset = "0x1003F4C")]
		public float maxLegOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003F84", Offset = "0x1003F84")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1003FBC", Offset = "0x1003FBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1003FBC", Offset = "0x1003FBC")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004010", Offset = "0x1004010")]
		public Transform characterRoot;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004048", Offset = "0x1004048")]
		public Transform pelvis;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004080", Offset = "0x1004080")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10040B8", Offset = "0x10040B8")]
		public Transform head;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2D76C98", Offset = "0x2D76C98", VA = "0x2D76C98", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B77C", Offset = "0x100B77C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2D76CE0", Offset = "0x2D76CE0", VA = "0x2D76CE0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B7B4", Offset = "0x100B7B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2D76D28", Offset = "0x2D76D28", VA = "0x2D76D28", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2D76D64", Offset = "0x2D76D64", VA = "0x2D76D64")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2D76E90", Offset = "0x2D76E90", VA = "0x2D76E90")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2D77094", Offset = "0x2D77094", VA = "0x2D77094")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2D770FC", Offset = "0x2D770FC", VA = "0x2D770FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2D77160", Offset = "0x2D77160", VA = "0x2D77160")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2D77494", Offset = "0x2D77494", VA = "0x2D77494")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2D777D8", Offset = "0x2D777D8", VA = "0x2D777D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2D778D0", Offset = "0x2D778D0", VA = "0x2D778D0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2D77C9C", Offset = "0x2D77C9C", VA = "0x2D77C9C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2D782C0", Offset = "0x2D782C0", VA = "0x2D782C0")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2D78490", Offset = "0x2D78490", VA = "0x2D78490")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2D7856C", Offset = "0x2D7856C", VA = "0x2D7856C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2D787B4", Offset = "0x2D787B4", VA = "0x2D787B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2D787EC", Offset = "0x2D787EC", VA = "0x2D787EC")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2D789CC", Offset = "0x2D789CC", VA = "0x2D789CC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002314", Offset = "0x1002314")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002314", Offset = "0x1002314")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004100", Offset = "0x1004100")]
		public VRIK ik;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2E0AD18", Offset = "0x2E0AD18", VA = "0x2E0AD18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B7EC", Offset = "0x100B7EC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2E0AD60", Offset = "0x2E0AD60", VA = "0x2E0AD60", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B824", Offset = "0x100B824")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2E0ADA8", Offset = "0x2E0ADA8", VA = "0x2E0ADA8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100B85C", Offset = "0x100B85C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2E0ADF0", Offset = "0x2E0ADF0", VA = "0x2E0ADF0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2E0AE94", Offset = "0x2E0AE94", VA = "0x2E0AE94")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2E0AF28", Offset = "0x2E0AF28", VA = "0x2E0AF28")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2E0AF88", Offset = "0x2E0AF88", VA = "0x2E0AF88")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2E0B430", Offset = "0x2E0B430", VA = "0x2E0B430")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2E0B868", Offset = "0x2E0B868", VA = "0x2E0B868")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2E0B8F8", Offset = "0x2E0B8F8", VA = "0x2E0B8F8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2E0BAB4", Offset = "0x2E0BAB4", VA = "0x2E0BAB4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2E0BC0C", Offset = "0x2E0BC0C", VA = "0x2E0BC0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2E0BD8C", Offset = "0x2E0BD8C", VA = "0x2E0BD8C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200003C")]
		public enum Quality
		{
			[Token(Token = "0x4000182")]
			Fastest,
			[Token(Token = "0x4000183")]
			Simple,
			[Token(Token = "0x4000184")]
			Best
		}

		[Token(Token = "0x200003D")]
		public class Leg
		{
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10045E4", Offset = "0x10045E4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10045F4", Offset = "0x10045F4")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004604", Offset = "0x1004604")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004614", Offset = "0x1004614")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004624", Offset = "0x1004624")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004634", Offset = "0x1004634")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004644", Offset = "0x1004644")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004654", Offset = "0x1004654")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004664", Offset = "0x1004664")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000022")]
			public bool isGrounded
			{
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x2AE806C", Offset = "0x2AE806C", VA = "0x2AE806C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B934", Offset = "0x100B934")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x2AE8074", Offset = "0x2AE8074", VA = "0x2AE8074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B944", Offset = "0x100B944")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x2AE8080", Offset = "0x2AE8080", VA = "0x2AE8080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B954", Offset = "0x100B954")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x2AE808C", Offset = "0x2AE808C", VA = "0x2AE808C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B964", Offset = "0x100B964")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x2AE8098", Offset = "0x2AE8098", VA = "0x2AE8098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B974", Offset = "0x100B974")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x2AE80A0", Offset = "0x2AE80A0", VA = "0x2AE80A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B984", Offset = "0x100B984")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x2AE80AC", Offset = "0x2AE80AC", VA = "0x2AE80AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B994", Offset = "0x100B994")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x2AE80B4", Offset = "0x2AE80B4", VA = "0x2AE80B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B9A4", Offset = "0x100B9A4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x2AE80BC", Offset = "0x2AE80BC", VA = "0x2AE80BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B9B4", Offset = "0x100B9B4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x2AE80C8", Offset = "0x2AE80C8", VA = "0x2AE80C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B9C4", Offset = "0x100B9C4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x2AE80D4", Offset = "0x2AE80D4", VA = "0x2AE80D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B9D4", Offset = "0x100B9D4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x2AE80DC", Offset = "0x2AE80DC", VA = "0x2AE80DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B9E4", Offset = "0x100B9E4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x2AE80E4", Offset = "0x2AE80E4", VA = "0x2AE80E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B9F4", Offset = "0x100B9F4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x2AE80EC", Offset = "0x2AE80EC", VA = "0x2AE80EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA04", Offset = "0x100BA04")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x2AE80F4", Offset = "0x2AE80F4", VA = "0x2AE80F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA14", Offset = "0x100BA14")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x2AE810C", Offset = "0x2AE810C", VA = "0x2AE810C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA24", Offset = "0x100BA24")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x2AE812C", Offset = "0x2AE812C", VA = "0x2AE812C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA34", Offset = "0x100BA34")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x2AE8144", Offset = "0x2AE8144", VA = "0x2AE8144")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA44", Offset = "0x100BA44")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x2AE8164", Offset = "0x2AE8164", VA = "0x2AE8164")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x2AE915C", Offset = "0x2AE915C", VA = "0x2AE915C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x2AE92C0", Offset = "0x2AE92C0", VA = "0x2AE92C0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x2AE81AC", Offset = "0x2AE81AC", VA = "0x2AE81AC")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2AE81C0", Offset = "0x2AE81C0", VA = "0x2AE81C0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2AE8234", Offset = "0x2AE8234", VA = "0x2AE8234")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2AE8280", Offset = "0x2AE8280", VA = "0x2AE8280")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2AE82F0", Offset = "0x2AE82F0", VA = "0x2AE82F0")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2AE8DD4", Offset = "0x2AE8DD4", VA = "0x2AE8DD4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x2AE8978", Offset = "0x2AE8978", VA = "0x2AE8978")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2AE91F0", Offset = "0x2AE91F0", VA = "0x2AE91F0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2AE8C14", Offset = "0x2AE8C14", VA = "0x2AE8C14")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2AE8CA0", Offset = "0x2AE8CA0", VA = "0x2AE8CA0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2AE9260", Offset = "0x2AE9260", VA = "0x2AE9260")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x2AE9184", Offset = "0x2AE9184", VA = "0x2AE9184")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x2AE9354", Offset = "0x2AE9354", VA = "0x2AE9354")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x2AE93E0", Offset = "0x2AE93E0", VA = "0x2AE93E0")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003E")]
		public class Pelvis
		{
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004674", Offset = "0x1004674")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004684", Offset = "0x1004684")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700002E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x2AE9424", Offset = "0x2AE9424", VA = "0x2AE9424")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA54", Offset = "0x100BA54")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x2AE9430", Offset = "0x2AE9430", VA = "0x2AE9430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA64", Offset = "0x100BA64")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x2AE943C", Offset = "0x2AE943C", VA = "0x2AE943C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA74", Offset = "0x100BA74")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x2AE9444", Offset = "0x2AE9444", VA = "0x2AE9444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100BA84", Offset = "0x100BA84")]
				private set
				{
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x2AE944C", Offset = "0x2AE944C", VA = "0x2AE944C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x2AE94BC", Offset = "0x2AE94BC", VA = "0x2AE94BC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x2AE945C", Offset = "0x2AE945C", VA = "0x2AE945C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x2AE9528", Offset = "0x2AE9528", VA = "0x2AE9528")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x2AE96C8", Offset = "0x2AE96C8", VA = "0x2AE96C8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004138", Offset = "0x1004138")]
		public LayerMask layers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004170", Offset = "0x1004170")]
		public float maxStep;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10041A8", Offset = "0x10041A8")]
		public float heightOffset;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10041E0", Offset = "0x10041E0")]
		public float footSpeed;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004218", Offset = "0x1004218")]
		public float footRadius;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004250", Offset = "0x1004250")]
		public float footCenterOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100429C", Offset = "0x100429C")]
		public float prediction;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10042D4", Offset = "0x10042D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10042D4", Offset = "0x10042D4")]
		public float footRotationWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004328", Offset = "0x1004328")]
		public float footRotationSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004360", Offset = "0x1004360")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004360", Offset = "0x1004360")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10043B8", Offset = "0x10043B8")]
		public bool rotateSolver;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10043F0", Offset = "0x10043F0")]
		public float pelvisSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004428", Offset = "0x1004428")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004428", Offset = "0x1004428")]
		public float pelvisDamper;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100447C", Offset = "0x100447C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10044B4", Offset = "0x10044B4")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10044EC", Offset = "0x10044EC")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004524", Offset = "0x1004524")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100455C", Offset = "0x100455C")]
		public Quality quality;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1004594", Offset = "0x1004594")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10045A4", Offset = "0x10045A4")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10045B4", Offset = "0x10045B4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10045C4", Offset = "0x10045C4")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10045D4", Offset = "0x10045D4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x2E0BDE8", Offset = "0x2E0BDE8", VA = "0x2E0BDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B894", Offset = "0x100B894")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x2E0BDF0", Offset = "0x2E0BDF0", VA = "0x2E0BDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B8A4", Offset = "0x100B8A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x2E0BDF8", Offset = "0x2E0BDF8", VA = "0x2E0BDF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B8B4", Offset = "0x100B8B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x2E0BE00", Offset = "0x2E0BE00", VA = "0x2E0BE00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B8C4", Offset = "0x100B8C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2E0BE08", Offset = "0x2E0BE08", VA = "0x2E0BE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B8D4", Offset = "0x100B8D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x2E0BE10", Offset = "0x2E0BE10", VA = "0x2E0BE10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B8E4", Offset = "0x100B8E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x2E0BE1C", Offset = "0x2E0BE1C", VA = "0x2E0BE1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B8F4", Offset = "0x100B8F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x2E0BE24", Offset = "0x2E0BE24", VA = "0x2E0BE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B904", Offset = "0x100B904")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x2E0BE2C", Offset = "0x2E0BE2C", VA = "0x2E0BE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B914", Offset = "0x100B914")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2E0BE44", Offset = "0x2E0BE44", VA = "0x2E0BE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B924", Offset = "0x100B924")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2E0BE64", Offset = "0x2E0BE64", VA = "0x2E0BE64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2E0C104", Offset = "0x2E0C104", VA = "0x2E0C104")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2E0C3C8", Offset = "0x2E0C3C8", VA = "0x2E0C3C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2E0BEB8", Offset = "0x2E0BEB8", VA = "0x2E0BEB8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2E0C148", Offset = "0x2E0C148", VA = "0x2E0C148")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2E0B1A8", Offset = "0x2E0B1A8", VA = "0x2E0B1A8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2E0B620", Offset = "0x2E0B620", VA = "0x2E0B620")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2E0C268", Offset = "0x2E0C268", VA = "0x2E0C268")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2E0AE08", Offset = "0x2E0AE08", VA = "0x2E0AE08")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2E0C250", Offset = "0x2E0C250", VA = "0x2E0C250")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2E0C448", Offset = "0x2E0C448", VA = "0x2E0C448")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2E0C4D8", Offset = "0x2E0C4D8", VA = "0x2E0C4D8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2E0C594", Offset = "0x2E0C594", VA = "0x2E0C594")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2E0C610", Offset = "0x2E0C610", VA = "0x2E0C610")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002374", Offset = "0x1002374")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002374", Offset = "0x1002374")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2D35B04", Offset = "0x2D35B04", VA = "0x2D35B04", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BA94", Offset = "0x100BA94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2D35B4C", Offset = "0x2D35B4C", VA = "0x2D35B4C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BACC", Offset = "0x100BACC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2D35B94", Offset = "0x2D35B94", VA = "0x2D35B94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BB04", Offset = "0x100BB04")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2D35BDC", Offset = "0x2D35BDC", VA = "0x2D35BDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BB3C", Offset = "0x100BB3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2D35C24", Offset = "0x2D35C24", VA = "0x2D35C24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BB74", Offset = "0x100BB74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2D35C6C", Offset = "0x2D35C6C", VA = "0x2D35C6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2D35C74", Offset = "0x2D35C74", VA = "0x2D35C74")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10023D4", Offset = "0x10023D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10023D4", Offset = "0x10023D4")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2D37564", Offset = "0x2D37564", VA = "0x2D37564", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BBAC", Offset = "0x100BBAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2D375AC", Offset = "0x2D375AC", VA = "0x2D375AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BBE4", Offset = "0x100BBE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2D375F4", Offset = "0x2D375F4", VA = "0x2D375F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BC1C", Offset = "0x100BC1C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2D3763C", Offset = "0x2D3763C", VA = "0x2D3763C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BC54", Offset = "0x100BC54")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2D37684", Offset = "0x2D37684", VA = "0x2D37684", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2D3768C", Offset = "0x2D3768C", VA = "0x2D3768C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002434", Offset = "0x1002434")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002434", Offset = "0x1002434")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2D43508", Offset = "0x2D43508", VA = "0x2D43508", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BC8C", Offset = "0x100BC8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2D43550", Offset = "0x2D43550", VA = "0x2D43550", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BCC4", Offset = "0x100BCC4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2D43598", Offset = "0x2D43598", VA = "0x2D43598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BCFC", Offset = "0x100BCFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2D435E0", Offset = "0x2D435E0", VA = "0x2D435E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BD34", Offset = "0x100BD34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2D43628", Offset = "0x2D43628", VA = "0x2D43628", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2D43630", Offset = "0x2D43630", VA = "0x2D43630")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002494", Offset = "0x1002494")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002494", Offset = "0x1002494")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2D696B0", Offset = "0x2D696B0", VA = "0x2D696B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BD6C", Offset = "0x100BD6C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2D696F8", Offset = "0x2D696F8", VA = "0x2D696F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BDA4", Offset = "0x100BDA4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2D69740", Offset = "0x2D69740", VA = "0x2D69740")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BDDC", Offset = "0x100BDDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2D69788", Offset = "0x2D69788", VA = "0x2D69788")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BE14", Offset = "0x100BE14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2D697D0", Offset = "0x2D697D0", VA = "0x2D697D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2D697D8", Offset = "0x2D697D8", VA = "0x2D697D8")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10024F4", Offset = "0x10024F4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10024F4", Offset = "0x10024F4")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2D69CFC", Offset = "0x2D69CFC", VA = "0x2D69CFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BE4C", Offset = "0x100BE4C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2D69D44", Offset = "0x2D69D44", VA = "0x2D69D44", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BE84", Offset = "0x100BE84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2D69D8C", Offset = "0x2D69D8C", VA = "0x2D69D8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BEBC", Offset = "0x100BEBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2D69DD4", Offset = "0x2D69DD4", VA = "0x2D69DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BEF4", Offset = "0x100BEF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2D69E1C", Offset = "0x2D69E1C", VA = "0x2D69E1C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2D69E24", Offset = "0x2D69E24", VA = "0x2D69E24")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002554", Offset = "0x1002554")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002554", Offset = "0x1002554")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2D72494", Offset = "0x2D72494", VA = "0x2D72494", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BF2C", Offset = "0x100BF2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2D724DC", Offset = "0x2D724DC", VA = "0x2D724DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BF64", Offset = "0x100BF64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2D72524", Offset = "0x2D72524", VA = "0x2D72524")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BF9C", Offset = "0x100BF9C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2D7256C", Offset = "0x2D7256C", VA = "0x2D7256C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100BFD4", Offset = "0x100BFD4")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2D725B4", Offset = "0x2D725B4", VA = "0x2D725B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C00C", Offset = "0x100C00C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2D725FC", Offset = "0x2D725FC", VA = "0x2D725FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C044", Offset = "0x100C044")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2D72644", Offset = "0x2D72644", VA = "0x2D72644")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2D72668", Offset = "0x2D72668", VA = "0x2D72668", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2D72670", Offset = "0x2D72670", VA = "0x2D72670")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2D7284C", Offset = "0x2D7284C", VA = "0x2D7284C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2D72AE0", Offset = "0x2D72AE0", VA = "0x2D72AE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C07C", Offset = "0x100C07C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2D72B00", Offset = "0x2D72B00", VA = "0x2D72B00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C0B4", Offset = "0x100C0B4")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2D72BD8", Offset = "0x2D72BD8", VA = "0x2D72BD8")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000220")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2E0FB14", Offset = "0x2E0FB14", VA = "0x2E0FB14", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2E0FC08", Offset = "0x2E0FC08", VA = "0x2E0FC08", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2E0FDEC", Offset = "0x2E0FDEC", VA = "0x2E0FDEC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000224")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000225")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2E0FE4C", Offset = "0x2E0FE4C", VA = "0x2E0FE4C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004694", Offset = "0x1004694")]
		public IK[] IKComponents;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10046CC", Offset = "0x10046CC")]
		public Animator animator;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x2E123BC", Offset = "0x2E123BC", VA = "0x2E123BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2E12454", Offset = "0x2E12454", VA = "0x2E12454")]
		private void Start()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2E124C4", Offset = "0x2E124C4", VA = "0x2E124C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2E12580", Offset = "0x2E12580", VA = "0x2E12580")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2E125BC", Offset = "0x2E125BC", VA = "0x2E125BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2E124F8", Offset = "0x2E124F8", VA = "0x2E124F8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2E12648", Offset = "0x2E12648", VA = "0x2E12648")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10025B4", Offset = "0x10025B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10025B4", Offset = "0x10025B4")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2C3EA64", Offset = "0x2C3EA64", VA = "0x2C3EA64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C0EC", Offset = "0x100C0EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2C3EAAC", Offset = "0x2C3EAAC", VA = "0x2C3EAAC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C124", Offset = "0x100C124")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2C3EAF4", Offset = "0x2C3EAF4", VA = "0x2C3EAF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C15C", Offset = "0x100C15C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2C3EB3C", Offset = "0x2C3EB3C", VA = "0x2C3EB3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C194", Offset = "0x100C194")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2C3EB84", Offset = "0x2C3EB84", VA = "0x2C3EB84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2C3EB8C", Offset = "0x2C3EB8C", VA = "0x2C3EB8C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002614", Offset = "0x1002614")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002614", Offset = "0x1002614")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2C3EBF0", Offset = "0x2C3EBF0", VA = "0x2C3EBF0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C1CC", Offset = "0x100C1CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2C3EC38", Offset = "0x2C3EC38", VA = "0x2C3EC38", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C204", Offset = "0x100C204")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2C3EC80", Offset = "0x2C3EC80", VA = "0x2C3EC80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C23C", Offset = "0x100C23C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2C3ECC8", Offset = "0x2C3ECC8", VA = "0x2C3ECC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C274", Offset = "0x100C274")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2C3ED10", Offset = "0x2C3ED10", VA = "0x2C3ED10", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2C3ED18", Offset = "0x2C3ED18", VA = "0x2C3ED18")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002674", Offset = "0x1002674")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002674", Offset = "0x1002674")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2C3F6F0", Offset = "0x2C3F6F0", VA = "0x2C3F6F0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C2AC", Offset = "0x100C2AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2C3F738", Offset = "0x2C3F738", VA = "0x2C3F738", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C2E4", Offset = "0x100C2E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2C3F780", Offset = "0x2C3F780", VA = "0x2C3F780")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C31C", Offset = "0x100C31C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2C3F7C8", Offset = "0x2C3F7C8", VA = "0x2C3F7C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C354", Offset = "0x100C354")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2C3F810", Offset = "0x2C3F810", VA = "0x2C3F810", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2C3F818", Offset = "0x2C3F818", VA = "0x2C3F818")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10026D4", Offset = "0x10026D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10026D4", Offset = "0x10026D4")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2AE09C4", Offset = "0x2AE09C4", VA = "0x2AE09C4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C38C", Offset = "0x100C38C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2AE0A0C", Offset = "0x2AE0A0C", VA = "0x2AE0A0C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C3C4", Offset = "0x100C3C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2AE0A54", Offset = "0x2AE0A54", VA = "0x2AE0A54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C3FC", Offset = "0x100C3FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2AE0A9C", Offset = "0x2AE0A9C", VA = "0x2AE0A9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C434", Offset = "0x100C434")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2AE0AE4", Offset = "0x2AE0AE4", VA = "0x2AE0AE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2AE0AEC", Offset = "0x2AE0AEC", VA = "0x2AE0AEC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002734", Offset = "0x1002734")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200004C")]
		public class References
		{
			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10047B0", Offset = "0x10047B0")]
			public Transform chest;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10047E8", Offset = "0x10047E8")]
			public Transform neck;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004820", Offset = "0x1004820")]
			public Transform leftShoulder;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004858", Offset = "0x1004858")]
			public Transform rightShoulder;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004890", Offset = "0x1004890")]
			public Transform leftThigh;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10048C8", Offset = "0x10048C8")]
			public Transform leftCalf;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004900", Offset = "0x1004900")]
			public Transform leftFoot;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004938", Offset = "0x1004938")]
			public Transform leftToes;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004970", Offset = "0x1004970")]
			public Transform rightThigh;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10049A8", Offset = "0x10049A8")]
			public Transform rightCalf;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10049E0", Offset = "0x10049E0")]
			public Transform rightFoot;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004A18", Offset = "0x1004A18")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x2DEE3A4", Offset = "0x2DEE3A4", VA = "0x2DEE3A4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x2DEE81C", Offset = "0x2DEE81C", VA = "0x2DEE81C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2DEDF5C", Offset = "0x2DEDF5C", VA = "0x2DEDF5C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2DEEC94", Offset = "0x2DEEC94", VA = "0x2DEEC94")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2DEF030", Offset = "0x2DEF030", VA = "0x2DEF030")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004704", Offset = "0x1004704")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x1004704", Offset = "0x1004704")]
		public References references;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004778", Offset = "0x1004778")]
		public IKSolverVR solver;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2AE2C5C", Offset = "0x2AE2C5C", VA = "0x2AE2C5C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C46C", Offset = "0x100C46C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2AE2CA4", Offset = "0x2AE2CA4", VA = "0x2AE2CA4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C4A4", Offset = "0x100C4A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2AE2CEC", Offset = "0x2AE2CEC", VA = "0x2AE2CEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C4DC", Offset = "0x100C4DC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2AE2D34", Offset = "0x2AE2D34", VA = "0x2AE2D34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C514", Offset = "0x100C514")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2AE2D60", Offset = "0x2AE2D60", VA = "0x2AE2D60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C54C", Offset = "0x100C54C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2AE2D88", Offset = "0x2AE2D88", VA = "0x2AE2D88", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2AE2D90", Offset = "0x2AE2D90", VA = "0x2AE2D90", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2AE2E10", Offset = "0x2AE2E10", VA = "0x2AE2E10", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2AE2F7C", Offset = "0x2AE2F7C", VA = "0x2AE2F7C")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004A50", Offset = "0x1004A50")]
		public float pull;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004A68", Offset = "0x1004A68")]
		public float pin;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2D6983C", Offset = "0x2D6983C", VA = "0x2D6983C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2D6990C", Offset = "0x2D6990C", VA = "0x2D6990C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2D6992C", Offset = "0x2D6992C", VA = "0x2D6992C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2D69BA0", Offset = "0x2D69BA0", VA = "0x2D69BA0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2D69A00", Offset = "0x2D69A00", VA = "0x2D69A00")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2D69C98", Offset = "0x2D69C98", VA = "0x2D69C98")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2D69E88", Offset = "0x2D69E88", VA = "0x2D69E88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2D6A2EC", Offset = "0x2D6A2EC", VA = "0x2D6A2EC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2D6A4A8", Offset = "0x2D6A4A8", VA = "0x2D6A4A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2D6A5B4", Offset = "0x2D6A5B4", VA = "0x2D6A5B4")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000050")]
		public class BendBone
		{
			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10050C0", Offset = "0x10050C0")]
			public Transform transform;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10050F8", Offset = "0x10050F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10050F8", Offset = "0x10050F8")]
			public float weight;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2AE7404", Offset = "0x2AE7404", VA = "0x2AE7404")]
			public BendBone()
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2AE7440", Offset = "0x2AE7440", VA = "0x2AE7440")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2AE7498", Offset = "0x2AE7498", VA = "0x2AE7498")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2AE74D0", Offset = "0x2AE74D0", VA = "0x2AE74D0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004A80", Offset = "0x1004A80")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004AB8", Offset = "0x1004AB8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1004AB8", Offset = "0x1004AB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004AB8", Offset = "0x1004AB8")]
		public float positionWeight;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004B30", Offset = "0x1004B30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004B30", Offset = "0x1004B30")]
		public float bodyWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004B84", Offset = "0x1004B84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004B84", Offset = "0x1004B84")]
		public float thighWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004BD8", Offset = "0x1004BD8")]
		public bool handsPullBody;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1004C10", Offset = "0x1004C10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004C10", Offset = "0x1004C10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004C10", Offset = "0x1004C10")]
		public float rotationWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004C88", Offset = "0x1004C88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004C88", Offset = "0x1004C88")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004CDC", Offset = "0x1004CDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004CDC", Offset = "0x1004CDC")]
		public float headClampWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004D30", Offset = "0x1004D30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004D30", Offset = "0x1004D30")]
		public float bendWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004D84", Offset = "0x1004D84")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1004DBC", Offset = "0x1004DBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004DBC", Offset = "0x1004DBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004DBC", Offset = "0x1004DBC")]
		public float CCDWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004E34", Offset = "0x1004E34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004E34", Offset = "0x1004E34")]
		public float roll;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004E88", Offset = "0x1004E88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004E88", Offset = "0x1004E88")]
		public float damper;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004EE0", Offset = "0x1004EE0")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1004F18", Offset = "0x1004F18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004F18", Offset = "0x1004F18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1004F18", Offset = "0x1004F18")]
		public float postStretchWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004F90", Offset = "0x1004F90")]
		public float maxStretch;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1004FC8", Offset = "0x1004FC8")]
		public float stretchDamper;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005000", Offset = "0x1005000")]
		public bool fixHead;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005038", Offset = "0x1005038")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1005070", Offset = "0x1005070")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10050A8", Offset = "0x10050A8")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2D6A5BC", Offset = "0x2D6A5BC", VA = "0x2D6A5BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2D6A8F0", Offset = "0x2D6A8F0", VA = "0x2D6A8F0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2D6AD90", Offset = "0x2D6AD90", VA = "0x2D6AD90")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2D6B15C", Offset = "0x2D6B15C", VA = "0x2D6B15C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2D6B8E8", Offset = "0x2D6B8E8", VA = "0x2D6B8E8")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2D6BBC8", Offset = "0x2D6BBC8", VA = "0x2D6BBC8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2D6BECC", Offset = "0x2D6BECC", VA = "0x2D6BECC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2D6C6A0", Offset = "0x2D6C6A0", VA = "0x2D6C6A0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2D6B6CC", Offset = "0x2D6B6CC", VA = "0x2D6B6CC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2D6C868", Offset = "0x2D6C868", VA = "0x2D6C868")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2D6C5B8", Offset = "0x2D6C5B8", VA = "0x2D6C5B8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2D6C4EC", Offset = "0x2D6C4EC", VA = "0x2D6C4EC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2D6CAEC", Offset = "0x2D6CAEC", VA = "0x2D6CAEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2D6CDBC", Offset = "0x2D6CDBC", VA = "0x2D6CDBC")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		public class ChildConstraint
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10051E4", Offset = "0x10051E4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10051F4", Offset = "0x10051F4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000033")]
			public float nominalDistance
			{
				[Token(Token = "0x6000284")]
				[Address(RVA = "0x2AE758C", Offset = "0x2AE758C", VA = "0x2AE758C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C584", Offset = "0x100C584")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x2AE7594", Offset = "0x2AE7594", VA = "0x2AE7594")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C594", Offset = "0x100C594")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x2AE759C", Offset = "0x2AE759C", VA = "0x2AE759C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C5A4", Offset = "0x100C5A4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x2AE75A4", Offset = "0x2AE75A4", VA = "0x2AE75A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C5B4", Offset = "0x100C5B4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2AE75B0", Offset = "0x2AE75B0", VA = "0x2AE75B0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2AE75FC", Offset = "0x2AE75FC", VA = "0x2AE75FC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2AE7654", Offset = "0x2AE7654", VA = "0x2AE7654")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x2AE77F8", Offset = "0x2AE77F8", VA = "0x2AE77F8")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000053")]
		public enum Smoothing
		{
			[Token(Token = "0x4000226")]
			None,
			[Token(Token = "0x4000227")]
			Exponential,
			[Token(Token = "0x4000228")]
			Cubic
		}

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100514C", Offset = "0x100514C")]
		public float pin;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005164", Offset = "0x1005164")]
		public float pull;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100517C", Offset = "0x100517C")]
		public float push;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005194", Offset = "0x1005194")]
		public float pushParent;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10051AC", Offset = "0x10051AC")]
		public float reach;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400021A")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2D6D498", Offset = "0x2D6D498", VA = "0x2D6D498")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2D6D584", Offset = "0x2D6D584", VA = "0x2D6D584")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2D6D6B0", Offset = "0x2D6D6B0", VA = "0x2D6D6B0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2D6D7DC", Offset = "0x2D6D7DC", VA = "0x2D6D7DC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2D6D8B4", Offset = "0x2D6D8B4", VA = "0x2D6D8B4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2D6D9CC", Offset = "0x2D6D9CC", VA = "0x2D6D9CC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2D6E048", Offset = "0x2D6E048", VA = "0x2D6E048")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2D6DB5C", Offset = "0x2D6DB5C", VA = "0x2D6DB5C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2D6E438", Offset = "0x2D6E438", VA = "0x2D6E438")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2D6E698", Offset = "0x2D6E698", VA = "0x2D6E698")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2D6E904", Offset = "0x2D6E904", VA = "0x2D6E904")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2D6ECA8", Offset = "0x2D6ECA8", VA = "0x2D6ECA8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2D6F13C", Offset = "0x2D6F13C", VA = "0x2D6F13C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2D6F360", Offset = "0x2D6F360", VA = "0x2D6F360")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2D6F0CC", Offset = "0x2D6F0CC", VA = "0x2D6F0CC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2D6EB34", Offset = "0x2D6EB34", VA = "0x2D6EB34")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2D6F050", Offset = "0x2D6F050", VA = "0x2D6F050")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2D6F448", Offset = "0x2D6F448", VA = "0x2D6F448")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2D6EF70", Offset = "0x2D6EF70", VA = "0x2D6EF70")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2D6F248", Offset = "0x2D6F248", VA = "0x2D6F248")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005204", Offset = "0x1005204")]
		public float weight;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100521C", Offset = "0x100521C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2E1003C", Offset = "0x2E1003C", VA = "0x2E1003C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C5C4", Offset = "0x100C5C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2E10044", Offset = "0x2E10044", VA = "0x2E10044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C5D4", Offset = "0x100C5D4")]
			private set
			{
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2E0FE54", Offset = "0x2E0FE54", VA = "0x2E0FE54")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2E10050", Offset = "0x2E10050", VA = "0x2E10050")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2E10090", Offset = "0x2E10090", VA = "0x2E10090")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2E100F0", Offset = "0x2E100F0", VA = "0x2E100F0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2E100FC", Offset = "0x2E100FC", VA = "0x2E100FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2E10474", Offset = "0x2E10474", VA = "0x2E10474")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2E10664", Offset = "0x2E10664", VA = "0x2E10664")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2E109B0", Offset = "0x2E109B0", VA = "0x2E109B0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2E10334", Offset = "0x2E10334", VA = "0x2E10334")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2E103D4", Offset = "0x2E103D4", VA = "0x2E103D4")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKEffector
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100522C", Offset = "0x100522C")]
		public float positionWeight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005244", Offset = "0x1005244")]
		public float rotationWeight;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100525C", Offset = "0x100525C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100526C", Offset = "0x100526C")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000036")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x2E10E90", Offset = "0x2E10E90", VA = "0x2E10E90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C5E4", Offset = "0x100C5E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2E10E98", Offset = "0x2E10E98", VA = "0x2E10E98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C5F4", Offset = "0x100C5F4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2E10E28", Offset = "0x2E10E28", VA = "0x2E10E28")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2E10EA4", Offset = "0x2E10EA4", VA = "0x2E10EA4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2E10F34", Offset = "0x2E10F34", VA = "0x2E10F34")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2E11048", Offset = "0x2E11048", VA = "0x2E11048")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2E11178", Offset = "0x2E11178", VA = "0x2E11178")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2E11494", Offset = "0x2E11494", VA = "0x2E11494")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2E11714", Offset = "0x2E11714", VA = "0x2E11714")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2E117E0", Offset = "0x2E117E0", VA = "0x2E117E0")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2E11888", Offset = "0x2E11888", VA = "0x2E11888")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2E11DB0", Offset = "0x2E11DB0", VA = "0x2E11DB0")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2E11DDC", Offset = "0x2E11DDC", VA = "0x2E11DDC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2E11F30", Offset = "0x2E11F30", VA = "0x2E11F30")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2E121A8", Offset = "0x2E121A8", VA = "0x2E121A8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000057")]
		public class BoneMap
		{
			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000037")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002AD")]
				[Address(RVA = "0x2ADEBAC", Offset = "0x2ADEBAC", VA = "0x2ADEBAC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0x2AEAAD0", Offset = "0x2AEAAD0", VA = "0x2AEAAD0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x2AEAE74", Offset = "0x2AEAE74", VA = "0x2AEAE74")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x2AEAA04", Offset = "0x2AEAA04", VA = "0x2AEAA04")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2AEAA30", Offset = "0x2AEAA30", VA = "0x2AEAA30")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2AEAA80", Offset = "0x2AEAA80", VA = "0x2AEAA80")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2AEAAE0", Offset = "0x2AEAAE0", VA = "0x2AEAAE0")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2AEAB68", Offset = "0x2AEAB68", VA = "0x2AEAB68")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2AEAB70", Offset = "0x2AEAB70", VA = "0x2AEAB70")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2AEAC48", Offset = "0x2AEAC48", VA = "0x2AEAC48")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x2AEACC0", Offset = "0x2AEACC0", VA = "0x2AEACC0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2AEAD58", Offset = "0x2AEAD58", VA = "0x2AEAD58")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x2AEAFB4", Offset = "0x2AEAFB4", VA = "0x2AEAFB4")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x2AEAFEC", Offset = "0x2AEAFEC", VA = "0x2AEAFEC")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2AEB024", Offset = "0x2AEB024", VA = "0x2AEB024")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x2AEB04C", Offset = "0x2AEB04C", VA = "0x2AEB04C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2AEB138", Offset = "0x2AEB138", VA = "0x2AEB138")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x2AEB2C4", Offset = "0x2AEB2C4", VA = "0x2AEB2C4")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x2AEB2F4", Offset = "0x2AEB2F4", VA = "0x2AEB2F4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x2AEB3BC", Offset = "0x2AEB3BC", VA = "0x2AEB3BC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x2AEB42C", Offset = "0x2AEB42C", VA = "0x2AEB42C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x2AEB57C", Offset = "0x2AEB57C", VA = "0x2AEB57C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2AEB6CC", Offset = "0x2AEB6CC", VA = "0x2AEB6CC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x2AEB74C", Offset = "0x2AEB74C", VA = "0x2AEB74C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x2AEB1B4", Offset = "0x2AEB1B4", VA = "0x2AEB1B4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x2AEB884", Offset = "0x2AEB884", VA = "0x2AEB884")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2E12650", Offset = "0x2E12650", VA = "0x2E12650", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2E12658", Offset = "0x2E12658", VA = "0x2E12658", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2E1265C", Offset = "0x2E1265C", VA = "0x2E1265C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2E127A0", Offset = "0x2E127A0", VA = "0x2E127A0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2E12810", Offset = "0x2E12810", VA = "0x2E12810")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005284", Offset = "0x1005284")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2E12818", Offset = "0x2E12818", VA = "0x2E12818", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2E128C0", Offset = "0x2E128C0", VA = "0x2E128C0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2E1292C", Offset = "0x2E1292C", VA = "0x2E1292C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2E129AC", Offset = "0x2E129AC", VA = "0x2E129AC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2E129C8", Offset = "0x2E129C8", VA = "0x2E129C8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2E129E8", Offset = "0x2E129E8", VA = "0x2E129E8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2E12A70", Offset = "0x2E12A70", VA = "0x2E12A70")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2E12A8C", Offset = "0x2E12A8C", VA = "0x2E12A8C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200005A")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000280")]
			Parent,
			[Token(Token = "0x4000281")]
			Bone1,
			[Token(Token = "0x4000282")]
			Bone2,
			[Token(Token = "0x4000283")]
			Bone3
		}

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100529C", Offset = "0x100529C")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10052B4", Offset = "0x10052B4")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2E12AB4", Offset = "0x2E12AB4", VA = "0x2E12AB4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2E12B38", Offset = "0x2E12B38", VA = "0x2E12B38")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2E12C14", Offset = "0x2E12C14", VA = "0x2E12C14")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2E12E38", Offset = "0x2E12E38", VA = "0x2E12E38")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2E12EFC", Offset = "0x2E12EFC", VA = "0x2E12EFC")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2E12FEC", Offset = "0x2E12FEC", VA = "0x2E12FEC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2E12FF8", Offset = "0x2E12FF8", VA = "0x2E12FF8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2E130AC", Offset = "0x2E130AC", VA = "0x2E130AC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2E13170", Offset = "0x2E13170", VA = "0x2E13170", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2E133B0", Offset = "0x2E133B0", VA = "0x2E133B0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2E13424", Offset = "0x2E13424", VA = "0x2E13424")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10052CC", Offset = "0x10052CC")]
		public int iterations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10052E4", Offset = "0x10052E4")]
		public float twistWeight;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2E135A0", Offset = "0x2E135A0", VA = "0x2E135A0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2E13904", Offset = "0x2E13904", VA = "0x2E13904")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2E139E8", Offset = "0x2E139E8", VA = "0x2E139E8")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2E13B00", Offset = "0x2E13B00", VA = "0x2E13B00")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2E13B10", Offset = "0x2E13B10", VA = "0x2E13B10")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2E13B7C", Offset = "0x2E13B7C", VA = "0x2E13B7C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2E13C00", Offset = "0x2E13C00", VA = "0x2E13C00", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2E141D8", Offset = "0x2E141D8", VA = "0x2E141D8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2E14210", Offset = "0x2E14210", VA = "0x2E14210")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2E14494", Offset = "0x2E14494", VA = "0x2E14494")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2E14794", Offset = "0x2E14794", VA = "0x2E14794")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2E14880", Offset = "0x2E14880", VA = "0x2E14880")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2E14948", Offset = "0x2E14948", VA = "0x2E14948")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200005D")]
		public class Point
		{
			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10053A8", Offset = "0x10053A8")]
			public float weight;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x2AEC390", Offset = "0x2AEC390", VA = "0x2AEC390")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x2AEC3E0", Offset = "0x2AEC3E0", VA = "0x2AEC3E0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x2AEC480", Offset = "0x2AEC480", VA = "0x2AEC480")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x2AEC4B8", Offset = "0x2AEC4B8", VA = "0x2AEC4B8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x2AEC4F0", Offset = "0x2AEC4F0", VA = "0x2AEC4F0")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x2AEC540", Offset = "0x2AEC540", VA = "0x2AEC540")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2AEBF70", Offset = "0x2AEBF70", VA = "0x2AEBF70")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		public class Bone : Point
		{
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700003B")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x2AEB8A0", Offset = "0x2AEB8A0", VA = "0x2AEB8A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x2AEB99C", Offset = "0x2AEB99C", VA = "0x2AEB99C")]
				set
				{
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x2AEBA20", Offset = "0x2AEBA20", VA = "0x2AEBA20")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x2AEBBD0", Offset = "0x2AEBBD0", VA = "0x2AEBBD0")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2AEBDA4", Offset = "0x2AEBDA4", VA = "0x2AEBDA4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2AEBF04", Offset = "0x2AEBF04", VA = "0x2AEBF04")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2AEBF2C", Offset = "0x2AEBF2C", VA = "0x2AEBF2C")]
			public Bone()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2AEBFAC", Offset = "0x2AEBFAC", VA = "0x2AEBFAC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2AEBFFC", Offset = "0x2AEBFFC", VA = "0x2AEBFFC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public class Node : Point
		{
			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2AEC32C", Offset = "0x2AEC32C", VA = "0x2AEC32C")]
			public Node()
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2AEC330", Offset = "0x2AEC330", VA = "0x2AEC330")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x2AEC358", Offset = "0x2AEC358", VA = "0x2AEC358")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000060")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000061")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100530C", Offset = "0x100530C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100530C", Offset = "0x100530C")]
		public float IKPositionWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005360", Offset = "0x1005360")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x2E14C78", Offset = "0x2E14C78", VA = "0x2E14C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C604", Offset = "0x100C604")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x2E14C80", Offset = "0x2E14C80", VA = "0x2E14C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C614", Offset = "0x100C614")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2E14BA8", Offset = "0x2E14BA8", VA = "0x2E14BA8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2E0FC78", Offset = "0x2E0FC78", VA = "0x2E0FC78")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2E0FB98", Offset = "0x2E0FB98", VA = "0x2E0FB98")]
		public void Update()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2E14C20", Offset = "0x2E14C20", VA = "0x2E14C20", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2E14C2C", Offset = "0x2E14C2C", VA = "0x2E14C2C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2E14C38", Offset = "0x2E14C38", VA = "0x2E14C38")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2E14C40", Offset = "0x2E14C40", VA = "0x2E14C40")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2E14C70", Offset = "0x2E14C70", VA = "0x2E14C70")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002F2")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002F3")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002F4")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002F5")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002F6")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2E14C8C", Offset = "0x2E14C8C", VA = "0x2E14C8C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2E14CA4", Offset = "0x2E14CA4", VA = "0x2E14CA4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2E14DDC", Offset = "0x2E14DDC", VA = "0x2E14DDC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2E14E84", Offset = "0x2E14E84", VA = "0x2E14E84")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2E1510C", Offset = "0x2E1510C", VA = "0x2E1510C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10053C0", Offset = "0x10053C0")]
		public float poleWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10053D8", Offset = "0x10053D8")]
		public float clampWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10053F0", Offset = "0x10053F0")]
		public int clampSmoothing;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700003C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2E151A0", Offset = "0x2E151A0", VA = "0x2E151A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2E151DC", Offset = "0x2E151DC", VA = "0x2E151DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x2E15C6C", Offset = "0x2E15C6C", VA = "0x2E15C6C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x2E16050", Offset = "0x2E16050", VA = "0x2E16050", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2E15124", Offset = "0x2E15124", VA = "0x2E15124")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2E15218", Offset = "0x2E15218", VA = "0x2E15218", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2E15438", Offset = "0x2E15438", VA = "0x2E15438", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2E15BB8", Offset = "0x2E15BB8", VA = "0x2E15BB8")]
		private void Solve()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2E15948", Offset = "0x2E15948", VA = "0x2E15948")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2E15C74", Offset = "0x2E15C74", VA = "0x2E15C74")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2E160C4", Offset = "0x2E160C4", VA = "0x2E160C4")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005408", Offset = "0x1005408")]
		public float IKRotationWeight;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2E16118", Offset = "0x2E16118", VA = "0x2E16118", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2E164B4", Offset = "0x2E164B4", VA = "0x2E164B4")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2E16520", Offset = "0x2E16520", VA = "0x2E16520", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2E16678", Offset = "0x2E16678", VA = "0x2E16678", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2E1680C", Offset = "0x2E1680C", VA = "0x2E1680C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2E16868", Offset = "0x2E16868", VA = "0x2E16868", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2E168D8", Offset = "0x2E168D8", VA = "0x2E168D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2E16C48", Offset = "0x2E16C48", VA = "0x2E16C48", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2E16C74", Offset = "0x2E16C74", VA = "0x2E16C74")]
		private void Solve()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2E1693C", Offset = "0x2E1693C", VA = "0x2E1693C")]
		private void Read()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2E16CE0", Offset = "0x2E16CE0", VA = "0x2E16CE0")]
		private void Write()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2E16E6C", Offset = "0x2E16E6C", VA = "0x2E16E6C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2E16FD0", Offset = "0x2E16FD0", VA = "0x2E16FD0")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2E17080", Offset = "0x2E17080", VA = "0x2E17080", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2E17104", Offset = "0x2E17104", VA = "0x2E17104", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2E17334", Offset = "0x2E17334", VA = "0x2E17334")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2E17910", Offset = "0x2E17910", VA = "0x2E17910")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000040")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2E18820", Offset = "0x2E18820", VA = "0x2E18820", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2E17918", Offset = "0x2E17918", VA = "0x2E17918")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2E17EDC", Offset = "0x2E17EDC", VA = "0x2E17EDC")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2E1801C", Offset = "0x2E1801C", VA = "0x2E1801C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2E180B0", Offset = "0x2E180B0", VA = "0x2E180B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2E1858C", Offset = "0x2E1858C", VA = "0x2E1858C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2E18828", Offset = "0x2E18828", VA = "0x2E18828")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2E179F4", Offset = "0x2E179F4", VA = "0x2E179F4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2E17FC8", Offset = "0x2E17FC8", VA = "0x2E17FC8")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2E187C4", Offset = "0x2E187C4", VA = "0x2E187C4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2E17D50", Offset = "0x2E17D50", VA = "0x2E17D50")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2E18E78", Offset = "0x2E18E78", VA = "0x2E18E78")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2E18EEC", Offset = "0x2E18EEC", VA = "0x2E18EEC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2E18FB4", Offset = "0x2E18FB4", VA = "0x2E18FB4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2E19064", Offset = "0x2E19064", VA = "0x2E19064")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2E1833C", Offset = "0x2E1833C", VA = "0x2E1833C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2E18464", Offset = "0x2E18464", VA = "0x2E18464")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2E19168", Offset = "0x2E19168", VA = "0x2E19168")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2E18A48", Offset = "0x2E18A48", VA = "0x2E18A48")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2E17FB8", Offset = "0x2E17FB8", VA = "0x2E17FB8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2E196F8", Offset = "0x2E196F8", VA = "0x2E196F8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2E192AC", Offset = "0x2E192AC", VA = "0x2E192AC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2E188A4", Offset = "0x2E188A4", VA = "0x2E188A4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2E18984", Offset = "0x2E18984", VA = "0x2E18984")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2E197C4", Offset = "0x2E197C4", VA = "0x2E197C4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005420", Offset = "0x1005420")]
		public float rootPin;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2E19844", Offset = "0x2E19844", VA = "0x2E19844", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2E19E84", Offset = "0x2E19E84", VA = "0x2E19E84", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2E19F1C", Offset = "0x2E19F1C", VA = "0x2E19F1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2E19FBC", Offset = "0x2E19FBC", VA = "0x2E19FBC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2E1A0B8", Offset = "0x2E1A0B8", VA = "0x2E1A0B8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x2E1A154", Offset = "0x2E1A154", VA = "0x2E1A154", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2E1A584", Offset = "0x2E1A584", VA = "0x2E1A584", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2E1A77C", Offset = "0x2E1A77C", VA = "0x2E1A77C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2E1A630", Offset = "0x2E1A630", VA = "0x2E1A630")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2E1A340", Offset = "0x2E1A340", VA = "0x2E1A340")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2E1A814", Offset = "0x2E1A814", VA = "0x2E1A814")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005438", Offset = "0x1005438")]
		public int iterations;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x2E1A888", Offset = "0x2E1A888", VA = "0x2E1A888")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2E1A978", Offset = "0x2E1A978", VA = "0x2E1A978")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2E1A9D4", Offset = "0x2E1A9D4", VA = "0x2E1A9D4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2E10DCC", Offset = "0x2E10DCC", VA = "0x2E10DCC")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2E102B4", Offset = "0x2E102B4", VA = "0x2E102B4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2E1AB04", Offset = "0x2E1AB04", VA = "0x2E1AB04", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2E1ACA8", Offset = "0x2E1ACA8", VA = "0x2E1ACA8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2E1AE18", Offset = "0x2E1AE18", VA = "0x2E1AE18", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2E1B020", Offset = "0x2E1B020", VA = "0x2E1B020", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2E1B0F8", Offset = "0x2E1B0F8", VA = "0x2E1B0F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2E1B1D8", Offset = "0x2E1B1D8", VA = "0x2E1B1D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2E1B348", Offset = "0x2E1B348", VA = "0x2E1B348", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x2E1B4A8", Offset = "0x2E1B4A8", VA = "0x2E1B4A8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2E1B6E8", Offset = "0x2E1B6E8", VA = "0x2E1B6E8", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2E1B9B4", Offset = "0x2E1B9B4", VA = "0x2E1B9B4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2E1B9F8", Offset = "0x2E1B9F8", VA = "0x2E1B9F8", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2E1BADC", Offset = "0x2E1BADC", VA = "0x2E1BADC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002DC")]
		Body,
		[Token(Token = "0x40002DD")]
		LeftShoulder,
		[Token(Token = "0x40002DE")]
		RightShoulder,
		[Token(Token = "0x40002DF")]
		LeftThigh,
		[Token(Token = "0x40002E0")]
		RightThigh,
		[Token(Token = "0x40002E1")]
		LeftHand,
		[Token(Token = "0x40002E2")]
		RightHand,
		[Token(Token = "0x40002E3")]
		LeftFoot,
		[Token(Token = "0x40002E4")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002E6")]
		LeftArm,
		[Token(Token = "0x40002E7")]
		RightArm,
		[Token(Token = "0x40002E8")]
		LeftLeg,
		[Token(Token = "0x40002E9")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005450", Offset = "0x1005450")]
		public float spineStiffness;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005468", Offset = "0x1005468")]
		public float pullBodyVertical;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005480", Offset = "0x1005480")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005498", Offset = "0x1005498")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2D8AB78", Offset = "0x2D8AB78", VA = "0x2D8AB78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2D8ACC0", Offset = "0x2D8ACC0", VA = "0x2D8ACC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x2D8ACC8", Offset = "0x2D8ACC8", VA = "0x2D8ACC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x2D8ACD0", Offset = "0x2D8ACD0", VA = "0x2D8ACD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x2D8ACD8", Offset = "0x2D8ACD8", VA = "0x2D8ACD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x2D8ACE0", Offset = "0x2D8ACE0", VA = "0x2D8ACE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x2D8ACE8", Offset = "0x2D8ACE8", VA = "0x2D8ACE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x2D8ACF0", Offset = "0x2D8ACF0", VA = "0x2D8ACF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x2D8ACF8", Offset = "0x2D8ACF8", VA = "0x2D8ACF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x2D8AD00", Offset = "0x2D8AD00", VA = "0x2D8AD00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x2D8AD38", Offset = "0x2D8AD38", VA = "0x2D8AD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x2D8AD70", Offset = "0x2D8AD70", VA = "0x2D8AD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x2D8ADA8", Offset = "0x2D8ADA8", VA = "0x2D8ADA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x2D8ADE0", Offset = "0x2D8ADE0", VA = "0x2D8ADE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x2D8AE14", Offset = "0x2D8AE14", VA = "0x2D8AE14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x2D8AE4C", Offset = "0x2D8AE4C", VA = "0x2D8AE4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x2D8AE84", Offset = "0x2D8AE84", VA = "0x2D8AE84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x2D8AEBC", Offset = "0x2D8AEBC", VA = "0x2D8AEBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x2D8CD88", Offset = "0x2D8CD88", VA = "0x2D8CD88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C624", Offset = "0x100C624")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x2D8CD94", Offset = "0x2D8CD94", VA = "0x2D8CD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C634", Offset = "0x100C634")]
			private set
			{
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2D8AEF0", Offset = "0x2D8AEF0", VA = "0x2D8AEF0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2D8AFFC", Offset = "0x2D8AFFC", VA = "0x2D8AFFC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2D8AF44", Offset = "0x2D8AF44", VA = "0x2D8AF44")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2D8B088", Offset = "0x2D8B088", VA = "0x2D8B088")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2D8AB80", Offset = "0x2D8AB80", VA = "0x2D8AB80")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2D8B158", Offset = "0x2D8B158", VA = "0x2D8B158")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2D8B210", Offset = "0x2D8B210", VA = "0x2D8B210")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2D8B2C4", Offset = "0x2D8B2C4", VA = "0x2D8B2C4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2D8B378", Offset = "0x2D8B378", VA = "0x2D8B378")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2D8B380", Offset = "0x2D8B380", VA = "0x2D8B380")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2D8B3B4", Offset = "0x2D8B3B4", VA = "0x2D8B3B4")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2D8B47C", Offset = "0x2D8B47C", VA = "0x2D8B47C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2D8B624", Offset = "0x2D8B624", VA = "0x2D8B624")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2D8C804", Offset = "0x2D8C804", VA = "0x2D8C804")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2D8CC18", Offset = "0x2D8CC18", VA = "0x2D8CC18")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2D8CC78", Offset = "0x2D8CC78", VA = "0x2D8CC78")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2D8CAA0", Offset = "0x2D8CAA0", VA = "0x2D8CAA0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2D8CB5C", Offset = "0x2D8CB5C", VA = "0x2D8CB5C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2D8CDA0", Offset = "0x2D8CDA0", VA = "0x2D8CDA0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2D8CE78", Offset = "0x2D8CE78", VA = "0x2D8CE78", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2D8CF78", Offset = "0x2D8CF78", VA = "0x2D8CF78")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2D8D0A0", Offset = "0x2D8D0A0", VA = "0x2D8D0A0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2D8D1E4", Offset = "0x2D8D1E4", VA = "0x2D8D1E4")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2D8D314", Offset = "0x2D8D314", VA = "0x2D8D314", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2D8D558", Offset = "0x2D8D558", VA = "0x2D8D558", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2D8D5E0", Offset = "0x2D8D5E0", VA = "0x2D8D5E0")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000054")]
		protected virtual int minBones
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2D8DE50", Offset = "0x2D8DE50", VA = "0x2D8DE50", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2D8DE58", Offset = "0x2D8DE58", VA = "0x2D8DE58", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x2D8DE60", Offset = "0x2D8DE60", VA = "0x2D8DE60", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x2D8E2E8", Offset = "0x2D8E2E8", VA = "0x2D8E2E8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x2D8E3B0", Offset = "0x2D8E3B0", VA = "0x2D8E3B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2D8D5F0", Offset = "0x2D8D5F0", VA = "0x2D8D5F0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2D8D78C", Offset = "0x2D8D78C", VA = "0x2D8D78C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2D8D8C4", Offset = "0x2D8D8C4", VA = "0x2D8D8C4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2D8D930", Offset = "0x2D8D930", VA = "0x2D8D930", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2D8D9B0", Offset = "0x2D8D9B0", VA = "0x2D8D9B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2D8DD58", Offset = "0x2D8DD58", VA = "0x2D8DD58", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2D8DD60", Offset = "0x2D8DD60", VA = "0x2D8DD60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2D8DE68", Offset = "0x2D8DE68", VA = "0x2D8DE68", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2D8DE6C", Offset = "0x2D8DE6C", VA = "0x2D8DE6C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2D8DE70", Offset = "0x2D8DE70", VA = "0x2D8DE70")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2D8E404", Offset = "0x2D8E404", VA = "0x2D8E404")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2D8E71C", Offset = "0x2D8E71C", VA = "0x2D8E71C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2D8E910", Offset = "0x2D8E910", VA = "0x2D8E910")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10054A8", Offset = "0x10054A8")]
		public float IKRotationWeight;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2D8E97C", Offset = "0x2D8E97C", VA = "0x2D8E97C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2D8ED1C", Offset = "0x2D8ED1C", VA = "0x2D8ED1C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2D8ED8C", Offset = "0x2D8ED8C", VA = "0x2D8ED8C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2D8EEE4", Offset = "0x2D8EEE4", VA = "0x2D8EEE4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2D8F078", Offset = "0x2D8F078", VA = "0x2D8F078", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2D8F0D4", Offset = "0x2D8F0D4", VA = "0x2D8F0D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2D8F144", Offset = "0x2D8F144", VA = "0x2D8F144", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2D8F4B4", Offset = "0x2D8F4B4", VA = "0x2D8F4B4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2D8F4E0", Offset = "0x2D8F4E0", VA = "0x2D8F4E0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2D8F1A8", Offset = "0x2D8F1A8", VA = "0x2D8F1A8")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2D8F574", Offset = "0x2D8F574", VA = "0x2D8F574")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2D8F700", Offset = "0x2D8F700", VA = "0x2D8F700")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200006E")]
		public enum BendModifier
		{
			[Token(Token = "0x4000314")]
			Animation,
			[Token(Token = "0x4000315")]
			Target,
			[Token(Token = "0x4000316")]
			Parent,
			[Token(Token = "0x4000317")]
			Arm,
			[Token(Token = "0x4000318")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200006F")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x2AEC7D4", Offset = "0x2AEC7D4", VA = "0x2AEC7D4")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10054C0", Offset = "0x10054C0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10054D8", Offset = "0x10054D8")]
		public float bendModifierWeight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000059")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x2D9097C", Offset = "0x2D9097C", VA = "0x2D9097C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2D8F858", Offset = "0x2D8F858", VA = "0x2D8F858")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2D8F8A8", Offset = "0x2D8F8A8", VA = "0x2D8F8A8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2D8F8F4", Offset = "0x2D8F8F4", VA = "0x2D8F8F4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2D8FDC8", Offset = "0x2D8FDC8", VA = "0x2D8FDC8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2D90710", Offset = "0x2D90710", VA = "0x2D90710", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2D907BC", Offset = "0x2D907BC", VA = "0x2D907BC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2D908F8", Offset = "0x2D908F8", VA = "0x2D908F8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2D8FBF0", Offset = "0x2D8FBF0", VA = "0x2D8FBF0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2D8FEAC", Offset = "0x2D8FEAC", VA = "0x2D8FEAC")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000071")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000060")]
			public Vector3 forward
			{
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0x2AECA60", Offset = "0x2AECA60", VA = "0x2AECA60")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2AEC834", Offset = "0x2AEC834", VA = "0x2AEC834")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x2AEC838", Offset = "0x2AEC838", VA = "0x2AEC838")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2AEC860", Offset = "0x2AEC860", VA = "0x2AEC860")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x2AEC958", Offset = "0x2AEC958", VA = "0x2AEC958")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10054F0", Offset = "0x10054F0")]
		public float bodyWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005508", Offset = "0x1005508")]
		public float headWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005520", Offset = "0x1005520")]
		public float eyesWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005538", Offset = "0x1005538")]
		public float clampWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005550", Offset = "0x1005550")]
		public float clampWeightHead;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005568", Offset = "0x1005568")]
		public float clampWeightEyes;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005580", Offset = "0x1005580")]
		public int clampSmoothing;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x1700005A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x2D9111C", Offset = "0x2D9111C", VA = "0x2D9111C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x2D912EC", Offset = "0x2D912EC", VA = "0x2D912EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x2D911FC", Offset = "0x2D911FC", VA = "0x2D911FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x2D91310", Offset = "0x2D91310", VA = "0x2D91310")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x2D9120C", Offset = "0x2D9120C", VA = "0x2D9120C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x2D91388", Offset = "0x2D91388", VA = "0x2D91388")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2D90998", Offset = "0x2D90998", VA = "0x2D90998")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2D909C8", Offset = "0x2D909C8", VA = "0x2D909C8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2D90A20", Offset = "0x2D90A20", VA = "0x2D90A20")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2D90A9C", Offset = "0x2D90A9C", VA = "0x2D90A9C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2D90B34", Offset = "0x2D90B34", VA = "0x2D90B34")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2D90BF4", Offset = "0x2D90BF4", VA = "0x2D90BF4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2D90CF0", Offset = "0x2D90CF0", VA = "0x2D90CF0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2D90E1C", Offset = "0x2D90E1C", VA = "0x2D90E1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2D90F5C", Offset = "0x2D90F5C", VA = "0x2D90F5C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2D913AC", Offset = "0x2D913AC", VA = "0x2D913AC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2D915EC", Offset = "0x2D915EC", VA = "0x2D915EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2D91788", Offset = "0x2D91788", VA = "0x2D91788")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2D919B8", Offset = "0x2D919B8", VA = "0x2D919B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2D91C8C", Offset = "0x2D91C8C", VA = "0x2D91C8C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2D91D5C", Offset = "0x2D91D5C", VA = "0x2D91D5C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2D91EFC", Offset = "0x2D91EFC", VA = "0x2D91EFC")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2D92120", Offset = "0x2D92120", VA = "0x2D92120")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2D924D4", Offset = "0x2D924D4", VA = "0x2D924D4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2D91834", Offset = "0x2D91834", VA = "0x2D91834")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2D92744", Offset = "0x2D92744", VA = "0x2D92744")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000073")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x2AECA9C", Offset = "0x2AECA9C", VA = "0x2AECA9C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x2AECB98", Offset = "0x2AECB98", VA = "0x2AECB98")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x2AECBC8", Offset = "0x2AECBC8", VA = "0x2AECBC8")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x2AECC04", Offset = "0x2AECC04", VA = "0x2AECC04")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005598", Offset = "0x1005598")]
		public float IKRotationWeight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2D92950", Offset = "0x2D92950", VA = "0x2D92950")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2D92AAC", Offset = "0x2D92AAC", VA = "0x2D92AAC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2D92BF0", Offset = "0x2D92BF0", VA = "0x2D92BF0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2D92BFC", Offset = "0x2D92BFC", VA = "0x2D92BFC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2D92C2C", Offset = "0x2D92C2C", VA = "0x2D92C2C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2D92C38", Offset = "0x2D92C38", VA = "0x2D92C38")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2D92C40", Offset = "0x2D92C40", VA = "0x2D92C40", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2D92D40", Offset = "0x2D92D40", VA = "0x2D92D40", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2D92E5C", Offset = "0x2D92E5C", VA = "0x2D92E5C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2D92EA8", Offset = "0x2D92EA8", VA = "0x2D92EA8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2D92F08", Offset = "0x2D92F08", VA = "0x2D92F08", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2D932D0", Offset = "0x2D932D0", VA = "0x2D932D0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2D93328", Offset = "0x2D93328", VA = "0x2D93328")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2D936E4", Offset = "0x2D936E4", VA = "0x2D936E4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2D9384C", Offset = "0x2D9384C", VA = "0x2D9384C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2D939B4", Offset = "0x2D939B4", VA = "0x2D939B4")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2D93928", Offset = "0x2D93928", VA = "0x2D93928")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2D93AB8", Offset = "0x2D93AB8", VA = "0x2D93AB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2D9428C", Offset = "0x2D9428C", VA = "0x2D9428C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2D94290", Offset = "0x2D94290", VA = "0x2D94290", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2D94294", Offset = "0x2D94294", VA = "0x2D94294", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2D940A4", Offset = "0x2D940A4", VA = "0x2D940A4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2D9082C", Offset = "0x2D9082C", VA = "0x2D9082C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000076")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400037A")]
				YawPitch,
				[Token(Token = "0x400037B")]
				FromTo
			}

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100579C", Offset = "0x100579C")]
			public Transform target;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10057D4", Offset = "0x10057D4")]
			public Transform bendGoal;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100580C", Offset = "0x100580C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100580C", Offset = "0x100580C")]
			public float positionWeight;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005860", Offset = "0x1005860")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005860", Offset = "0x1005860")]
			public float rotationWeight;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10058B4", Offset = "0x10058B4")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10058EC", Offset = "0x10058EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10058EC", Offset = "0x10058EC")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005940", Offset = "0x1005940")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005940", Offset = "0x1005940")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005994", Offset = "0x1005994")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005994", Offset = "0x1005994")]
			public float bendGoalWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10059E8", Offset = "0x10059E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10059E8", Offset = "0x10059E8")]
			public float swivelOffset;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005A44", Offset = "0x1005A44")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005A7C", Offset = "0x1005A7C")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005AB4", Offset = "0x1005AB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005AB4", Offset = "0x1005AB4")]
			public float armLengthMlp;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005B0C", Offset = "0x1005B0C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005B84", Offset = "0x1005B84")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005B94", Offset = "0x1005B94")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000377")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000378")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000062")]
			public Vector3 position
			{
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x2AECC08", Offset = "0x2AECC08", VA = "0x2AECC08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C664", Offset = "0x100C664")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x2AECC14", Offset = "0x2AECC14", VA = "0x2AECC14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C674", Offset = "0x100C674")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x2AECC20", Offset = "0x2AECC20", VA = "0x2AECC20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C684", Offset = "0x100C684")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x2AECC2C", Offset = "0x2AECC2C", VA = "0x2AECC2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C694", Offset = "0x100C694")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x2AECC38", Offset = "0x2AECC38", VA = "0x2AECC38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x2AECC6C", Offset = "0x2AECC6C", VA = "0x2AECC6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x2AECCAC", Offset = "0x2AECCAC", VA = "0x2AECCAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x2AECCF8", Offset = "0x2AECCF8", VA = "0x2AECCF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x2AECD44", Offset = "0x2AECD44", VA = "0x2AECD44", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x2AED56C", Offset = "0x2AED56C", VA = "0x2AED56C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x2AED724", Offset = "0x2AED724", VA = "0x2AED724", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x2AED748", Offset = "0x2AED748", VA = "0x2AED748")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x2AED9E8", Offset = "0x2AED9E8", VA = "0x2AED9E8")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x2AEEE04", Offset = "0x2AEEE04", VA = "0x2AEEE04", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x2AEEE30", Offset = "0x2AEEE30", VA = "0x2AEEE30", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x2AEE984", Offset = "0x2AEE984", VA = "0x2AEE984")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x2AEEA00", Offset = "0x2AEEA00", VA = "0x2AEEA00")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x2AEF050", Offset = "0x2AEF050", VA = "0x2AEF050")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x2AEF174", Offset = "0x2AEF174", VA = "0x2AEF174")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000077")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005BA4", Offset = "0x1005BA4")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005BB4", Offset = "0x1005BB4")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000068")]
			public float sqrMag
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x2DE0650", Offset = "0x2DE0650", VA = "0x2DE0650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C6A4", Offset = "0x100C6A4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x2DE0658", Offset = "0x2DE0658", VA = "0x2DE0658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C6B4", Offset = "0x100C6B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x2DE0660", Offset = "0x2DE0660", VA = "0x2DE0660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C6C4", Offset = "0x100C6C4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000432")]
				[Address(RVA = "0x2DE0668", Offset = "0x2DE0668", VA = "0x2DE0668")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C6D4", Offset = "0x100C6D4")]
				private set
				{
				}
			}

			[Token(Token = "0x600042A")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600042B")]
			public abstract void PreSolve();

			[Token(Token = "0x600042C")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600042D")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600042E")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x2DE0670", Offset = "0x2DE0670", VA = "0x2DE0670")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x2DE0678", Offset = "0x2DE0678", VA = "0x2DE0678")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x2DE0938", Offset = "0x2DE0938", VA = "0x2DE0938")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x2DE09CC", Offset = "0x2DE09CC", VA = "0x2DE09CC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x2DE0B9C", Offset = "0x2DE0B9C", VA = "0x2DE0B9C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2DE0BF0", Offset = "0x2DE0BF0", VA = "0x2DE0BF0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2DE0D28", Offset = "0x2DE0D28", VA = "0x2DE0D28")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x2DE0E68", Offset = "0x2DE0E68", VA = "0x2DE0E68")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x2DE0FA8", Offset = "0x2DE0FA8", VA = "0x2DE0FA8")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x2DE0FD0", Offset = "0x2DE0FD0", VA = "0x2DE0FD0")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public class Footstep
		{
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005BD4", Offset = "0x1005BD4")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006A")]
			public bool isStepping
			{
				[Token(Token = "0x600043D")]
				[Address(RVA = "0x2DE1044", Offset = "0x2DE1044", VA = "0x2DE1044")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x2DE1058", Offset = "0x2DE1058", VA = "0x2DE1058")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C6E4", Offset = "0x100C6E4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x2DE1060", Offset = "0x2DE1060", VA = "0x2DE1060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C6F4", Offset = "0x100C6F4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x2DE1068", Offset = "0x2DE1068", VA = "0x2DE1068")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x2DE11A0", Offset = "0x2DE11A0", VA = "0x2DE11A0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2DE11E8", Offset = "0x2DE11E8", VA = "0x2DE11E8")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2DE13AC", Offset = "0x2DE13AC", VA = "0x2DE13AC")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x2DE1520", Offset = "0x2DE1520", VA = "0x2DE1520")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x2DE1678", Offset = "0x2DE1678", VA = "0x2DE1678")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005BE4", Offset = "0x1005BE4")]
			public Transform target;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005C1C", Offset = "0x1005C1C")]
			public Transform bendGoal;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005C54", Offset = "0x1005C54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005C54", Offset = "0x1005C54")]
			public float positionWeight;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005CA8", Offset = "0x1005CA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005CA8", Offset = "0x1005CA8")]
			public float rotationWeight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005CFC", Offset = "0x1005CFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005CFC", Offset = "0x1005CFC")]
			public float bendGoalWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005D50", Offset = "0x1005D50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005D50", Offset = "0x1005D50")]
			public float swivelOffset;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005DAC", Offset = "0x1005DAC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005DAC", Offset = "0x1005DAC")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005E00", Offset = "0x1005E00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005E00", Offset = "0x1005E00")]
			public float legLengthMlp;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005E58", Offset = "0x1005E58")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005F00", Offset = "0x1005F00")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005F10", Offset = "0x1005F10")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005F20", Offset = "0x1005F20")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1005F30", Offset = "0x1005F30")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x2DE17B4", Offset = "0x2DE17B4", VA = "0x2DE17B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C704", Offset = "0x100C704")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x2DE17C0", Offset = "0x2DE17C0", VA = "0x2DE17C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C714", Offset = "0x100C714")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x2DE17CC", Offset = "0x2DE17CC", VA = "0x2DE17CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C724", Offset = "0x100C724")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x2DE17D8", Offset = "0x2DE17D8", VA = "0x2DE17D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C734", Offset = "0x100C734")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x2DE17E4", Offset = "0x2DE17E4", VA = "0x2DE17E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C744", Offset = "0x100C744")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x2DE17EC", Offset = "0x2DE17EC", VA = "0x2DE17EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C754", Offset = "0x100C754")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x2DE17F8", Offset = "0x2DE17F8", VA = "0x2DE17F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x2DE182C", Offset = "0x2DE182C", VA = "0x2DE182C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x2DE1864", Offset = "0x2DE1864", VA = "0x2DE1864")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x2DE189C", Offset = "0x2DE189C", VA = "0x2DE189C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x2DE18D4", Offset = "0x2DE18D4", VA = "0x2DE18D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x2DE1914", Offset = "0x2DE1914", VA = "0x2DE1914")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C764", Offset = "0x100C764")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x2DE1920", Offset = "0x2DE1920", VA = "0x2DE1920")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C774", Offset = "0x100C774")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x2DE192C", Offset = "0x2DE192C", VA = "0x2DE192C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2DE1FA4", Offset = "0x2DE1FA4", VA = "0x2DE1FA4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2DE2560", Offset = "0x2DE2560", VA = "0x2DE2560", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x2DE2510", Offset = "0x2DE2510", VA = "0x2DE2510")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2DE23A0", Offset = "0x2DE23A0", VA = "0x2DE23A0")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x2DE2948", Offset = "0x2DE2948", VA = "0x2DE2948")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2DE31F4", Offset = "0x2DE31F4", VA = "0x2DE31F4")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2DE2AD0", Offset = "0x2DE2AD0", VA = "0x2DE2AD0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x2DE34EC", Offset = "0x2DE34EC", VA = "0x2DE34EC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x2DE3708", Offset = "0x2DE3708", VA = "0x2DE3708", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x2DE3754", Offset = "0x2DE3754", VA = "0x2DE3754")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Locomotion
		{
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1005F40", Offset = "0x1005F40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005F40", Offset = "0x1005F40")]
			public float weight;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005F94", Offset = "0x1005F94")]
			public float footDistance;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005FCC", Offset = "0x1005FCC")]
			public float stepThreshold;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006004", Offset = "0x1006004")]
			public float angleThreshold;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100603C", Offset = "0x100603C")]
			public float comAngleMlp;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006074", Offset = "0x1006074")]
			public float maxVelocity;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10060AC", Offset = "0x10060AC")]
			public float velocityFactor;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10060E4", Offset = "0x10060E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10060E4", Offset = "0x10060E4")]
			public float maxLegStretch;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100613C", Offset = "0x100613C")]
			public float rootSpeed;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006174", Offset = "0x1006174")]
			public float stepSpeed;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10061AC", Offset = "0x10061AC")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10061E4", Offset = "0x10061E4")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100621C", Offset = "0x100621C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100621C", Offset = "0x100621C")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006274", Offset = "0x1006274")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10062AC", Offset = "0x10062AC")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10062E4", Offset = "0x10062E4")]
			public Vector3 offset;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100635C", Offset = "0x100635C")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006394", Offset = "0x1006394")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10063CC", Offset = "0x10063CC")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000075")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x2DE3824", Offset = "0x2DE3824", VA = "0x2DE3824")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C784", Offset = "0x100C784")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x2DE3830", Offset = "0x2DE3830", VA = "0x2DE3830")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C794", Offset = "0x100C794")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x2DE531C", Offset = "0x2DE531C", VA = "0x2DE531C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x2DE535C", Offset = "0x2DE535C", VA = "0x2DE535C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x2DE53A0", Offset = "0x2DE53A0", VA = "0x2DE53A0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x2DE53E0", Offset = "0x2DE53E0", VA = "0x2DE53E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2DE383C", Offset = "0x2DE383C", VA = "0x2DE383C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2DE3ADC", Offset = "0x2DE3ADC", VA = "0x2DE3ADC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2DE3CAC", Offset = "0x2DE3CAC", VA = "0x2DE3CAC")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x2DE3EF4", Offset = "0x2DE3EF4", VA = "0x2DE3EF4")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2DE3FB8", Offset = "0x2DE3FB8", VA = "0x2DE3FB8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2DE5094", Offset = "0x2DE5094", VA = "0x2DE5094")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2DE51CC", Offset = "0x2DE51CC", VA = "0x2DE51CC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x2DE5250", Offset = "0x2DE5250", VA = "0x2DE5250")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2DE5424", Offset = "0x2DE5424", VA = "0x2DE5424")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10063DC", Offset = "0x10063DC")]
			public Transform headTarget;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006414", Offset = "0x1006414")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100644C", Offset = "0x100644C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100644C", Offset = "0x100644C")]
			public float positionWeight;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10064A0", Offset = "0x10064A0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10064A0", Offset = "0x10064A0")]
			public float rotationWeight;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10064F4", Offset = "0x10064F4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10064F4", Offset = "0x10064F4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006548", Offset = "0x1006548")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006548", Offset = "0x1006548")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100659C", Offset = "0x100659C")]
			public Transform chestGoal;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10065D4", Offset = "0x10065D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10065D4", Offset = "0x10065D4")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006628", Offset = "0x1006628")]
			public float minHeadHeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006660", Offset = "0x1006660")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006660", Offset = "0x1006660")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10066B4", Offset = "0x10066B4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10066B4", Offset = "0x10066B4")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006708", Offset = "0x1006708")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1006708", Offset = "0x1006708")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006708", Offset = "0x1006708")]
			public float neckStiffness;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006780", Offset = "0x1006780")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006780", Offset = "0x1006780")]
			public float rotateChestByHands;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10067D4", Offset = "0x10067D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10067D4", Offset = "0x10067D4")]
			public float chestClampWeight;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006828", Offset = "0x1006828")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006828", Offset = "0x1006828")]
			public float headClampWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100687C", Offset = "0x100687C")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10068B4", Offset = "0x10068B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10068B4", Offset = "0x10068B4")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006908", Offset = "0x1006908")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006908", Offset = "0x1006908")]
			public float maxRootAngle;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006960", Offset = "0x1006960")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006960", Offset = "0x1006960")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1006A9C", Offset = "0x1006A9C")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1006AAC", Offset = "0x1006AAC")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007A")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x2DE5014", Offset = "0x2DE5014", VA = "0x2DE5014")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x2DE5510", Offset = "0x2DE5510", VA = "0x2DE5510")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x2DE5550", Offset = "0x2DE5550", VA = "0x2DE5550")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x2DE55A4", Offset = "0x2DE55A4", VA = "0x2DE55A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x2DE5054", Offset = "0x2DE5054", VA = "0x2DE5054")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x2DE55E4", Offset = "0x2DE55E4", VA = "0x2DE55E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C7A4", Offset = "0x100C7A4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x2DE55F8", Offset = "0x2DE55F8", VA = "0x2DE55F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C7B4", Offset = "0x100C7B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x2DE560C", Offset = "0x2DE560C", VA = "0x2DE560C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C7C4", Offset = "0x100C7C4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x2DE5620", Offset = "0x2DE5620", VA = "0x2DE5620")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C7D4", Offset = "0x100C7D4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x2DE5634", Offset = "0x2DE5634", VA = "0x2DE5634", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x2DE6040", Offset = "0x2DE6040", VA = "0x2DE6040", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x2DE624C", Offset = "0x2DE624C", VA = "0x2DE624C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x2DE6690", Offset = "0x2DE6690", VA = "0x2DE6690")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x2DE6ACC", Offset = "0x2DE6ACC", VA = "0x2DE6ACC")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x2DE7220", Offset = "0x2DE7220", VA = "0x2DE7220")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x2DE78A0", Offset = "0x2DE78A0", VA = "0x2DE78A0")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x2DE7EA0", Offset = "0x2DE7EA0", VA = "0x2DE7EA0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x2DE807C", Offset = "0x2DE807C", VA = "0x2DE807C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2DE6828", Offset = "0x2DE6828", VA = "0x2DE6828")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2DE75F0", Offset = "0x2DE75F0", VA = "0x2DE75F0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x2DE6EDC", Offset = "0x2DE6EDC", VA = "0x2DE6EDC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2DE8114", Offset = "0x2DE8114", VA = "0x2DE8114")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x2DE76CC", Offset = "0x2DE76CC", VA = "0x2DE76CC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x2DE739C", Offset = "0x2DE739C", VA = "0x2DE739C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x2DE8308", Offset = "0x2DE8308", VA = "0x2DE8308")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000401")]
			Pelvis,
			[Token(Token = "0x4000402")]
			Chest,
			[Token(Token = "0x4000403")]
			Head,
			[Token(Token = "0x4000404")]
			LeftHand,
			[Token(Token = "0x4000405")]
			RightHand,
			[Token(Token = "0x4000406")]
			LeftFoot,
			[Token(Token = "0x4000407")]
			RightFoot,
			[Token(Token = "0x4000408")]
			LeftHeel,
			[Token(Token = "0x4000409")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public enum RotationOffset
		{
			[Token(Token = "0x400040B")]
			Pelvis,
			[Token(Token = "0x400040C")]
			Chest,
			[Token(Token = "0x400040D")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class VirtualBone
		{
			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x2DE1F08", Offset = "0x2DE1F08", VA = "0x2DE1F08")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x2DE1F84", Offset = "0x2DE1F84", VA = "0x2DE1F84")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x2DE8478", Offset = "0x2DE8478", VA = "0x2DE8478")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x2DE0748", Offset = "0x2DE0748", VA = "0x2DE0748")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x2DE0A74", Offset = "0x2DE0A74", VA = "0x2DE0A74")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x2DE85FC", Offset = "0x2DE85FC", VA = "0x2DE85FC")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2DE875C", Offset = "0x2DE875C", VA = "0x2DE875C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x2DE8898", Offset = "0x2DE8898", VA = "0x2DE8898")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2DE2DF0", Offset = "0x2DE2DF0", VA = "0x2DE2DF0")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2DE8950", Offset = "0x2DE8950", VA = "0x2DE8950")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2DE7B10", Offset = "0x2DE7B10", VA = "0x2DE7B10")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2DE8AB8", Offset = "0x2DE8AB8", VA = "0x2DE8AB8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2DE8B28", Offset = "0x2DE8B28", VA = "0x2DE8B28")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10055B0", Offset = "0x10055B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10055B0", Offset = "0x10055B0")]
		public int LOD;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005604", Offset = "0x1005604")]
		public bool plantFeet;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100563C", Offset = "0x100563C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100564C", Offset = "0x100564C")]
		public Spine spine;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005684", Offset = "0x1005684")]
		public Arm leftArm;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10056BC", Offset = "0x10056BC")]
		public Arm rightArm;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10056F4", Offset = "0x10056F4")]
		public Leg leftLeg;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100572C", Offset = "0x100572C")]
		public Leg rightLeg;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1005764", Offset = "0x1005764")]
		public Locomotion locomotion;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000061")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x2D97E00", Offset = "0x2D97E00", VA = "0x2D97E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C644", Offset = "0x100C644")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x2D97E08", Offset = "0x2D97E08", VA = "0x2D97E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C654", Offset = "0x100C654")]
			private set
			{
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2D94298", Offset = "0x2D94298", VA = "0x2D94298")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2D946FC", Offset = "0x2D946FC", VA = "0x2D946FC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2D945A8", Offset = "0x2D945A8", VA = "0x2D945A8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2D94E5C", Offset = "0x2D94E5C", VA = "0x2D94E5C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2D94FA0", Offset = "0x2D94FA0", VA = "0x2D94FA0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2D94FD0", Offset = "0x2D94FD0", VA = "0x2D94FD0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2D95080", Offset = "0x2D95080", VA = "0x2D95080")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2D95168", Offset = "0x2D95168", VA = "0x2D95168")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2D958CC", Offset = "0x2D958CC", VA = "0x2D958CC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2D95A3C", Offset = "0x2D95A3C", VA = "0x2D95A3C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2D95C40", Offset = "0x2D95C40", VA = "0x2D95C40", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2D95CBC", Offset = "0x2D95CBC", VA = "0x2D95CBC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2D95D38", Offset = "0x2D95D38", VA = "0x2D95D38", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2D95F10", Offset = "0x2D95F10", VA = "0x2D95F10")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2D94930", Offset = "0x2D94930", VA = "0x2D94930")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2D94A20", Offset = "0x2D94A20", VA = "0x2D94A20")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2D94D3C", Offset = "0x2D94D3C", VA = "0x2D94D3C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2D9525C", Offset = "0x2D9525C", VA = "0x2D9525C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2D960D0", Offset = "0x2D960D0", VA = "0x2D960D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2D96118", Offset = "0x2D96118", VA = "0x2D96118", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2D97530", Offset = "0x2D97530", VA = "0x2D97530")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2D953C0", Offset = "0x2D953C0", VA = "0x2D953C0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2D9648C", Offset = "0x2D9648C", VA = "0x2D9648C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2D978E0", Offset = "0x2D978E0", VA = "0x2D978E0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2D97928", Offset = "0x2D97928", VA = "0x2D97928")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2D973E0", Offset = "0x2D973E0", VA = "0x2D973E0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2D9796C", Offset = "0x2D9796C", VA = "0x2D9796C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2D97E10", Offset = "0x2D97E10", VA = "0x2D97E10")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006ABC", Offset = "0x1006ABC")]
		public Transform parent;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006AF4", Offset = "0x1006AF4")]
		public Transform child;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006B2C", Offset = "0x1006B2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006B2C", Offset = "0x1006B2C")]
		public float weight;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006B80", Offset = "0x1006B80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006B80", Offset = "0x1006B80")]
		public float parentChildCrossfade;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006BD4", Offset = "0x1006BD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1006BD4", Offset = "0x1006BD4")]
		public float twistAngleOffset;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2AE0BD4", Offset = "0x2AE0BD4", VA = "0x2AE0BD4")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2AE0EF0", Offset = "0x2AE0EF0", VA = "0x2AE0EF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2AE12AC", Offset = "0x2AE12AC", VA = "0x2AE12AC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2AE1330", Offset = "0x2AE1330", VA = "0x2AE1330")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2AE13B4", Offset = "0x2AE13B4", VA = "0x2AE13B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2AE14C0", Offset = "0x2AE14C0", VA = "0x2AE14C0")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class InteractionEffector
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1006C30", Offset = "0x1006C30")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1006C40", Offset = "0x1006C40")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1006C50", Offset = "0x1006C50")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x2D98BCC", Offset = "0x2D98BCC", VA = "0x2D98BCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C7E4", Offset = "0x100C7E4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x2D98BD4", Offset = "0x2D98BD4", VA = "0x2D98BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C7F4", Offset = "0x100C7F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x2D98BDC", Offset = "0x2D98BDC", VA = "0x2D98BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C804", Offset = "0x100C804")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x2D98BE4", Offset = "0x2D98BE4", VA = "0x2D98BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C814", Offset = "0x100C814")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x2D98BF0", Offset = "0x2D98BF0", VA = "0x2D98BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C824", Offset = "0x100C824")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x2D98BF8", Offset = "0x2D98BF8", VA = "0x2D98BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100C834", Offset = "0x100C834")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x2D98C00", Offset = "0x2D98C00", VA = "0x2D98C00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x2D9A378", Offset = "0x2D9A378", VA = "0x2D9A378")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2D98C6C", Offset = "0x2D98C6C", VA = "0x2D98C6C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2D98CF8", Offset = "0x2D98CF8", VA = "0x2D98CF8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2D98D94", Offset = "0x2D98D94", VA = "0x2D98D94")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2D98EF0", Offset = "0x2D98EF0", VA = "0x2D98EF0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2D9922C", Offset = "0x2D9922C", VA = "0x2D9922C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2D992E8", Offset = "0x2D992E8", VA = "0x2D992E8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2D99340", Offset = "0x2D99340", VA = "0x2D99340")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2D99780", Offset = "0x2D99780", VA = "0x2D99780")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2D99D9C", Offset = "0x2D99D9C", VA = "0x2D99D9C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2D99FE0", Offset = "0x2D99FE0", VA = "0x2D99FE0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2D9A220", Offset = "0x2D9A220", VA = "0x2D9A220")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2D9A3B4", Offset = "0x2D9A3B4", VA = "0x2D9A3B4")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006C60", Offset = "0x1006C60")]
		public LookAtIK ik;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006C98", Offset = "0x1006C98")]
		public float lerpSpeed;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006CD0", Offset = "0x1006CD0")]
		public float weightSpeed;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2D9A5AC", Offset = "0x2D9A5AC", VA = "0x2D9A5AC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2D9A6C8", Offset = "0x2D9A6C8", VA = "0x2D9A6C8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2D9A76C", Offset = "0x2D9A76C", VA = "0x2D9A76C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2D9A964", Offset = "0x2D9A964", VA = "0x2D9A964")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2D9AA58", Offset = "0x2D9AA58", VA = "0x2D9AA58")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2D9AB20", Offset = "0x2D9AB20", VA = "0x2D9AB20")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x100276C", Offset = "0x100276C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x100276C", Offset = "0x100276C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006DE0", Offset = "0x1006DE0")]
			public float time;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006E18", Offset = "0x1006E18")]
			public bool pause;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006E50", Offset = "0x1006E50")]
			public bool pickUp;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006E88", Offset = "0x1006E88")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006EC0", Offset = "0x1006EC0")]
			public Message[] messages;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006EF8", Offset = "0x1006EF8")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x2DE92D4", Offset = "0x2DE92D4", VA = "0x2DE92D4")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x2DE94A8", Offset = "0x2DE94A8", VA = "0x2DE94A8")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public class Message
		{
			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006F30", Offset = "0x1006F30")]
			public string function;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006F68", Offset = "0x1006F68")]
			public GameObject recipient;

			[Token(Token = "0x400045C")]
			private const string empty = "";

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x2DE93A4", Offset = "0x2DE93A4", VA = "0x2DE93A4")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x2DE94B0", Offset = "0x2DE94B0", VA = "0x2DE94B0")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006FA0", Offset = "0x1006FA0")]
			public Animator animator;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006FD8", Offset = "0x1006FD8")]
			public Animation animation;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007010", Offset = "0x1007010")]
			public string animationState;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007048", Offset = "0x1007048")]
			public float crossfadeTime;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007080", Offset = "0x1007080")]
			public int layer;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10070B8", Offset = "0x10070B8")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000463")]
			private const string empty = "";

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x2DE9040", Offset = "0x2DE9040", VA = "0x2DE9040")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x2DE9130", Offset = "0x2DE9130", VA = "0x2DE9130")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x2DE91E4", Offset = "0x2DE91E4", VA = "0x2DE91E4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x2DE92C0", Offset = "0x2DE92C0", VA = "0x2DE92C0")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000087")]
			public enum Type
			{
				[Token(Token = "0x4000467")]
				PositionWeight,
				[Token(Token = "0x4000468")]
				RotationWeight,
				[Token(Token = "0x4000469")]
				PositionOffsetX,
				[Token(Token = "0x400046A")]
				PositionOffsetY,
				[Token(Token = "0x400046B")]
				PositionOffsetZ,
				[Token(Token = "0x400046C")]
				Pull,
				[Token(Token = "0x400046D")]
				Reach,
				[Token(Token = "0x400046E")]
				RotateBoneWeight,
				[Token(Token = "0x400046F")]
				Push,
				[Token(Token = "0x4000470")]
				PushParent,
				[Token(Token = "0x4000471")]
				PoserWeight,
				[Token(Token = "0x4000472")]
				BendGoalWeight
			}

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10070F0", Offset = "0x10070F0")]
			public Type type;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007128", Offset = "0x1007128")]
			public AnimationCurve curve;

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x2DE94F4", Offset = "0x2DE94F4", VA = "0x2DE94F4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x2DE9520", Offset = "0x2DE9520", VA = "0x2DE9520")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public class Multiplier
		{
			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007160", Offset = "0x1007160")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007198", Offset = "0x1007198")]
			public float multiplier;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10071D0", Offset = "0x10071D0")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x2DE94B8", Offset = "0x2DE94B8", VA = "0x2DE94B8")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x2DE9510", Offset = "0x2DE9510", VA = "0x2DE9510")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006D18", Offset = "0x1006D18")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006D50", Offset = "0x1006D50")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1006D88", Offset = "0x1006D88")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1006DC0", Offset = "0x1006DC0")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1006DD0", Offset = "0x1006DD0")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x2C37B48", Offset = "0x2C37B48", VA = "0x2C37B48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CA04", Offset = "0x100CA04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x2C37B50", Offset = "0x2C37B50", VA = "0x2C37B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CA14", Offset = "0x100CA14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x2C37B58", Offset = "0x2C37B58", VA = "0x2C37B58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CA24", Offset = "0x100CA24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x2C37B60", Offset = "0x2C37B60", VA = "0x2C37B60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CA34", Offset = "0x100CA34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x2C37DB4", Offset = "0x2C37DB4", VA = "0x2C37DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x2C37D28", Offset = "0x2C37D28", VA = "0x2C37D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2C37908", Offset = "0x2C37908", VA = "0x2C37908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C844", Offset = "0x100C844")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2C37950", Offset = "0x2C37950", VA = "0x2C37950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C87C", Offset = "0x100C87C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2C37998", Offset = "0x2C37998", VA = "0x2C37998")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C8B4", Offset = "0x100C8B4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2C379E0", Offset = "0x2C379E0", VA = "0x2C379E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C8EC", Offset = "0x100C8EC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2C37A28", Offset = "0x2C37A28", VA = "0x2C37A28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C924", Offset = "0x100C924")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2C37A70", Offset = "0x2C37A70", VA = "0x2C37A70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C95C", Offset = "0x100C95C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2C37AB8", Offset = "0x2C37AB8", VA = "0x2C37AB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C994", Offset = "0x100C994")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2C37B00", Offset = "0x2C37B00", VA = "0x2C37B00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100C9CC", Offset = "0x100C9CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2C37B68", Offset = "0x2C37B68", VA = "0x2C37B68")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2C37E40", Offset = "0x2C37E40", VA = "0x2C37E40")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2C37FCC", Offset = "0x2C37FCC", VA = "0x2C37FCC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2C38080", Offset = "0x2C38080", VA = "0x2C38080")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2C38088", Offset = "0x2C38088", VA = "0x2C38088")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2C38244", Offset = "0x2C38244", VA = "0x2C38244")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2C3824C", Offset = "0x2C3824C", VA = "0x2C3824C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2C38C14", Offset = "0x2C38C14", VA = "0x2C38C14")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2C38E34", Offset = "0x2C38E34", VA = "0x2C38E34")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2C38718", Offset = "0x2C38718", VA = "0x2C38718")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2C381D4", Offset = "0x2C381D4", VA = "0x2C381D4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2C38BAC", Offset = "0x2C38BAC", VA = "0x2C38BAC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2C38E38", Offset = "0x2C38E38", VA = "0x2C38E38")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2C38EA0", Offset = "0x2C38EA0", VA = "0x2C38EA0")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10027CC", Offset = "0x10027CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10027CC", Offset = "0x10027CC")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008B")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007208", Offset = "0x1007208")]
		public string targetTag;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007240", Offset = "0x1007240")]
		public float fadeInTime;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007278", Offset = "0x1007278")]
		public float speed;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10072B0", Offset = "0x10072B0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x10072E8", Offset = "0x10072E8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10072E8", Offset = "0x10072E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10072E8", Offset = "0x10072E8")]
		public Collider characterCollider;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x100736C", Offset = "0x100736C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100736C", Offset = "0x100736C")]
		public Transform FPSCamera;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10073CC", Offset = "0x10073CC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007404", Offset = "0x1007404")]
		public float camRaycastDistance;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100743C", Offset = "0x100743C")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100744C", Offset = "0x100744C")]
		[SerializeField]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x100744C", Offset = "0x100744C")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10074AC", Offset = "0x10074AC")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x2C3913C", Offset = "0x2C3913C", VA = "0x2C3913C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x2C3ADE0", Offset = "0x2C3ADE0", VA = "0x2C3ADE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x2C3ADE8", Offset = "0x2C3ADE8", VA = "0x2C3ADE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2C3ADF0", Offset = "0x2C3ADF0", VA = "0x2C3ADF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CC04", Offset = "0x100CC04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x2C3ADF8", Offset = "0x2C3ADF8", VA = "0x2C3ADF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CC14", Offset = "0x100CC14")]
			private set
			{
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2C38EFC", Offset = "0x2C38EFC", VA = "0x2C38EFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CA44", Offset = "0x100CA44")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2C38F44", Offset = "0x2C38F44", VA = "0x2C38F44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CA7C", Offset = "0x100CA7C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2C38F8C", Offset = "0x2C38F8C", VA = "0x2C38F8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CAB4", Offset = "0x100CAB4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2C38FD4", Offset = "0x2C38FD4", VA = "0x2C38FD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CAEC", Offset = "0x100CAEC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2C3901C", Offset = "0x2C3901C", VA = "0x2C3901C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CB24", Offset = "0x100CB24")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2C39064", Offset = "0x2C39064", VA = "0x2C39064")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CB5C", Offset = "0x100CB5C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2C390AC", Offset = "0x2C390AC", VA = "0x2C390AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CB94", Offset = "0x100CB94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2C390F4", Offset = "0x2C390F4", VA = "0x2C390F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CBCC", Offset = "0x100CBCC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2C392E4", Offset = "0x2C392E4", VA = "0x2C392E4")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2C393B4", Offset = "0x2C393B4", VA = "0x2C393B4")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2C39484", Offset = "0x2C39484", VA = "0x2C39484")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2C39534", Offset = "0x2C39534", VA = "0x2C39534")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2C39630", Offset = "0x2C39630", VA = "0x2C39630")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2C3974C", Offset = "0x2C3974C", VA = "0x2C3974C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2C397E0", Offset = "0x2C397E0", VA = "0x2C397E0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2C39874", Offset = "0x2C39874", VA = "0x2C39874")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2C39908", Offset = "0x2C39908", VA = "0x2C39908")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2C39980", Offset = "0x2C39980", VA = "0x2C39980")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2C399F8", Offset = "0x2C399F8", VA = "0x2C399F8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2C39A64", Offset = "0x2C39A64", VA = "0x2C39A64")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2C39AF0", Offset = "0x2C39AF0", VA = "0x2C39AF0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2C39B84", Offset = "0x2C39B84", VA = "0x2C39B84")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2C39C50", Offset = "0x2C39C50", VA = "0x2C39C50")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2C39F28", Offset = "0x2C39F28", VA = "0x2C39F28")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2C3A108", Offset = "0x2C3A108", VA = "0x2C3A108")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2C3A39C", Offset = "0x2C3A39C", VA = "0x2C3A39C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2C3A674", Offset = "0x2C3A674", VA = "0x2C3A674")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2C3A6B8", Offset = "0x2C3A6B8", VA = "0x2C3A6B8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2C3A730", Offset = "0x2C3A730", VA = "0x2C3A730")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2C3A84C", Offset = "0x2C3A84C", VA = "0x2C3A84C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2C3A9F0", Offset = "0x2C3A9F0", VA = "0x2C3A9F0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2C3AC94", Offset = "0x2C3AC94", VA = "0x2C3AC94")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2C3A4B0", Offset = "0x2C3A4B0", VA = "0x2C3A4B0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2C3AE00", Offset = "0x2C3AE00", VA = "0x2C3AE00")]
		public void Start()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2C3B570", Offset = "0x2C3B570", VA = "0x2C3B570")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2C3B590", Offset = "0x2C3B590", VA = "0x2C3B590")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2C3B5AC", Offset = "0x2C3B5AC", VA = "0x2C3B5AC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2C3B5C8", Offset = "0x2C3B5C8", VA = "0x2C3B5C8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2C3B62C", Offset = "0x2C3B62C", VA = "0x2C3B62C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2C3B768", Offset = "0x2C3B768", VA = "0x2C3B768")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2C3B878", Offset = "0x2C3B878", VA = "0x2C3B878")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2C3BC1C", Offset = "0x2C3BC1C", VA = "0x2C3BC1C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2C3BD1C", Offset = "0x2C3BD1C", VA = "0x2C3BD1C")]
		public void Update()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2C3BFB0", Offset = "0x2C3BFB0", VA = "0x2C3BFB0")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2C3B2D4", Offset = "0x2C3B2D4", VA = "0x2C3B2D4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2C3C0EC", Offset = "0x2C3C0EC", VA = "0x2C3C0EC")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2C3C21C", Offset = "0x2C3C21C", VA = "0x2C3C21C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2C3C2B4", Offset = "0x2C3C2B4", VA = "0x2C3C2B4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2C3C390", Offset = "0x2C3C390", VA = "0x2C3C390")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2C3C3AC", Offset = "0x2C3C3AC", VA = "0x2C3C3AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2C391EC", Offset = "0x2C391EC", VA = "0x2C391EC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2C39DF8", Offset = "0x2C39DF8", VA = "0x2C39DF8")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2C3C714", Offset = "0x2C3C714", VA = "0x2C3C714")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x100282C", Offset = "0x100282C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x100282C", Offset = "0x100282C")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class Multiplier
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10076A4", Offset = "0x10076A4")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10076DC", Offset = "0x10076DC")]
			public float multiplier;

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x2DE9B8C", Offset = "0x2DE9B8C", VA = "0x2DE9B8C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10074E4", Offset = "0x10074E4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100751C", Offset = "0x100751C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007554", Offset = "0x1007554")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100758C", Offset = "0x100758C")]
		public Transform pivot;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10075C4", Offset = "0x10075C4")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10075FC", Offset = "0x10075FC")]
		public float twistWeight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007634", Offset = "0x1007634")]
		public float swingWeight;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100766C", Offset = "0x100766C")]
		public bool rotateOnce;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2C3CE64", Offset = "0x2C3CE64", VA = "0x2C3CE64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CC24", Offset = "0x100CC24")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2C3CEAC", Offset = "0x2C3CEAC", VA = "0x2C3CEAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CC5C", Offset = "0x100CC5C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2C3CEF4", Offset = "0x2C3CEF4", VA = "0x2C3CEF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CC94", Offset = "0x100CC94")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2C3CF3C", Offset = "0x2C3CF3C", VA = "0x2C3CF3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CCCC", Offset = "0x100CCCC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2C3CF84", Offset = "0x2C3CF84", VA = "0x2C3CF84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CD04", Offset = "0x100CD04")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2C3CFCC", Offset = "0x2C3CFCC", VA = "0x2C3CFCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CD3C", Offset = "0x100CD3C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2C3D014", Offset = "0x2C3D014", VA = "0x2C3D014")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CD74", Offset = "0x100CD74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2C3D05C", Offset = "0x2C3D05C", VA = "0x2C3D05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CDAC", Offset = "0x100CDAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2C386A8", Offset = "0x2C386A8", VA = "0x2C386A8")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2C3D0A4", Offset = "0x2C3D0A4", VA = "0x2C3D0A4")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2C3D13C", Offset = "0x2C3D13C", VA = "0x2C3D13C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2C3D5EC", Offset = "0x2C3D5EC", VA = "0x2C3D5EC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x100288C", Offset = "0x100288C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x100288C", Offset = "0x100288C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class CharacterPosition
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100774C", Offset = "0x100774C")]
			public bool use;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007784", Offset = "0x1007784")]
			public Vector2 offset;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10077BC", Offset = "0x10077BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10077BC", Offset = "0x10077BC")]
			public float angleOffset;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007818", Offset = "0x1007818")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007818", Offset = "0x1007818")]
			public float maxAngle;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007870", Offset = "0x1007870")]
			public float radius;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10078A8", Offset = "0x10078A8")]
			public bool orbit;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10078E0", Offset = "0x10078E0")]
			public bool fixYAxis;

			[Token(Token = "0x1700008D")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x2DE9EFC", Offset = "0x2DE9EFC", VA = "0x2DE9EFC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x2DE9F08", Offset = "0x2DE9F08", VA = "0x2DE9F08")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x2DE9F90", Offset = "0x2DE9F90", VA = "0x2DE9F90")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x2DEA3D4", Offset = "0x2DEA3D4", VA = "0x2DEA3D4")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class CameraPosition
		{
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007918", Offset = "0x1007918")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007950", Offset = "0x1007950")]
			public Vector3 direction;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007988", Offset = "0x1007988")]
			public float maxDistance;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10079C0", Offset = "0x10079C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10079C0", Offset = "0x10079C0")]
			public float maxAngle;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007A18", Offset = "0x1007A18")]
			public bool fixYAxis;

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x2DE9B94", Offset = "0x2DE9B94", VA = "0x2DE9B94")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x2DE9C88", Offset = "0x2DE9C88", VA = "0x2DE9C88")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x2DE9EB0", Offset = "0x2DE9EB0", VA = "0x2DE9EB0")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000092")]
			public class Interaction
			{
				[Token(Token = "0x40004AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007B68", Offset = "0x1007B68")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007BA0", Offset = "0x1007BA0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600053B")]
				[Address(RVA = "0x2DEF8C4", Offset = "0x2DEF8C4", VA = "0x2DEF8C4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007AC0", Offset = "0x1007AC0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007AF8", Offset = "0x1007AF8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007B30", Offset = "0x1007B30")]
			public Interaction[] interactions;

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x2DEA3E8", Offset = "0x2DEA3E8", VA = "0x2DEA3E8")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x2DEA49C", Offset = "0x2DEA49C", VA = "0x2DEA49C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007714", Offset = "0x1007714")]
		public Range[] ranges;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2C3D634", Offset = "0x2C3D634", VA = "0x2C3D634")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CDE4", Offset = "0x100CDE4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2C3D67C", Offset = "0x2C3D67C", VA = "0x2C3D67C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CE1C", Offset = "0x100CE1C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2C3D6C4", Offset = "0x2C3D6C4", VA = "0x2C3D6C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CE54", Offset = "0x100CE54")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2C3D70C", Offset = "0x2C3D70C", VA = "0x2C3D70C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CE8C", Offset = "0x100CE8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2C3D754", Offset = "0x2C3D754", VA = "0x2C3D754")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CEC4", Offset = "0x100CEC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2C3D79C", Offset = "0x2C3D79C", VA = "0x2C3D79C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2C3BA48", Offset = "0x2C3BA48", VA = "0x2C3BA48")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2C3D7A0", Offset = "0x2C3D7A0", VA = "0x2C3D7A0")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public class Map
		{
			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x2AE7B78", Offset = "0x2AE7B78", VA = "0x2AE7B78")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2AE7BB4", Offset = "0x2AE7BB4", VA = "0x2AE7BB4")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x2AE7C04", Offset = "0x2AE7C04", VA = "0x2AE7C04")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x2AE7C50", Offset = "0x2AE7C50", VA = "0x2AE7C50")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2D73348", Offset = "0x2D73348", VA = "0x2D73348", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100CEFC", Offset = "0x100CEFC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2D736C4", Offset = "0x2D736C4", VA = "0x2D736C4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2D736C8", Offset = "0x2D736C8", VA = "0x2D736C8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2D737D0", Offset = "0x2D737D0", VA = "0x2D737D0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2D73658", Offset = "0x2D73658", VA = "0x2D73658")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2D735B8", Offset = "0x2D735B8", VA = "0x2D735B8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2D7383C", Offset = "0x2D7383C", VA = "0x2D7383C")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2E0C664", Offset = "0x2E0C664", VA = "0x2E0C664", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2E0C72C", Offset = "0x2E0C72C", VA = "0x2E0C72C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2E0C8E8", Offset = "0x2E0C8E8", VA = "0x2E0C8E8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2E0C9E4", Offset = "0x2E0C9E4", VA = "0x2E0C9E4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2E0C784", Offset = "0x2E0C784", VA = "0x2E0C784")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2E0CD44", Offset = "0x2E0CD44", VA = "0x2E0CD44")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007BD8", Offset = "0x1007BD8")]
		public float weight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007BF0", Offset = "0x1007BF0")]
		public float localRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007C08", Offset = "0x1007C08")]
		public float localPositionWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600054D")]
		public abstract void AutoMapping();

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2C44B6C", Offset = "0x2C44B6C", VA = "0x2C44B6C")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600054F")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000550")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000551")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x2C44B78", Offset = "0x2C44B78", VA = "0x2C44B78", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2C44BCC", Offset = "0x2C44BCC", VA = "0x2C44BCC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x2C44C08", Offset = "0x2C44C08", VA = "0x2C44C08", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2C44C20", Offset = "0x2C44C20", VA = "0x2C44C20")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10028EC", Offset = "0x10028EC")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000098")]
		public class Rigidbone
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x2DEC40C", Offset = "0x2DEC40C", VA = "0x2DEC40C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x2DEC57C", Offset = "0x2DEC57C", VA = "0x2DEC57C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x2DEC65C", Offset = "0x2DEC65C", VA = "0x2DEC65C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000099")]
		public class Child
		{
			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x600056B")]
			[Address(RVA = "0x2DEC21C", Offset = "0x2DEC21C", VA = "0x2DEC21C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x2DEC27C", Offset = "0x2DEC27C", VA = "0x2DEC27C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x2DEC3BC", Offset = "0x2DEC3BC", VA = "0x2DEC3BC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100294C", Offset = "0x100294C")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000571")]
				[Address(RVA = "0x2DEC1CC", Offset = "0x2DEC1CC", VA = "0x2DEC1CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000573")]
				[Address(RVA = "0x2DEC214", Offset = "0x2DEC214", VA = "0x2DEC214", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x2DEBFB0", Offset = "0x2DEBFB0", VA = "0x2DEBFB0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x2DEBFDC", Offset = "0x2DEBFDC", VA = "0x2DEBFDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x2DEBFE0", Offset = "0x2DEBFE0", VA = "0x2DEBFE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x2DEC1D4", Offset = "0x2DEC1D4", VA = "0x2DEC1D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007C20", Offset = "0x1007C20")]
		public IK ik;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007C58", Offset = "0x1007C58")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007C90", Offset = "0x1007C90")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007CC8", Offset = "0x1007CC8")]
		public float applyVelocity;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007D00", Offset = "0x1007D00")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700008F")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x2C45458", Offset = "0x2C45458", VA = "0x2C45458")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool ikUsed
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x2C45DE0", Offset = "0x2C45DE0", VA = "0x2C45DE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2C45420", Offset = "0x2C45420", VA = "0x2C45420")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2C454D0", Offset = "0x2C454D0", VA = "0x2C454D0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2C45600", Offset = "0x2C45600", VA = "0x2C45600")]
		public void Start()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2C45594", Offset = "0x2C45594", VA = "0x2C45594")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100CF34", Offset = "0x100CF34")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2C45A1C", Offset = "0x2C45A1C", VA = "0x2C45A1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2C45C68", Offset = "0x2C45C68", VA = "0x2C45C68")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2C45D24", Offset = "0x2C45D24", VA = "0x2C45D24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2C45F60", Offset = "0x2C45F60", VA = "0x2C45F60")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2C45DA4", Offset = "0x2C45DA4", VA = "0x2C45DA4")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2C45F1C", Offset = "0x2C45F1C", VA = "0x2C45F1C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2C46000", Offset = "0x2C46000", VA = "0x2C46000")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2C45F94", Offset = "0x2C45F94", VA = "0x2C45F94")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2C45528", Offset = "0x2C45528", VA = "0x2C45528")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2C45CA8", Offset = "0x2C45CA8", VA = "0x2C45CA8")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2C4622C", Offset = "0x2C4622C", VA = "0x2C4622C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2C46344", Offset = "0x2C46344", VA = "0x2C46344")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1007D48", Offset = "0x1007D48")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000093")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x2C47A60", Offset = "0x2C47A60", VA = "0x2C47A60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x2C47A6C", Offset = "0x2C47A6C", VA = "0x2C47A6C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x2C47A88", Offset = "0x2C47A88", VA = "0x2C47A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CFE4", Offset = "0x100CFE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x2C47A90", Offset = "0x2C47A90", VA = "0x2C47A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100CFF4", Offset = "0x100CFF4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2C47760", Offset = "0x2C47760", VA = "0x2C47760")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2C477A8", Offset = "0x2C477A8", VA = "0x2C477A8")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2C477C0", Offset = "0x2C477C0", VA = "0x2C477C0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2C479B8", Offset = "0x2C479B8", VA = "0x2C479B8")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2C47A28", Offset = "0x2C47A28", VA = "0x2C47A28")]
		public void Disable()
		{
		}

		[Token(Token = "0x600057D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2C478E0", Offset = "0x2C478E0", VA = "0x2C478E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2C47A9C", Offset = "0x2C47A9C", VA = "0x2C47A9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2C47AA0", Offset = "0x2C47AA0", VA = "0x2C47AA0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2C47AD4", Offset = "0x2C47AD4", VA = "0x2C47AD4")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2C47B50", Offset = "0x2C47B50", VA = "0x2C47B50")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2C47CE4", Offset = "0x2C47CE4", VA = "0x2C47CE4")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2C47D54", Offset = "0x2C47D54", VA = "0x2C47D54")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x100295C", Offset = "0x100295C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x100295C", Offset = "0x100295C")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007D58", Offset = "0x1007D58")]
		public float limit;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007D74", Offset = "0x1007D74")]
		public float twistLimit;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2C47D88", Offset = "0x2C47D88", VA = "0x2C47D88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D004", Offset = "0x100D004")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2C47DD0", Offset = "0x2C47DD0", VA = "0x2C47DD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D03C", Offset = "0x100D03C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2C47E18", Offset = "0x2C47E18", VA = "0x2C47E18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D074", Offset = "0x100D074")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2C47E60", Offset = "0x2C47E60", VA = "0x2C47E60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D0AC", Offset = "0x100D0AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2C47EA8", Offset = "0x2C47EA8", VA = "0x2C47EA8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2C47EEC", Offset = "0x2C47EEC", VA = "0x2C47EEC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2C480AC", Offset = "0x2C480AC", VA = "0x2C480AC")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10029BC", Offset = "0x10029BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10029BC", Offset = "0x10029BC")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2C480EC", Offset = "0x2C480EC", VA = "0x2C480EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D0E4", Offset = "0x100D0E4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2C48134", Offset = "0x2C48134", VA = "0x2C48134")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D11C", Offset = "0x100D11C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2C4817C", Offset = "0x2C4817C", VA = "0x2C4817C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D154", Offset = "0x100D154")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2C481C4", Offset = "0x2C481C4", VA = "0x2C481C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D18C", Offset = "0x100D18C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2C4820C", Offset = "0x2C4820C", VA = "0x2C4820C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2C48234", Offset = "0x2C48234", VA = "0x2C48234")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2C48430", Offset = "0x2C48430", VA = "0x2C48430")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002A1C", Offset = "0x1002A1C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002A1C", Offset = "0x1002A1C")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class ReachCone
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000096")]
			public Vector3 o
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0x2DECC90", Offset = "0x2DECC90", VA = "0x2DECC90")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 a
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x2DECCC8", Offset = "0x2DECCC8", VA = "0x2DECCC8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 b
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x2DECD04", Offset = "0x2DECD04", VA = "0x2DECD04")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 c
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x2DECD40", Offset = "0x2DECD40", VA = "0x2DECD40")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public bool isValid
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x2DECEB8", Offset = "0x2DECEB8", VA = "0x2DECEB8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x2DECD7C", Offset = "0x2DECD7C", VA = "0x2DECD7C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x2DECEC8", Offset = "0x2DECEC8", VA = "0x2DECEC8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class LimitPoint
		{
			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x2DECC54", Offset = "0x2DECC54", VA = "0x2DECC54")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007DA0", Offset = "0x1007DA0")]
		public float twistLimit;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007DBC", Offset = "0x1007DBC")]
		public int smoothIterations;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public Vector3[] P;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2C48488", Offset = "0x2C48488", VA = "0x2C48488")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D1C4", Offset = "0x100D1C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2C484D0", Offset = "0x2C484D0", VA = "0x2C484D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D1FC", Offset = "0x100D1FC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2C48518", Offset = "0x2C48518", VA = "0x2C48518")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D234", Offset = "0x100D234")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2C48560", Offset = "0x2C48560", VA = "0x2C48560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D26C", Offset = "0x100D26C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2C485A8", Offset = "0x2C485A8", VA = "0x2C485A8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2C48A48", Offset = "0x2C48A48", VA = "0x2C48A48", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2C48ADC", Offset = "0x2C48ADC", VA = "0x2C48ADC")]
		private void Start()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2C49008", Offset = "0x2C49008", VA = "0x2C49008")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2C48644", Offset = "0x2C48644", VA = "0x2C48644")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2C49388", Offset = "0x2C49388", VA = "0x2C49388")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2C49794", Offset = "0x2C49794", VA = "0x2C49794")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2C497D8", Offset = "0x2C497D8", VA = "0x2C497D8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2C49838", Offset = "0x2C49838", VA = "0x2C49838")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2C48D98", Offset = "0x2C48D98", VA = "0x2C48D98")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2C498A4", Offset = "0x2C498A4", VA = "0x2C498A4")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2C49980", Offset = "0x2C49980", VA = "0x2C49980")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1002A7C", Offset = "0x1002A7C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1002A7C", Offset = "0x1002A7C")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007E7C", Offset = "0x1007E7C")]
		public float twistLimit;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2ADE028", Offset = "0x2ADE028", VA = "0x2ADE028")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D2A4", Offset = "0x100D2A4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2ADE070", Offset = "0x2ADE070", VA = "0x2ADE070")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D2DC", Offset = "0x100D2DC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2ADE0B8", Offset = "0x2ADE0B8", VA = "0x2ADE0B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D314", Offset = "0x100D314")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2ADE100", Offset = "0x2ADE100", VA = "0x2ADE100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x100D34C", Offset = "0x100D34C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2ADE148", Offset = "0x2ADE148", VA = "0x2ADE148")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2ADE164", Offset = "0x2ADE164", VA = "0x2ADE164", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2ADE204", Offset = "0x2ADE204", VA = "0x2ADE204")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2ADE440", Offset = "0x2ADE440", VA = "0x2ADE440")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1002ADC", Offset = "0x1002ADC")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x2AE6CB0", Offset = "0x2AE6CB0", VA = "0x2AE6CB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x2AE6CF8", Offset = "0x2AE6CF8", VA = "0x2AE6CF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x2AE6BC0", Offset = "0x2AE6BC0", VA = "0x2AE6BC0")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x2AE6BEC", Offset = "0x2AE6BEC", VA = "0x2AE6BEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x2AE6BF0", Offset = "0x2AE6BF0", VA = "0x2AE6BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2AE6CB8", Offset = "0x2AE6CB8", VA = "0x2AE6CB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007ED0", Offset = "0x1007ED0")]
		public AimIK ik;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007F08", Offset = "0x1007F08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1007F08", Offset = "0x1007F08")]
		public float weight;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007F5C", Offset = "0x1007F5C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1007F5C", Offset = "0x1007F5C")]
		public Transform target;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007FBC", Offset = "0x1007FBC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1007FF4", Offset = "0x1007FF4")]
		public float weightSmoothTime;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100802C", Offset = "0x100802C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100802C", Offset = "0x100802C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100808C", Offset = "0x100808C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10080C4", Offset = "0x10080C4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10080FC", Offset = "0x10080FC")]
		public float slerpSpeed;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008134", Offset = "0x1008134")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100816C", Offset = "0x100816C")]
		public float minDistance;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10081A4", Offset = "0x10081A4")]
		public Vector3 offset;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10081DC", Offset = "0x10081DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10081DC", Offset = "0x10081DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10081DC", Offset = "0x10081DC")]
		public float maxRootAngle;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008258", Offset = "0x1008258")]
		public bool turnToTarget;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008290", Offset = "0x1008290")]
		public float turnToTargetTime;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10082C8", Offset = "0x10082C8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10082C8", Offset = "0x10082C8")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008328", Offset = "0x1008328")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700009B")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x2D350E4", Offset = "0x2D350E4", VA = "0x2D350E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2D3505C", Offset = "0x2D3505C", VA = "0x2D3505C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2D35174", Offset = "0x2D35174", VA = "0x2D35174")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2D356CC", Offset = "0x2D356CC", VA = "0x2D356CC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2D357B8", Offset = "0x2D357B8", VA = "0x2D357B8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2D35A08", Offset = "0x2D35A08", VA = "0x2D35A08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D384", Offset = "0x100D384")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2D35A74", Offset = "0x2D35A74", VA = "0x2D35A74")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A5")]
		public class Pose
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x2AE6D00", Offset = "0x2AE6D00", VA = "0x2AE6D00")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2AE6E8C", Offset = "0x2AE6E8C", VA = "0x2AE6E8C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x2AE6E94", Offset = "0x2AE6E94", VA = "0x2AE6E94")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2D35CD8", Offset = "0x2D35CD8", VA = "0x2D35CD8")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2D35DB8", Offset = "0x2D35DB8", VA = "0x2D35DB8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2D35E24", Offset = "0x2D35E24", VA = "0x2D35E24")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000A8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000529")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10084E8", Offset = "0x10084E8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400052A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008520", Offset = "0x1008520")]
				public float weight;

				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x2DEF4A8", Offset = "0x2DEF4A8", VA = "0x2DEF4A8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008398", Offset = "0x1008398")]
			public Transform transform;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10083D0", Offset = "0x10083D0")]
			public Transform relativeTo;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008408", Offset = "0x1008408")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008440", Offset = "0x1008440")]
			public float verticalWeight;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008478", Offset = "0x1008478")]
			public float horizontalWeight;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10084B0", Offset = "0x10084B0")]
			public float speed;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2AE6EB0", Offset = "0x2AE6EB0", VA = "0x2AE6EB0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2AE71D4", Offset = "0x2AE71D4", VA = "0x2AE71D4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x2AE71E4", Offset = "0x2AE71E4", VA = "0x2AE71E4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008360", Offset = "0x1008360")]
		public Body[] bodies;

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2D35F34", Offset = "0x2D35F34", VA = "0x2D35F34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2D36080", Offset = "0x2D36080", VA = "0x2D36080")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008558", Offset = "0x1008558")]
		public float tiltSpeed;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008590", Offset = "0x1008590")]
		public float tiltSensitivity;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10085C8", Offset = "0x10085C8")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008600", Offset = "0x1008600")]
		public OffsetPose poseRight;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2D432F4", Offset = "0x2D432F4", VA = "0x2D432F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2D4333C", Offset = "0x2D4333C", VA = "0x2D4333C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2D434F4", Offset = "0x2D434F4", VA = "0x2D434F4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2D68BC8", Offset = "0x2D68BC8", VA = "0x2D68BC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2D68C58", Offset = "0x2D68C58", VA = "0x2D68C58")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2D68D24", Offset = "0x2D68D24", VA = "0x2D68D24")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10086A8", Offset = "0x10086A8")]
			public string name;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10086E0", Offset = "0x10086E0")]
			public Collider collider;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008718", Offset = "0x1008718")]
			private float crossFadeTime;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008764", Offset = "0x1008764")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008774", Offset = "0x1008774")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008784", Offset = "0x1008784")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008794", Offset = "0x1008794")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700009F")]
			public bool inProgress
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x2AE96D0", Offset = "0x2AE96D0", VA = "0x2AE96D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A0")]
			protected float crossFader
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x2AE96E4", Offset = "0x2AE96E4", VA = "0x2AE96E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D434", Offset = "0x100D434")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x2AE96EC", Offset = "0x2AE96EC", VA = "0x2AE96EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D444", Offset = "0x100D444")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			protected float timer
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x2AE96F4", Offset = "0x2AE96F4", VA = "0x2AE96F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D454", Offset = "0x100D454")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x2AE96FC", Offset = "0x2AE96FC", VA = "0x2AE96FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D464", Offset = "0x100D464")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected Vector3 force
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x2AE9704", Offset = "0x2AE9704", VA = "0x2AE9704")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D474", Offset = "0x100D474")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x2AE9710", Offset = "0x2AE9710", VA = "0x2AE9710")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D484", Offset = "0x100D484")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x2AE971C", Offset = "0x2AE971C", VA = "0x2AE971C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D494", Offset = "0x100D494")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x2AE9728", Offset = "0x2AE9728", VA = "0x2AE9728")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D4A4", Offset = "0x100D4A4")]
				private set
				{
				}
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x2AE9734", Offset = "0x2AE9734", VA = "0x2AE9734")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x2AE9868", Offset = "0x2AE9868", VA = "0x2AE9868")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E1")]
			protected abstract float GetLength();

			[Token(Token = "0x60005E2")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005E3")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x2AE993C", Offset = "0x2AE993C", VA = "0x2AE993C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AD")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000AE")]
			public class EffectorLink
			{
				[Token(Token = "0x4000541")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100884C", Offset = "0x100884C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000542")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008884", Offset = "0x1008884")]
				public float weight;

				[Token(Token = "0x4000543")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x2DEF618", Offset = "0x2DEF618", VA = "0x2DEF618")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x2DEF6C8", Offset = "0x2DEF6C8", VA = "0x2DEF6C8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x2DEF6DC", Offset = "0x2DEF6DC", VA = "0x2DEF6DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10087A4", Offset = "0x10087A4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10087DC", Offset = "0x10087DC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008814", Offset = "0x1008814")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x2AE9C68", Offset = "0x2AE9C68", VA = "0x2AE9C68", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x2AE9D98", Offset = "0x2AE9D98", VA = "0x2AE9D98", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x2AE9E04", Offset = "0x2AE9E04", VA = "0x2AE9E04", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x2AE9F6C", Offset = "0x2AE9F6C", VA = "0x2AE9F6C")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AF")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B0")]
			public class BoneLink
			{
				[Token(Token = "0x4000548")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100892C", Offset = "0x100892C")]
				public Transform bone;

				[Token(Token = "0x4000549")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1008964", Offset = "0x1008964")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008964", Offset = "0x1008964")]
				public float weight;

				[Token(Token = "0x400054A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400054B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x2DEF4B0", Offset = "0x2DEF4B0", VA = "0x2DEF4B0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x2DEF5C8", Offset = "0x2DEF5C8", VA = "0x2DEF5C8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x2DEF5D4", Offset = "0x2DEF5D4", VA = "0x2DEF5D4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10088BC", Offset = "0x10088BC")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10088F4", Offset = "0x10088F4")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x2AE9950", Offset = "0x2AE9950", VA = "0x2AE9950", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x2AE99F4", Offset = "0x2AE99F4", VA = "0x2AE99F4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x2AE9A60", Offset = "0x2AE9A60", VA = "0x2AE9A60", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x2AE9C54", Offset = "0x2AE9C54", VA = "0x2AE9C54")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008638", Offset = "0x1008638")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008670", Offset = "0x1008670")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009E")]
		public bool inProgress
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x2E0DBE4", Offset = "0x2E0DBE4", VA = "0x2E0DBE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2E0DCB4", Offset = "0x2E0DCB4", VA = "0x2E0DCB4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2E0DD90", Offset = "0x2E0DD90", VA = "0x2E0DD90")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2E0DFEC", Offset = "0x2E0DFEC", VA = "0x2E0DFEC")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public abstract class Offset
		{
			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008A28", Offset = "0x1008A28")]
			public string name;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008A60", Offset = "0x1008A60")]
			public Collider collider;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008A98", Offset = "0x1008A98")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008AE4", Offset = "0x1008AE4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008AF4", Offset = "0x1008AF4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008B04", Offset = "0x1008B04")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1008B14", Offset = "0x1008B14")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A4")]
			protected float crossFader
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x2AE9F80", Offset = "0x2AE9F80", VA = "0x2AE9F80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D4B4", Offset = "0x100D4B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x2AE9F88", Offset = "0x2AE9F88", VA = "0x2AE9F88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D4C4", Offset = "0x100D4C4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected float timer
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x2AE9F90", Offset = "0x2AE9F90", VA = "0x2AE9F90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D4D4", Offset = "0x100D4D4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x2AE9F98", Offset = "0x2AE9F98", VA = "0x2AE9F98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D4E4", Offset = "0x100D4E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 force
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x2AE9FA0", Offset = "0x2AE9FA0", VA = "0x2AE9FA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D4F4", Offset = "0x100D4F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x2AE9FAC", Offset = "0x2AE9FAC", VA = "0x2AE9FAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D504", Offset = "0x100D504")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 point
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x2AE9FB8", Offset = "0x2AE9FB8", VA = "0x2AE9FB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D514", Offset = "0x100D514")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x2AE9FC4", Offset = "0x2AE9FC4", VA = "0x2AE9FC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D524", Offset = "0x100D524")]
				private set
				{
				}
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x2AE9FD0", Offset = "0x2AE9FD0", VA = "0x2AE9FD0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x2AEA118", Offset = "0x2AEA118", VA = "0x2AEA118")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000600")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000601")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000602")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x2AEA200", Offset = "0x2AEA200", VA = "0x2AEA200")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B4")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400055C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008BCC", Offset = "0x1008BCC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008C04", Offset = "0x1008C04")]
				public float weight;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000608")]
				[Address(RVA = "0x2DEF6E4", Offset = "0x2DEF6E4", VA = "0x2DEF6E4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0x2DEF774", Offset = "0x2DEF774", VA = "0x2DEF774")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060A")]
				[Address(RVA = "0x2DEF788", Offset = "0x2DEF788", VA = "0x2DEF788")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008B24", Offset = "0x1008B24")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008B5C", Offset = "0x1008B5C")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008B94", Offset = "0x1008B94")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x2AEA214", Offset = "0x2AEA214", VA = "0x2AEA214", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x2AEA3C4", Offset = "0x2AEA3C4", VA = "0x2AEA3C4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x2AEA430", Offset = "0x2AEA430", VA = "0x2AEA430", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x2AEA5D0", Offset = "0x2AEA5D0", VA = "0x2AEA5D0")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B6")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000563")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008CAC", Offset = "0x1008CAC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008CE4", Offset = "0x1008CE4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1008CE4", Offset = "0x1008CE4")]
				public float weight;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x2DEF790", Offset = "0x2DEF790", VA = "0x2DEF790")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x2DEF86C", Offset = "0x2DEF86C", VA = "0x2DEF86C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x2DEF878", Offset = "0x2DEF878", VA = "0x2DEF878")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008C3C", Offset = "0x1008C3C")]
			public int curveIndex;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008C74", Offset = "0x1008C74")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x2AEA5EC", Offset = "0x2AEA5EC", VA = "0x2AEA5EC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x2AEA6D0", Offset = "0x2AEA6D0", VA = "0x2AEA6D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x2AEA73C", Offset = "0x2AEA73C", VA = "0x2AEA73C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x2AEA9F0", Offset = "0x2AEA9F0", VA = "0x2AEA9F0")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10089B8", Offset = "0x10089B8")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10089F0", Offset = "0x10089F0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2E0E340", Offset = "0x2E0E340", VA = "0x2E0E340", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2E0E414", Offset = "0x2E0E414", VA = "0x2E0E414")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2E0E678", Offset = "0x2E0E678", VA = "0x2E0E678")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000B9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000574")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008F14", Offset = "0x1008F14")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000575")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008F4C", Offset = "0x1008F4C")]
				public float weight;

				[Token(Token = "0x6000618")]
				[Address(RVA = "0x2DEF8BC", Offset = "0x2DEF8BC", VA = "0x2DEF8BC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008DA8", Offset = "0x1008DA8")]
			public Transform transform;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008DE0", Offset = "0x1008DE0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008E18", Offset = "0x1008E18")]
			public float speed;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008E50", Offset = "0x1008E50")]
			public float acceleration;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008E88", Offset = "0x1008E88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1008E88", Offset = "0x1008E88")]
			public float matchVelocity;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008EDC", Offset = "0x1008EDC")]
			public float gravity;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x2DE8CB0", Offset = "0x2DE8CB0", VA = "0x2DE8CB0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x2DE8D68", Offset = "0x2DE8D68", VA = "0x2DE8D68")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x2DE9024", Offset = "0x2DE9024", VA = "0x2DE9024")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008D38", Offset = "0x1008D38")]
		public Body[] bodies;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008D70", Offset = "0x1008D70")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x2D9802C", Offset = "0x2D9802C", VA = "0x2D9802C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2D980A8", Offset = "0x2D980A8", VA = "0x2D980A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x2D98168", Offset = "0x2D98168", VA = "0x2D98168")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1008F84", Offset = "0x1008F84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008F84", Offset = "0x1008F84")]
		public Transform target;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1008FE4", Offset = "0x1008FE4")]
		public float weight;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1008FFC", Offset = "0x1008FFC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009034", Offset = "0x1009034")]
		public float weightSmoothTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100906C", Offset = "0x100906C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100906C", Offset = "0x100906C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10090CC", Offset = "0x10090CC")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009104", Offset = "0x1009104")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100913C", Offset = "0x100913C")]
		public float slerpSpeed;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009174", Offset = "0x1009174")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10091AC", Offset = "0x10091AC")]
		public float minDistance;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10091E4", Offset = "0x10091E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10091E4", Offset = "0x10091E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10091E4", Offset = "0x10091E4")]
		public float maxRootAngle;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000A8")]
		private Vector3 pivot
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x2C3EDF0", Offset = "0x2C3EDF0", VA = "0x2C3EDF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2C3ED7C", Offset = "0x2C3ED7C", VA = "0x2C3ED7C")]
		private void Start()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2C3EE80", Offset = "0x2C3EE80", VA = "0x2C3EE80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2C3F39C", Offset = "0x2C3F39C", VA = "0x2C3F39C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2C3F488", Offset = "0x2C3F488", VA = "0x2C3F488")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2C3F680", Offset = "0x2C3F680", VA = "0x2C3F680")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public class OffsetLimits
		{
			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10092D0", Offset = "0x10092D0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009308", Offset = "0x1009308")]
			public float spring;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009340", Offset = "0x1009340")]
			public bool x;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009378", Offset = "0x1009378")]
			public bool y;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10093B0", Offset = "0x10093B0")]
			public bool z;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10093E8", Offset = "0x10093E8")]
			public float minX;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009420", Offset = "0x1009420")]
			public float maxX;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009458", Offset = "0x1009458")]
			public float minY;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009490", Offset = "0x1009490")]
			public float maxY;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10094C8", Offset = "0x10094C8")]
			public float minZ;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009500", Offset = "0x1009500")]
			public float maxZ;

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x2DEB3DC", Offset = "0x2DEB3DC", VA = "0x2DEB3DC")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x2DEB534", Offset = "0x2DEB534", VA = "0x2DEB534")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x2DEB5AC", Offset = "0x2DEB5AC", VA = "0x2DEB5AC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2DEB604", Offset = "0x2DEB604", VA = "0x2DEB604")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1002AFC", Offset = "0x1002AFC")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x2DEB38C", Offset = "0x2DEB38C", VA = "0x2DEB38C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x2DEB3D4", Offset = "0x2DEB3D4", VA = "0x2DEB3D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x2DEB20C", Offset = "0x2DEB20C", VA = "0x2DEB20C")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x2DEB238", Offset = "0x2DEB238", VA = "0x2DEB238", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x2DEB23C", Offset = "0x2DEB23C", VA = "0x2DEB23C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x2DEB394", Offset = "0x2DEB394", VA = "0x2DEB394", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009260", Offset = "0x1009260")]
		public float weight;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009298", Offset = "0x1009298")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A9")]
		protected float deltaTime
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x2C42718", Offset = "0x2C42718", VA = "0x2C42718")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000620")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2C41508", Offset = "0x2C41508", VA = "0x2C41508", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2C42744", Offset = "0x2C42744", VA = "0x2C42744")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D534", Offset = "0x100D534")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x2C427B0", Offset = "0x2C427B0", VA = "0x2C427B0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2C4288C", Offset = "0x2C4288C", VA = "0x2C4288C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2C41878", Offset = "0x2C41878", VA = "0x2C41878", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2C41998", Offset = "0x2C41998", VA = "0x2C41998")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1002B0C", Offset = "0x1002B0C")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x2DEB78C", Offset = "0x2DEB78C", VA = "0x2DEB78C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x2DEB7D4", Offset = "0x2DEB7D4", VA = "0x2DEB7D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2DEB60C", Offset = "0x2DEB60C", VA = "0x2DEB60C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2DEB638", Offset = "0x2DEB638", VA = "0x2DEB638", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x2DEB63C", Offset = "0x2DEB63C", VA = "0x2DEB63C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2DEB794", Offset = "0x2DEB794", VA = "0x2DEB794", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009538", Offset = "0x1009538")]
		public float weight;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009570", Offset = "0x1009570")]
		public VRIK ik;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x2C4294C", Offset = "0x2C4294C", VA = "0x2C4294C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000632")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2C42978", Offset = "0x2C42978", VA = "0x2C42978", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2C429A4", Offset = "0x2C429A4", VA = "0x2C429A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D5E4", Offset = "0x100D5E4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2C42A10", Offset = "0x2C42A10", VA = "0x2C42A10")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2C42AEC", Offset = "0x2C42AEC", VA = "0x2C42AEC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2C42BF8", Offset = "0x2C42BF8", VA = "0x2C42BF8")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class EffectorLink
		{
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x2DEB7DC", Offset = "0x2DEB7DC", VA = "0x2DEB7DC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2DEB9F8", Offset = "0x2DEB9F8", VA = "0x2DEB9F8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2C42C08", Offset = "0x2C42C08", VA = "0x2C42C08")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2C42CCC", Offset = "0x2C42CCC", VA = "0x2C42CCC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2C42D88", Offset = "0x2C42D88", VA = "0x2C42D88")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000C4")]
			public class EffectorLink
			{
				[Token(Token = "0x40005B1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009784", Offset = "0x1009784")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10097BC", Offset = "0x10097BC")]
				public float weight;

				[Token(Token = "0x6000649")]
				[Address(RVA = "0x2DEF8CC", Offset = "0x2DEF8CC", VA = "0x2DEF8CC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10095E0", Offset = "0x10095E0")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009618", Offset = "0x1009618")]
			public Transform raycastTo;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009650", Offset = "0x1009650")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1009650", Offset = "0x1009650")]
			public float raycastRadius;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10096A4", Offset = "0x10096A4")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10096DC", Offset = "0x10096DC")]
			public float smoothTimeIn;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009714", Offset = "0x1009714")]
			public float smoothTimeOut;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100974C", Offset = "0x100974C")]
			public LayerMask layers;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x2DEBA00", Offset = "0x2DEBA00", VA = "0x2DEBA00")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x2DEBB44", Offset = "0x2DEBB44", VA = "0x2DEBB44")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x2DEBC3C", Offset = "0x2DEBC3C", VA = "0x2DEBC3C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x2DEBE0C", Offset = "0x2DEBE0C", VA = "0x2DEBE0C")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10095A8", Offset = "0x10095A8")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2C43730", Offset = "0x2C43730", VA = "0x2C43730", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2C437B8", Offset = "0x2C437B8", VA = "0x2C437B8")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000C7")]
			public class EffectorLink
			{
				[Token(Token = "0x40005D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009B48", Offset = "0x1009B48")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009B80", Offset = "0x1009B80")]
				public float weight;

				[Token(Token = "0x6000659")]
				[Address(RVA = "0x2DEF8D4", Offset = "0x2DEF8D4", VA = "0x2DEF8D4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009A4C", Offset = "0x1009A4C")]
			public Vector3 offset;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009A84", Offset = "0x1009A84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1009A84", Offset = "0x1009A84")]
			public float additivity;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009AD8", Offset = "0x1009AD8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009B10", Offset = "0x1009B10")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x2DEC800", Offset = "0x2DEC800", VA = "0x2DEC800")]
			public void Start()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x2DEC850", Offset = "0x2DEC850", VA = "0x2DEC850")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x2DECA14", Offset = "0x2DECA14", VA = "0x2DECA14")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public enum Handedness
		{
			[Token(Token = "0x40005D3")]
			Right,
			[Token(Token = "0x40005D4")]
			Left
		}

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10097F4", Offset = "0x10097F4")]
		public AimIK aimIK;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100982C", Offset = "0x100982C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009864", Offset = "0x1009864")]
		public Handedness handedness;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100989C", Offset = "0x100989C")]
		public bool twoHanded;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10098D4", Offset = "0x10098D4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100990C", Offset = "0x100990C")]
		public float magnitudeRandom;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009944", Offset = "0x1009944")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100997C", Offset = "0x100997C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10099B4", Offset = "0x10099B4")]
		public float blendTime;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10099EC", Offset = "0x10099EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10099EC", Offset = "0x10099EC")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000AF")]
		public bool isFinished
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x2C4662C", Offset = "0x2C4662C", VA = "0x2C4662C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x2C470A4", Offset = "0x2C470A4", VA = "0x2C470A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x2C470E4", Offset = "0x2C470E4", VA = "0x2C470E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x2C47064", Offset = "0x2C47064", VA = "0x2C47064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2C47084", Offset = "0x2C47084", VA = "0x2C47084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2C4665C", Offset = "0x2C4665C", VA = "0x2C4665C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2C46688", Offset = "0x2C46688", VA = "0x2C46688")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2C467D0", Offset = "0x2C467D0", VA = "0x2C467D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2C47124", Offset = "0x2C47124", VA = "0x2C47124")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2C471D8", Offset = "0x2C471D8", VA = "0x2C471D8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2C47214", Offset = "0x2C47214", VA = "0x2C47214", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2C473CC", Offset = "0x2C473CC", VA = "0x2C473CC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009BB8", Offset = "0x1009BB8")]
		public float weight;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009BF0", Offset = "0x1009BF0")]
		public float offset;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2ADE650", Offset = "0x2ADE650", VA = "0x2ADE650")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2ADE73C", Offset = "0x2ADE73C", VA = "0x2ADE73C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2ADE824", Offset = "0x2ADE824", VA = "0x2ADE824")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2ADEB74", Offset = "0x2ADEB74", VA = "0x2ADEB74")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2ADEBE8", Offset = "0x2ADEBE8", VA = "0x2ADEBE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2ADECE8", Offset = "0x2ADECE8", VA = "0x2ADECE8")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Settings
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009C28", Offset = "0x1009C28")]
			public float scaleMlp;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009C60", Offset = "0x1009C60")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009C98", Offset = "0x1009C98")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009CD0", Offset = "0x1009CD0")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009D08", Offset = "0x1009D08")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009D40", Offset = "0x1009D40")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009D78", Offset = "0x1009D78")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009DB0", Offset = "0x1009DB0")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009DE8", Offset = "0x1009DE8")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009E20", Offset = "0x1009E20")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1009E20", Offset = "0x1009E20")]
			public Vector3 headOffset;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009E70", Offset = "0x1009E70")]
			public Vector3 handOffset;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009EA8", Offset = "0x1009EA8")]
			public float footForwardOffset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009EE0", Offset = "0x1009EE0")]
			public float footInwardOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009F18", Offset = "0x1009F18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1009F18", Offset = "0x1009F18")]
			public float footHeadingOffset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1009F74", Offset = "0x1009F74")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1009F8C", Offset = "0x1009F8C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x2DEF040", Offset = "0x2DEF040", VA = "0x2DEF040")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000CD")]
			public class Target
			{
				[Token(Token = "0x40005F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40005F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40005F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000667")]
				[Address(RVA = "0x2DEF8DC", Offset = "0x2DEF8DC", VA = "0x2DEF8DC")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0x2DEF99C", Offset = "0x2DEF99C", VA = "0x2DEF99C")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x2DEF038", Offset = "0x2DEF038", VA = "0x2DEF038")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2AE4E5C", Offset = "0x2AE4E5C", VA = "0x2AE4E5C")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x2AE3170", Offset = "0x2AE3170", VA = "0x2AE3170")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2AE4FB8", Offset = "0x2AE4FB8", VA = "0x2AE4FB8")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x2AE437C", Offset = "0x2AE437C", VA = "0x2AE437C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x2AE57A4", Offset = "0x2AE57A4", VA = "0x2AE57A4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2AE5B98", Offset = "0x2AE5B98", VA = "0x2AE5B98")]
		private void Start()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2AE5BEC", Offset = "0x2AE5BEC", VA = "0x2AE5BEC")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2AE5C20", Offset = "0x2AE5C20", VA = "0x2AE5C20")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x2AE5D5C", Offset = "0x2AE5D5C", VA = "0x2AE5D5C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1009FA4", Offset = "0x1009FA4")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B4")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x2AE644C", Offset = "0x2AE644C", VA = "0x2AE644C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D694", Offset = "0x100D694")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x2AE6458", Offset = "0x2AE6458", VA = "0x2AE6458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D6A4", Offset = "0x100D6A4")]
			private set
			{
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2AE6464", Offset = "0x2AE6464", VA = "0x2AE6464")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2AE55AC", Offset = "0x2AE55AC", VA = "0x2AE55AC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x2AE5A14", Offset = "0x2AE5A14", VA = "0x2AE5A14")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x2AE6544", Offset = "0x2AE6544", VA = "0x2AE6544")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x2AE6960", Offset = "0x2AE6960", VA = "0x2AE6960")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2AE6A60", Offset = "0x2AE6A60", VA = "0x2AE6A60")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000D0")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public class Offset
		{
			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x2AE7A10", Offset = "0x2AE7A10", VA = "0x2AE7A10")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x2AE7B70", Offset = "0x2AE7B70", VA = "0x2AE7B70")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2D6FB78", Offset = "0x2D6FB78", VA = "0x2D6FB78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2D6FBCC", Offset = "0x2D6FBCC", VA = "0x2D6FBCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2D6FC48", Offset = "0x2D6FC48", VA = "0x2D6FC48")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2D6FD20", Offset = "0x2D6FD20", VA = "0x2D6FD20")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x2D34FD0", Offset = "0x2D34FD0", VA = "0x2D34FD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x2D35054", Offset = "0x2D35054", VA = "0x2D35054")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1009FEC", Offset = "0x1009FEC")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x2D35E88", Offset = "0x2D35E88", VA = "0x2D35E88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x2D35F00", Offset = "0x2D35F00", VA = "0x2D35F00")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x2ADE450", Offset = "0x2ADE450", VA = "0x2ADE450")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2ADE494", Offset = "0x2ADE494", VA = "0x2ADE494")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x2ADE648", Offset = "0x2ADE648", VA = "0x2ADE648")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A024", Offset = "0x100A024")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A05C", Offset = "0x100A05C")]
		public AimIK aim;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A094", Offset = "0x100A094")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A0CC", Offset = "0x100A0CC")]
		public Animator animator;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A104", Offset = "0x100A104")]
		public float crossfadeTime;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A13C", Offset = "0x100A13C")]
		public float minAimDistance;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2ADECFC", Offset = "0x2ADECFC", VA = "0x2ADECFC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2ADED40", Offset = "0x2ADED40", VA = "0x2ADED40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2ADEEA8", Offset = "0x2ADEEA8", VA = "0x2ADEEA8")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2ADF038", Offset = "0x2ADF038", VA = "0x2ADF038")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2ADF174", Offset = "0x2ADF174", VA = "0x2ADF174")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2ADF1F0", Offset = "0x2ADF1F0", VA = "0x2ADF1F0")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2AE0188", Offset = "0x2AE0188", VA = "0x2AE0188")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2AE02F8", Offset = "0x2AE02F8", VA = "0x2AE02F8")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x2AE048C", Offset = "0x2AE048C", VA = "0x2AE048C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x100A174", Offset = "0x100A174")]
		public Animator animator;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x100A1AC", Offset = "0x100A1AC")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A1E4", Offset = "0x100A1E4")]
		public float lookAtWeight;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A1FC", Offset = "0x100A1FC")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A214", Offset = "0x100A214")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A22C", Offset = "0x100A22C")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A244", Offset = "0x100A244")]
		public float lookAtClampWeight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A25C", Offset = "0x100A25C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A274", Offset = "0x100A274")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x100A28C", Offset = "0x100A28C")]
		public Transform footTargetBiped;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A2C4", Offset = "0x100A2C4")]
		public float footPositionWeight;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A2DC", Offset = "0x100A2DC")]
		public float footRotationWeight;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x100A2F4", Offset = "0x100A2F4")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A32C", Offset = "0x100A32C")]
		public float handPositionWeight;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A344", Offset = "0x100A344")]
		public float handRotationWeight;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2D3C4D8", Offset = "0x2D3C4D8", VA = "0x2D3C4D8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x2D3C8E0", Offset = "0x2D3C8E0", VA = "0x2D3C8E0")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2C3F87C", Offset = "0x2C3F87C", VA = "0x2C3F87C")]
		private void Update()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x2C40088", Offset = "0x2C40088", VA = "0x2C40088")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2C3FE38", Offset = "0x2C3FE38", VA = "0x2C3FE38")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x2C40184", Offset = "0x2C40184", VA = "0x2C40184")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B5")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x2C401B0", Offset = "0x2C401B0", VA = "0x2C401B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x2C40234", Offset = "0x2C40234", VA = "0x2C40234")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x2C40458", Offset = "0x2C40458", VA = "0x2C40458")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1002B1C", Offset = "0x1002B1C")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A2")]
				[Address(RVA = "0x2DEAF54", Offset = "0x2DEAF54", VA = "0x2DEAF54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x2DEAF9C", Offset = "0x2DEAF9C", VA = "0x2DEAF9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x2DEAC64", Offset = "0x2DEAC64", VA = "0x2DEAC64")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x2DEAC90", Offset = "0x2DEAC90", VA = "0x2DEAC90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x2DEAC94", Offset = "0x2DEAC94", VA = "0x2DEAC94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x2DEAF5C", Offset = "0x2DEAF5C", VA = "0x2DEAF5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000B6")]
		public bool isStepping
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x2C4046C", Offset = "0x2C4046C", VA = "0x2C4046C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x2C40150", Offset = "0x2C40150", VA = "0x2C40150")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x2C40480", Offset = "0x2C40480", VA = "0x2C40480")]
			set
			{
			}
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x2C404D0", Offset = "0x2C404D0", VA = "0x2C404D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2C406C4", Offset = "0x2C406C4", VA = "0x2C406C4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x2C40860", Offset = "0x2C40860", VA = "0x2C40860")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x2C40A88", Offset = "0x2C40A88", VA = "0x2C40A88")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x2C40D2C", Offset = "0x2C40D2C", VA = "0x2C40D2C")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x2C40EA4", Offset = "0x2C40EA4", VA = "0x2C40EA4")]
		private void Update()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x2C409E0", Offset = "0x2C409E0", VA = "0x2C409E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D6B4", Offset = "0x100D6B4")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x2C410A0", Offset = "0x2C410A0", VA = "0x2C410A0")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2C41104", Offset = "0x2C41104", VA = "0x2C41104")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2C411C4", Offset = "0x2C411C4", VA = "0x2C411C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2C41418", Offset = "0x2C41418", VA = "0x2C41418")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public struct Warp
		{
			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A41C", Offset = "0x100A41C")]
			public int animationLayer;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A454", Offset = "0x100A454")]
			public string animationState;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A48C", Offset = "0x100A48C")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A4C4", Offset = "0x100A4C4")]
			public Transform warpFrom;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A4FC", Offset = "0x100A4FC")]
			public Transform warpTo;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A534", Offset = "0x100A534")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000673")]
			PositionOffset,
			[Token(Token = "0x4000674")]
			Position
		}

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A35C", Offset = "0x100A35C")]
		public Animator animator;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A394", Offset = "0x100A394")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A3CC", Offset = "0x100A3CC")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x100A3CC", Offset = "0x100A3CC")]
		public Warp[] warps;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2D36088", Offset = "0x2D36088", VA = "0x2D36088", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2D360B4", Offset = "0x2D360B4", VA = "0x2D360B4")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2D362F4", Offset = "0x2D362F4", VA = "0x2D362F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2D365B8", Offset = "0x2D365B8", VA = "0x2D365B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2D36658", Offset = "0x2D36658", VA = "0x2D36658")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002B2C", Offset = "0x1002B2C")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2D36660", Offset = "0x2D36660", VA = "0x2D36660", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2D366B4", Offset = "0x2D366B4", VA = "0x2D366B4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2D36850", Offset = "0x2D36850", VA = "0x2D36850", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2D36A58", Offset = "0x2D36A58", VA = "0x2D36A58")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002B8C", Offset = "0x1002B8C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002B8C", Offset = "0x1002B8C")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A56C", Offset = "0x100A56C")]
		public float headLookWeight;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x2D36A6C", Offset = "0x2D36A6C", VA = "0x2D36A6C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2D36BF8", Offset = "0x2D36BF8", VA = "0x2D36BF8", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x2D36C74", Offset = "0x2D36C74", VA = "0x2D36C74")]
		private void Read()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x2D36D68", Offset = "0x2D36D68", VA = "0x2D36D68")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x2D36DB0", Offset = "0x2D36DB0", VA = "0x2D36DB0")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2D3719C", Offset = "0x2D3719C", VA = "0x2D3719C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2D37024", Offset = "0x2D37024", VA = "0x2D37024")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2D373F8", Offset = "0x2D373F8", VA = "0x2D373F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2D37504", Offset = "0x2D37504", VA = "0x2D37504")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002C20", Offset = "0x1002C20")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2D44FA8", Offset = "0x2D44FA8", VA = "0x2D44FA8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2D45004", Offset = "0x2D45004", VA = "0x2D45004", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2D45240", Offset = "0x2D45240", VA = "0x2D45240")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2D45334", Offset = "0x2D45334", VA = "0x2D45334")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002C80", Offset = "0x1002C80")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BA")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x2D45D58", Offset = "0x2D45D58", VA = "0x2D45D58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x2D45DDC", Offset = "0x2D45DDC", VA = "0x2D45DDC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2D45B60", Offset = "0x2D45B60", VA = "0x2D45B60")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2D45BCC", Offset = "0x2D45BCC", VA = "0x2D45BCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2D45E60", Offset = "0x2D45E60", VA = "0x2D45E60")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A584", Offset = "0x100A584")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2D68D2C", Offset = "0x2D68D2C", VA = "0x2D68D2C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2D6918C", Offset = "0x2D6918C", VA = "0x2D6918C")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2D69194", Offset = "0x2D69194", VA = "0x2D69194")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2D6923C", Offset = "0x2D6923C", VA = "0x2D6923C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2D695C0", Offset = "0x2D695C0", VA = "0x2D695C0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2D6966C", Offset = "0x2D6966C", VA = "0x2D6966C")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public class Limb
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x2AE74F8", Offset = "0x2AE74F8", VA = "0x2AE74F8")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x2AE757C", Offset = "0x2AE757C", VA = "0x2AE757C")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2D6CF38", Offset = "0x2D6CF38", VA = "0x2D6CF38")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x2D6D090", Offset = "0x2D6D090", VA = "0x2D6D090")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2D6D134", Offset = "0x2D6D134", VA = "0x2D6D134")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2D6D138", Offset = "0x2D6D138", VA = "0x2D6D138")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2D6D148", Offset = "0x2D6D148", VA = "0x2D6D148")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x2D6D1BC", Offset = "0x2D6D1BC", VA = "0x2D6D1BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2D6D290", Offset = "0x2D6D290", VA = "0x2D6D290")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A59C", Offset = "0x100A59C")]
		public Transform target;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A5D4", Offset = "0x100A5D4")]
		public Transform pin;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A60C", Offset = "0x100A60C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A644", Offset = "0x100A644")]
		public AimIK aim;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A67C", Offset = "0x100A67C")]
		public float weight;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A6B4", Offset = "0x100A6B4")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A6EC", Offset = "0x100A6EC")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2D6D298", Offset = "0x2D6D298", VA = "0x2D6D298")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2D6D2EC", Offset = "0x2D6D2EC", VA = "0x2D6D2EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2D6D490", Offset = "0x2D6D490", VA = "0x2D6D490")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2D6F534", Offset = "0x2D6F534", VA = "0x2D6F534")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2D6F5FC", Offset = "0x2D6F5FC", VA = "0x2D6F5FC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2D6F68C", Offset = "0x2D6F68C", VA = "0x2D6F68C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2D6FA64", Offset = "0x2D6FA64", VA = "0x2D6FA64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2D6FB70", Offset = "0x2D6FB70", VA = "0x2D6FB70")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A724", Offset = "0x100A724")]
		public float aimWeight;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A73C", Offset = "0x100A73C")]
		public float sightWeight;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A754", Offset = "0x100A754")]
		public float maxAngle;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A770", Offset = "0x100A770")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2D6FD28", Offset = "0x2D6FD28", VA = "0x2D6FD28")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2D6FE9C", Offset = "0x2D6FE9C", VA = "0x2D6FE9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2D6FEA8", Offset = "0x2D6FEA8", VA = "0x2D6FEA8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2D70128", Offset = "0x2D70128", VA = "0x2D70128")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2D702D4", Offset = "0x2D702D4", VA = "0x2D702D4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2D6FF70", Offset = "0x2D6FF70", VA = "0x2D6FF70")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2D70BC8", Offset = "0x2D70BC8", VA = "0x2D70BC8")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002CE0", Offset = "0x1002CE0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002CE0", Offset = "0x1002CE0")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A788", Offset = "0x100A788")]
		public float walkSpeed;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2D70BE8", Offset = "0x2D70BE8", VA = "0x2D70BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2D70C60", Offset = "0x2D70C60", VA = "0x2D70C60")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x2D70D4C", Offset = "0x2D70D4C", VA = "0x2D70D4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2D70E04", Offset = "0x2D70E04", VA = "0x2D70E04")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2E0DFF4", Offset = "0x2E0DFF4", VA = "0x2E0DFF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2E0E14C", Offset = "0x2E0E14C", VA = "0x2E0E14C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2E0E330", Offset = "0x2E0E330", VA = "0x2E0E330")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2E0E9CC", Offset = "0x2E0E9CC", VA = "0x2E0E9CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2E0EB14", Offset = "0x2E0EB14", VA = "0x2E0EB14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2E0EE50", Offset = "0x2E0EE50", VA = "0x2E0EE50")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2D98248", Offset = "0x2D98248", VA = "0x2D98248")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2D98384", Offset = "0x2D98384", VA = "0x2D98384")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2D98490", Offset = "0x2D98490", VA = "0x2D98490")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2D98498", Offset = "0x2D98498", VA = "0x2D98498")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2D98BC4", Offset = "0x2D98BC4", VA = "0x2D98BC4")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002D74", Offset = "0x1002D74")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A7A0", Offset = "0x100A7A0")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A7D8", Offset = "0x100A7D8")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2C3CAD0", Offset = "0x2C3CAD0", VA = "0x2C3CAD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2C3CB24", Offset = "0x2C3CB24", VA = "0x2C3CB24")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2C3CE5C", Offset = "0x2C3CE5C", VA = "0x2C3CE5C")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class Partner
		{
			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000BC")]
			private Transform neck
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x2DEABF8", Offset = "0x2DEABF8", VA = "0x2DEABF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x2DEA4AC", Offset = "0x2DEA4AC", VA = "0x2DEA4AC")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x2DEA4CC", Offset = "0x2DEA4CC", VA = "0x2DEA4CC")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x2DEAA64", Offset = "0x2DEAA64", VA = "0x2DEAA64")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x2DEAC50", Offset = "0x2DEAC50", VA = "0x2DEAC50")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2C3E378", Offset = "0x2C3E378", VA = "0x2C3E378")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2C3E3B4", Offset = "0x2C3E3B4", VA = "0x2C3E3B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2C3E41C", Offset = "0x2C3E41C", VA = "0x2C3E41C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public enum Mode
		{
			[Token(Token = "0x40006FF")]
			Position,
			[Token(Token = "0x4000700")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000F6")]
		public class Absorber
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A8F0", Offset = "0x100A8F0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A928", Offset = "0x100A928")]
			public float weight;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x2DEAFA4", Offset = "0x2DEAFA4", VA = "0x2DEAFA4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x2DEB078", Offset = "0x2DEB078", VA = "0x2DEB078")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x2DEB0B4", Offset = "0x2DEB0B4", VA = "0x2DEB0B4")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x2DEB14C", Offset = "0x2DEB14C", VA = "0x2DEB14C")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x2DEB1C0", Offset = "0x2DEB1C0", VA = "0x2DEB1C0")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A810", Offset = "0x100A810")]
		public Mode mode;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A848", Offset = "0x100A848")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A880", Offset = "0x100A880")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A8B8", Offset = "0x100A8B8")]
		public float falloffSpeed;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2C41420", Offset = "0x2C41420", VA = "0x2C41420", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2C41534", Offset = "0x2C41534", VA = "0x2C41534")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x2C415C4", Offset = "0x2C415C4", VA = "0x2C415C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x2C416D8", Offset = "0x2C416D8", VA = "0x2C416D8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2C41764", Offset = "0x2C41764", VA = "0x2C41764", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2C41984", Offset = "0x2C41984", VA = "0x2C41984")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x2C419A8", Offset = "0x2C419A8", VA = "0x2C419A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2C41A1C", Offset = "0x2C41A1C", VA = "0x2C41A1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2C41AF8", Offset = "0x2C41AF8", VA = "0x2C41AF8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2C41BB8", Offset = "0x2C41BB8", VA = "0x2C41BB8")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public class EffectorLink
		{
			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x2DEB1FC", Offset = "0x2DEB1FC", VA = "0x2DEB1FC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x2C42470", Offset = "0x2C42470", VA = "0x2C42470", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x2C4257C", Offset = "0x2C4257C", VA = "0x2C4257C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2C42708", Offset = "0x2C42708", VA = "0x2C42708")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002DD4", Offset = "0x1002DD4")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A970", Offset = "0x100A970")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100A970", Offset = "0x100A970")]
		public float weight;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A9C4", Offset = "0x100A9C4")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100A9FC", Offset = "0x100A9FC")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AA48", Offset = "0x100AA48")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x2C42DE4", Offset = "0x2C42DE4", VA = "0x2C42DE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2C430A8", Offset = "0x2C430A8", VA = "0x2C430A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2C436F0", Offset = "0x2C436F0", VA = "0x2C436F0")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000BD")]
		private bool holding
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x2C43A90", Offset = "0x2C43A90", VA = "0x2C43A90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2C437C8", Offset = "0x2C437C8", VA = "0x2C437C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000712")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2C43AAC", Offset = "0x2C43AAC", VA = "0x2C43AAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2C43C34", Offset = "0x2C43C34", VA = "0x2C43C34")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2C43DB8", Offset = "0x2C43DB8", VA = "0x2C43DB8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x2C43E94", Offset = "0x2C43E94", VA = "0x2C43E94")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x2C43FC8", Offset = "0x2C43FC8", VA = "0x2C43FC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2C4412C", Offset = "0x2C4412C", VA = "0x2C4412C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2C442F8", Offset = "0x2C442F8", VA = "0x2C442F8")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2C4430C", Offset = "0x2C4430C", VA = "0x2C4430C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2C44570", Offset = "0x2C44570", VA = "0x2C44570")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2C44584", Offset = "0x2C44584", VA = "0x2C44584", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2C446B8", Offset = "0x2C446B8", VA = "0x2C446B8")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2C46430", Offset = "0x2C46430", VA = "0x2C46430")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2C46510", Offset = "0x2C46510", VA = "0x2C46510")]
		private void Update()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2C46624", Offset = "0x2C46624", VA = "0x2C46624")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002E34", Offset = "0x1002E34")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2C4743C", Offset = "0x2C4743C", VA = "0x2C4743C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2C47490", Offset = "0x2C47490", VA = "0x2C47490")]
		private void Update()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2C474E8", Offset = "0x2C474E8", VA = "0x2C474E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2C475C8", Offset = "0x2C475C8", VA = "0x2C475C8")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1002E94", Offset = "0x1002E94")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000BE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072D")]
				[Address(RVA = "0x2DECC04", Offset = "0x2DECC04", VA = "0x2DECC04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072F")]
				[Address(RVA = "0x2DECC4C", Offset = "0x2DECC4C", VA = "0x2DECC4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2DECA28", Offset = "0x2DECA28", VA = "0x2DECA28")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x2DECA54", Offset = "0x2DECA54", VA = "0x2DECA54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2DECA58", Offset = "0x2DECA58", VA = "0x2DECA58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2DECC0C", Offset = "0x2DECC0C", VA = "0x2DECC0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2C475D8", Offset = "0x2C475D8", VA = "0x2C475D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2C4768C", Offset = "0x2C4768C", VA = "0x2C4768C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2C476D4", Offset = "0x2C476D4", VA = "0x2C476D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D764", Offset = "0x100D764")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2C47750", Offset = "0x2C47750", VA = "0x2C47750")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002EA4", Offset = "0x1002EA4")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1002F04", Offset = "0x1002F04")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0x2DED170", Offset = "0x2DED170", VA = "0x2DED170", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0x2DED1B8", Offset = "0x2DED1B8", VA = "0x2DED1B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x2DED018", Offset = "0x2DED018", VA = "0x2DED018")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x2DED044", Offset = "0x2DED044", VA = "0x2DED044", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x2DED048", Offset = "0x2DED048", VA = "0x2DED048", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x2DED178", Offset = "0x2DED178", VA = "0x2DED178", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2ADF9E4", Offset = "0x2ADF9E4", VA = "0x2ADF9E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2ADFA90", Offset = "0x2ADFA90", VA = "0x2ADFA90")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D814", Offset = "0x100D814")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2ADFAFC", Offset = "0x2ADFAFC", VA = "0x2ADFAFC")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class EffectorLink
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x2DED1C0", Offset = "0x2DED1C0", VA = "0x2DED1C0")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x2DED458", Offset = "0x2DED458", VA = "0x2DED458")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x2DED540", Offset = "0x2DED540", VA = "0x2DED540")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x2DED9D4", Offset = "0x2DED9D4", VA = "0x2DED9D4")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x2DEDAC8", Offset = "0x2DEDAC8", VA = "0x2DEDAC8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x2DEDB60", Offset = "0x2DEDB60", VA = "0x2DEDB60")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x2DEDBF4", Offset = "0x2DEDBF4", VA = "0x2DEDBF4")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x2DEDC88", Offset = "0x2DEDC88", VA = "0x2DEDC88")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x2DEDDF4", Offset = "0x2DEDDF4", VA = "0x2DEDDF4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2AE04BC", Offset = "0x2AE04BC", VA = "0x2AE04BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2AE0538", Offset = "0x2AE0538", VA = "0x2AE0538")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2AE05A8", Offset = "0x2AE05A8", VA = "0x2AE05A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2AE0670", Offset = "0x2AE0670", VA = "0x2AE0670")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AA94", Offset = "0x100AA94")]
		public Transform to;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100AACC", Offset = "0x100AACC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AACC", Offset = "0x100AACC")]
		public float transferMotion;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2AE0678", Offset = "0x2AE0678", VA = "0x2AE0678")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2AE06B4", Offset = "0x2AE06B4", VA = "0x2AE06B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2AE0768", Offset = "0x2AE0768", VA = "0x2AE0768")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AB20", Offset = "0x100AB20")]
		public Transform leftHandTarget;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2AE1510", Offset = "0x2AE1510", VA = "0x2AE1510")]
		private void Start()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2AE16F0", Offset = "0x2AE16F0", VA = "0x2AE16F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2AE18E0", Offset = "0x2AE18E0", VA = "0x2AE18E0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2AE19AC", Offset = "0x2AE19AC", VA = "0x2AE19AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2AE1AAC", Offset = "0x2AE1AAC", VA = "0x2AE1AAC")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2AE1D48", Offset = "0x2AE1D48", VA = "0x2AE1D48", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2AE20D4", Offset = "0x2AE20D4", VA = "0x2AE20D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2AE2340", Offset = "0x2AE2340", VA = "0x2AE2340")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2D748FC", Offset = "0x2D748FC", VA = "0x2D748FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x2D74C24", Offset = "0x2D74C24", VA = "0x2D74C24")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x2D74CA4", Offset = "0x2D74CA4", VA = "0x2D74CA4")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1002F14", Offset = "0x1002F14")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075D")]
				[Address(RVA = "0x2DEBF60", Offset = "0x2DEBF60", VA = "0x2DEBF60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x2DEBFA8", Offset = "0x2DEBFA8", VA = "0x2DEBFA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x2DEBE20", Offset = "0x2DEBE20", VA = "0x2DEBE20")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x2DEBE4C", Offset = "0x2DEBE4C", VA = "0x2DEBE4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x2DEBE50", Offset = "0x2DEBE50", VA = "0x2DEBE50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x2DEBF68", Offset = "0x2DEBF68", VA = "0x2DEBF68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2C446CC", Offset = "0x2C446CC", VA = "0x2C446CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x2C447F8", Offset = "0x2C447F8", VA = "0x2C447F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x2C4478C", Offset = "0x2C4478C", VA = "0x2C4478C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D8C4", Offset = "0x100D8C4")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x2C4497C", Offset = "0x2C4497C", VA = "0x2C4497C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x2C44A68", Offset = "0x2C44A68", VA = "0x2C44A68")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x2C44B50", Offset = "0x2C44B50", VA = "0x2C44B50")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100AB58", Offset = "0x100AB58")]
		public float weight;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2D3B278", Offset = "0x2D3B278", VA = "0x2D3B278")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2D3B2EC", Offset = "0x2D3B2EC", VA = "0x2D3B2EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2D3B3A4", Offset = "0x2D3B3A4", VA = "0x2D3B3A4")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class Part
		{
			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x2DEDE28", Offset = "0x2DEDE28", VA = "0x2DEDE28")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x2DEDF54", Offset = "0x2DEDF54", VA = "0x2DEDF54")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2AE0B50", Offset = "0x2AE0B50", VA = "0x2AE0B50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2AE0BCC", Offset = "0x2AE0BCC", VA = "0x2AE0BCC")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2E0E680", Offset = "0x2E0E680", VA = "0x2E0E680")]
		private void Update()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2E0E7D8", Offset = "0x2E0E7D8", VA = "0x2E0E7D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2E0E9BC", Offset = "0x2E0E9BC", VA = "0x2E0E9BC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AB70", Offset = "0x100AB70")]
		public VRIK ik;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100ABA8", Offset = "0x100ABA8")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100ABE0", Offset = "0x100ABE0")]
		public Transform headTracker;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AC18", Offset = "0x100AC18")]
		public Transform bodyTracker;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AC50", Offset = "0x100AC50")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AC88", Offset = "0x100AC88")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100ACC0", Offset = "0x100ACC0")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100ACF8", Offset = "0x100ACF8")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100AD30", Offset = "0x100AD30")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2AE300C", Offset = "0x2AE300C", VA = "0x2AE300C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2AE4F54", Offset = "0x2AE4F54", VA = "0x2AE4F54")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2AE5D74", Offset = "0x2AE5D74", VA = "0x2AE5D74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2AE5DD0", Offset = "0x2AE5DD0", VA = "0x2AE5DD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2AE5F58", Offset = "0x2AE5F58", VA = "0x2AE5F58")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x2AE5F8C", Offset = "0x2AE5F8C", VA = "0x2AE5F8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2AE6410", Offset = "0x2AE6410", VA = "0x2AE6410")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000C4")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x2D442A8", Offset = "0x2D442A8", VA = "0x2D442A8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2D44284", Offset = "0x2D44284", VA = "0x2D44284", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2D442B0", Offset = "0x2D442B0", VA = "0x2D442B0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2D44314", Offset = "0x2D44314", VA = "0x2D44314", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2D444AC", Offset = "0x2D444AC", VA = "0x2D444AC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2D446D0", Offset = "0x2D446D0", VA = "0x2D446D0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2D444BC", Offset = "0x2D444BC", VA = "0x2D444BC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2D446E0", Offset = "0x2D446E0", VA = "0x2D446E0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002F24", Offset = "0x1002F24")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2D446F8", Offset = "0x2D446F8", VA = "0x2D446F8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2D44754", Offset = "0x2D44754", VA = "0x2D44754", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2D447F0", Offset = "0x2D447F0", VA = "0x2D447F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2D44908", Offset = "0x2D44908", VA = "0x2D44908")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002F84", Offset = "0x1002F84")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x100AD98", Offset = "0x100AD98")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007A0")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007A1")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x170000C5")]
		public override bool animationGrounded
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x2D449BC", Offset = "0x2D449BC", VA = "0x2D449BC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2D44920", Offset = "0x2D44920", VA = "0x2D44920", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2D449A0", Offset = "0x2D449A0", VA = "0x2D449A0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2D44AB4", Offset = "0x2D44AB4", VA = "0x2D44AB4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2D44E7C", Offset = "0x2D44E7C", VA = "0x2D44E7C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x2D44F84", Offset = "0x2D44F84", VA = "0x2D44F84")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002FE4", Offset = "0x1002FE4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1002FE4", Offset = "0x1002FE4")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100ADDC", Offset = "0x100ADDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100ADDC", Offset = "0x100ADDC")]
		public Transform gravityTarget;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AE3C", Offset = "0x100AE3C")]
		public float gravityMultiplier;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007AD")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000783")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x2D45358", Offset = "0x2D45358", VA = "0x2D45358")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2D45488", Offset = "0x2D45488", VA = "0x2D45488", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2D45640", Offset = "0x2D45640", VA = "0x2D45640", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2D457F0", Offset = "0x2D457F0", VA = "0x2D457F0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2D45854", Offset = "0x2D45854", VA = "0x2D45854")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x2D45974", Offset = "0x2D45974", VA = "0x2D45974")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2D45A98", Offset = "0x2D45A98", VA = "0x2D45A98")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2D45ABC", Offset = "0x2D45ABC", VA = "0x2D45ABC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2D45AE0", Offset = "0x2D45AE0", VA = "0x2D45AE0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2D45B40", Offset = "0x2D45B40", VA = "0x2D45B40")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public enum MoveMode
		{
			[Token(Token = "0x40007EA")]
			Directional,
			[Token(Token = "0x40007EB")]
			Strafe
		}

		[Token(Token = "0x2000119")]
		public struct AnimState
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1003078", Offset = "0x1003078")]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A3")]
				[Address(RVA = "0x2AE73B4", Offset = "0x2AE73B4", VA = "0x2AE73B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x2AE73FC", Offset = "0x2AE73FC", VA = "0x2AE73FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x2AE7290", Offset = "0x2AE7290", VA = "0x2AE7290")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x2AE72BC", Offset = "0x2AE72BC", VA = "0x2AE72BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x2AE72C0", Offset = "0x2AE72C0", VA = "0x2AE72C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x2AE73BC", Offset = "0x2AE73BC", VA = "0x2AE73BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100AE74", Offset = "0x100AE74")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100AEAC", Offset = "0x100AEAC")]
		public MoveMode moveMode;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100AEE4", Offset = "0x100AEE4")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100AF1C", Offset = "0x100AF1C")]
		public bool smoothJump;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100AF54", Offset = "0x100AF54")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x100AF8C", Offset = "0x100AF8C")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100AFC4", Offset = "0x100AFC4")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x170000C6")]
		public bool onGround
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x2D45E68", Offset = "0x2D45E68", VA = "0x2D45E68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D974", Offset = "0x100D974")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x2D45E70", Offset = "0x2D45E70", VA = "0x2D45E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100D984", Offset = "0x100D984")]
			private set
			{
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2D45E7C", Offset = "0x2D45E7C", VA = "0x2D45E7C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2D45FBC", Offset = "0x2D45FBC", VA = "0x2D45FBC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2D4604C", Offset = "0x2D4604C", VA = "0x2D4604C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2D460C8", Offset = "0x2D460C8", VA = "0x2D460C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2D46CB4", Offset = "0x2D46CB4", VA = "0x2D46CB4", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2D46F0C", Offset = "0x2D46F0C", VA = "0x2D46F0C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2D465BC", Offset = "0x2D465BC", VA = "0x2D465BC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x2D46FE8", Offset = "0x2D46FE8", VA = "0x2D46FE8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2D47490", Offset = "0x2D47490", VA = "0x2D47490")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2D46D3C", Offset = "0x2D46D3C", VA = "0x2D46D3C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2D47530", Offset = "0x2D47530", VA = "0x2D47530", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2D4786C", Offset = "0x2D4786C", VA = "0x2D4786C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2D4795C", Offset = "0x2D4795C", VA = "0x2D4795C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2D47ABC", Offset = "0x2D47ABC", VA = "0x2D47ABC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x100D994", Offset = "0x100D994")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2D4690C", Offset = "0x2D4690C", VA = "0x2D4690C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2D47B4C", Offset = "0x2D47B4C", VA = "0x2D47B4C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1003088", Offset = "0x1003088")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public enum RotationMode
		{
			[Token(Token = "0x4000807")]
			Smooth,
			[Token(Token = "0x4000808")]
			Linear
		}

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100AFD4", Offset = "0x100AFD4")]
		public CameraController cameraController;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B00C", Offset = "0x100B00C")]
		public float accelerationTime;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B044", Offset = "0x100B044")]
		public float turnTime;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B07C", Offset = "0x100B07C")]
		public bool walkByDefault;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B0B4", Offset = "0x100B0B4")]
		public RotationMode rotationMode;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B0EC", Offset = "0x100B0EC")]
		public float moveSpeed;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B124", Offset = "0x100B124")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000C9")]
		public bool isGrounded
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x2ADF204", Offset = "0x2ADF204", VA = "0x2ADF204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100DA44", Offset = "0x100DA44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x2ADF20C", Offset = "0x2ADF20C", VA = "0x2ADF20C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100DA54", Offset = "0x100DA54")]
			private set
			{
			}
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2ADF218", Offset = "0x2ADF218", VA = "0x2ADF218")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2ADF2A8", Offset = "0x2ADF2A8", VA = "0x2ADF2A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2ADF768", Offset = "0x2ADF768", VA = "0x2ADF768")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2ADF2FC", Offset = "0x2ADF2FC", VA = "0x2ADF2FC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2ADF57C", Offset = "0x2ADF57C", VA = "0x2ADF57C")]
		private void Move()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2ADF7A4", Offset = "0x2ADF7A4", VA = "0x2ADF7A4")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2ADF840", Offset = "0x2ADF840", VA = "0x2ADF840")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2ADF8C4", Offset = "0x2ADF8C4", VA = "0x2ADF8C4")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2AE1AB4", Offset = "0x2AE1AB4", VA = "0x2AE1AB4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2AE1B30", Offset = "0x2AE1B30", VA = "0x2AE1B30", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2AE1CF4", Offset = "0x2AE1CF4", VA = "0x2AE1CF4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2AE1D1C", Offset = "0x2AE1D1C", VA = "0x2AE1D1C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200011F")]
		public struct State
		{
			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2AE1AF8", Offset = "0x2AE1AF8", VA = "0x2AE1AF8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2AE1E38", Offset = "0x2AE1E38", VA = "0x2AE1E38", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2AE1D38", Offset = "0x2AE1D38", VA = "0x2AE1D38")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2D37520", Offset = "0x2D37520", VA = "0x2D37520")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2D3755C", Offset = "0x2D3755C", VA = "0x2D3755C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2ADF8EC", Offset = "0x2ADF8EC", VA = "0x2ADF8EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2ADF920", Offset = "0x2ADF920", VA = "0x2ADF920")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2ADF9D0", Offset = "0x2ADF9D0", VA = "0x2ADF9D0")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000122")]
	public class Navigator
	{
		[Token(Token = "0x2000123")]
		public enum State
		{
			[Token(Token = "0x400082A")]
			Idle,
			[Token(Token = "0x400082B")]
			Seeking,
			[Token(Token = "0x400082C")]
			OnPath
		}

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B134", Offset = "0x100B134")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B16C", Offset = "0x100B16C")]
		public float cornerRadius;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B1A4", Offset = "0x100B1A4")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B1DC", Offset = "0x100B1DC")]
		public float maxSampleDistance;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x100B214", Offset = "0x100B214")]
		public float nextPathInterval;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B24C", Offset = "0x100B24C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100B25C", Offset = "0x100B25C")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000CA")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x2C41BCC", Offset = "0x2C41BCC", VA = "0x2C41BCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100DA64", Offset = "0x100DA64")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x2C41BD8", Offset = "0x2C41BD8", VA = "0x2C41BD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100DA74", Offset = "0x100DA74")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public State state
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x2C41BE4", Offset = "0x2C41BE4", VA = "0x2C41BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100DA84", Offset = "0x100DA84")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x2C41BEC", Offset = "0x2C41BEC", VA = "0x2C41BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x100DA94", Offset = "0x100DA94")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2C41BF4", Offset = "0x2C41BF4", VA = "0x2C41BF4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2C41CA4", Offset = "0x2C41CA4", VA = "0x2C41CA4")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2C42090", Offset = "0x2C42090", VA = "0x2C42090")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2C4210C", Offset = "0x2C4210C", VA = "0x2C4210C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2C4204C", Offset = "0x2C4204C", VA = "0x2C4204C")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2C4207C", Offset = "0x2C4207C", VA = "0x2C4207C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2C42258", Offset = "0x2C42258", VA = "0x2C42258")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2C42408", Offset = "0x2C42408", VA = "0x2C42408")]
		public Navigator()
		{
		}
	}
}
